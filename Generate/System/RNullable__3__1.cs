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
		protected RSystem.RBoolean r_FhasValue;
		public virtual RSystem.RBoolean RFhasValue
		{
			get
			{
				if(r_FhasValue == null)
				{
					r_FhasValue = new(this, "hasValue");
					r_FhasValue.SetBelong(this.instance);
				}
				return r_FhasValue;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected RField r_Fvalue;
		public virtual RField RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
					r_Fvalue.SetBelong(this.instance);
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// Boolean HasValue
		/// </summary>
		protected RSystem.RBoolean r_PHasValue;
		public virtual RSystem.RBoolean RPHasValue
		{
			get
			{
				if(r_PHasValue == null)
				{
					r_PHasValue = new(this, "HasValue", -1);
					r_PHasValue.SetBelong(this.instance);
				}
				return r_PHasValue;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected RProperty r_PValue;
		public virtual RProperty RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
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
					r_MGetValueOrDefault.SetBelong(this.instance);
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
					r_MGetValueOrDefault_T.SetBelong(this.instance);
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
		/// System.Nullable`1[T] op_Implicit(T)
		/// </summary>
		protected static RMethod r_Mop_Implicit_T;
		public static RMethod RMop_Implicit_T
		{
			get
			{
				if(r_Mop_Implicit_T == null)
				{
					r_Mop_Implicit_T = new(typeof(System.Nullable<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0));
					r_Mop_Implicit_T.SetBelong(null);
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
					r_Mop_Explicit_Nullable_d_T_p_ = new(typeof(System.Nullable<>), "op_Explicit", 0, typeof(System.Nullable<>));
					r_Mop_Explicit_Nullable_d_T_p_.SetBelong(null);
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
					r_MBox_Nullable_d_T_p_ = new(typeof(System.Nullable<>), "Box", 0, typeof(System.Nullable<>));
					r_MBox_Nullable_d_T_p_.SetBelong(null);
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
					r_MUnbox_Object = new(typeof(System.Nullable<>), "Unbox", 0, typeof(System.Object));
					r_MUnbox_Object.SetBelong(null);
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
					r_MUnboxExact_Object = new(typeof(System.Nullable<>), "UnboxExact", 0, typeof(System.Object));
					r_MUnboxExact_Object.SetBelong(null);
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
            var ___result = RMGetValueOrDefault.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual RType GetValueOrDefault(RType @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue.Value};
            var ___result = RMGetValueOrDefault_T.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
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


        public static RSystem.RNullable<RType> op_Implicit(RType @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMop_Implicit_T.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RType>(___result);
        }


        public static RType op_Explicit(RSystem.RNullable<RType> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMop_Explicit_Nullable_d_T_p_.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public static System.Object Box(RSystem.RNullable<RType> @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o.Value};
            var ___result = RMBox_Nullable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static RSystem.RNullable<RType> Unbox(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMUnbox_Object.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RType>(___result);
        }


        public static RSystem.RNullable<RType> UnboxExact(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMUnboxExact_Object.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RType>(___result);
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
