using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RYoga
{
	/// <summary>
	/// UnityEngine.Yoga.YogaValue
	/// </summary>
    public partial class RYogaValue : RMember //
    {

		/// <summary>
		/// System.Single value
		/// </summary>
		protected RSystem.RSingle r_value;
		public virtual RSystem.RSingle Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaUnit unit
		/// </summary>
		protected RField r_unit;
		public virtual RField Runit
		{
			get
			{
				if(r_unit == null)
				{
					r_unit = new(this, "unit");
					r_unit.SetBelong(this.instance);
				}
				return r_unit;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaUnit Unit
		/// </summary>
		protected RProperty r_Unit;
		public virtual RProperty RUnit
		{
			get
			{
				if(r_Unit == null)
				{
					r_Unit = new(this, "Unit", -1);
					r_Unit.SetBelong(this.instance);
				}
				return r_Unit;
			}
		}

		/// <summary>
		/// Single Value
		/// </summary>
		protected RSystem.RSingle r_Value;
		public virtual RSystem.RSingle RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Point(Single)
		/// </summary>
		protected static RMethod r_Point_Single;
		public static RMethod RPoint_Single
		{
			get
			{
				if(r_Point_Single == null)
				{
					r_Point_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Point", 0, typeof(System.Single));
					r_Point_Single.SetBelong(null);
				}
				return r_Point_Single;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_Equals_YogaValue;
		public virtual RMethod REquals_YogaValue
		{
			get
			{
				if(r_Equals_YogaValue == null)
				{
					r_Equals_YogaValue = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_Equals_YogaValue.SetBelong(this.instance);
				}
				return r_Equals_YogaValue;
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
		/// UnityEngine.Yoga.YogaValue Undefined()
		/// </summary>
		protected static RMethod r_Undefined;
		public static RMethod RUndefined
		{
			get
			{
				if(r_Undefined == null)
				{
					r_Undefined = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Undefined", 0);
					r_Undefined.SetBelong(null);
				}
				return r_Undefined;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Auto()
		/// </summary>
		protected static RMethod r_Auto;
		public static RMethod RAuto
		{
			get
			{
				if(r_Auto == null)
				{
					r_Auto = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Auto", 0);
					r_Auto.SetBelong(null);
				}
				return r_Auto;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Percent(Single)
		/// </summary>
		protected static RMethod r_Percent_Single;
		public static RMethod RPercent_Single
		{
			get
			{
				if(r_Percent_Single == null)
				{
					r_Percent_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Percent", 0, typeof(System.Single));
					r_Percent_Single.SetBelong(null);
				}
				return r_Percent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue op_Implicit(Single)
		/// </summary>
		protected static RMethod r_op_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_op_Implicit_Single == null)
				{
					r_op_Implicit_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "op_Implicit", 0, typeof(System.Single));
					r_op_Implicit_Single.SetBelong(null);
				}
				return r_op_Implicit_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarshalValue(UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected static RMethod r_MarshalValue_YogaValue;
		public static RMethod RMarshalValue_YogaValue
		{
			get
			{
				if(r_MarshalValue_YogaValue == null)
				{
					r_MarshalValue_YogaValue = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "MarshalValue", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_MarshalValue_YogaValue.SetBelong(null);
				}
				return r_MarshalValue_YogaValue;
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


        public RYogaValue() : base("UnityEngine.Yoga.YogaValue")
        {
        }

        public RYogaValue(System.Object instance) : base("UnityEngine.Yoga.YogaValue")
		{
            SetInstance(instance);
		}

        public RYogaValue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RYogaValue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RUnityEngine.RYoga.RYogaValue Point(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RPoint_Single.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaValue(___result);
        }


        public virtual System.Boolean Equals(RUnityEngine.RYoga.RYogaValue @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_YogaValue.Invoke(___genericsType, ___parameters);

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


        public static RUnityEngine.RYoga.RYogaValue Undefined()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUndefined.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static RUnityEngine.RYoga.RYogaValue Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAuto.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static RUnityEngine.RYoga.RYogaValue Percent(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RPercent_Single.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static RUnityEngine.RYoga.RYogaValue op_Implicit(System.Single @pointValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointValue};
            var ___result = Rop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static RUnityEngine.RYoga.RYogaValue MarshalValue(RUnityEngine.RYoga.RYogaValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMarshalValue_YogaValue.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaValue(___result);
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
