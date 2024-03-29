
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RActivation
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Remoting.Activation.IConstructionReturnMessage
	/// </summary>
    public partial class RIConstructionReturnMessage : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.Activation.IConstructionReturnMessage);
            }
        }

        public RIConstructionReturnMessage() : base("System.Runtime.Remoting.Activation.IConstructionReturnMessage")
        {
        }

        public RIConstructionReturnMessage(System.Object instance) : base("System.Runtime.Remoting.Activation.IConstructionReturnMessage")
		{
            SetInstance(instance);
		}

        public RIConstructionReturnMessage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIConstructionReturnMessage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



    }
}
