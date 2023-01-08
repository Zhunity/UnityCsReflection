using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Length
	/// </summary>
    public partial class RLength : RMember //
    {

		/// <summary>
		/// System.Single k_MaxValue
		/// </summary>
		protected static RField r_k_MaxValue;
		public static RField Rk_MaxValue
		{
			get
			{
				if(r_k_MaxValue == null)
				{
					r_k_MaxValue = new(typeof(UnityEngine.UIElements.Length), "k_MaxValue");
					r_k_MaxValue.SetBelong(null);
				}
				return r_k_MaxValue;
			}
		}

		/// <summary>
		/// System.Single m_Value
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
		/// UnityEngine.UIElements.Length+Unit m_Unit
		/// </summary>
		protected RField r_m_Unit;
		public virtual RField Rm_Unit
		{
			get
			{
				if(r_m_Unit == null)
				{
					r_m_Unit = new(this, "m_Unit");
					r_m_Unit.SetBelong(this.instance);
				}
				return r_m_Unit;
			}
		}

		/// <summary>
		/// Single value
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
		/// UnityEngine.UIElements.LengthUnit unit
		/// </summary>
		protected RProperty r_unit;
		public virtual RProperty Runit
		{
			get
			{
				if(r_unit == null)
				{
					r_unit = new(this, "unit", -1);
					r_unit.SetBelong(this.instance);
				}
				return r_unit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length Percent(Single)
		/// </summary>
		protected static RMethod r_Percent_Single;
		public static RMethod RPercent_Single
		{
			get
			{
				if(r_Percent_Single == null)
				{
					r_Percent_Single = new(typeof(UnityEngine.UIElements.Length), "Percent", 0, typeof(System.Single));
					r_Percent_Single.SetBelong(null);
				}
				return r_Percent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length Auto()
		/// </summary>
		protected static RMethod r_Auto;
		public static RMethod RAuto
		{
			get
			{
				if(r_Auto == null)
				{
					r_Auto = new(typeof(UnityEngine.UIElements.Length), "Auto", 0);
					r_Auto.SetBelong(null);
				}
				return r_Auto;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length None()
		/// </summary>
		protected static RMethod r_None;
		public static RMethod RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new(typeof(UnityEngine.UIElements.Length), "None", 0);
					r_None.SetBelong(null);
				}
				return r_None;
			}
		}

		/// <summary>
		/// Boolean IsAuto()
		/// </summary>
		protected RMethod r_IsAuto;
		public virtual RMethod RIsAuto
		{
			get
			{
				if(r_IsAuto == null)
				{
					r_IsAuto = new(this, "IsAuto", 0);
					r_IsAuto.SetBelong(this.instance);
				}
				return r_IsAuto;
			}
		}

		/// <summary>
		/// Boolean IsNone()
		/// </summary>
		protected RMethod r_IsNone;
		public virtual RMethod RIsNone
		{
			get
			{
				if(r_IsNone == null)
				{
					r_IsNone = new(this, "IsNone", 0);
					r_IsNone.SetBelong(this.instance);
				}
				return r_IsNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length op_Implicit(Single)
		/// </summary>
		protected static RMethod r_op_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_op_Implicit_Single == null)
				{
					r_op_Implicit_Single = new(typeof(UnityEngine.UIElements.Length), "op_Implicit", 0, typeof(System.Single));
					r_op_Implicit_Single.SetBelong(null);
				}
				return r_op_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Length, UnityEngine.UIElements.Length)
		/// </summary>
		protected static RMethod r_op_Equality_Length_Length;
		public static RMethod Rop_Equality_Length_Length
		{
			get
			{
				if(r_op_Equality_Length_Length == null)
				{
					r_op_Equality_Length_Length = new(typeof(UnityEngine.UIElements.Length), "op_Equality", 0, typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length));
					r_op_Equality_Length_Length.SetBelong(null);
				}
				return r_op_Equality_Length_Length;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Length, UnityEngine.UIElements.Length)
		/// </summary>
		protected static RMethod r_op_Inequality_Length_Length;
		public static RMethod Rop_Inequality_Length_Length
		{
			get
			{
				if(r_op_Inequality_Length_Length == null)
				{
					r_op_Inequality_Length_Length = new(typeof(UnityEngine.UIElements.Length), "op_Inequality", 0, typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length));
					r_op_Inequality_Length_Length.SetBelong(null);
				}
				return r_op_Inequality_Length_Length;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Length)
		/// </summary>
		protected RMethod r_Equals_Length;
		public virtual RMethod REquals_Length
		{
			get
			{
				if(r_Equals_Length == null)
				{
					r_Equals_Length = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Length));
					r_Equals_Length.SetBelong(this.instance);
				}
				return r_Equals_Length;
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

        public static UnityEngine.UIElements.Length Percent(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RPercent_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public static UnityEngine.UIElements.Length Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAuto.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public static UnityEngine.UIElements.Length None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual System.Boolean IsAuto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAuto.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.Length op_Implicit(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Length  @lhs, UnityEngine.UIElements.Length  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Length_Length.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Length  @lhs, UnityEngine.UIElements.Length  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Length_Length.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Length  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Length.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
