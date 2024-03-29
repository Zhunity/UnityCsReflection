
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.IWindowCreatedHandler
	/// </summary>
    public partial class RIWindowCreatedHandler : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IWindowCreatedHandler");
            }
        }

        public RIWindowCreatedHandler() : base("UnityEditor.PackageManager.UI.IWindowCreatedHandler")
        {
        }

        public RIWindowCreatedHandler(System.Object instance) : base("UnityEditor.PackageManager.UI.IWindowCreatedHandler")
		{
            SetInstance(instance);
		}

        public RIWindowCreatedHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIWindowCreatedHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void OnWindowCreated(UnityEditor.PackageManager.UI.WindowCreatedArgs)
		/// </summary>
		protected RMethod r_MOnWindowCreated_WindowCreatedArgs;
		public virtual RMethod RMOnWindowCreated_WindowCreatedArgs
		{
			get
			{
				if(r_MOnWindowCreated_WindowCreatedArgs == null)
				{
					r_MOnWindowCreated_WindowCreatedArgs = new(this, "OnWindowCreated", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.WindowCreatedArgs"));
				}
				return r_MOnWindowCreated_WindowCreatedArgs;
			}
		}


        public virtual void OnWindowCreated(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RWindowCreatedArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnWindowCreated_WindowCreatedArgs.Invoke(___genericsType, ___parameters);

            
        }


    }
}
