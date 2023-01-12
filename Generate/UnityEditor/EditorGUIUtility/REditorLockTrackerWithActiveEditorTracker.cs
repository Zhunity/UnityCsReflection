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
		protected RUnityEditor.RActiveEditorTracker r_Fm_Tracker;
		public virtual RUnityEditor.RActiveEditorTracker RFm_Tracker
		{
			get
			{
				if(r_Fm_Tracker == null)
				{
					r_Fm_Tracker = new(this, "m_Tracker");
					r_Fm_Tracker.SetBelong(this.instance);
				}
				return r_Fm_Tracker;
			}
		}

		/// <summary>
		/// UnityEditor.EditorGUIUtility+EditorLockTracker+LockStateEvent lockStateChanged
		/// </summary>
		protected RUnityEditor.REditorGUIUtility.REditorLockTracker.RLockStateEvent r_FlockStateChanged;
		public virtual RUnityEditor.REditorGUIUtility.REditorLockTracker.RLockStateEvent RFlockStateChanged
		{
			get
			{
				if(r_FlockStateChanged == null)
				{
					r_FlockStateChanged = new(this, "lockStateChanged");
					r_FlockStateChanged.SetBelong(this.instance);
				}
				return r_FlockStateChanged;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected RSystem.RBoolean r_PisLocked;
		public virtual RSystem.RBoolean RPisLocked
		{
			get
			{
				if(r_PisLocked == null)
				{
					r_PisLocked = new(this, "isLocked", -1);
					r_PisLocked.SetBelong(this.instance);
				}
				return r_PisLocked;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker tracker
		/// </summary>
		protected RUnityEditor.RActiveEditorTracker r_Ptracker;
		public virtual RUnityEditor.RActiveEditorTracker RPtracker
		{
			get
			{
				if(r_Ptracker == null)
				{
					r_Ptracker = new(this, "tracker", -1);
					r_Ptracker.SetBelong(this.instance);
				}
				return r_Ptracker;
			}
		}

		/// <summary>
		/// Void AddItemsToMenu(UnityEditor.GenericMenu, Boolean)
		/// </summary>
		protected RMethod r_MAddItemsToMenu_GenericMenu_Boolean;
		public virtual RMethod RMAddItemsToMenu_GenericMenu_Boolean
		{
			get
			{
				if(r_MAddItemsToMenu_GenericMenu_Boolean == null)
				{
					r_MAddItemsToMenu_GenericMenu_Boolean = new(this, "AddItemsToMenu", 0, typeof(UnityEditor.GenericMenu), typeof(System.Boolean));
					r_MAddItemsToMenu_GenericMenu_Boolean.SetBelong(this.instance);
				}
				return r_MAddItemsToMenu_GenericMenu_Boolean;
			}
		}

		/// <summary>
		/// Void PingIcon()
		/// </summary>
		protected RMethod r_MPingIcon;
		public virtual RMethod RMPingIcon
		{
			get
			{
				if(r_MPingIcon == null)
				{
					r_MPingIcon = new(this, "PingIcon", 0);
					r_MPingIcon.SetBelong(this.instance);
				}
				return r_MPingIcon;
			}
		}

		/// <summary>
		/// Void StopPingIcon()
		/// </summary>
		protected RMethod r_MStopPingIcon;
		public virtual RMethod RMStopPingIcon
		{
			get
			{
				if(r_MStopPingIcon == null)
				{
					r_MStopPingIcon = new(this, "StopPingIcon", 0);
					r_MStopPingIcon.SetBelong(this.instance);
				}
				return r_MStopPingIcon;
			}
		}

		/// <summary>
		/// Boolean ShowButton(UnityEngine.Rect, UnityEngine.GUIStyle, Boolean)
		/// </summary>
		protected RMethod r_MShowButton_Rect_GUIStyle_Boolean;
		public virtual RMethod RMShowButton_Rect_GUIStyle_Boolean
		{
			get
			{
				if(r_MShowButton_Rect_GUIStyle_Boolean == null)
				{
					r_MShowButton_Rect_GUIStyle_Boolean = new(this, "ShowButton", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle), typeof(System.Boolean));
					r_MShowButton_Rect_GUIStyle_Boolean.SetBelong(this.instance);
				}
				return r_MShowButton_Rect_GUIStyle_Boolean;
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

        public virtual void AddItemsToMenu(UnityEditor.GenericMenu @menu, System.Boolean @disabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @disabled};
            var ___result = RMAddItemsToMenu_GenericMenu_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PingIcon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPingIcon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopPingIcon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopPingIcon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShowButton(UnityEngine.Rect @position, UnityEngine.GUIStyle @lockButtonStyle, System.Boolean @disabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @lockButtonStyle, @disabled};
            var ___result = RMShowButton_Rect_GUIStyle_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
}