
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.CustomStyleProperty`1
	/// </summary>
    public partial class RCustomStyleProperty<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RCustomStyleProperty() : base("UnityEngine.UIElements.CustomStyleProperty`1")
        {
        }

        public RCustomStyleProperty(System.Object instance) : base("UnityEngine.UIElements.CustomStyleProperty`1")
		{
            SetInstance(instance);
		}

        public RCustomStyleProperty(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomStyleProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__name__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__name__1__k__BackingField
		{
			get
			{
				if(r_F__0__name__1__k__BackingField == null)
				{
					r_F__0__name__1__k__BackingField = new(this, "<name>k__BackingField");
				}
				return r_F__0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
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
		/// Boolean Equals(UnityEngine.UIElements.CustomStyleProperty`1[T])
		/// </summary>
		protected RMethod r_MEquals_CustomStyleProperty_d_T_p_;
		public virtual RMethod RMEquals_CustomStyleProperty_d_T_p_
		{
			get
			{
				if(r_MEquals_CustomStyleProperty_d_T_p_ == null)
				{
					r_MEquals_CustomStyleProperty_d_T_p_ = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1"));
				}
				return r_MEquals_CustomStyleProperty_d_T_p_;
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
		/// Boolean op_Equality(UnityEngine.UIElements.CustomStyleProperty`1[T], UnityEngine.UIElements.CustomStyleProperty`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
		public static RMethod RMop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ == null)
				{
					r_Mop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1"),  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1"));
				}
				return r_Mop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.CustomStyleProperty`1[T], UnityEngine.UIElements.CustomStyleProperty`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
		public static RMethod RMop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ == null)
				{
					r_Mop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1"),  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1"));
				}
				return r_Mop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.CustomStyleProperty<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_CustomStyleProperty_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.CustomStyleProperty<T> @a, UnityEngine.UIElements.CustomStyleProperty<T> @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.CustomStyleProperty<T> @a, UnityEngine.UIElements.CustomStyleProperty<T> @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
