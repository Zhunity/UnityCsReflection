
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.IExtension
	/// </summary>
    public partial class RIExtension : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IExtension");
            }
        }

        public RIExtension() : base("UnityEditor.PackageManager.UI.IExtension")
        {
        }

        public RIExtension(System.Object instance) : base("UnityEditor.PackageManager.UI.IExtension")
		{
            SetInstance(instance);
		}

        public RIExtension(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIExtension(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ppriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpriority
		{
			get
			{
				if(r_Ppriority == null)
				{
					r_Ppriority = new(this, "priority", -1);
				}
				return r_Ppriority;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pvisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
				}
				return r_Penabled;
			}
		}


    }
}
