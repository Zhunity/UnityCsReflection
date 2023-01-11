using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IntPtr
	/// </summary>
    public partial class RIntPtr : RMember //
    {

		/// <summary>
		/// System.Void* m_value
		/// </summary>
		protected RFieldPointer<RField> r_m_value;
		public virtual RFieldPointer<RField> Rm_value
		{
			get
			{
				if(r_m_value == null)
				{
					r_m_value = new(this, "m_value");
					r_m_value.SetBelong(this.instance);
				}
				return r_m_value;
			}
		}

		/// <summary>
		/// System.IntPtr Zero
		/// </summary>
		protected static RSystem.RIntPtr r_Zero;
		public static RSystem.RIntPtr RZero
		{
			get
			{
				if(r_Zero == null)
				{
					r_Zero = new(typeof(System.IntPtr), "Zero");
					r_Zero.SetBelong(null);
				}
				return r_Zero;
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
					r_Size = new(typeof(System.IntPtr), "Size", -1);
					r_Size.SetBelong(null);
				}
				return r_Size;
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
		/// Int32 ToInt32()
		/// </summary>
		protected RMethod r_ToInt32;
		public virtual RMethod RToInt32
		{
			get
			{
				if(r_ToInt32 == null)
				{
					r_ToInt32 = new(this, "ToInt32", 0);
					r_ToInt32.SetBelong(this.instance);
				}
				return r_ToInt32;
			}
		}

		/// <summary>
		/// Int64 ToInt64()
		/// </summary>
		protected RMethod r_ToInt64;
		public virtual RMethod RToInt64
		{
			get
			{
				if(r_ToInt64 == null)
				{
					r_ToInt64 = new(this, "ToInt64", 0);
					r_ToInt64.SetBelong(this.instance);
				}
				return r_ToInt64;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// Boolean op_Equality(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_op_Equality_IntPtr_IntPtr;
		public static RMethod Rop_Equality_IntPtr_IntPtr
		{
			get
			{
				if(r_op_Equality_IntPtr_IntPtr == null)
				{
					r_op_Equality_IntPtr_IntPtr = new(typeof(System.IntPtr), "op_Equality", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_op_Equality_IntPtr_IntPtr.SetBelong(null);
				}
				return r_op_Equality_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_op_Inequality_IntPtr_IntPtr;
		public static RMethod Rop_Inequality_IntPtr_IntPtr
		{
			get
			{
				if(r_op_Inequality_IntPtr_IntPtr == null)
				{
					r_op_Inequality_IntPtr_IntPtr = new(typeof(System.IntPtr), "op_Inequality", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_op_Inequality_IntPtr_IntPtr.SetBelong(null);
				}
				return r_op_Inequality_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(Int32)
		/// </summary>
		protected static RMethod r_op_Explicit_Int32;
		public static RMethod Rop_Explicit_Int32
		{
			get
			{
				if(r_op_Explicit_Int32 == null)
				{
					r_op_Explicit_Int32 = new(typeof(System.IntPtr), "op_Explicit", 0, typeof(System.Int32));
					r_op_Explicit_Int32.SetBelong(null);
				}
				return r_op_Explicit_Int32;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(Int64)
		/// </summary>
		protected static RMethod r_op_Explicit_Int64;
		public static RMethod Rop_Explicit_Int64
		{
			get
			{
				if(r_op_Explicit_Int64 == null)
				{
					r_op_Explicit_Int64 = new(typeof(System.IntPtr), "op_Explicit", 0, typeof(System.Int64));
					r_op_Explicit_Int64.SetBelong(null);
				}
				return r_op_Explicit_Int64;
			}
		}

		/// <summary>
		/// IntPtr op_Explicit(Void*)
		/// </summary>
		protected static RMethod r_op_Explicit_VoidPointer;
		public static RMethod Rop_Explicit_VoidPointer
		{
			get
			{
				if(r_op_Explicit_VoidPointer == null)
				{
					r_op_Explicit_VoidPointer = new(typeof(System.IntPtr), "op_Explicit", 0, typeof(void).MakePointerType());
					r_op_Explicit_VoidPointer.SetBelong(null);
				}
				return r_op_Explicit_VoidPointer;
			}
		}

		/// <summary>
		/// Int32 op_Explicit(IntPtr)
		/// </summary>
		protected static RMethod r_op_Explicit_IntPtr;
		public static RMethod Rop_Explicit_IntPtr
		{
			get
			{
				if(r_op_Explicit_IntPtr == null)
				{
					r_op_Explicit_IntPtr = new(typeof(System.IntPtr), "op_Explicit", 0, typeof(System.IntPtr));
					r_op_Explicit_IntPtr.SetBelong(null);
				}
				return r_op_Explicit_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Add(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_Add_IntPtr_Int32;
		public static RMethod RAdd_IntPtr_Int32
		{
			get
			{
				if(r_Add_IntPtr_Int32 == null)
				{
					r_Add_IntPtr_Int32 = new(typeof(System.IntPtr), "Add", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_Add_IntPtr_Int32.SetBelong(null);
				}
				return r_Add_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr Subtract(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_Subtract_IntPtr_Int32;
		public static RMethod RSubtract_IntPtr_Int32
		{
			get
			{
				if(r_Subtract_IntPtr_Int32 == null)
				{
					r_Subtract_IntPtr_Int32 = new(typeof(System.IntPtr), "Subtract", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_Subtract_IntPtr_Int32.SetBelong(null);
				}
				return r_Subtract_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr op_Addition(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_op_Addition_IntPtr_Int32;
		public static RMethod Rop_Addition_IntPtr_Int32
		{
			get
			{
				if(r_op_Addition_IntPtr_Int32 == null)
				{
					r_op_Addition_IntPtr_Int32 = new(typeof(System.IntPtr), "op_Addition", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_op_Addition_IntPtr_Int32.SetBelong(null);
				}
				return r_op_Addition_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr op_Subtraction(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_op_Subtraction_IntPtr_Int32;
		public static RMethod Rop_Subtraction_IntPtr_Int32
		{
			get
			{
				if(r_op_Subtraction_IntPtr_Int32 == null)
				{
					r_op_Subtraction_IntPtr_Int32 = new(typeof(System.IntPtr), "op_Subtraction", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_op_Subtraction_IntPtr_Int32.SetBelong(null);
				}
				return r_op_Subtraction_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNull()
		/// </summary>
		protected RMethod r_IsNull;
		public virtual RMethod RIsNull
		{
			get
			{
				if(r_IsNull == null)
				{
					r_IsNull = new(this, "IsNull", 0);
					r_IsNull.SetBelong(this.instance);
				}
				return r_IsNull;
			}
		}

		/// <summary>
		/// Boolean System.IEquatable<System.IntPtr>.Equals(IntPtr)
		/// </summary>
		protected RMethod r_System__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr;
		public virtual RMethod RSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr
		{
			get
			{
				if(r_System__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr == null)
				{
					r_System__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr = new(this, "System.IEquatable<System.IntPtr>.Equals", 0, typeof(System.IntPtr));
					r_System__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr;
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

        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Int32 ToInt32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 ToInt64()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToInt64.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
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


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean op_Equality(System.IntPtr @value1, System.IntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = Rop_Equality_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.IntPtr @value1, System.IntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = Rop_Inequality_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.IntPtr op_Explicit(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr op_Explicit(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_Int64.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public unsafe static System.IntPtr op_Explicit(void* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(void))};
            var ___result = Rop_Explicit_VoidPointer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Int32 op_Explicit(System.IntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rop_Explicit_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.IntPtr Add(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RAdd_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr Subtract(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RSubtract_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr op_Addition(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = Rop_Addition_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr op_Subtraction(System.IntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = Rop_Subtraction_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean IsNull()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNull.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__IEquatable__0__System__2__IntPtr__1____2__Equals(System.IntPtr @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSystem__2__IEquatable__0__System__2__IntPtr__1____2__Equals_IntPtr.Invoke(___genericsType, ___parameters);

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
