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
		protected RUnityEngine.RUIElements.RIVisualTreeEditorUpdater r___0__visualTreeEditorUpdater__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIVisualTreeEditorUpdater R__0__visualTreeEditorUpdater__1__k__BackingField
		{
			get
			{
				if(r___0__visualTreeEditorUpdater__1__k__BackingField == null)
				{
					r___0__visualTreeEditorUpdater__1__k__BackingField = new(this, "<visualTreeEditorUpdater>k__BackingField");
					r___0__visualTreeEditorUpdater__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__visualTreeEditorUpdater__1__k__BackingField;
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
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void UpdateVisualTree()
		/// </summary>
		protected RMethod r_UpdateVisualTree;
		public virtual RMethod RUpdateVisualTree
		{
			get
			{
				if(r_UpdateVisualTree == null)
				{
					r_UpdateVisualTree = new(this, "UpdateVisualTree", 0);
					r_UpdateVisualTree.SetBelong(this.instance);
				}
				return r_UpdateVisualTree;
			}
		}

		/// <summary>
		/// Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_UpdateVisualTreePhase_VisualTreeUpdatePhase;
		public virtual RMethod RUpdateVisualTreePhase_VisualTreeUpdatePhase
		{
			get
			{
				if(r_UpdateVisualTreePhase_VisualTreeUpdatePhase == null)
				{
					r_UpdateVisualTreePhase_VisualTreeUpdatePhase = new(this, "UpdateVisualTreePhase", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_UpdateVisualTreePhase_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_UpdateVisualTreePhase_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_OnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_OnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_OnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_OnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_OnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void DirtyStyleSheets()
		/// </summary>
		protected RMethod r_DirtyStyleSheets;
		public virtual RMethod RDirtyStyleSheets
		{
			get
			{
				if(r_DirtyStyleSheets == null)
				{
					r_DirtyStyleSheets = new(this, "DirtyStyleSheets", 0);
					r_DirtyStyleSheets.SetBelong(this.instance);
				}
				return r_DirtyStyleSheets;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase == null)
				{
					r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase = new(this, "SetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetUpdater[T](UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_SetUpdater_GT_VisualTreeUpdatePhase;
		public virtual RMethod RSetUpdater_GT_VisualTreeUpdatePhase
		{
			get
			{
				if(r_SetUpdater_GT_VisualTreeUpdatePhase == null)
				{
					r_SetUpdater_GT_VisualTreeUpdatePhase = new(this, "SetUpdater", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_SetUpdater_GT_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_SetUpdater_GT_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_GetUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RGetUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_GetUpdater_VisualTreeUpdatePhase == null)
				{
					r_GetUpdater_VisualTreeUpdatePhase = new(this, "GetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_GetUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_GetUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SetDefaultUpdaters()
		/// </summary>
		protected RMethod r_SetDefaultUpdaters;
		public virtual RMethod RSetDefaultUpdaters
		{
			get
			{
				if(r_SetDefaultUpdaters == null)
				{
					r_SetDefaultUpdaters = new(this, "SetDefaultUpdaters", 0);
					r_SetDefaultUpdaters.SetBelong(this.instance);
				}
				return r_SetDefaultUpdaters;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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
