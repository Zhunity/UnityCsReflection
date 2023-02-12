
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
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fis_container;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFis_container
		{
			get
			{
				if(r_Fis_container == null)
				{
					r_Fis_container = new(this, "is_container");
					r_Fis_container.SetBelong(this.instance);
				}
				return r_Fis_container;
			}
		}

		/// <summary>
		/// System.Boolean is_ds
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fis_ds;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFis_ds
		{
			get
			{
				if(r_Fis_ds == null)
				{
					r_Fis_ds = new(this, "is_ds");
					r_Fis_ds.SetBelong(this.instance);
				}
				return r_Fis_ds;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier owner
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_Fowner;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RFowner
		{
			get
			{
				if(r_Fowner == null)
				{
					r_Fowner = new(this, "owner");
					r_Fowner.SetBelong(this.instance);
				}
				return r_Fowner;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier group
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_Fgroup;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RFgroup
		{
			get
			{
				if(r_Fgroup == null)
				{
					r_Fgroup = new(this, "group");
					r_Fgroup.SetBelong(this.instance);
				}
				return r_Fgroup;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.SystemAcl system_acl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RSystemAcl r_Fsystem_acl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RSystemAcl RFsystem_acl
		{
			get
			{
				if(r_Fsystem_acl == null)
				{
					r_Fsystem_acl = new(this, "system_acl");
					r_Fsystem_acl.SetBelong(this.instance);
				}
				return r_Fsystem_acl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.DiscretionaryAcl discretionary_acl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RDiscretionaryAcl r_Fdiscretionary_acl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RDiscretionaryAcl RFdiscretionary_acl
		{
			get
			{
				if(r_Fdiscretionary_acl == null)
				{
					r_Fdiscretionary_acl = new(this, "discretionary_acl");
					r_Fdiscretionary_acl.SetBelong(this.instance);
				}
				return r_Fdiscretionary_acl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags ControlFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_PControlFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RPControlFlags
		{
			get
			{
				if(r_PControlFlags == null)
				{
					r_PControlFlags = new(this, "ControlFlags", -1);
					r_PControlFlags.SetBelong(this.instance);
				}
				return r_PControlFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.DiscretionaryAcl DiscretionaryAcl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RDiscretionaryAcl r_PDiscretionaryAcl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RDiscretionaryAcl RPDiscretionaryAcl
		{
			get
			{
				if(r_PDiscretionaryAcl == null)
				{
					r_PDiscretionaryAcl = new(this, "DiscretionaryAcl", -1);
					r_PDiscretionaryAcl.SetBelong(this.instance);
				}
				return r_PDiscretionaryAcl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAcl InternalDacl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl r_PInternalDacl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl RPInternalDacl
		{
			get
			{
				if(r_PInternalDacl == null)
				{
					r_PInternalDacl = new(this, "InternalDacl", -1);
					r_PInternalDacl.SetBelong(this.instance);
				}
				return r_PInternalDacl;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier Group
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_PGroup;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RPGroup
		{
			get
			{
				if(r_PGroup == null)
				{
					r_PGroup = new(this, "Group", -1);
					r_PGroup.SetBelong(this.instance);
				}
				return r_PGroup;
			}
		}

		/// <summary>
		/// Boolean IsContainer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsContainer;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsContainer
		{
			get
			{
				if(r_PIsContainer == null)
				{
					r_PIsContainer = new(this, "IsContainer", -1);
					r_PIsContainer.SetBelong(this.instance);
				}
				return r_PIsContainer;
			}
		}

		/// <summary>
		/// Boolean IsDiscretionaryAclCanonical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsDiscretionaryAclCanonical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsDiscretionaryAclCanonical
		{
			get
			{
				if(r_PIsDiscretionaryAclCanonical == null)
				{
					r_PIsDiscretionaryAclCanonical = new(this, "IsDiscretionaryAclCanonical", -1);
					r_PIsDiscretionaryAclCanonical.SetBelong(this.instance);
				}
				return r_PIsDiscretionaryAclCanonical;
			}
		}

		/// <summary>
		/// Boolean IsDS
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsDS;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsDS
		{
			get
			{
				if(r_PIsDS == null)
				{
					r_PIsDS = new(this, "IsDS", -1);
					r_PIsDS.SetBelong(this.instance);
				}
				return r_PIsDS;
			}
		}

		/// <summary>
		/// Boolean IsSystemAclCanonical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSystemAclCanonical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSystemAclCanonical
		{
			get
			{
				if(r_PIsSystemAclCanonical == null)
				{
					r_PIsSystemAclCanonical = new(this, "IsSystemAclCanonical", -1);
					r_PIsSystemAclCanonical.SetBelong(this.instance);
				}
				return r_PIsSystemAclCanonical;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier Owner
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_POwner;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RPOwner
		{
			get
			{
				if(r_POwner == null)
				{
					r_POwner = new(this, "Owner", -1);
					r_POwner.SetBelong(this.instance);
				}
				return r_POwner;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.SystemAcl SystemAcl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RSystemAcl r_PSystemAcl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RSystemAcl RPSystemAcl
		{
			get
			{
				if(r_PSystemAcl == null)
				{
					r_PSystemAcl = new(this, "SystemAcl", -1);
					r_PSystemAcl.SetBelong(this.instance);
				}
				return r_PSystemAcl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAcl InternalSacl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl r_PInternalSacl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl RPInternalSacl
		{
			get
			{
				if(r_PInternalSacl == null)
				{
					r_PInternalSacl = new(this, "InternalSacl", -1);
					r_PInternalSacl.SetBelong(this.instance);
				}
				return r_PInternalSacl;
			}
		}

		/// <summary>
		/// Boolean DaclIsUnmodifiedAefa
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PDaclIsUnmodifiedAefa;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPDaclIsUnmodifiedAefa
		{
			get
			{
				if(r_PDaclIsUnmodifiedAefa == null)
				{
					r_PDaclIsUnmodifiedAefa = new(this, "DaclIsUnmodifiedAefa", -1);
					r_PDaclIsUnmodifiedAefa.SetBelong(this.instance);
				}
				return r_PDaclIsUnmodifiedAefa;
			}
		}

		/// <summary>
		/// Int32 BinaryLength
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PBinaryLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPBinaryLength
		{
			get
			{
				if(r_PBinaryLength == null)
				{
					r_PBinaryLength = new(this, "BinaryLength", -1);
					r_PBinaryLength.SetBelong(this.instance);
				}
				return r_PBinaryLength;
			}
		}

		/// <summary>
		/// Byte InternalReservedField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RByte r_PInternalReservedField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RByte RPInternalReservedField
		{
			get
			{
				if(r_PInternalReservedField == null)
				{
					r_PInternalReservedField = new(this, "InternalReservedField", -1);
					r_PInternalReservedField.SetBelong(this.instance);
				}
				return r_PInternalReservedField;
			}
		}

		/// <summary>
		/// Void Init(Boolean, Boolean, System.Security.AccessControl.RawSecurityDescriptor)
		/// </summary>
		protected RMethod r_MInit_Boolean_Boolean_RawSecurityDescriptor;
		public virtual RMethod RMInit_Boolean_Boolean_RawSecurityDescriptor
		{
			get
			{
				if(r_MInit_Boolean_Boolean_RawSecurityDescriptor == null)
				{
					r_MInit_Boolean_Boolean_RawSecurityDescriptor = new(this, "Init", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Security.AccessControl.RawSecurityDescriptor));
					r_MInit_Boolean_Boolean_RawSecurityDescriptor.SetBelong(this.instance);
				}
				return r_MInit_Boolean_Boolean_RawSecurityDescriptor;
			}
		}

		/// <summary>
		/// Void Init(Boolean, Boolean, System.Security.AccessControl.ControlFlags, System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.SystemAcl, System.Security.AccessControl.DiscretionaryAcl)
		/// </summary>
		protected RMethod r_MInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl;
		public virtual RMethod RMInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl
		{
			get
			{
				if(r_MInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl == null)
				{
					r_MInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl = new(this, "Init", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Security.AccessControl.ControlFlags), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.AccessControl.SystemAcl), typeof(System.Security.AccessControl.DiscretionaryAcl));
					r_MInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl.SetBelong(this.instance);
				}
				return r_MInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl;
			}
		}

		/// <summary>
		/// Void PurgeAccessControl(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_MPurgeAccessControl_SecurityIdentifier;
		public virtual RMethod RMPurgeAccessControl_SecurityIdentifier
		{
			get
			{
				if(r_MPurgeAccessControl_SecurityIdentifier == null)
				{
					r_MPurgeAccessControl_SecurityIdentifier = new(this, "PurgeAccessControl", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_MPurgeAccessControl_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_MPurgeAccessControl_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void PurgeAudit(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_MPurgeAudit_SecurityIdentifier;
		public virtual RMethod RMPurgeAudit_SecurityIdentifier
		{
			get
			{
				if(r_MPurgeAudit_SecurityIdentifier == null)
				{
					r_MPurgeAudit_SecurityIdentifier = new(this, "PurgeAudit", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_MPurgeAudit_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_MPurgeAudit_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Void SetDiscretionaryAclProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSetDiscretionaryAclProtection_Boolean_Boolean;
		public virtual RMethod RMSetDiscretionaryAclProtection_Boolean_Boolean
		{
			get
			{
				if(r_MSetDiscretionaryAclProtection_Boolean_Boolean == null)
				{
					r_MSetDiscretionaryAclProtection_Boolean_Boolean = new(this, "SetDiscretionaryAclProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MSetDiscretionaryAclProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MSetDiscretionaryAclProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetSystemAclProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSetSystemAclProtection_Boolean_Boolean;
		public virtual RMethod RMSetSystemAclProtection_Boolean_Boolean
		{
			get
			{
				if(r_MSetSystemAclProtection_Boolean_Boolean == null)
				{
					r_MSetSystemAclProtection_Boolean_Boolean = new(this, "SetSystemAclProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MSetSystemAclProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MSetSystemAclProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void AddDiscretionaryAcl(Byte, Int32)
		/// </summary>
		protected RMethod r_MAddDiscretionaryAcl_Byte_Int32;
		public virtual RMethod RMAddDiscretionaryAcl_Byte_Int32
		{
			get
			{
				if(r_MAddDiscretionaryAcl_Byte_Int32 == null)
				{
					r_MAddDiscretionaryAcl_Byte_Int32 = new(this, "AddDiscretionaryAcl", 0, typeof(System.Byte), typeof(System.Int32));
					r_MAddDiscretionaryAcl_Byte_Int32.SetBelong(this.instance);
				}
				return r_MAddDiscretionaryAcl_Byte_Int32;
			}
		}

		/// <summary>
		/// Void AddSystemAcl(Byte, Int32)
		/// </summary>
		protected RMethod r_MAddSystemAcl_Byte_Int32;
		public virtual RMethod RMAddSystemAcl_Byte_Int32
		{
			get
			{
				if(r_MAddSystemAcl_Byte_Int32 == null)
				{
					r_MAddSystemAcl_Byte_Int32 = new(this, "AddSystemAcl", 0, typeof(System.Byte), typeof(System.Int32));
					r_MAddSystemAcl_Byte_Int32.SetBelong(this.instance);
				}
				return r_MAddSystemAcl_Byte_Int32;
			}
		}

		/// <summary>
		/// Void CheckAclConsistency(System.Security.AccessControl.CommonAcl)
		/// </summary>
		protected RMethod r_MCheckAclConsistency_CommonAcl;
		public virtual RMethod RMCheckAclConsistency_CommonAcl
		{
			get
			{
				if(r_MCheckAclConsistency_CommonAcl == null)
				{
					r_MCheckAclConsistency_CommonAcl = new(this, "CheckAclConsistency", 0, typeof(System.Security.AccessControl.CommonAcl));
					r_MCheckAclConsistency_CommonAcl.SetBelong(this.instance);
				}
				return r_MCheckAclConsistency_CommonAcl;
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
					r_MGetBinaryForm_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MGetBinaryForm_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.String GetSddlForm(System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MGetSddlForm_AccessControlSections;
		public virtual RMethod RMGetSddlForm_AccessControlSections
		{
			get
			{
				if(r_MGetSddlForm_AccessControlSections == null)
				{
					r_MGetSddlForm_AccessControlSections = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.AccessControlSections));
					r_MGetSddlForm_AccessControlSections.SetBelong(this.instance);
				}
				return r_MGetSddlForm_AccessControlSections;
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

        public virtual void Init(System.Boolean @isContainer, System.Boolean @isDS, System.Security.AccessControl.RawSecurityDescriptor @rawSecurityDescriptor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isContainer, @isDS, @rawSecurityDescriptor};
            var ___result = RMInit_Boolean_Boolean_RawSecurityDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.Boolean @isContainer, System.Boolean @isDS, System.Security.AccessControl.ControlFlags @flags, System.Security.Principal.SecurityIdentifier @owner, System.Security.Principal.SecurityIdentifier @group, System.Security.AccessControl.SystemAcl @systemAcl, System.Security.AccessControl.DiscretionaryAcl @discretionaryAcl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isContainer, @isDS, @flags, @owner, @group, @systemAcl, @discretionaryAcl};
            var ___result = RMInit_Boolean_Boolean_ControlFlags_SecurityIdentifier_SecurityIdentifier_SystemAcl_DiscretionaryAcl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PurgeAccessControl(System.Security.Principal.SecurityIdentifier @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RMPurgeAccessControl_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PurgeAudit(System.Security.Principal.SecurityIdentifier @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RMPurgeAudit_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDiscretionaryAclProtection(System.Boolean @isProtected, System.Boolean @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RMSetDiscretionaryAclProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSystemAclProtection(System.Boolean @isProtected, System.Boolean @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RMSetSystemAclProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDiscretionaryAcl(System.Byte @revision, System.Int32 @trusted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@revision, @trusted};
            var ___result = RMAddDiscretionaryAcl_Byte_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSystemAcl(System.Byte @revision, System.Int32 @trusted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@revision, @trusted};
            var ___result = RMAddSystemAcl_Byte_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckAclConsistency(System.Security.AccessControl.CommonAcl @acl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@acl};
            var ___result = RMCheckAclConsistency_CommonAcl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeSections};
            var ___result = RMGetSddlForm_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
