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
		protected RMethod r_Initialize_ObjectArray;
		public virtual RMethod RInitialize_ObjectArray
		{
			get
			{
				if(r_Initialize_ObjectArray == null)
				{
					r_Initialize_ObjectArray = new(this, "Initialize", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_Initialize_ObjectArray.SetBelong(this.instance);
				}
				return r_Initialize_ObjectArray;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_Cleanup;
		public virtual RMethod RCleanup
		{
			get
			{
				if(r_Cleanup == null)
				{
					r_Cleanup = new(this, "Cleanup", 0);
					r_Cleanup.SetBelong(this.instance);
				}
				return r_Cleanup;
			}
		}

		/// <summary>
		/// Boolean MoveNextTarget()
		/// </summary>
		protected RMethod r_MoveNextTarget;
		public virtual RMethod RMoveNextTarget
		{
			get
			{
				if(r_MoveNextTarget == null)
				{
					r_MoveNextTarget = new(this, "MoveNextTarget", 0);
					r_MoveNextTarget.SetBelong(this.instance);
				}
				return r_MoveNextTarget;
			}
		}

		/// <summary>
		/// Void ResetTarget()
		/// </summary>
		protected RMethod r_ResetTarget;
		public virtual RMethod RResetTarget
		{
			get
			{
				if(r_ResetTarget == null)
				{
					r_ResetTarget = new(this, "ResetTarget", 0);
					r_ResetTarget.SetBelong(this.instance);
				}
				return r_ResetTarget;
			}
		}

		/// <summary>
		/// Boolean HasPreviewGUI()
		/// </summary>
		protected RMethod r_HasPreviewGUI;
		public virtual RMethod RHasPreviewGUI
		{
			get
			{
				if(r_HasPreviewGUI == null)
				{
					r_HasPreviewGUI = new(this, "HasPreviewGUI", 0);
					r_HasPreviewGUI.SetBelong(this.instance);
				}
				return r_HasPreviewGUI;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetPreviewTitle()
		/// </summary>
		protected RMethod r_GetPreviewTitle;
		public virtual RMethod RGetPreviewTitle
		{
			get
			{
				if(r_GetPreviewTitle == null)
				{
					r_GetPreviewTitle = new(this, "GetPreviewTitle", 0);
					r_GetPreviewTitle.SetBelong(this.instance);
				}
				return r_GetPreviewTitle;
			}
		}

		/// <summary>
		/// Void DrawPreview(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DrawPreview_Rect;
		public virtual RMethod RDrawPreview_Rect
		{
			get
			{
				if(r_DrawPreview_Rect == null)
				{
					r_DrawPreview_Rect = new(this, "DrawPreview", 0, typeof(UnityEngine.Rect));
					r_DrawPreview_Rect.SetBelong(this.instance);
				}
				return r_DrawPreview_Rect;
			}
		}

		/// <summary>
		/// Void OnPreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_OnPreviewGUI_Rect_GUIStyle;
		public virtual RMethod ROnPreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_OnPreviewGUI_Rect_GUIStyle == null)
				{
					r_OnPreviewGUI_Rect_GUIStyle = new(this, "OnPreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_OnPreviewGUI_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_OnPreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnInteractivePreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_OnInteractivePreviewGUI_Rect_GUIStyle;
		public virtual RMethod ROnInteractivePreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_OnInteractivePreviewGUI_Rect_GUIStyle == null)
				{
					r_OnInteractivePreviewGUI_Rect_GUIStyle = new(this, "OnInteractivePreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_OnInteractivePreviewGUI_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_OnInteractivePreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnPreviewSettings()
		/// </summary>
		protected RMethod r_OnPreviewSettings;
		public virtual RMethod ROnPreviewSettings
		{
			get
			{
				if(r_OnPreviewSettings == null)
				{
					r_OnPreviewSettings = new(this, "OnPreviewSettings", 0);
					r_OnPreviewSettings.SetBelong(this.instance);
				}
				return r_OnPreviewSettings;
			}
		}

		/// <summary>
		/// System.String GetInfoString()
		/// </summary>
		protected RMethod r_GetInfoString;
		public virtual RMethod RGetInfoString
		{
			get
			{
				if(r_GetInfoString == null)
				{
					r_GetInfoString = new(this, "GetInfoString", 0);
					r_GetInfoString.SetBelong(this.instance);
				}
				return r_GetInfoString;
			}
		}

		/// <summary>
		/// Void ReloadPreviewInstances()
		/// </summary>
		protected RMethod r_ReloadPreviewInstances;
		public virtual RMethod RReloadPreviewInstances
		{
			get
			{
				if(r_ReloadPreviewInstances == null)
				{
					r_ReloadPreviewInstances = new(this, "ReloadPreviewInstances", 0);
					r_ReloadPreviewInstances.SetBelong(this.instance);
				}
				return r_ReloadPreviewInstances;
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

        public virtual void Initialize(UnityEngine.Object[] @targets)
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


        public virtual void DrawPreview(UnityEngine.Rect @previewArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previewArea};
            var ___result = RDrawPreview_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewGUI(UnityEngine.Rect @r, UnityEngine.GUIStyle @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = ROnPreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInteractivePreviewGUI(UnityEngine.Rect @r, UnityEngine.GUIStyle @background)
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
