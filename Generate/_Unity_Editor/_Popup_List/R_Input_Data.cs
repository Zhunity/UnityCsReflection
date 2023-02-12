
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
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement> r_Fm_ListElements;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement> RFm_ListElements
		{
			get
			{
				if(r_Fm_ListElements == null)
				{
					r_Fm_ListElements = new(this, "m_ListElements");
					r_Fm_ListElements.SetBelong(this.instance);
				}
				return r_Fm_ListElements;
			}
		}

		/// <summary>
		/// System.Boolean m_CloseOnSelection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_CloseOnSelection;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_CloseOnSelection
		{
			get
			{
				if(r_Fm_CloseOnSelection == null)
				{
					r_Fm_CloseOnSelection = new(this, "m_CloseOnSelection");
					r_Fm_CloseOnSelection.SetBelong(this.instance);
				}
				return r_Fm_CloseOnSelection;
			}
		}

		/// <summary>
		/// System.Boolean m_AllowCustom
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_AllowCustom;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_AllowCustom
		{
			get
			{
				if(r_Fm_AllowCustom == null)
				{
					r_Fm_AllowCustom = new(this, "m_AllowCustom");
					r_Fm_AllowCustom.SetBelong(this.instance);
				}
				return r_Fm_AllowCustom;
			}
		}

		/// <summary>
		/// System.Boolean m_EnableAutoCompletion
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_EnableAutoCompletion;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_EnableAutoCompletion
		{
			get
			{
				if(r_Fm_EnableAutoCompletion == null)
				{
					r_Fm_EnableAutoCompletion = new(this, "m_EnableAutoCompletion");
					r_Fm_EnableAutoCompletion.SetBelong(this.instance);
				}
				return r_Fm_EnableAutoCompletion;
			}
		}

		/// <summary>
		/// System.Boolean m_SortAlphabetically
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_SortAlphabetically;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_SortAlphabetically
		{
			get
			{
				if(r_Fm_SortAlphabetically == null)
				{
					r_Fm_SortAlphabetically = new(this, "m_SortAlphabetically");
					r_Fm_SortAlphabetically.SetBelong(this.instance);
				}
				return r_Fm_SortAlphabetically;
			}
		}

		/// <summary>
		/// UnityEditor.PopupList+OnSelectCallback m_OnSelectCallback
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.ROnSelectCallback r_Fm_OnSelectCallback;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.ROnSelectCallback RFm_OnSelectCallback
		{
			get
			{
				if(r_Fm_OnSelectCallback == null)
				{
					r_Fm_OnSelectCallback = new(this, "m_OnSelectCallback");
					r_Fm_OnSelectCallback.SetBelong(this.instance);
				}
				return r_Fm_OnSelectCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_MaxCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_MaxCount
		{
			get
			{
				if(r_Fm_MaxCount == null)
				{
					r_Fm_MaxCount = new(this, "m_MaxCount");
					r_Fm_MaxCount.SetBelong(this.instance);
				}
				return r_Fm_MaxCount;
			}
		}

		/// <summary>
		/// Void DeselectAll()
		/// </summary>
		protected RMethod r_MDeselectAll;
		public virtual RMethod RMDeselectAll
		{
			get
			{
				if(r_MDeselectAll == null)
				{
					r_MDeselectAll = new(this, "DeselectAll", 0);
					r_MDeselectAll.SetBelong(this.instance);
				}
				return r_MDeselectAll;
			}
		}

		/// <summary>
		/// Void ResetScores()
		/// </summary>
		protected RMethod r_MResetScores;
		public virtual RMethod RMResetScores
		{
			get
			{
				if(r_MResetScores == null)
				{
					r_MResetScores = new(this, "ResetScores", 0);
					r_MResetScores.SetBelong(this.instance);
				}
				return r_MResetScores;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PopupList+ListElement] BuildQuery(System.String)
		/// </summary>
		protected RMethod r_MBuildQuery_String;
		public virtual RMethod RMBuildQuery_String
		{
			get
			{
				if(r_MBuildQuery_String == null)
				{
					r_MBuildQuery_String = new(this, "BuildQuery", 0, typeof(System.String));
					r_MBuildQuery_String.SetBelong(this.instance);
				}
				return r_MBuildQuery_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PopupList+ListElement] GetFilteredList(System.String)
		/// </summary>
		protected RMethod r_MGetFilteredList_String;
		public virtual RMethod RMGetFilteredList_String
		{
			get
			{
				if(r_MGetFilteredList_String == null)
				{
					r_MGetFilteredList_String = new(this, "GetFilteredList", 0, typeof(System.String));
					r_MGetFilteredList_String.SetBelong(this.instance);
				}
				return r_MGetFilteredList_String;
			}
		}

		/// <summary>
		/// Int32 GetFilteredCount(System.String)
		/// </summary>
		protected RMethod r_MGetFilteredCount_String;
		public virtual RMethod RMGetFilteredCount_String
		{
			get
			{
				if(r_MGetFilteredCount_String == null)
				{
					r_MGetFilteredCount_String = new(this, "GetFilteredCount", 0, typeof(System.String));
					r_MGetFilteredCount_String.SetBelong(this.instance);
				}
				return r_MGetFilteredCount_String;
			}
		}

		/// <summary>
		/// Void AddElement(System.String, System.String[])
		/// </summary>
		protected RMethod r_MAddElement_String_StringArray;
		public virtual RMethod RMAddElement_String_StringArray
		{
			get
			{
				if(r_MAddElement_String_StringArray == null)
				{
					r_MAddElement_String_StringArray = new(this, "AddElement", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_MAddElement_String_StringArray.SetBelong(this.instance);
				}
				return r_MAddElement_String_StringArray;
			}
		}

		/// <summary>
		/// ListElement NewOrMatchingElement(System.String)
		/// </summary>
		protected RMethod r_MNewOrMatchingElement_String;
		public virtual RMethod RMNewOrMatchingElement_String
		{
			get
			{
				if(r_MNewOrMatchingElement_String == null)
				{
					r_MNewOrMatchingElement_String = new(this, "NewOrMatchingElement", 0, typeof(System.String));
					r_MNewOrMatchingElement_String.SetBelong(this.instance);
				}
				return r_MNewOrMatchingElement_String;
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
            var ___result = RMDeselectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetScores()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetScores.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement> BuildQuery(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RMBuildQuery_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement> GetFilteredList(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RMGetFilteredList_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement>(___result);
        }


        public virtual System.Int32 GetFilteredCount(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RMGetFilteredCount_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddElement(System.String @label, System.String[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label, @types};
            var ___result = RMAddElement_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement NewOrMatchingElement(System.String @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label};
            var ___result = RMNewOrMatchingElement_String.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEditor.RPopupList.RListElement(___result);
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
}