
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RExtensionManager
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.ExtensionManager+EventDispatcher
	/// </summary>
    public partial class REventDispatcher : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ExtensionManager+EventDispatcher");
            }
        }

        public REventDispatcher() : base("UnityEditor.PackageManager.UI.Internal.ExtensionManager+EventDispatcher")
        {
        }

        public REventDispatcher(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ExtensionManager+EventDispatcher")
		{
            SetInstance(instance);
		}

        public REventDispatcher(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventDispatcher(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String k_ExtensionErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ExtensionErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ExtensionErrorMessage
		{
			get
			{
				if(r_Fk_ExtensionErrorMessage == null)
				{
					r_Fk_ExtensionErrorMessage = new(Type, "k_ExtensionErrorMessage");
				}
				return r_Fk_ExtensionErrorMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IWindow m_Window
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow r_Fm_Window;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow RFm_Window
		{
			get
			{
				if(r_Fm_Window == null)
				{
					r_Fm_Window = new(this, "m_Window");
				}
				return r_Fm_Window;
			}
		}

		/// <summary>
		/// UnityEditor.Tuple`2[UnityEditor.PackageManager.UI.Internal.IPackage,UnityEditor.PackageManager.UI.Internal.IPackageVersion] m_DelayedPackageSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RTuple<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_Fm_DelayedPackageSelection;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RTuple<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RFm_DelayedPackageSelection
		{
			get
			{
				if(r_Fm_DelayedPackageSelection == null)
				{
					r_Fm_DelayedPackageSelection = new(this, "m_DelayedPackageSelection");
				}
				return r_Fm_DelayedPackageSelection;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Type,System.Object] m_HandlerObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RSystem.RObject> r_Fm_HandlerObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RSystem.RObject> RFm_HandlerObjects
		{
			get
			{
				if(r_Fm_HandlerObjects == null)
				{
					r_Fm_HandlerObjects = new(this, "m_HandlerObjects");
				}
				return r_Fm_HandlerObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.IWindowCreatedHandler] m_WindowCreatedHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowCreatedHandler> r_Fm_WindowCreatedHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowCreatedHandler> RFm_WindowCreatedHandlers
		{
			get
			{
				if(r_Fm_WindowCreatedHandlers == null)
				{
					r_Fm_WindowCreatedHandlers = new(this, "m_WindowCreatedHandlers");
				}
				return r_Fm_WindowCreatedHandlers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.IWindowDestroyHandler] m_WindowDestroyHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowDestroyHandler> r_Fm_WindowDestroyHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowDestroyHandler> RFm_WindowDestroyHandlers
		{
			get
			{
				if(r_Fm_WindowDestroyHandlers == null)
				{
					r_Fm_WindowDestroyHandlers = new(this, "m_WindowDestroyHandlers");
				}
				return r_Fm_WindowDestroyHandlers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.IPackageSelectionChangedHandler] m_PackageSelectionChangedHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageSelectionChangedHandler> r_Fm_PackageSelectionChangedHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageSelectionChangedHandler> RFm_PackageSelectionChangedHandlers
		{
			get
			{
				if(r_Fm_PackageSelectionChangedHandlers == null)
				{
					r_Fm_PackageSelectionChangedHandlers = new(this, "m_PackageSelectionChangedHandlers");
				}
				return r_Fm_PackageSelectionChangedHandlers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.IWindowCreatedHandler] windowCreatedHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowCreatedHandler> r_PwindowCreatedHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowCreatedHandler> RPwindowCreatedHandlers
		{
			get
			{
				if(r_PwindowCreatedHandlers == null)
				{
					r_PwindowCreatedHandlers = new(this, "windowCreatedHandlers", -1);
				}
				return r_PwindowCreatedHandlers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.IWindowDestroyHandler] windowDestroyHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowDestroyHandler> r_PwindowDestroyHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindowDestroyHandler> RPwindowDestroyHandlers
		{
			get
			{
				if(r_PwindowDestroyHandlers == null)
				{
					r_PwindowDestroyHandlers = new(this, "windowDestroyHandlers", -1);
				}
				return r_PwindowDestroyHandlers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.IPackageSelectionChangedHandler] packageSelectionChangedHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageSelectionChangedHandler> r_PpackageSelectionChangedHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackageSelectionChangedHandler> RPpackageSelectionChangedHandlers
		{
			get
			{
				if(r_PpackageSelectionChangedHandlers == null)
				{
					r_PpackageSelectionChangedHandlers = new(this, "packageSelectionChangedHandlers", -1);
				}
				return r_PpackageSelectionChangedHandlers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T] CreateImplementedInstances[T]()
		/// </summary>
		protected RMethod r_MCreateImplementedInstances_GT;
		public virtual RMethod RMCreateImplementedInstances_GT
		{
			get
			{
				if(r_MCreateImplementedInstances_GT == null)
				{
					r_MCreateImplementedInstances_GT = new(this, "CreateImplementedInstances", 1);
				}
				return r_MCreateImplementedInstances_GT;
			}
		}

		/// <summary>
		/// Void SendWindowCreatedEvent(UnityEditor.PackageManager.UI.IWindow)
		/// </summary>
		protected RMethod r_MSendWindowCreatedEvent_IWindow;
		public virtual RMethod RMSendWindowCreatedEvent_IWindow
		{
			get
			{
				if(r_MSendWindowCreatedEvent_IWindow == null)
				{
					r_MSendWindowCreatedEvent_IWindow = new(this, "SendWindowCreatedEvent", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IWindow"));
				}
				return r_MSendWindowCreatedEvent_IWindow;
			}
		}

		/// <summary>
		/// Void SendWindowDestroyEvent()
		/// </summary>
		protected RMethod r_MSendWindowDestroyEvent;
		public virtual RMethod RMSendWindowDestroyEvent
		{
			get
			{
				if(r_MSendWindowDestroyEvent == null)
				{
					r_MSendWindowDestroyEvent = new(this, "SendWindowDestroyEvent", 0);
				}
				return r_MSendWindowDestroyEvent;
			}
		}

		/// <summary>
		/// Void SendPackageSelectionChangedEvent(UnityEditor.PackageManager.UI.Internal.IPackage, UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MSendPackageSelectionChangedEvent_IPackage_IPackageVersion;
		public virtual RMethod RMSendPackageSelectionChangedEvent_IPackage_IPackageVersion
		{
			get
			{
				if(r_MSendPackageSelectionChangedEvent_IPackage_IPackageVersion == null)
				{
					r_MSendPackageSelectionChangedEvent_IPackage_IPackageVersion = new(this, "SendPackageSelectionChangedEvent", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MSendPackageSelectionChangedEvent_IPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
				}
				return r_MMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}


        public virtual System.Collections.Generic.List<T> CreateImplementedInstances<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMCreateImplementedInstances_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<T>>(___result);
        }


        public virtual void SendWindowCreatedEvent(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window.Value};
            var ___result = RMSendWindowCreatedEvent_IWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendWindowDestroyEvent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendWindowDestroyEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPackageSelectionChangedEvent(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMSendPackageSelectionChangedEvent_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
}