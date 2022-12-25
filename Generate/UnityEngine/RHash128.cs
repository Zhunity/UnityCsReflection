using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Hash128
	/// </summary>
    public partial class RHash128 : RMember //
    {

		/// <summary>
		/// System.UInt64 u64_0
		/// </summary>
		protected RField r_u64_0;
		public virtual RField Ru64_0
		{
			get
			{
				if(r_u64_0 == null)
				{
					r_u64_0 = new(this, "u64_0");
					r_u64_0.SetBelong(this.instance);
				}
				return r_u64_0;
			}
		}

		/// <summary>
		/// System.UInt64 u64_1
		/// </summary>
		protected RField r_u64_1;
		public virtual RField Ru64_1
		{
			get
			{
				if(r_u64_1 == null)
				{
					r_u64_1 = new(this, "u64_1");
					r_u64_1.SetBelong(this.instance);
				}
				return r_u64_1;
			}
		}

		/// <summary>
		/// System.UInt64 kConst
		/// </summary>
		protected static RField r_kConst;
		public static RField RkConst
		{
			get
			{
				if(r_kConst == null)
				{
					r_kConst = new(typeof(UnityEngine.Hash128), "kConst");
					r_kConst.SetBelong(null);
				}
				return r_kConst;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected RProperty r_isValid;
		public virtual RProperty RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid", -1);
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// Int32 CompareTo(UnityEngine.Hash128)
		/// </summary>
		protected RMethod r_RCompareTo_Hash128;
		public virtual RMethod RCompareTo_Hash128
		{
			get
			{
				if(r_RCompareTo_Hash128 == null)
				{
					r_RCompareTo_Hash128 = new(this, "CompareTo", 0, typeof(UnityEngine.Hash128));
					r_RCompareTo_Hash128.SetBelong(this.instance);
				}
				return r_RCompareTo_Hash128;
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
		/// UnityEngine.Hash128 Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(typeof(UnityEngine.Hash128), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// System.String Hash128ToStringImpl(UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_RHash128ToStringImpl_Hash128;
		public static RMethod RHash128ToStringImpl_Hash128
		{
			get
			{
				if(r_RHash128ToStringImpl_Hash128 == null)
				{
					r_RHash128ToStringImpl_Hash128 = new(typeof(UnityEngine.Hash128), "Hash128ToStringImpl", 0, typeof(UnityEngine.Hash128));
					r_RHash128ToStringImpl_Hash128.SetBelong(null);
				}
				return r_RHash128ToStringImpl_Hash128;
			}
		}

		/// <summary>
		/// Void ComputeFromString(System.String, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_RComputeFromString_String_Ref_Hash128;
		public static RMethod RComputeFromString_String_Ref_Hash128
		{
			get
			{
				if(r_RComputeFromString_String_Ref_Hash128 == null)
				{
					r_RComputeFromString_String_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "ComputeFromString", 0, typeof(System.String), typeof(UnityEngine.Hash128).MakeByRefType());
					r_RComputeFromString_String_Ref_Hash128.SetBelong(null);
				}
				return r_RComputeFromString_String_Ref_Hash128;
			}
		}

		/// <summary>
		/// Void ComputeFromPtr(IntPtr, Int32, Int32, Int32, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128;
		public static RMethod RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128
		{
			get
			{
				if(r_RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128 == null)
				{
					r_RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "ComputeFromPtr", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Hash128).MakeByRefType());
					r_RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128.SetBelong(null);
				}
				return r_RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128;
			}
		}

		/// <summary>
		/// Void ComputeFromArray(System.Array, Int32, Int32, Int32, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128;
		public static RMethod RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128
		{
			get
			{
				if(r_RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128 == null)
				{
					r_RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "ComputeFromArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Hash128).MakeByRefType());
					r_RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128.SetBelong(null);
				}
				return r_RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(System.String)
		/// </summary>
		protected static RMethod r_RCompute_String;
		public static RMethod RCompute_String
		{
			get
			{
				if(r_RCompute_String == null)
				{
					r_RCompute_String = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(System.String));
					r_RCompute_String.SetBelong(null);
				}
				return r_RCompute_String;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_RCompute_GT_NativeArray_d_T_p_;
		public static RMethod RCompute_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RCompute_GT_NativeArray_d_T_p_ == null)
				{
					r_RCompute_GT_NativeArray_d_T_p_ = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCompute_GT_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_RCompute_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_RCompute_GT_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RCompute_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RCompute_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RCompute_GT_NativeArray_d_T_p__Int32_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RCompute_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_RCompute_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](T[])
		/// </summary>
		protected static RMethod r_RCompute_GT_TArray;
		public static RMethod RCompute_GT_TArray
		{
			get
			{
				if(r_RCompute_GT_TArray == null)
				{
					r_RCompute_GT_TArray = new(typeof(UnityEngine.Hash128), "Compute", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_RCompute_GT_TArray.SetBelong(null);
				}
				return r_RCompute_GT_TArray;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RCompute_GT_TArray_Int32_Int32;
		public static RMethod RCompute_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_RCompute_GT_TArray_Int32_Int32 == null)
				{
					r_RCompute_GT_TArray_Int32_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RCompute_GT_TArray_Int32_Int32.SetBelong(null);
				}
				return r_RCompute_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected static RMethod r_RCompute_GT_List_d_T_p_;
		public static RMethod RCompute_GT_List_d_T_p_
		{
			get
			{
				if(r_RCompute_GT_List_d_T_p_ == null)
				{
					r_RCompute_GT_List_d_T_p_ = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCompute_GT_List_d_T_p_.SetBelong(null);
				}
				return r_RCompute_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](System.Collections.Generic.List`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_RCompute_GT_List_d_T_p__Int32_Int32;
		public static RMethod RCompute_GT_List_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RCompute_GT_List_d_T_p__Int32_Int32 == null)
				{
					r_RCompute_GT_List_d_T_p__Int32_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RCompute_GT_List_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_RCompute_GT_List_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](T ByRef)
		/// </summary>
		protected static RMethod r_RCompute_GT_Ref_T;
		public static RMethod RCompute_GT_Ref_T
		{
			get
			{
				if(r_RCompute_GT_Ref_T == null)
				{
					r_RCompute_GT_Ref_T = new(typeof(UnityEngine.Hash128), "Compute", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RCompute_GT_Ref_T.SetBelong(null);
				}
				return r_RCompute_GT_Ref_T;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(Int32)
		/// </summary>
		protected static RMethod r_RCompute_Int32;
		public static RMethod RCompute_Int32
		{
			get
			{
				if(r_RCompute_Int32 == null)
				{
					r_RCompute_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(System.Int32));
					r_RCompute_Int32.SetBelong(null);
				}
				return r_RCompute_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(Single)
		/// </summary>
		protected static RMethod r_RCompute_Single;
		public static RMethod RCompute_Single
		{
			get
			{
				if(r_RCompute_Single == null)
				{
					r_RCompute_Single = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(System.Single));
					r_RCompute_Single.SetBelong(null);
				}
				return r_RCompute_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(Void*, UInt64)
		/// </summary>
		protected static RMethod r_RCompute_VoidPointer_UInt64;
		public static RMethod RCompute_VoidPointer_UInt64
		{
			get
			{
				if(r_RCompute_VoidPointer_UInt64 == null)
				{
					r_RCompute_VoidPointer_UInt64 = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(void).MakePointerType(), typeof(System.UInt64));
					r_RCompute_VoidPointer_UInt64.SetBelong(null);
				}
				return r_RCompute_VoidPointer_UInt64;
			}
		}

		/// <summary>
		/// Void Append(System.String)
		/// </summary>
		protected RMethod r_RAppend_String;
		public virtual RMethod RAppend_String
		{
			get
			{
				if(r_RAppend_String == null)
				{
					r_RAppend_String = new(this, "Append", 0, typeof(System.String));
					r_RAppend_String.SetBelong(this.instance);
				}
				return r_RAppend_String;
			}
		}

		/// <summary>
		/// Void Append[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RAppend_GT_NativeArray_d_T_p_;
		public virtual RMethod RAppend_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RAppend_GT_NativeArray_d_T_p_ == null)
				{
					r_RAppend_GT_NativeArray_d_T_p_ = new(this, "Append", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAppend_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RAppend_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Append[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RAppend_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RAppend_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RAppend_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RAppend_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "Append", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RAppend_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppend_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Append[T](T[])
		/// </summary>
		protected RMethod r_RAppend_GT_TArray;
		public virtual RMethod RAppend_GT_TArray
		{
			get
			{
				if(r_RAppend_GT_TArray == null)
				{
					r_RAppend_GT_TArray = new(this, "Append", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_RAppend_GT_TArray.SetBelong(this.instance);
				}
				return r_RAppend_GT_TArray;
			}
		}

		/// <summary>
		/// Void Append[T](T[], Int32, Int32)
		/// </summary>
		protected RMethod r_RAppend_GT_TArray_Int32_Int32;
		public virtual RMethod RAppend_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_RAppend_GT_TArray_Int32_Int32 == null)
				{
					r_RAppend_GT_TArray_Int32_Int32 = new(this, "Append", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RAppend_GT_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppend_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Append[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RAppend_GT_List_d_T_p_;
		public virtual RMethod RAppend_GT_List_d_T_p_
		{
			get
			{
				if(r_RAppend_GT_List_d_T_p_ == null)
				{
					r_RAppend_GT_List_d_T_p_ = new(this, "Append", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAppend_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RAppend_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void Append[T](System.Collections.Generic.List`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RAppend_GT_List_d_T_p__Int32_Int32;
		public virtual RMethod RAppend_GT_List_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RAppend_GT_List_d_T_p__Int32_Int32 == null)
				{
					r_RAppend_GT_List_d_T_p__Int32_Int32 = new(this, "Append", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RAppend_GT_List_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppend_GT_List_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Append[T](T ByRef)
		/// </summary>
		protected RMethod r_RAppend_GT_Ref_T;
		public virtual RMethod RAppend_GT_Ref_T
		{
			get
			{
				if(r_RAppend_GT_Ref_T == null)
				{
					r_RAppend_GT_Ref_T = new(this, "Append", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RAppend_GT_Ref_T.SetBelong(this.instance);
				}
				return r_RAppend_GT_Ref_T;
			}
		}

		/// <summary>
		/// Void Append(Int32)
		/// </summary>
		protected RMethod r_RAppend_Int32;
		public virtual RMethod RAppend_Int32
		{
			get
			{
				if(r_RAppend_Int32 == null)
				{
					r_RAppend_Int32 = new(this, "Append", 0, typeof(System.Int32));
					r_RAppend_Int32.SetBelong(this.instance);
				}
				return r_RAppend_Int32;
			}
		}

		/// <summary>
		/// Void Append(Single)
		/// </summary>
		protected RMethod r_RAppend_Single;
		public virtual RMethod RAppend_Single
		{
			get
			{
				if(r_RAppend_Single == null)
				{
					r_RAppend_Single = new(this, "Append", 0, typeof(System.Single));
					r_RAppend_Single.SetBelong(this.instance);
				}
				return r_RAppend_Single;
			}
		}

		/// <summary>
		/// Void Append(Void*, UInt64)
		/// </summary>
		protected RMethod r_RAppend_VoidPointer_UInt64;
		public virtual RMethod RAppend_VoidPointer_UInt64
		{
			get
			{
				if(r_RAppend_VoidPointer_UInt64 == null)
				{
					r_RAppend_VoidPointer_UInt64 = new(this, "Append", 0, typeof(void).MakePointerType(), typeof(System.UInt64));
					r_RAppend_VoidPointer_UInt64.SetBelong(this.instance);
				}
				return r_RAppend_VoidPointer_UInt64;
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
		/// Boolean Equals(UnityEngine.Hash128)
		/// </summary>
		protected RMethod r_REquals_Hash128;
		public virtual RMethod REquals_Hash128
		{
			get
			{
				if(r_REquals_Hash128 == null)
				{
					r_REquals_Hash128 = new(this, "Equals", 0, typeof(UnityEngine.Hash128));
					r_REquals_Hash128.SetBelong(this.instance);
				}
				return r_REquals_Hash128;
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
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RCompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_RCompareTo_Object == null)
				{
					r_RCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_RCompareTo_Object.SetBelong(this.instance);
				}
				return r_RCompareTo_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Rop_Equality_Hash128_Hash128;
		public static RMethod Rop_Equality_Hash128_Hash128
		{
			get
			{
				if(r_Rop_Equality_Hash128_Hash128 == null)
				{
					r_Rop_Equality_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_Equality", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Rop_Equality_Hash128_Hash128.SetBelong(null);
				}
				return r_Rop_Equality_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Hash128_Hash128;
		public static RMethod Rop_Inequality_Hash128_Hash128
		{
			get
			{
				if(r_Rop_Inequality_Hash128_Hash128 == null)
				{
					r_Rop_Inequality_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_Inequality", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Rop_Inequality_Hash128_Hash128.SetBelong(null);
				}
				return r_Rop_Inequality_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Rop_LessThan_Hash128_Hash128;
		public static RMethod Rop_LessThan_Hash128_Hash128
		{
			get
			{
				if(r_Rop_LessThan_Hash128_Hash128 == null)
				{
					r_Rop_LessThan_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_LessThan", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Rop_LessThan_Hash128_Hash128.SetBelong(null);
				}
				return r_Rop_LessThan_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Rop_GreaterThan_Hash128_Hash128;
		public static RMethod Rop_GreaterThan_Hash128_Hash128
		{
			get
			{
				if(r_Rop_GreaterThan_Hash128_Hash128 == null)
				{
					r_Rop_GreaterThan_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_GreaterThan", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Rop_GreaterThan_Hash128_Hash128.SetBelong(null);
				}
				return r_Rop_GreaterThan_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Void ShortHash4(UInt32)
		/// </summary>
		protected RMethod r_RShortHash4_UInt32;
		public virtual RMethod RShortHash4_UInt32
		{
			get
			{
				if(r_RShortHash4_UInt32 == null)
				{
					r_RShortHash4_UInt32 = new(this, "ShortHash4", 0, typeof(System.UInt32));
					r_RShortHash4_UInt32.SetBelong(this.instance);
				}
				return r_RShortHash4_UInt32;
			}
		}

		/// <summary>
		/// Void ShortEnd(UInt64 ByRef, UInt64 ByRef, UInt64 ByRef, UInt64 ByRef)
		/// </summary>
		protected static RMethod r_RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64;
		public static RMethod RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64
		{
			get
			{
				if(r_RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64 == null)
				{
					r_RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64 = new(typeof(UnityEngine.Hash128), "ShortEnd", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64).MakeByRefType());
					r_RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64.SetBelong(null);
				}
				return r_RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64;
			}
		}

		/// <summary>
		/// Void Rot64(UInt64 ByRef, Int32)
		/// </summary>
		protected static RMethod r_RRot64_Ref_UInt64_Int32;
		public static RMethod RRot64_Ref_UInt64_Int32
		{
			get
			{
				if(r_RRot64_Ref_UInt64_Int32 == null)
				{
					r_RRot64_Ref_UInt64_Int32 = new(typeof(UnityEngine.Hash128), "Rot64", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.Int32));
					r_RRot64_Ref_UInt64_Int32.SetBelong(null);
				}
				return r_RRot64_Ref_UInt64_Int32;
			}
		}

		/// <summary>
		/// Void Parse_Injected(System.String, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_RParse_Injected_String_Out_Hash128;
		public static RMethod RParse_Injected_String_Out_Hash128
		{
			get
			{
				if(r_RParse_Injected_String_Out_Hash128 == null)
				{
					r_RParse_Injected_String_Out_Hash128 = new(typeof(UnityEngine.Hash128), "Parse_Injected", 0, typeof(System.String), typeof(UnityEngine.Hash128).MakeByRefType());
					r_RParse_Injected_String_Out_Hash128.SetBelong(null);
				}
				return r_RParse_Injected_String_Out_Hash128;
			}
		}

		/// <summary>
		/// System.String Hash128ToStringImpl_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_RHash128ToStringImpl_Injected_Ref_Hash128;
		public static RMethod RHash128ToStringImpl_Injected_Ref_Hash128
		{
			get
			{
				if(r_RHash128ToStringImpl_Injected_Ref_Hash128 == null)
				{
					r_RHash128ToStringImpl_Injected_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "Hash128ToStringImpl_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_RHash128ToStringImpl_Injected_Ref_Hash128.SetBelong(null);
				}
				return r_RHash128ToStringImpl_Injected_Ref_Hash128;
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


        public RHash128() : base("UnityEngine.Hash128")
        {
        }

        public RHash128(System.Object instance) : base("UnityEngine.Hash128")
		{
            SetInstance(instance);
		}

        public RHash128(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHash128(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 CompareTo(UnityEngine.Hash128  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = RCompareTo_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Hash128 Parse(System.String  @hashString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashString};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static System.String Hash128ToStringImpl(UnityEngine.Hash128  @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash};
            var ___result = RHash128ToStringImpl_Hash128.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void ComputeFromString(System.String  @data, ref UnityEngine.Hash128  @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hash};
            var ___result = RComputeFromString_String_Ref_Hash128.Invoke(___genericsType, ___parameters);
			hash = (UnityEngine.Hash128)___parameters[1];

            
        }


        public static void ComputeFromPtr(System.IntPtr  @data, System.Int32  @start, System.Int32  @count, System.Int32  @elemSize, ref UnityEngine.Hash128  @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @start, @count, @elemSize, @hash};
            var ___result = RComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128.Invoke(___genericsType, ___parameters);
			hash = (UnityEngine.Hash128)___parameters[4];

            
        }


        public static void ComputeFromArray(System.Array  @data, System.Int32  @start, System.Int32  @count, System.Int32  @elemSize, ref UnityEngine.Hash128  @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @start, @count, @elemSize, @hash};
            var ___result = RComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128.Invoke(___genericsType, ___parameters);
			hash = (UnityEngine.Hash128)___parameters[4];

            
        }


        public static UnityEngine.Hash128 Compute(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCompute_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }




        public static UnityEngine.Hash128 Compute<T>(T[]  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data};
            var ___result = RCompute_GT_TArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(T[]  @data, System.Int32  @start, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @start, @count};
            var ___result = RCompute_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(System.Collections.Generic.List<T>  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data};
            var ___result = RCompute_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(System.Collections.Generic.List<T>  @data, System.Int32  @start, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @start, @count};
            var ___result = RCompute_GT_List_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(ref T  @val) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@val};
            var ___result = RCompute_GT_Ref_T.Invoke(___genericsType, ___parameters);
			val = (T)___parameters[0];

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute(System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RCompute_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute(System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RCompute_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }



        public virtual void Append(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RAppend_String.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void Append<T>(T[]  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data};
            var ___result = RAppend_GT_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(T[]  @data, System.Int32  @start, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @start, @count};
            var ___result = RAppend_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(System.Collections.Generic.List<T>  @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data};
            var ___result = RAppend_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(System.Collections.Generic.List<T>  @data, System.Int32  @start, System.Int32  @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @start, @count};
            var ___result = RAppend_GT_List_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(ref T  @val) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@val};
            var ___result = RAppend_GT_Ref_T.Invoke(___genericsType, ___parameters);
			val = (T)___parameters[0];

            
        }


        public virtual void Append(System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RAppend_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append(System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RAppend_Single.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Hash128  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Hash128  @hash1, UnityEngine.Hash128  @hash2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash1, @hash2};
            var ___result = Rop_Equality_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Hash128  @hash1, UnityEngine.Hash128  @hash2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash1, @hash2};
            var ___result = Rop_Inequality_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(UnityEngine.Hash128  @x, UnityEngine.Hash128  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = Rop_LessThan_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(UnityEngine.Hash128  @x, UnityEngine.Hash128  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = Rop_GreaterThan_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShortHash4(System.UInt32  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RShortHash4_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ShortEnd(ref System.UInt64  @h0, ref System.UInt64  @h1, ref System.UInt64  @h2, ref System.UInt64  @h3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h0, @h1, @h2, @h3};
            var ___result = RShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64.Invoke(___genericsType, ___parameters);
			h0 = (System.UInt64)___parameters[0];
			h1 = (System.UInt64)___parameters[1];
			h2 = (System.UInt64)___parameters[2];
			h3 = (System.UInt64)___parameters[3];

            
        }


        public static void Rot64(ref System.UInt64  @x, System.Int32  @k)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @k};
            var ___result = RRot64_Ref_UInt64_Int32.Invoke(___genericsType, ___parameters);
			x = (System.UInt64)___parameters[0];

            
        }


        public static void Parse_Injected(System.String  @hashString, out UnityEngine.Hash128  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashString, @ret};
            var ___result = RParse_Injected_String_Out_Hash128.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Hash128)___parameters[1];

            
        }


        public static System.String Hash128ToStringImpl_Injected(ref UnityEngine.Hash128  @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash};
            var ___result = RHash128ToStringImpl_Injected_Ref_Hash128.Invoke(___genericsType, ___parameters);
			hash = (UnityEngine.Hash128)___parameters[0];

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
