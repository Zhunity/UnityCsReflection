using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.StrongNameMembershipCondition
	/// </summary>
    public partial class RStrongNameMembershipCondition : RMember //
    {

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected RSystem.RInt32 r_Fversion;
		public virtual RSystem.RInt32 RFversion
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
		/// System.Security.Permissions.StrongNamePublicKeyBlob blob
		/// </summary>
		protected RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob r_Fblob;
		public virtual RSystem.RSecurity.RPermissions.RStrongNamePublicKeyBlob RFblob
		{
			get
			{
				if(r_Fblob == null)
				{
					r_Fblob = new(this, "blob");
					r_Fblob.SetBelong(this.instance);
				}
				return r_Fblob;
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
		/// System.Version assemblyVersion
		/// </summary>
		protected RSystem.RVersion r_FassemblyVersion;
		public virtual RSystem.RVersion RFassemblyVersion
		{
			get
			{
				if(r_FassemblyVersion == null)
				{
					r_FassemblyVersion = new(this, "assemblyVersion");
					r_FassemblyVersion.SetBelong(this.instance);
				}
				return r_FassemblyVersion;
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
		/// Boolean Check(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MCheck_Evidence;
		public virtual RMethod RMCheck_Evidence
		{
			get
			{
				if(r_MCheck_Evidence == null)
				{
					r_MCheck_Evidence = new(this, "Check", 0, typeof(System.Security.Policy.Evidence));
					r_MCheck_Evidence.SetBelong(this.instance);
				}
				return r_MCheck_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition Copy()
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
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement;
		public virtual RMethod RMFromXml_SecurityElement
		{
			get
			{
				if(r_MFromXml_SecurityElement == null)
				{
					r_MFromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_MFromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_MFromXml_SecurityElement;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement_PolicyLevel;
		public virtual RMethod RMFromXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_MFromXml_SecurityElement_PolicyLevel == null)
				{
					r_MFromXml_SecurityElement_PolicyLevel = new(this, "FromXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
					r_MFromXml_SecurityElement_PolicyLevel.SetBelong(this.instance);
				}
				return r_MFromXml_SecurityElement_PolicyLevel;
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
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_MToXml;
		public virtual RMethod RMToXml
		{
			get
			{
				if(r_MToXml == null)
				{
					r_MToXml = new(this, "ToXml", 0);
					r_MToXml.SetBelong(this.instance);
				}
				return r_MToXml;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MToXml_PolicyLevel;
		public virtual RMethod RMToXml_PolicyLevel
		{
			get
			{
				if(r_MToXml_PolicyLevel == null)
				{
					r_MToXml_PolicyLevel = new(this, "ToXml", 0, typeof(System.Security.Policy.PolicyLevel));
					r_MToXml_PolicyLevel.SetBelong(this.instance);
				}
				return r_MToXml_PolicyLevel;
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


        public RStrongNameMembershipCondition() : base("System.Security.Policy.StrongNameMembershipCondition")
        {
        }

        public RStrongNameMembershipCondition(System.Object instance) : base("System.Security.Policy.StrongNameMembershipCondition")
		{
            SetInstance(instance);
		}

        public RStrongNameMembershipCondition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrongNameMembershipCondition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Check(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMCheck_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.Policy.IMembershipCondition Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.IMembershipCondition)___result;
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


        public virtual void FromXml(System.Security.SecurityElement @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @e, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @level};
            var ___result = RMFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RMToXml_PolicyLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
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
