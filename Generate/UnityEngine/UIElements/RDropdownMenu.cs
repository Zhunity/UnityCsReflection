using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DropdownMenu
	/// </summary>
    public partial class RDropdownMenu : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.DropdownMenuItem] m_MenuItems
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RDropdownMenuItem> r_m_MenuItems;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RDropdownMenuItem> Rm_MenuItems
		{
			get
			{
				if(r_m_MenuItems == null)
				{
					r_m_MenuItems = new(this, "m_MenuItems");
					r_m_MenuItems.SetBelong(this.instance);
				}
				return r_m_MenuItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DropdownMenuEventInfo m_DropdownMenuEventInfo
		/// </summary>
		protected RUnityEngine.RUIElements.RDropdownMenuEventInfo r_m_DropdownMenuEventInfo;
		public virtual RUnityEngine.RUIElements.RDropdownMenuEventInfo Rm_DropdownMenuEventInfo
		{
			get
			{
				if(r_m_DropdownMenuEventInfo == null)
				{
					r_m_DropdownMenuEventInfo = new(this, "m_DropdownMenuEventInfo");
					r_m_DropdownMenuEventInfo.SetBelong(this.instance);
				}
				return r_m_DropdownMenuEventInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.DropdownMenuItem] MenuItems()
		/// </summary>
		protected RMethod r_MenuItems;
		public virtual RMethod RMenuItems
		{
			get
			{
				if(r_MenuItems == null)
				{
					r_MenuItems = new(this, "MenuItems", 0);
					r_MenuItems.SetBelong(this.instance);
				}
				return r_MenuItems;
			}
		}

		/// <summary>
		/// Void AppendAction(System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status], System.Object)
		/// </summary>
		protected RMethod r_AppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
		public virtual RMethod RAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object
		{
			get
			{
				if(r_AppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object == null)
				{
					r_AppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object = new(this, "AppendAction", 0, typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)), typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status")), typeof(System.Object));
					r_AppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object.SetBelong(this.instance);
				}
				return r_AppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
			}
		}

		/// <summary>
		/// Void AppendAction(System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], Status)
		/// </summary>
		protected RMethod r_AppendAction_String_Action_d_DropdownMenuAction_p__Status;
		public virtual RMethod RAppendAction_String_Action_d_DropdownMenuAction_p__Status
		{
			get
			{
				if(r_AppendAction_String_Action_d_DropdownMenuAction_p__Status == null)
				{
					r_AppendAction_String_Action_d_DropdownMenuAction_p__Status = new(this, "AppendAction", 0, typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status"));
					r_AppendAction_String_Action_d_DropdownMenuAction_p__Status.SetBelong(this.instance);
				}
				return r_AppendAction_String_Action_d_DropdownMenuAction_p__Status;
			}
		}

		/// <summary>
		/// Void InsertAction(Int32, System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], System.Func`2[UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction+Status], System.Object)
		/// </summary>
		protected RMethod r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
		public virtual RMethod RInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object
		{
			get
			{
				if(r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object == null)
				{
					r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object = new(this, "InsertAction", 0, typeof(System.Int32), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)), typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status")), typeof(System.Object));
					r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object.SetBelong(this.instance);
				}
				return r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object;
			}
		}

		/// <summary>
		/// Void InsertAction(Int32, System.String, System.Action`1[UnityEngine.UIElements.DropdownMenuAction], Status)
		/// </summary>
		protected RMethod r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status;
		public virtual RMethod RInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status
		{
			get
			{
				if(r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status == null)
				{
					r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status = new(this, "InsertAction", 0, typeof(System.Int32), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.DropdownMenuAction)),  ReflectionUtils.GetType("UnityEngine.UIElements.DropdownMenuAction+Status"));
					r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status.SetBelong(this.instance);
				}
				return r_InsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status;
			}
		}

		/// <summary>
		/// Void AppendSeparator(System.String)
		/// </summary>
		protected RMethod r_AppendSeparator_String;
		public virtual RMethod RAppendSeparator_String
		{
			get
			{
				if(r_AppendSeparator_String == null)
				{
					r_AppendSeparator_String = new(this, "AppendSeparator", 0, typeof(System.String));
					r_AppendSeparator_String.SetBelong(this.instance);
				}
				return r_AppendSeparator_String;
			}
		}

		/// <summary>
		/// Void InsertSeparator(System.String, Int32)
		/// </summary>
		protected RMethod r_InsertSeparator_String_Int32;
		public virtual RMethod RInsertSeparator_String_Int32
		{
			get
			{
				if(r_InsertSeparator_String_Int32 == null)
				{
					r_InsertSeparator_String_Int32 = new(this, "InsertSeparator", 0, typeof(System.String), typeof(System.Int32));
					r_InsertSeparator_String_Int32.SetBelong(this.instance);
				}
				return r_InsertSeparator_String_Int32;
			}
		}

		/// <summary>
		/// Void RemoveItemAt(Int32)
		/// </summary>
		protected RMethod r_RemoveItemAt_Int32;
		public virtual RMethod RRemoveItemAt_Int32
		{
			get
			{
				if(r_RemoveItemAt_Int32 == null)
				{
					r_RemoveItemAt_Int32 = new(this, "RemoveItemAt", 0, typeof(System.Int32));
					r_RemoveItemAt_Int32.SetBelong(this.instance);
				}
				return r_RemoveItemAt_Int32;
			}
		}

		/// <summary>
		/// Void ClearItems()
		/// </summary>
		protected RMethod r_ClearItems;
		public virtual RMethod RClearItems
		{
			get
			{
				if(r_ClearItems == null)
				{
					r_ClearItems = new(this, "ClearItems", 0);
					r_ClearItems.SetBelong(this.instance);
				}
				return r_ClearItems;
			}
		}

		/// <summary>
		/// Void PrepareForDisplay(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_PrepareForDisplay_EventBase;
		public virtual RMethod RPrepareForDisplay_EventBase
		{
			get
			{
				if(r_PrepareForDisplay_EventBase == null)
				{
					r_PrepareForDisplay_EventBase = new(this, "PrepareForDisplay", 0, typeof(UnityEngine.UIElements.EventBase));
					r_PrepareForDisplay_EventBase.SetBelong(this.instance);
				}
				return r_PrepareForDisplay_EventBase;
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
            var ___result = RMenuItems.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem>)___result;
        }


        public virtual void AppendAction(System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, RSystem.RFunc<RUnityEngine.RUIElements.RDropdownMenuAction, RType> @actionStatusCallback, System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@actionName, @action, @actionStatusCallback.Value, @userData};
            var ___result = RAppendAction_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendAction(System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, RType @status)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@actionName, @action, @status.Value};
            var ___result = RAppendAction_String_Action_d_DropdownMenuAction_p__Status.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAction(System.Int32 @atIndex, System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, RSystem.RFunc<RUnityEngine.RUIElements.RDropdownMenuAction, RType> @actionStatusCallback, System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@atIndex, @actionName, @action, @actionStatusCallback.Value, @userData};
            var ___result = RInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Func_d_DropdownMenuAction_Status_p__Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAction(System.Int32 @atIndex, System.String @actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> @action, RType @status)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@atIndex, @actionName, @action, @status.Value};
            var ___result = RInsertAction_Int32_String_Action_d_DropdownMenuAction_p__Status.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendSeparator(System.String @subMenuPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subMenuPath};
            var ___result = RAppendSeparator_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertSeparator(System.String @subMenuPath, System.Int32 @atIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subMenuPath, @atIndex};
            var ___result = RInsertSeparator_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveItemAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveItemAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearItems.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareForDisplay(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RPrepareForDisplay_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
