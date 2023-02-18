
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StartDragArgs
	/// </summary>
    public partial class RStartDragArgs : RMember //
    {

		/// <summary>
		/// System.String <title>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__title__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__title__1__k__BackingField
		{
			get
			{
				if(r_F__0__title__1__k__BackingField == null)
				{
					r_F__0__title__1__k__BackingField = new(this, "<title>k__BackingField");
					r_F__0__title__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__title__1__k__BackingField;
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
		/// System.Collections.Hashtable m_GenericData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fm_GenericData;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFm_GenericData
		{
			get
			{
				if(r_Fm_GenericData == null)
				{
					r_Fm_GenericData = new(this, "m_GenericData");
					r_Fm_GenericData.SetBelong(this.GetValue());
				}
				return r_Fm_GenericData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.Object] <unityObjectReferences>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_F__0__unityObjectReferences__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RObject> RF__0__unityObjectReferences__1__k__BackingField
		{
			get
			{
				if(r_F__0__unityObjectReferences__1__k__BackingField == null)
				{
					r_F__0__unityObjectReferences__1__k__BackingField = new(this, "<unityObjectReferences>k__BackingField");
					r_F__0__unityObjectReferences__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__unityObjectReferences__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtitle
		{
			get
			{
				if(r_Ptitle == null)
				{
					r_Ptitle = new(this, "title", -1);
					r_Ptitle.SetBelong(this.GetValue());
				}
				return r_Ptitle;
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
		/// System.Collections.Hashtable genericData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_PgenericData;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RPgenericData
		{
			get
			{
				if(r_PgenericData == null)
				{
					r_PgenericData = new(this, "genericData", -1);
					r_PgenericData.SetBelong(this.GetValue());
				}
				return r_PgenericData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.Object] unityObjectReferences
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_PunityObjectReferences;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RObject> RPunityObjectReferences
		{
			get
			{
				if(r_PunityObjectReferences == null)
				{
					r_PunityObjectReferences = new(this, "unityObjectReferences", -1);
					r_PunityObjectReferences.SetBelong(this.GetValue());
				}
				return r_PunityObjectReferences;
			}
		}

		/// <summary>
		/// Void SetGenericData(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSetGenericData_String_Object;
		public virtual RMethod RMSetGenericData_String_Object
		{
			get
			{
				if(r_MSetGenericData_String_Object == null)
				{
					r_MSetGenericData_String_Object = new(this, "SetGenericData", 0, typeof(System.String), typeof(System.Object));
					r_MSetGenericData_String_Object.SetBelong(this.GetValue());
				}
				return r_MSetGenericData_String_Object;
			}
		}

		/// <summary>
		/// Void SetUnityObjectReferences(System.Collections.Generic.IEnumerable`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_MSetUnityObjectReferences_IEnumerable_d_Object_p_;
		public virtual RMethod RMSetUnityObjectReferences_IEnumerable_d_Object_p_
		{
			get
			{
				if(r_MSetUnityObjectReferences_IEnumerable_d_Object_p_ == null)
				{
					r_MSetUnityObjectReferences_IEnumerable_d_Object_p_ = new(this, "SetUnityObjectReferences", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_MSetUnityObjectReferences_IEnumerable_d_Object_p_.SetBelong(this.GetValue());
				}
				return r_MSetUnityObjectReferences_IEnumerable_d_Object_p_;
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


        public RStartDragArgs() : base("UnityEngine.UIElements.StartDragArgs")
        {
        }

        public RStartDragArgs(System.Object instance) : base("UnityEngine.UIElements.StartDragArgs")
		{
            SetInstance(instance);
		}

        public RStartDragArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStartDragArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetGenericData(System.String @key, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @data};
            var ___result = RMSetGenericData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUnityObjectReferences(System.Collections.Generic.IEnumerable<UnityEngine.Object> @references)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@references};
            var ___result = RMSetUnityObjectReferences_IEnumerable_d_Object_p_.Invoke(___genericsType, ___parameters);

            
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
