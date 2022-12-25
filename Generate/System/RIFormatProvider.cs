using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IFormatProvider
	/// </summary>
    public partial class RIFormatProvider : RMember //
    {

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_RGetFormat_Type;
		public virtual RMethod RGetFormat_Type
		{
			get
			{
				if(r_RGetFormat_Type == null)
				{
					r_RGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_RGetFormat_Type.SetBelong(this.instance);
				}
				return r_RGetFormat_Type;
			}
		}


        public RIFormatProvider() : base("System.IFormatProvider")
        {
        }

        public RIFormatProvider(System.Object instance) : base("System.IFormatProvider")
		{
            SetInstance(instance);
		}

        public RIFormatProvider(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIFormatProvider(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetFormat(System.Type  @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
