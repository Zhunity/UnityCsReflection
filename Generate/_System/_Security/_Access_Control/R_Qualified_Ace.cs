
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.QualifiedAce
	/// </summary>
    public partial class RQualifiedAce : RMember //
    {

		/// <summary>
		/// System.Byte[] opaque
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fopaque;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFopaque
		{
			get
			{
				if(r_Fopaque == null)
				{
					r_Fopaque = new(this, "opaque");
					r_Fopaque.SetBelong(this.instance);
				}
				return r_Fopaque;
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


        public virtual System.String GetSddlForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSddlForm.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
