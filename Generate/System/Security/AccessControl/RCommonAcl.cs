using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.CommonAcl
	/// </summary>
    public partial class RCommonAcl : RMember //
    {

		/// <summary>
		/// System.Int32 default_capacity
		/// </summary>
		protected static RField r_default_capacity;
		public static RField Rdefault_capacity
		{
			get
			{
				if(r_default_capacity == null)
				{
					r_default_capacity = new(typeof(System.Security.AccessControl.CommonAcl), "default_capacity");
					r_default_capacity.SetBelong(null);
				}
				return r_default_capacity;
			}
		}

		/// <summary>
		/// System.Boolean is_aefa
		/// </summary>
		protected RField r_is_aefa;
		public virtual RField Ris_aefa
		{
			get
			{
				if(r_is_aefa == null)
				{
					r_is_aefa = new(this, "is_aefa");
					r_is_aefa.SetBelong(this.instance);
				}
				return r_is_aefa;
			}
		}

		/// <summary>
		/// System.Boolean is_canonical
		/// </summary>
		protected RField r_is_canonical;
		public virtual RField Ris_canonical
		{
			get
			{
				if(r_is_canonical == null)
				{
					r_is_canonical = new(this, "is_canonical");
					r_is_canonical.SetBelong(this.instance);
				}
				return r_is_canonical;
			}
		}

		/// <summary>
		/// System.Boolean is_container
		/// </summary>
		protected RField r_is_container;
		public virtual RField Ris_container
		{
			get
			{
				if(r_is_container == null)
				{
					r_is_container = new(this, "is_container");
					r_is_container.SetBelong(this.instance);
				}
				return r_is_container;
			}
		}

		/// <summary>
		/// System.Boolean is_ds
		/// </summary>
		protected RField r_is_ds;
		public virtual RField Ris_ds
		{
			get
			{
				if(r_is_ds == null)
				{
					r_is_ds = new(this, "is_ds");
					r_is_ds.SetBelong(this.instance);
				}
				return r_is_ds;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl raw_acl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RRawAcl r_raw_acl;
		public virtual RSystem.RSecurity.RAccessControl.RRawAcl Rraw_acl
		{
			get
			{
				if(r_raw_acl == null)
				{
					r_raw_acl = new(this, "raw_acl");
					r_raw_acl.SetBelong(this.instance);
				}
				return r_raw_acl;
			}
		}

		/// <summary>
		/// Int32 BinaryLength
		/// </summary>
		protected RProperty r_BinaryLength;
		public virtual RProperty RBinaryLength
		{
			get
			{
				if(r_BinaryLength == null)
				{
					r_BinaryLength = new(this, "BinaryLength", -1);
					r_BinaryLength.SetBelong(this.instance);
				}
				return r_BinaryLength;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
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
		/// Boolean IsCanonical
		/// </summary>
		protected RProperty r_IsCanonical;
		public virtual RProperty RIsCanonical
		{
			get
			{
				if(r_IsCanonical == null)
				{
					r_IsCanonical = new(this, "IsCanonical", -1);
					r_IsCanonical.SetBelong(this.instance);
				}
				return r_IsCanonical;
			}
		}

		/// <summary>
		/// Boolean IsContainer
		/// </summary>
		protected RProperty r_IsContainer;
		public virtual RProperty RIsContainer
		{
			get
			{
				if(r_IsContainer == null)
				{
					r_IsContainer = new(this, "IsContainer", -1);
					r_IsContainer.SetBelong(this.instance);
				}
				return r_IsContainer;
			}
		}

		/// <summary>
		/// Boolean IsDS
		/// </summary>
		protected RProperty r_IsDS;
		public virtual RProperty RIsDS
		{
			get
			{
				if(r_IsDS == null)
				{
					r_IsDS = new(this, "IsDS", -1);
					r_IsDS.SetBelong(this.instance);
				}
				return r_IsDS;
			}
		}

		/// <summary>
		/// Boolean IsAefa
		/// </summary>
		protected RProperty r_IsAefa;
		public virtual RProperty RIsAefa
		{
			get
			{
				if(r_IsAefa == null)
				{
					r_IsAefa = new(this, "IsAefa", -1);
					r_IsAefa.SetBelong(this.instance);
				}
				return r_IsAefa;
			}
		}

		/// <summary>
		/// Byte Revision
		/// </summary>
		protected RProperty r_Revision;
		public virtual RProperty Revision
		{
			get
			{
				if(r_Revision == null)
				{
					r_Revision = new(this, "Revision", -1);
					r_Revision.SetBelong(this.instance);
				}
				return r_Revision;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Item [Int32]
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RGenericAce r_Item_Int32;
		public virtual RSystem.RSecurity.RAccessControl.RGenericAce RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
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
		/// Void Init(Boolean, Boolean, System.Security.AccessControl.RawAcl)
		/// </summary>
		protected RMethod r_RInit_Boolean_Boolean_RawAcl;
		public virtual RMethod RInit_Boolean_Boolean_RawAcl
		{
			get
			{
				if(r_RInit_Boolean_Boolean_RawAcl == null)
				{
					r_RInit_Boolean_Boolean_RawAcl = new(this, "Init", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Security.AccessControl.RawAcl));
					r_RInit_Boolean_Boolean_RawAcl.SetBelong(this.instance);
				}
				return r_RInit_Boolean_Boolean_RawAcl;
			}
		}

		/// <summary>
		/// Void GetBinaryForm(Byte[], Int32)
		/// </summary>
		protected RMethod r_RGetBinaryForm_ByteArray_Int32;
		public virtual RMethod RGetBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_RGetBinaryForm_ByteArray_Int32 == null)
				{
					r_RGetBinaryForm_ByteArray_Int32 = new(this, "GetBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RGetBinaryForm_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RGetBinaryForm_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void Purge(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_RPurge_SecurityIdentifier;
		public virtual RMethod RPurge_SecurityIdentifier
		{
			get
			{
				if(r_RPurge_SecurityIdentifier == null)
				{
					r_RPurge_SecurityIdentifier = new(this, "Purge", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_RPurge_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_RPurge_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void RemoveInheritedAces()
		/// </summary>
		protected RMethod r_RRemoveInheritedAces;
		public virtual RMethod RRemoveInheritedAces
		{
			get
			{
				if(r_RRemoveInheritedAces == null)
				{
					r_RRemoveInheritedAces = new(this, "RemoveInheritedAces", 0);
					r_RRemoveInheritedAces.SetBelong(this.instance);
				}
				return r_RRemoveInheritedAces;
			}
		}

		/// <summary>
		/// Void RequireCanonicity()
		/// </summary>
		protected RMethod r_RRequireCanonicity;
		public virtual RMethod RRequireCanonicity
		{
			get
			{
				if(r_RRequireCanonicity == null)
				{
					r_RRequireCanonicity = new(this, "RequireCanonicity", 0);
					r_RRequireCanonicity.SetBelong(this.instance);
				}
				return r_RRequireCanonicity;
			}
		}

		/// <summary>
		/// Void CanonicalizeAndClearAefa()
		/// </summary>
		protected RMethod r_RCanonicalizeAndClearAefa;
		public virtual RMethod RCanonicalizeAndClearAefa
		{
			get
			{
				if(r_RCanonicalizeAndClearAefa == null)
				{
					r_RCanonicalizeAndClearAefa = new(this, "CanonicalizeAndClearAefa", 0);
					r_RCanonicalizeAndClearAefa.SetBelong(this.instance);
				}
				return r_RCanonicalizeAndClearAefa;
			}
		}

		/// <summary>
		/// Boolean IsAceMeaningless(System.Security.AccessControl.GenericAce)
		/// </summary>
		protected RMethod r_RIsAceMeaningless_GenericAce;
		public virtual RMethod RIsAceMeaningless_GenericAce
		{
			get
			{
				if(r_RIsAceMeaningless_GenericAce == null)
				{
					r_RIsAceMeaningless_GenericAce = new(this, "IsAceMeaningless", 0, typeof(System.Security.AccessControl.GenericAce));
					r_RIsAceMeaningless_GenericAce.SetBelong(this.instance);
				}
				return r_RIsAceMeaningless_GenericAce;
			}
		}

		/// <summary>
		/// Boolean TestCanonicity()
		/// </summary>
		protected RMethod r_RTestCanonicity;
		public virtual RMethod RTestCanonicity
		{
			get
			{
				if(r_RTestCanonicity == null)
				{
					r_RTestCanonicity = new(this, "TestCanonicity", 0);
					r_RTestCanonicity.SetBelong(this.instance);
				}
				return r_RTestCanonicity;
			}
		}

		/// <summary>
		/// Int32 GetCanonicalExplicitDenyAceCount()
		/// </summary>
		protected RMethod r_RGetCanonicalExplicitDenyAceCount;
		public virtual RMethod RGetCanonicalExplicitDenyAceCount
		{
			get
			{
				if(r_RGetCanonicalExplicitDenyAceCount == null)
				{
					r_RGetCanonicalExplicitDenyAceCount = new(this, "GetCanonicalExplicitDenyAceCount", 0);
					r_RGetCanonicalExplicitDenyAceCount.SetBelong(this.instance);
				}
				return r_RGetCanonicalExplicitDenyAceCount;
			}
		}

		/// <summary>
		/// Int32 GetCanonicalExplicitAceCount()
		/// </summary>
		protected RMethod r_RGetCanonicalExplicitAceCount;
		public virtual RMethod RGetCanonicalExplicitAceCount
		{
			get
			{
				if(r_RGetCanonicalExplicitAceCount == null)
				{
					r_RGetCanonicalExplicitAceCount = new(this, "GetCanonicalExplicitAceCount", 0);
					r_RGetCanonicalExplicitAceCount.SetBelong(this.instance);
				}
				return r_RGetCanonicalExplicitAceCount;
			}
		}

		/// <summary>
		/// Void MergeExplicitAces()
		/// </summary>
		protected RMethod r_RMergeExplicitAces;
		public virtual RMethod RMergeExplicitAces
		{
			get
			{
				if(r_RMergeExplicitAces == null)
				{
					r_RMergeExplicitAces = new(this, "MergeExplicitAces", 0);
					r_RMergeExplicitAces.SetBelong(this.instance);
				}
				return r_RMergeExplicitAces;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce MergeExplicitAcePair(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected RMethod r_RMergeExplicitAcePair_GenericAce_GenericAce;
		public virtual RMethod RMergeExplicitAcePair_GenericAce_GenericAce
		{
			get
			{
				if(r_RMergeExplicitAcePair_GenericAce_GenericAce == null)
				{
					r_RMergeExplicitAcePair_GenericAce_GenericAce = new(this, "MergeExplicitAcePair", 0, typeof(System.Security.AccessControl.GenericAce), typeof(System.Security.AccessControl.GenericAce));
					r_RMergeExplicitAcePair_GenericAce_GenericAce.SetBelong(this.instance);
				}
				return r_RMergeExplicitAcePair_GenericAce_GenericAce;
			}
		}

		/// <summary>
		/// Void GetObjectAceTypeGuids(System.Security.AccessControl.ObjectAce, System.Guid ByRef, System.Guid ByRef)
		/// </summary>
		protected static RMethod r_RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid;
		public static RMethod RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid
		{
			get
			{
				if(r_RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid == null)
				{
					r_RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid = new(typeof(System.Security.AccessControl.CommonAcl), "GetObjectAceTypeGuids", 0, typeof(System.Security.AccessControl.ObjectAce), typeof(System.Guid).MakeByRefType(), typeof(System.Guid).MakeByRefType());
					r_RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid.SetBelong(null);
				}
				return r_RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid;
			}
		}

		/// <summary>
		/// Void ApplyCanonicalSortToExplicitAces()
		/// </summary>
		protected RMethod r_RApplyCanonicalSortToExplicitAces;
		public virtual RMethod RApplyCanonicalSortToExplicitAces
		{
			get
			{
				if(r_RApplyCanonicalSortToExplicitAces == null)
				{
					r_RApplyCanonicalSortToExplicitAces = new(this, "ApplyCanonicalSortToExplicitAces", 0);
					r_RApplyCanonicalSortToExplicitAces.SetBelong(this.instance);
				}
				return r_RApplyCanonicalSortToExplicitAces;
			}
		}

		/// <summary>
		/// Void ApplyCanonicalSortToExplicitAces(Int32, Int32)
		/// </summary>
		protected RMethod r_RApplyCanonicalSortToExplicitAces_Int32_Int32;
		public virtual RMethod RApplyCanonicalSortToExplicitAces_Int32_Int32
		{
			get
			{
				if(r_RApplyCanonicalSortToExplicitAces_Int32_Int32 == null)
				{
					r_RApplyCanonicalSortToExplicitAces_Int32_Int32 = new(this, "ApplyCanonicalSortToExplicitAces", 0, typeof(System.Int32), typeof(System.Int32));
					r_RApplyCanonicalSortToExplicitAces_Int32_Int32.SetBelong(this.instance);
				}
				return r_RApplyCanonicalSortToExplicitAces_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetSddlForm(System.Security.AccessControl.ControlFlags, Boolean)
		/// </summary>
		protected RMethod r_RGetSddlForm_ControlFlags_Boolean;
		public virtual RMethod RGetSddlForm_ControlFlags_Boolean
		{
			get
			{
				if(r_RGetSddlForm_ControlFlags_Boolean == null)
				{
					r_RGetSddlForm_ControlFlags_Boolean = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.ControlFlags), typeof(System.Boolean));
					r_RGetSddlForm_ControlFlags_Boolean.SetBelong(this.instance);
				}
				return r_RGetSddlForm_ControlFlags_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveAces[T](RemoveAcesCallback`1)
		/// </summary>
		protected RMethod r_RRemoveAces_GT_RemoveAcesCallback_d_T_p_;
		public virtual RMethod RRemoveAces_GT_RemoveAcesCallback_d_T_p_
		{
			get
			{
				if(r_RRemoveAces_GT_RemoveAcesCallback_d_T_p_ == null)
				{
					r_RRemoveAces_GT_RemoveAcesCallback_d_T_p_ = new(this, "RemoveAces", 1,  ReleactionUtils.GetType("System.Security.AccessControl.CommonAcl+RemoveAcesCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemoveAces_GT_RemoveAcesCallback_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemoveAces_GT_RemoveAcesCallback_d_T_p_;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "AddAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "AddAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.QualifiedAce AddAceGetQualifiedAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "AddAceGetQualifiedAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.QualifiedAce AddAceGetQualifiedAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "AddAceGetQualifiedAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.QualifiedAce)
		/// </summary>
		protected RMethod r_RAddAce_QualifiedAce;
		public virtual RMethod RAddAce_QualifiedAce
		{
			get
			{
				if(r_RAddAce_QualifiedAce == null)
				{
					r_RAddAce_QualifiedAce = new(this, "AddAce", 0, typeof(System.Security.AccessControl.QualifiedAce));
					r_RAddAce_QualifiedAce.SetBelong(this.instance);
				}
				return r_RAddAce_QualifiedAce;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce CopyAce(System.Security.AccessControl.GenericAce)
		/// </summary>
		protected static RMethod r_RCopyAce_GenericAce;
		public static RMethod RCopyAce_GenericAce
		{
			get
			{
				if(r_RCopyAce_GenericAce == null)
				{
					r_RCopyAce_GenericAce = new(typeof(System.Security.AccessControl.CommonAcl), "CopyAce", 0, typeof(System.Security.AccessControl.GenericAce));
					r_RCopyAce_GenericAce.SetBelong(null);
				}
				return r_RCopyAce_GenericAce;
			}
		}

		/// <summary>
		/// Int32 GetAceInsertPosition(System.Security.AccessControl.AceQualifier)
		/// </summary>
		protected RMethod r_RGetAceInsertPosition_AceQualifier;
		public virtual RMethod RGetAceInsertPosition_AceQualifier
		{
			get
			{
				if(r_RGetAceInsertPosition_AceQualifier == null)
				{
					r_RGetAceInsertPosition_AceQualifier = new(this, "GetAceInsertPosition", 0, typeof(System.Security.AccessControl.AceQualifier));
					r_RGetAceInsertPosition_AceQualifier.SetBelong(this.instance);
				}
				return r_RGetAceInsertPosition_AceQualifier;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceFlags GetAceFlags(System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "GetAceFlags", 0, typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void RemoveAceSpecific(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "RemoveAceSpecific", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void RemoveAceSpecific(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAceSpecific", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "SetAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "SetAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.QualifiedAce)
		/// </summary>
		protected RMethod r_RSetAce_QualifiedAce;
		public virtual RMethod RSetAce_QualifiedAce
		{
			get
			{
				if(r_RSetAce_QualifiedAce == null)
				{
					r_RSetAce_QualifiedAce = new(this, "SetAce", 0, typeof(System.Security.AccessControl.QualifiedAce));
					r_RSetAce_QualifiedAce.SetBelong(this.instance);
				}
				return r_RSetAce_QualifiedAce;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Security.AccessControl.GenericAce[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_GenericAceArray_Int32;
		public virtual RMethod RCopyTo_GenericAceArray_Int32
		{
			get
			{
				if(r_RCopyTo_GenericAceArray_Int32 == null)
				{
					r_RCopyTo_GenericAceArray_Int32 = new(this, "CopyTo", 0, typeof(System.Security.AccessControl.GenericAce).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_GenericAceArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_GenericAceArray_Int32;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceEnumerator GetEnumerator()
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


        public RCommonAcl() : base("System.Security.AccessControl.CommonAcl")
        {
        }

        public RCommonAcl(System.Object instance) : base("System.Security.AccessControl.CommonAcl")
		{
            SetInstance(instance);
		}

        public RCommonAcl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCommonAcl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(System.Boolean  @isContainer, System.Boolean  @isDS, System.Security.AccessControl.RawAcl  @rawAcl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isContainer, @isDS, @rawAcl};
            var ___result = RInit_Boolean_Boolean_RawAcl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBinaryForm(System.Byte[]  @binaryForm, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Purge(System.Security.Principal.SecurityIdentifier  @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RPurge_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveInheritedAces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveInheritedAces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequireCanonicity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequireCanonicity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CanonicalizeAndClearAefa()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanonicalizeAndClearAefa.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAceMeaningless(System.Security.AccessControl.GenericAce  @ace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace};
            var ___result = RIsAceMeaningless_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TestCanonicity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTestCanonicity.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetCanonicalExplicitDenyAceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCanonicalExplicitDenyAceCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCanonicalExplicitAceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCanonicalExplicitAceCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void MergeExplicitAces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMergeExplicitAces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.GenericAce MergeExplicitAcePair(System.Security.AccessControl.GenericAce  @ace1, System.Security.AccessControl.GenericAce  @ace2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace1, @ace2};
            var ___result = RMergeExplicitAcePair_GenericAce_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public static void GetObjectAceTypeGuids(System.Security.AccessControl.ObjectAce  @ace, out System.Guid  @type, out System.Guid  @inheritedType)
        {
			type = default;
			inheritedType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace, @type, @inheritedType};
            var ___result = RGetObjectAceTypeGuids_ObjectAce_Out_Guid_Out_Guid.Invoke(___genericsType, ___parameters);
			type = (System.Guid)___parameters[1];
			inheritedType = (System.Guid)___parameters[2];

            
        }


        public virtual void ApplyCanonicalSortToExplicitAces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyCanonicalSortToExplicitAces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyCanonicalSortToExplicitAces(System.Int32  @start, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @count};
            var ___result = RApplyCanonicalSortToExplicitAces_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.ControlFlags  @sdFlags, System.Boolean  @isDacl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sdFlags, @isDacl};
            var ___result = RGetSddlForm_ControlFlags_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void AddAce(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAce(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.QualifiedAce AddAceGetQualifiedAce(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.QualifiedAce)___result;
        }


        public virtual System.Security.AccessControl.QualifiedAce AddAceGetQualifiedAce(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RAddAceGetQualifiedAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.QualifiedAce)___result;
        }


        public virtual void AddAce(System.Security.AccessControl.QualifiedAce  @newAce)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newAce};
            var ___result = RAddAce_QualifiedAce.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.AccessControl.GenericAce CopyAce(System.Security.AccessControl.GenericAce  @ace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace};
            var ___result = RCopyAce_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public virtual System.Int32 GetAceInsertPosition(System.Security.AccessControl.AceQualifier  @aceQualifier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier};
            var ___result = RGetAceInsertPosition_AceQualifier.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Security.AccessControl.AceFlags GetAceFlags(System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RGetAceFlags_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceFlags)___result;
        }


        public virtual void RemoveAceSpecific(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAceSpecific(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAce(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAce(System.Security.AccessControl.AceQualifier  @aceQualifier, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAce(System.Security.AccessControl.QualifiedAce  @newAce)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newAce};
            var ___result = RSetAce_QualifiedAce.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Security.AccessControl.GenericAce[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_GenericAceArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AceEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceEnumerator)___result;
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
