
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IPackageListView
	/// </summary>
    public partial class RIPackageListView : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageItem GetPackageItem(System.String)
		/// </summary>
		protected RMethod r_MGetPackageItem_String;
		public virtual RMethod RMGetPackageItem_String
		{
			get
			{
				if(r_MGetPackageItem_String == null)
				{
					r_MGetPackageItem_String = new(this, "GetPackageItem", 0, typeof(System.String));
					r_MGetPackageItem_String.SetBelong(this.instance);
				}
				return r_MGetPackageItem_String;
			}
		}

		/// <summary>
		/// Void ScrollToSelection()
		/// </summary>
		protected RMethod r_MScrollToSelection;
		public virtual RMethod RMScrollToSelection
		{
			get
			{
				if(r_MScrollToSelection == null)
				{
					r_MScrollToSelection = new(this, "ScrollToSelection", 0);
					r_MScrollToSelection.SetBelong(this.instance);
				}
				return r_MScrollToSelection;
			}
		}

		/// <summary>
		/// Void OnVisualStateChange(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState])
		/// </summary>
		protected RMethod r_MOnVisualStateChange_IEnumerable_d_VisualState_p_;
		public virtual RMethod RMOnVisualStateChange_IEnumerable_d_VisualState_p_
		{
			get
			{
				if(r_MOnVisualStateChange_IEnumerable_d_VisualState_p_ == null)
				{
					r_MOnVisualStateChange_IEnumerable_d_VisualState_p_ = new(this, "OnVisualStateChange", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualState")));
					r_MOnVisualStateChange_IEnumerable_d_VisualState_p_.SetBelong(this.instance);
				}
				return r_MOnVisualStateChange_IEnumerable_d_VisualState_p_;
			}
		}

		/// <summary>
		/// Void OnListRebuild(UnityEditor.PackageManager.UI.Internal.IPage)
		/// </summary>
		protected RMethod r_MOnListRebuild_IPage;
		public virtual RMethod RMOnListRebuild_IPage
		{
			get
			{
				if(r_MOnListRebuild_IPage == null)
				{
					r_MOnListRebuild_IPage = new(this, "OnListRebuild", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPage"));
					r_MOnListRebuild_IPage.SetBelong(this.instance);
				}
				return r_MOnListRebuild_IPage;
			}
		}

		/// <summary>
		/// Void OnListUpdate(UnityEditor.PackageManager.UI.Internal.ListUpdateArgs)
		/// </summary>
		protected RMethod r_MOnListUpdate_ListUpdateArgs;
		public virtual RMethod RMOnListUpdate_ListUpdateArgs
		{
			get
			{
				if(r_MOnListUpdate_ListUpdateArgs == null)
				{
					r_MOnListUpdate_ListUpdateArgs = new(this, "OnListUpdate", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ListUpdateArgs"));
					r_MOnListUpdate_ListUpdateArgs.SetBelong(this.instance);
				}
				return r_MOnListUpdate_ListUpdateArgs;
			}
		}

		/// <summary>
		/// Void OnFilterTabChanged(UnityEditor.PackageManager.UI.Internal.PackageFilterTab)
		/// </summary>
		protected RMethod r_MOnFilterTabChanged_PackageFilterTab;
		public virtual RMethod RMOnFilterTabChanged_PackageFilterTab
		{
			get
			{
				if(r_MOnFilterTabChanged_PackageFilterTab == null)
				{
					r_MOnFilterTabChanged_PackageFilterTab = new(this, "OnFilterTabChanged", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageFilterTab"));
					r_MOnFilterTabChanged_PackageFilterTab.SetBelong(this.instance);
				}
				return r_MOnFilterTabChanged_PackageFilterTab;
			}
		}

		/// <summary>
		/// Void OnKeyDownShortcut(UnityEngine.UIElements.KeyDownEvent)
		/// </summary>
		protected RMethod r_MOnKeyDownShortcut_KeyDownEvent;
		public virtual RMethod RMOnKeyDownShortcut_KeyDownEvent
		{
			get
			{
				if(r_MOnKeyDownShortcut_KeyDownEvent == null)
				{
					r_MOnKeyDownShortcut_KeyDownEvent = new(this, "OnKeyDownShortcut", 0, typeof(UnityEngine.UIElements.KeyDownEvent));
					r_MOnKeyDownShortcut_KeyDownEvent.SetBelong(this.instance);
				}
				return r_MOnKeyDownShortcut_KeyDownEvent;
			}
		}

		/// <summary>
		/// Void OnNavigationMoveShortcut(UnityEngine.UIElements.NavigationMoveEvent)
		/// </summary>
		protected RMethod r_MOnNavigationMoveShortcut_NavigationMoveEvent;
		public virtual RMethod RMOnNavigationMoveShortcut_NavigationMoveEvent
		{
			get
			{
				if(r_MOnNavigationMoveShortcut_NavigationMoveEvent == null)
				{
					r_MOnNavigationMoveShortcut_NavigationMoveEvent = new(this, "OnNavigationMoveShortcut", 0, typeof(UnityEngine.UIElements.NavigationMoveEvent));
					r_MOnNavigationMoveShortcut_NavigationMoveEvent.SetBelong(this.instance);
				}
				return r_MOnNavigationMoveShortcut_NavigationMoveEvent;
			}
		}


        public RIPackageListView() : base("UnityEditor.PackageManager.UI.Internal.IPackageListView")
        {
        }

        public RIPackageListView(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IPackageListView")
		{
            SetInstance(instance);
		}

        public RIPackageListView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackageListView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageItem GetPackageItem(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMGetPackageItem_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageItem(___result);
        }


        public virtual void ScrollToSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMScrollToSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVisualStateChange(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> @visualStates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualStates.Value};
            var ___result = RMOnVisualStateChange_IEnumerable_d_VisualState_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnListRebuild(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPage @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value};
            var ___result = RMOnListRebuild_IPage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnListUpdate(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RListUpdateArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMOnListUpdate_ListUpdateArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFilterTabChanged(SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab @filterTab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filterTab.Value};
            var ___result = RMOnFilterTabChanged_PackageFilterTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnKeyDownShortcut(UnityEngine.UIElements.KeyDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnKeyDownShortcut_KeyDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNavigationMoveShortcut(UnityEngine.UIElements.NavigationMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnNavigationMoveShortcut_NavigationMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


    }
}
