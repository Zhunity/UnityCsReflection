using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.TrustManagerContext
	/// </summary>
    public partial class RTrustManagerContext : RMember //
    {

		/// <summary>
		/// System.Boolean _ignorePersistedDecision
		/// </summary>
		protected RField r__ignorePersistedDecision;
		public virtual RField R_ignorePersistedDecision
		{
			get
			{
				if(r__ignorePersistedDecision == null)
				{
					r__ignorePersistedDecision = new(this, "_ignorePersistedDecision");
					r__ignorePersistedDecision.SetBelong(this.instance);
				}
				return r__ignorePersistedDecision;
			}
		}

		/// <summary>
		/// System.Boolean _noPrompt
		/// </summary>
		protected RField r__noPrompt;
		public virtual RField R_noPrompt
		{
			get
			{
				if(r__noPrompt == null)
				{
					r__noPrompt = new(this, "_noPrompt");
					r__noPrompt.SetBelong(this.instance);
				}
				return r__noPrompt;
			}
		}

		/// <summary>
		/// System.Boolean _keepAlive
		/// </summary>
		protected RField r__keepAlive;
		public virtual RField R_keepAlive
		{
			get
			{
				if(r__keepAlive == null)
				{
					r__keepAlive = new(this, "_keepAlive");
					r__keepAlive.SetBelong(this.instance);
				}
				return r__keepAlive;
			}
		}

		/// <summary>
		/// System.Boolean _persist
		/// </summary>
		protected RField r__persist;
		public virtual RField R_persist
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
		/// System.ApplicationIdentity _previousId
		/// </summary>
		protected RSystem.RApplicationIdentity r__previousId;
		public virtual RSystem.RApplicationIdentity R_previousId
		{
			get
			{
				if(r__previousId == null)
				{
					r__previousId = new(this, "_previousId");
					r__previousId.SetBelong(this.instance);
				}
				return r__previousId;
			}
		}

		/// <summary>
		/// System.Security.Policy.TrustManagerUIContext _ui
		/// </summary>
		protected RField r__ui;
		public virtual RField R_ui
		{
			get
			{
				if(r__ui == null)
				{
					r__ui = new(this, "_ui");
					r__ui.SetBelong(this.instance);
				}
				return r__ui;
			}
		}

		/// <summary>
		/// Boolean IgnorePersistedDecision
		/// </summary>
		protected RProperty r_IgnorePersistedDecision;
		public virtual RProperty RIgnorePersistedDecision
		{
			get
			{
				if(r_IgnorePersistedDecision == null)
				{
					r_IgnorePersistedDecision = new(this, "IgnorePersistedDecision", -1);
					r_IgnorePersistedDecision.SetBelong(this.instance);
				}
				return r_IgnorePersistedDecision;
			}
		}

		/// <summary>
		/// Boolean KeepAlive
		/// </summary>
		protected RProperty r_KeepAlive;
		public virtual RProperty RKeepAlive
		{
			get
			{
				if(r_KeepAlive == null)
				{
					r_KeepAlive = new(this, "KeepAlive", -1);
					r_KeepAlive.SetBelong(this.instance);
				}
				return r_KeepAlive;
			}
		}

		/// <summary>
		/// Boolean NoPrompt
		/// </summary>
		protected RProperty r_NoPrompt;
		public virtual RProperty RNoPrompt
		{
			get
			{
				if(r_NoPrompt == null)
				{
					r_NoPrompt = new(this, "NoPrompt", -1);
					r_NoPrompt.SetBelong(this.instance);
				}
				return r_NoPrompt;
			}
		}

		/// <summary>
		/// Boolean Persist
		/// </summary>
		protected RProperty r_Persist;
		public virtual RProperty RPersist
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
		/// System.ApplicationIdentity PreviousApplicationIdentity
		/// </summary>
		protected RSystem.RApplicationIdentity r_PreviousApplicationIdentity;
		public virtual RSystem.RApplicationIdentity RPreviousApplicationIdentity
		{
			get
			{
				if(r_PreviousApplicationIdentity == null)
				{
					r_PreviousApplicationIdentity = new(this, "PreviousApplicationIdentity", -1);
					r_PreviousApplicationIdentity.SetBelong(this.instance);
				}
				return r_PreviousApplicationIdentity;
			}
		}

		/// <summary>
		/// System.Security.Policy.TrustManagerUIContext UIContext
		/// </summary>
		protected RProperty r_UIContext;
		public virtual RProperty RUIContext
		{
			get
			{
				if(r_UIContext == null)
				{
					r_UIContext = new(this, "UIContext", -1);
					r_UIContext.SetBelong(this.instance);
				}
				return r_UIContext;
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


        public RTrustManagerContext() : base("System.Security.Policy.TrustManagerContext")
        {
        }

        public RTrustManagerContext(System.Object instance) : base("System.Security.Policy.TrustManagerContext")
		{
            SetInstance(instance);
		}

        public RTrustManagerContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTrustManagerContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
