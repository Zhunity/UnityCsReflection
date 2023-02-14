
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.MenuDropdownItem
	/// </summary>
    public partial class RMenuDropdownItem : RMember //
    {

		/// <summary>
		/// System.Action onVisibleChanged
		/// </summary>
		protected REvent r_EonVisibleChanged;
		public virtual REvent REonVisibleChanged
		{
			get
			{
				if(r_EonVisibleChanged == null)
				{
					r_EonVisibleChanged = new(this, "onVisibleChanged");
					r_EonVisibleChanged.SetBelong(this.instance);
				}
				return r_EonVisibleChanged;
			}
		}

		/// <summary>
		/// System.Object <userData>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F__0__userData__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF__0__userData__1__k__BackingField
		{
			get
			{
				if(r_F__0__userData__1__k__BackingField == null)
				{
					r_F__0__userData__1__k__BackingField = new(this, "<userData>k__BackingField");
					r_F__0__userData__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__userData__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action m_Action
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Fm_Action;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFm_Action
		{
			get
			{
				if(r_Fm_Action == null)
				{
					r_Fm_Action = new(this, "m_Action");
					r_Fm_Action.SetBelong(this.instance);
				}
				return r_Fm_Action;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PuserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
					r_PuserData.SetBelong(this.instance);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// System.Action action
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Paction;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RPaction
		{
			get
			{
				if(r_Paction == null)
				{
					r_Paction = new(this, "action", -1);
					r_Paction.SetBelong(this.instance);
				}
				return r_Paction;
			}
		}

		/// <summary>
		/// Boolean needRefresh
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PneedRefresh;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPneedRefresh
		{
			get
			{
				if(r_PneedRefresh == null)
				{
					r_PneedRefresh = new(this, "needRefresh", -1);
					r_PneedRefresh.SetBelong(this.instance);
				}
				return r_PneedRefresh;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pvisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
					r_Pvisible.SetBelong(this.instance);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
					r_Penabled.SetBelong(this.instance);
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Boolean insertSeparatorBefore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PinsertSeparatorBefore;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPinsertSeparatorBefore
		{
			get
			{
				if(r_PinsertSeparatorBefore == null)
				{
					r_PinsertSeparatorBefore = new(this, "insertSeparatorBefore", -1);
					r_PinsertSeparatorBefore.SetBelong(this.instance);
				}
				return r_PinsertSeparatorBefore;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status] statusCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus> r_PstatusCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus> RPstatusCallback
		{
			get
			{
				if(r_PstatusCallback == null)
				{
					r_PstatusCallback = new(this, "statusCallback", -1);
					r_PstatusCallback.SetBelong(this.instance);
				}
				return r_PstatusCallback;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.instance);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ppriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpriority
		{
			get
			{
				if(r_Ppriority == null)
				{
					r_Ppriority = new(this, "priority", -1);
					r_Ppriority.SetBelong(this.instance);
				}
				return r_Ppriority;
			}
		}

		/// <summary>
		/// Boolean isChecked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisChecked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisChecked
		{
			get
			{
				if(r_PisChecked == null)
				{
					r_PisChecked = new(this, "isChecked", -1);
					r_PisChecked.SetBelong(this.instance);
				}
				return r_PisChecked;
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


        public RMenuDropdownItem() : base("UnityEditor.PackageManager.UI.Internal.MenuDropdownItem")
        {
        }

        public RMenuDropdownItem(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.MenuDropdownItem")
		{
            SetInstance(instance);
		}

        public RMenuDropdownItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMenuDropdownItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
