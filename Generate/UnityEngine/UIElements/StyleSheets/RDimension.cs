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
		/// UnityEngine.UIElements.Length ToLength()
		/// </summary>
		protected RMethod r_ToLength;
		public virtual RMethod RToLength
		{
			get
			{
				if(r_ToLength == null)
				{
					r_ToLength = new(this, "ToLength", 0);
					r_ToLength.SetBelong(this.instance);
				}
				return r_ToLength;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeValue ToTime()
		/// </summary>
		protected RMethod r_ToTime;
		public virtual RMethod RToTime
		{
			get
			{
				if(r_ToTime == null)
				{
					r_ToTime = new(this, "ToTime", 0);
					r_ToTime.SetBelong(this.instance);
				}
				return r_ToTime;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle ToAngle()
		/// </summary>
		protected RMethod r_ToAngle;
		public virtual RMethod RToAngle
		{
			get
			{
				if(r_ToAngle == null)
				{
					r_ToAngle = new(this, "ToAngle", 0);
					r_ToAngle.SetBelong(this.instance);
				}
				return r_ToAngle;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleSheets.Dimension, UnityEngine.UIElements.StyleSheets.Dimension)
		/// </summary>
		protected static RMethod r_op_Equality_Dimension_Dimension;
		public static RMethod Rop_Equality_Dimension_Dimension
		{
			get
			{
				if(r_op_Equality_Dimension_Dimension == null)
				{
					r_op_Equality_Dimension_Dimension = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"));
					r_op_Equality_Dimension_Dimension.SetBelong(null);
				}
				return r_op_Equality_Dimension_Dimension;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleSheets.Dimension, UnityEngine.UIElements.StyleSheets.Dimension)
		/// </summary>
		protected static RMethod r_op_Inequality_Dimension_Dimension;
		public static RMethod Rop_Inequality_Dimension_Dimension
		{
			get
			{
				if(r_op_Inequality_Dimension_Dimension == null)
				{
					r_op_Inequality_Dimension_Dimension = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"));
					r_op_Inequality_Dimension_Dimension.SetBelong(null);
				}
				return r_op_Inequality_Dimension_Dimension;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleSheets.Dimension)
		/// </summary>
		protected RMethod r_Equals_Dimension;
		public virtual RMethod REquals_Dimension
		{
			get
			{
				if(r_Equals_Dimension == null)
				{
					r_Equals_Dimension = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension"));
					r_Equals_Dimension.SetBelong(this.instance);
				}
				return r_Equals_Dimension;
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
            var ___result = RToLength.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual UnityEngine.UIElements.TimeValue ToTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToTime.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public virtual UnityEngine.UIElements.Angle ToAngle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToAngle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
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
