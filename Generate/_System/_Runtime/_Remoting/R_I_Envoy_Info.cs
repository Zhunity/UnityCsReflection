
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.IEnvoyInfo
	/// </summary>
    public partial class RIEnvoyInfo : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_PEnvoySinks;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RPEnvoySinks
		{
			get
			{
				if(r_PEnvoySinks == null)
				{
					r_PEnvoySinks = new(this, "EnvoySinks", -1);
					r_PEnvoySinks.SetBelong(this.instance);
				}
				return r_PEnvoySinks;
			}
		}


        public RIEnvoyInfo() : base("System.Runtime.Remoting.IEnvoyInfo")
        {
        }

        public RIEnvoyInfo(System.Object instance) : base("System.Runtime.Remoting.IEnvoyInfo")
		{
            SetInstance(instance);
		}

        public RIEnvoyInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEnvoyInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
