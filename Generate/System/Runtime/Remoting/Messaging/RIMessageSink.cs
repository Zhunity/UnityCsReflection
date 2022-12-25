using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.IMessageSink
	/// </summary>
    public partial class RIMessageSink : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageSink NextSink
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink r_NextSink;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RIMessageSink RNextSink
		{
			get
			{
				if(r_NextSink == null)
				{
					r_NextSink = new(this, "NextSink", -1);
					r_NextSink.SetBelong(this.instance);
				}
				return r_NextSink;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected RMethod r_RSyncProcessMessage_IMessage;
		public virtual RMethod RSyncProcessMessage_IMessage
		{
			get
			{
				if(r_RSyncProcessMessage_IMessage == null)
				{
					r_RSyncProcessMessage_IMessage = new(this, "SyncProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_RSyncProcessMessage_IMessage.SetBelong(this.instance);
				}
				return r_RSyncProcessMessage_IMessage;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMessageSink)
		/// </summary>
		protected RMethod r_RAsyncProcessMessage_IMessage_IMessageSink;
		public virtual RMethod RAsyncProcessMessage_IMessage_IMessageSink
		{
			get
			{
				if(r_RAsyncProcessMessage_IMessage_IMessageSink == null)
				{
					r_RAsyncProcessMessage_IMessage_IMessageSink = new(this, "AsyncProcessMessage", 0, typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Runtime.Remoting.Messaging.IMessageSink));
					r_RAsyncProcessMessage_IMessage_IMessageSink.SetBelong(this.instance);
				}
				return r_RAsyncProcessMessage_IMessage_IMessageSink;
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

        public virtual System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RSyncProcessMessage_IMessage.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessage)___result;
        }


        public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage  @msg, System.Runtime.Remoting.Messaging.IMessageSink  @replySink)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg, @replySink};
            var ___result = RAsyncProcessMessage_IMessage_IMessageSink.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.IMessageCtrl)___result;
        }


    }
}
