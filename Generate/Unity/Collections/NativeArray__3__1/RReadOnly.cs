using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RCollections
{public partial class RNativeArray<T>
{
	
	/// <summary>
	/// Unity.Collections.NativeArray`1+ReadOnly
	/// </summary>
    public partial class RReadOnly : RMember //
    {

		/// <summary>
		/// System.Void* m_Buffer
		/// </summary>
		protected RFieldPointer<RField> r_m_Buffer;
		public virtual RFieldPointer<RField> Rm_Buffer
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
		/// Boolean IsCreated
		/// </summary>
		protected RSystem.RBoolean r_IsCreated;
		public virtual RSystem.RBoolean RIsCreated
		{
			get
			{
				if(r_IsCreated == null)
				{
					r_IsCreated = new(this, "IsCreated", -1);
					r_IsCreated.SetBelong(this.instance);
				}
				return r_IsCreated;
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
		/// ReadOnly Reinterpret[U]()
		/// </summary>
		protected RMethod r_Reinterpret_GU;
		public virtual RMethod RReinterpret_GU
		{
			get
			{
				if(r_Reinterpret_GU == null)
				{
					r_Reinterpret_GU = new(this, "Reinterpret", 1);
					r_Reinterpret_GU.SetBelong(this.instance);
				}
				return r_Reinterpret_GU;
			}
		}

		/// <summary>
		/// Void CheckElementReadAccess(Int32)
		/// </summary>
		protected RMethod r_CheckElementReadAccess_Int32;
		public virtual RMethod RCheckElementReadAccess_Int32
		{
			get
			{
				if(r_CheckElementReadAccess_Int32 == null)
				{
					r_CheckElementReadAccess_Int32 = new(this, "CheckElementReadAccess", 0, typeof(System.Int32));
					r_CheckElementReadAccess_Int32.SetBelong(this.instance);
				}
				return r_CheckElementReadAccess_Int32;
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
		/// System.ReadOnlySpan`1[T] AsReadOnlySpan()
		/// </summary>
		protected RMethod r_AsReadOnlySpan;
		public virtual RMethod RAsReadOnlySpan
		{
			get
			{
				if(r_AsReadOnlySpan == null)
				{
					r_AsReadOnlySpan = new(this, "AsReadOnlySpan", 0);
					r_AsReadOnlySpan.SetBelong(this.instance);
				}
				return r_AsReadOnlySpan;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] op_Implicit(ReadOnly ByRef)
		/// </summary>
		protected static RMethod r_op_Implicit_In_ReadOnly;
		public static RMethod Rop_Implicit_In_ReadOnly
		{
			get
			{
				if(r_op_Implicit_In_ReadOnly == null)
				{
					r_op_Implicit_In_ReadOnly = new( ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly"), "op_Implicit", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeByRefType());
					r_op_Implicit_In_ReadOnly.SetBelong(null);
				}
				return r_op_Implicit_In_ReadOnly;
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


        public RReadOnly() : base("Unity.Collections.NativeArray`1+ReadOnly")
        {
        }

        public RReadOnly(System.Object instance) : base("Unity.Collections.NativeArray`1+ReadOnly")
		{
            SetInstance(instance);
		}

        public RReadOnly(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadOnly(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CopyTo(RTypeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(RUnity.RCollections.RNativeArray<RType> @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array.Value};
            var ___result = RCopyTo_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RTypeArray<RType> ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return new RTypeArray<RType>(___result);
        }


        public virtual RUnity.RCollections.RNativeArray<RType>.RReadOnly Reinterpret<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RReinterpret_GU.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>.RReadOnly(___result);
        }


        public virtual void CheckElementReadAccess(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckElementReadAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnity.RCollections.RNativeArray<RType>.RReadOnly.REnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeArray<RType>.RReadOnly.REnumerator(___result);
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


        public virtual RSystem.RReadOnlySpan<RType> AsReadOnlySpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsReadOnlySpan.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RType>(___result);
        }


        public static RSystem.RReadOnlySpan<RType> op_Implicit(in RUnity.RCollections.RNativeArray<RType>.RReadOnly @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value};
            var ___result = Rop_Implicit_In_ReadOnly.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RType>(___result);
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
}