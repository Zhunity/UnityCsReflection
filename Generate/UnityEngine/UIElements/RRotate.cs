using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Rotate
	/// </summary>
    public partial class RRotate : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Angle m_Angle
		/// </summary>
		protected RUnityEngine.RUIElements.RAngle r_m_Angle;
		public virtual RUnityEngine.RUIElements.RAngle Rm_Angle
		{
			get
			{
				if(r_m_Angle == null)
				{
					r_m_Angle = new(this, "m_Angle");
					r_m_Angle.SetBelong(this.instance);
				}
				return r_m_Angle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Axis
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Axis;
		public virtual RUnityEngine.RVector3 Rm_Axis
		{
			get
			{
				if(r_m_Axis == null)
				{
					r_m_Axis = new(this, "m_Axis");
					r_m_Axis.SetBelong(this.instance);
				}
				return r_m_Axis;
			}
		}

		/// <summary>
		/// System.Boolean m_IsNone
		/// </summary>
		protected RSystem.RBoolean r_m_IsNone;
		public virtual RSystem.RBoolean Rm_IsNone
		{
			get
			{
				if(r_m_IsNone == null)
				{
					r_m_IsNone = new(this, "m_IsNone");
					r_m_IsNone.SetBelong(this.instance);
				}
				return r_m_IsNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle angle
		/// </summary>
		protected RUnityEngine.RUIElements.RAngle r_angle;
		public virtual RUnityEngine.RUIElements.RAngle Rangle
		{
			get
			{
				if(r_angle == null)
				{
					r_angle = new(this, "angle", -1);
					r_angle.SetBelong(this.instance);
				}
				return r_angle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 axis
		/// </summary>
		protected RUnityEngine.RVector3 r_axis;
		public virtual RUnityEngine.RVector3 Raxis
		{
			get
			{
				if(r_axis == null)
				{
					r_axis = new(this, "axis", -1);
					r_axis.SetBelong(this.instance);
				}
				return r_axis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate Initial()
		/// </summary>
		protected static RMethod r_Initial;
		public static RMethod RInitial
		{
			get
			{
				if(r_Initial == null)
				{
					r_Initial = new(typeof(UnityEngine.UIElements.Rotate), "Initial", 0);
					r_Initial.SetBelong(null);
				}
				return r_Initial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate None()
		/// </summary>
		protected static RMethod r_None;
		public static RMethod RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new(typeof(UnityEngine.UIElements.Rotate), "None", 0);
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
		/// Boolean op_Equality(UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate)
		/// </summary>
		protected static RMethod r_op_Equality_Rotate_Rotate;
		public static RMethod Rop_Equality_Rotate_Rotate
		{
			get
			{
				if(r_op_Equality_Rotate_Rotate == null)
				{
					r_op_Equality_Rotate_Rotate = new(typeof(UnityEngine.UIElements.Rotate), "op_Equality", 0, typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate));
					r_op_Equality_Rotate_Rotate.SetBelong(null);
				}
				return r_op_Equality_Rotate_Rotate;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate)
		/// </summary>
		protected static RMethod r_op_Inequality_Rotate_Rotate;
		public static RMethod Rop_Inequality_Rotate_Rotate
		{
			get
			{
				if(r_op_Inequality_Rotate_Rotate == null)
				{
					r_op_Inequality_Rotate_Rotate = new(typeof(UnityEngine.UIElements.Rotate), "op_Inequality", 0, typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate));
					r_op_Inequality_Rotate_Rotate.SetBelong(null);
				}
				return r_op_Inequality_Rotate_Rotate;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Rotate)
		/// </summary>
		protected RMethod r_Equals_Rotate;
		public virtual RMethod REquals_Rotate
		{
			get
			{
				if(r_Equals_Rotate == null)
				{
					r_Equals_Rotate = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Rotate));
					r_Equals_Rotate.SetBelong(this.instance);
				}
				return r_Equals_Rotate;
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
		/// UnityEngine.Quaternion ToQuaternion()
		/// </summary>
		protected RMethod r_ToQuaternion;
		public virtual RMethod RToQuaternion
		{
			get
			{
				if(r_ToQuaternion == null)
				{
					r_ToQuaternion = new(this, "ToQuaternion", 0);
					r_ToQuaternion.SetBelong(this.instance);
				}
				return r_ToQuaternion;
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


        public RRotate() : base("UnityEngine.UIElements.Rotate")
        {
        }

        public RRotate(System.Object instance) : base("UnityEngine.UIElements.Rotate")
		{
            SetInstance(instance);
		}

        public RRotate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRotate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.Rotate Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public static UnityEngine.UIElements.Rotate None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Rotate @lhs, UnityEngine.UIElements.Rotate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Rotate_Rotate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Rotate @lhs, UnityEngine.UIElements.Rotate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Rotate_Rotate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Rotate @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Rotate.Invoke(___genericsType, ___parameters);

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


        public virtual UnityEngine.Quaternion ToQuaternion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToQuaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
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
