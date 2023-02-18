
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DropdownMenuAction
	/// </summary>
    public partial class RDropdownMenuAction : RMember //
    {

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__name__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__name__1__k__BackingField
		{
			get
			{
				if(r_F__0__name__1__k__BackingField == null)
				{
					r_F__0__name__1__k__BackingField = new(this, "<name>k__BackingField");
				}
				return r_F__0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuAction+Status <status>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus r_F__0__status__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus RF__0__status__1__k__BackingField
		{
			get
			{
				if(r_F__0__status__1__k__BackingField == null)
				{
					r_F__0__status__1__k__BackingField = new(this, "<status>k__BackingField");
				}
				return r_F__0__status__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo <eventInfo>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuEventInfo r_F__0__eventInfo__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuEventInfo RF__0__eventInfo__1__k__BackingField
		{
			get
			{
				if(r_F__0__eventInfo__1__k__BackingField == null)
				{
					r_F__0__eventInfo__1__k__BackingField = new(this, "<eventInfo>k__BackingField");
				}
				return r_F__0__eventInfo__1__k__BackingField;
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
				}
				return r_F__0__userData__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.DropdownMenuAction] actionCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction> r_FactionCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction> RFactionCallback
		{
			get
			{
				if(r_FactionCallback == null)
				{
					r_FactionCallback = new(this, "actionCallback");
				}
				return r_FactionCallback;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status] actionStatusCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus> r_FactionStatusCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus> RFactionStatusCallback
		{
			get
			{
				if(r_FactionStatusCallback == null)
				{
					r_FactionStatusCallback = new(this, "actionStatusCallback");
				}
				return r_FactionStatusCallback;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Status status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus r_Pstatus;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus RPstatus
		{
			get
			{
				if(r_Pstatus == null)
				{
					r_Pstatus = new(this, "status", -1);
				}
				return r_Pstatus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo eventInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuEventInfo r_PeventInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuEventInfo RPeventInfo
		{
			get
			{
				if(r_PeventInfo == null)
				{
					r_PeventInfo = new(this, "eventInfo", -1);
				}
				return r_PeventInfo;
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
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// Status AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected static RMethod r_MAlwaysEnabled_DropdownMenuAction;
		public static RMethod RMAlwaysEnabled_DropdownMenuAction
		{
			get
			{
				if(r_MAlwaysEnabled_DropdownMenuAction == null)
				{
					r_MAlwaysEnabled_DropdownMenuAction = new(typeof(UnityEngine.UIElements.DropdownMenuAction), "AlwaysEnabled", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
				}
				return r_MAlwaysEnabled_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Status AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected static RMethod r_MAlwaysDisabled_DropdownMenuAction;
		public static RMethod RMAlwaysDisabled_DropdownMenuAction
		{
			get
			{
				if(r_MAlwaysDisabled_DropdownMenuAction == null)
				{
					r_MAlwaysDisabled_DropdownMenuAction = new(typeof(UnityEngine.UIElements.DropdownMenuAction), "AlwaysDisabled", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
				}
				return r_MAlwaysDisabled_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo)
		/// </summary>
		protected RMethod r_MUpdateActionStatus_DropdownMenuEventInfo;
		public virtual RMethod RMUpdateActionStatus_DropdownMenuEventInfo
		{
			get
			{
				if(r_MUpdateActionStatus_DropdownMenuEventInfo == null)
				{
					r_MUpdateActionStatus_DropdownMenuEventInfo = new(this, "UpdateActionStatus", 0, typeof(UnityEngine.UIElements.DropdownMenuEventInfo));
				}
				return r_MUpdateActionStatus_DropdownMenuEventInfo;
			}
		}

		/// <summary>
		/// Void Execute()
		/// </summary>
		protected RMethod r_MExecute;
		public virtual RMethod RMExecute
		{
			get
			{
				if(r_MExecute == null)
				{
					r_MExecute = new(this, "Execute", 0);
				}
				return r_MExecute;
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

        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMAlwaysEnabled_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMAlwaysDisabled_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
        }


        public virtual void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo @eventInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventInfo};
            var ___result = RMUpdateActionStatus_DropdownMenuEventInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Execute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExecute.Invoke(___genericsType, ___parameters);

            
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
