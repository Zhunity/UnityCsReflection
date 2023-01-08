using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ValueType
	/// </summary>
    public partial class RValueType : RMember //
    {

		/// <summary>
		/// Boolean InternalEquals(System.Object, System.Object, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_InternalEquals_Object_Object_Out_ObjectArray;
		public static RMethod RInternalEquals_Object_Object_Out_ObjectArray
		{
			get
			{
				if(r_InternalEquals_Object_Object_Out_ObjectArray == null)
				{
					r_InternalEquals_Object_Object_Out_ObjectArray = new(typeof(System.ValueType), "InternalEquals", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object).MakeArrayType().MakeByRefType());
					r_InternalEquals_Object_Object_Out_ObjectArray.SetBelong(null);
				}
				return r_InternalEquals_Object_Object_Out_ObjectArray;
			}
		}

		/// <summary>
		/// Boolean DefaultEquals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_DefaultEquals_Object_Object;
		public static RMethod RDefaultEquals_Object_Object
		{
			get
			{
				if(r_DefaultEquals_Object_Object == null)
				{
					r_DefaultEquals_Object_Object = new(typeof(System.ValueType), "DefaultEquals", 0, typeof(System.Object), typeof(System.Object));
					r_DefaultEquals_Object_Object.SetBelong(null);
				}
				return r_DefaultEquals_Object_Object;
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
		/// Int32 InternalGetHashCode(System.Object, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_InternalGetHashCode_Object_Out_ObjectArray;
		public static RMethod RInternalGetHashCode_Object_Out_ObjectArray
		{
			get
			{
				if(r_InternalGetHashCode_Object_Out_ObjectArray == null)
				{
					r_InternalGetHashCode_Object_Out_ObjectArray = new(typeof(System.ValueType), "InternalGetHashCode", 0, typeof(System.Object), typeof(System.Object).MakeArrayType().MakeByRefType());
					r_InternalGetHashCode_Object_Out_ObjectArray.SetBelong(null);
				}
				return r_InternalGetHashCode_Object_Out_ObjectArray;
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
		/// Int32 GetHashCodeOfPtr(IntPtr)
		/// </summary>
		protected static RMethod r_GetHashCodeOfPtr_IntPtr;
		public static RMethod RGetHashCodeOfPtr_IntPtr
		{
			get
			{
				if(r_GetHashCodeOfPtr_IntPtr == null)
				{
					r_GetHashCodeOfPtr_IntPtr = new(typeof(System.ValueType), "GetHashCodeOfPtr", 0, typeof(System.IntPtr));
					r_GetHashCodeOfPtr_IntPtr.SetBelong(null);
				}
				return r_GetHashCodeOfPtr_IntPtr;
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


        public RValueType() : base("System.ValueType")
        {
        }

        public RValueType(System.Object instance) : base("System.ValueType")
		{
            SetInstance(instance);
		}

        public RValueType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValueType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean InternalEquals(System.Object @o1, System.Object @o2, out System.Object[] @fields)
        {
			@fields = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2, @fields};
            var ___result = RInternalEquals_Object_Object_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			@fields = (System.Object[])___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean DefaultEquals(System.Object @o1, System.Object @o2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2};
            var ___result = RDefaultEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 InternalGetHashCode(System.Object @o, out System.Object[] @fields)
        {
			@fields = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o, @fields};
            var ___result = RInternalGetHashCode_Object_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			@fields = (System.Object[])___parameters[1];

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetHashCodeOfPtr(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RGetHashCodeOfPtr_IntPtr.Invoke(___genericsType, ___parameters);

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
