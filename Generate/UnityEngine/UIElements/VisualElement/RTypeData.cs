using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RVisualElement
{
	
	/// <summary>
	/// UnityEngine.UIElements.VisualElement+TypeData
	/// </summary>
    public partial class RTypeData : RMember //
    {

		/// <summary>
		/// System.Type <type>k__BackingField
		/// </summary>
		protected RSystem.RType r___1__type__2__k__BackingField;
		public virtual RSystem.RType R__1__type__2__k__BackingField
		{
			get
			{
				if(r___1__type__2__k__BackingField == null)
				{
					r___1__type__2__k__BackingField = new(this, "<type>k__BackingField");
					r___1__type__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__type__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String m_FullTypeName
		/// </summary>
		protected RField r_m_FullTypeName;
		public virtual RField Rm_FullTypeName
		{
			get
			{
				if(r_m_FullTypeName == null)
				{
					r_m_FullTypeName = new(this, "m_FullTypeName");
					r_m_FullTypeName.SetBelong(this.instance);
				}
				return r_m_FullTypeName;
			}
		}

		/// <summary>
		/// System.String m_TypeName
		/// </summary>
		protected RField r_m_TypeName;
		public virtual RField Rm_TypeName
		{
			get
			{
				if(r_m_TypeName == null)
				{
					r_m_TypeName = new(this, "m_TypeName");
					r_m_TypeName.SetBelong(this.instance);
				}
				return r_m_TypeName;
			}
		}

		/// <summary>
		/// System.String m_TypeNamespace
		/// </summary>
		protected RField r_m_TypeNamespace;
		public virtual RField Rm_TypeNamespace
		{
			get
			{
				if(r_m_TypeNamespace == null)
				{
					r_m_TypeNamespace = new(this, "m_TypeNamespace");
					r_m_TypeNamespace.SetBelong(this.instance);
				}
				return r_m_TypeNamespace;
			}
		}

		/// <summary>
		/// System.Type type
		/// </summary>
		protected RSystem.RType r_type;
		public virtual RSystem.RType Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RProperty r_fullTypeName;
		public virtual RProperty RfullTypeName
		{
			get
			{
				if(r_fullTypeName == null)
				{
					r_fullTypeName = new(this, "fullTypeName", -1);
					r_fullTypeName.SetBelong(this.instance);
				}
				return r_fullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected RProperty r_typeName;
		public virtual RProperty RtypeName
		{
			get
			{
				if(r_typeName == null)
				{
					r_typeName = new(this, "typeName", -1);
					r_typeName.SetBelong(this.instance);
				}
				return r_typeName;
			}
		}

		/// <summary>
		/// System.String typeNamespace
		/// </summary>
		protected RProperty r_typeNamespace;
		public virtual RProperty RtypeNamespace
		{
			get
			{
				if(r_typeNamespace == null)
				{
					r_typeNamespace = new(this, "typeNamespace", -1);
					r_typeNamespace.SetBelong(this.instance);
				}
				return r_typeNamespace;
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

        public virtual System.Boolean Equals(System.Object  @obj)
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