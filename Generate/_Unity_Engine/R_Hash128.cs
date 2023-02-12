
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
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_Fu64_0;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RFu64_0
		{
			get
			{
				if(r_Fu64_0 == null)
				{
					r_Fu64_0 = new(this, "u64_0");
					r_Fu64_0.SetBelong(this.instance);
				}
				return r_Fu64_0;
			}
		}

		/// <summary>
		/// System.UInt64 u64_1
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_Fu64_1;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RFu64_1
		{
			get
			{
				if(r_Fu64_1 == null)
				{
					r_Fu64_1 = new(this, "u64_1");
					r_Fu64_1.SetBelong(this.instance);
				}
				return r_Fu64_1;
			}
		}

		/// <summary>
		/// System.UInt64 kConst
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RUInt64 r_FkConst;
		public static SMFrame.Editor.Refleaction.RSystem.RUInt64 RFkConst
		{
			get
			{
				if(r_FkConst == null)
				{
					r_FkConst = new(typeof(UnityEngine.Hash128), "kConst");
					r_FkConst.SetBelong(null);
				}
				return r_FkConst;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
					r_PisValid.SetBelong(this.instance);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// Int32 CompareTo(UnityEngine.Hash128)
		/// </summary>
		protected RMethod r_MCompareTo_Hash128;
		public virtual RMethod RMCompareTo_Hash128
		{
			get
			{
				if(r_MCompareTo_Hash128 == null)
				{
					r_MCompareTo_Hash128 = new(this, "CompareTo", 0, typeof(UnityEngine.Hash128));
					r_MCompareTo_Hash128.SetBelong(this.instance);
				}
				return r_MCompareTo_Hash128;
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
		/// UnityEngine.Hash128 Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(typeof(UnityEngine.Hash128), "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(null);
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// System.String Hash128ToStringImpl(UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_MHash128ToStringImpl_Hash128;
		public static RMethod RMHash128ToStringImpl_Hash128
		{
			get
			{
				if(r_MHash128ToStringImpl_Hash128 == null)
				{
					r_MHash128ToStringImpl_Hash128 = new(typeof(UnityEngine.Hash128), "Hash128ToStringImpl", 0, typeof(UnityEngine.Hash128));
					r_MHash128ToStringImpl_Hash128.SetBelong(null);
				}
				return r_MHash128ToStringImpl_Hash128;
			}
		}

		/// <summary>
		/// Void ComputeFromString(System.String, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_MComputeFromString_String_Ref_Hash128;
		public static RMethod RMComputeFromString_String_Ref_Hash128
		{
			get
			{
				if(r_MComputeFromString_String_Ref_Hash128 == null)
				{
					r_MComputeFromString_String_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "ComputeFromString", 0, typeof(System.String), typeof(UnityEngine.Hash128).MakeByRefType());
					r_MComputeFromString_String_Ref_Hash128.SetBelong(null);
				}
				return r_MComputeFromString_String_Ref_Hash128;
			}
		}

		/// <summary>
		/// Void ComputeFromPtr(IntPtr, Int32, Int32, Int32, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_MComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128;
		public static RMethod RMComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128
		{
			get
			{
				if(r_MComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128 == null)
				{
					r_MComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "ComputeFromPtr", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Hash128).MakeByRefType());
					r_MComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128.SetBelong(null);
				}
				return r_MComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128;
			}
		}

		/// <summary>
		/// Void ComputeFromArray(System.Array, Int32, Int32, Int32, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_MComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128;
		public static RMethod RMComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128
		{
			get
			{
				if(r_MComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128 == null)
				{
					r_MComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "ComputeFromArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Hash128).MakeByRefType());
					r_MComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128.SetBelong(null);
				}
				return r_MComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(System.String)
		/// </summary>
		protected static RMethod r_MCompute_String;
		public static RMethod RMCompute_String
		{
			get
			{
				if(r_MCompute_String == null)
				{
					r_MCompute_String = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(System.String));
					r_MCompute_String.SetBelong(null);
				}
				return r_MCompute_String;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected static RMethod r_MCompute_GT_NativeArray_d_T_p_;
		public static RMethod RMCompute_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MCompute_GT_NativeArray_d_T_p_ == null)
				{
					r_MCompute_GT_NativeArray_d_T_p_ = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MCompute_GT_NativeArray_d_T_p_.SetBelong(null);
				}
				return r_MCompute_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompute_GT_NativeArray_d_T_p__Int32_Int32;
		public static RMethod RMCompute_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCompute_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MCompute_GT_NativeArray_d_T_p__Int32_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_MCompute_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_MCompute_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](T[])
		/// </summary>
		protected static RMethod r_MCompute_GT_TArray;
		public static RMethod RMCompute_GT_TArray
		{
			get
			{
				if(r_MCompute_GT_TArray == null)
				{
					r_MCompute_GT_TArray = new(typeof(UnityEngine.Hash128), "Compute", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_MCompute_GT_TArray.SetBelong(null);
				}
				return r_MCompute_GT_TArray;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompute_GT_TArray_Int32_Int32;
		public static RMethod RMCompute_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_MCompute_GT_TArray_Int32_Int32 == null)
				{
					r_MCompute_GT_TArray_Int32_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MCompute_GT_TArray_Int32_Int32.SetBelong(null);
				}
				return r_MCompute_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected static RMethod r_MCompute_GT_List_d_T_p_;
		public static RMethod RMCompute_GT_List_d_T_p_
		{
			get
			{
				if(r_MCompute_GT_List_d_T_p_ == null)
				{
					r_MCompute_GT_List_d_T_p_ = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MCompute_GT_List_d_T_p_.SetBelong(null);
				}
				return r_MCompute_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](System.Collections.Generic.List`1[T], Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompute_GT_List_d_T_p__Int32_Int32;
		public static RMethod RMCompute_GT_List_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MCompute_GT_List_d_T_p__Int32_Int32 == null)
				{
					r_MCompute_GT_List_d_T_p__Int32_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_MCompute_GT_List_d_T_p__Int32_Int32.SetBelong(null);
				}
				return r_MCompute_GT_List_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute[T](T ByRef)
		/// </summary>
		protected static RMethod r_MCompute_GT_Ref_T;
		public static RMethod RMCompute_GT_Ref_T
		{
			get
			{
				if(r_MCompute_GT_Ref_T == null)
				{
					r_MCompute_GT_Ref_T = new(typeof(UnityEngine.Hash128), "Compute", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MCompute_GT_Ref_T.SetBelong(null);
				}
				return r_MCompute_GT_Ref_T;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(Int32)
		/// </summary>
		protected static RMethod r_MCompute_Int32;
		public static RMethod RMCompute_Int32
		{
			get
			{
				if(r_MCompute_Int32 == null)
				{
					r_MCompute_Int32 = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(System.Int32));
					r_MCompute_Int32.SetBelong(null);
				}
				return r_MCompute_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(Single)
		/// </summary>
		protected static RMethod r_MCompute_Single;
		public static RMethod RMCompute_Single
		{
			get
			{
				if(r_MCompute_Single == null)
				{
					r_MCompute_Single = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(System.Single));
					r_MCompute_Single.SetBelong(null);
				}
				return r_MCompute_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 Compute(Void*, UInt64)
		/// </summary>
		protected static RMethod r_MCompute_VoidPointer_UInt64;
		public static RMethod RMCompute_VoidPointer_UInt64
		{
			get
			{
				if(r_MCompute_VoidPointer_UInt64 == null)
				{
					r_MCompute_VoidPointer_UInt64 = new(typeof(UnityEngine.Hash128), "Compute", 0, typeof(void).MakePointerType(), typeof(System.UInt64));
					r_MCompute_VoidPointer_UInt64.SetBelong(null);
				}
				return r_MCompute_VoidPointer_UInt64;
			}
		}

		/// <summary>
		/// Void Append(System.String)
		/// </summary>
		protected RMethod r_MAppend_String;
		public virtual RMethod RMAppend_String
		{
			get
			{
				if(r_MAppend_String == null)
				{
					r_MAppend_String = new(this, "Append", 0, typeof(System.String));
					r_MAppend_String.SetBelong(this.instance);
				}
				return r_MAppend_String;
			}
		}

		/// <summary>
		/// Void Append[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MAppend_GT_NativeArray_d_T_p_;
		public virtual RMethod RMAppend_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MAppend_GT_NativeArray_d_T_p_ == null)
				{
					r_MAppend_GT_NativeArray_d_T_p_ = new(this, "Append", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MAppend_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_MAppend_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void Append[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MAppend_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMAppend_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MAppend_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MAppend_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "Append", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_MAppend_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_MAppend_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Append[T](T[])
		/// </summary>
		protected RMethod r_MAppend_GT_TArray;
		public virtual RMethod RMAppend_GT_TArray
		{
			get
			{
				if(r_MAppend_GT_TArray == null)
				{
					r_MAppend_GT_TArray = new(this, "Append", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_MAppend_GT_TArray.SetBelong(this.instance);
				}
				return r_MAppend_GT_TArray;
			}
		}

		/// <summary>
		/// Void Append[T](T[], Int32, Int32)
		/// </summary>
		protected RMethod r_MAppend_GT_TArray_Int32_Int32;
		public virtual RMethod RMAppend_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_MAppend_GT_TArray_Int32_Int32 == null)
				{
					r_MAppend_GT_TArray_Int32_Int32 = new(this, "Append", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MAppend_GT_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MAppend_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Append[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MAppend_GT_List_d_T_p_;
		public virtual RMethod RMAppend_GT_List_d_T_p_
		{
			get
			{
				if(r_MAppend_GT_List_d_T_p_ == null)
				{
					r_MAppend_GT_List_d_T_p_ = new(this, "Append", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MAppend_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_MAppend_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// Void Append[T](System.Collections.Generic.List`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MAppend_GT_List_d_T_p__Int32_Int32;
		public virtual RMethod RMAppend_GT_List_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MAppend_GT_List_d_T_p__Int32_Int32 == null)
				{
					r_MAppend_GT_List_d_T_p__Int32_Int32 = new(this, "Append", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_MAppend_GT_List_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_MAppend_GT_List_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void Append[T](T ByRef)
		/// </summary>
		protected RMethod r_MAppend_GT_Ref_T;
		public virtual RMethod RMAppend_GT_Ref_T
		{
			get
			{
				if(r_MAppend_GT_Ref_T == null)
				{
					r_MAppend_GT_Ref_T = new(this, "Append", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MAppend_GT_Ref_T.SetBelong(this.instance);
				}
				return r_MAppend_GT_Ref_T;
			}
		}

		/// <summary>
		/// Void Append(Int32)
		/// </summary>
		protected RMethod r_MAppend_Int32;
		public virtual RMethod RMAppend_Int32
		{
			get
			{
				if(r_MAppend_Int32 == null)
				{
					r_MAppend_Int32 = new(this, "Append", 0, typeof(System.Int32));
					r_MAppend_Int32.SetBelong(this.instance);
				}
				return r_MAppend_Int32;
			}
		}

		/// <summary>
		/// Void Append(Single)
		/// </summary>
		protected RMethod r_MAppend_Single;
		public virtual RMethod RMAppend_Single
		{
			get
			{
				if(r_MAppend_Single == null)
				{
					r_MAppend_Single = new(this, "Append", 0, typeof(System.Single));
					r_MAppend_Single.SetBelong(this.instance);
				}
				return r_MAppend_Single;
			}
		}

		/// <summary>
		/// Void Append(Void*, UInt64)
		/// </summary>
		protected RMethod r_MAppend_VoidPointer_UInt64;
		public virtual RMethod RMAppend_VoidPointer_UInt64
		{
			get
			{
				if(r_MAppend_VoidPointer_UInt64 == null)
				{
					r_MAppend_VoidPointer_UInt64 = new(this, "Append", 0, typeof(void).MakePointerType(), typeof(System.UInt64));
					r_MAppend_VoidPointer_UInt64.SetBelong(this.instance);
				}
				return r_MAppend_VoidPointer_UInt64;
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
		/// Boolean Equals(UnityEngine.Hash128)
		/// </summary>
		protected RMethod r_MEquals_Hash128;
		public virtual RMethod RMEquals_Hash128
		{
			get
			{
				if(r_MEquals_Hash128 == null)
				{
					r_MEquals_Hash128 = new(this, "Equals", 0, typeof(UnityEngine.Hash128));
					r_MEquals_Hash128.SetBelong(this.instance);
				}
				return r_MEquals_Hash128;
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
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Mop_Equality_Hash128_Hash128;
		public static RMethod RMop_Equality_Hash128_Hash128
		{
			get
			{
				if(r_Mop_Equality_Hash128_Hash128 == null)
				{
					r_Mop_Equality_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_Equality", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Mop_Equality_Hash128_Hash128.SetBelong(null);
				}
				return r_Mop_Equality_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Hash128_Hash128;
		public static RMethod RMop_Inequality_Hash128_Hash128
		{
			get
			{
				if(r_Mop_Inequality_Hash128_Hash128 == null)
				{
					r_Mop_Inequality_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_Inequality", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Mop_Inequality_Hash128_Hash128.SetBelong(null);
				}
				return r_Mop_Inequality_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Mop_LessThan_Hash128_Hash128;
		public static RMethod RMop_LessThan_Hash128_Hash128
		{
			get
			{
				if(r_Mop_LessThan_Hash128_Hash128 == null)
				{
					r_Mop_LessThan_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_LessThan", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Mop_LessThan_Hash128_Hash128.SetBelong(null);
				}
				return r_Mop_LessThan_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(UnityEngine.Hash128, UnityEngine.Hash128)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_Hash128_Hash128;
		public static RMethod RMop_GreaterThan_Hash128_Hash128
		{
			get
			{
				if(r_Mop_GreaterThan_Hash128_Hash128 == null)
				{
					r_Mop_GreaterThan_Hash128_Hash128 = new(typeof(UnityEngine.Hash128), "op_GreaterThan", 0, typeof(UnityEngine.Hash128), typeof(UnityEngine.Hash128));
					r_Mop_GreaterThan_Hash128_Hash128.SetBelong(null);
				}
				return r_Mop_GreaterThan_Hash128_Hash128;
			}
		}

		/// <summary>
		/// Void ShortHash4(UInt32)
		/// </summary>
		protected RMethod r_MShortHash4_UInt32;
		public virtual RMethod RMShortHash4_UInt32
		{
			get
			{
				if(r_MShortHash4_UInt32 == null)
				{
					r_MShortHash4_UInt32 = new(this, "ShortHash4", 0, typeof(System.UInt32));
					r_MShortHash4_UInt32.SetBelong(this.instance);
				}
				return r_MShortHash4_UInt32;
			}
		}

		/// <summary>
		/// Void ShortEnd(UInt64 ByRef, UInt64 ByRef, UInt64 ByRef, UInt64 ByRef)
		/// </summary>
		protected static RMethod r_MShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64;
		public static RMethod RMShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64
		{
			get
			{
				if(r_MShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64 == null)
				{
					r_MShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64 = new(typeof(UnityEngine.Hash128), "ShortEnd", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.UInt64).MakeByRefType());
					r_MShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64.SetBelong(null);
				}
				return r_MShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64;
			}
		}

		/// <summary>
		/// Void Rot64(UInt64 ByRef, Int32)
		/// </summary>
		protected static RMethod r_MRot64_Ref_UInt64_Int32;
		public static RMethod RMRot64_Ref_UInt64_Int32
		{
			get
			{
				if(r_MRot64_Ref_UInt64_Int32 == null)
				{
					r_MRot64_Ref_UInt64_Int32 = new(typeof(UnityEngine.Hash128), "Rot64", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.Int32));
					r_MRot64_Ref_UInt64_Int32.SetBelong(null);
				}
				return r_MRot64_Ref_UInt64_Int32;
			}
		}

		/// <summary>
		/// Void Parse_Injected(System.String, UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_MParse_Injected_String_Out_Hash128;
		public static RMethod RMParse_Injected_String_Out_Hash128
		{
			get
			{
				if(r_MParse_Injected_String_Out_Hash128 == null)
				{
					r_MParse_Injected_String_Out_Hash128 = new(typeof(UnityEngine.Hash128), "Parse_Injected", 0, typeof(System.String), typeof(UnityEngine.Hash128).MakeByRefType());
					r_MParse_Injected_String_Out_Hash128.SetBelong(null);
				}
				return r_MParse_Injected_String_Out_Hash128;
			}
		}

		/// <summary>
		/// System.String Hash128ToStringImpl_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected static RMethod r_MHash128ToStringImpl_Injected_Ref_Hash128;
		public static RMethod RMHash128ToStringImpl_Injected_Ref_Hash128
		{
			get
			{
				if(r_MHash128ToStringImpl_Injected_Ref_Hash128 == null)
				{
					r_MHash128ToStringImpl_Injected_Ref_Hash128 = new(typeof(UnityEngine.Hash128), "Hash128ToStringImpl_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_MHash128ToStringImpl_Injected_Ref_Hash128.SetBelong(null);
				}
				return r_MHash128ToStringImpl_Injected_Ref_Hash128;
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

        public virtual System.Int32 CompareTo(UnityEngine.Hash128 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = RMCompareTo_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Hash128 Parse(System.String @hashString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashString};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static System.String Hash128ToStringImpl(UnityEngine.Hash128 @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash};
            var ___result = RMHash128ToStringImpl_Hash128.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void ComputeFromString(System.String @data, ref UnityEngine.Hash128 @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @hash};
            var ___result = RMComputeFromString_String_Ref_Hash128.Invoke(___genericsType, ___parameters);
			@hash = (UnityEngine.Hash128)___parameters[1];

            
        }


        public static void ComputeFromPtr(System.IntPtr @data, System.Int32 @start, System.Int32 @count, System.Int32 @elemSize, ref UnityEngine.Hash128 @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @start, @count, @elemSize, @hash};
            var ___result = RMComputeFromPtr_IntPtr_Int32_Int32_Int32_Ref_Hash128.Invoke(___genericsType, ___parameters);
			@hash = (UnityEngine.Hash128)___parameters[4];

            
        }


        public static void ComputeFromArray(System.Array @data, System.Int32 @start, System.Int32 @count, System.Int32 @elemSize, ref UnityEngine.Hash128 @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @start, @count, @elemSize, @hash};
            var ___result = RMComputeFromArray_Array_Int32_Int32_Int32_Ref_Hash128.Invoke(___genericsType, ___parameters);
			@hash = (UnityEngine.Hash128)___parameters[4];

            
        }


        public static UnityEngine.Hash128 Compute(System.String @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMCompute_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMCompute_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @data, System.Int32 @start, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @start, @count};
            var ___result = RMCompute_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMCompute_GT_TArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> @data, System.Int32 @start, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @start, @count};
            var ___result = RMCompute_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMCompute_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RType> @data, System.Int32 @start, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @start, @count};
            var ___result = RMCompute_GT_List_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute<T>(ref SMFrame.Editor.Refleaction.RType @val) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@val.Value};
            var ___result = RMCompute_GT_Ref_T.Invoke(___genericsType, ___parameters);
			@val = new SMFrame.Editor.Refleaction.RType(___parameters[0]);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute(System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMCompute_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public static UnityEngine.Hash128 Compute(System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMCompute_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public unsafe static UnityEngine.Hash128 Compute(void* @data, System.UInt64 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@data, typeof(void)), @size};
            var ___result = RMCompute_VoidPointer_UInt64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Hash128)___result;
        }


        public virtual void Append(System.String @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMAppend_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMAppend_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RType> @data, System.Int32 @start, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @start, @count};
            var ___result = RMAppend_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMAppend_GT_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RType> @data, System.Int32 @start, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @start, @count};
            var ___result = RMAppend_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMAppend_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RType> @data, System.Int32 @start, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @start, @count};
            var ___result = RMAppend_GT_List_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append<T>(ref SMFrame.Editor.Refleaction.RType @val) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@val.Value};
            var ___result = RMAppend_GT_Ref_T.Invoke(___genericsType, ___parameters);
			@val = new SMFrame.Editor.Refleaction.RType(___parameters[0]);

            
        }


        public virtual void Append(System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMAppend_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Append(System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMAppend_Single.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void Append(void* @data, System.UInt64 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@data, typeof(void)), @size};
            var ___result = RMAppend_VoidPointer_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Hash128 @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Hash128 @hash1, UnityEngine.Hash128 @hash2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash1, @hash2};
            var ___result = RMop_Equality_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Hash128 @hash1, UnityEngine.Hash128 @hash2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash1, @hash2};
            var ___result = RMop_Inequality_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(UnityEngine.Hash128 @x, UnityEngine.Hash128 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMop_LessThan_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(UnityEngine.Hash128 @x, UnityEngine.Hash128 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMop_GreaterThan_Hash128_Hash128.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShortHash4(System.UInt32 @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMShortHash4_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ShortEnd(ref System.UInt64 @h0, ref System.UInt64 @h1, ref System.UInt64 @h2, ref System.UInt64 @h3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h0, @h1, @h2, @h3};
            var ___result = RMShortEnd_Ref_UInt64_Ref_UInt64_Ref_UInt64_Ref_UInt64.Invoke(___genericsType, ___parameters);
			@h0 = (System.UInt64)___parameters[0];
			@h1 = (System.UInt64)___parameters[1];
			@h2 = (System.UInt64)___parameters[2];
			@h3 = (System.UInt64)___parameters[3];

            
        }


        public static void Rot64(ref System.UInt64 @x, System.Int32 @k)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @k};
            var ___result = RMRot64_Ref_UInt64_Int32.Invoke(___genericsType, ___parameters);
			@x = (System.UInt64)___parameters[0];

            
        }


        public static void Parse_Injected(System.String @hashString, out UnityEngine.Hash128 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashString, @ret};
            var ___result = RMParse_Injected_String_Out_Hash128.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Hash128)___parameters[1];

            
        }


        public static System.String Hash128ToStringImpl_Injected(ref UnityEngine.Hash128 @hash)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hash};
            var ___result = RMHash128ToStringImpl_Injected_Ref_Hash128.Invoke(___genericsType, ___parameters);
			@hash = (UnityEngine.Hash128)___parameters[0];

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