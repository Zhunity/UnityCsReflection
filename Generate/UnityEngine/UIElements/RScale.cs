using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Scale
	/// </summary>
    public partial class RScale : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 m_Scale
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Scale;
		public virtual RUnityEngine.RVector3 Rm_Scale
		{
			get
			{
				if(r_m_Scale == null)
				{
					r_m_Scale = new(this, "m_Scale");
					r_m_Scale.SetBelong(this.instance);
				}
				return r_m_Scale;
			}
		}

		/// <summary>
		/// System.Boolean m_IsNone
		/// </summary>
		protected RField r_m_IsNone;
		public virtual RField Rm_IsNone
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
		/// UnityEngine.Vector3 value
		/// </summary>
		protected RUnityEngine.RVector3 r_value;
		public virtual RUnityEngine.RVector3 Rvalue
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
		/// UnityEngine.UIElements.Scale Initial()
		/// </summary>
		protected static RMethod r_RInitial;
		public static RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(typeof(UnityEngine.UIElements.Scale), "Initial", 0);
					r_RInitial.SetBelong(null);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale None()
		/// </summary>
		protected static RMethod r_RNone;
		public static RMethod RNone
		{
			get
			{
				if(r_RNone == null)
				{
					r_RNone = new(typeof(UnityEngine.UIElements.Scale), "None", 0);
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
		/// UnityEngine.UIElements.Scale op_Implicit(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector2;
		public static RMethod Rop_Implicit_Vector2
		{
			get
			{
				if(r_Rop_Implicit_Vector2 == null)
				{
					r_Rop_Implicit_Vector2 = new(typeof(UnityEngine.UIElements.Scale), "op_Implicit", 0, typeof(UnityEngine.Vector2));
					r_Rop_Implicit_Vector2.SetBelong(null);
				}
				return r_Rop_Implicit_Vector2;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale)
		/// </summary>
		protected static RMethod r_Rop_Equality_Scale_Scale;
		public static RMethod Rop_Equality_Scale_Scale
		{
			get
			{
				if(r_Rop_Equality_Scale_Scale == null)
				{
					r_Rop_Equality_Scale_Scale = new(typeof(UnityEngine.UIElements.Scale), "op_Equality", 0, typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale));
					r_Rop_Equality_Scale_Scale.SetBelong(null);
				}
				return r_Rop_Equality_Scale_Scale;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Scale_Scale;
		public static RMethod Rop_Inequality_Scale_Scale
		{
			get
			{
				if(r_Rop_Inequality_Scale_Scale == null)
				{
					r_Rop_Inequality_Scale_Scale = new(typeof(UnityEngine.UIElements.Scale), "op_Inequality", 0, typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale));
					r_Rop_Inequality_Scale_Scale.SetBelong(null);
				}
				return r_Rop_Inequality_Scale_Scale;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Scale)
		/// </summary>
		protected RMethod r_REquals_Scale;
		public virtual RMethod REquals_Scale
		{
			get
			{
				if(r_REquals_Scale == null)
				{
					r_REquals_Scale = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Scale));
					r_REquals_Scale.SetBelong(this.instance);
				}
				return r_REquals_Scale;
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


        public RScale() : base("UnityEngine.UIElements.Scale")
        {
        }

        public RScale(System.Object instance) : base("UnityEngine.UIElements.Scale")
		{
            SetInstance(instance);
		}

        public RScale(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScale(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.Scale Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public static UnityEngine.UIElements.Scale None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.Scale op_Implicit(UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = Rop_Implicit_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Scale  @lhs, UnityEngine.UIElements.Scale  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Scale_Scale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Scale  @lhs, UnityEngine.UIElements.Scale  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Scale_Scale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Scale  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Scale.Invoke(___genericsType, ___parameters);

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
