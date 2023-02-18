
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TimeValue
	/// </summary>
    public partial class RTimeValue : RMember //
    {

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
					r_Fm_Value.SetBelong(this.GetValue());
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeUnit m_Unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeUnit r_Fm_Unit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeUnit RFm_Unit
		{
			get
			{
				if(r_Fm_Unit == null)
				{
					r_Fm_Unit = new(this, "m_Unit");
					r_Fm_Unit.SetBelong(this.GetValue());
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
					r_Pvalue.SetBelong(this.GetValue());
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeUnit unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeUnit r_Punit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeUnit RPunit
		{
			get
			{
				if(r_Punit == null)
				{
					r_Punit = new(this, "unit", -1);
					r_Punit.SetBelong(this.GetValue());
				}
				return r_Punit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeValue op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Single;
		public static RMethod RMop_Implicit_Single
		{
			get
			{
				if(r_Mop_Implicit_Single == null)
				{
					r_Mop_Implicit_Single = new(typeof(UnityEngine.UIElements.TimeValue), "op_Implicit", 0, typeof(System.Single));
					r_Mop_Implicit_Single.SetBelong(null);
				}
				return r_Mop_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TimeValue, UnityEngine.UIElements.TimeValue)
		/// </summary>
		protected static RMethod r_Mop_Equality_TimeValue_TimeValue;
		public static RMethod RMop_Equality_TimeValue_TimeValue
		{
			get
			{
				if(r_Mop_Equality_TimeValue_TimeValue == null)
				{
					r_Mop_Equality_TimeValue_TimeValue = new(typeof(UnityEngine.UIElements.TimeValue), "op_Equality", 0, typeof(UnityEngine.UIElements.TimeValue), typeof(UnityEngine.UIElements.TimeValue));
					r_Mop_Equality_TimeValue_TimeValue.SetBelong(null);
				}
				return r_Mop_Equality_TimeValue_TimeValue;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TimeValue, UnityEngine.UIElements.TimeValue)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TimeValue_TimeValue;
		public static RMethod RMop_Inequality_TimeValue_TimeValue
		{
			get
			{
				if(r_Mop_Inequality_TimeValue_TimeValue == null)
				{
					r_Mop_Inequality_TimeValue_TimeValue = new(typeof(UnityEngine.UIElements.TimeValue), "op_Inequality", 0, typeof(UnityEngine.UIElements.TimeValue), typeof(UnityEngine.UIElements.TimeValue));
					r_Mop_Inequality_TimeValue_TimeValue.SetBelong(null);
				}
				return r_Mop_Inequality_TimeValue_TimeValue;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TimeValue)
		/// </summary>
		protected RMethod r_MEquals_TimeValue;
		public virtual RMethod RMEquals_TimeValue
		{
			get
			{
				if(r_MEquals_TimeValue == null)
				{
					r_MEquals_TimeValue = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TimeValue));
					r_MEquals_TimeValue.SetBelong(this.GetValue());
				}
				return r_MEquals_TimeValue;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
            var ___result = RMop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TimeValue @lhs, UnityEngine.UIElements.TimeValue @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_TimeValue_TimeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TimeValue @lhs, UnityEngine.UIElements.TimeValue @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_TimeValue_TimeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TimeValue @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_TimeValue.Invoke(___genericsType, ___parameters);

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
