using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.UnityType
	/// </summary>
    public partial class RUnityType : RMember //
    {

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected RField r___0__name__1__k__BackingField;
		public virtual RField R__0__name__1__k__BackingField
		{
			get
			{
				if(r___0__name__1__k__BackingField == null)
				{
					r___0__name__1__k__BackingField = new(this, "<name>k__BackingField");
					r___0__name__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <nativeNamespace>k__BackingField
		/// </summary>
		protected RField r___0__nativeNamespace__1__k__BackingField;
		public virtual RField R__0__nativeNamespace__1__k__BackingField
		{
			get
			{
				if(r___0__nativeNamespace__1__k__BackingField == null)
				{
					r___0__nativeNamespace__1__k__BackingField = new(this, "<nativeNamespace>k__BackingField");
					r___0__nativeNamespace__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__nativeNamespace__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <module>k__BackingField
		/// </summary>
		protected RField r___0__module__1__k__BackingField;
		public virtual RField R__0__module__1__k__BackingField
		{
			get
			{
				if(r___0__module__1__k__BackingField == null)
				{
					r___0__module__1__k__BackingField = new(this, "<module>k__BackingField");
					r___0__module__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__module__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <persistentTypeID>k__BackingField
		/// </summary>
		protected RField r___0__persistentTypeID__1__k__BackingField;
		public virtual RField R__0__persistentTypeID__1__k__BackingField
		{
			get
			{
				if(r___0__persistentTypeID__1__k__BackingField == null)
				{
					r___0__persistentTypeID__1__k__BackingField = new(this, "<persistentTypeID>k__BackingField");
					r___0__persistentTypeID__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__persistentTypeID__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType <baseClass>k__BackingField
		/// </summary>
		protected RUnityEditor.RUnityType r___0__baseClass__1__k__BackingField;
		public virtual RUnityEditor.RUnityType R__0__baseClass__1__k__BackingField
		{
			get
			{
				if(r___0__baseClass__1__k__BackingField == null)
				{
					r___0__baseClass__1__k__BackingField = new(this, "<baseClass>k__BackingField");
					r___0__baseClass__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__baseClass__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.UnityTypeFlags <flags>k__BackingField
		/// </summary>
		protected RField r___0__flags__1__k__BackingField;
		public virtual RField R__0__flags__1__k__BackingField
		{
			get
			{
				if(r___0__flags__1__k__BackingField == null)
				{
					r___0__flags__1__k__BackingField = new(this, "<flags>k__BackingField");
					r___0__flags__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__flags__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 runtimeTypeIndex
		/// </summary>
		protected RField r_runtimeTypeIndex;
		public virtual RField RruntimeTypeIndex
		{
			get
			{
				if(r_runtimeTypeIndex == null)
				{
					r_runtimeTypeIndex = new(this, "runtimeTypeIndex");
					r_runtimeTypeIndex.SetBelong(this.instance);
				}
				return r_runtimeTypeIndex;
			}
		}

		/// <summary>
		/// System.UInt32 descendantCount
		/// </summary>
		protected RField r_descendantCount;
		public virtual RField RdescendantCount
		{
			get
			{
				if(r_descendantCount == null)
				{
					r_descendantCount = new(this, "descendantCount");
					r_descendantCount.SetBelong(this.instance);
				}
				return r_descendantCount;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType[] ms_types
		/// </summary>
		protected static RFieldArray<RUnityEditor.RUnityType> r_ms_types;
		public static RFieldArray<RUnityEditor.RUnityType> Rms_types
		{
			get
			{
				if(r_ms_types == null)
				{
					r_ms_types = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "ms_types");
					r_ms_types.SetBelong(null);
				}
				return r_ms_types;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.UnityType] ms_typesReadOnly
		/// </summary>
		protected static RSystem.RCollections.RObjectModel.RReadOnlyCollection<RUnityEditor.RUnityType> r_ms_typesReadOnly;
		public static RSystem.RCollections.RObjectModel.RReadOnlyCollection<RUnityEditor.RUnityType> Rms_typesReadOnly
		{
			get
			{
				if(r_ms_typesReadOnly == null)
				{
					r_ms_typesReadOnly = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "ms_typesReadOnly");
					r_ms_typesReadOnly.SetBelong(null);
				}
				return r_ms_typesReadOnly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEditor.UnityType] ms_idToType
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditor.RUnityType> r_ms_idToType;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditor.RUnityType> Rms_idToType
		{
			get
			{
				if(r_ms_idToType == null)
				{
					r_ms_idToType = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "ms_idToType");
					r_ms_idToType.SetBelong(null);
				}
				return r_ms_idToType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.UnityType] ms_nameToType
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditor.RUnityType> r_ms_nameToType;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditor.RUnityType> Rms_nameToType
		{
			get
			{
				if(r_ms_nameToType == null)
				{
					r_ms_nameToType = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "ms_nameToType");
					r_ms_nameToType.SetBelong(null);
				}
				return r_ms_nameToType;
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
		/// System.String nativeNamespace
		/// </summary>
		protected RProperty r_nativeNamespace;
		public virtual RProperty RnativeNamespace
		{
			get
			{
				if(r_nativeNamespace == null)
				{
					r_nativeNamespace = new(this, "nativeNamespace", -1);
					r_nativeNamespace.SetBelong(this.instance);
				}
				return r_nativeNamespace;
			}
		}

		/// <summary>
		/// System.String module
		/// </summary>
		protected RProperty r_module;
		public virtual RProperty Rmodule
		{
			get
			{
				if(r_module == null)
				{
					r_module = new(this, "module", -1);
					r_module.SetBelong(this.instance);
				}
				return r_module;
			}
		}

		/// <summary>
		/// Int32 persistentTypeID
		/// </summary>
		protected RProperty r_persistentTypeID;
		public virtual RProperty RpersistentTypeID
		{
			get
			{
				if(r_persistentTypeID == null)
				{
					r_persistentTypeID = new(this, "persistentTypeID", -1);
					r_persistentTypeID.SetBelong(this.instance);
				}
				return r_persistentTypeID;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType baseClass
		/// </summary>
		protected RUnityEditor.RUnityType r_baseClass;
		public virtual RUnityEditor.RUnityType RbaseClass
		{
			get
			{
				if(r_baseClass == null)
				{
					r_baseClass = new(this, "baseClass", -1);
					r_baseClass.SetBelong(this.instance);
				}
				return r_baseClass;
			}
		}

		/// <summary>
		/// UnityEditor.UnityTypeFlags flags
		/// </summary>
		protected RProperty r_flags;
		public virtual RProperty Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags", -1);
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// Boolean isAbstract
		/// </summary>
		protected RProperty r_isAbstract;
		public virtual RProperty RisAbstract
		{
			get
			{
				if(r_isAbstract == null)
				{
					r_isAbstract = new(this, "isAbstract", -1);
					r_isAbstract.SetBelong(this.instance);
				}
				return r_isAbstract;
			}
		}

		/// <summary>
		/// Boolean isSealed
		/// </summary>
		protected RProperty r_isSealed;
		public virtual RProperty RisSealed
		{
			get
			{
				if(r_isSealed == null)
				{
					r_isSealed = new(this, "isSealed", -1);
					r_isSealed.SetBelong(this.instance);
				}
				return r_isSealed;
			}
		}

		/// <summary>
		/// Boolean isEditorOnly
		/// </summary>
		protected RProperty r_isEditorOnly;
		public virtual RProperty RisEditorOnly
		{
			get
			{
				if(r_isEditorOnly == null)
				{
					r_isEditorOnly = new(this, "isEditorOnly", -1);
					r_isEditorOnly.SetBelong(this.instance);
				}
				return r_isEditorOnly;
			}
		}

		/// <summary>
		/// System.String qualifiedName
		/// </summary>
		protected RProperty r_qualifiedName;
		public virtual RProperty RqualifiedName
		{
			get
			{
				if(r_qualifiedName == null)
				{
					r_qualifiedName = new(this, "qualifiedName", -1);
					r_qualifiedName.SetBelong(this.instance);
				}
				return r_qualifiedName;
			}
		}

		/// <summary>
		/// Boolean hasNativeNamespace
		/// </summary>
		protected RProperty r_hasNativeNamespace;
		public virtual RProperty RhasNativeNamespace
		{
			get
			{
				if(r_hasNativeNamespace == null)
				{
					r_hasNativeNamespace = new(this, "hasNativeNamespace", -1);
					r_hasNativeNamespace.SetBelong(this.instance);
				}
				return r_hasNativeNamespace;
			}
		}

		/// <summary>
		/// UInt32 TypeCount
		/// </summary>
		protected static RProperty r_TypeCount;
		public static RProperty RTypeCount
		{
			get
			{
				if(r_TypeCount == null)
				{
					r_TypeCount = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "TypeCount", -1);
					r_TypeCount.SetBelong(null);
				}
				return r_TypeCount;
			}
		}

		/// <summary>
		/// UnityTypeTransport[] Internal_GetAllTypes()
		/// </summary>
		protected static RMethod r_Internal_GetAllTypes;
		public static RMethod RInternal_GetAllTypes
		{
			get
			{
				if(r_Internal_GetAllTypes == null)
				{
					r_Internal_GetAllTypes = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "Internal_GetAllTypes", 0);
					r_Internal_GetAllTypes.SetBelong(null);
				}
				return r_Internal_GetAllTypes;
			}
		}

		/// <summary>
		/// Boolean IsDerivedFrom(UnityEditor.UnityType)
		/// </summary>
		protected RMethod r_IsDerivedFrom_UnityType;
		public virtual RMethod RIsDerivedFrom_UnityType
		{
			get
			{
				if(r_IsDerivedFrom_UnityType == null)
				{
					r_IsDerivedFrom_UnityType = new(this, "IsDerivedFrom", 0,  ReleactionUtils.GetType("UnityEditor.UnityType"));
					r_IsDerivedFrom_UnityType.SetBelong(this.instance);
				}
				return r_IsDerivedFrom_UnityType;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType FindTypeByPersistentTypeID(Int32)
		/// </summary>
		protected static RMethod r_FindTypeByPersistentTypeID_Int32;
		public static RMethod RFindTypeByPersistentTypeID_Int32
		{
			get
			{
				if(r_FindTypeByPersistentTypeID_Int32 == null)
				{
					r_FindTypeByPersistentTypeID_Int32 = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "FindTypeByPersistentTypeID", 0, typeof(System.Int32));
					r_FindTypeByPersistentTypeID_Int32.SetBelong(null);
				}
				return r_FindTypeByPersistentTypeID_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType GetTypeByRuntimeTypeIndex(UInt32)
		/// </summary>
		protected static RMethod r_GetTypeByRuntimeTypeIndex_UInt32;
		public static RMethod RGetTypeByRuntimeTypeIndex_UInt32
		{
			get
			{
				if(r_GetTypeByRuntimeTypeIndex_UInt32 == null)
				{
					r_GetTypeByRuntimeTypeIndex_UInt32 = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "GetTypeByRuntimeTypeIndex", 0, typeof(System.UInt32));
					r_GetTypeByRuntimeTypeIndex_UInt32.SetBelong(null);
				}
				return r_GetTypeByRuntimeTypeIndex_UInt32;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType FindTypeByName(System.String)
		/// </summary>
		protected static RMethod r_FindTypeByName_String;
		public static RMethod RFindTypeByName_String
		{
			get
			{
				if(r_FindTypeByName_String == null)
				{
					r_FindTypeByName_String = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "FindTypeByName", 0, typeof(System.String));
					r_FindTypeByName_String.SetBelong(null);
				}
				return r_FindTypeByName_String;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType FindTypeByNameCaseInsensitive(System.String)
		/// </summary>
		protected static RMethod r_FindTypeByNameCaseInsensitive_String;
		public static RMethod RFindTypeByNameCaseInsensitive_String
		{
			get
			{
				if(r_FindTypeByNameCaseInsensitive_String == null)
				{
					r_FindTypeByNameCaseInsensitive_String = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "FindTypeByNameCaseInsensitive", 0, typeof(System.String));
					r_FindTypeByNameCaseInsensitive_String.SetBelong(null);
				}
				return r_FindTypeByNameCaseInsensitive_String;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.UnityType] GetTypes()
		/// </summary>
		protected static RMethod r_GetTypes;
		public static RMethod RGetTypes
		{
			get
			{
				if(r_GetTypes == null)
				{
					r_GetTypes = new( ReleactionUtils.GetType("UnityEditor.UnityType"), "GetTypes", 0);
					r_GetTypes.SetBelong(null);
				}
				return r_GetTypes;
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


        public RUnityType() : base("UnityEditor.UnityType")
        {
        }

        public RUnityType(System.Object instance) : base("UnityEditor.UnityType")
		{
            SetInstance(instance);
		}

        public RUnityType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object Internal_GetAllTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetAllTypes.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public static System.Object FindTypeByPersistentTypeID(System.Int32  @persistentTypeId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@persistentTypeId};
            var ___result = RFindTypeByPersistentTypeID_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object GetTypeByRuntimeTypeIndex(System.UInt32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetTypeByRuntimeTypeIndex_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FindTypeByName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindTypeByName_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FindTypeByNameCaseInsensitive(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindTypeByNameCaseInsensitive_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
