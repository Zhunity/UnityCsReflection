
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.AccessControl.DiscretionaryAcl
	/// </summary>
    public partial class RDiscretionaryAcl : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.AccessControl.DiscretionaryAcl);
            }
        }

        public RDiscretionaryAcl() : base("System.Security.AccessControl.DiscretionaryAcl")
        {
        }

        public RDiscretionaryAcl(System.Object instance) : base("System.Security.AccessControl.DiscretionaryAcl")
		{
            SetInstance(instance);
		}

        public RDiscretionaryAcl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDiscretionaryAcl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Security.AccessControl.RawAcl raw_acl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl r_Fraw_acl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl RFraw_acl
		{
			get
			{
				if(r_Fraw_acl == null)
				{
					r_Fraw_acl = new(this, "raw_acl");
				}
				return r_Fraw_acl;
			}
		}

		/// <summary>
		/// Int32 BinaryLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PBinaryLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPBinaryLength
		{
			get
			{
				if(r_PBinaryLength == null)
				{
					r_PBinaryLength = new(this, "BinaryLength", -1);
				}
				return r_PBinaryLength;
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
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsCanonical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCanonical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCanonical
		{
			get
			{
				if(r_PIsCanonical == null)
				{
					r_PIsCanonical = new(this, "IsCanonical", -1);
				}
				return r_PIsCanonical;
			}
		}

		/// <summary>
		/// Boolean IsContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsContainer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsContainer
		{
			get
			{
				if(r_PIsContainer == null)
				{
					r_PIsContainer = new(this, "IsContainer", -1);
				}
				return r_PIsContainer;
			}
		}

		/// <summary>
		/// Boolean IsDS
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsDS;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsDS
		{
			get
			{
				if(r_PIsDS == null)
				{
					r_PIsDS = new(this, "IsDS", -1);
				}
				return r_PIsDS;
			}
		}

		/// <summary>
		/// Boolean IsAefa
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAefa;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAefa
		{
			get
			{
				if(r_PIsAefa == null)
				{
					r_PIsAefa = new(this, "IsAefa", -1);
				}
				return r_PIsAefa;
			}
		}

		/// <summary>
		/// Byte Revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PRevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPRevision
		{
			get
			{
				if(r_PRevision == null)
				{
					r_PRevision = new(this, "Revision", -1);
				}
				return r_PRevision;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAce r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAce RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
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
				}
				return r_PIsSynchronized;
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
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// Void AddAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RMAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "AddAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
				}
				return r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Void AddAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "AddAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void AddAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAccessRule)
		/// </summary>
		protected RMethod r_MAddAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule;
		public virtual RMethod RMAddAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule
		{
			get
			{
				if(r_MAddAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule == null)
				{
					r_MAddAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule = new(this, "AddAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAccessRule));
				}
				return r_MAddAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RMRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "RemoveAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
				}
				return r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Boolean RemoveAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Boolean RemoveAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule;
		public virtual RMethod RMRemoveAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule
		{
			get
			{
				if(r_MRemoveAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule == null)
				{
					r_MRemoveAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule = new(this, "RemoveAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAccessRule));
				}
				return r_MRemoveAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RMRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "RemoveAccessSpecific", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
				}
				return r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAccessSpecific", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_ObjectAccessRule;
		public virtual RMethod RMRemoveAccessSpecific_AccessControlType_SecurityIdentifier_ObjectAccessRule
		{
			get
			{
				if(r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_ObjectAccessRule == null)
				{
					r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_ObjectAccessRule = new(this, "RemoveAccessSpecific", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAccessRule));
				}
				return r_MRemoveAccessSpecific_AccessControlType_SecurityIdentifier_ObjectAccessRule;
			}
		}

		/// <summary>
		/// Void SetAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags)
		/// </summary>
		protected RMethod r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
		public virtual RMethod RMSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags
		{
			get
			{
				if(r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags == null)
				{
					r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags = new(this, "SetAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags));
				}
				return r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags;
			}
		}

		/// <summary>
		/// Void SetAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid = new(this, "SetAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void SetAccess(System.Security.AccessControl.AccessControlType, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.ObjectAccessRule)
		/// </summary>
		protected RMethod r_MSetAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule;
		public virtual RMethod RMSetAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule
		{
			get
			{
				if(r_MSetAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule == null)
				{
					r_MSetAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule = new(this, "SetAccess", 0, typeof(System.Security.AccessControl.AccessControlType), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.ObjectAccessRule));
				}
				return r_MSetAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule;
			}
		}

		/// <summary>
		/// Void ApplyCanonicalSortToExplicitAces()
		/// </summary>
		protected RMethod r_MApplyCanonicalSortToExplicitAces;
		public virtual RMethod RMApplyCanonicalSortToExplicitAces
		{
			get
			{
				if(r_MApplyCanonicalSortToExplicitAces == null)
				{
					r_MApplyCanonicalSortToExplicitAces = new(this, "ApplyCanonicalSortToExplicitAces", 0);
				}
				return r_MApplyCanonicalSortToExplicitAces;
			}
		}

		/// <summary>
		/// Int32 GetAceInsertPosition(System.Security.AccessControl.AceQualifier)
		/// </summary>
		protected RMethod r_MGetAceInsertPosition_AceQualifier;
		public virtual RMethod RMGetAceInsertPosition_AceQualifier
		{
			get
			{
				if(r_MGetAceInsertPosition_AceQualifier == null)
				{
					r_MGetAceInsertPosition_AceQualifier = new(this, "GetAceInsertPosition", 0, typeof(System.Security.AccessControl.AceQualifier));
				}
				return r_MGetAceInsertPosition_AceQualifier;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceQualifier GetAceQualifier(System.Security.AccessControl.AccessControlType)
		/// </summary>
		protected static RMethod r_MGetAceQualifier_AccessControlType;
		public static RMethod RMGetAceQualifier_AccessControlType
		{
			get
			{
				if(r_MGetAceQualifier_AccessControlType == null)
				{
					r_MGetAceQualifier_AccessControlType = new(Type, "GetAceQualifier", 0, typeof(System.Security.AccessControl.AccessControlType));
				}
				return r_MGetAceQualifier_AccessControlType;
			}
		}

		/// <summary>
		/// Boolean IsAceMeaningless(System.Security.AccessControl.GenericAce)
		/// </summary>
		protected RMethod r_MIsAceMeaningless_GenericAce;
		public virtual RMethod RMIsAceMeaningless_GenericAce
		{
			get
			{
				if(r_MIsAceMeaningless_GenericAce == null)
				{
					r_MIsAceMeaningless_GenericAce = new(this, "IsAceMeaningless", 0, typeof(System.Security.AccessControl.GenericAce));
				}
				return r_MIsAceMeaningless_GenericAce;
			}
		}

		/// <summary>
		/// Void GetBinaryForm(Byte[], Int32)
		/// </summary>
		protected RMethod r_MGetBinaryForm_ByteArray_Int32;
		public virtual RMethod RMGetBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_MGetBinaryForm_ByteArray_Int32 == null)
				{
					r_MGetBinaryForm_ByteArray_Int32 = new(this, "GetBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MGetBinaryForm_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void Purge(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_MPurge_SecurityIdentifier;
		public virtual RMethod RMPurge_SecurityIdentifier
		{
			get
			{
				if(r_MPurge_SecurityIdentifier == null)
				{
					r_MPurge_SecurityIdentifier = new(this, "Purge", 0, typeof(System.Security.Principal.SecurityIdentifier));
				}
				return r_MPurge_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void RemoveInheritedAces()
		/// </summary>
		protected RMethod r_MRemoveInheritedAces;
		public virtual RMethod RMRemoveInheritedAces
		{
			get
			{
				if(r_MRemoveInheritedAces == null)
				{
					r_MRemoveInheritedAces = new(this, "RemoveInheritedAces", 0);
				}
				return r_MRemoveInheritedAces;
			}
		}

		/// <summary>
		/// Void RequireCanonicity()
		/// </summary>
		protected RMethod r_MRequireCanonicity;
		public virtual RMethod RMRequireCanonicity
		{
			get
			{
				if(r_MRequireCanonicity == null)
				{
					r_MRequireCanonicity = new(this, "RequireCanonicity", 0);
				}
				return r_MRequireCanonicity;
			}
		}

		/// <summary>
		/// Void CanonicalizeAndClearAefa()
		/// </summary>
		protected RMethod r_MCanonicalizeAndClearAefa;
		public virtual RMethod RMCanonicalizeAndClearAefa
		{
			get
			{
				if(r_MCanonicalizeAndClearAefa == null)
				{
					r_MCanonicalizeAndClearAefa = new(this, "CanonicalizeAndClearAefa", 0);
				}
				return r_MCanonicalizeAndClearAefa;
			}
		}

		/// <summary>
		/// Int32 GetCanonicalExplicitDenyAceCount()
		/// </summary>
		protected RMethod r_MGetCanonicalExplicitDenyAceCount;
		public virtual RMethod RMGetCanonicalExplicitDenyAceCount
		{
			get
			{
				if(r_MGetCanonicalExplicitDenyAceCount == null)
				{
					r_MGetCanonicalExplicitDenyAceCount = new(this, "GetCanonicalExplicitDenyAceCount", 0);
				}
				return r_MGetCanonicalExplicitDenyAceCount;
			}
		}

		/// <summary>
		/// Int32 GetCanonicalExplicitAceCount()
		/// </summary>
		protected RMethod r_MGetCanonicalExplicitAceCount;
		public virtual RMethod RMGetCanonicalExplicitAceCount
		{
			get
			{
				if(r_MGetCanonicalExplicitAceCount == null)
				{
					r_MGetCanonicalExplicitAceCount = new(this, "GetCanonicalExplicitAceCount", 0);
				}
				return r_MGetCanonicalExplicitAceCount;
			}
		}

		/// <summary>
		/// Void ApplyCanonicalSortToExplicitAces(Int32, Int32)
		/// </summary>
		protected RMethod r_MApplyCanonicalSortToExplicitAces_Int32_Int32;
		public virtual RMethod RMApplyCanonicalSortToExplicitAces_Int32_Int32
		{
			get
			{
				if(r_MApplyCanonicalSortToExplicitAces_Int32_Int32 == null)
				{
					r_MApplyCanonicalSortToExplicitAces_Int32_Int32 = new(this, "ApplyCanonicalSortToExplicitAces", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MApplyCanonicalSortToExplicitAces_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetSddlForm(System.Security.AccessControl.ControlFlags, Boolean)
		/// </summary>
		protected RMethod r_MGetSddlForm_ControlFlags_Boolean;
		public virtual RMethod RMGetSddlForm_ControlFlags_Boolean
		{
			get
			{
				if(r_MGetSddlForm_ControlFlags_Boolean == null)
				{
					r_MGetSddlForm_ControlFlags_Boolean = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.ControlFlags), typeof(System.Boolean));
				}
				return r_MGetSddlForm_ControlFlags_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveAces[T](RemoveAcesCallback`1)
		/// </summary>
		protected RMethod r_MRemoveAces_GT_RemoveAcesCallback_d_T_p_;
		public virtual RMethod RMRemoveAces_GT_RemoveAcesCallback_d_T_p_
		{
			get
			{
				if(r_MRemoveAces_GT_RemoveAcesCallback_d_T_p_ == null)
				{
					r_MRemoveAces_GT_RemoveAcesCallback_d_T_p_ = new(this, "RemoveAces", 1,  ReflectionUtils.GetType("System.Security.AccessControl.CommonAcl+RemoveAcesCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MRemoveAces_GT_RemoveAcesCallback_d_T_p_;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RMAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "AddAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
				}
				return r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void AddAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "AddAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void RemoveAceSpecific(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RMRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "RemoveAceSpecific", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
				}
				return r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void RemoveAceSpecific(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "RemoveAceSpecific", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RMSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "SetAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
				}
				return r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void SetAce(System.Security.AccessControl.AceQualifier, System.Security.Principal.SecurityIdentifier, Int32, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags, System.Security.AccessControl.ObjectAceFlags, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
		public virtual RMethod RMSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid
		{
			get
			{
				if(r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid == null)
				{
					r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid = new(this, "SetAce", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Int32), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags), typeof(System.Security.AccessControl.ObjectAceFlags), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Security.AccessControl.GenericAce[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_GenericAceArray_Int32;
		public virtual RMethod RMCopyTo_GenericAceArray_Int32
		{
			get
			{
				if(r_MCopyTo_GenericAceArray_Int32 == null)
				{
					r_MCopyTo_GenericAceArray_Int32 = new(this, "CopyTo", 0, typeof(System.Security.AccessControl.GenericAce).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopyTo_GenericAceArray_Int32;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
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


        public virtual void AddAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RMAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMAddAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Security.AccessControl.ObjectAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @rule};
            var ___result = RMAddAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RMRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RemoveAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMRemoveAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RemoveAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Security.AccessControl.ObjectAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @rule};
            var ___result = RMRemoveAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RMRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMRemoveAccessSpecific_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Security.AccessControl.ObjectAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @rule};
            var ___result = RMRemoveAccessSpecific_AccessControlType_SecurityIdentifier_ObjectAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags};
            var ___result = RMSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMSetAccess_AccessControlType_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccess(System.Security.AccessControl.AccessControlType @accessType, System.Security.Principal.SecurityIdentifier @sid, System.Security.AccessControl.ObjectAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType, @sid, @rule};
            var ___result = RMSetAccess_AccessControlType_SecurityIdentifier_ObjectAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyCanonicalSortToExplicitAces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyCanonicalSortToExplicitAces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetAceInsertPosition(System.Security.AccessControl.AceQualifier @aceQualifier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier};
            var ___result = RMGetAceInsertPosition_AceQualifier.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Security.AccessControl.AceQualifier GetAceQualifier(System.Security.AccessControl.AccessControlType @accessType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessType};
            var ___result = RMGetAceQualifier_AccessControlType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.AccessControl.AceQualifier>(___result);
        }


        public virtual System.Boolean IsAceMeaningless(System.Security.AccessControl.GenericAce @ace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace};
            var ___result = RMIsAceMeaningless_GenericAce.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Purge(System.Security.Principal.SecurityIdentifier @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RMPurge_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveInheritedAces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveInheritedAces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequireCanonicity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRequireCanonicity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CanonicalizeAndClearAefa()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanonicalizeAndClearAefa.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCanonicalExplicitDenyAceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCanonicalExplicitDenyAceCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetCanonicalExplicitAceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCanonicalExplicitAceCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void ApplyCanonicalSortToExplicitAces(System.Int32 @start, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @count};
            var ___result = RMApplyCanonicalSortToExplicitAces_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.ControlFlags @sdFlags, System.Boolean @isDacl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sdFlags, @isDacl};
            var ___result = RMGetSddlForm_ControlFlags_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void RemoveAces<T>(Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RCommonAcl.RRemoveAcesCallback<Hvak.Editor.Refleaction.RType> @callback) where T : System.Security.AccessControl.GenericAce
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@callback.Value};
            var ___result = RMRemoveAces_GT_RemoveAcesCallback_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAce(System.Security.AccessControl.AceQualifier @aceQualifier, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RMAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAce(System.Security.AccessControl.AceQualifier @aceQualifier, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @auditFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMAddAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAceSpecific(System.Security.AccessControl.AceQualifier @aceQualifier, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RMRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAceSpecific(System.Security.AccessControl.AceQualifier @aceQualifier, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @auditFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMRemoveAceSpecific_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAce(System.Security.AccessControl.AceQualifier @aceQualifier, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @auditFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags};
            var ___result = RMSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAce(System.Security.AccessControl.AceQualifier @aceQualifier, System.Security.Principal.SecurityIdentifier @sid, System.Int32 @accessMask, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @auditFlags, System.Security.AccessControl.ObjectAceFlags @objectFlags, System.Guid @objectType, System.Guid @inheritedObjectType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aceQualifier, @sid, @accessMask, @inheritanceFlags, @propagationFlags, @auditFlags, @objectFlags, @objectType, @inheritedObjectType};
            var ___result = RMSetAce_AceQualifier_SecurityIdentifier_Int32_InheritanceFlags_PropagationFlags_AuditFlags_ObjectAceFlags_Guid_Guid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Security.AccessControl.GenericAce[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_GenericAceArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AceEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.AccessControl.AceEnumerator>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
