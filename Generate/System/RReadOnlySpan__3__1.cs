using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ReadOnlySpan`1
	/// </summary>
    public partial class RReadOnlySpan<T> : RMember //
    {

		/// <summary>
		/// System.ByReference`1[T] _pointer
		/// </summary>
		protected RSystem.RByReference<RField> r__pointer;
		public virtual RSystem.RByReference<RField> R_pointer
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
		/// T& Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
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
		/// System.ReadOnlySpan`1[T] Empty
		/// </summary>
		protected static RSystem.RReadOnlySpan<RProperty> r_Empty;
		public static RSystem.RReadOnlySpan<RProperty> REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.ReadOnlySpan<>), "Empty", -1);
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// T& GetPinnableReference()
		/// </summary>
		protected RMethod r_GetPinnableReference;
		public virtual RMethod RGetPinnableReference
		{
			get
			{
				if(r_GetPinnableReference == null)
				{
					r_GetPinnableReference = new(this, "GetPinnableReference", 0);
					r_GetPinnableReference.SetBelong(this.instance);
				}
				return r_GetPinnableReference;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Span`1[T])
		/// </summary>
		protected RMethod r_CopyTo_Span_d_T_p_;
		public virtual RMethod RCopyTo_Span_d_T_p_
		{
			get
			{
				if(r_CopyTo_Span_d_T_p_ == null)
				{
					r_CopyTo_Span_d_T_p_ = new(this, "CopyTo", 0, typeof(System.Span<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_CopyTo_Span_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyTo_Span_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TryCopyTo(System.Span`1[T])
		/// </summary>
		protected RMethod r_TryCopyTo_Span_d_T_p_;
		public virtual RMethod RTryCopyTo_Span_d_T_p_
		{
			get
			{
				if(r_TryCopyTo_Span_d_T_p_ == null)
				{
					r_TryCopyTo_Span_d_T_p_ = new(this, "TryCopyTo", 0, typeof(System.Span<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_TryCopyTo_Span_d_T_p_.SetBelong(this.instance);
				}
				return r_TryCopyTo_Span_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.ReadOnlySpan`1[T], System.ReadOnlySpan`1[T])
		/// </summary>
		protected static RMethod r_op_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
		public static RMethod Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_
		{
			get
			{
				if(r_op_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ == null)
				{
					r_op_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Equality", 0, typeof(System.ReadOnlySpan<>), typeof(System.ReadOnlySpan<>));
					r_op_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.SetBelong(null);
				}
				return r_op_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
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
		/// System.ReadOnlySpan`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_Slice_Int32;
		public virtual RMethod RSlice_Int32
		{
			get
			{
				if(r_Slice_Int32 == null)
				{
					r_Slice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
					r_Slice_Int32.SetBelong(this.instance);
				}
				return r_Slice_Int32;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_Slice_Int32_Int32;
		public virtual RMethod RSlice_Int32_Int32
		{
			get
			{
				if(r_Slice_Int32_Int32 == null)
				{
					r_Slice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
					r_Slice_Int32_Int32.SetBelong(this.instance);
				}
				return r_Slice_Int32_Int32;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_ToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_ToArray == null)
				{
					r_ToArray = new(this, "ToArray", 0);
					r_ToArray.SetBelong(this.instance);
				}
				return r_ToArray;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ReadOnlySpan`1[T], System.ReadOnlySpan`1[T])
		/// </summary>
		protected static RMethod r_op_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
		public static RMethod Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_
		{
			get
			{
				if(r_op_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ == null)
				{
					r_op_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Inequality", 0, typeof(System.ReadOnlySpan<>), typeof(System.ReadOnlySpan<>));
					r_op_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.SetBelong(null);
				}
				return r_op_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
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
		/// System.ReadOnlySpan`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_op_Implicit_TArray;
		public static RMethod Rop_Implicit_TArray
		{
			get
			{
				if(r_op_Implicit_TArray == null)
				{
					r_op_Implicit_TArray = new(typeof(System.ReadOnlySpan<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_op_Implicit_TArray.SetBelong(null);
				}
				return r_op_Implicit_TArray;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] op_Implicit(System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_op_Implicit_ArraySegment_d_T_p_;
		public static RMethod Rop_Implicit_ArraySegment_d_T_p_
		{
			get
			{
				if(r_op_Implicit_ArraySegment_d_T_p_ == null)
				{
					r_op_Implicit_ArraySegment_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Implicit", 0, typeof(System.ArraySegment<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_op_Implicit_ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_op_Implicit_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
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


        public RReadOnlySpan() : base("System.ReadOnlySpan`1")
        {
        }

        public RReadOnlySpan(System.Object instance) : base("System.ReadOnlySpan`1")
		{
            SetInstance(instance);
		}

        public RReadOnlySpan(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadOnlySpan(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual T GetPinnableReference()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPinnableReference.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }





        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object Slice(System.Int32  @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RSlice_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Slice(System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Object op_Implicit(T[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = Rop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object op_Implicit(System.ArraySegment<T>  @segment)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@segment};
            var ___result = Rop_Implicit_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

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
