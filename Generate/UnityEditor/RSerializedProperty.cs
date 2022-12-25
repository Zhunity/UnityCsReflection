using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.SerializedProperty
	/// </summary>
    public partial class RSerializedProperty : RMember //
    {

		/// <summary>
		/// System.IntPtr m_NativePropertyPtr
		/// </summary>
		protected RField r_m_NativePropertyPtr;
		public virtual RField Rm_NativePropertyPtr
		{
			get
			{
				if(r_m_NativePropertyPtr == null)
				{
					r_m_NativePropertyPtr = new(this, "m_NativePropertyPtr");
					r_m_NativePropertyPtr.SetBelong(this.instance);
				}
				return r_m_NativePropertyPtr;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject m_SerializedObject
		/// </summary>
		protected RUnityEditor.RSerializedObject r_m_SerializedObject;
		public virtual RUnityEditor.RSerializedObject Rm_SerializedObject
		{
			get
			{
				if(r_m_SerializedObject == null)
				{
					r_m_SerializedObject = new(this, "m_SerializedObject");
					r_m_SerializedObject.SetBelong(this.instance);
				}
				return r_m_SerializedObject;
			}
		}

		/// <summary>
		/// System.String m_CachedLocalizedDisplayName
		/// </summary>
		protected RField r_m_CachedLocalizedDisplayName;
		public virtual RField Rm_CachedLocalizedDisplayName
		{
			get
			{
				if(r_m_CachedLocalizedDisplayName == null)
				{
					r_m_CachedLocalizedDisplayName = new(this, "m_CachedLocalizedDisplayName");
					r_m_CachedLocalizedDisplayName.SetBelong(this.instance);
				}
				return r_m_CachedLocalizedDisplayName;
			}
		}

		/// <summary>
		/// System.String m_CachedTooltip
		/// </summary>
		protected RField r_m_CachedTooltip;
		public virtual RField Rm_CachedTooltip
		{
			get
			{
				if(r_m_CachedTooltip == null)
				{
					r_m_CachedTooltip = new(this, "m_CachedTooltip");
					r_m_CachedTooltip.SetBelong(this.instance);
				}
				return r_m_CachedTooltip;
			}
		}

		/// <summary>
		/// System.String m_PropertyPath
		/// </summary>
		protected RField r_m_PropertyPath;
		public virtual RField Rm_PropertyPath
		{
			get
			{
				if(r_m_PropertyPath == null)
				{
					r_m_PropertyPath = new(this, "m_PropertyPath");
					r_m_PropertyPath.SetBelong(this.instance);
				}
				return r_m_PropertyPath;
			}
		}

		/// <summary>
		/// System.Int32 m_PropertyPathHash
		/// </summary>
		protected RField r_m_PropertyPathHash;
		public virtual RField Rm_PropertyPathHash
		{
			get
			{
				if(r_m_PropertyPathHash == null)
				{
					r_m_PropertyPathHash = new(this, "m_PropertyPathHash");
					r_m_PropertyPathHash.SetBelong(this.instance);
				}
				return r_m_PropertyPathHash;
			}
		}

		/// <summary>
		/// System.Boolean <unsafeMode>k__BackingField
		/// </summary>
		protected RField r___1__unsafeMode__2__k__BackingField;
		public virtual RField R__1__unsafeMode__2__k__BackingField
		{
			get
			{
				if(r___1__unsafeMode__2__k__BackingField == null)
				{
					r___1__unsafeMode__2__k__BackingField = new(this, "<unsafeMode>k__BackingField");
					r___1__unsafeMode__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__unsafeMode__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject serializedObject
		/// </summary>
		protected RUnityEditor.RSerializedObject r_serializedObject;
		public virtual RUnityEditor.RSerializedObject RserializedObject
		{
			get
			{
				if(r_serializedObject == null)
				{
					r_serializedObject = new(this, "serializedObject", -1);
					r_serializedObject.SetBelong(this.instance);
				}
				return r_serializedObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object exposedReferenceValue
		/// </summary>
		protected RUnityEngine.RObject r_exposedReferenceValue;
		public virtual RUnityEngine.RObject RexposedReferenceValue
		{
			get
			{
				if(r_exposedReferenceValue == null)
				{
					r_exposedReferenceValue = new(this, "exposedReferenceValue", -1);
					r_exposedReferenceValue.SetBelong(this.instance);
				}
				return r_exposedReferenceValue;
			}
		}

		/// <summary>
		/// Boolean isScript
		/// </summary>
		protected RProperty r_isScript;
		public virtual RProperty RisScript
		{
			get
			{
				if(r_isScript == null)
				{
					r_isScript = new(this, "isScript", -1);
					r_isScript.SetBelong(this.instance);
				}
				return r_isScript;
			}
		}

		/// <summary>
		/// System.String localizedDisplayName
		/// </summary>
		protected RProperty r_localizedDisplayName;
		public virtual RProperty RlocalizedDisplayName
		{
			get
			{
				if(r_localizedDisplayName == null)
				{
					r_localizedDisplayName = new(this, "localizedDisplayName", -1);
					r_localizedDisplayName.SetBelong(this.instance);
				}
				return r_localizedDisplayName;
			}
		}

		/// <summary>
		/// System.String[] enumLocalizedDisplayNames
		/// </summary>
		protected RPropertyArray<RProperty> r_enumLocalizedDisplayNames;
		public virtual RPropertyArray<RProperty> RenumLocalizedDisplayNames
		{
			get
			{
				if(r_enumLocalizedDisplayNames == null)
				{
					r_enumLocalizedDisplayNames = new(this, "enumLocalizedDisplayNames", -1);
					r_enumLocalizedDisplayNames.SetBelong(this.instance);
				}
				return r_enumLocalizedDisplayNames;
			}
		}

		/// <summary>
		/// System.Object boxedValue
		/// </summary>
		protected RSystem.RObject r_boxedValue;
		public virtual RSystem.RObject RboxedValue
		{
			get
			{
				if(r_boxedValue == null)
				{
					r_boxedValue = new(this, "boxedValue", -1);
					r_boxedValue.SetBelong(this.instance);
				}
				return r_boxedValue;
			}
		}

		/// <summary>
		/// Boolean hasMultipleDifferentValues
		/// </summary>
		protected RProperty r_hasMultipleDifferentValues;
		public virtual RProperty RhasMultipleDifferentValues
		{
			get
			{
				if(r_hasMultipleDifferentValues == null)
				{
					r_hasMultipleDifferentValues = new(this, "hasMultipleDifferentValues", -1);
					r_hasMultipleDifferentValues.SetBelong(this.instance);
				}
				return r_hasMultipleDifferentValues;
			}
		}

		/// <summary>
		/// Int32 hasMultipleDifferentValuesBitwise
		/// </summary>
		protected RProperty r_hasMultipleDifferentValuesBitwise;
		public virtual RProperty RhasMultipleDifferentValuesBitwise
		{
			get
			{
				if(r_hasMultipleDifferentValuesBitwise == null)
				{
					r_hasMultipleDifferentValuesBitwise = new(this, "hasMultipleDifferentValuesBitwise", -1);
					r_hasMultipleDifferentValuesBitwise.SetBelong(this.instance);
				}
				return r_hasMultipleDifferentValuesBitwise;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected RProperty r_displayName;
		public virtual RProperty RdisplayName
		{
			get
			{
				if(r_displayName == null)
				{
					r_displayName = new(this, "displayName", -1);
					r_displayName.SetBelong(this.instance);
				}
				return r_displayName;
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
		/// System.String type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.String arrayElementType
		/// </summary>
		protected RProperty r_arrayElementType;
		public virtual RProperty RarrayElementType
		{
			get
			{
				if(r_arrayElementType == null)
				{
					r_arrayElementType = new(this, "arrayElementType", -1);
					r_arrayElementType.SetBelong(this.instance);
				}
				return r_arrayElementType;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RProperty r_tooltip;
		public virtual RProperty Rtooltip
		{
			get
			{
				if(r_tooltip == null)
				{
					r_tooltip = new(this, "tooltip", -1);
					r_tooltip.SetBelong(this.instance);
				}
				return r_tooltip;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected RProperty r_depth;
		public virtual RProperty Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth", -1);
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// System.String propertyPath
		/// </summary>
		protected RProperty r_propertyPath;
		public virtual RProperty RpropertyPath
		{
			get
			{
				if(r_propertyPath == null)
				{
					r_propertyPath = new(this, "propertyPath", -1);
					r_propertyPath.SetBelong(this.instance);
				}
				return r_propertyPath;
			}
		}

		/// <summary>
		/// Int32 hashCodeForPropertyPathWithoutArrayIndex
		/// </summary>
		protected RProperty r_hashCodeForPropertyPathWithoutArrayIndex;
		public virtual RProperty RhashCodeForPropertyPathWithoutArrayIndex
		{
			get
			{
				if(r_hashCodeForPropertyPathWithoutArrayIndex == null)
				{
					r_hashCodeForPropertyPathWithoutArrayIndex = new(this, "hashCodeForPropertyPathWithoutArrayIndex", -1);
					r_hashCodeForPropertyPathWithoutArrayIndex.SetBelong(this.instance);
				}
				return r_hashCodeForPropertyPathWithoutArrayIndex;
			}
		}

		/// <summary>
		/// Int32 hashCodeForPropertyPath
		/// </summary>
		protected RProperty r_hashCodeForPropertyPath;
		public virtual RProperty RhashCodeForPropertyPath
		{
			get
			{
				if(r_hashCodeForPropertyPath == null)
				{
					r_hashCodeForPropertyPath = new(this, "hashCodeForPropertyPath", -1);
					r_hashCodeForPropertyPath.SetBelong(this.instance);
				}
				return r_hashCodeForPropertyPath;
			}
		}

		/// <summary>
		/// Boolean editable
		/// </summary>
		protected RProperty r_editable;
		public virtual RProperty Reditable
		{
			get
			{
				if(r_editable == null)
				{
					r_editable = new(this, "editable", -1);
					r_editable.SetBelong(this.instance);
				}
				return r_editable;
			}
		}

		/// <summary>
		/// Boolean isAnimated
		/// </summary>
		protected RProperty r_isAnimated;
		public virtual RProperty RisAnimated
		{
			get
			{
				if(r_isAnimated == null)
				{
					r_isAnimated = new(this, "isAnimated", -1);
					r_isAnimated.SetBelong(this.instance);
				}
				return r_isAnimated;
			}
		}

		/// <summary>
		/// Boolean isCandidate
		/// </summary>
		protected RProperty r_isCandidate;
		public virtual RProperty RisCandidate
		{
			get
			{
				if(r_isCandidate == null)
				{
					r_isCandidate = new(this, "isCandidate", -1);
					r_isCandidate.SetBelong(this.instance);
				}
				return r_isCandidate;
			}
		}

		/// <summary>
		/// Boolean isKey
		/// </summary>
		protected RProperty r_isKey;
		public virtual RProperty RisKey
		{
			get
			{
				if(r_isKey == null)
				{
					r_isKey = new(this, "isKey", -1);
					r_isKey.SetBelong(this.instance);
				}
				return r_isKey;
			}
		}

		/// <summary>
		/// Boolean isLiveModified
		/// </summary>
		protected RProperty r_isLiveModified;
		public virtual RProperty RisLiveModified
		{
			get
			{
				if(r_isLiveModified == null)
				{
					r_isLiveModified = new(this, "isLiveModified", -1);
					r_isLiveModified.SetBelong(this.instance);
				}
				return r_isLiveModified;
			}
		}

		/// <summary>
		/// Boolean isExpanded
		/// </summary>
		protected RProperty r_isExpanded;
		public virtual RProperty RisExpanded
		{
			get
			{
				if(r_isExpanded == null)
				{
					r_isExpanded = new(this, "isExpanded", -1);
					r_isExpanded.SetBelong(this.instance);
				}
				return r_isExpanded;
			}
		}

		/// <summary>
		/// Boolean hasChildren
		/// </summary>
		protected RProperty r_hasChildren;
		public virtual RProperty RhasChildren
		{
			get
			{
				if(r_hasChildren == null)
				{
					r_hasChildren = new(this, "hasChildren", -1);
					r_hasChildren.SetBelong(this.instance);
				}
				return r_hasChildren;
			}
		}

		/// <summary>
		/// Boolean hasVisibleChildren
		/// </summary>
		protected RProperty r_hasVisibleChildren;
		public virtual RProperty RhasVisibleChildren
		{
			get
			{
				if(r_hasVisibleChildren == null)
				{
					r_hasVisibleChildren = new(this, "hasVisibleChildren", -1);
					r_hasVisibleChildren.SetBelong(this.instance);
				}
				return r_hasVisibleChildren;
			}
		}

		/// <summary>
		/// Boolean isInstantiatedPrefab
		/// </summary>
		protected RProperty r_isInstantiatedPrefab;
		public virtual RProperty RisInstantiatedPrefab
		{
			get
			{
				if(r_isInstantiatedPrefab == null)
				{
					r_isInstantiatedPrefab = new(this, "isInstantiatedPrefab", -1);
					r_isInstantiatedPrefab.SetBelong(this.instance);
				}
				return r_isInstantiatedPrefab;
			}
		}

		/// <summary>
		/// Boolean isReferencingAManagedReferenceField
		/// </summary>
		protected RProperty r_isReferencingAManagedReferenceField;
		public virtual RProperty RisReferencingAManagedReferenceField
		{
			get
			{
				if(r_isReferencingAManagedReferenceField == null)
				{
					r_isReferencingAManagedReferenceField = new(this, "isReferencingAManagedReferenceField", -1);
					r_isReferencingAManagedReferenceField.SetBelong(this.instance);
				}
				return r_isReferencingAManagedReferenceField;
			}
		}

		/// <summary>
		/// System.String managedReferencePropertyPath
		/// </summary>
		protected RProperty r_managedReferencePropertyPath;
		public virtual RProperty RmanagedReferencePropertyPath
		{
			get
			{
				if(r_managedReferencePropertyPath == null)
				{
					r_managedReferencePropertyPath = new(this, "managedReferencePropertyPath", -1);
					r_managedReferencePropertyPath.SetBelong(this.instance);
				}
				return r_managedReferencePropertyPath;
			}
		}

		/// <summary>
		/// Boolean prefabOverride
		/// </summary>
		protected RProperty r_prefabOverride;
		public virtual RProperty RprefabOverride
		{
			get
			{
				if(r_prefabOverride == null)
				{
					r_prefabOverride = new(this, "prefabOverride", -1);
					r_prefabOverride.SetBelong(this.instance);
				}
				return r_prefabOverride;
			}
		}

		/// <summary>
		/// Boolean isDefaultOverride
		/// </summary>
		protected RProperty r_isDefaultOverride;
		public virtual RProperty RisDefaultOverride
		{
			get
			{
				if(r_isDefaultOverride == null)
				{
					r_isDefaultOverride = new(this, "isDefaultOverride", -1);
					r_isDefaultOverride.SetBelong(this.instance);
				}
				return r_isDefaultOverride;
			}
		}

		/// <summary>
		/// Boolean isDrivenRectTransformProperty
		/// </summary>
		protected RProperty r_isDrivenRectTransformProperty;
		public virtual RProperty RisDrivenRectTransformProperty
		{
			get
			{
				if(r_isDrivenRectTransformProperty == null)
				{
					r_isDrivenRectTransformProperty = new(this, "isDrivenRectTransformProperty", -1);
					r_isDrivenRectTransformProperty.SetBelong(this.instance);
				}
				return r_isDrivenRectTransformProperty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType propertyType
		/// </summary>
		protected RProperty r_propertyType;
		public virtual RProperty RpropertyType
		{
			get
			{
				if(r_propertyType == null)
				{
					r_propertyType = new(this, "propertyType", -1);
					r_propertyType.SetBelong(this.instance);
				}
				return r_propertyType;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyNumericType numericType
		/// </summary>
		protected RProperty r_numericType;
		public virtual RProperty RnumericType
		{
			get
			{
				if(r_numericType == null)
				{
					r_numericType = new(this, "numericType", -1);
					r_numericType.SetBelong(this.instance);
				}
				return r_numericType;
			}
		}

		/// <summary>
		/// Int32 intValue
		/// </summary>
		protected RProperty r_intValue;
		public virtual RProperty RintValue
		{
			get
			{
				if(r_intValue == null)
				{
					r_intValue = new(this, "intValue", -1);
					r_intValue.SetBelong(this.instance);
				}
				return r_intValue;
			}
		}

		/// <summary>
		/// Int64 longValue
		/// </summary>
		protected RProperty r_longValue;
		public virtual RProperty RlongValue
		{
			get
			{
				if(r_longValue == null)
				{
					r_longValue = new(this, "longValue", -1);
					r_longValue.SetBelong(this.instance);
				}
				return r_longValue;
			}
		}

		/// <summary>
		/// UInt64 ulongValue
		/// </summary>
		protected RProperty r_ulongValue;
		public virtual RProperty RulongValue
		{
			get
			{
				if(r_ulongValue == null)
				{
					r_ulongValue = new(this, "ulongValue", -1);
					r_ulongValue.SetBelong(this.instance);
				}
				return r_ulongValue;
			}
		}

		/// <summary>
		/// UInt32 uintValue
		/// </summary>
		protected RProperty r_uintValue;
		public virtual RProperty RuintValue
		{
			get
			{
				if(r_uintValue == null)
				{
					r_uintValue = new(this, "uintValue", -1);
					r_uintValue.SetBelong(this.instance);
				}
				return r_uintValue;
			}
		}

		/// <summary>
		/// Boolean boolValue
		/// </summary>
		protected RProperty r_boolValue;
		public virtual RProperty RboolValue
		{
			get
			{
				if(r_boolValue == null)
				{
					r_boolValue = new(this, "boolValue", -1);
					r_boolValue.SetBelong(this.instance);
				}
				return r_boolValue;
			}
		}

		/// <summary>
		/// Single floatValue
		/// </summary>
		protected RProperty r_floatValue;
		public virtual RProperty RfloatValue
		{
			get
			{
				if(r_floatValue == null)
				{
					r_floatValue = new(this, "floatValue", -1);
					r_floatValue.SetBelong(this.instance);
				}
				return r_floatValue;
			}
		}

		/// <summary>
		/// Double[] allDoubleValues
		/// </summary>
		protected RPropertyArray<RProperty> r_allDoubleValues;
		public virtual RPropertyArray<RProperty> RallDoubleValues
		{
			get
			{
				if(r_allDoubleValues == null)
				{
					r_allDoubleValues = new(this, "allDoubleValues", -1);
					r_allDoubleValues.SetBelong(this.instance);
				}
				return r_allDoubleValues;
			}
		}

		/// <summary>
		/// Int64[] allLongValues
		/// </summary>
		protected RPropertyArray<RProperty> r_allLongValues;
		public virtual RPropertyArray<RProperty> RallLongValues
		{
			get
			{
				if(r_allLongValues == null)
				{
					r_allLongValues = new(this, "allLongValues", -1);
					r_allLongValues.SetBelong(this.instance);
				}
				return r_allLongValues;
			}
		}

		/// <summary>
		/// Double doubleValue
		/// </summary>
		protected RProperty r_doubleValue;
		public virtual RProperty RdoubleValue
		{
			get
			{
				if(r_doubleValue == null)
				{
					r_doubleValue = new(this, "doubleValue", -1);
					r_doubleValue.SetBelong(this.instance);
				}
				return r_doubleValue;
			}
		}

		/// <summary>
		/// System.String stringValue
		/// </summary>
		protected RProperty r_stringValue;
		public virtual RProperty RstringValue
		{
			get
			{
				if(r_stringValue == null)
				{
					r_stringValue = new(this, "stringValue", -1);
					r_stringValue.SetBelong(this.instance);
				}
				return r_stringValue;
			}
		}

		/// <summary>
		/// UnityEngine.Color colorValue
		/// </summary>
		protected RUnityEngine.RColor r_colorValue;
		public virtual RUnityEngine.RColor RcolorValue
		{
			get
			{
				if(r_colorValue == null)
				{
					r_colorValue = new(this, "colorValue", -1);
					r_colorValue.SetBelong(this.instance);
				}
				return r_colorValue;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve animationCurveValue
		/// </summary>
		protected RUnityEngine.RAnimationCurve r_animationCurveValue;
		public virtual RUnityEngine.RAnimationCurve RanimationCurveValue
		{
			get
			{
				if(r_animationCurveValue == null)
				{
					r_animationCurveValue = new(this, "animationCurveValue", -1);
					r_animationCurveValue.SetBelong(this.instance);
				}
				return r_animationCurveValue;
			}
		}

		/// <summary>
		/// UnityEngine.Gradient gradientValue
		/// </summary>
		protected RUnityEngine.RGradient r_gradientValue;
		public virtual RUnityEngine.RGradient RgradientValue
		{
			get
			{
				if(r_gradientValue == null)
				{
					r_gradientValue = new(this, "gradientValue", -1);
					r_gradientValue.SetBelong(this.instance);
				}
				return r_gradientValue;
			}
		}

		/// <summary>
		/// UnityEngine.Object objectReferenceValue
		/// </summary>
		protected RUnityEngine.RObject r_objectReferenceValue;
		public virtual RUnityEngine.RObject RobjectReferenceValue
		{
			get
			{
				if(r_objectReferenceValue == null)
				{
					r_objectReferenceValue = new(this, "objectReferenceValue", -1);
					r_objectReferenceValue.SetBelong(this.instance);
				}
				return r_objectReferenceValue;
			}
		}

		/// <summary>
		/// System.Object managedReferenceValue
		/// </summary>
		protected RSystem.RObject r_managedReferenceValue;
		public virtual RSystem.RObject RmanagedReferenceValue
		{
			get
			{
				if(r_managedReferenceValue == null)
				{
					r_managedReferenceValue = new(this, "managedReferenceValue", -1);
					r_managedReferenceValue.SetBelong(this.instance);
				}
				return r_managedReferenceValue;
			}
		}

		/// <summary>
		/// Int64 managedReferenceId
		/// </summary>
		protected RProperty r_managedReferenceId;
		public virtual RProperty RmanagedReferenceId
		{
			get
			{
				if(r_managedReferenceId == null)
				{
					r_managedReferenceId = new(this, "managedReferenceId", -1);
					r_managedReferenceId.SetBelong(this.instance);
				}
				return r_managedReferenceId;
			}
		}

		/// <summary>
		/// System.String managedReferenceFullTypename
		/// </summary>
		protected RProperty r_managedReferenceFullTypename;
		public virtual RProperty RmanagedReferenceFullTypename
		{
			get
			{
				if(r_managedReferenceFullTypename == null)
				{
					r_managedReferenceFullTypename = new(this, "managedReferenceFullTypename", -1);
					r_managedReferenceFullTypename.SetBelong(this.instance);
				}
				return r_managedReferenceFullTypename;
			}
		}

		/// <summary>
		/// System.String managedReferenceFieldTypename
		/// </summary>
		protected RProperty r_managedReferenceFieldTypename;
		public virtual RProperty RmanagedReferenceFieldTypename
		{
			get
			{
				if(r_managedReferenceFieldTypename == null)
				{
					r_managedReferenceFieldTypename = new(this, "managedReferenceFieldTypename", -1);
					r_managedReferenceFieldTypename.SetBelong(this.instance);
				}
				return r_managedReferenceFieldTypename;
			}
		}

		/// <summary>
		/// System.Object structValue
		/// </summary>
		protected RSystem.RObject r_structValue;
		public virtual RSystem.RObject RstructValue
		{
			get
			{
				if(r_structValue == null)
				{
					r_structValue = new(this, "structValue", -1);
					r_structValue.SetBelong(this.instance);
				}
				return r_structValue;
			}
		}

		/// <summary>
		/// Int32 objectReferenceInstanceIDValue
		/// </summary>
		protected RProperty r_objectReferenceInstanceIDValue;
		public virtual RProperty RobjectReferenceInstanceIDValue
		{
			get
			{
				if(r_objectReferenceInstanceIDValue == null)
				{
					r_objectReferenceInstanceIDValue = new(this, "objectReferenceInstanceIDValue", -1);
					r_objectReferenceInstanceIDValue.SetBelong(this.instance);
				}
				return r_objectReferenceInstanceIDValue;
			}
		}

		/// <summary>
		/// System.String objectReferenceStringValue
		/// </summary>
		protected RProperty r_objectReferenceStringValue;
		public virtual RProperty RobjectReferenceStringValue
		{
			get
			{
				if(r_objectReferenceStringValue == null)
				{
					r_objectReferenceStringValue = new(this, "objectReferenceStringValue", -1);
					r_objectReferenceStringValue.SetBelong(this.instance);
				}
				return r_objectReferenceStringValue;
			}
		}

		/// <summary>
		/// System.String objectReferenceTypeString
		/// </summary>
		protected RProperty r_objectReferenceTypeString;
		public virtual RProperty RobjectReferenceTypeString
		{
			get
			{
				if(r_objectReferenceTypeString == null)
				{
					r_objectReferenceTypeString = new(this, "objectReferenceTypeString", -1);
					r_objectReferenceTypeString.SetBelong(this.instance);
				}
				return r_objectReferenceTypeString;
			}
		}

		/// <summary>
		/// UInt32 layerMaskBits
		/// </summary>
		protected RProperty r_layerMaskBits;
		public virtual RProperty RlayerMaskBits
		{
			get
			{
				if(r_layerMaskBits == null)
				{
					r_layerMaskBits = new(this, "layerMaskBits", -1);
					r_layerMaskBits.SetBelong(this.instance);
				}
				return r_layerMaskBits;
			}
		}

		/// <summary>
		/// Int32 enumValueIndex
		/// </summary>
		protected RProperty r_enumValueIndex;
		public virtual RProperty RenumValueIndex
		{
			get
			{
				if(r_enumValueIndex == null)
				{
					r_enumValueIndex = new(this, "enumValueIndex", -1);
					r_enumValueIndex.SetBelong(this.instance);
				}
				return r_enumValueIndex;
			}
		}

		/// <summary>
		/// Int32 enumValueFlag
		/// </summary>
		protected RProperty r_enumValueFlag;
		public virtual RProperty RenumValueFlag
		{
			get
			{
				if(r_enumValueFlag == null)
				{
					r_enumValueFlag = new(this, "enumValueFlag", -1);
					r_enumValueFlag.SetBelong(this.instance);
				}
				return r_enumValueFlag;
			}
		}

		/// <summary>
		/// System.String[] enumNames
		/// </summary>
		protected RPropertyArray<RProperty> r_enumNames;
		public virtual RPropertyArray<RProperty> RenumNames
		{
			get
			{
				if(r_enumNames == null)
				{
					r_enumNames = new(this, "enumNames", -1);
					r_enumNames.SetBelong(this.instance);
				}
				return r_enumNames;
			}
		}

		/// <summary>
		/// System.String[] enumDisplayNames
		/// </summary>
		protected RPropertyArray<RProperty> r_enumDisplayNames;
		public virtual RPropertyArray<RProperty> RenumDisplayNames
		{
			get
			{
				if(r_enumDisplayNames == null)
				{
					r_enumDisplayNames = new(this, "enumDisplayNames", -1);
					r_enumDisplayNames.SetBelong(this.instance);
				}
				return r_enumDisplayNames;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 vector2Value
		/// </summary>
		protected RUnityEngine.RVector2 r_vector2Value;
		public virtual RUnityEngine.RVector2 Rvector2Value
		{
			get
			{
				if(r_vector2Value == null)
				{
					r_vector2Value = new(this, "vector2Value", -1);
					r_vector2Value.SetBelong(this.instance);
				}
				return r_vector2Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 vector3Value
		/// </summary>
		protected RUnityEngine.RVector3 r_vector3Value;
		public virtual RUnityEngine.RVector3 Rvector3Value
		{
			get
			{
				if(r_vector3Value == null)
				{
					r_vector3Value = new(this, "vector3Value", -1);
					r_vector3Value.SetBelong(this.instance);
				}
				return r_vector3Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 vector4Value
		/// </summary>
		protected RUnityEngine.RVector4 r_vector4Value;
		public virtual RUnityEngine.RVector4 Rvector4Value
		{
			get
			{
				if(r_vector4Value == null)
				{
					r_vector4Value = new(this, "vector4Value", -1);
					r_vector4Value.SetBelong(this.instance);
				}
				return r_vector4Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int vector2IntValue
		/// </summary>
		protected RUnityEngine.RVector2Int r_vector2IntValue;
		public virtual RUnityEngine.RVector2Int Rvector2IntValue
		{
			get
			{
				if(r_vector2IntValue == null)
				{
					r_vector2IntValue = new(this, "vector2IntValue", -1);
					r_vector2IntValue.SetBelong(this.instance);
				}
				return r_vector2IntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int vector3IntValue
		/// </summary>
		protected RUnityEngine.RVector3Int r_vector3IntValue;
		public virtual RUnityEngine.RVector3Int Rvector3IntValue
		{
			get
			{
				if(r_vector3IntValue == null)
				{
					r_vector3IntValue = new(this, "vector3IntValue", -1);
					r_vector3IntValue.SetBelong(this.instance);
				}
				return r_vector3IntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion quaternionValue
		/// </summary>
		protected RUnityEngine.RQuaternion r_quaternionValue;
		public virtual RUnityEngine.RQuaternion RquaternionValue
		{
			get
			{
				if(r_quaternionValue == null)
				{
					r_quaternionValue = new(this, "quaternionValue", -1);
					r_quaternionValue.SetBelong(this.instance);
				}
				return r_quaternionValue;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rectValue
		/// </summary>
		protected RUnityEngine.RRect r_rectValue;
		public virtual RUnityEngine.RRect RrectValue
		{
			get
			{
				if(r_rectValue == null)
				{
					r_rectValue = new(this, "rectValue", -1);
					r_rectValue.SetBelong(this.instance);
				}
				return r_rectValue;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt rectIntValue
		/// </summary>
		protected RUnityEngine.RRectInt r_rectIntValue;
		public virtual RUnityEngine.RRectInt RrectIntValue
		{
			get
			{
				if(r_rectIntValue == null)
				{
					r_rectIntValue = new(this, "rectIntValue", -1);
					r_rectIntValue.SetBelong(this.instance);
				}
				return r_rectIntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds boundsValue
		/// </summary>
		protected RUnityEngine.RBounds r_boundsValue;
		public virtual RUnityEngine.RBounds RboundsValue
		{
			get
			{
				if(r_boundsValue == null)
				{
					r_boundsValue = new(this, "boundsValue", -1);
					r_boundsValue.SetBelong(this.instance);
				}
				return r_boundsValue;
			}
		}

		/// <summary>
		/// UnityEngine.BoundsInt boundsIntValue
		/// </summary>
		protected RUnityEngine.RBoundsInt r_boundsIntValue;
		public virtual RUnityEngine.RBoundsInt RboundsIntValue
		{
			get
			{
				if(r_boundsIntValue == null)
				{
					r_boundsIntValue = new(this, "boundsIntValue", -1);
					r_boundsIntValue.SetBelong(this.instance);
				}
				return r_boundsIntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 hash128Value
		/// </summary>
		protected RUnityEngine.RHash128 r_hash128Value;
		public virtual RUnityEngine.RHash128 Rhash128Value
		{
			get
			{
				if(r_hash128Value == null)
				{
					r_hash128Value = new(this, "hash128Value", -1);
					r_hash128Value.SetBelong(this.instance);
				}
				return r_hash128Value;
			}
		}

		/// <summary>
		/// Boolean isArray
		/// </summary>
		protected RProperty r_isArray;
		public virtual RProperty RisArray
		{
			get
			{
				if(r_isArray == null)
				{
					r_isArray = new(this, "isArray", -1);
					r_isArray.SetBelong(this.instance);
				}
				return r_isArray;
			}
		}

		/// <summary>
		/// Int32 arraySize
		/// </summary>
		protected RProperty r_arraySize;
		public virtual RProperty RarraySize
		{
			get
			{
				if(r_arraySize == null)
				{
					r_arraySize = new(this, "arraySize", -1);
					r_arraySize.SetBelong(this.instance);
				}
				return r_arraySize;
			}
		}

		/// <summary>
		/// Int32 minArraySize
		/// </summary>
		protected RProperty r_minArraySize;
		public virtual RProperty RminArraySize
		{
			get
			{
				if(r_minArraySize == null)
				{
					r_minArraySize = new(this, "minArraySize", -1);
					r_minArraySize.SetBelong(this.instance);
				}
				return r_minArraySize;
			}
		}

		/// <summary>
		/// Boolean isFixedBuffer
		/// </summary>
		protected RProperty r_isFixedBuffer;
		public virtual RProperty RisFixedBuffer
		{
			get
			{
				if(r_isFixedBuffer == null)
				{
					r_isFixedBuffer = new(this, "isFixedBuffer", -1);
					r_isFixedBuffer.SetBelong(this.instance);
				}
				return r_isFixedBuffer;
			}
		}

		/// <summary>
		/// Int32 fixedBufferSize
		/// </summary>
		protected RProperty r_fixedBufferSize;
		public virtual RProperty RfixedBufferSize
		{
			get
			{
				if(r_fixedBufferSize == null)
				{
					r_fixedBufferSize = new(this, "fixedBufferSize", -1);
					r_fixedBufferSize.SetBelong(this.instance);
				}
				return r_fixedBufferSize;
			}
		}

		/// <summary>
		/// Boolean isValidDisplayNameCache
		/// </summary>
		protected RProperty r_isValidDisplayNameCache;
		public virtual RProperty RisValidDisplayNameCache
		{
			get
			{
				if(r_isValidDisplayNameCache == null)
				{
					r_isValidDisplayNameCache = new(this, "isValidDisplayNameCache", -1);
					r_isValidDisplayNameCache.SetBelong(this.instance);
				}
				return r_isValidDisplayNameCache;
			}
		}

		/// <summary>
		/// Boolean isValidTooltipCache
		/// </summary>
		protected RProperty r_isValidTooltipCache;
		public virtual RProperty RisValidTooltipCache
		{
			get
			{
				if(r_isValidTooltipCache == null)
				{
					r_isValidTooltipCache = new(this, "isValidTooltipCache", -1);
					r_isValidTooltipCache.SetBelong(this.instance);
				}
				return r_isValidTooltipCache;
			}
		}

		/// <summary>
		/// Boolean unsafeMode
		/// </summary>
		protected RProperty r_unsafeMode;
		public virtual RProperty RunsafeMode
		{
			get
			{
				if(r_unsafeMode == null)
				{
					r_unsafeMode = new(this, "unsafeMode", -1);
					r_unsafeMode.SetBelong(this.instance);
				}
				return r_unsafeMode;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected RProperty r_isValid;
		public virtual RProperty RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid", -1);
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// UInt32 contentHash
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
		/// UnityEditor.SerializedProperty Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty FindPropertyRelative(System.String)
		/// </summary>
		protected RMethod r_RFindPropertyRelative_String;
		public virtual RMethod RFindPropertyRelative_String
		{
			get
			{
				if(r_RFindPropertyRelative_String == null)
				{
					r_RFindPropertyRelative_String = new(this, "FindPropertyRelative", 0, typeof(System.String));
					r_RFindPropertyRelative_String.SetBelong(this.instance);
				}
				return r_RFindPropertyRelative_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetArrayElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_RGetArrayElementAtIndex_Int32;
		public virtual RMethod RGetArrayElementAtIndex_Int32
		{
			get
			{
				if(r_RGetArrayElementAtIndex_Int32 == null)
				{
					r_RGetArrayElementAtIndex_Int32 = new(this, "GetArrayElementAtIndex", 0, typeof(System.Int32));
					r_RGetArrayElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetArrayElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void SetToValueOfTarget(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RSetToValueOfTarget_Object;
		public virtual RMethod RSetToValueOfTarget_Object
		{
			get
			{
				if(r_RSetToValueOfTarget_Object == null)
				{
					r_RSetToValueOfTarget_Object = new(this, "SetToValueOfTarget", 0, typeof(UnityEngine.Object));
					r_RSetToValueOfTarget_Object.SetBelong(this.instance);
				}
				return r_RSetToValueOfTarget_Object;
			}
		}

		/// <summary>
		/// Boolean EndOfData()
		/// </summary>
		protected RMethod r_REndOfData;
		public virtual RMethod REndOfData
		{
			get
			{
				if(r_REndOfData == null)
				{
					r_REndOfData = new(this, "EndOfData", 0);
					r_REndOfData.SetBelong(this.instance);
				}
				return r_REndOfData;
			}
		}

		/// <summary>
		/// Void SyncSerializedObjectVersion()
		/// </summary>
		protected RMethod r_RSyncSerializedObjectVersion;
		public virtual RMethod RSyncSerializedObjectVersion
		{
			get
			{
				if(r_RSyncSerializedObjectVersion == null)
				{
					r_RSyncSerializedObjectVersion = new(this, "SyncSerializedObjectVersion", 0);
					r_RSyncSerializedObjectVersion.SetBelong(this.instance);
				}
				return r_RSyncSerializedObjectVersion;
			}
		}

		/// <summary>
		/// Void Verify(VerifyFlags)
		/// </summary>
		protected RMethod r_RVerify_VerifyFlags;
		public virtual RMethod RVerify_VerifyFlags
		{
			get
			{
				if(r_RVerify_VerifyFlags == null)
				{
					r_RVerify_VerifyFlags = new(this, "Verify", 0,  ReleactionUtils.GetType("UnityEditor.SerializedProperty+VerifyFlags"));
					r_RVerify_VerifyFlags.SetBelong(this.instance);
				}
				return r_RVerify_VerifyFlags;
			}
		}

		/// <summary>
		/// Boolean NextVisible(Boolean)
		/// </summary>
		protected RMethod r_RNextVisible_Boolean;
		public virtual RMethod RNextVisible_Boolean
		{
			get
			{
				if(r_RNextVisible_Boolean == null)
				{
					r_RNextVisible_Boolean = new(this, "NextVisible", 0, typeof(System.Boolean));
					r_RNextVisible_Boolean.SetBelong(this.instance);
				}
				return r_RNextVisible_Boolean;
			}
		}

		/// <summary>
		/// Boolean NextVisibleInternal(Boolean)
		/// </summary>
		protected RMethod r_RNextVisibleInternal_Boolean;
		public virtual RMethod RNextVisibleInternal_Boolean
		{
			get
			{
				if(r_RNextVisibleInternal_Boolean == null)
				{
					r_RNextVisibleInternal_Boolean = new(this, "NextVisibleInternal", 0, typeof(System.Boolean));
					r_RNextVisibleInternal_Boolean.SetBelong(this.instance);
				}
				return r_RNextVisibleInternal_Boolean;
			}
		}

		/// <summary>
		/// Void ClearArray()
		/// </summary>
		protected RMethod r_RClearArray;
		public virtual RMethod RClearArray
		{
			get
			{
				if(r_RClearArray == null)
				{
					r_RClearArray = new(this, "ClearArray", 0);
					r_RClearArray.SetBelong(this.instance);
				}
				return r_RClearArray;
			}
		}

		/// <summary>
		/// Void ClearArrayInternal()
		/// </summary>
		protected RMethod r_RClearArrayInternal;
		public virtual RMethod RClearArrayInternal
		{
			get
			{
				if(r_RClearArrayInternal == null)
				{
					r_RClearArrayInternal = new(this, "ClearArrayInternal", 0);
					r_RClearArrayInternal.SetBelong(this.instance);
				}
				return r_RClearArrayInternal;
			}
		}

		/// <summary>
		/// Boolean FindPropertyInternal(System.String)
		/// </summary>
		protected RMethod r_RFindPropertyInternal_String;
		public virtual RMethod RFindPropertyInternal_String
		{
			get
			{
				if(r_RFindPropertyInternal_String == null)
				{
					r_RFindPropertyInternal_String = new(this, "FindPropertyInternal", 0, typeof(System.String));
					r_RFindPropertyInternal_String.SetBelong(this.instance);
				}
				return r_RFindPropertyInternal_String;
			}
		}

		/// <summary>
		/// Boolean FindFirstPropertyFromManagedReferencePathInternal(System.String)
		/// </summary>
		protected RMethod r_RFindFirstPropertyFromManagedReferencePathInternal_String;
		public virtual RMethod RFindFirstPropertyFromManagedReferencePathInternal_String
		{
			get
			{
				if(r_RFindFirstPropertyFromManagedReferencePathInternal_String == null)
				{
					r_RFindFirstPropertyFromManagedReferencePathInternal_String = new(this, "FindFirstPropertyFromManagedReferencePathInternal", 0, typeof(System.String));
					r_RFindFirstPropertyFromManagedReferencePathInternal_String.SetBelong(this.instance);
				}
				return r_RFindFirstPropertyFromManagedReferencePathInternal_String;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_Destroy_IntPtr;
		public static RMethod RInternal_Destroy_IntPtr
		{
			get
			{
				if(r_RInternal_Destroy_IntPtr == null)
				{
					r_RInternal_Destroy_IntPtr = new(typeof(UnityEditor.SerializedProperty), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_RInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_RInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// Boolean EqualContents(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_REqualContents_SerializedProperty_SerializedProperty;
		public static RMethod REqualContents_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_REqualContents_SerializedProperty_SerializedProperty == null)
				{
					r_REqualContents_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "EqualContents", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_REqualContents_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_REqualContents_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean EqualContentsInternal(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_REqualContentsInternal_SerializedProperty_SerializedProperty;
		public static RMethod REqualContentsInternal_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_REqualContentsInternal_SerializedProperty_SerializedProperty == null)
				{
					r_REqualContentsInternal_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "EqualContentsInternal", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_REqualContentsInternal_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_REqualContentsInternal_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean DataEquals(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RDataEquals_SerializedProperty_SerializedProperty;
		public static RMethod RDataEquals_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_RDataEquals_SerializedProperty_SerializedProperty == null)
				{
					r_RDataEquals_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "DataEquals", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_RDataEquals_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_RDataEquals_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean VersionEquals(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RVersionEquals_SerializedProperty_SerializedProperty;
		public static RMethod RVersionEquals_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_RVersionEquals_SerializedProperty_SerializedProperty == null)
				{
					r_RVersionEquals_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "VersionEquals", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_RVersionEquals_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_RVersionEquals_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean DataEqualsInternal(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RDataEqualsInternal_SerializedProperty_SerializedProperty;
		public static RMethod RDataEqualsInternal_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_RDataEqualsInternal_SerializedProperty_SerializedProperty == null)
				{
					r_RDataEqualsInternal_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "DataEqualsInternal", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_RDataEqualsInternal_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_RDataEqualsInternal_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Int32 HasMultipleDifferentValuesInternal()
		/// </summary>
		protected RMethod r_RHasMultipleDifferentValuesInternal;
		public virtual RMethod RHasMultipleDifferentValuesInternal
		{
			get
			{
				if(r_RHasMultipleDifferentValuesInternal == null)
				{
					r_RHasMultipleDifferentValuesInternal = new(this, "HasMultipleDifferentValuesInternal", 0);
					r_RHasMultipleDifferentValuesInternal.SetBelong(this.instance);
				}
				return r_RHasMultipleDifferentValuesInternal;
			}
		}

		/// <summary>
		/// Void SetBitAtIndexForAllTargetsImmediate(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean;
		public virtual RMethod RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean
		{
			get
			{
				if(r_RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean == null)
				{
					r_RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean = new(this, "SetBitAtIndexForAllTargetsImmediate", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetBitAtIndexForAllTargetsImmediateInternal(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean;
		public virtual RMethod RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean
		{
			get
			{
				if(r_RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean == null)
				{
					r_RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean = new(this, "SetBitAtIndexForAllTargetsImmediateInternal", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.String GetMangledNameInternal()
		/// </summary>
		protected RMethod r_RGetMangledNameInternal;
		public virtual RMethod RGetMangledNameInternal
		{
			get
			{
				if(r_RGetMangledNameInternal == null)
				{
					r_RGetMangledNameInternal = new(this, "GetMangledNameInternal", 0);
					r_RGetMangledNameInternal.SetBelong(this.instance);
				}
				return r_RGetMangledNameInternal;
			}
		}

		/// <summary>
		/// System.String GetNameInternal()
		/// </summary>
		protected RMethod r_RGetNameInternal;
		public virtual RMethod RGetNameInternal
		{
			get
			{
				if(r_RGetNameInternal == null)
				{
					r_RGetNameInternal = new(this, "GetNameInternal", 0);
					r_RGetNameInternal.SetBelong(this.instance);
				}
				return r_RGetNameInternal;
			}
		}

		/// <summary>
		/// System.String GetSerializedPropertyTypeNameInternal()
		/// </summary>
		protected RMethod r_RGetSerializedPropertyTypeNameInternal;
		public virtual RMethod RGetSerializedPropertyTypeNameInternal
		{
			get
			{
				if(r_RGetSerializedPropertyTypeNameInternal == null)
				{
					r_RGetSerializedPropertyTypeNameInternal = new(this, "GetSerializedPropertyTypeNameInternal", 0);
					r_RGetSerializedPropertyTypeNameInternal.SetBelong(this.instance);
				}
				return r_RGetSerializedPropertyTypeNameInternal;
			}
		}

		/// <summary>
		/// System.String GetSerializedPropertyArrayElementTypeNameInternal()
		/// </summary>
		protected RMethod r_RGetSerializedPropertyArrayElementTypeNameInternal;
		public virtual RMethod RGetSerializedPropertyArrayElementTypeNameInternal
		{
			get
			{
				if(r_RGetSerializedPropertyArrayElementTypeNameInternal == null)
				{
					r_RGetSerializedPropertyArrayElementTypeNameInternal = new(this, "GetSerializedPropertyArrayElementTypeNameInternal", 0);
					r_RGetSerializedPropertyArrayElementTypeNameInternal.SetBelong(this.instance);
				}
				return r_RGetSerializedPropertyArrayElementTypeNameInternal;
			}
		}

		/// <summary>
		/// System.String GetTooltipInternal()
		/// </summary>
		protected RMethod r_RGetTooltipInternal;
		public virtual RMethod RGetTooltipInternal
		{
			get
			{
				if(r_RGetTooltipInternal == null)
				{
					r_RGetTooltipInternal = new(this, "GetTooltipInternal", 0);
					r_RGetTooltipInternal.SetBelong(this.instance);
				}
				return r_RGetTooltipInternal;
			}
		}

		/// <summary>
		/// Int32 GetDepthInternal()
		/// </summary>
		protected RMethod r_RGetDepthInternal;
		public virtual RMethod RGetDepthInternal
		{
			get
			{
				if(r_RGetDepthInternal == null)
				{
					r_RGetDepthInternal = new(this, "GetDepthInternal", 0);
					r_RGetDepthInternal.SetBelong(this.instance);
				}
				return r_RGetDepthInternal;
			}
		}

		/// <summary>
		/// System.String GetPropertyPathInternal()
		/// </summary>
		protected RMethod r_RGetPropertyPathInternal;
		public virtual RMethod RGetPropertyPathInternal
		{
			get
			{
				if(r_RGetPropertyPathInternal == null)
				{
					r_RGetPropertyPathInternal = new(this, "GetPropertyPathInternal", 0);
					r_RGetPropertyPathInternal.SetBelong(this.instance);
				}
				return r_RGetPropertyPathInternal;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeForPropertyPathInternal()
		/// </summary>
		protected RMethod r_RGetHashCodeForPropertyPathInternal;
		public virtual RMethod RGetHashCodeForPropertyPathInternal
		{
			get
			{
				if(r_RGetHashCodeForPropertyPathInternal == null)
				{
					r_RGetHashCodeForPropertyPathInternal = new(this, "GetHashCodeForPropertyPathInternal", 0);
					r_RGetHashCodeForPropertyPathInternal.SetBelong(this.instance);
				}
				return r_RGetHashCodeForPropertyPathInternal;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeForPropertyPathWithoutArrayIndexInternal()
		/// </summary>
		protected RMethod r_RGetHashCodeForPropertyPathWithoutArrayIndexInternal;
		public virtual RMethod RGetHashCodeForPropertyPathWithoutArrayIndexInternal
		{
			get
			{
				if(r_RGetHashCodeForPropertyPathWithoutArrayIndexInternal == null)
				{
					r_RGetHashCodeForPropertyPathWithoutArrayIndexInternal = new(this, "GetHashCodeForPropertyPathWithoutArrayIndexInternal", 0);
					r_RGetHashCodeForPropertyPathWithoutArrayIndexInternal.SetBelong(this.instance);
				}
				return r_RGetHashCodeForPropertyPathWithoutArrayIndexInternal;
			}
		}

		/// <summary>
		/// Boolean GetEditableInternal()
		/// </summary>
		protected RMethod r_RGetEditableInternal;
		public virtual RMethod RGetEditableInternal
		{
			get
			{
				if(r_RGetEditableInternal == null)
				{
					r_RGetEditableInternal = new(this, "GetEditableInternal", 0);
					r_RGetEditableInternal.SetBelong(this.instance);
				}
				return r_RGetEditableInternal;
			}
		}

		/// <summary>
		/// Boolean IsReorderable()
		/// </summary>
		protected RMethod r_RIsReorderable;
		public virtual RMethod RIsReorderable
		{
			get
			{
				if(r_RIsReorderable == null)
				{
					r_RIsReorderable = new(this, "IsReorderable", 0);
					r_RIsReorderable.SetBelong(this.instance);
				}
				return r_RIsReorderable;
			}
		}

		/// <summary>
		/// Boolean IsAnimatedInternal()
		/// </summary>
		protected RMethod r_RIsAnimatedInternal;
		public virtual RMethod RIsAnimatedInternal
		{
			get
			{
				if(r_RIsAnimatedInternal == null)
				{
					r_RIsAnimatedInternal = new(this, "IsAnimatedInternal", 0);
					r_RIsAnimatedInternal.SetBelong(this.instance);
				}
				return r_RIsAnimatedInternal;
			}
		}

		/// <summary>
		/// Boolean IsCandidateInternal()
		/// </summary>
		protected RMethod r_RIsCandidateInternal;
		public virtual RMethod RIsCandidateInternal
		{
			get
			{
				if(r_RIsCandidateInternal == null)
				{
					r_RIsCandidateInternal = new(this, "IsCandidateInternal", 0);
					r_RIsCandidateInternal.SetBelong(this.instance);
				}
				return r_RIsCandidateInternal;
			}
		}

		/// <summary>
		/// Boolean IsKeyInternal()
		/// </summary>
		protected RMethod r_RIsKeyInternal;
		public virtual RMethod RIsKeyInternal
		{
			get
			{
				if(r_RIsKeyInternal == null)
				{
					r_RIsKeyInternal = new(this, "IsKeyInternal", 0);
					r_RIsKeyInternal.SetBelong(this.instance);
				}
				return r_RIsKeyInternal;
			}
		}

		/// <summary>
		/// Boolean IsLiveModified()
		/// </summary>
		protected RMethod r_RIsLiveModified;
		public virtual RMethod RIsLiveModified
		{
			get
			{
				if(r_RIsLiveModified == null)
				{
					r_RIsLiveModified = new(this, "IsLiveModified", 0);
					r_RIsLiveModified.SetBelong(this.instance);
				}
				return r_RIsLiveModified;
			}
		}

		/// <summary>
		/// Boolean GetIsExpandedInternal()
		/// </summary>
		protected RMethod r_RGetIsExpandedInternal;
		public virtual RMethod RGetIsExpandedInternal
		{
			get
			{
				if(r_RGetIsExpandedInternal == null)
				{
					r_RGetIsExpandedInternal = new(this, "GetIsExpandedInternal", 0);
					r_RGetIsExpandedInternal.SetBelong(this.instance);
				}
				return r_RGetIsExpandedInternal;
			}
		}

		/// <summary>
		/// Void SetIsExpandedInternal(Boolean)
		/// </summary>
		protected RMethod r_RSetIsExpandedInternal_Boolean;
		public virtual RMethod RSetIsExpandedInternal_Boolean
		{
			get
			{
				if(r_RSetIsExpandedInternal_Boolean == null)
				{
					r_RSetIsExpandedInternal_Boolean = new(this, "SetIsExpandedInternal", 0, typeof(System.Boolean));
					r_RSetIsExpandedInternal_Boolean.SetBelong(this.instance);
				}
				return r_RSetIsExpandedInternal_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasChildrenInternal()
		/// </summary>
		protected RMethod r_RHasChildrenInternal;
		public virtual RMethod RHasChildrenInternal
		{
			get
			{
				if(r_RHasChildrenInternal == null)
				{
					r_RHasChildrenInternal = new(this, "HasChildrenInternal", 0);
					r_RHasChildrenInternal.SetBelong(this.instance);
				}
				return r_RHasChildrenInternal;
			}
		}

		/// <summary>
		/// Boolean HasVisibleChildrenInternal()
		/// </summary>
		protected RMethod r_RHasVisibleChildrenInternal;
		public virtual RMethod RHasVisibleChildrenInternal
		{
			get
			{
				if(r_RHasVisibleChildrenInternal == null)
				{
					r_RHasVisibleChildrenInternal = new(this, "HasVisibleChildrenInternal", 0);
					r_RHasVisibleChildrenInternal.SetBelong(this.instance);
				}
				return r_RHasVisibleChildrenInternal;
			}
		}

		/// <summary>
		/// Boolean GetIsInstantiatedPrefabInternal()
		/// </summary>
		protected RMethod r_RGetIsInstantiatedPrefabInternal;
		public virtual RMethod RGetIsInstantiatedPrefabInternal
		{
			get
			{
				if(r_RGetIsInstantiatedPrefabInternal == null)
				{
					r_RGetIsInstantiatedPrefabInternal = new(this, "GetIsInstantiatedPrefabInternal", 0);
					r_RGetIsInstantiatedPrefabInternal.SetBelong(this.instance);
				}
				return r_RGetIsInstantiatedPrefabInternal;
			}
		}

		/// <summary>
		/// Boolean IsReferencingAManagedReferenceFieldInternal()
		/// </summary>
		protected RMethod r_RIsReferencingAManagedReferenceFieldInternal;
		public virtual RMethod RIsReferencingAManagedReferenceFieldInternal
		{
			get
			{
				if(r_RIsReferencingAManagedReferenceFieldInternal == null)
				{
					r_RIsReferencingAManagedReferenceFieldInternal = new(this, "IsReferencingAManagedReferenceFieldInternal", 0);
					r_RIsReferencingAManagedReferenceFieldInternal.SetBelong(this.instance);
				}
				return r_RIsReferencingAManagedReferenceFieldInternal;
			}
		}

		/// <summary>
		/// System.String GetFullyQualifiedTypenameForCurrentTypeTreeInternal()
		/// </summary>
		protected RMethod r_RGetFullyQualifiedTypenameForCurrentTypeTreeInternal;
		public virtual RMethod RGetFullyQualifiedTypenameForCurrentTypeTreeInternal
		{
			get
			{
				if(r_RGetFullyQualifiedTypenameForCurrentTypeTreeInternal == null)
				{
					r_RGetFullyQualifiedTypenameForCurrentTypeTreeInternal = new(this, "GetFullyQualifiedTypenameForCurrentTypeTreeInternal", 0);
					r_RGetFullyQualifiedTypenameForCurrentTypeTreeInternal.SetBelong(this.instance);
				}
				return r_RGetFullyQualifiedTypenameForCurrentTypeTreeInternal;
			}
		}

		/// <summary>
		/// System.String GetPropertyPathInCurrentManagedTypeTreeInternal()
		/// </summary>
		protected RMethod r_RGetPropertyPathInCurrentManagedTypeTreeInternal;
		public virtual RMethod RGetPropertyPathInCurrentManagedTypeTreeInternal
		{
			get
			{
				if(r_RGetPropertyPathInCurrentManagedTypeTreeInternal == null)
				{
					r_RGetPropertyPathInCurrentManagedTypeTreeInternal = new(this, "GetPropertyPathInCurrentManagedTypeTreeInternal", 0);
					r_RGetPropertyPathInCurrentManagedTypeTreeInternal.SetBelong(this.instance);
				}
				return r_RGetPropertyPathInCurrentManagedTypeTreeInternal;
			}
		}

		/// <summary>
		/// System.String GetManagedReferencePropertyPathInternal()
		/// </summary>
		protected RMethod r_RGetManagedReferencePropertyPathInternal;
		public virtual RMethod RGetManagedReferencePropertyPathInternal
		{
			get
			{
				if(r_RGetManagedReferencePropertyPathInternal == null)
				{
					r_RGetManagedReferencePropertyPathInternal = new(this, "GetManagedReferencePropertyPathInternal", 0);
					r_RGetManagedReferencePropertyPathInternal.SetBelong(this.instance);
				}
				return r_RGetManagedReferencePropertyPathInternal;
			}
		}

		/// <summary>
		/// Boolean GetPrefabOverrideInternal()
		/// </summary>
		protected RMethod r_RGetPrefabOverrideInternal;
		public virtual RMethod RGetPrefabOverrideInternal
		{
			get
			{
				if(r_RGetPrefabOverrideInternal == null)
				{
					r_RGetPrefabOverrideInternal = new(this, "GetPrefabOverrideInternal", 0);
					r_RGetPrefabOverrideInternal.SetBelong(this.instance);
				}
				return r_RGetPrefabOverrideInternal;
			}
		}

		/// <summary>
		/// Void SetPrefabOverrideInternal(Boolean)
		/// </summary>
		protected RMethod r_RSetPrefabOverrideInternal_Boolean;
		public virtual RMethod RSetPrefabOverrideInternal_Boolean
		{
			get
			{
				if(r_RSetPrefabOverrideInternal_Boolean == null)
				{
					r_RSetPrefabOverrideInternal_Boolean = new(this, "SetPrefabOverrideInternal", 0, typeof(System.Boolean));
					r_RSetPrefabOverrideInternal_Boolean.SetBelong(this.instance);
				}
				return r_RSetPrefabOverrideInternal_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetIsDefaultOverrideInternal()
		/// </summary>
		protected RMethod r_RGetIsDefaultOverrideInternal;
		public virtual RMethod RGetIsDefaultOverrideInternal
		{
			get
			{
				if(r_RGetIsDefaultOverrideInternal == null)
				{
					r_RGetIsDefaultOverrideInternal = new(this, "GetIsDefaultOverrideInternal", 0);
					r_RGetIsDefaultOverrideInternal.SetBelong(this.instance);
				}
				return r_RGetIsDefaultOverrideInternal;
			}
		}

		/// <summary>
		/// Boolean GetIsDrivenRectTransformPropertyInternal()
		/// </summary>
		protected RMethod r_RGetIsDrivenRectTransformPropertyInternal;
		public virtual RMethod RGetIsDrivenRectTransformPropertyInternal
		{
			get
			{
				if(r_RGetIsDrivenRectTransformPropertyInternal == null)
				{
					r_RGetIsDrivenRectTransformPropertyInternal = new(this, "GetIsDrivenRectTransformPropertyInternal", 0);
					r_RGetIsDrivenRectTransformPropertyInternal.SetBelong(this.instance);
				}
				return r_RGetIsDrivenRectTransformPropertyInternal;
			}
		}

		/// <summary>
		/// Int32 GetSerializedPropertyTypeInternal()
		/// </summary>
		protected RMethod r_RGetSerializedPropertyTypeInternal;
		public virtual RMethod RGetSerializedPropertyTypeInternal
		{
			get
			{
				if(r_RGetSerializedPropertyTypeInternal == null)
				{
					r_RGetSerializedPropertyTypeInternal = new(this, "GetSerializedPropertyTypeInternal", 0);
					r_RGetSerializedPropertyTypeInternal.SetBelong(this.instance);
				}
				return r_RGetSerializedPropertyTypeInternal;
			}
		}

		/// <summary>
		/// Int32 GetNumericTypeInternal()
		/// </summary>
		protected RMethod r_RGetNumericTypeInternal;
		public virtual RMethod RGetNumericTypeInternal
		{
			get
			{
				if(r_RGetNumericTypeInternal == null)
				{
					r_RGetNumericTypeInternal = new(this, "GetNumericTypeInternal", 0);
					r_RGetNumericTypeInternal.SetBelong(this.instance);
				}
				return r_RGetNumericTypeInternal;
			}
		}

		/// <summary>
		/// Int64 GetIntValueInternal()
		/// </summary>
		protected RMethod r_RGetIntValueInternal;
		public virtual RMethod RGetIntValueInternal
		{
			get
			{
				if(r_RGetIntValueInternal == null)
				{
					r_RGetIntValueInternal = new(this, "GetIntValueInternal", 0);
					r_RGetIntValueInternal.SetBelong(this.instance);
				}
				return r_RGetIntValueInternal;
			}
		}

		/// <summary>
		/// Void SetIntValueInternal(Int64)
		/// </summary>
		protected RMethod r_RSetIntValueInternal_Int64;
		public virtual RMethod RSetIntValueInternal_Int64
		{
			get
			{
				if(r_RSetIntValueInternal_Int64 == null)
				{
					r_RSetIntValueInternal_Int64 = new(this, "SetIntValueInternal", 0, typeof(System.Int64));
					r_RSetIntValueInternal_Int64.SetBelong(this.instance);
				}
				return r_RSetIntValueInternal_Int64;
			}
		}

		/// <summary>
		/// Boolean GetBoolValueInternal()
		/// </summary>
		protected RMethod r_RGetBoolValueInternal;
		public virtual RMethod RGetBoolValueInternal
		{
			get
			{
				if(r_RGetBoolValueInternal == null)
				{
					r_RGetBoolValueInternal = new(this, "GetBoolValueInternal", 0);
					r_RGetBoolValueInternal.SetBelong(this.instance);
				}
				return r_RGetBoolValueInternal;
			}
		}

		/// <summary>
		/// Void SetBoolValueInternal(Boolean)
		/// </summary>
		protected RMethod r_RSetBoolValueInternal_Boolean;
		public virtual RMethod RSetBoolValueInternal_Boolean
		{
			get
			{
				if(r_RSetBoolValueInternal_Boolean == null)
				{
					r_RSetBoolValueInternal_Boolean = new(this, "SetBoolValueInternal", 0, typeof(System.Boolean));
					r_RSetBoolValueInternal_Boolean.SetBelong(this.instance);
				}
				return r_RSetBoolValueInternal_Boolean;
			}
		}

		/// <summary>
		/// Double GetFloatValueInternal()
		/// </summary>
		protected RMethod r_RGetFloatValueInternal;
		public virtual RMethod RGetFloatValueInternal
		{
			get
			{
				if(r_RGetFloatValueInternal == null)
				{
					r_RGetFloatValueInternal = new(this, "GetFloatValueInternal", 0);
					r_RGetFloatValueInternal.SetBelong(this.instance);
				}
				return r_RGetFloatValueInternal;
			}
		}

		/// <summary>
		/// Void SetFloatValueInternal(Double)
		/// </summary>
		protected RMethod r_RSetFloatValueInternal_Double;
		public virtual RMethod RSetFloatValueInternal_Double
		{
			get
			{
				if(r_RSetFloatValueInternal_Double == null)
				{
					r_RSetFloatValueInternal_Double = new(this, "SetFloatValueInternal", 0, typeof(System.Double));
					r_RSetFloatValueInternal_Double.SetBelong(this.instance);
				}
				return r_RSetFloatValueInternal_Double;
			}
		}

		/// <summary>
		/// Double[] GetAllFloatValues()
		/// </summary>
		protected RMethod r_RGetAllFloatValues;
		public virtual RMethod RGetAllFloatValues
		{
			get
			{
				if(r_RGetAllFloatValues == null)
				{
					r_RGetAllFloatValues = new(this, "GetAllFloatValues", 0);
					r_RGetAllFloatValues.SetBelong(this.instance);
				}
				return r_RGetAllFloatValues;
			}
		}

		/// <summary>
		/// Void SetAllFloatValuesImmediate(Double[])
		/// </summary>
		protected RMethod r_RSetAllFloatValuesImmediate_DoubleArray;
		public virtual RMethod RSetAllFloatValuesImmediate_DoubleArray
		{
			get
			{
				if(r_RSetAllFloatValuesImmediate_DoubleArray == null)
				{
					r_RSetAllFloatValuesImmediate_DoubleArray = new(this, "SetAllFloatValuesImmediate", 0, typeof(System.Double).MakeArrayType());
					r_RSetAllFloatValuesImmediate_DoubleArray.SetBelong(this.instance);
				}
				return r_RSetAllFloatValuesImmediate_DoubleArray;
			}
		}

		/// <summary>
		/// Int64[] GetAllIntValues()
		/// </summary>
		protected RMethod r_RGetAllIntValues;
		public virtual RMethod RGetAllIntValues
		{
			get
			{
				if(r_RGetAllIntValues == null)
				{
					r_RGetAllIntValues = new(this, "GetAllIntValues", 0);
					r_RGetAllIntValues.SetBelong(this.instance);
				}
				return r_RGetAllIntValues;
			}
		}

		/// <summary>
		/// Void SetAllIntValuesImmediate(Int64[])
		/// </summary>
		protected RMethod r_RSetAllIntValuesImmediate_Int64Array;
		public virtual RMethod RSetAllIntValuesImmediate_Int64Array
		{
			get
			{
				if(r_RSetAllIntValuesImmediate_Int64Array == null)
				{
					r_RSetAllIntValuesImmediate_Int64Array = new(this, "SetAllIntValuesImmediate", 0, typeof(System.Int64).MakeArrayType());
					r_RSetAllIntValuesImmediate_Int64Array.SetBelong(this.instance);
				}
				return r_RSetAllIntValuesImmediate_Int64Array;
			}
		}

		/// <summary>
		/// System.String GetStringValueInternal()
		/// </summary>
		protected RMethod r_RGetStringValueInternal;
		public virtual RMethod RGetStringValueInternal
		{
			get
			{
				if(r_RGetStringValueInternal == null)
				{
					r_RGetStringValueInternal = new(this, "GetStringValueInternal", 0);
					r_RGetStringValueInternal.SetBelong(this.instance);
				}
				return r_RGetStringValueInternal;
			}
		}

		/// <summary>
		/// Void SetStringValueInternal(System.String)
		/// </summary>
		protected RMethod r_RSetStringValueInternal_String;
		public virtual RMethod RSetStringValueInternal_String
		{
			get
			{
				if(r_RSetStringValueInternal_String == null)
				{
					r_RSetStringValueInternal_String = new(this, "SetStringValueInternal", 0, typeof(System.String));
					r_RSetStringValueInternal_String.SetBelong(this.instance);
				}
				return r_RSetStringValueInternal_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorValueInternal()
		/// </summary>
		protected RMethod r_RGetColorValueInternal;
		public virtual RMethod RGetColorValueInternal
		{
			get
			{
				if(r_RGetColorValueInternal == null)
				{
					r_RGetColorValueInternal = new(this, "GetColorValueInternal", 0);
					r_RGetColorValueInternal.SetBelong(this.instance);
				}
				return r_RGetColorValueInternal;
			}
		}

		/// <summary>
		/// Void SetColorValueInternal(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColorValueInternal_Color;
		public virtual RMethod RSetColorValueInternal_Color
		{
			get
			{
				if(r_RSetColorValueInternal_Color == null)
				{
					r_RSetColorValueInternal_Color = new(this, "SetColorValueInternal", 0, typeof(UnityEngine.Color));
					r_RSetColorValueInternal_Color.SetBelong(this.instance);
				}
				return r_RSetColorValueInternal_Color;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve GetAnimationCurveValueCopyInternal()
		/// </summary>
		protected RMethod r_RGetAnimationCurveValueCopyInternal;
		public virtual RMethod RGetAnimationCurveValueCopyInternal
		{
			get
			{
				if(r_RGetAnimationCurveValueCopyInternal == null)
				{
					r_RGetAnimationCurveValueCopyInternal = new(this, "GetAnimationCurveValueCopyInternal", 0);
					r_RGetAnimationCurveValueCopyInternal.SetBelong(this.instance);
				}
				return r_RGetAnimationCurveValueCopyInternal;
			}
		}

		/// <summary>
		/// Void SetAnimationCurveValueInternal(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_RSetAnimationCurveValueInternal_AnimationCurve;
		public virtual RMethod RSetAnimationCurveValueInternal_AnimationCurve
		{
			get
			{
				if(r_RSetAnimationCurveValueInternal_AnimationCurve == null)
				{
					r_RSetAnimationCurveValueInternal_AnimationCurve = new(this, "SetAnimationCurveValueInternal", 0, typeof(UnityEngine.AnimationCurve));
					r_RSetAnimationCurveValueInternal_AnimationCurve.SetBelong(this.instance);
				}
				return r_RSetAnimationCurveValueInternal_AnimationCurve;
			}
		}

		/// <summary>
		/// UnityEngine.Gradient GetGradientValueCopyInternal()
		/// </summary>
		protected RMethod r_RGetGradientValueCopyInternal;
		public virtual RMethod RGetGradientValueCopyInternal
		{
			get
			{
				if(r_RGetGradientValueCopyInternal == null)
				{
					r_RGetGradientValueCopyInternal = new(this, "GetGradientValueCopyInternal", 0);
					r_RGetGradientValueCopyInternal.SetBelong(this.instance);
				}
				return r_RGetGradientValueCopyInternal;
			}
		}

		/// <summary>
		/// Void SetGradientValueInternal(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_RSetGradientValueInternal_Gradient;
		public virtual RMethod RSetGradientValueInternal_Gradient
		{
			get
			{
				if(r_RSetGradientValueInternal_Gradient == null)
				{
					r_RSetGradientValueInternal_Gradient = new(this, "SetGradientValueInternal", 0, typeof(UnityEngine.Gradient));
					r_RSetGradientValueInternal_Gradient.SetBelong(this.instance);
				}
				return r_RSetGradientValueInternal_Gradient;
			}
		}

		/// <summary>
		/// Int64 GetManagedReferenceIdInternal()
		/// </summary>
		protected RMethod r_RGetManagedReferenceIdInternal;
		public virtual RMethod RGetManagedReferenceIdInternal
		{
			get
			{
				if(r_RGetManagedReferenceIdInternal == null)
				{
					r_RGetManagedReferenceIdInternal = new(this, "GetManagedReferenceIdInternal", 0);
					r_RGetManagedReferenceIdInternal.SetBelong(this.instance);
				}
				return r_RGetManagedReferenceIdInternal;
			}
		}

		/// <summary>
		/// System.String GetManagedReferenceFullTypeNameInternal()
		/// </summary>
		protected RMethod r_RGetManagedReferenceFullTypeNameInternal;
		public virtual RMethod RGetManagedReferenceFullTypeNameInternal
		{
			get
			{
				if(r_RGetManagedReferenceFullTypeNameInternal == null)
				{
					r_RGetManagedReferenceFullTypeNameInternal = new(this, "GetManagedReferenceFullTypeNameInternal", 0);
					r_RGetManagedReferenceFullTypeNameInternal.SetBelong(this.instance);
				}
				return r_RGetManagedReferenceFullTypeNameInternal;
			}
		}

		/// <summary>
		/// Void SetManagedReferenceValueInternal(System.Object)
		/// </summary>
		protected RMethod r_RSetManagedReferenceValueInternal_Object;
		public virtual RMethod RSetManagedReferenceValueInternal_Object
		{
			get
			{
				if(r_RSetManagedReferenceValueInternal_Object == null)
				{
					r_RSetManagedReferenceValueInternal_Object = new(this, "SetManagedReferenceValueInternal", 0, typeof(System.Object));
					r_RSetManagedReferenceValueInternal_Object.SetBelong(this.instance);
				}
				return r_RSetManagedReferenceValueInternal_Object;
			}
		}

		/// <summary>
		/// Void SetStructValueInternal(System.Object)
		/// </summary>
		protected RMethod r_RSetStructValueInternal_Object;
		public virtual RMethod RSetStructValueInternal_Object
		{
			get
			{
				if(r_RSetStructValueInternal_Object == null)
				{
					r_RSetStructValueInternal_Object = new(this, "SetStructValueInternal", 0, typeof(System.Object));
					r_RSetStructValueInternal_Object.SetBelong(this.instance);
				}
				return r_RSetStructValueInternal_Object;
			}
		}

		/// <summary>
		/// System.Object GetStructValueInternal(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RGetStructValueInternal_String_String_String;
		public virtual RMethod RGetStructValueInternal_String_String_String
		{
			get
			{
				if(r_RGetStructValueInternal_String_String_String == null)
				{
					r_RGetStructValueInternal_String_String_String = new(this, "GetStructValueInternal", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RGetStructValueInternal_String_String_String.SetBelong(this.instance);
				}
				return r_RGetStructValueInternal_String_String_String;
			}
		}

		/// <summary>
		/// System.Object LookupInstanceByIdInternal(Int64)
		/// </summary>
		protected RMethod r_RLookupInstanceByIdInternal_Int64;
		public virtual RMethod RLookupInstanceByIdInternal_Int64
		{
			get
			{
				if(r_RLookupInstanceByIdInternal_Int64 == null)
				{
					r_RLookupInstanceByIdInternal_Int64 = new(this, "LookupInstanceByIdInternal", 0, typeof(System.Int64));
					r_RLookupInstanceByIdInternal_Int64.SetBelong(this.instance);
				}
				return r_RLookupInstanceByIdInternal_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetPPtrValueInternal()
		/// </summary>
		protected RMethod r_RGetPPtrValueInternal;
		public virtual RMethod RGetPPtrValueInternal
		{
			get
			{
				if(r_RGetPPtrValueInternal == null)
				{
					r_RGetPPtrValueInternal = new(this, "GetPPtrValueInternal", 0);
					r_RGetPPtrValueInternal.SetBelong(this.instance);
				}
				return r_RGetPPtrValueInternal;
			}
		}

		/// <summary>
		/// Void SetPPtrValueInternal(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RSetPPtrValueInternal_Object;
		public virtual RMethod RSetPPtrValueInternal_Object
		{
			get
			{
				if(r_RSetPPtrValueInternal_Object == null)
				{
					r_RSetPPtrValueInternal_Object = new(this, "SetPPtrValueInternal", 0, typeof(UnityEngine.Object));
					r_RSetPPtrValueInternal_Object.SetBelong(this.instance);
				}
				return r_RSetPPtrValueInternal_Object;
			}
		}

		/// <summary>
		/// Int32 GetPPtrValueFromInstanceIDInternal()
		/// </summary>
		protected RMethod r_RGetPPtrValueFromInstanceIDInternal;
		public virtual RMethod RGetPPtrValueFromInstanceIDInternal
		{
			get
			{
				if(r_RGetPPtrValueFromInstanceIDInternal == null)
				{
					r_RGetPPtrValueFromInstanceIDInternal = new(this, "GetPPtrValueFromInstanceIDInternal", 0);
					r_RGetPPtrValueFromInstanceIDInternal.SetBelong(this.instance);
				}
				return r_RGetPPtrValueFromInstanceIDInternal;
			}
		}

		/// <summary>
		/// Void SetPPtrValueFromInstanceIDInternal(Int32)
		/// </summary>
		protected RMethod r_RSetPPtrValueFromInstanceIDInternal_Int32;
		public virtual RMethod RSetPPtrValueFromInstanceIDInternal_Int32
		{
			get
			{
				if(r_RSetPPtrValueFromInstanceIDInternal_Int32 == null)
				{
					r_RSetPPtrValueFromInstanceIDInternal_Int32 = new(this, "SetPPtrValueFromInstanceIDInternal", 0, typeof(System.Int32));
					r_RSetPPtrValueFromInstanceIDInternal_Int32.SetBelong(this.instance);
				}
				return r_RSetPPtrValueFromInstanceIDInternal_Int32;
			}
		}

		/// <summary>
		/// System.String GetPPtrStringValueInternal()
		/// </summary>
		protected RMethod r_RGetPPtrStringValueInternal;
		public virtual RMethod RGetPPtrStringValueInternal
		{
			get
			{
				if(r_RGetPPtrStringValueInternal == null)
				{
					r_RGetPPtrStringValueInternal = new(this, "GetPPtrStringValueInternal", 0);
					r_RGetPPtrStringValueInternal.SetBelong(this.instance);
				}
				return r_RGetPPtrStringValueInternal;
			}
		}

		/// <summary>
		/// Boolean ValidateObjectReferenceValue(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RValidateObjectReferenceValue_Object;
		public virtual RMethod RValidateObjectReferenceValue_Object
		{
			get
			{
				if(r_RValidateObjectReferenceValue_Object == null)
				{
					r_RValidateObjectReferenceValue_Object = new(this, "ValidateObjectReferenceValue", 0, typeof(UnityEngine.Object));
					r_RValidateObjectReferenceValue_Object.SetBelong(this.instance);
				}
				return r_RValidateObjectReferenceValue_Object;
			}
		}

		/// <summary>
		/// Boolean ValidatePPtrValueInternal(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RValidatePPtrValueInternal_Object;
		public virtual RMethod RValidatePPtrValueInternal_Object
		{
			get
			{
				if(r_RValidatePPtrValueInternal_Object == null)
				{
					r_RValidatePPtrValueInternal_Object = new(this, "ValidatePPtrValueInternal", 0, typeof(UnityEngine.Object));
					r_RValidatePPtrValueInternal_Object.SetBelong(this.instance);
				}
				return r_RValidatePPtrValueInternal_Object;
			}
		}

		/// <summary>
		/// Boolean ValidateObjectReferenceValueExact(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RValidateObjectReferenceValueExact_Object;
		public virtual RMethod RValidateObjectReferenceValueExact_Object
		{
			get
			{
				if(r_RValidateObjectReferenceValueExact_Object == null)
				{
					r_RValidateObjectReferenceValueExact_Object = new(this, "ValidateObjectReferenceValueExact", 0, typeof(UnityEngine.Object));
					r_RValidateObjectReferenceValueExact_Object.SetBelong(this.instance);
				}
				return r_RValidateObjectReferenceValueExact_Object;
			}
		}

		/// <summary>
		/// Boolean ValidatePPtrValueExact(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RValidatePPtrValueExact_Object;
		public virtual RMethod RValidatePPtrValueExact_Object
		{
			get
			{
				if(r_RValidatePPtrValueExact_Object == null)
				{
					r_RValidatePPtrValueExact_Object = new(this, "ValidatePPtrValueExact", 0, typeof(UnityEngine.Object));
					r_RValidatePPtrValueExact_Object.SetBelong(this.instance);
				}
				return r_RValidatePPtrValueExact_Object;
			}
		}

		/// <summary>
		/// System.String GetPPtrClassNameInternal()
		/// </summary>
		protected RMethod r_RGetPPtrClassNameInternal;
		public virtual RMethod RGetPPtrClassNameInternal
		{
			get
			{
				if(r_RGetPPtrClassNameInternal == null)
				{
					r_RGetPPtrClassNameInternal = new(this, "GetPPtrClassNameInternal", 0);
					r_RGetPPtrClassNameInternal.SetBelong(this.instance);
				}
				return r_RGetPPtrClassNameInternal;
			}
		}

		/// <summary>
		/// Void AppendFoldoutPPtrValue(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RAppendFoldoutPPtrValue_Object;
		public virtual RMethod RAppendFoldoutPPtrValue_Object
		{
			get
			{
				if(r_RAppendFoldoutPPtrValue_Object == null)
				{
					r_RAppendFoldoutPPtrValue_Object = new(this, "AppendFoldoutPPtrValue", 0, typeof(UnityEngine.Object));
					r_RAppendFoldoutPPtrValue_Object.SetBelong(this.instance);
				}
				return r_RAppendFoldoutPPtrValue_Object;
			}
		}

		/// <summary>
		/// Void AppendFoldoutPPtrValueInternal(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RAppendFoldoutPPtrValueInternal_Object;
		public virtual RMethod RAppendFoldoutPPtrValueInternal_Object
		{
			get
			{
				if(r_RAppendFoldoutPPtrValueInternal_Object == null)
				{
					r_RAppendFoldoutPPtrValueInternal_Object = new(this, "AppendFoldoutPPtrValueInternal", 0, typeof(UnityEngine.Object));
					r_RAppendFoldoutPPtrValueInternal_Object.SetBelong(this.instance);
				}
				return r_RAppendFoldoutPPtrValueInternal_Object;
			}
		}

		/// <summary>
		/// System.String GetLayerMaskStringValue(UInt32)
		/// </summary>
		protected static RMethod r_RGetLayerMaskStringValue_UInt32;
		public static RMethod RGetLayerMaskStringValue_UInt32
		{
			get
			{
				if(r_RGetLayerMaskStringValue_UInt32 == null)
				{
					r_RGetLayerMaskStringValue_UInt32 = new(typeof(UnityEditor.SerializedProperty), "GetLayerMaskStringValue", 0, typeof(System.UInt32));
					r_RGetLayerMaskStringValue_UInt32.SetBelong(null);
				}
				return r_RGetLayerMaskStringValue_UInt32;
			}
		}

		/// <summary>
		/// UInt32 GetLayerMaskBitsInternal()
		/// </summary>
		protected RMethod r_RGetLayerMaskBitsInternal;
		public virtual RMethod RGetLayerMaskBitsInternal
		{
			get
			{
				if(r_RGetLayerMaskBitsInternal == null)
				{
					r_RGetLayerMaskBitsInternal = new(this, "GetLayerMaskBitsInternal", 0);
					r_RGetLayerMaskBitsInternal.SetBelong(this.instance);
				}
				return r_RGetLayerMaskBitsInternal;
			}
		}

		/// <summary>
		/// Int32 GetEnumValueIndexInternal()
		/// </summary>
		protected RMethod r_RGetEnumValueIndexInternal;
		public virtual RMethod RGetEnumValueIndexInternal
		{
			get
			{
				if(r_RGetEnumValueIndexInternal == null)
				{
					r_RGetEnumValueIndexInternal = new(this, "GetEnumValueIndexInternal", 0);
					r_RGetEnumValueIndexInternal.SetBelong(this.instance);
				}
				return r_RGetEnumValueIndexInternal;
			}
		}

		/// <summary>
		/// Void SetEnumValueIndexInternal(Int32)
		/// </summary>
		protected RMethod r_RSetEnumValueIndexInternal_Int32;
		public virtual RMethod RSetEnumValueIndexInternal_Int32
		{
			get
			{
				if(r_RSetEnumValueIndexInternal_Int32 == null)
				{
					r_RSetEnumValueIndexInternal_Int32 = new(this, "SetEnumValueIndexInternal", 0, typeof(System.Int32));
					r_RSetEnumValueIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_RSetEnumValueIndexInternal_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNamesInternal(Boolean)
		/// </summary>
		protected RMethod r_RGetEnumNamesInternal_Boolean;
		public virtual RMethod RGetEnumNamesInternal_Boolean
		{
			get
			{
				if(r_RGetEnumNamesInternal_Boolean == null)
				{
					r_RGetEnumNamesInternal_Boolean = new(this, "GetEnumNamesInternal", 0, typeof(System.Boolean));
					r_RGetEnumNamesInternal_Boolean.SetBelong(this.instance);
				}
				return r_RGetEnumNamesInternal_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetValueVector2Internal()
		/// </summary>
		protected RMethod r_RGetValueVector2Internal;
		public virtual RMethod RGetValueVector2Internal
		{
			get
			{
				if(r_RGetValueVector2Internal == null)
				{
					r_RGetValueVector2Internal = new(this, "GetValueVector2Internal", 0);
					r_RGetValueVector2Internal.SetBelong(this.instance);
				}
				return r_RGetValueVector2Internal;
			}
		}

		/// <summary>
		/// Void SetValueVector2Internal(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetValueVector2Internal_Vector2;
		public virtual RMethod RSetValueVector2Internal_Vector2
		{
			get
			{
				if(r_RSetValueVector2Internal_Vector2 == null)
				{
					r_RSetValueVector2Internal_Vector2 = new(this, "SetValueVector2Internal", 0, typeof(UnityEngine.Vector2));
					r_RSetValueVector2Internal_Vector2.SetBelong(this.instance);
				}
				return r_RSetValueVector2Internal_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetValueVector3Internal()
		/// </summary>
		protected RMethod r_RGetValueVector3Internal;
		public virtual RMethod RGetValueVector3Internal
		{
			get
			{
				if(r_RGetValueVector3Internal == null)
				{
					r_RGetValueVector3Internal = new(this, "GetValueVector3Internal", 0);
					r_RGetValueVector3Internal.SetBelong(this.instance);
				}
				return r_RGetValueVector3Internal;
			}
		}

		/// <summary>
		/// Void SetValueVector3Internal(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetValueVector3Internal_Vector3;
		public virtual RMethod RSetValueVector3Internal_Vector3
		{
			get
			{
				if(r_RSetValueVector3Internal_Vector3 == null)
				{
					r_RSetValueVector3Internal_Vector3 = new(this, "SetValueVector3Internal", 0, typeof(UnityEngine.Vector3));
					r_RSetValueVector3Internal_Vector3.SetBelong(this.instance);
				}
				return r_RSetValueVector3Internal_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetValueVector4Internal()
		/// </summary>
		protected RMethod r_RGetValueVector4Internal;
		public virtual RMethod RGetValueVector4Internal
		{
			get
			{
				if(r_RGetValueVector4Internal == null)
				{
					r_RGetValueVector4Internal = new(this, "GetValueVector4Internal", 0);
					r_RGetValueVector4Internal.SetBelong(this.instance);
				}
				return r_RGetValueVector4Internal;
			}
		}

		/// <summary>
		/// Void SetValueVector4Internal(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetValueVector4Internal_Vector4;
		public virtual RMethod RSetValueVector4Internal_Vector4
		{
			get
			{
				if(r_RSetValueVector4Internal_Vector4 == null)
				{
					r_RSetValueVector4Internal_Vector4 = new(this, "SetValueVector4Internal", 0, typeof(UnityEngine.Vector4));
					r_RSetValueVector4Internal_Vector4.SetBelong(this.instance);
				}
				return r_RSetValueVector4Internal_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int GetValueVector2IntInternal()
		/// </summary>
		protected RMethod r_RGetValueVector2IntInternal;
		public virtual RMethod RGetValueVector2IntInternal
		{
			get
			{
				if(r_RGetValueVector2IntInternal == null)
				{
					r_RGetValueVector2IntInternal = new(this, "GetValueVector2IntInternal", 0);
					r_RGetValueVector2IntInternal.SetBelong(this.instance);
				}
				return r_RGetValueVector2IntInternal;
			}
		}

		/// <summary>
		/// Void SetValueVector2IntInternal(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_RSetValueVector2IntInternal_Vector2Int;
		public virtual RMethod RSetValueVector2IntInternal_Vector2Int
		{
			get
			{
				if(r_RSetValueVector2IntInternal_Vector2Int == null)
				{
					r_RSetValueVector2IntInternal_Vector2Int = new(this, "SetValueVector2IntInternal", 0, typeof(UnityEngine.Vector2Int));
					r_RSetValueVector2IntInternal_Vector2Int.SetBelong(this.instance);
				}
				return r_RSetValueVector2IntInternal_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int GetValueVector3IntInternal()
		/// </summary>
		protected RMethod r_RGetValueVector3IntInternal;
		public virtual RMethod RGetValueVector3IntInternal
		{
			get
			{
				if(r_RGetValueVector3IntInternal == null)
				{
					r_RGetValueVector3IntInternal = new(this, "GetValueVector3IntInternal", 0);
					r_RGetValueVector3IntInternal.SetBelong(this.instance);
				}
				return r_RGetValueVector3IntInternal;
			}
		}

		/// <summary>
		/// Void SetValueVector3IntInternal(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_RSetValueVector3IntInternal_Vector3Int;
		public virtual RMethod RSetValueVector3IntInternal_Vector3Int
		{
			get
			{
				if(r_RSetValueVector3IntInternal_Vector3Int == null)
				{
					r_RSetValueVector3IntInternal_Vector3Int = new(this, "SetValueVector3IntInternal", 0, typeof(UnityEngine.Vector3Int));
					r_RSetValueVector3IntInternal_Vector3Int.SetBelong(this.instance);
				}
				return r_RSetValueVector3IntInternal_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion GetValueQuaternionInternal()
		/// </summary>
		protected RMethod r_RGetValueQuaternionInternal;
		public virtual RMethod RGetValueQuaternionInternal
		{
			get
			{
				if(r_RGetValueQuaternionInternal == null)
				{
					r_RGetValueQuaternionInternal = new(this, "GetValueQuaternionInternal", 0);
					r_RGetValueQuaternionInternal.SetBelong(this.instance);
				}
				return r_RGetValueQuaternionInternal;
			}
		}

		/// <summary>
		/// Void SetValueQuaternionInternal(UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_RSetValueQuaternionInternal_Quaternion;
		public virtual RMethod RSetValueQuaternionInternal_Quaternion
		{
			get
			{
				if(r_RSetValueQuaternionInternal_Quaternion == null)
				{
					r_RSetValueQuaternionInternal_Quaternion = new(this, "SetValueQuaternionInternal", 0, typeof(UnityEngine.Quaternion));
					r_RSetValueQuaternionInternal_Quaternion.SetBelong(this.instance);
				}
				return r_RSetValueQuaternionInternal_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetValueRectInternal()
		/// </summary>
		protected RMethod r_RGetValueRectInternal;
		public virtual RMethod RGetValueRectInternal
		{
			get
			{
				if(r_RGetValueRectInternal == null)
				{
					r_RGetValueRectInternal = new(this, "GetValueRectInternal", 0);
					r_RGetValueRectInternal.SetBelong(this.instance);
				}
				return r_RGetValueRectInternal;
			}
		}

		/// <summary>
		/// Void SetValueRectInternal(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetValueRectInternal_Rect;
		public virtual RMethod RSetValueRectInternal_Rect
		{
			get
			{
				if(r_RSetValueRectInternal_Rect == null)
				{
					r_RSetValueRectInternal_Rect = new(this, "SetValueRectInternal", 0, typeof(UnityEngine.Rect));
					r_RSetValueRectInternal_Rect.SetBelong(this.instance);
				}
				return r_RSetValueRectInternal_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt GetValueRectIntInternal()
		/// </summary>
		protected RMethod r_RGetValueRectIntInternal;
		public virtual RMethod RGetValueRectIntInternal
		{
			get
			{
				if(r_RGetValueRectIntInternal == null)
				{
					r_RGetValueRectIntInternal = new(this, "GetValueRectIntInternal", 0);
					r_RGetValueRectIntInternal.SetBelong(this.instance);
				}
				return r_RGetValueRectIntInternal;
			}
		}

		/// <summary>
		/// Void SetValueRectIntInternal(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_RSetValueRectIntInternal_RectInt;
		public virtual RMethod RSetValueRectIntInternal_RectInt
		{
			get
			{
				if(r_RSetValueRectIntInternal_RectInt == null)
				{
					r_RSetValueRectIntInternal_RectInt = new(this, "SetValueRectIntInternal", 0, typeof(UnityEngine.RectInt));
					r_RSetValueRectIntInternal_RectInt.SetBelong(this.instance);
				}
				return r_RSetValueRectIntInternal_RectInt;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds GetValueBoundsInternal()
		/// </summary>
		protected RMethod r_RGetValueBoundsInternal;
		public virtual RMethod RGetValueBoundsInternal
		{
			get
			{
				if(r_RGetValueBoundsInternal == null)
				{
					r_RGetValueBoundsInternal = new(this, "GetValueBoundsInternal", 0);
					r_RGetValueBoundsInternal.SetBelong(this.instance);
				}
				return r_RGetValueBoundsInternal;
			}
		}

		/// <summary>
		/// Void SetValueBoundsInternal(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_RSetValueBoundsInternal_Bounds;
		public virtual RMethod RSetValueBoundsInternal_Bounds
		{
			get
			{
				if(r_RSetValueBoundsInternal_Bounds == null)
				{
					r_RSetValueBoundsInternal_Bounds = new(this, "SetValueBoundsInternal", 0, typeof(UnityEngine.Bounds));
					r_RSetValueBoundsInternal_Bounds.SetBelong(this.instance);
				}
				return r_RSetValueBoundsInternal_Bounds;
			}
		}

		/// <summary>
		/// UnityEngine.BoundsInt GetValueBoundsIntInternal()
		/// </summary>
		protected RMethod r_RGetValueBoundsIntInternal;
		public virtual RMethod RGetValueBoundsIntInternal
		{
			get
			{
				if(r_RGetValueBoundsIntInternal == null)
				{
					r_RGetValueBoundsIntInternal = new(this, "GetValueBoundsIntInternal", 0);
					r_RGetValueBoundsIntInternal.SetBelong(this.instance);
				}
				return r_RGetValueBoundsIntInternal;
			}
		}

		/// <summary>
		/// Void SetValueBoundsIntInternal(UnityEngine.BoundsInt)
		/// </summary>
		protected RMethod r_RSetValueBoundsIntInternal_BoundsInt;
		public virtual RMethod RSetValueBoundsIntInternal_BoundsInt
		{
			get
			{
				if(r_RSetValueBoundsIntInternal_BoundsInt == null)
				{
					r_RSetValueBoundsIntInternal_BoundsInt = new(this, "SetValueBoundsIntInternal", 0, typeof(UnityEngine.BoundsInt));
					r_RSetValueBoundsIntInternal_BoundsInt.SetBelong(this.instance);
				}
				return r_RSetValueBoundsIntInternal_BoundsInt;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 GetHash128ValueInternal()
		/// </summary>
		protected RMethod r_RGetHash128ValueInternal;
		public virtual RMethod RGetHash128ValueInternal
		{
			get
			{
				if(r_RGetHash128ValueInternal == null)
				{
					r_RGetHash128ValueInternal = new(this, "GetHash128ValueInternal", 0);
					r_RGetHash128ValueInternal.SetBelong(this.instance);
				}
				return r_RGetHash128ValueInternal;
			}
		}

		/// <summary>
		/// Void SetHash128ValueInternal(UnityEngine.Hash128)
		/// </summary>
		protected RMethod r_RSetHash128ValueInternal_Hash128;
		public virtual RMethod RSetHash128ValueInternal_Hash128
		{
			get
			{
				if(r_RSetHash128ValueInternal_Hash128 == null)
				{
					r_RSetHash128ValueInternal_Hash128 = new(this, "SetHash128ValueInternal", 0, typeof(UnityEngine.Hash128));
					r_RSetHash128ValueInternal_Hash128.SetBelong(this.instance);
				}
				return r_RSetHash128ValueInternal_Hash128;
			}
		}

		/// <summary>
		/// Boolean Next(Boolean)
		/// </summary>
		protected RMethod r_RNext_Boolean;
		public virtual RMethod RNext_Boolean
		{
			get
			{
				if(r_RNext_Boolean == null)
				{
					r_RNext_Boolean = new(this, "Next", 0, typeof(System.Boolean));
					r_RNext_Boolean.SetBelong(this.instance);
				}
				return r_RNext_Boolean;
			}
		}

		/// <summary>
		/// Boolean NextInternal(Boolean)
		/// </summary>
		protected RMethod r_RNextInternal_Boolean;
		public virtual RMethod RNextInternal_Boolean
		{
			get
			{
				if(r_RNextInternal_Boolean == null)
				{
					r_RNextInternal_Boolean = new(this, "NextInternal", 0, typeof(System.Boolean));
					r_RNextInternal_Boolean.SetBelong(this.instance);
				}
				return r_RNextInternal_Boolean;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void ResetInternal()
		/// </summary>
		protected RMethod r_RResetInternal;
		public virtual RMethod RResetInternal
		{
			get
			{
				if(r_RResetInternal == null)
				{
					r_RResetInternal = new(this, "ResetInternal", 0);
					r_RResetInternal.SetBelong(this.instance);
				}
				return r_RResetInternal;
			}
		}

		/// <summary>
		/// Int32 CountRemaining()
		/// </summary>
		protected RMethod r_RCountRemaining;
		public virtual RMethod RCountRemaining
		{
			get
			{
				if(r_RCountRemaining == null)
				{
					r_RCountRemaining = new(this, "CountRemaining", 0);
					r_RCountRemaining.SetBelong(this.instance);
				}
				return r_RCountRemaining;
			}
		}

		/// <summary>
		/// Int32 CountRemainingInternal()
		/// </summary>
		protected RMethod r_RCountRemainingInternal;
		public virtual RMethod RCountRemainingInternal
		{
			get
			{
				if(r_RCountRemainingInternal == null)
				{
					r_RCountRemainingInternal = new(this, "CountRemainingInternal", 0);
					r_RCountRemainingInternal.SetBelong(this.instance);
				}
				return r_RCountRemainingInternal;
			}
		}

		/// <summary>
		/// Int32 CountInProperty()
		/// </summary>
		protected RMethod r_RCountInProperty;
		public virtual RMethod RCountInProperty
		{
			get
			{
				if(r_RCountInProperty == null)
				{
					r_RCountInProperty = new(this, "CountInProperty", 0);
					r_RCountInProperty.SetBelong(this.instance);
				}
				return r_RCountInProperty;
			}
		}

		/// <summary>
		/// Int32 CountInPropertyInternal()
		/// </summary>
		protected RMethod r_RCountInPropertyInternal;
		public virtual RMethod RCountInPropertyInternal
		{
			get
			{
				if(r_RCountInPropertyInternal == null)
				{
					r_RCountInPropertyInternal = new(this, "CountInPropertyInternal", 0);
					r_RCountInPropertyInternal.SetBelong(this.instance);
				}
				return r_RCountInPropertyInternal;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty CopyInternal()
		/// </summary>
		protected RMethod r_RCopyInternal;
		public virtual RMethod RCopyInternal
		{
			get
			{
				if(r_RCopyInternal == null)
				{
					r_RCopyInternal = new(this, "CopyInternal", 0);
					r_RCopyInternal.SetBelong(this.instance);
				}
				return r_RCopyInternal;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty CopyInternalImpl()
		/// </summary>
		protected RMethod r_RCopyInternalImpl;
		public virtual RMethod RCopyInternalImpl
		{
			get
			{
				if(r_RCopyInternalImpl == null)
				{
					r_RCopyInternalImpl = new(this, "CopyInternalImpl", 0);
					r_RCopyInternalImpl.SetBelong(this.instance);
				}
				return r_RCopyInternalImpl;
			}
		}

		/// <summary>
		/// Boolean DuplicateCommand()
		/// </summary>
		protected RMethod r_RDuplicateCommand;
		public virtual RMethod RDuplicateCommand
		{
			get
			{
				if(r_RDuplicateCommand == null)
				{
					r_RDuplicateCommand = new(this, "DuplicateCommand", 0);
					r_RDuplicateCommand.SetBelong(this.instance);
				}
				return r_RDuplicateCommand;
			}
		}

		/// <summary>
		/// Boolean DuplicateCommandInternal()
		/// </summary>
		protected RMethod r_RDuplicateCommandInternal;
		public virtual RMethod RDuplicateCommandInternal
		{
			get
			{
				if(r_RDuplicateCommandInternal == null)
				{
					r_RDuplicateCommandInternal = new(this, "DuplicateCommandInternal", 0);
					r_RDuplicateCommandInternal.SetBelong(this.instance);
				}
				return r_RDuplicateCommandInternal;
			}
		}

		/// <summary>
		/// Boolean DeleteCommand()
		/// </summary>
		protected RMethod r_RDeleteCommand;
		public virtual RMethod RDeleteCommand
		{
			get
			{
				if(r_RDeleteCommand == null)
				{
					r_RDeleteCommand = new(this, "DeleteCommand", 0);
					r_RDeleteCommand.SetBelong(this.instance);
				}
				return r_RDeleteCommand;
			}
		}

		/// <summary>
		/// Boolean DeleteCommandInternal()
		/// </summary>
		protected RMethod r_RDeleteCommandInternal;
		public virtual RMethod RDeleteCommandInternal
		{
			get
			{
				if(r_RDeleteCommandInternal == null)
				{
					r_RDeleteCommandInternal = new(this, "DeleteCommandInternal", 0);
					r_RDeleteCommandInternal.SetBelong(this.instance);
				}
				return r_RDeleteCommandInternal;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetEndProperty()
		/// </summary>
		protected RMethod r_RGetEndProperty;
		public virtual RMethod RGetEndProperty
		{
			get
			{
				if(r_RGetEndProperty == null)
				{
					r_RGetEndProperty = new(this, "GetEndProperty", 0);
					r_RGetEndProperty.SetBelong(this.instance);
				}
				return r_RGetEndProperty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetEndProperty(Boolean)
		/// </summary>
		protected RMethod r_RGetEndProperty_Boolean;
		public virtual RMethod RGetEndProperty_Boolean
		{
			get
			{
				if(r_RGetEndProperty_Boolean == null)
				{
					r_RGetEndProperty_Boolean = new(this, "GetEndProperty", 0, typeof(System.Boolean));
					r_RGetEndProperty_Boolean.SetBelong(this.instance);
				}
				return r_RGetEndProperty_Boolean;
			}
		}

		/// <summary>
		/// Boolean FindPropertyRelativeInternal(System.String)
		/// </summary>
		protected RMethod r_RFindPropertyRelativeInternal_String;
		public virtual RMethod RFindPropertyRelativeInternal_String
		{
			get
			{
				if(r_RFindPropertyRelativeInternal_String == null)
				{
					r_RFindPropertyRelativeInternal_String = new(this, "FindPropertyRelativeInternal", 0, typeof(System.String));
					r_RFindPropertyRelativeInternal_String.SetBelong(this.instance);
				}
				return r_RFindPropertyRelativeInternal_String;
			}
		}

		/// <summary>
		/// Boolean FindRelativeProperty(System.String)
		/// </summary>
		protected RMethod r_RFindRelativeProperty_String;
		public virtual RMethod RFindRelativeProperty_String
		{
			get
			{
				if(r_RFindRelativeProperty_String == null)
				{
					r_RFindRelativeProperty_String = new(this, "FindRelativeProperty", 0, typeof(System.String));
					r_RFindRelativeProperty_String.SetBelong(this.instance);
				}
				return r_RFindRelativeProperty_String;
			}
		}

		/// <summary>
		/// Boolean IsArray()
		/// </summary>
		protected RMethod r_RIsArray;
		public virtual RMethod RIsArray
		{
			get
			{
				if(r_RIsArray == null)
				{
					r_RIsArray = new(this, "IsArray", 0);
					r_RIsArray.SetBelong(this.instance);
				}
				return r_RIsArray;
			}
		}

		/// <summary>
		/// Int32 GetMinArraySize()
		/// </summary>
		protected RMethod r_RGetMinArraySize;
		public virtual RMethod RGetMinArraySize
		{
			get
			{
				if(r_RGetMinArraySize == null)
				{
					r_RGetMinArraySize = new(this, "GetMinArraySize", 0);
					r_RGetMinArraySize.SetBelong(this.instance);
				}
				return r_RGetMinArraySize;
			}
		}

		/// <summary>
		/// Int32 GetInspectableArraySize()
		/// </summary>
		protected RMethod r_RGetInspectableArraySize;
		public virtual RMethod RGetInspectableArraySize
		{
			get
			{
				if(r_RGetInspectableArraySize == null)
				{
					r_RGetInspectableArraySize = new(this, "GetInspectableArraySize", 0);
					r_RGetInspectableArraySize.SetBelong(this.instance);
				}
				return r_RGetInspectableArraySize;
			}
		}

		/// <summary>
		/// Void ResizeArray(Int32)
		/// </summary>
		protected RMethod r_RResizeArray_Int32;
		public virtual RMethod RResizeArray_Int32
		{
			get
			{
				if(r_RResizeArray_Int32 == null)
				{
					r_RResizeArray_Int32 = new(this, "ResizeArray", 0, typeof(System.Int32));
					r_RResizeArray_Int32.SetBelong(this.instance);
				}
				return r_RResizeArray_Int32;
			}
		}

		/// <summary>
		/// Boolean GetArrayElementAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_RGetArrayElementAtIndexInternal_Int32;
		public virtual RMethod RGetArrayElementAtIndexInternal_Int32
		{
			get
			{
				if(r_RGetArrayElementAtIndexInternal_Int32 == null)
				{
					r_RGetArrayElementAtIndexInternal_Int32 = new(this, "GetArrayElementAtIndexInternal", 0, typeof(System.Int32));
					r_RGetArrayElementAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_RGetArrayElementAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean GetArrayElementAtIndexImpl(Int32)
		/// </summary>
		protected RMethod r_RGetArrayElementAtIndexImpl_Int32;
		public virtual RMethod RGetArrayElementAtIndexImpl_Int32
		{
			get
			{
				if(r_RGetArrayElementAtIndexImpl_Int32 == null)
				{
					r_RGetArrayElementAtIndexImpl_Int32 = new(this, "GetArrayElementAtIndexImpl", 0, typeof(System.Int32));
					r_RGetArrayElementAtIndexImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetArrayElementAtIndexImpl_Int32;
			}
		}

		/// <summary>
		/// Void InsertArrayElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_RInsertArrayElementAtIndex_Int32;
		public virtual RMethod RInsertArrayElementAtIndex_Int32
		{
			get
			{
				if(r_RInsertArrayElementAtIndex_Int32 == null)
				{
					r_RInsertArrayElementAtIndex_Int32 = new(this, "InsertArrayElementAtIndex", 0, typeof(System.Int32));
					r_RInsertArrayElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RInsertArrayElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void InsertArrayElementAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_RInsertArrayElementAtIndexInternal_Int32;
		public virtual RMethod RInsertArrayElementAtIndexInternal_Int32
		{
			get
			{
				if(r_RInsertArrayElementAtIndexInternal_Int32 == null)
				{
					r_RInsertArrayElementAtIndexInternal_Int32 = new(this, "InsertArrayElementAtIndexInternal", 0, typeof(System.Int32));
					r_RInsertArrayElementAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_RInsertArrayElementAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Void DeleteArrayElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_RDeleteArrayElementAtIndex_Int32;
		public virtual RMethod RDeleteArrayElementAtIndex_Int32
		{
			get
			{
				if(r_RDeleteArrayElementAtIndex_Int32 == null)
				{
					r_RDeleteArrayElementAtIndex_Int32 = new(this, "DeleteArrayElementAtIndex", 0, typeof(System.Int32));
					r_RDeleteArrayElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RDeleteArrayElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void DeleteArrayElementAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_RDeleteArrayElementAtIndexInternal_Int32;
		public virtual RMethod RDeleteArrayElementAtIndexInternal_Int32
		{
			get
			{
				if(r_RDeleteArrayElementAtIndexInternal_Int32 == null)
				{
					r_RDeleteArrayElementAtIndexInternal_Int32 = new(this, "DeleteArrayElementAtIndexInternal", 0, typeof(System.Int32));
					r_RDeleteArrayElementAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_RDeleteArrayElementAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveArrayElement(Int32, Int32)
		/// </summary>
		protected RMethod r_RMoveArrayElement_Int32_Int32;
		public virtual RMethod RMoveArrayElement_Int32_Int32
		{
			get
			{
				if(r_RMoveArrayElement_Int32_Int32 == null)
				{
					r_RMoveArrayElement_Int32_Int32 = new(this, "MoveArrayElement", 0, typeof(System.Int32), typeof(System.Int32));
					r_RMoveArrayElement_Int32_Int32.SetBelong(this.instance);
				}
				return r_RMoveArrayElement_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveArrayElementInternal(Int32, Int32)
		/// </summary>
		protected RMethod r_RMoveArrayElementInternal_Int32_Int32;
		public virtual RMethod RMoveArrayElementInternal_Int32_Int32
		{
			get
			{
				if(r_RMoveArrayElementInternal_Int32_Int32 == null)
				{
					r_RMoveArrayElementInternal_Int32_Int32 = new(this, "MoveArrayElementInternal", 0, typeof(System.Int32), typeof(System.Int32));
					r_RMoveArrayElementInternal_Int32_Int32.SetBelong(this.instance);
				}
				return r_RMoveArrayElementInternal_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsFixedBuffer()
		/// </summary>
		protected RMethod r_RIsFixedBuffer;
		public virtual RMethod RIsFixedBuffer
		{
			get
			{
				if(r_RIsFixedBuffer == null)
				{
					r_RIsFixedBuffer = new(this, "IsFixedBuffer", 0);
					r_RIsFixedBuffer.SetBelong(this.instance);
				}
				return r_RIsFixedBuffer;
			}
		}

		/// <summary>
		/// Int32 GetFixedBufferSize()
		/// </summary>
		protected RMethod r_RGetFixedBufferSize;
		public virtual RMethod RGetFixedBufferSize
		{
			get
			{
				if(r_RGetFixedBufferSize == null)
				{
					r_RGetFixedBufferSize = new(this, "GetFixedBufferSize", 0);
					r_RGetFixedBufferSize.SetBelong(this.instance);
				}
				return r_RGetFixedBufferSize;
			}
		}

		/// <summary>
		/// Boolean GetIsValidDisplayNameCache()
		/// </summary>
		protected RMethod r_RGetIsValidDisplayNameCache;
		public virtual RMethod RGetIsValidDisplayNameCache
		{
			get
			{
				if(r_RGetIsValidDisplayNameCache == null)
				{
					r_RGetIsValidDisplayNameCache = new(this, "GetIsValidDisplayNameCache", 0);
					r_RGetIsValidDisplayNameCache.SetBelong(this.instance);
				}
				return r_RGetIsValidDisplayNameCache;
			}
		}

		/// <summary>
		/// Void SetIsValidDisplayNameCache(Boolean)
		/// </summary>
		protected RMethod r_RSetIsValidDisplayNameCache_Boolean;
		public virtual RMethod RSetIsValidDisplayNameCache_Boolean
		{
			get
			{
				if(r_RSetIsValidDisplayNameCache_Boolean == null)
				{
					r_RSetIsValidDisplayNameCache_Boolean = new(this, "SetIsValidDisplayNameCache", 0, typeof(System.Boolean));
					r_RSetIsValidDisplayNameCache_Boolean.SetBelong(this.instance);
				}
				return r_RSetIsValidDisplayNameCache_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetIsValidTooltipCache()
		/// </summary>
		protected RMethod r_RGetIsValidTooltipCache;
		public virtual RMethod RGetIsValidTooltipCache
		{
			get
			{
				if(r_RGetIsValidTooltipCache == null)
				{
					r_RGetIsValidTooltipCache = new(this, "GetIsValidTooltipCache", 0);
					r_RGetIsValidTooltipCache.SetBelong(this.instance);
				}
				return r_RGetIsValidTooltipCache;
			}
		}

		/// <summary>
		/// Void SetIsValidTooltipCache(Boolean)
		/// </summary>
		protected RMethod r_RSetIsValidTooltipCache_Boolean;
		public virtual RMethod RSetIsValidTooltipCache_Boolean
		{
			get
			{
				if(r_RSetIsValidTooltipCache_Boolean == null)
				{
					r_RSetIsValidTooltipCache_Boolean = new(this, "SetIsValidTooltipCache", 0, typeof(System.Boolean));
					r_RSetIsValidTooltipCache_Boolean.SetBelong(this.instance);
				}
				return r_RSetIsValidTooltipCache_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetFixedBufferElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_RGetFixedBufferElementAtIndex_Int32;
		public virtual RMethod RGetFixedBufferElementAtIndex_Int32
		{
			get
			{
				if(r_RGetFixedBufferElementAtIndex_Int32 == null)
				{
					r_RGetFixedBufferElementAtIndex_Int32 = new(this, "GetFixedBufferElementAtIndex", 0, typeof(System.Int32));
					r_RGetFixedBufferElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetFixedBufferElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean GetFixedBufferAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_RGetFixedBufferAtIndexInternal_Int32;
		public virtual RMethod RGetFixedBufferAtIndexInternal_Int32
		{
			get
			{
				if(r_RGetFixedBufferAtIndexInternal_Int32 == null)
				{
					r_RGetFixedBufferAtIndexInternal_Int32 = new(this, "GetFixedBufferAtIndexInternal", 0, typeof(System.Int32));
					r_RGetFixedBufferAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_RGetFixedBufferAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean AnimationCurveValueEquals(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_RAnimationCurveValueEquals_AnimationCurve;
		public virtual RMethod RAnimationCurveValueEquals_AnimationCurve
		{
			get
			{
				if(r_RAnimationCurveValueEquals_AnimationCurve == null)
				{
					r_RAnimationCurveValueEquals_AnimationCurve = new(this, "AnimationCurveValueEquals", 0, typeof(UnityEngine.AnimationCurve));
					r_RAnimationCurveValueEquals_AnimationCurve.SetBelong(this.instance);
				}
				return r_RAnimationCurveValueEquals_AnimationCurve;
			}
		}

		/// <summary>
		/// Boolean ValueEquals(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_RValueEquals_AnimationCurve;
		public virtual RMethod RValueEquals_AnimationCurve
		{
			get
			{
				if(r_RValueEquals_AnimationCurve == null)
				{
					r_RValueEquals_AnimationCurve = new(this, "ValueEquals", 0, typeof(UnityEngine.AnimationCurve));
					r_RValueEquals_AnimationCurve.SetBelong(this.instance);
				}
				return r_RValueEquals_AnimationCurve;
			}
		}

		/// <summary>
		/// Boolean GradientValueEquals(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_RGradientValueEquals_Gradient;
		public virtual RMethod RGradientValueEquals_Gradient
		{
			get
			{
				if(r_RGradientValueEquals_Gradient == null)
				{
					r_RGradientValueEquals_Gradient = new(this, "GradientValueEquals", 0, typeof(UnityEngine.Gradient));
					r_RGradientValueEquals_Gradient.SetBelong(this.instance);
				}
				return r_RGradientValueEquals_Gradient;
			}
		}

		/// <summary>
		/// Boolean ValueEquals(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_RValueEquals_Gradient;
		public virtual RMethod RValueEquals_Gradient
		{
			get
			{
				if(r_RValueEquals_Gradient == null)
				{
					r_RValueEquals_Gradient = new(this, "ValueEquals", 0, typeof(UnityEngine.Gradient));
					r_RValueEquals_Gradient.SetBelong(this.instance);
				}
				return r_RValueEquals_Gradient;
			}
		}

		/// <summary>
		/// Boolean StringValueEquals(System.String)
		/// </summary>
		protected RMethod r_RStringValueEquals_String;
		public virtual RMethod RStringValueEquals_String
		{
			get
			{
				if(r_RStringValueEquals_String == null)
				{
					r_RStringValueEquals_String = new(this, "StringValueEquals", 0, typeof(System.String));
					r_RStringValueEquals_String.SetBelong(this.instance);
				}
				return r_RStringValueEquals_String;
			}
		}

		/// <summary>
		/// Boolean ValueEquals(System.String)
		/// </summary>
		protected RMethod r_RValueEquals_String;
		public virtual RMethod RValueEquals_String
		{
			get
			{
				if(r_RValueEquals_String == null)
				{
					r_RValueEquals_String = new(this, "ValueEquals", 0, typeof(System.String));
					r_RValueEquals_String.SetBelong(this.instance);
				}
				return r_RValueEquals_String;
			}
		}

		/// <summary>
		/// Boolean IsValidInternal()
		/// </summary>
		protected RMethod r_RIsValidInternal;
		public virtual RMethod RIsValidInternal
		{
			get
			{
				if(r_RIsValidInternal == null)
				{
					r_RIsValidInternal = new(this, "IsValidInternal", 0);
					r_RIsValidInternal.SetBelong(this.instance);
				}
				return r_RIsValidInternal;
			}
		}

		/// <summary>
		/// UInt32 GetContentHashInternal()
		/// </summary>
		protected RMethod r_RGetContentHashInternal;
		public virtual RMethod RGetContentHashInternal
		{
			get
			{
				if(r_RGetContentHashInternal == null)
				{
					r_RGetContentHashInternal = new(this, "GetContentHashInternal", 0);
					r_RGetContentHashInternal.SetBelong(this.instance);
				}
				return r_RGetContentHashInternal;
			}
		}

		/// <summary>
		/// Void GetColorValueInternal_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RGetColorValueInternal_Injected_Out_Color;
		public virtual RMethod RGetColorValueInternal_Injected_Out_Color
		{
			get
			{
				if(r_RGetColorValueInternal_Injected_Out_Color == null)
				{
					r_RGetColorValueInternal_Injected_Out_Color = new(this, "GetColorValueInternal_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_RGetColorValueInternal_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_RGetColorValueInternal_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void SetColorValueInternal_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RSetColorValueInternal_Injected_Ref_Color;
		public virtual RMethod RSetColorValueInternal_Injected_Ref_Color
		{
			get
			{
				if(r_RSetColorValueInternal_Injected_Ref_Color == null)
				{
					r_RSetColorValueInternal_Injected_Ref_Color = new(this, "SetColorValueInternal_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_RSetColorValueInternal_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_RSetColorValueInternal_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void GetValueVector2Internal_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RGetValueVector2Internal_Injected_Out_Vector2;
		public virtual RMethod RGetValueVector2Internal_Injected_Out_Vector2
		{
			get
			{
				if(r_RGetValueVector2Internal_Injected_Out_Vector2 == null)
				{
					r_RGetValueVector2Internal_Injected_Out_Vector2 = new(this, "GetValueVector2Internal_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_RGetValueVector2Internal_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_RGetValueVector2Internal_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void SetValueVector2Internal_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RSetValueVector2Internal_Injected_Ref_Vector2;
		public virtual RMethod RSetValueVector2Internal_Injected_Ref_Vector2
		{
			get
			{
				if(r_RSetValueVector2Internal_Injected_Ref_Vector2 == null)
				{
					r_RSetValueVector2Internal_Injected_Ref_Vector2 = new(this, "SetValueVector2Internal_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_RSetValueVector2Internal_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RSetValueVector2Internal_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void GetValueVector3Internal_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetValueVector3Internal_Injected_Out_Vector3;
		public virtual RMethod RGetValueVector3Internal_Injected_Out_Vector3
		{
			get
			{
				if(r_RGetValueVector3Internal_Injected_Out_Vector3 == null)
				{
					r_RGetValueVector3Internal_Injected_Out_Vector3 = new(this, "GetValueVector3Internal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetValueVector3Internal_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetValueVector3Internal_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SetValueVector3Internal_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RSetValueVector3Internal_Injected_Ref_Vector3;
		public virtual RMethod RSetValueVector3Internal_Injected_Ref_Vector3
		{
			get
			{
				if(r_RSetValueVector3Internal_Injected_Ref_Vector3 == null)
				{
					r_RSetValueVector3Internal_Injected_Ref_Vector3 = new(this, "SetValueVector3Internal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_RSetValueVector3Internal_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_RSetValueVector3Internal_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void GetValueVector4Internal_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RGetValueVector4Internal_Injected_Out_Vector4;
		public virtual RMethod RGetValueVector4Internal_Injected_Out_Vector4
		{
			get
			{
				if(r_RGetValueVector4Internal_Injected_Out_Vector4 == null)
				{
					r_RGetValueVector4Internal_Injected_Out_Vector4 = new(this, "GetValueVector4Internal_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_RGetValueVector4Internal_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_RGetValueVector4Internal_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetValueVector4Internal_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RSetValueVector4Internal_Injected_Ref_Vector4;
		public virtual RMethod RSetValueVector4Internal_Injected_Ref_Vector4
		{
			get
			{
				if(r_RSetValueVector4Internal_Injected_Ref_Vector4 == null)
				{
					r_RSetValueVector4Internal_Injected_Ref_Vector4 = new(this, "SetValueVector4Internal_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_RSetValueVector4Internal_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_RSetValueVector4Internal_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void GetValueVector2IntInternal_Injected(UnityEngine.Vector2Int ByRef)
		/// </summary>
		protected RMethod r_RGetValueVector2IntInternal_Injected_Out_Vector2Int;
		public virtual RMethod RGetValueVector2IntInternal_Injected_Out_Vector2Int
		{
			get
			{
				if(r_RGetValueVector2IntInternal_Injected_Out_Vector2Int == null)
				{
					r_RGetValueVector2IntInternal_Injected_Out_Vector2Int = new(this, "GetValueVector2IntInternal_Injected", 0, typeof(UnityEngine.Vector2Int).MakeByRefType());
					r_RGetValueVector2IntInternal_Injected_Out_Vector2Int.SetBelong(this.instance);
				}
				return r_RGetValueVector2IntInternal_Injected_Out_Vector2Int;
			}
		}

		/// <summary>
		/// Void SetValueVector2IntInternal_Injected(UnityEngine.Vector2Int ByRef)
		/// </summary>
		protected RMethod r_RSetValueVector2IntInternal_Injected_Ref_Vector2Int;
		public virtual RMethod RSetValueVector2IntInternal_Injected_Ref_Vector2Int
		{
			get
			{
				if(r_RSetValueVector2IntInternal_Injected_Ref_Vector2Int == null)
				{
					r_RSetValueVector2IntInternal_Injected_Ref_Vector2Int = new(this, "SetValueVector2IntInternal_Injected", 0, typeof(UnityEngine.Vector2Int).MakeByRefType());
					r_RSetValueVector2IntInternal_Injected_Ref_Vector2Int.SetBelong(this.instance);
				}
				return r_RSetValueVector2IntInternal_Injected_Ref_Vector2Int;
			}
		}

		/// <summary>
		/// Void GetValueVector3IntInternal_Injected(UnityEngine.Vector3Int ByRef)
		/// </summary>
		protected RMethod r_RGetValueVector3IntInternal_Injected_Out_Vector3Int;
		public virtual RMethod RGetValueVector3IntInternal_Injected_Out_Vector3Int
		{
			get
			{
				if(r_RGetValueVector3IntInternal_Injected_Out_Vector3Int == null)
				{
					r_RGetValueVector3IntInternal_Injected_Out_Vector3Int = new(this, "GetValueVector3IntInternal_Injected", 0, typeof(UnityEngine.Vector3Int).MakeByRefType());
					r_RGetValueVector3IntInternal_Injected_Out_Vector3Int.SetBelong(this.instance);
				}
				return r_RGetValueVector3IntInternal_Injected_Out_Vector3Int;
			}
		}

		/// <summary>
		/// Void SetValueVector3IntInternal_Injected(UnityEngine.Vector3Int ByRef)
		/// </summary>
		protected RMethod r_RSetValueVector3IntInternal_Injected_Ref_Vector3Int;
		public virtual RMethod RSetValueVector3IntInternal_Injected_Ref_Vector3Int
		{
			get
			{
				if(r_RSetValueVector3IntInternal_Injected_Ref_Vector3Int == null)
				{
					r_RSetValueVector3IntInternal_Injected_Ref_Vector3Int = new(this, "SetValueVector3IntInternal_Injected", 0, typeof(UnityEngine.Vector3Int).MakeByRefType());
					r_RSetValueVector3IntInternal_Injected_Ref_Vector3Int.SetBelong(this.instance);
				}
				return r_RSetValueVector3IntInternal_Injected_Ref_Vector3Int;
			}
		}

		/// <summary>
		/// Void GetValueQuaternionInternal_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_RGetValueQuaternionInternal_Injected_Out_Quaternion;
		public virtual RMethod RGetValueQuaternionInternal_Injected_Out_Quaternion
		{
			get
			{
				if(r_RGetValueQuaternionInternal_Injected_Out_Quaternion == null)
				{
					r_RGetValueQuaternionInternal_Injected_Out_Quaternion = new(this, "GetValueQuaternionInternal_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_RGetValueQuaternionInternal_Injected_Out_Quaternion.SetBelong(this.instance);
				}
				return r_RGetValueQuaternionInternal_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void SetValueQuaternionInternal_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_RSetValueQuaternionInternal_Injected_Ref_Quaternion;
		public virtual RMethod RSetValueQuaternionInternal_Injected_Ref_Quaternion
		{
			get
			{
				if(r_RSetValueQuaternionInternal_Injected_Ref_Quaternion == null)
				{
					r_RSetValueQuaternionInternal_Injected_Ref_Quaternion = new(this, "SetValueQuaternionInternal_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_RSetValueQuaternionInternal_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_RSetValueQuaternionInternal_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void GetValueRectInternal_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RGetValueRectInternal_Injected_Out_Rect;
		public virtual RMethod RGetValueRectInternal_Injected_Out_Rect
		{
			get
			{
				if(r_RGetValueRectInternal_Injected_Out_Rect == null)
				{
					r_RGetValueRectInternal_Injected_Out_Rect = new(this, "GetValueRectInternal_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RGetValueRectInternal_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_RGetValueRectInternal_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void SetValueRectInternal_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RSetValueRectInternal_Injected_Ref_Rect;
		public virtual RMethod RSetValueRectInternal_Injected_Ref_Rect
		{
			get
			{
				if(r_RSetValueRectInternal_Injected_Ref_Rect == null)
				{
					r_RSetValueRectInternal_Injected_Ref_Rect = new(this, "SetValueRectInternal_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RSetValueRectInternal_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_RSetValueRectInternal_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void GetValueRectIntInternal_Injected(UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_RGetValueRectIntInternal_Injected_Out_RectInt;
		public virtual RMethod RGetValueRectIntInternal_Injected_Out_RectInt
		{
			get
			{
				if(r_RGetValueRectIntInternal_Injected_Out_RectInt == null)
				{
					r_RGetValueRectIntInternal_Injected_Out_RectInt = new(this, "GetValueRectIntInternal_Injected", 0, typeof(UnityEngine.RectInt).MakeByRefType());
					r_RGetValueRectIntInternal_Injected_Out_RectInt.SetBelong(this.instance);
				}
				return r_RGetValueRectIntInternal_Injected_Out_RectInt;
			}
		}

		/// <summary>
		/// Void SetValueRectIntInternal_Injected(UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_RSetValueRectIntInternal_Injected_Ref_RectInt;
		public virtual RMethod RSetValueRectIntInternal_Injected_Ref_RectInt
		{
			get
			{
				if(r_RSetValueRectIntInternal_Injected_Ref_RectInt == null)
				{
					r_RSetValueRectIntInternal_Injected_Ref_RectInt = new(this, "SetValueRectIntInternal_Injected", 0, typeof(UnityEngine.RectInt).MakeByRefType());
					r_RSetValueRectIntInternal_Injected_Ref_RectInt.SetBelong(this.instance);
				}
				return r_RSetValueRectIntInternal_Injected_Ref_RectInt;
			}
		}

		/// <summary>
		/// Void GetValueBoundsInternal_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_RGetValueBoundsInternal_Injected_Out_Bounds;
		public virtual RMethod RGetValueBoundsInternal_Injected_Out_Bounds
		{
			get
			{
				if(r_RGetValueBoundsInternal_Injected_Out_Bounds == null)
				{
					r_RGetValueBoundsInternal_Injected_Out_Bounds = new(this, "GetValueBoundsInternal_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_RGetValueBoundsInternal_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_RGetValueBoundsInternal_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void SetValueBoundsInternal_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_RSetValueBoundsInternal_Injected_Ref_Bounds;
		public virtual RMethod RSetValueBoundsInternal_Injected_Ref_Bounds
		{
			get
			{
				if(r_RSetValueBoundsInternal_Injected_Ref_Bounds == null)
				{
					r_RSetValueBoundsInternal_Injected_Ref_Bounds = new(this, "SetValueBoundsInternal_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_RSetValueBoundsInternal_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_RSetValueBoundsInternal_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Void GetValueBoundsIntInternal_Injected(UnityEngine.BoundsInt ByRef)
		/// </summary>
		protected RMethod r_RGetValueBoundsIntInternal_Injected_Out_BoundsInt;
		public virtual RMethod RGetValueBoundsIntInternal_Injected_Out_BoundsInt
		{
			get
			{
				if(r_RGetValueBoundsIntInternal_Injected_Out_BoundsInt == null)
				{
					r_RGetValueBoundsIntInternal_Injected_Out_BoundsInt = new(this, "GetValueBoundsIntInternal_Injected", 0, typeof(UnityEngine.BoundsInt).MakeByRefType());
					r_RGetValueBoundsIntInternal_Injected_Out_BoundsInt.SetBelong(this.instance);
				}
				return r_RGetValueBoundsIntInternal_Injected_Out_BoundsInt;
			}
		}

		/// <summary>
		/// Void SetValueBoundsIntInternal_Injected(UnityEngine.BoundsInt ByRef)
		/// </summary>
		protected RMethod r_RSetValueBoundsIntInternal_Injected_Ref_BoundsInt;
		public virtual RMethod RSetValueBoundsIntInternal_Injected_Ref_BoundsInt
		{
			get
			{
				if(r_RSetValueBoundsIntInternal_Injected_Ref_BoundsInt == null)
				{
					r_RSetValueBoundsIntInternal_Injected_Ref_BoundsInt = new(this, "SetValueBoundsIntInternal_Injected", 0, typeof(UnityEngine.BoundsInt).MakeByRefType());
					r_RSetValueBoundsIntInternal_Injected_Ref_BoundsInt.SetBelong(this.instance);
				}
				return r_RSetValueBoundsIntInternal_Injected_Ref_BoundsInt;
			}
		}

		/// <summary>
		/// Void GetHash128ValueInternal_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_RGetHash128ValueInternal_Injected_Out_Hash128;
		public virtual RMethod RGetHash128ValueInternal_Injected_Out_Hash128
		{
			get
			{
				if(r_RGetHash128ValueInternal_Injected_Out_Hash128 == null)
				{
					r_RGetHash128ValueInternal_Injected_Out_Hash128 = new(this, "GetHash128ValueInternal_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_RGetHash128ValueInternal_Injected_Out_Hash128.SetBelong(this.instance);
				}
				return r_RGetHash128ValueInternal_Injected_Out_Hash128;
			}
		}

		/// <summary>
		/// Void SetHash128ValueInternal_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_RSetHash128ValueInternal_Injected_Ref_Hash128;
		public virtual RMethod RSetHash128ValueInternal_Injected_Ref_Hash128
		{
			get
			{
				if(r_RSetHash128ValueInternal_Injected_Ref_Hash128 == null)
				{
					r_RSetHash128ValueInternal_Injected_Ref_Hash128 = new(this, "SetHash128ValueInternal_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_RSetHash128ValueInternal_Injected_Ref_Hash128.SetBelong(this.instance);
				}
				return r_RSetHash128ValueInternal_Injected_Ref_Hash128;
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


        public RSerializedProperty() : base("UnityEditor.SerializedProperty")
        {
        }

        public RSerializedProperty(System.Object instance) : base("UnityEditor.SerializedProperty")
		{
            SetInstance(instance);
		}

        public RSerializedProperty(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializedProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedProperty Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty FindPropertyRelative(System.String  @relativePropertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativePropertyPath};
            var ___result = RFindPropertyRelative_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual UnityEditor.SerializedProperty GetArrayElementAtIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetArrayElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual void SetToValueOfTarget(UnityEngine.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RSetToValueOfTarget_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean EndOfData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndOfData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SyncSerializedObjectVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSyncSerializedObjectVersion.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean NextVisible(System.Boolean  @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RNextVisible_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean NextVisibleInternal(System.Boolean  @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RNextVisibleInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearArrayInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearArrayInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean FindPropertyInternal(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RFindPropertyInternal_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean FindFirstPropertyFromManagedReferencePathInternal(System.String  @managedReferencePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@managedReferencePath};
            var ___result = RFindFirstPropertyFromManagedReferencePathInternal_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Destroy(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean EqualContents(UnityEditor.SerializedProperty  @x, UnityEditor.SerializedProperty  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = REqualContents_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean EqualContentsInternal(UnityEditor.SerializedProperty  @x, UnityEditor.SerializedProperty  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = REqualContentsInternal_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean DataEquals(UnityEditor.SerializedProperty  @x, UnityEditor.SerializedProperty  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RDataEquals_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VersionEquals(UnityEditor.SerializedProperty  @x, UnityEditor.SerializedProperty  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RVersionEquals_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean DataEqualsInternal(UnityEditor.SerializedProperty  @x, UnityEditor.SerializedProperty  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RDataEqualsInternal_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 HasMultipleDifferentValuesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasMultipleDifferentValuesInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetBitAtIndexForAllTargetsImmediate(System.Int32  @index, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSetBitAtIndexForAllTargetsImmediate_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBitAtIndexForAllTargetsImmediateInternal(System.Int32  @index, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetMangledNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMangledNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSerializedPropertyTypeNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSerializedPropertyTypeNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSerializedPropertyArrayElementTypeNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSerializedPropertyArrayElementTypeNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetTooltipInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTooltipInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetDepthInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDepthInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetPropertyPathInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPropertyPathInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCodeForPropertyPathInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCodeForPropertyPathInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCodeForPropertyPathWithoutArrayIndexInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCodeForPropertyPathWithoutArrayIndexInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetEditableInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEditableInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsReorderable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsReorderable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAnimatedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAnimatedInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCandidateInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCandidateInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsKeyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsKeyInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLiveModified()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsLiveModified.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetIsExpandedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsExpandedInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsExpandedInternal(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetIsExpandedInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasChildrenInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasChildrenInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVisibleChildrenInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasVisibleChildrenInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetIsInstantiatedPrefabInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsInstantiatedPrefabInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsReferencingAManagedReferenceFieldInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsReferencingAManagedReferenceFieldInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetFullyQualifiedTypenameForCurrentTypeTreeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFullyQualifiedTypenameForCurrentTypeTreeInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPropertyPathInCurrentManagedTypeTreeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPropertyPathInCurrentManagedTypeTreeInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetManagedReferencePropertyPathInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManagedReferencePropertyPathInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean GetPrefabOverrideInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPrefabOverrideInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPrefabOverrideInternal(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetPrefabOverrideInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsDefaultOverrideInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsDefaultOverrideInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetIsDrivenRectTransformPropertyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsDrivenRectTransformPropertyInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetSerializedPropertyTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSerializedPropertyTypeInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetNumericTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNumericTypeInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 GetIntValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIntValueInternal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void SetIntValueInternal(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetIntValueInternal_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetBoolValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBoolValueInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetBoolValueInternal(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetBoolValueInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Double GetFloatValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFloatValueInternal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual void SetFloatValueInternal(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetFloatValueInternal_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Double[] GetAllFloatValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllFloatValues.Invoke(___genericsType, ___parameters);

            return (System.Double[])___result;
        }


        public virtual void SetAllFloatValuesImmediate(System.Double[]  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetAllFloatValuesImmediate_DoubleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64[] GetAllIntValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllIntValues.Invoke(___genericsType, ___parameters);

            return (System.Int64[])___result;
        }


        public virtual void SetAllIntValuesImmediate(System.Int64[]  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetAllIntValuesImmediate_Int64Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetStringValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStringValueInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetStringValueInternal(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetStringValueInternal_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetColorValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetColorValueInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void SetColorValueInternal(UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetColorValueInternal_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.AnimationCurve GetAnimationCurveValueCopyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAnimationCurveValueCopyInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public virtual void SetAnimationCurveValueInternal(UnityEngine.AnimationCurve  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetAnimationCurveValueInternal_AnimationCurve.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Gradient GetGradientValueCopyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGradientValueCopyInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Gradient)___result;
        }


        public virtual void SetGradientValueInternal(UnityEngine.Gradient  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetGradientValueInternal_Gradient.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 GetManagedReferenceIdInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManagedReferenceIdInternal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String GetManagedReferenceFullTypeNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManagedReferenceFullTypeNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetManagedReferenceValueInternal(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetManagedReferenceValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStructValueInternal(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetStructValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetStructValueInternal(System.String  @assemblyName, System.String  @nameSpace, System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @nameSpace, @className};
            var ___result = RGetStructValueInternal_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LookupInstanceByIdInternal(System.Int64  @refId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@refId};
            var ___result = RLookupInstanceByIdInternal_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual UnityEngine.Object GetPPtrValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPPtrValueInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual void SetPPtrValueInternal(UnityEngine.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetPPtrValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPPtrValueFromInstanceIDInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPPtrValueFromInstanceIDInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetPPtrValueFromInstanceIDInternal(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RSetPPtrValueFromInstanceIDInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetPPtrStringValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPPtrStringValueInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ValidateObjectReferenceValue(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RValidateObjectReferenceValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidatePPtrValueInternal(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RValidatePPtrValueInternal_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateObjectReferenceValueExact(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RValidateObjectReferenceValueExact_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidatePPtrValueExact(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RValidatePPtrValueExact_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetPPtrClassNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPPtrClassNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void AppendFoldoutPPtrValue(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RAppendFoldoutPPtrValue_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendFoldoutPPtrValueInternal(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RAppendFoldoutPPtrValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetLayerMaskStringValue(System.UInt32  @layers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layers};
            var ___result = RGetLayerMaskStringValue_UInt32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.UInt32 GetLayerMaskBitsInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLayerMaskBitsInternal.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int32 GetEnumValueIndexInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumValueIndexInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetEnumValueIndexInternal(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetEnumValueIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetEnumNamesInternal(System.Boolean  @nicify)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nicify};
            var ___result = RGetEnumNamesInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual UnityEngine.Vector2 GetValueVector2Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueVector2Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetValueVector2Internal(UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector2Internal_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetValueVector3Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueVector3Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetValueVector3Internal(UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector3Internal_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector4 GetValueVector4Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueVector4Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void SetValueVector4Internal(UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector4Internal_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2Int GetValueVector2IntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueVector2IntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public virtual void SetValueVector2IntInternal(UnityEngine.Vector2Int  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector2IntInternal_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3Int GetValueVector3IntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueVector3IntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public virtual void SetValueVector3IntInternal(UnityEngine.Vector3Int  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector3IntInternal_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Quaternion GetValueQuaternionInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueQuaternionInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void SetValueQuaternionInternal(UnityEngine.Quaternion  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueQuaternionInternal_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetValueRectInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueRectInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void SetValueRectInternal(UnityEngine.Rect  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueRectInternal_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RectInt GetValueRectIntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueRectIntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RectInt)___result;
        }


        public virtual void SetValueRectIntInternal(UnityEngine.RectInt  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueRectIntInternal_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Bounds GetValueBoundsInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueBoundsInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Bounds)___result;
        }


        public virtual void SetValueBoundsInternal(UnityEngine.Bounds  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueBoundsInternal_Bounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.BoundsInt GetValueBoundsIntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueBoundsIntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.BoundsInt)___result;
        }


        public virtual void SetValueBoundsIntInternal(UnityEngine.BoundsInt  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueBoundsIntInternal_BoundsInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Hash128 GetHash128ValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHash128ValueInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public virtual void SetHash128ValueInternal(UnityEngine.Hash128  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetHash128ValueInternal_Hash128.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Next(System.Boolean  @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RNext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean NextInternal(System.Boolean  @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RNextInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 CountRemaining()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCountRemaining.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CountRemainingInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCountRemainingInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CountInProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCountInProperty.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CountInPropertyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCountInPropertyInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEditor.SerializedProperty CopyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopyInternal.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty CopyInternalImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopyInternalImpl.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean DuplicateCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDuplicateCommand.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DuplicateCommandInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDuplicateCommandInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteCommand.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteCommandInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteCommandInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.SerializedProperty GetEndProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEndProperty.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty GetEndProperty(System.Boolean  @includeInvisible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeInvisible};
            var ___result = RGetEndProperty_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean FindPropertyRelativeInternal(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RFindPropertyRelativeInternal_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean FindRelativeProperty(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RFindRelativeProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetMinArraySize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMinArraySize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInspectableArraySize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInspectableArraySize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ResizeArray(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RResizeArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetArrayElementAtIndexInternal(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetArrayElementAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetArrayElementAtIndexImpl(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetArrayElementAtIndexImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InsertArrayElementAtIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RInsertArrayElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertArrayElementAtIndexInternal(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RInsertArrayElementAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteArrayElementAtIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RDeleteArrayElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteArrayElementAtIndexInternal(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RDeleteArrayElementAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveArrayElement(System.Int32  @srcIndex, System.Int32  @dstIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcIndex, @dstIndex};
            var ___result = RMoveArrayElement_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveArrayElementInternal(System.Int32  @srcIndex, System.Int32  @dstIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcIndex, @dstIndex};
            var ___result = RMoveArrayElementInternal_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsFixedBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFixedBuffer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetFixedBufferSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFixedBufferSize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetIsValidDisplayNameCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsValidDisplayNameCache.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsValidDisplayNameCache(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetIsValidDisplayNameCache_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsValidTooltipCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsValidTooltipCache.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsValidTooltipCache(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetIsValidTooltipCache_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedProperty GetFixedBufferElementAtIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetFixedBufferElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean GetFixedBufferAtIndexInternal(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetFixedBufferAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AnimationCurveValueEquals(UnityEngine.AnimationCurve  @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@curve};
            var ___result = RAnimationCurveValueEquals_AnimationCurve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValueEquals(UnityEngine.AnimationCurve  @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@curve};
            var ___result = RValueEquals_AnimationCurve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GradientValueEquals(UnityEngine.Gradient  @gradient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gradient};
            var ___result = RGradientValueEquals_Gradient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValueEquals(UnityEngine.Gradient  @gradient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gradient};
            var ___result = RValueEquals_Gradient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StringValueEquals(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RStringValueEquals_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValueEquals(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RValueEquals_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValidInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.UInt32 GetContentHashInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetContentHashInternal.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void GetColorValueInternal_Injected(out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetColorValueInternal_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void SetColorValueInternal_Injected(ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetColorValueInternal_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void GetValueVector2Internal_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueVector2Internal_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void SetValueVector2Internal_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector2Internal_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetValueVector3Internal_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueVector3Internal_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void SetValueVector3Internal_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector3Internal_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void GetValueVector4Internal_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueVector4Internal_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void SetValueVector4Internal_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector4Internal_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void GetValueVector2IntInternal_Injected(out UnityEngine.Vector2Int  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueVector2IntInternal_Injected_Out_Vector2Int.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2Int)___parameters[0];

            
        }


        public virtual void SetValueVector2IntInternal_Injected(ref UnityEngine.Vector2Int  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector2IntInternal_Injected_Ref_Vector2Int.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2Int)___parameters[0];

            
        }


        public virtual void GetValueVector3IntInternal_Injected(out UnityEngine.Vector3Int  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueVector3IntInternal_Injected_Out_Vector3Int.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3Int)___parameters[0];

            
        }


        public virtual void SetValueVector3IntInternal_Injected(ref UnityEngine.Vector3Int  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueVector3IntInternal_Injected_Ref_Vector3Int.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3Int)___parameters[0];

            
        }


        public virtual void GetValueQuaternionInternal_Injected(out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueQuaternionInternal_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void SetValueQuaternionInternal_Injected(ref UnityEngine.Quaternion  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueQuaternionInternal_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void GetValueRectInternal_Injected(out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueRectInternal_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void SetValueRectInternal_Injected(ref UnityEngine.Rect  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueRectInternal_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void GetValueRectIntInternal_Injected(out UnityEngine.RectInt  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueRectIntInternal_Injected_Out_RectInt.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.RectInt)___parameters[0];

            
        }


        public virtual void SetValueRectIntInternal_Injected(ref UnityEngine.RectInt  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueRectIntInternal_Injected_Ref_RectInt.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.RectInt)___parameters[0];

            
        }


        public virtual void GetValueBoundsInternal_Injected(out UnityEngine.Bounds  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueBoundsInternal_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void SetValueBoundsInternal_Injected(ref UnityEngine.Bounds  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueBoundsInternal_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void GetValueBoundsIntInternal_Injected(out UnityEngine.BoundsInt  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetValueBoundsIntInternal_Injected_Out_BoundsInt.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.BoundsInt)___parameters[0];

            
        }


        public virtual void SetValueBoundsIntInternal_Injected(ref UnityEngine.BoundsInt  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetValueBoundsIntInternal_Injected_Ref_BoundsInt.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.BoundsInt)___parameters[0];

            
        }


        public virtual void GetHash128ValueInternal_Injected(out UnityEngine.Hash128  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetHash128ValueInternal_Injected_Out_Hash128.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual void SetHash128ValueInternal_Injected(ref UnityEngine.Hash128  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetHash128ValueInternal_Injected_Ref_Hash128.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
