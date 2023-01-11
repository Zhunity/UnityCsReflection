using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.PermissionSet
	/// </summary>
    public partial class RPermissionSet : RMember //
    {

		/// <summary>
		/// System.String tagName
		/// </summary>
		protected static RSystem.RString r_tagName;
		public static RSystem.RString RtagName
		{
			get
			{
				if(r_tagName == null)
				{
					r_tagName = new(typeof(System.Security.PermissionSet), "tagName");
					r_tagName.SetBelong(null);
				}
				return r_tagName;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected static RSystem.RInt32 r_version;
		public static RSystem.RInt32 Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(typeof(System.Security.PermissionSet), "version");
					r_version.SetBelong(null);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.Object[] psUnrestricted
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_psUnrestricted;
		public static RFieldArray<RSystem.RObject> RpsUnrestricted
		{
			get
			{
				if(r_psUnrestricted == null)
				{
					r_psUnrestricted = new(typeof(System.Security.PermissionSet), "psUnrestricted");
					r_psUnrestricted.SetBelong(null);
				}
				return r_psUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.Permissions.PermissionState state
		/// </summary>
		protected RField r_state;
		public virtual RField Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList list
		/// </summary>
		protected RSystem.RCollections.RArrayList r_list;
		public virtual RSystem.RCollections.RArrayList Rlist
		{
			get
			{
				if(r_list == null)
				{
					r_list = new(this, "list");
					r_list.SetBelong(this.instance);
				}
				return r_list;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel _policyLevel
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyLevel r__policyLevel;
		public virtual RSystem.RSecurity.RPolicy.RPolicyLevel R_policyLevel
		{
			get
			{
				if(r__policyLevel == null)
				{
					r__policyLevel = new(this, "_policyLevel");
					r__policyLevel.SetBelong(this.instance);
				}
				return r__policyLevel;
			}
		}

		/// <summary>
		/// System.Boolean _declsec
		/// </summary>
		protected RSystem.RBoolean r__declsec;
		public virtual RSystem.RBoolean R_declsec
		{
			get
			{
				if(r__declsec == null)
				{
					r__declsec = new(this, "_declsec");
					r__declsec.SetBelong(this.instance);
				}
				return r__declsec;
			}
		}

		/// <summary>
		/// System.Boolean _readOnly
		/// </summary>
		protected RSystem.RBoolean r__readOnly;
		public virtual RSystem.RBoolean R_readOnly
		{
			get
			{
				if(r__readOnly == null)
				{
					r__readOnly = new(this, "_readOnly");
					r__readOnly.SetBelong(this.instance);
				}
				return r__readOnly;
			}
		}

		/// <summary>
		/// System.Boolean[] _ignored
		/// </summary>
		protected RFieldArray<RSystem.RBoolean> r__ignored;
		public virtual RFieldArray<RSystem.RBoolean> R_ignored
		{
			get
			{
				if(r__ignored == null)
				{
					r__ignored = new(this, "_ignored");
					r__ignored.SetBelong(this.instance);
				}
				return r__ignored;
			}
		}

		/// <summary>
		/// System.Object[] action
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_action;
		public static RFieldArray<RSystem.RObject> Raction
		{
			get
			{
				if(r_action == null)
				{
					r_action = new(typeof(System.Security.PermissionSet), "action");
					r_action.SetBelong(null);
				}
				return r_action;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RSystem.RInt32 r_Count;
		public virtual RSystem.RInt32 RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RSystem.RBoolean r_IsSynchronized;
		public virtual RSystem.RBoolean RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_IsReadOnly;
		public virtual RSystem.RBoolean RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
			}
		}

		/// <summary>
		/// Boolean DeclarativeSecurity
		/// </summary>
		protected RSystem.RBoolean r_DeclarativeSecurity;
		public virtual RSystem.RBoolean RDeclarativeSecurity
		{
			get
			{
				if(r_DeclarativeSecurity == null)
				{
					r_DeclarativeSecurity = new(this, "DeclarativeSecurity", -1);
					r_DeclarativeSecurity.SetBelong(this.instance);
				}
				return r_DeclarativeSecurity;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel Resolver
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyLevel r_Resolver;
		public virtual RSystem.RSecurity.RPolicy.RPolicyLevel RResolver
		{
			get
			{
				if(r_Resolver == null)
				{
					r_Resolver = new(this, "Resolver", -1);
					r_Resolver.SetBelong(this.instance);
				}
				return r_Resolver;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_AddPermission_IPermission;
		public virtual RMethod RAddPermission_IPermission
		{
			get
			{
				if(r_AddPermission_IPermission == null)
				{
					r_AddPermission_IPermission = new(this, "AddPermission", 0, typeof(System.Security.IPermission));
					r_AddPermission_IPermission.SetBelong(this.instance);
				}
				return r_AddPermission_IPermission;
			}
		}

		/// <summary>
		/// Void Assert()
		/// </summary>
		protected RMethod r_Assert;
		public virtual RMethod RAssert
		{
			get
			{
				if(r_Assert == null)
				{
					r_Assert = new(this, "Assert", 0);
					r_Assert.SetBelong(this.instance);
				}
				return r_Assert;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_CopyTo_Array_Int32 == null)
				{
					r_CopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_Demand;
		public virtual RMethod RDemand
		{
			get
			{
				if(r_Demand == null)
				{
					r_Demand = new(this, "Demand", 0);
					r_Demand.SetBelong(this.instance);
				}
				return r_Demand;
			}
		}

		/// <summary>
		/// Void CasOnlyDemand(Int32)
		/// </summary>
		protected RMethod r_CasOnlyDemand_Int32;
		public virtual RMethod RCasOnlyDemand_Int32
		{
			get
			{
				if(r_CasOnlyDemand_Int32 == null)
				{
					r_CasOnlyDemand_Int32 = new(this, "CasOnlyDemand", 0, typeof(System.Int32));
					r_CasOnlyDemand_Int32.SetBelong(this.instance);
				}
				return r_CasOnlyDemand_Int32;
			}
		}

		/// <summary>
		/// Void Deny()
		/// </summary>
		protected RMethod r_Deny;
		public virtual RMethod RDeny
		{
			get
			{
				if(r_Deny == null)
				{
					r_Deny = new(this, "Deny", 0);
					r_Deny.SetBelong(this.instance);
				}
				return r_Deny;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_FromXml_SecurityElement;
		public virtual RMethod RFromXml_SecurityElement
		{
			get
			{
				if(r_FromXml_SecurityElement == null)
				{
					r_FromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_FromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_FromXml_SecurityElement;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_IsSubsetOf_PermissionSet;
		public virtual RMethod RIsSubsetOf_PermissionSet
		{
			get
			{
				if(r_IsSubsetOf_PermissionSet == null)
				{
					r_IsSubsetOf_PermissionSet = new(this, "IsSubsetOf", 0, typeof(System.Security.PermissionSet));
					r_IsSubsetOf_PermissionSet.SetBelong(this.instance);
				}
				return r_IsSubsetOf_PermissionSet;
			}
		}

		/// <summary>
		/// Void PermitOnly()
		/// </summary>
		protected RMethod r_PermitOnly;
		public virtual RMethod RPermitOnly
		{
			get
			{
				if(r_PermitOnly == null)
				{
					r_PermitOnly = new(this, "PermitOnly", 0);
					r_PermitOnly.SetBelong(this.instance);
				}
				return r_PermitOnly;
			}
		}

		/// <summary>
		/// Boolean ContainsNonCodeAccessPermissions()
		/// </summary>
		protected RMethod r_ContainsNonCodeAccessPermissions;
		public virtual RMethod RContainsNonCodeAccessPermissions
		{
			get
			{
				if(r_ContainsNonCodeAccessPermissions == null)
				{
					r_ContainsNonCodeAccessPermissions = new(this, "ContainsNonCodeAccessPermissions", 0);
					r_ContainsNonCodeAccessPermissions.SetBelong(this.instance);
				}
				return r_ContainsNonCodeAccessPermissions;
			}
		}

		/// <summary>
		/// Byte[] ConvertPermissionSet(System.String, Byte[], System.String)
		/// </summary>
		protected static RMethod r_ConvertPermissionSet_String_ByteArray_String;
		public static RMethod RConvertPermissionSet_String_ByteArray_String
		{
			get
			{
				if(r_ConvertPermissionSet_String_ByteArray_String == null)
				{
					r_ConvertPermissionSet_String_ByteArray_String = new(typeof(System.Security.PermissionSet), "ConvertPermissionSet", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.String));
					r_ConvertPermissionSet_String_ByteArray_String.SetBelong(null);
				}
				return r_ConvertPermissionSet_String_ByteArray_String;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermission(System.Type)
		/// </summary>
		protected RMethod r_GetPermission_Type;
		public virtual RMethod RGetPermission_Type
		{
			get
			{
				if(r_GetPermission_Type == null)
				{
					r_GetPermission_Type = new(this, "GetPermission", 0, typeof(System.Type));
					r_GetPermission_Type.SetBelong(this.instance);
				}
				return r_GetPermission_Type;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Intersect(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_Intersect_PermissionSet;
		public virtual RMethod RIntersect_PermissionSet
		{
			get
			{
				if(r_Intersect_PermissionSet == null)
				{
					r_Intersect_PermissionSet = new(this, "Intersect", 0, typeof(System.Security.PermissionSet));
					r_Intersect_PermissionSet.SetBelong(this.instance);
				}
				return r_Intersect_PermissionSet;
			}
		}

		/// <summary>
		/// Void InternalIntersect(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "InternalIntersect", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
					r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.SetBelong(this.instance);
				}
				return r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_IsEmpty;
		public virtual RMethod RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", 0);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
			}
		}

		/// <summary>
		/// Boolean IsUnrestricted()
		/// </summary>
		protected RMethod r_IsUnrestricted;
		public virtual RMethod RIsUnrestricted
		{
			get
			{
				if(r_IsUnrestricted == null)
				{
					r_IsUnrestricted = new(this, "IsUnrestricted", 0);
					r_IsUnrestricted.SetBelong(this.instance);
				}
				return r_IsUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermission(System.Type)
		/// </summary>
		protected RMethod r_RemovePermission_Type;
		public virtual RMethod RRemovePermission_Type
		{
			get
			{
				if(r_RemovePermission_Type == null)
				{
					r_RemovePermission_Type = new(this, "RemovePermission", 0, typeof(System.Type));
					r_RemovePermission_Type.SetBelong(this.instance);
				}
				return r_RemovePermission_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_SetPermission_IPermission;
		public virtual RMethod RSetPermission_IPermission
		{
			get
			{
				if(r_SetPermission_IPermission == null)
				{
					r_SetPermission_IPermission = new(this, "SetPermission", 0, typeof(System.Security.IPermission));
					r_SetPermission_IPermission.SetBelong(this.instance);
				}
				return r_SetPermission_IPermission;
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

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_ToXml;
		public virtual RMethod RToXml
		{
			get
			{
				if(r_ToXml == null)
				{
					r_ToXml = new(this, "ToXml", 0);
					r_ToXml.SetBelong(this.instance);
				}
				return r_ToXml;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Union(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_Union_PermissionSet;
		public virtual RMethod RUnion_PermissionSet
		{
			get
			{
				if(r_Union_PermissionSet == null)
				{
					r_Union_PermissionSet = new(this, "Union", 0, typeof(System.Security.PermissionSet));
					r_Union_PermissionSet.SetBelong(this.instance);
				}
				return r_Union_PermissionSet;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
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
		/// Void RevertAssert()
		/// </summary>
		protected static RMethod r_RevertAssert;
		public static RMethod RRevertAssert
		{
			get
			{
				if(r_RevertAssert == null)
				{
					r_RevertAssert = new(typeof(System.Security.PermissionSet), "RevertAssert", 0);
					r_RevertAssert.SetBelong(null);
				}
				return r_RevertAssert;
			}
		}

		/// <summary>
		/// Void SetReadOnly(Boolean)
		/// </summary>
		protected RMethod r_SetReadOnly_Boolean;
		public virtual RMethod RSetReadOnly_Boolean
		{
			get
			{
				if(r_SetReadOnly_Boolean == null)
				{
					r_SetReadOnly_Boolean = new(this, "SetReadOnly", 0, typeof(System.Boolean));
					r_SetReadOnly_Boolean.SetBelong(this.instance);
				}
				return r_SetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// Boolean AllIgnored()
		/// </summary>
		protected RMethod r_AllIgnored;
		public virtual RMethod RAllIgnored
		{
			get
			{
				if(r_AllIgnored == null)
				{
					r_AllIgnored = new(this, "AllIgnored", 0);
					r_AllIgnored.SetBelong(this.instance);
				}
				return r_AllIgnored;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet CreateFromBinaryFormat(Byte[])
		/// </summary>
		protected static RMethod r_CreateFromBinaryFormat_ByteArray;
		public static RMethod RCreateFromBinaryFormat_ByteArray
		{
			get
			{
				if(r_CreateFromBinaryFormat_ByteArray == null)
				{
					r_CreateFromBinaryFormat_ByteArray = new(typeof(System.Security.PermissionSet), "CreateFromBinaryFormat", 0, typeof(System.Byte).MakeArrayType());
					r_CreateFromBinaryFormat_ByteArray.SetBelong(null);
				}
				return r_CreateFromBinaryFormat_ByteArray;
			}
		}

		/// <summary>
		/// Int32 ReadEncodedInt(Byte[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_ReadEncodedInt_ByteArray_Ref_Int32;
		public static RMethod RReadEncodedInt_ByteArray_Ref_Int32
		{
			get
			{
				if(r_ReadEncodedInt_ByteArray_Ref_Int32 == null)
				{
					r_ReadEncodedInt_ByteArray_Ref_Int32 = new(typeof(System.Security.PermissionSet), "ReadEncodedInt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_ReadEncodedInt_ByteArray_Ref_Int32.SetBelong(null);
				}
				return r_ReadEncodedInt_ByteArray_Ref_Int32;
			}
		}

		/// <summary>
		/// System.Security.IPermission ProcessAttribute(Byte[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_ProcessAttribute_ByteArray_Ref_Int32;
		public static RMethod RProcessAttribute_ByteArray_Ref_Int32
		{
			get
			{
				if(r_ProcessAttribute_ByteArray_Ref_Int32 == null)
				{
					r_ProcessAttribute_ByteArray_Ref_Int32 = new(typeof(System.Security.PermissionSet), "ProcessAttribute", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_ProcessAttribute_ByteArray_Ref_Int32.SetBelong(null);
				}
				return r_ProcessAttribute_ByteArray_Ref_Int32;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_AddPermissionImpl_IPermission;
		public virtual RMethod RAddPermissionImpl_IPermission
		{
			get
			{
				if(r_AddPermissionImpl_IPermission == null)
				{
					r_AddPermissionImpl_IPermission = new(this, "AddPermissionImpl", 0, typeof(System.Security.IPermission));
					r_AddPermissionImpl_IPermission.SetBelong(this.instance);
				}
				return r_AddPermissionImpl_IPermission;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumeratorImpl()
		/// </summary>
		protected RMethod r_GetEnumeratorImpl;
		public virtual RMethod RGetEnumeratorImpl
		{
			get
			{
				if(r_GetEnumeratorImpl == null)
				{
					r_GetEnumeratorImpl = new(this, "GetEnumeratorImpl", 0);
					r_GetEnumeratorImpl.SetBelong(this.instance);
				}
				return r_GetEnumeratorImpl;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_GetPermissionImpl_Type;
		public virtual RMethod RGetPermissionImpl_Type
		{
			get
			{
				if(r_GetPermissionImpl_Type == null)
				{
					r_GetPermissionImpl_Type = new(this, "GetPermissionImpl", 0, typeof(System.Type));
					r_GetPermissionImpl_Type.SetBelong(this.instance);
				}
				return r_GetPermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_RemovePermissionImpl_Type;
		public virtual RMethod RRemovePermissionImpl_Type
		{
			get
			{
				if(r_RemovePermissionImpl_Type == null)
				{
					r_RemovePermissionImpl_Type = new(this, "RemovePermissionImpl", 0, typeof(System.Type));
					r_RemovePermissionImpl_Type.SetBelong(this.instance);
				}
				return r_RemovePermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_SetPermissionImpl_IPermission;
		public virtual RMethod RSetPermissionImpl_IPermission
		{
			get
			{
				if(r_SetPermissionImpl_IPermission == null)
				{
					r_SetPermissionImpl_IPermission = new(this, "SetPermissionImpl", 0, typeof(System.Security.IPermission));
					r_SetPermissionImpl_IPermission.SetBelong(this.instance);
				}
				return r_SetPermissionImpl_IPermission;
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


        public RPermissionSet() : base("System.Security.PermissionSet")
        {
        }

        public RPermissionSet(System.Object instance) : base("System.Security.PermissionSet")
		{
            SetInstance(instance);
		}

        public RPermissionSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPermissionSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.IPermission AddPermission(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RAddPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Assert()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAssert.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.PermissionSet Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Demand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDemand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CasOnlyDemand(System.Int32 @skip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skip};
            var ___result = RCasOnlyDemand_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Deny()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeny.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @et)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et};
            var ___result = RFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean IsSubsetOf(System.Security.PermissionSet @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RIsSubsetOf_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PermitOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPermitOnly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsNonCodeAccessPermissions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RContainsNonCodeAccessPermissions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Byte[] ConvertPermissionSet(System.String @inFormat, System.Byte[] @inData, System.String @outFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inFormat, @inData, @outFormat};
            var ___result = RConvertPermissionSet_String_ByteArray_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Security.IPermission GetPermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RGetPermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.PermissionSet Intersect(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersect_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void InternalIntersect(System.Security.PermissionSet @intersect, System.Security.PermissionSet @a, System.Security.PermissionSet @b, System.Boolean @unrestricted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intersect, @a, @b, @unrestricted};
            var ___result = RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsUnrestricted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsUnrestricted.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission RemovePermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RRemovePermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermission(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RSetPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.PermissionSet Union(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RUnion_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public static void RevertAssert()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRevertAssert.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReadOnly(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AllIgnored()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllIgnored.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Security.PermissionSet CreateFromBinaryFormat(System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCreateFromBinaryFormat_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public static System.Int32 ReadEncodedInt(System.Byte[] @data, ref System.Int32 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @position};
            var ___result = RReadEncodedInt_ByteArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			@position = (System.Int32)___parameters[1];

            return (System.Int32)___result;
        }


        public static System.Security.IPermission ProcessAttribute(System.Byte[] @data, ref System.Int32 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @position};
            var ___result = RProcessAttribute_ByteArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			@position = (System.Int32)___parameters[1];

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission AddPermissionImpl(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RAddPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumeratorImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumeratorImpl.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Security.IPermission GetPermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RGetPermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission RemovePermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RRemovePermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermissionImpl(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RSetPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
