
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Remoting.Activation.IActivator
	/// </summary>
    public partial class RIActivator : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.Activation.IActivator);
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
				}
				return r_MActivate_IConstructionCallMessage;
			}
		}


        public virtual System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMActivate_IConstructionCallMessage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Activation.IConstructionReturnMessage>(___result);
        }


    }
}
