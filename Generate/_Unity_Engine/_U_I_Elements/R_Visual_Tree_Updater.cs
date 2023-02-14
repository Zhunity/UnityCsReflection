
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualTreeUpdater
	/// </summary>
    public partial class RVisualTreeUpdater : RMember //
    {

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
					r_Fm_Panel.SetBelong(this.instance);
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
					r_Fm_UpdaterArray.SetBelong(this.instance);
				}
				return r_Fm_UpdaterArray;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeEditorUpdater <visualTreeEditorUpdater>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeEditorUpdater r_F__0__visualTreeEditorUpdater__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeEditorUpdater RF__0__visualTreeEditorUpdater__1__k__BackingField
		{
			get
			{
				if(r_F__0__visualTreeEditorUpdater__1__k__BackingField == null)
				{
					r_F__0__visualTreeEditorUpdater__1__k__BackingField = new(this, "<visualTreeEditorUpdater>k__BackingField");
					r_F__0__visualTreeEditorUpdater__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__visualTreeEditorUpdater__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeEditorUpdater visualTreeEditorUpdater
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeEditorUpdater r_PvisualTreeEditorUpdater;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeEditorUpdater RPvisualTreeEditorUpdater
		{
			get
			{
				if(r_PvisualTreeEditorUpdater == null)
				{
					r_PvisualTreeEditorUpdater = new(this, "visualTreeEditorUpdater", -1);
					r_PvisualTreeEditorUpdater.SetBelong(this.instance);
				}
				return r_PvisualTreeEditorUpdater;
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
					r_MDispose.SetBelong(this.instance);
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
					r_MUpdateVisualTree.SetBelong(this.instance);
				}
				return r_MUpdateVisualTree;
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
					r_MUpdateVisualTreePhase_VisualTreeUpdatePhase.SetBelong(this.instance);
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
					r_MOnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
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
					r_MDirtyStyleSheets.SetBelong(this.instance);
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
					r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
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
					r_MSetUpdater_GT_VisualTreeUpdatePhase.SetBelong(this.instance);
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
					r_MGetUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_MGetUpdater_VisualTreeUpdatePhase;
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
					r_MSetDefaultUpdaters.SetBelong(this.instance);
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

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
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
