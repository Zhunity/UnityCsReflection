using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Dimension
	/// </summary>
    public partial class RDimension : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension+Unit unit
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RDimension.RUnit r_Funit;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RDimension.RUnit RFunit
		{
			get
			{
				if(r_Funit == null)
				{
					r_Funit = new(this, "unit");
					r_Funit.SetBelong(this.instance);
				}
				return r_Funit;
			}
		}

		/// <summary>
		/// System.Single value
		/// </summary>
		protected RSystem.RSingle r_Fvalue;
		public virtual RSystem.RSingle RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
					r_Fvalue.SetBelong(this.instance);
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ToLength()
		/// </summary>
		protected RMethod r_MToLength;
		public virtual RMethod RMToLength
		{
			get
			{
				if(r_MToLength == null)
				{
					r_MToLength = new(this, "ToLength", 0);
					r_MToLength.SetBelong(this.instance);
				}
				return r_MToLength;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeValue ToTime()
		/// </summary>
		protected RMethod r_MToTime;
		public virtual RMethod RMToTime
		{
			get
			{
				if(r_MToTime == null)
				{
					r_MToTime = new(this, "ToTime", 0);
					r_MToTime.SetBelong(this.instance);
				}
				return r_MToTime;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle ToAngle()
		/// </summary>
		protected RMethod r_MToAngle;
		public virtual RMethod RMToAngle
		{
			get
			{
				if(r_MToAngle == null)
				{
					r_MToAngle = new(this, "ToAngle", 0);
					r_MToAngle.SetBelong(this.instance);
				}
				return r_MToAngle;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleSheets.Dimension, UnityEngine.UIElements.StyleSheets.Dimension)
		/// </summary>
		protected static RMethod r_Mop_Equality_Dimension_Dimension;
		public static RMethod RMop_Equality_Dimension_Dimension
		{
			get
			{
				if(r_Mop_Equality_Dimension_Dimension == null)
				{
					r_Mop_Equality_Dimension_Dimension = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"));
					r_Mop_Equality_Dimension_Dimension.SetBelong(null);
				}
				return r_Mop_Equality_Dimension_Dimension;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleSheets.Dimension, UnityEngine.UIElements.StyleSheets.Dimension)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Dimension_Dimension;
		public static RMethod RMop_Inequality_Dimension_Dimension
		{
			get
			{
				if(r_Mop_Inequality_Dimension_Dimension == null)
				{
					r_Mop_Inequality_Dimension_Dimension = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"));
					r_Mop_Inequality_Dimension_Dimension.SetBelong(null);
				}
				return r_Mop_Inequality_Dimension_Dimension;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleSheets.Dimension)
		/// </summary>
		protected RMethod r_MEquals_Dimension;
		public virtual RMethod RMEquals_Dimension
		{
			get
			{
				if(r_MEquals_Dimension == null)
				{
					r_MEquals_Dimension = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"));
					r_MEquals_Dimension.SetBelong(this.instance);
				}
				return r_MEquals_Dimension;
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


        public RDimension() : base("UnityEngine.UIElements.StyleSheets.Dimension")
        {
        }

        public RDimension(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.Dimension")
		{
            SetInstance(instance);
		}

        public RDimension(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDimension(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.Length ToLength()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToLength.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual UnityEngine.UIElements.TimeValue ToTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToTime.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public virtual UnityEngine.UIElements.Angle ToAngle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToAngle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static System.Boolean op_Equality(RUnityEngine.RUIElements.RStyleSheets.RDimension @lhs, RUnityEngine.RUIElements.RStyleSheets.RDimension @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_Dimension_Dimension.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnityEngine.RUIElements.RStyleSheets.RDimension @lhs, RUnityEngine.RUIElements.RStyleSheets.RDimension @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_Dimension_Dimension.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RUnityEngine.RUIElements.RStyleSheets.RDimension @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_Dimension.Invoke(___genericsType, ___parameters);

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
