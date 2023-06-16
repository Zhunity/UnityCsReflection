
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.AccessControl.RawSecurityDescriptor
	/// </summary>
    public partial class RRawSecurityDescriptor : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.AccessControl.RawSecurityDescriptor);
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


		/// <summary>
		/// System.Security.AccessControl.ControlFlags control_flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_Fcontrol_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFcontrol_flags
		{
			get
			{
				if(r_Fcontrol_flags == null)
				{
					r_Fcontrol_flags = new(this, "control_flags");
				}
				return r_Fcontrol_flags;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier owner_sid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_Fowner_sid;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RFowner_sid
		{
			get
			{
				if(r_Fowner_sid == null)
				{
					r_Fowner_sid = new(this, "owner_sid");
				}
				return r_Fowner_sid;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier group_sid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_Fgroup_sid;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RFgroup_sid
		{
			get
			{
				if(r_Fgroup_sid == null)
				{
					r_Fgroup_sid = new(this, "group_sid");
				}
				return r_Fgroup_sid;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl system_acl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl r_Fsystem_acl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl RFsystem_acl
		{
			get
			{
				if(r_Fsystem_acl == null)
				{
					r_Fsystem_acl = new(this, "system_acl");
				}
				return r_Fsystem_acl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl discretionary_acl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl r_Fdiscretionary_acl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl RFdiscretionary_acl
		{
			get
			{
				if(r_Fdiscretionary_acl == null)
				{
					r_Fdiscretionary_acl = new(this, "discretionary_acl");
				}
				return r_Fdiscretionary_acl;
			}
		}

		/// <summary>
		/// System.Byte resourcemgr_control
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fresourcemgr_control;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFresourcemgr_control
		{
			get
			{
				if(r_Fresourcemgr_control == null)
				{
					r_Fresourcemgr_control = new(this, "resourcemgr_control");
				}
				return r_Fresourcemgr_control;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags ControlFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_PControlFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RPControlFlags
		{
			get
			{
				if(r_PControlFlags == null)
				{
					r_PControlFlags = new(this, "ControlFlags", -1);
				}
				return r_PControlFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl DiscretionaryAcl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl r_PDiscretionaryAcl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl RPDiscretionaryAcl
		{
			get
			{
				if(r_PDiscretionaryAcl == null)
				{
					r_PDiscretionaryAcl = new(this, "DiscretionaryAcl", -1);
				}
				return r_PDiscretionaryAcl;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier Group
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_PGroup;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RPGroup
		{
			get
			{
				if(r_PGroup == null)
				{
					r_PGroup = new(this, "Group", -1);
				}
				return r_PGroup;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier Owner
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_POwner;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RPOwner
		{
			get
			{
				if(r_POwner == null)
				{
					r_POwner = new(this, "Owner", -1);
				}
				return r_POwner;
			}
		}

		/// <summary>
		/// Byte ResourceManagerControl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PResourceManagerControl;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPResourceManagerControl
		{
			get
			{
				if(r_PResourceManagerControl == null)
				{
					r_PResourceManagerControl = new(this, "ResourceManagerControl", -1);
				}
				return r_PResourceManagerControl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.RawAcl SystemAcl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl r_PSystemAcl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RRawAcl RPSystemAcl
		{
			get
			{
				if(r_PSystemAcl == null)
				{
					r_PSystemAcl = new(this, "SystemAcl", -1);
				}
				return r_PSystemAcl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAcl InternalDacl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl r_PInternalDacl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl RPInternalDacl
		{
			get
			{
				if(r_PInternalDacl == null)
				{
					r_PInternalDacl = new(this, "InternalDacl", -1);
				}
				return r_PInternalDacl;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAcl InternalSacl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl r_PInternalSacl;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAcl RPInternalSacl
		{
			get
			{
				if(r_PInternalSacl == null)
				{
					r_PInternalSacl = new(this, "InternalSacl", -1);
				}
				return r_PInternalSacl;
			}
		}

		/// <summary>
		/// Byte InternalReservedField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PInternalReservedField;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPInternalReservedField
		{
			get
			{
				if(r_PInternalReservedField == null)
				{
					r_PInternalReservedField = new(this, "InternalReservedField", -1);
				}
				return r_PInternalReservedField;
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
		/// Boolean DaclIsUnmodifiedAefa
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDaclIsUnmodifiedAefa;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDaclIsUnmodifiedAefa
		{
			get
			{
				if(r_PDaclIsUnmodifiedAefa == null)
				{
					r_PDaclIsUnmodifiedAefa = new(this, "DaclIsUnmodifiedAefa", -1);
				}
				return r_PDaclIsUnmodifiedAefa;
			}
		}

		/// <summary>
		/// Void SetFlags(System.Security.AccessControl.ControlFlags)
		/// </summary>
		protected RMethod r_MSetFlags_ControlFlags;
		public virtual RMethod RMSetFlags_ControlFlags
		{
			get
			{
				if(r_MSetFlags_ControlFlags == null)
				{
					r_MSetFlags_ControlFlags = new(this, "SetFlags", 0, typeof(System.Security.AccessControl.ControlFlags));
				}
				return r_MSetFlags_ControlFlags;
			}
		}

		/// <summary>
		/// Void ParseSddl(System.String)
		/// </summary>
		protected RMethod r_MParseSddl_String;
		public virtual RMethod RMParseSddl_String
		{
			get
			{
				if(r_MParseSddl_String == null)
				{
					r_MParseSddl_String = new(this, "ParseSddl", 0, typeof(System.String));
				}
				return r_MParseSddl_String;
			}
		}

		/// <summary>
		/// UInt16 ReadUShort(Byte[], Int32)
		/// </summary>
		protected RMethod r_MReadUShort_ByteArray_Int32;
		public virtual RMethod RMReadUShort_ByteArray_Int32
		{
			get
			{
				if(r_MReadUShort_ByteArray_Int32 == null)
				{
					r_MReadUShort_ByteArray_Int32 = new(this, "ReadUShort", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MReadUShort_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Byte[], Int32)
		/// </summary>
		protected RMethod r_MReadInt_ByteArray_Int32;
		public virtual RMethod RMReadInt_ByteArray_Int32
		{
			get
			{
				if(r_MReadInt_ByteArray_Int32 == null)
				{
					r_MReadInt_ByteArray_Int32 = new(this, "ReadInt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MReadInt_ByteArray_Int32;
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


        public virtual void SetFlags(System.Security.AccessControl.ControlFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMSetFlags_ControlFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseSddl(System.String @sddlForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm};
            var ___result = RMParseSddl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt16 ReadUShort(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RMReadUShort_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt16>(___result);
        }


        public virtual System.Int32 ReadInt(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RMReadInt_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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

            return ReflectionUtils.Convert<System.String>(___result);
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
