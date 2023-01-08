using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.GenericAce
	/// </summary>
    public partial class RGenericAce : RMember //
    {

		/// <summary>
		/// System.Security.AccessControl.AceFlags ace_flags
		/// </summary>
		protected RField r_ace_flags;
		public virtual RField Race_flags
		{
			get
			{
				if(r_ace_flags == null)
				{
					r_ace_flags = new(this, "ace_flags");
					r_ace_flags.SetBelong(this.instance);
				}
				return r_ace_flags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType ace_type
		/// </summary>
		protected RField r_ace_type;
		public virtual RField Race_type
		{
			get
			{
				if(r_ace_type == null)
				{
					r_ace_type = new(this, "ace_type");
					r_ace_type.SetBelong(this.instance);
				}
				return r_ace_type;
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
		/// System.Security.AccessControl.GenericAce CreateFromBinaryForm(Byte[], Int32)
		/// </summary>
		protected static RMethod r_CreateFromBinaryForm_ByteArray_Int32;
		public static RMethod RCreateFromBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_CreateFromBinaryForm_ByteArray_Int32 == null)
				{
					r_CreateFromBinaryForm_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "CreateFromBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_CreateFromBinaryForm_ByteArray_Int32.SetBelong(null);
				}
				return r_CreateFromBinaryForm_ByteArray_Int32;
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
		/// Boolean op_Equality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected static RMethod r_op_Equality_GenericAce_GenericAce;
		public static RMethod Rop_Equality_GenericAce_GenericAce
		{
			get
			{
				if(r_op_Equality_GenericAce_GenericAce == null)
				{
					r_op_Equality_GenericAce_GenericAce = new(typeof(System.Security.AccessControl.GenericAce), "op_Equality", 0, typeof(System.Security.AccessControl.GenericAce), typeof(System.Security.AccessControl.GenericAce));
					r_op_Equality_GenericAce_GenericAce.SetBelong(null);
				}
				return r_op_Equality_GenericAce_GenericAce;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected static RMethod r_op_Inequality_GenericAce_GenericAce;
		public static RMethod Rop_Inequality_GenericAce_GenericAce
		{
			get
			{
				if(r_op_Inequality_GenericAce_GenericAce == null)
				{
					r_op_Inequality_GenericAce_GenericAce = new(typeof(System.Security.AccessControl.GenericAce), "op_Inequality", 0, typeof(System.Security.AccessControl.GenericAce), typeof(System.Security.AccessControl.GenericAce));
					r_op_Inequality_GenericAce_GenericAce.SetBelong(null);
				}
				return r_op_Inequality_GenericAce_GenericAce;
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
		/// System.Security.AccessControl.GenericAce CreateFromSddlForm(System.String, Int32 ByRef)
		/// </summary>
		protected static RMethod r_CreateFromSddlForm_String_Ref_Int32;
		public static RMethod RCreateFromSddlForm_String_Ref_Int32
		{
			get
			{
				if(r_CreateFromSddlForm_String_Ref_Int32 == null)
				{
					r_CreateFromSddlForm_String_Ref_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "CreateFromSddlForm", 0, typeof(System.String), typeof(System.Int32).MakeByRefType());
					r_CreateFromSddlForm_String_Ref_Int32.SetBelong(null);
				}
				return r_CreateFromSddlForm_String_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean IsObjectType(System.Security.AccessControl.AceType)
		/// </summary>
		protected static RMethod r_IsObjectType_AceType;
		public static RMethod RIsObjectType_AceType
		{
			get
			{
				if(r_IsObjectType_AceType == null)
				{
					r_IsObjectType_AceType = new(typeof(System.Security.AccessControl.GenericAce), "IsObjectType", 0, typeof(System.Security.AccessControl.AceType));
					r_IsObjectType_AceType.SetBelong(null);
				}
				return r_IsObjectType_AceType;
			}
		}

		/// <summary>
		/// System.String GetSddlAceType(System.Security.AccessControl.AceType)
		/// </summary>
		protected static RMethod r_GetSddlAceType_AceType;
		public static RMethod RGetSddlAceType_AceType
		{
			get
			{
				if(r_GetSddlAceType_AceType == null)
				{
					r_GetSddlAceType_AceType = new(typeof(System.Security.AccessControl.GenericAce), "GetSddlAceType", 0, typeof(System.Security.AccessControl.AceType));
					r_GetSddlAceType_AceType.SetBelong(null);
				}
				return r_GetSddlAceType_AceType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType ParseSddlAceType(System.String)
		/// </summary>
		protected static RMethod r_ParseSddlAceType_String;
		public static RMethod RParseSddlAceType_String
		{
			get
			{
				if(r_ParseSddlAceType_String == null)
				{
					r_ParseSddlAceType_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAceType", 0, typeof(System.String));
					r_ParseSddlAceType_String.SetBelong(null);
				}
				return r_ParseSddlAceType_String;
			}
		}

		/// <summary>
		/// System.String GetSddlAceFlags(System.Security.AccessControl.AceFlags)
		/// </summary>
		protected static RMethod r_GetSddlAceFlags_AceFlags;
		public static RMethod RGetSddlAceFlags_AceFlags
		{
			get
			{
				if(r_GetSddlAceFlags_AceFlags == null)
				{
					r_GetSddlAceFlags_AceFlags = new(typeof(System.Security.AccessControl.GenericAce), "GetSddlAceFlags", 0, typeof(System.Security.AccessControl.AceFlags));
					r_GetSddlAceFlags_AceFlags.SetBelong(null);
				}
				return r_GetSddlAceFlags_AceFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceFlags ParseSddlAceFlags(System.String)
		/// </summary>
		protected static RMethod r_ParseSddlAceFlags_String;
		public static RMethod RParseSddlAceFlags_String
		{
			get
			{
				if(r_ParseSddlAceFlags_String == null)
				{
					r_ParseSddlAceFlags_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAceFlags", 0, typeof(System.String));
					r_ParseSddlAceFlags_String.SetBelong(null);
				}
				return r_ParseSddlAceFlags_String;
			}
		}

		/// <summary>
		/// Int32 ParseSddlAccessRights(System.String)
		/// </summary>
		protected static RMethod r_ParseSddlAccessRights_String;
		public static RMethod RParseSddlAccessRights_String
		{
			get
			{
				if(r_ParseSddlAccessRights_String == null)
				{
					r_ParseSddlAccessRights_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAccessRights", 0, typeof(System.String));
					r_ParseSddlAccessRights_String.SetBelong(null);
				}
				return r_ParseSddlAccessRights_String;
			}
		}

		/// <summary>
		/// Int32 ParseSddlAliasRights(System.String)
		/// </summary>
		protected static RMethod r_ParseSddlAliasRights_String;
		public static RMethod RParseSddlAliasRights_String
		{
			get
			{
				if(r_ParseSddlAliasRights_String == null)
				{
					r_ParseSddlAliasRights_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAliasRights", 0, typeof(System.String));
					r_ParseSddlAliasRights_String.SetBelong(null);
				}
				return r_ParseSddlAliasRights_String;
			}
		}

		/// <summary>
		/// UInt16 ReadUShort(Byte[], Int32)
		/// </summary>
		protected static RMethod r_ReadUShort_ByteArray_Int32;
		public static RMethod RReadUShort_ByteArray_Int32
		{
			get
			{
				if(r_ReadUShort_ByteArray_Int32 == null)
				{
					r_ReadUShort_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "ReadUShort", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadUShort_ByteArray_Int32.SetBelong(null);
				}
				return r_ReadUShort_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Byte[], Int32)
		/// </summary>
		protected static RMethod r_ReadInt_ByteArray_Int32;
		public static RMethod RReadInt_ByteArray_Int32
		{
			get
			{
				if(r_ReadInt_ByteArray_Int32 == null)
				{
					r_ReadInt_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "ReadInt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_ReadInt_ByteArray_Int32.SetBelong(null);
				}
				return r_ReadInt_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void WriteInt(Int32, Byte[], Int32)
		/// </summary>
		protected static RMethod r_WriteInt_Int32_ByteArray_Int32;
		public static RMethod RWriteInt_Int32_ByteArray_Int32
		{
			get
			{
				if(r_WriteInt_Int32_ByteArray_Int32 == null)
				{
					r_WriteInt_Int32_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "WriteInt", 0, typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_WriteInt_Int32_ByteArray_Int32.SetBelong(null);
				}
				return r_WriteInt_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void WriteUShort(UInt16, Byte[], Int32)
		/// </summary>
		protected static RMethod r_WriteUShort_UInt16_ByteArray_Int32;
		public static RMethod RWriteUShort_UInt16_ByteArray_Int32
		{
			get
			{
				if(r_WriteUShort_UInt16_ByteArray_Int32 == null)
				{
					r_WriteUShort_UInt16_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "WriteUShort", 0, typeof(System.UInt16), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_WriteUShort_UInt16_ByteArray_Int32.SetBelong(null);
				}
				return r_WriteUShort_UInt16_ByteArray_Int32;
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


        public RGenericAce() : base("System.Security.AccessControl.GenericAce")
        {
        }

        public RGenericAce(System.Object instance) : base("System.Security.AccessControl.GenericAce")
		{
            SetInstance(instance);
		}

        public RGenericAce(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGenericAce(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.AccessControl.GenericAce Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public static System.Security.AccessControl.GenericAce CreateFromBinaryForm(System.Byte[]  @binaryForm, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RCreateFromBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetBinaryForm(System.Byte[]  @binaryForm, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Security.AccessControl.GenericAce  @left, System.Security.AccessControl.GenericAce  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_GenericAce_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.AccessControl.GenericAce  @left, System.Security.AccessControl.GenericAce  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_GenericAce_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.GenericAce CreateFromSddlForm(System.String  @sddlForm, ref System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @pos};
            var ___result = RCreateFromSddlForm_String_Ref_Int32.Invoke(___genericsType, ___parameters);
			pos = (System.Int32)___parameters[1];

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public static System.Boolean IsObjectType(System.Security.AccessControl.AceType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsObjectType_AceType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetSddlAceType(System.Security.AccessControl.AceType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetSddlAceType_AceType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.AceType ParseSddlAceType(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RParseSddlAceType_String.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceType)___result;
        }


        public static System.String GetSddlAceFlags(System.Security.AccessControl.AceFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RGetSddlAceFlags_AceFlags.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.AceFlags ParseSddlAceFlags(System.String  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RParseSddlAceFlags_String.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceFlags)___result;
        }


        public static System.Int32 ParseSddlAccessRights(System.String  @accessMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessMask};
            var ___result = RParseSddlAccessRights_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ParseSddlAliasRights(System.String  @accessMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessMask};
            var ___result = RParseSddlAliasRights_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.UInt16 ReadUShort(System.Byte[]  @buffer, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RReadUShort_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public static System.Int32 ReadInt(System.Byte[]  @buffer, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RReadInt_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void WriteInt(System.Int32  @val, System.Byte[]  @buffer, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RWriteInt_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void WriteUShort(System.UInt16  @val, System.Byte[]  @buffer, System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RWriteUShort_UInt16_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
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
