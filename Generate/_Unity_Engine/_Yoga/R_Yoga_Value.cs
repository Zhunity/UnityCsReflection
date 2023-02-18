
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RYoga
{
	/// <summary>
	/// UnityEngine.Yoga.YogaValue
	/// </summary>
    public partial class RYogaValue : RMember //
    {

		/// <summary>
		/// System.Single value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaUnit unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaUnit r_Funit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaUnit RFunit
		{
			get
			{
				if(r_Funit == null)
				{
					r_Funit = new(this, "unit");
				}
				return r_Funit;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaUnit Unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaUnit r_PUnit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaUnit RPUnit
		{
			get
			{
				if(r_PUnit == null)
				{
					r_PUnit = new(this, "Unit", -1);
				}
				return r_PUnit;
			}
		}

		/// <summary>
		/// Single Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Point(Single)
		/// </summary>
		protected static RMethod r_MPoint_Single;
		public static RMethod RMPoint_Single
		{
			get
			{
				if(r_MPoint_Single == null)
				{
					r_MPoint_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Point", 0, typeof(System.Single));
				}
				return r_MPoint_Single;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_MEquals_YogaValue;
		public virtual RMethod RMEquals_YogaValue
		{
			get
			{
				if(r_MEquals_YogaValue == null)
				{
					r_MEquals_YogaValue = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
				}
				return r_MEquals_YogaValue;
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
		/// UnityEngine.Yoga.YogaValue Undefined()
		/// </summary>
		protected static RMethod r_MUndefined;
		public static RMethod RMUndefined
		{
			get
			{
				if(r_MUndefined == null)
				{
					r_MUndefined = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Undefined", 0);
				}
				return r_MUndefined;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Auto()
		/// </summary>
		protected static RMethod r_MAuto;
		public static RMethod RMAuto
		{
			get
			{
				if(r_MAuto == null)
				{
					r_MAuto = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Auto", 0);
				}
				return r_MAuto;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Percent(Single)
		/// </summary>
		protected static RMethod r_MPercent_Single;
		public static RMethod RMPercent_Single
		{
			get
			{
				if(r_MPercent_Single == null)
				{
					r_MPercent_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "Percent", 0, typeof(System.Single));
				}
				return r_MPercent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Single;
		public static RMethod RMop_Implicit_Single
		{
			get
			{
				if(r_Mop_Implicit_Single == null)
				{
					r_Mop_Implicit_Single = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "op_Implicit", 0, typeof(System.Single));
				}
				return r_Mop_Implicit_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarshalValue(UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected static RMethod r_MMarshalValue_YogaValue;
		public static RMethod RMMarshalValue_YogaValue
		{
			get
			{
				if(r_MMarshalValue_YogaValue == null)
				{
					r_MMarshalValue_YogaValue = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"), "MarshalValue", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaValue"));
				}
				return r_MMarshalValue_YogaValue;
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

        public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue Point(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMPoint_Single.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_YogaValue.Invoke(___genericsType, ___parameters);

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


        public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue Undefined()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUndefined.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAuto.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue Percent(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMPercent_Single.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue op_Implicit(System.Single @pointValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointValue};
            var ___result = RMop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue MarshalValue(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMMarshalValue_YogaValue.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaValue(___result);
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
