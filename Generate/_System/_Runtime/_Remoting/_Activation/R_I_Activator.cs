
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation
{
	/// <summary>
	/// System.Runtime.Remoting.Activation.IActivator
	/// </summary>
    public partial class RIActivator : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.Activation.ActivatorLevel Level
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation.RActivatorLevel r_PLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation.RActivatorLevel RPLevel
		{
			get
			{
				if(r_PLevel == null)
				{
					r_PLevel = new(this, "Level", -1);
					r_PLevel.SetBelong(this.GetValue());
				}
				return r_PLevel;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Activation.IActivator NextActivator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation.RIActivator r_PNextActivator;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation.RIActivator RPNextActivator
		{
			get
			{
				if(r_PNextActivator == null)
				{
					r_PNextActivator = new(this, "NextActivator", -1);
					r_PNextActivator.SetBelong(this.GetValue());
				}
				return r_PNextActivator;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage)
		/// </summary>
		protected RMethod r_MActivate_IConstructionCallMessage;
		public virtual RMethod RMActivate_IConstructionCallMessage
		{
			get
			{
				if(r_MActivate_IConstructionCallMessage == null)
				{
					r_MActivate_IConstructionCallMessage = new(this, "Activate", 0, typeof(System.Runtime.Remoting.Activation.IConstructionCallMessage));
					r_MActivate_IConstructionCallMessage.SetBelong(this.GetValue());
				}
				return r_MActivate_IConstructionCallMessage;
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

        public virtual System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMActivate_IConstructionCallMessage.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Activation.IConstructionReturnMessage)___result;
        }


    }
}
