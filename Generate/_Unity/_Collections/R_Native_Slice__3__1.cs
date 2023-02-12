
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RCollections
{
	/// <summary>
	/// Unity.Collections.NativeSlice`1
	/// </summary>
    public partial class RNativeSlice<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.Byte* m_Buffer
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldPointer<SMFrame.Editor.Refleaction.RSystem.RByte> r_Fm_Buffer;
		public virtual SMFrame.Editor.Refleaction.RFieldPointer<SMFrame.Editor.Refleaction.RSystem.RByte> RFm_Buffer
		{
			get
			{
				if(r_Fm_Buffer == null)
				{
					r_Fm_Buffer = new(this, "m_Buffer");
					r_Fm_Buffer.SetBelong(this.instance);
				}
				return r_Fm_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Stride
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_Stride;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_Stride
		{
			get
			{
				if(r_Fm_Stride == null)
				{
					r_Fm_Stride = new(this, "m_Stride");
					r_Fm_Stride.SetBelong(this.instance);
				}
				return r_Fm_Stride;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_Length;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_Length
		{
			get
			{
				if(r_Fm_Length == null)
				{
					r_Fm_Length = new(this, "m_Length");
					r_Fm_Length.SetBelong(this.instance);
				}
				return r_Fm_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_MinIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_MinIndex
		{
			get
			{
				if(r_Fm_MinIndex == null)
				{
					r_Fm_MinIndex = new(this, "m_MinIndex");
					r_Fm_MinIndex.SetBelong(this.instance);
				}
				return r_Fm_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_MaxIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_MaxIndex
		{
			get
			{
				if(r_Fm_MaxIndex == null)
				{
					r_Fm_MaxIndex = new(this, "m_MaxIndex");
					r_Fm_MaxIndex.SetBelong(this.instance);
				}
				return r_Fm_MaxIndex;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_Fm_Safety;
		public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RFm_Safety
		{
			get
			{
				if(r_Fm_Safety == null)
				{
					r_Fm_Safety = new(this, "m_Safety");
					r_Fm_Safety.SetBelong(this.instance);
				}
				return r_Fm_Safety;
			}
		}

		/// <summary>
		/// T Item [Int32]
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
		/// Int32 Stride
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PStride;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPStride
		{
			get
			{
				if(r_PStride == null)
				{
					r_PStride = new(this, "Stride", -1);
					r_PStride.SetBelong(this.instance);
				}
				return r_PStride;
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
		/// Unity.Collections.NativeSlice`1[T] op_Implicit(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_Mop_Implicit_NativeArray_d_T_p_;
		public static RMethod RMop_Implicit_NativeArray_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_NativeArray_d_T_p_ == null)
				{
					r_Mop_Implicit_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeSlice<>), "op_Implicit", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Mop_Implicit_NativeArray_d_T_p_.SetBelong(null);
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
					r_MSliceConvert_GU.SetBelong(this.instance);
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
					r_MSliceWithStride_GU_Int32.SetBelong(this.instance);
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
					r_MSliceWithStride_GU.SetBelong(this.instance);
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
					r_MCheckReadIndex_Int32.SetBelong(this.instance);
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
					r_MCheckWriteIndex_Int32.SetBelong(this.instance);
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
					r_MFailOutOfRangeError_Int32.SetBelong(this.instance);
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
					r_MCopyFrom_NativeSlice_d_T_p_ = new(this, "CopyFrom", 0, typeof(Unity.Collections.NativeSlice<>));
					r_MCopyFrom_NativeSlice_d_T_p_.SetBelong(this.instance);
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
					r_MCopyFrom_TArray.SetBelong(this.instance);
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
					r_MCopyTo_NativeArray_d_T_p_ = new(this, "CopyTo", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MCopyTo_NativeArray_d_T_p_.SetBelong(this.instance);
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
					r_MCopyTo_TArray.SetBelong(this.instance);
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
					r_MToArray.SetBelong(this.instance);
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
					r_MGetEnumerator.SetBelong(this.instance);
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
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.SetBelong(this.instance);
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
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
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
					r_MEquals_NativeSlice_d_T_p_ = new(this, "Equals", 0, typeof(Unity.Collections.NativeSlice<>));
					r_MEquals_NativeSlice_d_T_p_.SetBelong(this.instance);
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
		/// Boolean op_Equality(Unity.Collections.NativeSlice`1[T], Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
		public static RMethod RMop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_ == null)
				{
					r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_ = new(typeof(Unity.Collections.NativeSlice<>), "op_Equality", 0, typeof(Unity.Collections.NativeSlice<>), typeof(Unity.Collections.NativeSlice<>));
					r_Mop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_.SetBelong(null);
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
					r_Mop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_ = new(typeof(Unity.Collections.NativeSlice<>), "op_Inequality", 0, typeof(Unity.Collections.NativeSlice<>), typeof(Unity.Collections.NativeSlice<>));
					r_Mop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_.SetBelong(null);
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
					r_MToString.SetBelong(this.instance);
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

        public static SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> op_Implicit(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMop_Implicit_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> SliceConvert<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RMSliceConvert_GU.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> SliceWithStride<U>(System.Int32 @offset) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@offset};
            var ___result = RMSliceWithStride_GU_Int32.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> SliceWithStride<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RMSliceWithStride_GU.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType>(___result);
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


        public virtual void CopyFrom(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @slice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slice.Value};
            var ___result = RMCopyFrom_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyFrom_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyTo_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RMCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType>.REnumerator(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<SMFrame.Editor.Refleaction.RType> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<SMFrame.Editor.Refleaction.RType>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @other)
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


        public static System.Boolean op_Equality(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @left, SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @left, SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RType> @right)
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