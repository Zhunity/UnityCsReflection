
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.SerializedObject
	/// </summary>
    public partial class RSerializedObject : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.SerializedObject);
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


		/// <summary>
		/// System.IntPtr m_NativeObjectPtr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_NativeObjectPtr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_NativeObjectPtr
		{
			get
			{
				if(r_Fm_NativeObjectPtr == null)
				{
					r_Fm_NativeObjectPtr = new(this, "m_NativeObjectPtr");
				}
				return r_Fm_NativeObjectPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Object targetObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_PtargetObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPtargetObject
		{
			get
			{
				if(r_PtargetObject == null)
				{
					r_PtargetObject = new(this, "targetObject", -1);
				}
				return r_PtargetObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] targetObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_PtargetObjects;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> RPtargetObjects
		{
			get
			{
				if(r_PtargetObjects == null)
				{
					r_PtargetObjects = new(this, "targetObjects", -1);
				}
				return r_PtargetObjects;
			}
		}

		/// <summary>
		/// Int32 targetObjectsCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtargetObjectsCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtargetObjectsCount
		{
			get
			{
				if(r_PtargetObjectsCount == null)
				{
					r_PtargetObjectsCount = new(this, "targetObjectsCount", -1);
				}
				return r_PtargetObjectsCount;
			}
		}

		/// <summary>
		/// UnityEngine.Object context
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Pcontext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPcontext
		{
			get
			{
				if(r_Pcontext == null)
				{
					r_Pcontext = new(this, "context", -1);
				}
				return r_Pcontext;
			}
		}

		/// <summary>
		/// Boolean hasModifiedProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasModifiedProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasModifiedProperties
		{
			get
			{
				if(r_PhasModifiedProperties == null)
				{
					r_PhasModifiedProperties = new(this, "hasModifiedProperties", -1);
				}
				return r_PhasModifiedProperties;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode inspectorMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode r_PinspectorMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode RPinspectorMode
		{
			get
			{
				if(r_PinspectorMode == null)
				{
					r_PinspectorMode = new(this, "inspectorMode", -1);
				}
				return r_PinspectorMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode inspectorDataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_PinspectorDataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RPinspectorDataMode
		{
			get
			{
				if(r_PinspectorDataMode == null)
				{
					r_PinspectorDataMode = new(this, "inspectorDataMode", -1);
				}
				return r_PinspectorDataMode;
			}
		}

		/// <summary>
		/// Boolean isEditingMultipleObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisEditingMultipleObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisEditingMultipleObjects
		{
			get
			{
				if(r_PisEditingMultipleObjects == null)
				{
					r_PisEditingMultipleObjects = new(this, "isEditingMultipleObjects", -1);
				}
				return r_PisEditingMultipleObjects;
			}
		}

		/// <summary>
		/// Int32 maxArraySizeForMultiEditing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaxArraySizeForMultiEditing;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmaxArraySizeForMultiEditing
		{
			get
			{
				if(r_PmaxArraySizeForMultiEditing == null)
				{
					r_PmaxArraySizeForMultiEditing = new(this, "maxArraySizeForMultiEditing", -1);
				}
				return r_PmaxArraySizeForMultiEditing;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// UInt32 objectVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PobjectVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPobjectVersion
		{
			get
			{
				if(r_PobjectVersion == null)
				{
					r_PobjectVersion = new(this, "objectVersion", -1);
				}
				return r_PobjectVersion;
			}
		}

		/// <summary>
		/// Boolean forceChildVisibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PforceChildVisibility;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPforceChildVisibility
		{
			get
			{
				if(r_PforceChildVisibility == null)
				{
					r_PforceChildVisibility = new(this, "forceChildVisibility", -1);
				}
				return r_PforceChildVisibility;
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
					r_MInternal_Destroy_IntPtr = new(Type, "Internal_Destroy", 0, typeof(System.IntPtr));
				}
				return r_MInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetIterator()
		/// </summary>
		protected RMethod r_MGetIterator;
		public virtual RMethod RMGetIterator
		{
			get
			{
				if(r_MGetIterator == null)
				{
					r_MGetIterator = new(this, "GetIterator", 0);
				}
				return r_MGetIterator;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty FindProperty(System.String)
		/// </summary>
		protected RMethod r_MFindProperty_String;
		public virtual RMethod RMFindProperty_String
		{
			get
			{
				if(r_MFindProperty_String == null)
				{
					r_MFindProperty_String = new(this, "FindProperty", 0, typeof(System.String));
				}
				return r_MFindProperty_String;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty FindFirstPropertyFromManagedReferencePath(System.String)
		/// </summary>
		protected RMethod r_MFindFirstPropertyFromManagedReferencePath_String;
		public virtual RMethod RMFindFirstPropertyFromManagedReferencePath_String
		{
			get
			{
				if(r_MFindFirstPropertyFromManagedReferencePath_String == null)
				{
					r_MFindFirstPropertyFromManagedReferencePath_String = new(this, "FindFirstPropertyFromManagedReferencePath", 0, typeof(System.String));
				}
				return r_MFindFirstPropertyFromManagedReferencePath_String;
			}
		}

		/// <summary>
		/// Boolean ApplyModifiedProperties()
		/// </summary>
		protected RMethod r_MApplyModifiedProperties;
		public virtual RMethod RMApplyModifiedProperties
		{
			get
			{
				if(r_MApplyModifiedProperties == null)
				{
					r_MApplyModifiedProperties = new(this, "ApplyModifiedProperties", 0);
				}
				return r_MApplyModifiedProperties;
			}
		}

		/// <summary>
		/// Void SetIsDifferentCacheDirty()
		/// </summary>
		protected RMethod r_MSetIsDifferentCacheDirty;
		public virtual RMethod RMSetIsDifferentCacheDirty
		{
			get
			{
				if(r_MSetIsDifferentCacheDirty == null)
				{
					r_MSetIsDifferentCacheDirty = new(this, "SetIsDifferentCacheDirty", 0);
				}
				return r_MSetIsDifferentCacheDirty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty GetIterator_Internal()
		/// </summary>
		protected RMethod r_MGetIterator_Internal;
		public virtual RMethod RMGetIterator_Internal
		{
			get
			{
				if(r_MGetIterator_Internal == null)
				{
					r_MGetIterator_Internal = new(this, "GetIterator_Internal", 0);
				}
				return r_MGetIterator_Internal;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void UpdateIfDirtyOrScript()
		/// </summary>
		protected RMethod r_MUpdateIfDirtyOrScript;
		public virtual RMethod RMUpdateIfDirtyOrScript
		{
			get
			{
				if(r_MUpdateIfDirtyOrScript == null)
				{
					r_MUpdateIfDirtyOrScript = new(this, "UpdateIfDirtyOrScript", 0);
				}
				return r_MUpdateIfDirtyOrScript;
			}
		}

		/// <summary>
		/// Boolean UpdateIfRequiredOrScript()
		/// </summary>
		protected RMethod r_MUpdateIfRequiredOrScript;
		public virtual RMethod RMUpdateIfRequiredOrScript
		{
			get
			{
				if(r_MUpdateIfRequiredOrScript == null)
				{
					r_MUpdateIfRequiredOrScript = new(this, "UpdateIfRequiredOrScript", 0);
				}
				return r_MUpdateIfRequiredOrScript;
			}
		}

		/// <summary>
		/// Void UpdateExpandedState()
		/// </summary>
		protected RMethod r_MUpdateExpandedState;
		public virtual RMethod RMUpdateExpandedState
		{
			get
			{
				if(r_MUpdateExpandedState == null)
				{
					r_MUpdateExpandedState = new(this, "UpdateExpandedState", 0);
				}
				return r_MUpdateExpandedState;
			}
		}

		/// <summary>
		/// IntPtr InternalCreate(UnityEngine.Object[], UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MInternalCreate_ObjectArray_Object;
		public static RMethod RMInternalCreate_ObjectArray_Object
		{
			get
			{
				if(r_MInternalCreate_ObjectArray_Object == null)
				{
					r_MInternalCreate_ObjectArray_Object = new(Type, "InternalCreate", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object));
				}
				return r_MInternalCreate_ObjectArray_Object;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyModification ExtractPropertyModification(System.String)
		/// </summary>
		protected RMethod r_MExtractPropertyModification_String;
		public virtual RMethod RMExtractPropertyModification_String
		{
			get
			{
				if(r_MExtractPropertyModification_String == null)
				{
					r_MExtractPropertyModification_String = new(this, "ExtractPropertyModification", 0, typeof(System.String));
				}
				return r_MExtractPropertyModification_String;
			}
		}

		/// <summary>
		/// System.Object InternalExtractPropertyModification(System.String)
		/// </summary>
		protected RMethod r_MInternalExtractPropertyModification_String;
		public virtual RMethod RMInternalExtractPropertyModification_String
		{
			get
			{
				if(r_MInternalExtractPropertyModification_String == null)
				{
					r_MInternalExtractPropertyModification_String = new(this, "InternalExtractPropertyModification", 0, typeof(System.String));
				}
				return r_MInternalExtractPropertyModification_String;
			}
		}

		/// <summary>
		/// Void Cache(Int32)
		/// </summary>
		protected RMethod r_MCache_Int32;
		public virtual RMethod RMCache_Int32
		{
			get
			{
				if(r_MCache_Int32 == null)
				{
					r_MCache_Int32 = new(this, "Cache", 0, typeof(System.Int32));
				}
				return r_MCache_Int32;
			}
		}

		/// <summary>
		/// Void CacheInternal(Int32)
		/// </summary>
		protected RMethod r_MCacheInternal_Int32;
		public virtual RMethod RMCacheInternal_Int32
		{
			get
			{
				if(r_MCacheInternal_Int32 == null)
				{
					r_MCacheInternal_Int32 = new(this, "CacheInternal", 0, typeof(System.Int32));
				}
				return r_MCacheInternal_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject LoadFromCache(Int32)
		/// </summary>
		protected static RMethod r_MLoadFromCache_Int32;
		public static RMethod RMLoadFromCache_Int32
		{
			get
			{
				if(r_MLoadFromCache_Int32 == null)
				{
					r_MLoadFromCache_Int32 = new(Type, "LoadFromCache", 0, typeof(System.Int32));
				}
				return r_MLoadFromCache_Int32;
			}
		}

		/// <summary>
		/// Boolean ApplyModifiedPropertiesWithoutUndo()
		/// </summary>
		protected RMethod r_MApplyModifiedPropertiesWithoutUndo;
		public virtual RMethod RMApplyModifiedPropertiesWithoutUndo
		{
			get
			{
				if(r_MApplyModifiedPropertiesWithoutUndo == null)
				{
					r_MApplyModifiedPropertiesWithoutUndo = new(this, "ApplyModifiedPropertiesWithoutUndo", 0);
				}
				return r_MApplyModifiedPropertiesWithoutUndo;
			}
		}

		/// <summary>
		/// Void EnableLivePropertyFeatureGlobally(Boolean)
		/// </summary>
		protected static RMethod r_MEnableLivePropertyFeatureGlobally_Boolean;
		public static RMethod RMEnableLivePropertyFeatureGlobally_Boolean
		{
			get
			{
				if(r_MEnableLivePropertyFeatureGlobally_Boolean == null)
				{
					r_MEnableLivePropertyFeatureGlobally_Boolean = new(Type, "EnableLivePropertyFeatureGlobally", 0, typeof(System.Boolean));
				}
				return r_MEnableLivePropertyFeatureGlobally_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetLivePropertyFeatureGlobalState()
		/// </summary>
		protected static RMethod r_MGetLivePropertyFeatureGlobalState;
		public static RMethod RMGetLivePropertyFeatureGlobalState
		{
			get
			{
				if(r_MGetLivePropertyFeatureGlobalState == null)
				{
					r_MGetLivePropertyFeatureGlobalState = new(Type, "GetLivePropertyFeatureGlobalState", 0);
				}
				return r_MGetLivePropertyFeatureGlobalState;
			}
		}

		/// <summary>
		/// Void CopyFromSerializedProperty(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCopyFromSerializedProperty_SerializedProperty;
		public virtual RMethod RMCopyFromSerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MCopyFromSerializedProperty_SerializedProperty == null)
				{
					r_MCopyFromSerializedProperty_SerializedProperty = new(this, "CopyFromSerializedProperty", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCopyFromSerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Void CopyFromSerializedPropertyInternal(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCopyFromSerializedPropertyInternal_SerializedProperty;
		public virtual RMethod RMCopyFromSerializedPropertyInternal_SerializedProperty
		{
			get
			{
				if(r_MCopyFromSerializedPropertyInternal_SerializedProperty == null)
				{
					r_MCopyFromSerializedPropertyInternal_SerializedProperty = new(this, "CopyFromSerializedPropertyInternal", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCopyFromSerializedPropertyInternal_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean CopyFromSerializedPropertyIfDifferent(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCopyFromSerializedPropertyIfDifferent_SerializedProperty;
		public virtual RMethod RMCopyFromSerializedPropertyIfDifferent_SerializedProperty
		{
			get
			{
				if(r_MCopyFromSerializedPropertyIfDifferent_SerializedProperty == null)
				{
					r_MCopyFromSerializedPropertyIfDifferent_SerializedProperty = new(this, "CopyFromSerializedPropertyIfDifferent", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCopyFromSerializedPropertyIfDifferent_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean CopyFromSerializedPropertyIfDifferentInternal(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty;
		public virtual RMethod RMCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty
		{
			get
			{
				if(r_MCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty == null)
				{
					r_MCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty = new(this, "CopyFromSerializedPropertyIfDifferentInternal", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean HasAnyInstantiatedPrefabsWithValidAsset()
		/// </summary>
		protected RMethod r_MHasAnyInstantiatedPrefabsWithValidAsset;
		public virtual RMethod RMHasAnyInstantiatedPrefabsWithValidAsset
		{
			get
			{
				if(r_MHasAnyInstantiatedPrefabsWithValidAsset == null)
				{
					r_MHasAnyInstantiatedPrefabsWithValidAsset = new(this, "HasAnyInstantiatedPrefabsWithValidAsset", 0);
				}
				return r_MHasAnyInstantiatedPrefabsWithValidAsset;
			}
		}

		/// <summary>
		/// Boolean VersionEquals(UnityEditor.SerializedObject, UnityEditor.SerializedObject)
		/// </summary>
		protected static RMethod r_MVersionEquals_SerializedObject_SerializedObject;
		public static RMethod RMVersionEquals_SerializedObject_SerializedObject
		{
			get
			{
				if(r_MVersionEquals_SerializedObject_SerializedObject == null)
				{
					r_MVersionEquals_SerializedObject_SerializedObject = new(Type, "VersionEquals", 0, typeof(UnityEditor.SerializedObject), typeof(UnityEditor.SerializedObject));
				}
				return r_MVersionEquals_SerializedObject_SerializedObject;
			}
		}

		/// <summary>
		/// Boolean VersionEqualsInternal(UnityEditor.SerializedObject, UnityEditor.SerializedObject)
		/// </summary>
		protected static RMethod r_MVersionEqualsInternal_SerializedObject_SerializedObject;
		public static RMethod RMVersionEqualsInternal_SerializedObject_SerializedObject
		{
			get
			{
				if(r_MVersionEqualsInternal_SerializedObject_SerializedObject == null)
				{
					r_MVersionEqualsInternal_SerializedObject_SerializedObject = new(Type, "VersionEqualsInternal", 0, typeof(UnityEditor.SerializedObject), typeof(UnityEditor.SerializedObject));
				}
				return r_MVersionEqualsInternal_SerializedObject_SerializedObject;
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


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual UnityEditor.SerializedProperty GetIterator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIterator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.SerializedProperty>(___result);
        }


        public virtual UnityEditor.SerializedProperty FindProperty(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMFindProperty_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.SerializedProperty>(___result);
        }


        public virtual UnityEditor.SerializedProperty FindFirstPropertyFromManagedReferencePath(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMFindFirstPropertyFromManagedReferencePath_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.SerializedProperty>(___result);
        }


        public virtual System.Boolean ApplyModifiedProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyModifiedProperties.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetIsDifferentCacheDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetIsDifferentCacheDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedProperty GetIterator_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIterator_Internal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.SerializedProperty>(___result);
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateIfDirtyOrScript()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateIfDirtyOrScript.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UpdateIfRequiredOrScript()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateIfRequiredOrScript.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void UpdateExpandedState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateExpandedState.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InternalCreate(UnityEngine.Object[] @monoObjs, UnityEngine.Object @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@monoObjs, @context};
            var ___result = RMInternalCreate_ObjectArray_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual UnityEditor.PropertyModification ExtractPropertyModification(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMExtractPropertyModification_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.PropertyModification>(___result);
        }


        public virtual System.Object InternalExtractPropertyModification(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RMInternalExtractPropertyModification_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual void Cache(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMCache_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CacheInternal(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMCacheInternal_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.SerializedObject LoadFromCache(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMLoadFromCache_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.SerializedObject>(___result);
        }


        public virtual System.Boolean ApplyModifiedPropertiesWithoutUndo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyModifiedPropertiesWithoutUndo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void EnableLivePropertyFeatureGlobally(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEnableLivePropertyFeatureGlobally_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetLivePropertyFeatureGlobalState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLivePropertyFeatureGlobalState.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void CopyFromSerializedProperty(UnityEditor.SerializedProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMCopyFromSerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFromSerializedPropertyInternal(UnityEditor.SerializedProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMCopyFromSerializedPropertyInternal_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CopyFromSerializedPropertyIfDifferent(UnityEditor.SerializedProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMCopyFromSerializedPropertyIfDifferent_SerializedProperty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CopyFromSerializedPropertyIfDifferentInternal(UnityEditor.SerializedProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMCopyFromSerializedPropertyIfDifferentInternal_SerializedProperty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasAnyInstantiatedPrefabsWithValidAsset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasAnyInstantiatedPrefabsWithValidAsset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean VersionEquals(UnityEditor.SerializedObject @x, UnityEditor.SerializedObject @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMVersionEquals_SerializedObject_SerializedObject.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean VersionEqualsInternal(UnityEditor.SerializedObject @x, UnityEditor.SerializedObject @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMVersionEqualsInternal_SerializedObject_SerializedObject.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
