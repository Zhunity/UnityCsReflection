using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSMFrame.REditor.RRefleaction
{
    public partial class RATestGenericMethod : RMember
    {

		/// <summary>
		/// System.Int32
		/// </summary>
		protected static RField r_qeqwe;
		public static RField qeqwe
		{
			get
			{
				if(r_qeqwe == null)
				{
					r_qeqwe = new RField( ReleactionUtils.GetType("SMFrame.Editor.Refleaction.ATestGenericMethod"), "qeqwe");
					r_qeqwe.SetBelong(null);
				}
				return r_qeqwe;
			}
		}
		/// <summary>
		/// System.String
		/// </summary>
		protected RField r_sdfsdf;
		public virtual RField sdfsdf
		{
			get
			{
				if(r_sdfsdf == null)
				{
					r_sdfsdf = new RField(this, "sdfsdf");
					r_sdfsdf.SetBelong(this.instance);
				}
				return r_sdfsdf;
			}
		}

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
