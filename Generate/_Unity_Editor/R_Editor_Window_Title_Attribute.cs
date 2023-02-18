
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.EditorWindowTitleAttribute
	/// </summary>
    public partial class REditorWindowTitleAttribute : RMember //
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
				}
				return r_F__0__title__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <icon>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__icon__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__icon__1__k__BackingField
		{
			get
			{
				if(r_F__0__icon__1__k__BackingField == null)
				{
					r_F__0__icon__1__k__BackingField = new(this, "<icon>k__BackingField");
				}
				return r_F__0__icon__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <useTypeNameAsIconName>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__useTypeNameAsIconName__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__useTypeNameAsIconName__1__k__BackingField
		{
			get
			{
				if(r_F__0__useTypeNameAsIconName__1__k__BackingField == null)
				{
					r_F__0__useTypeNameAsIconName__1__k__BackingField = new(this, "<useTypeNameAsIconName>k__BackingField");
				}
				return r_F__0__useTypeNameAsIconName__1__k__BackingField;
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
				}
				return r_Ptitle;
			}
		}

		/// <summary>
		/// System.String icon
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Picon;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPicon
		{
			get
			{
				if(r_Picon == null)
				{
					r_Picon = new(this, "icon", -1);
				}
				return r_Picon;
			}
		}

		/// <summary>
		/// Boolean useTypeNameAsIconName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseTypeNameAsIconName;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseTypeNameAsIconName
		{
			get
			{
				if(r_PuseTypeNameAsIconName == null)
				{
					r_PuseTypeNameAsIconName = new(this, "useTypeNameAsIconName", -1);
				}
				return r_PuseTypeNameAsIconName;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PTypeId;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPTypeId
		{
			get
			{
				if(r_PTypeId == null)
				{
					r_PTypeId = new(this, "TypeId", -1);
				}
				return r_PTypeId;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_MMatch_Object;
		public virtual RMethod RMMatch_Object
		{
			get
			{
				if(r_MMatch_Object == null)
				{
					r_MMatch_Object = new(this, "Match", 0, typeof(System.Object));
				}
				return r_MMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_MIsDefaultAttribute;
		public virtual RMethod RMIsDefaultAttribute
		{
			get
			{
				if(r_MIsDefaultAttribute == null)
				{
					r_MIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
				}
				return r_MIsDefaultAttribute;
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
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Match(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
