
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.IWindowDestroyHandler
	/// </summary>
    public partial class RIWindowDestroyHandler : RMember //
    {

		/// <summary>
		/// Void OnWindowDestroy(UnityEditor.PackageManager.UI.WindowDestroyArgs)
		/// </summary>
		protected RMethod r_MOnWindowDestroy_WindowDestroyArgs;
		public virtual RMethod RMOnWindowDestroy_WindowDestroyArgs
		{
			get
			{
				if(r_MOnWindowDestroy_WindowDestroyArgs == null)
				{
					r_MOnWindowDestroy_WindowDestroyArgs = new(this, "OnWindowDestroy", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.WindowDestroyArgs"));
				}
				return r_MOnWindowDestroy_WindowDestroyArgs;
			}
		}


        public RIWindowDestroyHandler() : base("UnityEditor.PackageManager.UI.IWindowDestroyHandler")
        {
        }

        public RIWindowDestroyHandler(System.Object instance) : base("UnityEditor.PackageManager.UI.IWindowDestroyHandler")
		{
            SetInstance(instance);
		}

        public RIWindowDestroyHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIWindowDestroyHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnWindowDestroy(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RWindowDestroyArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnWindowDestroy_WindowDestroyArgs.Invoke(___genericsType, ___parameters);

            
        }


    }
}
