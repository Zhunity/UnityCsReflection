using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.UIntPtr
	/// </summary>
    public partial class RUIntPtr : RMember //
    {

		/// <summary>
		/// System.UIntPtr Zero
		/// </summary>
		protected static RSystem.RUIntPtr r_Zero;
		public static RSystem.RUIntPtr RZero
		{
			get
			{
				if(r_Zero == null)
				{
					r_Zero = new(typeof(System.UIntPtr), "Zero");
					r_Zero.SetBelong(null);
				}
				return r_Zero;
			}
		}

		/// <summary>
		/// System.Void* _pointer
		/// </summary>
		protected RFieldPointer<RField> r__pointer;
		public virtual RFieldPointer<RField> R_pointer
		{
			get
			{
				if(r__pointer == null)
				{
					r__pointer = new(this, "_pointer");
					r__pointer.SetBelong(this.instance);
				}
				return r__pointer;
			}
		}

		/// <summary>
		/// Int32 Size
		/// </summary>
		protected static RSystem.RInt32 r_Size;
		public static RSystem.RInt32 RSize
		{
			get
			{
				if(r_Size == null)
				{
					r_Size = new(typeof(System.UIntPtr), "Size", -1);
					r_Size.SetBelong(null);
				}
				return r_Size;
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
		/// UInt32 ToUInt32()
		/// </summary>
		protected RMethod r_ToUInt32;
		public virtual RMethod RToUInt32
		{
			get
			{
				if(r_ToUInt32 == null)
				{
					r_ToUInt32 = new(this, "ToUInt32", 0);
					r_ToUInt32.SetBelong(this.instance);
				}
				return r_ToUInt32;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64()
		/// </summary>
		protected RMethod r_ToUInt64;
		public virtual RMethod RToUInt64
		{
			get
			{
				if(r_ToUInt64 == null)
				{
					r_ToUInt64 = new(this, "ToUInt64", 0);
					r_ToUInt64.SetBelong(this.instance);
				}
				return r_ToUInt64;
			}
		}

		/// <summary>
		/// Void* ToPointer()
		/// </summary>
		protected RMethod r_ToPointer;
		public virtual RMethod RToPointer
		{
			get
			{
				if(r_ToPointer == null)
				{
					r_ToPointer = new(this, "ToPointer", 0);
					r_ToPointer.SetBelong(this.instance);
				}
				return r_ToPointer;
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
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UIntPtr, UIntPtr)
		/// </summary>
		protected static RMethod r_op_Equality_UIntPtr_UIntPtr;
		public static RMethod Rop_Equality_UIntPtr_UIntPtr
		{
			get
			{
				if(r_op_Equality_UIntPtr_UIntPtr == null)
				{
					r_op_Equality_UIntPtr_UIntPtr = new(typeof(System.UIntPtr), "op_Equality", 0, typeof(System.UIntPtr), typeof(System.UIntPtr));
					r_op_Equality_UIntPtr_UIntPtr.SetBelong(null);
				}
				return r_op_Equality_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UIntPtr, UIntPtr)
		/// </summary>
		protected static RMethod r_op_Inequality_UIntPtr_UIntPtr;
		public static RMethod Rop_Inequality_UIntPtr_UIntPtr
		{
			get
			{
				if(r_op_Inequality_UIntPtr_UIntPtr == null)
				{
					r_op_Inequality_UIntPtr_UIntPtr = new(typeof(System.UIntPtr), "op_Inequality", 0, typeof(System.UIntPtr), typeof(System.UIntPtr));
					r_op_Inequality_UIntPtr_UIntPtr.SetBelong(null);
				}
				return r_op_Inequality_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// UInt64 op_Explicit(UIntPtr)
		/// </summary>
		protected static RMethod r_op_Explicit_UIntPtr;
		public static RMethod Rop_Explicit_UIntPtr
		{
			get
			{
				if(r_op_Explicit_UIntPtr == null)
				{
					r_op_Explicit_UIntPtr = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(System.UIntPtr));
					r_op_Explicit_UIntPtr.SetBelong(null);
				}
				return r_op_Explicit_UIntPtr;
			}
		}

		/// <summary>
		/// UIntPtr op_Explicit(UInt64)
		/// </summary>
		protected static RMethod r_op_Explicit_UInt64;
		public static RMethod Rop_Explicit_UInt64
		{
			get
			{
				if(r_op_Explicit_UInt64 == null)
				{
					r_op_Explicit_UInt64 = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(System.UInt64));
					r_op_Explicit_UInt64.SetBelong(null);
				}
				return r_op_Explicit_UInt64;
			}
		}

		/// <summary>
		/// UIntPtr op_Explicit(Void*)
		/// </summary>
		protected static RMethod r_op_Explicit_VoidPointer;
		public static RMethod Rop_Explicit_VoidPointer
		{
			get
			{
				if(r_op_Explicit_VoidPointer == null)
				{
					r_op_Explicit_VoidPointer = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(void).MakePointerType());
					r_op_Explicit_VoidPointer.SetBelong(null);
				}
				return r_op_Explicit_VoidPointer;
			}
		}

		/// <summary>
		/// UIntPtr op_Explicit(UInt32)
		/// </summary>
		protected static RMethod r_op_Explicit_UInt32;
		public static RMethod Rop_Explicit_UInt32
		{
			get
			{
				if(r_op_Explicit_UInt32 == null)
				{
					r_op_Explicit_UInt32 = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(System.UInt32));
					r_op_Explicit_UInt32.SetBelong(null);
				}
				return r_op_Explicit_UInt32;
			}
		}

		/// <summary>
		/// UIntPtr Add(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_Add_UIntPtr_Int32;
		public static RMethod RAdd_UIntPtr_Int32
		{
			get
			{
				if(r_Add_UIntPtr_Int32 == null)
				{
					r_Add_UIntPtr_Int32 = new(typeof(System.UIntPtr), "Add", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_Add_UIntPtr_Int32.SetBelong(null);
				}
				return r_Add_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// UIntPtr Subtract(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_Subtract_UIntPtr_Int32;
		public static RMethod RSubtract_UIntPtr_Int32
		{
			get
			{
				if(r_Subtract_UIntPtr_Int32 == null)
				{
					r_Subtract_UIntPtr_Int32 = new(typeof(System.UIntPtr), "Subtract", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_Subtract_UIntPtr_Int32.SetBelong(null);
				}
				return r_Subtract_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// UIntPtr op_Addition(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_op_Addition_UIntPtr_Int32;
		public static RMethod Rop_Addition_UIntPtr_Int32
		{
			get
			{
				if(r_op_Addition_UIntPtr_Int32 == null)
				{
					r_op_Addition_UIntPtr_Int32 = new(typeof(System.UIntPtr), "op_Addition", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_op_Addition_UIntPtr_Int32.SetBelong(null);
				}
				return r_op_Addition_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// UIntPtr op_Subtraction(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_op_Subtraction_UIntPtr_Int32;
		public static RMethod Rop_Subtraction_UIntPtr_Int32
		{
			get
			{
				if(r_op_Subtraction_UIntPtr_Int32 == null)
				{
					r_op_Subtraction_UIntPtr_Int32 = new(typeof(System.UIntPtr), "op_Subtraction", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_op_Subtraction_UIntPtr_Int32.SetBelong(null);
				}
				return r_op_Subtraction_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// Boolean System.IEquatable<System.UIntPtr>.Equals(UIntPtr)
		/// </summary>
		protected RMethod r_System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr;
		public virtual RMethod RSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr
		{
			get
			{
				if(r_System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr == null)
				{
					r_System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr = new(this, "System.IEquatable<System.UIntPtr>.Equals", 0, typeof(System.UIntPtr));
					r_System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr.SetBelong(this.instance);
				}
				return r_System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr;
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


        public RUIntPtr() : base("System.UIntPtr")
        {
        }

        public RUIntPtr(System.Object instance) : base("System.UIntPtr")
		{
            SetInstance(instance);
		}

        public RUIntPtr(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIntPtr(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
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


        public virtual System.UInt32 ToUInt32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt64 ToUInt64()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUInt64.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public unsafe virtual void* ToPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToPointer.Invoke(___genericsType, ___parameters);

            return (void*)Pointer.Unbox(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean op_Equality(System.UIntPtr @value1, System.UIntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = Rop_Equality_UIntPtr_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.UIntPtr @value1, System.UIntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = Rop_Inequality_UIntPtr_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.UInt64 op_Explicit(System.UIntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.UIntPtr op_Explicit(System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_UInt64.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public unsafe static System.UIntPtr op_Explicit(void* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(void))};
            var ___result = Rop_Explicit_VoidPointer.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr op_Explicit(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr Add(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RAdd_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr Subtract(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RSubtract_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr op_Addition(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = Rop_Addition_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr op_Subtraction(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = Rop_Subtraction_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public virtual System.Boolean System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals(System.UIntPtr @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
