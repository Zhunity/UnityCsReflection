using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class REditorGUIUtility
{
	
	/// <summary>
	/// UnityEditor.EditorGUIUtility+EditorLockTrackerWithActiveEditorTracker
	/// </summary>
    public partial class REditorLockTrackerWithActiveEditorTracker : RMember //
    {

		/// <summary>
		/// UnityEditor.ActiveEditorTracker m_Tracker
		/// </summary>
		protected RUnityEditor.RActiveEditorTracker r_m_Tracker;
		public virtual RUnityEditor.RActiveEditorTracker Rm_Tracker
		{
			get
			{
				if(r_m_Tracker == null)
				{
					r_m_Tracker = new(this, "m_Tracker");
					r_m_Tracker.SetBelong(this.instance);
				}
				return r_m_Tracker;
			}
		}

		/// <summary>
		/// UnityEditor.EditorGUIUtility+EditorLockTracker+LockStateEvent lockStateChanged
		/// </summary>
		protected RUnityEditor.REditorGUIUtility.REditorLockTracker.RLockStateEvent r_lockStateChanged;
		public virtual RUnityEditor.REditorGUIUtility.REditorLockTracker.RLockStateEvent RlockStateChanged
		{
			get
			{
				if(r_lockStateChanged == null)
				{
					r_lockStateChanged = new(this, "lockStateChanged");
					r_lockStateChanged.SetBelong(this.instance);
				}
				return r_lockStateChanged;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected RProperty r_isLocked;
		public virtual RProperty RisLocked
		{
			get
			{
				if(r_isLocked == null)
				{
					r_isLocked = new(this, "isLocked", -1);
					r_isLocked.SetBelong(this.instance);
				}
				return r_isLocked;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker tracker
		/// </summary>
		protected RUnityEditor.RActiveEditorTracker r_tracker;
		public virtual RUnityEditor.RActiveEditorTracker Rtracker
		{
			get
			{
				if(r_tracker == null)
				{
					r_tracker = new(this, "tracker", -1);
					r_tracker.SetBelong(this.instance);
				}
				return r_tracker;
			}
		}

		/// <summary>
		/// Void AddItemsToMenu(UnityEditor.GenericMenu, Boolean)
		/// </summary>
		protected RMethod r_RAddItemsToMenu_GenericMenu_Boolean;
		public virtual RMethod RAddItemsToMenu_GenericMenu_Boolean
		{
			get
			{
				if(r_RAddItemsToMenu_GenericMenu_Boolean == null)
				{
					r_RAddItemsToMenu_GenericMenu_Boolean = new(this, "AddItemsToMenu", 0, typeof(UnityEditor.GenericMenu), typeof(System.Boolean));
					r_RAddItemsToMenu_GenericMenu_Boolean.SetBelong(this.instance);
				}
				return r_RAddItemsToMenu_GenericMenu_Boolean;
			}
		}

		/// <summary>
		/// Void PingIcon()
		/// </summary>
		protected RMethod r_RPingIcon;
		public virtual RMethod RPingIcon
		{
			get
			{
				if(r_RPingIcon == null)
				{
					r_RPingIcon = new(this, "PingIcon", 0);
					r_RPingIcon.SetBelong(this.instance);
				}
				return r_RPingIcon;
			}
		}

		/// <summary>
		/// Void StopPingIcon()
		/// </summary>
		protected RMethod r_RStopPingIcon;
		public virtual RMethod RStopPingIcon
		{
			get
			{
				if(r_RStopPingIcon == null)
				{
					r_RStopPingIcon = new(this, "StopPingIcon", 0);
					r_RStopPingIcon.SetBelong(this.instance);
				}
				return r_RStopPingIcon;
			}
		}

		/// <summary>
		/// Boolean ShowButton(UnityEngine.Rect, UnityEngine.GUIStyle, Boolean)
		/// </summary>
		protected RMethod r_RShowButton_Rect_GUIStyle_Boolean;
		public virtual RMethod RShowButton_Rect_GUIStyle_Boolean
		{
			get
			{
				if(r_RShowButton_Rect_GUIStyle_Boolean == null)
				{
					r_RShowButton_Rect_GUIStyle_Boolean = new(this, "ShowButton", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle), typeof(System.Boolean));
					r_RShowButton_Rect_GUIStyle_Boolean.SetBelong(this.instance);
				}
				return r_RShowButton_Rect_GUIStyle_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}


        public REditorLockTrackerWithActiveEditorTracker() : base("UnityEditor.EditorGUIUtility+EditorLockTrackerWithActiveEditorTracker")
        {
        }

        public REditorLockTrackerWithActiveEditorTracker(System.Object instance) : base("UnityEditor.EditorGUIUtility+EditorLockTrackerWithActiveEditorTracker")
		{
            SetInstance(instance);
		}

        public REditorLockTrackerWithActiveEditorTracker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REditorLockTrackerWithActiveEditorTracker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddItemsToMenu(UnityEditor.GenericMenu  @menu, System.Boolean  @disabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @disabled};
            var ___result = RAddItemsToMenu_GenericMenu_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PingIcon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPingIcon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopPingIcon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopPingIcon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShowButton(UnityEngine.Rect  @position, UnityEngine.GUIStyle  @lockButtonStyle, System.Boolean  @disabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @lockButtonStyle, @disabled};
            var ___result = RShowButton_Rect_GUIStyle_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}