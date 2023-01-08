using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.ObjectAce
	/// </summary>
    public partial class RObjectAce : RMember //
    {

		/// <summary>
		/// System.Guid object_ace_type
		/// </summary>
		protected RSystem.RGuid r_object_ace_type;
		public virtual RSystem.RGuid Robject_ace_type
		{
			get
			{
				if(r_object_ace_type == null)
				{
					r_object_ace_type = new(this, "object_ace_type");
					r_object_ace_type.SetBelong(this.instance);
				}
				return r_object_ace_type;
			}
		}

		/// <summary>
		/// System.Guid inherited_object_type
		/// </summary>
		protected RSystem.RGuid r_inherited_object_type;
		public virtual RSystem.RGuid Rinherited_object_type
		{
			get
			{
				if(r_inherited_object_type == null)
				{
					r_inherited_object_type = new(this, "inherited_object_type");
					r_inherited_object_type.SetBelong(this.instance);
				}
				return r_inherited_object_type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags object_ace_flags
		/// </summary>
		protected RField r_object_ace_flags;
		public virtual RField Robject_ace_flags
		{
			get
			{
				if(r_object_ace_flags == null)
				{
					r_object_ace_flags = new(this, "object_ace_flags");
					r_object_ace_flags.SetBelong(this.instance);
				}
				return r_object_ace_flags;
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
		/// System.Guid InheritedObjectAceType
		/// </summary>
		protected RSystem.RGuid r_InheritedObjectAceType;
		public virtual RSystem.RGuid RInheritedObjectAceType
		{
			get
			{
				if(r_InheritedObjectAceType == null)
				{
					r_InheritedObjectAceType = new(this, "InheritedObjectAceType", -1);
					r_InheritedObjectAceType.SetBelong(this.instance);
				}
				return r_InheritedObjectAceType;
			}
		}

		/// <summary>
		/// Boolean InheritedObjectAceTypePresent
		/// </summary>
		protected RProperty r_InheritedObjectAceTypePresent;
		public virtual RProperty RInheritedObjectAceTypePresent
		{
			get
			{
				if(r_InheritedObjectAceTypePresent == null)
				{
					r_InheritedObjectAceTypePresent = new(this, "InheritedObjectAceTypePresent", -1);
					r_InheritedObjectAceTypePresent.SetBelong(this.instance);
				}
				return r_InheritedObjectAceTypePresent;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags ObjectAceFlags
		/// </summary>
		protected RProperty r_ObjectAceFlags;
		public virtual RProperty RObjectAceFlags
		{
			get
			{
				if(r_ObjectAceFlags == null)
				{
					r_ObjectAceFlags = new(this, "ObjectAceFlags", -1);
					r_ObjectAceFlags.SetBelong(this.instance);
				}
				return r_ObjectAceFlags;
			}
		}

		/// <summary>
		/// System.Guid ObjectAceType
		/// </summary>
		protected RSystem.RGuid r_ObjectAceType;
		public virtual RSystem.RGuid RObjectAceType
		{
			get
			{
				if(r_ObjectAceType == null)
				{
					r_ObjectAceType = new(this, "ObjectAceType", -1);
					r_ObjectAceType.SetBelong(this.instance);
				}
				return r_ObjectAceType;
			}
		}

		/// <summary>
		/// Boolean ObjectAceTypePresent
		/// </summary>
		protected RProperty r_ObjectAceTypePresent;
		public virtual RProperty RObjectAceTypePresent
		{
			get
			{
				if(r_ObjectAceTypePresent == null)
				{
					r_ObjectAceTypePresent = new(this, "ObjectAceTypePresent", -1);
					r_ObjectAceTypePresent.SetBelong(this.instance);
				}
				return r_ObjectAceTypePresent;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceQualifier AceQualifier
		/// </summary>
		protected RProperty r_AceQualifier;
		public virtual RProperty RAceQualifier
		{
			get
			{
				if(r_AceQualifier == null)
				{
					r_AceQualifier = new(this, "AceQualifier", -1);
					r_AceQualifier.SetBelong(this.instance);
				}
				return r_AceQualifier;
			}
		}

		/// <summary>
		/// Boolean IsCallback
		/// </summary>
		protected RProperty r_IsCallback;
		public virtual RProperty RIsCallback
		{
			get
			{
				if(r_IsCallback == null)
				{
					r_IsCallback = new(this, "IsCallback", -1);
					r_IsCallback.SetBelong(this.instance);
				}
				return r_IsCallback;
			}
		}

		/// <summary>
		/// Int32 OpaqueLength
		/// </summary>
		protected RProperty r_OpaqueLength;
		public virtual RProperty ROpaqueLength
		{
			get
			{
				if(r_OpaqueLength == null)
				{
					r_OpaqueLength = new(this, "OpaqueLength", -1);
					r_OpaqueLength.SetBelong(this.instance);
				}
				return r_OpaqueLength;
			}
		}

		/// <summary>
		/// Int32 AccessMask
		/// </summary>
		protected RProperty r_AccessMask;
		public virtual RProperty RAccessMask
		{
			get
			{
				if(r_AccessMask == null)
				{
					r_AccessMask = new(this, "AccessMask", -1);
					r_AccessMask.SetBelong(this.instance);
				}
				return r_AccessMask;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier SecurityIdentifier
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_SecurityIdentifier;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier RSecurityIdentifier
		{
			get
			{
				if(r_SecurityIdentifier == null)
				{
					r_SecurityIdentifier = new(this, "SecurityIdentifier", -1);
					r_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_SecurityIdentifier;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceFlags AceFlags
		/// </summary>
		protected RProperty r_AceFlags;
		public virtual RProperty RAceFlags
		{
			get
			{
				if(r_AceFlags == null)
				{
					r_AceFlags = new(this, "AceFlags", -1);
					r_AceFlags.SetBelong(this.instance);
				}
				return r_AceFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AceType
		/// </summary>
		protected RProperty r_AceType;
		public virtual RProperty RAceType
		{
			get
			{
				if(r_AceType == null)
				{
					r_AceType = new(this, "AceType", -1);
					r_AceType.SetBelong(this.instance);
				}
				return r_AceType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditFlags AuditFlags
		/// </summary>
		protected RProperty r_AuditFlags;
		public virtual RProperty RAuditFlags
		{
			get
			{
				if(r_AuditFlags == null)
				{
					r_AuditFlags = new(this, "AuditFlags", -1);
					r_AuditFlags.SetBelong(this.instance);
				}
				return r_AuditFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags InheritanceFlags
		/// </summary>
		protected RProperty r_InheritanceFlags;
		public virtual RProperty RInheritanceFlags
		{
			get
			{
				if(r_InheritanceFlags == null)
				{
					r_InheritanceFlags = new(this, "InheritanceFlags", -1);
					r_InheritanceFlags.SetBelong(this.instance);
				}
				return r_InheritanceFlags;
			}
		}

		/// <summary>
		/// Boolean IsInherited
		/// </summary>
		protected RProperty r_IsInherited;
		public virtual RProperty RIsInherited
		{
			get
			{
				if(r_IsInherited == null)
				{
					r_IsInherited = new(this, "IsInherited", -1);
					r_IsInherited.SetBelong(this.instance);
				}
				return r_IsInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags PropagationFlags
		/// </summary>
		protected RProperty r_PropagationFlags;
		public virtual RProperty RPropagationFlags
		{
			get
			{
				if(r_PropagationFlags == null)
				{
					r_PropagationFlags = new(this, "PropagationFlags", -1);
					r_PropagationFlags.SetBelong(this.instance);
				}
				return r_PropagationFlags;
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
		/// Int32 MaxOpaqueLength(Boolean)
		/// </summary>
		protected static RMethod r_MaxOpaqueLength_Boolean;
		public static RMethod RMaxOpaqueLength_Boolean
		{
			get
			{
				if(r_MaxOpaqueLength_Boolean == null)
				{
					r_MaxOpaqueLength_Boolean = new(typeof(System.Security.AccessControl.ObjectAce), "MaxOpaqueLength", 0, typeof(System.Boolean));
					r_MaxOpaqueLength_Boolean.SetBelong(null);
				}
				return r_MaxOpaqueLength_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSddlForm()
		/// </summary>
		protected RMethod r_GetSddlForm;
		public virtual RMethod RGetSddlForm
		{
			get
			{
				if(r_GetSddlForm == null)
				{
					r_GetSddlForm = new(this, "GetSddlForm", 0);
					r_GetSddlForm.SetBelong(this.instance);
				}
				return r_GetSddlForm;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType ConvertType(System.Security.AccessControl.AceQualifier, Boolean)
		/// </summary>
		protected static RMethod r_ConvertType_AceQualifier_Boolean;
		public static RMethod RConvertType_AceQualifier_Boolean
		{
			get
			{
				if(r_ConvertType_AceQualifier_Boolean == null)
				{
					r_ConvertType_AceQualifier_Boolean = new(typeof(System.Security.AccessControl.ObjectAce), "ConvertType", 0, typeof(System.Security.AccessControl.AceQualifier), typeof(System.Boolean));
					r_ConvertType_AceQualifier_Boolean.SetBelong(null);
				}
				return r_ConvertType_AceQualifier_Boolean;
			}
		}

		/// <summary>
		/// Void WriteGuid(System.Guid, Byte[], Int32)
		/// </summary>
		protected RMethod r_WriteGuid_Guid_ByteArray_Int32;
		public virtual RMethod RWriteGuid_Guid_ByteArray_Int32
		{
			get
			{
				if(r_WriteGuid_Guid_ByteArray_Int32 == null)
				{
					r_WriteGuid_Guid_ByteArray_Int32 = new(this, "WriteGuid", 0, typeof(System.Guid), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_WriteGuid_Guid_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_WriteGuid_Guid_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.Guid ReadGuid(Byte[], Int32)
		/// </summary>
		protected RMethod r_ReadGuid_ByteArray_Int32;
		public virtual RMethod RReadGuid_ByteArray_Int32
		{
			get
			{
				if(r_ReadGuid_ByteArray_Int32 == null)
				{
					r_ReadGuid_ByteArray_Int32 = new(this, "ReadGuid", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadGuid_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_ReadGuid_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetOpaque()
		/// </summary>
		protected RMethod r_GetOpaque;
		public virtual RMethod RGetOpaque
		{
			get
			{
				if(r_GetOpaque == null)
				{
					r_GetOpaque = new(this, "GetOpaque", 0);
					r_GetOpaque.SetBelong(this.instance);
				}
				return r_GetOpaque;
			}
		}

		/// <summary>
		/// Void SetOpaque(Byte[])
		/// </summary>
		protected RMethod r_SetOpaque_ByteArray;
		public virtual RMethod RSetOpaque_ByteArray
		{
			get
			{
				if(r_SetOpaque_ByteArray == null)
				{
					r_SetOpaque_ByteArray = new(this, "SetOpaque", 0, typeof(System.Byte).MakeArrayType());
					r_SetOpaque_ByteArray.SetBelong(this.instance);
				}
				return r_SetOpaque_ByteArray;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Copy()
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
            var ___result = RGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 MaxOpaqueLength(System.Boolean @isCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isCallback};
            var ___result = RMaxOpaqueLength_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.AceType ConvertType(System.Security.AccessControl.AceQualifier @qualifier, System.Boolean @isCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qualifier, @isCallback};
            var ___result = RConvertType_AceQualifier_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceType)___result;
        }


        public virtual void WriteGuid(System.Guid @val, System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RWriteGuid_Guid_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Guid ReadGuid(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RReadGuid_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public virtual System.Byte[] GetOpaque()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOpaque.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void SetOpaque(System.Byte[] @opaque)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opaque};
            var ___result = RSetOpaque_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.GenericAce Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
