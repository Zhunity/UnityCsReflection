
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IEditorWindowBackend
	/// </summary>
    public partial class RIEditorWindowBackend : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IEditorWindowBackend");
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


		/// <summary>
		/// System.Action overlayGUIHandler
		/// </summary>
		protected REvent r_EoverlayGUIHandler;
		public virtual REvent REoverlayGUIHandler
		{
			get
			{
				if(r_EoverlayGUIHandler == null)
				{
					r_EoverlayGUIHandler = new(this, "overlayGUIHandler");
				}
				return r_EoverlayGUIHandler;
			}
		}

		/// <summary>
		/// Void PlayModeTintColorChanged()
		/// </summary>
		protected RMethod r_MPlayModeTintColorChanged;
		public virtual RMethod RMPlayModeTintColorChanged
		{
			get
			{
				if(r_MPlayModeTintColorChanged == null)
				{
					r_MPlayModeTintColorChanged = new(this, "PlayModeTintColorChanged", 0);
				}
				return r_MPlayModeTintColorChanged;
			}
		}

		/// <summary>
		/// Void NotificationVisibilityChanged()
		/// </summary>
		protected RMethod r_MNotificationVisibilityChanged;
		public virtual RMethod RMNotificationVisibilityChanged
		{
			get
			{
				if(r_MNotificationVisibilityChanged == null)
				{
					r_MNotificationVisibilityChanged = new(this, "NotificationVisibilityChanged", 0);
				}
				return r_MNotificationVisibilityChanged;
			}
		}

		/// <summary>
		/// Void Focused()
		/// </summary>
		protected RMethod r_MFocused;
		public virtual RMethod RMFocused
		{
			get
			{
				if(r_MFocused == null)
				{
					r_MFocused = new(this, "Focused", 0);
				}
				return r_MFocused;
			}
		}

		/// <summary>
		/// Void Blurred()
		/// </summary>
		protected RMethod r_MBlurred;
		public virtual RMethod RMBlurred
		{
			get
			{
				if(r_MBlurred == null)
				{
					r_MBlurred = new(this, "Blurred", 0);
				}
				return r_MBlurred;
			}
		}

		/// <summary>
		/// Void OnRegisterWindow()
		/// </summary>
		protected RMethod r_MOnRegisterWindow;
		public virtual RMethod RMOnRegisterWindow
		{
			get
			{
				if(r_MOnRegisterWindow == null)
				{
					r_MOnRegisterWindow = new(this, "OnRegisterWindow", 0);
				}
				return r_MOnRegisterWindow;
			}
		}

		/// <summary>
		/// Void OnUnregisterWindow()
		/// </summary>
		protected RMethod r_MOnUnregisterWindow;
		public virtual RMethod RMOnUnregisterWindow
		{
			get
			{
				if(r_MOnUnregisterWindow == null)
				{
					r_MOnUnregisterWindow = new(this, "OnUnregisterWindow", 0);
				}
				return r_MOnUnregisterWindow;
			}
		}

		/// <summary>
		/// Void OnDisplayWindowMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_MOnDisplayWindowMenu_GenericMenu;
		public virtual RMethod RMOnDisplayWindowMenu_GenericMenu
		{
			get
			{
				if(r_MOnDisplayWindowMenu_GenericMenu == null)
				{
					r_MOnDisplayWindowMenu_GenericMenu = new(this, "OnDisplayWindowMenu", 0, typeof(UnityEditor.GenericMenu));
				}
				return r_MOnDisplayWindowMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ViewMarginsChanged()
		/// </summary>
		protected RMethod r_MViewMarginsChanged;
		public virtual RMethod RMViewMarginsChanged
		{
			get
			{
				if(r_MViewMarginsChanged == null)
				{
					r_MViewMarginsChanged = new(this, "ViewMarginsChanged", 0);
				}
				return r_MViewMarginsChanged;
			}
		}


        public virtual void PlayModeTintColorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPlayModeTintColorChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotificationVisibilityChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNotificationVisibilityChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focused()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocused.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blurred()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlurred.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRegisterWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnRegisterWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUnregisterWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnUnregisterWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisplayWindowMenu(UnityEditor.GenericMenu @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu};
            var ___result = RMOnDisplayWindowMenu_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ViewMarginsChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMViewMarginsChanged.Invoke(___genericsType, ___parameters);

            
        }


    }
}
