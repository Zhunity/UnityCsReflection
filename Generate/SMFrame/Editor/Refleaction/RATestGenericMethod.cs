using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSMFrame.REditor.RRefleaction
{
    public partial class RATestGenericMethod : RMember
    {


        public RATestGenericMethod() : base("SMFrame.Editor.Refleaction.ATestGenericMethod")
        {
        }

        public RATestGenericMethod(System.Object instance) : base("SMFrame.Editor.Refleaction.ATestGenericMethod")
		{
            SetInstance(instance);
		}

        public RATestGenericMethod(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

    }
}
