
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.ExtensionManager
	/// </summary>
    public partial class RExtensionManager : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ExtensionManager+EventDispatcher m_EventDispatcher
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RExtensionManager.REventDispatcher r_Fm_EventDispatcher;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RExtensionManager.REventDispatcher RFm_EventDispatcher
		{
			get
			{
				if(r_Fm_EventDispatcher == null)
				{
					r_Fm_EventDispatcher = new(this, "m_EventDispatcher");
					r_Fm_EventDispatcher.SetBelong(this.instance);
				}
				return r_Fm_EventDispatcher;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IWindow m_Window
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow r_Fm_Window;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow RFm_Window
		{
			get
			{
				if(r_Fm_Window == null)
				{
					r_Fm_Window = new(this, "m_Window");
					r_Fm_Window.SetBelong(this.instance);
				}
				return r_Fm_Window;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_DetailsExtensionContainer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_DetailsExtensionContainer;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_DetailsExtensionContainer
		{
			get
			{
				if(r_Fm_DetailsExtensionContainer == null)
				{
					r_Fm_DetailsExtensionContainer = new(this, "m_DetailsExtensionContainer");
					r_Fm_DetailsExtensionContainer.SetBelong(this.instance);
				}
				return r_Fm_DetailsExtensionContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ToolbarExtensionContainer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_ToolbarExtensionContainer;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_ToolbarExtensionContainer
		{
			get
			{
				if(r_Fm_ToolbarExtensionContainer == null)
				{
					r_Fm_ToolbarExtensionContainer = new(this, "m_ToolbarExtensionContainer");
					r_Fm_ToolbarExtensionContainer.SetBelong(this.instance);
				}
				return r_Fm_ToolbarExtensionContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_PackageActionContainer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_PackageActionContainer;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_PackageActionContainer
		{
			get
			{
				if(r_Fm_PackageActionContainer == null)
				{
					r_Fm_PackageActionContainer = new(this, "m_PackageActionContainer");
					r_Fm_PackageActionContainer.SetBelong(this.instance);
				}
				return r_Fm_PackageActionContainer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.DetailsExtension] m_DetailsExtensions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDetailsExtension> r_Fm_DetailsExtensions;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDetailsExtension> RFm_DetailsExtensions
		{
			get
			{
				if(r_Fm_DetailsExtensions == null)
				{
					r_Fm_DetailsExtensions = new(this, "m_DetailsExtensions");
					r_Fm_DetailsExtensions.SetBelong(this.instance);
				}
				return r_Fm_DetailsExtensions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageAction] m_PackageActions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction> r_Fm_PackageActions;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction> RFm_PackageActions
		{
			get
			{
				if(r_Fm_PackageActions == null)
				{
					r_Fm_PackageActions = new(this, "m_PackageActions");
					r_Fm_PackageActions.SetBelong(this.instance);
				}
				return r_Fm_PackageActions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DropdownButton m_CollapsedPackageActions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton r_Fm_CollapsedPackageActions;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDropdownButton RFm_CollapsedPackageActions
		{
			get
			{
				if(r_Fm_CollapsedPackageActions == null)
				{
					r_Fm_CollapsedPackageActions = new(this, "m_CollapsedPackageActions");
					r_Fm_CollapsedPackageActions.SetBelong(this.instance);
				}
				return r_Fm_CollapsedPackageActions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs m_PackageManagerPrefs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs r_Fm_PackageManagerPrefs;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs RFm_PackageManagerPrefs
		{
			get
			{
				if(r_Fm_PackageManagerPrefs == null)
				{
					r_Fm_PackageManagerPrefs = new(this, "m_PackageManagerPrefs");
					r_Fm_PackageManagerPrefs.SetBelong(this.instance);
				}
				return r_Fm_PackageManagerPrefs;
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
					r_MSendPackageSelectionChangedEvent_IPackage_IPackageVersion.SetBelong(this.instance);
				}
				return r_MSendPackageSelectionChangedEvent_IPackage_IPackageVersion;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs)
		/// </summary>
		protected RMethod r_MResolveDependencies_PackageManagerPrefs;
		public virtual RMethod RMResolveDependencies_PackageManagerPrefs
		{
			get
			{
				if(r_MResolveDependencies_PackageManagerPrefs == null)
				{
					r_MResolveDependencies_PackageManagerPrefs = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerPrefs"));
					r_MResolveDependencies_PackageManagerPrefs.SetBelong(this.instance);
				}
				return r_MResolveDependencies_PackageManagerPrefs;
			}
		}

		/// <summary>
		/// Void OnWindowCreated(UnityEditor.PackageManager.UI.IWindow, UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MOnWindowCreated_IWindow_VisualElement_VisualElement;
		public virtual RMethod RMOnWindowCreated_IWindow_VisualElement_VisualElement
		{
			get
			{
				if(r_MOnWindowCreated_IWindow_VisualElement_VisualElement == null)
				{
					r_MOnWindowCreated_IWindow_VisualElement_VisualElement = new(this, "OnWindowCreated", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IWindow"), typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement));
					r_MOnWindowCreated_IWindow_VisualElement_VisualElement.SetBelong(this.instance);
				}
				return r_MOnWindowCreated_IWindow_VisualElement_VisualElement;
			}
		}

		/// <summary>
		/// Void OnWindowDestroy()
		/// </summary>
		protected RMethod r_MOnWindowDestroy;
		public virtual RMethod RMOnWindowDestroy
		{
			get
			{
				if(r_MOnWindowDestroy == null)
				{
					r_MOnWindowDestroy = new(this, "OnWindowDestroy", 0);
					r_MOnWindowDestroy.SetBelong(this.instance);
				}
				return r_MOnWindowDestroy;
			}
		}

		/// <summary>
		/// Void CollapsedPackageActionsOnBeforeShowDropdown()
		/// </summary>
		protected RMethod r_MCollapsedPackageActionsOnBeforeShowDropdown;
		public virtual RMethod RMCollapsedPackageActionsOnBeforeShowDropdown
		{
			get
			{
				if(r_MCollapsedPackageActionsOnBeforeShowDropdown == null)
				{
					r_MCollapsedPackageActionsOnBeforeShowDropdown = new(this, "CollapsedPackageActionsOnBeforeShowDropdown", 0);
					r_MCollapsedPackageActionsOnBeforeShowDropdown.SetBelong(this.instance);
				}
				return r_MCollapsedPackageActionsOnBeforeShowDropdown;
			}
		}

		/// <summary>
		/// Void RefreshPackageActionsBasedOnWidth()
		/// </summary>
		protected RMethod r_MRefreshPackageActionsBasedOnWidth;
		public virtual RMethod RMRefreshPackageActionsBasedOnWidth
		{
			get
			{
				if(r_MRefreshPackageActionsBasedOnWidth == null)
				{
					r_MRefreshPackageActionsBasedOnWidth = new(this, "RefreshPackageActionsBasedOnWidth", 0);
					r_MRefreshPackageActionsBasedOnWidth.SetBelong(this.instance);
				}
				return r_MRefreshPackageActionsBasedOnWidth;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DetailsExtension CreateDetailsExtension()
		/// </summary>
		protected RMethod r_MCreateDetailsExtension;
		public virtual RMethod RMCreateDetailsExtension
		{
			get
			{
				if(r_MCreateDetailsExtension == null)
				{
					r_MCreateDetailsExtension = new(this, "CreateDetailsExtension", 0);
					r_MCreateDetailsExtension.SetBelong(this.instance);
				}
				return r_MCreateDetailsExtension;
			}
		}

		/// <summary>
		/// Void OnDetailsExtensionPriorityChanged()
		/// </summary>
		protected RMethod r_MOnDetailsExtensionPriorityChanged;
		public virtual RMethod RMOnDetailsExtensionPriorityChanged
		{
			get
			{
				if(r_MOnDetailsExtensionPriorityChanged == null)
				{
					r_MOnDetailsExtensionPriorityChanged = new(this, "OnDetailsExtensionPriorityChanged", 0);
					r_MOnDetailsExtensionPriorityChanged.SetBelong(this.instance);
				}
				return r_MOnDetailsExtensionPriorityChanged;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageAction CreatePackageAction()
		/// </summary>
		protected RMethod r_MCreatePackageAction;
		public virtual RMethod RMCreatePackageAction
		{
			get
			{
				if(r_MCreatePackageAction == null)
				{
					r_MCreatePackageAction = new(this, "CreatePackageAction", 0);
					r_MCreatePackageAction.SetBelong(this.instance);
				}
				return r_MCreatePackageAction;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageAction CreatePackageActionButton()
		/// </summary>
		protected RMethod r_MCreatePackageActionButton;
		public virtual RMethod RMCreatePackageActionButton
		{
			get
			{
				if(r_MCreatePackageActionButton == null)
				{
					r_MCreatePackageActionButton = new(this, "CreatePackageActionButton", 0);
					r_MCreatePackageActionButton.SetBelong(this.instance);
				}
				return r_MCreatePackageActionButton;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageAction CreatePackageActionMenu()
		/// </summary>
		protected RMethod r_MCreatePackageActionMenu;
		public virtual RMethod RMCreatePackageActionMenu
		{
			get
			{
				if(r_MCreatePackageActionMenu == null)
				{
					r_MCreatePackageActionMenu = new(this, "CreatePackageActionMenu", 0);
					r_MCreatePackageActionMenu.SetBelong(this.instance);
				}
				return r_MCreatePackageActionMenu;
			}
		}

		/// <summary>
		/// Void OnPackageActionPriorityChanged()
		/// </summary>
		protected RMethod r_MOnPackageActionPriorityChanged;
		public virtual RMethod RMOnPackageActionPriorityChanged
		{
			get
			{
				if(r_MOnPackageActionPriorityChanged == null)
				{
					r_MOnPackageActionPriorityChanged = new(this, "OnPackageActionPriorityChanged", 0);
					r_MOnPackageActionPriorityChanged.SetBelong(this.instance);
				}
				return r_MOnPackageActionPriorityChanged;
			}
		}

		/// <summary>
		/// Int32 CompareExtensions(UnityEditor.PackageManager.UI.IExtension, UnityEditor.PackageManager.UI.IExtension)
		/// </summary>
		protected static RMethod r_MCompareExtensions_IExtension_IExtension;
		public static RMethod RMCompareExtensions_IExtension_IExtension
		{
			get
			{
				if(r_MCompareExtensions_IExtension_IExtension == null)
				{
					r_MCompareExtensions_IExtension_IExtension = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ExtensionManager"), "CompareExtensions", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IExtension"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.IExtension"));
					r_MCompareExtensions_IExtension_IExtension.SetBelong(null);
				}
				return r_MCompareExtensions_IExtension_IExtension;
			}
		}

		/// <summary>
		/// Boolean IsSorted[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected static RMethod r_MIsSorted_GT_List_d_T_p_;
		public static RMethod RMIsSorted_GT_List_d_T_p_
		{
			get
			{
				if(r_MIsSorted_GT_List_d_T_p_ == null)
				{
					r_MIsSorted_GT_List_d_T_p_ = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ExtensionManager"), "IsSorted", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MIsSorted_GT_List_d_T_p_.SetBelong(null);
				}
				return r_MIsSorted_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void <OnWindowCreated>b__12_0(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_M__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent;
		public virtual RMethod RM__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent
		{
			get
			{
				if(r_M__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent == null)
				{
					r_M__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent = new(this, "<OnWindowCreated>b__12_0", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_M__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_M__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}


        public RExtensionManager() : base("UnityEditor.PackageManager.UI.Internal.ExtensionManager")
        {
        }

        public RExtensionManager(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ExtensionManager")
		{
            SetInstance(instance);
		}

        public RExtensionManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExtensionManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SendPackageSelectionChangedEvent(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package.Value, @version.Value};
            var ___result = RMSendPackageSelectionChangedEvent_IPackage_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveDependencies(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerPrefs @packageManagerPrefs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageManagerPrefs.Value};
            var ___result = RMResolveDependencies_PackageManagerPrefs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnWindowCreated(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIWindow @window, UnityEngine.UIElements.VisualElement @detailsExtensionContainer, UnityEngine.UIElements.VisualElement @toolbarExtensionsContainer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window.Value, @detailsExtensionContainer, @toolbarExtensionsContainer};
            var ___result = RMOnWindowCreated_IWindow_VisualElement_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnWindowDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnWindowDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CollapsedPackageActionsOnBeforeShowDropdown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCollapsedPackageActionsOnBeforeShowDropdown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshPackageActionsBasedOnWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshPackageActionsBasedOnWidth.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDetailsExtension CreateDetailsExtension()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDetailsExtension.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDetailsExtension(___result);
        }


        public virtual void OnDetailsExtensionPriorityChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDetailsExtensionPriorityChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction CreatePackageAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreatePackageAction.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction CreatePackageActionButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreatePackageActionButton.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction CreatePackageActionMenu()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreatePackageActionMenu.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAction(___result);
        }


        public virtual void OnPackageActionPriorityChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnPackageActionPriorityChanged.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 CompareExtensions(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIExtension @e1, SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIExtension @e2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e1.Value, @e2.Value};
            var ___result = RMCompareExtensions_IExtension_IExtension.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsSorted<T>(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RType> @extensions)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@extensions.Value};
            var ___result = RMIsSorted_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__OnWindowCreated__1__b__12_0(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RM__0__OnWindowCreated__1__b__12_0_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
