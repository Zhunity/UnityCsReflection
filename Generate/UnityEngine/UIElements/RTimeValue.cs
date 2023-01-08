using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TimeValue
	/// </summary>
    public partial class RTimeValue : RMember //
    {

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
		/// UnityEngine.UIElements.TimeUnit m_Unit
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
		/// UnityEngine.UIElements.TimeUnit unit
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
		/// UnityEngine.UIElements.TimeValue op_Implicit(Single)
		/// </summary>
		protected static RMethod r_op_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_op_Implicit_Single == null)
				{
					r_op_Implicit_Single = new(typeof(UnityEngine.UIElements.TimeValue), "op_Implicit", 0, typeof(System.Single));
					r_op_Implicit_Single.SetBelong(null);
				}
				return r_op_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TimeValue, UnityEngine.UIElements.TimeValue)
		/// </summary>
		protected static RMethod r_op_Equality_TimeValue_TimeValue;
		public static RMethod Rop_Equality_TimeValue_TimeValue
		{
			get
			{
				if(r_op_Equality_TimeValue_TimeValue == null)
				{
					r_op_Equality_TimeValue_TimeValue = new(typeof(UnityEngine.UIElements.TimeValue), "op_Equality", 0, typeof(UnityEngine.UIElements.TimeValue), typeof(UnityEngine.UIElements.TimeValue));
					r_op_Equality_TimeValue_TimeValue.SetBelong(null);
				}
				return r_op_Equality_TimeValue_TimeValue;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TimeValue, UnityEngine.UIElements.TimeValue)
		/// </summary>
		protected static RMethod r_op_Inequality_TimeValue_TimeValue;
		public static RMethod Rop_Inequality_TimeValue_TimeValue
		{
			get
			{
				if(r_op_Inequality_TimeValue_TimeValue == null)
				{
					r_op_Inequality_TimeValue_TimeValue = new(typeof(UnityEngine.UIElements.TimeValue), "op_Inequality", 0, typeof(UnityEngine.UIElements.TimeValue), typeof(UnityEngine.UIElements.TimeValue));
					r_op_Inequality_TimeValue_TimeValue.SetBelong(null);
				}
				return r_op_Inequality_TimeValue_TimeValue;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TimeValue)
		/// </summary>
		protected RMethod r_Equals_TimeValue;
		public virtual RMethod REquals_TimeValue
		{
			get
			{
				if(r_Equals_TimeValue == null)
				{
					r_Equals_TimeValue = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TimeValue));
					r_Equals_TimeValue.SetBelong(this.instance);
				}
				return r_Equals_TimeValue;
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


        public RTimeValue() : base("UnityEngine.UIElements.TimeValue")
        {
        }

        public RTimeValue(System.Object instance) : base("UnityEngine.UIElements.TimeValue")
		{
            SetInstance(instance);
		}

        public RTimeValue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTimeValue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.TimeValue op_Implicit(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TimeValue @lhs, UnityEngine.UIElements.TimeValue @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_TimeValue_TimeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TimeValue @lhs, UnityEngine.UIElements.TimeValue @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_TimeValue_TimeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TimeValue @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_TimeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
