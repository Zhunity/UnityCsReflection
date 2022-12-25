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
		protected static RMethod r_RDegrees_Single;
		public static RMethod RDegrees_Single
		{
			get
			{
				if(r_RDegrees_Single == null)
				{
					r_RDegrees_Single = new(typeof(UnityEngine.UIElements.Angle), "Degrees", 0, typeof(System.Single));
					r_RDegrees_Single.SetBelong(null);
				}
				return r_RDegrees_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Gradians(Single)
		/// </summary>
		protected static RMethod r_RGradians_Single;
		public static RMethod RGradians_Single
		{
			get
			{
				if(r_RGradians_Single == null)
				{
					r_RGradians_Single = new(typeof(UnityEngine.UIElements.Angle), "Gradians", 0, typeof(System.Single));
					r_RGradians_Single.SetBelong(null);
				}
				return r_RGradians_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Radians(Single)
		/// </summary>
		protected static RMethod r_RRadians_Single;
		public static RMethod RRadians_Single
		{
			get
			{
				if(r_RRadians_Single == null)
				{
					r_RRadians_Single = new(typeof(UnityEngine.UIElements.Angle), "Radians", 0, typeof(System.Single));
					r_RRadians_Single.SetBelong(null);
				}
				return r_RRadians_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Turns(Single)
		/// </summary>
		protected static RMethod r_RTurns_Single;
		public static RMethod RTurns_Single
		{
			get
			{
				if(r_RTurns_Single == null)
				{
					r_RTurns_Single = new(typeof(UnityEngine.UIElements.Angle), "Turns", 0, typeof(System.Single));
					r_RTurns_Single.SetBelong(null);
				}
				return r_RTurns_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle None()
		/// </summary>
		protected static RMethod r_RNone;
		public static RMethod RNone
		{
			get
			{
				if(r_RNone == null)
				{
					r_RNone = new(typeof(UnityEngine.UIElements.Angle), "None", 0);
					r_RNone.SetBelong(null);
				}
				return r_RNone;
			}
		}

		/// <summary>
		/// Boolean IsNone()
		/// </summary>
		protected RMethod r_RIsNone;
		public virtual RMethod RIsNone
		{
			get
			{
				if(r_RIsNone == null)
				{
					r_RIsNone = new(this, "IsNone", 0);
					r_RIsNone.SetBelong(this.instance);
				}
				return r_RIsNone;
			}
		}

		/// <summary>
		/// Single ToDegrees()
		/// </summary>
		protected RMethod r_RToDegrees;
		public virtual RMethod RToDegrees
		{
			get
			{
				if(r_RToDegrees == null)
				{
					r_RToDegrees = new(this, "ToDegrees", 0);
					r_RToDegrees.SetBelong(this.instance);
				}
				return r_RToDegrees;
			}
		}

		/// <summary>
		/// Single ToGradians()
		/// </summary>
		protected RMethod r_RToGradians;
		public virtual RMethod RToGradians
		{
			get
			{
				if(r_RToGradians == null)
				{
					r_RToGradians = new(this, "ToGradians", 0);
					r_RToGradians.SetBelong(this.instance);
				}
				return r_RToGradians;
			}
		}

		/// <summary>
		/// Single ToRadians()
		/// </summary>
		protected RMethod r_RToRadians;
		public virtual RMethod RToRadians
		{
			get
			{
				if(r_RToRadians == null)
				{
					r_RToRadians = new(this, "ToRadians", 0);
					r_RToRadians.SetBelong(this.instance);
				}
				return r_RToRadians;
			}
		}

		/// <summary>
		/// Single ToTurns()
		/// </summary>
		protected RMethod r_RToTurns;
		public virtual RMethod RToTurns
		{
			get
			{
				if(r_RToTurns == null)
				{
					r_RToTurns = new(this, "ToTurns", 0);
					r_RToTurns.SetBelong(this.instance);
				}
				return r_RToTurns;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_Rop_Implicit_Single == null)
				{
					r_Rop_Implicit_Single = new(typeof(UnityEngine.UIElements.Angle), "op_Implicit", 0, typeof(System.Single));
					r_Rop_Implicit_Single.SetBelong(null);
				}
				return r_Rop_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle)
		/// </summary>
		protected static RMethod r_Rop_Equality_Angle_Angle;
		public static RMethod Rop_Equality_Angle_Angle
		{
			get
			{
				if(r_Rop_Equality_Angle_Angle == null)
				{
					r_Rop_Equality_Angle_Angle = new(typeof(UnityEngine.UIElements.Angle), "op_Equality", 0, typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle));
					r_Rop_Equality_Angle_Angle.SetBelong(null);
				}
				return r_Rop_Equality_Angle_Angle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Angle_Angle;
		public static RMethod Rop_Inequality_Angle_Angle
		{
			get
			{
				if(r_Rop_Inequality_Angle_Angle == null)
				{
					r_Rop_Inequality_Angle_Angle = new(typeof(UnityEngine.UIElements.Angle), "op_Inequality", 0, typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle));
					r_Rop_Inequality_Angle_Angle.SetBelong(null);
				}
				return r_Rop_Inequality_Angle_Angle;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Angle)
		/// </summary>
		protected RMethod r_REquals_Angle;
		public virtual RMethod REquals_Angle
		{
			get
			{
				if(r_REquals_Angle == null)
				{
					r_REquals_Angle = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Angle));
					r_REquals_Angle.SetBelong(this.instance);
				}
				return r_REquals_Angle;
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
