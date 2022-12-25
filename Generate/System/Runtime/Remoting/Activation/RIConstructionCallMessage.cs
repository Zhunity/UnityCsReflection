using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation
{
	/// <summary>
	/// System.Runtime.Remoting.Activation.IConstructionCallMessage
	/// </summary>
    public partial class RIConstructionCallMessage : RMember //
    {

		/// <summary>
		/// System.Type ActivationType
		/// </summary>
		protected RSystem.RType r_ActivationType;
		public virtual RSystem.RType RActivationType
		{
			get
			{
				if(r_ActivationType == null)
				{
					r_ActivationType = new(this, "ActivationType", -1);
					r_ActivationType.SetBelong(this.instance);
				}
				return r_ActivationType;
			}
		}

		/// <summary>
		/// System.String ActivationTypeName
		/// </summary>
		protected RProperty r_ActivationTypeName;
		public virtual RProperty RActivationTypeName
		{
			get
			{
				if(r_ActivationTypeName == null)
				{
					r_ActivationTypeName = new(this, "ActivationTypeName", -1);
					r_ActivationTypeName.SetBelong(this.instance);
				}
				return r_ActivationTypeName;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Activation.IActivator Activator
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RActivation.RIActivator r_Activator;
		public virtual RSystem.RRuntime.RRemoting.RActivation.RIActivator RActivator
		{
			get
			{
				if(r_Activator == null)
				{
					r_Activator = new(this, "Activator", -1);
					r_Activator.SetBelong(this.instance);
				}
				return r_Activator;
			}
		}

		/// <summary>
		/// System.Object[] CallSiteActivationAttributes
		/// </summary>
		protected RPropertyArray<RSystem.RObject> r_CallSiteActivationAttributes;
		public virtual RPropertyArray<RSystem.RObject> RCallSiteActivationAttributes
		{
			get
			{
				if(r_CallSiteActivationAttributes == null)
				{
					r_CallSiteActivationAttributes = new(this, "CallSiteActivationAttributes", -1);
					r_CallSiteActivationAttributes.SetBelong(this.instance);
				}
				return r_CallSiteActivationAttributes;
			}
		}

		/// <summary>
		/// System.Collections.IList ContextProperties
		/// </summary>
		protected RSystem.RCollections.RIList r_ContextProperties;
		public virtual RSystem.RCollections.RIList RContextProperties
		{
			get
			{
				if(r_ContextProperties == null)
				{
					r_ContextProperties = new(this, "ContextProperties", -1);
					r_ContextProperties.SetBelong(this.instance);
				}
				return r_ContextProperties;
			}
		}


        public RIConstructionCallMessage() : base("System.Runtime.Remoting.Activation.IConstructionCallMessage")
        {
        }

        public RIConstructionCallMessage(System.Object instance) : base("System.Runtime.Remoting.Activation.IConstructionCallMessage")
		{
            SetInstance(instance);
		}

        public RIConstructionCallMessage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIConstructionCallMessage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
