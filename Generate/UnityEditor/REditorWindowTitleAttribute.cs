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
		protected RField r___1__title__2__k__BackingField;
		public virtual RField R__1__title__2__k__BackingField
		{
			get
			{
				if(r___1__title__2__k__BackingField == null)
				{
					r___1__title__2__k__BackingField = new(this, "<title>k__BackingField");
					r___1__title__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__title__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <icon>k__BackingField
		/// </summary>
		protected RField r___1__icon__2__k__BackingField;
		public virtual RField R__1__icon__2__k__BackingField
		{
			get
			{
				if(r___1__icon__2__k__BackingField == null)
				{
					r___1__icon__2__k__BackingField = new(this, "<icon>k__BackingField");
					r___1__icon__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__icon__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <useTypeNameAsIconName>k__BackingField
		/// </summary>
		protected RField r___1__useTypeNameAsIconName__2__k__BackingField;
		public virtual RField R__1__useTypeNameAsIconName__2__k__BackingField
		{
			get
			{
				if(r___1__useTypeNameAsIconName__2__k__BackingField == null)
				{
					r___1__useTypeNameAsIconName__2__k__BackingField = new(this, "<useTypeNameAsIconName>k__BackingField");
					r___1__useTypeNameAsIconName__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__useTypeNameAsIconName__2__k__BackingField;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_RMatch_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_RMatch_Object == null)
				{
					r_RMatch_Object = new(this, "Match", 0, typeof(System.Object));
					r_RMatch_Object.SetBelong(this.instance);
				}
				return r_RMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_RIsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_RIsDefaultAttribute == null)
				{
					r_RIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_RIsDefaultAttribute.SetBelong(this.instance);
				}
				return r_RIsDefaultAttribute;
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

        public virtual System.Boolean Equals(System.Object  @obj)
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


        public virtual System.Boolean Match(System.Object  @obj)
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
