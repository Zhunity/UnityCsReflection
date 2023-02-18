
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EasingFunction
	/// </summary>
    public partial class REasingFunction : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.EasingMode m_Mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingMode r_Fm_Mode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingMode RFm_Mode
		{
			get
			{
				if(r_Fm_Mode == null)
				{
					r_Fm_Mode = new(this, "m_Mode");
					r_Fm_Mode.SetBelong(this.GetValue());
				}
				return r_Fm_Mode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EasingMode mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingMode r_Pmode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingMode RPmode
		{
			get
			{
				if(r_Pmode == null)
				{
					r_Pmode = new(this, "mode", -1);
					r_Pmode.SetBelong(this.GetValue());
				}
				return r_Pmode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode)
		/// </summary>
		protected static RMethod r_Mop_Implicit_EasingMode;
		public static RMethod RMop_Implicit_EasingMode
		{
			get
			{
				if(r_Mop_Implicit_EasingMode == null)
				{
					r_Mop_Implicit_EasingMode = new(typeof(UnityEngine.UIElements.EasingFunction), "op_Implicit", 0, typeof(UnityEngine.UIElements.EasingMode));
					r_Mop_Implicit_EasingMode.SetBelong(null);
				}
				return r_Mop_Implicit_EasingMode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.EasingFunction, UnityEngine.UIElements.EasingFunction)
		/// </summary>
		protected static RMethod r_Mop_Equality_EasingFunction_EasingFunction;
		public static RMethod RMop_Equality_EasingFunction_EasingFunction
		{
			get
			{
				if(r_Mop_Equality_EasingFunction_EasingFunction == null)
				{
					r_Mop_Equality_EasingFunction_EasingFunction = new(typeof(UnityEngine.UIElements.EasingFunction), "op_Equality", 0, typeof(UnityEngine.UIElements.EasingFunction), typeof(UnityEngine.UIElements.EasingFunction));
					r_Mop_Equality_EasingFunction_EasingFunction.SetBelong(null);
				}
				return r_Mop_Equality_EasingFunction_EasingFunction;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.EasingFunction, UnityEngine.UIElements.EasingFunction)
		/// </summary>
		protected static RMethod r_Mop_Inequality_EasingFunction_EasingFunction;
		public static RMethod RMop_Inequality_EasingFunction_EasingFunction
		{
			get
			{
				if(r_Mop_Inequality_EasingFunction_EasingFunction == null)
				{
					r_Mop_Inequality_EasingFunction_EasingFunction = new(typeof(UnityEngine.UIElements.EasingFunction), "op_Inequality", 0, typeof(UnityEngine.UIElements.EasingFunction), typeof(UnityEngine.UIElements.EasingFunction));
					r_Mop_Inequality_EasingFunction_EasingFunction.SetBelong(null);
				}
				return r_Mop_Inequality_EasingFunction_EasingFunction;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.EasingFunction)
		/// </summary>
		protected RMethod r_MEquals_EasingFunction;
		public virtual RMethod RMEquals_EasingFunction
		{
			get
			{
				if(r_MEquals_EasingFunction == null)
				{
					r_MEquals_EasingFunction = new(this, "Equals", 0, typeof(UnityEngine.UIElements.EasingFunction));
					r_MEquals_EasingFunction.SetBelong(this.GetValue());
				}
				return r_MEquals_EasingFunction;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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

        public static UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode @easingMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@easingMode};
            var ___result = RMop_Implicit_EasingMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.EasingFunction)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.EasingFunction @lhs, UnityEngine.UIElements.EasingFunction @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_EasingFunction_EasingFunction.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.EasingFunction @lhs, UnityEngine.UIElements.EasingFunction @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_EasingFunction_EasingFunction.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.EasingFunction @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_EasingFunction.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
