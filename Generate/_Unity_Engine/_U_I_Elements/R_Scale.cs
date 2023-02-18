
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Scale
	/// </summary>
    public partial class RScale : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 m_Scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Scale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Scale
		{
			get
			{
				if(r_Fm_Scale == null)
				{
					r_Fm_Scale = new(this, "m_Scale");
					r_Fm_Scale.SetBelong(this.GetValue());
				}
				return r_Fm_Scale;
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
					r_Fm_IsNone.SetBelong(this.GetValue());
				}
				return r_Fm_IsNone;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.GetValue());
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale Initial()
		/// </summary>
		protected static RMethod r_MInitial;
		public static RMethod RMInitial
		{
			get
			{
				if(r_MInitial == null)
				{
					r_MInitial = new(typeof(UnityEngine.UIElements.Scale), "Initial", 0);
					r_MInitial.SetBelong(null);
				}
				return r_MInitial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale None()
		/// </summary>
		protected static RMethod r_MNone;
		public static RMethod RMNone
		{
			get
			{
				if(r_MNone == null)
				{
					r_MNone = new(typeof(UnityEngine.UIElements.Scale), "None", 0);
					r_MNone.SetBelong(null);
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
					r_MIsNone.SetBelong(this.GetValue());
				}
				return r_MIsNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale op_Implicit(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector2;
		public static RMethod RMop_Implicit_Vector2
		{
			get
			{
				if(r_Mop_Implicit_Vector2 == null)
				{
					r_Mop_Implicit_Vector2 = new(typeof(UnityEngine.UIElements.Scale), "op_Implicit", 0, typeof(UnityEngine.Vector2));
					r_Mop_Implicit_Vector2.SetBelong(null);
				}
				return r_Mop_Implicit_Vector2;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale)
		/// </summary>
		protected static RMethod r_Mop_Equality_Scale_Scale;
		public static RMethod RMop_Equality_Scale_Scale
		{
			get
			{
				if(r_Mop_Equality_Scale_Scale == null)
				{
					r_Mop_Equality_Scale_Scale = new(typeof(UnityEngine.UIElements.Scale), "op_Equality", 0, typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale));
					r_Mop_Equality_Scale_Scale.SetBelong(null);
				}
				return r_Mop_Equality_Scale_Scale;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Scale_Scale;
		public static RMethod RMop_Inequality_Scale_Scale
		{
			get
			{
				if(r_Mop_Inequality_Scale_Scale == null)
				{
					r_Mop_Inequality_Scale_Scale = new(typeof(UnityEngine.UIElements.Scale), "op_Inequality", 0, typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale));
					r_Mop_Inequality_Scale_Scale.SetBelong(null);
				}
				return r_Mop_Inequality_Scale_Scale;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Scale)
		/// </summary>
		protected RMethod r_MEquals_Scale;
		public virtual RMethod RMEquals_Scale
		{
			get
			{
				if(r_MEquals_Scale == null)
				{
					r_MEquals_Scale = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Scale));
					r_MEquals_Scale.SetBelong(this.GetValue());
				}
				return r_MEquals_Scale;
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
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public static UnityEngine.UIElements.Scale None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.Scale op_Implicit(UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMop_Implicit_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Scale @lhs, UnityEngine.UIElements.Scale @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Scale_Scale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Scale @lhs, UnityEngine.UIElements.Scale @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Scale_Scale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Scale @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Scale.Invoke(___genericsType, ___parameters);

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
