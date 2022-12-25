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
		protected RMethod r_RGetPinnableReference;
		public virtual RMethod RGetPinnableReference
		{
			get
			{
				if(r_RGetPinnableReference == null)
				{
					r_RGetPinnableReference = new(this, "GetPinnableReference", 0);
					r_RGetPinnableReference.SetBelong(this.instance);
				}
				return r_RGetPinnableReference;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Span`1[T])
		/// </summary>
		protected RMethod r_RCopyTo_Span_d_T_p_;
		public virtual RMethod RCopyTo_Span_d_T_p_
		{
			get
			{
				if(r_RCopyTo_Span_d_T_p_ == null)
				{
					r_RCopyTo_Span_d_T_p_ = new(this, "CopyTo", 0, typeof(System.Span<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCopyTo_Span_d_T_p_.SetBelong(this.instance);
				}
				return r_RCopyTo_Span_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TryCopyTo(System.Span`1[T])
		/// </summary>
		protected RMethod r_RTryCopyTo_Span_d_T_p_;
		public virtual RMethod RTryCopyTo_Span_d_T_p_
		{
			get
			{
				if(r_RTryCopyTo_Span_d_T_p_ == null)
				{
					r_RTryCopyTo_Span_d_T_p_ = new(this, "TryCopyTo", 0, typeof(System.Span<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RTryCopyTo_Span_d_T_p_.SetBelong(this.instance);
				}
				return r_RTryCopyTo_Span_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.ReadOnlySpan`1[T], System.ReadOnlySpan`1[T])
		/// </summary>
		protected static RMethod r_Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
		public static RMethod Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_
		{
			get
			{
				if(r_Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ == null)
				{
					r_Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Equality", 0, typeof(System.ReadOnlySpan<>), typeof(System.ReadOnlySpan<>));
					r_Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.SetBelong(null);
				}
				return r_Rop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
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
		/// System.ReadOnlySpan`1[T] Slice(Int32)
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
		/// System.ReadOnlySpan`1[T] Slice(Int32, Int32)
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
		/// Boolean op_Inequality(System.ReadOnlySpan`1[T], System.ReadOnlySpan`1[T])
		/// </summary>
		protected static RMethod r_Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
		public static RMethod Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_
		{
			get
			{
				if(r_Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ == null)
				{
					r_Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Inequality", 0, typeof(System.ReadOnlySpan<>), typeof(System.ReadOnlySpan<>));
					r_Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.SetBelong(null);
				}
				return r_Rop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
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
		/// System.ReadOnlySpan`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_Rop_Implicit_TArray;
		public static RMethod Rop_Implicit_TArray
		{
			get
			{
				if(r_Rop_Implicit_TArray == null)
				{
					r_Rop_Implicit_TArray = new(typeof(System.ReadOnlySpan<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Rop_Implicit_TArray.SetBelong(null);
				}
				return r_Rop_Implicit_TArray;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] op_Implicit(System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Rop_Implicit_ArraySegment_d_T_p_;
		public static RMethod Rop_Implicit_ArraySegment_d_T_p_
		{
			get
			{
				if(r_Rop_Implicit_ArraySegment_d_T_p_ == null)
				{
					r_Rop_Implicit_ArraySegment_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Implicit", 0, typeof(System.ArraySegment<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Rop_Implicit_ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_Rop_Implicit_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
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
