
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.ICollectionDragAndDropController
	/// </summary>
    public partial class RICollectionDragAndDropController : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ICollectionDragAndDropController");
            }
        }

        public RICollectionDragAndDropController() : base("UnityEngine.UIElements.ICollectionDragAndDropController")
        {
        }

        public RICollectionDragAndDropController(System.Object instance) : base("UnityEngine.UIElements.ICollectionDragAndDropController")
		{
            SetInstance(instance);
		}

        public RICollectionDragAndDropController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RICollectionDragAndDropController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



    }
}
