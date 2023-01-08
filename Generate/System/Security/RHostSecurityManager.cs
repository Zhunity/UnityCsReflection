using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.HostSecurityManager
	/// </summary>
    public partial class RHostSecurityManager : RMember //
    {

		/// <summary>
		/// System.Security.Policy.PolicyLevel DomainPolicy
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyLevel r_DomainPolicy;
		public virtual RSystem.RSecurity.RPolicy.RPolicyLevel RDomainPolicy
		{
			get
			{
				if(r_DomainPolicy == null)
				{
					r_DomainPolicy = new(this, "DomainPolicy", -1);
					r_DomainPolicy.SetBelong(this.instance);
				}
				return r_DomainPolicy;
			}
		}

		/// <summary>
		/// System.Security.HostSecurityManagerOptions Flags
		/// </summary>
		protected RProperty r_Flags;
		public virtual RProperty RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags", -1);
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence, System.Security.Policy.Evidence, System.Security.Policy.TrustManagerContext)
		/// </summary>
		protected RMethod r_DetermineApplicationTrust_Evidence_Evidence_TrustManagerContext;
		public virtual RMethod RDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext
		{
			get
			{
				if(r_DetermineApplicationTrust_Evidence_Evidence_TrustManagerContext == null)
				{
					r_DetermineApplicationTrust_Evidence_Evidence_TrustManagerContext = new(this, "DetermineApplicationTrust", 0, typeof(System.Security.Policy.Evidence), typeof(System.Security.Policy.Evidence), typeof(System.Security.Policy.TrustManagerContext));
					r_DetermineApplicationTrust_Evidence_Evidence_TrustManagerContext.SetBelong(this.instance);
				}
				return r_DetermineApplicationTrust_Evidence_Evidence_TrustManagerContext;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_ProvideAppDomainEvidence_Evidence;
		public virtual RMethod RProvideAppDomainEvidence_Evidence
		{
			get
			{
				if(r_ProvideAppDomainEvidence_Evidence == null)
				{
					r_ProvideAppDomainEvidence_Evidence = new(this, "ProvideAppDomainEvidence", 0, typeof(System.Security.Policy.Evidence));
					r_ProvideAppDomainEvidence_Evidence.SetBelong(this.instance);
				}
				return r_ProvideAppDomainEvidence_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_ProvideAssemblyEvidence_Assembly_Evidence;
		public virtual RMethod RProvideAssemblyEvidence_Assembly_Evidence
		{
			get
			{
				if(r_ProvideAssemblyEvidence_Assembly_Evidence == null)
				{
					r_ProvideAssemblyEvidence_Assembly_Evidence = new(this, "ProvideAssemblyEvidence", 0, typeof(System.Reflection.Assembly), typeof(System.Security.Policy.Evidence));
					r_ProvideAssemblyEvidence_Assembly_Evidence.SetBelong(this.instance);
				}
				return r_ProvideAssemblyEvidence_Assembly_Evidence;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_ResolvePolicy_Evidence;
		public virtual RMethod RResolvePolicy_Evidence
		{
			get
			{
				if(r_ResolvePolicy_Evidence == null)
				{
					r_ResolvePolicy_Evidence = new(this, "ResolvePolicy", 0, typeof(System.Security.Policy.Evidence));
					r_ResolvePolicy_Evidence.SetBelong(this.instance);
				}
				return r_ResolvePolicy_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase GenerateAppDomainEvidence(System.Type)
		/// </summary>
		protected RMethod r_GenerateAppDomainEvidence_Type;
		public virtual RMethod RGenerateAppDomainEvidence_Type
		{
			get
			{
				if(r_GenerateAppDomainEvidence_Type == null)
				{
					r_GenerateAppDomainEvidence_Type = new(this, "GenerateAppDomainEvidence", 0, typeof(System.Type));
					r_GenerateAppDomainEvidence_Type.SetBelong(this.instance);
				}
				return r_GenerateAppDomainEvidence_Type;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase GenerateAssemblyEvidence(System.Type, System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_GenerateAssemblyEvidence_Type_Assembly;
		public virtual RMethod RGenerateAssemblyEvidence_Type_Assembly
		{
			get
			{
				if(r_GenerateAssemblyEvidence_Type_Assembly == null)
				{
					r_GenerateAssemblyEvidence_Type_Assembly = new(this, "GenerateAssemblyEvidence", 0, typeof(System.Type), typeof(System.Reflection.Assembly));
					r_GenerateAssemblyEvidence_Type_Assembly.SetBelong(this.instance);
				}
				return r_GenerateAssemblyEvidence_Type_Assembly;
			}
		}

		/// <summary>
		/// System.Type[] GetHostSuppliedAppDomainEvidenceTypes()
		/// </summary>
		protected RMethod r_GetHostSuppliedAppDomainEvidenceTypes;
		public virtual RMethod RGetHostSuppliedAppDomainEvidenceTypes
		{
			get
			{
				if(r_GetHostSuppliedAppDomainEvidenceTypes == null)
				{
					r_GetHostSuppliedAppDomainEvidenceTypes = new(this, "GetHostSuppliedAppDomainEvidenceTypes", 0);
					r_GetHostSuppliedAppDomainEvidenceTypes.SetBelong(this.instance);
				}
				return r_GetHostSuppliedAppDomainEvidenceTypes;
			}
		}

		/// <summary>
		/// System.Type[] GetHostSuppliedAssemblyEvidenceTypes(System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_GetHostSuppliedAssemblyEvidenceTypes_Assembly;
		public virtual RMethod RGetHostSuppliedAssemblyEvidenceTypes_Assembly
		{
			get
			{
				if(r_GetHostSuppliedAssemblyEvidenceTypes_Assembly == null)
				{
					r_GetHostSuppliedAssemblyEvidenceTypes_Assembly = new(this, "GetHostSuppliedAssemblyEvidenceTypes", 0, typeof(System.Reflection.Assembly));
					r_GetHostSuppliedAssemblyEvidenceTypes_Assembly.SetBelong(this.instance);
				}
				return r_GetHostSuppliedAssemblyEvidenceTypes_Assembly;
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


        public RHostSecurityManager() : base("System.Security.HostSecurityManager")
        {
        }

        public RHostSecurityManager(System.Object instance) : base("System.Security.HostSecurityManager")
		{
            SetInstance(instance);
		}

        public RHostSecurityManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHostSecurityManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence @applicationEvidence, System.Security.Policy.Evidence @activatorEvidence, System.Security.Policy.TrustManagerContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@applicationEvidence, @activatorEvidence, @context};
            var ___result = RDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.ApplicationTrust)___result;
        }


        public virtual System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence @inputEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputEvidence};
            var ___result = RProvideAppDomainEvidence_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly @loadedAssembly, System.Security.Policy.Evidence @inputEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadedAssembly, @inputEvidence};
            var ___result = RProvideAssemblyEvidence_Assembly_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RResolvePolicy_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual System.Security.Policy.EvidenceBase GenerateAppDomainEvidence(System.Type @evidenceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidenceType};
            var ___result = RGenerateAppDomainEvidence_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
        }


        public virtual System.Security.Policy.EvidenceBase GenerateAssemblyEvidence(System.Type @evidenceType, System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidenceType, @assembly};
            var ___result = RGenerateAssemblyEvidence_Type_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
        }


        public virtual System.Type[] GetHostSuppliedAppDomainEvidenceTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHostSuppliedAppDomainEvidenceTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetHostSuppliedAssemblyEvidenceTypes(System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly};
            var ___result = RGetHostSuppliedAssemblyEvidenceTypes_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
