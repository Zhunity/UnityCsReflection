using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.IMessageCtrl
	/// </summary>
    public partial class RIMessageCtrl : RMember //
    {

		/// <summary>
		/// Void Cancel(Int32)
		/// </summary>
		protected RMethod r_RCancel_Int32;
		public virtual RMethod RCancel_Int32
		{
			get
			{
				if(r_RCancel_Int32 == null)
				{
					r_RCancel_Int32 = new(this, "Cancel", 0, typeof(System.Int32));
					r_RCancel_Int32.SetBelong(this.instance);
				}
				return r_RCancel_Int32;
			}
		}


        public RIMessageCtrl() : base("System.Runtime.Remoting.Messaging.IMessageCtrl")
        {
        }

        public RIMessageCtrl(System.Object instance) : base("System.Runtime.Remoting.Messaging.IMessageCtrl")
		{
            SetInstance(instance);
		}

        public RIMessageCtrl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMessageCtrl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Cancel(System.Int32  @msToCancel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msToCancel};
            var ___result = RCancel_Int32.Invoke(___genericsType, ___parameters);

            
        }


    }
}
