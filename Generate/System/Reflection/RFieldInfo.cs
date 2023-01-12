using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.FieldInfo
	/// </summary>
    public partial class RFieldInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual RSystem.RReflection.RMemberTypes RPMemberType
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
		/// System.Reflection.FieldAttributes Attributes
		/// </summary>
		protected RSystem.RReflection.RFieldAttributes r_PAttributes;
		public virtual RSystem.RReflection.RFieldAttributes RPAttributes
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
		/// System.Type FieldType
		/// </summary>
		protected RSystem.RType r_PFieldType;
		public virtual RSystem.RType RPFieldType
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
		/// Boolean IsInitOnly
		/// </summary>
		protected RSystem.RBoolean r_PIsInitOnly;
		public virtual RSystem.RBoolean RPIsInitOnly
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
		protected RSystem.RBoolean r_PIsLiteral;
		public virtual RSystem.RBoolean RPIsLiteral
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
		protected RSystem.RBoolean r_PIsNotSerialized;
		public virtual RSystem.RBoolean RPIsNotSerialized
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
		protected RSystem.RBoolean r_PIsPinvokeImpl;
		public virtual RSystem.RBoolean RPIsPinvokeImpl
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
		protected RSystem.RBoolean r_PIsSpecialName;
		public virtual RSystem.RBoolean RPIsSpecialName
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
		protected RSystem.RBoolean r_PIsStatic;
		public virtual RSystem.RBoolean RPIsStatic
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
		protected RSystem.RBoolean r_PIsAssembly;
		public virtual RSystem.RBoolean RPIsAssembly
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
		protected RSystem.RBoolean r_PIsFamily;
		public virtual RSystem.RBoolean RPIsFamily
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
		protected RSystem.RBoolean r_PIsFamilyAndAssembly;
		public virtual RSystem.RBoolean RPIsFamilyAndAssembly
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
		protected RSystem.RBoolean r_PIsFamilyOrAssembly;
		public virtual RSystem.RBoolean RPIsFamilyOrAssembly
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
		protected RSystem.RBoolean r_PIsPrivate;
		public virtual RSystem.RBoolean RPIsPrivate
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
		protected RSystem.RBoolean r_PIsPublic;
		public virtual RSystem.RBoolean RPIsPublic
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
		/// Boolean IsSecurityCritical
		/// </summary>
		protected RSystem.RBoolean r_PIsSecurityCritical;
		public virtual RSystem.RBoolean RPIsSecurityCritical
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
		protected RSystem.RBoolean r_PIsSecuritySafeCritical;
		public virtual RSystem.RBoolean RPIsSecuritySafeCritical
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
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected RSystem.RBoolean r_PIsSecurityTransparent;
		public virtual RSystem.RBoolean RPIsSecurityTransparent
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
		/// System.RuntimeFieldHandle FieldHandle
		/// </summary>
		protected RSystem.RRuntimeFieldHandle r_PFieldHandle;
		public virtual RSystem.RRuntimeFieldHandle RPFieldHandle
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
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_PName;
		public virtual RSystem.RString RPName
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
		/// System.Type DeclaringType
		/// </summary>
		protected RSystem.RType r_PDeclaringType;
		public virtual RSystem.RType RPDeclaringType
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
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_PReflectedType;
		public virtual RSystem.RType RPReflectedType
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
		/// System.Reflection.Module Module
		/// </summary>
		protected RSystem.RReflection.RModule r_PModule;
		public virtual RSystem.RReflection.RModule RPModule
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
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
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
		/// Int32 MetadataToken
		/// </summary>
		protected RSystem.RInt32 r_PMetadataToken;
		public virtual RSystem.RInt32 RPMetadataToken
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
		/// Boolean op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
		/// </summary>
		protected static RMethod r_Mop_Equality_FieldInfo_FieldInfo;
		public static RMethod RMop_Equality_FieldInfo_FieldInfo
		{
			get
			{
				if(r_Mop_Equality_FieldInfo_FieldInfo == null)
				{
					r_Mop_Equality_FieldInfo_FieldInfo = new(typeof(System.Reflection.FieldInfo), "op_Equality", 0, typeof(System.Reflection.FieldInfo), typeof(System.Reflection.FieldInfo));
					r_Mop_Equality_FieldInfo_FieldInfo.SetBelong(null);
				}
				return r_Mop_Equality_FieldInfo_FieldInfo;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
		/// </summary>
		protected static RMethod r_Mop_Inequality_FieldInfo_FieldInfo;
		public static RMethod RMop_Inequality_FieldInfo_FieldInfo
		{
			get
			{
				if(r_Mop_Inequality_FieldInfo_FieldInfo == null)
				{
					r_Mop_Inequality_FieldInfo_FieldInfo = new(typeof(System.Reflection.FieldInfo), "op_Inequality", 0, typeof(System.Reflection.FieldInfo), typeof(System.Reflection.FieldInfo));
					r_Mop_Inequality_FieldInfo_FieldInfo.SetBelong(null);
				}
				return r_Mop_Inequality_FieldInfo_FieldInfo;
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
		/// System.Reflection.FieldInfo internal_from_handle_type(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Minternal_from_handle_type_IntPtr_IntPtr;
		public static RMethod RMinternal_from_handle_type_IntPtr_IntPtr
		{
			get
			{
				if(r_Minternal_from_handle_type_IntPtr_IntPtr == null)
				{
					r_Minternal_from_handle_type_IntPtr_IntPtr = new(typeof(System.Reflection.FieldInfo), "internal_from_handle_type", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_Minternal_from_handle_type_IntPtr_IntPtr.SetBelong(null);
				}
				return r_Minternal_from_handle_type_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle)
		/// </summary>
		protected static RMethod r_MGetFieldFromHandle_RuntimeFieldHandle;
		public static RMethod RMGetFieldFromHandle_RuntimeFieldHandle
		{
			get
			{
				if(r_MGetFieldFromHandle_RuntimeFieldHandle == null)
				{
					r_MGetFieldFromHandle_RuntimeFieldHandle = new(typeof(System.Reflection.FieldInfo), "GetFieldFromHandle", 0, typeof(System.RuntimeFieldHandle));
					r_MGetFieldFromHandle_RuntimeFieldHandle.SetBelong(null);
				}
				return r_MGetFieldFromHandle_RuntimeFieldHandle;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_MGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle;
		public static RMethod RMGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_MGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle == null)
				{
					r_MGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle = new(typeof(System.Reflection.FieldInfo), "GetFieldFromHandle", 0, typeof(System.RuntimeFieldHandle), typeof(System.RuntimeTypeHandle));
					r_MGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_MGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle;
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
		/// System.Runtime.InteropServices.MarshalAsAttribute get_marshal_info()
		/// </summary>
		protected RMethod r_Mget_marshal_info;
		public virtual RMethod RMget_marshal_info
		{
			get
			{
				if(r_Mget_marshal_info == null)
				{
					r_Mget_marshal_info = new(this, "get_marshal_info", 0);
					r_Mget_marshal_info.SetBelong(this.instance);
				}
				return r_Mget_marshal_info;
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
		/// Void System.Runtime.InteropServices._FieldInfo.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._FieldInfo.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// System.Type System.Runtime.InteropServices._FieldInfo.GetType()
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType = new(this, "System.Runtime.InteropServices._FieldInfo.GetType", 0);
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._FieldInfo.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._FieldInfo.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._FieldInfo.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._FieldInfo.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._FieldInfo.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._FieldInfo.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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


        public RFieldInfo() : base("System.Reflection.FieldInfo")
        {
        }

        public RFieldInfo(System.Object instance) : base("System.Reflection.FieldInfo")
		{
            SetInstance(instance);
		}

        public RFieldInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFieldInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public static System.Boolean op_Equality(System.Reflection.FieldInfo @left, System.Reflection.FieldInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_FieldInfo_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.FieldInfo @left, System.Reflection.FieldInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_FieldInfo_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetValue(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RMSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @obj, System.Object @value, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @culture};
            var ___result = RMSetValue_Object_Object_BindingFlags_Binder_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValueDirect(RSystem.RTypedReference @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj.Value, @value};
            var ___result = RMSetValueDirect_TypedReference_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetValueDirect(RSystem.RTypedReference @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj.Value};
            var ___result = RMGetValueDirect_TypedReference.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public static System.Reflection.FieldInfo internal_from_handle_type(System.IntPtr @field_handle, System.IntPtr @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field_handle, @type_handle};
            var ___result = RMinternal_from_handle_type_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public static System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetFieldFromHandle_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public static System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle @handle, System.RuntimeTypeHandle @declaringType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @declaringType};
            var ___result = RMGetFieldFromHandle_RuntimeFieldHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Int32 GetFieldOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFieldOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Runtime.InteropServices.MarshalAsAttribute get_marshal_info()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_marshal_info.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.MarshalAsAttribute)___result;
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


        public virtual void System__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type System__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___FieldInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
