
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.ValueType
	/// </summary>
    public partial class RValueType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.ValueType);
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


		/// <summary>
		/// Boolean InternalEquals(System.Object, System.Object, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_MInternalEquals_Object_Object_Out_ObjectArray;
		public static RMethod RMInternalEquals_Object_Object_Out_ObjectArray
		{
			get
			{
				if(r_MInternalEquals_Object_Object_Out_ObjectArray == null)
				{
					r_MInternalEquals_Object_Object_Out_ObjectArray = new(Type, "InternalEquals", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object).MakeArrayType().MakeByRefType());
				}
				return r_MInternalEquals_Object_Object_Out_ObjectArray;
			}
		}

		/// <summary>
		/// Boolean DefaultEquals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MDefaultEquals_Object_Object;
		public static RMethod RMDefaultEquals_Object_Object
		{
			get
			{
				if(r_MDefaultEquals_Object_Object == null)
				{
					r_MDefaultEquals_Object_Object = new(Type, "DefaultEquals", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MDefaultEquals_Object_Object;
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
		/// Int32 InternalGetHashCode(System.Object, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_MInternalGetHashCode_Object_Out_ObjectArray;
		public static RMethod RMInternalGetHashCode_Object_Out_ObjectArray
		{
			get
			{
				if(r_MInternalGetHashCode_Object_Out_ObjectArray == null)
				{
					r_MInternalGetHashCode_Object_Out_ObjectArray = new(Type, "InternalGetHashCode", 0, typeof(System.Object), typeof(System.Object).MakeArrayType().MakeByRefType());
				}
				return r_MInternalGetHashCode_Object_Out_ObjectArray;
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
		/// Int32 GetHashCodeOfPtr(IntPtr)
		/// </summary>
		protected static RMethod r_MGetHashCodeOfPtr_IntPtr;
		public static RMethod RMGetHashCodeOfPtr_IntPtr
		{
			get
			{
				if(r_MGetHashCodeOfPtr_IntPtr == null)
				{
					r_MGetHashCodeOfPtr_IntPtr = new(Type, "GetHashCodeOfPtr", 0, typeof(System.IntPtr));
				}
				return r_MGetHashCodeOfPtr_IntPtr;
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


        public static System.Boolean InternalEquals(System.Object @o1, System.Object @o2, out System.Object[] @fields)
        {
			@fields = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2, @fields};
            var ___result = RMInternalEquals_Object_Object_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			@fields = ReflectionUtils.Convert<System.Object[]>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean DefaultEquals(System.Object @o1, System.Object @o2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2};
            var ___result = RMDefaultEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 InternalGetHashCode(System.Object @o, out System.Object[] @fields)
        {
			@fields = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o, @fields};
            var ___result = RMInternalGetHashCode_Object_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			@fields = ReflectionUtils.Convert<System.Object[]>(___parameters[1]);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetHashCodeOfPtr(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMGetHashCodeOfPtr_IntPtr.Invoke(___genericsType, ___parameters);

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
