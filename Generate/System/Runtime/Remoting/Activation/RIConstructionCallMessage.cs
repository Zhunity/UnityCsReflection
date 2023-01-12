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
		protected RSystem.RType r_PActivationType;
		public virtual RSystem.RType RPActivationType
		{
			get
			{
				if(r_PActivationType == null)
				{
					r_PActivationType = new(this, "ActivationType", -1);
					r_PActivationType.SetBelong(this.instance);
				}
				return r_PActivationType;
			}
		}

		/// <summary>
		/// System.String ActivationTypeName
		/// </summary>
		protected RSystem.RString r_PActivationTypeName;
		public virtual RSystem.RString RPActivationTypeName
		{
			get
			{
				if(r_PActivationTypeName == null)
				{
					r_PActivationTypeName = new(this, "ActivationTypeName", -1);
					r_PActivationTypeName.SetBelong(this.instance);
				}
				return r_PActivationTypeName;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Activation.IActivator Activator
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RActivation.RIActivator r_PActivator;
		public virtual RSystem.RRuntime.RRemoting.RActivation.RIActivator RPActivator
		{
			get
			{
				if(r_PActivator == null)
				{
					r_PActivator = new(this, "Activator", -1);
					r_PActivator.SetBelong(this.instance);
				}
				return r_PActivator;
			}
		}

		/// <summary>
		/// System.Object[] CallSiteActivationAttributes
		/// </summary>
		protected RPropertyArray<RSystem.RObject> r_PCallSiteActivationAttributes;
		public virtual RPropertyArray<RSystem.RObject> RPCallSiteActivationAttributes
		{
			get
			{
				if(r_PCallSiteActivationAttributes == null)
				{
					r_PCallSiteActivationAttributes = new(this, "CallSiteActivationAttributes", -1);
					r_PCallSiteActivationAttributes.SetBelong(this.instance);
				}
				return r_PCallSiteActivationAttributes;
			}
		}

		/// <summary>
		/// System.Collections.IList ContextProperties
		/// </summary>
		protected RSystem.RCollections.RIList r_PContextProperties;
		public virtual RSystem.RCollections.RIList RPContextProperties
		{
			get
			{
				if(r_PContextProperties == null)
				{
					r_PContextProperties = new(this, "ContextProperties", -1);
					r_PContextProperties.SetBelong(this.instance);
				}
				return r_PContextProperties;
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
