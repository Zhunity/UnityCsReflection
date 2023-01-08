using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class RPopupList
{
	
	/// <summary>
	/// UnityEditor.PopupList+InputData
	/// </summary>
    public partial class RInputData : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PopupList+ListElement] m_ListElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RPopupList.RListElement> r_m_ListElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RPopupList.RListElement> Rm_ListElements
		{
			get
			{
				if(r_m_ListElements == null)
				{
					r_m_ListElements = new(this, "m_ListElements");
					r_m_ListElements.SetBelong(this.instance);
				}
				return r_m_ListElements;
			}
		}

		/// <summary>
		/// System.Boolean m_CloseOnSelection
		/// </summary>
		protected RField r_m_CloseOnSelection;
		public virtual RField Rm_CloseOnSelection
		{
			get
			{
				if(r_m_CloseOnSelection == null)
				{
					r_m_CloseOnSelection = new(this, "m_CloseOnSelection");
					r_m_CloseOnSelection.SetBelong(this.instance);
				}
				return r_m_CloseOnSelection;
			}
		}

		/// <summary>
		/// System.Boolean m_AllowCustom
		/// </summary>
		protected RField r_m_AllowCustom;
		public virtual RField Rm_AllowCustom
		{
			get
			{
				if(r_m_AllowCustom == null)
				{
					r_m_AllowCustom = new(this, "m_AllowCustom");
					r_m_AllowCustom.SetBelong(this.instance);
				}
				return r_m_AllowCustom;
			}
		}

		/// <summary>
		/// System.Boolean m_EnableAutoCompletion
		/// </summary>
		protected RField r_m_EnableAutoCompletion;
		public virtual RField Rm_EnableAutoCompletion
		{
			get
			{
				if(r_m_EnableAutoCompletion == null)
				{
					r_m_EnableAutoCompletion = new(this, "m_EnableAutoCompletion");
					r_m_EnableAutoCompletion.SetBelong(this.instance);
				}
				return r_m_EnableAutoCompletion;
			}
		}

		/// <summary>
		/// System.Boolean m_SortAlphabetically
		/// </summary>
		protected RField r_m_SortAlphabetically;
		public virtual RField Rm_SortAlphabetically
		{
			get
			{
				if(r_m_SortAlphabetically == null)
				{
					r_m_SortAlphabetically = new(this, "m_SortAlphabetically");
					r_m_SortAlphabetically.SetBelong(this.instance);
				}
				return r_m_SortAlphabetically;
			}
		}

		/// <summary>
		/// UnityEditor.PopupList+OnSelectCallback m_OnSelectCallback
		/// </summary>
		protected RUnityEditor.RPopupList.ROnSelectCallback r_m_OnSelectCallback;
		public virtual RUnityEditor.RPopupList.ROnSelectCallback Rm_OnSelectCallback
		{
			get
			{
				if(r_m_OnSelectCallback == null)
				{
					r_m_OnSelectCallback = new(this, "m_OnSelectCallback");
					r_m_OnSelectCallback.SetBelong(this.instance);
				}
				return r_m_OnSelectCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxCount
		/// </summary>
		protected RField r_m_MaxCount;
		public virtual RField Rm_MaxCount
		{
			get
			{
				if(r_m_MaxCount == null)
				{
					r_m_MaxCount = new(this, "m_MaxCount");
					r_m_MaxCount.SetBelong(this.instance);
				}
				return r_m_MaxCount;
			}
		}

		/// <summary>
		/// Void DeselectAll()
		/// </summary>
		protected RMethod r_DeselectAll;
		public virtual RMethod RDeselectAll
		{
			get
			{
				if(r_DeselectAll == null)
				{
					r_DeselectAll = new(this, "DeselectAll", 0);
					r_DeselectAll.SetBelong(this.instance);
				}
				return r_DeselectAll;
			}
		}

		/// <summary>
		/// Void ResetScores()
		/// </summary>
		protected RMethod r_ResetScores;
		public virtual RMethod RResetScores
		{
			get
			{
				if(r_ResetScores == null)
				{
					r_ResetScores = new(this, "ResetScores", 0);
					r_ResetScores.SetBelong(this.instance);
				}
				return r_ResetScores;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PopupList+ListElement] BuildQuery(System.String)
		/// </summary>
		protected RMethod r_BuildQuery_String;
		public virtual RMethod RBuildQuery_String
		{
			get
			{
				if(r_BuildQuery_String == null)
				{
					r_BuildQuery_String = new(this, "BuildQuery", 0, typeof(System.String));
					r_BuildQuery_String.SetBelong(this.instance);
				}
				return r_BuildQuery_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PopupList+ListElement] GetFilteredList(System.String)
		/// </summary>
		protected RMethod r_GetFilteredList_String;
		public virtual RMethod RGetFilteredList_String
		{
			get
			{
				if(r_GetFilteredList_String == null)
				{
					r_GetFilteredList_String = new(this, "GetFilteredList", 0, typeof(System.String));
					r_GetFilteredList_String.SetBelong(this.instance);
				}
				return r_GetFilteredList_String;
			}
		}

		/// <summary>
		/// Int32 GetFilteredCount(System.String)
		/// </summary>
		protected RMethod r_GetFilteredCount_String;
		public virtual RMethod RGetFilteredCount_String
		{
			get
			{
				if(r_GetFilteredCount_String == null)
				{
					r_GetFilteredCount_String = new(this, "GetFilteredCount", 0, typeof(System.String));
					r_GetFilteredCount_String.SetBelong(this.instance);
				}
				return r_GetFilteredCount_String;
			}
		}

		/// <summary>
		/// Void AddElement(System.String, System.String[])
		/// </summary>
		protected RMethod r_AddElement_String_StringArray;
		public virtual RMethod RAddElement_String_StringArray
		{
			get
			{
				if(r_AddElement_String_StringArray == null)
				{
					r_AddElement_String_StringArray = new(this, "AddElement", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_AddElement_String_StringArray.SetBelong(this.instance);
				}
				return r_AddElement_String_StringArray;
			}
		}

		/// <summary>
		/// ListElement NewOrMatchingElement(System.String)
		/// </summary>
		protected RMethod r_NewOrMatchingElement_String;
		public virtual RMethod RNewOrMatchingElement_String
		{
			get
			{
				if(r_NewOrMatchingElement_String == null)
				{
					r_NewOrMatchingElement_String = new(this, "NewOrMatchingElement", 0, typeof(System.String));
					r_NewOrMatchingElement_String.SetBelong(this.instance);
				}
				return r_NewOrMatchingElement_String;
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


        public RInputData() : base("UnityEditor.PopupList+InputData")
        {
        }

        public RInputData(System.Object instance) : base("UnityEditor.PopupList+InputData")
		{
            SetInstance(instance);
		}

        public RInputData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInputData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void DeselectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeselectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetScores()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetScores.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RPopupList.RListElement> BuildQuery(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RBuildQuery_String.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RPopupList.RListElement>(___result);
        }


        public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RPopupList.RListElement> GetFilteredList(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RGetFilteredList_String.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RPopupList.RListElement>(___result);
        }


        public virtual System.Int32 GetFilteredCount(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RGetFilteredCount_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddElement(System.String @label, System.String[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label, @types};
            var ___result = RAddElement_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEditor.RPopupList.RListElement NewOrMatchingElement(System.String @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label};
            var ___result = RNewOrMatchingElement_String.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.RPopupList.RListElement(___result);
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
}