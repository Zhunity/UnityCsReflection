
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.VisualTreeUpdater
	/// </summary>
    public partial class RVisualTreeUpdater : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdater");
            }
        }

        public RVisualTreeUpdater() : base("UnityEngine.UIElements.VisualTreeUpdater")
        {
        }

        public RVisualTreeUpdater(System.Object instance) : base("UnityEngine.UIElements.VisualTreeUpdater")
		{
            SetInstance(instance);
		}

        public RVisualTreeUpdater(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualTreeUpdater(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel m_Panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_Fm_Panel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RFm_Panel
		{
			get
			{
				if(r_Fm_Panel == null)
				{
					r_Fm_Panel = new(this, "m_Panel");
				}
				return r_Fm_Panel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeUpdater+UpdaterArray m_UpdaterArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdater.RUpdaterArray r_Fm_UpdaterArray;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdater.RUpdaterArray RFm_UpdaterArray
		{
			get
			{
				if(r_Fm_UpdaterArray == null)
				{
					r_Fm_UpdaterArray = new(this, "m_UpdaterArray");
				}
				return r_Fm_UpdaterArray;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeUpdater+EditorUpdaterArray m_EditorUpdaterArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdater.REditorUpdaterArray r_Fm_EditorUpdaterArray;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdater.REditorUpdaterArray RFm_EditorUpdaterArray
		{
			get
			{
				if(r_Fm_EditorUpdaterArray == null)
				{
					r_Fm_EditorUpdaterArray = new(this, "m_EditorUpdaterArray");
				}
				return r_Fm_EditorUpdaterArray;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void UpdateVisualTree()
		/// </summary>
		protected RMethod r_MUpdateVisualTree;
		public virtual RMethod RMUpdateVisualTree
		{
			get
			{
				if(r_MUpdateVisualTree == null)
				{
					r_MUpdateVisualTree = new(this, "UpdateVisualTree", 0);
				}
				return r_MUpdateVisualTree;
			}
		}

		/// <summary>
		/// Void UpdateEditorVisualTreePhase(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MUpdateEditorVisualTreePhase_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMUpdateEditorVisualTreePhase_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MUpdateEditorVisualTreePhase_VisualTreeEditorUpdatePhase == null)
				{
					r_MUpdateEditorVisualTreePhase_VisualTreeEditorUpdatePhase = new(this, "UpdateEditorVisualTreePhase", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
				}
				return r_MUpdateEditorVisualTreePhase_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_MUpdateVisualTreePhase_VisualTreeUpdatePhase;
		public virtual RMethod RMUpdateVisualTreePhase_VisualTreeUpdatePhase
		{
			get
			{
				if(r_MUpdateVisualTreePhase_VisualTreeUpdatePhase == null)
				{
					r_MUpdateVisualTreePhase_VisualTreeUpdatePhase = new(this, "UpdateVisualTreePhase", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
				}
				return r_MUpdateVisualTreePhase_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MOnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod RMOnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_MOnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_MOnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void DirtyStyleSheets()
		/// </summary>
		protected RMethod r_MDirtyStyleSheets;
		public virtual RMethod RMDirtyStyleSheets
		{
			get
			{
				if(r_MDirtyStyleSheets == null)
				{
					r_MDirtyStyleSheets = new(this, "DirtyStyleSheets", 0);
				}
				return r_MDirtyStyleSheets;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RMSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase == null)
				{
					r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase = new(this, "SetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
				}
				return r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetUpdater[T](UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_MSetUpdater_GT_VisualTreeUpdatePhase;
		public virtual RMethod RMSetUpdater_GT_VisualTreeUpdatePhase
		{
			get
			{
				if(r_MSetUpdater_GT_VisualTreeUpdatePhase == null)
				{
					r_MSetUpdater_GT_VisualTreeUpdatePhase = new(this, "SetUpdater", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
				}
				return r_MSetUpdater_GT_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_MGetUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RMGetUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_MGetUpdater_VisualTreeUpdatePhase == null)
				{
					r_MGetUpdater_VisualTreeUpdatePhase = new(this, "GetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
				}
				return r_MGetUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetEditorUpdater[T](UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MSetEditorUpdater_GT_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMSetEditorUpdater_GT_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MSetEditorUpdater_GT_VisualTreeEditorUpdatePhase == null)
				{
					r_MSetEditorUpdater_GT_VisualTreeEditorUpdatePhase = new(this, "SetEditorUpdater", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
				}
				return r_MSetEditorUpdater_GT_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetEditorUpdater(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MGetEditorUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMGetEditorUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MGetEditorUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_MGetEditorUpdater_VisualTreeEditorUpdatePhase = new(this, "GetEditorUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
				}
				return r_MGetEditorUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetDefaultUpdaters()
		/// </summary>
		protected RMethod r_MSetDefaultUpdaters;
		public virtual RMethod RMSetDefaultUpdaters
		{
			get
			{
				if(r_MSetDefaultUpdaters == null)
				{
					r_MSetDefaultUpdaters = new(this, "SetDefaultUpdaters", 0);
				}
				return r_MSetDefaultUpdaters;
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
				}
				return r_MToString;
			}
		}


		public virtual void Dispose()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMDispose.Invoke(___genericsType, ___parameters);
		}


		public virtual void UpdateVisualTree()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMUpdateVisualTree.Invoke(___genericsType, ___parameters);
		}


		public virtual void UpdateEditorVisualTreePhase(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@phase.Value};
			var ___result = RMUpdateEditorVisualTreePhase_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);
		}


		public virtual void UpdateVisualTreePhase(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@phase.Value};
			var ___result = RMUpdateVisualTreePhase_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @versionChangeType)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@ve, @versionChangeType.Value};
			var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);
		}


		public virtual void DirtyStyleSheets()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMDirtyStyleSheets.Invoke(___genericsType, ___parameters);
		}


		public virtual void SetUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater @updater, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@updater.Value, @phase.Value};
			var ___result = RMSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);
		}


		public virtual void SetUpdater<T>(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase) where T : new()
		{
			var ___genericsType = new Type[] {typeof(T)};
			var ___parameters = new object[]{@phase.Value};
			var ___result = RMSetUpdater_GT_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);
		}


		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater GetUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@phase.Value};
			var ___result = RMGetUpdater_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater>(___result);
		}


		public virtual void SetEditorUpdater<T>(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase) where T : new()
		{
			var ___genericsType = new Type[] {typeof(T)};
			var ___parameters = new object[]{@phase.Value};
			var ___result = RMSetEditorUpdater_GT_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);
		}


		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater GetEditorUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@phase.Value};
			var ___result = RMGetEditorUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater>(___result);
		}


		public virtual void SetDefaultUpdaters()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMSetDefaultUpdaters.Invoke(___genericsType, ___parameters);
		}


		public virtual System.Boolean Equals(System.Object @obj)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@obj};
			var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
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
			return ReflectionUtils.Convert<System.Int32>(___result);
		}


		public virtual System.Type GetType()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetType.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Type>(___result);
		}


		public virtual System.Object MemberwiseClone()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Object>(___result);
		}


		public virtual System.String ToString()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMToString.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


    }
}
