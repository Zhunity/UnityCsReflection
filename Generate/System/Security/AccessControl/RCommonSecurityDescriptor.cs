using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.CommonSecurityDescriptor
	/// </summary>
    public partial class RCommonSecurityDescriptor : RMember //
    {

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
		/// System.Security.AccessControl.ControlFlags flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier owner
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_owner;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier Rowner
		{
			get
			{
				if(r_owner == null)
				{
					r_owner = new(this, "owner");
					r_owner.SetBelong(this.instance);
				}
				return r_owner;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier group
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_group;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier Rgroup
		{
			get
			{
				if(r_group == null)
				{
					r_group = new(this, "group");
					r_group.SetBelong(this.instance);
				}
				return r_group;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.SystemAcl system_acl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RSystemAcl r_system_acl;
		public virtual RSystem.RSecurity.RAccessControl.RSystemAcl Rsystem_acl
		{
			get
			{
				if(r_system_acl == null)
				{
					r_system_acl = new(this, "system_acl");
					r_system_acl.SetBelong(this.instance);
				}
				return r_system_acl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.DiscretionaryAcl discretionary_acl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RDiscretionaryAcl r_discretionary_acl;
		public virtual RSystem.RSecurity.RAccessControl.RDiscretionaryAcl Rdiscretionary_acl
		{
			get
			{
				if(r_discretionary_acl == null)
				{
					r_discretionary_acl = new(this, "discretionary_acl");
					r_discretionary_acl.SetBelong(this.instance);
				}
				return r_discretionary_acl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags ControlFlags
		/// </summary>
		protected RProperty r_ControlFlags;
		public virtual RProperty RControlFlags
		{
			get
			{
				if(r_ControlFlags == null)
				{
					r_ControlFlags = new(this, "ControlFlags", -1);
					r_ControlFlags.SetBelong(this.instance);
				}
				return r_ControlFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.DiscretionaryAcl DiscretionaryAcl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RDiscretionaryAcl r_DiscretionaryAcl;
		public virtual RSystem.RSecurity.RAccessControl.RDiscretionaryAcl RDiscretionaryAcl
		{
			get
			{
				if(r_DiscretionaryAcl == null)
				{
					r_DiscretionaryAcl = new(this, "DiscretionaryAcl", -1);
					r_DiscretionaryAcl.SetBelong(this.instance);
				}
				return r_DiscretionaryAcl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAcl InternalDacl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RGenericAcl r_InternalDacl;
		public virtual RSystem.RSecurity.RAccessControl.RGenericAcl RInternalDacl
		{
			get
			{
				if(r_InternalDacl == null)
				{
					r_InternalDacl = new(this, "InternalDacl", -1);
					r_InternalDacl.SetBelong(this.instance);
				}
				return r_InternalDacl;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier Group
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_Group;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier RGroup
		{
			get
			{
				if(r_Group == null)
				{
					r_Group = new(this, "Group", -1);
					r_Group.SetBelong(this.instance);
				}
				return r_Group;
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
		/// Boolean IsDiscretionaryAclCanonical
		/// </summary>
		protected RProperty r_IsDiscretionaryAclCanonical;
		public virtual RProperty RIsDiscretionaryAclCanonical
		{
			get
			{
				if(r_IsDiscretionaryAclCanonical == null)
				{
					r_IsDiscretionaryAclCanonical = new(this, "IsDiscretionaryAclCanonical", -1);
					r_IsDiscretionaryAclCanonical.SetBelong(this.instance);
				}
				return r_IsDiscretionaryAclCanonical;
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
		/// Boolean IsSystemAclCanonical
		/// </summary>
		protected RProperty r_IsSystemAclCanonical;
		public virtual RProperty RIsSystemAclCanonical
		{
			get
			{
				if(r_IsSystemAclCanonical == null)
				{
					r_IsSystemAclCanonical = new(this, "IsSystemAclCanonical", -1);
					r_IsSystemAclCanonical.SetBelong(this.instance);
				}
				return r_IsSystemAclCanonical;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier Owner
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_Owner;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier ROwner
		{
			get
			{
				if(r_Owner == null)
				{
					r_Owner = new(this, "Owner", -1);
					r_Owner.SetBelong(this.instance);
				}
				return r_Owner;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.SystemAcl SystemAcl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RSystemAcl r_SystemAcl;
		public virtual RSystem.RSecurity.RAccessControl.RSystemAcl RSystemAcl
		{
			get
			{
				if(r_SystemAcl == null)
				{
					r_SystemAcl = new(this, "SystemAcl", -1);
					r_SystemAcl.SetBelong(this.instance);
				}
				return r_SystemAcl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAcl InternalSacl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RGenericAcl r_InternalSacl;
		public virtual RSystem.RSecurity.RAccessControl.RGenericAcl RInternalSacl
		{
			get
			{
				if(r_InternalSacl == null)
				{
					r_InternalSacl = new(this, "InternalSacl", -1);
					r_InternalSacl.SetBelong(this.instance);
				}
				return r_InternalSacl;
			}
		}

		/// <summary>
		/// Boolean DaclIsUnmodifiedAefa
		/// </summary>
		protected RProperty r_DaclIsUnmodifiedAefa;
		public virtual RProperty RDaclIsUnmodifiedAefa
		{
			get
			{
				if(r_DaclIsUnmodifiedAefa == null)
				{
					r_DaclIsUnmodifiedAefa = new(this, "DaclIsUnmodifiedAefa", -1);
					r_DaclIsUnmodifiedAefa.SetBelong(this.instance);
				}
				return r_DaclIsUnmodifiedAefa;
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
		/// Byte InternalReservedField
		/// </summary>
		protected RProperty r_InternalReservedField;
		public virtual RProperty RInternalReservedField
		{
			get
			{
				if(r_InternalReservedField == null)
				{
					r_InternalReservedField = new(this, "InternalReservedField", -1);
					r_InternalReservedField.SetBelong(this.instance);
				}
				return r_InternalReservedField;
			}
		}

		/// <summary>
		/// Void Init(Boolean, Boolean, System.Security.AccessControl.RawSecurityDescriptor)
		/// </summary>
		protected RMethod r_RInit_Boolean_Boolean_RawSecurityDescriptor;
		public virtual RMethod RInit_Boolean_Boolean_RawSecurityDescriptor
		{
			get
			{
				if(r_RInit_Boolean_Boolean_RawSecurityDescriptor == null)
				{
					r_RInit_Boolean_Boolean_RawSecurityDescriptor = new(this, "Init", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Security.AccessControl.RawSecurityDescriptor));
					r_RInit_Boolean_Boolean_RawSecurityDescriptor.SetBelong(this.instance);
				}
				return r_RInit_Boolean_Boolean_RawSecurityDescriptor;
			}
		}

		/// <summary>
		/// Void Init(Boolean, Boolean, System.Security.AccessControl.ControlFlags, System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.SystemAcl, System.Security.AccessControl.DiscretionaryAcl)
		/// </summary>
		protected RMethod r_RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl;
		public virtual RMethod RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl
		{
			get
			{
				if(r_RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl == null)
				{
					r_RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl = new(this, "Init", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Security.AccessControl.ControlFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.SystemAcl), typeof(System.Security.AccessControl.DiscretionaryAcl));
					r_RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl.SetBelong(this.instance);
				}
				return r_RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl;
			}
		}

		/// <summary>
		/// Void PurgeAccessControl(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_RPurgeAccessControl_SecurityIdentifier;
		public virtual RMethod RPurgeAccessControl_SecurityIdentifier
		{
			get
			{
				if(r_RPurgeAccessControl_SecurityIdentifier == null)
				{
					r_RPurgeAccessControl_SecurityIdentifier = new(this, "PurgeAccessControl", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_RPurgeAccessControl_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_RPurgeAccessControl_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void PurgeAudit(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_RPurgeAudit_SecurityIdentifier;
		public virtual RMethod RPurgeAudit_SecurityIdentifier
		{
			get
			{
				if(r_RPurgeAudit_SecurityIdentifier == null)
				{
					r_RPurgeAudit_SecurityIdentifier = new(this, "PurgeAudit", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_RPurgeAudit_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_RPurgeAudit_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void SetDiscretionaryAclProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSetDiscretionaryAclProtection_Boolean_Boolean;
		public virtual RMethod RSetDiscretionaryAclProtection_Boolean_Boolean
		{
			get
			{
				if(r_RSetDiscretionaryAclProtection_Boolean_Boolean == null)
				{
					r_RSetDiscretionaryAclProtection_Boolean_Boolean = new(this, "SetDiscretionaryAclProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RSetDiscretionaryAclProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSetDiscretionaryAclProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetSystemAclProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSetSystemAclProtection_Boolean_Boolean;
		public virtual RMethod RSetSystemAclProtection_Boolean_Boolean
		{
			get
			{
				if(r_RSetSystemAclProtection_Boolean_Boolean == null)
				{
					r_RSetSystemAclProtection_Boolean_Boolean = new(this, "SetSystemAclProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RSetSystemAclProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSetSystemAclProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void AddDiscretionaryAcl(Byte, Int32)
		/// </summary>
		protected RMethod r_RAddDiscretionaryAcl_Byte_Int32;
		public virtual RMethod RAddDiscretionaryAcl_Byte_Int32
		{
			get
			{
				if(r_RAddDiscretionaryAcl_Byte_Int32 == null)
				{
					r_RAddDiscretionaryAcl_Byte_Int32 = new(this, "AddDiscretionaryAcl", 0, typeof(System.Byte), typeof(System.Int32));
					r_RAddDiscretionaryAcl_Byte_Int32.SetBelong(this.instance);
				}
				return r_RAddDiscretionaryAcl_Byte_Int32;
			}
		}

		/// <summary>
		/// Void AddSystemAcl(Byte, Int32)
		/// </summary>
		protected RMethod r_RAddSystemAcl_Byte_Int32;
		public virtual RMethod RAddSystemAcl_Byte_Int32
		{
			get
			{
				if(r_RAddSystemAcl_Byte_Int32 == null)
				{
					r_RAddSystemAcl_Byte_Int32 = new(this, "AddSystemAcl", 0, typeof(System.Byte), typeof(System.Int32));
					r_RAddSystemAcl_Byte_Int32.SetBelong(this.instance);
				}
				return r_RAddSystemAcl_Byte_Int32;
			}
		}

		/// <summary>
		/// Void CheckAclConsistency(System.Security.AccessControl.CommonAcl)
		/// </summary>
		protected RMethod r_RCheckAclConsistency_CommonAcl;
		public virtual RMethod RCheckAclConsistency_CommonAcl
		{
			get
			{
				if(r_RCheckAclConsistency_CommonAcl == null)
				{
					r_RCheckAclConsistency_CommonAcl = new(this, "CheckAclConsistency", 0, typeof(System.Security.AccessControl.CommonAcl));
					r_RCheckAclConsistency_CommonAcl.SetBelong(this.instance);
				}
				return r_RCheckAclConsistency_CommonAcl;
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
		/// System.String GetSddlForm(System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RGetSddlForm_AccessControlSections;
		public virtual RMethod RGetSddlForm_AccessControlSections
		{
			get
			{
				if(r_RGetSddlForm_AccessControlSections == null)
				{
					r_RGetSddlForm_AccessControlSections = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.AccessControlSections));
					r_RGetSddlForm_AccessControlSections.SetBelong(this.instance);
				}
				return r_RGetSddlForm_AccessControlSections;
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


        public RCommonSecurityDescriptor() : base("System.Security.AccessControl.CommonSecurityDescriptor")
        {
        }

        public RCommonSecurityDescriptor(System.Object instance) : base("System.Security.AccessControl.CommonSecurityDescriptor")
		{
            SetInstance(instance);
		}

        public RCommonSecurityDescriptor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCommonSecurityDescriptor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(System.Boolean  @isContainer, System.Boolean  @isDS, System.Security.AccessControl.RawSecurityDescriptor  @rawSecurityDescriptor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isContainer, @isDS, @rawSecurityDescriptor};
            var ___result = RInit_Boolean_Boolean_RawSecurityDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.Boolean  @isContainer, System.Boolean  @isDS, System.Security.AccessControl.ControlFlags  @flags, System.Security.Principal.SecurityIdentifier  @owner, System.Security.Principal.SecurityIdentifier  @group, System.Security.AccessControl.SystemAcl  @systemAcl, System.Security.AccessControl.DiscretionaryAcl  @discretionaryAcl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isContainer, @isDS, @flags, @owner, @group, @systemAcl, @discretionaryAcl};
            var ___result = RInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PurgeAccessControl(System.Security.Principal.SecurityIdentifier  @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RPurgeAccessControl_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PurgeAudit(System.Security.Principal.SecurityIdentifier  @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RPurgeAudit_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDiscretionaryAclProtection(System.Boolean  @isProtected, System.Boolean  @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RSetDiscretionaryAclProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSystemAclProtection(System.Boolean  @isProtected, System.Boolean  @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RSetSystemAclProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDiscretionaryAcl(System.Byte  @revision, System.Int32  @trusted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@revision, @trusted};
            var ___result = RAddDiscretionaryAcl_Byte_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSystemAcl(System.Byte  @revision, System.Int32  @trusted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@revision, @trusted};
            var ___result = RAddSystemAcl_Byte_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckAclConsistency(System.Security.AccessControl.CommonAcl  @acl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@acl};
            var ___result = RCheckAclConsistency_CommonAcl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBinaryForm(System.Byte[]  @binaryForm, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeSections};
            var ___result = RGetSddlForm_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
