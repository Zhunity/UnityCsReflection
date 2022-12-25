using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.StrongName
	/// </summary>
    public partial class RStrongName : RMember //
    {

		/// <summary>
		/// System.Security.Permissions.StrongNamePublicKeyBlob publickey
		/// </summary>
		protected RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob r_publickey;
		public virtual RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob Rpublickey
		{
			get
			{
				if(r_publickey == null)
				{
					r_publickey = new(this, "publickey");
					r_publickey.SetBelong(this.instance);
				}
				return r_publickey;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Version version
		/// </summary>
		protected RSystem.RVersion r_version;
		public virtual RSystem.RVersion Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Security.Permissions.StrongNamePublicKeyBlob PublicKey
		/// </summary>
		protected RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob r_PublicKey;
		public virtual RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob RPublicKey
		{
			get
			{
				if(r_PublicKey == null)
				{
					r_PublicKey = new(this, "PublicKey", -1);
					r_PublicKey.SetBelong(this.instance);
				}
				return r_PublicKey;
			}
		}

		/// <summary>
		/// System.Version Version
		/// </summary>
		protected RSystem.RVersion r_Version;
		public virtual RSystem.RVersion RVersion
		{
			get
			{
				if(r_Version == null)
				{
					r_Version = new(this, "Version", -1);
					r_Version.SetBelong(this.instance);
				}
				return r_Version;
			}
		}

		/// <summary>
		/// System.Object Copy()
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
		/// System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RCreateIdentityPermission_Evidence;
		public virtual RMethod RCreateIdentityPermission_Evidence
		{
			get
			{
				if(r_RCreateIdentityPermission_Evidence == null)
				{
					r_RCreateIdentityPermission_Evidence = new(this, "CreateIdentityPermission", 0, typeof(System.Security.Policy.Evidence));
					r_RCreateIdentityPermission_Evidence.SetBelong(this.instance);
				}
				return r_RCreateIdentityPermission_Evidence;
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
		/// Int32 System.Security.Policy.IBuiltInEvidence.GetRequiredSize(Boolean)
		/// </summary>
		protected RMethod r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean;
		public virtual RMethod RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean
		{
			get
			{
				if(r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean == null)
				{
					r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean = new(this, "System.Security.Policy.IBuiltInEvidence.GetRequiredSize", 0, typeof(System.Boolean));
					r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean.SetBelong(this.instance);
				}
				return r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean;
			}
		}

		/// <summary>
		/// Int32 System.Security.Policy.IBuiltInEvidence.InitFromBuffer(Char[], Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32;
		public virtual RMethod RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32
		{
			get
			{
				if(r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32 == null)
				{
					r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32 = new(this, "System.Security.Policy.IBuiltInEvidence.InitFromBuffer", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Security.Policy.IBuiltInEvidence.OutputToBuffer(Char[], Int32, Boolean)
		/// </summary>
		protected RMethod r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean;
		public virtual RMethod RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean
		{
			get
			{
				if(r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean == null)
				{
					r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean = new(this, "System.Security.Policy.IBuiltInEvidence.OutputToBuffer", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
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


        public RStrongName() : base("System.Security.Policy.StrongName")
        {
        }

        public RStrongName(System.Object instance) : base("System.Security.Policy.StrongName")
		{
            SetInstance(instance);
		}

        public RStrongName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrongName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RCreateIdentityPermission_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 System__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize(System.Boolean  @verbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@verbose};
            var ___result = RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__GetRequiredSize_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer(System.Char[]  @buffer, System.Int32  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @position};
            var ___result = RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__InitFromBuffer_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer(System.Char[]  @buffer, System.Int32  @position, System.Boolean  @verbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @position, @verbose};
            var ___result = RSystem__0__Security__0__Policy__0__IBuiltInEvidence__0__OutputToBuffer_CharArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Security.Policy.EvidenceBase Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
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
