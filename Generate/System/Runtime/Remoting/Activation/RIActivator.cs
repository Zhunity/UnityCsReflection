using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation
{
	/// <summary>
	/// System.Runtime.Remoting.Activation.IActivator
	/// </summary>
    public partial class RIActivator : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.Activation.ActivatorLevel Level
		/// </summary>
		protected RProperty r_Level;
		public virtual RProperty RLevel
		{
			get
			{
				if(r_Level == null)
				{
					r_Level = new(this, "Level", -1);
					r_Level.SetBelong(this.instance);
				}
				return r_Level;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Activation.IActivator NextActivator
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RActivation.RIActivator r_NextActivator;
		public virtual RSystem.RRuntime.RRemoting.RActivation.RIActivator RNextActivator
		{
			get
			{
				if(r_NextActivator == null)
				{
					r_NextActivator = new(this, "NextActivator", -1);
					r_NextActivator.SetBelong(this.instance);
				}
				return r_NextActivator;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage)
		/// </summary>
		protected RMethod r_RActivate_IConstructionCallMessage;
		public virtual RMethod RActivate_IConstructionCallMessage
		{
			get
			{
				if(r_RActivate_IConstructionCallMessage == null)
				{
					r_RActivate_IConstructionCallMessage = new(this, "Activate", 0, typeof(System.Runtime.Remoting.Activation.IConstructionCallMessage));
					r_RActivate_IConstructionCallMessage.SetBelong(this.instance);
				}
				return r_RActivate_IConstructionCallMessage;
			}
		}


        public RIActivator() : base("System.Runtime.Remoting.Activation.IActivator")
        {
        }

        public RIActivator(System.Object instance) : base("System.Runtime.Remoting.Activation.IActivator")
		{
            SetInstance(instance);
		}

        public RIActivator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIActivator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RActivate_IConstructionCallMessage.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Activation.IConstructionReturnMessage)___result;
        }


    }
}
