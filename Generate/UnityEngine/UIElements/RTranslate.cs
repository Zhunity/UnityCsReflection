using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Translate
	/// </summary>
    public partial class RTranslate : RMember //
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
		/// System.Boolean m_isNone
		/// </summary>
		protected RSystem.RBoolean r_m_isNone;
		public virtual RSystem.RBoolean Rm_isNone
		{
			get
			{
				if(r_m_isNone == null)
				{
					r_m_isNone = new(this, "m_isNone");
					r_m_isNone.SetBelong(this.instance);
				}
				return r_m_isNone;
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
		/// UnityEngine.UIElements.Translate None()
		/// </summary>
		protected static RMethod r_None;
		public static RMethod RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new(typeof(UnityEngine.UIElements.Translate), "None", 0);
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
		/// Boolean op_Equality(UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate)
		/// </summary>
		protected static RMethod r_op_Equality_Translate_Translate;
		public static RMethod Rop_Equality_Translate_Translate
		{
			get
			{
				if(r_op_Equality_Translate_Translate == null)
				{
					r_op_Equality_Translate_Translate = new(typeof(UnityEngine.UIElements.Translate), "op_Equality", 0, typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate));
					r_op_Equality_Translate_Translate.SetBelong(null);
				}
				return r_op_Equality_Translate_Translate;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate)
		/// </summary>
		protected static RMethod r_op_Inequality_Translate_Translate;
		public static RMethod Rop_Inequality_Translate_Translate
		{
			get
			{
				if(r_op_Inequality_Translate_Translate == null)
				{
					r_op_Inequality_Translate_Translate = new(typeof(UnityEngine.UIElements.Translate), "op_Inequality", 0, typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate));
					r_op_Inequality_Translate_Translate.SetBelong(null);
				}
				return r_op_Inequality_Translate_Translate;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Translate)
		/// </summary>
		protected RMethod r_Equals_Translate;
		public virtual RMethod REquals_Translate
		{
			get
			{
				if(r_Equals_Translate == null)
				{
					r_Equals_Translate = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Translate));
					r_Equals_Translate.SetBelong(this.instance);
				}
				return r_Equals_Translate;
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


        public RTranslate() : base("UnityEngine.UIElements.Translate")
        {
        }

        public RTranslate(System.Object instance) : base("UnityEngine.UIElements.Translate")
		{
            SetInstance(instance);
		}

        public RTranslate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTranslate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.Translate None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNone.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Translate)___result;
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Translate @lhs, UnityEngine.UIElements.Translate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Translate_Translate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Translate @lhs, UnityEngine.UIElements.Translate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Translate_Translate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Translate @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Translate.Invoke(___genericsType, ___parameters);

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
