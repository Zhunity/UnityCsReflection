
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.IEnumerator`1
	/// </summary>
    public partial class RIEnumerator<T> : RMember //
    {

		/// <summary>
		/// T Current
		/// </summary>
		protected SMFrame.Editor.Refleaction.RProperty r_PCurrent;
		public virtual SMFrame.Editor.Refleaction.RProperty RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
					r_PCurrent.SetBelong(this.instance);
				}
				return r_PCurrent;
			}
		}


        public RIEnumerator() : base("System.Collections.Generic.IEnumerator`1")
        {
        }

        public RIEnumerator(System.Object instance) : base("System.Collections.Generic.IEnumerator`1")
		{
            SetInstance(instance);
		}

        public RIEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}