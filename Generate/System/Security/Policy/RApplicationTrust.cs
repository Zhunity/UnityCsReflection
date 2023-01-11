using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.ApplicationTrust
	/// </summary>
    public partial class RApplicationTrust : RMember //
    {

		/// <summary>
		/// System.ApplicationIdentity _appid
		/// </summary>
		protected RSystem.RApplicationIdentity r__appid;
		public virtual RSystem.RApplicationIdentity R_appid
		{
			get
			{
				if(r__appid == null)
				{
					r__appid = new(this, "_appid");
					r__appid.SetBelong(this.instance);
				}
				return r__appid;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement _defaultPolicy
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyStatement r__defaultPolicy;
		public virtual RSystem.RSecurity.RPolicy.RPolicyStatement R_defaultPolicy
		{
			get
			{
				if(r__defaultPolicy == null)
				{
					r__defaultPolicy = new(this, "_defaultPolicy");
					r__defaultPolicy.SetBelong(this.instance);
				}
				return r__defaultPolicy;
			}
		}

		/// <summary>
		/// System.Object _xtranfo
		/// </summary>
		protected RSystem.RObject r__xtranfo;
		public virtual RSystem.RObject R_xtranfo
		{
			get
			{
				if(r__xtranfo == null)
				{
					r__xtranfo = new(this, "_xtranfo");
					r__xtranfo.SetBelong(this.instance);
				}
				return r__xtranfo;
			}
		}

		/// <summary>
		/// System.Boolean _trustrun
		/// </summary>
		protected RSystem.RBoolean r__trustrun;
		public virtual RSystem.RBoolean R_trustrun
		{
			get
			{
				if(r__trustrun == null)
				{
					r__trustrun = new(this, "_trustrun");
					r__trustrun.SetBelong(this.instance);
				}
				return r__trustrun;
			}
		}

		/// <summary>
		/// System.Boolean _persist
		/// </summary>
		protected RSystem.RBoolean r__persist;
		public virtual RSystem.RBoolean R_persist
		{
			get
			{
				if(r__persist == null)
				{
					r__persist = new(this, "_persist");
					r__persist.SetBelong(this.instance);
				}
				return r__persist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Security.Policy.StrongName] fullTrustAssemblies
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RSecurity.RPolicy.RStrongName> r_fullTrustAssemblies;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RSecurity.RPolicy.RStrongName> RfullTrustAssemblies
		{
			get
			{
				if(r_fullTrustAssemblies == null)
				{
					r_fullTrustAssemblies = new(this, "fullTrustAssemblies");
					r_fullTrustAssemblies.SetBelong(this.instance);
				}
				return r_fullTrustAssemblies;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity ApplicationIdentity
		/// </summary>
		protected RSystem.RApplicationIdentity r_ApplicationIdentity;
		public virtual RSystem.RApplicationIdentity RApplicationIdentity
		{
			get
			{
				if(r_ApplicationIdentity == null)
				{
					r_ApplicationIdentity = new(this, "ApplicationIdentity", -1);
					r_ApplicationIdentity.SetBelong(this.instance);
				}
				return r_ApplicationIdentity;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement DefaultGrantSet
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyStatement r_DefaultGrantSet;
		public virtual RSystem.RSecurity.RPolicy.RPolicyStatement RDefaultGrantSet
		{
			get
			{
				if(r_DefaultGrantSet == null)
				{
					r_DefaultGrantSet = new(this, "DefaultGrantSet", -1);
					r_DefaultGrantSet.SetBelong(this.instance);
				}
				return r_DefaultGrantSet;
			}
		}

		/// <summary>
		/// System.Object ExtraInfo
		/// </summary>
		protected RSystem.RObject r_ExtraInfo;
		public virtual RSystem.RObject RExtraInfo
		{
			get
			{
				if(r_ExtraInfo == null)
				{
					r_ExtraInfo = new(this, "ExtraInfo", -1);
					r_ExtraInfo.SetBelong(this.instance);
				}
				return r_ExtraInfo;
			}
		}

		/// <summary>
		/// Boolean IsApplicationTrustedToRun
		/// </summary>
		protected RSystem.RBoolean r_IsApplicationTrustedToRun;
		public virtual RSystem.RBoolean RIsApplicationTrustedToRun
		{
			get
			{
				if(r_IsApplicationTrustedToRun == null)
				{
					r_IsApplicationTrustedToRun = new(this, "IsApplicationTrustedToRun", -1);
					r_IsApplicationTrustedToRun.SetBelong(this.instance);
				}
				return r_IsApplicationTrustedToRun;
			}
		}

		/// <summary>
		/// Boolean Persist
		/// </summary>
		protected RSystem.RBoolean r_Persist;
		public virtual RSystem.RBoolean RPersist
		{
			get
			{
				if(r_Persist == null)
				{
					r_Persist = new(this, "Persist", -1);
					r_Persist.SetBelong(this.instance);
				}
				return r_Persist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Security.Policy.StrongName] FullTrustAssemblies
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RSecurity.RPolicy.RStrongName> r_FullTrustAssemblies;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RSecurity.RPolicy.RStrongName> RFullTrustAssemblies
		{
			get
			{
				if(r_FullTrustAssemblies == null)
				{
					r_FullTrustAssemblies = new(this, "FullTrustAssemblies", -1);
					r_FullTrustAssemblies.SetBelong(this.instance);
				}
				return r_FullTrustAssemblies;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_FromXml_SecurityElement;
		public virtual RMethod RFromXml_SecurityElement
		{
			get
			{
				if(r_FromXml_SecurityElement == null)
				{
					r_FromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_FromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_FromXml_SecurityElement;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_ToXml;
		public virtual RMethod RToXml
		{
			get
			{
				if(r_ToXml == null)
				{
					r_ToXml = new(this, "ToXml", 0);
					r_ToXml.SetBelong(this.instance);
				}
				return r_ToXml;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement GetDefaultGrantSet()
		/// </summary>
		protected RMethod r_GetDefaultGrantSet;
		public virtual RMethod RGetDefaultGrantSet
		{
			get
			{
				if(r_GetDefaultGrantSet == null)
				{
					r_GetDefaultGrantSet = new(this, "GetDefaultGrantSet", 0);
					r_GetDefaultGrantSet.SetBelong(this.instance);
				}
				return r_GetDefaultGrantSet;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
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


        public RApplicationTrust() : base("System.Security.Policy.ApplicationTrust")
        {
        }

        public RApplicationTrust(System.Object instance) : base("System.Security.Policy.ApplicationTrust")
		{
            SetInstance(instance);
		}

        public RApplicationTrust(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RApplicationTrust(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void FromXml(System.Security.SecurityElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.Policy.PolicyStatement GetDefaultGrantSet()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultGrantSet.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual System.Security.Policy.EvidenceBase Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
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
