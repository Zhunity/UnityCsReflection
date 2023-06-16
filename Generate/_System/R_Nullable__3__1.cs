
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Nullable`1
	/// </summary>
    public partial class RNullable<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Nullable`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RNullable() : base("System.Nullable`1")
        {
        }

        public RNullable(System.Object instance) : base("System.Nullable`1")
		{
            SetInstance(instance);
		}

        public RNullable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNullable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean hasValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhasValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhasValue
		{
			get
			{
				if(r_FhasValue == null)
				{
					r_FhasValue = new(this, "hasValue");
				}
				return r_FhasValue;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RField RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// Boolean HasValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasValue
		{
			get
			{
				if(r_PHasValue == null)
				{
					r_PHasValue = new(this, "HasValue", -1);
				}
				return r_PHasValue;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PValue;
		public virtual Hvak.Editor.Refleaction.RProperty RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// T GetValueOrDefault()
		/// </summary>
		protected RMethod r_MGetValueOrDefault;
		public virtual RMethod RMGetValueOrDefault
		{
			get
			{
				if(r_MGetValueOrDefault == null)
				{
					r_MGetValueOrDefault = new(this, "GetValueOrDefault", 0);
				}
				return r_MGetValueOrDefault;
			}
		}

		/// <summary>
		/// T GetValueOrDefault(T)
		/// </summary>
		protected RMethod r_MGetValueOrDefault_T;
		public virtual RMethod RMGetValueOrDefault_T
		{
			get
			{
				if(r_MGetValueOrDefault_T == null)
				{
					r_MGetValueOrDefault_T = new(this, "GetValueOrDefault", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MGetValueOrDefault_T;
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
		/// System.Nullable`1[T] op_Implicit(T)
		/// </summary>
		protected static RMethod r_Mop_Implicit_T;
		public static RMethod RMop_Implicit_T
		{
			get
			{
				if(r_Mop_Implicit_T == null)
				{
					r_Mop_Implicit_T = new(Type, "op_Implicit", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_Mop_Implicit_T;
			}
		}

		/// <summary>
		/// T op_Explicit(System.Nullable`1[T])
		/// </summary>
		protected static RMethod r_Mop_Explicit_Nullable_d_T_p_;
		public static RMethod RMop_Explicit_Nullable_d_T_p_
		{
			get
			{
				if(r_Mop_Explicit_Nullable_d_T_p_ == null)
				{
					r_Mop_Explicit_Nullable_d_T_p_ = new(Type, "op_Explicit", 0,  ReflectionUtils.GetType("System.Nullable`1"));
				}
				return r_Mop_Explicit_Nullable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Object Box(System.Nullable`1[T])
		/// </summary>
		protected static RMethod r_MBox_Nullable_d_T_p_;
		public static RMethod RMBox_Nullable_d_T_p_
		{
			get
			{
				if(r_MBox_Nullable_d_T_p_ == null)
				{
					r_MBox_Nullable_d_T_p_ = new(Type, "Box", 0,  ReflectionUtils.GetType("System.Nullable`1"));
				}
				return r_MBox_Nullable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Nullable`1[T] Unbox(System.Object)
		/// </summary>
		protected static RMethod r_MUnbox_Object;
		public static RMethod RMUnbox_Object
		{
			get
			{
				if(r_MUnbox_Object == null)
				{
					r_MUnbox_Object = new(Type, "Unbox", 0, typeof(System.Object));
				}
				return r_MUnbox_Object;
			}
		}

		/// <summary>
		/// System.Nullable`1[T] UnboxExact(System.Object)
		/// </summary>
		protected static RMethod r_MUnboxExact_Object;
		public static RMethod RMUnboxExact_Object
		{
			get
			{
				if(r_MUnboxExact_Object == null)
				{
					r_MUnboxExact_Object = new(Type, "UnboxExact", 0, typeof(System.Object));
				}
				return r_MUnboxExact_Object;
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


        public virtual Hvak.Editor.Refleaction.RType GetValueOrDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValueOrDefault.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RType GetValueOrDefault(Hvak.Editor.Refleaction.RType @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue.Value};
            var ___result = RMGetValueOrDefault_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
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


        public static Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType> op_Implicit(Hvak.Editor.Refleaction.RType @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMop_Implicit_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public static Hvak.Editor.Refleaction.RType op_Explicit(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMop_Explicit_Nullable_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
        }


        public static System.Object Box(Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType> @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o.Value};
            var ___result = RMBox_Nullable_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType> Unbox(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMUnbox_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType> UnboxExact(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMUnboxExact_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RType>>(___result);
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
