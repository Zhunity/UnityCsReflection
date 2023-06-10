
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource
	/// </summary>
    public partial class RAdvancedDropdownDataSource : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource");
            }
        }

        public RAdvancedDropdownDataSource() : base("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource")
        {
        }

        public RAdvancedDropdownDataSource(System.Object instance) : base("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource")
		{
            SetInstance(instance);
		}

        public RAdvancedDropdownDataSource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAdvancedDropdownDataSource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String kSearchHeader
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FkSearchHeader;
		public static Hvak.Editor.Refleaction.RSystem.RString RFkSearchHeader
		{
			get
			{
				if(r_FkSearchHeader == null)
				{
					r_FkSearchHeader = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource"), "kSearchHeader");
				}
				return r_FkSearchHeader;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem m_MainTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_Fm_MainTree;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RFm_MainTree
		{
			get
			{
				if(r_Fm_MainTree == null)
				{
					r_Fm_MainTree = new(this, "m_MainTree");
				}
				return r_Fm_MainTree;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem m_SearchTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_Fm_SearchTree;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RFm_SearchTree
		{
			get
			{
				if(r_Fm_SearchTree == null)
				{
					r_Fm_SearchTree = new(this, "m_SearchTree");
				}
				return r_Fm_SearchTree;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_SelectedIDs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_SelectedIDs;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_SelectedIDs
		{
			get
			{
				if(r_Fm_SelectedIDs == null)
				{
					r_Fm_SelectedIDs = new(this, "m_SelectedIDs");
				}
				return r_Fm_SelectedIDs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] m_SearchableElements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_Fm_SearchableElements;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RFm_SearchableElements
		{
			get
			{
				if(r_Fm_SearchableElements == null)
				{
					r_Fm_SearchableElements = new(this, "m_SearchableElements");
				}
				return r_Fm_SearchableElements;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource+SearchMatchItemHandler searchMatchItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource.RSearchMatchItemHandler r_FsearchMatchItem;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource.RSearchMatchItemHandler RFsearchMatchItem
		{
			get
			{
				if(r_FsearchMatchItem == null)
				{
					r_FsearchMatchItem = new(this, "searchMatchItem");
				}
				return r_FsearchMatchItem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IComparer`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] searchMatchItemComparer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIComparer<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_FsearchMatchItemComparer;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIComparer<Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RFsearchMatchItemComparer
		{
			get
			{
				if(r_FsearchMatchItemComparer == null)
				{
					r_FsearchMatchItemComparer = new(this, "searchMatchItemComparer");
				}
				return r_FsearchMatchItemComparer;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem mainTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_PmainTree;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RPmainTree
		{
			get
			{
				if(r_PmainTree == null)
				{
					r_PmainTree = new(this, "mainTree", -1);
				}
				return r_PmainTree;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem searchTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_PsearchTree;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RPsearchTree
		{
			get
			{
				if(r_PsearchTree == null)
				{
					r_PsearchTree = new(this, "searchTree", -1);
				}
				return r_PsearchTree;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] selectedIDs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> r_PselectedIDs;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> RPselectedIDs
		{
			get
			{
				if(r_PselectedIDs == null)
				{
					r_PselectedIDs = new(this, "selectedIDs", -1);
				}
				return r_PselectedIDs;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem root
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_Proot;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RProot
		{
			get
			{
				if(r_Proot == null)
				{
					r_Proot = new(this, "root", -1);
				}
				return r_Proot;
			}
		}

		/// <summary>
		/// Void ReloadData()
		/// </summary>
		protected RMethod r_MReloadData;
		public virtual RMethod RMReloadData
		{
			get
			{
				if(r_MReloadData == null)
				{
					r_MReloadData = new(this, "ReloadData", 0);
				}
				return r_MReloadData;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem FetchData()
		/// </summary>
		protected RMethod r_MFetchData;
		public virtual RMethod RMFetchData
		{
			get
			{
				if(r_MFetchData == null)
				{
					r_MFetchData = new(this, "FetchData", 0);
				}
				return r_MFetchData;
			}
		}

		/// <summary>
		/// Void RebuildSearch(System.String)
		/// </summary>
		protected RMethod r_MRebuildSearch_String;
		public virtual RMethod RMRebuildSearch_String
		{
			get
			{
				if(r_MRebuildSearch_String == null)
				{
					r_MRebuildSearch_String = new(this, "RebuildSearch", 0, typeof(System.String));
				}
				return r_MRebuildSearch_String;
			}
		}

		/// <summary>
		/// Boolean AddMatchItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, System.String, System.String[], System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem], System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem])
		/// </summary>
		protected RMethod r_MAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_;
		public virtual RMethod RMAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_
		{
			get
			{
				if(r_MAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_ == null)
				{
					r_MAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_ = new(this, "AddMatchItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)));
				}
				return r_MAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem Search(System.String)
		/// </summary>
		protected RMethod r_MSearch_String;
		public virtual RMethod RMSearch_String
		{
			get
			{
				if(r_MSearch_String == null)
				{
					r_MSearch_String = new(this, "Search", 0, typeof(System.String));
				}
				return r_MSearch_String;
			}
		}

		/// <summary>
		/// Void BuildSearchableElements()
		/// </summary>
		protected RMethod r_MBuildSearchableElements;
		public virtual RMethod RMBuildSearchableElements
		{
			get
			{
				if(r_MBuildSearchableElements == null)
				{
					r_MBuildSearchableElements = new(this, "BuildSearchableElements", 0);
				}
				return r_MBuildSearchableElements;
			}
		}

		/// <summary>
		/// Void BuildSearchableElements(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MBuildSearchableElements_AdvancedDropdownItem;
		public virtual RMethod RMBuildSearchableElements_AdvancedDropdownItem
		{
			get
			{
				if(r_MBuildSearchableElements_AdvancedDropdownItem == null)
				{
					r_MBuildSearchableElements_AdvancedDropdownItem = new(this, "BuildSearchableElements", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
				}
				return r_MBuildSearchableElements_AdvancedDropdownItem;
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


        public virtual void ReloadData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReloadData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem FetchData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFetchData.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual void RebuildSearch(System.String @search)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@search};
            var ___result = RMRebuildSearch_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddMatchItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @e, System.String @name, System.String[] @searchWords, System.Collections.Generic.List<UnityEditor.IMGUI.Controls.AdvancedDropdownItem> @matchesStart, System.Collections.Generic.List<UnityEditor.IMGUI.Controls.AdvancedDropdownItem> @matchesWithin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @name, @searchWords, @matchesStart, @matchesWithin};
            var ___result = RMAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem Search(System.String @searchString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchString};
            var ___result = RMSearch_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual void BuildSearchableElements()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBuildSearchableElements.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildSearchableElements(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMBuildSearchableElements_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
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
