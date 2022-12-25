using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IPreviewable
	/// </summary>
    public partial class RIPreviewable : RMember //
    {

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected RUnityEngine.RObject r_target;
		public virtual RUnityEngine.RObject Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target", -1);
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_RInitialize_ObjectArray;
		public virtual RMethod RInitialize_ObjectArray
		{
			get
			{
				if(r_RInitialize_ObjectArray == null)
				{
					r_RInitialize_ObjectArray = new(this, "Initialize", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_RInitialize_ObjectArray.SetBelong(this.instance);
				}
				return r_RInitialize_ObjectArray;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_RCleanup;
		public virtual RMethod RCleanup
		{
			get
			{
				if(r_RCleanup == null)
				{
					r_RCleanup = new(this, "Cleanup", 0);
					r_RCleanup.SetBelong(this.instance);
				}
				return r_RCleanup;
			}
		}

		/// <summary>
		/// Boolean MoveNextTarget()
		/// </summary>
		protected RMethod r_RMoveNextTarget;
		public virtual RMethod RMoveNextTarget
		{
			get
			{
				if(r_RMoveNextTarget == null)
				{
					r_RMoveNextTarget = new(this, "MoveNextTarget", 0);
					r_RMoveNextTarget.SetBelong(this.instance);
				}
				return r_RMoveNextTarget;
			}
		}

		/// <summary>
		/// Void ResetTarget()
		/// </summary>
		protected RMethod r_RResetTarget;
		public virtual RMethod RResetTarget
		{
			get
			{
				if(r_RResetTarget == null)
				{
					r_RResetTarget = new(this, "ResetTarget", 0);
					r_RResetTarget.SetBelong(this.instance);
				}
				return r_RResetTarget;
			}
		}

		/// <summary>
		/// Boolean HasPreviewGUI()
		/// </summary>
		protected RMethod r_RHasPreviewGUI;
		public virtual RMethod RHasPreviewGUI
		{
			get
			{
				if(r_RHasPreviewGUI == null)
				{
					r_RHasPreviewGUI = new(this, "HasPreviewGUI", 0);
					r_RHasPreviewGUI.SetBelong(this.instance);
				}
				return r_RHasPreviewGUI;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetPreviewTitle()
		/// </summary>
		protected RMethod r_RGetPreviewTitle;
		public virtual RMethod RGetPreviewTitle
		{
			get
			{
				if(r_RGetPreviewTitle == null)
				{
					r_RGetPreviewTitle = new(this, "GetPreviewTitle", 0);
					r_RGetPreviewTitle.SetBelong(this.instance);
				}
				return r_RGetPreviewTitle;
			}
		}

		/// <summary>
		/// Void DrawPreview(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RDrawPreview_Rect;
		public virtual RMethod RDrawPreview_Rect
		{
			get
			{
				if(r_RDrawPreview_Rect == null)
				{
					r_RDrawPreview_Rect = new(this, "DrawPreview", 0, typeof(UnityEngine.Rect));
					r_RDrawPreview_Rect.SetBelong(this.instance);
				}
				return r_RDrawPreview_Rect;
			}
		}

		/// <summary>
		/// Void OnPreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_ROnPreviewGUI_Rect_GUIStyle;
		public virtual RMethod ROnPreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_ROnPreviewGUI_Rect_GUIStyle == null)
				{
					r_ROnPreviewGUI_Rect_GUIStyle = new(this, "OnPreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_ROnPreviewGUI_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_ROnPreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnInteractivePreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_ROnInteractivePreviewGUI_Rect_GUIStyle;
		public virtual RMethod ROnInteractivePreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_ROnInteractivePreviewGUI_Rect_GUIStyle == null)
				{
					r_ROnInteractivePreviewGUI_Rect_GUIStyle = new(this, "OnInteractivePreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_ROnInteractivePreviewGUI_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_ROnInteractivePreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnPreviewSettings()
		/// </summary>
		protected RMethod r_ROnPreviewSettings;
		public virtual RMethod ROnPreviewSettings
		{
			get
			{
				if(r_ROnPreviewSettings == null)
				{
					r_ROnPreviewSettings = new(this, "OnPreviewSettings", 0);
					r_ROnPreviewSettings.SetBelong(this.instance);
				}
				return r_ROnPreviewSettings;
			}
		}

		/// <summary>
		/// System.String GetInfoString()
		/// </summary>
		protected RMethod r_RGetInfoString;
		public virtual RMethod RGetInfoString
		{
			get
			{
				if(r_RGetInfoString == null)
				{
					r_RGetInfoString = new(this, "GetInfoString", 0);
					r_RGetInfoString.SetBelong(this.instance);
				}
				return r_RGetInfoString;
			}
		}

		/// <summary>
		/// Void ReloadPreviewInstances()
		/// </summary>
		protected RMethod r_RReloadPreviewInstances;
		public virtual RMethod RReloadPreviewInstances
		{
			get
			{
				if(r_RReloadPreviewInstances == null)
				{
					r_RReloadPreviewInstances = new(this, "ReloadPreviewInstances", 0);
					r_RReloadPreviewInstances.SetBelong(this.instance);
				}
				return r_RReloadPreviewInstances;
			}
		}


        public RIPreviewable() : base("UnityEditor.IPreviewable")
        {
        }

        public RIPreviewable(System.Object instance) : base("UnityEditor.IPreviewable")
		{
            SetInstance(instance);
		}

        public RIPreviewable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPreviewable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initialize(UnityEngine.Object[]  @targets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targets};
            var ___result = RInitialize_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNextTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNextTarget.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ResetTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasPreviewGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasPreviewGUI.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.GUIContent GetPreviewTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreviewTitle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void DrawPreview(UnityEngine.Rect  @previewArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previewArea};
            var ___result = RDrawPreview_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewGUI(UnityEngine.Rect  @r, UnityEngine.GUIStyle  @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = ROnPreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInteractivePreviewGUI(UnityEngine.Rect  @r, UnityEngine.GUIStyle  @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = ROnInteractivePreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnPreviewSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetInfoString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInfoString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ReloadPreviewInstances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReloadPreviewInstances.Invoke(___genericsType, ___parameters);

            
        }


    }
}
