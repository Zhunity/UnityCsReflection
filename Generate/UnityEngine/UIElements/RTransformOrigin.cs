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
		protected RUnityEngine.RUIElements.RLength r_Fm_X;
		public virtual RUnityEngine.RUIElements.RLength RFm_X
		{
			get
			{
				if(r_Fm_X == null)
				{
					r_Fm_X = new(this, "m_X");
					r_Fm_X.SetBelong(this.instance);
				}
				return r_Fm_X;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length m_Y
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Fm_Y;
		public virtual RUnityEngine.RUIElements.RLength RFm_Y
		{
			get
			{
				if(r_Fm_Y == null)
				{
					r_Fm_Y = new(this, "m_Y");
					r_Fm_Y.SetBelong(this.instance);
				}
				return r_Fm_Y;
			}
		}

		/// <summary>
		/// System.Single m_Z
		/// </summary>
		protected RSystem.RSingle r_Fm_Z;
		public virtual RSystem.RSingle RFm_Z
		{
			get
			{
				if(r_Fm_Z == null)
				{
					r_Fm_Z = new(this, "m_Z");
					r_Fm_Z.SetBelong(this.instance);
				}
				return r_Fm_Z;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length x
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Px;
		public virtual RUnityEngine.RUIElements.RLength RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
					r_Px.SetBelong(this.instance);
				}
				return r_Px;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length y
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Py;
		public virtual RUnityEngine.RUIElements.RLength RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
					r_Py.SetBelong(this.instance);
				}
				return r_Py;
			}
		}

		/// <summary>
		/// Single z
		/// </summary>
		protected RSystem.RSingle r_Pz;
		public virtual RSystem.RSingle RPz
		{
			get
			{
				if(r_Pz == null)
				{
					r_Pz = new(this, "z", -1);
					r_Pz.SetBelong(this.instance);
				}
				return r_Pz;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin Initial()
		/// </summary>
		protected static RMethod r_MInitial;
		public static RMethod RMInitial
		{
			get
			{
				if(r_MInitial == null)
				{
					r_MInitial = new(typeof(UnityEngine.UIElements.TransformOrigin), "Initial", 0);
					r_MInitial.SetBelong(null);
				}
				return r_MInitial;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected static RMethod r_Mop_Equality_TransformOrigin_TransformOrigin;
		public static RMethod RMop_Equality_TransformOrigin_TransformOrigin
		{
			get
			{
				if(r_Mop_Equality_TransformOrigin_TransformOrigin == null)
				{
					r_Mop_Equality_TransformOrigin_TransformOrigin = new(typeof(UnityEngine.UIElements.TransformOrigin), "op_Equality", 0, typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin));
					r_Mop_Equality_TransformOrigin_TransformOrigin.SetBelong(null);
				}
				return r_Mop_Equality_TransformOrigin_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TransformOrigin_TransformOrigin;
		public static RMethod RMop_Inequality_TransformOrigin_TransformOrigin
		{
			get
			{
				if(r_Mop_Inequality_TransformOrigin_TransformOrigin == null)
				{
					r_Mop_Inequality_TransformOrigin_TransformOrigin = new(typeof(UnityEngine.UIElements.TransformOrigin), "op_Inequality", 0, typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin));
					r_Mop_Inequality_TransformOrigin_TransformOrigin.SetBelong(null);
				}
				return r_Mop_Inequality_TransformOrigin_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected RMethod r_MEquals_TransformOrigin;
		public virtual RMethod RMEquals_TransformOrigin
		{
			get
			{
				if(r_MEquals_TransformOrigin == null)
				{
					r_MEquals_TransformOrigin = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TransformOrigin));
					r_MEquals_TransformOrigin.SetBelong(this.instance);
				}
				return r_MEquals_TransformOrigin;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TransformOrigin @lhs, UnityEngine.UIElements.TransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_TransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin @lhs, UnityEngine.UIElements.TransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_TransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TransformOrigin @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_TransformOrigin.Invoke(___genericsType, ___parameters);

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
