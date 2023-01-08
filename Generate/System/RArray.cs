using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Array
	/// </summary>
    public partial class RArray : RMember //
    {

		/// <summary>
		/// Int32 System.Collections.ICollection.Count
		/// </summary>
		protected RProperty r_System__2__Collections__2__ICollection__2__Count;
		public virtual RProperty RSystem__2__Collections__2__ICollection__2__Count
		{
			get
			{
				if(r_System__2__Collections__2__ICollection__2__Count == null)
				{
					r_System__2__Collections__2__ICollection__2__Count = new(this, "System.Collections.ICollection.Count", -1);
					r_System__2__Collections__2__ICollection__2__Count.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__ICollection__2__Count;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsReadOnly
		/// </summary>
		protected RProperty r_System__2__Collections__2__IList__2__IsReadOnly;
		public virtual RProperty RSystem__2__Collections__2__IList__2__IsReadOnly
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__IsReadOnly == null)
				{
					r_System__2__Collections__2__IList__2__IsReadOnly = new(this, "System.Collections.IList.IsReadOnly", -1);
					r_System__2__Collections__2__IList__2__IsReadOnly.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__IsReadOnly;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__IList__2__Item_Int32;
		public virtual RSystem.RObject RSystem__2__Collections__2__IList__2__Item_Int32
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Item_Int32 == null)
				{
					r_System__2__Collections__2__IList__2__Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_System__2__Collections__2__IList__2__Item_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Item_Int32;
			}
		}

		/// <summary>
		/// Int64 LongLength
		/// </summary>
		protected RProperty r_LongLength;
		public virtual RProperty RLongLength
		{
			get
			{
				if(r_LongLength == null)
				{
					r_LongLength = new(this, "LongLength", -1);
					r_LongLength.SetBelong(this.instance);
				}
				return r_LongLength;
			}
		}

		/// <summary>
		/// Boolean IsFixedSize
		/// </summary>
		protected RProperty r_IsFixedSize;
		public virtual RProperty RIsFixedSize
		{
			get
			{
				if(r_IsFixedSize == null)
				{
					r_IsFixedSize = new(this, "IsFixedSize", -1);
					r_IsFixedSize.SetBelong(this.instance);
				}
				return r_IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
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
		/// Int32 Rank
		/// </summary>
		protected RProperty r_Rank;
		public virtual RProperty RRank
		{
			get
			{
				if(r_Rank == null)
				{
					r_Rank = new(this, "Rank", -1);
					r_Rank.SetBelong(this.instance);
				}
				return r_Rank;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int64[])
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Int64Array;
		public static RMethod RCreateInstance_Type_Int64Array
		{
			get
			{
				if(r_CreateInstance_Type_Int64Array == null)
				{
					r_CreateInstance_Type_Int64Array = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int64).MakeArrayType());
					r_CreateInstance_Type_Int64Array.SetBelong(null);
				}
				return r_CreateInstance_Type_Int64Array;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[T] AsReadOnly[T](T[])
		/// </summary>
		protected static RMethod r_AsReadOnly_GT_TArray;
		public static RMethod RAsReadOnly_GT_TArray
		{
			get
			{
				if(r_AsReadOnly_GT_TArray == null)
				{
					r_AsReadOnly_GT_TArray = new(typeof(System.Array), "AsReadOnly", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_AsReadOnly_GT_TArray.SetBelong(null);
				}
				return r_AsReadOnly_GT_TArray;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32)
		/// </summary>
		protected static RMethod r_Resize_GT_Ref_TArray_Int32;
		public static RMethod RResize_GT_Ref_TArray_Int32
		{
			get
			{
				if(r_Resize_GT_Ref_TArray_Int32 == null)
				{
					r_Resize_GT_Ref_TArray_Int32 = new(typeof(System.Array), "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32));
					r_Resize_GT_Ref_TArray_Int32.SetBelong(null);
				}
				return r_Resize_GT_Ref_TArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Add_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Add_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Add_Object == null)
				{
					r_System__2__Collections__2__IList__2__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__Add_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Add_Object;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Contains_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Contains_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Contains_Object == null)
				{
					r_System__2__Collections__2__IList__2__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__Contains_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Contains_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Clear()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Clear;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Clear
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Clear == null)
				{
					r_System__2__Collections__2__IList__2__Clear = new(this, "System.Collections.IList.Clear", 0);
					r_System__2__Collections__2__IList__2__Clear.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Clear;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__IndexOf_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__IndexOf_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__IndexOf_Object == null)
				{
					r_System__2__Collections__2__IList__2__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__IndexOf_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__IndexOf_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Insert_Int32_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Insert_Int32_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Insert_Int32_Object == null)
				{
					r_System__2__Collections__2__IList__2__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_System__2__Collections__2__IList__2__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__Remove_Object;
		public virtual RMethod RSystem__2__Collections__2__IList__2__Remove_Object
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__Remove_Object == null)
				{
					r_System__2__Collections__2__IList__2__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_System__2__Collections__2__IList__2__Remove_Object.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__Remove_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IList__2__RemoveAt_Int32;
		public virtual RMethod RSystem__2__Collections__2__IList__2__RemoveAt_Int32
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__RemoveAt_Int32 == null)
				{
					r_System__2__Collections__2__IList__2__RemoveAt_Int32 = new(this, "System.Collections.IList.RemoveAt", 0, typeof(System.Int32));
					r_System__2__Collections__2__IList__2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_CopyTo_Array_Int32 == null)
				{
					r_CopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IStructuralComparable.CompareTo(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer;
		public virtual RMethod RSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer
		{
			get
			{
				if(r_System__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer == null)
				{
					r_System__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer = new(this, "System.Collections.IStructuralComparable.CompareTo", 0, typeof(System.Object), typeof(System.Collections.IComparer));
					r_System__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IStructuralEquatable.Equals(System.Object, System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer;
		public virtual RMethod RSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer
		{
			get
			{
				if(r_System__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer == null)
				{
					r_System__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer = new(this, "System.Collections.IStructuralEquatable.Equals", 0, typeof(System.Object), typeof(System.Collections.IEqualityComparer));
					r_System__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 CombineHashCodes(Int32, Int32)
		/// </summary>
		protected static RMethod r_CombineHashCodes_Int32_Int32;
		public static RMethod RCombineHashCodes_Int32_Int32
		{
			get
			{
				if(r_CombineHashCodes_Int32_Int32 == null)
				{
					r_CombineHashCodes_Int32_Int32 = new(typeof(System.Array), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32));
					r_CombineHashCodes_Int32_Int32.SetBelong(null);
				}
				return r_CombineHashCodes_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_System__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer;
		public virtual RMethod RSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer
		{
			get
			{
				if(r_System__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer == null)
				{
					r_System__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer = new(this, "System.Collections.IStructuralEquatable.GetHashCode", 0, typeof(System.Collections.IEqualityComparer));
					r_System__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_BinarySearch_Array_Object;
		public static RMethod RBinarySearch_Array_Object
		{
			get
			{
				if(r_BinarySearch_Array_Object == null)
				{
					r_BinarySearch_Array_Object = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Object));
					r_BinarySearch_Array_Object.SetBelong(null);
				}
				return r_BinarySearch_Array_Object;
			}
		}

		/// <summary>
		/// TOutput[] ConvertAll[TInput,TOutput](TInput[], System.Converter`2[TInput,TOutput])
		/// </summary>
		protected static RMethod r_ConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_;
		public static RMethod RConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_
		{
			get
			{
				if(r_ConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_ == null)
				{
					r_ConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_ = new(typeof(System.Array), "ConvertAll", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Converter<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
					r_ConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_.SetBelong(null);
				}
				return r_ConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, System.Array, Int64)
		/// </summary>
		protected static RMethod r_Copy_Array_Array_Int64;
		public static RMethod RCopy_Array_Array_Int64
		{
			get
			{
				if(r_Copy_Array_Array_Int64 == null)
				{
					r_Copy_Array_Array_Int64 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int64));
					r_Copy_Array_Array_Int64.SetBelong(null);
				}
				return r_Copy_Array_Array_Int64;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, Int64, System.Array, Int64, Int64)
		/// </summary>
		protected static RMethod r_Copy_Array_Int64_Array_Int64_Int64;
		public static RMethod RCopy_Array_Int64_Array_Int64_Int64
		{
			get
			{
				if(r_Copy_Array_Int64_Array_Int64_Int64 == null)
				{
					r_Copy_Array_Int64_Array_Int64_Int64 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Int64), typeof(System.Array), typeof(System.Int64), typeof(System.Int64));
					r_Copy_Array_Int64_Array_Int64_Int64.SetBelong(null);
				}
				return r_Copy_Array_Int64_Array_Int64_Int64;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int64)
		/// </summary>
		protected RMethod r_CopyTo_Array_Int64;
		public virtual RMethod RCopyTo_Array_Int64
		{
			get
			{
				if(r_CopyTo_Array_Int64 == null)
				{
					r_CopyTo_Array_Int64 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int64));
					r_CopyTo_Array_Int64.SetBelong(this.instance);
				}
				return r_CopyTo_Array_Int64;
			}
		}

		/// <summary>
		/// Void ForEach[T](T[], System.Action`1[T])
		/// </summary>
		protected static RMethod r_ForEach_GT_TArray_Action_d_T_p_;
		public static RMethod RForEach_GT_TArray_Action_d_T_p_
		{
			get
			{
				if(r_ForEach_GT_TArray_Action_d_T_p_ == null)
				{
					r_ForEach_GT_TArray_Action_d_T_p_ = new(typeof(System.Array), "ForEach", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Action<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ForEach_GT_TArray_Action_d_T_p_.SetBelong(null);
				}
				return r_ForEach_GT_TArray_Action_d_T_p_;
			}
		}

		/// <summary>
		/// Int64 GetLongLength(Int32)
		/// </summary>
		protected RMethod r_GetLongLength_Int32;
		public virtual RMethod RGetLongLength_Int32
		{
			get
			{
				if(r_GetLongLength_Int32 == null)
				{
					r_GetLongLength_Int32 = new(this, "GetLongLength", 0, typeof(System.Int32));
					r_GetLongLength_Int32.SetBelong(this.instance);
				}
				return r_GetLongLength_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64)
		/// </summary>
		protected RMethod r_GetValue_Int64;
		public virtual RMethod RGetValue_Int64
		{
			get
			{
				if(r_GetValue_Int64 == null)
				{
					r_GetValue_Int64 = new(this, "GetValue", 0, typeof(System.Int64));
					r_GetValue_Int64.SetBelong(this.instance);
				}
				return r_GetValue_Int64;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64, Int64)
		/// </summary>
		protected RMethod r_GetValue_Int64_Int64;
		public virtual RMethod RGetValue_Int64_Int64
		{
			get
			{
				if(r_GetValue_Int64_Int64 == null)
				{
					r_GetValue_Int64_Int64 = new(this, "GetValue", 0, typeof(System.Int64), typeof(System.Int64));
					r_GetValue_Int64_Int64.SetBelong(this.instance);
				}
				return r_GetValue_Int64_Int64;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_GetValue_Int64_Int64_Int64;
		public virtual RMethod RGetValue_Int64_Int64_Int64
		{
			get
			{
				if(r_GetValue_Int64_Int64_Int64 == null)
				{
					r_GetValue_Int64_Int64_Int64 = new(this, "GetValue", 0, typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_GetValue_Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_GetValue_Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64[])
		/// </summary>
		protected RMethod r_GetValue_Int64Array;
		public virtual RMethod RGetValue_Int64Array
		{
			get
			{
				if(r_GetValue_Int64Array == null)
				{
					r_GetValue_Int64Array = new(this, "GetValue", 0, typeof(System.Int64).MakeArrayType());
					r_GetValue_Int64Array.SetBelong(this.instance);
				}
				return r_GetValue_Int64Array;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, Int32, Int32, System.Object)
		/// </summary>
		protected static RMethod r_BinarySearch_Array_Int32_Int32_Object;
		public static RMethod RBinarySearch_Array_Int32_Int32_Object
		{
			get
			{
				if(r_BinarySearch_Array_Int32_Int32_Object == null)
				{
					r_BinarySearch_Array_Int32_Int32_Object = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Object));
					r_BinarySearch_Array_Int32_Int32_Object.SetBelong(null);
				}
				return r_BinarySearch_Array_Int32_Int32_Object;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, System.Object, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_BinarySearch_Array_Object_IComparer;
		public static RMethod RBinarySearch_Array_Object_IComparer
		{
			get
			{
				if(r_BinarySearch_Array_Object_IComparer == null)
				{
					r_BinarySearch_Array_Object_IComparer = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Object), typeof(System.Collections.IComparer));
					r_BinarySearch_Array_Object_IComparer.SetBelong(null);
				}
				return r_BinarySearch_Array_Object_IComparer;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, Int32, Int32, System.Object, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_BinarySearch_Array_Int32_Int32_Object_IComparer;
		public static RMethod RBinarySearch_Array_Int32_Int32_Object_IComparer
		{
			get
			{
				if(r_BinarySearch_Array_Int32_Int32_Object_IComparer == null)
				{
					r_BinarySearch_Array_Int32_Int32_Object_IComparer = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Object), typeof(System.Collections.IComparer));
					r_BinarySearch_Array_Int32_Int32_Object_IComparer.SetBelong(null);
				}
				return r_BinarySearch_Array_Int32_Int32_Object_IComparer;
			}
		}

		/// <summary>
		/// Int32 GetMedian(Int32, Int32)
		/// </summary>
		protected static RMethod r_GetMedian_Int32_Int32;
		public static RMethod RGetMedian_Int32_Int32
		{
			get
			{
				if(r_GetMedian_Int32_Int32 == null)
				{
					r_GetMedian_Int32_Int32 = new(typeof(System.Array), "GetMedian", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetMedian_Int32_Int32.SetBelong(null);
				}
				return r_GetMedian_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], T)
		/// </summary>
		protected static RMethod r_BinarySearch_GT_TArray_T;
		public static RMethod RBinarySearch_GT_TArray_T
		{
			get
			{
				if(r_BinarySearch_GT_TArray_T == null)
				{
					r_BinarySearch_GT_TArray_T = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_BinarySearch_GT_TArray_T.SetBelong(null);
				}
				return r_BinarySearch_GT_TArray_T;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_BinarySearch_GT_TArray_T_IComparer_d_T_p_;
		public static RMethod RBinarySearch_GT_TArray_T_IComparer_d_T_p_
		{
			get
			{
				if(r_BinarySearch_GT_TArray_T_IComparer_d_T_p_ == null)
				{
					r_BinarySearch_GT_TArray_T_IComparer_d_T_p_ = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_BinarySearch_GT_TArray_T_IComparer_d_T_p_.SetBelong(null);
				}
				return r_BinarySearch_GT_TArray_T_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], Int32, Int32, T)
		/// </summary>
		protected static RMethod r_BinarySearch_GT_TArray_Int32_Int32_T;
		public static RMethod RBinarySearch_GT_TArray_Int32_Int32_T
		{
			get
			{
				if(r_BinarySearch_GT_TArray_Int32_Int32_T == null)
				{
					r_BinarySearch_GT_TArray_Int32_Int32_T = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_BinarySearch_GT_TArray_Int32_Int32_T.SetBelong(null);
				}
				return r_BinarySearch_GT_TArray_Int32_Int32_T;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], Int32, Int32, T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_BinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_;
		public static RMethod RBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_
		{
			get
			{
				if(r_BinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_ == null)
				{
					r_BinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_ = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_BinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_.SetBelong(null);
				}
				return r_BinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_IndexOf_Array_Object;
		public static RMethod RIndexOf_Array_Object
		{
			get
			{
				if(r_IndexOf_Array_Object == null)
				{
					r_IndexOf_Array_Object = new(typeof(System.Array), "IndexOf", 0, typeof(System.Array), typeof(System.Object));
					r_IndexOf_Array_Object.SetBelong(null);
				}
				return r_IndexOf_Array_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Array, System.Object, Int32)
		/// </summary>
		protected static RMethod r_IndexOf_Array_Object_Int32;
		public static RMethod RIndexOf_Array_Object_Int32
		{
			get
			{
				if(r_IndexOf_Array_Object_Int32 == null)
				{
					r_IndexOf_Array_Object_Int32 = new(typeof(System.Array), "IndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32));
					r_IndexOf_Array_Object_Int32.SetBelong(null);
				}
				return r_IndexOf_Array_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Array, System.Object, Int32, Int32)
		/// </summary>
		protected static RMethod r_IndexOf_Array_Object_Int32_Int32;
		public static RMethod RIndexOf_Array_Object_Int32_Int32
		{
			get
			{
				if(r_IndexOf_Array_Object_Int32_Int32 == null)
				{
					r_IndexOf_Array_Object_Int32_Int32 = new(typeof(System.Array), "IndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_Array_Object_Int32_Int32.SetBelong(null);
				}
				return r_IndexOf_Array_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf[T](T[], T)
		/// </summary>
		protected static RMethod r_IndexOf_GT_TArray_T;
		public static RMethod RIndexOf_GT_TArray_T
		{
			get
			{
				if(r_IndexOf_GT_TArray_T == null)
				{
					r_IndexOf_GT_TArray_T = new(typeof(System.Array), "IndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_IndexOf_GT_TArray_T.SetBelong(null);
				}
				return r_IndexOf_GT_TArray_T;
			}
		}

		/// <summary>
		/// Int32 IndexOf[T](T[], T, Int32)
		/// </summary>
		protected static RMethod r_IndexOf_GT_TArray_T_Int32;
		public static RMethod RIndexOf_GT_TArray_T_Int32
		{
			get
			{
				if(r_IndexOf_GT_TArray_T_Int32 == null)
				{
					r_IndexOf_GT_TArray_T_Int32 = new(typeof(System.Array), "IndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32));
					r_IndexOf_GT_TArray_T_Int32.SetBelong(null);
				}
				return r_IndexOf_GT_TArray_T_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_IndexOf_GT_TArray_T_Int32_Int32;
		public static RMethod RIndexOf_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_IndexOf_GT_TArray_T_Int32_Int32 == null)
				{
					r_IndexOf_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "IndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_IndexOf_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_LastIndexOf_Array_Object;
		public static RMethod RLastIndexOf_Array_Object
		{
			get
			{
				if(r_LastIndexOf_Array_Object == null)
				{
					r_LastIndexOf_Array_Object = new(typeof(System.Array), "LastIndexOf", 0, typeof(System.Array), typeof(System.Object));
					r_LastIndexOf_Array_Object.SetBelong(null);
				}
				return r_LastIndexOf_Array_Object;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Array, System.Object, Int32)
		/// </summary>
		protected static RMethod r_LastIndexOf_Array_Object_Int32;
		public static RMethod RLastIndexOf_Array_Object_Int32
		{
			get
			{
				if(r_LastIndexOf_Array_Object_Int32 == null)
				{
					r_LastIndexOf_Array_Object_Int32 = new(typeof(System.Array), "LastIndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32));
					r_LastIndexOf_Array_Object_Int32.SetBelong(null);
				}
				return r_LastIndexOf_Array_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Array, System.Object, Int32, Int32)
		/// </summary>
		protected static RMethod r_LastIndexOf_Array_Object_Int32_Int32;
		public static RMethod RLastIndexOf_Array_Object_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_Array_Object_Int32_Int32 == null)
				{
					r_LastIndexOf_Array_Object_Int32_Int32 = new(typeof(System.Array), "LastIndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_Array_Object_Int32_Int32.SetBelong(null);
				}
				return r_LastIndexOf_Array_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf[T](T[], T)
		/// </summary>
		protected static RMethod r_LastIndexOf_GT_TArray_T;
		public static RMethod RLastIndexOf_GT_TArray_T
		{
			get
			{
				if(r_LastIndexOf_GT_TArray_T == null)
				{
					r_LastIndexOf_GT_TArray_T = new(typeof(System.Array), "LastIndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_LastIndexOf_GT_TArray_T.SetBelong(null);
				}
				return r_LastIndexOf_GT_TArray_T;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf[T](T[], T, Int32)
		/// </summary>
		protected static RMethod r_LastIndexOf_GT_TArray_T_Int32;
		public static RMethod RLastIndexOf_GT_TArray_T_Int32
		{
			get
			{
				if(r_LastIndexOf_GT_TArray_T_Int32 == null)
				{
					r_LastIndexOf_GT_TArray_T_Int32 = new(typeof(System.Array), "LastIndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32));
					r_LastIndexOf_GT_TArray_T_Int32.SetBelong(null);
				}
				return r_LastIndexOf_GT_TArray_T_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_LastIndexOf_GT_TArray_T_Int32_Int32;
		public static RMethod RLastIndexOf_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_GT_TArray_T_Int32_Int32 == null)
				{
					r_LastIndexOf_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "LastIndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_LastIndexOf_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Reverse(System.Array)
		/// </summary>
		protected static RMethod r_Reverse_Array;
		public static RMethod RReverse_Array
		{
			get
			{
				if(r_Reverse_Array == null)
				{
					r_Reverse_Array = new(typeof(System.Array), "Reverse", 0, typeof(System.Array));
					r_Reverse_Array.SetBelong(null);
				}
				return r_Reverse_Array;
			}
		}

		/// <summary>
		/// Void Reverse(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_Reverse_Array_Int32_Int32;
		public static RMethod RReverse_Array_Int32_Int32
		{
			get
			{
				if(r_Reverse_Array_Int32_Int32 == null)
				{
					r_Reverse_Array_Int32_Int32 = new(typeof(System.Array), "Reverse", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_Reverse_Array_Int32_Int32.SetBelong(null);
				}
				return r_Reverse_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Reverse[T](T[])
		/// </summary>
		protected static RMethod r_Reverse_GT_TArray;
		public static RMethod RReverse_GT_TArray
		{
			get
			{
				if(r_Reverse_GT_TArray == null)
				{
					r_Reverse_GT_TArray = new(typeof(System.Array), "Reverse", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Reverse_GT_TArray.SetBelong(null);
				}
				return r_Reverse_GT_TArray;
			}
		}

		/// <summary>
		/// Void Reverse[T](T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Reverse_GT_TArray_Int32_Int32;
		public static RMethod RReverse_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_Reverse_GT_TArray_Int32_Int32 == null)
				{
					r_Reverse_GT_TArray_Int32_Int32 = new(typeof(System.Array), "Reverse", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Reverse_GT_TArray_Int32_Int32.SetBelong(null);
				}
				return r_Reverse_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64)
		/// </summary>
		protected RMethod r_SetValue_Object_Int64;
		public virtual RMethod RSetValue_Object_Int64
		{
			get
			{
				if(r_SetValue_Object_Int64 == null)
				{
					r_SetValue_Object_Int64 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64));
					r_SetValue_Object_Int64.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int64;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64, Int64)
		/// </summary>
		protected RMethod r_SetValue_Object_Int64_Int64;
		public virtual RMethod RSetValue_Object_Int64_Int64
		{
			get
			{
				if(r_SetValue_Object_Int64_Int64 == null)
				{
					r_SetValue_Object_Int64_Int64 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64), typeof(System.Int64));
					r_SetValue_Object_Int64_Int64.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int64_Int64;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_SetValue_Object_Int64_Int64_Int64;
		public virtual RMethod RSetValue_Object_Int64_Int64_Int64
		{
			get
			{
				if(r_SetValue_Object_Int64_Int64_Int64 == null)
				{
					r_SetValue_Object_Int64_Int64_Int64 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_SetValue_Object_Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64[])
		/// </summary>
		protected RMethod r_SetValue_Object_Int64Array;
		public virtual RMethod RSetValue_Object_Int64Array
		{
			get
			{
				if(r_SetValue_Object_Int64Array == null)
				{
					r_SetValue_Object_Int64Array = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64).MakeArrayType());
					r_SetValue_Object_Int64Array.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int64Array;
			}
		}

		/// <summary>
		/// Void Sort(System.Array)
		/// </summary>
		protected static RMethod r_Sort_Array;
		public static RMethod RSort_Array
		{
			get
			{
				if(r_Sort_Array == null)
				{
					r_Sort_Array = new(typeof(System.Array), "Sort", 0, typeof(System.Array));
					r_Sort_Array.SetBelong(null);
				}
				return r_Sort_Array;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_Sort_Array_Int32_Int32;
		public static RMethod RSort_Array_Int32_Int32
		{
			get
			{
				if(r_Sort_Array_Int32_Int32 == null)
				{
					r_Sort_Array_Int32_Int32 = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_Sort_Array_Int32_Int32.SetBelong(null);
				}
				return r_Sort_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_Sort_Array_IComparer;
		public static RMethod RSort_Array_IComparer
		{
			get
			{
				if(r_Sort_Array_IComparer == null)
				{
					r_Sort_Array_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Collections.IComparer));
					r_Sort_Array_IComparer.SetBelong(null);
				}
				return r_Sort_Array_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_Sort_Array_Int32_Int32_IComparer;
		public static RMethod RSort_Array_Int32_Int32_IComparer
		{
			get
			{
				if(r_Sort_Array_Int32_Int32_IComparer == null)
				{
					r_Sort_Array_Int32_Int32_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_Sort_Array_Int32_Int32_IComparer.SetBelong(null);
				}
				return r_Sort_Array_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array)
		/// </summary>
		protected static RMethod r_Sort_Array_Array;
		public static RMethod RSort_Array_Array
		{
			get
			{
				if(r_Sort_Array_Array == null)
				{
					r_Sort_Array_Array = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array));
					r_Sort_Array_Array.SetBelong(null);
				}
				return r_Sort_Array_Array;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_Sort_Array_Array_IComparer;
		public static RMethod RSort_Array_Array_IComparer
		{
			get
			{
				if(r_Sort_Array_Array_IComparer == null)
				{
					r_Sort_Array_Array_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array), typeof(System.Collections.IComparer));
					r_Sort_Array_Array_IComparer.SetBelong(null);
				}
				return r_Sort_Array_Array_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_Sort_Array_Array_Int32_Int32;
		public static RMethod RSort_Array_Array_Int32_Int32
		{
			get
			{
				if(r_Sort_Array_Array_Int32_Int32 == null)
				{
					r_Sort_Array_Array_Int32_Int32 = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_Sort_Array_Array_Int32_Int32.SetBelong(null);
				}
				return r_Sort_Array_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array, Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_Sort_Array_Array_Int32_Int32_IComparer;
		public static RMethod RSort_Array_Array_Int32_Int32_IComparer
		{
			get
			{
				if(r_Sort_Array_Array_Int32_Int32_IComparer == null)
				{
					r_Sort_Array_Array_Int32_Int32_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_Sort_Array_Array_Int32_Int32_IComparer.SetBelong(null);
				}
				return r_Sort_Array_Array_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// Void Sort[T](T[])
		/// </summary>
		protected static RMethod r_Sort_GT_TArray;
		public static RMethod RSort_GT_TArray
		{
			get
			{
				if(r_Sort_GT_TArray == null)
				{
					r_Sort_GT_TArray = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_Sort_GT_TArray.SetBelong(null);
				}
				return r_Sort_GT_TArray;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Sort_GT_TArray_Int32_Int32;
		public static RMethod RSort_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_Sort_GT_TArray_Int32_Int32 == null)
				{
					r_Sort_GT_TArray_Int32_Int32 = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Sort_GT_TArray_Int32_Int32.SetBelong(null);
				}
				return r_Sort_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_Sort_GT_TArray_IComparer_d_T_p_;
		public static RMethod RSort_GT_TArray_IComparer_d_T_p_
		{
			get
			{
				if(r_Sort_GT_TArray_IComparer_d_T_p_ == null)
				{
					r_Sort_GT_TArray_IComparer_d_T_p_ = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_GT_TArray_IComparer_d_T_p_.SetBelong(null);
				}
				return r_Sort_GT_TArray_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], Int32, Int32, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_Sort_GT_TArray_Int32_Int32_IComparer_d_T_p_;
		public static RMethod RSort_GT_TArray_Int32_Int32_IComparer_d_T_p_
		{
			get
			{
				if(r_Sort_GT_TArray_Int32_Int32_IComparer_d_T_p_ == null)
				{
					r_Sort_GT_TArray_Int32_Int32_IComparer_d_T_p_ = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_GT_TArray_Int32_Int32_IComparer_d_T_p_.SetBelong(null);
				}
				return r_Sort_GT_TArray_Int32_Int32_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], System.Comparison`1[T])
		/// </summary>
		protected static RMethod r_Sort_GT_TArray_Comparison_d_T_p_;
		public static RMethod RSort_GT_TArray_Comparison_d_T_p_
		{
			get
			{
				if(r_Sort_GT_TArray_Comparison_d_T_p_ == null)
				{
					r_Sort_GT_TArray_Comparison_d_T_p_ = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Comparison<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_GT_TArray_Comparison_d_T_p_.SetBelong(null);
				}
				return r_Sort_GT_TArray_Comparison_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[])
		/// </summary>
		protected static RMethod r_Sort_GTKey_GTValue_TKeyArray_TValueArray;
		public static RMethod RSort_GTKey_GTValue_TKeyArray_TValueArray
		{
			get
			{
				if(r_Sort_GTKey_GTValue_TKeyArray_TValueArray == null)
				{
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType());
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray.SetBelong(null);
				}
				return r_Sort_GTKey_GTValue_TKeyArray_TValueArray;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32;
		public static RMethod RSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32
		{
			get
			{
				if(r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32 == null)
				{
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32 = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32.SetBelong(null);
				}
				return r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[], System.Collections.Generic.IComparer`1[TKey])
		/// </summary>
		protected static RMethod r_Sort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_;
		public static RMethod RSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_
		{
			get
			{
				if(r_Sort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_ == null)
				{
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_ = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_.SetBelong(null);
				}
				return r_Sort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[], Int32, Int32, System.Collections.Generic.IComparer`1[TKey])
		/// </summary>
		protected static RMethod r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_;
		public static RMethod RSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_
		{
			get
			{
				if(r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_ == null)
				{
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_ = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_.SetBelong(null);
				}
				return r_Sort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_;
			}
		}

		/// <summary>
		/// Boolean Exists[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_Exists_GT_TArray_Predicate_d_T_p_;
		public static RMethod RExists_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_Exists_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_Exists_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "Exists", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Exists_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_Exists_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void Fill[T](T[], T)
		/// </summary>
		protected static RMethod r_Fill_GT_TArray_T;
		public static RMethod RFill_GT_TArray_T
		{
			get
			{
				if(r_Fill_GT_TArray_T == null)
				{
					r_Fill_GT_TArray_T = new(typeof(System.Array), "Fill", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_Fill_GT_TArray_T.SetBelong(null);
				}
				return r_Fill_GT_TArray_T;
			}
		}

		/// <summary>
		/// Void Fill[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_Fill_GT_TArray_T_Int32_Int32;
		public static RMethod RFill_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_Fill_GT_TArray_T_Int32_Int32 == null)
				{
					r_Fill_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "Fill", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_Fill_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_Fill_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// T Find[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_Find_GT_TArray_Predicate_d_T_p_;
		public static RMethod RFind_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_Find_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_Find_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "Find", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Find_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_Find_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T[] FindAll[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindAll_GT_TArray_Predicate_d_T_p_;
		public static RMethod RFindAll_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_FindAll_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_FindAll_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindAll", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindAll_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindAll_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindIndex_GT_TArray_Predicate_d_T_p_;
		public static RMethod RFindIndex_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_FindIndex_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_FindIndex_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindIndex_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindIndex_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex[T](T[], Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindIndex_GT_TArray_Int32_Predicate_d_T_p_;
		public static RMethod RFindIndex_GT_TArray_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindIndex_GT_TArray_Int32_Predicate_d_T_p_ == null)
				{
					r_FindIndex_GT_TArray_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindIndex_GT_TArray_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindIndex_GT_TArray_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex[T](T[], Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
		public static RMethod RFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_FindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T FindLast[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindLast_GT_TArray_Predicate_d_T_p_;
		public static RMethod RFindLast_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLast_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_FindLast_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindLast", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLast_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindLast_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindLastIndex_GT_TArray_Predicate_d_T_p_;
		public static RMethod RFindLastIndex_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLastIndex_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_FindLastIndex_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindLastIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLastIndex_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindLastIndex_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex[T](T[], Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindLastIndex_GT_TArray_Int32_Predicate_d_T_p_;
		public static RMethod RFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLastIndex_GT_TArray_Int32_Predicate_d_T_p_ == null)
				{
					r_FindLastIndex_GT_TArray_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindLastIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLastIndex_GT_TArray_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindLastIndex_GT_TArray_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex[T](T[], Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_FindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
		public static RMethod RFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_FindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_FindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindLastIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_FindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_FindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TrueForAll[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_TrueForAll_GT_TArray_Predicate_d_T_p_;
		public static RMethod RTrueForAll_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_TrueForAll_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_TrueForAll_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "TrueForAll", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_TrueForAll_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_TrueForAll_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
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
		/// Int32 InternalArray__ICollection_get_Count()
		/// </summary>
		protected RMethod r_InternalArray__ICollection_get_Count;
		public virtual RMethod RInternalArray__ICollection_get_Count
		{
			get
			{
				if(r_InternalArray__ICollection_get_Count == null)
				{
					r_InternalArray__ICollection_get_Count = new(this, "InternalArray__ICollection_get_Count", 0);
					r_InternalArray__ICollection_get_Count.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_get_Count;
			}
		}

		/// <summary>
		/// Boolean InternalArray__ICollection_get_IsReadOnly()
		/// </summary>
		protected RMethod r_InternalArray__ICollection_get_IsReadOnly;
		public virtual RMethod RInternalArray__ICollection_get_IsReadOnly
		{
			get
			{
				if(r_InternalArray__ICollection_get_IsReadOnly == null)
				{
					r_InternalArray__ICollection_get_IsReadOnly = new(this, "InternalArray__ICollection_get_IsReadOnly", 0);
					r_InternalArray__ICollection_get_IsReadOnly.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_get_IsReadOnly;
			}
		}

		/// <summary>
		/// Byte& GetRawSzArrayData()
		/// </summary>
		protected RMethod r_GetRawSzArrayData;
		public virtual RMethod RGetRawSzArrayData
		{
			get
			{
				if(r_GetRawSzArrayData == null)
				{
					r_GetRawSzArrayData = new(this, "GetRawSzArrayData", 0);
					r_GetRawSzArrayData.SetBelong(this.instance);
				}
				return r_GetRawSzArrayData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] InternalArray__IEnumerable_GetEnumerator[T]()
		/// </summary>
		protected RMethod r_InternalArray__IEnumerable_GetEnumerator_GT;
		public virtual RMethod RInternalArray__IEnumerable_GetEnumerator_GT
		{
			get
			{
				if(r_InternalArray__IEnumerable_GetEnumerator_GT == null)
				{
					r_InternalArray__IEnumerable_GetEnumerator_GT = new(this, "InternalArray__IEnumerable_GetEnumerator", 1);
					r_InternalArray__IEnumerable_GetEnumerator_GT.SetBelong(this.instance);
				}
				return r_InternalArray__IEnumerable_GetEnumerator_GT;
			}
		}

		/// <summary>
		/// Void InternalArray__ICollection_Clear()
		/// </summary>
		protected RMethod r_InternalArray__ICollection_Clear;
		public virtual RMethod RInternalArray__ICollection_Clear
		{
			get
			{
				if(r_InternalArray__ICollection_Clear == null)
				{
					r_InternalArray__ICollection_Clear = new(this, "InternalArray__ICollection_Clear", 0);
					r_InternalArray__ICollection_Clear.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_Clear;
			}
		}

		/// <summary>
		/// Void InternalArray__ICollection_Add[T](T)
		/// </summary>
		protected RMethod r_InternalArray__ICollection_Add_GT_T;
		public virtual RMethod RInternalArray__ICollection_Add_GT_T
		{
			get
			{
				if(r_InternalArray__ICollection_Add_GT_T == null)
				{
					r_InternalArray__ICollection_Add_GT_T = new(this, "InternalArray__ICollection_Add", 1, Type.MakeGenericMethodParameter(0));
					r_InternalArray__ICollection_Add_GT_T.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_Add_GT_T;
			}
		}

		/// <summary>
		/// Boolean InternalArray__ICollection_Remove[T](T)
		/// </summary>
		protected RMethod r_InternalArray__ICollection_Remove_GT_T;
		public virtual RMethod RInternalArray__ICollection_Remove_GT_T
		{
			get
			{
				if(r_InternalArray__ICollection_Remove_GT_T == null)
				{
					r_InternalArray__ICollection_Remove_GT_T = new(this, "InternalArray__ICollection_Remove", 1, Type.MakeGenericMethodParameter(0));
					r_InternalArray__ICollection_Remove_GT_T.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_Remove_GT_T;
			}
		}

		/// <summary>
		/// Boolean InternalArray__ICollection_Contains[T](T)
		/// </summary>
		protected RMethod r_InternalArray__ICollection_Contains_GT_T;
		public virtual RMethod RInternalArray__ICollection_Contains_GT_T
		{
			get
			{
				if(r_InternalArray__ICollection_Contains_GT_T == null)
				{
					r_InternalArray__ICollection_Contains_GT_T = new(this, "InternalArray__ICollection_Contains", 1, Type.MakeGenericMethodParameter(0));
					r_InternalArray__ICollection_Contains_GT_T.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_Contains_GT_T;
			}
		}

		/// <summary>
		/// Void InternalArray__ICollection_CopyTo[T](T[], Int32)
		/// </summary>
		protected RMethod r_InternalArray__ICollection_CopyTo_GT_TArray_Int32;
		public virtual RMethod RInternalArray__ICollection_CopyTo_GT_TArray_Int32
		{
			get
			{
				if(r_InternalArray__ICollection_CopyTo_GT_TArray_Int32 == null)
				{
					r_InternalArray__ICollection_CopyTo_GT_TArray_Int32 = new(this, "InternalArray__ICollection_CopyTo", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_InternalArray__ICollection_CopyTo_GT_TArray_Int32.SetBelong(this.instance);
				}
				return r_InternalArray__ICollection_CopyTo_GT_TArray_Int32;
			}
		}

		/// <summary>
		/// T InternalArray__IReadOnlyList_get_Item[T](Int32)
		/// </summary>
		protected RMethod r_InternalArray__IReadOnlyList_get_Item_GT_Int32;
		public virtual RMethod RInternalArray__IReadOnlyList_get_Item_GT_Int32
		{
			get
			{
				if(r_InternalArray__IReadOnlyList_get_Item_GT_Int32 == null)
				{
					r_InternalArray__IReadOnlyList_get_Item_GT_Int32 = new(this, "InternalArray__IReadOnlyList_get_Item", 1, typeof(System.Int32));
					r_InternalArray__IReadOnlyList_get_Item_GT_Int32.SetBelong(this.instance);
				}
				return r_InternalArray__IReadOnlyList_get_Item_GT_Int32;
			}
		}

		/// <summary>
		/// Int32 InternalArray__IReadOnlyCollection_get_Count()
		/// </summary>
		protected RMethod r_InternalArray__IReadOnlyCollection_get_Count;
		public virtual RMethod RInternalArray__IReadOnlyCollection_get_Count
		{
			get
			{
				if(r_InternalArray__IReadOnlyCollection_get_Count == null)
				{
					r_InternalArray__IReadOnlyCollection_get_Count = new(this, "InternalArray__IReadOnlyCollection_get_Count", 0);
					r_InternalArray__IReadOnlyCollection_get_Count.SetBelong(this.instance);
				}
				return r_InternalArray__IReadOnlyCollection_get_Count;
			}
		}

		/// <summary>
		/// Void InternalArray__Insert[T](Int32, T)
		/// </summary>
		protected RMethod r_InternalArray__Insert_GT_Int32_T;
		public virtual RMethod RInternalArray__Insert_GT_Int32_T
		{
			get
			{
				if(r_InternalArray__Insert_GT_Int32_T == null)
				{
					r_InternalArray__Insert_GT_Int32_T = new(this, "InternalArray__Insert", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_InternalArray__Insert_GT_Int32_T.SetBelong(this.instance);
				}
				return r_InternalArray__Insert_GT_Int32_T;
			}
		}

		/// <summary>
		/// Void InternalArray__RemoveAt(Int32)
		/// </summary>
		protected RMethod r_InternalArray__RemoveAt_Int32;
		public virtual RMethod RInternalArray__RemoveAt_Int32
		{
			get
			{
				if(r_InternalArray__RemoveAt_Int32 == null)
				{
					r_InternalArray__RemoveAt_Int32 = new(this, "InternalArray__RemoveAt", 0, typeof(System.Int32));
					r_InternalArray__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_InternalArray__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Int32 InternalArray__IndexOf[T](T)
		/// </summary>
		protected RMethod r_InternalArray__IndexOf_GT_T;
		public virtual RMethod RInternalArray__IndexOf_GT_T
		{
			get
			{
				if(r_InternalArray__IndexOf_GT_T == null)
				{
					r_InternalArray__IndexOf_GT_T = new(this, "InternalArray__IndexOf", 1, Type.MakeGenericMethodParameter(0));
					r_InternalArray__IndexOf_GT_T.SetBelong(this.instance);
				}
				return r_InternalArray__IndexOf_GT_T;
			}
		}

		/// <summary>
		/// T InternalArray__get_Item[T](Int32)
		/// </summary>
		protected RMethod r_InternalArray__get_Item_GT_Int32;
		public virtual RMethod RInternalArray__get_Item_GT_Int32
		{
			get
			{
				if(r_InternalArray__get_Item_GT_Int32 == null)
				{
					r_InternalArray__get_Item_GT_Int32 = new(this, "InternalArray__get_Item", 1, typeof(System.Int32));
					r_InternalArray__get_Item_GT_Int32.SetBelong(this.instance);
				}
				return r_InternalArray__get_Item_GT_Int32;
			}
		}

		/// <summary>
		/// Void InternalArray__set_Item[T](Int32, T)
		/// </summary>
		protected RMethod r_InternalArray__set_Item_GT_Int32_T;
		public virtual RMethod RInternalArray__set_Item_GT_Int32_T
		{
			get
			{
				if(r_InternalArray__set_Item_GT_Int32_T == null)
				{
					r_InternalArray__set_Item_GT_Int32_T = new(this, "InternalArray__set_Item", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_InternalArray__set_Item_GT_Int32_T.SetBelong(this.instance);
				}
				return r_InternalArray__set_Item_GT_Int32_T;
			}
		}

		/// <summary>
		/// Void GetGenericValue_icall[T](System.Array ByRef, Int32, T ByRef)
		/// </summary>
		protected static RMethod r_GetGenericValue_icall_GT_Ref_Array_Int32_Out_T;
		public static RMethod RGetGenericValue_icall_GT_Ref_Array_Int32_Out_T
		{
			get
			{
				if(r_GetGenericValue_icall_GT_Ref_Array_Int32_Out_T == null)
				{
					r_GetGenericValue_icall_GT_Ref_Array_Int32_Out_T = new(typeof(System.Array), "GetGenericValue_icall", 1, typeof(System.Array).MakeByRefType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_GetGenericValue_icall_GT_Ref_Array_Int32_Out_T.SetBelong(null);
				}
				return r_GetGenericValue_icall_GT_Ref_Array_Int32_Out_T;
			}
		}

		/// <summary>
		/// Void SetGenericValue_icall[T](System.Array ByRef, Int32, T ByRef)
		/// </summary>
		protected static RMethod r_SetGenericValue_icall_GT_Ref_Array_Int32_Ref_T;
		public static RMethod RSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T
		{
			get
			{
				if(r_SetGenericValue_icall_GT_Ref_Array_Int32_Ref_T == null)
				{
					r_SetGenericValue_icall_GT_Ref_Array_Int32_Ref_T = new(typeof(System.Array), "SetGenericValue_icall", 1, typeof(System.Array).MakeByRefType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_SetGenericValue_icall_GT_Ref_Array_Int32_Ref_T.SetBelong(null);
				}
				return r_SetGenericValue_icall_GT_Ref_Array_Int32_Ref_T;
			}
		}

		/// <summary>
		/// Void GetGenericValueImpl[T](Int32, T ByRef)
		/// </summary>
		protected RMethod r_GetGenericValueImpl_GT_Int32_Out_T;
		public virtual RMethod RGetGenericValueImpl_GT_Int32_Out_T
		{
			get
			{
				if(r_GetGenericValueImpl_GT_Int32_Out_T == null)
				{
					r_GetGenericValueImpl_GT_Int32_Out_T = new(this, "GetGenericValueImpl", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_GetGenericValueImpl_GT_Int32_Out_T.SetBelong(this.instance);
				}
				return r_GetGenericValueImpl_GT_Int32_Out_T;
			}
		}

		/// <summary>
		/// Void SetGenericValueImpl[T](Int32, T ByRef)
		/// </summary>
		protected RMethod r_SetGenericValueImpl_GT_Int32_Ref_T;
		public virtual RMethod RSetGenericValueImpl_GT_Int32_Ref_T
		{
			get
			{
				if(r_SetGenericValueImpl_GT_Int32_Ref_T == null)
				{
					r_SetGenericValueImpl_GT_Int32_Ref_T = new(this, "SetGenericValueImpl", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_SetGenericValueImpl_GT_Int32_Ref_T.SetBelong(this.instance);
				}
				return r_SetGenericValueImpl_GT_Int32_Ref_T;
			}
		}

		/// <summary>
		/// Int32 GetRank()
		/// </summary>
		protected RMethod r_GetRank;
		public virtual RMethod RGetRank
		{
			get
			{
				if(r_GetRank == null)
				{
					r_GetRank = new(this, "GetRank", 0);
					r_GetRank.SetBelong(this.instance);
				}
				return r_GetRank;
			}
		}

		/// <summary>
		/// Int32 GetLength(Int32)
		/// </summary>
		protected RMethod r_GetLength_Int32;
		public virtual RMethod RGetLength_Int32
		{
			get
			{
				if(r_GetLength_Int32 == null)
				{
					r_GetLength_Int32 = new(this, "GetLength", 0, typeof(System.Int32));
					r_GetLength_Int32.SetBelong(this.instance);
				}
				return r_GetLength_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLowerBound(Int32)
		/// </summary>
		protected RMethod r_GetLowerBound_Int32;
		public virtual RMethod RGetLowerBound_Int32
		{
			get
			{
				if(r_GetLowerBound_Int32 == null)
				{
					r_GetLowerBound_Int32 = new(this, "GetLowerBound", 0, typeof(System.Int32));
					r_GetLowerBound_Int32.SetBelong(this.instance);
				}
				return r_GetLowerBound_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32[])
		/// </summary>
		protected RMethod r_GetValue_Int32Array;
		public virtual RMethod RGetValue_Int32Array
		{
			get
			{
				if(r_GetValue_Int32Array == null)
				{
					r_GetValue_Int32Array = new(this, "GetValue", 0, typeof(System.Int32).MakeArrayType());
					r_GetValue_Int32Array.SetBelong(this.instance);
				}
				return r_GetValue_Int32Array;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32[])
		/// </summary>
		protected RMethod r_SetValue_Object_Int32Array;
		public virtual RMethod RSetValue_Object_Int32Array
		{
			get
			{
				if(r_SetValue_Object_Int32Array == null)
				{
					r_SetValue_Object_Int32Array = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32).MakeArrayType());
					r_SetValue_Object_Int32Array.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int32Array;
			}
		}

		/// <summary>
		/// System.Object GetValueImpl(Int32)
		/// </summary>
		protected RMethod r_GetValueImpl_Int32;
		public virtual RMethod RGetValueImpl_Int32
		{
			get
			{
				if(r_GetValueImpl_Int32 == null)
				{
					r_GetValueImpl_Int32 = new(this, "GetValueImpl", 0, typeof(System.Int32));
					r_GetValueImpl_Int32.SetBelong(this.instance);
				}
				return r_GetValueImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetValueImpl(System.Object, Int32)
		/// </summary>
		protected RMethod r_SetValueImpl_Object_Int32;
		public virtual RMethod RSetValueImpl_Object_Int32
		{
			get
			{
				if(r_SetValueImpl_Object_Int32 == null)
				{
					r_SetValueImpl_Object_Int32 = new(this, "SetValueImpl", 0, typeof(System.Object), typeof(System.Int32));
					r_SetValueImpl_Object_Int32.SetBelong(this.instance);
				}
				return r_SetValueImpl_Object_Int32;
			}
		}

		/// <summary>
		/// Boolean FastCopy(System.Array, Int32, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_FastCopy_Array_Int32_Array_Int32_Int32;
		public static RMethod RFastCopy_Array_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_FastCopy_Array_Int32_Array_Int32_Int32 == null)
				{
					r_FastCopy_Array_Int32_Array_Int32_Int32 = new(typeof(System.Array), "FastCopy", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_FastCopy_Array_Int32_Array_Int32_Int32.SetBelong(null);
				}
				return r_FastCopy_Array_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstanceImpl(System.Type, Int32[], Int32[])
		/// </summary>
		protected static RMethod r_CreateInstanceImpl_Type_Int32Array_Int32Array;
		public static RMethod RCreateInstanceImpl_Type_Int32Array_Int32Array
		{
			get
			{
				if(r_CreateInstanceImpl_Type_Int32Array_Int32Array == null)
				{
					r_CreateInstanceImpl_Type_Int32Array_Int32Array = new(typeof(System.Array), "CreateInstanceImpl", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_CreateInstanceImpl_Type_Int32Array_Int32Array.SetBelong(null);
				}
				return r_CreateInstanceImpl_Type_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Int32 GetUpperBound(Int32)
		/// </summary>
		protected RMethod r_GetUpperBound_Int32;
		public virtual RMethod RGetUpperBound_Int32
		{
			get
			{
				if(r_GetUpperBound_Int32 == null)
				{
					r_GetUpperBound_Int32 = new(this, "GetUpperBound", 0, typeof(System.Int32));
					r_GetUpperBound_Int32.SetBelong(this.instance);
				}
				return r_GetUpperBound_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32)
		/// </summary>
		protected RMethod r_GetValue_Int32;
		public virtual RMethod RGetValue_Int32
		{
			get
			{
				if(r_GetValue_Int32 == null)
				{
					r_GetValue_Int32 = new(this, "GetValue", 0, typeof(System.Int32));
					r_GetValue_Int32.SetBelong(this.instance);
				}
				return r_GetValue_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32, Int32)
		/// </summary>
		protected RMethod r_GetValue_Int32_Int32;
		public virtual RMethod RGetValue_Int32_Int32
		{
			get
			{
				if(r_GetValue_Int32_Int32 == null)
				{
					r_GetValue_Int32_Int32 = new(this, "GetValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetValue_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_GetValue_Int32_Int32_Int32;
		public virtual RMethod RGetValue_Int32_Int32_Int32
		{
			get
			{
				if(r_GetValue_Int32_Int32_Int32 == null)
				{
					r_GetValue_Int32_Int32_Int32 = new(this, "GetValue", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_GetValue_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetValue_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32)
		/// </summary>
		protected RMethod r_SetValue_Object_Int32;
		public virtual RMethod RSetValue_Object_Int32
		{
			get
			{
				if(r_SetValue_Object_Int32 == null)
				{
					r_SetValue_Object_Int32 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32));
					r_SetValue_Object_Int32.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_SetValue_Object_Int32_Int32;
		public virtual RMethod RSetValue_Object_Int32_Int32
		{
			get
			{
				if(r_SetValue_Object_Int32_Int32 == null)
				{
					r_SetValue_Object_Int32_Int32 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_SetValue_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetValue_Object_Int32_Int32_Int32;
		public virtual RMethod RSetValue_Object_Int32_Int32_Int32
		{
			get
			{
				if(r_SetValue_Object_Int32_Int32_Int32 == null)
				{
					r_SetValue_Object_Int32_Int32_Int32 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetValue_Object_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetValue_Object_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array UnsafeCreateInstance(System.Type, Int32[], Int32[])
		/// </summary>
		protected static RMethod r_UnsafeCreateInstance_Type_Int32Array_Int32Array;
		public static RMethod RUnsafeCreateInstance_Type_Int32Array_Int32Array
		{
			get
			{
				if(r_UnsafeCreateInstance_Type_Int32Array_Int32Array == null)
				{
					r_UnsafeCreateInstance_Type_Int32Array_Int32Array = new(typeof(System.Array), "UnsafeCreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_UnsafeCreateInstance_Type_Int32Array_Int32Array.SetBelong(null);
				}
				return r_UnsafeCreateInstance_Type_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// System.Array UnsafeCreateInstance(System.Type, Int32, Int32)
		/// </summary>
		protected static RMethod r_UnsafeCreateInstance_Type_Int32_Int32;
		public static RMethod RUnsafeCreateInstance_Type_Int32_Int32
		{
			get
			{
				if(r_UnsafeCreateInstance_Type_Int32_Int32 == null)
				{
					r_UnsafeCreateInstance_Type_Int32_Int32 = new(typeof(System.Array), "UnsafeCreateInstance", 0, typeof(System.Type), typeof(System.Int32), typeof(System.Int32));
					r_UnsafeCreateInstance_Type_Int32_Int32.SetBelong(null);
				}
				return r_UnsafeCreateInstance_Type_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array UnsafeCreateInstance(System.Type, Int32[])
		/// </summary>
		protected static RMethod r_UnsafeCreateInstance_Type_Int32Array;
		public static RMethod RUnsafeCreateInstance_Type_Int32Array
		{
			get
			{
				if(r_UnsafeCreateInstance_Type_Int32Array == null)
				{
					r_UnsafeCreateInstance_Type_Int32Array = new(typeof(System.Array), "UnsafeCreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType());
					r_UnsafeCreateInstance_Type_Int32Array.SetBelong(null);
				}
				return r_UnsafeCreateInstance_Type_Int32Array;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32)
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Int32;
		public static RMethod RCreateInstance_Type_Int32
		{
			get
			{
				if(r_CreateInstance_Type_Int32 == null)
				{
					r_CreateInstance_Type_Int32 = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32));
					r_CreateInstance_Type_Int32.SetBelong(null);
				}
				return r_CreateInstance_Type_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32, Int32)
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Int32_Int32;
		public static RMethod RCreateInstance_Type_Int32_Int32
		{
			get
			{
				if(r_CreateInstance_Type_Int32_Int32 == null)
				{
					r_CreateInstance_Type_Int32_Int32 = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32), typeof(System.Int32));
					r_CreateInstance_Type_Int32_Int32.SetBelong(null);
				}
				return r_CreateInstance_Type_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Int32_Int32_Int32;
		public static RMethod RCreateInstance_Type_Int32_Int32_Int32
		{
			get
			{
				if(r_CreateInstance_Type_Int32_Int32_Int32 == null)
				{
					r_CreateInstance_Type_Int32_Int32_Int32 = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CreateInstance_Type_Int32_Int32_Int32.SetBelong(null);
				}
				return r_CreateInstance_Type_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32[])
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Int32Array;
		public static RMethod RCreateInstance_Type_Int32Array
		{
			get
			{
				if(r_CreateInstance_Type_Int32Array == null)
				{
					r_CreateInstance_Type_Int32Array = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType());
					r_CreateInstance_Type_Int32Array.SetBelong(null);
				}
				return r_CreateInstance_Type_Int32Array;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32[], Int32[])
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Int32Array_Int32Array;
		public static RMethod RCreateInstance_Type_Int32Array_Int32Array
		{
			get
			{
				if(r_CreateInstance_Type_Int32Array_Int32Array == null)
				{
					r_CreateInstance_Type_Int32Array_Int32Array = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_CreateInstance_Type_Int32Array_Int32Array.SetBelong(null);
				}
				return r_CreateInstance_Type_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Void Clear(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_Clear_Array_Int32_Int32;
		public static RMethod RClear_Array_Int32_Int32
		{
			get
			{
				if(r_Clear_Array_Int32_Int32 == null)
				{
					r_Clear_Array_Int32_Int32 = new(typeof(System.Array), "Clear", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_Clear_Array_Int32_Int32.SetBelong(null);
				}
				return r_Clear_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ClearInternal(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_ClearInternal_Array_Int32_Int32;
		public static RMethod RClearInternal_Array_Int32_Int32
		{
			get
			{
				if(r_ClearInternal_Array_Int32_Int32 == null)
				{
					r_ClearInternal_Array_Int32_Int32 = new(typeof(System.Array), "ClearInternal", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_ClearInternal_Array_Int32_Int32.SetBelong(null);
				}
				return r_ClearInternal_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, System.Array, Int32)
		/// </summary>
		protected static RMethod r_Copy_Array_Array_Int32;
		public static RMethod RCopy_Array_Array_Int32
		{
			get
			{
				if(r_Copy_Array_Array_Int32 == null)
				{
					r_Copy_Array_Array_Int32 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32));
					r_Copy_Array_Array_Int32.SetBelong(null);
				}
				return r_Copy_Array_Array_Int32;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, Int32, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_Copy_Array_Int32_Array_Int32_Int32;
		public static RMethod RCopy_Array_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_Copy_Array_Int32_Array_Int32_Int32 == null)
				{
					r_Copy_Array_Int32_Array_Int32_Int32 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_Copy_Array_Int32_Array_Int32_Int32.SetBelong(null);
				}
				return r_Copy_Array_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// System.ArrayTypeMismatchException CreateArrayTypeMismatchException()
		/// </summary>
		protected static RMethod r_CreateArrayTypeMismatchException;
		public static RMethod RCreateArrayTypeMismatchException
		{
			get
			{
				if(r_CreateArrayTypeMismatchException == null)
				{
					r_CreateArrayTypeMismatchException = new(typeof(System.Array), "CreateArrayTypeMismatchException", 0);
					r_CreateArrayTypeMismatchException.SetBelong(null);
				}
				return r_CreateArrayTypeMismatchException;
			}
		}

		/// <summary>
		/// Boolean CanAssignArrayElement(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_CanAssignArrayElement_Type_Type;
		public static RMethod RCanAssignArrayElement_Type_Type
		{
			get
			{
				if(r_CanAssignArrayElement_Type_Type == null)
				{
					r_CanAssignArrayElement_Type_Type = new(typeof(System.Array), "CanAssignArrayElement", 0, typeof(System.Type), typeof(System.Type));
					r_CanAssignArrayElement_Type_Type.SetBelong(null);
				}
				return r_CanAssignArrayElement_Type_Type;
			}
		}

		/// <summary>
		/// Void ConstrainedCopy(System.Array, Int32, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_ConstrainedCopy_Array_Int32_Array_Int32_Int32;
		public static RMethod RConstrainedCopy_Array_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_ConstrainedCopy_Array_Int32_Array_Int32_Int32 == null)
				{
					r_ConstrainedCopy_Array_Int32_Array_Int32_Int32 = new(typeof(System.Array), "ConstrainedCopy", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_ConstrainedCopy_Array_Int32_Array_Int32_Int32.SetBelong(null);
				}
				return r_ConstrainedCopy_Array_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// T[] Empty[T]()
		/// </summary>
		protected static RMethod r_Empty_GT;
		public static RMethod REmpty_GT
		{
			get
			{
				if(r_Empty_GT == null)
				{
					r_Empty_GT = new(typeof(System.Array), "Empty", 1);
					r_Empty_GT.SetBelong(null);
				}
				return r_Empty_GT;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_Initialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_Initialize == null)
				{
					r_Initialize = new(this, "Initialize", 0);
					r_Initialize.SetBelong(this.instance);
				}
				return r_Initialize;
			}
		}

		/// <summary>
		/// Int32 IndexOfImpl[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_IndexOfImpl_GT_TArray_T_Int32_Int32;
		public static RMethod RIndexOfImpl_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_IndexOfImpl_GT_TArray_T_Int32_Int32 == null)
				{
					r_IndexOfImpl_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "IndexOfImpl", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_IndexOfImpl_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_IndexOfImpl_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfImpl[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_LastIndexOfImpl_GT_TArray_T_Int32_Int32;
		public static RMethod RLastIndexOfImpl_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_LastIndexOfImpl_GT_TArray_T_Int32_Int32 == null)
				{
					r_LastIndexOfImpl_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "LastIndexOfImpl", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOfImpl_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_LastIndexOfImpl_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SortImpl(System.Array, System.Array, Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_SortImpl_Array_Array_Int32_Int32_IComparer;
		public static RMethod RSortImpl_Array_Array_Int32_Int32_IComparer
		{
			get
			{
				if(r_SortImpl_Array_Array_Int32_Int32_IComparer == null)
				{
					r_SortImpl_Array_Array_Int32_Int32_IComparer = new(typeof(System.Array), "SortImpl", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_SortImpl_Array_Array_Int32_Int32_IComparer.SetBelong(null);
				}
				return r_SortImpl_Array_Array_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// T UnsafeLoad[T](T[], Int32)
		/// </summary>
		protected static RMethod r_UnsafeLoad_GT_TArray_Int32;
		public static RMethod RUnsafeLoad_GT_TArray_Int32
		{
			get
			{
				if(r_UnsafeLoad_GT_TArray_Int32 == null)
				{
					r_UnsafeLoad_GT_TArray_Int32 = new(typeof(System.Array), "UnsafeLoad", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_UnsafeLoad_GT_TArray_Int32.SetBelong(null);
				}
				return r_UnsafeLoad_GT_TArray_Int32;
			}
		}

		/// <summary>
		/// Void UnsafeStore[T](T[], Int32, T)
		/// </summary>
		protected static RMethod r_UnsafeStore_GT_TArray_Int32_T;
		public static RMethod RUnsafeStore_GT_TArray_Int32_T
		{
			get
			{
				if(r_UnsafeStore_GT_TArray_Int32_T == null)
				{
					r_UnsafeStore_GT_TArray_Int32_T = new(typeof(System.Array), "UnsafeStore", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_UnsafeStore_GT_TArray_Int32_T.SetBelong(null);
				}
				return r_UnsafeStore_GT_TArray_Int32_T;
			}
		}

		/// <summary>
		/// R UnsafeMov[S,R](S)
		/// </summary>
		protected static RMethod r_UnsafeMov_GS_GR_S;
		public static RMethod RUnsafeMov_GS_GR_S
		{
			get
			{
				if(r_UnsafeMov_GS_GR_S == null)
				{
					r_UnsafeMov_GS_GR_S = new(typeof(System.Array), "UnsafeMov", 2, Type.MakeGenericMethodParameter(0));
					r_UnsafeMov_GS_GR_S.SetBelong(null);
				}
				return r_UnsafeMov_GS_GR_S;
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


        public RArray() : base("System.Array")
        {
        }

        public RArray(System.Object instance) : base("System.Array")
		{
            SetInstance(instance);
		}

        public RArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Array CreateInstance(System.Type  @elementType, System.Int64[]  @lengths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths};
            var ___result = RCreateInstance_Type_Int64Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[]  @array)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array};
            var ___result = RAsReadOnly_GT_TArray.Invoke(___genericsType, ___parameters);

            return (System.Collections.ObjectModel.ReadOnlyCollection<T>)___result;
        }


        public static void Resize<T>(ref T[]  @array, System.Int32  @newSize)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @newSize};
            var ___result = RResize_GT_Ref_TArray_Int32.Invoke(___genericsType, ___parameters);
			@array = (T[])___parameters[0];

            
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IList__2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Insert(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSystem__2__Collections__2__IList__2__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__Remove(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__2__Collections__2__IList__2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IStructuralComparable__2__CompareTo(System.Object  @other, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean System__2__Collections__2__IStructuralEquatable__2__Equals(System.Object  @other, System.Collections.IEqualityComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32  @h1, System.Int32  @h2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h1, @h2};
            var ___result = RCombineHashCodes_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IStructuralEquatable__2__GetHashCode(System.Collections.IEqualityComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch(System.Array  @array, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RBinarySearch_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[]  @array, System.Converter<TInput, TOutput>  @converter)
        {

            var ___genericsType = new Type[] {typeof(TInput), typeof(TOutput)};
            var ___parameters = new object[]{@array, @converter};
            var ___result = RConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_.Invoke(___genericsType, ___parameters);

            return (TOutput[])___result;
        }


        public static void Copy(System.Array  @sourceArray, System.Array  @destinationArray, System.Int64  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @destinationArray, @length};
            var ___result = RCopy_Array_Array_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(System.Array  @sourceArray, System.Int64  @sourceIndex, System.Array  @destinationArray, System.Int64  @destinationIndex, System.Int64  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @sourceIndex, @destinationArray, @destinationIndex, @length};
            var ___result = RCopy_Array_Int64_Array_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array  @array, System.Int64  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public static void ForEach<T>(T[]  @array, System.Action<T>  @action)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @action};
            var ___result = RForEach_GT_TArray_Action_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 GetLongLength(System.Int32  @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RGetLongLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Object GetValue(System.Int64  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetValue_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int64  @index1, System.Int64  @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2};
            var ___result = RGetValue_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int64  @index1, System.Int64  @index2, System.Int64  @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2, @index3};
            var ___result = RGetValue_Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int64[]  @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RGetValue_Int64Array.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Int32 BinarySearch(System.Array  @array, System.Int32  @index, System.Int32  @length, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length, @value};
            var ___result = RBinarySearch_Array_Int32_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch(System.Array  @array, System.Object  @value, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @comparer};
            var ___result = RBinarySearch_Array_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch(System.Array  @array, System.Int32  @index, System.Int32  @length, System.Object  @value, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length, @value, @comparer};
            var ___result = RBinarySearch_Array_Int32_Int32_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetMedian(System.Int32  @low, System.Int32  @hi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@low, @hi};
            var ___result = RGetMedian_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[]  @array, T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RBinarySearch_GT_TArray_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[]  @array, T  @value, System.Collections.Generic.IComparer<T>  @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @comparer};
            var ___result = RBinarySearch_GT_TArray_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[]  @array, System.Int32  @index, System.Int32  @length, T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length, @value};
            var ___result = RBinarySearch_GT_TArray_Int32_Int32_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[]  @array, System.Int32  @index, System.Int32  @length, T  @value, System.Collections.Generic.IComparer<T>  @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length, @value, @comparer};
            var ___result = RBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf(System.Array  @array, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RIndexOf_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf(System.Array  @array, System.Object  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RIndexOf_Array_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf(System.Array  @array, System.Object  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RIndexOf_Array_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf<T>(T[]  @array, T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RIndexOf_GT_TArray_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf<T>(T[]  @array, T  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RIndexOf_GT_TArray_T_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf<T>(T[]  @array, T  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RIndexOf_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf(System.Array  @array, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RLastIndexOf_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf(System.Array  @array, System.Object  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RLastIndexOf_Array_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf(System.Array  @array, System.Object  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RLastIndexOf_Array_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf<T>(T[]  @array, T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RLastIndexOf_GT_TArray_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf<T>(T[]  @array, T  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RLastIndexOf_GT_TArray_T_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf<T>(T[]  @array, T  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RLastIndexOf_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Reverse(System.Array  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RReverse_Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Reverse(System.Array  @array, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RReverse_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Reverse<T>(T[]  @array)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array};
            var ___result = RReverse_GT_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Reverse<T>(T[]  @array, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RReverse_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @value, System.Int64  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index};
            var ___result = RSetValue_Object_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @value, System.Int64  @index1, System.Int64  @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2};
            var ___result = RSetValue_Object_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @value, System.Int64  @index1, System.Int64  @index2, System.Int64  @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2, @index3};
            var ___result = RSetValue_Object_Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @value, System.Int64[]  @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @indices};
            var ___result = RSetValue_Object_Int64Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RSort_Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @array, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RSort_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @array, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @comparer};
            var ___result = RSort_Array_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @array, System.Int32  @index, System.Int32  @length, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length, @comparer};
            var ___result = RSort_Array_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @keys, System.Array  @items)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items};
            var ___result = RSort_Array_Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @keys, System.Array  @items, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @comparer};
            var ___result = RSort_Array_Array_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @keys, System.Array  @items, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @index, @length};
            var ___result = RSort_Array_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array  @keys, System.Array  @items, System.Int32  @index, System.Int32  @length, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @index, @length, @comparer};
            var ___result = RSort_Array_Array_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[]  @array)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array};
            var ___result = RSort_GT_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[]  @array, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RSort_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[]  @array, System.Collections.Generic.IComparer<T>  @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @comparer};
            var ___result = RSort_GT_TArray_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[]  @array, System.Int32  @index, System.Int32  @length, System.Collections.Generic.IComparer<T>  @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length, @comparer};
            var ___result = RSort_GT_TArray_Int32_Int32_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[]  @array, System.Comparison<T>  @comparison)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @comparison};
            var ___result = RSort_GT_TArray_Comparison_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[]  @keys, TValue[]  @items)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items};
            var ___result = RSort_GTKey_GTValue_TKeyArray_TValueArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[]  @keys, TValue[]  @items, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items, @index, @length};
            var ___result = RSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[]  @keys, TValue[]  @items, System.Collections.Generic.IComparer<TKey>  @comparer)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items, @comparer};
            var ___result = RSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[]  @keys, TValue[]  @items, System.Int32  @index, System.Int32  @length, System.Collections.Generic.IComparer<TKey>  @comparer)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items, @index, @length, @comparer};
            var ___result = RSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Exists<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RExists_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Fill<T>(T[]  @array, T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RFill_GT_TArray_T.Invoke(___genericsType, ___parameters);

            
        }


        public static void Fill<T>(T[]  @array, T  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RFill_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static T Find<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RFind_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T[] FindAll<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RFindAll_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static System.Int32 FindIndex<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RFindIndex_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindIndex<T>(T[]  @array, System.Int32  @startIndex, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @match};
            var ___result = RFindIndex_GT_TArray_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindIndex<T>(T[]  @array, System.Int32  @startIndex, System.Int32  @count, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @count, @match};
            var ___result = RFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static T FindLast<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RFindLast_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static System.Int32 FindLastIndex<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RFindLastIndex_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindLastIndex<T>(T[]  @array, System.Int32  @startIndex, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @match};
            var ___result = RFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindLastIndex<T>(T[]  @array, System.Int32  @startIndex, System.Int32  @count, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @count, @match};
            var ___result = RFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean TrueForAll<T>(T[]  @array, System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RTrueForAll_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Int32 InternalArray__ICollection_get_Count()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalArray__ICollection_get_Count.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean InternalArray__ICollection_get_IsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalArray__ICollection_get_IsReadOnly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte GetRawSzArrayData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawSzArrayData.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RInternalArray__IEnumerable_GetEnumerator_GT.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual void InternalArray__ICollection_Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalArray__ICollection_Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalArray__ICollection_Add<T>(T  @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RInternalArray__ICollection_Add_GT_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InternalArray__ICollection_Remove<T>(T  @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RInternalArray__ICollection_Remove_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalArray__ICollection_Contains<T>(T  @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RInternalArray__ICollection_Contains_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InternalArray__ICollection_CopyTo<T>(T[]  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RInternalArray__ICollection_CopyTo_GT_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T InternalArray__IReadOnlyList_get_Item<T>(System.Int32  @index)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index};
            var ___result = RInternalArray__IReadOnlyList_get_Item_GT_Int32.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Int32 InternalArray__IReadOnlyCollection_get_Count()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalArray__IReadOnlyCollection_get_Count.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InternalArray__Insert<T>(System.Int32  @index, T  @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @item};
            var ___result = RInternalArray__Insert_GT_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalArray__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RInternalArray__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalArray__IndexOf<T>(T  @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RInternalArray__IndexOf_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual T InternalArray__get_Item<T>(System.Int32  @index)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index};
            var ___result = RInternalArray__get_Item_GT_Int32.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void InternalArray__set_Item<T>(System.Int32  @index, T  @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @item};
            var ___result = RInternalArray__set_Item_GT_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGenericValue_icall<T>(ref System.Array  @self, System.Int32  @pos, out T  @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@self, @pos, @value};
            var ___result = RGetGenericValue_icall_GT_Ref_Array_Int32_Out_T.Invoke(___genericsType, ___parameters);
			@self = (System.Array)___parameters[0];
			@value = (T)___parameters[2];

            
        }


        public static void SetGenericValue_icall<T>(ref System.Array  @self, System.Int32  @pos, ref T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@self, @pos, @value};
            var ___result = RSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T.Invoke(___genericsType, ___parameters);
			@self = (System.Array)___parameters[0];
			@value = (T)___parameters[2];

            
        }


        public virtual void GetGenericValueImpl<T>(System.Int32  @pos, out T  @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@pos, @value};
            var ___result = RGetGenericValueImpl_GT_Int32_Out_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[1];

            
        }


        public virtual void SetGenericValueImpl<T>(System.Int32  @pos, ref T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@pos, @value};
            var ___result = RSetGenericValueImpl_GT_Int32_Ref_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[1];

            
        }


        public virtual System.Int32 GetRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLength(System.Int32  @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RGetLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLowerBound(System.Int32  @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RGetLowerBound_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetValue(System.Int32[]  @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RGetValue_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object  @value, System.Int32[]  @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @indices};
            var ___result = RSetValue_Object_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetValueImpl(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetValueImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValueImpl(System.Object  @value, System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @pos};
            var ___result = RSetValueImpl_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean FastCopy(System.Array  @source, System.Int32  @source_idx, System.Array  @dest, System.Int32  @dest_idx, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @source_idx, @dest, @dest_idx, @length};
            var ___result = RFastCopy_Array_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Array CreateInstanceImpl(System.Type  @elementType, System.Int32[]  @lengths, System.Int32[]  @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths, @bounds};
            var ___result = RCreateInstanceImpl_Type_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Int32 GetUpperBound(System.Int32  @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RGetUpperBound_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetValue(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int32  @index1, System.Int32  @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2};
            var ___result = RGetValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int32  @index1, System.Int32  @index2, System.Int32  @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2, @index3};
            var ___result = RGetValue_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object  @value, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index};
            var ___result = RSetValue_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @value, System.Int32  @index1, System.Int32  @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2};
            var ___result = RSetValue_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @value, System.Int32  @index1, System.Int32  @index2, System.Int32  @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2, @index3};
            var ___result = RSetValue_Object_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Array UnsafeCreateInstance(System.Type  @elementType, System.Int32[]  @lengths, System.Int32[]  @lowerBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths, @lowerBounds};
            var ___result = RUnsafeCreateInstance_Type_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array UnsafeCreateInstance(System.Type  @elementType, System.Int32  @length1, System.Int32  @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length1, @length2};
            var ___result = RUnsafeCreateInstance_Type_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array UnsafeCreateInstance(System.Type  @elementType, System.Int32[]  @lengths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths};
            var ___result = RUnsafeCreateInstance_Type_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type  @elementType, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length};
            var ___result = RCreateInstance_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type  @elementType, System.Int32  @length1, System.Int32  @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length1, @length2};
            var ___result = RCreateInstance_Type_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type  @elementType, System.Int32  @length1, System.Int32  @length2, System.Int32  @length3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length1, @length2, @length3};
            var ___result = RCreateInstance_Type_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type  @elementType, System.Int32[]  @lengths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths};
            var ___result = RCreateInstance_Type_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type  @elementType, System.Int32[]  @lengths, System.Int32[]  @lowerBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths, @lowerBounds};
            var ___result = RCreateInstance_Type_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static void Clear(System.Array  @array, System.Int32  @index, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RClear_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearInternal(System.Array  @a, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @index, @count};
            var ___result = RClearInternal_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(System.Array  @sourceArray, System.Array  @destinationArray, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @destinationArray, @length};
            var ___result = RCopy_Array_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(System.Array  @sourceArray, System.Int32  @sourceIndex, System.Array  @destinationArray, System.Int32  @destinationIndex, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @sourceIndex, @destinationArray, @destinationIndex, @length};
            var ___result = RCopy_Array_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.ArrayTypeMismatchException CreateArrayTypeMismatchException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateArrayTypeMismatchException.Invoke(___genericsType, ___parameters);

            return (System.ArrayTypeMismatchException)___result;
        }


        public static System.Boolean CanAssignArrayElement(System.Type  @source, System.Type  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target};
            var ___result = RCanAssignArrayElement_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ConstrainedCopy(System.Array  @sourceArray, System.Int32  @sourceIndex, System.Array  @destinationArray, System.Int32  @destinationIndex, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @sourceIndex, @destinationArray, @destinationIndex, @length};
            var ___result = RConstrainedCopy_Array_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static T[] Empty<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = REmpty_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 IndexOfImpl<T>(T[]  @array, T  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RIndexOfImpl_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfImpl<T>(T[]  @array, T  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RLastIndexOfImpl_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SortImpl(System.Array  @keys, System.Array  @items, System.Int32  @index, System.Int32  @length, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @index, @length, @comparer};
            var ___result = RSortImpl_Array_Array_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static T UnsafeLoad<T>(T[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index};
            var ___result = RUnsafeLoad_GT_TArray_Int32.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static void UnsafeStore<T>(T[]  @array, System.Int32  @index, T  @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @value};
            var ___result = RUnsafeStore_GT_TArray_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public static R UnsafeMov<S, R>(S  @instance)
        {

            var ___genericsType = new Type[] {typeof(S), typeof(R)};
            var ___parameters = new object[]{@instance};
            var ___result = RUnsafeMov_GS_GR_S.Invoke(___genericsType, ___parameters);

            return (R)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
