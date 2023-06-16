
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RVisualElement
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.VisualElement+TypeData
	/// </summary>
    public partial class RTypeData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+TypeData");
            }
        }

        public RTypeData() : base("UnityEngine.UIElements.VisualElement+TypeData")
        {
        }

        public RTypeData(System.Object instance) : base("UnityEngine.UIElements.VisualElement+TypeData")
		{
            SetInstance(instance);
		}

        public RTypeData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Type <type>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_F__0__type__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RF__0__type__1__k__BackingField
		{
			get
			{
				if(r_F__0__type__1__k__BackingField == null)
				{
					r_F__0__type__1__k__BackingField = new(this, "<type>k__BackingField");
				}
				return r_F__0__type__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String m_FullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_FullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_FullTypeName
		{
			get
			{
				if(r_Fm_FullTypeName == null)
				{
					r_Fm_FullTypeName = new(this, "m_FullTypeName");
				}
				return r_Fm_FullTypeName;
			}
		}

		/// <summary>
		/// System.String m_TypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_TypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_TypeName
		{
			get
			{
				if(r_Fm_TypeName == null)
				{
					r_Fm_TypeName = new(this, "m_TypeName");
				}
				return r_Fm_TypeName;
			}
		}

		/// <summary>
		/// System.String m_TypeNamespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_TypeNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_TypeNamespace
		{
			get
			{
				if(r_Fm_TypeNamespace == null)
				{
					r_Fm_TypeNamespace = new(this, "m_TypeNamespace");
				}
				return r_Fm_TypeNamespace;
			}
		}

		/// <summary>
		/// System.Type type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PfullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PtypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtypeName
		{
			get
			{
				if(r_PtypeName == null)
				{
					r_PtypeName = new(this, "typeName", -1);
				}
				return r_PtypeName;
			}
		}

		/// <summary>
		/// System.String typeNamespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PtypeNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtypeNamespace
		{
			get
			{
				if(r_PtypeNamespace == null)
				{
					r_PtypeNamespace = new(this, "typeNamespace", -1);
				}
				return r_PtypeNamespace;
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