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
		protected RMethod r_RPlayModeTintColorChanged;
		public virtual RMethod RPlayModeTintColorChanged
		{
			get
			{
				if(r_RPlayModeTintColorChanged == null)
				{
					r_RPlayModeTintColorChanged = new(this, "PlayModeTintColorChanged", 0);
					r_RPlayModeTintColorChanged.SetBelong(this.instance);
				}
				return r_RPlayModeTintColorChanged;
			}
		}

		/// <summary>
		/// Void NotificationVisibilityChanged()
		/// </summary>
		protected RMethod r_RNotificationVisibilityChanged;
		public virtual RMethod RNotificationVisibilityChanged
		{
			get
			{
				if(r_RNotificationVisibilityChanged == null)
				{
					r_RNotificationVisibilityChanged = new(this, "NotificationVisibilityChanged", 0);
					r_RNotificationVisibilityChanged.SetBelong(this.instance);
				}
				return r_RNotificationVisibilityChanged;
			}
		}

		/// <summary>
		/// Void Focused()
		/// </summary>
		protected RMethod r_RFocused;
		public virtual RMethod RFocused
		{
			get
			{
				if(r_RFocused == null)
				{
					r_RFocused = new(this, "Focused", 0);
					r_RFocused.SetBelong(this.instance);
				}
				return r_RFocused;
			}
		}

		/// <summary>
		/// Void Blurred()
		/// </summary>
		protected RMethod r_RBlurred;
		public virtual RMethod RBlurred
		{
			get
			{
				if(r_RBlurred == null)
				{
					r_RBlurred = new(this, "Blurred", 0);
					r_RBlurred.SetBelong(this.instance);
				}
				return r_RBlurred;
			}
		}

		/// <summary>
		/// Void OnRegisterWindow()
		/// </summary>
		protected RMethod r_ROnRegisterWindow;
		public virtual RMethod ROnRegisterWindow
		{
			get
			{
				if(r_ROnRegisterWindow == null)
				{
					r_ROnRegisterWindow = new(this, "OnRegisterWindow", 0);
					r_ROnRegisterWindow.SetBelong(this.instance);
				}
				return r_ROnRegisterWindow;
			}
		}

		/// <summary>
		/// Void OnUnregisterWindow()
		/// </summary>
		protected RMethod r_ROnUnregisterWindow;
		public virtual RMethod ROnUnregisterWindow
		{
			get
			{
				if(r_ROnUnregisterWindow == null)
				{
					r_ROnUnregisterWindow = new(this, "OnUnregisterWindow", 0);
					r_ROnUnregisterWindow.SetBelong(this.instance);
				}
				return r_ROnUnregisterWindow;
			}
		}

		/// <summary>
		/// Void OnDisplayWindowMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_ROnDisplayWindowMenu_GenericMenu;
		public virtual RMethod ROnDisplayWindowMenu_GenericMenu
		{
			get
			{
				if(r_ROnDisplayWindowMenu_GenericMenu == null)
				{
					r_ROnDisplayWindowMenu_GenericMenu = new(this, "OnDisplayWindowMenu", 0, typeof(UnityEditor.GenericMenu));
					r_ROnDisplayWindowMenu_GenericMenu.SetBelong(this.instance);
				}
				return r_ROnDisplayWindowMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ViewMarginsChanged()
		/// </summary>
		protected RMethod r_RViewMarginsChanged;
		public virtual RMethod RViewMarginsChanged
		{
			get
			{
				if(r_RViewMarginsChanged == null)
				{
					r_RViewMarginsChanged = new(this, "ViewMarginsChanged", 0);
					r_RViewMarginsChanged.SetBelong(this.instance);
				}
				return r_RViewMarginsChanged;
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


        public virtual void OnDisplayWindowMenu(UnityEditor.GenericMenu  @menu)
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
