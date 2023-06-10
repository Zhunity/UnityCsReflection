
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Angle
	/// </summary>
    public partial class RAngle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Angle);
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
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle+Unit m_Unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngle.RUnit r_Fm_Unit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngle.RUnit RFm_Unit
		{
			get
			{
				if(r_Fm_Unit == null)
				{
					r_Fm_Unit = new(this, "m_Unit");
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
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AngleUnit unit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngleUnit r_Punit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngleUnit RPunit
		{
			get
			{
				if(r_Punit == null)
				{
					r_Punit = new(this, "unit", -1);
				}
				return r_Punit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Degrees(Single)
		/// </summary>
		protected static RMethod r_MDegrees_Single;
		public static RMethod RMDegrees_Single
		{
			get
			{
				if(r_MDegrees_Single == null)
				{
					r_MDegrees_Single = new(typeof(UnityEngine.UIElements.Angle), "Degrees", 0, typeof(System.Single));
				}
				return r_MDegrees_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Gradians(Single)
		/// </summary>
		protected static RMethod r_MGradians_Single;
		public static RMethod RMGradians_Single
		{
			get
			{
				if(r_MGradians_Single == null)
				{
					r_MGradians_Single = new(typeof(UnityEngine.UIElements.Angle), "Gradians", 0, typeof(System.Single));
				}
				return r_MGradians_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Radians(Single)
		/// </summary>
		protected static RMethod r_MRadians_Single;
		public static RMethod RMRadians_Single
		{
			get
			{
				if(r_MRadians_Single == null)
				{
					r_MRadians_Single = new(typeof(UnityEngine.UIElements.Angle), "Radians", 0, typeof(System.Single));
				}
				return r_MRadians_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle Turns(Single)
		/// </summary>
		protected static RMethod r_MTurns_Single;
		public static RMethod RMTurns_Single
		{
			get
			{
				if(r_MTurns_Single == null)
				{
					r_MTurns_Single = new(typeof(UnityEngine.UIElements.Angle), "Turns", 0, typeof(System.Single));
				}
				return r_MTurns_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle None()
		/// </summary>
		protected static RMethod r_MNone;
		public static RMethod RMNone
		{
			get
			{
				if(r_MNone == null)
				{
					r_MNone = new(typeof(UnityEngine.UIElements.Angle), "None", 0);
				}
				return r_MNone;
			}
		}

		/// <summary>
		/// Boolean IsNone()
		/// </summary>
		protected RMethod r_MIsNone;
		public virtual RMethod RMIsNone
		{
			get
			{
				if(r_MIsNone == null)
				{
					r_MIsNone = new(this, "IsNone", 0);
				}
				return r_MIsNone;
			}
		}

		/// <summary>
		/// Single ToDegrees()
		/// </summary>
		protected RMethod r_MToDegrees;
		public virtual RMethod RMToDegrees
		{
			get
			{
				if(r_MToDegrees == null)
				{
					r_MToDegrees = new(this, "ToDegrees", 0);
				}
				return r_MToDegrees;
			}
		}

		/// <summary>
		/// Single ToGradians()
		/// </summary>
		protected RMethod r_MToGradians;
		public virtual RMethod RMToGradians
		{
			get
			{
				if(r_MToGradians == null)
				{
					r_MToGradians = new(this, "ToGradians", 0);
				}
				return r_MToGradians;
			}
		}

		/// <summary>
		/// Single ToRadians()
		/// </summary>
		protected RMethod r_MToRadians;
		public virtual RMethod RMToRadians
		{
			get
			{
				if(r_MToRadians == null)
				{
					r_MToRadians = new(this, "ToRadians", 0);
				}
				return r_MToRadians;
			}
		}

		/// <summary>
		/// Single ToTurns()
		/// </summary>
		protected RMethod r_MToTurns;
		public virtual RMethod RMToTurns
		{
			get
			{
				if(r_MToTurns == null)
				{
					r_MToTurns = new(this, "ToTurns", 0);
				}
				return r_MToTurns;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Single;
		public static RMethod RMop_Implicit_Single
		{
			get
			{
				if(r_Mop_Implicit_Single == null)
				{
					r_Mop_Implicit_Single = new(typeof(UnityEngine.UIElements.Angle), "op_Implicit", 0, typeof(System.Single));
				}
				return r_Mop_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle)
		/// </summary>
		protected static RMethod r_Mop_Equality_Angle_Angle;
		public static RMethod RMop_Equality_Angle_Angle
		{
			get
			{
				if(r_Mop_Equality_Angle_Angle == null)
				{
					r_Mop_Equality_Angle_Angle = new(typeof(UnityEngine.UIElements.Angle), "op_Equality", 0, typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle));
				}
				return r_Mop_Equality_Angle_Angle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Angle_Angle;
		public static RMethod RMop_Inequality_Angle_Angle
		{
			get
			{
				if(r_Mop_Inequality_Angle_Angle == null)
				{
					r_Mop_Inequality_Angle_Angle = new(typeof(UnityEngine.UIElements.Angle), "op_Inequality", 0, typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle));
				}
				return r_Mop_Inequality_Angle_Angle;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Angle)
		/// </summary>
		protected RMethod r_MEquals_Angle;
		public virtual RMethod RMEquals_Angle
		{
			get
			{
				if(r_MEquals_Angle == null)
				{
					r_MEquals_Angle = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Angle));
				}
				return r_MEquals_Angle;
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


        public static UnityEngine.UIElements.Angle Degrees(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMDegrees_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle Gradians(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMGradians_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle Radians(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMRadians_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle Turns(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMTurns_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.Angle None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single ToDegrees()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToDegrees.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToGradians()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToGradians.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToRadians()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToRadians.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToTurns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToTurns.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.UIElements.Angle op_Implicit(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Angle @lhs, UnityEngine.UIElements.Angle @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Angle_Angle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Angle @lhs, UnityEngine.UIElements.Angle @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Angle_Angle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Angle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Angle.Invoke(___genericsType, ___parameters);

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
