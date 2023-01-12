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
		protected RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob r_Fpublickey;
		public virtual RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob RFpublickey
		{
			get
			{
				if(r_Fpublickey == null)
				{
					r_Fpublickey = new(this, "publickey");
					r_Fpublickey.SetBelong(this.instance);
				}
				return r_Fpublickey;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Fname;
		public virtual RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Version version
		/// </summary>
		protected RSystem.RVersion r_Fversion;
		public virtual RSystem.RVersion RFversion
		{
			get
			{
				if(r_Fversion == null)
				{
					r_Fversion = new(this, "version");
					r_Fversion.SetBelong(this.instance);
				}
				return r_Fversion;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_PName;
		public virtual RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Security.Permissions.StrongNamePublicKeyBlob PublicKey
		/// </summary>
		protected RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob r_PPublicKey;
		public virtual RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob RPPublicKey
		{
			get
			{
				if(r_PPublicKey == null)
				{
					r_PPublicKey = new(this, "PublicKey", -1);
					r_PPublicKey.SetBelong(this.instance);
				}
				return r_PPublicKey;
			}
		}

		/// <summary>
		/// System.Version Version
		/// </summary>
		protected RSystem.RVersion r_PVersion;
		public virtual RSystem.RVersion RPVersion
		{
			get
			{
				if(r_PVersion == null)
				{
					r_PVersion = new(this, "Version", -1);
					r_PVersion.SetBelong(this.instance);
				}
				return r_PVersion;
			}
		}

		/// <summary>
		/// System.Object Copy()
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
		/// System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCreateIdentityPermission_Evidence;
		public virtual RMethod RMCreateIdentityPermission_Evidence
		{
			get
			{
				if(r_MCreateIdentityPermission_Evidence == null)
				{
					r_MCreateIdentityPermission_Evidence = new(this, "CreateIdentityPermission", 0, typeof(System.Security.Policy.Evidence));
					r_MCreateIdentityPermission_Evidence.SetBelong(this.instance);
				}
				return r_MCreateIdentityPermission_Evidence;
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
		/// Int32 System.Security.Policy.IBuiltInEvidence.GetRequiredSize(Boolean)
		/// </summary>
		protected RMethod r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean;
		public virtual RMethod RMSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean
		{
			get
			{
				if(r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean == null)
				{
					r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean = new(this, "System.Security.Policy.IBuiltInEvidence.GetRequiredSize", 0, typeof(System.Boolean));
					r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean.SetBelong(this.instance);
				}
				return r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean;
			}
		}

		/// <summary>
		/// Int32 System.Security.Policy.IBuiltInEvidence.InitFromBuffer(Char[], Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32;
		public virtual RMethod RMSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32
		{
			get
			{
				if(r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32 == null)
				{
					r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32 = new(this, "System.Security.Policy.IBuiltInEvidence.InitFromBuffer", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32.SetBelong(this.instance);
				}
				return r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Security.Policy.IBuiltInEvidence.OutputToBuffer(Char[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean;
		public virtual RMethod RMSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean
		{
			get
			{
				if(r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean == null)
				{
					r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean = new(this, "System.Security.Policy.IBuiltInEvidence.OutputToBuffer", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
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
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMCreateIdentityPermission_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 System__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize(System.Boolean @verbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@verbose};
            var ___result = RMSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__GetRequiredSize_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer(System.Char[] @buffer, System.Int32 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @position};
            var ___result = RMSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__InitFromBuffer_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer(System.Char[] @buffer, System.Int32 @position, System.Boolean @verbose)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @position, @verbose};
            var ___result = RMSystem__2__Security__2__Policy__2__IBuiltInEvidence__2__OutputToBuffer_CharArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Security.Policy.EvidenceBase Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
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
