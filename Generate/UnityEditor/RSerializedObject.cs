using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.SerializedObject
	/// </summary>
    public partial class RSerializedObject : RMember //
    {

		/// <summary>
		/// System.IntPtr m_NativeObjectPtr
		/// </summary>
		protected RField r_m_NativeObjectPtr;
		public virtual RField Rm_NativeObjectPtr
		{
			get
			{
				if(r_m_NativeObjectPtr == null)
				{
					r_m_NativeObjectPtr = new(this, "m_NativeObjectPtr");
					r_m_NativeObjectPtr.SetBelong(this.instance);
				}
				return r_m_NativeObjectPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Object targetObject
		/// </summary>
		protected RUnityEngine.RObject r_targetObject;
		public virtual RUnityEngine.RObject RtargetObject
		{
			get
			{
				if(r_targetObject == null)
				{
					r_targetObject = new(this, "targetObject", -1);
					r_targetObject.SetBelong(this.instance);
				}
				return r_targetObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] targetObjects
		/// </summary>
		protected RPropertyArray<RUnityEngine.RObject> r_targetObjects;
		public virtual RPropertyArray<RUnityEngine.RObject> RtargetObjects
		{
			get
			{
				if(r_targetObjects == null)
				{
					r_targetObjects = new(this, "targetObjects", -1);
					r_targetObjects.SetBelong(this.instance);
				}
				return r_targetObjects;
			}
		}

		/// <summary>
		/// Int32 targetObjectsCount
		/// </summary>
		protected RProperty r_targetObjectsCount;
		public virtual RProperty RtargetObjectsCount
		{
			get
			{
				if(r_targetObjectsCount == null)
				{
					r_targetObjectsCount = new(this, "targetObjectsCount", -1);
					r_targetObjectsCount.SetBelong(this.instance);
				}
				return r_targetObjectsCount;
			}
		}

		/// <summary>
		/// UnityEngine.Object context
		/// </summary>
		protected RUnityEngine.RObject r_context;
		public virtual RUnityEngine.RObject Rcontext
		{
			get
			{
				if(r_context == null)
				{
					r_context = new(this, "context", -1);
					r_context.SetBelong(this.instance);
				}
				return r_context;
			}
		}

		/// <summary>
		/// Boolean hasModifiedProperties
		/// </summary>
		protected RProperty r_hasModifiedProperties;
		public virtual RProperty RhasModifiedProperties
		{
			get
			{
				if(r_hasModifiedProperties == null)
				{
					r_hasModifiedProperties = new(this, "hasModifiedProperties", -1);
					r_hasModifiedProperties.SetBelong(this.instance);
				}
				return r_hasModifiedProperties;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode inspectorMode
		/// </summary>
		protected RProperty r_inspectorMode;
		public virtual RProperty RinspectorMode
		{
			get
			{
				if(r_inspectorMode == null)
				{
					r_inspectorMode = new(this, "inspectorMode", -1);
					r_inspectorMode.SetBelong(this.instance);
				}
				return r_inspectorMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode inspectorDataMode
		/// </summary>
		protected RProperty r_inspectorDataMode;
		public virtual RProperty RinspectorDataMode
		{
			get
			{
				if(r_inspectorDataMode == null)
				{
					r_inspectorDataMode = new(this, "inspectorDataMode", -1);
					r_inspectorDataMode.SetBelong(this.instance);
				}
				return r_inspectorDataMode;
			}
		}

		/// <summary>
		/// Boolean isEditingMultipleObjects
		/// </summary>
		protected RProperty r_isEditingMultipleObjects;
		public virtual RProperty RisEditingMultipleObjects
		{
			get
			{
				if(r_isEditingMultipleObjects == null)
				{
					r_isEditingMultipleObjects = new(this, "isEditingMultipleObjects", -1);
					r_isEditingMultipleObjects.SetBelong(this.instance);
				}
				return r_isEditingMultipleObjects;
			}
		}

		/// <summary>
		/// Int32 maxArraySizeForMultiEditing
		/// </summary>
		protected RProperty r_maxArraySizeForMultiEditing;
		public virtual RProperty RmaxArraySizeForMultiEditing
		{
			get
			{
				if(r_maxArraySizeForMultiEditing == null)
				{
					r_maxArraySizeForMultiEditing = new(this, "maxArraySizeForMultiEditing", -1);
					r_maxArraySizeForMultiEditing.SetBelong(this.instance);
				}
				return r_maxArraySizeForMultiEditing;
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
		/// UInt32 objectVersion
		/// </summary>
		protected RProperty r_objectVersion;
		public virtual RProperty RobjectVersion
		{
			get
			{
				if(r_objectVersion == null)
				{
					r_objectVersion = new(this, "objectVersion", -1);
					r_objectVersion.SetBelong(this.instance);
				}
				return r_objectVersion;
			}
		}

		/// <summary>
		/// Boolean forceChildVisibility
		/// </summary>
		protected RProperty r_forceChildVisibility;
		public virtual RProperty RforceChildVisibility
		{
			get
			{
				if(r_forceChildVisibility == null)
				{
					r_forceChildVisibility = new(this, "forceChildVisibility", -1);
					r_forceChildVisibility.SetBelong(this.instance);
				}
				return r_forceChildVisibility;
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
					r_RInternal_Destroy_IntPtr = new(typeof(UnityEditor.SerializedObject), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_RInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_RInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetIterator()
		/// </summary>
		protected RMethod r_RGetIterator;
		public virtual RMethod RGetIterator
		{
			get
			{
				if(r_RGetIterator == null)
				{
					r_RGetIterator = new(this, "GetIterator", 0);
					r_RGetIterator.SetBelong(this.instance);
				}
				return r_RGetIterator;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty FindProperty(System.String)
		/// </summary>
		protected RMethod r_RFindProperty_String;
		public virtual RMethod RFindProperty_String
		{
			get
			{
				if(r_RFindProperty_String == null)
				{
					r_RFindProperty_String = new(this, "FindProperty", 0, typeof(System.String));
					r_RFindProperty_String.SetBelong(this.instance);
				}
				return r_RFindProperty_String;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty FindFirstPropertyFromManagedReferencePath(System.String)
		/// </summary>
		protected RMethod r_RFindFirstPropertyFromManagedReferencePath_String;
		public virtual RMethod RFindFirstPropertyFromManagedReferencePath_String
		{
			get
			{
				if(r_RFindFirstPropertyFromManagedReferencePath_String == null)
				{
					r_RFindFirstPropertyFromManagedReferencePath_String = new(this, "FindFirstPropertyFromManagedReferencePath", 0, typeof(System.String));
					r_RFindFirstPropertyFromManagedReferencePath_String.SetBelong(this.instance);
				}
				return r_RFindFirstPropertyFromManagedReferencePath_String;
			}
		}

		/// <summary>
		/// Boolean ApplyModifiedProperties()
		/// </summary>
		protected RMethod r_RApplyModifiedProperties;
		public virtual RMethod RApplyModifiedProperties
		{
			get
			{
				if(r_RApplyModifiedProperties == null)
				{
					r_RApplyModifiedProperties = new(this, "ApplyModifiedProperties", 0);
					r_RApplyModifiedProperties.SetBelong(this.instance);
				}
				return r_RApplyModifiedProperties;
			}
		}

		/// <summary>
		/// Void SetIsDifferentCacheDirty()
		/// </summary>
		protected RMethod r_RSetIsDifferentCacheDirty;
		public virtual RMethod RSetIsDifferentCacheDirty
		{
			get
			{
				if(r_RSetIsDifferentCacheDirty == null)
				{
					r_RSetIsDifferentCacheDirty = new(this, "SetIsDifferentCacheDirty", 0);
					r_RSetIsDifferentCacheDirty.SetBelong(this.instance);
				}
				return r_RSetIsDifferentCacheDirty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetIterator_Internal()
		/// </summary>
		protected RMethod r_RGetIterator_Internal;
		public virtual RMethod RGetIterator_Internal
		{
			get
			{
				if(r_RGetIterator_Internal == null)
				{
					r_RGetIterator_Internal = new(this, "GetIterator_Internal", 0);
					r_RGetIterator_Internal.SetBelong(this.instance);
				}
				return r_RGetIterator_Internal;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void UpdateIfDirtyOrScript()
		/// </summary>
		protected RMethod r_RUpdateIfDirtyOrScript;
		public virtual RMethod RUpdateIfDirtyOrScript
		{
			get
			{
				if(r_RUpdateIfDirtyOrScript == null)
				{
					r_RUpdateIfDirtyOrScript = new(this, "UpdateIfDirtyOrScript", 0);
					r_RUpdateIfDirtyOrScript.SetBelong(this.instance);
				}
				return r_RUpdateIfDirtyOrScript;
			}
		}

		/// <summary>
		/// Boolean UpdateIfRequiredOrScript()
		/// </summary>
		protected RMethod r_RUpdateIfRequiredOrScript;
		public virtual RMethod RUpdateIfRequiredOrScript
		{
			get
			{
				if(r_RUpdateIfRequiredOrScript == null)
				{
					r_RUpdateIfRequiredOrScript = new(this, "UpdateIfRequiredOrScript", 0);
					r_RUpdateIfRequiredOrScript.SetBelong(this.instance);
				}
				return r_RUpdateIfRequiredOrScript;
			}
		}

		/// <summary>
		/// Void UpdateExpandedState()
		/// </summary>
		protected RMethod r_RUpdateExpandedState;
		public virtual RMethod RUpdateExpandedState
		{
			get
			{
				if(r_RUpdateExpandedState == null)
				{
					r_RUpdateExpandedState = new(this, "UpdateExpandedState", 0);
					r_RUpdateExpandedState.SetBelong(this.instance);
				}
				return r_RUpdateExpandedState;
			}
		}

		/// <summary>
		/// IntPtr InternalCreate(UnityEngine.Object[], UnityEngine.Object)
		/// </summary>
		protected static RMethod r_RInternalCreate_ObjectArray_Object;
		public static RMethod RInternalCreate_ObjectArray_Object
		{
			get
			{
				if(r_RInternalCreate_ObjectArray_Object == null)
				{
					r_RInternalCreate_ObjectArray_Object = new(typeof(UnityEditor.SerializedObject), "InternalCreate", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object));
					r_RInternalCreate_ObjectArray_Object.SetBelong(null);
				}
				return r_RInternalCreate_ObjectArray_Object;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyModification ExtractPropertyModification(System.String)
		/// </summary>
		protected RMethod r_RExtractPropertyModification_String;
		public virtual RMethod RExtractPropertyModification_String
		{
			get
			{
				if(r_RExtractPropertyModification_String == null)
				{
					r_RExtractPropertyModification_String = new(this, "ExtractPropertyModification", 0, typeof(System.String));
					r_RExtractPropertyModification_String.SetBelong(this.instance);
				}
				return r_RExtractPropertyModification_String;
			}
		}

		/// <summary>
		/// System.Object InternalExtractPropertyModification(System.String)
		/// </summary>
		protected RMethod r_RInternalExtractPropertyModification_String;
		public virtual RMethod RInternalExtractPropertyModification_String
		{
			get
			{
				if(r_RInternalExtractPropertyModification_String == null)
				{
					r_RInternalExtractPropertyModification_String = new(this, "InternalExtractPropertyModification", 0, typeof(System.String));
					r_RInternalExtractPropertyModification_String.SetBelong(this.instance);
				}
				return r_RInternalExtractPropertyModification_String;
			}
		}

		/// <summary>
		/// Void Cache(Int32)
		/// </summary>
		protected RMethod r_RCache_Int32;
		public virtual RMethod RCache_Int32
		{
			get
			{
				if(r_RCache_Int32 == null)
				{
					r_RCache_Int32 = new(this, "Cache", 0, typeof(System.Int32));
					r_RCache_Int32.SetBelong(this.instance);
				}
				return r_RCache_Int32;
			}
		}

		/// <summary>
		/// Void CacheInternal(Int32)
		/// </summary>
		protected RMethod r_RCacheInternal_Int32;
		public virtual RMethod RCacheInternal_Int32
		{
			get
			{
				if(r_RCacheInternal_Int32 == null)
				{
					r_RCacheInternal_Int32 = new(this, "CacheInternal", 0, typeof(System.Int32));
					r_RCacheInternal_Int32.SetBelong(this.instance);
				}
				return r_RCacheInternal_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject LoadFromCache(Int32)
		/// </summary>
		protected static RMethod r_RLoadFromCache_Int32;
		public static RMethod RLoadFromCache_Int32
		{
			get
			{
				if(r_RLoadFromCache_Int32 == null)
				{
					r_RLoadFromCache_Int32 = new(typeof(UnityEditor.SerializedObject), "LoadFromCache", 0, typeof(System.Int32));
					r_RLoadFromCache_Int32.SetBelong(null);
				}
				return r_RLoadFromCache_Int32;
			}
		}

		/// <summary>
		/// Boolean ApplyModifiedPropertiesWithoutUndo()
		/// </summary>
		protected RMethod r_RApplyModifiedPropertiesWithoutUndo;
		public virtual RMethod RApplyModifiedPropertiesWithoutUndo
		{
			get
			{
				if(r_RApplyModifiedPropertiesWithoutUndo == null)
				{
					r_RApplyModifiedPropertiesWithoutUndo = new(this, "ApplyModifiedPropertiesWithoutUndo", 0);
					r_RApplyModifiedPropertiesWithoutUndo.SetBelong(this.instance);
				}
				return r_RApplyModifiedPropertiesWithoutUndo;
			}
		}

		/// <summary>
		/// Void EnableLivePropertyFeatureGlobally(Boolean)
		/// </summary>
		protected static RMethod r_REnableLivePropertyFeatureGlobally_Boolean;
		public static RMethod REnableLivePropertyFeatureGlobally_Boolean
		{
			get
			{
				if(r_REnableLivePropertyFeatureGlobally_Boolean == null)
				{
					r_REnableLivePropertyFeatureGlobally_Boolean = new(typeof(UnityEditor.SerializedObject), "EnableLivePropertyFeatureGlobally", 0, typeof(System.Boolean));
					r_REnableLivePropertyFeatureGlobally_Boolean.SetBelong(null);
				}
				return r_REnableLivePropertyFeatureGlobally_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetLivePropertyFeatureGlobalState()
		/// </summary>
		protected static RMethod r_RGetLivePropertyFeatureGlobalState;
		public static RMethod RGetLivePropertyFeatureGlobalState
		{
			get
			{
				if(r_RGetLivePropertyFeatureGlobalState == null)
				{
					r_RGetLivePropertyFeatureGlobalState = new(typeof(UnityEditor.SerializedObject), "GetLivePropertyFeatureGlobalState", 0);
					r_RGetLivePropertyFeatureGlobalState.SetBelong(null);
				}
				return r_RGetLivePropertyFeatureGlobalState;
			}
		}

		/// <summary>
		/// Void CopyFromSerializedProperty(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_RCopyFromSerializedProperty_SerializedProperty;
		public virtual RMethod RCopyFromSerializedProperty_SerializedProperty
		{
			get
			{
				if(r_RCopyFromSerializedProperty_SerializedProperty == null)
				{
					r_RCopyFromSerializedProperty_SerializedProperty = new(this, "CopyFromSerializedProperty", 0, typeof(UnityEditor.SerializedProperty));
					r_RCopyFromSerializedProperty_SerializedProperty.SetBelong(this.instance);
				}
				return r_RCopyFromSerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Void CopyFromSerializedPropertyInternal(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_RCopyFromSerializedPropertyInternal_SerializedProperty;
		public virtual RMethod RCopyFromSerializedPropertyInternal_SerializedProperty
		{
			get
			{
				if(r_RCopyFromSerializedPropertyInternal_SerializedProperty == null)
				{
					r_RCopyFromSerializedPropertyInternal_SerializedProperty = new(this, "CopyFromSerializedPropertyInternal", 0, typeof(UnityEditor.SerializedProperty));
					r_RCopyFromSerializedPropertyInternal_SerializedProperty.SetBelong(this.instance);
				}
				return r_RCopyFromSerializedPropertyInternal_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean CopyFromSerializedPropertyIfDifferent(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_RCopyFromSerializedPropertyIfDifferent_SerializedProperty;
		public virtual RMethod RCopyFromSerializedPropertyIfDifferent_SerializedProperty
		{
			get
			{
				if(r_RCopyFromSerializedPropertyIfDifferent_SerializedProperty == null)
				{
					r_RCopyFromSerializedPropertyIfDifferent_SerializedProperty = new(this, "CopyFromSerializedPropertyIfDifferent", 0, typeof(UnityEditor.SerializedProperty));
					r_RCopyFromSerializedPropertyIfDifferent_SerializedProperty.SetBelong(this.instance);
				}
				return r_RCopyFromSerializedPropertyIfDifferent_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean CopyFromSerializedPropertyIfDifferentInternal(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty;
		public virtual RMethod RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty
		{
			get
			{
				if(r_RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty == null)
				{
					r_RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty = new(this, "CopyFromSerializedPropertyIfDifferentInternal", 0, typeof(UnityEditor.SerializedProperty));
					r_RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty.SetBelong(this.instance);
				}
				return r_RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean HasAnyInstantiatedPrefabsWithValidAsset()
		/// </summary>
		protected RMethod r_RHasAnyInstantiatedPrefabsWithValidAsset;
		public virtual RMethod RHasAnyInstantiatedPrefabsWithValidAsset
		{
			get
			{
				if(r_RHasAnyInstantiatedPrefabsWithValidAsset == null)
				{
					r_RHasAnyInstantiatedPrefabsWithValidAsset = new(this, "HasAnyInstantiatedPrefabsWithValidAsset", 0);
					r_RHasAnyInstantiatedPrefabsWithValidAsset.SetBelong(this.instance);
				}
				return r_RHasAnyInstantiatedPrefabsWithValidAsset;
			}
		}

		/// <summary>
		/// Boolean VersionEquals(UnityEditor.SerializedObject, UnityEditor.SerializedObject)
		/// </summary>
		protected static RMethod r_RVersionEquals_SerializedObject_SerializedObject;
		public static RMethod RVersionEquals_SerializedObject_SerializedObject
		{
			get
			{
				if(r_RVersionEquals_SerializedObject_SerializedObject == null)
				{
					r_RVersionEquals_SerializedObject_SerializedObject = new(typeof(UnityEditor.SerializedObject), "VersionEquals", 0, typeof(UnityEditor.SerializedObject), typeof(UnityEditor.SerializedObject));
					r_RVersionEquals_SerializedObject_SerializedObject.SetBelong(null);
				}
				return r_RVersionEquals_SerializedObject_SerializedObject;
			}
		}

		/// <summary>
		/// Boolean VersionEqualsInternal(UnityEditor.SerializedObject, UnityEditor.SerializedObject)
		/// </summary>
		protected static RMethod r_RVersionEqualsInternal_SerializedObject_SerializedObject;
		public static RMethod RVersionEqualsInternal_SerializedObject_SerializedObject
		{
			get
			{
				if(r_RVersionEqualsInternal_SerializedObject_SerializedObject == null)
				{
					r_RVersionEqualsInternal_SerializedObject_SerializedObject = new(typeof(UnityEditor.SerializedObject), "VersionEqualsInternal", 0, typeof(UnityEditor.SerializedObject), typeof(UnityEditor.SerializedObject));
					r_RVersionEqualsInternal_SerializedObject_SerializedObject.SetBelong(null);
				}
				return r_RVersionEqualsInternal_SerializedObject_SerializedObject;
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


        public RSerializedObject() : base("UnityEditor.SerializedObject")
        {
        }

        public RSerializedObject(System.Object instance) : base("UnityEditor.SerializedObject")
		{
            SetInstance(instance);
		}

        public RSerializedObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializedObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual UnityEditor.SerializedProperty GetIterator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIterator.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty FindProperty(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RFindProperty_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual UnityEditor.SerializedProperty FindFirstPropertyFromManagedReferencePath(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RFindFirstPropertyFromManagedReferencePath_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual System.Boolean ApplyModifiedProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyModifiedProperties.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsDifferentCacheDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetIsDifferentCacheDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedProperty GetIterator_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIterator_Internal.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedProperty)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateIfDirtyOrScript()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateIfDirtyOrScript.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UpdateIfRequiredOrScript()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateIfRequiredOrScript.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateExpandedState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateExpandedState.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InternalCreate(UnityEngine.Object[]  @monoObjs, UnityEngine.Object  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@monoObjs, @context};
            var ___result = RInternalCreate_ObjectArray_Object.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual UnityEditor.PropertyModification ExtractPropertyModification(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RExtractPropertyModification_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PropertyModification)___result;
        }


        public virtual System.Object InternalExtractPropertyModification(System.String  @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RInternalExtractPropertyModification_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Cache(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RCache_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CacheInternal(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RCacheInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.SerializedObject LoadFromCache(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RLoadFromCache_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedObject)___result;
        }


        public virtual System.Boolean ApplyModifiedPropertiesWithoutUndo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyModifiedPropertiesWithoutUndo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void EnableLivePropertyFeatureGlobally(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REnableLivePropertyFeatureGlobally_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetLivePropertyFeatureGlobalState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLivePropertyFeatureGlobalState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyFromSerializedProperty(UnityEditor.SerializedProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RCopyFromSerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFromSerializedPropertyInternal(UnityEditor.SerializedProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RCopyFromSerializedPropertyInternal_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CopyFromSerializedPropertyIfDifferent(UnityEditor.SerializedProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RCopyFromSerializedPropertyIfDifferent_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CopyFromSerializedPropertyIfDifferentInternal(UnityEditor.SerializedProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasAnyInstantiatedPrefabsWithValidAsset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasAnyInstantiatedPrefabsWithValidAsset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VersionEquals(UnityEditor.SerializedObject  @x, UnityEditor.SerializedObject  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RVersionEquals_SerializedObject_SerializedObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VersionEqualsInternal(UnityEditor.SerializedObject  @x, UnityEditor.SerializedObject  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RVersionEqualsInternal_SerializedObject_SerializedObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
