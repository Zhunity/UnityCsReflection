
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.IFormatProvider
	/// </summary>
    public partial class RIFormatProvider : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.IFormatProvider);
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
				}
				return r_MGetFormat_Type;
			}
		}


        public virtual System.Object GetFormat(System.Type @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RMGetFormat_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
