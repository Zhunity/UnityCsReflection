using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Nullable`1
	/// </summary>
    public partial class RNullable<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.Boolean hasValue
		/// </summary>
		protected RSystem.RBoolean r_hasValue;
		public virtual RSystem.RBoolean RhasValue
		{
			get
			{
				if(r_hasValue == null)
				{
					r_hasValue = new(this, "hasValue");
					r_hasValue.SetBelong(this.instance);
				}
				return r_hasValue;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// Boolean HasValue
		/// </summary>
		protected RSystem.RBoolean r_HasValue;
		public virtual RSystem.RBoolean RHasValue
		{
			get
			{
				if(r_HasValue == null)
				{
					r_HasValue = new(this, "HasValue", -1);
					r_HasValue.SetBelong(this.instance);
				}
				return r_HasValue;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// T GetValueOrDefault()
		/// </summary>
		protected RMethod r_GetValueOrDefault;
		public virtual RMethod RGetValueOrDefault
		{
			get
			{
				if(r_GetValueOrDefault == null)
				{
					r_GetValueOrDefault = new(this, "GetValueOrDefault", 0);
					r_GetValueOrDefault.SetBelong(this.instance);
				}
				return r_GetValueOrDefault;
			}
		}

		/// <summary>
		/// T GetValueOrDefault(T)
		/// </summary>
		protected RMethod r_GetValueOrDefault_T;
		public virtual RMethod RGetValueOrDefault_T
		{
			get
			{
				if(r_GetValueOrDefault_T == null)
				{
					r_GetValueOrDefault_T = new(this, "GetValueOrDefault", 0, Type.MakeGenericMethodParameter(0));
					r_GetValueOrDefault_T.SetBelong(this.instance);
				}
				return r_GetValueOrDefault_T;
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
		/// System.Nullable`1[T] op_Implicit(T)
		/// </summary>
		protected static RMethod r_op_Implicit_T;
		public static RMethod Rop_Implicit_T
		{
			get
			{
				if(r_op_Implicit_T == null)
				{
					r_op_Implicit_T = new(typeof(System.Nullable<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0));
					r_op_Implicit_T.SetBelong(null);
				}
				return r_op_Implicit_T;
			}
		}

		/// <summary>
		/// T op_Explicit(System.Nullable`1[T])
		/// </summary>
		protected static RMethod r_op_Explicit_Nullable_d_T_p_;
		public static RMethod Rop_Explicit_Nullable_d_T_p_
		{
			get
			{
				if(r_op_Explicit_Nullable_d_T_p_ == null)
				{
					r_op_Explicit_Nullable_d_T_p_ = new(typeof(System.Nullable<>), "op_Explicit", 0, typeof(System.Nullable<>));
					r_op_Explicit_Nullable_d_T_p_.SetBelong(null);
				}
				return r_op_Explicit_Nullable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Object Box(System.Nullable`1[T])
		/// </summary>
		protected static RMethod r_Box_Nullable_d_T_p_;
		public static RMethod RBox_Nullable_d_T_p_
		{
			get
			{
				if(r_Box_Nullable_d_T_p_ == null)
				{
					r_Box_Nullable_d_T_p_ = new(typeof(System.Nullable<>), "Box", 0, typeof(System.Nullable<>));
					r_Box_Nullable_d_T_p_.SetBelong(null);
				}
				return r_Box_Nullable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Nullable`1[T] Unbox(System.Object)
		/// </summary>
		protected static RMethod r_Unbox_Object;
		public static RMethod RUnbox_Object
		{
			get
			{
				if(r_Unbox_Object == null)
				{
					r_Unbox_Object = new(typeof(System.Nullable<>), "Unbox", 0, typeof(System.Object));
					r_Unbox_Object.SetBelong(null);
				}
				return r_Unbox_Object;
			}
		}

		/// <summary>
		/// System.Nullable`1[T] UnboxExact(System.Object)
		/// </summary>
		protected static RMethod r_UnboxExact_Object;
		public static RMethod RUnboxExact_Object
		{
			get
			{
				if(r_UnboxExact_Object == null)
				{
					r_UnboxExact_Object = new(typeof(System.Nullable<>), "UnboxExact", 0, typeof(System.Object));
					r_UnboxExact_Object.SetBelong(null);
				}
				return r_UnboxExact_Object;
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

        public virtual RType GetValueOrDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueOrDefault.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual RType GetValueOrDefault(RType @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue.Value};
            var ___result = RGetValueOrDefault_T.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
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


        public static RSystem.RNullable<RType> op_Implicit(RType @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = Rop_Implicit_T.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RType>(___result);
        }


        public static RType op_Explicit(RSystem.RNullable<RType> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = Rop_Explicit_Nullable_d_T_p_.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public static System.Object Box(RSystem.RNullable<RType> @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o.Value};
            var ___result = RBox_Nullable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static RSystem.RNullable<RType> Unbox(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RUnbox_Object.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RType>(___result);
        }


        public static RSystem.RNullable<RType> UnboxExact(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RUnboxExact_Object.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RType>(___result);
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
