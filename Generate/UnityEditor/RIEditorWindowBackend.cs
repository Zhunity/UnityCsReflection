using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IEditorWindowBackend
	/// </summary>
    public partial class RIEditorWindowBackend : RMember //
    {

		/// <summary>
		/// System.Action overlayGUIHandler
		/// </summary>
		protected REvent r_overlayGUIHandler;
		public virtual REvent RoverlayGUIHandler
		{
			get
			{
				if(r_overlayGUIHandler == null)
				{
					r_overlayGUIHandler = new(this, "overlayGUIHandler");
					r_overlayGUIHandler.SetBelong(this.instance);
				}
				return r_overlayGUIHandler;
			}
		}

		/// <summary>
		/// Void PlayModeTintColorChanged()
		/// </summary>
		protected RMethod r_PlayModeTintColorChanged;
		public virtual RMethod RPlayModeTintColorChanged
		{
			get
			{
				if(r_PlayModeTintColorChanged == null)
				{
					r_PlayModeTintColorChanged = new(this, "PlayModeTintColorChanged", 0);
					r_PlayModeTintColorChanged.SetBelong(this.instance);
				}
				return r_PlayModeTintColorChanged;
			}
		}

		/// <summary>
		/// Void NotificationVisibilityChanged()
		/// </summary>
		protected RMethod r_NotificationVisibilityChanged;
		public virtual RMethod RNotificationVisibilityChanged
		{
			get
			{
				if(r_NotificationVisibilityChanged == null)
				{
					r_NotificationVisibilityChanged = new(this, "NotificationVisibilityChanged", 0);
					r_NotificationVisibilityChanged.SetBelong(this.instance);
				}
				return r_NotificationVisibilityChanged;
			}
		}

		/// <summary>
		/// Void Focused()
		/// </summary>
		protected RMethod r_Focused;
		public virtual RMethod RFocused
		{
			get
			{
				if(r_Focused == null)
				{
					r_Focused = new(this, "Focused", 0);
					r_Focused.SetBelong(this.instance);
				}
				return r_Focused;
			}
		}

		/// <summary>
		/// Void Blurred()
		/// </summary>
		protected RMethod r_Blurred;
		public virtual RMethod RBlurred
		{
			get
			{
				if(r_Blurred == null)
				{
					r_Blurred = new(this, "Blurred", 0);
					r_Blurred.SetBelong(this.instance);
				}
				return r_Blurred;
			}
		}

		/// <summary>
		/// Void OnRegisterWindow()
		/// </summary>
		protected RMethod r_OnRegisterWindow;
		public virtual RMethod ROnRegisterWindow
		{
			get
			{
				if(r_OnRegisterWindow == null)
				{
					r_OnRegisterWindow = new(this, "OnRegisterWindow", 0);
					r_OnRegisterWindow.SetBelong(this.instance);
				}
				return r_OnRegisterWindow;
			}
		}

		/// <summary>
		/// Void OnUnregisterWindow()
		/// </summary>
		protected RMethod r_OnUnregisterWindow;
		public virtual RMethod ROnUnregisterWindow
		{
			get
			{
				if(r_OnUnregisterWindow == null)
				{
					r_OnUnregisterWindow = new(this, "OnUnregisterWindow", 0);
					r_OnUnregisterWindow.SetBelong(this.instance);
				}
				return r_OnUnregisterWindow;
			}
		}

		/// <summary>
		/// Void OnDisplayWindowMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_OnDisplayWindowMenu_GenericMenu;
		public virtual RMethod ROnDisplayWindowMenu_GenericMenu
		{
			get
			{
				if(r_OnDisplayWindowMenu_GenericMenu == null)
				{
					r_OnDisplayWindowMenu_GenericMenu = new(this, "OnDisplayWindowMenu", 0, typeof(UnityEditor.GenericMenu));
					r_OnDisplayWindowMenu_GenericMenu.SetBelong(this.instance);
				}
				return r_OnDisplayWindowMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ViewMarginsChanged()
		/// </summary>
		protected RMethod r_ViewMarginsChanged;
		public virtual RMethod RViewMarginsChanged
		{
			get
			{
				if(r_ViewMarginsChanged == null)
				{
					r_ViewMarginsChanged = new(this, "ViewMarginsChanged", 0);
					r_ViewMarginsChanged.SetBelong(this.instance);
				}
				return r_ViewMarginsChanged;
			}
		}


        public RIEditorWindowBackend() : base("UnityEditor.IEditorWindowBackend")
        {
        }

        public RIEditorWindowBackend(System.Object instance) : base("UnityEditor.IEditorWindowBackend")
		{
            SetInstance(instance);
		}

        public RIEditorWindowBackend(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIEditorWindowBackend(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void PlayModeTintColorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPlayModeTintColorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotificationVisibilityChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNotificationVisibilityChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focused()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocused.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blurred()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlurred.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRegisterWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnRegisterWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUnregisterWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnUnregisterWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisplayWindowMenu(UnityEditor.GenericMenu @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu};
            var ___result = ROnDisplayWindowMenu_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ViewMarginsChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RViewMarginsChanged.Invoke(___genericsType, ___parameters);

            
        }


    }
}
