
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DropdownMenu
	/// </summary>
    public partial class RDropdownMenu : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.DropdownMenuItem] m_MenuItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuItem> r_Fm_MenuItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuItem> RFm_MenuItems
		{
			get
			{
				if(r_Fm_MenuItems == null)
				{
					r_Fm_MenuItems = new(this, "m_MenuItems");
				}
				return r_Fm_MenuItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo m_DropdownMenuEventInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuEventInfo r_Fm_DropdownMenuEventInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuEventInfo RFm_DropdownMenuEventInfo
		{
			get
			{
				if(r_Fm_DropdownMenuEventInfo == null)
				{
					r_Fm_DropdownMenuEventInfo = new(this, "m_DropdownMenuEventInfo");
				}
				return r_Fm_DropdownMenuEventInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.DropdownMenuItem] MenuItems()
		/// </summary>
		protected RMethod r_MMenuItems;
		public virtual RMethod RMMenuItems
		{
			get
			{
				if(r_MMenuItems == null)
				{
					r_MMenuItems = new(this, "MenuItems", 0);
				}
				return r_MMenuItems;
			}
		}

		/// <summary>
		/// Void AppendAction(System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status], System.Object)
		/// </summary>
		protected RMethod r_MAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
		public virtual RMethod RMAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object
		{
			get
			{
				if(r_MAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object == null)
				{
					r_MAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object = new(this, "AppendAction", 0, typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)), typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status")), typeof(System.Object));
				}
				return r_MAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
			}
		}

		/// <summary>
		/// Void AppendAction(System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], Status)
		/// </summary>
		protected RMethod r_MAppendAction_String_Action_d_DropdownMenuAction_p__Status;
		public virtual RMethod RMAppendAction_String_Action_d_DropdownMenuAction_p__Status
		{
			get
			{
				if(r_MAppendAction_String_Action_d_DropdownMenuAction_p__Status == null)
				{
					r_MAppendAction_String_Action_d_DropdownMenuAction_p__Status = new(this, "AppendAction", 0, typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status"));
				}
				return r_MAppendAction_String_Action_d_DropdownMenuAction_p__Status;
			}
		}

		/// <summary>
		/// Void InsertAction(Int32, System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status], System.Object)
		/// </summary>
		protected RMethod r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
		public virtual RMethod RMInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object
		{
			get
			{
				if(r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object == null)
				{
					r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object = new(this, "InsertAction", 0, typeof(System.Int32), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)), typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status")), typeof(System.Object));
				}
				return r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
			}
		}

		/// <summary>
		/// Void InsertAction(Int32, System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], Status)
		/// </summary>
		protected RMethod r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status;
		public virtual RMethod RMInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status
		{
			get
			{
				if(r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status == null)
				{
					r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status = new(this, "InsertAction", 0, typeof(System.Int32), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status"));
				}
				return r_MInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status;
			}
		}

		/// <summary>
		/// Void AppendSeparator(System.String)
		/// </summary>
		protected RMethod r_MAppendSeparator_String;
		public virtual RMethod RMAppendSeparator_String
		{
			get
			{
				if(r_MAppendSeparator_String == null)
				{
					r_MAppendSeparator_String = new(this, "AppendSeparator", 0, typeof(System.String));
				}
				return r_MAppendSeparator_String;
			}
		}

		/// <summary>
		/// Void InsertSeparator(System.String, Int32)
		/// </summary>
		protected RMethod r_MInsertSeparator_String_Int32;
		public virtual RMethod RMInsertSeparator_String_Int32
		{
			get
			{
				if(r_MInsertSeparator_String_Int32 == null)
				{
					r_MInsertSeparator_String_Int32 = new(this, "InsertSeparator", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MInsertSeparator_String_Int32;
			}
		}

		/// <summary>
		/// Void RemoveItemAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveItemAt_Int32;
		public virtual RMethod RMRemoveItemAt_Int32
		{
			get
			{
				if(r_MRemoveItemAt_Int32 == null)
				{
					r_MRemoveItemAt_Int32 = new(this, "RemoveItemAt", 0, typeof(System.Int32));
				}
				return r_MRemoveItemAt_Int32;
			}
		}

		/// <summary>
		/// Void ClearItems()
		/// </summary>
		protected RMethod r_MClearItems;
		public virtual RMethod RMClearItems
		{
			get
			{
				if(r_MClearItems == null)
				{
					r_MClearItems = new(this, "ClearItems", 0);
				}
				return r_MClearItems;
			}
		}

		/// <summary>
		/// Void PrepareForDisplay(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MPrepareForDisplay_EventBase;
		public virtual RMethod RMPrepareForDisplay_EventBase
		{
			get
			{
				if(r_MPrepareForDisplay_EventBase == null)
				{
					r_MPrepareForDisplay_EventBase = new(this, "PrepareForDisplay", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MPrepareForDisplay_EventBase;
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


        public RDropdownMenu() : base("UnityEngine.UIElements.DropdownMenu")
        {
        }

        public RDropdownMenu(System.Object instance) : base("UnityEngine.UIElements.DropdownMenu")
		{
            SetInstance(instance);
		}

        public RDropdownMenu(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDropdownMenu(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMenuItems.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem>)___result;
        }


        public virtual void AppendAction(System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus> @actionStatusCallback, System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@actionName, @action, @actionStatusCallback.Value, @userData};
            var ___result = RMAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendAction(System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus @status)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@actionName, @action, @status.Value};
            var ___result = RMAppendAction_String_Action_d_DropdownMenuAction_p__Status.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAction(System.Int32 @atIndex, System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus> @actionStatusCallback, System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@atIndex, @actionName, @action, @actionStatusCallback.Value, @userData};
            var ___result = RMInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAction(System.Int32 @atIndex, System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus @status)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@atIndex, @actionName, @action, @status.Value};
            var ___result = RMInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendSeparator(System.String @subMenuPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subMenuPath};
            var ___result = RMAppendSeparator_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertSeparator(System.String @subMenuPath, System.Int32 @atIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subMenuPath, @atIndex};
            var ___result = RMInsertSeparator_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveItemAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveItemAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearItems.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareForDisplay(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMPrepareForDisplay_EventBase.Invoke(___genericsType, ___parameters);

            
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
