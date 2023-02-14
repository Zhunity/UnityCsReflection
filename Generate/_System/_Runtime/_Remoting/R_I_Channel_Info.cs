
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.IChannelInfo
	/// </summary>
    public partial class RIChannelInfo : RMember //
    {

		/// <summary>
		/// System.Object[] ChannelData
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RObject> r_PChannelData;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RObject> RPChannelData
		{
			get
			{
				if(r_PChannelData == null)
				{
					r_PChannelData = new(this, "ChannelData", -1);
					r_PChannelData.SetBelong(this.instance);
				}
				return r_PChannelData;
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
