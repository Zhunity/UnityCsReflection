
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ReadOnlyMemory`1
	/// </summary>
    public partial class RReadOnlyMemory<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.ReadOnlyMemory`1").MakeGenericType(typeof(T));
            }
        }

        public RReadOnlyMemory() : base("System.ReadOnlyMemory`1")
        {
        }

        public RReadOnlyMemory(System.Object instance) : base("System.ReadOnlyMemory`1")
		{
            SetInstance(instance);
		}

        public RReadOnlyMemory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadOnlyMemory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Object _object
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_object;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_object
		{
			get
			{
				if(r_F_object == null)
				{
					r_F_object = new(this, "_object");
				}
				return r_F_object;
			}
		}

		/// <summary>
		/// System.Int32 _index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_index
		{
			get
			{
				if(r_F_index == null)
				{
					r_F_index = new(this, "_index");
				}
				return r_F_index;
			}
		}

		/// <summary>
		/// System.Int32 _length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_length
		{
			get
			{
				if(r_F_length == null)
				{
					r_F_length = new(this, "_length");
				}
				return r_F_length;
			}
		}

		/// <summary>
		/// System.Int32 RemoveFlagsBitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FRemoveFlagsBitMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFRemoveFlagsBitMask
		{
			get
			{
				if(r_FRemoveFlagsBitMask == null)
				{
					r_FRemoveFlagsBitMask = new( ReflectionUtils.GetType("System.ReadOnlyMemory`1"), "RemoveFlagsBitMask");
				}
				return r_FRemoveFlagsBitMask;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReadOnlyMemory<Hvak.Editor.Refleaction.RProperty> r_PEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RReadOnlyMemory<Hvak.Editor.Refleaction.RProperty> RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new( ReflectionUtils.GetType("System.ReadOnlyMemory`1"), "Empty", -1);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// Boolean IsEmpty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsEmpty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsEmpty
		{
			get
			{
				if(r_PIsEmpty == null)
				{
					r_PIsEmpty = new(this, "IsEmpty", -1);
				}
				return r_PIsEmpty;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] Span
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RProperty> r_PSpan;
		public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RProperty> RPSpan
		{
			get
			{
				if(r_PSpan == null)
				{
					r_PSpan = new(this, "Span", -1);
				}
				return r_PSpan;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_Mop_Implicit_TArray;
		public static RMethod RMop_Implicit_TArray
		{
			get
			{
				if(r_Mop_Implicit_TArray == null)
				{
					r_Mop_Implicit_TArray = new( ReflectionUtils.GetType("System.ReadOnlyMemory`1"), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_Mop_Implicit_TArray;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] op_Implicit(System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Mop_Implicit_ArraySegment_d_T_p_;
		public static RMethod RMop_Implicit_ArraySegment_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_ArraySegment_d_T_p_ == null)
				{
					r_Mop_Implicit_ArraySegment_d_T_p_ = new( ReflectionUtils.GetType("System.ReadOnlyMemory`1"), "op_Implicit", 0,  ReflectionUtils.GetType("System.ArraySegment`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_Mop_Implicit_ArraySegment_d_T_p_;
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
		/// System.ReadOnlyMemory`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_MSlice_Int32;
		public virtual RMethod RMSlice_Int32
		{
			get
			{
				if(r_MSlice_Int32 == null)
				{
					r_MSlice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
				}
				return r_MSlice_Int32;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_MSlice_Int32_Int32;
		public virtual RMethod RMSlice_Int32_Int32
		{
			get
			{
				if(r_MSlice_Int32_Int32 == null)
				{
					r_MSlice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSlice_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Memory`1[T])
		/// </summary>
		protected RMethod r_MCopyTo_Memory_d_T_p_;
		public virtual RMethod RMCopyTo_Memory_d_T_p_
		{
			get
			{
				if(r_MCopyTo_Memory_d_T_p_ == null)
				{
					r_MCopyTo_Memory_d_T_p_ = new(this, "CopyTo", 0,  ReflectionUtils.GetType("System.Memory`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MCopyTo_Memory_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TryCopyTo(System.Memory`1[T])
		/// </summary>
		protected RMethod r_MTryCopyTo_Memory_d_T_p_;
		public virtual RMethod RMTryCopyTo_Memory_d_T_p_
		{
			get
			{
				if(r_MTryCopyTo_Memory_d_T_p_ == null)
				{
					r_MTryCopyTo_Memory_d_T_p_ = new(this, "TryCopyTo", 0,  ReflectionUtils.GetType("System.Memory`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MTryCopyTo_Memory_d_T_p_;
			}
		}

		/// <summary>
		/// System.Buffers.MemoryHandle Pin()
		/// </summary>
		protected RMethod r_MPin;
		public virtual RMethod RMPin
		{
			get
			{
				if(r_MPin == null)
				{
					r_MPin = new(this, "Pin", 0);
				}
				return r_MPin;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_MToArray;
		public virtual RMethod RMToArray
		{
			get
			{
				if(r_MToArray == null)
				{
					r_MToArray = new(this, "ToArray", 0);
				}
				return r_MToArray;
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
		/// Boolean Equals(System.ReadOnlyMemory`1[T])
		/// </summary>
		protected RMethod r_MEquals_ReadOnlyMemory_d_T_p_;
		public virtual RMethod RMEquals_ReadOnlyMemory_d_T_p_
		{
			get
			{
				if(r_MEquals_ReadOnlyMemory_d_T_p_ == null)
				{
					r_MEquals_ReadOnlyMemory_d_T_p_ = new(this, "Equals", 0,  ReflectionUtils.GetType("System.ReadOnlyMemory`1"));
				}
				return r_MEquals_ReadOnlyMemory_d_T_p_;
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
		/// Int32 CombineHashCodes(Int32, Int32)
		/// </summary>
		protected static RMethod r_MCombineHashCodes_Int32_Int32;
		public static RMethod RMCombineHashCodes_Int32_Int32
		{
			get
			{
				if(r_MCombineHashCodes_Int32_Int32 == null)
				{
					r_MCombineHashCodes_Int32_Int32 = new( ReflectionUtils.GetType("System.ReadOnlyMemory`1"), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCombineHashCodes_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 CombineHashCodes(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCombineHashCodes_Int32_Int32_Int32;
		public static RMethod RMCombineHashCodes_Int32_Int32_Int32
		{
			get
			{
				if(r_MCombineHashCodes_Int32_Int32_Int32 == null)
				{
					r_MCombineHashCodes_Int32_Int32_Int32 = new( ReflectionUtils.GetType("System.ReadOnlyMemory`1"), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCombineHashCodes_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Object GetObjectStartLength(Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MGetObjectStartLength_Out_Int32_Out_Int32;
		public virtual RMethod RMGetObjectStartLength_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MGetObjectStartLength_Out_Int32_Out_Int32 == null)
				{
					r_MGetObjectStartLength_Out_Int32_Out_Int32 = new(this, "GetObjectStartLength", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MGetObjectStartLength_Out_Int32_Out_Int32;
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


        public static System.ReadOnlyMemory<T> op_Implicit(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public static System.ReadOnlyMemory<T> op_Implicit(System.ArraySegment<T> @segment)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@segment};
            var ___result = RMop_Implicit_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.ReadOnlyMemory<T> Slice(System.Int32 @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RMSlice_Int32.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public virtual System.ReadOnlyMemory<T> Slice(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public virtual void CopyTo(System.Memory<T> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMCopyTo_Memory_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryCopyTo(System.Memory<T> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMTryCopyTo_Memory_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Buffers.MemoryHandle Pin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPin.Invoke(___genericsType, ___parameters);

            return (System.Buffers.MemoryHandle)___result;
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.ReadOnlyMemory<T> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_ReadOnlyMemory_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32 @left, System.Int32 @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMCombineHashCodes_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32 @h1, System.Int32 @h2, System.Int32 @h3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h1, @h2, @h3};
            var ___result = RMCombineHashCodes_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetObjectStartLength(out System.Int32 @start, out System.Int32 @length)
        {
			@start = default;
			@length = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMGetObjectStartLength_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@start = (System.Int32)___parameters[0];
			@length = (System.Int32)___parameters[1];

            return (System.Object)___result;
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
