
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.IEnvoyInfo
	/// </summary>
    public partial class RIEnvoyInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.IEnvoyInfo);
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


		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_PEnvoySinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RPEnvoySinks
		{
			get
			{
				if(r_PEnvoySinks == null)
				{
					r_PEnvoySinks = new(this, "EnvoySinks", -1);
				}
				return r_PEnvoySinks;
			}
		}


    }
}
