
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.Translate
	/// </summary>
    public partial class RTranslate : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Translate);
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
		/// System.Boolean m_isNone
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isNone;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isNone
		{
			get
			{
				if(r_Fm_isNone == null)
				{
					r_Fm_isNone = new(this, "m_isNone");
				}
				return r_Fm_isNone;
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
		/// UnityEngine.UIElements.Translate None()
		/// </summary>
		protected static RMethod r_MNone;
		public static RMethod RMNone
		{
			get
			{
				if(r_MNone == null)
				{
					r_MNone = new(Type, "None", 0);
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
		/// Boolean op_Equality(UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate)
		/// </summary>
		protected static RMethod r_Mop_Equality_Translate_Translate;
		public static RMethod RMop_Equality_Translate_Translate
		{
			get
			{
				if(r_Mop_Equality_Translate_Translate == null)
				{
					r_Mop_Equality_Translate_Translate = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate));
				}
				return r_Mop_Equality_Translate_Translate;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Translate_Translate;
		public static RMethod RMop_Inequality_Translate_Translate
		{
			get
			{
				if(r_Mop_Inequality_Translate_Translate == null)
				{
					r_Mop_Inequality_Translate_Translate = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate));
				}
				return r_Mop_Inequality_Translate_Translate;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Translate)
		/// </summary>
		protected RMethod r_MEquals_Translate;
		public virtual RMethod RMEquals_Translate
		{
			get
			{
				if(r_MEquals_Translate == null)
				{
					r_MEquals_Translate = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Translate));
				}
				return r_MEquals_Translate;
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


        public static UnityEngine.UIElements.Translate None()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Translate>(___result);
        }


        public virtual System.Boolean IsNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Translate @lhs, UnityEngine.UIElements.Translate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Translate_Translate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Translate @lhs, UnityEngine.UIElements.Translate @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Translate_Translate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Translate @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Translate.Invoke(___genericsType, ___parameters);

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
