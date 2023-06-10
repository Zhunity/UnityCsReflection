
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Rotate
	/// </summary>
    public partial class RRotate : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Rotate);
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


		/// <summary>
		/// UnityEngine.UIElements.Angle m_Angle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngle r_Fm_Angle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngle RFm_Angle
		{
			get
			{
				if(r_Fm_Angle == null)
				{
					r_Fm_Angle = new(this, "m_Angle");
				}
				return r_Fm_Angle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Axis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Axis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Axis
		{
			get
			{
				if(r_Fm_Axis == null)
				{
					r_Fm_Axis = new(this, "m_Axis");
				}
				return r_Fm_Axis;
			}
		}

		/// <summary>
		/// System.Boolean m_IsNone
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsNone;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsNone
		{
			get
			{
				if(r_Fm_IsNone == null)
				{
					r_Fm_IsNone = new(this, "m_IsNone");
				}
				return r_Fm_IsNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle angle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngle r_Pangle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAngle RPangle
		{
			get
			{
				if(r_Pangle == null)
				{
					r_Pangle = new(this, "angle", -1);
				}
				return r_Pangle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 axis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Paxis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPaxis
		{
			get
			{
				if(r_Paxis == null)
				{
					r_Paxis = new(this, "axis", -1);
				}
				return r_Paxis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate Initial()
		/// </summary>
		protected static RMethod r_MInitial;
		public static RMethod RMInitial
		{
			get
			{
				if(r_MInitial == null)
				{
					r_MInitial = new(typeof(UnityEngine.UIElements.Rotate), "Initial", 0);
				}
				return r_MInitial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate None()
		/// </summary>
		protected static RMethod r_MNone;
		public static RMethod RMNone
		{
			get
			{
				if(r_MNone == null)
				{
					r_MNone = new(typeof(UnityEngine.UIElements.Rotate), "None", 0);
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
		/// Boolean op_Equality(UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate)
		/// </summary>
		protected static RMethod r_Mop_Equality_Rotate_Rotate;
		public static RMethod RMop_Equality_Rotate_Rotate
		{
			get
			{
				if(r_Mop_Equality_Rotate_Rotate == null)
				{
					r_Mop_Equality_Rotate_Rotate = new(typeof(UnityEngine.UIElements.Rotate), "op_Equality", 0, typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate));
				}
				return r_Mop_Equality_Rotate_Rotate;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Rotate_Rotate;
		public static RMethod RMop_Inequality_Rotate_Rotate
		{
			get
			{
				if(r_Mop_Inequality_Rotate_Rotate == null)
				{
					r_Mop_Inequality_Rotate_Rotate = new(typeof(UnityEngine.UIElements.Rotate), "op_Inequality", 0, typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate));
				}
				return r_Mop_Inequality_Rotate_Rotate;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Rotate)
		/// </summary>
		protected RMethod r_MEquals_Rotate;
		public virtual RMethod RMEquals_Rotate
		{
			get
			{
				if(r_MEquals_Rotate == null)
				{
					r_MEquals_Rotate = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Rotate));
				}
				return r_MEquals_Rotate;
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
		/// UnityEngine.Quaternion ToQuaternion()
		/// </summary>
		protected RMethod r_MToQuaternion;
		public virtual RMethod RMToQuaternion
		{
			get
			{
				if(r_MToQuaternion == null)
				{
					r_MToQuaternion = new(this, "ToQuaternion", 0);
				}
				return r_MToQuaternion;
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


        public static UnityEngine.UIElements.Rotate Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public static UnityEngine.UIElements.Rotate None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Rotate @lhs, UnityEngine.UIElements.Rotate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Rotate_Rotate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Rotate @lhs, UnityEngine.UIElements.Rotate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Rotate_Rotate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Rotate @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Rotate.Invoke(___genericsType, ___parameters);

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


        public virtual UnityEngine.Quaternion ToQuaternion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToQuaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
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
