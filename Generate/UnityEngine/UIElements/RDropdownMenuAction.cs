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
		protected RField r___0__name__1__k__BackingField;
		public virtual RField R__0__name__1__k__BackingField
		{
			get
			{
				if(r___0__name__1__k__BackingField == null)
				{
					r___0__name__1__k__BackingField = new(this, "<name>k__BackingField");
					r___0__name__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuAction+Status <status>k__BackingField
		/// </summary>
		protected RField r___0__status__1__k__BackingField;
		public virtual RField R__0__status__1__k__BackingField
		{
			get
			{
				if(r___0__status__1__k__BackingField == null)
				{
					r___0__status__1__k__BackingField = new(this, "<status>k__BackingField");
					r___0__status__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__status__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo <eventInfo>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RDropdownMenuEventInfo r___0__eventInfo__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RDropdownMenuEventInfo R__0__eventInfo__1__k__BackingField
		{
			get
			{
				if(r___0__eventInfo__1__k__BackingField == null)
				{
					r___0__eventInfo__1__k__BackingField = new(this, "<eventInfo>k__BackingField");
					r___0__eventInfo__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__eventInfo__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Object <userData>k__BackingField
		/// </summary>
		protected RSystem.RObject r___0__userData__1__k__BackingField;
		public virtual RSystem.RObject R__0__userData__1__k__BackingField
		{
			get
			{
				if(r___0__userData__1__k__BackingField == null)
				{
					r___0__userData__1__k__BackingField = new(this, "<userData>k__BackingField");
					r___0__userData__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__userData__1__k__BackingField;
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
		protected static RMethod r_AlwaysEnabled_DropdownMenuAction;
		public static RMethod RAlwaysEnabled_DropdownMenuAction
		{
			get
			{
				if(r_AlwaysEnabled_DropdownMenuAction == null)
				{
					r_AlwaysEnabled_DropdownMenuAction = new(typeof(UnityEngine.UIElements.DropdownMenuAction), "AlwaysEnabled", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_AlwaysEnabled_DropdownMenuAction.SetBelong(null);
				}
				return r_AlwaysEnabled_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Status AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected static RMethod r_AlwaysDisabled_DropdownMenuAction;
		public static RMethod RAlwaysDisabled_DropdownMenuAction
		{
			get
			{
				if(r_AlwaysDisabled_DropdownMenuAction == null)
				{
					r_AlwaysDisabled_DropdownMenuAction = new(typeof(UnityEngine.UIElements.DropdownMenuAction), "AlwaysDisabled", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_AlwaysDisabled_DropdownMenuAction.SetBelong(null);
				}
				return r_AlwaysDisabled_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo)
		/// </summary>
		protected RMethod r_UpdateActionStatus_DropdownMenuEventInfo;
		public virtual RMethod RUpdateActionStatus_DropdownMenuEventInfo
		{
			get
			{
				if(r_UpdateActionStatus_DropdownMenuEventInfo == null)
				{
					r_UpdateActionStatus_DropdownMenuEventInfo = new(this, "UpdateActionStatus", 0, typeof(UnityEngine.UIElements.DropdownMenuEventInfo));
					r_UpdateActionStatus_DropdownMenuEventInfo.SetBelong(this.instance);
				}
				return r_UpdateActionStatus_DropdownMenuEventInfo;
			}
		}

		/// <summary>
		/// Void Execute()
		/// </summary>
		protected RMethod r_Execute;
		public virtual RMethod RExecute
		{
			get
			{
				if(r_Execute == null)
				{
					r_Execute = new(this, "Execute", 0);
					r_Execute.SetBelong(this.instance);
				}
				return r_Execute;
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
