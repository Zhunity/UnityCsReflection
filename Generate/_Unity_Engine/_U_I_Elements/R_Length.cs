
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Length
	/// </summary>
    public partial class RLength : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Length);
            }
        }

        public RLength() : base("UnityEngine.UIElements.Length")
        {
        }

        public RLength(System.Object instance) : base("UnityEngine.UIElements.Length")
		{
            SetInstance(instance);
		}

        public RLength(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLength(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Single k_MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fk_MaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFk_MaxValue
		{
			get
			{
				if(r_Fk_MaxValue == null)
				{
					r_Fk_MaxValue = new(typeof(UnityEngine.UIElements.Length), "k_MaxValue");
				}
				return r_Fk_MaxValue;
			}
		}

		/// <summary>
		/// System.Single m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length+Unit m_Unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength.RUnit r_Fm_Unit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength.RUnit RFm_Unit
		{
			get
			{
				if(r_Fm_Unit == null)
				{
					r_Fm_Unit = new(this, "m_Unit");
				}
				return r_Fm_Unit;
			}
		}

		/// <summary>
		/// Single value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LengthUnit unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLengthUnit r_Punit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLengthUnit RPunit
		{
			get
			{
				if(r_Punit == null)
				{
					r_Punit = new(this, "unit", -1);
				}
				return r_Punit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length Percent(Single)
		/// </summary>
		protected static RMethod r_MPercent_Single;
		public static RMethod RMPercent_Single
		{
			get
			{
				if(r_MPercent_Single == null)
				{
					r_MPercent_Single = new(typeof(UnityEngine.UIElements.Length), "Percent", 0, typeof(System.Single));
				}
				return r_MPercent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length Auto()
		/// </summary>
		protected static RMethod r_MAuto;
		public static RMethod RMAuto
		{
			get
			{
				if(r_MAuto == null)
				{
					r_MAuto = new(typeof(UnityEngine.UIElements.Length), "Auto", 0);
				}
				return r_MAuto;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length None()
		/// </summary>
		protected static RMethod r_MNone;
		public static RMethod RMNone
		{
			get
			{
				if(r_MNone == null)
				{
					r_MNone = new(typeof(UnityEngine.UIElements.Length), "None", 0);
				}
				return r_MNone;
			}
		}

		/// <summary>
		/// Boolean IsAuto()
		/// </summary>
		protected RMethod r_MIsAuto;
		public virtual RMethod RMIsAuto
		{
			get
			{
				if(r_MIsAuto == null)
				{
					r_MIsAuto = new(this, "IsAuto", 0);
				}
				return r_MIsAuto;
			}
		}

		/// <summary>
		/// Boolean IsNone()
		/// </summary>
		protected RMethod r_MIsNone;
		public virtual RMethod RMIsNone
		{
			get
			{
				if(r_MIsNone == null)
				{
					r_MIsNone = new(this, "IsNone", 0);
				}
				return r_MIsNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Single;
		public static RMethod RMop_Implicit_Single
		{
			get
			{
				if(r_Mop_Implicit_Single == null)
				{
					r_Mop_Implicit_Single = new(typeof(UnityEngine.UIElements.Length), "op_Implicit", 0, typeof(System.Single));
				}
				return r_Mop_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Length, UnityEngine.UIElements.Length)
		/// </summary>
		protected static RMethod r_Mop_Equality_Length_Length;
		public static RMethod RMop_Equality_Length_Length
		{
			get
			{
				if(r_Mop_Equality_Length_Length == null)
				{
					r_Mop_Equality_Length_Length = new(typeof(UnityEngine.UIElements.Length), "op_Equality", 0, typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length));
				}
				return r_Mop_Equality_Length_Length;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Length, UnityEngine.UIElements.Length)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Length_Length;
		public static RMethod RMop_Inequality_Length_Length
		{
			get
			{
				if(r_Mop_Inequality_Length_Length == null)
				{
					r_Mop_Inequality_Length_Length = new(typeof(UnityEngine.UIElements.Length), "op_Inequality", 0, typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length));
				}
				return r_Mop_Inequality_Length_Length;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Length)
		/// </summary>
		protected RMethod r_MEquals_Length;
		public virtual RMethod RMEquals_Length
		{
			get
			{
				if(r_MEquals_Length == null)
				{
					r_MEquals_Length = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Length));
				}
				return r_MEquals_Length;
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


        public static UnityEngine.UIElements.Length Percent(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMPercent_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public static UnityEngine.UIElements.Length Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAuto.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public static UnityEngine.UIElements.Length None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual System.Boolean IsAuto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAuto.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.Length op_Implicit(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Length @lhs, UnityEngine.UIElements.Length @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Length_Length.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Length @lhs, UnityEngine.UIElements.Length @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Length_Length.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Length @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Length.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
