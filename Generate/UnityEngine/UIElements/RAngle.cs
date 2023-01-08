using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Angle
	/// </summary>
    public partial class RAngle : RMember //
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
		/// UnityEngine.UIElements.Angle+Unit m_Unit
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
		/// UnityEngine.UIElements.AngleUnit unit
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
		/// UnityEngine.UIElements.Angle Degrees(Single)
		/// </summary>
		protected static RMethod r_Degrees_Single;
		public static RMethod RDegrees_Single
		{
			get
			{
				if(r_Degrees_Single == null)
				{
					r_Degrees_Single = new(typeof(UnityEngine.UIElements.Angle), "Degrees", 0, typeof(System.Single));
					r_Degrees_Single.SetBelong(null);
				}
				return r_Degrees_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Gradians(Single)
		/// </summary>
		protected static RMethod r_Gradians_Single;
		public static RMethod RGradians_Single
		{
			get
			{
				if(r_Gradians_Single == null)
				{
					r_Gradians_Single = new(typeof(UnityEngine.UIElements.Angle), "Gradians", 0, typeof(System.Single));
					r_Gradians_Single.SetBelong(null);
				}
				return r_Gradians_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Radians(Single)
		/// </summary>
		protected static RMethod r_Radians_Single;
		public static RMethod RRadians_Single
		{
			get
			{
				if(r_Radians_Single == null)
				{
					r_Radians_Single = new(typeof(UnityEngine.UIElements.Angle), "Radians", 0, typeof(System.Single));
					r_Radians_Single.SetBelong(null);
				}
				return r_Radians_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Turns(Single)
		/// </summary>
		protected static RMethod r_Turns_Single;
		public static RMethod RTurns_Single
		{
			get
			{
				if(r_Turns_Single == null)
				{
					r_Turns_Single = new(typeof(UnityEngine.UIElements.Angle), "Turns", 0, typeof(System.Single));
					r_Turns_Single.SetBelong(null);
				}
				return r_Turns_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle None()
		/// </summary>
		protected static RMethod r_None;
		public static RMethod RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new(typeof(UnityEngine.UIElements.Angle), "None", 0);
					r_None.SetBelong(null);
				}
				return r_None;
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
		/// Single ToDegrees()
		/// </summary>
		protected RMethod r_ToDegrees;
		public virtual RMethod RToDegrees
		{
			get
			{
				if(r_ToDegrees == null)
				{
					r_ToDegrees = new(this, "ToDegrees", 0);
					r_ToDegrees.SetBelong(this.instance);
				}
				return r_ToDegrees;
			}
		}

		/// <summary>
		/// Single ToGradians()
		/// </summary>
		protected RMethod r_ToGradians;
		public virtual RMethod RToGradians
		{
			get
			{
				if(r_ToGradians == null)
				{
					r_ToGradians = new(this, "ToGradians", 0);
					r_ToGradians.SetBelong(this.instance);
				}
				return r_ToGradians;
			}
		}

		/// <summary>
		/// Single ToRadians()
		/// </summary>
		protected RMethod r_ToRadians;
		public virtual RMethod RToRadians
		{
			get
			{
				if(r_ToRadians == null)
				{
					r_ToRadians = new(this, "ToRadians", 0);
					r_ToRadians.SetBelong(this.instance);
				}
				return r_ToRadians;
			}
		}

		/// <summary>
		/// Single ToTurns()
		/// </summary>
		protected RMethod r_ToTurns;
		public virtual RMethod RToTurns
		{
			get
			{
				if(r_ToTurns == null)
				{
					r_ToTurns = new(this, "ToTurns", 0);
					r_ToTurns.SetBelong(this.instance);
				}
				return r_ToTurns;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle op_Implicit(Single)
		/// </summary>
		protected static RMethod r_op_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_op_Implicit_Single == null)
				{
					r_op_Implicit_Single = new(typeof(UnityEngine.UIElements.Angle), "op_Implicit", 0, typeof(System.Single));
					r_op_Implicit_Single.SetBelong(null);
				}
				return r_op_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle)
		/// </summary>
		protected static RMethod r_op_Equality_Angle_Angle;
		public static RMethod Rop_Equality_Angle_Angle
		{
			get
			{
				if(r_op_Equality_Angle_Angle == null)
				{
					r_op_Equality_Angle_Angle = new(typeof(UnityEngine.UIElements.Angle), "op_Equality", 0, typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle));
					r_op_Equality_Angle_Angle.SetBelong(null);
				}
				return r_op_Equality_Angle_Angle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle)
		/// </summary>
		protected static RMethod r_op_Inequality_Angle_Angle;
		public static RMethod Rop_Inequality_Angle_Angle
		{
			get
			{
				if(r_op_Inequality_Angle_Angle == null)
				{
					r_op_Inequality_Angle_Angle = new(typeof(UnityEngine.UIElements.Angle), "op_Inequality", 0, typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle));
					r_op_Inequality_Angle_Angle.SetBelong(null);
				}
				return r_op_Inequality_Angle_Angle;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Angle)
		/// </summary>
		protected RMethod r_Equals_Angle;
		public virtual RMethod REquals_Angle
		{
			get
			{
				if(r_Equals_Angle == null)
				{
					r_Equals_Angle = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Angle));
					r_Equals_Angle.SetBelong(this.instance);
				}
				return r_Equals_Angle;
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


        public RAngle() : base("UnityEngine.UIElements.Angle")
        {
        }

        public RAngle(System.Object instance) : base("UnityEngine.UIElements.Angle")
		{
            SetInstance(instance);
		}

        public RAngle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAngle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.Angle Degrees(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RDegrees_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle Gradians(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RGradians_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle Radians(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RRadians_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle Turns(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RTurns_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single ToDegrees()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToDegrees.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToGradians()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToGradians.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToRadians()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToRadians.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToTurns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToTurns.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.UIElements.Angle op_Implicit(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Angle  @lhs, UnityEngine.UIElements.Angle  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Angle_Angle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Angle  @lhs, UnityEngine.UIElements.Angle  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Angle_Angle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Angle  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Angle.Invoke(___genericsType, ___parameters);

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
