
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.ObjectAce
	/// </summary>
    public partial class RObjectAce : RMember //
    {

		/// <summary>
		/// System.Guid object_ace_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_Fobject_ace_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RFobject_ace_type
		{
			get
			{
				if(r_Fobject_ace_type == null)
				{
					r_Fobject_ace_type = new(this, "object_ace_type");
					r_Fobject_ace_type.SetBelong(this.instance);
				}
				return r_Fobject_ace_type;
			}
		}

		/// <summary>
		/// System.Guid inherited_object_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_Finherited_object_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RFinherited_object_type
		{
			get
			{
				if(r_Finherited_object_type == null)
				{
					r_Finherited_object_type = new(this, "inherited_object_type");
					r_Finherited_object_type.SetBelong(this.instance);
				}
				return r_Finherited_object_type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags object_ace_flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RObjectAceFlags r_Fobject_ace_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RObjectAceFlags RFobject_ace_flags
		{
			get
			{
				if(r_Fobject_ace_flags == null)
				{
					r_Fobject_ace_flags = new(this, "object_ace_flags");
					r_Fobject_ace_flags.SetBelong(this.instance);
				}
				return r_Fobject_ace_flags;
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
					r_PBinaryLength.SetBelong(this.instance);
				}
				return r_PBinaryLength;
			}
		}

		/// <summary>
		/// System.Guid InheritedObjectAceType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PInheritedObjectAceType;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPInheritedObjectAceType
		{
			get
			{
				if(r_PInheritedObjectAceType == null)
				{
					r_PInheritedObjectAceType = new(this, "InheritedObjectAceType", -1);
					r_PInheritedObjectAceType.SetBelong(this.instance);
				}
				return r_PInheritedObjectAceType;
			}
		}

		/// <summary>
		/// Boolean InheritedObjectAceTypePresent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PInheritedObjectAceTypePresent;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPInheritedObjectAceTypePresent
		{
			get
			{
				if(r_PInheritedObjectAceTypePresent == null)
				{
					r_PInheritedObjectAceTypePresent = new(this, "InheritedObjectAceTypePresent", -1);
					r_PInheritedObjectAceTypePresent.SetBelong(this.instance);
				}
				return r_PInheritedObjectAceTypePresent;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags ObjectAceFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RObjectAceFlags r_PObjectAceFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RObjectAceFlags RPObjectAceFlags
		{
			get
			{
				if(r_PObjectAceFlags == null)
				{
					r_PObjectAceFlags = new(this, "ObjectAceFlags", -1);
					r_PObjectAceFlags.SetBelong(this.instance);
				}
				return r_PObjectAceFlags;
			}
		}

		/// <summary>
		/// System.Guid ObjectAceType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PObjectAceType;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPObjectAceType
		{
			get
			{
				if(r_PObjectAceType == null)
				{
					r_PObjectAceType = new(this, "ObjectAceType", -1);
					r_PObjectAceType.SetBelong(this.instance);
				}
				return r_PObjectAceType;
			}
		}

		/// <summary>
		/// Boolean ObjectAceTypePresent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PObjectAceTypePresent;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPObjectAceTypePresent
		{
			get
			{
				if(r_PObjectAceTypePresent == null)
				{
					r_PObjectAceTypePresent = new(this, "ObjectAceTypePresent", -1);
					r_PObjectAceTypePresent.SetBelong(this.instance);
				}
				return r_PObjectAceTypePresent;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceQualifier AceQualifier
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceQualifier r_PAceQualifier;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceQualifier RPAceQualifier
		{
			get
			{
				if(r_PAceQualifier == null)
				{
					r_PAceQualifier = new(this, "AceQualifier", -1);
					r_PAceQualifier.SetBelong(this.instance);
				}
				return r_PAceQualifier;
			}
		}

		/// <summary>
		/// Boolean IsCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCallback
		{
			get
			{
				if(r_PIsCallback == null)
				{
					r_PIsCallback = new(this, "IsCallback", -1);
					r_PIsCallback.SetBelong(this.instance);
				}
				return r_PIsCallback;
			}
		}

		/// <summary>
		/// Int32 OpaqueLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_POpaqueLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPOpaqueLength
		{
			get
			{
				if(r_POpaqueLength == null)
				{
					r_POpaqueLength = new(this, "OpaqueLength", -1);
					r_POpaqueLength.SetBelong(this.instance);
				}
				return r_POpaqueLength;
			}
		}

		/// <summary>
		/// Int32 AccessMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PAccessMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPAccessMask
		{
			get
			{
				if(r_PAccessMask == null)
				{
					r_PAccessMask = new(this, "AccessMask", -1);
					r_PAccessMask.SetBelong(this.instance);
				}
				return r_PAccessMask;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier SecurityIdentifier
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_PSecurityIdentifier;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RPSecurityIdentifier
		{
			get
			{
				if(r_PSecurityIdentifier == null)
				{
					r_PSecurityIdentifier = new(this, "SecurityIdentifier", -1);
					r_PSecurityIdentifier.SetBelong(this.instance);
				}
				return r_PSecurityIdentifier;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceFlags AceFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceFlags r_PAceFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceFlags RPAceFlags
		{
			get
			{
				if(r_PAceFlags == null)
				{
					r_PAceFlags = new(this, "AceFlags", -1);
					r_PAceFlags.SetBelong(this.instance);
				}
				return r_PAceFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AceType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_PAceType;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RPAceType
		{
			get
			{
				if(r_PAceType == null)
				{
					r_PAceType = new(this, "AceType", -1);
					r_PAceType.SetBelong(this.instance);
				}
				return r_PAceType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditFlags AuditFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAuditFlags r_PAuditFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAuditFlags RPAuditFlags
		{
			get
			{
				if(r_PAuditFlags == null)
				{
					r_PAuditFlags = new(this, "AuditFlags", -1);
					r_PAuditFlags.SetBelong(this.instance);
				}
				return r_PAuditFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags InheritanceFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags r_PInheritanceFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags RPInheritanceFlags
		{
			get
			{
				if(r_PInheritanceFlags == null)
				{
					r_PInheritanceFlags = new(this, "InheritanceFlags", -1);
					r_PInheritanceFlags.SetBelong(this.instance);
				}
				return r_PInheritanceFlags;
			}
		}

		/// <summary>
		/// Boolean IsInherited
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsInherited;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsInherited
		{
			get
			{
				if(r_PIsInherited == null)
				{
					r_PIsInherited = new(this, "IsInherited", -1);
					r_PIsInherited.SetBelong(this.instance);
				}
				return r_PIsInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags PropagationFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags r_PPropagationFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags RPPropagationFlags
		{
			get
			{
				if(r_PPropagationFlags == null)
				{
					r_PPropagationFlags = new(this, "PropagationFlags", -1);
					r_PPropagationFlags.SetBelong(this.instance);
				}
				return r_PPropagationFlags;
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
		/// Int32 MaxOpaqueLength(Boolean)
		/// </summary>
		protected static RMethod r_MMaxOpaqueLength_Boolean;
		public static RMethod RMMaxOpaqueLength_Boolean
		{
			get
			{
				if(r_MMaxOpaqueLength_Boolean == null)
				{
					r_MMaxOpaqueLength_Boolean = new(typeof(System.Security.AccessControl.ObjectAce), "MaxOpaqueLength", 0, typeof(System.Boolean));
					r_MMaxOpaqueLength_Boolean.SetBelong(null);
				}
				return r_MMaxOpaqueLength_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSddlForm()
		/// </summary>
		protected RMethod r_MGetSddlForm;
		public virtual RMethod RMGetSddlForm
		{
			get
			{
				if(r_MGetSddlForm == null)
				{
					r_MGetSddlForm = new(this, "GetSddlForm", 0);
					r_MGetSddlForm.SetBelong(this.instance);
				}
				return r_MGetSddlForm;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType ConvertType(System.Security.AccessControl.AceQualifier, Boolean)
		/// </summary>
		protected static RMethod r_MConvertType_AceQualifier_Boolean;
		public static RMethod RMConvertType_AceQualifier_Boolean
		{
			get
			{
				if(r_MConvertType_AceQualifier_Boolean == null)
				{
					r_MConvertType_AceQualifier_Boolean = new(typeof(System.Security.AccessControl.ObjectAce), "ConvertType", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Boolean));
					r_MConvertType_AceQualifier_Boolean.SetBelong(null);
				}
				return r_MConvertType_AceQualifier_Boolean;
			}
		}

		/// <summary>
		/// Void WriteGuid(System.Guid, Byte[], Int32)
		/// </summary>
		protected RMethod r_MWriteGuid_Guid_ByteArray_Int32;
		public virtual RMethod RMWriteGuid_Guid_ByteArray_Int32
		{
			get
			{
				if(r_MWriteGuid_Guid_ByteArray_Int32 == null)
				{
					r_MWriteGuid_Guid_ByteArray_Int32 = new(this, "WriteGuid", 0, typeof(System.Guid), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MWriteGuid_Guid_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MWriteGuid_Guid_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.Guid ReadGuid(Byte[], Int32)
		/// </summary>
		protected RMethod r_MReadGuid_ByteArray_Int32;
		public virtual RMethod RMReadGuid_ByteArray_Int32
		{
			get
			{
				if(r_MReadGuid_ByteArray_Int32 == null)
				{
					r_MReadGuid_ByteArray_Int32 = new(this, "ReadGuid", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MReadGuid_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MReadGuid_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetOpaque()
		/// </summary>
		protected RMethod r_MGetOpaque;
		public virtual RMethod RMGetOpaque
		{
			get
			{
				if(r_MGetOpaque == null)
				{
					r_MGetOpaque = new(this, "GetOpaque", 0);
					r_MGetOpaque.SetBelong(this.instance);
				}
				return r_MGetOpaque;
			}
		}

		/// <summary>
		/// Void SetOpaque(Byte[])
		/// </summary>
		protected RMethod r_MSetOpaque_ByteArray;
		public virtual RMethod RMSetOpaque_ByteArray
		{
			get
			{
				if(r_MSetOpaque_ByteArray == null)
				{
					r_MSetOpaque_ByteArray = new(this, "SetOpaque", 0, typeof(System.Byte).MakeArrayType());
					r_MSetOpaque_ByteArray.SetBelong(this.instance);
				}
				return r_MSetOpaque_ByteArray;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.instance);
				}
				return r_MCopy;
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


        public RObjectAce() : base("System.Security.AccessControl.ObjectAce")
        {
        }

        public RObjectAce(System.Object instance) : base("System.Security.AccessControl.ObjectAce")
		{
            SetInstance(instance);
		}

        public RObjectAce(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObjectAce(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 MaxOpaqueLength(System.Boolean @isCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isCallback};
            var ___result = RMMaxOpaqueLength_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.AceType ConvertType(System.Security.AccessControl.AceQualifier @qualifier, System.Boolean @isCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qualifier, @isCallback};
            var ___result = RMConvertType_AceQualifier_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceType)___result;
        }


        public virtual void WriteGuid(System.Guid @val, System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RMWriteGuid_Guid_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Guid ReadGuid(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RMReadGuid_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public virtual System.Byte[] GetOpaque()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOpaque.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void SetOpaque(System.Byte[] @opaque)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opaque};
            var ___result = RMSetOpaque_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.GenericAce Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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
