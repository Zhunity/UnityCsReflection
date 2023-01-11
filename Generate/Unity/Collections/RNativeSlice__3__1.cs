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
		protected RFieldPointer<RSystem.RByte> r_m_Buffer;
		public virtual RFieldPointer<RSystem.RByte> Rm_Buffer
		{
			get
			{
				if(r_m_Buffer == null)
				{
					r_m_Buffer = new(this, "m_Buffer");
					r_m_Buffer.SetBelong(this.instance);
				}
				return r_m_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Stride
		/// </summary>
		protected RSystem.RInt32 r_m_Stride;
		public virtual RSystem.RInt32 Rm_Stride
		{
			get
			{
				if(r_m_Stride == null)
				{
					r_m_Stride = new(this, "m_Stride");
					r_m_Stride.SetBelong(this.instance);
				}
				return r_m_Stride;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected RSystem.RInt32 r_m_Length;
		public virtual RSystem.RInt32 Rm_Length
		{
			get
			{
				if(r_m_Length == null)
				{
					r_m_Length = new(this, "m_Length");
					r_m_Length.SetBelong(this.instance);
				}
				return r_m_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected RSystem.RInt32 r_m_MinIndex;
		public virtual RSystem.RInt32 Rm_MinIndex
		{
			get
			{
				if(r_m_MinIndex == null)
				{
					r_m_MinIndex = new(this, "m_MinIndex");
					r_m_MinIndex.SetBelong(this.instance);
				}
				return r_m_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected RSystem.RInt32 r_m_MaxIndex;
		public virtual RSystem.RInt32 Rm_MaxIndex
		{
			get
			{
				if(r_m_MaxIndex == null)
				{
					r_m_MaxIndex = new(this, "m_MaxIndex");
					r_m_MaxIndex.SetBelong(this.instance);
				}
				return r_m_MaxIndex;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_m_Safety;
		public virtual RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle Rm_Safety
		{
			get
			{
				if(r_m_Safety == null)
				{
					r_m_Safety = new(this, "m_Safety");
					r_m_Safety.SetBelong(this.instance);
				}
				return r_m_Safety;
			}
		}

		/// <summary>
		/// T Item [Int32]
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
		/// Int32 Stride
		/// </summary>
		protected RSystem.RInt32 r_Stride;
		public virtual RSystem.RInt32 RStride
		{
			get
			{
				if(r_Stride == null)
				{
					r_Stride = new(this, "Stride", -1);
					r_Stride.SetBelong(this.instance);
				}
				return r_Stride;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_Length;
		public virtual RSystem.RInt32 RLength
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
		/// Unity.Collections.NativeSlice`1[T] op_Implicit(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_op_Implicit_NativeArray_d_T_p_;
		public static RMethod Rop_Implicit_NativeArray_d_T_p_
		{
			get
			{
				if(r_op_Implicit_NativeArray_d_T_p_ == null)
				{
					r_op_Implicit_NativeArray_d_T_p_ = new(typeof(Unity.Collections.NativeSlice<>), "op_Implicit", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_op_Implicit_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_op_Implicit_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[U] SliceConvert[U]()
		/// </summary>
		protected RMethod r_SliceConvert_GU;
		public virtual RMethod RSliceConvert_GU
		{
			get
			{
				if(r_SliceConvert_GU == null)
				{
					r_SliceConvert_GU = new(this, "SliceConvert", 1);
					r_SliceConvert_GU.SetBelong(this.instance);
				}
				return r_SliceConvert_GU;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[U] SliceWithStride[U](Int32)
		/// </summary>
		protected RMethod r_SliceWithStride_GU_Int32;
		public virtual RMethod RSliceWithStride_GU_Int32
		{
			get
			{
				if(r_SliceWithStride_GU_Int32 == null)
				{
					r_SliceWithStride_GU_Int32 = new(this, "SliceWithStride", 1, typeof(System.Int32));
					r_SliceWithStride_GU_Int32.SetBelong(this.instance);
				}
				return r_SliceWithStride_GU_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[U] SliceWithStride[U]()
		/// </summary>
		protected RMethod r_SliceWithStride_GU;
		public virtual RMethod RSliceWithStride_GU
		{
			get
			{
				if(r_SliceWithStride_GU == null)
				{
					r_SliceWithStride_GU = new(this, "SliceWithStride", 1);
					r_SliceWithStride_GU.SetBelong(this.instance);
				}
				return r_SliceWithStride_GU;
			}
		}

		/// <summary>
		/// Void CheckReadIndex(Int32)
		/// </summary>
		protected RMethod r_CheckReadIndex_Int32;
		public virtual RMethod RCheckReadIndex_Int32
		{
			get
			{
				if(r_CheckReadIndex_Int32 == null)
				{
					r_CheckReadIndex_Int32 = new(this, "CheckReadIndex", 0, typeof(System.Int32));
					r_CheckReadIndex_Int32.SetBelong(this.instance);
				}
				return r_CheckReadIndex_Int32;
			}
		}

		/// <summary>
		/// Void CheckWriteIndex(Int32)
		/// </summary>
		protected RMethod r_CheckWriteIndex_Int32;
		public virtual RMethod RCheckWriteIndex_Int32
		{
			get
			{
				if(r_CheckWriteIndex_Int32 == null)
				{
					r_CheckWriteIndex_Int32 = new(this, "CheckWriteIndex", 0, typeof(System.Int32));
					r_CheckWriteIndex_Int32.SetBelong(this.instance);
				}
				return r_CheckWriteIndex_Int32;
			}
		}

		/// <summary>
		/// Void FailOutOfRangeError(Int32)
		/// </summary>
		protected RMethod r_FailOutOfRangeError_Int32;
		public virtual RMethod RFailOutOfRangeError_Int32
		{
			get
			{
				if(r_FailOutOfRangeError_Int32 == null)
				{
					r_FailOutOfRangeError_Int32 = new(this, "FailOutOfRangeError", 0, typeof(System.Int32));
					r_FailOutOfRangeError_Int32.SetBelong(this.instance);
				}
				return r_FailOutOfRangeError_Int32;
			}
		}

		/// <summary>
		/// Void CopyFrom(Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected RMethod r_CopyFrom_NativeSlice_d_T_p_;
		public virtual RMethod RCopyFrom_NativeSlice_d_T_p_
		{
			get
			{
				if(r_CopyFrom_NativeSlice_d_T_p_ == null)
				{
					r_CopyFrom_NativeSlice_d_T_p_ = new(this, "CopyFrom", 0, typeof(Unity.Collections.NativeSlice<>));
					r_CopyFrom_NativeSlice_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyFrom_NativeSlice_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyFrom(T[])
		/// </summary>
		protected RMethod r_CopyFrom_TArray;
		public virtual RMethod RCopyFrom_TArray
		{
			get
			{
				if(r_CopyFrom_TArray == null)
				{
					r_CopyFrom_TArray = new(this, "CopyFrom", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_CopyFrom_TArray.SetBelong(this.instance);
				}
				return r_CopyFrom_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_CopyTo_NativeArray_d_T_p_;
		public virtual RMethod RCopyTo_NativeArray_d_T_p_
		{
			get
			{
				if(r_CopyTo_NativeArray_d_T_p_ == null)
				{
					r_CopyTo_NativeArray_d_T_p_ = new(this, "CopyTo", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_CopyTo_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyTo_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_CopyTo_TArray;
		public virtual RMethod RCopyTo_TArray
		{
			get
			{
				if(r_CopyTo_TArray == null)
				{
					r_CopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_CopyTo_TArray.SetBelong(this.instance);
				}
				return r_CopyTo_TArray;
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
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator == null)
				{
					r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
					r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean Equals(Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected RMethod r_Equals_NativeSlice_d_T_p_;
		public virtual RMethod REquals_NativeSlice_d_T_p_
		{
			get
			{
				if(r_Equals_NativeSlice_d_T_p_ == null)
				{
					r_Equals_NativeSlice_d_T_p_ = new(this, "Equals", 0, typeof(Unity.Collections.NativeSlice<>));
					r_Equals_NativeSlice_d_T_p_.SetBelong(this.instance);
				}
				return r_Equals_NativeSlice_d_T_p_;
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
		/// Boolean op_Equality(Unity.Collections.NativeSlice`1[T], Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_op_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
		public static RMethod Rop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_
		{
			get
			{
				if(r_op_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_ == null)
				{
					r_op_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_ = new(typeof(Unity.Collections.NativeSlice<>), "op_Equality", 0, typeof(Unity.Collections.NativeSlice<>), typeof(Unity.Collections.NativeSlice<>));
					r_op_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_.SetBelong(null);
				}
				return r_op_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Unity.Collections.NativeSlice`1[T], Unity.Collections.NativeSlice`1[T])
		/// </summary>
		protected static RMethod r_op_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
		public static RMethod Rop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_
		{
			get
			{
				if(r_op_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_ == null)
				{
					r_op_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_ = new(typeof(Unity.Collections.NativeSlice<>), "op_Inequality", 0, typeof(Unity.Collections.NativeSlice<>), typeof(Unity.Collections.NativeSlice<>));
					r_op_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_.SetBelong(null);
				}
				return r_op_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_;
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

        public static RUnity.RCollections.RNativeSlice<RType> op_Implicit(RUnity.RCollections.RNativeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = Rop_Implicit_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeSlice<RType>(___result);
        }


        public virtual RUnity.RCollections.RNativeSlice<RType> SliceConvert<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RSliceConvert_GU.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeSlice<RType>(___result);
        }


        public virtual RUnity.RCollections.RNativeSlice<RType> SliceWithStride<U>(System.Int32 @offset) where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{@offset};
            var ___result = RSliceWithStride_GU_Int32.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeSlice<RType>(___result);
        }


        public virtual RUnity.RCollections.RNativeSlice<RType> SliceWithStride<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RSliceWithStride_GU.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeSlice<RType>(___result);
        }


        public virtual void CheckReadIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckReadIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckWriteIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckWriteIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FailOutOfRangeError(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RFailOutOfRangeError_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(RUnity.RCollections.RNativeSlice<RType> @slice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slice.Value};
            var ___result = RCopyFrom_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(RTypeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyFrom_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(RUnity.RCollections.RNativeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyTo_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(RTypeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RTypeArray<RType> ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return new RTypeArray<RType>(___result);
        }


        public virtual RUnity.RCollections.RNativeSlice<RType>.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeSlice<RType>.REnumerator(___result);
        }


        public virtual RSystem.RCollections.RGeneric.RIEnumerator<RType> System__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__T__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RIEnumerator<RType>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean Equals(RUnity.RCollections.RNativeSlice<RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(RUnity.RCollections.RNativeSlice<RType> @left, RUnity.RCollections.RNativeSlice<RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Equality_NativeSlice_d_T_p__NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnity.RCollections.RNativeSlice<RType> @left, RUnity.RCollections.RNativeSlice<RType> @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Inequality_NativeSlice_d_T_p__NativeSlice_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
