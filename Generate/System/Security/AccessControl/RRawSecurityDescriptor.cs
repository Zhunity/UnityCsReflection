using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.RawSecurityDescriptor
	/// </summary>
    public partial class RRawSecurityDescriptor : RMember //
    {

		/// <summary>
		/// System.Security.AccessControl.ControlFlags control_flags
		/// </summary>
		protected RField r_control_flags;
		public virtual RField Rcontrol_flags
		{
			get
			{
				if(r_control_flags == null)
				{
					r_control_flags = new(this, "control_flags");
					r_control_flags.SetBelong(this.instance);
				}
				return r_control_flags;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier owner_sid
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_owner_sid;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier Rowner_sid
		{
			get
			{
				if(r_owner_sid == null)
				{
					r_owner_sid = new(this, "owner_sid");
					r_owner_sid.SetBelong(this.instance);
				}
				return r_owner_sid;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier group_sid
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_group_sid;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier Rgroup_sid
		{
			get
			{
				if(r_group_sid == null)
				{
					r_group_sid = new(this, "group_sid");
					r_group_sid.SetBelong(this.instance);
				}
				return r_group_sid;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl system_acl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RRawAcl r_system_acl;
		public virtual RSystem.RSecurity.RAccessControl.RRawAcl Rsystem_acl
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
		/// System.Security.AccessControl.RawAcl discretionary_acl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RRawAcl r_discretionary_acl;
		public virtual RSystem.RSecurity.RAccessControl.RRawAcl Rdiscretionary_acl
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
		/// System.Byte resourcemgr_control
		/// </summary>
		protected RField r_resourcemgr_control;
		public virtual RField Rresourcemgr_control
		{
			get
			{
				if(r_resourcemgr_control == null)
				{
					r_resourcemgr_control = new(this, "resourcemgr_control");
					r_resourcemgr_control.SetBelong(this.instance);
				}
				return r_resourcemgr_control;
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
		/// System.Security.AccessControl.RawAcl DiscretionaryAcl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RRawAcl r_DiscretionaryAcl;
		public virtual RSystem.RSecurity.RAccessControl.RRawAcl RDiscretionaryAcl
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
		/// Byte ResourceManagerControl
		/// </summary>
		protected RProperty r_ResourceManagerControl;
		public virtual RProperty RResourceManagerControl
		{
			get
			{
				if(r_ResourceManagerControl == null)
				{
					r_ResourceManagerControl = new(this, "ResourceManagerControl", -1);
					r_ResourceManagerControl.SetBelong(this.instance);
				}
				return r_ResourceManagerControl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl SystemAcl
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RRawAcl r_SystemAcl;
		public virtual RSystem.RSecurity.RAccessControl.RRawAcl RSystemAcl
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
		/// Void SetFlags(System.Security.AccessControl.ControlFlags)
		/// </summary>
		protected RMethod r_SetFlags_ControlFlags;
		public virtual RMethod RSetFlags_ControlFlags
		{
			get
			{
				if(r_SetFlags_ControlFlags == null)
				{
					r_SetFlags_ControlFlags = new(this, "SetFlags", 0, typeof(System.Security.AccessControl.ControlFlags));
					r_SetFlags_ControlFlags.SetBelong(this.instance);
				}
				return r_SetFlags_ControlFlags;
			}
		}

		/// <summary>
		/// Void ParseSddl(System.String)
		/// </summary>
		protected RMethod r_ParseSddl_String;
		public virtual RMethod RParseSddl_String
		{
			get
			{
				if(r_ParseSddl_String == null)
				{
					r_ParseSddl_String = new(this, "ParseSddl", 0, typeof(System.String));
					r_ParseSddl_String.SetBelong(this.instance);
				}
				return r_ParseSddl_String;
			}
		}

		/// <summary>
		/// UInt16 ReadUShort(Byte[], Int32)
		/// </summary>
		protected RMethod r_ReadUShort_ByteArray_Int32;
		public virtual RMethod RReadUShort_ByteArray_Int32
		{
			get
			{
				if(r_ReadUShort_ByteArray_Int32 == null)
				{
					r_ReadUShort_ByteArray_Int32 = new(this, "ReadUShort", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadUShort_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_ReadUShort_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Byte[], Int32)
		/// </summary>
		protected RMethod r_ReadInt_ByteArray_Int32;
		public virtual RMethod RReadInt_ByteArray_Int32
		{
			get
			{
				if(r_ReadInt_ByteArray_Int32 == null)
				{
					r_ReadInt_ByteArray_Int32 = new(this, "ReadInt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadInt_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_ReadInt_ByteArray_Int32;
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
		/// System.String GetSddlForm(System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_GetSddlForm_AccessControlSections;
		public virtual RMethod RGetSddlForm_AccessControlSections
		{
			get
			{
				if(r_GetSddlForm_AccessControlSections == null)
				{
					r_GetSddlForm_AccessControlSections = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.AccessControlSections));
					r_GetSddlForm_AccessControlSections.SetBelong(this.instance);
				}
				return r_GetSddlForm_AccessControlSections;
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


        public RRawSecurityDescriptor() : base("System.Security.AccessControl.RawSecurityDescriptor")
        {
        }

        public RRawSecurityDescriptor(System.Object instance) : base("System.Security.AccessControl.RawSecurityDescriptor")
		{
            SetInstance(instance);
		}

        public RRawSecurityDescriptor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRawSecurityDescriptor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetFlags(System.Security.AccessControl.ControlFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RSetFlags_ControlFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseSddl(System.String @sddlForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm};
            var ___result = RParseSddl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt16 ReadUShort(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RReadUShort_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 ReadInt(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RReadInt_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeSections};
            var ___result = RGetSddlForm_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
