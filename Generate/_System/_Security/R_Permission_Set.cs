
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.PermissionSet
	/// </summary>
    public partial class RPermissionSet : RMember //
    {

		/// <summary>
		/// System.String tagName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FtagName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFtagName
		{
			get
			{
				if(r_FtagName == null)
				{
					r_FtagName = new(typeof(System.Security.PermissionSet), "tagName");
					r_FtagName.SetBelong(null);
				}
				return r_FtagName;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fversion;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(typeof(System.Security.PermissionSet), "version");
					r_Fversion.SetBelong(null);
				}
				return r_Fversion;
			}
		}

		/// <summary>
		/// System.Object[] psUnrestricted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_FpsUnrestricted;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFpsUnrestricted
		{
			get
			{
				if(r_FpsUnrestricted == null)
				{
					r_FpsUnrestricted = new(typeof(System.Security.PermissionSet), "psUnrestricted");
					r_FpsUnrestricted.SetBelong(null);
				}
				return r_FpsUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.Permissions.PermissionState state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissions.RPermissionState r_Fstate;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissions.RPermissionState RFstate
		{
			get
			{
				if(r_Fstate == null)
				{
					r_Fstate = new(this, "state");
					r_Fstate.SetBelong(this.GetValue());
				}
				return r_Fstate;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_Flist;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFlist
		{
			get
			{
				if(r_Flist == null)
				{
					r_Flist = new(this, "list");
					r_Flist.SetBelong(this.GetValue());
				}
				return r_Flist;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel _policyLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel r_F_policyLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel RF_policyLevel
		{
			get
			{
				if(r_F_policyLevel == null)
				{
					r_F_policyLevel = new(this, "_policyLevel");
					r_F_policyLevel.SetBelong(this.GetValue());
				}
				return r_F_policyLevel;
			}
		}

		/// <summary>
		/// System.Boolean _declsec
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_declsec;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_declsec
		{
			get
			{
				if(r_F_declsec == null)
				{
					r_F_declsec = new(this, "_declsec");
					r_F_declsec.SetBelong(this.GetValue());
				}
				return r_F_declsec;
			}
		}

		/// <summary>
		/// System.Boolean _readOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_readOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_readOnly
		{
			get
			{
				if(r_F_readOnly == null)
				{
					r_F_readOnly = new(this, "_readOnly");
					r_F_readOnly.SetBelong(this.GetValue());
				}
				return r_F_readOnly;
			}
		}

		/// <summary>
		/// System.Boolean[] _ignored
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> r_F_ignored;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> RF_ignored
		{
			get
			{
				if(r_F_ignored == null)
				{
					r_F_ignored = new(this, "_ignored");
					r_F_ignored.SetBelong(this.GetValue());
				}
				return r_F_ignored;
			}
		}

		/// <summary>
		/// System.Object[] action
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_Faction;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFaction
		{
			get
			{
				if(r_Faction == null)
				{
					r_Faction = new(typeof(System.Security.PermissionSet), "action");
					r_Faction.SetBelong(null);
				}
				return r_Faction;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.GetValue());
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSynchronized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
					r_PIsSynchronized.SetBelong(this.GetValue());
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.GetValue());
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSyncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
					r_PSyncRoot.SetBelong(this.GetValue());
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// Boolean DeclarativeSecurity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDeclarativeSecurity;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDeclarativeSecurity
		{
			get
			{
				if(r_PDeclarativeSecurity == null)
				{
					r_PDeclarativeSecurity = new(this, "DeclarativeSecurity", -1);
					r_PDeclarativeSecurity.SetBelong(this.GetValue());
				}
				return r_PDeclarativeSecurity;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel Resolver
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel r_PResolver;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel RPResolver
		{
			get
			{
				if(r_PResolver == null)
				{
					r_PResolver = new(this, "Resolver", -1);
					r_PResolver.SetBelong(this.GetValue());
				}
				return r_PResolver;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MAddPermission_IPermission;
		public virtual RMethod RMAddPermission_IPermission
		{
			get
			{
				if(r_MAddPermission_IPermission == null)
				{
					r_MAddPermission_IPermission = new(this, "AddPermission", 0, typeof(System.Security.IPermission));
					r_MAddPermission_IPermission.SetBelong(this.GetValue());
				}
				return r_MAddPermission_IPermission;
			}
		}

		/// <summary>
		/// Void Assert()
		/// </summary>
		protected RMethod r_MAssert;
		public virtual RMethod RMAssert
		{
			get
			{
				if(r_MAssert == null)
				{
					r_MAssert = new(this, "Assert", 0);
					r_MAssert.SetBelong(this.GetValue());
				}
				return r_MAssert;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.GetValue());
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.GetValue());
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int32;
		public virtual RMethod RMCopyTo_Array_Int32
		{
			get
			{
				if(r_MCopyTo_Array_Int32 == null)
				{
					r_MCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_MCopyTo_Array_Int32.SetBelong(this.GetValue());
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_MDemand;
		public virtual RMethod RMDemand
		{
			get
			{
				if(r_MDemand == null)
				{
					r_MDemand = new(this, "Demand", 0);
					r_MDemand.SetBelong(this.GetValue());
				}
				return r_MDemand;
			}
		}

		/// <summary>
		/// Void CasOnlyDemand(Int32)
		/// </summary>
		protected RMethod r_MCasOnlyDemand_Int32;
		public virtual RMethod RMCasOnlyDemand_Int32
		{
			get
			{
				if(r_MCasOnlyDemand_Int32 == null)
				{
					r_MCasOnlyDemand_Int32 = new(this, "CasOnlyDemand", 0, typeof(System.Int32));
					r_MCasOnlyDemand_Int32.SetBelong(this.GetValue());
				}
				return r_MCasOnlyDemand_Int32;
			}
		}

		/// <summary>
		/// Void Deny()
		/// </summary>
		protected RMethod r_MDeny;
		public virtual RMethod RMDeny
		{
			get
			{
				if(r_MDeny == null)
				{
					r_MDeny = new(this, "Deny", 0);
					r_MDeny.SetBelong(this.GetValue());
				}
				return r_MDeny;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement;
		public virtual RMethod RMFromXml_SecurityElement
		{
			get
			{
				if(r_MFromXml_SecurityElement == null)
				{
					r_MFromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_MFromXml_SecurityElement.SetBelong(this.GetValue());
				}
				return r_MFromXml_SecurityElement;
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
					r_MGetEnumerator.SetBelong(this.GetValue());
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MIsSubsetOf_PermissionSet;
		public virtual RMethod RMIsSubsetOf_PermissionSet
		{
			get
			{
				if(r_MIsSubsetOf_PermissionSet == null)
				{
					r_MIsSubsetOf_PermissionSet = new(this, "IsSubsetOf", 0, typeof(System.Security.PermissionSet));
					r_MIsSubsetOf_PermissionSet.SetBelong(this.GetValue());
				}
				return r_MIsSubsetOf_PermissionSet;
			}
		}

		/// <summary>
		/// Void PermitOnly()
		/// </summary>
		protected RMethod r_MPermitOnly;
		public virtual RMethod RMPermitOnly
		{
			get
			{
				if(r_MPermitOnly == null)
				{
					r_MPermitOnly = new(this, "PermitOnly", 0);
					r_MPermitOnly.SetBelong(this.GetValue());
				}
				return r_MPermitOnly;
			}
		}

		/// <summary>
		/// Boolean ContainsNonCodeAccessPermissions()
		/// </summary>
		protected RMethod r_MContainsNonCodeAccessPermissions;
		public virtual RMethod RMContainsNonCodeAccessPermissions
		{
			get
			{
				if(r_MContainsNonCodeAccessPermissions == null)
				{
					r_MContainsNonCodeAccessPermissions = new(this, "ContainsNonCodeAccessPermissions", 0);
					r_MContainsNonCodeAccessPermissions.SetBelong(this.GetValue());
				}
				return r_MContainsNonCodeAccessPermissions;
			}
		}

		/// <summary>
		/// Byte[] ConvertPermissionSet(System.String, Byte[], System.String)
		/// </summary>
		protected static RMethod r_MConvertPermissionSet_String_ByteArray_String;
		public static RMethod RMConvertPermissionSet_String_ByteArray_String
		{
			get
			{
				if(r_MConvertPermissionSet_String_ByteArray_String == null)
				{
					r_MConvertPermissionSet_String_ByteArray_String = new(typeof(System.Security.PermissionSet), "ConvertPermissionSet", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.String));
					r_MConvertPermissionSet_String_ByteArray_String.SetBelong(null);
				}
				return r_MConvertPermissionSet_String_ByteArray_String;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermission(System.Type)
		/// </summary>
		protected RMethod r_MGetPermission_Type;
		public virtual RMethod RMGetPermission_Type
		{
			get
			{
				if(r_MGetPermission_Type == null)
				{
					r_MGetPermission_Type = new(this, "GetPermission", 0, typeof(System.Type));
					r_MGetPermission_Type.SetBelong(this.GetValue());
				}
				return r_MGetPermission_Type;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Intersect(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MIntersect_PermissionSet;
		public virtual RMethod RMIntersect_PermissionSet
		{
			get
			{
				if(r_MIntersect_PermissionSet == null)
				{
					r_MIntersect_PermissionSet = new(this, "Intersect", 0, typeof(System.Security.PermissionSet));
					r_MIntersect_PermissionSet.SetBelong(this.GetValue());
				}
				return r_MIntersect_PermissionSet;
			}
		}

		/// <summary>
		/// Void InternalIntersect(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RMInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "InternalIntersect", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
					r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.SetBelong(this.GetValue());
				}
				return r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_MIsEmpty;
		public virtual RMethod RMIsEmpty
		{
			get
			{
				if(r_MIsEmpty == null)
				{
					r_MIsEmpty = new(this, "IsEmpty", 0);
					r_MIsEmpty.SetBelong(this.GetValue());
				}
				return r_MIsEmpty;
			}
		}

		/// <summary>
		/// Boolean IsUnrestricted()
		/// </summary>
		protected RMethod r_MIsUnrestricted;
		public virtual RMethod RMIsUnrestricted
		{
			get
			{
				if(r_MIsUnrestricted == null)
				{
					r_MIsUnrestricted = new(this, "IsUnrestricted", 0);
					r_MIsUnrestricted.SetBelong(this.GetValue());
				}
				return r_MIsUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermission(System.Type)
		/// </summary>
		protected RMethod r_MRemovePermission_Type;
		public virtual RMethod RMRemovePermission_Type
		{
			get
			{
				if(r_MRemovePermission_Type == null)
				{
					r_MRemovePermission_Type = new(this, "RemovePermission", 0, typeof(System.Type));
					r_MRemovePermission_Type.SetBelong(this.GetValue());
				}
				return r_MRemovePermission_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MSetPermission_IPermission;
		public virtual RMethod RMSetPermission_IPermission
		{
			get
			{
				if(r_MSetPermission_IPermission == null)
				{
					r_MSetPermission_IPermission = new(this, "SetPermission", 0, typeof(System.Security.IPermission));
					r_MSetPermission_IPermission.SetBelong(this.GetValue());
				}
				return r_MSetPermission_IPermission;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_MToXml;
		public virtual RMethod RMToXml
		{
			get
			{
				if(r_MToXml == null)
				{
					r_MToXml = new(this, "ToXml", 0);
					r_MToXml.SetBelong(this.GetValue());
				}
				return r_MToXml;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Union(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MUnion_PermissionSet;
		public virtual RMethod RMUnion_PermissionSet
		{
			get
			{
				if(r_MUnion_PermissionSet == null)
				{
					r_MUnion_PermissionSet = new(this, "Union", 0, typeof(System.Security.PermissionSet));
					r_MUnion_PermissionSet.SetBelong(this.GetValue());
				}
				return r_MUnion_PermissionSet;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Void RevertAssert()
		/// </summary>
		protected static RMethod r_MRevertAssert;
		public static RMethod RMRevertAssert
		{
			get
			{
				if(r_MRevertAssert == null)
				{
					r_MRevertAssert = new(typeof(System.Security.PermissionSet), "RevertAssert", 0);
					r_MRevertAssert.SetBelong(null);
				}
				return r_MRevertAssert;
			}
		}

		/// <summary>
		/// Void SetReadOnly(Boolean)
		/// </summary>
		protected RMethod r_MSetReadOnly_Boolean;
		public virtual RMethod RMSetReadOnly_Boolean
		{
			get
			{
				if(r_MSetReadOnly_Boolean == null)
				{
					r_MSetReadOnly_Boolean = new(this, "SetReadOnly", 0, typeof(System.Boolean));
					r_MSetReadOnly_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// Boolean AllIgnored()
		/// </summary>
		protected RMethod r_MAllIgnored;
		public virtual RMethod RMAllIgnored
		{
			get
			{
				if(r_MAllIgnored == null)
				{
					r_MAllIgnored = new(this, "AllIgnored", 0);
					r_MAllIgnored.SetBelong(this.GetValue());
				}
				return r_MAllIgnored;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet CreateFromBinaryFormat(Byte[])
		/// </summary>
		protected static RMethod r_MCreateFromBinaryFormat_ByteArray;
		public static RMethod RMCreateFromBinaryFormat_ByteArray
		{
			get
			{
				if(r_MCreateFromBinaryFormat_ByteArray == null)
				{
					r_MCreateFromBinaryFormat_ByteArray = new(typeof(System.Security.PermissionSet), "CreateFromBinaryFormat", 0, typeof(System.Byte).MakeArrayType());
					r_MCreateFromBinaryFormat_ByteArray.SetBelong(null);
				}
				return r_MCreateFromBinaryFormat_ByteArray;
			}
		}

		/// <summary>
		/// Int32 ReadEncodedInt(Byte[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_MReadEncodedInt_ByteArray_Ref_Int32;
		public static RMethod RMReadEncodedInt_ByteArray_Ref_Int32
		{
			get
			{
				if(r_MReadEncodedInt_ByteArray_Ref_Int32 == null)
				{
					r_MReadEncodedInt_ByteArray_Ref_Int32 = new(typeof(System.Security.PermissionSet), "ReadEncodedInt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_MReadEncodedInt_ByteArray_Ref_Int32.SetBelong(null);
				}
				return r_MReadEncodedInt_ByteArray_Ref_Int32;
			}
		}

		/// <summary>
		/// System.Security.IPermission ProcessAttribute(Byte[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_MProcessAttribute_ByteArray_Ref_Int32;
		public static RMethod RMProcessAttribute_ByteArray_Ref_Int32
		{
			get
			{
				if(r_MProcessAttribute_ByteArray_Ref_Int32 == null)
				{
					r_MProcessAttribute_ByteArray_Ref_Int32 = new(typeof(System.Security.PermissionSet), "ProcessAttribute", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_MProcessAttribute_ByteArray_Ref_Int32.SetBelong(null);
				}
				return r_MProcessAttribute_ByteArray_Ref_Int32;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MAddPermissionImpl_IPermission;
		public virtual RMethod RMAddPermissionImpl_IPermission
		{
			get
			{
				if(r_MAddPermissionImpl_IPermission == null)
				{
					r_MAddPermissionImpl_IPermission = new(this, "AddPermissionImpl", 0, typeof(System.Security.IPermission));
					r_MAddPermissionImpl_IPermission.SetBelong(this.GetValue());
				}
				return r_MAddPermissionImpl_IPermission;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumeratorImpl()
		/// </summary>
		protected RMethod r_MGetEnumeratorImpl;
		public virtual RMethod RMGetEnumeratorImpl
		{
			get
			{
				if(r_MGetEnumeratorImpl == null)
				{
					r_MGetEnumeratorImpl = new(this, "GetEnumeratorImpl", 0);
					r_MGetEnumeratorImpl.SetBelong(this.GetValue());
				}
				return r_MGetEnumeratorImpl;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_MGetPermissionImpl_Type;
		public virtual RMethod RMGetPermissionImpl_Type
		{
			get
			{
				if(r_MGetPermissionImpl_Type == null)
				{
					r_MGetPermissionImpl_Type = new(this, "GetPermissionImpl", 0, typeof(System.Type));
					r_MGetPermissionImpl_Type.SetBelong(this.GetValue());
				}
				return r_MGetPermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_MRemovePermissionImpl_Type;
		public virtual RMethod RMRemovePermissionImpl_Type
		{
			get
			{
				if(r_MRemovePermissionImpl_Type == null)
				{
					r_MRemovePermissionImpl_Type = new(this, "RemovePermissionImpl", 0, typeof(System.Type));
					r_MRemovePermissionImpl_Type.SetBelong(this.GetValue());
				}
				return r_MRemovePermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MSetPermissionImpl_IPermission;
		public virtual RMethod RMSetPermissionImpl_IPermission
		{
			get
			{
				if(r_MSetPermissionImpl_IPermission == null)
				{
					r_MSetPermissionImpl_IPermission = new(this, "SetPermissionImpl", 0, typeof(System.Security.IPermission));
					r_MSetPermissionImpl_IPermission.SetBelong(this.GetValue());
				}
				return r_MSetPermissionImpl_IPermission;
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
            var ___result = RMAddPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Assert()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAssert.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.PermissionSet Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Demand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDemand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CasOnlyDemand(System.Int32 @skip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skip};
            var ___result = RMCasOnlyDemand_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Deny()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeny.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @et)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean IsSubsetOf(System.Security.PermissionSet @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMIsSubsetOf_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PermitOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPermitOnly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsNonCodeAccessPermissions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMContainsNonCodeAccessPermissions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Byte[] ConvertPermissionSet(System.String @inFormat, System.Byte[] @inData, System.String @outFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inFormat, @inData, @outFormat};
            var ___result = RMConvertPermissionSet_String_ByteArray_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Security.IPermission GetPermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMGetPermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.PermissionSet Intersect(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIntersect_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void InternalIntersect(System.Security.PermissionSet @intersect, System.Security.PermissionSet @a, System.Security.PermissionSet @b, System.Boolean @unrestricted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intersect, @a, @b, @unrestricted};
            var ___result = RMInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsUnrestricted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsUnrestricted.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission RemovePermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMRemovePermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermission(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMSetPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.PermissionSet Union(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMUnion_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
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


        public static void RevertAssert()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRevertAssert.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReadOnly(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AllIgnored()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllIgnored.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Security.PermissionSet CreateFromBinaryFormat(System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMCreateFromBinaryFormat_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public static System.Int32 ReadEncodedInt(System.Byte[] @data, ref System.Int32 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @position};
            var ___result = RMReadEncodedInt_ByteArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			@position = (System.Int32)___parameters[1];

            return (System.Int32)___result;
        }


        public static System.Security.IPermission ProcessAttribute(System.Byte[] @data, ref System.Int32 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @position};
            var ___result = RMProcessAttribute_ByteArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			@position = (System.Int32)___parameters[1];

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission AddPermissionImpl(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMAddPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumeratorImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumeratorImpl.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Security.IPermission GetPermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMGetPermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission RemovePermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMRemovePermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermissionImpl(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMSetPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
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
