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
		protected RUnityEngine.RGUIContent r_m_Content;
		public virtual RUnityEngine.RGUIContent Rm_Content
		{
			get
			{
				if(r_m_Content == null)
				{
					r_m_Content = new(this, "m_Content");
					r_m_Content.SetBelong(this.instance);
				}
				return r_m_Content;
			}
		}

		/// <summary>
		/// System.Single m_FilterScore
		/// </summary>
		protected RField r_m_FilterScore;
		public virtual RField Rm_FilterScore
		{
			get
			{
				if(r_m_FilterScore == null)
				{
					r_m_FilterScore = new(this, "m_FilterScore");
					r_m_FilterScore.SetBelong(this.instance);
				}
				return r_m_FilterScore;
			}
		}

		/// <summary>
		/// System.Boolean m_Selected
		/// </summary>
		protected RField r_m_Selected;
		public virtual RField Rm_Selected
		{
			get
			{
				if(r_m_Selected == null)
				{
					r_m_Selected = new(this, "m_Selected");
					r_m_Selected.SetBelong(this.instance);
				}
				return r_m_Selected;
			}
		}

		/// <summary>
		/// System.Boolean m_WasSelected
		/// </summary>
		protected RField r_m_WasSelected;
		public virtual RField Rm_WasSelected
		{
			get
			{
				if(r_m_WasSelected == null)
				{
					r_m_WasSelected = new(this, "m_WasSelected");
					r_m_WasSelected.SetBelong(this.instance);
				}
				return r_m_WasSelected;
			}
		}

		/// <summary>
		/// System.Boolean m_PartiallySelected
		/// </summary>
		protected RField r_m_PartiallySelected;
		public virtual RField Rm_PartiallySelected
		{
			get
			{
				if(r_m_PartiallySelected == null)
				{
					r_m_PartiallySelected = new(this, "m_PartiallySelected");
					r_m_PartiallySelected.SetBelong(this.instance);
				}
				return r_m_PartiallySelected;
			}
		}

		/// <summary>
		/// System.Boolean m_Enabled
		/// </summary>
		protected RField r_m_Enabled;
		public virtual RField Rm_Enabled
		{
			get
			{
				if(r_m_Enabled == null)
				{
					r_m_Enabled = new(this, "m_Enabled");
					r_m_Enabled.SetBelong(this.instance);
				}
				return r_m_Enabled;
			}
		}

		/// <summary>
		/// System.String[] m_Types
		/// </summary>
		protected RFieldArray<RField> r_m_Types;
		public virtual RFieldArray<RField> Rm_Types
		{
			get
			{
				if(r_m_Types == null)
				{
					r_m_Types = new(this, "m_Types");
					r_m_Types.SetBelong(this.instance);
				}
				return r_m_Types;
			}
		}

		/// <summary>
		/// Single filterScore
		/// </summary>
		protected RProperty r_filterScore;
		public virtual RProperty RfilterScore
		{
			get
			{
				if(r_filterScore == null)
				{
					r_filterScore = new(this, "filterScore", -1);
					r_filterScore.SetBelong(this.instance);
				}
				return r_filterScore;
			}
		}

		/// <summary>
		/// Boolean selected
		/// </summary>
		protected RProperty r_selected;
		public virtual RProperty Rselected
		{
			get
			{
				if(r_selected == null)
				{
					r_selected = new(this, "selected", -1);
					r_selected.SetBelong(this.instance);
				}
				return r_selected;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// Boolean partiallySelected
		/// </summary>
		protected RProperty r_partiallySelected;
		public virtual RProperty RpartiallySelected
		{
			get
			{
				if(r_partiallySelected == null)
				{
					r_partiallySelected = new(this, "partiallySelected", -1);
					r_partiallySelected.SetBelong(this.instance);
				}
				return r_partiallySelected;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RProperty r_text;
		public virtual RProperty Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text", -1);
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] types
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RProperty> r_types;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RProperty> Rtypes
		{
			get
			{
				if(r_types == null)
				{
					r_types = new(this, "types", -1);
					r_types.SetBelong(this.instance);
				}
				return r_types;
			}
		}

		/// <summary>
		/// Void ResetScore()
		/// </summary>
		protected RMethod r_ResetScore;
		public virtual RMethod RResetScore
		{
			get
			{
				if(r_ResetScore == null)
				{
					r_ResetScore = new(this, "ResetScore", 0);
					r_ResetScore.SetBelong(this.instance);
				}
				return r_ResetScore;
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
            var ___result = RResetScore.Invoke(___genericsType, ___parameters);

            
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