
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IUxmlAttributes
	/// </summary>
    public partial class RIUxmlAttributes : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IUxmlAttributes);
            }
        }

        public RIUxmlAttributes() : base("UnityEngine.UIElements.IUxmlAttributes")
        {
        }

        public RIUxmlAttributes(System.Object instance) : base("UnityEngine.UIElements.IUxmlAttributes")
		{
            SetInstance(instance);
		}

        public RIUxmlAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIUxmlAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean TryGetAttributeValue(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryGetAttributeValue_String_Out_String;
		public virtual RMethod RMTryGetAttributeValue_String_Out_String
		{
			get
			{
				if(r_MTryGetAttributeValue_String_Out_String == null)
				{
					r_MTryGetAttributeValue_String_Out_String = new(this, "TryGetAttributeValue", 0, typeof(System.String), typeof(System.String).MakeByRefType());
				}
				return r_MTryGetAttributeValue_String_Out_String;
			}
		}


        public virtual System.Boolean TryGetAttributeValue(System.String @attributeName, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName, @value};
            var ___result = RMTryGetAttributeValue_String_Out_String.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


    }
}
