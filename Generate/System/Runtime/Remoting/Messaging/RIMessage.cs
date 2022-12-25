using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.IMessage
	/// </summary>
    public partial class RIMessage : RMember //
    {

		/// <summary>
		/// System.Collections.IDictionary Properties
		/// </summary>
		protected RSystem.RCollections.RIDictionary r_Properties;
		public virtual RSystem.RCollections.RIDictionary RProperties
		{
			get
			{
				if(r_Properties == null)
				{
					r_Properties = new(this, "Properties", -1);
					r_Properties.SetBelong(this.instance);
				}
				return r_Properties;
			}
		}


        public RIMessage() : base("System.Runtime.Remoting.Messaging.IMessage")
        {
        }

        public RIMessage(System.Object instance) : base("System.Runtime.Remoting.Messaging.IMessage")
		{
            SetInstance(instance);
		}

        public RIMessage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMessage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
