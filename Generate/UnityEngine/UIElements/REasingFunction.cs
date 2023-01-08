using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EasingFunction
	/// </summary>
    public partial class REasingFunction : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.EasingMode m_Mode
		/// </summary>
		protected RField r_m_Mode;
		public virtual RField Rm_Mode
		{
			get
			{
				if(r_m_Mode == null)
				{
					r_m_Mode = new(this, "m_Mode");
					r_m_Mode.SetBelong(this.instance);
				}
				return r_m_Mode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EasingMode mode
		/// </summary>
		protected RProperty r_mode;
		public virtual RProperty Rmode
		{
			get
			{
				if(r_mode == null)
				{
					r_mode = new(this, "mode", -1);
					r_mode.SetBelong(this.instance);
				}
				return r_mode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode)
		/// </summary>
		protected static RMethod r_op_Implicit_EasingMode;
		public static RMethod Rop_Implicit_EasingMode
		{
			get
			{
				if(r_op_Implicit_EasingMode == null)
				{
					r_op_Implicit_EasingMode = new(typeof(UnityEngine.UIElements.EasingFunction), "op_Implicit", 0, typeof(UnityEngine.UIElements.EasingMode));
					r_op_Implicit_EasingMode.SetBelong(null);
				}
				return r_op_Implicit_EasingMode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.EasingFunction, UnityEngine.UIElements.EasingFunction)
		/// </summary>
		protected static RMethod r_op_Equality_EasingFunction_EasingFunction;
		public static RMethod Rop_Equality_EasingFunction_EasingFunction
		{
			get
			{
				if(r_op_Equality_EasingFunction_EasingFunction == null)
				{
					r_op_Equality_EasingFunction_EasingFunction = new(typeof(UnityEngine.UIElements.EasingFunction), "op_Equality", 0, typeof(UnityEngine.UIElements.EasingFunction), typeof(UnityEngine.UIElements.EasingFunction));
					r_op_Equality_EasingFunction_EasingFunction.SetBelong(null);
				}
				return r_op_Equality_EasingFunction_EasingFunction;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.EasingFunction, UnityEngine.UIElements.EasingFunction)
		/// </summary>
		protected static RMethod r_op_Inequality_EasingFunction_EasingFunction;
		public static RMethod Rop_Inequality_EasingFunction_EasingFunction
		{
			get
			{
				if(r_op_Inequality_EasingFunction_EasingFunction == null)
				{
					r_op_Inequality_EasingFunction_EasingFunction = new(typeof(UnityEngine.UIElements.EasingFunction), "op_Inequality", 0, typeof(UnityEngine.UIElements.EasingFunction), typeof(UnityEngine.UIElements.EasingFunction));
					r_op_Inequality_EasingFunction_EasingFunction.SetBelong(null);
				}
				return r_op_Inequality_EasingFunction_EasingFunction;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.EasingFunction)
		/// </summary>
		protected RMethod r_Equals_EasingFunction;
		public virtual RMethod REquals_EasingFunction
		{
			get
			{
				if(r_Equals_EasingFunction == null)
				{
					r_Equals_EasingFunction = new(this, "Equals", 0, typeof(UnityEngine.UIElements.EasingFunction));
					r_Equals_EasingFunction.SetBelong(this.instance);
				}
				return r_Equals_EasingFunction;
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


        public REasingFunction() : base("UnityEngine.UIElements.EasingFunction")
        {
        }

        public REasingFunction(System.Object instance) : base("UnityEngine.UIElements.EasingFunction")
		{
            SetInstance(instance);
		}

        public REasingFunction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REasingFunction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode  @easingMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@easingMode};
            var ___result = Rop_Implicit_EasingMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.EasingFunction)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.EasingFunction  @lhs, UnityEngine.UIElements.EasingFunction  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_EasingFunction_EasingFunction.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.EasingFunction  @lhs, UnityEngine.UIElements.EasingFunction  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_EasingFunction_EasingFunction.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.EasingFunction  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_EasingFunction.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
