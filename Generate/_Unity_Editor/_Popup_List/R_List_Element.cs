
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{public partial class RPopupList
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PopupList+ListElement
	/// </summary>
    public partial class RListElement : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PopupList+ListElement");
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
				}
				return r_Fm_Content;
			}
		}

		/// <summary>
		/// System.Single m_FilterScore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_FilterScore;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_FilterScore
		{
			get
			{
				if(r_Fm_FilterScore == null)
				{
					r_Fm_FilterScore = new(this, "m_FilterScore");
				}
				return r_Fm_FilterScore;
			}
		}

		/// <summary>
		/// System.Boolean m_Selected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Selected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Selected
		{
			get
			{
				if(r_Fm_Selected == null)
				{
					r_Fm_Selected = new(this, "m_Selected");
				}
				return r_Fm_Selected;
			}
		}

		/// <summary>
		/// System.Boolean m_WasSelected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_WasSelected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_WasSelected
		{
			get
			{
				if(r_Fm_WasSelected == null)
				{
					r_Fm_WasSelected = new(this, "m_WasSelected");
				}
				return r_Fm_WasSelected;
			}
		}

		/// <summary>
		/// System.Boolean m_PartiallySelected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_PartiallySelected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_PartiallySelected
		{
			get
			{
				if(r_Fm_PartiallySelected == null)
				{
					r_Fm_PartiallySelected = new(this, "m_PartiallySelected");
				}
				return r_Fm_PartiallySelected;
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
				}
				return r_Fm_Enabled;
			}
		}

		/// <summary>
		/// System.String[] m_Types
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Types;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_Types
		{
			get
			{
				if(r_Fm_Types == null)
				{
					r_Fm_Types = new(this, "m_Types");
				}
				return r_Fm_Types;
			}
		}

		/// <summary>
		/// Single filterScore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfilterScore;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfilterScore
		{
			get
			{
				if(r_PfilterScore == null)
				{
					r_PfilterScore = new(this, "filterScore", -1);
				}
				return r_PfilterScore;
			}
		}

		/// <summary>
		/// Boolean selected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pselected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPselected
		{
			get
			{
				if(r_Pselected == null)
				{
					r_Pselected = new(this, "selected", -1);
				}
				return r_Pselected;
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
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Boolean partiallySelected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PpartiallySelected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPpartiallySelected
		{
			get
			{
				if(r_PpartiallySelected == null)
				{
					r_PpartiallySelected = new(this, "partiallySelected", -1);
				}
				return r_PpartiallySelected;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] types
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> r_Ptypes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> RPtypes
		{
			get
			{
				if(r_Ptypes == null)
				{
					r_Ptypes = new(this, "types", -1);
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
}