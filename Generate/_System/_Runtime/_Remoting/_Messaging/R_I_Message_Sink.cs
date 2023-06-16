
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Runtime.Remoting.Messaging.IMessageSink
	/// </summary>
    public partial class RIMessageSink : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.Messaging.IMessageSink);
            }
        }

        public RIMessageSink() : base("System.Runtime.Remoting.Messaging.IMessageSink")
        {
        }

        public RIMessageSink(System.Object instance) : base("System.Runtime.Remoting.Messaging.IMessageSink")
		{
            SetInstance(instance);
		}

        public RIMessageSink(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMessageSink(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink NextSink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_PNextSink;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RPNextSink
		{
			get
			{
				if(r_PNextSink == null)
				{
					r_PNextSink = new(this, "NextSink", -1);
				}
				return r_PNextSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_MSyncProcessMessage_IMessage;
		public virtual RMethod RMSyncProcessMessage_IMessage
		{
			get
			{
				if(r_MSyncProcessMessage_IMessage == null)
				{
					r_MSyncProcessMessage_IMessage = new(this, "SyncProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
				}
				return r_MSyncProcessMessage_IMessage;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMessageSink)
		/// </summary>
		protected RMethod r_MAsyncProcessMessage_IMessage_IMessageSink;
		public virtual RMethod RMAsyncProcessMessage_IMessage_IMessageSink
		{
			get
			{
				if(r_MAsyncProcessMessage_IMessage_IMessageSink == null)
				{
					r_MAsyncProcessMessage_IMessage_IMessageSink = new(this, "AsyncProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Runtime.Remoting.Messaging.IMessageSink));
				}
				return r_MAsyncProcessMessage_IMessage_IMessageSink;
			}
		}


        public virtual System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RMSyncProcessMessage_IMessage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Messaging.IMessage>(___result);
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage @msg, System.Runtime.Remoting.Messaging.IMessageSink @replySink)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg, @replySink};
            var ___result = RMAsyncProcessMessage_IMessage_IMessageSink.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.Messaging.IMessageCtrl>(___result);
        }


    }
}
