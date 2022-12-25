using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.SecurityIdentifier
	/// </summary>
    public partial class RSecurityIdentifier : RMember //
    {

		/// <summary>
		/// System.Byte[] buffer
		/// </summary>
		protected RFieldArray<RField> r_buffer;
		public virtual RFieldArray<RField> Rbuffer
		{
			get
			{
				if(r_buffer == null)
				{
					r_buffer = new(this, "buffer");
					r_buffer.SetBelong(this.instance);
				}
				return r_buffer;
			}
		}

		/// <summary>
		/// System.Int32 MaxBinaryLength
		/// </summary>
		protected static RField r_MaxBinaryLength;
		public static RField RMaxBinaryLength
		{
			get
			{
				if(r_MaxBinaryLength == null)
				{
					r_MaxBinaryLength = new(typeof(System.Security.Principal.SecurityIdentifier), "MaxBinaryLength");
					r_MaxBinaryLength.SetBelong(null);
				}
				return r_MaxBinaryLength;
			}
		}

		/// <summary>
		/// System.Int32 MinBinaryLength
		/// </summary>
		protected static RField r_MinBinaryLength;
		public static RField RMinBinaryLength
		{
			get
			{
				if(r_MinBinaryLength == null)
				{
					r_MinBinaryLength = new(typeof(System.Security.Principal.SecurityIdentifier), "MinBinaryLength");
					r_MinBinaryLength.SetBelong(null);
				}
				return r_MinBinaryLength;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier AccountDomainSid
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_AccountDomainSid;
		public virtual RSystem.RSecurity.RPrincipal.RSecurityIdentifier RAccountDomainSid
		{
			get
			{
				if(r_AccountDomainSid == null)
				{
					r_AccountDomainSid = new(this, "AccountDomainSid", -1);
					r_AccountDomainSid.SetBelong(this.instance);
				}
				return r_AccountDomainSid;
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
		/// System.String Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Void CreateFromBinaryForm(IntPtr, Int32)
		/// </summary>
		protected RMethod r_RCreateFromBinaryForm_IntPtr_Int32;
		public virtual RMethod RCreateFromBinaryForm_IntPtr_Int32
		{
			get
			{
				if(r_RCreateFromBinaryForm_IntPtr_Int32 == null)
				{
					r_RCreateFromBinaryForm_IntPtr_Int32 = new(this, "CreateFromBinaryForm", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_RCreateFromBinaryForm_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_RCreateFromBinaryForm_IntPtr_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetSidAuthority()
		/// </summary>
		protected RMethod r_RGetSidAuthority;
		public virtual RMethod RGetSidAuthority
		{
			get
			{
				if(r_RGetSidAuthority == null)
				{
					r_RGetSidAuthority = new(this, "GetSidAuthority", 0);
					r_RGetSidAuthority.SetBelong(this.instance);
				}
				return r_RGetSidAuthority;
			}
		}

		/// <summary>
		/// Byte GetSidSubAuthorityCount()
		/// </summary>
		protected RMethod r_RGetSidSubAuthorityCount;
		public virtual RMethod RGetSidSubAuthorityCount
		{
			get
			{
				if(r_RGetSidSubAuthorityCount == null)
				{
					r_RGetSidSubAuthorityCount = new(this, "GetSidSubAuthorityCount", 0);
					r_RGetSidSubAuthorityCount.SetBelong(this.instance);
				}
				return r_RGetSidSubAuthorityCount;
			}
		}

		/// <summary>
		/// UInt32 GetSidSubAuthority(Byte)
		/// </summary>
		protected RMethod r_RGetSidSubAuthority_Byte;
		public virtual RMethod RGetSidSubAuthority_Byte
		{
			get
			{
				if(r_RGetSidSubAuthority_Byte == null)
				{
					r_RGetSidSubAuthority_Byte = new(this, "GetSidSubAuthority", 0, typeof(System.Byte));
					r_RGetSidSubAuthority_Byte.SetBelong(this.instance);
				}
				return r_RGetSidSubAuthority_Byte;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_RCompareTo_SecurityIdentifier;
		public virtual RMethod RCompareTo_SecurityIdentifier
		{
			get
			{
				if(r_RCompareTo_SecurityIdentifier == null)
				{
					r_RCompareTo_SecurityIdentifier = new(this, "CompareTo", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_RCompareTo_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_RCompareTo_SecurityIdentifier;
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
		/// Boolean Equals(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_REquals_SecurityIdentifier;
		public virtual RMethod REquals_SecurityIdentifier
		{
			get
			{
				if(r_REquals_SecurityIdentifier == null)
				{
					r_REquals_SecurityIdentifier = new(this, "Equals", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_REquals_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_REquals_SecurityIdentifier;
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
		/// Boolean IsAccountSid()
		/// </summary>
		protected RMethod r_RIsAccountSid;
		public virtual RMethod RIsAccountSid
		{
			get
			{
				if(r_RIsAccountSid == null)
				{
					r_RIsAccountSid = new(this, "IsAccountSid", 0);
					r_RIsAccountSid.SetBelong(this.instance);
				}
				return r_RIsAccountSid;
			}
		}

		/// <summary>
		/// Boolean IsEqualDomainSid(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_RIsEqualDomainSid_SecurityIdentifier;
		public virtual RMethod RIsEqualDomainSid_SecurityIdentifier
		{
			get
			{
				if(r_RIsEqualDomainSid_SecurityIdentifier == null)
				{
					r_RIsEqualDomainSid_SecurityIdentifier = new(this, "IsEqualDomainSid", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_RIsEqualDomainSid_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_RIsEqualDomainSid_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Boolean IsValidTargetType(System.Type)
		/// </summary>
		protected RMethod r_RIsValidTargetType_Type;
		public virtual RMethod RIsValidTargetType_Type
		{
			get
			{
				if(r_RIsValidTargetType_Type == null)
				{
					r_RIsValidTargetType_Type = new(this, "IsValidTargetType", 0, typeof(System.Type));
					r_RIsValidTargetType_Type.SetBelong(this.instance);
				}
				return r_RIsValidTargetType_Type;
			}
		}

		/// <summary>
		/// Boolean IsWellKnown(System.Security.Principal.WellKnownSidType)
		/// </summary>
		protected RMethod r_RIsWellKnown_WellKnownSidType;
		public virtual RMethod RIsWellKnown_WellKnownSidType
		{
			get
			{
				if(r_RIsWellKnown_WellKnownSidType == null)
				{
					r_RIsWellKnown_WellKnownSidType = new(this, "IsWellKnown", 0, typeof(System.Security.Principal.WellKnownSidType));
					r_RIsWellKnown_WellKnownSidType.SetBelong(this.instance);
				}
				return r_RIsWellKnown_WellKnownSidType;
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

		/// <summary>
		/// System.Security.Principal.IdentityReference Translate(System.Type)
		/// </summary>
		protected RMethod r_RTranslate_Type;
		public virtual RMethod RTranslate_Type
		{
			get
			{
				if(r_RTranslate_Type == null)
				{
					r_RTranslate_Type = new(this, "Translate", 0, typeof(System.Type));
					r_RTranslate_Type.SetBelong(this.instance);
				}
				return r_RTranslate_Type;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected static RMethod r_Rop_Equality_SecurityIdentifier_SecurityIdentifier;
		public static RMethod Rop_Equality_SecurityIdentifier_SecurityIdentifier
		{
			get
			{
				if(r_Rop_Equality_SecurityIdentifier_SecurityIdentifier == null)
				{
					r_Rop_Equality_SecurityIdentifier_SecurityIdentifier = new(typeof(System.Security.Principal.SecurityIdentifier), "op_Equality", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.Principal.SecurityIdentifier));
					r_Rop_Equality_SecurityIdentifier_SecurityIdentifier.SetBelong(null);
				}
				return r_Rop_Equality_SecurityIdentifier_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected static RMethod r_Rop_Inequality_SecurityIdentifier_SecurityIdentifier;
		public static RMethod Rop_Inequality_SecurityIdentifier_SecurityIdentifier
		{
			get
			{
				if(r_Rop_Inequality_SecurityIdentifier_SecurityIdentifier == null)
				{
					r_Rop_Inequality_SecurityIdentifier_SecurityIdentifier = new(typeof(System.Security.Principal.SecurityIdentifier), "op_Inequality", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.Principal.SecurityIdentifier));
					r_Rop_Inequality_SecurityIdentifier_SecurityIdentifier.SetBelong(null);
				}
				return r_Rop_Inequality_SecurityIdentifier_SecurityIdentifier;
			}
		}

		/// <summary>
		/// System.String GetSddlForm()
		/// </summary>
		protected RMethod r_RGetSddlForm;
		public virtual RMethod RGetSddlForm
		{
			get
			{
				if(r_RGetSddlForm == null)
				{
					r_RGetSddlForm = new(this, "GetSddlForm", 0);
					r_RGetSddlForm.SetBelong(this.instance);
				}
				return r_RGetSddlForm;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier ParseSddlForm(System.String, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RParseSddlForm_String_Ref_Int32;
		public static RMethod RParseSddlForm_String_Ref_Int32
		{
			get
			{
				if(r_RParseSddlForm_String_Ref_Int32 == null)
				{
					r_RParseSddlForm_String_Ref_Int32 = new(typeof(System.Security.Principal.SecurityIdentifier), "ParseSddlForm", 0, typeof(System.String), typeof(System.Int32).MakeByRefType());
					r_RParseSddlForm_String_Ref_Int32.SetBelong(null);
				}
				return r_RParseSddlForm_String_Ref_Int32;
			}
		}

		/// <summary>
		/// Byte[] ParseSddlForm(System.String)
		/// </summary>
		protected static RMethod r_RParseSddlForm_String;
		public static RMethod RParseSddlForm_String
		{
			get
			{
				if(r_RParseSddlForm_String == null)
				{
					r_RParseSddlForm_String = new(typeof(System.Security.Principal.SecurityIdentifier), "ParseSddlForm", 0, typeof(System.String));
					r_RParseSddlForm_String.SetBelong(null);
				}
				return r_RParseSddlForm_String;
			}
		}

		/// <summary>
		/// Boolean TryParseAuthority(System.String, UInt64 ByRef)
		/// </summary>
		protected static RMethod r_RTryParseAuthority_String_Out_UInt64;
		public static RMethod RTryParseAuthority_String_Out_UInt64
		{
			get
			{
				if(r_RTryParseAuthority_String_Out_UInt64 == null)
				{
					r_RTryParseAuthority_String_Out_UInt64 = new(typeof(System.Security.Principal.SecurityIdentifier), "TryParseAuthority", 0, typeof(System.String), typeof(System.UInt64).MakeByRefType());
					r_RTryParseAuthority_String_Out_UInt64.SetBelong(null);
				}
				return r_RTryParseAuthority_String_Out_UInt64;
			}
		}

		/// <summary>
		/// Boolean TryParseSubAuthority(System.String, UInt32 ByRef)
		/// </summary>
		protected static RMethod r_RTryParseSubAuthority_String_Out_UInt32;
		public static RMethod RTryParseSubAuthority_String_Out_UInt32
		{
			get
			{
				if(r_RTryParseSubAuthority_String_Out_UInt32 == null)
				{
					r_RTryParseSubAuthority_String_Out_UInt32 = new(typeof(System.Security.Principal.SecurityIdentifier), "TryParseSubAuthority", 0, typeof(System.String), typeof(System.UInt32).MakeByRefType());
					r_RTryParseSubAuthority_String_Out_UInt32.SetBelong(null);
				}
				return r_RTryParseSubAuthority_String_Out_UInt32;
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


        public RSecurityIdentifier() : base("System.Security.Principal.SecurityIdentifier")
        {
        }

        public RSecurityIdentifier(System.Object instance) : base("System.Security.Principal.SecurityIdentifier")
		{
            SetInstance(instance);
		}

        public RSecurityIdentifier(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSecurityIdentifier(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CreateFromBinaryForm(System.IntPtr  @binaryForm, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @length};
            var ___result = RCreateFromBinaryForm_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetSidAuthority()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSidAuthority.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Byte GetSidSubAuthorityCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSidSubAuthorityCount.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.UInt32 GetSidSubAuthority(System.Byte  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetSidSubAuthority_Byte.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int32 CompareTo(System.Security.Principal.SecurityIdentifier  @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RCompareTo_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Principal.SecurityIdentifier  @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = REquals_SecurityIdentifier.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean IsAccountSid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAccountSid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEqualDomainSid(System.Security.Principal.SecurityIdentifier  @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RIsEqualDomainSid_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidTargetType(System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RIsValidTargetType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsWellKnown(System.Security.Principal.WellKnownSidType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsWellKnown_WellKnownSidType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Principal.IdentityReference Translate(System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RTranslate_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public static System.Boolean op_Equality(System.Security.Principal.SecurityIdentifier  @left, System.Security.Principal.SecurityIdentifier  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_SecurityIdentifier_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Principal.SecurityIdentifier  @left, System.Security.Principal.SecurityIdentifier  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_SecurityIdentifier_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.Principal.SecurityIdentifier ParseSddlForm(System.String  @sddlForm, ref System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @pos};
            var ___result = RParseSddlForm_String_Ref_Int32.Invoke(___genericsType, ___parameters);
			pos = (System.Int32)___parameters[1];

            return (System.Security.Principal.SecurityIdentifier)___result;
        }


        public static System.Byte[] ParseSddlForm(System.String  @sddlForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm};
            var ___result = RParseSddlForm_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Boolean TryParseAuthority(System.String  @s, out System.UInt64  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParseAuthority_String_Out_UInt64.Invoke(___genericsType, ___parameters);
			result = (System.UInt64)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseSubAuthority(System.String  @s, out System.UInt32  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RTryParseSubAuthority_String_Out_UInt32.Invoke(___genericsType, ___parameters);
			result = (System.UInt32)___parameters[1];

            return (System.Boolean)___result;
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


    }
}
