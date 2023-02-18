
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem
	/// </summary>
    public partial class RAdvancedDropdownItem : RMember //
    {

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.GetValue());
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
					r_Fm_Id.SetBelong(this.GetValue());
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// System.Int32 m_ElementIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ElementIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ElementIndex
		{
			get
			{
				if(r_Fm_ElementIndex == null)
				{
					r_Fm_ElementIndex = new(this, "m_ElementIndex");
					r_Fm_ElementIndex.SetBelong(this.GetValue());
				}
				return r_Fm_ElementIndex;
			}
		}

		/// <summary>
		/// System.Boolean m_Enabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Enabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Enabled
		{
			get
			{
				if(r_Fm_Enabled == null)
				{
					r_Fm_Enabled = new(this, "m_Enabled");
					r_Fm_Enabled.SetBelong(this.GetValue());
				}
				return r_Fm_Enabled;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_Content
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fm_Content;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFm_Content
		{
			get
			{
				if(r_Fm_Content == null)
				{
					r_Fm_Content = new(this, "m_Content");
					r_Fm_Content.SetBelong(this.GetValue());
				}
				return r_Fm_Content;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] m_Children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_Fm_Children;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RFm_Children
		{
			get
			{
				if(r_Fm_Children == null)
				{
					r_Fm_Children = new(this, "m_Children");
					r_Fm_Children.SetBelong(this.GetValue());
				}
				return r_Fm_Children;
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
					r_F__0__userData__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__userData__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem k_SeparatorItem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_Fk_SeparatorItem;
		public static Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RFk_SeparatorItem
		{
			get
			{
				if(r_Fk_SeparatorItem == null)
				{
					r_Fk_SeparatorItem = new(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "k_SeparatorItem");
					r_Fk_SeparatorItem.SetBelong(null);
				}
				return r_Fk_SeparatorItem;
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
					r_Pname.SetBelong(this.GetValue());
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Pcontent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RPcontent
		{
			get
			{
				if(r_Pcontent == null)
				{
					r_Pcontent = new(this, "content", -1);
					r_Pcontent.SetBelong(this.GetValue());
				}
				return r_Pcontent;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.GetValue());
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.GetValue());
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Picon;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPicon
		{
			get
			{
				if(r_Picon == null)
				{
					r_Picon = new(this, "icon", -1);
					r_Picon.SetBelong(this.GetValue());
				}
				return r_Picon;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.GetValue());
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Int32 elementIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PelementIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPelementIndex
		{
			get
			{
				if(r_PelementIndex == null)
				{
					r_PelementIndex = new(this, "elementIndex", -1);
					r_PelementIndex.SetBelong(this.GetValue());
				}
				return r_PelementIndex;
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
					r_Penabled.SetBelong(this.GetValue());
				}
				return r_Penabled;
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
					r_PuserData.SetBelong(this.GetValue());
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_Pchildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RPchildren
		{
			get
			{
				if(r_Pchildren == null)
				{
					r_Pchildren = new(this, "children", -1);
					r_Pchildren.SetBelong(this.GetValue());
				}
				return r_Pchildren;
			}
		}

		/// <summary>
		/// Boolean hasChildren
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasChildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasChildren
		{
			get
			{
				if(r_PhasChildren == null)
				{
					r_PhasChildren = new(this, "hasChildren", -1);
					r_PhasChildren.SetBelong(this.GetValue());
				}
				return r_PhasChildren;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MAddChild_AdvancedDropdownItem;
		public virtual RMethod RMAddChild_AdvancedDropdownItem
		{
			get
			{
				if(r_MAddChild_AdvancedDropdownItem == null)
				{
					r_MAddChild_AdvancedDropdownItem = new(this, "AddChild", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_MAddChild_AdvancedDropdownItem.SetBelong(this.GetValue());
				}
				return r_MAddChild_AdvancedDropdownItem;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.GetValue());
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Void AddSeparator()
		/// </summary>
		protected RMethod r_MAddSeparator;
		public virtual RMethod RMAddSeparator
		{
			get
			{
				if(r_MAddSeparator == null)
				{
					r_MAddSeparator = new(this, "AddSeparator", 0);
					r_MAddSeparator.SetBelong(this.GetValue());
				}
				return r_MAddSeparator;
			}
		}

		/// <summary>
		/// Boolean IsSeparator()
		/// </summary>
		protected RMethod r_MIsSeparator;
		public virtual RMethod RMIsSeparator
		{
			get
			{
				if(r_MIsSeparator == null)
				{
					r_MIsSeparator = new(this, "IsSeparator", 0);
					r_MIsSeparator.SetBelong(this.GetValue());
				}
				return r_MIsSeparator;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Void SortChildren(System.Comparison`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem], Boolean)
		/// </summary>
		protected RMethod r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean;
		public virtual RMethod RMSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean
		{
			get
			{
				if(r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean == null)
				{
					r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean = new(this, "SortChildren", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)), typeof(System.Boolean));
					r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RAdvancedDropdownItem() : base("UnityEditor.IMGUI.Controls.AdvancedDropdownItem")
        {
        }

        public RAdvancedDropdownItem(System.Object instance) : base("UnityEditor.IMGUI.Controls.AdvancedDropdownItem")
		{
            SetInstance(instance);
		}

        public RAdvancedDropdownItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAdvancedDropdownItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAddChild_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddSeparator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsSeparator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SortChildren(System.Comparison<UnityEditor.IMGUI.Controls.AdvancedDropdownItem> @comparer, System.Boolean @recursive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer, @recursive};
            var ___result = RMSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.Invoke(___genericsType, ___parameters);

            
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


    }
}
