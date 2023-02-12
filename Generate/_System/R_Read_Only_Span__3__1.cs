
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
		protected SMFrame.Editor.Refleaction.RSystem.RByReference<SMFrame.Editor.Refleaction.RField> r_F_pointer;
		public virtual SMFrame.Editor.Refleaction.RSystem.RByReference<SMFrame.Editor.Refleaction.RField> RF_pointer
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
		/// System.Int32 _length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_length;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_length
		{
			get
			{
				if(r_F_length == null)
				{
					r_F_length = new(this, "_length");
					r_F_length.SetBelong(this.instance);
				}
				return r_F_length;
			}
		}

		/// <summary>
		/// T& Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual SMFrame.Editor.Refleaction.RProperty RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
					r_PLength.SetBelong(this.instance);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// Boolean IsEmpty
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsEmpty;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsEmpty
		{
			get
			{
				if(r_PIsEmpty == null)
				{
					r_PIsEmpty = new(this, "IsEmpty", -1);
					r_PIsEmpty.SetBelong(this.instance);
				}
				return r_PIsEmpty;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] Empty
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RProperty> r_PEmpty;
		public static SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RProperty> RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new(typeof(System.ReadOnlySpan<>), "Empty", -1);
					r_PEmpty.SetBelong(null);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// T& GetPinnableReference()
		/// </summary>
		protected RMethod r_MGetPinnableReference;
		public virtual RMethod RMGetPinnableReference
		{
			get
			{
				if(r_MGetPinnableReference == null)
				{
					r_MGetPinnableReference = new(this, "GetPinnableReference", 0);
					r_MGetPinnableReference.SetBelong(this.instance);
				}
				return r_MGetPinnableReference;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Span`1[T])
		/// </summary>
		protected RMethod r_MCopyTo_Span_d_T_p_;
		public virtual RMethod RMCopyTo_Span_d_T_p_
		{
			get
			{
				if(r_MCopyTo_Span_d_T_p_ == null)
				{
					r_MCopyTo_Span_d_T_p_ = new(this, "CopyTo", 0, typeof(System.Span<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MCopyTo_Span_d_T_p_.SetBelong(this.instance);
				}
				return r_MCopyTo_Span_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TryCopyTo(System.Span`1[T])
		/// </summary>
		protected RMethod r_MTryCopyTo_Span_d_T_p_;
		public virtual RMethod RMTryCopyTo_Span_d_T_p_
		{
			get
			{
				if(r_MTryCopyTo_Span_d_T_p_ == null)
				{
					r_MTryCopyTo_Span_d_T_p_ = new(this, "TryCopyTo", 0, typeof(System.Span<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MTryCopyTo_Span_d_T_p_.SetBelong(this.instance);
				}
				return r_MTryCopyTo_Span_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.ReadOnlySpan`1[T], System.ReadOnlySpan`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
		public static RMethod RMop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ == null)
				{
					r_Mop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Equality", 0, typeof(System.ReadOnlySpan<>), typeof(System.ReadOnlySpan<>));
					r_Mop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.SetBelong(null);
				}
				return r_Mop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
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
		/// System.ReadOnlySpan`1[T] Slice(Int32)
		/// </summary>
		protected RMethod r_MSlice_Int32;
		public virtual RMethod RMSlice_Int32
		{
			get
			{
				if(r_MSlice_Int32 == null)
				{
					r_MSlice_Int32 = new(this, "Slice", 0, typeof(System.Int32));
					r_MSlice_Int32.SetBelong(this.instance);
				}
				return r_MSlice_Int32;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] Slice(Int32, Int32)
		/// </summary>
		protected RMethod r_MSlice_Int32_Int32;
		public virtual RMethod RMSlice_Int32_Int32
		{
			get
			{
				if(r_MSlice_Int32_Int32 == null)
				{
					r_MSlice_Int32_Int32 = new(this, "Slice", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSlice_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSlice_Int32_Int32;
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
					r_MToArray.SetBelong(this.instance);
				}
				return r_MToArray;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.ReadOnlySpan`1[T], System.ReadOnlySpan`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
		public static RMethod RMop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ == null)
				{
					r_Mop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Inequality", 0, typeof(System.ReadOnlySpan<>), typeof(System.ReadOnlySpan<>));
					r_Mop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.SetBelong(null);
				}
				return r_Mop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_;
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
		/// System.ReadOnlySpan`1[T] op_Implicit(T[])
		/// </summary>
		protected static RMethod r_Mop_Implicit_TArray;
		public static RMethod RMop_Implicit_TArray
		{
			get
			{
				if(r_Mop_Implicit_TArray == null)
				{
					r_Mop_Implicit_TArray = new(typeof(System.ReadOnlySpan<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Mop_Implicit_TArray.SetBelong(null);
				}
				return r_Mop_Implicit_TArray;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] op_Implicit(System.ArraySegment`1[T])
		/// </summary>
		protected static RMethod r_Mop_Implicit_ArraySegment_d_T_p_;
		public static RMethod RMop_Implicit_ArraySegment_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_ArraySegment_d_T_p_ == null)
				{
					r_Mop_Implicit_ArraySegment_d_T_p_ = new(typeof(System.ReadOnlySpan<>), "op_Implicit", 0, typeof(System.ArraySegment<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Mop_Implicit_ArraySegment_d_T_p_.SetBelong(null);
				}
				return r_Mop_Implicit_ArraySegment_d_T_p_;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
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
            var ___result = RMGetPinnableReference.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void CopyTo(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RType> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value};
            var ___result = RMCopyTo_Span_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryCopyTo(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RType> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value};
            var ___result = RMTryCopyTo_Span_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> @left, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> Slice(System.Int32 @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RMSlice_Int32.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> Slice(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static System.Boolean op_Inequality(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> @left, SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_ReadOnlySpan_d_T_p__ReadOnlySpan_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> op_Implicit(T[] @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMop_Implicit_TArray.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public static SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType> op_Implicit(System.ArraySegment<T> @segment)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@segment};
            var ___result = RMop_Implicit_ArraySegment_d_T_p_.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RType>.REnumerator(___result);
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