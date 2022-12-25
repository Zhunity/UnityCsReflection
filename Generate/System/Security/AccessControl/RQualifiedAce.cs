using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.QualifiedAce
	/// </summary>
    public partial class RQualifiedAce : RMember //
    {

		/// <summary>
		/// System.Byte[] opaque
		/// </summary>
		protected RFieldArray<RField> r_opaque;
		public virtual RFieldArray<RField> Ropaque
		{
			get
			{
				if(r_opaque == null)
				{
					r_opaque = new(this, "opaque");
					r_opaque.SetBelong(this.instance);
				}
				return r_opaque;
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
		/// Byte[] GetOpaque()
		/// </summary>
		protected RMethod r_RGetOpaque;
		public virtual RMethod RGetOpaque
		{
			get
			{
				if(r_RGetOpaque == null)
				{
					r_RGetOpaque = new(this, "GetOpaque", 0);
					r_RGetOpaque.SetBelong(this.instance);
				}
				return r_RGetOpaque;
			}
		}

		/// <summary>
		/// Void SetOpaque(Byte[])
		/// </summary>
		protected RMethod r_RSetOpaque_ByteArray;
		public virtual RMethod RSetOpaque_ByteArray
		{
			get
			{
				if(r_RSetOpaque_ByteArray == null)
				{
					r_RSetOpaque_ByteArray = new(this, "SetOpaque", 0, typeof(System.Byte).MakeArrayType());
					r_RSetOpaque_ByteArray.SetBelong(this.instance);
				}
				return r_RSetOpaque_ByteArray;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
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


        public RQualifiedAce() : base("System.Security.AccessControl.QualifiedAce")
        {
        }

        public RQualifiedAce(System.Object instance) : base("System.Security.AccessControl.QualifiedAce")
		{
            SetInstance(instance);
		}

        public RQualifiedAce(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RQualifiedAce(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Byte[] GetOpaque()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOpaque.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void SetOpaque(System.Byte[]  @opaque)
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


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
