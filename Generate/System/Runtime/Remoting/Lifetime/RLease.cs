using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime
{
	/// <summary>
	/// System.Runtime.Remoting.Lifetime.Lease
	/// </summary>
    public partial class RLease : RMember //
    {

		/// <summary>
		/// System.DateTime _leaseExpireTime
		/// </summary>
		protected RSystem.RDateTime r__leaseExpireTime;
		public virtual RSystem.RDateTime R_leaseExpireTime
		{
			get
			{
				if(r__leaseExpireTime == null)
				{
					r__leaseExpireTime = new(this, "_leaseExpireTime");
					r__leaseExpireTime.SetBelong(this.instance);
				}
				return r__leaseExpireTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.LeaseState _currentState
		/// </summary>
		protected RField r__currentState;
		public virtual RField R_currentState
		{
			get
			{
				if(r__currentState == null)
				{
					r__currentState = new(this, "_currentState");
					r__currentState.SetBelong(this.instance);
				}
				return r__currentState;
			}
		}

		/// <summary>
		/// System.TimeSpan _initialLeaseTime
		/// </summary>
		protected RSystem.RTimeSpan r__initialLeaseTime;
		public virtual RSystem.RTimeSpan R_initialLeaseTime
		{
			get
			{
				if(r__initialLeaseTime == null)
				{
					r__initialLeaseTime = new(this, "_initialLeaseTime");
					r__initialLeaseTime.SetBelong(this.instance);
				}
				return r__initialLeaseTime;
			}
		}

		/// <summary>
		/// System.TimeSpan _renewOnCallTime
		/// </summary>
		protected RSystem.RTimeSpan r__renewOnCallTime;
		public virtual RSystem.RTimeSpan R_renewOnCallTime
		{
			get
			{
				if(r__renewOnCallTime == null)
				{
					r__renewOnCallTime = new(this, "_renewOnCallTime");
					r__renewOnCallTime.SetBelong(this.instance);
				}
				return r__renewOnCallTime;
			}
		}

		/// <summary>
		/// System.TimeSpan _sponsorshipTimeout
		/// </summary>
		protected RSystem.RTimeSpan r__sponsorshipTimeout;
		public virtual RSystem.RTimeSpan R_sponsorshipTimeout
		{
			get
			{
				if(r__sponsorshipTimeout == null)
				{
					r__sponsorshipTimeout = new(this, "_sponsorshipTimeout");
					r__sponsorshipTimeout.SetBelong(this.instance);
				}
				return r__sponsorshipTimeout;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList _sponsors
		/// </summary>
		protected RSystem.RCollections.RArrayList r__sponsors;
		public virtual RSystem.RCollections.RArrayList R_sponsors
		{
			get
			{
				if(r__sponsors == null)
				{
					r__sponsors = new(this, "_sponsors");
					r__sponsors.SetBelong(this.instance);
				}
				return r__sponsors;
			}
		}

		/// <summary>
		/// System.Collections.Queue _renewingSponsors
		/// </summary>
		protected RSystem.RCollections.RQueue r__renewingSponsors;
		public virtual RSystem.RCollections.RQueue R_renewingSponsors
		{
			get
			{
				if(r__renewingSponsors == null)
				{
					r__renewingSponsors = new(this, "_renewingSponsors");
					r__renewingSponsors.SetBelong(this.instance);
				}
				return r__renewingSponsors;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.Lease+RenewalDelegate _renewalDelegate
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RLifetime.RLease.RRenewalDelegate r__renewalDelegate;
		public virtual RSystem.RRuntime.RRemoting.RLifetime.RLease.RRenewalDelegate R_renewalDelegate
		{
			get
			{
				if(r__renewalDelegate == null)
				{
					r__renewalDelegate = new(this, "_renewalDelegate");
					r__renewalDelegate.SetBelong(this.instance);
				}
				return r__renewalDelegate;
			}
		}

		/// <summary>
		/// System.TimeSpan CurrentLeaseTime
		/// </summary>
		protected RSystem.RTimeSpan r_CurrentLeaseTime;
		public virtual RSystem.RTimeSpan RCurrentLeaseTime
		{
			get
			{
				if(r_CurrentLeaseTime == null)
				{
					r_CurrentLeaseTime = new(this, "CurrentLeaseTime", -1);
					r_CurrentLeaseTime.SetBelong(this.instance);
				}
				return r_CurrentLeaseTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.LeaseState CurrentState
		/// </summary>
		protected RProperty r_CurrentState;
		public virtual RProperty RCurrentState
		{
			get
			{
				if(r_CurrentState == null)
				{
					r_CurrentState = new(this, "CurrentState", -1);
					r_CurrentState.SetBelong(this.instance);
				}
				return r_CurrentState;
			}
		}

		/// <summary>
		/// System.TimeSpan InitialLeaseTime
		/// </summary>
		protected RSystem.RTimeSpan r_InitialLeaseTime;
		public virtual RSystem.RTimeSpan RInitialLeaseTime
		{
			get
			{
				if(r_InitialLeaseTime == null)
				{
					r_InitialLeaseTime = new(this, "InitialLeaseTime", -1);
					r_InitialLeaseTime.SetBelong(this.instance);
				}
				return r_InitialLeaseTime;
			}
		}

		/// <summary>
		/// System.TimeSpan RenewOnCallTime
		/// </summary>
		protected RSystem.RTimeSpan r_RenewOnCallTime;
		public virtual RSystem.RTimeSpan RRenewOnCallTime
		{
			get
			{
				if(r_RenewOnCallTime == null)
				{
					r_RenewOnCallTime = new(this, "RenewOnCallTime", -1);
					r_RenewOnCallTime.SetBelong(this.instance);
				}
				return r_RenewOnCallTime;
			}
		}

		/// <summary>
		/// System.TimeSpan SponsorshipTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_SponsorshipTimeout;
		public virtual RSystem.RTimeSpan RSponsorshipTimeout
		{
			get
			{
				if(r_SponsorshipTimeout == null)
				{
					r_SponsorshipTimeout = new(this, "SponsorshipTimeout", -1);
					r_SponsorshipTimeout.SetBelong(this.instance);
				}
				return r_SponsorshipTimeout;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Void Activate()
		/// </summary>
		protected RMethod r_Activate;
		public virtual RMethod RActivate
		{
			get
			{
				if(r_Activate == null)
				{
					r_Activate = new(this, "Activate", 0);
					r_Activate.SetBelong(this.instance);
				}
				return r_Activate;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_Register_ISponsor;
		public virtual RMethod RRegister_ISponsor
		{
			get
			{
				if(r_Register_ISponsor == null)
				{
					r_Register_ISponsor = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_Register_ISponsor.SetBelong(this.instance);
				}
				return r_Register_ISponsor;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor, System.TimeSpan)
		/// </summary>
		protected RMethod r_Register_ISponsor_TimeSpan;
		public virtual RMethod RRegister_ISponsor_TimeSpan
		{
			get
			{
				if(r_Register_ISponsor_TimeSpan == null)
				{
					r_Register_ISponsor_TimeSpan = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor), typeof(System.TimeSpan));
					r_Register_ISponsor_TimeSpan.SetBelong(this.instance);
				}
				return r_Register_ISponsor_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan Renew(System.TimeSpan)
		/// </summary>
		protected RMethod r_Renew_TimeSpan;
		public virtual RMethod RRenew_TimeSpan
		{
			get
			{
				if(r_Renew_TimeSpan == null)
				{
					r_Renew_TimeSpan = new(this, "Renew", 0, typeof(System.TimeSpan));
					r_Renew_TimeSpan.SetBelong(this.instance);
				}
				return r_Renew_TimeSpan;
			}
		}

		/// <summary>
		/// Void Unregister(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_Unregister_ISponsor;
		public virtual RMethod RUnregister_ISponsor
		{
			get
			{
				if(r_Unregister_ISponsor == null)
				{
					r_Unregister_ISponsor = new(this, "Unregister", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_Unregister_ISponsor.SetBelong(this.instance);
				}
				return r_Unregister_ISponsor;
			}
		}

		/// <summary>
		/// Void UpdateState()
		/// </summary>
		protected RMethod r_UpdateState;
		public virtual RMethod RUpdateState
		{
			get
			{
				if(r_UpdateState == null)
				{
					r_UpdateState = new(this, "UpdateState", 0);
					r_UpdateState.SetBelong(this.instance);
				}
				return r_UpdateState;
			}
		}

		/// <summary>
		/// Void CheckNextSponsor()
		/// </summary>
		protected RMethod r_CheckNextSponsor;
		public virtual RMethod RCheckNextSponsor
		{
			get
			{
				if(r_CheckNextSponsor == null)
				{
					r_CheckNextSponsor = new(this, "CheckNextSponsor", 0);
					r_CheckNextSponsor.SetBelong(this.instance);
				}
				return r_CheckNextSponsor;
			}
		}

		/// <summary>
		/// Void ProcessSponsorResponse(System.Object, Boolean)
		/// </summary>
		protected RMethod r_ProcessSponsorResponse_Object_Boolean;
		public virtual RMethod RProcessSponsorResponse_Object_Boolean
		{
			get
			{
				if(r_ProcessSponsorResponse_Object_Boolean == null)
				{
					r_ProcessSponsorResponse_Object_Boolean = new(this, "ProcessSponsorResponse", 0, typeof(System.Object), typeof(System.Boolean));
					r_ProcessSponsorResponse_Object_Boolean.SetBelong(this.instance);
				}
				return r_ProcessSponsorResponse_Object_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_GetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_CreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_CreateObjRef_Type == null)
				{
					r_CreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_CreateObjRef_Type.SetBelong(this.instance);
				}
				return r_CreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_GetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_GetLifetimeService == null)
				{
					r_GetLifetimeService = new(this, "GetLifetimeService", 0);
					r_GetLifetimeService.SetBelong(this.instance);
				}
				return r_GetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_InitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_InitializeLifetimeService == null)
				{
					r_InitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_InitializeLifetimeService.SetBelong(this.instance);
				}
				return r_InitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_MemberwiseClone_Boolean == null)
				{
					r_MemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MemberwiseClone_Boolean;
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


        public RLease() : base("System.Runtime.Remoting.Lifetime.Lease")
        {
        }

        public RLease(System.Object instance) : base("System.Runtime.Remoting.Lifetime.Lease")
		{
            SetInstance(instance);
		}

        public RLease(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLease(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Activate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RActivate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRegister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor  @obj, System.TimeSpan  @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @renewalTime};
            var ___result = RRegister_ISponsor_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.TimeSpan Renew(System.TimeSpan  @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renewalTime};
            var ___result = RRenew_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual void Unregister(System.Runtime.Remoting.Lifetime.ISponsor  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RUnregister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNextSponsor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckNextSponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessSponsorResponse(System.Object  @state, System.Boolean  @timedOut)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @timedOut};
            var ___result = RProcessSponsorResponse_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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
