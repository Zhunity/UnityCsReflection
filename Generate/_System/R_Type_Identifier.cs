
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TypeIdentifier
	/// </summary>
    public partial class RTypeIdentifier : RMember //
    {

		/// <summary>
		/// System.String InternalName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PInternalName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPInternalName
		{
			get
			{
				if(r_PInternalName == null)
				{
					r_PInternalName = new(this, "InternalName", -1);
					r_PInternalName.SetBelong(this.instance);
				}
				return r_PInternalName;
			}
		}


        public RTypeIdentifier() : base("System.TypeIdentifier")
        {
        }

        public RTypeIdentifier(System.Object instance) : base("System.TypeIdentifier")
		{
            SetInstance(instance);
		}

        public RTypeIdentifier(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeIdentifier(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
