
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.TransformOrigin
	/// </summary>
    public partial class RTransformOrigin : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.TransformOrigin);
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


		/// <summary>
		/// UnityEngine.UIElements.Length m_X
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fm_X;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFm_X
		{
			get
			{
				if(r_Fm_X == null)
				{
					r_Fm_X = new(this, "m_X");
				}
				return r_Fm_X;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length m_Y
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fm_Y;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFm_Y
		{
			get
			{
				if(r_Fm_Y == null)
				{
					r_Fm_Y = new(this, "m_Y");
				}
				return r_Fm_Y;
			}
		}

		/// <summary>
		/// System.Single m_Z
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Z;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Z
		{
			get
			{
				if(r_Fm_Z == null)
				{
					r_Fm_Z = new(this, "m_Z");
				}
				return r_Fm_Z;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length x
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Px;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
				}
				return r_Px;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length y
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Py;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
				}
				return r_Py;
			}
		}

		/// <summary>
		/// Single z
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pz;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPz
		{
			get
			{
				if(r_Pz == null)
				{
					r_Pz = new(this, "z", -1);
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
					r_MInitial = new(Type, "Initial", 0);
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
					r_Mop_Equality_TransformOrigin_TransformOrigin = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin));
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
					r_Mop_Inequality_TransformOrigin_TransformOrigin = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin));
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


        public static UnityEngine.UIElements.TransformOrigin Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.TransformOrigin>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TransformOrigin @lhs, UnityEngine.UIElements.TransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_TransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin @lhs, UnityEngine.UIElements.TransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_TransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TransformOrigin @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_TransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
