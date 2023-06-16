
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.IBaseUxmlObjectFactory
	/// </summary>
    public partial class RIBaseUxmlObjectFactory : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.IBaseUxmlObjectFactory");
            }
        }

        public RIBaseUxmlObjectFactory() : base("UnityEngine.UIElements.IBaseUxmlObjectFactory")
        {
        }

        public RIBaseUxmlObjectFactory(System.Object instance) : base("UnityEngine.UIElements.IBaseUxmlObjectFactory")
		{
            SetInstance(instance);
		}

        public RIBaseUxmlObjectFactory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIBaseUxmlObjectFactory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



    }
}
