
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.UIntPtr
	/// </summary>
    public partial class RUIntPtr : RMember //
    {

		/// <summary>
		/// System.UIntPtr Zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUIntPtr r_FZero;
		public static Hvak.Editor.Refleaction.RSystem.RUIntPtr RFZero
		{
			get
			{
				if(r_FZero == null)
				{
					r_FZero = new(typeof(System.UIntPtr), "Zero");
					r_FZero.SetBelong(null);
				}
				return r_FZero;
			}
		}

		/// <summary>
		/// System.Void* _pointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> r_F_pointer;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> RF_pointer
		{
			get
			{
				if(r_F_pointer == null)
				{
					r_F_pointer = new(this, "_pointer");
					r_F_pointer.SetBelong(this.instance);
				}
				return r_F_pointer;
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
					r_PSize = new(typeof(System.UIntPtr), "Size", -1);
					r_PSize.SetBelong(null);
				}
				return r_PSize;
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
		/// UInt32 ToUInt32()
		/// </summary>
		protected RMethod r_MToUInt32;
		public virtual RMethod RMToUInt32
		{
			get
			{
				if(r_MToUInt32 == null)
				{
					r_MToUInt32 = new(this, "ToUInt32", 0);
					r_MToUInt32.SetBelong(this.instance);
				}
				return r_MToUInt32;
			}
		}

		/// <summary>
		/// UInt64 ToUInt64()
		/// </summary>
		protected RMethod r_MToUInt64;
		public virtual RMethod RMToUInt64
		{
			get
			{
				if(r_MToUInt64 == null)
				{
					r_MToUInt64 = new(this, "ToUInt64", 0);
					r_MToUInt64.SetBelong(this.instance);
				}
				return r_MToUInt64;
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
					r_MToPointer.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UIntPtr, UIntPtr)
		/// </summary>
		protected static RMethod r_Mop_Equality_UIntPtr_UIntPtr;
		public static RMethod RMop_Equality_UIntPtr_UIntPtr
		{
			get
			{
				if(r_Mop_Equality_UIntPtr_UIntPtr == null)
				{
					r_Mop_Equality_UIntPtr_UIntPtr = new(typeof(System.UIntPtr), "op_Equality", 0, typeof(System.UIntPtr), typeof(System.UIntPtr));
					r_Mop_Equality_UIntPtr_UIntPtr.SetBelong(null);
				}
				return r_Mop_Equality_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UIntPtr, UIntPtr)
		/// </summary>
		protected static RMethod r_Mop_Inequality_UIntPtr_UIntPtr;
		public static RMethod RMop_Inequality_UIntPtr_UIntPtr
		{
			get
			{
				if(r_Mop_Inequality_UIntPtr_UIntPtr == null)
				{
					r_Mop_Inequality_UIntPtr_UIntPtr = new(typeof(System.UIntPtr), "op_Inequality", 0, typeof(System.UIntPtr), typeof(System.UIntPtr));
					r_Mop_Inequality_UIntPtr_UIntPtr.SetBelong(null);
				}
				return r_Mop_Inequality_UIntPtr_UIntPtr;
			}
		}

		/// <summary>
		/// UInt64 op_Explicit(UIntPtr)
		/// </summary>
		protected static RMethod r_Mop_Explicit_UIntPtr;
		public static RMethod RMop_Explicit_UIntPtr
		{
			get
			{
				if(r_Mop_Explicit_UIntPtr == null)
				{
					r_Mop_Explicit_UIntPtr = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(System.UIntPtr));
					r_Mop_Explicit_UIntPtr.SetBelong(null);
				}
				return r_Mop_Explicit_UIntPtr;
			}
		}

		/// <summary>
		/// UIntPtr op_Explicit(UInt64)
		/// </summary>
		protected static RMethod r_Mop_Explicit_UInt64;
		public static RMethod RMop_Explicit_UInt64
		{
			get
			{
				if(r_Mop_Explicit_UInt64 == null)
				{
					r_Mop_Explicit_UInt64 = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(System.UInt64));
					r_Mop_Explicit_UInt64.SetBelong(null);
				}
				return r_Mop_Explicit_UInt64;
			}
		}

		/// <summary>
		/// UIntPtr op_Explicit(Void*)
		/// </summary>
		protected static RMethod r_Mop_Explicit_VoidPointer;
		public static RMethod RMop_Explicit_VoidPointer
		{
			get
			{
				if(r_Mop_Explicit_VoidPointer == null)
				{
					r_Mop_Explicit_VoidPointer = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(void).MakePointerType());
					r_Mop_Explicit_VoidPointer.SetBelong(null);
				}
				return r_Mop_Explicit_VoidPointer;
			}
		}

		/// <summary>
		/// UIntPtr op_Explicit(UInt32)
		/// </summary>
		protected static RMethod r_Mop_Explicit_UInt32;
		public static RMethod RMop_Explicit_UInt32
		{
			get
			{
				if(r_Mop_Explicit_UInt32 == null)
				{
					r_Mop_Explicit_UInt32 = new(typeof(System.UIntPtr), "op_Explicit", 0, typeof(System.UInt32));
					r_Mop_Explicit_UInt32.SetBelong(null);
				}
				return r_Mop_Explicit_UInt32;
			}
		}

		/// <summary>
		/// UIntPtr Add(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_MAdd_UIntPtr_Int32;
		public static RMethod RMAdd_UIntPtr_Int32
		{
			get
			{
				if(r_MAdd_UIntPtr_Int32 == null)
				{
					r_MAdd_UIntPtr_Int32 = new(typeof(System.UIntPtr), "Add", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_MAdd_UIntPtr_Int32.SetBelong(null);
				}
				return r_MAdd_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// UIntPtr Subtract(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_MSubtract_UIntPtr_Int32;
		public static RMethod RMSubtract_UIntPtr_Int32
		{
			get
			{
				if(r_MSubtract_UIntPtr_Int32 == null)
				{
					r_MSubtract_UIntPtr_Int32 = new(typeof(System.UIntPtr), "Subtract", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_MSubtract_UIntPtr_Int32.SetBelong(null);
				}
				return r_MSubtract_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// UIntPtr op_Addition(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_Mop_Addition_UIntPtr_Int32;
		public static RMethod RMop_Addition_UIntPtr_Int32
		{
			get
			{
				if(r_Mop_Addition_UIntPtr_Int32 == null)
				{
					r_Mop_Addition_UIntPtr_Int32 = new(typeof(System.UIntPtr), "op_Addition", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_Mop_Addition_UIntPtr_Int32.SetBelong(null);
				}
				return r_Mop_Addition_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// UIntPtr op_Subtraction(UIntPtr, Int32)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_UIntPtr_Int32;
		public static RMethod RMop_Subtraction_UIntPtr_Int32
		{
			get
			{
				if(r_Mop_Subtraction_UIntPtr_Int32 == null)
				{
					r_Mop_Subtraction_UIntPtr_Int32 = new(typeof(System.UIntPtr), "op_Subtraction", 0, typeof(System.UIntPtr), typeof(System.Int32));
					r_Mop_Subtraction_UIntPtr_Int32.SetBelong(null);
				}
				return r_Mop_Subtraction_UIntPtr_Int32;
			}
		}

		/// <summary>
		/// Boolean System.IEquatable<System.UIntPtr>.Equals(UIntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr;
		public virtual RMethod RMSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr
		{
			get
			{
				if(r_MSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr == null)
				{
					r_MSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr = new(this, "System.IEquatable<System.UIntPtr>.Equals", 0, typeof(System.UIntPtr));
					r_MSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr;
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


        public virtual System.UInt32 ToUInt32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToUInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt64 ToUInt64()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToUInt64.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
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

            return (System.String)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean op_Equality(System.UIntPtr @value1, System.UIntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RMop_Equality_UIntPtr_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.UIntPtr @value1, System.UIntPtr @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RMop_Inequality_UIntPtr_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.UInt64 op_Explicit(System.UIntPtr @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.UIntPtr op_Explicit(System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_UInt64.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public unsafe static System.UIntPtr op_Explicit(void* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(void))};
            var ___result = RMop_Explicit_VoidPointer.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr op_Explicit(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMop_Explicit_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr Add(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMAdd_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr Subtract(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMSubtract_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr op_Addition(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMop_Addition_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public static System.UIntPtr op_Subtraction(System.UIntPtr @pointer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointer, @offset};
            var ___result = RMop_Subtraction_UIntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UIntPtr)___result;
        }


        public virtual System.Boolean System__2__IEquatable__0__System__2__UIntPtr__1____2__Equals(System.UIntPtr @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMSystem__2__IEquatable__0__System__2__UIntPtr__1____2__Equals_UIntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
