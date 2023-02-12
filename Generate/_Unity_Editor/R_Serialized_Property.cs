
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
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fm_NativePropertyPtr;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFm_NativePropertyPtr
		{
			get
			{
				if(r_Fm_NativePropertyPtr == null)
				{
					r_Fm_NativePropertyPtr = new(this, "m_NativePropertyPtr");
					r_Fm_NativePropertyPtr.SetBelong(this.instance);
				}
				return r_Fm_NativePropertyPtr;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject m_SerializedObject
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedObject r_Fm_SerializedObject;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedObject RFm_SerializedObject
		{
			get
			{
				if(r_Fm_SerializedObject == null)
				{
					r_Fm_SerializedObject = new(this, "m_SerializedObject");
					r_Fm_SerializedObject.SetBelong(this.instance);
				}
				return r_Fm_SerializedObject;
			}
		}

		/// <summary>
		/// System.String m_CachedLocalizedDisplayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_CachedLocalizedDisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_CachedLocalizedDisplayName
		{
			get
			{
				if(r_Fm_CachedLocalizedDisplayName == null)
				{
					r_Fm_CachedLocalizedDisplayName = new(this, "m_CachedLocalizedDisplayName");
					r_Fm_CachedLocalizedDisplayName.SetBelong(this.instance);
				}
				return r_Fm_CachedLocalizedDisplayName;
			}
		}

		/// <summary>
		/// System.String m_CachedTooltip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_CachedTooltip;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_CachedTooltip
		{
			get
			{
				if(r_Fm_CachedTooltip == null)
				{
					r_Fm_CachedTooltip = new(this, "m_CachedTooltip");
					r_Fm_CachedTooltip.SetBelong(this.instance);
				}
				return r_Fm_CachedTooltip;
			}
		}

		/// <summary>
		/// System.String m_PropertyPath
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_PropertyPath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_PropertyPath
		{
			get
			{
				if(r_Fm_PropertyPath == null)
				{
					r_Fm_PropertyPath = new(this, "m_PropertyPath");
					r_Fm_PropertyPath.SetBelong(this.instance);
				}
				return r_Fm_PropertyPath;
			}
		}

		/// <summary>
		/// System.Int32 m_PropertyPathHash
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_PropertyPathHash;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_PropertyPathHash
		{
			get
			{
				if(r_Fm_PropertyPathHash == null)
				{
					r_Fm_PropertyPathHash = new(this, "m_PropertyPathHash");
					r_Fm_PropertyPathHash.SetBelong(this.instance);
				}
				return r_Fm_PropertyPathHash;
			}
		}

		/// <summary>
		/// System.Boolean <unsafeMode>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F__0__unsafeMode__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF__0__unsafeMode__1__k__BackingField
		{
			get
			{
				if(r_F__0__unsafeMode__1__k__BackingField == null)
				{
					r_F__0__unsafeMode__1__k__BackingField = new(this, "<unsafeMode>k__BackingField");
					r_F__0__unsafeMode__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__unsafeMode__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject serializedObject
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedObject r_PserializedObject;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedObject RPserializedObject
		{
			get
			{
				if(r_PserializedObject == null)
				{
					r_PserializedObject = new(this, "serializedObject", -1);
					r_PserializedObject.SetBelong(this.instance);
				}
				return r_PserializedObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object exposedReferenceValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RObject r_PexposedReferenceValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RObject RPexposedReferenceValue
		{
			get
			{
				if(r_PexposedReferenceValue == null)
				{
					r_PexposedReferenceValue = new(this, "exposedReferenceValue", -1);
					r_PexposedReferenceValue.SetBelong(this.instance);
				}
				return r_PexposedReferenceValue;
			}
		}

		/// <summary>
		/// Boolean isScript
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisScript;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisScript
		{
			get
			{
				if(r_PisScript == null)
				{
					r_PisScript = new(this, "isScript", -1);
					r_PisScript.SetBelong(this.instance);
				}
				return r_PisScript;
			}
		}

		/// <summary>
		/// System.String localizedDisplayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PlocalizedDisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPlocalizedDisplayName
		{
			get
			{
				if(r_PlocalizedDisplayName == null)
				{
					r_PlocalizedDisplayName = new(this, "localizedDisplayName", -1);
					r_PlocalizedDisplayName.SetBelong(this.instance);
				}
				return r_PlocalizedDisplayName;
			}
		}

		/// <summary>
		/// System.String[] enumLocalizedDisplayNames
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> r_PenumLocalizedDisplayNames;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> RPenumLocalizedDisplayNames
		{
			get
			{
				if(r_PenumLocalizedDisplayNames == null)
				{
					r_PenumLocalizedDisplayNames = new(this, "enumLocalizedDisplayNames", -1);
					r_PenumLocalizedDisplayNames.SetBelong(this.instance);
				}
				return r_PenumLocalizedDisplayNames;
			}
		}

		/// <summary>
		/// System.Object boxedValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PboxedValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPboxedValue
		{
			get
			{
				if(r_PboxedValue == null)
				{
					r_PboxedValue = new(this, "boxedValue", -1);
					r_PboxedValue.SetBelong(this.instance);
				}
				return r_PboxedValue;
			}
		}

		/// <summary>
		/// Boolean hasMultipleDifferentValues
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhasMultipleDifferentValues;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhasMultipleDifferentValues
		{
			get
			{
				if(r_PhasMultipleDifferentValues == null)
				{
					r_PhasMultipleDifferentValues = new(this, "hasMultipleDifferentValues", -1);
					r_PhasMultipleDifferentValues.SetBelong(this.instance);
				}
				return r_PhasMultipleDifferentValues;
			}
		}

		/// <summary>
		/// Int32 hasMultipleDifferentValuesBitwise
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PhasMultipleDifferentValuesBitwise;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPhasMultipleDifferentValuesBitwise
		{
			get
			{
				if(r_PhasMultipleDifferentValuesBitwise == null)
				{
					r_PhasMultipleDifferentValuesBitwise = new(this, "hasMultipleDifferentValuesBitwise", -1);
					r_PhasMultipleDifferentValuesBitwise.SetBelong(this.instance);
				}
				return r_PhasMultipleDifferentValuesBitwise;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
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
		/// System.String type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
					r_Ptype.SetBelong(this.instance);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// System.String arrayElementType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_ParrayElementType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RParrayElementType
		{
			get
			{
				if(r_ParrayElementType == null)
				{
					r_ParrayElementType = new(this, "arrayElementType", -1);
					r_ParrayElementType.SetBelong(this.instance);
				}
				return r_ParrayElementType;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pdepth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPdepth
		{
			get
			{
				if(r_Pdepth == null)
				{
					r_Pdepth = new(this, "depth", -1);
					r_Pdepth.SetBelong(this.instance);
				}
				return r_Pdepth;
			}
		}

		/// <summary>
		/// System.String propertyPath
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PpropertyPath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPpropertyPath
		{
			get
			{
				if(r_PpropertyPath == null)
				{
					r_PpropertyPath = new(this, "propertyPath", -1);
					r_PpropertyPath.SetBelong(this.instance);
				}
				return r_PpropertyPath;
			}
		}

		/// <summary>
		/// Int32 hashCodeForPropertyPathWithoutArrayIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PhashCodeForPropertyPathWithoutArrayIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPhashCodeForPropertyPathWithoutArrayIndex
		{
			get
			{
				if(r_PhashCodeForPropertyPathWithoutArrayIndex == null)
				{
					r_PhashCodeForPropertyPathWithoutArrayIndex = new(this, "hashCodeForPropertyPathWithoutArrayIndex", -1);
					r_PhashCodeForPropertyPathWithoutArrayIndex.SetBelong(this.instance);
				}
				return r_PhashCodeForPropertyPathWithoutArrayIndex;
			}
		}

		/// <summary>
		/// Int32 hashCodeForPropertyPath
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PhashCodeForPropertyPath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPhashCodeForPropertyPath
		{
			get
			{
				if(r_PhashCodeForPropertyPath == null)
				{
					r_PhashCodeForPropertyPath = new(this, "hashCodeForPropertyPath", -1);
					r_PhashCodeForPropertyPath.SetBelong(this.instance);
				}
				return r_PhashCodeForPropertyPath;
			}
		}

		/// <summary>
		/// Boolean editable
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Peditable;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPeditable
		{
			get
			{
				if(r_Peditable == null)
				{
					r_Peditable = new(this, "editable", -1);
					r_Peditable.SetBelong(this.instance);
				}
				return r_Peditable;
			}
		}

		/// <summary>
		/// Boolean isAnimated
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisAnimated;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisAnimated
		{
			get
			{
				if(r_PisAnimated == null)
				{
					r_PisAnimated = new(this, "isAnimated", -1);
					r_PisAnimated.SetBelong(this.instance);
				}
				return r_PisAnimated;
			}
		}

		/// <summary>
		/// Boolean isCandidate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisCandidate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisCandidate
		{
			get
			{
				if(r_PisCandidate == null)
				{
					r_PisCandidate = new(this, "isCandidate", -1);
					r_PisCandidate.SetBelong(this.instance);
				}
				return r_PisCandidate;
			}
		}

		/// <summary>
		/// Boolean isKey
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisKey;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisKey
		{
			get
			{
				if(r_PisKey == null)
				{
					r_PisKey = new(this, "isKey", -1);
					r_PisKey.SetBelong(this.instance);
				}
				return r_PisKey;
			}
		}

		/// <summary>
		/// Boolean isLiveModified
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisLiveModified;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisLiveModified
		{
			get
			{
				if(r_PisLiveModified == null)
				{
					r_PisLiveModified = new(this, "isLiveModified", -1);
					r_PisLiveModified.SetBelong(this.instance);
				}
				return r_PisLiveModified;
			}
		}

		/// <summary>
		/// Boolean isExpanded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisExpanded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisExpanded
		{
			get
			{
				if(r_PisExpanded == null)
				{
					r_PisExpanded = new(this, "isExpanded", -1);
					r_PisExpanded.SetBelong(this.instance);
				}
				return r_PisExpanded;
			}
		}

		/// <summary>
		/// Boolean hasChildren
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhasChildren;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhasChildren
		{
			get
			{
				if(r_PhasChildren == null)
				{
					r_PhasChildren = new(this, "hasChildren", -1);
					r_PhasChildren.SetBelong(this.instance);
				}
				return r_PhasChildren;
			}
		}

		/// <summary>
		/// Boolean hasVisibleChildren
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhasVisibleChildren;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhasVisibleChildren
		{
			get
			{
				if(r_PhasVisibleChildren == null)
				{
					r_PhasVisibleChildren = new(this, "hasVisibleChildren", -1);
					r_PhasVisibleChildren.SetBelong(this.instance);
				}
				return r_PhasVisibleChildren;
			}
		}

		/// <summary>
		/// Boolean isInstantiatedPrefab
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisInstantiatedPrefab;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisInstantiatedPrefab
		{
			get
			{
				if(r_PisInstantiatedPrefab == null)
				{
					r_PisInstantiatedPrefab = new(this, "isInstantiatedPrefab", -1);
					r_PisInstantiatedPrefab.SetBelong(this.instance);
				}
				return r_PisInstantiatedPrefab;
			}
		}

		/// <summary>
		/// Boolean isReferencingAManagedReferenceField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisReferencingAManagedReferenceField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisReferencingAManagedReferenceField
		{
			get
			{
				if(r_PisReferencingAManagedReferenceField == null)
				{
					r_PisReferencingAManagedReferenceField = new(this, "isReferencingAManagedReferenceField", -1);
					r_PisReferencingAManagedReferenceField.SetBelong(this.instance);
				}
				return r_PisReferencingAManagedReferenceField;
			}
		}

		/// <summary>
		/// System.String managedReferencePropertyPath
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PmanagedReferencePropertyPath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPmanagedReferencePropertyPath
		{
			get
			{
				if(r_PmanagedReferencePropertyPath == null)
				{
					r_PmanagedReferencePropertyPath = new(this, "managedReferencePropertyPath", -1);
					r_PmanagedReferencePropertyPath.SetBelong(this.instance);
				}
				return r_PmanagedReferencePropertyPath;
			}
		}

		/// <summary>
		/// Boolean prefabOverride
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PprefabOverride;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPprefabOverride
		{
			get
			{
				if(r_PprefabOverride == null)
				{
					r_PprefabOverride = new(this, "prefabOverride", -1);
					r_PprefabOverride.SetBelong(this.instance);
				}
				return r_PprefabOverride;
			}
		}

		/// <summary>
		/// Boolean isDefaultOverride
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisDefaultOverride;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisDefaultOverride
		{
			get
			{
				if(r_PisDefaultOverride == null)
				{
					r_PisDefaultOverride = new(this, "isDefaultOverride", -1);
					r_PisDefaultOverride.SetBelong(this.instance);
				}
				return r_PisDefaultOverride;
			}
		}

		/// <summary>
		/// Boolean isDrivenRectTransformProperty
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisDrivenRectTransformProperty;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisDrivenRectTransformProperty
		{
			get
			{
				if(r_PisDrivenRectTransformProperty == null)
				{
					r_PisDrivenRectTransformProperty = new(this, "isDrivenRectTransformProperty", -1);
					r_PisDrivenRectTransformProperty.SetBelong(this.instance);
				}
				return r_PisDrivenRectTransformProperty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyType propertyType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedPropertyType r_PpropertyType;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedPropertyType RPpropertyType
		{
			get
			{
				if(r_PpropertyType == null)
				{
					r_PpropertyType = new(this, "propertyType", -1);
					r_PpropertyType.SetBelong(this.instance);
				}
				return r_PpropertyType;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedPropertyNumericType numericType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedPropertyNumericType r_PnumericType;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedPropertyNumericType RPnumericType
		{
			get
			{
				if(r_PnumericType == null)
				{
					r_PnumericType = new(this, "numericType", -1);
					r_PnumericType.SetBelong(this.instance);
				}
				return r_PnumericType;
			}
		}

		/// <summary>
		/// Int32 intValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PintValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPintValue
		{
			get
			{
				if(r_PintValue == null)
				{
					r_PintValue = new(this, "intValue", -1);
					r_PintValue.SetBelong(this.instance);
				}
				return r_PintValue;
			}
		}

		/// <summary>
		/// Int64 longValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PlongValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPlongValue
		{
			get
			{
				if(r_PlongValue == null)
				{
					r_PlongValue = new(this, "longValue", -1);
					r_PlongValue.SetBelong(this.instance);
				}
				return r_PlongValue;
			}
		}

		/// <summary>
		/// UInt64 ulongValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_PulongValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RPulongValue
		{
			get
			{
				if(r_PulongValue == null)
				{
					r_PulongValue = new(this, "ulongValue", -1);
					r_PulongValue.SetBelong(this.instance);
				}
				return r_PulongValue;
			}
		}

		/// <summary>
		/// UInt32 uintValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PuintValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPuintValue
		{
			get
			{
				if(r_PuintValue == null)
				{
					r_PuintValue = new(this, "uintValue", -1);
					r_PuintValue.SetBelong(this.instance);
				}
				return r_PuintValue;
			}
		}

		/// <summary>
		/// Boolean boolValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PboolValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPboolValue
		{
			get
			{
				if(r_PboolValue == null)
				{
					r_PboolValue = new(this, "boolValue", -1);
					r_PboolValue.SetBelong(this.instance);
				}
				return r_PboolValue;
			}
		}

		/// <summary>
		/// Single floatValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PfloatValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPfloatValue
		{
			get
			{
				if(r_PfloatValue == null)
				{
					r_PfloatValue = new(this, "floatValue", -1);
					r_PfloatValue.SetBelong(this.instance);
				}
				return r_PfloatValue;
			}
		}

		/// <summary>
		/// Double[] allDoubleValues
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RDouble> r_PallDoubleValues;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RDouble> RPallDoubleValues
		{
			get
			{
				if(r_PallDoubleValues == null)
				{
					r_PallDoubleValues = new(this, "allDoubleValues", -1);
					r_PallDoubleValues.SetBelong(this.instance);
				}
				return r_PallDoubleValues;
			}
		}

		/// <summary>
		/// Int64[] allLongValues
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RInt64> r_PallLongValues;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RInt64> RPallLongValues
		{
			get
			{
				if(r_PallLongValues == null)
				{
					r_PallLongValues = new(this, "allLongValues", -1);
					r_PallLongValues.SetBelong(this.instance);
				}
				return r_PallLongValues;
			}
		}

		/// <summary>
		/// Double doubleValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RDouble r_PdoubleValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RDouble RPdoubleValue
		{
			get
			{
				if(r_PdoubleValue == null)
				{
					r_PdoubleValue = new(this, "doubleValue", -1);
					r_PdoubleValue.SetBelong(this.instance);
				}
				return r_PdoubleValue;
			}
		}

		/// <summary>
		/// System.String stringValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PstringValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPstringValue
		{
			get
			{
				if(r_PstringValue == null)
				{
					r_PstringValue = new(this, "stringValue", -1);
					r_PstringValue.SetBelong(this.instance);
				}
				return r_PstringValue;
			}
		}

		/// <summary>
		/// UnityEngine.Color colorValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_PcolorValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RPcolorValue
		{
			get
			{
				if(r_PcolorValue == null)
				{
					r_PcolorValue = new(this, "colorValue", -1);
					r_PcolorValue.SetBelong(this.instance);
				}
				return r_PcolorValue;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve animationCurveValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RAnimationCurve r_PanimationCurveValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RAnimationCurve RPanimationCurveValue
		{
			get
			{
				if(r_PanimationCurveValue == null)
				{
					r_PanimationCurveValue = new(this, "animationCurveValue", -1);
					r_PanimationCurveValue.SetBelong(this.instance);
				}
				return r_PanimationCurveValue;
			}
		}

		/// <summary>
		/// UnityEngine.Gradient gradientValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RGradient r_PgradientValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RGradient RPgradientValue
		{
			get
			{
				if(r_PgradientValue == null)
				{
					r_PgradientValue = new(this, "gradientValue", -1);
					r_PgradientValue.SetBelong(this.instance);
				}
				return r_PgradientValue;
			}
		}

		/// <summary>
		/// UnityEngine.Object objectReferenceValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RObject r_PobjectReferenceValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RObject RPobjectReferenceValue
		{
			get
			{
				if(r_PobjectReferenceValue == null)
				{
					r_PobjectReferenceValue = new(this, "objectReferenceValue", -1);
					r_PobjectReferenceValue.SetBelong(this.instance);
				}
				return r_PobjectReferenceValue;
			}
		}

		/// <summary>
		/// System.Object managedReferenceValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PmanagedReferenceValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPmanagedReferenceValue
		{
			get
			{
				if(r_PmanagedReferenceValue == null)
				{
					r_PmanagedReferenceValue = new(this, "managedReferenceValue", -1);
					r_PmanagedReferenceValue.SetBelong(this.instance);
				}
				return r_PmanagedReferenceValue;
			}
		}

		/// <summary>
		/// Int64 managedReferenceId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PmanagedReferenceId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPmanagedReferenceId
		{
			get
			{
				if(r_PmanagedReferenceId == null)
				{
					r_PmanagedReferenceId = new(this, "managedReferenceId", -1);
					r_PmanagedReferenceId.SetBelong(this.instance);
				}
				return r_PmanagedReferenceId;
			}
		}

		/// <summary>
		/// System.String managedReferenceFullTypename
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PmanagedReferenceFullTypename;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPmanagedReferenceFullTypename
		{
			get
			{
				if(r_PmanagedReferenceFullTypename == null)
				{
					r_PmanagedReferenceFullTypename = new(this, "managedReferenceFullTypename", -1);
					r_PmanagedReferenceFullTypename.SetBelong(this.instance);
				}
				return r_PmanagedReferenceFullTypename;
			}
		}

		/// <summary>
		/// System.String managedReferenceFieldTypename
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PmanagedReferenceFieldTypename;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPmanagedReferenceFieldTypename
		{
			get
			{
				if(r_PmanagedReferenceFieldTypename == null)
				{
					r_PmanagedReferenceFieldTypename = new(this, "managedReferenceFieldTypename", -1);
					r_PmanagedReferenceFieldTypename.SetBelong(this.instance);
				}
				return r_PmanagedReferenceFieldTypename;
			}
		}

		/// <summary>
		/// System.Object structValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PstructValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPstructValue
		{
			get
			{
				if(r_PstructValue == null)
				{
					r_PstructValue = new(this, "structValue", -1);
					r_PstructValue.SetBelong(this.instance);
				}
				return r_PstructValue;
			}
		}

		/// <summary>
		/// Int32 objectReferenceInstanceIDValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PobjectReferenceInstanceIDValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPobjectReferenceInstanceIDValue
		{
			get
			{
				if(r_PobjectReferenceInstanceIDValue == null)
				{
					r_PobjectReferenceInstanceIDValue = new(this, "objectReferenceInstanceIDValue", -1);
					r_PobjectReferenceInstanceIDValue.SetBelong(this.instance);
				}
				return r_PobjectReferenceInstanceIDValue;
			}
		}

		/// <summary>
		/// System.String objectReferenceStringValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PobjectReferenceStringValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPobjectReferenceStringValue
		{
			get
			{
				if(r_PobjectReferenceStringValue == null)
				{
					r_PobjectReferenceStringValue = new(this, "objectReferenceStringValue", -1);
					r_PobjectReferenceStringValue.SetBelong(this.instance);
				}
				return r_PobjectReferenceStringValue;
			}
		}

		/// <summary>
		/// System.String objectReferenceTypeString
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PobjectReferenceTypeString;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPobjectReferenceTypeString
		{
			get
			{
				if(r_PobjectReferenceTypeString == null)
				{
					r_PobjectReferenceTypeString = new(this, "objectReferenceTypeString", -1);
					r_PobjectReferenceTypeString.SetBelong(this.instance);
				}
				return r_PobjectReferenceTypeString;
			}
		}

		/// <summary>
		/// UInt32 layerMaskBits
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PlayerMaskBits;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPlayerMaskBits
		{
			get
			{
				if(r_PlayerMaskBits == null)
				{
					r_PlayerMaskBits = new(this, "layerMaskBits", -1);
					r_PlayerMaskBits.SetBelong(this.instance);
				}
				return r_PlayerMaskBits;
			}
		}

		/// <summary>
		/// Int32 enumValueIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PenumValueIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPenumValueIndex
		{
			get
			{
				if(r_PenumValueIndex == null)
				{
					r_PenumValueIndex = new(this, "enumValueIndex", -1);
					r_PenumValueIndex.SetBelong(this.instance);
				}
				return r_PenumValueIndex;
			}
		}

		/// <summary>
		/// Int32 enumValueFlag
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PenumValueFlag;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPenumValueFlag
		{
			get
			{
				if(r_PenumValueFlag == null)
				{
					r_PenumValueFlag = new(this, "enumValueFlag", -1);
					r_PenumValueFlag.SetBelong(this.instance);
				}
				return r_PenumValueFlag;
			}
		}

		/// <summary>
		/// System.String[] enumNames
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> r_PenumNames;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> RPenumNames
		{
			get
			{
				if(r_PenumNames == null)
				{
					r_PenumNames = new(this, "enumNames", -1);
					r_PenumNames.SetBelong(this.instance);
				}
				return r_PenumNames;
			}
		}

		/// <summary>
		/// System.String[] enumDisplayNames
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> r_PenumDisplayNames;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RString> RPenumDisplayNames
		{
			get
			{
				if(r_PenumDisplayNames == null)
				{
					r_PenumDisplayNames = new(this, "enumDisplayNames", -1);
					r_PenumDisplayNames.SetBelong(this.instance);
				}
				return r_PenumDisplayNames;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 vector2Value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_Pvector2Value;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RPvector2Value
		{
			get
			{
				if(r_Pvector2Value == null)
				{
					r_Pvector2Value = new(this, "vector2Value", -1);
					r_Pvector2Value.SetBelong(this.instance);
				}
				return r_Pvector2Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 vector3Value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_Pvector3Value;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RPvector3Value
		{
			get
			{
				if(r_Pvector3Value == null)
				{
					r_Pvector3Value = new(this, "vector3Value", -1);
					r_Pvector3Value.SetBelong(this.instance);
				}
				return r_Pvector3Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 vector4Value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_Pvector4Value;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RPvector4Value
		{
			get
			{
				if(r_Pvector4Value == null)
				{
					r_Pvector4Value = new(this, "vector4Value", -1);
					r_Pvector4Value.SetBelong(this.instance);
				}
				return r_Pvector4Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int vector2IntValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pvector2IntValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPvector2IntValue
		{
			get
			{
				if(r_Pvector2IntValue == null)
				{
					r_Pvector2IntValue = new(this, "vector2IntValue", -1);
					r_Pvector2IntValue.SetBelong(this.instance);
				}
				return r_Pvector2IntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int vector3IntValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3Int r_Pvector3IntValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3Int RPvector3IntValue
		{
			get
			{
				if(r_Pvector3IntValue == null)
				{
					r_Pvector3IntValue = new(this, "vector3IntValue", -1);
					r_Pvector3IntValue.SetBelong(this.instance);
				}
				return r_Pvector3IntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion quaternionValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RQuaternion r_PquaternionValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RQuaternion RPquaternionValue
		{
			get
			{
				if(r_PquaternionValue == null)
				{
					r_PquaternionValue = new(this, "quaternionValue", -1);
					r_PquaternionValue.SetBelong(this.instance);
				}
				return r_PquaternionValue;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rectValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRect r_PrectValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRect RPrectValue
		{
			get
			{
				if(r_PrectValue == null)
				{
					r_PrectValue = new(this, "rectValue", -1);
					r_PrectValue.SetBelong(this.instance);
				}
				return r_PrectValue;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt rectIntValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRectInt r_PrectIntValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRectInt RPrectIntValue
		{
			get
			{
				if(r_PrectIntValue == null)
				{
					r_PrectIntValue = new(this, "rectIntValue", -1);
					r_PrectIntValue.SetBelong(this.instance);
				}
				return r_PrectIntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds boundsValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RBounds r_PboundsValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RBounds RPboundsValue
		{
			get
			{
				if(r_PboundsValue == null)
				{
					r_PboundsValue = new(this, "boundsValue", -1);
					r_PboundsValue.SetBelong(this.instance);
				}
				return r_PboundsValue;
			}
		}

		/// <summary>
		/// UnityEngine.BoundsInt boundsIntValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RBoundsInt r_PboundsIntValue;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RBoundsInt RPboundsIntValue
		{
			get
			{
				if(r_PboundsIntValue == null)
				{
					r_PboundsIntValue = new(this, "boundsIntValue", -1);
					r_PboundsIntValue.SetBelong(this.instance);
				}
				return r_PboundsIntValue;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 hash128Value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RHash128 r_Phash128Value;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RHash128 RPhash128Value
		{
			get
			{
				if(r_Phash128Value == null)
				{
					r_Phash128Value = new(this, "hash128Value", -1);
					r_Phash128Value.SetBelong(this.instance);
				}
				return r_Phash128Value;
			}
		}

		/// <summary>
		/// Boolean isArray
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisArray;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisArray
		{
			get
			{
				if(r_PisArray == null)
				{
					r_PisArray = new(this, "isArray", -1);
					r_PisArray.SetBelong(this.instance);
				}
				return r_PisArray;
			}
		}

		/// <summary>
		/// Int32 arraySize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_ParraySize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RParraySize
		{
			get
			{
				if(r_ParraySize == null)
				{
					r_ParraySize = new(this, "arraySize", -1);
					r_ParraySize.SetBelong(this.instance);
				}
				return r_ParraySize;
			}
		}

		/// <summary>
		/// Int32 minArraySize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PminArraySize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPminArraySize
		{
			get
			{
				if(r_PminArraySize == null)
				{
					r_PminArraySize = new(this, "minArraySize", -1);
					r_PminArraySize.SetBelong(this.instance);
				}
				return r_PminArraySize;
			}
		}

		/// <summary>
		/// Boolean isFixedBuffer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisFixedBuffer;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisFixedBuffer
		{
			get
			{
				if(r_PisFixedBuffer == null)
				{
					r_PisFixedBuffer = new(this, "isFixedBuffer", -1);
					r_PisFixedBuffer.SetBelong(this.instance);
				}
				return r_PisFixedBuffer;
			}
		}

		/// <summary>
		/// Int32 fixedBufferSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PfixedBufferSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPfixedBufferSize
		{
			get
			{
				if(r_PfixedBufferSize == null)
				{
					r_PfixedBufferSize = new(this, "fixedBufferSize", -1);
					r_PfixedBufferSize.SetBelong(this.instance);
				}
				return r_PfixedBufferSize;
			}
		}

		/// <summary>
		/// Boolean isValidDisplayNameCache
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisValidDisplayNameCache;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisValidDisplayNameCache
		{
			get
			{
				if(r_PisValidDisplayNameCache == null)
				{
					r_PisValidDisplayNameCache = new(this, "isValidDisplayNameCache", -1);
					r_PisValidDisplayNameCache.SetBelong(this.instance);
				}
				return r_PisValidDisplayNameCache;
			}
		}

		/// <summary>
		/// Boolean isValidTooltipCache
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisValidTooltipCache;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisValidTooltipCache
		{
			get
			{
				if(r_PisValidTooltipCache == null)
				{
					r_PisValidTooltipCache = new(this, "isValidTooltipCache", -1);
					r_PisValidTooltipCache.SetBelong(this.instance);
				}
				return r_PisValidTooltipCache;
			}
		}

		/// <summary>
		/// Boolean unsafeMode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PunsafeMode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPunsafeMode
		{
			get
			{
				if(r_PunsafeMode == null)
				{
					r_PunsafeMode = new(this, "unsafeMode", -1);
					r_PunsafeMode.SetBelong(this.instance);
				}
				return r_PunsafeMode;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
					r_PisValid.SetBelong(this.instance);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// UInt32 contentHash
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PcontentHash;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPcontentHash
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
		/// UnityEditor.SerializedProperty Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.instance);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty FindPropertyRelative(System.String)
		/// </summary>
		protected RMethod r_MFindPropertyRelative_String;
		public virtual RMethod RMFindPropertyRelative_String
		{
			get
			{
				if(r_MFindPropertyRelative_String == null)
				{
					r_MFindPropertyRelative_String = new(this, "FindPropertyRelative", 0, typeof(System.String));
					r_MFindPropertyRelative_String.SetBelong(this.instance);
				}
				return r_MFindPropertyRelative_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetArrayElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_MGetArrayElementAtIndex_Int32;
		public virtual RMethod RMGetArrayElementAtIndex_Int32
		{
			get
			{
				if(r_MGetArrayElementAtIndex_Int32 == null)
				{
					r_MGetArrayElementAtIndex_Int32 = new(this, "GetArrayElementAtIndex", 0, typeof(System.Int32));
					r_MGetArrayElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_MGetArrayElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void SetToValueOfTarget(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MSetToValueOfTarget_Object;
		public virtual RMethod RMSetToValueOfTarget_Object
		{
			get
			{
				if(r_MSetToValueOfTarget_Object == null)
				{
					r_MSetToValueOfTarget_Object = new(this, "SetToValueOfTarget", 0, typeof(UnityEngine.Object));
					r_MSetToValueOfTarget_Object.SetBelong(this.instance);
				}
				return r_MSetToValueOfTarget_Object;
			}
		}

		/// <summary>
		/// Boolean EndOfData()
		/// </summary>
		protected RMethod r_MEndOfData;
		public virtual RMethod RMEndOfData
		{
			get
			{
				if(r_MEndOfData == null)
				{
					r_MEndOfData = new(this, "EndOfData", 0);
					r_MEndOfData.SetBelong(this.instance);
				}
				return r_MEndOfData;
			}
		}

		/// <summary>
		/// Void SyncSerializedObjectVersion()
		/// </summary>
		protected RMethod r_MSyncSerializedObjectVersion;
		public virtual RMethod RMSyncSerializedObjectVersion
		{
			get
			{
				if(r_MSyncSerializedObjectVersion == null)
				{
					r_MSyncSerializedObjectVersion = new(this, "SyncSerializedObjectVersion", 0);
					r_MSyncSerializedObjectVersion.SetBelong(this.instance);
				}
				return r_MSyncSerializedObjectVersion;
			}
		}

		/// <summary>
		/// Void Verify(VerifyFlags)
		/// </summary>
		protected RMethod r_MVerify_VerifyFlags;
		public virtual RMethod RMVerify_VerifyFlags
		{
			get
			{
				if(r_MVerify_VerifyFlags == null)
				{
					r_MVerify_VerifyFlags = new(this, "Verify", 0,  ReflectionUtils.GetType("UnityEditor.SerializedProperty+VerifyFlags"));
					r_MVerify_VerifyFlags.SetBelong(this.instance);
				}
				return r_MVerify_VerifyFlags;
			}
		}

		/// <summary>
		/// Boolean NextVisible(Boolean)
		/// </summary>
		protected RMethod r_MNextVisible_Boolean;
		public virtual RMethod RMNextVisible_Boolean
		{
			get
			{
				if(r_MNextVisible_Boolean == null)
				{
					r_MNextVisible_Boolean = new(this, "NextVisible", 0, typeof(System.Boolean));
					r_MNextVisible_Boolean.SetBelong(this.instance);
				}
				return r_MNextVisible_Boolean;
			}
		}

		/// <summary>
		/// Boolean NextVisibleInternal(Boolean)
		/// </summary>
		protected RMethod r_MNextVisibleInternal_Boolean;
		public virtual RMethod RMNextVisibleInternal_Boolean
		{
			get
			{
				if(r_MNextVisibleInternal_Boolean == null)
				{
					r_MNextVisibleInternal_Boolean = new(this, "NextVisibleInternal", 0, typeof(System.Boolean));
					r_MNextVisibleInternal_Boolean.SetBelong(this.instance);
				}
				return r_MNextVisibleInternal_Boolean;
			}
		}

		/// <summary>
		/// Void ClearArray()
		/// </summary>
		protected RMethod r_MClearArray;
		public virtual RMethod RMClearArray
		{
			get
			{
				if(r_MClearArray == null)
				{
					r_MClearArray = new(this, "ClearArray", 0);
					r_MClearArray.SetBelong(this.instance);
				}
				return r_MClearArray;
			}
		}

		/// <summary>
		/// Void ClearArrayInternal()
		/// </summary>
		protected RMethod r_MClearArrayInternal;
		public virtual RMethod RMClearArrayInternal
		{
			get
			{
				if(r_MClearArrayInternal == null)
				{
					r_MClearArrayInternal = new(this, "ClearArrayInternal", 0);
					r_MClearArrayInternal.SetBelong(this.instance);
				}
				return r_MClearArrayInternal;
			}
		}

		/// <summary>
		/// Boolean FindPropertyInternal(System.String)
		/// </summary>
		protected RMethod r_MFindPropertyInternal_String;
		public virtual RMethod RMFindPropertyInternal_String
		{
			get
			{
				if(r_MFindPropertyInternal_String == null)
				{
					r_MFindPropertyInternal_String = new(this, "FindPropertyInternal", 0, typeof(System.String));
					r_MFindPropertyInternal_String.SetBelong(this.instance);
				}
				return r_MFindPropertyInternal_String;
			}
		}

		/// <summary>
		/// Boolean FindFirstPropertyFromManagedReferencePathInternal(System.String)
		/// </summary>
		protected RMethod r_MFindFirstPropertyFromManagedReferencePathInternal_String;
		public virtual RMethod RMFindFirstPropertyFromManagedReferencePathInternal_String
		{
			get
			{
				if(r_MFindFirstPropertyFromManagedReferencePathInternal_String == null)
				{
					r_MFindFirstPropertyFromManagedReferencePathInternal_String = new(this, "FindFirstPropertyFromManagedReferencePathInternal", 0, typeof(System.String));
					r_MFindFirstPropertyFromManagedReferencePathInternal_String.SetBelong(this.instance);
				}
				return r_MFindFirstPropertyFromManagedReferencePathInternal_String;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_Destroy_IntPtr;
		public static RMethod RMInternal_Destroy_IntPtr
		{
			get
			{
				if(r_MInternal_Destroy_IntPtr == null)
				{
					r_MInternal_Destroy_IntPtr = new(typeof(UnityEditor.SerializedProperty), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_MInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_MInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// Boolean EqualContents(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MEqualContents_SerializedProperty_SerializedProperty;
		public static RMethod RMEqualContents_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MEqualContents_SerializedProperty_SerializedProperty == null)
				{
					r_MEqualContents_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "EqualContents", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_MEqualContents_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_MEqualContents_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean EqualContentsInternal(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MEqualContentsInternal_SerializedProperty_SerializedProperty;
		public static RMethod RMEqualContentsInternal_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MEqualContentsInternal_SerializedProperty_SerializedProperty == null)
				{
					r_MEqualContentsInternal_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "EqualContentsInternal", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_MEqualContentsInternal_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_MEqualContentsInternal_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean DataEquals(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MDataEquals_SerializedProperty_SerializedProperty;
		public static RMethod RMDataEquals_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MDataEquals_SerializedProperty_SerializedProperty == null)
				{
					r_MDataEquals_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "DataEquals", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_MDataEquals_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_MDataEquals_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean VersionEquals(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MVersionEquals_SerializedProperty_SerializedProperty;
		public static RMethod RMVersionEquals_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MVersionEquals_SerializedProperty_SerializedProperty == null)
				{
					r_MVersionEquals_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "VersionEquals", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_MVersionEquals_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_MVersionEquals_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean DataEqualsInternal(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MDataEqualsInternal_SerializedProperty_SerializedProperty;
		public static RMethod RMDataEqualsInternal_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MDataEqualsInternal_SerializedProperty_SerializedProperty == null)
				{
					r_MDataEqualsInternal_SerializedProperty_SerializedProperty = new(typeof(UnityEditor.SerializedProperty), "DataEqualsInternal", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_MDataEqualsInternal_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_MDataEqualsInternal_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Int32 HasMultipleDifferentValuesInternal()
		/// </summary>
		protected RMethod r_MHasMultipleDifferentValuesInternal;
		public virtual RMethod RMHasMultipleDifferentValuesInternal
		{
			get
			{
				if(r_MHasMultipleDifferentValuesInternal == null)
				{
					r_MHasMultipleDifferentValuesInternal = new(this, "HasMultipleDifferentValuesInternal", 0);
					r_MHasMultipleDifferentValuesInternal.SetBelong(this.instance);
				}
				return r_MHasMultipleDifferentValuesInternal;
			}
		}

		/// <summary>
		/// Void SetBitAtIndexForAllTargetsImmediate(Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetBitAtIndexForAllTargetsImmediate_Int32_Boolean;
		public virtual RMethod RMSetBitAtIndexForAllTargetsImmediate_Int32_Boolean
		{
			get
			{
				if(r_MSetBitAtIndexForAllTargetsImmediate_Int32_Boolean == null)
				{
					r_MSetBitAtIndexForAllTargetsImmediate_Int32_Boolean = new(this, "SetBitAtIndexForAllTargetsImmediate", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MSetBitAtIndexForAllTargetsImmediate_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MSetBitAtIndexForAllTargetsImmediate_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetBitAtIndexForAllTargetsImmediateInternal(Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean;
		public virtual RMethod RMSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean
		{
			get
			{
				if(r_MSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean == null)
				{
					r_MSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean = new(this, "SetBitAtIndexForAllTargetsImmediateInternal", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.String GetMangledNameInternal()
		/// </summary>
		protected RMethod r_MGetMangledNameInternal;
		public virtual RMethod RMGetMangledNameInternal
		{
			get
			{
				if(r_MGetMangledNameInternal == null)
				{
					r_MGetMangledNameInternal = new(this, "GetMangledNameInternal", 0);
					r_MGetMangledNameInternal.SetBelong(this.instance);
				}
				return r_MGetMangledNameInternal;
			}
		}

		/// <summary>
		/// System.String GetNameInternal()
		/// </summary>
		protected RMethod r_MGetNameInternal;
		public virtual RMethod RMGetNameInternal
		{
			get
			{
				if(r_MGetNameInternal == null)
				{
					r_MGetNameInternal = new(this, "GetNameInternal", 0);
					r_MGetNameInternal.SetBelong(this.instance);
				}
				return r_MGetNameInternal;
			}
		}

		/// <summary>
		/// System.String GetSerializedPropertyTypeNameInternal()
		/// </summary>
		protected RMethod r_MGetSerializedPropertyTypeNameInternal;
		public virtual RMethod RMGetSerializedPropertyTypeNameInternal
		{
			get
			{
				if(r_MGetSerializedPropertyTypeNameInternal == null)
				{
					r_MGetSerializedPropertyTypeNameInternal = new(this, "GetSerializedPropertyTypeNameInternal", 0);
					r_MGetSerializedPropertyTypeNameInternal.SetBelong(this.instance);
				}
				return r_MGetSerializedPropertyTypeNameInternal;
			}
		}

		/// <summary>
		/// System.String GetSerializedPropertyArrayElementTypeNameInternal()
		/// </summary>
		protected RMethod r_MGetSerializedPropertyArrayElementTypeNameInternal;
		public virtual RMethod RMGetSerializedPropertyArrayElementTypeNameInternal
		{
			get
			{
				if(r_MGetSerializedPropertyArrayElementTypeNameInternal == null)
				{
					r_MGetSerializedPropertyArrayElementTypeNameInternal = new(this, "GetSerializedPropertyArrayElementTypeNameInternal", 0);
					r_MGetSerializedPropertyArrayElementTypeNameInternal.SetBelong(this.instance);
				}
				return r_MGetSerializedPropertyArrayElementTypeNameInternal;
			}
		}

		/// <summary>
		/// System.String GetTooltipInternal()
		/// </summary>
		protected RMethod r_MGetTooltipInternal;
		public virtual RMethod RMGetTooltipInternal
		{
			get
			{
				if(r_MGetTooltipInternal == null)
				{
					r_MGetTooltipInternal = new(this, "GetTooltipInternal", 0);
					r_MGetTooltipInternal.SetBelong(this.instance);
				}
				return r_MGetTooltipInternal;
			}
		}

		/// <summary>
		/// Int32 GetDepthInternal()
		/// </summary>
		protected RMethod r_MGetDepthInternal;
		public virtual RMethod RMGetDepthInternal
		{
			get
			{
				if(r_MGetDepthInternal == null)
				{
					r_MGetDepthInternal = new(this, "GetDepthInternal", 0);
					r_MGetDepthInternal.SetBelong(this.instance);
				}
				return r_MGetDepthInternal;
			}
		}

		/// <summary>
		/// System.String GetPropertyPathInternal()
		/// </summary>
		protected RMethod r_MGetPropertyPathInternal;
		public virtual RMethod RMGetPropertyPathInternal
		{
			get
			{
				if(r_MGetPropertyPathInternal == null)
				{
					r_MGetPropertyPathInternal = new(this, "GetPropertyPathInternal", 0);
					r_MGetPropertyPathInternal.SetBelong(this.instance);
				}
				return r_MGetPropertyPathInternal;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeForPropertyPathInternal()
		/// </summary>
		protected RMethod r_MGetHashCodeForPropertyPathInternal;
		public virtual RMethod RMGetHashCodeForPropertyPathInternal
		{
			get
			{
				if(r_MGetHashCodeForPropertyPathInternal == null)
				{
					r_MGetHashCodeForPropertyPathInternal = new(this, "GetHashCodeForPropertyPathInternal", 0);
					r_MGetHashCodeForPropertyPathInternal.SetBelong(this.instance);
				}
				return r_MGetHashCodeForPropertyPathInternal;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeForPropertyPathWithoutArrayIndexInternal()
		/// </summary>
		protected RMethod r_MGetHashCodeForPropertyPathWithoutArrayIndexInternal;
		public virtual RMethod RMGetHashCodeForPropertyPathWithoutArrayIndexInternal
		{
			get
			{
				if(r_MGetHashCodeForPropertyPathWithoutArrayIndexInternal == null)
				{
					r_MGetHashCodeForPropertyPathWithoutArrayIndexInternal = new(this, "GetHashCodeForPropertyPathWithoutArrayIndexInternal", 0);
					r_MGetHashCodeForPropertyPathWithoutArrayIndexInternal.SetBelong(this.instance);
				}
				return r_MGetHashCodeForPropertyPathWithoutArrayIndexInternal;
			}
		}

		/// <summary>
		/// Boolean GetEditableInternal()
		/// </summary>
		protected RMethod r_MGetEditableInternal;
		public virtual RMethod RMGetEditableInternal
		{
			get
			{
				if(r_MGetEditableInternal == null)
				{
					r_MGetEditableInternal = new(this, "GetEditableInternal", 0);
					r_MGetEditableInternal.SetBelong(this.instance);
				}
				return r_MGetEditableInternal;
			}
		}

		/// <summary>
		/// Boolean IsReorderable()
		/// </summary>
		protected RMethod r_MIsReorderable;
		public virtual RMethod RMIsReorderable
		{
			get
			{
				if(r_MIsReorderable == null)
				{
					r_MIsReorderable = new(this, "IsReorderable", 0);
					r_MIsReorderable.SetBelong(this.instance);
				}
				return r_MIsReorderable;
			}
		}

		/// <summary>
		/// Boolean IsAnimatedInternal()
		/// </summary>
		protected RMethod r_MIsAnimatedInternal;
		public virtual RMethod RMIsAnimatedInternal
		{
			get
			{
				if(r_MIsAnimatedInternal == null)
				{
					r_MIsAnimatedInternal = new(this, "IsAnimatedInternal", 0);
					r_MIsAnimatedInternal.SetBelong(this.instance);
				}
				return r_MIsAnimatedInternal;
			}
		}

		/// <summary>
		/// Boolean IsCandidateInternal()
		/// </summary>
		protected RMethod r_MIsCandidateInternal;
		public virtual RMethod RMIsCandidateInternal
		{
			get
			{
				if(r_MIsCandidateInternal == null)
				{
					r_MIsCandidateInternal = new(this, "IsCandidateInternal", 0);
					r_MIsCandidateInternal.SetBelong(this.instance);
				}
				return r_MIsCandidateInternal;
			}
		}

		/// <summary>
		/// Boolean IsKeyInternal()
		/// </summary>
		protected RMethod r_MIsKeyInternal;
		public virtual RMethod RMIsKeyInternal
		{
			get
			{
				if(r_MIsKeyInternal == null)
				{
					r_MIsKeyInternal = new(this, "IsKeyInternal", 0);
					r_MIsKeyInternal.SetBelong(this.instance);
				}
				return r_MIsKeyInternal;
			}
		}

		/// <summary>
		/// Boolean IsLiveModified()
		/// </summary>
		protected RMethod r_MIsLiveModified;
		public virtual RMethod RMIsLiveModified
		{
			get
			{
				if(r_MIsLiveModified == null)
				{
					r_MIsLiveModified = new(this, "IsLiveModified", 0);
					r_MIsLiveModified.SetBelong(this.instance);
				}
				return r_MIsLiveModified;
			}
		}

		/// <summary>
		/// Boolean GetIsExpandedInternal()
		/// </summary>
		protected RMethod r_MGetIsExpandedInternal;
		public virtual RMethod RMGetIsExpandedInternal
		{
			get
			{
				if(r_MGetIsExpandedInternal == null)
				{
					r_MGetIsExpandedInternal = new(this, "GetIsExpandedInternal", 0);
					r_MGetIsExpandedInternal.SetBelong(this.instance);
				}
				return r_MGetIsExpandedInternal;
			}
		}

		/// <summary>
		/// Void SetIsExpandedInternal(Boolean)
		/// </summary>
		protected RMethod r_MSetIsExpandedInternal_Boolean;
		public virtual RMethod RMSetIsExpandedInternal_Boolean
		{
			get
			{
				if(r_MSetIsExpandedInternal_Boolean == null)
				{
					r_MSetIsExpandedInternal_Boolean = new(this, "SetIsExpandedInternal", 0, typeof(System.Boolean));
					r_MSetIsExpandedInternal_Boolean.SetBelong(this.instance);
				}
				return r_MSetIsExpandedInternal_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasChildrenInternal()
		/// </summary>
		protected RMethod r_MHasChildrenInternal;
		public virtual RMethod RMHasChildrenInternal
		{
			get
			{
				if(r_MHasChildrenInternal == null)
				{
					r_MHasChildrenInternal = new(this, "HasChildrenInternal", 0);
					r_MHasChildrenInternal.SetBelong(this.instance);
				}
				return r_MHasChildrenInternal;
			}
		}

		/// <summary>
		/// Boolean HasVisibleChildrenInternal()
		/// </summary>
		protected RMethod r_MHasVisibleChildrenInternal;
		public virtual RMethod RMHasVisibleChildrenInternal
		{
			get
			{
				if(r_MHasVisibleChildrenInternal == null)
				{
					r_MHasVisibleChildrenInternal = new(this, "HasVisibleChildrenInternal", 0);
					r_MHasVisibleChildrenInternal.SetBelong(this.instance);
				}
				return r_MHasVisibleChildrenInternal;
			}
		}

		/// <summary>
		/// Boolean GetIsInstantiatedPrefabInternal()
		/// </summary>
		protected RMethod r_MGetIsInstantiatedPrefabInternal;
		public virtual RMethod RMGetIsInstantiatedPrefabInternal
		{
			get
			{
				if(r_MGetIsInstantiatedPrefabInternal == null)
				{
					r_MGetIsInstantiatedPrefabInternal = new(this, "GetIsInstantiatedPrefabInternal", 0);
					r_MGetIsInstantiatedPrefabInternal.SetBelong(this.instance);
				}
				return r_MGetIsInstantiatedPrefabInternal;
			}
		}

		/// <summary>
		/// Boolean IsReferencingAManagedReferenceFieldInternal()
		/// </summary>
		protected RMethod r_MIsReferencingAManagedReferenceFieldInternal;
		public virtual RMethod RMIsReferencingAManagedReferenceFieldInternal
		{
			get
			{
				if(r_MIsReferencingAManagedReferenceFieldInternal == null)
				{
					r_MIsReferencingAManagedReferenceFieldInternal = new(this, "IsReferencingAManagedReferenceFieldInternal", 0);
					r_MIsReferencingAManagedReferenceFieldInternal.SetBelong(this.instance);
				}
				return r_MIsReferencingAManagedReferenceFieldInternal;
			}
		}

		/// <summary>
		/// System.String GetFullyQualifiedTypenameForCurrentTypeTreeInternal()
		/// </summary>
		protected RMethod r_MGetFullyQualifiedTypenameForCurrentTypeTreeInternal;
		public virtual RMethod RMGetFullyQualifiedTypenameForCurrentTypeTreeInternal
		{
			get
			{
				if(r_MGetFullyQualifiedTypenameForCurrentTypeTreeInternal == null)
				{
					r_MGetFullyQualifiedTypenameForCurrentTypeTreeInternal = new(this, "GetFullyQualifiedTypenameForCurrentTypeTreeInternal", 0);
					r_MGetFullyQualifiedTypenameForCurrentTypeTreeInternal.SetBelong(this.instance);
				}
				return r_MGetFullyQualifiedTypenameForCurrentTypeTreeInternal;
			}
		}

		/// <summary>
		/// System.String GetPropertyPathInCurrentManagedTypeTreeInternal()
		/// </summary>
		protected RMethod r_MGetPropertyPathInCurrentManagedTypeTreeInternal;
		public virtual RMethod RMGetPropertyPathInCurrentManagedTypeTreeInternal
		{
			get
			{
				if(r_MGetPropertyPathInCurrentManagedTypeTreeInternal == null)
				{
					r_MGetPropertyPathInCurrentManagedTypeTreeInternal = new(this, "GetPropertyPathInCurrentManagedTypeTreeInternal", 0);
					r_MGetPropertyPathInCurrentManagedTypeTreeInternal.SetBelong(this.instance);
				}
				return r_MGetPropertyPathInCurrentManagedTypeTreeInternal;
			}
		}

		/// <summary>
		/// System.String GetManagedReferencePropertyPathInternal()
		/// </summary>
		protected RMethod r_MGetManagedReferencePropertyPathInternal;
		public virtual RMethod RMGetManagedReferencePropertyPathInternal
		{
			get
			{
				if(r_MGetManagedReferencePropertyPathInternal == null)
				{
					r_MGetManagedReferencePropertyPathInternal = new(this, "GetManagedReferencePropertyPathInternal", 0);
					r_MGetManagedReferencePropertyPathInternal.SetBelong(this.instance);
				}
				return r_MGetManagedReferencePropertyPathInternal;
			}
		}

		/// <summary>
		/// Boolean GetPrefabOverrideInternal()
		/// </summary>
		protected RMethod r_MGetPrefabOverrideInternal;
		public virtual RMethod RMGetPrefabOverrideInternal
		{
			get
			{
				if(r_MGetPrefabOverrideInternal == null)
				{
					r_MGetPrefabOverrideInternal = new(this, "GetPrefabOverrideInternal", 0);
					r_MGetPrefabOverrideInternal.SetBelong(this.instance);
				}
				return r_MGetPrefabOverrideInternal;
			}
		}

		/// <summary>
		/// Void SetPrefabOverrideInternal(Boolean)
		/// </summary>
		protected RMethod r_MSetPrefabOverrideInternal_Boolean;
		public virtual RMethod RMSetPrefabOverrideInternal_Boolean
		{
			get
			{
				if(r_MSetPrefabOverrideInternal_Boolean == null)
				{
					r_MSetPrefabOverrideInternal_Boolean = new(this, "SetPrefabOverrideInternal", 0, typeof(System.Boolean));
					r_MSetPrefabOverrideInternal_Boolean.SetBelong(this.instance);
				}
				return r_MSetPrefabOverrideInternal_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetIsDefaultOverrideInternal()
		/// </summary>
		protected RMethod r_MGetIsDefaultOverrideInternal;
		public virtual RMethod RMGetIsDefaultOverrideInternal
		{
			get
			{
				if(r_MGetIsDefaultOverrideInternal == null)
				{
					r_MGetIsDefaultOverrideInternal = new(this, "GetIsDefaultOverrideInternal", 0);
					r_MGetIsDefaultOverrideInternal.SetBelong(this.instance);
				}
				return r_MGetIsDefaultOverrideInternal;
			}
		}

		/// <summary>
		/// Boolean GetIsDrivenRectTransformPropertyInternal()
		/// </summary>
		protected RMethod r_MGetIsDrivenRectTransformPropertyInternal;
		public virtual RMethod RMGetIsDrivenRectTransformPropertyInternal
		{
			get
			{
				if(r_MGetIsDrivenRectTransformPropertyInternal == null)
				{
					r_MGetIsDrivenRectTransformPropertyInternal = new(this, "GetIsDrivenRectTransformPropertyInternal", 0);
					r_MGetIsDrivenRectTransformPropertyInternal.SetBelong(this.instance);
				}
				return r_MGetIsDrivenRectTransformPropertyInternal;
			}
		}

		/// <summary>
		/// Int32 GetSerializedPropertyTypeInternal()
		/// </summary>
		protected RMethod r_MGetSerializedPropertyTypeInternal;
		public virtual RMethod RMGetSerializedPropertyTypeInternal
		{
			get
			{
				if(r_MGetSerializedPropertyTypeInternal == null)
				{
					r_MGetSerializedPropertyTypeInternal = new(this, "GetSerializedPropertyTypeInternal", 0);
					r_MGetSerializedPropertyTypeInternal.SetBelong(this.instance);
				}
				return r_MGetSerializedPropertyTypeInternal;
			}
		}

		/// <summary>
		/// Int32 GetNumericTypeInternal()
		/// </summary>
		protected RMethod r_MGetNumericTypeInternal;
		public virtual RMethod RMGetNumericTypeInternal
		{
			get
			{
				if(r_MGetNumericTypeInternal == null)
				{
					r_MGetNumericTypeInternal = new(this, "GetNumericTypeInternal", 0);
					r_MGetNumericTypeInternal.SetBelong(this.instance);
				}
				return r_MGetNumericTypeInternal;
			}
		}

		/// <summary>
		/// Int64 GetIntValueInternal()
		/// </summary>
		protected RMethod r_MGetIntValueInternal;
		public virtual RMethod RMGetIntValueInternal
		{
			get
			{
				if(r_MGetIntValueInternal == null)
				{
					r_MGetIntValueInternal = new(this, "GetIntValueInternal", 0);
					r_MGetIntValueInternal.SetBelong(this.instance);
				}
				return r_MGetIntValueInternal;
			}
		}

		/// <summary>
		/// Void SetIntValueInternal(Int64)
		/// </summary>
		protected RMethod r_MSetIntValueInternal_Int64;
		public virtual RMethod RMSetIntValueInternal_Int64
		{
			get
			{
				if(r_MSetIntValueInternal_Int64 == null)
				{
					r_MSetIntValueInternal_Int64 = new(this, "SetIntValueInternal", 0, typeof(System.Int64));
					r_MSetIntValueInternal_Int64.SetBelong(this.instance);
				}
				return r_MSetIntValueInternal_Int64;
			}
		}

		/// <summary>
		/// Boolean GetBoolValueInternal()
		/// </summary>
		protected RMethod r_MGetBoolValueInternal;
		public virtual RMethod RMGetBoolValueInternal
		{
			get
			{
				if(r_MGetBoolValueInternal == null)
				{
					r_MGetBoolValueInternal = new(this, "GetBoolValueInternal", 0);
					r_MGetBoolValueInternal.SetBelong(this.instance);
				}
				return r_MGetBoolValueInternal;
			}
		}

		/// <summary>
		/// Void SetBoolValueInternal(Boolean)
		/// </summary>
		protected RMethod r_MSetBoolValueInternal_Boolean;
		public virtual RMethod RMSetBoolValueInternal_Boolean
		{
			get
			{
				if(r_MSetBoolValueInternal_Boolean == null)
				{
					r_MSetBoolValueInternal_Boolean = new(this, "SetBoolValueInternal", 0, typeof(System.Boolean));
					r_MSetBoolValueInternal_Boolean.SetBelong(this.instance);
				}
				return r_MSetBoolValueInternal_Boolean;
			}
		}

		/// <summary>
		/// Double GetFloatValueInternal()
		/// </summary>
		protected RMethod r_MGetFloatValueInternal;
		public virtual RMethod RMGetFloatValueInternal
		{
			get
			{
				if(r_MGetFloatValueInternal == null)
				{
					r_MGetFloatValueInternal = new(this, "GetFloatValueInternal", 0);
					r_MGetFloatValueInternal.SetBelong(this.instance);
				}
				return r_MGetFloatValueInternal;
			}
		}

		/// <summary>
		/// Void SetFloatValueInternal(Double)
		/// </summary>
		protected RMethod r_MSetFloatValueInternal_Double;
		public virtual RMethod RMSetFloatValueInternal_Double
		{
			get
			{
				if(r_MSetFloatValueInternal_Double == null)
				{
					r_MSetFloatValueInternal_Double = new(this, "SetFloatValueInternal", 0, typeof(System.Double));
					r_MSetFloatValueInternal_Double.SetBelong(this.instance);
				}
				return r_MSetFloatValueInternal_Double;
			}
		}

		/// <summary>
		/// Double[] GetAllFloatValues()
		/// </summary>
		protected RMethod r_MGetAllFloatValues;
		public virtual RMethod RMGetAllFloatValues
		{
			get
			{
				if(r_MGetAllFloatValues == null)
				{
					r_MGetAllFloatValues = new(this, "GetAllFloatValues", 0);
					r_MGetAllFloatValues.SetBelong(this.instance);
				}
				return r_MGetAllFloatValues;
			}
		}

		/// <summary>
		/// Void SetAllFloatValuesImmediate(Double[])
		/// </summary>
		protected RMethod r_MSetAllFloatValuesImmediate_DoubleArray;
		public virtual RMethod RMSetAllFloatValuesImmediate_DoubleArray
		{
			get
			{
				if(r_MSetAllFloatValuesImmediate_DoubleArray == null)
				{
					r_MSetAllFloatValuesImmediate_DoubleArray = new(this, "SetAllFloatValuesImmediate", 0, typeof(System.Double).MakeArrayType());
					r_MSetAllFloatValuesImmediate_DoubleArray.SetBelong(this.instance);
				}
				return r_MSetAllFloatValuesImmediate_DoubleArray;
			}
		}

		/// <summary>
		/// Int64[] GetAllIntValues()
		/// </summary>
		protected RMethod r_MGetAllIntValues;
		public virtual RMethod RMGetAllIntValues
		{
			get
			{
				if(r_MGetAllIntValues == null)
				{
					r_MGetAllIntValues = new(this, "GetAllIntValues", 0);
					r_MGetAllIntValues.SetBelong(this.instance);
				}
				return r_MGetAllIntValues;
			}
		}

		/// <summary>
		/// Void SetAllIntValuesImmediate(Int64[])
		/// </summary>
		protected RMethod r_MSetAllIntValuesImmediate_Int64Array;
		public virtual RMethod RMSetAllIntValuesImmediate_Int64Array
		{
			get
			{
				if(r_MSetAllIntValuesImmediate_Int64Array == null)
				{
					r_MSetAllIntValuesImmediate_Int64Array = new(this, "SetAllIntValuesImmediate", 0, typeof(System.Int64).MakeArrayType());
					r_MSetAllIntValuesImmediate_Int64Array.SetBelong(this.instance);
				}
				return r_MSetAllIntValuesImmediate_Int64Array;
			}
		}

		/// <summary>
		/// System.String GetStringValueInternal()
		/// </summary>
		protected RMethod r_MGetStringValueInternal;
		public virtual RMethod RMGetStringValueInternal
		{
			get
			{
				if(r_MGetStringValueInternal == null)
				{
					r_MGetStringValueInternal = new(this, "GetStringValueInternal", 0);
					r_MGetStringValueInternal.SetBelong(this.instance);
				}
				return r_MGetStringValueInternal;
			}
		}

		/// <summary>
		/// Void SetStringValueInternal(System.String)
		/// </summary>
		protected RMethod r_MSetStringValueInternal_String;
		public virtual RMethod RMSetStringValueInternal_String
		{
			get
			{
				if(r_MSetStringValueInternal_String == null)
				{
					r_MSetStringValueInternal_String = new(this, "SetStringValueInternal", 0, typeof(System.String));
					r_MSetStringValueInternal_String.SetBelong(this.instance);
				}
				return r_MSetStringValueInternal_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorValueInternal()
		/// </summary>
		protected RMethod r_MGetColorValueInternal;
		public virtual RMethod RMGetColorValueInternal
		{
			get
			{
				if(r_MGetColorValueInternal == null)
				{
					r_MGetColorValueInternal = new(this, "GetColorValueInternal", 0);
					r_MGetColorValueInternal.SetBelong(this.instance);
				}
				return r_MGetColorValueInternal;
			}
		}

		/// <summary>
		/// Void SetColorValueInternal(UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetColorValueInternal_Color;
		public virtual RMethod RMSetColorValueInternal_Color
		{
			get
			{
				if(r_MSetColorValueInternal_Color == null)
				{
					r_MSetColorValueInternal_Color = new(this, "SetColorValueInternal", 0, typeof(UnityEngine.Color));
					r_MSetColorValueInternal_Color.SetBelong(this.instance);
				}
				return r_MSetColorValueInternal_Color;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve GetAnimationCurveValueCopyInternal()
		/// </summary>
		protected RMethod r_MGetAnimationCurveValueCopyInternal;
		public virtual RMethod RMGetAnimationCurveValueCopyInternal
		{
			get
			{
				if(r_MGetAnimationCurveValueCopyInternal == null)
				{
					r_MGetAnimationCurveValueCopyInternal = new(this, "GetAnimationCurveValueCopyInternal", 0);
					r_MGetAnimationCurveValueCopyInternal.SetBelong(this.instance);
				}
				return r_MGetAnimationCurveValueCopyInternal;
			}
		}

		/// <summary>
		/// Void SetAnimationCurveValueInternal(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_MSetAnimationCurveValueInternal_AnimationCurve;
		public virtual RMethod RMSetAnimationCurveValueInternal_AnimationCurve
		{
			get
			{
				if(r_MSetAnimationCurveValueInternal_AnimationCurve == null)
				{
					r_MSetAnimationCurveValueInternal_AnimationCurve = new(this, "SetAnimationCurveValueInternal", 0, typeof(UnityEngine.AnimationCurve));
					r_MSetAnimationCurveValueInternal_AnimationCurve.SetBelong(this.instance);
				}
				return r_MSetAnimationCurveValueInternal_AnimationCurve;
			}
		}

		/// <summary>
		/// UnityEngine.Gradient GetGradientValueCopyInternal()
		/// </summary>
		protected RMethod r_MGetGradientValueCopyInternal;
		public virtual RMethod RMGetGradientValueCopyInternal
		{
			get
			{
				if(r_MGetGradientValueCopyInternal == null)
				{
					r_MGetGradientValueCopyInternal = new(this, "GetGradientValueCopyInternal", 0);
					r_MGetGradientValueCopyInternal.SetBelong(this.instance);
				}
				return r_MGetGradientValueCopyInternal;
			}
		}

		/// <summary>
		/// Void SetGradientValueInternal(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_MSetGradientValueInternal_Gradient;
		public virtual RMethod RMSetGradientValueInternal_Gradient
		{
			get
			{
				if(r_MSetGradientValueInternal_Gradient == null)
				{
					r_MSetGradientValueInternal_Gradient = new(this, "SetGradientValueInternal", 0, typeof(UnityEngine.Gradient));
					r_MSetGradientValueInternal_Gradient.SetBelong(this.instance);
				}
				return r_MSetGradientValueInternal_Gradient;
			}
		}

		/// <summary>
		/// Int64 GetManagedReferenceIdInternal()
		/// </summary>
		protected RMethod r_MGetManagedReferenceIdInternal;
		public virtual RMethod RMGetManagedReferenceIdInternal
		{
			get
			{
				if(r_MGetManagedReferenceIdInternal == null)
				{
					r_MGetManagedReferenceIdInternal = new(this, "GetManagedReferenceIdInternal", 0);
					r_MGetManagedReferenceIdInternal.SetBelong(this.instance);
				}
				return r_MGetManagedReferenceIdInternal;
			}
		}

		/// <summary>
		/// System.String GetManagedReferenceFullTypeNameInternal()
		/// </summary>
		protected RMethod r_MGetManagedReferenceFullTypeNameInternal;
		public virtual RMethod RMGetManagedReferenceFullTypeNameInternal
		{
			get
			{
				if(r_MGetManagedReferenceFullTypeNameInternal == null)
				{
					r_MGetManagedReferenceFullTypeNameInternal = new(this, "GetManagedReferenceFullTypeNameInternal", 0);
					r_MGetManagedReferenceFullTypeNameInternal.SetBelong(this.instance);
				}
				return r_MGetManagedReferenceFullTypeNameInternal;
			}
		}

		/// <summary>
		/// Void SetManagedReferenceValueInternal(System.Object)
		/// </summary>
		protected RMethod r_MSetManagedReferenceValueInternal_Object;
		public virtual RMethod RMSetManagedReferenceValueInternal_Object
		{
			get
			{
				if(r_MSetManagedReferenceValueInternal_Object == null)
				{
					r_MSetManagedReferenceValueInternal_Object = new(this, "SetManagedReferenceValueInternal", 0, typeof(System.Object));
					r_MSetManagedReferenceValueInternal_Object.SetBelong(this.instance);
				}
				return r_MSetManagedReferenceValueInternal_Object;
			}
		}

		/// <summary>
		/// Void SetStructValueInternal(System.Object)
		/// </summary>
		protected RMethod r_MSetStructValueInternal_Object;
		public virtual RMethod RMSetStructValueInternal_Object
		{
			get
			{
				if(r_MSetStructValueInternal_Object == null)
				{
					r_MSetStructValueInternal_Object = new(this, "SetStructValueInternal", 0, typeof(System.Object));
					r_MSetStructValueInternal_Object.SetBelong(this.instance);
				}
				return r_MSetStructValueInternal_Object;
			}
		}

		/// <summary>
		/// System.Object GetStructValueInternal(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MGetStructValueInternal_String_String_String;
		public virtual RMethod RMGetStructValueInternal_String_String_String
		{
			get
			{
				if(r_MGetStructValueInternal_String_String_String == null)
				{
					r_MGetStructValueInternal_String_String_String = new(this, "GetStructValueInternal", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_MGetStructValueInternal_String_String_String.SetBelong(this.instance);
				}
				return r_MGetStructValueInternal_String_String_String;
			}
		}

		/// <summary>
		/// System.Object LookupInstanceByIdInternal(Int64)
		/// </summary>
		protected RMethod r_MLookupInstanceByIdInternal_Int64;
		public virtual RMethod RMLookupInstanceByIdInternal_Int64
		{
			get
			{
				if(r_MLookupInstanceByIdInternal_Int64 == null)
				{
					r_MLookupInstanceByIdInternal_Int64 = new(this, "LookupInstanceByIdInternal", 0, typeof(System.Int64));
					r_MLookupInstanceByIdInternal_Int64.SetBelong(this.instance);
				}
				return r_MLookupInstanceByIdInternal_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetPPtrValueInternal()
		/// </summary>
		protected RMethod r_MGetPPtrValueInternal;
		public virtual RMethod RMGetPPtrValueInternal
		{
			get
			{
				if(r_MGetPPtrValueInternal == null)
				{
					r_MGetPPtrValueInternal = new(this, "GetPPtrValueInternal", 0);
					r_MGetPPtrValueInternal.SetBelong(this.instance);
				}
				return r_MGetPPtrValueInternal;
			}
		}

		/// <summary>
		/// Void SetPPtrValueInternal(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MSetPPtrValueInternal_Object;
		public virtual RMethod RMSetPPtrValueInternal_Object
		{
			get
			{
				if(r_MSetPPtrValueInternal_Object == null)
				{
					r_MSetPPtrValueInternal_Object = new(this, "SetPPtrValueInternal", 0, typeof(UnityEngine.Object));
					r_MSetPPtrValueInternal_Object.SetBelong(this.instance);
				}
				return r_MSetPPtrValueInternal_Object;
			}
		}

		/// <summary>
		/// Int32 GetPPtrValueFromInstanceIDInternal()
		/// </summary>
		protected RMethod r_MGetPPtrValueFromInstanceIDInternal;
		public virtual RMethod RMGetPPtrValueFromInstanceIDInternal
		{
			get
			{
				if(r_MGetPPtrValueFromInstanceIDInternal == null)
				{
					r_MGetPPtrValueFromInstanceIDInternal = new(this, "GetPPtrValueFromInstanceIDInternal", 0);
					r_MGetPPtrValueFromInstanceIDInternal.SetBelong(this.instance);
				}
				return r_MGetPPtrValueFromInstanceIDInternal;
			}
		}

		/// <summary>
		/// Void SetPPtrValueFromInstanceIDInternal(Int32)
		/// </summary>
		protected RMethod r_MSetPPtrValueFromInstanceIDInternal_Int32;
		public virtual RMethod RMSetPPtrValueFromInstanceIDInternal_Int32
		{
			get
			{
				if(r_MSetPPtrValueFromInstanceIDInternal_Int32 == null)
				{
					r_MSetPPtrValueFromInstanceIDInternal_Int32 = new(this, "SetPPtrValueFromInstanceIDInternal", 0, typeof(System.Int32));
					r_MSetPPtrValueFromInstanceIDInternal_Int32.SetBelong(this.instance);
				}
				return r_MSetPPtrValueFromInstanceIDInternal_Int32;
			}
		}

		/// <summary>
		/// System.String GetPPtrStringValueInternal()
		/// </summary>
		protected RMethod r_MGetPPtrStringValueInternal;
		public virtual RMethod RMGetPPtrStringValueInternal
		{
			get
			{
				if(r_MGetPPtrStringValueInternal == null)
				{
					r_MGetPPtrStringValueInternal = new(this, "GetPPtrStringValueInternal", 0);
					r_MGetPPtrStringValueInternal.SetBelong(this.instance);
				}
				return r_MGetPPtrStringValueInternal;
			}
		}

		/// <summary>
		/// Boolean ValidateObjectReferenceValue(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MValidateObjectReferenceValue_Object;
		public virtual RMethod RMValidateObjectReferenceValue_Object
		{
			get
			{
				if(r_MValidateObjectReferenceValue_Object == null)
				{
					r_MValidateObjectReferenceValue_Object = new(this, "ValidateObjectReferenceValue", 0, typeof(UnityEngine.Object));
					r_MValidateObjectReferenceValue_Object.SetBelong(this.instance);
				}
				return r_MValidateObjectReferenceValue_Object;
			}
		}

		/// <summary>
		/// Boolean ValidatePPtrValueInternal(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MValidatePPtrValueInternal_Object;
		public virtual RMethod RMValidatePPtrValueInternal_Object
		{
			get
			{
				if(r_MValidatePPtrValueInternal_Object == null)
				{
					r_MValidatePPtrValueInternal_Object = new(this, "ValidatePPtrValueInternal", 0, typeof(UnityEngine.Object));
					r_MValidatePPtrValueInternal_Object.SetBelong(this.instance);
				}
				return r_MValidatePPtrValueInternal_Object;
			}
		}

		/// <summary>
		/// Boolean ValidateObjectReferenceValueExact(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MValidateObjectReferenceValueExact_Object;
		public virtual RMethod RMValidateObjectReferenceValueExact_Object
		{
			get
			{
				if(r_MValidateObjectReferenceValueExact_Object == null)
				{
					r_MValidateObjectReferenceValueExact_Object = new(this, "ValidateObjectReferenceValueExact", 0, typeof(UnityEngine.Object));
					r_MValidateObjectReferenceValueExact_Object.SetBelong(this.instance);
				}
				return r_MValidateObjectReferenceValueExact_Object;
			}
		}

		/// <summary>
		/// Boolean ValidatePPtrValueExact(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MValidatePPtrValueExact_Object;
		public virtual RMethod RMValidatePPtrValueExact_Object
		{
			get
			{
				if(r_MValidatePPtrValueExact_Object == null)
				{
					r_MValidatePPtrValueExact_Object = new(this, "ValidatePPtrValueExact", 0, typeof(UnityEngine.Object));
					r_MValidatePPtrValueExact_Object.SetBelong(this.instance);
				}
				return r_MValidatePPtrValueExact_Object;
			}
		}

		/// <summary>
		/// System.String GetPPtrClassNameInternal()
		/// </summary>
		protected RMethod r_MGetPPtrClassNameInternal;
		public virtual RMethod RMGetPPtrClassNameInternal
		{
			get
			{
				if(r_MGetPPtrClassNameInternal == null)
				{
					r_MGetPPtrClassNameInternal = new(this, "GetPPtrClassNameInternal", 0);
					r_MGetPPtrClassNameInternal.SetBelong(this.instance);
				}
				return r_MGetPPtrClassNameInternal;
			}
		}

		/// <summary>
		/// Void AppendFoldoutPPtrValue(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MAppendFoldoutPPtrValue_Object;
		public virtual RMethod RMAppendFoldoutPPtrValue_Object
		{
			get
			{
				if(r_MAppendFoldoutPPtrValue_Object == null)
				{
					r_MAppendFoldoutPPtrValue_Object = new(this, "AppendFoldoutPPtrValue", 0, typeof(UnityEngine.Object));
					r_MAppendFoldoutPPtrValue_Object.SetBelong(this.instance);
				}
				return r_MAppendFoldoutPPtrValue_Object;
			}
		}

		/// <summary>
		/// Void AppendFoldoutPPtrValueInternal(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MAppendFoldoutPPtrValueInternal_Object;
		public virtual RMethod RMAppendFoldoutPPtrValueInternal_Object
		{
			get
			{
				if(r_MAppendFoldoutPPtrValueInternal_Object == null)
				{
					r_MAppendFoldoutPPtrValueInternal_Object = new(this, "AppendFoldoutPPtrValueInternal", 0, typeof(UnityEngine.Object));
					r_MAppendFoldoutPPtrValueInternal_Object.SetBelong(this.instance);
				}
				return r_MAppendFoldoutPPtrValueInternal_Object;
			}
		}

		/// <summary>
		/// System.String GetLayerMaskStringValue(UInt32)
		/// </summary>
		protected static RMethod r_MGetLayerMaskStringValue_UInt32;
		public static RMethod RMGetLayerMaskStringValue_UInt32
		{
			get
			{
				if(r_MGetLayerMaskStringValue_UInt32 == null)
				{
					r_MGetLayerMaskStringValue_UInt32 = new(typeof(UnityEditor.SerializedProperty), "GetLayerMaskStringValue", 0, typeof(System.UInt32));
					r_MGetLayerMaskStringValue_UInt32.SetBelong(null);
				}
				return r_MGetLayerMaskStringValue_UInt32;
			}
		}

		/// <summary>
		/// UInt32 GetLayerMaskBitsInternal()
		/// </summary>
		protected RMethod r_MGetLayerMaskBitsInternal;
		public virtual RMethod RMGetLayerMaskBitsInternal
		{
			get
			{
				if(r_MGetLayerMaskBitsInternal == null)
				{
					r_MGetLayerMaskBitsInternal = new(this, "GetLayerMaskBitsInternal", 0);
					r_MGetLayerMaskBitsInternal.SetBelong(this.instance);
				}
				return r_MGetLayerMaskBitsInternal;
			}
		}

		/// <summary>
		/// Int32 GetEnumValueIndexInternal()
		/// </summary>
		protected RMethod r_MGetEnumValueIndexInternal;
		public virtual RMethod RMGetEnumValueIndexInternal
		{
			get
			{
				if(r_MGetEnumValueIndexInternal == null)
				{
					r_MGetEnumValueIndexInternal = new(this, "GetEnumValueIndexInternal", 0);
					r_MGetEnumValueIndexInternal.SetBelong(this.instance);
				}
				return r_MGetEnumValueIndexInternal;
			}
		}

		/// <summary>
		/// Void SetEnumValueIndexInternal(Int32)
		/// </summary>
		protected RMethod r_MSetEnumValueIndexInternal_Int32;
		public virtual RMethod RMSetEnumValueIndexInternal_Int32
		{
			get
			{
				if(r_MSetEnumValueIndexInternal_Int32 == null)
				{
					r_MSetEnumValueIndexInternal_Int32 = new(this, "SetEnumValueIndexInternal", 0, typeof(System.Int32));
					r_MSetEnumValueIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_MSetEnumValueIndexInternal_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNamesInternal(Boolean)
		/// </summary>
		protected RMethod r_MGetEnumNamesInternal_Boolean;
		public virtual RMethod RMGetEnumNamesInternal_Boolean
		{
			get
			{
				if(r_MGetEnumNamesInternal_Boolean == null)
				{
					r_MGetEnumNamesInternal_Boolean = new(this, "GetEnumNamesInternal", 0, typeof(System.Boolean));
					r_MGetEnumNamesInternal_Boolean.SetBelong(this.instance);
				}
				return r_MGetEnumNamesInternal_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetValueVector2Internal()
		/// </summary>
		protected RMethod r_MGetValueVector2Internal;
		public virtual RMethod RMGetValueVector2Internal
		{
			get
			{
				if(r_MGetValueVector2Internal == null)
				{
					r_MGetValueVector2Internal = new(this, "GetValueVector2Internal", 0);
					r_MGetValueVector2Internal.SetBelong(this.instance);
				}
				return r_MGetValueVector2Internal;
			}
		}

		/// <summary>
		/// Void SetValueVector2Internal(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetValueVector2Internal_Vector2;
		public virtual RMethod RMSetValueVector2Internal_Vector2
		{
			get
			{
				if(r_MSetValueVector2Internal_Vector2 == null)
				{
					r_MSetValueVector2Internal_Vector2 = new(this, "SetValueVector2Internal", 0, typeof(UnityEngine.Vector2));
					r_MSetValueVector2Internal_Vector2.SetBelong(this.instance);
				}
				return r_MSetValueVector2Internal_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetValueVector3Internal()
		/// </summary>
		protected RMethod r_MGetValueVector3Internal;
		public virtual RMethod RMGetValueVector3Internal
		{
			get
			{
				if(r_MGetValueVector3Internal == null)
				{
					r_MGetValueVector3Internal = new(this, "GetValueVector3Internal", 0);
					r_MGetValueVector3Internal.SetBelong(this.instance);
				}
				return r_MGetValueVector3Internal;
			}
		}

		/// <summary>
		/// Void SetValueVector3Internal(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetValueVector3Internal_Vector3;
		public virtual RMethod RMSetValueVector3Internal_Vector3
		{
			get
			{
				if(r_MSetValueVector3Internal_Vector3 == null)
				{
					r_MSetValueVector3Internal_Vector3 = new(this, "SetValueVector3Internal", 0, typeof(UnityEngine.Vector3));
					r_MSetValueVector3Internal_Vector3.SetBelong(this.instance);
				}
				return r_MSetValueVector3Internal_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetValueVector4Internal()
		/// </summary>
		protected RMethod r_MGetValueVector4Internal;
		public virtual RMethod RMGetValueVector4Internal
		{
			get
			{
				if(r_MGetValueVector4Internal == null)
				{
					r_MGetValueVector4Internal = new(this, "GetValueVector4Internal", 0);
					r_MGetValueVector4Internal.SetBelong(this.instance);
				}
				return r_MGetValueVector4Internal;
			}
		}

		/// <summary>
		/// Void SetValueVector4Internal(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetValueVector4Internal_Vector4;
		public virtual RMethod RMSetValueVector4Internal_Vector4
		{
			get
			{
				if(r_MSetValueVector4Internal_Vector4 == null)
				{
					r_MSetValueVector4Internal_Vector4 = new(this, "SetValueVector4Internal", 0, typeof(UnityEngine.Vector4));
					r_MSetValueVector4Internal_Vector4.SetBelong(this.instance);
				}
				return r_MSetValueVector4Internal_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int GetValueVector2IntInternal()
		/// </summary>
		protected RMethod r_MGetValueVector2IntInternal;
		public virtual RMethod RMGetValueVector2IntInternal
		{
			get
			{
				if(r_MGetValueVector2IntInternal == null)
				{
					r_MGetValueVector2IntInternal = new(this, "GetValueVector2IntInternal", 0);
					r_MGetValueVector2IntInternal.SetBelong(this.instance);
				}
				return r_MGetValueVector2IntInternal;
			}
		}

		/// <summary>
		/// Void SetValueVector2IntInternal(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_MSetValueVector2IntInternal_Vector2Int;
		public virtual RMethod RMSetValueVector2IntInternal_Vector2Int
		{
			get
			{
				if(r_MSetValueVector2IntInternal_Vector2Int == null)
				{
					r_MSetValueVector2IntInternal_Vector2Int = new(this, "SetValueVector2IntInternal", 0, typeof(UnityEngine.Vector2Int));
					r_MSetValueVector2IntInternal_Vector2Int.SetBelong(this.instance);
				}
				return r_MSetValueVector2IntInternal_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int GetValueVector3IntInternal()
		/// </summary>
		protected RMethod r_MGetValueVector3IntInternal;
		public virtual RMethod RMGetValueVector3IntInternal
		{
			get
			{
				if(r_MGetValueVector3IntInternal == null)
				{
					r_MGetValueVector3IntInternal = new(this, "GetValueVector3IntInternal", 0);
					r_MGetValueVector3IntInternal.SetBelong(this.instance);
				}
				return r_MGetValueVector3IntInternal;
			}
		}

		/// <summary>
		/// Void SetValueVector3IntInternal(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_MSetValueVector3IntInternal_Vector3Int;
		public virtual RMethod RMSetValueVector3IntInternal_Vector3Int
		{
			get
			{
				if(r_MSetValueVector3IntInternal_Vector3Int == null)
				{
					r_MSetValueVector3IntInternal_Vector3Int = new(this, "SetValueVector3IntInternal", 0, typeof(UnityEngine.Vector3Int));
					r_MSetValueVector3IntInternal_Vector3Int.SetBelong(this.instance);
				}
				return r_MSetValueVector3IntInternal_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion GetValueQuaternionInternal()
		/// </summary>
		protected RMethod r_MGetValueQuaternionInternal;
		public virtual RMethod RMGetValueQuaternionInternal
		{
			get
			{
				if(r_MGetValueQuaternionInternal == null)
				{
					r_MGetValueQuaternionInternal = new(this, "GetValueQuaternionInternal", 0);
					r_MGetValueQuaternionInternal.SetBelong(this.instance);
				}
				return r_MGetValueQuaternionInternal;
			}
		}

		/// <summary>
		/// Void SetValueQuaternionInternal(UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_MSetValueQuaternionInternal_Quaternion;
		public virtual RMethod RMSetValueQuaternionInternal_Quaternion
		{
			get
			{
				if(r_MSetValueQuaternionInternal_Quaternion == null)
				{
					r_MSetValueQuaternionInternal_Quaternion = new(this, "SetValueQuaternionInternal", 0, typeof(UnityEngine.Quaternion));
					r_MSetValueQuaternionInternal_Quaternion.SetBelong(this.instance);
				}
				return r_MSetValueQuaternionInternal_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetValueRectInternal()
		/// </summary>
		protected RMethod r_MGetValueRectInternal;
		public virtual RMethod RMGetValueRectInternal
		{
			get
			{
				if(r_MGetValueRectInternal == null)
				{
					r_MGetValueRectInternal = new(this, "GetValueRectInternal", 0);
					r_MGetValueRectInternal.SetBelong(this.instance);
				}
				return r_MGetValueRectInternal;
			}
		}

		/// <summary>
		/// Void SetValueRectInternal(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetValueRectInternal_Rect;
		public virtual RMethod RMSetValueRectInternal_Rect
		{
			get
			{
				if(r_MSetValueRectInternal_Rect == null)
				{
					r_MSetValueRectInternal_Rect = new(this, "SetValueRectInternal", 0, typeof(UnityEngine.Rect));
					r_MSetValueRectInternal_Rect.SetBelong(this.instance);
				}
				return r_MSetValueRectInternal_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt GetValueRectIntInternal()
		/// </summary>
		protected RMethod r_MGetValueRectIntInternal;
		public virtual RMethod RMGetValueRectIntInternal
		{
			get
			{
				if(r_MGetValueRectIntInternal == null)
				{
					r_MGetValueRectIntInternal = new(this, "GetValueRectIntInternal", 0);
					r_MGetValueRectIntInternal.SetBelong(this.instance);
				}
				return r_MGetValueRectIntInternal;
			}
		}

		/// <summary>
		/// Void SetValueRectIntInternal(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_MSetValueRectIntInternal_RectInt;
		public virtual RMethod RMSetValueRectIntInternal_RectInt
		{
			get
			{
				if(r_MSetValueRectIntInternal_RectInt == null)
				{
					r_MSetValueRectIntInternal_RectInt = new(this, "SetValueRectIntInternal", 0, typeof(UnityEngine.RectInt));
					r_MSetValueRectIntInternal_RectInt.SetBelong(this.instance);
				}
				return r_MSetValueRectIntInternal_RectInt;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds GetValueBoundsInternal()
		/// </summary>
		protected RMethod r_MGetValueBoundsInternal;
		public virtual RMethod RMGetValueBoundsInternal
		{
			get
			{
				if(r_MGetValueBoundsInternal == null)
				{
					r_MGetValueBoundsInternal = new(this, "GetValueBoundsInternal", 0);
					r_MGetValueBoundsInternal.SetBelong(this.instance);
				}
				return r_MGetValueBoundsInternal;
			}
		}

		/// <summary>
		/// Void SetValueBoundsInternal(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_MSetValueBoundsInternal_Bounds;
		public virtual RMethod RMSetValueBoundsInternal_Bounds
		{
			get
			{
				if(r_MSetValueBoundsInternal_Bounds == null)
				{
					r_MSetValueBoundsInternal_Bounds = new(this, "SetValueBoundsInternal", 0, typeof(UnityEngine.Bounds));
					r_MSetValueBoundsInternal_Bounds.SetBelong(this.instance);
				}
				return r_MSetValueBoundsInternal_Bounds;
			}
		}

		/// <summary>
		/// UnityEngine.BoundsInt GetValueBoundsIntInternal()
		/// </summary>
		protected RMethod r_MGetValueBoundsIntInternal;
		public virtual RMethod RMGetValueBoundsIntInternal
		{
			get
			{
				if(r_MGetValueBoundsIntInternal == null)
				{
					r_MGetValueBoundsIntInternal = new(this, "GetValueBoundsIntInternal", 0);
					r_MGetValueBoundsIntInternal.SetBelong(this.instance);
				}
				return r_MGetValueBoundsIntInternal;
			}
		}

		/// <summary>
		/// Void SetValueBoundsIntInternal(UnityEngine.BoundsInt)
		/// </summary>
		protected RMethod r_MSetValueBoundsIntInternal_BoundsInt;
		public virtual RMethod RMSetValueBoundsIntInternal_BoundsInt
		{
			get
			{
				if(r_MSetValueBoundsIntInternal_BoundsInt == null)
				{
					r_MSetValueBoundsIntInternal_BoundsInt = new(this, "SetValueBoundsIntInternal", 0, typeof(UnityEngine.BoundsInt));
					r_MSetValueBoundsIntInternal_BoundsInt.SetBelong(this.instance);
				}
				return r_MSetValueBoundsIntInternal_BoundsInt;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 GetHash128ValueInternal()
		/// </summary>
		protected RMethod r_MGetHash128ValueInternal;
		public virtual RMethod RMGetHash128ValueInternal
		{
			get
			{
				if(r_MGetHash128ValueInternal == null)
				{
					r_MGetHash128ValueInternal = new(this, "GetHash128ValueInternal", 0);
					r_MGetHash128ValueInternal.SetBelong(this.instance);
				}
				return r_MGetHash128ValueInternal;
			}
		}

		/// <summary>
		/// Void SetHash128ValueInternal(UnityEngine.Hash128)
		/// </summary>
		protected RMethod r_MSetHash128ValueInternal_Hash128;
		public virtual RMethod RMSetHash128ValueInternal_Hash128
		{
			get
			{
				if(r_MSetHash128ValueInternal_Hash128 == null)
				{
					r_MSetHash128ValueInternal_Hash128 = new(this, "SetHash128ValueInternal", 0, typeof(UnityEngine.Hash128));
					r_MSetHash128ValueInternal_Hash128.SetBelong(this.instance);
				}
				return r_MSetHash128ValueInternal_Hash128;
			}
		}

		/// <summary>
		/// Boolean Next(Boolean)
		/// </summary>
		protected RMethod r_MNext_Boolean;
		public virtual RMethod RMNext_Boolean
		{
			get
			{
				if(r_MNext_Boolean == null)
				{
					r_MNext_Boolean = new(this, "Next", 0, typeof(System.Boolean));
					r_MNext_Boolean.SetBelong(this.instance);
				}
				return r_MNext_Boolean;
			}
		}

		/// <summary>
		/// Boolean NextInternal(Boolean)
		/// </summary>
		protected RMethod r_MNextInternal_Boolean;
		public virtual RMethod RMNextInternal_Boolean
		{
			get
			{
				if(r_MNextInternal_Boolean == null)
				{
					r_MNextInternal_Boolean = new(this, "NextInternal", 0, typeof(System.Boolean));
					r_MNextInternal_Boolean.SetBelong(this.instance);
				}
				return r_MNextInternal_Boolean;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void ResetInternal()
		/// </summary>
		protected RMethod r_MResetInternal;
		public virtual RMethod RMResetInternal
		{
			get
			{
				if(r_MResetInternal == null)
				{
					r_MResetInternal = new(this, "ResetInternal", 0);
					r_MResetInternal.SetBelong(this.instance);
				}
				return r_MResetInternal;
			}
		}

		/// <summary>
		/// Int32 CountRemaining()
		/// </summary>
		protected RMethod r_MCountRemaining;
		public virtual RMethod RMCountRemaining
		{
			get
			{
				if(r_MCountRemaining == null)
				{
					r_MCountRemaining = new(this, "CountRemaining", 0);
					r_MCountRemaining.SetBelong(this.instance);
				}
				return r_MCountRemaining;
			}
		}

		/// <summary>
		/// Int32 CountRemainingInternal()
		/// </summary>
		protected RMethod r_MCountRemainingInternal;
		public virtual RMethod RMCountRemainingInternal
		{
			get
			{
				if(r_MCountRemainingInternal == null)
				{
					r_MCountRemainingInternal = new(this, "CountRemainingInternal", 0);
					r_MCountRemainingInternal.SetBelong(this.instance);
				}
				return r_MCountRemainingInternal;
			}
		}

		/// <summary>
		/// Int32 CountInProperty()
		/// </summary>
		protected RMethod r_MCountInProperty;
		public virtual RMethod RMCountInProperty
		{
			get
			{
				if(r_MCountInProperty == null)
				{
					r_MCountInProperty = new(this, "CountInProperty", 0);
					r_MCountInProperty.SetBelong(this.instance);
				}
				return r_MCountInProperty;
			}
		}

		/// <summary>
		/// Int32 CountInPropertyInternal()
		/// </summary>
		protected RMethod r_MCountInPropertyInternal;
		public virtual RMethod RMCountInPropertyInternal
		{
			get
			{
				if(r_MCountInPropertyInternal == null)
				{
					r_MCountInPropertyInternal = new(this, "CountInPropertyInternal", 0);
					r_MCountInPropertyInternal.SetBelong(this.instance);
				}
				return r_MCountInPropertyInternal;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty CopyInternal()
		/// </summary>
		protected RMethod r_MCopyInternal;
		public virtual RMethod RMCopyInternal
		{
			get
			{
				if(r_MCopyInternal == null)
				{
					r_MCopyInternal = new(this, "CopyInternal", 0);
					r_MCopyInternal.SetBelong(this.instance);
				}
				return r_MCopyInternal;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty CopyInternalImpl()
		/// </summary>
		protected RMethod r_MCopyInternalImpl;
		public virtual RMethod RMCopyInternalImpl
		{
			get
			{
				if(r_MCopyInternalImpl == null)
				{
					r_MCopyInternalImpl = new(this, "CopyInternalImpl", 0);
					r_MCopyInternalImpl.SetBelong(this.instance);
				}
				return r_MCopyInternalImpl;
			}
		}

		/// <summary>
		/// Boolean DuplicateCommand()
		/// </summary>
		protected RMethod r_MDuplicateCommand;
		public virtual RMethod RMDuplicateCommand
		{
			get
			{
				if(r_MDuplicateCommand == null)
				{
					r_MDuplicateCommand = new(this, "DuplicateCommand", 0);
					r_MDuplicateCommand.SetBelong(this.instance);
				}
				return r_MDuplicateCommand;
			}
		}

		/// <summary>
		/// Boolean DuplicateCommandInternal()
		/// </summary>
		protected RMethod r_MDuplicateCommandInternal;
		public virtual RMethod RMDuplicateCommandInternal
		{
			get
			{
				if(r_MDuplicateCommandInternal == null)
				{
					r_MDuplicateCommandInternal = new(this, "DuplicateCommandInternal", 0);
					r_MDuplicateCommandInternal.SetBelong(this.instance);
				}
				return r_MDuplicateCommandInternal;
			}
		}

		/// <summary>
		/// Boolean DeleteCommand()
		/// </summary>
		protected RMethod r_MDeleteCommand;
		public virtual RMethod RMDeleteCommand
		{
			get
			{
				if(r_MDeleteCommand == null)
				{
					r_MDeleteCommand = new(this, "DeleteCommand", 0);
					r_MDeleteCommand.SetBelong(this.instance);
				}
				return r_MDeleteCommand;
			}
		}

		/// <summary>
		/// Boolean DeleteCommandInternal()
		/// </summary>
		protected RMethod r_MDeleteCommandInternal;
		public virtual RMethod RMDeleteCommandInternal
		{
			get
			{
				if(r_MDeleteCommandInternal == null)
				{
					r_MDeleteCommandInternal = new(this, "DeleteCommandInternal", 0);
					r_MDeleteCommandInternal.SetBelong(this.instance);
				}
				return r_MDeleteCommandInternal;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetEndProperty()
		/// </summary>
		protected RMethod r_MGetEndProperty;
		public virtual RMethod RMGetEndProperty
		{
			get
			{
				if(r_MGetEndProperty == null)
				{
					r_MGetEndProperty = new(this, "GetEndProperty", 0);
					r_MGetEndProperty.SetBelong(this.instance);
				}
				return r_MGetEndProperty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetEndProperty(Boolean)
		/// </summary>
		protected RMethod r_MGetEndProperty_Boolean;
		public virtual RMethod RMGetEndProperty_Boolean
		{
			get
			{
				if(r_MGetEndProperty_Boolean == null)
				{
					r_MGetEndProperty_Boolean = new(this, "GetEndProperty", 0, typeof(System.Boolean));
					r_MGetEndProperty_Boolean.SetBelong(this.instance);
				}
				return r_MGetEndProperty_Boolean;
			}
		}

		/// <summary>
		/// Boolean FindPropertyRelativeInternal(System.String)
		/// </summary>
		protected RMethod r_MFindPropertyRelativeInternal_String;
		public virtual RMethod RMFindPropertyRelativeInternal_String
		{
			get
			{
				if(r_MFindPropertyRelativeInternal_String == null)
				{
					r_MFindPropertyRelativeInternal_String = new(this, "FindPropertyRelativeInternal", 0, typeof(System.String));
					r_MFindPropertyRelativeInternal_String.SetBelong(this.instance);
				}
				return r_MFindPropertyRelativeInternal_String;
			}
		}

		/// <summary>
		/// Boolean FindRelativeProperty(System.String)
		/// </summary>
		protected RMethod r_MFindRelativeProperty_String;
		public virtual RMethod RMFindRelativeProperty_String
		{
			get
			{
				if(r_MFindRelativeProperty_String == null)
				{
					r_MFindRelativeProperty_String = new(this, "FindRelativeProperty", 0, typeof(System.String));
					r_MFindRelativeProperty_String.SetBelong(this.instance);
				}
				return r_MFindRelativeProperty_String;
			}
		}

		/// <summary>
		/// Boolean IsArray()
		/// </summary>
		protected RMethod r_MIsArray;
		public virtual RMethod RMIsArray
		{
			get
			{
				if(r_MIsArray == null)
				{
					r_MIsArray = new(this, "IsArray", 0);
					r_MIsArray.SetBelong(this.instance);
				}
				return r_MIsArray;
			}
		}

		/// <summary>
		/// Int32 GetMinArraySize()
		/// </summary>
		protected RMethod r_MGetMinArraySize;
		public virtual RMethod RMGetMinArraySize
		{
			get
			{
				if(r_MGetMinArraySize == null)
				{
					r_MGetMinArraySize = new(this, "GetMinArraySize", 0);
					r_MGetMinArraySize.SetBelong(this.instance);
				}
				return r_MGetMinArraySize;
			}
		}

		/// <summary>
		/// Int32 GetInspectableArraySize()
		/// </summary>
		protected RMethod r_MGetInspectableArraySize;
		public virtual RMethod RMGetInspectableArraySize
		{
			get
			{
				if(r_MGetInspectableArraySize == null)
				{
					r_MGetInspectableArraySize = new(this, "GetInspectableArraySize", 0);
					r_MGetInspectableArraySize.SetBelong(this.instance);
				}
				return r_MGetInspectableArraySize;
			}
		}

		/// <summary>
		/// Void ResizeArray(Int32)
		/// </summary>
		protected RMethod r_MResizeArray_Int32;
		public virtual RMethod RMResizeArray_Int32
		{
			get
			{
				if(r_MResizeArray_Int32 == null)
				{
					r_MResizeArray_Int32 = new(this, "ResizeArray", 0, typeof(System.Int32));
					r_MResizeArray_Int32.SetBelong(this.instance);
				}
				return r_MResizeArray_Int32;
			}
		}

		/// <summary>
		/// Boolean GetArrayElementAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_MGetArrayElementAtIndexInternal_Int32;
		public virtual RMethod RMGetArrayElementAtIndexInternal_Int32
		{
			get
			{
				if(r_MGetArrayElementAtIndexInternal_Int32 == null)
				{
					r_MGetArrayElementAtIndexInternal_Int32 = new(this, "GetArrayElementAtIndexInternal", 0, typeof(System.Int32));
					r_MGetArrayElementAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_MGetArrayElementAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean GetArrayElementAtIndexImpl(Int32)
		/// </summary>
		protected RMethod r_MGetArrayElementAtIndexImpl_Int32;
		public virtual RMethod RMGetArrayElementAtIndexImpl_Int32
		{
			get
			{
				if(r_MGetArrayElementAtIndexImpl_Int32 == null)
				{
					r_MGetArrayElementAtIndexImpl_Int32 = new(this, "GetArrayElementAtIndexImpl", 0, typeof(System.Int32));
					r_MGetArrayElementAtIndexImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetArrayElementAtIndexImpl_Int32;
			}
		}

		/// <summary>
		/// Void InsertArrayElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_MInsertArrayElementAtIndex_Int32;
		public virtual RMethod RMInsertArrayElementAtIndex_Int32
		{
			get
			{
				if(r_MInsertArrayElementAtIndex_Int32 == null)
				{
					r_MInsertArrayElementAtIndex_Int32 = new(this, "InsertArrayElementAtIndex", 0, typeof(System.Int32));
					r_MInsertArrayElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_MInsertArrayElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void InsertArrayElementAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_MInsertArrayElementAtIndexInternal_Int32;
		public virtual RMethod RMInsertArrayElementAtIndexInternal_Int32
		{
			get
			{
				if(r_MInsertArrayElementAtIndexInternal_Int32 == null)
				{
					r_MInsertArrayElementAtIndexInternal_Int32 = new(this, "InsertArrayElementAtIndexInternal", 0, typeof(System.Int32));
					r_MInsertArrayElementAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_MInsertArrayElementAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Void DeleteArrayElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_MDeleteArrayElementAtIndex_Int32;
		public virtual RMethod RMDeleteArrayElementAtIndex_Int32
		{
			get
			{
				if(r_MDeleteArrayElementAtIndex_Int32 == null)
				{
					r_MDeleteArrayElementAtIndex_Int32 = new(this, "DeleteArrayElementAtIndex", 0, typeof(System.Int32));
					r_MDeleteArrayElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_MDeleteArrayElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Void DeleteArrayElementAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_MDeleteArrayElementAtIndexInternal_Int32;
		public virtual RMethod RMDeleteArrayElementAtIndexInternal_Int32
		{
			get
			{
				if(r_MDeleteArrayElementAtIndexInternal_Int32 == null)
				{
					r_MDeleteArrayElementAtIndexInternal_Int32 = new(this, "DeleteArrayElementAtIndexInternal", 0, typeof(System.Int32));
					r_MDeleteArrayElementAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_MDeleteArrayElementAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveArrayElement(Int32, Int32)
		/// </summary>
		protected RMethod r_MMoveArrayElement_Int32_Int32;
		public virtual RMethod RMMoveArrayElement_Int32_Int32
		{
			get
			{
				if(r_MMoveArrayElement_Int32_Int32 == null)
				{
					r_MMoveArrayElement_Int32_Int32 = new(this, "MoveArrayElement", 0, typeof(System.Int32), typeof(System.Int32));
					r_MMoveArrayElement_Int32_Int32.SetBelong(this.instance);
				}
				return r_MMoveArrayElement_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveArrayElementInternal(Int32, Int32)
		/// </summary>
		protected RMethod r_MMoveArrayElementInternal_Int32_Int32;
		public virtual RMethod RMMoveArrayElementInternal_Int32_Int32
		{
			get
			{
				if(r_MMoveArrayElementInternal_Int32_Int32 == null)
				{
					r_MMoveArrayElementInternal_Int32_Int32 = new(this, "MoveArrayElementInternal", 0, typeof(System.Int32), typeof(System.Int32));
					r_MMoveArrayElementInternal_Int32_Int32.SetBelong(this.instance);
				}
				return r_MMoveArrayElementInternal_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsFixedBuffer()
		/// </summary>
		protected RMethod r_MIsFixedBuffer;
		public virtual RMethod RMIsFixedBuffer
		{
			get
			{
				if(r_MIsFixedBuffer == null)
				{
					r_MIsFixedBuffer = new(this, "IsFixedBuffer", 0);
					r_MIsFixedBuffer.SetBelong(this.instance);
				}
				return r_MIsFixedBuffer;
			}
		}

		/// <summary>
		/// Int32 GetFixedBufferSize()
		/// </summary>
		protected RMethod r_MGetFixedBufferSize;
		public virtual RMethod RMGetFixedBufferSize
		{
			get
			{
				if(r_MGetFixedBufferSize == null)
				{
					r_MGetFixedBufferSize = new(this, "GetFixedBufferSize", 0);
					r_MGetFixedBufferSize.SetBelong(this.instance);
				}
				return r_MGetFixedBufferSize;
			}
		}

		/// <summary>
		/// Boolean GetIsValidDisplayNameCache()
		/// </summary>
		protected RMethod r_MGetIsValidDisplayNameCache;
		public virtual RMethod RMGetIsValidDisplayNameCache
		{
			get
			{
				if(r_MGetIsValidDisplayNameCache == null)
				{
					r_MGetIsValidDisplayNameCache = new(this, "GetIsValidDisplayNameCache", 0);
					r_MGetIsValidDisplayNameCache.SetBelong(this.instance);
				}
				return r_MGetIsValidDisplayNameCache;
			}
		}

		/// <summary>
		/// Void SetIsValidDisplayNameCache(Boolean)
		/// </summary>
		protected RMethod r_MSetIsValidDisplayNameCache_Boolean;
		public virtual RMethod RMSetIsValidDisplayNameCache_Boolean
		{
			get
			{
				if(r_MSetIsValidDisplayNameCache_Boolean == null)
				{
					r_MSetIsValidDisplayNameCache_Boolean = new(this, "SetIsValidDisplayNameCache", 0, typeof(System.Boolean));
					r_MSetIsValidDisplayNameCache_Boolean.SetBelong(this.instance);
				}
				return r_MSetIsValidDisplayNameCache_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetIsValidTooltipCache()
		/// </summary>
		protected RMethod r_MGetIsValidTooltipCache;
		public virtual RMethod RMGetIsValidTooltipCache
		{
			get
			{
				if(r_MGetIsValidTooltipCache == null)
				{
					r_MGetIsValidTooltipCache = new(this, "GetIsValidTooltipCache", 0);
					r_MGetIsValidTooltipCache.SetBelong(this.instance);
				}
				return r_MGetIsValidTooltipCache;
			}
		}

		/// <summary>
		/// Void SetIsValidTooltipCache(Boolean)
		/// </summary>
		protected RMethod r_MSetIsValidTooltipCache_Boolean;
		public virtual RMethod RMSetIsValidTooltipCache_Boolean
		{
			get
			{
				if(r_MSetIsValidTooltipCache_Boolean == null)
				{
					r_MSetIsValidTooltipCache_Boolean = new(this, "SetIsValidTooltipCache", 0, typeof(System.Boolean));
					r_MSetIsValidTooltipCache_Boolean.SetBelong(this.instance);
				}
				return r_MSetIsValidTooltipCache_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetFixedBufferElementAtIndex(Int32)
		/// </summary>
		protected RMethod r_MGetFixedBufferElementAtIndex_Int32;
		public virtual RMethod RMGetFixedBufferElementAtIndex_Int32
		{
			get
			{
				if(r_MGetFixedBufferElementAtIndex_Int32 == null)
				{
					r_MGetFixedBufferElementAtIndex_Int32 = new(this, "GetFixedBufferElementAtIndex", 0, typeof(System.Int32));
					r_MGetFixedBufferElementAtIndex_Int32.SetBelong(this.instance);
				}
				return r_MGetFixedBufferElementAtIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean GetFixedBufferAtIndexInternal(Int32)
		/// </summary>
		protected RMethod r_MGetFixedBufferAtIndexInternal_Int32;
		public virtual RMethod RMGetFixedBufferAtIndexInternal_Int32
		{
			get
			{
				if(r_MGetFixedBufferAtIndexInternal_Int32 == null)
				{
					r_MGetFixedBufferAtIndexInternal_Int32 = new(this, "GetFixedBufferAtIndexInternal", 0, typeof(System.Int32));
					r_MGetFixedBufferAtIndexInternal_Int32.SetBelong(this.instance);
				}
				return r_MGetFixedBufferAtIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean AnimationCurveValueEquals(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_MAnimationCurveValueEquals_AnimationCurve;
		public virtual RMethod RMAnimationCurveValueEquals_AnimationCurve
		{
			get
			{
				if(r_MAnimationCurveValueEquals_AnimationCurve == null)
				{
					r_MAnimationCurveValueEquals_AnimationCurve = new(this, "AnimationCurveValueEquals", 0, typeof(UnityEngine.AnimationCurve));
					r_MAnimationCurveValueEquals_AnimationCurve.SetBelong(this.instance);
				}
				return r_MAnimationCurveValueEquals_AnimationCurve;
			}
		}

		/// <summary>
		/// Boolean ValueEquals(UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_MValueEquals_AnimationCurve;
		public virtual RMethod RMValueEquals_AnimationCurve
		{
			get
			{
				if(r_MValueEquals_AnimationCurve == null)
				{
					r_MValueEquals_AnimationCurve = new(this, "ValueEquals", 0, typeof(UnityEngine.AnimationCurve));
					r_MValueEquals_AnimationCurve.SetBelong(this.instance);
				}
				return r_MValueEquals_AnimationCurve;
			}
		}

		/// <summary>
		/// Boolean GradientValueEquals(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_MGradientValueEquals_Gradient;
		public virtual RMethod RMGradientValueEquals_Gradient
		{
			get
			{
				if(r_MGradientValueEquals_Gradient == null)
				{
					r_MGradientValueEquals_Gradient = new(this, "GradientValueEquals", 0, typeof(UnityEngine.Gradient));
					r_MGradientValueEquals_Gradient.SetBelong(this.instance);
				}
				return r_MGradientValueEquals_Gradient;
			}
		}

		/// <summary>
		/// Boolean ValueEquals(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_MValueEquals_Gradient;
		public virtual RMethod RMValueEquals_Gradient
		{
			get
			{
				if(r_MValueEquals_Gradient == null)
				{
					r_MValueEquals_Gradient = new(this, "ValueEquals", 0, typeof(UnityEngine.Gradient));
					r_MValueEquals_Gradient.SetBelong(this.instance);
				}
				return r_MValueEquals_Gradient;
			}
		}

		/// <summary>
		/// Boolean StringValueEquals(System.String)
		/// </summary>
		protected RMethod r_MStringValueEquals_String;
		public virtual RMethod RMStringValueEquals_String
		{
			get
			{
				if(r_MStringValueEquals_String == null)
				{
					r_MStringValueEquals_String = new(this, "StringValueEquals", 0, typeof(System.String));
					r_MStringValueEquals_String.SetBelong(this.instance);
				}
				return r_MStringValueEquals_String;
			}
		}

		/// <summary>
		/// Boolean ValueEquals(System.String)
		/// </summary>
		protected RMethod r_MValueEquals_String;
		public virtual RMethod RMValueEquals_String
		{
			get
			{
				if(r_MValueEquals_String == null)
				{
					r_MValueEquals_String = new(this, "ValueEquals", 0, typeof(System.String));
					r_MValueEquals_String.SetBelong(this.instance);
				}
				return r_MValueEquals_String;
			}
		}

		/// <summary>
		/// Boolean IsValidInternal()
		/// </summary>
		protected RMethod r_MIsValidInternal;
		public virtual RMethod RMIsValidInternal
		{
			get
			{
				if(r_MIsValidInternal == null)
				{
					r_MIsValidInternal = new(this, "IsValidInternal", 0);
					r_MIsValidInternal.SetBelong(this.instance);
				}
				return r_MIsValidInternal;
			}
		}

		/// <summary>
		/// UInt32 GetContentHashInternal()
		/// </summary>
		protected RMethod r_MGetContentHashInternal;
		public virtual RMethod RMGetContentHashInternal
		{
			get
			{
				if(r_MGetContentHashInternal == null)
				{
					r_MGetContentHashInternal = new(this, "GetContentHashInternal", 0);
					r_MGetContentHashInternal.SetBelong(this.instance);
				}
				return r_MGetContentHashInternal;
			}
		}

		/// <summary>
		/// Void GetColorValueInternal_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MGetColorValueInternal_Injected_Out_Color;
		public virtual RMethod RMGetColorValueInternal_Injected_Out_Color
		{
			get
			{
				if(r_MGetColorValueInternal_Injected_Out_Color == null)
				{
					r_MGetColorValueInternal_Injected_Out_Color = new(this, "GetColorValueInternal_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_MGetColorValueInternal_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_MGetColorValueInternal_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void SetColorValueInternal_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MSetColorValueInternal_Injected_Ref_Color;
		public virtual RMethod RMSetColorValueInternal_Injected_Ref_Color
		{
			get
			{
				if(r_MSetColorValueInternal_Injected_Ref_Color == null)
				{
					r_MSetColorValueInternal_Injected_Ref_Color = new(this, "SetColorValueInternal_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_MSetColorValueInternal_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_MSetColorValueInternal_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void GetValueVector2Internal_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MGetValueVector2Internal_Injected_Out_Vector2;
		public virtual RMethod RMGetValueVector2Internal_Injected_Out_Vector2
		{
			get
			{
				if(r_MGetValueVector2Internal_Injected_Out_Vector2 == null)
				{
					r_MGetValueVector2Internal_Injected_Out_Vector2 = new(this, "GetValueVector2Internal_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_MGetValueVector2Internal_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_MGetValueVector2Internal_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void SetValueVector2Internal_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MSetValueVector2Internal_Injected_Ref_Vector2;
		public virtual RMethod RMSetValueVector2Internal_Injected_Ref_Vector2
		{
			get
			{
				if(r_MSetValueVector2Internal_Injected_Ref_Vector2 == null)
				{
					r_MSetValueVector2Internal_Injected_Ref_Vector2 = new(this, "SetValueVector2Internal_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_MSetValueVector2Internal_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_MSetValueVector2Internal_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void GetValueVector3Internal_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MGetValueVector3Internal_Injected_Out_Vector3;
		public virtual RMethod RMGetValueVector3Internal_Injected_Out_Vector3
		{
			get
			{
				if(r_MGetValueVector3Internal_Injected_Out_Vector3 == null)
				{
					r_MGetValueVector3Internal_Injected_Out_Vector3 = new(this, "GetValueVector3Internal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_MGetValueVector3Internal_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_MGetValueVector3Internal_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SetValueVector3Internal_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MSetValueVector3Internal_Injected_Ref_Vector3;
		public virtual RMethod RMSetValueVector3Internal_Injected_Ref_Vector3
		{
			get
			{
				if(r_MSetValueVector3Internal_Injected_Ref_Vector3 == null)
				{
					r_MSetValueVector3Internal_Injected_Ref_Vector3 = new(this, "SetValueVector3Internal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_MSetValueVector3Internal_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_MSetValueVector3Internal_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void GetValueVector4Internal_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetValueVector4Internal_Injected_Out_Vector4;
		public virtual RMethod RMGetValueVector4Internal_Injected_Out_Vector4
		{
			get
			{
				if(r_MGetValueVector4Internal_Injected_Out_Vector4 == null)
				{
					r_MGetValueVector4Internal_Injected_Out_Vector4 = new(this, "GetValueVector4Internal_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetValueVector4Internal_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_MGetValueVector4Internal_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetValueVector4Internal_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetValueVector4Internal_Injected_Ref_Vector4;
		public virtual RMethod RMSetValueVector4Internal_Injected_Ref_Vector4
		{
			get
			{
				if(r_MSetValueVector4Internal_Injected_Ref_Vector4 == null)
				{
					r_MSetValueVector4Internal_Injected_Ref_Vector4 = new(this, "SetValueVector4Internal_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_MSetValueVector4Internal_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_MSetValueVector4Internal_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void GetValueVector2IntInternal_Injected(UnityEngine.Vector2Int ByRef)
		/// </summary>
		protected RMethod r_MGetValueVector2IntInternal_Injected_Out_Vector2Int;
		public virtual RMethod RMGetValueVector2IntInternal_Injected_Out_Vector2Int
		{
			get
			{
				if(r_MGetValueVector2IntInternal_Injected_Out_Vector2Int == null)
				{
					r_MGetValueVector2IntInternal_Injected_Out_Vector2Int = new(this, "GetValueVector2IntInternal_Injected", 0, typeof(UnityEngine.Vector2Int).MakeByRefType());
					r_MGetValueVector2IntInternal_Injected_Out_Vector2Int.SetBelong(this.instance);
				}
				return r_MGetValueVector2IntInternal_Injected_Out_Vector2Int;
			}
		}

		/// <summary>
		/// Void SetValueVector2IntInternal_Injected(UnityEngine.Vector2Int ByRef)
		/// </summary>
		protected RMethod r_MSetValueVector2IntInternal_Injected_Ref_Vector2Int;
		public virtual RMethod RMSetValueVector2IntInternal_Injected_Ref_Vector2Int
		{
			get
			{
				if(r_MSetValueVector2IntInternal_Injected_Ref_Vector2Int == null)
				{
					r_MSetValueVector2IntInternal_Injected_Ref_Vector2Int = new(this, "SetValueVector2IntInternal_Injected", 0, typeof(UnityEngine.Vector2Int).MakeByRefType());
					r_MSetValueVector2IntInternal_Injected_Ref_Vector2Int.SetBelong(this.instance);
				}
				return r_MSetValueVector2IntInternal_Injected_Ref_Vector2Int;
			}
		}

		/// <summary>
		/// Void GetValueVector3IntInternal_Injected(UnityEngine.Vector3Int ByRef)
		/// </summary>
		protected RMethod r_MGetValueVector3IntInternal_Injected_Out_Vector3Int;
		public virtual RMethod RMGetValueVector3IntInternal_Injected_Out_Vector3Int
		{
			get
			{
				if(r_MGetValueVector3IntInternal_Injected_Out_Vector3Int == null)
				{
					r_MGetValueVector3IntInternal_Injected_Out_Vector3Int = new(this, "GetValueVector3IntInternal_Injected", 0, typeof(UnityEngine.Vector3Int).MakeByRefType());
					r_MGetValueVector3IntInternal_Injected_Out_Vector3Int.SetBelong(this.instance);
				}
				return r_MGetValueVector3IntInternal_Injected_Out_Vector3Int;
			}
		}

		/// <summary>
		/// Void SetValueVector3IntInternal_Injected(UnityEngine.Vector3Int ByRef)
		/// </summary>
		protected RMethod r_MSetValueVector3IntInternal_Injected_Ref_Vector3Int;
		public virtual RMethod RMSetValueVector3IntInternal_Injected_Ref_Vector3Int
		{
			get
			{
				if(r_MSetValueVector3IntInternal_Injected_Ref_Vector3Int == null)
				{
					r_MSetValueVector3IntInternal_Injected_Ref_Vector3Int = new(this, "SetValueVector3IntInternal_Injected", 0, typeof(UnityEngine.Vector3Int).MakeByRefType());
					r_MSetValueVector3IntInternal_Injected_Ref_Vector3Int.SetBelong(this.instance);
				}
				return r_MSetValueVector3IntInternal_Injected_Ref_Vector3Int;
			}
		}

		/// <summary>
		/// Void GetValueQuaternionInternal_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_MGetValueQuaternionInternal_Injected_Out_Quaternion;
		public virtual RMethod RMGetValueQuaternionInternal_Injected_Out_Quaternion
		{
			get
			{
				if(r_MGetValueQuaternionInternal_Injected_Out_Quaternion == null)
				{
					r_MGetValueQuaternionInternal_Injected_Out_Quaternion = new(this, "GetValueQuaternionInternal_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_MGetValueQuaternionInternal_Injected_Out_Quaternion.SetBelong(this.instance);
				}
				return r_MGetValueQuaternionInternal_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void SetValueQuaternionInternal_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_MSetValueQuaternionInternal_Injected_Ref_Quaternion;
		public virtual RMethod RMSetValueQuaternionInternal_Injected_Ref_Quaternion
		{
			get
			{
				if(r_MSetValueQuaternionInternal_Injected_Ref_Quaternion == null)
				{
					r_MSetValueQuaternionInternal_Injected_Ref_Quaternion = new(this, "SetValueQuaternionInternal_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_MSetValueQuaternionInternal_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_MSetValueQuaternionInternal_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void GetValueRectInternal_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MGetValueRectInternal_Injected_Out_Rect;
		public virtual RMethod RMGetValueRectInternal_Injected_Out_Rect
		{
			get
			{
				if(r_MGetValueRectInternal_Injected_Out_Rect == null)
				{
					r_MGetValueRectInternal_Injected_Out_Rect = new(this, "GetValueRectInternal_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_MGetValueRectInternal_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_MGetValueRectInternal_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void SetValueRectInternal_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MSetValueRectInternal_Injected_Ref_Rect;
		public virtual RMethod RMSetValueRectInternal_Injected_Ref_Rect
		{
			get
			{
				if(r_MSetValueRectInternal_Injected_Ref_Rect == null)
				{
					r_MSetValueRectInternal_Injected_Ref_Rect = new(this, "SetValueRectInternal_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_MSetValueRectInternal_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_MSetValueRectInternal_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void GetValueRectIntInternal_Injected(UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_MGetValueRectIntInternal_Injected_Out_RectInt;
		public virtual RMethod RMGetValueRectIntInternal_Injected_Out_RectInt
		{
			get
			{
				if(r_MGetValueRectIntInternal_Injected_Out_RectInt == null)
				{
					r_MGetValueRectIntInternal_Injected_Out_RectInt = new(this, "GetValueRectIntInternal_Injected", 0, typeof(UnityEngine.RectInt).MakeByRefType());
					r_MGetValueRectIntInternal_Injected_Out_RectInt.SetBelong(this.instance);
				}
				return r_MGetValueRectIntInternal_Injected_Out_RectInt;
			}
		}

		/// <summary>
		/// Void SetValueRectIntInternal_Injected(UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_MSetValueRectIntInternal_Injected_Ref_RectInt;
		public virtual RMethod RMSetValueRectIntInternal_Injected_Ref_RectInt
		{
			get
			{
				if(r_MSetValueRectIntInternal_Injected_Ref_RectInt == null)
				{
					r_MSetValueRectIntInternal_Injected_Ref_RectInt = new(this, "SetValueRectIntInternal_Injected", 0, typeof(UnityEngine.RectInt).MakeByRefType());
					r_MSetValueRectIntInternal_Injected_Ref_RectInt.SetBelong(this.instance);
				}
				return r_MSetValueRectIntInternal_Injected_Ref_RectInt;
			}
		}

		/// <summary>
		/// Void GetValueBoundsInternal_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_MGetValueBoundsInternal_Injected_Out_Bounds;
		public virtual RMethod RMGetValueBoundsInternal_Injected_Out_Bounds
		{
			get
			{
				if(r_MGetValueBoundsInternal_Injected_Out_Bounds == null)
				{
					r_MGetValueBoundsInternal_Injected_Out_Bounds = new(this, "GetValueBoundsInternal_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_MGetValueBoundsInternal_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_MGetValueBoundsInternal_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void SetValueBoundsInternal_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_MSetValueBoundsInternal_Injected_Ref_Bounds;
		public virtual RMethod RMSetValueBoundsInternal_Injected_Ref_Bounds
		{
			get
			{
				if(r_MSetValueBoundsInternal_Injected_Ref_Bounds == null)
				{
					r_MSetValueBoundsInternal_Injected_Ref_Bounds = new(this, "SetValueBoundsInternal_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_MSetValueBoundsInternal_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_MSetValueBoundsInternal_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Void GetValueBoundsIntInternal_Injected(UnityEngine.BoundsInt ByRef)
		/// </summary>
		protected RMethod r_MGetValueBoundsIntInternal_Injected_Out_BoundsInt;
		public virtual RMethod RMGetValueBoundsIntInternal_Injected_Out_BoundsInt
		{
			get
			{
				if(r_MGetValueBoundsIntInternal_Injected_Out_BoundsInt == null)
				{
					r_MGetValueBoundsIntInternal_Injected_Out_BoundsInt = new(this, "GetValueBoundsIntInternal_Injected", 0, typeof(UnityEngine.BoundsInt).MakeByRefType());
					r_MGetValueBoundsIntInternal_Injected_Out_BoundsInt.SetBelong(this.instance);
				}
				return r_MGetValueBoundsIntInternal_Injected_Out_BoundsInt;
			}
		}

		/// <summary>
		/// Void SetValueBoundsIntInternal_Injected(UnityEngine.BoundsInt ByRef)
		/// </summary>
		protected RMethod r_MSetValueBoundsIntInternal_Injected_Ref_BoundsInt;
		public virtual RMethod RMSetValueBoundsIntInternal_Injected_Ref_BoundsInt
		{
			get
			{
				if(r_MSetValueBoundsIntInternal_Injected_Ref_BoundsInt == null)
				{
					r_MSetValueBoundsIntInternal_Injected_Ref_BoundsInt = new(this, "SetValueBoundsIntInternal_Injected", 0, typeof(UnityEngine.BoundsInt).MakeByRefType());
					r_MSetValueBoundsIntInternal_Injected_Ref_BoundsInt.SetBelong(this.instance);
				}
				return r_MSetValueBoundsIntInternal_Injected_Ref_BoundsInt;
			}
		}

		/// <summary>
		/// Void GetHash128ValueInternal_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_MGetHash128ValueInternal_Injected_Out_Hash128;
		public virtual RMethod RMGetHash128ValueInternal_Injected_Out_Hash128
		{
			get
			{
				if(r_MGetHash128ValueInternal_Injected_Out_Hash128 == null)
				{
					r_MGetHash128ValueInternal_Injected_Out_Hash128 = new(this, "GetHash128ValueInternal_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_MGetHash128ValueInternal_Injected_Out_Hash128.SetBelong(this.instance);
				}
				return r_MGetHash128ValueInternal_Injected_Out_Hash128;
			}
		}

		/// <summary>
		/// Void SetHash128ValueInternal_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_MSetHash128ValueInternal_Injected_Ref_Hash128;
		public virtual RMethod RMSetHash128ValueInternal_Injected_Ref_Hash128
		{
			get
			{
				if(r_MSetHash128ValueInternal_Injected_Ref_Hash128 == null)
				{
					r_MSetHash128ValueInternal_Injected_Ref_Hash128 = new(this, "SetHash128ValueInternal_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_MSetHash128ValueInternal_Injected_Ref_Hash128.SetBelong(this.instance);
				}
				return r_MSetHash128ValueInternal_Injected_Ref_Hash128;
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
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedProperty Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty FindPropertyRelative(System.String @relativePropertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativePropertyPath};
            var ___result = RMFindPropertyRelative_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual UnityEditor.SerializedProperty GetArrayElementAtIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetArrayElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual void SetToValueOfTarget(UnityEngine.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMSetToValueOfTarget_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean EndOfData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndOfData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SyncSerializedObjectVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSyncSerializedObjectVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Verify(SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty.RVerifyFlags @verifyFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@verifyFlags.Value};
            var ___result = RMVerify_VerifyFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean NextVisible(System.Boolean @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RMNextVisible_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean NextVisibleInternal(System.Boolean @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RMNextVisibleInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearArrayInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearArrayInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean FindPropertyInternal(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMFindPropertyInternal_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean FindFirstPropertyFromManagedReferencePathInternal(System.String @managedReferencePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@managedReferencePath};
            var ___result = RMFindFirstPropertyFromManagedReferencePathInternal_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Destroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean EqualContents(UnityEditor.SerializedProperty @x, UnityEditor.SerializedProperty @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMEqualContents_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean EqualContentsInternal(UnityEditor.SerializedProperty @x, UnityEditor.SerializedProperty @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMEqualContentsInternal_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean DataEquals(UnityEditor.SerializedProperty @x, UnityEditor.SerializedProperty @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMDataEquals_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VersionEquals(UnityEditor.SerializedProperty @x, UnityEditor.SerializedProperty @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMVersionEquals_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean DataEqualsInternal(UnityEditor.SerializedProperty @x, UnityEditor.SerializedProperty @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMDataEqualsInternal_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 HasMultipleDifferentValuesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasMultipleDifferentValuesInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetBitAtIndexForAllTargetsImmediate(System.Int32 @index, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMSetBitAtIndexForAllTargetsImmediate_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBitAtIndexForAllTargetsImmediateInternal(System.Int32 @index, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMSetBitAtIndexForAllTargetsImmediateInternal_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetMangledNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMangledNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSerializedPropertyTypeNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerializedPropertyTypeNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSerializedPropertyArrayElementTypeNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerializedPropertyArrayElementTypeNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetTooltipInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTooltipInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetDepthInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDepthInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetPropertyPathInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPropertyPathInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCodeForPropertyPathInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCodeForPropertyPathInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCodeForPropertyPathWithoutArrayIndexInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCodeForPropertyPathWithoutArrayIndexInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetEditableInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEditableInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsReorderable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsReorderable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAnimatedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAnimatedInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCandidateInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCandidateInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsKeyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsKeyInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLiveModified()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsLiveModified.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetIsExpandedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsExpandedInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsExpandedInternal(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetIsExpandedInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasChildrenInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasChildrenInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasVisibleChildrenInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasVisibleChildrenInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetIsInstantiatedPrefabInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsInstantiatedPrefabInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsReferencingAManagedReferenceFieldInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsReferencingAManagedReferenceFieldInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetFullyQualifiedTypenameForCurrentTypeTreeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFullyQualifiedTypenameForCurrentTypeTreeInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPropertyPathInCurrentManagedTypeTreeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPropertyPathInCurrentManagedTypeTreeInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetManagedReferencePropertyPathInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManagedReferencePropertyPathInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean GetPrefabOverrideInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPrefabOverrideInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPrefabOverrideInternal(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetPrefabOverrideInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsDefaultOverrideInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsDefaultOverrideInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetIsDrivenRectTransformPropertyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsDrivenRectTransformPropertyInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetSerializedPropertyTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerializedPropertyTypeInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetNumericTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNumericTypeInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 GetIntValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIntValueInternal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void SetIntValueInternal(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetIntValueInternal_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetBoolValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBoolValueInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetBoolValueInternal(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetBoolValueInternal_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Double GetFloatValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFloatValueInternal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual void SetFloatValueInternal(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetFloatValueInternal_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Double[] GetAllFloatValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllFloatValues.Invoke(___genericsType, ___parameters);

            return (System.Double[])___result;
        }


        public virtual void SetAllFloatValuesImmediate(System.Double[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetAllFloatValuesImmediate_DoubleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64[] GetAllIntValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllIntValues.Invoke(___genericsType, ___parameters);

            return (System.Int64[])___result;
        }


        public virtual void SetAllIntValuesImmediate(System.Int64[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetAllIntValuesImmediate_Int64Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetStringValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStringValueInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetStringValueInternal(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetStringValueInternal_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetColorValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetColorValueInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void SetColorValueInternal(UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetColorValueInternal_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.AnimationCurve GetAnimationCurveValueCopyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAnimationCurveValueCopyInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public virtual void SetAnimationCurveValueInternal(UnityEngine.AnimationCurve @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetAnimationCurveValueInternal_AnimationCurve.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Gradient GetGradientValueCopyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGradientValueCopyInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Gradient)___result;
        }


        public virtual void SetGradientValueInternal(UnityEngine.Gradient @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetGradientValueInternal_Gradient.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 GetManagedReferenceIdInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManagedReferenceIdInternal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String GetManagedReferenceFullTypeNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetManagedReferenceFullTypeNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetManagedReferenceValueInternal(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetManagedReferenceValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStructValueInternal(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetStructValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetStructValueInternal(System.String @assemblyName, System.String @nameSpace, System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @nameSpace, @className};
            var ___result = RMGetStructValueInternal_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LookupInstanceByIdInternal(System.Int64 @refId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@refId};
            var ___result = RMLookupInstanceByIdInternal_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual UnityEngine.Object GetPPtrValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPPtrValueInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual void SetPPtrValueInternal(UnityEngine.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetPPtrValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPPtrValueFromInstanceIDInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPPtrValueFromInstanceIDInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetPPtrValueFromInstanceIDInternal(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMSetPPtrValueFromInstanceIDInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetPPtrStringValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPPtrStringValueInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ValidateObjectReferenceValue(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMValidateObjectReferenceValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidatePPtrValueInternal(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMValidatePPtrValueInternal_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateObjectReferenceValueExact(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMValidateObjectReferenceValueExact_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidatePPtrValueExact(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMValidatePPtrValueExact_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetPPtrClassNameInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPPtrClassNameInternal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void AppendFoldoutPPtrValue(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMAppendFoldoutPPtrValue_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendFoldoutPPtrValueInternal(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMAppendFoldoutPPtrValueInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetLayerMaskStringValue(System.UInt32 @layers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layers};
            var ___result = RMGetLayerMaskStringValue_UInt32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.UInt32 GetLayerMaskBitsInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLayerMaskBitsInternal.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int32 GetEnumValueIndexInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumValueIndexInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetEnumValueIndexInternal(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetEnumValueIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetEnumNamesInternal(System.Boolean @nicify)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nicify};
            var ___result = RMGetEnumNamesInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual UnityEngine.Vector2 GetValueVector2Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueVector2Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetValueVector2Internal(UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector2Internal_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetValueVector3Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueVector3Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetValueVector3Internal(UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector3Internal_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector4 GetValueVector4Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueVector4Internal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void SetValueVector4Internal(UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector4Internal_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2Int GetValueVector2IntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueVector2IntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public virtual void SetValueVector2IntInternal(UnityEngine.Vector2Int @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector2IntInternal_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3Int GetValueVector3IntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueVector3IntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public virtual void SetValueVector3IntInternal(UnityEngine.Vector3Int @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector3IntInternal_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Quaternion GetValueQuaternionInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueQuaternionInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual void SetValueQuaternionInternal(UnityEngine.Quaternion @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueQuaternionInternal_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetValueRectInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueRectInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void SetValueRectInternal(UnityEngine.Rect @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueRectInternal_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RectInt GetValueRectIntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueRectIntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RectInt)___result;
        }


        public virtual void SetValueRectIntInternal(UnityEngine.RectInt @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueRectIntInternal_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Bounds GetValueBoundsInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueBoundsInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Bounds)___result;
        }


        public virtual void SetValueBoundsInternal(UnityEngine.Bounds @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueBoundsInternal_Bounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.BoundsInt GetValueBoundsIntInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueBoundsIntInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.BoundsInt)___result;
        }


        public virtual void SetValueBoundsIntInternal(UnityEngine.BoundsInt @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueBoundsIntInternal_BoundsInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Hash128 GetHash128ValueInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHash128ValueInternal.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public virtual void SetHash128ValueInternal(UnityEngine.Hash128 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetHash128ValueInternal_Hash128.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Next(System.Boolean @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RMNext_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean NextInternal(System.Boolean @enterChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enterChildren};
            var ___result = RMNextInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 CountRemaining()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCountRemaining.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CountRemainingInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCountRemainingInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CountInProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCountInProperty.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CountInPropertyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCountInPropertyInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEditor.SerializedProperty CopyInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopyInternal.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty CopyInternalImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopyInternalImpl.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean DuplicateCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDuplicateCommand.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DuplicateCommandInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDuplicateCommandInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteCommand.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteCommandInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteCommandInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.SerializedProperty GetEndProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEndProperty.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty GetEndProperty(System.Boolean @includeInvisible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeInvisible};
            var ___result = RMGetEndProperty_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean FindPropertyRelativeInternal(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMFindPropertyRelativeInternal_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean FindRelativeProperty(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMFindRelativeProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetMinArraySize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMinArraySize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetInspectableArraySize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInspectableArraySize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ResizeArray(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMResizeArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetArrayElementAtIndexInternal(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetArrayElementAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetArrayElementAtIndexImpl(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetArrayElementAtIndexImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InsertArrayElementAtIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMInsertArrayElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertArrayElementAtIndexInternal(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMInsertArrayElementAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteArrayElementAtIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMDeleteArrayElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteArrayElementAtIndexInternal(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMDeleteArrayElementAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveArrayElement(System.Int32 @srcIndex, System.Int32 @dstIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcIndex, @dstIndex};
            var ___result = RMMoveArrayElement_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveArrayElementInternal(System.Int32 @srcIndex, System.Int32 @dstIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srcIndex, @dstIndex};
            var ___result = RMMoveArrayElementInternal_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsFixedBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsFixedBuffer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetFixedBufferSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFixedBufferSize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetIsValidDisplayNameCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsValidDisplayNameCache.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsValidDisplayNameCache(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetIsValidDisplayNameCache_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsValidTooltipCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsValidTooltipCache.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsValidTooltipCache(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetIsValidTooltipCache_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedProperty GetFixedBufferElementAtIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetFixedBufferElementAtIndex_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean GetFixedBufferAtIndexInternal(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetFixedBufferAtIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AnimationCurveValueEquals(UnityEngine.AnimationCurve @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@curve};
            var ___result = RMAnimationCurveValueEquals_AnimationCurve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValueEquals(UnityEngine.AnimationCurve @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@curve};
            var ___result = RMValueEquals_AnimationCurve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GradientValueEquals(UnityEngine.Gradient @gradient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gradient};
            var ___result = RMGradientValueEquals_Gradient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValueEquals(UnityEngine.Gradient @gradient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gradient};
            var ___result = RMValueEquals_Gradient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StringValueEquals(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMStringValueEquals_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValueEquals(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMValueEquals_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValidInternal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.UInt32 GetContentHashInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetContentHashInternal.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void GetColorValueInternal_Injected(out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetColorValueInternal_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void SetColorValueInternal_Injected(ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetColorValueInternal_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void GetValueVector2Internal_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueVector2Internal_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void SetValueVector2Internal_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector2Internal_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetValueVector3Internal_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueVector3Internal_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void SetValueVector3Internal_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector3Internal_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void GetValueVector4Internal_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueVector4Internal_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void SetValueVector4Internal_Injected(ref UnityEngine.Vector4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector4Internal_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void GetValueVector2IntInternal_Injected(out UnityEngine.Vector2Int @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueVector2IntInternal_Injected_Out_Vector2Int.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2Int)___parameters[0];

            
        }


        public virtual void SetValueVector2IntInternal_Injected(ref UnityEngine.Vector2Int @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector2IntInternal_Injected_Ref_Vector2Int.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2Int)___parameters[0];

            
        }


        public virtual void GetValueVector3IntInternal_Injected(out UnityEngine.Vector3Int @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueVector3IntInternal_Injected_Out_Vector3Int.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3Int)___parameters[0];

            
        }


        public virtual void SetValueVector3IntInternal_Injected(ref UnityEngine.Vector3Int @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueVector3IntInternal_Injected_Ref_Vector3Int.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3Int)___parameters[0];

            
        }


        public virtual void GetValueQuaternionInternal_Injected(out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueQuaternionInternal_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void SetValueQuaternionInternal_Injected(ref UnityEngine.Quaternion @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueQuaternionInternal_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void GetValueRectInternal_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueRectInternal_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void SetValueRectInternal_Injected(ref UnityEngine.Rect @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueRectInternal_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void GetValueRectIntInternal_Injected(out UnityEngine.RectInt @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueRectIntInternal_Injected_Out_RectInt.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.RectInt)___parameters[0];

            
        }


        public virtual void SetValueRectIntInternal_Injected(ref UnityEngine.RectInt @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueRectIntInternal_Injected_Ref_RectInt.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.RectInt)___parameters[0];

            
        }


        public virtual void GetValueBoundsInternal_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueBoundsInternal_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void SetValueBoundsInternal_Injected(ref UnityEngine.Bounds @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueBoundsInternal_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void GetValueBoundsIntInternal_Injected(out UnityEngine.BoundsInt @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetValueBoundsIntInternal_Injected_Out_BoundsInt.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.BoundsInt)___parameters[0];

            
        }


        public virtual void SetValueBoundsIntInternal_Injected(ref UnityEngine.BoundsInt @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetValueBoundsIntInternal_Injected_Ref_BoundsInt.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.BoundsInt)___parameters[0];

            
        }


        public virtual void GetHash128ValueInternal_Injected(out UnityEngine.Hash128 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetHash128ValueInternal_Injected_Out_Hash128.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual void SetHash128ValueInternal_Injected(ref UnityEngine.Hash128 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetHash128ValueInternal_Injected_Ref_Hash128.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
