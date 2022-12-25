using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DropdownMenuAction
	/// </summary>
    public partial class RDropdownMenuAction : RMember //
    {

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected RField r___1__name__2__k__BackingField;
		public virtual RField R__1__name__2__k__BackingField
		{
			get
			{
				if(r___1__name__2__k__BackingField == null)
				{
					r___1__name__2__k__BackingField = new(this, "<name>k__BackingField");
					r___1__name__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__name__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuAction+Status <status>k__BackingField
		/// </summary>
		protected RField r___1__status__2__k__BackingField;
		public virtual RField R__1__status__2__k__BackingField
		{
			get
			{
				if(r___1__status__2__k__BackingField == null)
				{
					r___1__status__2__k__BackingField = new(this, "<status>k__BackingField");
					r___1__status__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__status__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo <eventInfo>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RDropdownMenuEventInfo r___1__eventInfo__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RDropdownMenuEventInfo R__1__eventInfo__2__k__BackingField
		{
			get
			{
				if(r___1__eventInfo__2__k__BackingField == null)
				{
					r___1__eventInfo__2__k__BackingField = new(this, "<eventInfo>k__BackingField");
					r___1__eventInfo__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__eventInfo__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Object <userData>k__BackingField
		/// </summary>
		protected RSystem.RObject r___1__userData__2__k__BackingField;
		public virtual RSystem.RObject R__1__userData__2__k__BackingField
		{
			get
			{
				if(r___1__userData__2__k__BackingField == null)
				{
					r___1__userData__2__k__BackingField = new(this, "<userData>k__BackingField");
					r___1__userData__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__userData__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.DropdownMenuAction] actionCallback
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RDropdownMenuAction> r_actionCallback;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RDropdownMenuAction> RactionCallback
		{
			get
			{
				if(r_actionCallback == null)
				{
					r_actionCallback = new(this, "actionCallback");
					r_actionCallback.SetBelong(this.instance);
				}
				return r_actionCallback;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status] actionStatusCallback
		/// </summary>
		protected RSystem.RFunc<RUnityEngine.RUIElements.RDropdownMenuAction, RField> r_actionStatusCallback;
		public virtual RSystem.RFunc<RUnityEngine.RUIElements.RDropdownMenuAction, RField> RactionStatusCallback
		{
			get
			{
				if(r_actionStatusCallback == null)
				{
					r_actionStatusCallback = new(this, "actionStatusCallback");
					r_actionStatusCallback.SetBelong(this.instance);
				}
				return r_actionStatusCallback;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Status status
		/// </summary>
		protected RProperty r_status;
		public virtual RProperty Rstatus
		{
			get
			{
				if(r_status == null)
				{
					r_status = new(this, "status", -1);
					r_status.SetBelong(this.instance);
				}
				return r_status;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo eventInfo
		/// </summary>
		protected RUnityEngine.RUIElements.RDropdownMenuEventInfo r_eventInfo;
		public virtual RUnityEngine.RUIElements.RDropdownMenuEventInfo ReventInfo
		{
			get
			{
				if(r_eventInfo == null)
				{
					r_eventInfo = new(this, "eventInfo", -1);
					r_eventInfo.SetBelong(this.instance);
				}
				return r_eventInfo;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData", -1);
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
			}
		}

		/// <summary>
		/// Status AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected static RMethod r_RAlwaysEnabled_DropdownMenuAction;
		public static RMethod RAlwaysEnabled_DropdownMenuAction
		{
			get
			{
				if(r_RAlwaysEnabled_DropdownMenuAction == null)
				{
					r_RAlwaysEnabled_DropdownMenuAction = new(typeof(UnityEngine.UIElements.DropdownMenuAction), "AlwaysEnabled", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_RAlwaysEnabled_DropdownMenuAction.SetBelong(null);
				}
				return r_RAlwaysEnabled_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Status AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected static RMethod r_RAlwaysDisabled_DropdownMenuAction;
		public static RMethod RAlwaysDisabled_DropdownMenuAction
		{
			get
			{
				if(r_RAlwaysDisabled_DropdownMenuAction == null)
				{
					r_RAlwaysDisabled_DropdownMenuAction = new(typeof(UnityEngine.UIElements.DropdownMenuAction), "AlwaysDisabled", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_RAlwaysDisabled_DropdownMenuAction.SetBelong(null);
				}
				return r_RAlwaysDisabled_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo)
		/// </summary>
		protected RMethod r_RUpdateActionStatus_DropdownMenuEventInfo;
		public virtual RMethod RUpdateActionStatus_DropdownMenuEventInfo
		{
			get
			{
				if(r_RUpdateActionStatus_DropdownMenuEventInfo == null)
				{
					r_RUpdateActionStatus_DropdownMenuEventInfo = new(this, "UpdateActionStatus", 0, typeof(UnityEngine.UIElements.DropdownMenuEventInfo));
					r_RUpdateActionStatus_DropdownMenuEventInfo.SetBelong(this.instance);
				}
				return r_RUpdateActionStatus_DropdownMenuEventInfo;
			}
		}

		/// <summary>
		/// Void Execute()
		/// </summary>
		protected RMethod r_RExecute;
		public virtual RMethod RExecute
		{
			get
			{
				if(r_RExecute == null)
				{
					r_RExecute = new(this, "Execute", 0);
					r_RExecute.SetBelong(this.instance);
				}
				return r_RExecute;
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


        public RDropdownMenuAction() : base("UnityEngine.UIElements.DropdownMenuAction")
        {
        }

        public RDropdownMenuAction(System.Object instance) : base("UnityEngine.UIElements.DropdownMenuAction")
		{
            SetInstance(instance);
		}

        public RDropdownMenuAction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDropdownMenuAction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RAlwaysEnabled_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RAlwaysDisabled_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo  @eventInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventInfo};
            var ___result = RUpdateActionStatus_DropdownMenuEventInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Execute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExecute.Invoke(___genericsType, ___parameters);

            
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
