
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RAddComponent
{
	/// <summary>
	/// UnityEditor.AddComponent.ComponentDropdownItem
	/// </summary>
    public partial class RComponentDropdownItem : RMember //
    {

		/// <summary>
		/// System.String m_MenuPath
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_MenuPath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_MenuPath
		{
			get
			{
				if(r_Fm_MenuPath == null)
				{
					r_Fm_MenuPath = new(this, "m_MenuPath");
					r_Fm_MenuPath.SetBelong(this.instance);
				}
				return r_Fm_MenuPath;
			}
		}

		/// <summary>
		/// System.Boolean m_IsLegacy
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_IsLegacy;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_IsLegacy
		{
			get
			{
				if(r_Fm_IsLegacy == null)
				{
					r_Fm_IsLegacy = new(this, "m_IsLegacy");
					r_Fm_IsLegacy.SetBelong(this.instance);
				}
				return r_Fm_IsLegacy;
			}
		}

		/// <summary>
		/// System.String m_LocalizedName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_LocalizedName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_LocalizedName
		{
			get
			{
				if(r_Fm_LocalizedName == null)
				{
					r_Fm_LocalizedName = new(this, "m_LocalizedName");
					r_Fm_LocalizedName.SetBelong(this.instance);
				}
				return r_Fm_LocalizedName;
			}
		}

		/// <summary>
		/// System.String m_SearchableNameLocalized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_SearchableNameLocalized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_SearchableNameLocalized
		{
			get
			{
				if(r_Fm_SearchableNameLocalized == null)
				{
					r_Fm_SearchableNameLocalized = new(this, "m_SearchableNameLocalized");
					r_Fm_SearchableNameLocalized.SetBelong(this.instance);
				}
				return r_Fm_SearchableNameLocalized;
			}
		}

		/// <summary>
		/// System.String m_SearchableName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_SearchableName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_SearchableName
		{
			get
			{
				if(r_Fm_SearchableName == null)
				{
					r_Fm_SearchableName = new(this, "m_SearchableName");
					r_Fm_SearchableName.SetBelong(this.instance);
				}
				return r_Fm_SearchableName;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String searchableName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PsearchableName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPsearchableName
		{
			get
			{
				if(r_PsearchableName == null)
				{
					r_PsearchableName = new(this, "searchableName", -1);
					r_PsearchableName.SetBelong(this.instance);
				}
				return r_PsearchableName;
			}
		}

		/// <summary>
		/// System.String searchableNameLocalized
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PsearchableNameLocalized;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPsearchableNameLocalized
		{
			get
			{
				if(r_PsearchableNameLocalized == null)
				{
					r_PsearchableNameLocalized = new(this, "searchableNameLocalized", -1);
					r_PsearchableNameLocalized.SetBelong(this.instance);
				}
				return r_PsearchableNameLocalized;
			}
		}

		/// <summary>
		/// System.String localizedName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PlocalizedName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPlocalizedName
		{
			get
			{
				if(r_PlocalizedName == null)
				{
					r_PlocalizedName = new(this, "localizedName", -1);
					r_PlocalizedName.SetBelong(this.instance);
				}
				return r_PlocalizedName;
			}
		}

		/// <summary>
		/// System.String menuPath
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PmenuPath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPmenuPath
		{
			get
			{
				if(r_PmenuPath == null)
				{
					r_PmenuPath = new(this, "menuPath", -1);
					r_PmenuPath.SetBelong(this.instance);
				}
				return r_PmenuPath;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RGUIContent r_Pcontent;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RGUIContent RPcontent
		{
			get
			{
				if(r_Pcontent == null)
				{
					r_Pcontent = new(this, "content", -1);
					r_Pcontent.SetBelong(this.instance);
				}
				return r_Pcontent;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D r_Picon;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D RPicon
		{
			get
			{
				if(r_Picon == null)
				{
					r_Picon = new(this, "icon", -1);
					r_Picon.SetBelong(this.instance);
				}
				return r_Picon;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.instance);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Int32 elementIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PelementIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPelementIndex
		{
			get
			{
				if(r_PelementIndex == null)
				{
					r_PelementIndex = new(this, "elementIndex", -1);
					r_PelementIndex.SetBelong(this.instance);
				}
				return r_PelementIndex;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPenabled
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
		/// System.Object userData
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PuserData;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPuserData
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
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] children
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_Pchildren;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RPchildren
		{
			get
			{
				if(r_Pchildren == null)
				{
					r_Pchildren = new(this, "children", -1);
					r_Pchildren.SetBelong(this.instance);
				}
				return r_Pchildren;
			}
		}

		/// <summary>
		/// Boolean hasChildren
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhasChildren;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhasChildren
		{
			get
			{
				if(r_PhasChildren == null)
				{
					r_PhasChildren = new(this, "hasChildren", -1);
					r_PhasChildren.SetBelong(this.instance);
				}
				return r_PhasChildren;
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
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
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

		/// <summary>
		/// Void set_displayName(System.String)
		/// </summary>
		protected RMethod r_Mset_displayName_String;
		public virtual RMethod RMset_displayName_String
		{
			get
			{
				if(r_Mset_displayName_String == null)
				{
					r_Mset_displayName_String = new(this, "set_displayName", 0, typeof(System.String));
					r_Mset_displayName_String.SetBelong(this.instance);
				}
				return r_Mset_displayName_String;
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
					r_MAddChild_AdvancedDropdownItem.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MAddSeparator.SetBelong(this.instance);
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
					r_MIsSeparator.SetBelong(this.instance);
				}
				return r_MIsSeparator;
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
					r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.SetBelong(this.instance);
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


        public RComponentDropdownItem() : base("UnityEditor.AddComponent.ComponentDropdownItem")
        {
        }

        public RComponentDropdownItem(System.Object instance) : base("UnityEditor.AddComponent.ComponentDropdownItem")
		{
            SetInstance(instance);
		}

        public RComponentDropdownItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RComponentDropdownItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 CompareTo(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void set_displayName(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_displayName_String.Invoke(___genericsType, ___parameters);

            
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