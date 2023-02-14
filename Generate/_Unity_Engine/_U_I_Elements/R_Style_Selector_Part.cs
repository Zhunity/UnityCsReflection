
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSelectorPart
	/// </summary>
    public partial class RStyleSelectorPart : RMember //
    {

		/// <summary>
		/// System.String m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
					r_Fm_Value.SetBelong(this.instance);
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorType m_Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorType r_Fm_Type;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorType RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
					r_Fm_Type.SetBelong(this.instance);
				}
				return r_Fm_Type;
			}
		}

		/// <summary>
		/// System.Object tempData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_FtempData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFtempData
		{
			get
			{
				if(r_FtempData == null)
				{
					r_FtempData = new(this, "tempData");
					r_FtempData.SetBelong(this.instance);
				}
				return r_FtempData;
			}
		}

		/// <summary>
		/// System.String value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.instance);
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
					r_Ptype.SetBelong(this.instance);
				}
				return r_Ptype;
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

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateClass(System.String)
		/// </summary>
		protected static RMethod r_MCreateClass_String;
		public static RMethod RMCreateClass_String
		{
			get
			{
				if(r_MCreateClass_String == null)
				{
					r_MCreateClass_String = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateClass", 0, typeof(System.String));
					r_MCreateClass_String.SetBelong(null);
				}
				return r_MCreateClass_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreatePseudoClass(System.String)
		/// </summary>
		protected static RMethod r_MCreatePseudoClass_String;
		public static RMethod RMCreatePseudoClass_String
		{
			get
			{
				if(r_MCreatePseudoClass_String == null)
				{
					r_MCreatePseudoClass_String = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreatePseudoClass", 0, typeof(System.String));
					r_MCreatePseudoClass_String.SetBelong(null);
				}
				return r_MCreatePseudoClass_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateId(System.String)
		/// </summary>
		protected static RMethod r_MCreateId_String;
		public static RMethod RMCreateId_String
		{
			get
			{
				if(r_MCreateId_String == null)
				{
					r_MCreateId_String = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateId", 0, typeof(System.String));
					r_MCreateId_String.SetBelong(null);
				}
				return r_MCreateId_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateType(System.Type)
		/// </summary>
		protected static RMethod r_MCreateType_Type;
		public static RMethod RMCreateType_Type
		{
			get
			{
				if(r_MCreateType_Type == null)
				{
					r_MCreateType_Type = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateType", 0, typeof(System.Type));
					r_MCreateType_Type.SetBelong(null);
				}
				return r_MCreateType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateType(System.String)
		/// </summary>
		protected static RMethod r_MCreateType_String;
		public static RMethod RMCreateType_String
		{
			get
			{
				if(r_MCreateType_String == null)
				{
					r_MCreateType_String = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateType", 0, typeof(System.String));
					r_MCreateType_String.SetBelong(null);
				}
				return r_MCreateType_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreatePredicate(System.Object)
		/// </summary>
		protected static RMethod r_MCreatePredicate_Object;
		public static RMethod RMCreatePredicate_Object
		{
			get
			{
				if(r_MCreatePredicate_Object == null)
				{
					r_MCreatePredicate_Object = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreatePredicate", 0, typeof(System.Object));
					r_MCreatePredicate_Object.SetBelong(null);
				}
				return r_MCreatePredicate_Object;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart CreateWildCard()
		/// </summary>
		protected static RMethod r_MCreateWildCard;
		public static RMethod RMCreateWildCard
		{
			get
			{
				if(r_MCreateWildCard == null)
				{
					r_MCreateWildCard = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"), "CreateWildCard", 0);
					r_MCreateWildCard.SetBelong(null);
				}
				return r_MCreateWildCard;
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
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreateClass(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMCreateClass_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreatePseudoClass(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMCreatePseudoClass_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreateId(System.String @Id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Id};
            var ___result = RMCreateId_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreateType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMCreateType_Type.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreateType(System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RMCreateType_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreatePredicate(System.Object @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RMCreatePredicate_Object.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart CreateWildCard()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateWildCard.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart(___result);
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


    }
}
