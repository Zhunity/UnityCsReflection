
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.HostSecurityManager
	/// </summary>
    public partial class RHostSecurityManager : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.HostSecurityManager);
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


		/// <summary>
		/// System.Security.Policy.PolicyLevel DomainPolicy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel r_PDomainPolicy;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel RPDomainPolicy
		{
			get
			{
				if(r_PDomainPolicy == null)
				{
					r_PDomainPolicy = new(this, "DomainPolicy", -1);
				}
				return r_PDomainPolicy;
			}
		}

		/// <summary>
		/// System.Security.HostSecurityManagerOptions Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RHostSecurityManagerOptions r_PFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RHostSecurityManagerOptions RPFlags
		{
			get
			{
				if(r_PFlags == null)
				{
					r_PFlags = new(this, "Flags", -1);
				}
				return r_PFlags;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence, System.Security.Policy.Evidence, System.Security.Policy.TrustManagerContext)
		/// </summary>
		protected RMethod r_MDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext;
		public virtual RMethod RMDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext
		{
			get
			{
				if(r_MDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext == null)
				{
					r_MDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext = new(this, "DetermineApplicationTrust", 0, typeof(System.Security.Policy.Evidence), typeof(System.Security.Policy.Evidence), typeof(System.Security.Policy.TrustManagerContext));
				}
				return r_MDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MProvideAppDomainEvidence_Evidence;
		public virtual RMethod RMProvideAppDomainEvidence_Evidence
		{
			get
			{
				if(r_MProvideAppDomainEvidence_Evidence == null)
				{
					r_MProvideAppDomainEvidence_Evidence = new(this, "ProvideAppDomainEvidence", 0, typeof(System.Security.Policy.Evidence));
				}
				return r_MProvideAppDomainEvidence_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MProvideAssemblyEvidence_Assembly_Evidence;
		public virtual RMethod RMProvideAssemblyEvidence_Assembly_Evidence
		{
			get
			{
				if(r_MProvideAssemblyEvidence_Assembly_Evidence == null)
				{
					r_MProvideAssemblyEvidence_Assembly_Evidence = new(this, "ProvideAssemblyEvidence", 0, typeof(System.Reflection.Assembly), typeof(System.Security.Policy.Evidence));
				}
				return r_MProvideAssemblyEvidence_Assembly_Evidence;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MResolvePolicy_Evidence;
		public virtual RMethod RMResolvePolicy_Evidence
		{
			get
			{
				if(r_MResolvePolicy_Evidence == null)
				{
					r_MResolvePolicy_Evidence = new(this, "ResolvePolicy", 0, typeof(System.Security.Policy.Evidence));
				}
				return r_MResolvePolicy_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase GenerateAppDomainEvidence(System.Type)
		/// </summary>
		protected RMethod r_MGenerateAppDomainEvidence_Type;
		public virtual RMethod RMGenerateAppDomainEvidence_Type
		{
			get
			{
				if(r_MGenerateAppDomainEvidence_Type == null)
				{
					r_MGenerateAppDomainEvidence_Type = new(this, "GenerateAppDomainEvidence", 0, typeof(System.Type));
				}
				return r_MGenerateAppDomainEvidence_Type;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase GenerateAssemblyEvidence(System.Type, System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_MGenerateAssemblyEvidence_Type_Assembly;
		public virtual RMethod RMGenerateAssemblyEvidence_Type_Assembly
		{
			get
			{
				if(r_MGenerateAssemblyEvidence_Type_Assembly == null)
				{
					r_MGenerateAssemblyEvidence_Type_Assembly = new(this, "GenerateAssemblyEvidence", 0, typeof(System.Type), typeof(System.Reflection.Assembly));
				}
				return r_MGenerateAssemblyEvidence_Type_Assembly;
			}
		}

		/// <summary>
		/// System.Type[] GetHostSuppliedAppDomainEvidenceTypes()
		/// </summary>
		protected RMethod r_MGetHostSuppliedAppDomainEvidenceTypes;
		public virtual RMethod RMGetHostSuppliedAppDomainEvidenceTypes
		{
			get
			{
				if(r_MGetHostSuppliedAppDomainEvidenceTypes == null)
				{
					r_MGetHostSuppliedAppDomainEvidenceTypes = new(this, "GetHostSuppliedAppDomainEvidenceTypes", 0);
				}
				return r_MGetHostSuppliedAppDomainEvidenceTypes;
			}
		}

		/// <summary>
		/// System.Type[] GetHostSuppliedAssemblyEvidenceTypes(System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_MGetHostSuppliedAssemblyEvidenceTypes_Assembly;
		public virtual RMethod RMGetHostSuppliedAssemblyEvidenceTypes_Assembly
		{
			get
			{
				if(r_MGetHostSuppliedAssemblyEvidenceTypes_Assembly == null)
				{
					r_MGetHostSuppliedAssemblyEvidenceTypes_Assembly = new(this, "GetHostSuppliedAssemblyEvidenceTypes", 0, typeof(System.Reflection.Assembly));
				}
				return r_MGetHostSuppliedAssemblyEvidenceTypes_Assembly;
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


        public virtual System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence @applicationEvidence, System.Security.Policy.Evidence @activatorEvidence, System.Security.Policy.TrustManagerContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@applicationEvidence, @activatorEvidence, @context};
            var ___result = RMDetermineApplicationTrust_Evidence_Evidence_TrustManagerContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.ApplicationTrust>(___result);
        }


        public virtual System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence @inputEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputEvidence};
            var ___result = RMProvideAppDomainEvidence_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.Evidence>(___result);
        }


        public virtual System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly @loadedAssembly, System.Security.Policy.Evidence @inputEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loadedAssembly, @inputEvidence};
            var ___result = RMProvideAssemblyEvidence_Assembly_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.Evidence>(___result);
        }


        public virtual System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMResolvePolicy_Evidence.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.PermissionSet>(___result);
        }


        public virtual System.Security.Policy.EvidenceBase GenerateAppDomainEvidence(System.Type @evidenceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidenceType};
            var ___result = RMGenerateAppDomainEvidence_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.EvidenceBase>(___result);
        }


        public virtual System.Security.Policy.EvidenceBase GenerateAssemblyEvidence(System.Type @evidenceType, System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidenceType, @assembly};
            var ___result = RMGenerateAssemblyEvidence_Type_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.EvidenceBase>(___result);
        }


        public virtual System.Type[] GetHostSuppliedAppDomainEvidenceTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHostSuppliedAppDomainEvidenceTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Type[] GetHostSuppliedAssemblyEvidenceTypes(System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly};
            var ___result = RMGetHostSuppliedAssemblyEvidenceTypes_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
