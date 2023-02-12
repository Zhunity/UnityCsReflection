
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class RPopupList
{
	
	/// <summary>
	/// UnityEditor.PopupList+ListElement
	/// </summary>
    public partial class RListElement : RMember //
    {

		/// <summary>
		/// UnityEngine.GUIContent m_Content
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RGUIContent r_Fm_Content;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RGUIContent RFm_Content
		{
			get
			{
				if(r_Fm_Content == null)
				{
					r_Fm_Content = new(this, "m_Content");
					r_Fm_Content.SetBelong(this.instance);
				}
				return r_Fm_Content;
			}
		}

		/// <summary>
		/// System.Single m_FilterScore
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fm_FilterScore;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFm_FilterScore
		{
			get
			{
				if(r_Fm_FilterScore == null)
				{
					r_Fm_FilterScore = new(this, "m_FilterScore");
					r_Fm_FilterScore.SetBelong(this.instance);
				}
				return r_Fm_FilterScore;
			}
		}

		/// <summary>
		/// System.Boolean m_Selected
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Selected;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Selected
		{
			get
			{
				if(r_Fm_Selected == null)
				{
					r_Fm_Selected = new(this, "m_Selected");
					r_Fm_Selected.SetBelong(this.instance);
				}
				return r_Fm_Selected;
			}
		}

		/// <summary>
		/// System.Boolean m_WasSelected
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_WasSelected;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_WasSelected
		{
			get
			{
				if(r_Fm_WasSelected == null)
				{
					r_Fm_WasSelected = new(this, "m_WasSelected");
					r_Fm_WasSelected.SetBelong(this.instance);
				}
				return r_Fm_WasSelected;
			}
		}

		/// <summary>
		/// System.Boolean m_PartiallySelected
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_PartiallySelected;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_PartiallySelected
		{
			get
			{
				if(r_Fm_PartiallySelected == null)
				{
					r_Fm_PartiallySelected = new(this, "m_PartiallySelected");
					r_Fm_PartiallySelected.SetBelong(this.instance);
				}
				return r_Fm_PartiallySelected;
			}
		}

		/// <summary>
		/// System.Boolean m_Enabled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Enabled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Enabled
		{
			get
			{
				if(r_Fm_Enabled == null)
				{
					r_Fm_Enabled = new(this, "m_Enabled");
					r_Fm_Enabled.SetBelong(this.instance);
				}
				return r_Fm_Enabled;
			}
		}

		/// <summary>
		/// System.String[] m_Types
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RString> r_Fm_Types;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RString> RFm_Types
		{
			get
			{
				if(r_Fm_Types == null)
				{
					r_Fm_Types = new(this, "m_Types");
					r_Fm_Types.SetBelong(this.instance);
				}
				return r_Fm_Types;
			}
		}

		/// <summary>
		/// Single filterScore
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PfilterScore;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPfilterScore
		{
			get
			{
				if(r_PfilterScore == null)
				{
					r_PfilterScore = new(this, "filterScore", -1);
					r_PfilterScore.SetBelong(this.instance);
				}
				return r_PfilterScore;
			}
		}

		/// <summary>
		/// Boolean selected
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pselected;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPselected
		{
			get
			{
				if(r_Pselected == null)
				{
					r_Pselected = new(this, "selected", -1);
					r_Pselected.SetBelong(this.instance);
				}
				return r_Pselected;
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
		/// Boolean partiallySelected
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PpartiallySelected;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPpartiallySelected
		{
			get
			{
				if(r_PpartiallySelected == null)
				{
					r_PpartiallySelected = new(this, "partiallySelected", -1);
					r_PpartiallySelected.SetBelong(this.instance);
				}
				return r_PpartiallySelected;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.instance);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] types
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RString> r_Ptypes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RString> RPtypes
		{
			get
			{
				if(r_Ptypes == null)
				{
					r_Ptypes = new(this, "types", -1);
					r_Ptypes.SetBelong(this.instance);
				}
				return r_Ptypes;
			}
		}

		/// <summary>
		/// Void ResetScore()
		/// </summary>
		protected RMethod r_MResetScore;
		public virtual RMethod RMResetScore
		{
			get
			{
				if(r_MResetScore == null)
				{
					r_MResetScore = new(this, "ResetScore", 0);
					r_MResetScore.SetBelong(this.instance);
				}
				return r_MResetScore;
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


        public RListElement() : base("UnityEditor.PopupList+ListElement")
        {
        }

        public RListElement(System.Object instance) : base("UnityEditor.PopupList+ListElement")
		{
            SetInstance(instance);
		}

        public RListElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RListElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResetScore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetScore.Invoke(___genericsType, ___parameters);

            
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