
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.UnityType
	/// </summary>
    public partial class RUnityType : RMember //
    {

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__name__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__name__1__k__BackingField
		{
			get
			{
				if(r_F__0__name__1__k__BackingField == null)
				{
					r_F__0__name__1__k__BackingField = new(this, "<name>k__BackingField");
					r_F__0__name__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <nativeNamespace>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__nativeNamespace__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__nativeNamespace__1__k__BackingField
		{
			get
			{
				if(r_F__0__nativeNamespace__1__k__BackingField == null)
				{
					r_F__0__nativeNamespace__1__k__BackingField = new(this, "<nativeNamespace>k__BackingField");
					r_F__0__nativeNamespace__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__nativeNamespace__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <module>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__module__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__module__1__k__BackingField
		{
			get
			{
				if(r_F__0__module__1__k__BackingField == null)
				{
					r_F__0__module__1__k__BackingField = new(this, "<module>k__BackingField");
					r_F__0__module__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__module__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <persistentTypeID>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__persistentTypeID__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__persistentTypeID__1__k__BackingField
		{
			get
			{
				if(r_F__0__persistentTypeID__1__k__BackingField == null)
				{
					r_F__0__persistentTypeID__1__k__BackingField = new(this, "<persistentTypeID>k__BackingField");
					r_F__0__persistentTypeID__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__persistentTypeID__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType <baseClass>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUnityType r_F__0__baseClass__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUnityType RF__0__baseClass__1__k__BackingField
		{
			get
			{
				if(r_F__0__baseClass__1__k__BackingField == null)
				{
					r_F__0__baseClass__1__k__BackingField = new(this, "<baseClass>k__BackingField");
					r_F__0__baseClass__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__baseClass__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.UnityTypeFlags <flags>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUnityTypeFlags r_F__0__flags__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUnityTypeFlags RF__0__flags__1__k__BackingField
		{
			get
			{
				if(r_F__0__flags__1__k__BackingField == null)
				{
					r_F__0__flags__1__k__BackingField = new(this, "<flags>k__BackingField");
					r_F__0__flags__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__flags__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 runtimeTypeIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FruntimeTypeIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFruntimeTypeIndex
		{
			get
			{
				if(r_FruntimeTypeIndex == null)
				{
					r_FruntimeTypeIndex = new(this, "runtimeTypeIndex");
					r_FruntimeTypeIndex.SetBelong(this.instance);
				}
				return r_FruntimeTypeIndex;
			}
		}

		/// <summary>
		/// System.UInt32 descendantCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdescendantCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdescendantCount
		{
			get
			{
				if(r_FdescendantCount == null)
				{
					r_FdescendantCount = new(this, "descendantCount");
					r_FdescendantCount.SetBelong(this.instance);
				}
				return r_FdescendantCount;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType[] ms_types
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RUnityType> r_Fms_types;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RUnityType> RFms_types
		{
			get
			{
				if(r_Fms_types == null)
				{
					r_Fms_types = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "ms_types");
					r_Fms_types.SetBelong(null);
				}
				return r_Fms_types;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.UnityType] ms_typesReadOnly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RUnityType> r_Fms_typesReadOnly;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RUnityType> RFms_typesReadOnly
		{
			get
			{
				if(r_Fms_typesReadOnly == null)
				{
					r_Fms_typesReadOnly = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "ms_typesReadOnly");
					r_Fms_typesReadOnly.SetBelong(null);
				}
				return r_Fms_typesReadOnly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEditor.UnityType] ms_idToType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEditor.RUnityType> r_Fms_idToType;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEditor.RUnityType> RFms_idToType
		{
			get
			{
				if(r_Fms_idToType == null)
				{
					r_Fms_idToType = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "ms_idToType");
					r_Fms_idToType.SetBelong(null);
				}
				return r_Fms_idToType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.UnityType] ms_nameToType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RUnityType> r_Fms_nameToType;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RUnityType> RFms_nameToType
		{
			get
			{
				if(r_Fms_nameToType == null)
				{
					r_Fms_nameToType = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "ms_nameToType");
					r_Fms_nameToType.SetBelong(null);
				}
				return r_Fms_nameToType;
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
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String nativeNamespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PnativeNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPnativeNamespace
		{
			get
			{
				if(r_PnativeNamespace == null)
				{
					r_PnativeNamespace = new(this, "nativeNamespace", -1);
					r_PnativeNamespace.SetBelong(this.instance);
				}
				return r_PnativeNamespace;
			}
		}

		/// <summary>
		/// System.String module
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pmodule;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPmodule
		{
			get
			{
				if(r_Pmodule == null)
				{
					r_Pmodule = new(this, "module", -1);
					r_Pmodule.SetBelong(this.instance);
				}
				return r_Pmodule;
			}
		}

		/// <summary>
		/// Int32 persistentTypeID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpersistentTypeID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpersistentTypeID
		{
			get
			{
				if(r_PpersistentTypeID == null)
				{
					r_PpersistentTypeID = new(this, "persistentTypeID", -1);
					r_PpersistentTypeID.SetBelong(this.instance);
				}
				return r_PpersistentTypeID;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType baseClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUnityType r_PbaseClass;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUnityType RPbaseClass
		{
			get
			{
				if(r_PbaseClass == null)
				{
					r_PbaseClass = new(this, "baseClass", -1);
					r_PbaseClass.SetBelong(this.instance);
				}
				return r_PbaseClass;
			}
		}

		/// <summary>
		/// UnityEditor.UnityTypeFlags flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUnityTypeFlags r_Pflags;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUnityTypeFlags RPflags
		{
			get
			{
				if(r_Pflags == null)
				{
					r_Pflags = new(this, "flags", -1);
					r_Pflags.SetBelong(this.instance);
				}
				return r_Pflags;
			}
		}

		/// <summary>
		/// Boolean isAbstract
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisAbstract;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisAbstract
		{
			get
			{
				if(r_PisAbstract == null)
				{
					r_PisAbstract = new(this, "isAbstract", -1);
					r_PisAbstract.SetBelong(this.instance);
				}
				return r_PisAbstract;
			}
		}

		/// <summary>
		/// Boolean isSealed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSealed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisSealed
		{
			get
			{
				if(r_PisSealed == null)
				{
					r_PisSealed = new(this, "isSealed", -1);
					r_PisSealed.SetBelong(this.instance);
				}
				return r_PisSealed;
			}
		}

		/// <summary>
		/// Boolean isEditorOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisEditorOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisEditorOnly
		{
			get
			{
				if(r_PisEditorOnly == null)
				{
					r_PisEditorOnly = new(this, "isEditorOnly", -1);
					r_PisEditorOnly.SetBelong(this.instance);
				}
				return r_PisEditorOnly;
			}
		}

		/// <summary>
		/// System.String qualifiedName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PqualifiedName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPqualifiedName
		{
			get
			{
				if(r_PqualifiedName == null)
				{
					r_PqualifiedName = new(this, "qualifiedName", -1);
					r_PqualifiedName.SetBelong(this.instance);
				}
				return r_PqualifiedName;
			}
		}

		/// <summary>
		/// Boolean hasNativeNamespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasNativeNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasNativeNamespace
		{
			get
			{
				if(r_PhasNativeNamespace == null)
				{
					r_PhasNativeNamespace = new(this, "hasNativeNamespace", -1);
					r_PhasNativeNamespace.SetBelong(this.instance);
				}
				return r_PhasNativeNamespace;
			}
		}

		/// <summary>
		/// UInt32 TypeCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_PTypeCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RPTypeCount
		{
			get
			{
				if(r_PTypeCount == null)
				{
					r_PTypeCount = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "TypeCount", -1);
					r_PTypeCount.SetBelong(null);
				}
				return r_PTypeCount;
			}
		}

		/// <summary>
		/// UnityTypeTransport[] Internal_GetAllTypes()
		/// </summary>
		protected static RMethod r_MInternal_GetAllTypes;
		public static RMethod RMInternal_GetAllTypes
		{
			get
			{
				if(r_MInternal_GetAllTypes == null)
				{
					r_MInternal_GetAllTypes = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "Internal_GetAllTypes", 0);
					r_MInternal_GetAllTypes.SetBelong(null);
				}
				return r_MInternal_GetAllTypes;
			}
		}

		/// <summary>
		/// Boolean IsDerivedFrom(UnityEditor.UnityType)
		/// </summary>
		protected RMethod r_MIsDerivedFrom_UnityType;
		public virtual RMethod RMIsDerivedFrom_UnityType
		{
			get
			{
				if(r_MIsDerivedFrom_UnityType == null)
				{
					r_MIsDerivedFrom_UnityType = new(this, "IsDerivedFrom", 0,  ReflectionUtils.GetType("UnityEditor.UnityType"));
					r_MIsDerivedFrom_UnityType.SetBelong(this.instance);
				}
				return r_MIsDerivedFrom_UnityType;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType FindTypeByPersistentTypeID(Int32)
		/// </summary>
		protected static RMethod r_MFindTypeByPersistentTypeID_Int32;
		public static RMethod RMFindTypeByPersistentTypeID_Int32
		{
			get
			{
				if(r_MFindTypeByPersistentTypeID_Int32 == null)
				{
					r_MFindTypeByPersistentTypeID_Int32 = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "FindTypeByPersistentTypeID", 0, typeof(System.Int32));
					r_MFindTypeByPersistentTypeID_Int32.SetBelong(null);
				}
				return r_MFindTypeByPersistentTypeID_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType GetTypeByRuntimeTypeIndex(UInt32)
		/// </summary>
		protected static RMethod r_MGetTypeByRuntimeTypeIndex_UInt32;
		public static RMethod RMGetTypeByRuntimeTypeIndex_UInt32
		{
			get
			{
				if(r_MGetTypeByRuntimeTypeIndex_UInt32 == null)
				{
					r_MGetTypeByRuntimeTypeIndex_UInt32 = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "GetTypeByRuntimeTypeIndex", 0, typeof(System.UInt32));
					r_MGetTypeByRuntimeTypeIndex_UInt32.SetBelong(null);
				}
				return r_MGetTypeByRuntimeTypeIndex_UInt32;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType FindTypeByName(System.String)
		/// </summary>
		protected static RMethod r_MFindTypeByName_String;
		public static RMethod RMFindTypeByName_String
		{
			get
			{
				if(r_MFindTypeByName_String == null)
				{
					r_MFindTypeByName_String = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "FindTypeByName", 0, typeof(System.String));
					r_MFindTypeByName_String.SetBelong(null);
				}
				return r_MFindTypeByName_String;
			}
		}

		/// <summary>
		/// UnityEditor.UnityType FindTypeByNameCaseInsensitive(System.String)
		/// </summary>
		protected static RMethod r_MFindTypeByNameCaseInsensitive_String;
		public static RMethod RMFindTypeByNameCaseInsensitive_String
		{
			get
			{
				if(r_MFindTypeByNameCaseInsensitive_String == null)
				{
					r_MFindTypeByNameCaseInsensitive_String = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "FindTypeByNameCaseInsensitive", 0, typeof(System.String));
					r_MFindTypeByNameCaseInsensitive_String.SetBelong(null);
				}
				return r_MFindTypeByNameCaseInsensitive_String;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.UnityType] GetTypes()
		/// </summary>
		protected static RMethod r_MGetTypes;
		public static RMethod RMGetTypes
		{
			get
			{
				if(r_MGetTypes == null)
				{
					r_MGetTypes = new( ReflectionUtils.GetType("UnityEditor.UnityType"), "GetTypes", 0);
					r_MGetTypes.SetBelong(null);
				}
				return r_MGetTypes;
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

        public static Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RUnityType.RUnityTypeTransport> Internal_GetAllTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_GetAllTypes.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RUnityType.RUnityTypeTransport>(___result);
        }


        public virtual System.Boolean IsDerivedFrom(Hvak.Editor.Refleaction.RUnityEditor.RUnityType @baseClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseClass.Value};
            var ___result = RMIsDerivedFrom_UnityType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RUnityType FindTypeByPersistentTypeID(System.Int32 @persistentTypeId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@persistentTypeId};
            var ___result = RMFindTypeByPersistentTypeID_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RUnityType(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RUnityType GetTypeByRuntimeTypeIndex(System.UInt32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetTypeByRuntimeTypeIndex_UInt32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RUnityType(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RUnityType FindTypeByName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindTypeByName_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RUnityType(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RUnityType FindTypeByNameCaseInsensitive(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindTypeByNameCaseInsensitive_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RUnityType(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RUnityType> GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypes.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RUnityType>(___result);
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
