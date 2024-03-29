
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Policy.TrustManagerContext
	/// </summary>
    public partial class RTrustManagerContext : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Policy.TrustManagerContext);
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


		/// <summary>
		/// System.Boolean _ignorePersistedDecision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_ignorePersistedDecision;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_ignorePersistedDecision
		{
			get
			{
				if(r_F_ignorePersistedDecision == null)
				{
					r_F_ignorePersistedDecision = new(this, "_ignorePersistedDecision");
				}
				return r_F_ignorePersistedDecision;
			}
		}

		/// <summary>
		/// System.Boolean _noPrompt
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_noPrompt;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_noPrompt
		{
			get
			{
				if(r_F_noPrompt == null)
				{
					r_F_noPrompt = new(this, "_noPrompt");
				}
				return r_F_noPrompt;
			}
		}

		/// <summary>
		/// System.Boolean _keepAlive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_keepAlive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_keepAlive
		{
			get
			{
				if(r_F_keepAlive == null)
				{
					r_F_keepAlive = new(this, "_keepAlive");
				}
				return r_F_keepAlive;
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
		/// System.ApplicationIdentity _previousId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_F_previousId;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RF_previousId
		{
			get
			{
				if(r_F_previousId == null)
				{
					r_F_previousId = new(this, "_previousId");
				}
				return r_F_previousId;
			}
		}

		/// <summary>
		/// System.Security.Policy.TrustManagerUIContext _ui
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RTrustManagerUIContext r_F_ui;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RTrustManagerUIContext RF_ui
		{
			get
			{
				if(r_F_ui == null)
				{
					r_F_ui = new(this, "_ui");
				}
				return r_F_ui;
			}
		}

		/// <summary>
		/// Boolean IgnorePersistedDecision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIgnorePersistedDecision;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIgnorePersistedDecision
		{
			get
			{
				if(r_PIgnorePersistedDecision == null)
				{
					r_PIgnorePersistedDecision = new(this, "IgnorePersistedDecision", -1);
				}
				return r_PIgnorePersistedDecision;
			}
		}

		/// <summary>
		/// Boolean KeepAlive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PKeepAlive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPKeepAlive
		{
			get
			{
				if(r_PKeepAlive == null)
				{
					r_PKeepAlive = new(this, "KeepAlive", -1);
				}
				return r_PKeepAlive;
			}
		}

		/// <summary>
		/// Boolean NoPrompt
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PNoPrompt;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPNoPrompt
		{
			get
			{
				if(r_PNoPrompt == null)
				{
					r_PNoPrompt = new(this, "NoPrompt", -1);
				}
				return r_PNoPrompt;
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
		/// System.ApplicationIdentity PreviousApplicationIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_PPreviousApplicationIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RPPreviousApplicationIdentity
		{
			get
			{
				if(r_PPreviousApplicationIdentity == null)
				{
					r_PPreviousApplicationIdentity = new(this, "PreviousApplicationIdentity", -1);
				}
				return r_PPreviousApplicationIdentity;
			}
		}

		/// <summary>
		/// System.Security.Policy.TrustManagerUIContext UIContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RTrustManagerUIContext r_PUIContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RTrustManagerUIContext RPUIContext
		{
			get
			{
				if(r_PUIContext == null)
				{
					r_PUIContext = new(this, "UIContext", -1);
				}
				return r_PUIContext;
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
