using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource
	/// </summary>
    public partial class RAdvancedDropdownDataSource : RMember //
    {

		/// <summary>
		/// System.String kSearchHeader
		/// </summary>
		protected static RField r_kSearchHeader;
		public static RField RkSearchHeader
		{
			get
			{
				if(r_kSearchHeader == null)
				{
					r_kSearchHeader = new( ReleactionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource"), "kSearchHeader");
					r_kSearchHeader.SetBelong(null);
				}
				return r_kSearchHeader;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem m_MainTree
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_m_MainTree;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem Rm_MainTree
		{
			get
			{
				if(r_m_MainTree == null)
				{
					r_m_MainTree = new(this, "m_MainTree");
					r_m_MainTree.SetBelong(this.instance);
				}
				return r_m_MainTree;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem m_SearchTree
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_m_SearchTree;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem Rm_SearchTree
		{
			get
			{
				if(r_m_SearchTree == null)
				{
					r_m_SearchTree = new(this, "m_SearchTree");
					r_m_SearchTree.SetBelong(this.instance);
				}
				return r_m_SearchTree;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_SelectedIDs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_SelectedIDs;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_SelectedIDs
		{
			get
			{
				if(r_m_SelectedIDs == null)
				{
					r_m_SelectedIDs = new(this, "m_SelectedIDs");
					r_m_SelectedIDs.SetBelong(this.instance);
				}
				return r_m_SelectedIDs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] m_SearchableElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_m_SearchableElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> Rm_SearchableElements
		{
			get
			{
				if(r_m_SearchableElements == null)
				{
					r_m_SearchableElements = new(this, "m_SearchableElements");
					r_m_SearchableElements.SetBelong(this.instance);
				}
				return r_m_SearchableElements;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource+SearchMatchItemHandler searchMatchItem
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource.RSearchMatchItemHandler r_searchMatchItem;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource.RSearchMatchItemHandler RsearchMatchItem
		{
			get
			{
				if(r_searchMatchItem == null)
				{
					r_searchMatchItem = new(this, "searchMatchItem");
					r_searchMatchItem.SetBelong(this.instance);
				}
				return r_searchMatchItem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IComparer`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] searchMatchItemComparer
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIComparer<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_searchMatchItemComparer;
		public virtual RSystem.RCollections.RGeneric.RIComparer<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RsearchMatchItemComparer
		{
			get
			{
				if(r_searchMatchItemComparer == null)
				{
					r_searchMatchItemComparer = new(this, "searchMatchItemComparer");
					r_searchMatchItemComparer.SetBelong(this.instance);
				}
				return r_searchMatchItemComparer;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem mainTree
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_mainTree;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RmainTree
		{
			get
			{
				if(r_mainTree == null)
				{
					r_mainTree = new(this, "mainTree", -1);
					r_mainTree.SetBelong(this.instance);
				}
				return r_mainTree;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem searchTree
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_searchTree;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem RsearchTree
		{
			get
			{
				if(r_searchTree == null)
				{
					r_searchTree = new(this, "searchTree", -1);
					r_searchTree.SetBelong(this.instance);
				}
				return r_searchTree;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] selectedIDs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_selectedIDs;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RselectedIDs
		{
			get
			{
				if(r_selectedIDs == null)
				{
					r_selectedIDs = new(this, "selectedIDs", -1);
					r_selectedIDs.SetBelong(this.instance);
				}
				return r_selectedIDs;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem root
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem r_root;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem Rroot
		{
			get
			{
				if(r_root == null)
				{
					r_root = new(this, "root", -1);
					r_root.SetBelong(this.instance);
				}
				return r_root;
			}
		}

		/// <summary>
		/// Void ReloadData()
		/// </summary>
		protected RMethod r_RReloadData;
		public virtual RMethod RReloadData
		{
			get
			{
				if(r_RReloadData == null)
				{
					r_RReloadData = new(this, "ReloadData", 0);
					r_RReloadData.SetBelong(this.instance);
				}
				return r_RReloadData;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem FetchData()
		/// </summary>
		protected RMethod r_RFetchData;
		public virtual RMethod RFetchData
		{
			get
			{
				if(r_RFetchData == null)
				{
					r_RFetchData = new(this, "FetchData", 0);
					r_RFetchData.SetBelong(this.instance);
				}
				return r_RFetchData;
			}
		}

		/// <summary>
		/// Void RebuildSearch(System.String)
		/// </summary>
		protected RMethod r_RRebuildSearch_String;
		public virtual RMethod RRebuildSearch_String
		{
			get
			{
				if(r_RRebuildSearch_String == null)
				{
					r_RRebuildSearch_String = new(this, "RebuildSearch", 0, typeof(System.String));
					r_RRebuildSearch_String.SetBelong(this.instance);
				}
				return r_RRebuildSearch_String;
			}
		}

		/// <summary>
		/// Boolean AddMatchItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, System.String, System.String[], System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem], System.Collections.Generic.List`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem])
		/// </summary>
		protected RMethod r_RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_;
		public virtual RMethod RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_
		{
			get
			{
				if(r_RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_ == null)
				{
					r_RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_ = new(this, "AddMatchItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)));
					r_RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_.SetBelong(this.instance);
				}
				return r_RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownItem Search(System.String)
		/// </summary>
		protected RMethod r_RSearch_String;
		public virtual RMethod RSearch_String
		{
			get
			{
				if(r_RSearch_String == null)
				{
					r_RSearch_String = new(this, "Search", 0, typeof(System.String));
					r_RSearch_String.SetBelong(this.instance);
				}
				return r_RSearch_String;
			}
		}

		/// <summary>
		/// Void BuildSearchableElements()
		/// </summary>
		protected RMethod r_RBuildSearchableElements;
		public virtual RMethod RBuildSearchableElements
		{
			get
			{
				if(r_RBuildSearchableElements == null)
				{
					r_RBuildSearchableElements = new(this, "BuildSearchableElements", 0);
					r_RBuildSearchableElements.SetBelong(this.instance);
				}
				return r_RBuildSearchableElements;
			}
		}

		/// <summary>
		/// Void BuildSearchableElements(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RBuildSearchableElements_AdvancedDropdownItem;
		public virtual RMethod RBuildSearchableElements_AdvancedDropdownItem
		{
			get
			{
				if(r_RBuildSearchableElements_AdvancedDropdownItem == null)
				{
					r_RBuildSearchableElements_AdvancedDropdownItem = new(this, "BuildSearchableElements", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RBuildSearchableElements_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RBuildSearchableElements_AdvancedDropdownItem;
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

        public virtual void ReloadData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReloadData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem FetchData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFetchData.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual void RebuildSearch(System.String  @search)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@search};
            var ___result = RRebuildSearch_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddMatchItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @e, System.String  @name, System.String[]  @searchWords, System.Collections.Generic.List<UnityEditor.IMGUI.Controls.AdvancedDropdownItem>  @matchesStart, System.Collections.Generic.List<UnityEditor.IMGUI.Controls.AdvancedDropdownItem>  @matchesWithin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @name, @searchWords, @matchesStart, @matchesWithin};
            var ___result = RAddMatchItem_AdvancedDropdownItem_String_StringArray_List_d_AdvancedDropdownItem_p__List_d_AdvancedDropdownItem_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.IMGUI.Controls.AdvancedDropdownItem Search(System.String  @searchString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchString};
            var ___result = RSearch_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.IMGUI.Controls.AdvancedDropdownItem)___result;
        }


        public virtual void BuildSearchableElements()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBuildSearchableElements.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildSearchableElements(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RBuildSearchableElements_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
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