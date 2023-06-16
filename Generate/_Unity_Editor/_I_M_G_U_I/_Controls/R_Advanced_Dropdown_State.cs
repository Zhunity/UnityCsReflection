
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownState
	/// </summary>
    public partial class RAdvancedDropdownState : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownState);
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


		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState+AdvancedDropdownItemState[] states
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState> r_Fstates;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState> RFstates
		{
			get
			{
				if(r_Fstates == null)
				{
					r_Fstates = new(this, "states");
				}
				return r_Fstates;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState+AdvancedDropdownItemState m_LastSelectedState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState r_Fm_LastSelectedState;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState RFm_LastSelectedState
		{
			get
			{
				if(r_Fm_LastSelectedState == null)
				{
					r_Fm_LastSelectedState = new(this, "m_LastSelectedState");
				}
				return r_Fm_LastSelectedState;
			}
		}

		/// <summary>
		/// AdvancedDropdownItemState GetStateForItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MGetStateForItem_AdvancedDropdownItem;
		public virtual RMethod RMGetStateForItem_AdvancedDropdownItem
		{
			get
			{
				if(r_MGetStateForItem_AdvancedDropdownItem == null)
				{
					r_MGetStateForItem_AdvancedDropdownItem = new(this, "GetStateForItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MGetStateForItem_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void MoveDownSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MMoveDownSelection_AdvancedDropdownItem;
		public virtual RMethod RMMoveDownSelection_AdvancedDropdownItem
		{
			get
			{
				if(r_MMoveDownSelection_AdvancedDropdownItem == null)
				{
					r_MMoveDownSelection_AdvancedDropdownItem = new(this, "MoveDownSelection", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MMoveDownSelection_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void MoveUpSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MMoveUpSelection_AdvancedDropdownItem;
		public virtual RMethod RMMoveUpSelection_AdvancedDropdownItem
		{
			get
			{
				if(r_MMoveUpSelection_AdvancedDropdownItem == null)
				{
					r_MMoveUpSelection_AdvancedDropdownItem = new(this, "MoveUpSelection", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MMoveUpSelection_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void SetSelectionOnItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, Int32)
		/// </summary>
		protected RMethod r_MSetSelectionOnItem_AdvancedDropdownItem_Int32;
		public virtual RMethod RMSetSelectionOnItem_AdvancedDropdownItem_Int32
		{
			get
			{
				if(r_MSetSelectionOnItem_AdvancedDropdownItem_Int32 == null)
				{
					r_MSetSelectionOnItem_AdvancedDropdownItem_Int32 = new(this, "SetSelectionOnItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.Int32));
				}
				return r_MSetSelectionOnItem_AdvancedDropdownItem_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MGetSelectedIndex_AdvancedDropdownItem;
		public virtual RMethod RMGetSelectedIndex_AdvancedDropdownItem
		{
			get
			{
				if(r_MGetSelectedIndex_AdvancedDropdownItem == null)
				{
					r_MGetSelectedIndex_AdvancedDropdownItem = new(this, "GetSelectedIndex", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MGetSelectedIndex_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void SetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, Int32)
		/// </summary>
		protected RMethod r_MSetSelectedIndex_AdvancedDropdownItem_Int32;
		public virtual RMethod RMSetSelectedIndex_AdvancedDropdownItem_Int32
		{
			get
			{
				if(r_MSetSelectedIndex_AdvancedDropdownItem_Int32 == null)
				{
					r_MSetSelectedIndex_AdvancedDropdownItem_Int32 = new(this, "SetSelectedIndex", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.Int32));
				}
				return r_MSetSelectedIndex_AdvancedDropdownItem_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MGetSelectedChild_AdvancedDropdownItem;
		public virtual RMethod RMGetSelectedChild_AdvancedDropdownItem
		{
			get
			{
				if(r_MGetSelectedChild_AdvancedDropdownItem == null)
				{
					r_MGetSelectedChild_AdvancedDropdownItem = new(this, "GetSelectedChild", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MGetSelectedChild_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MGetScrollState_AdvancedDropdownItem;
		public virtual RMethod RMGetScrollState_AdvancedDropdownItem
		{
			get
			{
				if(r_MGetScrollState_AdvancedDropdownItem == null)
				{
					r_MGetScrollState_AdvancedDropdownItem = new(this, "GetScrollState", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MGetScrollState_AdvancedDropdownItem;
			}
		}

		/// <summary>
		/// Void SetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetScrollState_AdvancedDropdownItem_Vector2;
		public virtual RMethod RMSetScrollState_AdvancedDropdownItem_Vector2
		{
			get
			{
				if(r_MSetScrollState_AdvancedDropdownItem_Vector2 == null)
				{
					r_MSetScrollState_AdvancedDropdownItem_Vector2 = new(this, "SetScrollState", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(UnityEngine.Vector2));
				}
				return r_MSetScrollState_AdvancedDropdownItem_Vector2;
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


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState GetStateForItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMGetStateForItem_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState.RAdvancedDropdownItemState>(___result);
        }


        public virtual void MoveDownSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMMoveDownSelection_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveUpSelection(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMMoveUpSelection_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectionOnItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item, System.Int32 @selectedIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @selectedIndex};
            var ___result = RMSetSelectionOnItem_AdvancedDropdownItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMGetSelectedIndex_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void SetSelectedIndex(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @index};
            var ___result = RMSetSelectedIndex_AdvancedDropdownItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem GetSelectedChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMGetSelectedChild_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.IMGUI.Controls.AdvancedDropdownItem>(___result);
        }


        public virtual UnityEngine.Vector2 GetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMGetScrollState_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual void SetScrollState(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item, UnityEngine.Vector2 @scrollState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @scrollState};
            var ___result = RMSetScrollState_AdvancedDropdownItem_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
