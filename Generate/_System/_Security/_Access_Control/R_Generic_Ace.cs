
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.GenericAce
	/// </summary>
    public partial class RGenericAce : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.AccessControl.GenericAce);
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


		/// <summary>
		/// System.Security.AccessControl.AceFlags ace_flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceFlags r_Face_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceFlags RFace_flags
		{
			get
			{
				if(r_Face_flags == null)
				{
					r_Face_flags = new(this, "ace_flags");
				}
				return r_Face_flags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType ace_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_Face_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFace_type
		{
			get
			{
				if(r_Face_type == null)
				{
					r_Face_type = new(this, "ace_type");
				}
				return r_Face_type;
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
				}
				return r_PAuditFlags;
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
				}
				return r_PPropagationFlags;
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
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce CreateFromBinaryForm(Byte[], Int32)
		/// </summary>
		protected static RMethod r_MCreateFromBinaryForm_ByteArray_Int32;
		public static RMethod RMCreateFromBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_MCreateFromBinaryForm_ByteArray_Int32 == null)
				{
					r_MCreateFromBinaryForm_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "CreateFromBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCreateFromBinaryForm_ByteArray_Int32;
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
		/// Boolean op_Equality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected static RMethod r_Mop_Equality_GenericAce_GenericAce;
		public static RMethod RMop_Equality_GenericAce_GenericAce
		{
			get
			{
				if(r_Mop_Equality_GenericAce_GenericAce == null)
				{
					r_Mop_Equality_GenericAce_GenericAce = new(typeof(System.Security.AccessControl.GenericAce), "op_Equality", 0, typeof(System.Security.AccessControl.GenericAce), typeof(System.Security.AccessControl.GenericAce));
				}
				return r_Mop_Equality_GenericAce_GenericAce;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GenericAce_GenericAce;
		public static RMethod RMop_Inequality_GenericAce_GenericAce
		{
			get
			{
				if(r_Mop_Inequality_GenericAce_GenericAce == null)
				{
					r_Mop_Inequality_GenericAce_GenericAce = new(typeof(System.Security.AccessControl.GenericAce), "op_Inequality", 0, typeof(System.Security.AccessControl.GenericAce), typeof(System.Security.AccessControl.GenericAce));
				}
				return r_Mop_Inequality_GenericAce_GenericAce;
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
				}
				return r_MGetSddlForm;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce CreateFromSddlForm(System.String, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MCreateFromSddlForm_String_Ref_Int32;
		public static RMethod RMCreateFromSddlForm_String_Ref_Int32
		{
			get
			{
				if(r_MCreateFromSddlForm_String_Ref_Int32 == null)
				{
					r_MCreateFromSddlForm_String_Ref_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "CreateFromSddlForm", 0, typeof(System.String), typeof(System.Int32).MakeByRefType());
				}
				return r_MCreateFromSddlForm_String_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean IsObjectType(System.Security.AccessControl.AceType)
		/// </summary>
		protected static RMethod r_MIsObjectType_AceType;
		public static RMethod RMIsObjectType_AceType
		{
			get
			{
				if(r_MIsObjectType_AceType == null)
				{
					r_MIsObjectType_AceType = new(typeof(System.Security.AccessControl.GenericAce), "IsObjectType", 0, typeof(System.Security.AccessControl.AceType));
				}
				return r_MIsObjectType_AceType;
			}
		}

		/// <summary>
		/// System.String GetSddlAceType(System.Security.AccessControl.AceType)
		/// </summary>
		protected static RMethod r_MGetSddlAceType_AceType;
		public static RMethod RMGetSddlAceType_AceType
		{
			get
			{
				if(r_MGetSddlAceType_AceType == null)
				{
					r_MGetSddlAceType_AceType = new(typeof(System.Security.AccessControl.GenericAce), "GetSddlAceType", 0, typeof(System.Security.AccessControl.AceType));
				}
				return r_MGetSddlAceType_AceType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType ParseSddlAceType(System.String)
		/// </summary>
		protected static RMethod r_MParseSddlAceType_String;
		public static RMethod RMParseSddlAceType_String
		{
			get
			{
				if(r_MParseSddlAceType_String == null)
				{
					r_MParseSddlAceType_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAceType", 0, typeof(System.String));
				}
				return r_MParseSddlAceType_String;
			}
		}

		/// <summary>
		/// System.String GetSddlAceFlags(System.Security.AccessControl.AceFlags)
		/// </summary>
		protected static RMethod r_MGetSddlAceFlags_AceFlags;
		public static RMethod RMGetSddlAceFlags_AceFlags
		{
			get
			{
				if(r_MGetSddlAceFlags_AceFlags == null)
				{
					r_MGetSddlAceFlags_AceFlags = new(typeof(System.Security.AccessControl.GenericAce), "GetSddlAceFlags", 0, typeof(System.Security.AccessControl.AceFlags));
				}
				return r_MGetSddlAceFlags_AceFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceFlags ParseSddlAceFlags(System.String)
		/// </summary>
		protected static RMethod r_MParseSddlAceFlags_String;
		public static RMethod RMParseSddlAceFlags_String
		{
			get
			{
				if(r_MParseSddlAceFlags_String == null)
				{
					r_MParseSddlAceFlags_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAceFlags", 0, typeof(System.String));
				}
				return r_MParseSddlAceFlags_String;
			}
		}

		/// <summary>
		/// Int32 ParseSddlAccessRights(System.String)
		/// </summary>
		protected static RMethod r_MParseSddlAccessRights_String;
		public static RMethod RMParseSddlAccessRights_String
		{
			get
			{
				if(r_MParseSddlAccessRights_String == null)
				{
					r_MParseSddlAccessRights_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAccessRights", 0, typeof(System.String));
				}
				return r_MParseSddlAccessRights_String;
			}
		}

		/// <summary>
		/// Int32 ParseSddlAliasRights(System.String)
		/// </summary>
		protected static RMethod r_MParseSddlAliasRights_String;
		public static RMethod RMParseSddlAliasRights_String
		{
			get
			{
				if(r_MParseSddlAliasRights_String == null)
				{
					r_MParseSddlAliasRights_String = new(typeof(System.Security.AccessControl.GenericAce), "ParseSddlAliasRights", 0, typeof(System.String));
				}
				return r_MParseSddlAliasRights_String;
			}
		}

		/// <summary>
		/// UInt16 ReadUShort(Byte[], Int32)
		/// </summary>
		protected static RMethod r_MReadUShort_ByteArray_Int32;
		public static RMethod RMReadUShort_ByteArray_Int32
		{
			get
			{
				if(r_MReadUShort_ByteArray_Int32 == null)
				{
					r_MReadUShort_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "ReadUShort", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MReadUShort_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Byte[], Int32)
		/// </summary>
		protected static RMethod r_MReadInt_ByteArray_Int32;
		public static RMethod RMReadInt_ByteArray_Int32
		{
			get
			{
				if(r_MReadInt_ByteArray_Int32 == null)
				{
					r_MReadInt_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "ReadInt", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MReadInt_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void WriteInt(Int32, Byte[], Int32)
		/// </summary>
		protected static RMethod r_MWriteInt_Int32_ByteArray_Int32;
		public static RMethod RMWriteInt_Int32_ByteArray_Int32
		{
			get
			{
				if(r_MWriteInt_Int32_ByteArray_Int32 == null)
				{
					r_MWriteInt_Int32_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "WriteInt", 0, typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MWriteInt_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void WriteUShort(UInt16, Byte[], Int32)
		/// </summary>
		protected static RMethod r_MWriteUShort_UInt16_ByteArray_Int32;
		public static RMethod RMWriteUShort_UInt16_ByteArray_Int32
		{
			get
			{
				if(r_MWriteUShort_UInt16_ByteArray_Int32 == null)
				{
					r_MWriteUShort_UInt16_ByteArray_Int32 = new(typeof(System.Security.AccessControl.GenericAce), "WriteUShort", 0, typeof(System.UInt16), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
				}
				return r_MWriteUShort_UInt16_ByteArray_Int32;
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


        public virtual System.Security.AccessControl.GenericAce Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public static System.Security.AccessControl.GenericAce CreateFromBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMCreateFromBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Security.AccessControl.GenericAce @left, System.Security.AccessControl.GenericAce @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_GenericAce_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.AccessControl.GenericAce @left, System.Security.AccessControl.GenericAce @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_GenericAce_GenericAce.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.GenericAce CreateFromSddlForm(System.String @sddlForm, ref System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @pos};
            var ___result = RMCreateFromSddlForm_String_Ref_Int32.Invoke(___genericsType, ___parameters);
			@pos = (System.Int32)___parameters[1];

            return (System.Security.AccessControl.GenericAce)___result;
        }


        public static System.Boolean IsObjectType(System.Security.AccessControl.AceType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMIsObjectType_AceType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetSddlAceType(System.Security.AccessControl.AceType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetSddlAceType_AceType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.AceType ParseSddlAceType(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMParseSddlAceType_String.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceType)___result;
        }


        public static System.String GetSddlAceFlags(System.Security.AccessControl.AceFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMGetSddlAceFlags_AceFlags.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.AceFlags ParseSddlAceFlags(System.String @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMParseSddlAceFlags_String.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceFlags)___result;
        }


        public static System.Int32 ParseSddlAccessRights(System.String @accessMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessMask};
            var ___result = RMParseSddlAccessRights_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ParseSddlAliasRights(System.String @accessMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accessMask};
            var ___result = RMParseSddlAliasRights_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.UInt16 ReadUShort(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RMReadUShort_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public static System.Int32 ReadInt(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RMReadInt_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void WriteInt(System.Int32 @val, System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RMWriteInt_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void WriteUShort(System.UInt16 @val, System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RMWriteUShort_UInt16_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
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
