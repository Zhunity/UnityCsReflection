using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.IChannelInfo
	/// </summary>
    public partial class RIChannelInfo : RMember //
    {

		/// <summary>
		/// System.Object[] ChannelData
		/// </summary>
		protected RPropertyArray<RSystem.RObject> r_ChannelData;
		public virtual RPropertyArray<RSystem.RObject> RChannelData
		{
			get
			{
				if(r_ChannelData == null)
				{
					r_ChannelData = new(this, "ChannelData", -1);
					r_ChannelData.SetBelong(this.instance);
				}
				return r_ChannelData;
			}
		}


        public RIChannelInfo() : base("System.Runtime.Remoting.IChannelInfo")
        {
        }

        public RIChannelInfo(System.Object instance) : base("System.Runtime.Remoting.IChannelInfo")
		{
            SetInstance(instance);
		}

        public RIChannelInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIChannelInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
