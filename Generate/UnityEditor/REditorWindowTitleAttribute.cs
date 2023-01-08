using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.EditorWindowTitleAttribute
	/// </summary>
    public partial class REditorWindowTitleAttribute : RMember //
    {

		/// <summary>
		/// System.String <title>k__BackingField
		/// </summary>
		protected RField r___0__title__1__k__BackingField;
		public virtual RField R__0__title__1__k__BackingField
		{
			get
			{
				if(r___0__title__1__k__BackingField == null)
				{
					r___0__title__1__k__BackingField = new(this, "<title>k__BackingField");
					r___0__title__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__title__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <icon>k__BackingField
		/// </summary>
		protected RField r___0__icon__1__k__BackingField;
		public virtual RField R__0__icon__1__k__BackingField
		{
			get
			{
				if(r___0__icon__1__k__BackingField == null)
				{
					r___0__icon__1__k__BackingField = new(this, "<icon>k__BackingField");
					r___0__icon__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__icon__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <useTypeNameAsIconName>k__BackingField
		/// </summary>
		protected RField r___0__useTypeNameAsIconName__1__k__BackingField;
		public virtual RField R__0__useTypeNameAsIconName__1__k__BackingField
		{
			get
			{
				if(r___0__useTypeNameAsIconName__1__k__BackingField == null)
				{
					r___0__useTypeNameAsIconName__1__k__BackingField = new(this, "<useTypeNameAsIconName>k__BackingField");
					r___0__useTypeNameAsIconName__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__useTypeNameAsIconName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected RProperty r_title;
		public virtual RProperty Rtitle
		{
			get
			{
				if(r_title == null)
				{
					r_title = new(this, "title", -1);
					r_title.SetBelong(this.instance);
				}
				return r_title;
			}
		}

		/// <summary>
		/// System.String icon
		/// </summary>
		protected RProperty r_icon;
		public virtual RProperty Ricon
		{
			get
			{
				if(r_icon == null)
				{
					r_icon = new(this, "icon", -1);
					r_icon.SetBelong(this.instance);
				}
				return r_icon;
			}
		}

		/// <summary>
		/// Boolean useTypeNameAsIconName
		/// </summary>
		protected RProperty r_useTypeNameAsIconName;
		public virtual RProperty RuseTypeNameAsIconName
		{
			get
			{
				if(r_useTypeNameAsIconName == null)
				{
					r_useTypeNameAsIconName = new(this, "useTypeNameAsIconName", -1);
					r_useTypeNameAsIconName.SetBelong(this.instance);
				}
				return r_useTypeNameAsIconName;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected RSystem.RObject r_TypeId;
		public virtual RSystem.RObject RTypeId
		{
			get
			{
				if(r_TypeId == null)
				{
					r_TypeId = new(this, "TypeId", -1);
					r_TypeId.SetBelong(this.instance);
				}
				return r_TypeId;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_Match_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_Match_Object == null)
				{
					r_Match_Object = new(this, "Match", 0, typeof(System.Object));
					r_Match_Object.SetBelong(this.instance);
				}
				return r_Match_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_IsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_IsDefaultAttribute == null)
				{
					r_IsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_IsDefaultAttribute.SetBelong(this.instance);
				}
				return r_IsDefaultAttribute;
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


        public REditorWindowTitleAttribute() : base("UnityEditor.EditorWindowTitleAttribute")
        {
        }

        public REditorWindowTitleAttribute(System.Object instance) : base("UnityEditor.EditorWindowTitleAttribute")
		{
            SetInstance(instance);
		}

        public REditorWindowTitleAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REditorWindowTitleAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Match(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
