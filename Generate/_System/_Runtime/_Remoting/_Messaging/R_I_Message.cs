
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Runtime.Remoting.Messaging.IMessage
	/// </summary>
    public partial class RIMessage : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.Messaging.IMessage);
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


		/// <summary>
		/// System.Collections.IDictionary Properties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIDictionary r_PProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIDictionary RPProperties
		{
			get
			{
				if(r_PProperties == null)
				{
					r_PProperties = new(this, "Properties", -1);
				}
				return r_PProperties;
			}
		}


    }
}
