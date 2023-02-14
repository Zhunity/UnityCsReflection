
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.SecurityIdentifier
	/// </summary>
    public partial class RSecurityIdentifier : RMember //
    {

		/// <summary>
		/// System.Byte[] buffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fbuffer;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFbuffer
		{
			get
			{
				if(r_Fbuffer == null)
				{
					r_Fbuffer = new(this, "buffer");
					r_Fbuffer.SetBelong(this.instance);
				}
				return r_Fbuffer;
			}
		}

		/// <summary>
		/// System.Int32 MaxBinaryLength
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxBinaryLength;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxBinaryLength
		{
			get
			{
				if(r_FMaxBinaryLength == null)
				{
					r_FMaxBinaryLength = new(typeof(System.Security.Principal.SecurityIdentifier), "MaxBinaryLength");
					r_FMaxBinaryLength.SetBelong(null);
				}
				return r_FMaxBinaryLength;
			}
		}

		/// <summary>
		/// System.Int32 MinBinaryLength
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMinBinaryLength;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMinBinaryLength
		{
			get
			{
				if(r_FMinBinaryLength == null)
				{
					r_FMinBinaryLength = new(typeof(System.Security.Principal.SecurityIdentifier), "MinBinaryLength");
					r_FMinBinaryLength.SetBelong(null);
				}
				return r_FMinBinaryLength;
			}
		}

		/// <summary>
		/// System.Security.Principal.SecurityIdentifier AccountDomainSid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier r_PAccountDomainSid;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RSecurityIdentifier RPAccountDomainSid
		{
			get
			{
				if(r_PAccountDomainSid == null)
				{
					r_PAccountDomainSid = new(this, "AccountDomainSid", -1);
					r_PAccountDomainSid.SetBelong(this.instance);
				}
				return r_PAccountDomainSid;
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
		/// System.String Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Void CreateFromBinaryForm(IntPtr, Int32)
		/// </summary>
		protected RMethod r_MCreateFromBinaryForm_IntPtr_Int32;
		public virtual RMethod RMCreateFromBinaryForm_IntPtr_Int32
		{
			get
			{
				if(r_MCreateFromBinaryForm_IntPtr_Int32 == null)
				{
					r_MCreateFromBinaryForm_IntPtr_Int32 = new(this, "CreateFromBinaryForm", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_MCreateFromBinaryForm_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_MCreateFromBinaryForm_IntPtr_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetSidAuthority()
		/// </summary>
		protected RMethod r_MGetSidAuthority;
		public virtual RMethod RMGetSidAuthority
		{
			get
			{
				if(r_MGetSidAuthority == null)
				{
					r_MGetSidAuthority = new(this, "GetSidAuthority", 0);
					r_MGetSidAuthority.SetBelong(this.instance);
				}
				return r_MGetSidAuthority;
			}
		}

		/// <summary>
		/// Byte GetSidSubAuthorityCount()
		/// </summary>
		protected RMethod r_MGetSidSubAuthorityCount;
		public virtual RMethod RMGetSidSubAuthorityCount
		{
			get
			{
				if(r_MGetSidSubAuthorityCount == null)
				{
					r_MGetSidSubAuthorityCount = new(this, "GetSidSubAuthorityCount", 0);
					r_MGetSidSubAuthorityCount.SetBelong(this.instance);
				}
				return r_MGetSidSubAuthorityCount;
			}
		}

		/// <summary>
		/// UInt32 GetSidSubAuthority(Byte)
		/// </summary>
		protected RMethod r_MGetSidSubAuthority_Byte;
		public virtual RMethod RMGetSidSubAuthority_Byte
		{
			get
			{
				if(r_MGetSidSubAuthority_Byte == null)
				{
					r_MGetSidSubAuthority_Byte = new(this, "GetSidSubAuthority", 0, typeof(System.Byte));
					r_MGetSidSubAuthority_Byte.SetBelong(this.instance);
				}
				return r_MGetSidSubAuthority_Byte;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_MCompareTo_SecurityIdentifier;
		public virtual RMethod RMCompareTo_SecurityIdentifier
		{
			get
			{
				if(r_MCompareTo_SecurityIdentifier == null)
				{
					r_MCompareTo_SecurityIdentifier = new(this, "CompareTo", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_MCompareTo_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_MCompareTo_SecurityIdentifier;
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
		/// Boolean Equals(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_MEquals_SecurityIdentifier;
		public virtual RMethod RMEquals_SecurityIdentifier
		{
			get
			{
				if(r_MEquals_SecurityIdentifier == null)
				{
					r_MEquals_SecurityIdentifier = new(this, "Equals", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_MEquals_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_MEquals_SecurityIdentifier;
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
		/// Boolean IsAccountSid()
		/// </summary>
		protected RMethod r_MIsAccountSid;
		public virtual RMethod RMIsAccountSid
		{
			get
			{
				if(r_MIsAccountSid == null)
				{
					r_MIsAccountSid = new(this, "IsAccountSid", 0);
					r_MIsAccountSid.SetBelong(this.instance);
				}
				return r_MIsAccountSid;
			}
		}

		/// <summary>
		/// Boolean IsEqualDomainSid(System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected RMethod r_MIsEqualDomainSid_SecurityIdentifier;
		public virtual RMethod RMIsEqualDomainSid_SecurityIdentifier
		{
			get
			{
				if(r_MIsEqualDomainSid_SecurityIdentifier == null)
				{
					r_MIsEqualDomainSid_SecurityIdentifier = new(this, "IsEqualDomainSid", 0, typeof(System.Security.Principal.SecurityIdentifier));
					r_MIsEqualDomainSid_SecurityIdentifier.SetBelong(this.instance);
				}
				return r_MIsEqualDomainSid_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Boolean IsValidTargetType(System.Type)
		/// </summary>
		protected RMethod r_MIsValidTargetType_Type;
		public virtual RMethod RMIsValidTargetType_Type
		{
			get
			{
				if(r_MIsValidTargetType_Type == null)
				{
					r_MIsValidTargetType_Type = new(this, "IsValidTargetType", 0, typeof(System.Type));
					r_MIsValidTargetType_Type.SetBelong(this.instance);
				}
				return r_MIsValidTargetType_Type;
			}
		}

		/// <summary>
		/// Boolean IsWellKnown(System.Security.Principal.WellKnownSidType)
		/// </summary>
		protected RMethod r_MIsWellKnown_WellKnownSidType;
		public virtual RMethod RMIsWellKnown_WellKnownSidType
		{
			get
			{
				if(r_MIsWellKnown_WellKnownSidType == null)
				{
					r_MIsWellKnown_WellKnownSidType = new(this, "IsWellKnown", 0, typeof(System.Security.Principal.WellKnownSidType));
					r_MIsWellKnown_WellKnownSidType.SetBelong(this.instance);
				}
				return r_MIsWellKnown_WellKnownSidType;
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

		/// <summary>
		/// System.Security.Principal.IdentityReference Translate(System.Type)
		/// </summary>
		protected RMethod r_MTranslate_Type;
		public virtual RMethod RMTranslate_Type
		{
			get
			{
				if(r_MTranslate_Type == null)
				{
					r_MTranslate_Type = new(this, "Translate", 0, typeof(System.Type));
					r_MTranslate_Type.SetBelong(this.instance);
				}
				return r_MTranslate_Type;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected static RMethod r_Mop_Equality_SecurityIdentifier_SecurityIdentifier;
		public static RMethod RMop_Equality_SecurityIdentifier_SecurityIdentifier
		{
			get
			{
				if(r_Mop_Equality_SecurityIdentifier_SecurityIdentifier == null)
				{
					r_Mop_Equality_SecurityIdentifier_SecurityIdentifier = new(typeof(System.Security.Principal.SecurityIdentifier), "op_Equality", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.Principal.SecurityIdentifier));
					r_Mop_Equality_SecurityIdentifier_SecurityIdentifier.SetBelong(null);
				}
				return r_Mop_Equality_SecurityIdentifier_SecurityIdentifier;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier)
		/// </summary>
		protected static RMethod r_Mop_Inequality_SecurityIdentifier_SecurityIdentifier;
		public static RMethod RMop_Inequality_SecurityIdentifier_SecurityIdentifier
		{
			get
			{
				if(r_Mop_Inequality_SecurityIdentifier_SecurityIdentifier == null)
				{
					r_Mop_Inequality_SecurityIdentifier_SecurityIdentifier = new(typeof(System.Security.Principal.SecurityIdentifier), "op_Inequality", 0, typeof(System.Security.Principal.SecurityIdentifier), typeof(System.Security.Principal.SecurityIdentifier));
					r_Mop_Inequality_SecurityIdentifier_SecurityIdentifier.SetBelong(null);
				}
				return r_Mop_Inequality_SecurityIdentifier_SecurityIdentifier;
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
		/// System.Security.Principal.SecurityIdentifier ParseSddlForm(System.String, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MParseSddlForm_String_Ref_Int32;
		public static RMethod RMParseSddlForm_String_Ref_Int32
		{
			get
			{
				if(r_MParseSddlForm_String_Ref_Int32 == null)
				{
					r_MParseSddlForm_String_Ref_Int32 = new(typeof(System.Security.Principal.SecurityIdentifier), "ParseSddlForm", 0, typeof(System.String), typeof(System.Int32).MakeByRefType());
					r_MParseSddlForm_String_Ref_Int32.SetBelong(null);
				}
				return r_MParseSddlForm_String_Ref_Int32;
			}
		}

		/// <summary>
		/// Byte[] ParseSddlForm(System.String)
		/// </summary>
		protected static RMethod r_MParseSddlForm_String;
		public static RMethod RMParseSddlForm_String
		{
			get
			{
				if(r_MParseSddlForm_String == null)
				{
					r_MParseSddlForm_String = new(typeof(System.Security.Principal.SecurityIdentifier), "ParseSddlForm", 0, typeof(System.String));
					r_MParseSddlForm_String.SetBelong(null);
				}
				return r_MParseSddlForm_String;
			}
		}

		/// <summary>
		/// Boolean TryParseAuthority(System.String, UInt64 ByRef)
		/// </summary>
		protected static RMethod r_MTryParseAuthority_String_Out_UInt64;
		public static RMethod RMTryParseAuthority_String_Out_UInt64
		{
			get
			{
				if(r_MTryParseAuthority_String_Out_UInt64 == null)
				{
					r_MTryParseAuthority_String_Out_UInt64 = new(typeof(System.Security.Principal.SecurityIdentifier), "TryParseAuthority", 0, typeof(System.String), typeof(System.UInt64).MakeByRefType());
					r_MTryParseAuthority_String_Out_UInt64.SetBelong(null);
				}
				return r_MTryParseAuthority_String_Out_UInt64;
			}
		}

		/// <summary>
		/// Boolean TryParseSubAuthority(System.String, UInt32 ByRef)
		/// </summary>
		protected static RMethod r_MTryParseSubAuthority_String_Out_UInt32;
		public static RMethod RMTryParseSubAuthority_String_Out_UInt32
		{
			get
			{
				if(r_MTryParseSubAuthority_String_Out_UInt32 == null)
				{
					r_MTryParseSubAuthority_String_Out_UInt32 = new(typeof(System.Security.Principal.SecurityIdentifier), "TryParseSubAuthority", 0, typeof(System.String), typeof(System.UInt32).MakeByRefType());
					r_MTryParseSubAuthority_String_Out_UInt32.SetBelong(null);
				}
				return r_MTryParseSubAuthority_String_Out_UInt32;
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

        public virtual void CreateFromBinaryForm(System.IntPtr @binaryForm, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @length};
            var ___result = RMCreateFromBinaryForm_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetSidAuthority()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSidAuthority.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Byte GetSidSubAuthorityCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSidSubAuthorityCount.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.UInt32 GetSidSubAuthority(System.Byte @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetSidSubAuthority_Byte.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int32 CompareTo(System.Security.Principal.SecurityIdentifier @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RMCompareTo_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Principal.SecurityIdentifier @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RMEquals_SecurityIdentifier.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean IsAccountSid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAccountSid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEqualDomainSid(System.Security.Principal.SecurityIdentifier @sid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sid};
            var ___result = RMIsEqualDomainSid_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidTargetType(System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RMIsValidTargetType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsWellKnown(System.Security.Principal.WellKnownSidType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMIsWellKnown_WellKnownSidType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Principal.IdentityReference Translate(System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RMTranslate_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public static System.Boolean op_Equality(System.Security.Principal.SecurityIdentifier @left, System.Security.Principal.SecurityIdentifier @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_SecurityIdentifier_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Principal.SecurityIdentifier @left, System.Security.Principal.SecurityIdentifier @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_SecurityIdentifier_SecurityIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.Principal.SecurityIdentifier ParseSddlForm(System.String @sddlForm, ref System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @pos};
            var ___result = RMParseSddlForm_String_Ref_Int32.Invoke(___genericsType, ___parameters);
			@pos = (System.Int32)___parameters[1];

            return (System.Security.Principal.SecurityIdentifier)___result;
        }


        public static System.Byte[] ParseSddlForm(System.String @sddlForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm};
            var ___result = RMParseSddlForm_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Boolean TryParseAuthority(System.String @s, out System.UInt64 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParseAuthority_String_Out_UInt64.Invoke(___genericsType, ___parameters);
			@result = (System.UInt64)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryParseSubAuthority(System.String @s, out System.UInt32 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @result};
            var ___result = RMTryParseSubAuthority_String_Out_UInt32.Invoke(___genericsType, ___parameters);
			@result = (System.UInt32)___parameters[1];

            return (System.Boolean)___result;
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


    }
}
