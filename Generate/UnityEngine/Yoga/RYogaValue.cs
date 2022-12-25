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
		protected RField r_value;
		public virtual RField Rvalue
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
		protected RProperty r_Value;
		public virtual RProperty RValue
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
		protected static RMethod r_RPoint_Single;
		public static RMethod RPoint_Single
		{
			get
			{
				if(r_RPoint_Single == null)
				{
					r_RPoint_Single = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Point", 0, typeof(System.Single));
					r_RPoint_Single.SetBelong(null);
				}
				return r_RPoint_Single;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_REquals_YogaValue;
		public virtual RMethod REquals_YogaValue
		{
			get
			{
				if(r_REquals_YogaValue == null)
				{
					r_REquals_YogaValue = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_REquals_YogaValue.SetBelong(this.instance);
				}
				return r_REquals_YogaValue;
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
		/// UnityEngine.Yoga.YogaValue Undefined()
		/// </summary>
		protected static RMethod r_RUndefined;
		public static RMethod RUndefined
		{
			get
			{
				if(r_RUndefined == null)
				{
					r_RUndefined = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Undefined", 0);
					r_RUndefined.SetBelong(null);
				}
				return r_RUndefined;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Auto()
		/// </summary>
		protected static RMethod r_RAuto;
		public static RMethod RAuto
		{
			get
			{
				if(r_RAuto == null)
				{
					r_RAuto = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Auto", 0);
					r_RAuto.SetBelong(null);
				}
				return r_RAuto;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Percent(Single)
		/// </summary>
		protected static RMethod r_RPercent_Single;
		public static RMethod RPercent_Single
		{
			get
			{
				if(r_RPercent_Single == null)
				{
					r_RPercent_Single = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Percent", 0, typeof(System.Single));
					r_RPercent_Single.SetBelong(null);
				}
				return r_RPercent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_Rop_Implicit_Single == null)
				{
					r_Rop_Implicit_Single = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"), "op_Implicit", 0, typeof(System.Single));
					r_Rop_Implicit_Single.SetBelong(null);
				}
				return r_Rop_Implicit_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarshalValue(UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected static RMethod r_RMarshalValue_YogaValue;
		public static RMethod RMarshalValue_YogaValue
		{
			get
			{
				if(r_RMarshalValue_YogaValue == null)
				{
					r_RMarshalValue_YogaValue = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"), "MarshalValue", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_RMarshalValue_YogaValue.SetBelong(null);
				}
				return r_RMarshalValue_YogaValue;
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

        public static System.Object Point(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RPoint_Single.Invoke(___genericsType, ___parameters);

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


        public static System.Object Undefined()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUndefined.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAuto.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object Percent(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RPercent_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object op_Implicit(System.Single  @pointValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointValue};
            var ___result = Rop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
