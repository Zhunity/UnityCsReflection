using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownState
	/// </summary>
    public partial class RAdvancedDropdownState : RMember //
    {

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState+AdvancedDropdownItemState[] states
		/// </summary>
		protected RFieldArray<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState> r_states;
		public virtual RFieldArray<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState> Rstates
		{
			get
			{
				if(r_states == null)
				{
					r_states = new(this, "states");
					r_states.SetBelong(this.instance);
				}
				return r_states;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState+AdvancedDropdownItemState m_LastSelectedState
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState r_m_LastSelectedState;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState Rm_LastSelectedState
		{
			get
			{
				if(r_m_LastSelectedState == null)
				{
					r_m_LastSelectedState = new(this, "m_LastSelectedState");
					r_m_LastSelectedState.SetBelong(this.instance);
				}
				return r_m_LastSelectedState;
			}
		}

		/// <summary>
		/// AdvancedDropdownItemState GetStateForItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RGetStateForItem_AdvancedDropdownItem;
		public virtual RMethod RGetStateForItem_AdvancedDropdownItem
		{
			get
			{
				if(r_RGetStateForItem_AdvancedDropdownItem == null)
				{
					r_RGetStateForItem_AdvancedDropdownItem = new(this, "GetStateForItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RGetStateForItem_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RGetStateForItem_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void MoveDownSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RMoveDownSelection_AdvancedDropdownItem;
		public virtual RMethod RMoveDownSelection_AdvancedDropdownItem
		{
			get
			{
				if(r_RMoveDownSelection_AdvancedDropdownItem == null)
				{
					r_RMoveDownSelection_AdvancedDropdownItem = new(this, "MoveDownSelection", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RMoveDownSelection_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RMoveDownSelection_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void MoveUpSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RMoveUpSelection_AdvancedDropdownItem;
		public virtual RMethod RMoveUpSelection_AdvancedDropdownItem
		{
			get
			{
				if(r_RMoveUpSelection_AdvancedDropdownItem == null)
				{
					r_RMoveUpSelection_AdvancedDropdownItem = new(this, "MoveUpSelection", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RMoveUpSelection_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RMoveUpSelection_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void SetSelectionOnItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, Int32)
		/// </summary>
		protected RMethod r_RSetSelectionOnItem_AdvancedDropdownItem_Int32;
		public virtual RMethod RSetSelectionOnItem_AdvancedDropdownItem_Int32
		{
			get
			{
				if(r_RSetSelectionOnItem_AdvancedDropdownItem_Int32 == null)
				{
					r_RSetSelectionOnItem_AdvancedDropdownItem_Int32 = new(this, "SetSelectionOnItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.Int32));
					r_RSetSelectionOnItem_AdvancedDropdownItem_Int32.SetBelong(this.instance);
				}
				return r_RSetSelectionOnItem_AdvancedDropdownItem_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RGetSelectedIndex_AdvancedDropdownItem;
		public virtual RMethod RGetSelectedIndex_AdvancedDropdownItem
		{
			get
			{
				if(r_RGetSelectedIndex_AdvancedDropdownItem == null)
				{
					r_RGetSelectedIndex_AdvancedDropdownItem = new(this, "GetSelectedIndex", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RGetSelectedIndex_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RGetSelectedIndex_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void SetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, Int32)
		/// </summary>
		protected RMethod r_RSetSelectedIndex_AdvancedDropdownItem_Int32;
		public virtual RMethod RSetSelectedIndex_AdvancedDropdownItem_Int32
		{
			get
			{
				if(r_RSetSelectedIndex_AdvancedDropdownItem_Int32 == null)
				{
					r_RSetSelectedIndex_AdvancedDropdownItem_Int32 = new(this, "SetSelectedIndex", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.Int32));
					r_RSetSelectedIndex_AdvancedDropdownItem_Int32.SetBelong(this.instance);
				}
				return r_RSetSelectedIndex_AdvancedDropdownItem_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RGetSelectedChild_AdvancedDropdownItem;
		public virtual RMethod RGetSelectedChild_AdvancedDropdownItem
		{
			get
			{
				if(r_RGetSelectedChild_AdvancedDropdownItem == null)
				{
					r_RGetSelectedChild_AdvancedDropdownItem = new(this, "GetSelectedChild", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RGetSelectedChild_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RGetSelectedChild_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RGetScrollState_AdvancedDropdownItem;
		public virtual RMethod RGetScrollState_AdvancedDropdownItem
		{
			get
			{
				if(r_RGetScrollState_AdvancedDropdownItem == null)
				{
					r_RGetScrollState_AdvancedDropdownItem = new(this, "GetScrollState", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RGetScrollState_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RGetScrollState_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void SetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetScrollState_AdvancedDropdownItem_Vector2;
		public virtual RMethod RSetScrollState_AdvancedDropdownItem_Vector2
		{
			get
			{
				if(r_RSetScrollState_AdvancedDropdownItem_Vector2 == null)
				{
					r_RSetScrollState_AdvancedDropdownItem_Vector2 = new(this, "SetScrollState", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(UnityEngine.Vector2));
					r_RSetScrollState_AdvancedDropdownItem_Vector2.SetBelong(this.instance);
				}
				return r_RSetScrollState_AdvancedDropdownItem_Vector2;
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


        public RAdvancedDropdownState() : base("UnityEditor.IMGUI.Controls.AdvancedDropdownState")
        {
        }

        public RAdvancedDropdownState(System.Object instance) : base("UnityEditor.IMGUI.Controls.AdvancedDropdownState")
		{
            SetInstance(instance);
		}

        public RAdvancedDropdownState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAdvancedDropdownState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetStateForItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RGetStateForItem_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void MoveDownSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMoveDownSelection_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveUpSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMoveUpSelection_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectionOnItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item, System.Int32  @selectedIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @selectedIndex};
            var ___result = RSetSelectionOnItem_AdvancedDropdownItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RGetSelectedIndex_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RSetSelectedIndex_AdvancedDropdownItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RGetSelectedChild_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual UnityEngine.Vector2 GetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RGetScrollState_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item, UnityEngine.Vector2  @scrollState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @scrollState};
            var ___result = RSetScrollState_AdvancedDropdownItem_Vector2.Invoke(___genericsType, ___parameters);

            
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
