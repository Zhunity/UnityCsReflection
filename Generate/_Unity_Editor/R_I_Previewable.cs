
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IPreviewable
	/// </summary>
    public partial class RIPreviewable : RMember //
    {

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
					r_Ptarget.SetBelong(this.GetValue());
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_MInitialize_ObjectArray;
		public virtual RMethod RMInitialize_ObjectArray
		{
			get
			{
				if(r_MInitialize_ObjectArray == null)
				{
					r_MInitialize_ObjectArray = new(this, "Initialize", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_MInitialize_ObjectArray.SetBelong(this.GetValue());
				}
				return r_MInitialize_ObjectArray;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_MCleanup;
		public virtual RMethod RMCleanup
		{
			get
			{
				if(r_MCleanup == null)
				{
					r_MCleanup = new(this, "Cleanup", 0);
					r_MCleanup.SetBelong(this.GetValue());
				}
				return r_MCleanup;
			}
		}

		/// <summary>
		/// Boolean MoveNextTarget()
		/// </summary>
		protected RMethod r_MMoveNextTarget;
		public virtual RMethod RMMoveNextTarget
		{
			get
			{
				if(r_MMoveNextTarget == null)
				{
					r_MMoveNextTarget = new(this, "MoveNextTarget", 0);
					r_MMoveNextTarget.SetBelong(this.GetValue());
				}
				return r_MMoveNextTarget;
			}
		}

		/// <summary>
		/// Void ResetTarget()
		/// </summary>
		protected RMethod r_MResetTarget;
		public virtual RMethod RMResetTarget
		{
			get
			{
				if(r_MResetTarget == null)
				{
					r_MResetTarget = new(this, "ResetTarget", 0);
					r_MResetTarget.SetBelong(this.GetValue());
				}
				return r_MResetTarget;
			}
		}

		/// <summary>
		/// Boolean HasPreviewGUI()
		/// </summary>
		protected RMethod r_MHasPreviewGUI;
		public virtual RMethod RMHasPreviewGUI
		{
			get
			{
				if(r_MHasPreviewGUI == null)
				{
					r_MHasPreviewGUI = new(this, "HasPreviewGUI", 0);
					r_MHasPreviewGUI.SetBelong(this.GetValue());
				}
				return r_MHasPreviewGUI;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetPreviewTitle()
		/// </summary>
		protected RMethod r_MGetPreviewTitle;
		public virtual RMethod RMGetPreviewTitle
		{
			get
			{
				if(r_MGetPreviewTitle == null)
				{
					r_MGetPreviewTitle = new(this, "GetPreviewTitle", 0);
					r_MGetPreviewTitle.SetBelong(this.GetValue());
				}
				return r_MGetPreviewTitle;
			}
		}

		/// <summary>
		/// Void DrawPreview(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDrawPreview_Rect;
		public virtual RMethod RMDrawPreview_Rect
		{
			get
			{
				if(r_MDrawPreview_Rect == null)
				{
					r_MDrawPreview_Rect = new(this, "DrawPreview", 0, typeof(UnityEngine.Rect));
					r_MDrawPreview_Rect.SetBelong(this.GetValue());
				}
				return r_MDrawPreview_Rect;
			}
		}

		/// <summary>
		/// Void OnPreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MOnPreviewGUI_Rect_GUIStyle;
		public virtual RMethod RMOnPreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_MOnPreviewGUI_Rect_GUIStyle == null)
				{
					r_MOnPreviewGUI_Rect_GUIStyle = new(this, "OnPreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_MOnPreviewGUI_Rect_GUIStyle.SetBelong(this.GetValue());
				}
				return r_MOnPreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnInteractivePreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MOnInteractivePreviewGUI_Rect_GUIStyle;
		public virtual RMethod RMOnInteractivePreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_MOnInteractivePreviewGUI_Rect_GUIStyle == null)
				{
					r_MOnInteractivePreviewGUI_Rect_GUIStyle = new(this, "OnInteractivePreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_MOnInteractivePreviewGUI_Rect_GUIStyle.SetBelong(this.GetValue());
				}
				return r_MOnInteractivePreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnPreviewSettings()
		/// </summary>
		protected RMethod r_MOnPreviewSettings;
		public virtual RMethod RMOnPreviewSettings
		{
			get
			{
				if(r_MOnPreviewSettings == null)
				{
					r_MOnPreviewSettings = new(this, "OnPreviewSettings", 0);
					r_MOnPreviewSettings.SetBelong(this.GetValue());
				}
				return r_MOnPreviewSettings;
			}
		}

		/// <summary>
		/// System.String GetInfoString()
		/// </summary>
		protected RMethod r_MGetInfoString;
		public virtual RMethod RMGetInfoString
		{
			get
			{
				if(r_MGetInfoString == null)
				{
					r_MGetInfoString = new(this, "GetInfoString", 0);
					r_MGetInfoString.SetBelong(this.GetValue());
				}
				return r_MGetInfoString;
			}
		}

		/// <summary>
		/// Void ReloadPreviewInstances()
		/// </summary>
		protected RMethod r_MReloadPreviewInstances;
		public virtual RMethod RMReloadPreviewInstances
		{
			get
			{
				if(r_MReloadPreviewInstances == null)
				{
					r_MReloadPreviewInstances = new(this, "ReloadPreviewInstances", 0);
					r_MReloadPreviewInstances.SetBelong(this.GetValue());
				}
				return r_MReloadPreviewInstances;
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
            var ___result = RMInitialize_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNextTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNextTarget.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ResetTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasPreviewGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasPreviewGUI.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.GUIContent GetPreviewTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviewTitle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void DrawPreview(UnityEngine.Rect @previewArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previewArea};
            var ___result = RMDrawPreview_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewGUI(UnityEngine.Rect @r, UnityEngine.GUIStyle @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = RMOnPreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInteractivePreviewGUI(UnityEngine.Rect @r, UnityEngine.GUIStyle @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = RMOnInteractivePreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnPreviewSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetInfoString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInfoString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ReloadPreviewInstances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReloadPreviewInstances.Invoke(___genericsType, ___parameters);

            
        }


    }
}
