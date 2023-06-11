
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RCollections
{
	/// <summary>
	/// Unity.Collections.NativeSlice`1
	/// </summary>
    public partial class RNativeSlice<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(T));
            }
        }

        public RNativeSlice() : base("Unity.Collections.NativeSlice`1")
        {
        }

        public RNativeSlice(System.Object instance) : base("Unity.Collections.NativeSlice`1")
		{
            SetInstance(instance);
		}

        public RNativeSlice(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNativeSlice(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Byte* m_Buffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RByte> r_Fm_Buffer;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RByte> RFm_Buffer
		{
			get
			{
				if(r_Fm_Buffer == null)
				{
					r_Fm_Buffer = new(this, "m_Buffer");
				}
				return r_Fm_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Stride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Stride;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Stride
		{
			get
			{
				if(r_Fm_Stride == null)
				{
					r_Fm_Stride = new(this, "m_Stride");
				}
				return r_Fm_Stride;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Length
		{
			get
			{
				if(r_Fm_Length == null)
				{
					r_Fm_Length = new(this, "m_Length");
				}
				return r_Fm_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MinIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MinIndex
		{
			get
			{
				if(r_Fm_MinIndex == null)
				{
					r_Fm_MinIndex = new(this, "m_MinIndex");
				}
				return r_Fm_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaxIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaxIndex
		{
			get
			{
				if(r_Fm_MaxIndex == null)
				{
					r_Fm_MaxIndex = new(this, "m_MaxIndex");
				}
				return r_Fm_MaxIndex;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_Fm_Safety;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RFm_Safety
		{
			get
			{
				if(r_Fm_Safety == null)
				{
					r_Fm_Safety = new(this, "m_Safety");
				}
				return r_Fm_Safety;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 Stride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PStride;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPStride
		{
			get
			{
				if(r_PStride == null)
				{
					r_PStride = new(this, "Stride", -1);
				}
				return r_PStride;
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
		/// Unity.Collections.NativeSlice`1[T] op_Implicit(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Mop_Implicit_NativeArray_d_T_p_;
		public static RMethod RMop_Implicit_NativeArray_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_NativeArray_d_T_p_ == null)
				{
					r_Mop_Implicit_NativeArray_d_T_p_ = new( ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"), "op_Implicit", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_Mop_Implicit_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[U] SliceConvert[U]()
		/// </summary>
		protected RMethod r_MSliceConvert_GU;
		public virtual RMethod RMSliceConvert_GU
		{
			get
			{
				if(r_MSliceConvert_GU == null)
				{
					r_MSliceConvert_GU = new(this, "SliceConvert", 1);
				}
				return r_MSliceConvert_GU;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[U] SliceWithStride[U](Int32)
		/// </summary>
		protected RMethod r_MSliceWithStride_GU_Int32;
		public virtual RMethod RMSliceWithStride_GU_Int32
		{
			get
			{
				if(r_MSliceWithStride_GU_Int32 == null)
				{
					r_MSliceWithStride_GU_Int32 = new(this, "SliceWithStride", 1, typeof(System.Int32));
				}
				return r_MSliceWithStride_GU_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[U] SliceWithStride[U]()
		/// </summary>
		protected RMethod r_MSliceWithStride_GU;
		public virtual RMethod RMSliceWithStride_GU
		{
			get
			{
				if(r_MSliceWithStride_GU == null)
				{
					r_MSliceWithStride_GU = new(this, "SliceWithStride", 1);
				}
				return r_MSliceWithStride_GU;
			}
		}

		/// <summary>
		/// Void CheckReadIndex(Int32)
		/// </summary>
		protected RMethod r_MCheckReadIndex_Int32;
		public virtual RMethod RMCheckReadIndex_Int32
		{
			get
			{
				if(r_MCheckReadIndex_Int32 == null)
				{
					r_MCheckReadIndex_Int32 = new(this, "CheckReadIndex", 0, typeof(System.Int32));
				}
				return r_MCheckReadIndex_Int32;
			}
		}

		/// <summary>
		/// Void CheckWriteIndex(Int32)
		/// </summary>
		protected RMethod r_MCheckWriteIndex_Int32;
		public virtual RMethod RMCheckWriteIndex_Int32
		{
			get
			{
				if(r_MCheckWriteIndex_Int32 == null)
				{
					r_MCheckWriteIndex_Int32 = new(this, "CheckWriteIndex", 0, typeof(System.Int32));
				}
				return r_MCheckWriteIndex_Int32;
			}
		}

		/// <summary>
		/// Void FailOutOfRangeError(Int32)
		/// </summary>
		protected RMethod r_MFailOutOfRangeError_Int32;
		public virtual RMethod RMFailOutOfRangeError_Int32
		{
			get
			{
				if(r_MFailOutOfRangeError_Int32 == null)
				{
					r_MFailOutOfRangeError_Int32 = new(this, "FailOutOfRangeError", 0, typeof(System.Int32));
				}
				return r_MFailOutOfRangeError_Int32;
			}
		}

		/// <summary>
		/// Void CopyFrom(Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected RMethod r_MCopyFrom_NativeSlice_d_T_p_;
		public virtual RMethod RMCopyFrom_NativeSlice_d_T_p_
		{
			get
			{
				if(r_MCopyFrom_NativeSlice_d_T_p_ == null)
				{
					r_MCopyFrom_NativeSlice_d_T_p_ = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"));
				}
				return r_MCopyFrom_NativeSlice_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyFrom(T[])
		/// </summary>
		protected RMethod r_MCopyFrom_TArray;
		public virtual RMethod RMCopyFrom_TArray
		{
			get
			{
				if(r_MCopyFrom_TArray == null)
				{
					r_MCopyFrom_TArray = new(this, "CopyFrom", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCopyFrom_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MCopyTo_NativeArray_d_T_p_;
		public virtual RMethod RMCopyTo_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCopyTo_NativeArray_d_T_p_ == null)
				{
					r_MCopyTo_NativeArray_d_T_p_ = new(this, "CopyTo", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MCopyTo_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_MCopyTo_TArray;
		public virtual RMethod RMCopyTo_TArray
		{
			get
			{
				if(r_MCopyTo_TArray == null)
				{
					r_MCopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MCopyTo_TArray;
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
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean Equals(Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected RMethod r_MEquals_NativeSlice_d_T_p_;
		public virtual RMethod RMEquals_NativeSlice_d_T_p_
		{
			get
			{
				if(r_MEquals_NativeSlice_d_T_p_ == null)
				{
					r_MEquals_NativeSlice_d_T_p_ = new(this, "Equals", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"));
				}
				return r_MEquals_NativeSlice_d_T_p_;
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
		/// Boolean op_Equality(Unity.Collections.NativeSlice`1[T], Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
		public static RMethod RMop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_ == null)
				{
					r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_ = new( ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"), "op_Equality", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"),  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"));
				}
				return r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Unity.Collections.NativeSlice`1[T], Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
		public static RMethod RMop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_ == null)
				{
					r_Mop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_ = new( ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"), "op_Inequality", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"),  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1"));
				}
				return r_Mop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
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


        public static Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> op_Implicit(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMop_Implicit_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> SliceConvert<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RMSliceConvert_GU.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> SliceWithStride<U>(System.Int32 @offset) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@offset};
            var ___result = RMSliceWithStride_GU_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> SliceWithStride<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RMSliceWithStride_GU.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void CheckReadIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMCheckReadIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckWriteIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMCheckWriteIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FailOutOfRangeError(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMFailOutOfRangeError_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @slice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slice.Value};
            var ___result = RMCopyFrom_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyFrom_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyTo_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>.REnumerator(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RType> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @left, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @left, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
