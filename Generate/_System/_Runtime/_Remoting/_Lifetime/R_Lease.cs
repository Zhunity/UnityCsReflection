
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
		protected SMFrame.Editor.Refleaction.RSystem.RDateTime r_F_leaseExpireTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RDateTime RF_leaseExpireTime
		{
			get
			{
				if(r_F_leaseExpireTime == null)
				{
					r_F_leaseExpireTime = new(this, "_leaseExpireTime");
					r_F_leaseExpireTime.SetBelong(this.instance);
				}
				return r_F_leaseExpireTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.LeaseState _currentState
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLeaseState r_F_currentState;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLeaseState RF_currentState
		{
			get
			{
				if(r_F_currentState == null)
				{
					r_F_currentState = new(this, "_currentState");
					r_F_currentState.SetBelong(this.instance);
				}
				return r_F_currentState;
			}
		}

		/// <summary>
		/// System.TimeSpan _initialLeaseTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_F_initialLeaseTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RF_initialLeaseTime
		{
			get
			{
				if(r_F_initialLeaseTime == null)
				{
					r_F_initialLeaseTime = new(this, "_initialLeaseTime");
					r_F_initialLeaseTime.SetBelong(this.instance);
				}
				return r_F_initialLeaseTime;
			}
		}

		/// <summary>
		/// System.TimeSpan _renewOnCallTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_F_renewOnCallTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RF_renewOnCallTime
		{
			get
			{
				if(r_F_renewOnCallTime == null)
				{
					r_F_renewOnCallTime = new(this, "_renewOnCallTime");
					r_F_renewOnCallTime.SetBelong(this.instance);
				}
				return r_F_renewOnCallTime;
			}
		}

		/// <summary>
		/// System.TimeSpan _sponsorshipTimeout
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_F_sponsorshipTimeout;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RF_sponsorshipTimeout
		{
			get
			{
				if(r_F_sponsorshipTimeout == null)
				{
					r_F_sponsorshipTimeout = new(this, "_sponsorshipTimeout");
					r_F_sponsorshipTimeout.SetBelong(this.instance);
				}
				return r_F_sponsorshipTimeout;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList _sponsors
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RArrayList r_F_sponsors;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RArrayList RF_sponsors
		{
			get
			{
				if(r_F_sponsors == null)
				{
					r_F_sponsors = new(this, "_sponsors");
					r_F_sponsors.SetBelong(this.instance);
				}
				return r_F_sponsors;
			}
		}

		/// <summary>
		/// System.Collections.Queue _renewingSponsors
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RQueue r_F_renewingSponsors;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RQueue RF_renewingSponsors
		{
			get
			{
				if(r_F_renewingSponsors == null)
				{
					r_F_renewingSponsors = new(this, "_renewingSponsors");
					r_F_renewingSponsors.SetBelong(this.instance);
				}
				return r_F_renewingSponsors;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.Lease+RenewalDelegate _renewalDelegate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLease.RRenewalDelegate r_F_renewalDelegate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLease.RRenewalDelegate RF_renewalDelegate
		{
			get
			{
				if(r_F_renewalDelegate == null)
				{
					r_F_renewalDelegate = new(this, "_renewalDelegate");
					r_F_renewalDelegate.SetBelong(this.instance);
				}
				return r_F_renewalDelegate;
			}
		}

		/// <summary>
		/// System.TimeSpan CurrentLeaseTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_PCurrentLeaseTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RPCurrentLeaseTime
		{
			get
			{
				if(r_PCurrentLeaseTime == null)
				{
					r_PCurrentLeaseTime = new(this, "CurrentLeaseTime", -1);
					r_PCurrentLeaseTime.SetBelong(this.instance);
				}
				return r_PCurrentLeaseTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Lifetime.LeaseState CurrentState
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLeaseState r_PCurrentState;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RLifetime.RLeaseState RPCurrentState
		{
			get
			{
				if(r_PCurrentState == null)
				{
					r_PCurrentState = new(this, "CurrentState", -1);
					r_PCurrentState.SetBelong(this.instance);
				}
				return r_PCurrentState;
			}
		}

		/// <summary>
		/// System.TimeSpan InitialLeaseTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_PInitialLeaseTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RPInitialLeaseTime
		{
			get
			{
				if(r_PInitialLeaseTime == null)
				{
					r_PInitialLeaseTime = new(this, "InitialLeaseTime", -1);
					r_PInitialLeaseTime.SetBelong(this.instance);
				}
				return r_PInitialLeaseTime;
			}
		}

		/// <summary>
		/// System.TimeSpan RenewOnCallTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_PRenewOnCallTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RPRenewOnCallTime
		{
			get
			{
				if(r_PRenewOnCallTime == null)
				{
					r_PRenewOnCallTime = new(this, "RenewOnCallTime", -1);
					r_PRenewOnCallTime.SetBelong(this.instance);
				}
				return r_PRenewOnCallTime;
			}
		}

		/// <summary>
		/// System.TimeSpan SponsorshipTimeout
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RTimeSpan r_PSponsorshipTimeout;
		public virtual SMFrame.Editor.Refleaction.RSystem.RTimeSpan RPSponsorshipTimeout
		{
			get
			{
				if(r_PSponsorshipTimeout == null)
				{
					r_PSponsorshipTimeout = new(this, "SponsorshipTimeout", -1);
					r_PSponsorshipTimeout.SetBelong(this.instance);
				}
				return r_PSponsorshipTimeout;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity r_PObjectIdentity;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity RPObjectIdentity
		{
			get
			{
				if(r_PObjectIdentity == null)
				{
					r_PObjectIdentity = new(this, "ObjectIdentity", -1);
					r_PObjectIdentity.SetBelong(this.instance);
				}
				return r_PObjectIdentity;
			}
		}

		/// <summary>
		/// Void Activate()
		/// </summary>
		protected RMethod r_MActivate;
		public virtual RMethod RMActivate
		{
			get
			{
				if(r_MActivate == null)
				{
					r_MActivate = new(this, "Activate", 0);
					r_MActivate.SetBelong(this.instance);
				}
				return r_MActivate;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_MRegister_ISponsor;
		public virtual RMethod RMRegister_ISponsor
		{
			get
			{
				if(r_MRegister_ISponsor == null)
				{
					r_MRegister_ISponsor = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_MRegister_ISponsor.SetBelong(this.instance);
				}
				return r_MRegister_ISponsor;
			}
		}

		/// <summary>
		/// Void Register(System.Runtime.Remoting.Lifetime.ISponsor, System.TimeSpan)
		/// </summary>
		protected RMethod r_MRegister_ISponsor_TimeSpan;
		public virtual RMethod RMRegister_ISponsor_TimeSpan
		{
			get
			{
				if(r_MRegister_ISponsor_TimeSpan == null)
				{
					r_MRegister_ISponsor_TimeSpan = new(this, "Register", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor), typeof(System.TimeSpan));
					r_MRegister_ISponsor_TimeSpan.SetBelong(this.instance);
				}
				return r_MRegister_ISponsor_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan Renew(System.TimeSpan)
		/// </summary>
		protected RMethod r_MRenew_TimeSpan;
		public virtual RMethod RMRenew_TimeSpan
		{
			get
			{
				if(r_MRenew_TimeSpan == null)
				{
					r_MRenew_TimeSpan = new(this, "Renew", 0, typeof(System.TimeSpan));
					r_MRenew_TimeSpan.SetBelong(this.instance);
				}
				return r_MRenew_TimeSpan;
			}
		}

		/// <summary>
		/// Void Unregister(System.Runtime.Remoting.Lifetime.ISponsor)
		/// </summary>
		protected RMethod r_MUnregister_ISponsor;
		public virtual RMethod RMUnregister_ISponsor
		{
			get
			{
				if(r_MUnregister_ISponsor == null)
				{
					r_MUnregister_ISponsor = new(this, "Unregister", 0, typeof(System.Runtime.Remoting.Lifetime.ISponsor));
					r_MUnregister_ISponsor.SetBelong(this.instance);
				}
				return r_MUnregister_ISponsor;
			}
		}

		/// <summary>
		/// Void UpdateState()
		/// </summary>
		protected RMethod r_MUpdateState;
		public virtual RMethod RMUpdateState
		{
			get
			{
				if(r_MUpdateState == null)
				{
					r_MUpdateState = new(this, "UpdateState", 0);
					r_MUpdateState.SetBelong(this.instance);
				}
				return r_MUpdateState;
			}
		}

		/// <summary>
		/// Void CheckNextSponsor()
		/// </summary>
		protected RMethod r_MCheckNextSponsor;
		public virtual RMethod RMCheckNextSponsor
		{
			get
			{
				if(r_MCheckNextSponsor == null)
				{
					r_MCheckNextSponsor = new(this, "CheckNextSponsor", 0);
					r_MCheckNextSponsor.SetBelong(this.instance);
				}
				return r_MCheckNextSponsor;
			}
		}

		/// <summary>
		/// Void ProcessSponsorResponse(System.Object, Boolean)
		/// </summary>
		protected RMethod r_MProcessSponsorResponse_Object_Boolean;
		public virtual RMethod RMProcessSponsorResponse_Object_Boolean
		{
			get
			{
				if(r_MProcessSponsorResponse_Object_Boolean == null)
				{
					r_MProcessSponsorResponse_Object_Boolean = new(this, "ProcessSponsorResponse", 0, typeof(System.Object), typeof(System.Boolean));
					r_MProcessSponsorResponse_Object_Boolean.SetBelong(this.instance);
				}
				return r_MProcessSponsorResponse_Object_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RMGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_MCreateObjRef_Type;
		public virtual RMethod RMCreateObjRef_Type
		{
			get
			{
				if(r_MCreateObjRef_Type == null)
				{
					r_MCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_MCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_MCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_MGetLifetimeService;
		public virtual RMethod RMGetLifetimeService
		{
			get
			{
				if(r_MGetLifetimeService == null)
				{
					r_MGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_MGetLifetimeService.SetBelong(this.instance);
				}
				return r_MGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_MInitializeLifetimeService;
		public virtual RMethod RMInitializeLifetimeService
		{
			get
			{
				if(r_MInitializeLifetimeService == null)
				{
					r_MInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_MInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_MInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MMemberwiseClone_Boolean;
		public virtual RMethod RMMemberwiseClone_Boolean
		{
			get
			{
				if(r_MMemberwiseClone_Boolean == null)
				{
					r_MMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MMemberwiseClone_Boolean;
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
            var ___result = RMActivate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMRegister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register(System.Runtime.Remoting.Lifetime.ISponsor @obj, System.TimeSpan @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @renewalTime};
            var ___result = RMRegister_ISponsor_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.TimeSpan Renew(System.TimeSpan @renewalTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renewalTime};
            var ___result = RMRenew_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual void Unregister(System.Runtime.Remoting.Lifetime.ISponsor @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMUnregister_ISponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNextSponsor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckNextSponsor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessSponsorResponse(System.Object @state, System.Boolean @timedOut)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @timedOut};
            var ___result = RMProcessSponsorResponse_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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