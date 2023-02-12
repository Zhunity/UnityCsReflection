
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeFieldInfo
	/// </summary>
    public partial class RRuntimeFieldInfo : RMember //
    {

		/// <summary>
		/// System.IntPtr klass
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fklass;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFklass
		{
			get
			{
				if(r_Fklass == null)
				{
					r_Fklass = new(this, "klass");
					r_Fklass.SetBelong(this.instance);
				}
				return r_Fklass;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle fhandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeFieldHandle r_Ffhandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeFieldHandle RFfhandle
		{
			get
			{
				if(r_Ffhandle == null)
				{
					r_Ffhandle = new(this, "fhandle");
					r_Ffhandle.SetBelong(this.instance);
				}
				return r_Ffhandle;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Type type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Ftype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes attrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_Fattrs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
					r_Fattrs.SetBelong(this.instance);
				}
				return r_Fattrs;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BindingFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_PBindingFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RBindingFlags RPBindingFlags
		{
			get
			{
				if(r_PBindingFlags == null)
				{
					r_PBindingFlags = new(this, "BindingFlags", -1);
					r_PBindingFlags.SetBelong(this.instance);
				}
				return r_PBindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RModule r_PModule;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
					r_PModule.SetBelong(this.instance);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.RuntimeType ReflectedTypeInternal
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeType r_PReflectedTypeInternal;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeType RPReflectedTypeInternal
		{
			get
			{
				if(r_PReflectedTypeInternal == null)
				{
					r_PReflectedTypeInternal = new(this, "ReflectedTypeInternal", -1);
					r_PReflectedTypeInternal.SetBelong(this.instance);
				}
				return r_PReflectedTypeInternal;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Attributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_PAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle FieldHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeFieldHandle r_PFieldHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeFieldHandle RPFieldHandle
		{
			get
			{
				if(r_PFieldHandle == null)
				{
					r_PFieldHandle = new(this, "FieldHandle", -1);
					r_PFieldHandle.SetBelong(this.instance);
				}
				return r_PFieldHandle;
			}
		}

		/// <summary>
		/// System.Type FieldType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PFieldType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPFieldType
		{
			get
			{
				if(r_PFieldType == null)
				{
					r_PFieldType = new(this, "FieldType", -1);
					r_PFieldType.SetBelong(this.instance);
				}
				return r_PFieldType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PReflectedType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
					r_PReflectedType.SetBelong(this.instance);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PDeclaringType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
					r_PDeclaringType.SetBelong(this.instance);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityTransparent;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecurityTransparent
		{
			get
			{
				if(r_PIsSecurityTransparent == null)
				{
					r_PIsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_PIsSecurityTransparent.SetBelong(this.instance);
				}
				return r_PIsSecurityTransparent;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityCritical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecurityCritical
		{
			get
			{
				if(r_PIsSecurityCritical == null)
				{
					r_PIsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_PIsSecurityCritical.SetBelong(this.instance);
				}
				return r_PIsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecuritySafeCritical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecuritySafeCritical
		{
			get
			{
				if(r_PIsSecuritySafeCritical == null)
				{
					r_PIsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_PIsSecuritySafeCritical.SetBelong(this.instance);
				}
				return r_PIsSecuritySafeCritical;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PMetadataToken;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
					r_PMemberType.SetBelong(this.instance);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// Boolean IsInitOnly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsInitOnly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsInitOnly
		{
			get
			{
				if(r_PIsInitOnly == null)
				{
					r_PIsInitOnly = new(this, "IsInitOnly", -1);
					r_PIsInitOnly.SetBelong(this.instance);
				}
				return r_PIsInitOnly;
			}
		}

		/// <summary>
		/// Boolean IsLiteral
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsLiteral;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsLiteral
		{
			get
			{
				if(r_PIsLiteral == null)
				{
					r_PIsLiteral = new(this, "IsLiteral", -1);
					r_PIsLiteral.SetBelong(this.instance);
				}
				return r_PIsLiteral;
			}
		}

		/// <summary>
		/// Boolean IsNotSerialized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsNotSerialized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsNotSerialized
		{
			get
			{
				if(r_PIsNotSerialized == null)
				{
					r_PIsNotSerialized = new(this, "IsNotSerialized", -1);
					r_PIsNotSerialized.SetBelong(this.instance);
				}
				return r_PIsNotSerialized;
			}
		}

		/// <summary>
		/// Boolean IsPinvokeImpl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPinvokeImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPinvokeImpl
		{
			get
			{
				if(r_PIsPinvokeImpl == null)
				{
					r_PIsPinvokeImpl = new(this, "IsPinvokeImpl", -1);
					r_PIsPinvokeImpl.SetBelong(this.instance);
				}
				return r_PIsPinvokeImpl;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSpecialName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
					r_PIsSpecialName.SetBelong(this.instance);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// Boolean IsStatic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsStatic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsStatic
		{
			get
			{
				if(r_PIsStatic == null)
				{
					r_PIsStatic = new(this, "IsStatic", -1);
					r_PIsStatic.SetBelong(this.instance);
				}
				return r_PIsStatic;
			}
		}

		/// <summary>
		/// Boolean IsAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAssembly
		{
			get
			{
				if(r_PIsAssembly == null)
				{
					r_PIsAssembly = new(this, "IsAssembly", -1);
					r_PIsAssembly.SetBelong(this.instance);
				}
				return r_PIsAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamily
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamily;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamily
		{
			get
			{
				if(r_PIsFamily == null)
				{
					r_PIsFamily = new(this, "IsFamily", -1);
					r_PIsFamily.SetBelong(this.instance);
				}
				return r_PIsFamily;
			}
		}

		/// <summary>
		/// Boolean IsFamilyAndAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyAndAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamilyAndAssembly
		{
			get
			{
				if(r_PIsFamilyAndAssembly == null)
				{
					r_PIsFamilyAndAssembly = new(this, "IsFamilyAndAssembly", -1);
					r_PIsFamilyAndAssembly.SetBelong(this.instance);
				}
				return r_PIsFamilyAndAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamilyOrAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyOrAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamilyOrAssembly
		{
			get
			{
				if(r_PIsFamilyOrAssembly == null)
				{
					r_PIsFamilyOrAssembly = new(this, "IsFamilyOrAssembly", -1);
					r_PIsFamilyOrAssembly.SetBelong(this.instance);
				}
				return r_PIsFamilyOrAssembly;
			}
		}

		/// <summary>
		/// Boolean IsPrivate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPrivate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPrivate
		{
			get
			{
				if(r_PIsPrivate == null)
				{
					r_PIsPrivate = new(this, "IsPrivate", -1);
					r_PIsPrivate.SetBelong(this.instance);
				}
				return r_PIsPrivate;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPublic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPublic
		{
			get
			{
				if(r_PIsPublic == null)
				{
					r_PIsPublic = new(this, "IsPublic", -1);
					r_PIsPublic.SetBelong(this.instance);
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
					r_PCustomAttributes.SetBelong(this.instance);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// System.RuntimeType GetDeclaringTypeInternal()
		/// </summary>
		protected RMethod r_MGetDeclaringTypeInternal;
		public virtual RMethod RMGetDeclaringTypeInternal
		{
			get
			{
				if(r_MGetDeclaringTypeInternal == null)
				{
					r_MGetDeclaringTypeInternal = new(this, "GetDeclaringTypeInternal", 0);
					r_MGetDeclaringTypeInternal.SetBelong(this.instance);
				}
				return r_MGetDeclaringTypeInternal;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeModule GetRuntimeModule()
		/// </summary>
		protected RMethod r_MGetRuntimeModule;
		public virtual RMethod RMGetRuntimeModule
		{
			get
			{
				if(r_MGetRuntimeModule == null)
				{
					r_MGetRuntimeModule = new(this, "GetRuntimeModule", 0);
					r_MGetRuntimeModule.SetBelong(this.instance);
				}
				return r_MGetRuntimeModule;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object UnsafeGetValue(System.Object)
		/// </summary>
		protected RMethod r_MUnsafeGetValue_Object;
		public virtual RMethod RMUnsafeGetValue_Object
		{
			get
			{
				if(r_MUnsafeGetValue_Object == null)
				{
					r_MUnsafeGetValue_Object = new(this, "UnsafeGetValue", 0, typeof(System.Object));
					r_MUnsafeGetValue_Object.SetBelong(this.instance);
				}
				return r_MUnsafeGetValue_Object;
			}
		}

		/// <summary>
		/// Void CheckConsistency(System.Object)
		/// </summary>
		protected RMethod r_MCheckConsistency_Object;
		public virtual RMethod RMCheckConsistency_Object
		{
			get
			{
				if(r_MCheckConsistency_Object == null)
				{
					r_MCheckConsistency_Object = new(this, "CheckConsistency", 0, typeof(System.Object));
					r_MCheckConsistency_Object.SetBelong(this.instance);
				}
				return r_MCheckConsistency_Object;
			}
		}

		/// <summary>
		/// Void UnsafeSetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo;
		public virtual RMethod RMUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo
		{
			get
			{
				if(r_MUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo == null)
				{
					r_MUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo = new(this, "UnsafeSetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Globalization.CultureInfo));
					r_MUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo.SetBelong(this.instance);
				}
				return r_MUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo;
			}
		}

		/// <summary>
		/// Void SetValueDirect(TypedReference, System.Object)
		/// </summary>
		protected RMethod r_MSetValueDirect_TypedReference_Object;
		public virtual RMethod RMSetValueDirect_TypedReference_Object
		{
			get
			{
				if(r_MSetValueDirect_TypedReference_Object == null)
				{
					r_MSetValueDirect_TypedReference_Object = new(this, "SetValueDirect", 0, typeof(System.TypedReference), typeof(System.Object));
					r_MSetValueDirect_TypedReference_Object.SetBelong(this.instance);
				}
				return r_MSetValueDirect_TypedReference_Object;
			}
		}

		/// <summary>
		/// System.Object GetValueDirect(TypedReference)
		/// </summary>
		protected RMethod r_MGetValueDirect_TypedReference;
		public virtual RMethod RMGetValueDirect_TypedReference
		{
			get
			{
				if(r_MGetValueDirect_TypedReference == null)
				{
					r_MGetValueDirect_TypedReference = new(this, "GetValueDirect", 0, typeof(System.TypedReference));
					r_MGetValueDirect_TypedReference.SetBelong(this.instance);
				}
				return r_MGetValueDirect_TypedReference;
			}
		}

		/// <summary>
		/// System.Type ResolveType()
		/// </summary>
		protected RMethod r_MResolveType;
		public virtual RMethod RMResolveType
		{
			get
			{
				if(r_MResolveType == null)
				{
					r_MResolveType = new(this, "ResolveType", 0);
					r_MResolveType.SetBelong(this.instance);
				}
				return r_MResolveType;
			}
		}

		/// <summary>
		/// System.Type GetParentType(Boolean)
		/// </summary>
		protected RMethod r_MGetParentType_Boolean;
		public virtual RMethod RMGetParentType_Boolean
		{
			get
			{
				if(r_MGetParentType_Boolean == null)
				{
					r_MGetParentType_Boolean = new(this, "GetParentType", 0, typeof(System.Boolean));
					r_MGetParentType_Boolean.SetBelong(this.instance);
				}
				return r_MGetParentType_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MIsDefined_Type_Boolean;
		public virtual RMethod RMIsDefined_Type_Boolean
		{
			get
			{
				if(r_MIsDefined_Type_Boolean == null)
				{
					r_MIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_MIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Boolean;
		public virtual RMethod RMGetCustomAttributes_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Boolean == null)
				{
					r_MGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_MGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Type_Boolean;
		public virtual RMethod RMGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Type_Boolean == null)
				{
					r_MGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetFieldOffset()
		/// </summary>
		protected RMethod r_MGetFieldOffset;
		public virtual RMethod RMGetFieldOffset
		{
			get
			{
				if(r_MGetFieldOffset == null)
				{
					r_MGetFieldOffset = new(this, "GetFieldOffset", 0);
					r_MGetFieldOffset.SetBelong(this.instance);
				}
				return r_MGetFieldOffset;
			}
		}

		/// <summary>
		/// System.Object GetValueInternal(System.Object)
		/// </summary>
		protected RMethod r_MGetValueInternal_Object;
		public virtual RMethod RMGetValueInternal_Object
		{
			get
			{
				if(r_MGetValueInternal_Object == null)
				{
					r_MGetValueInternal_Object = new(this, "GetValueInternal", 0, typeof(System.Object));
					r_MGetValueInternal_Object.SetBelong(this.instance);
				}
				return r_MGetValueInternal_Object;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object)
		/// </summary>
		protected RMethod r_MGetValue_Object;
		public virtual RMethod RMGetValue_Object
		{
			get
			{
				if(r_MGetValue_Object == null)
				{
					r_MGetValue_Object = new(this, "GetValue", 0, typeof(System.Object));
					r_MGetValue_Object.SetBelong(this.instance);
				}
				return r_MGetValue_Object;
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

		/// <summary>
		/// Void SetValueInternal(System.Reflection.FieldInfo, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MSetValueInternal_FieldInfo_Object_Object;
		public static RMethod RMSetValueInternal_FieldInfo_Object_Object
		{
			get
			{
				if(r_MSetValueInternal_FieldInfo_Object_Object == null)
				{
					r_MSetValueInternal_FieldInfo_Object_Object = new( ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"), "SetValueInternal", 0, typeof(System.Reflection.FieldInfo), typeof(System.Object), typeof(System.Object));
					r_MSetValueInternal_FieldInfo_Object_Object.SetBelong(null);
				}
				return r_MSetValueInternal_FieldInfo_Object_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MSetValue_Object_Object_BindingFlags_Binder_CultureInfo;
		public virtual RMethod RMSetValue_Object_Object_BindingFlags_Binder_CultureInfo
		{
			get
			{
				if(r_MSetValue_Object_Object_BindingFlags_Binder_CultureInfo == null)
				{
					r_MSetValue_Object_Object_BindingFlags_Binder_CultureInfo = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Globalization.CultureInfo));
					r_MSetValue_Object_Object_BindingFlags_Binder_CultureInfo.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object_BindingFlags_Binder_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeFieldInfo Clone(System.String)
		/// </summary>
		protected RMethod r_MClone_String;
		public virtual RMethod RMClone_String
		{
			get
			{
				if(r_MClone_String == null)
				{
					r_MClone_String = new(this, "Clone", 0, typeof(System.String));
					r_MClone_String.SetBelong(this.instance);
				}
				return r_MClone_String;
			}
		}

		/// <summary>
		/// System.Object GetRawConstantValue()
		/// </summary>
		protected RMethod r_MGetRawConstantValue;
		public virtual RMethod RMGetRawConstantValue
		{
			get
			{
				if(r_MGetRawConstantValue == null)
				{
					r_MGetRawConstantValue = new(this, "GetRawConstantValue", 0);
					r_MGetRawConstantValue.SetBelong(this.instance);
				}
				return r_MGetRawConstantValue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetCustomAttributesData;
		public virtual RMethod RMGetCustomAttributesData
		{
			get
			{
				if(r_MGetCustomAttributesData == null)
				{
					r_MGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_MGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Void CheckGeneric()
		/// </summary>
		protected RMethod r_MCheckGeneric;
		public virtual RMethod RMCheckGeneric
		{
			get
			{
				if(r_MCheckGeneric == null)
				{
					r_MCheckGeneric = new(this, "CheckGeneric", 0);
					r_MCheckGeneric.SetBelong(this.instance);
				}
				return r_MCheckGeneric;
			}
		}

		/// <summary>
		/// Int32 get_core_clr_security_level()
		/// </summary>
		protected RMethod r_Mget_core_clr_security_level;
		public virtual RMethod RMget_core_clr_security_level
		{
			get
			{
				if(r_Mget_core_clr_security_level == null)
				{
					r_Mget_core_clr_security_level = new(this, "get_core_clr_security_level", 0);
					r_Mget_core_clr_security_level.SetBelong(this.instance);
				}
				return r_Mget_core_clr_security_level;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Int32 get_metadata_token(System.Reflection.RuntimeFieldInfo)
		/// </summary>
		protected static RMethod r_Mget_metadata_token_RuntimeFieldInfo;
		public static RMethod RMget_metadata_token_RuntimeFieldInfo
		{
			get
			{
				if(r_Mget_metadata_token_RuntimeFieldInfo == null)
				{
					r_Mget_metadata_token_RuntimeFieldInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"), "get_metadata_token", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"));
					r_Mget_metadata_token_RuntimeFieldInfo.SetBelong(null);
				}
				return r_Mget_metadata_token_RuntimeFieldInfo;
			}
		}

		/// <summary>
		/// System.Type[] GetTypeModifiers(Boolean)
		/// </summary>
		protected RMethod r_MGetTypeModifiers_Boolean;
		public virtual RMethod RMGetTypeModifiers_Boolean
		{
			get
			{
				if(r_MGetTypeModifiers_Boolean == null)
				{
					r_MGetTypeModifiers_Boolean = new(this, "GetTypeModifiers", 0, typeof(System.Boolean));
					r_MGetTypeModifiers_Boolean.SetBelong(this.instance);
				}
				return r_MGetTypeModifiers_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_MGetOptionalCustomModifiers;
		public virtual RMethod RMGetOptionalCustomModifiers
		{
			get
			{
				if(r_MGetOptionalCustomModifiers == null)
				{
					r_MGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_MGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_MGetRequiredCustomModifiers;
		public virtual RMethod RMGetRequiredCustomModifiers
		{
			get
			{
				if(r_MGetRequiredCustomModifiers == null)
				{
					r_MGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_MGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetCustomModifiers(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomModifiers_Boolean;
		public virtual RMethod RMGetCustomModifiers_Boolean
		{
			get
			{
				if(r_MGetCustomModifiers_Boolean == null)
				{
					r_MGetCustomModifiers_Boolean = new(this, "GetCustomModifiers", 0, typeof(System.Boolean));
					r_MGetCustomModifiers_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomModifiers_Boolean;
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
		/// Void SetValue(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MSetValue_Object_Object;
		public virtual RMethod RMSetValue_Object_Object
		{
			get
			{
				if(r_MSetValue_Object_Object == null)
				{
					r_MSetValue_Object_Object = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object));
					r_MSetValue_Object_Object.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object;
			}
		}

		/// <summary>
		/// System.Object[] GetPseudoCustomAttributes()
		/// </summary>
		protected RMethod r_MGetPseudoCustomAttributes;
		public virtual RMethod RMGetPseudoCustomAttributes
		{
			get
			{
				if(r_MGetPseudoCustomAttributes == null)
				{
					r_MGetPseudoCustomAttributes = new(this, "GetPseudoCustomAttributes", 0);
					r_MGetPseudoCustomAttributes.SetBelong(this.instance);
				}
				return r_MGetPseudoCustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetPseudoCustomAttributesData;
		public virtual RMethod RMGetPseudoCustomAttributesData
		{
			get
			{
				if(r_MGetPseudoCustomAttributesData == null)
				{
					r_MGetPseudoCustomAttributesData = new(this, "GetPseudoCustomAttributesData", 0);
					r_MGetPseudoCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetPseudoCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_MCacheEquals_Object;
		public virtual RMethod RMCacheEquals_Object
		{
			get
			{
				if(r_MCacheEquals_Object == null)
				{
					r_MCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_MCacheEquals_Object.SetBelong(this.instance);
				}
				return r_MCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RRuntimeFieldInfo() : base("System.Reflection.RuntimeFieldInfo")
        {
        }

        public RRuntimeFieldInfo(System.Object instance) : base("System.Reflection.RuntimeFieldInfo")
		{
            SetInstance(instance);
		}

        public RRuntimeFieldInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeFieldInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeType GetDeclaringTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDeclaringTypeInternal.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RRuntimeType(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RRuntimeModule GetRuntimeModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRuntimeModule.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReflection.RRuntimeModule(___result);
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object UnsafeGetValue(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMUnsafeGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void CheckConsistency(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCheckConsistency_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeSetValue(System.Object @obj, System.Object @value, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @culture};
            var ___result = RMUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValueDirect(SMFrame.Editor.Refleaction.RSystem.RTypedReference @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj.Value, @value};
            var ___result = RMSetValueDirect_TypedReference_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetValueDirect(SMFrame.Editor.Refleaction.RSystem.RTypedReference @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj.Value};
            var ___result = RMGetValueDirect_TypedReference.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type ResolveType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetParentType(System.Boolean @declaring)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@declaring};
            var ___result = RMGetParentType_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Int32 GetFieldOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFieldOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetValueInternal(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetValueInternal_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void SetValueInternal(System.Reflection.FieldInfo @fi, System.Object @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fi, @obj, @value};
            var ___result = RMSetValueInternal_FieldInfo_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @obj, System.Object @val, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @val, @invokeAttr, @binder, @culture};
            var ___result = RMSetValue_Object_Object_BindingFlags_Binder_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo Clone(System.String @newName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newName};
            var ___result = RMClone_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo(___result);
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual void CheckGeneric()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckGeneric.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 get_core_clr_security_level()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_core_clr_security_level.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 get_metadata_token(SMFrame.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo @monoField)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@monoField.Value};
            var ___result = RMget_metadata_token_RuntimeFieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type[] GetTypeModifiers(System.Boolean @optional)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optional};
            var ___result = RMGetTypeModifiers_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetCustomModifiers(System.Boolean @optional)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optional};
            var ___result = RMGetCustomModifiers_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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


        public virtual void SetValue(System.Object @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RMSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object[] GetPseudoCustomAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPseudoCustomAttributes.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPseudoCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Reflection.CustomAttributeData[])___result;
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}