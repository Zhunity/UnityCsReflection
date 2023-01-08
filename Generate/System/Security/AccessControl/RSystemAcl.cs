using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.SystemAcl
	/// </summary>
    public partial class RSystemAcl : RMember //
    {

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
		public virtual RProperty RRevision
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
		/// Void AddAudit(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RAddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "AddAudit", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
					r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.SetBelong(this.instance);
				}
				return r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Void AddAudit(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RAddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "AddAudit", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_AddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void AddAudit(System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAuditRule)
		/// </summary>
		protected RMethod r_AddAudit_SecurityIdentifier_ObjectAuditRule;
		public virtual RMethod RAddAudit_SecurityIdentifier_ObjectAuditRule
		{
			get
			{
				if(r_AddAudit_SecurityIdentifier_ObjectAuditRule == null)
				{
					r_AddAudit_SecurityIdentifier_ObjectAuditRule = new(this, "AddAudit", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAuditRule));
					r_AddAudit_SecurityIdentifier_ObjectAuditRule.SetBelong(this.instance);
				}
				return r_AddAudit_SecurityIdentifier_ObjectAuditRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAudit(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RRemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "RemoveAudit", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
					r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.SetBelong(this.instance);
				}
				return r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Boolean RemoveAudit(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RRemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAudit", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Boolean RemoveAudit(System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAuditRule)
		/// </summary>
		protected RMethod r_RemoveAudit_SecurityIdentifier_ObjectAuditRule;
		public virtual RMethod RRemoveAudit_SecurityIdentifier_ObjectAuditRule
		{
			get
			{
				if(r_RemoveAudit_SecurityIdentifier_ObjectAuditRule == null)
				{
					r_RemoveAudit_SecurityIdentifier_ObjectAuditRule = new(this, "RemoveAudit", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAuditRule));
					r_RemoveAudit_SecurityIdentifier_ObjectAuditRule.SetBelong(this.instance);
				}
				return r_RemoveAudit_SecurityIdentifier_ObjectAuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RRemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "RemoveAuditSpecific", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
					r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.SetBelong(this.instance);
				}
				return r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RRemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAuditSpecific", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void RemoveAuditSpecific(System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAuditRule)
		/// </summary>
		protected RMethod r_RemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule;
		public virtual RMethod RRemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule
		{
			get
			{
				if(r_RemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule == null)
				{
					r_RemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule = new(this, "RemoveAuditSpecific", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAuditRule));
					r_RemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule.SetBelong(this.instance);
				}
				return r_RemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule;
			}
		}

		/// <summary>
		/// Void SetAudit(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RSetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "SetAudit", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
					r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.SetBelong(this.instance);
				}
				return r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Void SetAudit(System.Security.AccessControl.AuditFlags, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RSetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "SetAudit", 0, typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_SetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void SetAudit(System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAuditRule)
		/// </summary>
		protected RMethod r_SetAudit_SecurityIdentifier_ObjectAuditRule;
		public virtual RMethod RSetAudit_SecurityIdentifier_ObjectAuditRule
		{
			get
			{
				if(r_SetAudit_SecurityIdentifier_ObjectAuditRule == null)
				{
					r_SetAudit_SecurityIdentifier_ObjectAuditRule = new(this, "SetAudit", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAuditRule));
					r_SetAudit_SecurityIdentifier_ObjectAuditRule.SetBelong(this.instance);
				}
				return r_SetAudit_SecurityIdentifier_ObjectAuditRule;
			}
		}

		/// <summary>
		/// Void ApplyCanonicalSortToExplicitAces()
		/// </summary>
		protected RMethod r_ApplyCanonicalSortToExplicitAces;
		public virtual RMethod RApplyCanonicalSortToExplicitAces
		{
			get
			{
				if(r_ApplyCanonicalSortToExplicitAces == null)
				{
					r_ApplyCanonicalSortToExplicitAces = new(this, "ApplyCanonicalSortToExplicitAces", 0);
					r_ApplyCanonicalSortToExplicitAces.SetBelong(this.instance);
				}
				return r_ApplyCanonicalSortToExplicitAces;
			}
		}

		/// <summary>
		/// Int32 GetAceInsertPosition(System.Security.AccessControl.AceQualifier)
		/// </summary>
		protected RMethod r_GetAceInsertPosition_AceQualifier;
		public virtual RMethod RGetAceInsertPosition_AceQualifier
		{
			get
			{
				if(r_GetAceInsertPosition_AceQualifier == null)
				{
					r_GetAceInsertPosition_AceQualifier = new(this, "GetAceInsertPosition", 0, typeof(System.Security.AccessControl.AceQualifier));
					r_GetAceInsertPosition_AceQualifier.SetBelong(this.instance);
				}
				return r_GetAceInsertPosition_AceQualifier;
			}
		}

		/// <summary>
		/// Boolean IsAceMeaningless(System.Security.AccessControl.GenericAce)
		/// </summary>
		protected RMethod r_IsAceMeaningless_GenericAce;
		public virtual RMethod RIsAceMeaningless_GenericAce
		{
			get
			{
				if(r_IsAceMeaningless_GenericAce == null)
				{
					r_IsAceMeaningless_GenericAce = new(this, "IsAceMeaningless", 0, typeof(System.Security.AccessControl.GenericAce));
					r_IsAceMeaningless_GenericAce.SetBelong(this.instance);
				}
				return r_IsAceMeaningless_GenericAce;
			}
		}

		/// <summary>
		/// Boolean IsValidAuditFlags(System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected static RMethod r_IsValidAuditFlags_AuditFlags;
		public static RMethod RIsValidAuditFlags_AuditFlags
		{
			get
			{
				if(r_IsValidAuditFlags_AuditFlags == null)
				{
					r_IsValidAuditFlags_AuditFlags = new(typeof(System.Security.AccessControl.SystemAcl), "IsValidAuditFlags", 0, typeof(System.Security.AccessControl.AuditFlags));
					r_IsValidAuditFlags_AuditFlags.SetBelong(null);
				}
				return r_IsValidAuditFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void GetBinaryForm(Byte[], Int32)
		/// </summary>
		protected RMethod r_GetBinaryForm_ByteArray_Int32;
		public virtual RMethod RGetBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_GetBinaryForm_ByteArray_Int32 == null)
				{
					r_GetBinaryForm_ByteArray_Int32 = new(this, "GetBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_GetBinaryForm_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_GetBinaryForm_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void Purge(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_Purge_SecurityIdentifier;
		public virtual RMethod RPurge_SecurityIdentifier
		{
			get
			{
				if(r_Purge_SecurityIdentifier == null)
				{
					r_Purge_SecurityIdentifier = new(this, "Purge", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_Purge_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_Purge_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void RemoveInheritedAces()
		/// </summary>
		protected RMethod r_RemoveInheritedAces;
		public virtual RMethod RRemoveInheritedAces
		{
			get
			{
				if(r_RemoveInheritedAces == null)
				{
					r_RemoveInheritedAces = new(this, "RemoveInheritedAces", 0);
					r_RemoveInheritedAces.SetBelong(this.instance);
				}
				return r_RemoveInheritedAces;
			}
		}

		/// <summary>
		/// Void RequireCanonicity()
		/// </summary>
		protected RMethod r_RequireCanonicity;
		public virtual RMethod RRequireCanonicity
		{
			get
			{
				if(r_RequireCanonicity == null)
				{
					r_RequireCanonicity = new(this, "RequireCanonicity", 0);
					r_RequireCanonicity.SetBelong(this.instance);
				}
				return r_RequireCanonicity;
			}
		}

		/// <summary>
		/// Void CanonicalizeAndClearAefa()
		/// </summary>
		protected RMethod r_CanonicalizeAndClearAefa;
		public virtual RMethod RCanonicalizeAndClearAefa
		{
			get
			{
				if(r_CanonicalizeAndClearAefa == null)
				{
					r_CanonicalizeAndClearAefa = new(this, "CanonicalizeAndClearAefa", 0);
					r_CanonicalizeAndClearAefa.SetBelong(this.instance);
				}
				return r_CanonicalizeAndClearAefa;
			}
		}

		/// <summary>
		/// Int32 GetCanonicalExplicitDenyAceCount()
		/// </summary>
		protected RMethod r_GetCanonicalExplicitDenyAceCount;
		public virtual RMethod RGetCanonicalExplicitDenyAceCount
		{
			get
			{
				if(r_GetCanonicalExplicitDenyAceCount == null)
				{
					r_GetCanonicalExplicitDenyAceCount = new(this, "GetCanonicalExplicitDenyAceCount", 0);
					r_GetCanonicalExplicitDenyAceCount.SetBelong(this.instance);
				}
				return r_GetCanonicalExplicitDenyAceCount;
			}
		}

		/// <summary>
		/// Int32 GetCanonicalExplicitAceCount()
		/// </summary>
		protected RMethod r_GetCanonicalExplicitAceCount;
		public virtual RMethod RGetCanonicalExplicitAceCount
		{
			get
			{
				if(r_GetCanonicalExplicitAceCount == null)
				{
					r_GetCanonicalExplicitAceCount = new(this, "GetCanonicalExplicitAceCount", 0);
					r_GetCanonicalExplicitAceCount.SetBelong(this.instance);
				}
				return r_GetCanonicalExplicitAceCount;
			}
		}

		/// <summary>
		/// Void ApplyCanonicalSortToExplicitAces(Int32, Int32)
		/// </summary>
		protected RMethod r_ApplyCanonicalSortToExplicitAces_Int32_Int32;
		public virtual RMethod RApplyCanonicalSortToExplicitAces_Int32_Int32
		{
			get
			{
				if(r_ApplyCanonicalSortToExplicitAces_Int32_Int32 == null)
				{
					r_ApplyCanonicalSortToExplicitAces_Int32_Int32 = new(this, "ApplyCanonicalSortToExplicitAces", 0, typeof(System.Int32), typeof(System.Int32));
					r_ApplyCanonicalSortToExplicitAces_Int32_Int32.SetBelong(this.instance);
				}
				return r_ApplyCanonicalSortToExplicitAces_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetSddlForm(System.Security.AccessControl.ControlFlags, Boolean)
		/// </summary>
		protected RMethod r_GetSddlForm_ControlFlags_Boolean;
		public virtual RMethod RGetSddlForm_ControlFlags_Boolean
		{
			get
			{
				if(r_GetSddlForm_ControlFlags_Boolean == null)
				{
					r_GetSddlForm_ControlFlags_Boolean = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.ControlFlags), typeof(System.Boolean));
					r_GetSddlForm_ControlFlags_Boolean.SetBelong(this.instance);
				}
				return r_GetSddlForm_ControlFlags_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveAces[T](RemoveAcesCallback`1)
		/// </summary>
		protected RMethod r_RemoveAces_GT_RemoveAcesCallback_d_T_p_;
		public virtual RMethod RRemoveAces_GT_RemoveAcesCallback_d_T_p_
		{
			get
			{
				if(r_RemoveAces_GT_RemoveAcesCallback_d_T_p_ == null)
				{
					r_RemoveAces_GT_RemoveAcesCallback_d_T_p_ = new(this, "RemoveAces", 1,  ReflectionUtils.GetType("System.Security.AccessControl.CommonAcl+RemoveAcesCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RemoveAces_GT_RemoveAcesCallback_d_T_p_.SetBelong(this.instance);
				}
				return r_RemoveAces_GT_RemoveAcesCallback_d_T_p_;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "AddAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "AddAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_AddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void RemoveAceSpecific(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "RemoveAceSpecific", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void RemoveAceSpecific(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAceSpecific", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_RemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "SetAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "SetAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
					r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.SetBelong(this.instance);
				}
				return r_SetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Security.AccessControl.GenericAce[], Int32)
		/// </summary>
		protected RMethod r_CopyTo_GenericAceArray_Int32;
		public virtual RMethod RCopyTo_GenericAceArray_Int32
		{
			get
			{
				if(r_CopyTo_GenericAceArray_Int32 == null)
				{
					r_CopyTo_GenericAceArray_Int32 = new(this, "CopyTo", 0, typeof(System.Security.AccessControl.GenericAce).MakeArrayType(), typeof(System.Int32));
					r_CopyTo_GenericAceArray_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_GenericAceArray_Int32;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceEnumerator GetEnumerator()
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


        public RSystemAcl() : base("System.Security.AccessControl.SystemAcl")
        {
        }

        public RSystemAcl(System.Object instance) : base("System.Security.AccessControl.SystemAcl")
		{
            SetInstance(instance);
		}

        public RSystemAcl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSystemAcl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddAudit(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RAddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAudit(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RAddAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAudit(System.Security.Principal.SecurityIdentifier  @sid, System.Security.AccessControl.ObjectAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid, @rule};
            var ___result = RAddAudit_SecurityIdentifier_ObjectAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAudit(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RRemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RemoveAudit(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RRemoveAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RemoveAudit(System.Security.Principal.SecurityIdentifier  @sid, System.Security.AccessControl.ObjectAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid, @rule};
            var ___result = RRemoveAudit_SecurityIdentifier_ObjectAuditRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RRemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RRemoveAuditSpecific_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAuditSpecific(System.Security.Principal.SecurityIdentifier  @sid, System.Security.AccessControl.ObjectAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid, @rule};
            var ___result = RRemoveAuditSpecific_SecurityIdentifier_ObjectAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAudit(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RSetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAudit(System.Security.AccessControl.AuditFlags  @auditFlags, System.Security.Principal.SecurityIdentifier  @sid, System.Int32  @accessMask, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.ObjectAceFlags  @objectFlags, System.Guid  @objectType, System.Guid  @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RSetAudit_AuditFlags_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAudit(System.Security.Principal.SecurityIdentifier  @sid, System.Security.AccessControl.ObjectAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid, @rule};
            var ___result = RSetAudit_SecurityIdentifier_ObjectAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyCanonicalSortToExplicitAces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyCanonicalSortToExplicitAces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetAceInsertPosition(System.Security.AccessControl.AceQualifier  @aceQualifier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier};
            var ___result = RGetAceInsertPosition_AceQualifier.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsAceMeaningless(System.Security.AccessControl.GenericAce  @ace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace};
            var ___result = RIsAceMeaningless_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidAuditFlags(System.Security.AccessControl.AuditFlags  @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@auditFlags};
            var ___result = RIsValidAuditFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual void RemoveAces<T>(RSystem.RSecurity.RAccessControl.RCommonAcl.RRemoveAcesCallback<RType>  @callback) where T : System.Security.AccessControl.GenericAce
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@callback.Value};
            var ___result = RRemoveAces_GT_RemoveAcesCallback_d_T_p_.Invoke(___genericsType, ___parameters);

            
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
