using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ReadOnlyMemory`1
	/// </summary>
    public partial class RReadOnlyMemory<T> : RMember //
    {

		/// <summary>
		/// System.Object _object
		/// </summary>
		protected RSystem.RObject r__object;
		public virtual RSystem.RObject R_object
		{
			get
			{
				if(r__object == null)
				{
					r__object = new(this, "_object");
					r__object.SetBelong(this.instance);
				}
				return r__object;
			}
		}

		/// <summary>
		/// System.Int32 _index
		/// </summary>
		protected RField r__index;
		public virtual RField R_index
		{
			get
			{
				if(r__index == null)
				{
					r__index = new(this, "_index");
					r__index.SetBelong(this.instance);
				}
				return r__index;
			}
		}

		/// <summary>
		/// System.Int32 _length
		/// </summary>
		protected RField r__length;
		public virtual RField R_length
		{
			get
			{
				if(r__length == null)
				{
					r__length = new(this, "_length");
					r__length.SetBelong(this.instance);
				}
				return r__length;
			}
		}

		/// <summary>
		/// System.Int32 RemoveFlagsBitMask
		/// </summary>
		protected static RField r_RemoveFlagsBitMask;
		public static RField RemoveFlagsBitMask
		{
			get
			{
				if(r_RemoveFlagsBitMask == null)
				{
					r_RemoveFlagsBitMask = new(typeof(System.ReadOnlyMemory<>), "RemoveFlagsBitMask");
					r_RemoveFlagsBitMask.SetBelong(null);
				}
				return r_RemoveFlagsBitMask;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] Empty
		/// </summary>
		protected static RSystem.RReadOnlyMemory<RProperty> r_Empty;
		public static RSystem.RReadOnlyMemory<RProperty> REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.ReadOnlyMemory<>), "Empty", -1);
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// Boolean IsEmpty
		/// </summary>
		protected RProperty r_IsEmpty;
		public virtual RProperty RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", -1);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] Span
		/// </summary>
		protected RSystem.RReadOnlySpan<RProperty> r_Span;
		public virtual RSystem.RReadOnlySpan<RProperty> RSpan
		{
			get
			{
				if(r_Span == null)
				{
					r_Span = new(this, "Span", -1);
					r_Span.SetBelong(this.instance);
				}
				return r_Span;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_Rop_Implicit_TArray;
		public static RMethod Rop_Implicit_TArray
		{
			get
			{
				if(r_Rop_Implicit_TArray == null)
				{
					r_Rop_Implicit_TArray = new(typeof(System.ReadOnlyMemory<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Rop_Implicit_TArray.SetBelong(null);
				}
				return r_Rop_Implicit_TArray;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] op_Implicit(System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Rop_Implicit_ArraySegment_d_T_p_;
		public static RMethod Rop_Implicit_ArraySegment_d_T_p_
		{
			get
			{
				if(r_Rop_Implicit_ArraySegment_d_T_p_ == null)
				{
					r_Rop_Implicit_ArraySegment_d_T_p_ = new(typeof(System.ReadOnlyMemory<>), "op_Implicit", 0, typeof(System.ArraySegment<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Rop_Implicit_ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_Rop_Implicit_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_RSlice_Int32;
		public virtual RMethod RSlice_Int32
		{
			get
			{
				if(r_RSlice_Int32 == null)
				{
					r_RSlice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
					r_RSlice_Int32.SetBelong(this.instance);
				}
				return r_RSlice_Int32;
			}
		}

		/// <summary>
		/// System.ReadOnlyMemory`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_RSlice_Int32_Int32;
		public virtual RMethod RSlice_Int32_Int32
		{
			get
			{
				if(r_RSlice_Int32_Int32 == null)
				{
					r_RSlice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSlice_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSlice_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Memory`1[T])
		/// </summary>
		protected RMethod r_RCopyTo_Memory_d_T_p_;
		public virtual RMethod RCopyTo_Memory_d_T_p_
		{
			get
			{
				if(r_RCopyTo_Memory_d_T_p_ == null)
				{
					r_RCopyTo_Memory_d_T_p_ = new(this, "CopyTo", 0, typeof(System.Memory<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCopyTo_Memory_d_T_p_.SetBelong(this.instance);
				}
				return r_RCopyTo_Memory_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TryCopyTo(System.Memory`1[T])
		/// </summary>
		protected RMethod r_RTryCopyTo_Memory_d_T_p_;
		public virtual RMethod RTryCopyTo_Memory_d_T_p_
		{
			get
			{
				if(r_RTryCopyTo_Memory_d_T_p_ == null)
				{
					r_RTryCopyTo_Memory_d_T_p_ = new(this, "TryCopyTo", 0, typeof(System.Memory<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RTryCopyTo_Memory_d_T_p_.SetBelong(this.instance);
				}
				return r_RTryCopyTo_Memory_d_T_p_;
			}
		}

		/// <summary>
		/// System.Buffers.MemoryHandle Pin()
		/// </summary>
		protected RMethod r_RPin;
		public virtual RMethod RPin
		{
			get
			{
				if(r_RPin == null)
				{
					r_RPin = new(this, "Pin", 0);
					r_RPin.SetBelong(this.instance);
				}
				return r_RPin;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_RToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_RToArray == null)
				{
					r_RToArray = new(this, "ToArray", 0);
					r_RToArray.SetBelong(this.instance);
				}
				return r_RToArray;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.ReadOnlyMemory`1[T])
		/// </summary>
		protected RMethod r_REquals_ReadOnlyMemory_d_T_p_;
		public virtual RMethod REquals_ReadOnlyMemory_d_T_p_
		{
			get
			{
				if(r_REquals_ReadOnlyMemory_d_T_p_ == null)
				{
					r_REquals_ReadOnlyMemory_d_T_p_ = new(this, "Equals", 0, typeof(System.ReadOnlyMemory<>));
					r_REquals_ReadOnlyMemory_d_T_p_.SetBelong(this.instance);
				}
				return r_REquals_ReadOnlyMemory_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Int32 CombineHashCodes(Int32, Int32)
		/// </summary>
		protected static RMethod r_RCombineHashCodes_Int32_Int32;
		public static RMethod RCombineHashCodes_Int32_Int32
		{
			get
			{
				if(r_RCombineHashCodes_Int32_Int32 == null)
				{
					r_RCombineHashCodes_Int32_Int32 = new(typeof(System.ReadOnlyMemory<>), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32));
					r_RCombineHashCodes_Int32_Int32.SetBelong(null);
				}
				return r_RCombineHashCodes_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 CombineHashCodes(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_RCombineHashCodes_Int32_Int32_Int32;
		public static RMethod RCombineHashCodes_Int32_Int32_Int32
		{
			get
			{
				if(r_RCombineHashCodes_Int32_Int32_Int32 == null)
				{
					r_RCombineHashCodes_Int32_Int32_Int32 = new(typeof(System.ReadOnlyMemory<>), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RCombineHashCodes_Int32_Int32_Int32.SetBelong(null);
				}
				return r_RCombineHashCodes_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Object GetObjectStartLength(Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RGetObjectStartLength_Out_Int32_Out_Int32;
		public virtual RMethod RGetObjectStartLength_Out_Int32_Out_Int32
		{
			get
			{
				if(r_RGetObjectStartLength_Out_Int32_Out_Int32 == null)
				{
					r_RGetObjectStartLength_Out_Int32_Out_Int32 = new(this, "GetObjectStartLength", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RGetObjectStartLength_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RGetObjectStartLength_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public static System.ReadOnlyMemory<T> op_Implicit(T[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = Rop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public static System.ReadOnlyMemory<T> op_Implicit(System.ArraySegment<T>  @segment)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@segment};
            var ___result = Rop_Implicit_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.ReadOnlyMemory<T> Slice(System.Int32  @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RSlice_Int32.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public virtual System.ReadOnlyMemory<T> Slice(System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.ReadOnlyMemory<T>)___result;
        }


        public virtual void CopyTo(System.Memory<T>  @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyTo_Memory_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryCopyTo(System.Memory<T>  @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RTryCopyTo_Memory_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Buffers.MemoryHandle Pin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPin.Invoke(___genericsType, ___parameters);

            return (System.Buffers.MemoryHandle)___result;
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.ReadOnlyMemory<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ReadOnlyMemory_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32  @left, System.Int32  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RCombineHashCodes_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32  @h1, System.Int32  @h2, System.Int32  @h3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h1, @h2, @h3};
            var ___result = RCombineHashCodes_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetObjectStartLength(out System.Int32  @start, out System.Int32  @length)
        {
			start = default;
			length = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RGetObjectStartLength_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			start = (System.Int32)___parameters[0];
			length = (System.Int32)___parameters[1];

            return (System.Object)___result;
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
