
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.IntPtr
	/// </summary>
    public partial class RIntPtr : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.IntPtr);
            }
        }

        public RIntPtr() : base("System.IntPtr")
        {
        }

        public RIntPtr(System.Object instance) : base("System.IntPtr")
		{
            SetInstance(instance);
		}

        public RIntPtr(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIntPtr(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Void* m_value
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> r_Fm_value;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> RFm_value
		{
			get
			{
				if(r_Fm_value == null)
				{
					r_Fm_value = new(this, "m_value");
				}
				return r_Fm_value;
			}
		}

		/// <summary>
		/// System.IntPtr Zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIntPtr r_FZero;
		public static Hvak.Editor.Refleaction.RSystem.RIntPtr RFZero
		{
			get
			{
				if(r_FZero == null)
				{
					r_FZero = new(Type, "Zero");
				}
				return r_FZero;
			}
		}

		/// <summary>
		/// Int32 Size
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPSize
		{
			get
			{
				if(r_PSize == null)
				{
					r_PSize = new(Type, "Size", -1);
				}
				return r_PSize;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
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
		/// Int32 ToInt32()
		/// </summary>
		protected RMethod r_MToInt32;
		public virtual RMethod RMToInt32
		{
			get
			{
				if(r_MToInt32 == null)
				{
					r_MToInt32 = new(this, "ToInt32", 0);
				}
				return r_MToInt32;
			}
		}

		/// <summary>
		/// Int64 ToInt64()
		/// </summary>
		protected RMethod r_MToInt64;
		public virtual RMethod RMToInt64
		{
			get
			{
				if(r_MToInt64 == null)
				{
					r_MToInt64 = new(this, "ToInt64", 0);
				}
				return r_MToInt64;
			}
		}

		/// <summary>
		/// Void* ToPointer()
		/// </summary>
		protected RMethod r_MToPointer;
		public virtual RMethod RMToPointer
		{
			get
			{
				if(r_MToPointer == null)
				{
					r_MToPointer = new(this, "ToPointer", 0);
				}
				return r_MToPointer;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// Boolean op_Equality(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Mop_Equality_IntPtr_IntPtr;
		public static RMethod RMop_Equality_IntPtr_IntPtr
		{
			get
			{
				if(r_Mop_Equality_IntPtr_IntPtr == null)
				{
					r_Mop_Equality_IntPtr_IntPtr = new(Type, "op_Equality", 0, typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_Mop_Equality_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Mop_Inequality_IntPtr_IntPtr;
		public static RMethod RMop_Inequality_IntPtr_IntPtr
		{
			get
			{
				if(r_Mop_Inequality_IntPtr_IntPtr == null)
				{
					r_Mop_Inequality_IntPtr_IntPtr = new(Type, "op_Inequality", 0, typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_Mop_Inequality_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(Int32)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Int32;
		public static RMethod RMop_Explicit_Int32
		{
			get
			{
				if(r_Mop_Explicit_Int32 == null)
				{
					r_Mop_Explicit_Int32 = new(Type, "op_Explicit", 0, typeof(System.Int32));
				}
				return r_Mop_Explicit_Int32;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(Int64)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Int64;
		public static RMethod RMop_Explicit_Int64
		{
			get
			{
				if(r_Mop_Explicit_Int64 == null)
				{
					r_Mop_Explicit_Int64 = new(Type, "op_Explicit", 0, typeof(System.Int64));
				}
				return r_Mop_Explicit_Int64;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(Void*)
		/// </summary>
		protected static RMethod r_Mop_Explicit_VoidPointer;
		public static RMethod RMop_Explicit_VoidPointer
		{
			get
			{
				if(r_Mop_Explicit_VoidPointer == null)
				{
					r_Mop_Explicit_VoidPointer = new(Type, "op_Explicit", 0, typeof(void).MakePointerType());
				}
				return r_Mop_Explicit_VoidPointer;
			}
		}

		/// <summary>
		/// Int32 op_Explicit(IntPtr)
		/// </summary>
		protected static RMethod r_Mop_Explicit_IntPtr;
		public static RMethod RMop_Explicit_IntPtr
		{
			get
			{
				if(r_Mop_Explicit_IntPtr == null)
				{
					r_Mop_Explicit_IntPtr = new(Type, "op_Explicit", 0, typeof(System.IntPtr));
				}
				return r_Mop_Explicit_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Add(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MAdd_IntPtr_Int32;
		public static RMethod RMAdd_IntPtr_Int32
		{
			get
			{
				if(r_MAdd_IntPtr_Int32 == null)
				{
					r_MAdd_IntPtr_Int32 = new(Type, "Add", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MAdd_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr Subtract(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MSubtract_IntPtr_Int32;
		public static RMethod RMSubtract_IntPtr_Int32
		{
			get
			{
				if(r_MSubtract_IntPtr_Int32 == null)
				{
					r_MSubtract_IntPtr_Int32 = new(Type, "Subtract", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MSubtract_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr op_Addition(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_Mop_Addition_IntPtr_Int32;
		public static RMethod RMop_Addition_IntPtr_Int32
		{
			get
			{
				if(r_Mop_Addition_IntPtr_Int32 == null)
				{
					r_Mop_Addition_IntPtr_Int32 = new(Type, "op_Addition", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_Mop_Addition_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr op_Subtraction(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_IntPtr_Int32;
		public static RMethod RMop_Subtraction_IntPtr_Int32
		{
			get
			{
				if(r_Mop_Subtraction_IntPtr_Int32 == null)
				{
					r_Mop_Subtraction_IntPtr_Int32 = new(Type, "op_Subtraction", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_Mop_Subtraction_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNull()
		/// </summary>
		protected RMethod r_MIsNull;
		public virtual RMethod RMIsNull
		{
			get
			{
				if(r_MIsNull == null)
				{
					r_MIsNull = new(this, "IsNull", 0);
				}
				return r_MIsNull;
			}
		}

		/// <summary>
		/// Boolean System.IEquatable<System.IntPtr>.Equals(IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr;
		public virtual RMethod RMSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr
		{
			get
			{
				if(r_MSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr == null)
				{
					r_MSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr = new(this, "System.IEquatable<System.IntPtr>.Equals", 0, typeof(System.IntPtr));
				}
				return r_MSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr;
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


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Int32 ToInt32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToInt32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int64 ToInt64()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToInt64.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public unsafe virtual void* ToPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToPointer.Invoke(___genericsType, ___parameters);

            return (void*)Pointer.Unbox(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Boolean op_Equality(System.IntPtr @value1, System.IntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RMop_Equality_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.IntPtr @value1, System.IntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RMop_Inequality_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.IntPtr op_Explicit(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.IntPtr op_Explicit(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_Int64.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public unsafe static System.IntPtr op_Explicit(void* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(void))};
            var ___result = RMop_Explicit_VoidPointer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.Int32 op_Explicit(System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.IntPtr Add(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMAdd_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.IntPtr Subtract(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMSubtract_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.IntPtr op_Addition(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMop_Addition_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.IntPtr op_Subtraction(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMop_Subtraction_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual System.Boolean IsNull()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNull.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean System__2__IEquatable__0__System__2__IntPtr__1____2__Equals(System.IntPtr @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
