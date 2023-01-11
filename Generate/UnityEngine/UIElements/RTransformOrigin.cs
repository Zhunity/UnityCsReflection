using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TransformOrigin
	/// </summary>
    public partial class RTransformOrigin : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Length m_X
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_m_X;
		public virtual RUnityEngine.RUIElements.RLength Rm_X
		{
			get
			{
				if(r_m_X == null)
				{
					r_m_X = new(this, "m_X");
					r_m_X.SetBelong(this.instance);
				}
				return r_m_X;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length m_Y
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_m_Y;
		public virtual RUnityEngine.RUIElements.RLength Rm_Y
		{
			get
			{
				if(r_m_Y == null)
				{
					r_m_Y = new(this, "m_Y");
					r_m_Y.SetBelong(this.instance);
				}
				return r_m_Y;
			}
		}

		/// <summary>
		/// System.Single m_Z
		/// </summary>
		protected RSystem.RSingle r_m_Z;
		public virtual RSystem.RSingle Rm_Z
		{
			get
			{
				if(r_m_Z == null)
				{
					r_m_Z = new(this, "m_Z");
					r_m_Z.SetBelong(this.instance);
				}
				return r_m_Z;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length x
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_x;
		public virtual RUnityEngine.RUIElements.RLength Rx
		{
			get
			{
				if(r_x == null)
				{
					r_x = new(this, "x", -1);
					r_x.SetBelong(this.instance);
				}
				return r_x;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length y
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_y;
		public virtual RUnityEngine.RUIElements.RLength Ry
		{
			get
			{
				if(r_y == null)
				{
					r_y = new(this, "y", -1);
					r_y.SetBelong(this.instance);
				}
				return r_y;
			}
		}

		/// <summary>
		/// Single z
		/// </summary>
		protected RSystem.RSingle r_z;
		public virtual RSystem.RSingle Rz
		{
			get
			{
				if(r_z == null)
				{
					r_z = new(this, "z", -1);
					r_z.SetBelong(this.instance);
				}
				return r_z;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin Initial()
		/// </summary>
		protected static RMethod r_Initial;
		public static RMethod RInitial
		{
			get
			{
				if(r_Initial == null)
				{
					r_Initial = new(typeof(UnityEngine.UIElements.TransformOrigin), "Initial", 0);
					r_Initial.SetBelong(null);
				}
				return r_Initial;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected static RMethod r_op_Equality_TransformOrigin_TransformOrigin;
		public static RMethod Rop_Equality_TransformOrigin_TransformOrigin
		{
			get
			{
				if(r_op_Equality_TransformOrigin_TransformOrigin == null)
				{
					r_op_Equality_TransformOrigin_TransformOrigin = new(typeof(UnityEngine.UIElements.TransformOrigin), "op_Equality", 0, typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin));
					r_op_Equality_TransformOrigin_TransformOrigin.SetBelong(null);
				}
				return r_op_Equality_TransformOrigin_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected static RMethod r_op_Inequality_TransformOrigin_TransformOrigin;
		public static RMethod Rop_Inequality_TransformOrigin_TransformOrigin
		{
			get
			{
				if(r_op_Inequality_TransformOrigin_TransformOrigin == null)
				{
					r_op_Inequality_TransformOrigin_TransformOrigin = new(typeof(UnityEngine.UIElements.TransformOrigin), "op_Inequality", 0, typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin));
					r_op_Inequality_TransformOrigin_TransformOrigin.SetBelong(null);
				}
				return r_op_Inequality_TransformOrigin_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected RMethod r_Equals_TransformOrigin;
		public virtual RMethod REquals_TransformOrigin
		{
			get
			{
				if(r_Equals_TransformOrigin == null)
				{
					r_Equals_TransformOrigin = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TransformOrigin));
					r_Equals_TransformOrigin.SetBelong(this.instance);
				}
				return r_Equals_TransformOrigin;
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


        public RTransformOrigin() : base("UnityEngine.UIElements.TransformOrigin")
        {
        }

        public RTransformOrigin(System.Object instance) : base("UnityEngine.UIElements.TransformOrigin")
		{
            SetInstance(instance);
		}

        public RTransformOrigin(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransformOrigin(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.TransformOrigin Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TransformOrigin @lhs, UnityEngine.UIElements.TransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_TransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin @lhs, UnityEngine.UIElements.TransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_TransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TransformOrigin @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_TransformOrigin.Invoke(___genericsType, ___parameters);

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
