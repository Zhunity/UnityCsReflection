using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSelectorPart
	/// </summary>
    public partial class RStyleSelectorPart : RMember //
    {

		/// <summary>
		/// System.String m_Value
		/// </summary>
		protected RField r_m_Value;
		public virtual RField Rm_Value
		{
			get
			{
				if(r_m_Value == null)
				{
					r_m_Value = new(this, "m_Value");
					r_m_Value.SetBelong(this.instance);
				}
				return r_m_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorType m_Type
		/// </summary>
		protected RField r_m_Type;
		public virtual RField Rm_Type
		{
			get
			{
				if(r_m_Type == null)
				{
					r_m_Type = new(this, "m_Type");
					r_m_Type.SetBelong(this.instance);
				}
				return r_m_Type;
			}
		}

		/// <summary>
		/// System.Object tempData
		/// </summary>
		protected RSystem.RObject r_tempData;
		public virtual RSystem.RObject RtempData
		{
			get
			{
				if(r_tempData == null)
				{
					r_tempData = new(this, "tempData");
					r_tempData.SetBelong(this.instance);
				}
				return r_tempData;
			}
		}

		/// <summary>
		/// System.String value
		/// </summary>
		protected RProperty r_value;
		public virtual RProperty Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value", -1);
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorType type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
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

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateClass(System.String)
		/// </summary>
		protected static RMethod r_CreateClass_String;
		public static RMethod RCreateClass_String
		{
			get
			{
				if(r_CreateClass_String == null)
				{
					r_CreateClass_String = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateClass", 0, typeof(System.String));
					r_CreateClass_String.SetBelong(null);
				}
				return r_CreateClass_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreatePseudoClass(System.String)
		/// </summary>
		protected static RMethod r_CreatePseudoClass_String;
		public static RMethod RCreatePseudoClass_String
		{
			get
			{
				if(r_CreatePseudoClass_String == null)
				{
					r_CreatePseudoClass_String = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreatePseudoClass", 0, typeof(System.String));
					r_CreatePseudoClass_String.SetBelong(null);
				}
				return r_CreatePseudoClass_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateId(System.String)
		/// </summary>
		protected static RMethod r_CreateId_String;
		public static RMethod RCreateId_String
		{
			get
			{
				if(r_CreateId_String == null)
				{
					r_CreateId_String = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateId", 0, typeof(System.String));
					r_CreateId_String.SetBelong(null);
				}
				return r_CreateId_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateType(System.Type)
		/// </summary>
		protected static RMethod r_CreateType_Type;
		public static RMethod RCreateType_Type
		{
			get
			{
				if(r_CreateType_Type == null)
				{
					r_CreateType_Type = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateType", 0, typeof(System.Type));
					r_CreateType_Type.SetBelong(null);
				}
				return r_CreateType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateType(System.String)
		/// </summary>
		protected static RMethod r_CreateType_String;
		public static RMethod RCreateType_String
		{
			get
			{
				if(r_CreateType_String == null)
				{
					r_CreateType_String = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateType", 0, typeof(System.String));
					r_CreateType_String.SetBelong(null);
				}
				return r_CreateType_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreatePredicate(System.Object)
		/// </summary>
		protected static RMethod r_CreatePredicate_Object;
		public static RMethod RCreatePredicate_Object
		{
			get
			{
				if(r_CreatePredicate_Object == null)
				{
					r_CreatePredicate_Object = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreatePredicate", 0, typeof(System.Object));
					r_CreatePredicate_Object.SetBelong(null);
				}
				return r_CreatePredicate_Object;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateWildCard()
		/// </summary>
		protected static RMethod r_CreateWildCard;
		public static RMethod RCreateWildCard
		{
			get
			{
				if(r_CreateWildCard == null)
				{
					r_CreateWildCard = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateWildCard", 0);
					r_CreateWildCard.SetBelong(null);
				}
				return r_CreateWildCard;
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


        public RStyleSelectorPart() : base("UnityEngine.UIElements.StyleSelectorPart")
        {
        }

        public RStyleSelectorPart(System.Object instance) : base("UnityEngine.UIElements.StyleSelectorPart")
		{
            SetInstance(instance);
		}

        public RStyleSelectorPart(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleSelectorPart(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Object CreateClass(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RCreateClass_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object CreatePseudoClass(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RCreatePseudoClass_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object CreateId(System.String  @Id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Id};
            var ___result = RCreateId_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object CreateType(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RCreateType_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object CreateType(System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RCreateType_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object CreatePredicate(System.Object  @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RCreatePredicate_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object CreateWildCard()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateWildCard.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


    }
}
