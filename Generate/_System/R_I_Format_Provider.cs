
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IFormatProvider
	/// </summary>
    public partial class RIFormatProvider : RMember //
    {

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_MGetFormat_Type;
		public virtual RMethod RMGetFormat_Type
		{
			get
			{
				if(r_MGetFormat_Type == null)
				{
					r_MGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_MGetFormat_Type.SetBelong(this.GetValue());
				}
				return r_MGetFormat_Type;
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

        public virtual System.Object GetFormat(System.Type @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RMGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
