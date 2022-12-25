using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualTreeUpdater
	/// </summary>
    public partial class RVisualTreeUpdater : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel m_Panel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_m_Panel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel Rm_Panel
		{
			get
			{
				if(r_m_Panel == null)
				{
					r_m_Panel = new(this, "m_Panel");
					r_m_Panel.SetBelong(this.instance);
				}
				return r_m_Panel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeUpdater+UpdaterArray m_UpdaterArray
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeUpdater.RUpdaterArray r_m_UpdaterArray;
		public virtual RUnityEngine.RUIElements.RVisualTreeUpdater.RUpdaterArray Rm_UpdaterArray
		{
			get
			{
				if(r_m_UpdaterArray == null)
				{
					r_m_UpdaterArray = new(this, "m_UpdaterArray");
					r_m_UpdaterArray.SetBelong(this.instance);
				}
				return r_m_UpdaterArray;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeEditorUpdater <visualTreeEditorUpdater>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualTreeEditorUpdater r___1__visualTreeEditorUpdater__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIVisualTreeEditorUpdater R__1__visualTreeEditorUpdater__2__k__BackingField
		{
			get
			{
				if(r___1__visualTreeEditorUpdater__2__k__BackingField == null)
				{
					r___1__visualTreeEditorUpdater__2__k__BackingField = new(this, "<visualTreeEditorUpdater>k__BackingField");
					r___1__visualTreeEditorUpdater__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__visualTreeEditorUpdater__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeEditorUpdater visualTreeEditorUpdater
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualTreeEditorUpdater r_visualTreeEditorUpdater;
		public virtual RUnityEngine.RUIElements.RIVisualTreeEditorUpdater RvisualTreeEditorUpdater
		{
			get
			{
				if(r_visualTreeEditorUpdater == null)
				{
					r_visualTreeEditorUpdater = new(this, "visualTreeEditorUpdater", -1);
					r_visualTreeEditorUpdater.SetBelong(this.instance);
				}
				return r_visualTreeEditorUpdater;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void UpdateVisualTree()
		/// </summary>
		protected RMethod r_RUpdateVisualTree;
		public virtual RMethod RUpdateVisualTree
		{
			get
			{
				if(r_RUpdateVisualTree == null)
				{
					r_RUpdateVisualTree = new(this, "UpdateVisualTree", 0);
					r_RUpdateVisualTree.SetBelong(this.instance);
				}
				return r_RUpdateVisualTree;
			}
		}

		/// <summary>
		/// Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_RUpdateVisualTreePhase_VisualTreeUpdatePhase;
		public virtual RMethod RUpdateVisualTreePhase_VisualTreeUpdatePhase
		{
			get
			{
				if(r_RUpdateVisualTreePhase_VisualTreeUpdatePhase == null)
				{
					r_RUpdateVisualTreePhase_VisualTreeUpdatePhase = new(this, "UpdateVisualTreePhase", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_RUpdateVisualTreePhase_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_RUpdateVisualTreePhase_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_ROnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_ROnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_ROnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_ROnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_ROnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void DirtyStyleSheets()
		/// </summary>
		protected RMethod r_RDirtyStyleSheets;
		public virtual RMethod RDirtyStyleSheets
		{
			get
			{
				if(r_RDirtyStyleSheets == null)
				{
					r_RDirtyStyleSheets = new(this, "DirtyStyleSheets", 0);
					r_RDirtyStyleSheets.SetBelong(this.instance);
				}
				return r_RDirtyStyleSheets;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase == null)
				{
					r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase = new(this, "SetUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetUpdater[T](UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_RSetUpdater_GT_VisualTreeUpdatePhase;
		public virtual RMethod RSetUpdater_GT_VisualTreeUpdatePhase
		{
			get
			{
				if(r_RSetUpdater_GT_VisualTreeUpdatePhase == null)
				{
					r_RSetUpdater_GT_VisualTreeUpdatePhase = new(this, "SetUpdater", 1,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_RSetUpdater_GT_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_RSetUpdater_GT_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_RGetUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RGetUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_RGetUpdater_VisualTreeUpdatePhase == null)
				{
					r_RGetUpdater_VisualTreeUpdatePhase = new(this, "GetUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_RGetUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_RGetUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetDefaultUpdaters()
		/// </summary>
		protected RMethod r_RSetDefaultUpdaters;
		public virtual RMethod RSetDefaultUpdaters
		{
			get
			{
				if(r_RSetDefaultUpdaters == null)
				{
					r_RSetDefaultUpdaters = new(this, "SetDefaultUpdaters", 0);
					r_RSetDefaultUpdaters.SetBelong(this.instance);
				}
				return r_RSetDefaultUpdaters;
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
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVisualTree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateVisualTree.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void DirtyStyleSheets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDirtyStyleSheets.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void SetDefaultUpdaters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDefaultUpdaters.Invoke(___genericsType, ___parameters);

            
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
