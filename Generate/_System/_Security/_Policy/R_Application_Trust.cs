
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.ApplicationTrust
	/// </summary>
    public partial class RApplicationTrust : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Policy.ApplicationTrust);
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


		/// <summary>
		/// System.ApplicationIdentity _appid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_F_appid;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RF_appid
		{
			get
			{
				if(r_F_appid == null)
				{
					r_F_appid = new(this, "_appid");
				}
				return r_F_appid;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement _defaultPolicy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement r_F_defaultPolicy;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement RF_defaultPolicy
		{
			get
			{
				if(r_F_defaultPolicy == null)
				{
					r_F_defaultPolicy = new(this, "_defaultPolicy");
				}
				return r_F_defaultPolicy;
			}
		}

		/// <summary>
		/// System.Object _xtranfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_xtranfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_xtranfo
		{
			get
			{
				if(r_F_xtranfo == null)
				{
					r_F_xtranfo = new(this, "_xtranfo");
				}
				return r_F_xtranfo;
			}
		}

		/// <summary>
		/// System.Boolean _trustrun
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_trustrun;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_trustrun
		{
			get
			{
				if(r_F_trustrun == null)
				{
					r_F_trustrun = new(this, "_trustrun");
				}
				return r_F_trustrun;
			}
		}

		/// <summary>
		/// System.Boolean _persist
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_persist;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_persist
		{
			get
			{
				if(r_F_persist == null)
				{
					r_F_persist = new(this, "_persist");
				}
				return r_F_persist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Security.Policy.StrongName] fullTrustAssemblies
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RStrongName> r_FfullTrustAssemblies;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RStrongName> RFfullTrustAssemblies
		{
			get
			{
				if(r_FfullTrustAssemblies == null)
				{
					r_FfullTrustAssemblies = new(this, "fullTrustAssemblies");
				}
				return r_FfullTrustAssemblies;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity ApplicationIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_PApplicationIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RPApplicationIdentity
		{
			get
			{
				if(r_PApplicationIdentity == null)
				{
					r_PApplicationIdentity = new(this, "ApplicationIdentity", -1);
				}
				return r_PApplicationIdentity;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement DefaultGrantSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement r_PDefaultGrantSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement RPDefaultGrantSet
		{
			get
			{
				if(r_PDefaultGrantSet == null)
				{
					r_PDefaultGrantSet = new(this, "DefaultGrantSet", -1);
				}
				return r_PDefaultGrantSet;
			}
		}

		/// <summary>
		/// System.Object ExtraInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PExtraInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPExtraInfo
		{
			get
			{
				if(r_PExtraInfo == null)
				{
					r_PExtraInfo = new(this, "ExtraInfo", -1);
				}
				return r_PExtraInfo;
			}
		}

		/// <summary>
		/// Boolean IsApplicationTrustedToRun
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsApplicationTrustedToRun;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsApplicationTrustedToRun
		{
			get
			{
				if(r_PIsApplicationTrustedToRun == null)
				{
					r_PIsApplicationTrustedToRun = new(this, "IsApplicationTrustedToRun", -1);
				}
				return r_PIsApplicationTrustedToRun;
			}
		}

		/// <summary>
		/// Boolean Persist
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PPersist;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPPersist
		{
			get
			{
				if(r_PPersist == null)
				{
					r_PPersist = new(this, "Persist", -1);
				}
				return r_PPersist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Security.Policy.StrongName] FullTrustAssemblies
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RStrongName> r_PFullTrustAssemblies;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RStrongName> RPFullTrustAssemblies
		{
			get
			{
				if(r_PFullTrustAssemblies == null)
				{
					r_PFullTrustAssemblies = new(this, "FullTrustAssemblies", -1);
				}
				return r_PFullTrustAssemblies;
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
				}
				return r_MFromXml_SecurityElement;
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
				}
				return r_MToXml;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement GetDefaultGrantSet()
		/// </summary>
		protected RMethod r_MGetDefaultGrantSet;
		public virtual RMethod RMGetDefaultGrantSet
		{
			get
			{
				if(r_MGetDefaultGrantSet == null)
				{
					r_MGetDefaultGrantSet = new(this, "GetDefaultGrantSet", 0);
				}
				return r_MGetDefaultGrantSet;
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
				}
				return r_MClone;
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


        public virtual void FromXml(System.Security.SecurityElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.Policy.PolicyStatement GetDefaultGrantSet()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultGrantSet.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual System.Security.Policy.EvidenceBase Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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
