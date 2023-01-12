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
		protected RSystem.RInt32 r_PSystem__2__Collections__2__ICollection__2__Count;
		public virtual RSystem.RInt32 RPSystem__2__Collections__2__ICollection__2__Count
		{
			get
			{
				if(r_PSystem__2__Collections__2__ICollection__2__Count == null)
				{
					r_PSystem__2__Collections__2__ICollection__2__Count = new(this, "System.Collections.ICollection.Count", -1);
					r_PSystem__2__Collections__2__ICollection__2__Count.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__ICollection__2__Count;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_PSystem__2__Collections__2__IList__2__IsReadOnly;
		public virtual RSystem.RBoolean RPSystem__2__Collections__2__IList__2__IsReadOnly
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__IsReadOnly == null)
				{
					r_PSystem__2__Collections__2__IList__2__IsReadOnly = new(this, "System.Collections.IList.IsReadOnly", -1);
					r_PSystem__2__Collections__2__IList__2__IsReadOnly.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IList__2__IsReadOnly;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_PSystem__2__Collections__2__IList__2__Item_Int32;
		public virtual RSystem.RObject RPSystem__2__Collections__2__IList__2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__IList__2__Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_PSystem__2__Collections__2__IList__2__Item_Int32.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IList__2__Item_Int32;
			}
		}

		/// <summary>
		/// Int64 LongLength
		/// </summary>
		protected RSystem.RInt64 r_PLongLength;
		public virtual RSystem.RInt64 RPLongLength
		{
			get
			{
				if(r_PLongLength == null)
				{
					r_PLongLength = new(this, "LongLength", -1);
					r_PLongLength.SetBelong(this.instance);
				}
				return r_PLongLength;
			}
		}

		/// <summary>
		/// Boolean IsFixedSize
		/// </summary>
		protected RSystem.RBoolean r_PIsFixedSize;
		public virtual RSystem.RBoolean RPIsFixedSize
		{
			get
			{
				if(r_PIsFixedSize == null)
				{
					r_PIsFixedSize = new(this, "IsFixedSize", -1);
					r_PIsFixedSize.SetBelong(this.instance);
				}
				return r_PIsFixedSize;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_PIsReadOnly;
		public virtual RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.instance);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RSystem.RBoolean r_PIsSynchronized;
		public virtual RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
					r_PIsSynchronized.SetBelong(this.instance);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_PSyncRoot;
		public virtual RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
					r_PSyncRoot.SetBelong(this.instance);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_PLength;
		public virtual RSystem.RInt32 RPLength
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
		/// Int32 Rank
		/// </summary>
		protected RSystem.RInt32 r_PRank;
		public virtual RSystem.RInt32 RPRank
		{
			get
			{
				if(r_PRank == null)
				{
					r_PRank = new(this, "Rank", -1);
					r_PRank.SetBelong(this.instance);
				}
				return r_PRank;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int64[])
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Int64Array;
		public static RMethod RMCreateInstance_Type_Int64Array
		{
			get
			{
				if(r_MCreateInstance_Type_Int64Array == null)
				{
					r_MCreateInstance_Type_Int64Array = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int64).MakeArrayType());
					r_MCreateInstance_Type_Int64Array.SetBelong(null);
				}
				return r_MCreateInstance_Type_Int64Array;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[T] AsReadOnly[T](T[])
		/// </summary>
		protected static RMethod r_MAsReadOnly_GT_TArray;
		public static RMethod RMAsReadOnly_GT_TArray
		{
			get
			{
				if(r_MAsReadOnly_GT_TArray == null)
				{
					r_MAsReadOnly_GT_TArray = new(typeof(System.Array), "AsReadOnly", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_MAsReadOnly_GT_TArray.SetBelong(null);
				}
				return r_MAsReadOnly_GT_TArray;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32)
		/// </summary>
		protected static RMethod r_MResize_GT_Ref_TArray_Int32;
		public static RMethod RMResize_GT_Ref_TArray_Int32
		{
			get
			{
				if(r_MResize_GT_Ref_TArray_Int32 == null)
				{
					r_MResize_GT_Ref_TArray_Int32 = new(typeof(System.Array), "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32));
					r_MResize_GT_Ref_TArray_Int32.SetBelong(null);
				}
				return r_MResize_GT_Ref_TArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Add_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Add_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Add_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Add_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Add_Object;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Contains_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Contains_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Contains_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Contains_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Contains_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Clear == null)
				{
					r_MSystem__2__Collections__2__IList__2__Clear = new(this, "System.Collections.IList.Clear", 0);
					r_MSystem__2__Collections__2__IList__2__Clear.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Clear;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__IndexOf_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__IndexOf_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__IndexOf_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__IndexOf_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__IndexOf_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Insert_Int32_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__Remove_Object;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__Remove_Object
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__Remove_Object == null)
				{
					r_MSystem__2__Collections__2__IList__2__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_MSystem__2__Collections__2__IList__2__Remove_Object.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__Remove_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32;
		public virtual RMethod RMSystem__2__Collections__2__IList__2__RemoveAt_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32 == null)
				{
					r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32 = new(this, "System.Collections.IList.RemoveAt", 0, typeof(System.Int32));
					r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int32;
		public virtual RMethod RMCopyTo_Array_Int32
		{
			get
			{
				if(r_MCopyTo_Array_Int32 == null)
				{
					r_MCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_MCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IStructuralComparable.CompareTo(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer;
		public virtual RMethod RMSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer
		{
			get
			{
				if(r_MSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer == null)
				{
					r_MSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer = new(this, "System.Collections.IStructuralComparable.CompareTo", 0, typeof(System.Object), typeof(System.Collections.IComparer));
					r_MSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IStructuralEquatable.Equals(System.Object, System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer;
		public virtual RMethod RMSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer
		{
			get
			{
				if(r_MSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer == null)
				{
					r_MSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer = new(this, "System.Collections.IStructuralEquatable.Equals", 0, typeof(System.Object), typeof(System.Collections.IEqualityComparer));
					r_MSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 CombineHashCodes(Int32, Int32)
		/// </summary>
		protected static RMethod r_MCombineHashCodes_Int32_Int32;
		public static RMethod RMCombineHashCodes_Int32_Int32
		{
			get
			{
				if(r_MCombineHashCodes_Int32_Int32 == null)
				{
					r_MCombineHashCodes_Int32_Int32 = new(typeof(System.Array), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32));
					r_MCombineHashCodes_Int32_Int32.SetBelong(null);
				}
				return r_MCombineHashCodes_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer;
		public virtual RMethod RMSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer
		{
			get
			{
				if(r_MSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer == null)
				{
					r_MSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer = new(this, "System.Collections.IStructuralEquatable.GetHashCode", 0, typeof(System.Collections.IEqualityComparer));
					r_MSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_MBinarySearch_Array_Object;
		public static RMethod RMBinarySearch_Array_Object
		{
			get
			{
				if(r_MBinarySearch_Array_Object == null)
				{
					r_MBinarySearch_Array_Object = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Object));
					r_MBinarySearch_Array_Object.SetBelong(null);
				}
				return r_MBinarySearch_Array_Object;
			}
		}

		/// <summary>
		/// TOutput[] ConvertAll[TInput,TOutput](TInput[], System.Converter`2[TInput,TOutput])
		/// </summary>
		protected static RMethod r_MConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_;
		public static RMethod RMConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_
		{
			get
			{
				if(r_MConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_ == null)
				{
					r_MConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_ = new(typeof(System.Array), "ConvertAll", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Converter<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
					r_MConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_.SetBelong(null);
				}
				return r_MConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, System.Array, Int64)
		/// </summary>
		protected static RMethod r_MCopy_Array_Array_Int64;
		public static RMethod RMCopy_Array_Array_Int64
		{
			get
			{
				if(r_MCopy_Array_Array_Int64 == null)
				{
					r_MCopy_Array_Array_Int64 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int64));
					r_MCopy_Array_Array_Int64.SetBelong(null);
				}
				return r_MCopy_Array_Array_Int64;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, Int64, System.Array, Int64, Int64)
		/// </summary>
		protected static RMethod r_MCopy_Array_Int64_Array_Int64_Int64;
		public static RMethod RMCopy_Array_Int64_Array_Int64_Int64
		{
			get
			{
				if(r_MCopy_Array_Int64_Array_Int64_Int64 == null)
				{
					r_MCopy_Array_Int64_Array_Int64_Int64 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Int64), typeof(System.Array), typeof(System.Int64), typeof(System.Int64));
					r_MCopy_Array_Int64_Array_Int64_Int64.SetBelong(null);
				}
				return r_MCopy_Array_Int64_Array_Int64_Int64;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int64)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int64;
		public virtual RMethod RMCopyTo_Array_Int64
		{
			get
			{
				if(r_MCopyTo_Array_Int64 == null)
				{
					r_MCopyTo_Array_Int64 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int64));
					r_MCopyTo_Array_Int64.SetBelong(this.instance);
				}
				return r_MCopyTo_Array_Int64;
			}
		}

		/// <summary>
		/// Void ForEach[T](T[], System.Action`1[T])
		/// </summary>
		protected static RMethod r_MForEach_GT_TArray_Action_d_T_p_;
		public static RMethod RMForEach_GT_TArray_Action_d_T_p_
		{
			get
			{
				if(r_MForEach_GT_TArray_Action_d_T_p_ == null)
				{
					r_MForEach_GT_TArray_Action_d_T_p_ = new(typeof(System.Array), "ForEach", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Action<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MForEach_GT_TArray_Action_d_T_p_.SetBelong(null);
				}
				return r_MForEach_GT_TArray_Action_d_T_p_;
			}
		}

		/// <summary>
		/// Int64 GetLongLength(Int32)
		/// </summary>
		protected RMethod r_MGetLongLength_Int32;
		public virtual RMethod RMGetLongLength_Int32
		{
			get
			{
				if(r_MGetLongLength_Int32 == null)
				{
					r_MGetLongLength_Int32 = new(this, "GetLongLength", 0, typeof(System.Int32));
					r_MGetLongLength_Int32.SetBelong(this.instance);
				}
				return r_MGetLongLength_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64)
		/// </summary>
		protected RMethod r_MGetValue_Int64;
		public virtual RMethod RMGetValue_Int64
		{
			get
			{
				if(r_MGetValue_Int64 == null)
				{
					r_MGetValue_Int64 = new(this, "GetValue", 0, typeof(System.Int64));
					r_MGetValue_Int64.SetBelong(this.instance);
				}
				return r_MGetValue_Int64;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64, Int64)
		/// </summary>
		protected RMethod r_MGetValue_Int64_Int64;
		public virtual RMethod RMGetValue_Int64_Int64
		{
			get
			{
				if(r_MGetValue_Int64_Int64 == null)
				{
					r_MGetValue_Int64_Int64 = new(this, "GetValue", 0, typeof(System.Int64), typeof(System.Int64));
					r_MGetValue_Int64_Int64.SetBelong(this.instance);
				}
				return r_MGetValue_Int64_Int64;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_MGetValue_Int64_Int64_Int64;
		public virtual RMethod RMGetValue_Int64_Int64_Int64
		{
			get
			{
				if(r_MGetValue_Int64_Int64_Int64 == null)
				{
					r_MGetValue_Int64_Int64_Int64 = new(this, "GetValue", 0, typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_MGetValue_Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_MGetValue_Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int64[])
		/// </summary>
		protected RMethod r_MGetValue_Int64Array;
		public virtual RMethod RMGetValue_Int64Array
		{
			get
			{
				if(r_MGetValue_Int64Array == null)
				{
					r_MGetValue_Int64Array = new(this, "GetValue", 0, typeof(System.Int64).MakeArrayType());
					r_MGetValue_Int64Array.SetBelong(this.instance);
				}
				return r_MGetValue_Int64Array;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, Int32, Int32, System.Object)
		/// </summary>
		protected static RMethod r_MBinarySearch_Array_Int32_Int32_Object;
		public static RMethod RMBinarySearch_Array_Int32_Int32_Object
		{
			get
			{
				if(r_MBinarySearch_Array_Int32_Int32_Object == null)
				{
					r_MBinarySearch_Array_Int32_Int32_Object = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Object));
					r_MBinarySearch_Array_Int32_Int32_Object.SetBelong(null);
				}
				return r_MBinarySearch_Array_Int32_Int32_Object;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, System.Object, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MBinarySearch_Array_Object_IComparer;
		public static RMethod RMBinarySearch_Array_Object_IComparer
		{
			get
			{
				if(r_MBinarySearch_Array_Object_IComparer == null)
				{
					r_MBinarySearch_Array_Object_IComparer = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Object), typeof(System.Collections.IComparer));
					r_MBinarySearch_Array_Object_IComparer.SetBelong(null);
				}
				return r_MBinarySearch_Array_Object_IComparer;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, Int32, Int32, System.Object, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MBinarySearch_Array_Int32_Int32_Object_IComparer;
		public static RMethod RMBinarySearch_Array_Int32_Int32_Object_IComparer
		{
			get
			{
				if(r_MBinarySearch_Array_Int32_Int32_Object_IComparer == null)
				{
					r_MBinarySearch_Array_Int32_Int32_Object_IComparer = new(typeof(System.Array), "BinarySearch", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Object), typeof(System.Collections.IComparer));
					r_MBinarySearch_Array_Int32_Int32_Object_IComparer.SetBelong(null);
				}
				return r_MBinarySearch_Array_Int32_Int32_Object_IComparer;
			}
		}

		/// <summary>
		/// Int32 GetMedian(Int32, Int32)
		/// </summary>
		protected static RMethod r_MGetMedian_Int32_Int32;
		public static RMethod RMGetMedian_Int32_Int32
		{
			get
			{
				if(r_MGetMedian_Int32_Int32 == null)
				{
					r_MGetMedian_Int32_Int32 = new(typeof(System.Array), "GetMedian", 0, typeof(System.Int32), typeof(System.Int32));
					r_MGetMedian_Int32_Int32.SetBelong(null);
				}
				return r_MGetMedian_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], T)
		/// </summary>
		protected static RMethod r_MBinarySearch_GT_TArray_T;
		public static RMethod RMBinarySearch_GT_TArray_T
		{
			get
			{
				if(r_MBinarySearch_GT_TArray_T == null)
				{
					r_MBinarySearch_GT_TArray_T = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_MBinarySearch_GT_TArray_T.SetBelong(null);
				}
				return r_MBinarySearch_GT_TArray_T;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_MBinarySearch_GT_TArray_T_IComparer_d_T_p_;
		public static RMethod RMBinarySearch_GT_TArray_T_IComparer_d_T_p_
		{
			get
			{
				if(r_MBinarySearch_GT_TArray_T_IComparer_d_T_p_ == null)
				{
					r_MBinarySearch_GT_TArray_T_IComparer_d_T_p_ = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MBinarySearch_GT_TArray_T_IComparer_d_T_p_.SetBelong(null);
				}
				return r_MBinarySearch_GT_TArray_T_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], Int32, Int32, T)
		/// </summary>
		protected static RMethod r_MBinarySearch_GT_TArray_Int32_Int32_T;
		public static RMethod RMBinarySearch_GT_TArray_Int32_Int32_T
		{
			get
			{
				if(r_MBinarySearch_GT_TArray_Int32_Int32_T == null)
				{
					r_MBinarySearch_GT_TArray_Int32_Int32_T = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_MBinarySearch_GT_TArray_Int32_Int32_T.SetBelong(null);
				}
				return r_MBinarySearch_GT_TArray_Int32_Int32_T;
			}
		}

		/// <summary>
		/// Int32 BinarySearch[T](T[], Int32, Int32, T, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_MBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_;
		public static RMethod RMBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_
		{
			get
			{
				if(r_MBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_ == null)
				{
					r_MBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_ = new(typeof(System.Array), "BinarySearch", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), Type.MakeGenericMethodParameter(0), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_.SetBelong(null);
				}
				return r_MBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_MIndexOf_Array_Object;
		public static RMethod RMIndexOf_Array_Object
		{
			get
			{
				if(r_MIndexOf_Array_Object == null)
				{
					r_MIndexOf_Array_Object = new(typeof(System.Array), "IndexOf", 0, typeof(System.Array), typeof(System.Object));
					r_MIndexOf_Array_Object.SetBelong(null);
				}
				return r_MIndexOf_Array_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Array, System.Object, Int32)
		/// </summary>
		protected static RMethod r_MIndexOf_Array_Object_Int32;
		public static RMethod RMIndexOf_Array_Object_Int32
		{
			get
			{
				if(r_MIndexOf_Array_Object_Int32 == null)
				{
					r_MIndexOf_Array_Object_Int32 = new(typeof(System.Array), "IndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32));
					r_MIndexOf_Array_Object_Int32.SetBelong(null);
				}
				return r_MIndexOf_Array_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Array, System.Object, Int32, Int32)
		/// </summary>
		protected static RMethod r_MIndexOf_Array_Object_Int32_Int32;
		public static RMethod RMIndexOf_Array_Object_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_Array_Object_Int32_Int32 == null)
				{
					r_MIndexOf_Array_Object_Int32_Int32 = new(typeof(System.Array), "IndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_Array_Object_Int32_Int32.SetBelong(null);
				}
				return r_MIndexOf_Array_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf[T](T[], T)
		/// </summary>
		protected static RMethod r_MIndexOf_GT_TArray_T;
		public static RMethod RMIndexOf_GT_TArray_T
		{
			get
			{
				if(r_MIndexOf_GT_TArray_T == null)
				{
					r_MIndexOf_GT_TArray_T = new(typeof(System.Array), "IndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_MIndexOf_GT_TArray_T.SetBelong(null);
				}
				return r_MIndexOf_GT_TArray_T;
			}
		}

		/// <summary>
		/// Int32 IndexOf[T](T[], T, Int32)
		/// </summary>
		protected static RMethod r_MIndexOf_GT_TArray_T_Int32;
		public static RMethod RMIndexOf_GT_TArray_T_Int32
		{
			get
			{
				if(r_MIndexOf_GT_TArray_T_Int32 == null)
				{
					r_MIndexOf_GT_TArray_T_Int32 = new(typeof(System.Array), "IndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32));
					r_MIndexOf_GT_TArray_T_Int32.SetBelong(null);
				}
				return r_MIndexOf_GT_TArray_T_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_MIndexOf_GT_TArray_T_Int32_Int32;
		public static RMethod RMIndexOf_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_GT_TArray_T_Int32_Int32 == null)
				{
					r_MIndexOf_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "IndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_MIndexOf_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_MLastIndexOf_Array_Object;
		public static RMethod RMLastIndexOf_Array_Object
		{
			get
			{
				if(r_MLastIndexOf_Array_Object == null)
				{
					r_MLastIndexOf_Array_Object = new(typeof(System.Array), "LastIndexOf", 0, typeof(System.Array), typeof(System.Object));
					r_MLastIndexOf_Array_Object.SetBelong(null);
				}
				return r_MLastIndexOf_Array_Object;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Array, System.Object, Int32)
		/// </summary>
		protected static RMethod r_MLastIndexOf_Array_Object_Int32;
		public static RMethod RMLastIndexOf_Array_Object_Int32
		{
			get
			{
				if(r_MLastIndexOf_Array_Object_Int32 == null)
				{
					r_MLastIndexOf_Array_Object_Int32 = new(typeof(System.Array), "LastIndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32));
					r_MLastIndexOf_Array_Object_Int32.SetBelong(null);
				}
				return r_MLastIndexOf_Array_Object_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.Array, System.Object, Int32, Int32)
		/// </summary>
		protected static RMethod r_MLastIndexOf_Array_Object_Int32_Int32;
		public static RMethod RMLastIndexOf_Array_Object_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_Array_Object_Int32_Int32 == null)
				{
					r_MLastIndexOf_Array_Object_Int32_Int32 = new(typeof(System.Array), "LastIndexOf", 0, typeof(System.Array), typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_Array_Object_Int32_Int32.SetBelong(null);
				}
				return r_MLastIndexOf_Array_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf[T](T[], T)
		/// </summary>
		protected static RMethod r_MLastIndexOf_GT_TArray_T;
		public static RMethod RMLastIndexOf_GT_TArray_T
		{
			get
			{
				if(r_MLastIndexOf_GT_TArray_T == null)
				{
					r_MLastIndexOf_GT_TArray_T = new(typeof(System.Array), "LastIndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_MLastIndexOf_GT_TArray_T.SetBelong(null);
				}
				return r_MLastIndexOf_GT_TArray_T;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf[T](T[], T, Int32)
		/// </summary>
		protected static RMethod r_MLastIndexOf_GT_TArray_T_Int32;
		public static RMethod RMLastIndexOf_GT_TArray_T_Int32
		{
			get
			{
				if(r_MLastIndexOf_GT_TArray_T_Int32 == null)
				{
					r_MLastIndexOf_GT_TArray_T_Int32 = new(typeof(System.Array), "LastIndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32));
					r_MLastIndexOf_GT_TArray_T_Int32.SetBelong(null);
				}
				return r_MLastIndexOf_GT_TArray_T_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_MLastIndexOf_GT_TArray_T_Int32_Int32;
		public static RMethod RMLastIndexOf_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_GT_TArray_T_Int32_Int32 == null)
				{
					r_MLastIndexOf_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "LastIndexOf", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_MLastIndexOf_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Reverse(System.Array)
		/// </summary>
		protected static RMethod r_MReverse_Array;
		public static RMethod RMReverse_Array
		{
			get
			{
				if(r_MReverse_Array == null)
				{
					r_MReverse_Array = new(typeof(System.Array), "Reverse", 0, typeof(System.Array));
					r_MReverse_Array.SetBelong(null);
				}
				return r_MReverse_Array;
			}
		}

		/// <summary>
		/// Void Reverse(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MReverse_Array_Int32_Int32;
		public static RMethod RMReverse_Array_Int32_Int32
		{
			get
			{
				if(r_MReverse_Array_Int32_Int32 == null)
				{
					r_MReverse_Array_Int32_Int32 = new(typeof(System.Array), "Reverse", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MReverse_Array_Int32_Int32.SetBelong(null);
				}
				return r_MReverse_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Reverse[T](T[])
		/// </summary>
		protected static RMethod r_MReverse_GT_TArray;
		public static RMethod RMReverse_GT_TArray
		{
			get
			{
				if(r_MReverse_GT_TArray == null)
				{
					r_MReverse_GT_TArray = new(typeof(System.Array), "Reverse", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_MReverse_GT_TArray.SetBelong(null);
				}
				return r_MReverse_GT_TArray;
			}
		}

		/// <summary>
		/// Void Reverse[T](T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MReverse_GT_TArray_Int32_Int32;
		public static RMethod RMReverse_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_MReverse_GT_TArray_Int32_Int32 == null)
				{
					r_MReverse_GT_TArray_Int32_Int32 = new(typeof(System.Array), "Reverse", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MReverse_GT_TArray_Int32_Int32.SetBelong(null);
				}
				return r_MReverse_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64)
		/// </summary>
		protected RMethod r_MSetValue_Object_Int64;
		public virtual RMethod RMSetValue_Object_Int64
		{
			get
			{
				if(r_MSetValue_Object_Int64 == null)
				{
					r_MSetValue_Object_Int64 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64));
					r_MSetValue_Object_Int64.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int64;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64, Int64)
		/// </summary>
		protected RMethod r_MSetValue_Object_Int64_Int64;
		public virtual RMethod RMSetValue_Object_Int64_Int64
		{
			get
			{
				if(r_MSetValue_Object_Int64_Int64 == null)
				{
					r_MSetValue_Object_Int64_Int64 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64), typeof(System.Int64));
					r_MSetValue_Object_Int64_Int64.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int64_Int64;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64, Int64, Int64)
		/// </summary>
		protected RMethod r_MSetValue_Object_Int64_Int64_Int64;
		public virtual RMethod RMSetValue_Object_Int64_Int64_Int64
		{
			get
			{
				if(r_MSetValue_Object_Int64_Int64_Int64 == null)
				{
					r_MSetValue_Object_Int64_Int64_Int64 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64), typeof(System.Int64), typeof(System.Int64));
					r_MSetValue_Object_Int64_Int64_Int64.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int64_Int64_Int64;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int64[])
		/// </summary>
		protected RMethod r_MSetValue_Object_Int64Array;
		public virtual RMethod RMSetValue_Object_Int64Array
		{
			get
			{
				if(r_MSetValue_Object_Int64Array == null)
				{
					r_MSetValue_Object_Int64Array = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int64).MakeArrayType());
					r_MSetValue_Object_Int64Array.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int64Array;
			}
		}

		/// <summary>
		/// Void Sort(System.Array)
		/// </summary>
		protected static RMethod r_MSort_Array;
		public static RMethod RMSort_Array
		{
			get
			{
				if(r_MSort_Array == null)
				{
					r_MSort_Array = new(typeof(System.Array), "Sort", 0, typeof(System.Array));
					r_MSort_Array.SetBelong(null);
				}
				return r_MSort_Array;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSort_Array_Int32_Int32;
		public static RMethod RMSort_Array_Int32_Int32
		{
			get
			{
				if(r_MSort_Array_Int32_Int32 == null)
				{
					r_MSort_Array_Int32_Int32 = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MSort_Array_Int32_Int32.SetBelong(null);
				}
				return r_MSort_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MSort_Array_IComparer;
		public static RMethod RMSort_Array_IComparer
		{
			get
			{
				if(r_MSort_Array_IComparer == null)
				{
					r_MSort_Array_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Collections.IComparer));
					r_MSort_Array_IComparer.SetBelong(null);
				}
				return r_MSort_Array_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MSort_Array_Int32_Int32_IComparer;
		public static RMethod RMSort_Array_Int32_Int32_IComparer
		{
			get
			{
				if(r_MSort_Array_Int32_Int32_IComparer == null)
				{
					r_MSort_Array_Int32_Int32_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_MSort_Array_Int32_Int32_IComparer.SetBelong(null);
				}
				return r_MSort_Array_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array)
		/// </summary>
		protected static RMethod r_MSort_Array_Array;
		public static RMethod RMSort_Array_Array
		{
			get
			{
				if(r_MSort_Array_Array == null)
				{
					r_MSort_Array_Array = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array));
					r_MSort_Array_Array.SetBelong(null);
				}
				return r_MSort_Array_Array;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MSort_Array_Array_IComparer;
		public static RMethod RMSort_Array_Array_IComparer
		{
			get
			{
				if(r_MSort_Array_Array_IComparer == null)
				{
					r_MSort_Array_Array_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array), typeof(System.Collections.IComparer));
					r_MSort_Array_Array_IComparer.SetBelong(null);
				}
				return r_MSort_Array_Array_IComparer;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSort_Array_Array_Int32_Int32;
		public static RMethod RMSort_Array_Array_Int32_Int32
		{
			get
			{
				if(r_MSort_Array_Array_Int32_Int32 == null)
				{
					r_MSort_Array_Array_Int32_Int32 = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MSort_Array_Array_Int32_Int32.SetBelong(null);
				}
				return r_MSort_Array_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort(System.Array, System.Array, Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MSort_Array_Array_Int32_Int32_IComparer;
		public static RMethod RMSort_Array_Array_Int32_Int32_IComparer
		{
			get
			{
				if(r_MSort_Array_Array_Int32_Int32_IComparer == null)
				{
					r_MSort_Array_Array_Int32_Int32_IComparer = new(typeof(System.Array), "Sort", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_MSort_Array_Array_Int32_Int32_IComparer.SetBelong(null);
				}
				return r_MSort_Array_Array_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// Void Sort[T](T[])
		/// </summary>
		protected static RMethod r_MSort_GT_TArray;
		public static RMethod RMSort_GT_TArray
		{
			get
			{
				if(r_MSort_GT_TArray == null)
				{
					r_MSort_GT_TArray = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_MSort_GT_TArray.SetBelong(null);
				}
				return r_MSort_GT_TArray;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MSort_GT_TArray_Int32_Int32;
		public static RMethod RMSort_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_MSort_GT_TArray_Int32_Int32 == null)
				{
					r_MSort_GT_TArray_Int32_Int32 = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MSort_GT_TArray_Int32_Int32.SetBelong(null);
				}
				return r_MSort_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_MSort_GT_TArray_IComparer_d_T_p_;
		public static RMethod RMSort_GT_TArray_IComparer_d_T_p_
		{
			get
			{
				if(r_MSort_GT_TArray_IComparer_d_T_p_ == null)
				{
					r_MSort_GT_TArray_IComparer_d_T_p_ = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSort_GT_TArray_IComparer_d_T_p_.SetBelong(null);
				}
				return r_MSort_GT_TArray_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], Int32, Int32, System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_MSort_GT_TArray_Int32_Int32_IComparer_d_T_p_;
		public static RMethod RMSort_GT_TArray_Int32_Int32_IComparer_d_T_p_
		{
			get
			{
				if(r_MSort_GT_TArray_Int32_Int32_IComparer_d_T_p_ == null)
				{
					r_MSort_GT_TArray_Int32_Int32_IComparer_d_T_p_ = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSort_GT_TArray_Int32_Int32_IComparer_d_T_p_.SetBelong(null);
				}
				return r_MSort_GT_TArray_Int32_Int32_IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort[T](T[], System.Comparison`1[T])
		/// </summary>
		protected static RMethod r_MSort_GT_TArray_Comparison_d_T_p_;
		public static RMethod RMSort_GT_TArray_Comparison_d_T_p_
		{
			get
			{
				if(r_MSort_GT_TArray_Comparison_d_T_p_ == null)
				{
					r_MSort_GT_TArray_Comparison_d_T_p_ = new(typeof(System.Array), "Sort", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Comparison<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSort_GT_TArray_Comparison_d_T_p_.SetBelong(null);
				}
				return r_MSort_GT_TArray_Comparison_d_T_p_;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[])
		/// </summary>
		protected static RMethod r_MSort_GTKey_GTValue_TKeyArray_TValueArray;
		public static RMethod RMSort_GTKey_GTValue_TKeyArray_TValueArray
		{
			get
			{
				if(r_MSort_GTKey_GTValue_TKeyArray_TValueArray == null)
				{
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType());
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray.SetBelong(null);
				}
				return r_MSort_GTKey_GTValue_TKeyArray_TValueArray;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32;
		public static RMethod RMSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32
		{
			get
			{
				if(r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32 == null)
				{
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32 = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32.SetBelong(null);
				}
				return r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[], System.Collections.Generic.IComparer`1[TKey])
		/// </summary>
		protected static RMethod r_MSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_;
		public static RMethod RMSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_
		{
			get
			{
				if(r_MSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_ == null)
				{
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_ = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_.SetBelong(null);
				}
				return r_MSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_;
			}
		}

		/// <summary>
		/// Void Sort[TKey,TValue](TKey[], TValue[], Int32, Int32, System.Collections.Generic.IComparer`1[TKey])
		/// </summary>
		protected static RMethod r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_;
		public static RMethod RMSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_
		{
			get
			{
				if(r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_ == null)
				{
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_ = new(typeof(System.Array), "Sort", 2, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_.SetBelong(null);
				}
				return r_MSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_;
			}
		}

		/// <summary>
		/// Boolean Exists[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MExists_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMExists_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MExists_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MExists_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "Exists", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MExists_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MExists_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void Fill[T](T[], T)
		/// </summary>
		protected static RMethod r_MFill_GT_TArray_T;
		public static RMethod RMFill_GT_TArray_T
		{
			get
			{
				if(r_MFill_GT_TArray_T == null)
				{
					r_MFill_GT_TArray_T = new(typeof(System.Array), "Fill", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0));
					r_MFill_GT_TArray_T.SetBelong(null);
				}
				return r_MFill_GT_TArray_T;
			}
		}

		/// <summary>
		/// Void Fill[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_MFill_GT_TArray_T_Int32_Int32;
		public static RMethod RMFill_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_MFill_GT_TArray_T_Int32_Int32 == null)
				{
					r_MFill_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "Fill", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_MFill_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_MFill_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// T Find[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFind_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMFind_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MFind_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MFind_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "Find", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFind_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFind_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T[] FindAll[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindAll_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMFindAll_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindAll_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MFindAll_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindAll", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindAll_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindAll_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindIndex_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMFindIndex_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindIndex_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MFindIndex_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindIndex_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindIndex_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex[T](T[], Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindIndex_GT_TArray_Int32_Predicate_d_T_p_;
		public static RMethod RMFindIndex_GT_TArray_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindIndex_GT_TArray_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindIndex_GT_TArray_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindIndex_GT_TArray_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindIndex_GT_TArray_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindIndex[T](T[], Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
		public static RMethod RMFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// T FindLast[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindLast_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMFindLast_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLast_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MFindLast_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindLast", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindLast_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindLast_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindLastIndex_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMFindLastIndex_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLastIndex_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MFindLastIndex_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "FindLastIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindLastIndex_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindLastIndex_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex[T](T[], Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_;
		public static RMethod RMFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindLastIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Int32 FindLastIndex[T](T[], Int32, Int32, System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
		public static RMethod RMFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_
		{
			get
			{
				if(r_MFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ == null)
				{
					r_MFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_ = new(typeof(System.Array), "FindLastIndex", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean TrueForAll[T](T[], System.Predicate`1[T])
		/// </summary>
		protected static RMethod r_MTrueForAll_GT_TArray_Predicate_d_T_p_;
		public static RMethod RMTrueForAll_GT_TArray_Predicate_d_T_p_
		{
			get
			{
				if(r_MTrueForAll_GT_TArray_Predicate_d_T_p_ == null)
				{
					r_MTrueForAll_GT_TArray_Predicate_d_T_p_ = new(typeof(System.Array), "TrueForAll", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MTrueForAll_GT_TArray_Predicate_d_T_p_.SetBelong(null);
				}
				return r_MTrueForAll_GT_TArray_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
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
		/// Int32 InternalArray__ICollection_get_Count()
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_get_Count;
		public virtual RMethod RMInternalArray__ICollection_get_Count
		{
			get
			{
				if(r_MInternalArray__ICollection_get_Count == null)
				{
					r_MInternalArray__ICollection_get_Count = new(this, "InternalArray__ICollection_get_Count", 0);
					r_MInternalArray__ICollection_get_Count.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_get_Count;
			}
		}

		/// <summary>
		/// Boolean InternalArray__ICollection_get_IsReadOnly()
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_get_IsReadOnly;
		public virtual RMethod RMInternalArray__ICollection_get_IsReadOnly
		{
			get
			{
				if(r_MInternalArray__ICollection_get_IsReadOnly == null)
				{
					r_MInternalArray__ICollection_get_IsReadOnly = new(this, "InternalArray__ICollection_get_IsReadOnly", 0);
					r_MInternalArray__ICollection_get_IsReadOnly.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_get_IsReadOnly;
			}
		}

		/// <summary>
		/// Byte& GetRawSzArrayData()
		/// </summary>
		protected RMethod r_MGetRawSzArrayData;
		public virtual RMethod RMGetRawSzArrayData
		{
			get
			{
				if(r_MGetRawSzArrayData == null)
				{
					r_MGetRawSzArrayData = new(this, "GetRawSzArrayData", 0);
					r_MGetRawSzArrayData.SetBelong(this.instance);
				}
				return r_MGetRawSzArrayData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[T] InternalArray__IEnumerable_GetEnumerator[T]()
		/// </summary>
		protected RMethod r_MInternalArray__IEnumerable_GetEnumerator_GT;
		public virtual RMethod RMInternalArray__IEnumerable_GetEnumerator_GT
		{
			get
			{
				if(r_MInternalArray__IEnumerable_GetEnumerator_GT == null)
				{
					r_MInternalArray__IEnumerable_GetEnumerator_GT = new(this, "InternalArray__IEnumerable_GetEnumerator", 1);
					r_MInternalArray__IEnumerable_GetEnumerator_GT.SetBelong(this.instance);
				}
				return r_MInternalArray__IEnumerable_GetEnumerator_GT;
			}
		}

		/// <summary>
		/// Void InternalArray__ICollection_Clear()
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_Clear;
		public virtual RMethod RMInternalArray__ICollection_Clear
		{
			get
			{
				if(r_MInternalArray__ICollection_Clear == null)
				{
					r_MInternalArray__ICollection_Clear = new(this, "InternalArray__ICollection_Clear", 0);
					r_MInternalArray__ICollection_Clear.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_Clear;
			}
		}

		/// <summary>
		/// Void InternalArray__ICollection_Add[T](T)
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_Add_GT_T;
		public virtual RMethod RMInternalArray__ICollection_Add_GT_T
		{
			get
			{
				if(r_MInternalArray__ICollection_Add_GT_T == null)
				{
					r_MInternalArray__ICollection_Add_GT_T = new(this, "InternalArray__ICollection_Add", 1, Type.MakeGenericMethodParameter(0));
					r_MInternalArray__ICollection_Add_GT_T.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_Add_GT_T;
			}
		}

		/// <summary>
		/// Boolean InternalArray__ICollection_Remove[T](T)
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_Remove_GT_T;
		public virtual RMethod RMInternalArray__ICollection_Remove_GT_T
		{
			get
			{
				if(r_MInternalArray__ICollection_Remove_GT_T == null)
				{
					r_MInternalArray__ICollection_Remove_GT_T = new(this, "InternalArray__ICollection_Remove", 1, Type.MakeGenericMethodParameter(0));
					r_MInternalArray__ICollection_Remove_GT_T.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_Remove_GT_T;
			}
		}

		/// <summary>
		/// Boolean InternalArray__ICollection_Contains[T](T)
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_Contains_GT_T;
		public virtual RMethod RMInternalArray__ICollection_Contains_GT_T
		{
			get
			{
				if(r_MInternalArray__ICollection_Contains_GT_T == null)
				{
					r_MInternalArray__ICollection_Contains_GT_T = new(this, "InternalArray__ICollection_Contains", 1, Type.MakeGenericMethodParameter(0));
					r_MInternalArray__ICollection_Contains_GT_T.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_Contains_GT_T;
			}
		}

		/// <summary>
		/// Void InternalArray__ICollection_CopyTo[T](T[], Int32)
		/// </summary>
		protected RMethod r_MInternalArray__ICollection_CopyTo_GT_TArray_Int32;
		public virtual RMethod RMInternalArray__ICollection_CopyTo_GT_TArray_Int32
		{
			get
			{
				if(r_MInternalArray__ICollection_CopyTo_GT_TArray_Int32 == null)
				{
					r_MInternalArray__ICollection_CopyTo_GT_TArray_Int32 = new(this, "InternalArray__ICollection_CopyTo", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_MInternalArray__ICollection_CopyTo_GT_TArray_Int32.SetBelong(this.instance);
				}
				return r_MInternalArray__ICollection_CopyTo_GT_TArray_Int32;
			}
		}

		/// <summary>
		/// T InternalArray__IReadOnlyList_get_Item[T](Int32)
		/// </summary>
		protected RMethod r_MInternalArray__IReadOnlyList_get_Item_GT_Int32;
		public virtual RMethod RMInternalArray__IReadOnlyList_get_Item_GT_Int32
		{
			get
			{
				if(r_MInternalArray__IReadOnlyList_get_Item_GT_Int32 == null)
				{
					r_MInternalArray__IReadOnlyList_get_Item_GT_Int32 = new(this, "InternalArray__IReadOnlyList_get_Item", 1, typeof(System.Int32));
					r_MInternalArray__IReadOnlyList_get_Item_GT_Int32.SetBelong(this.instance);
				}
				return r_MInternalArray__IReadOnlyList_get_Item_GT_Int32;
			}
		}

		/// <summary>
		/// Int32 InternalArray__IReadOnlyCollection_get_Count()
		/// </summary>
		protected RMethod r_MInternalArray__IReadOnlyCollection_get_Count;
		public virtual RMethod RMInternalArray__IReadOnlyCollection_get_Count
		{
			get
			{
				if(r_MInternalArray__IReadOnlyCollection_get_Count == null)
				{
					r_MInternalArray__IReadOnlyCollection_get_Count = new(this, "InternalArray__IReadOnlyCollection_get_Count", 0);
					r_MInternalArray__IReadOnlyCollection_get_Count.SetBelong(this.instance);
				}
				return r_MInternalArray__IReadOnlyCollection_get_Count;
			}
		}

		/// <summary>
		/// Void InternalArray__Insert[T](Int32, T)
		/// </summary>
		protected RMethod r_MInternalArray__Insert_GT_Int32_T;
		public virtual RMethod RMInternalArray__Insert_GT_Int32_T
		{
			get
			{
				if(r_MInternalArray__Insert_GT_Int32_T == null)
				{
					r_MInternalArray__Insert_GT_Int32_T = new(this, "InternalArray__Insert", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_MInternalArray__Insert_GT_Int32_T.SetBelong(this.instance);
				}
				return r_MInternalArray__Insert_GT_Int32_T;
			}
		}

		/// <summary>
		/// Void InternalArray__RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MInternalArray__RemoveAt_Int32;
		public virtual RMethod RMInternalArray__RemoveAt_Int32
		{
			get
			{
				if(r_MInternalArray__RemoveAt_Int32 == null)
				{
					r_MInternalArray__RemoveAt_Int32 = new(this, "InternalArray__RemoveAt", 0, typeof(System.Int32));
					r_MInternalArray__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MInternalArray__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Int32 InternalArray__IndexOf[T](T)
		/// </summary>
		protected RMethod r_MInternalArray__IndexOf_GT_T;
		public virtual RMethod RMInternalArray__IndexOf_GT_T
		{
			get
			{
				if(r_MInternalArray__IndexOf_GT_T == null)
				{
					r_MInternalArray__IndexOf_GT_T = new(this, "InternalArray__IndexOf", 1, Type.MakeGenericMethodParameter(0));
					r_MInternalArray__IndexOf_GT_T.SetBelong(this.instance);
				}
				return r_MInternalArray__IndexOf_GT_T;
			}
		}

		/// <summary>
		/// T InternalArray__get_Item[T](Int32)
		/// </summary>
		protected RMethod r_MInternalArray__get_Item_GT_Int32;
		public virtual RMethod RMInternalArray__get_Item_GT_Int32
		{
			get
			{
				if(r_MInternalArray__get_Item_GT_Int32 == null)
				{
					r_MInternalArray__get_Item_GT_Int32 = new(this, "InternalArray__get_Item", 1, typeof(System.Int32));
					r_MInternalArray__get_Item_GT_Int32.SetBelong(this.instance);
				}
				return r_MInternalArray__get_Item_GT_Int32;
			}
		}

		/// <summary>
		/// Void InternalArray__set_Item[T](Int32, T)
		/// </summary>
		protected RMethod r_MInternalArray__set_Item_GT_Int32_T;
		public virtual RMethod RMInternalArray__set_Item_GT_Int32_T
		{
			get
			{
				if(r_MInternalArray__set_Item_GT_Int32_T == null)
				{
					r_MInternalArray__set_Item_GT_Int32_T = new(this, "InternalArray__set_Item", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_MInternalArray__set_Item_GT_Int32_T.SetBelong(this.instance);
				}
				return r_MInternalArray__set_Item_GT_Int32_T;
			}
		}

		/// <summary>
		/// Void GetGenericValue_icall[T](System.Array ByRef, Int32, T ByRef)
		/// </summary>
		protected static RMethod r_MGetGenericValue_icall_GT_Ref_Array_Int32_Out_T;
		public static RMethod RMGetGenericValue_icall_GT_Ref_Array_Int32_Out_T
		{
			get
			{
				if(r_MGetGenericValue_icall_GT_Ref_Array_Int32_Out_T == null)
				{
					r_MGetGenericValue_icall_GT_Ref_Array_Int32_Out_T = new(typeof(System.Array), "GetGenericValue_icall", 1, typeof(System.Array).MakeByRefType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MGetGenericValue_icall_GT_Ref_Array_Int32_Out_T.SetBelong(null);
				}
				return r_MGetGenericValue_icall_GT_Ref_Array_Int32_Out_T;
			}
		}

		/// <summary>
		/// Void SetGenericValue_icall[T](System.Array ByRef, Int32, T ByRef)
		/// </summary>
		protected static RMethod r_MSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T;
		public static RMethod RMSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T
		{
			get
			{
				if(r_MSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T == null)
				{
					r_MSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T = new(typeof(System.Array), "SetGenericValue_icall", 1, typeof(System.Array).MakeByRefType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T.SetBelong(null);
				}
				return r_MSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T;
			}
		}

		/// <summary>
		/// Void GetGenericValueImpl[T](Int32, T ByRef)
		/// </summary>
		protected RMethod r_MGetGenericValueImpl_GT_Int32_Out_T;
		public virtual RMethod RMGetGenericValueImpl_GT_Int32_Out_T
		{
			get
			{
				if(r_MGetGenericValueImpl_GT_Int32_Out_T == null)
				{
					r_MGetGenericValueImpl_GT_Int32_Out_T = new(this, "GetGenericValueImpl", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MGetGenericValueImpl_GT_Int32_Out_T.SetBelong(this.instance);
				}
				return r_MGetGenericValueImpl_GT_Int32_Out_T;
			}
		}

		/// <summary>
		/// Void SetGenericValueImpl[T](Int32, T ByRef)
		/// </summary>
		protected RMethod r_MSetGenericValueImpl_GT_Int32_Ref_T;
		public virtual RMethod RMSetGenericValueImpl_GT_Int32_Ref_T
		{
			get
			{
				if(r_MSetGenericValueImpl_GT_Int32_Ref_T == null)
				{
					r_MSetGenericValueImpl_GT_Int32_Ref_T = new(this, "SetGenericValueImpl", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MSetGenericValueImpl_GT_Int32_Ref_T.SetBelong(this.instance);
				}
				return r_MSetGenericValueImpl_GT_Int32_Ref_T;
			}
		}

		/// <summary>
		/// Int32 GetRank()
		/// </summary>
		protected RMethod r_MGetRank;
		public virtual RMethod RMGetRank
		{
			get
			{
				if(r_MGetRank == null)
				{
					r_MGetRank = new(this, "GetRank", 0);
					r_MGetRank.SetBelong(this.instance);
				}
				return r_MGetRank;
			}
		}

		/// <summary>
		/// Int32 GetLength(Int32)
		/// </summary>
		protected RMethod r_MGetLength_Int32;
		public virtual RMethod RMGetLength_Int32
		{
			get
			{
				if(r_MGetLength_Int32 == null)
				{
					r_MGetLength_Int32 = new(this, "GetLength", 0, typeof(System.Int32));
					r_MGetLength_Int32.SetBelong(this.instance);
				}
				return r_MGetLength_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLowerBound(Int32)
		/// </summary>
		protected RMethod r_MGetLowerBound_Int32;
		public virtual RMethod RMGetLowerBound_Int32
		{
			get
			{
				if(r_MGetLowerBound_Int32 == null)
				{
					r_MGetLowerBound_Int32 = new(this, "GetLowerBound", 0, typeof(System.Int32));
					r_MGetLowerBound_Int32.SetBelong(this.instance);
				}
				return r_MGetLowerBound_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32[])
		/// </summary>
		protected RMethod r_MGetValue_Int32Array;
		public virtual RMethod RMGetValue_Int32Array
		{
			get
			{
				if(r_MGetValue_Int32Array == null)
				{
					r_MGetValue_Int32Array = new(this, "GetValue", 0, typeof(System.Int32).MakeArrayType());
					r_MGetValue_Int32Array.SetBelong(this.instance);
				}
				return r_MGetValue_Int32Array;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32[])
		/// </summary>
		protected RMethod r_MSetValue_Object_Int32Array;
		public virtual RMethod RMSetValue_Object_Int32Array
		{
			get
			{
				if(r_MSetValue_Object_Int32Array == null)
				{
					r_MSetValue_Object_Int32Array = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32).MakeArrayType());
					r_MSetValue_Object_Int32Array.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int32Array;
			}
		}

		/// <summary>
		/// System.Object GetValueImpl(Int32)
		/// </summary>
		protected RMethod r_MGetValueImpl_Int32;
		public virtual RMethod RMGetValueImpl_Int32
		{
			get
			{
				if(r_MGetValueImpl_Int32 == null)
				{
					r_MGetValueImpl_Int32 = new(this, "GetValueImpl", 0, typeof(System.Int32));
					r_MGetValueImpl_Int32.SetBelong(this.instance);
				}
				return r_MGetValueImpl_Int32;
			}
		}

		/// <summary>
		/// Void SetValueImpl(System.Object, Int32)
		/// </summary>
		protected RMethod r_MSetValueImpl_Object_Int32;
		public virtual RMethod RMSetValueImpl_Object_Int32
		{
			get
			{
				if(r_MSetValueImpl_Object_Int32 == null)
				{
					r_MSetValueImpl_Object_Int32 = new(this, "SetValueImpl", 0, typeof(System.Object), typeof(System.Int32));
					r_MSetValueImpl_Object_Int32.SetBelong(this.instance);
				}
				return r_MSetValueImpl_Object_Int32;
			}
		}

		/// <summary>
		/// Boolean FastCopy(System.Array, Int32, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MFastCopy_Array_Int32_Array_Int32_Int32;
		public static RMethod RMFastCopy_Array_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_MFastCopy_Array_Int32_Array_Int32_Int32 == null)
				{
					r_MFastCopy_Array_Int32_Array_Int32_Int32 = new(typeof(System.Array), "FastCopy", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MFastCopy_Array_Int32_Array_Int32_Int32.SetBelong(null);
				}
				return r_MFastCopy_Array_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstanceImpl(System.Type, Int32[], Int32[])
		/// </summary>
		protected static RMethod r_MCreateInstanceImpl_Type_Int32Array_Int32Array;
		public static RMethod RMCreateInstanceImpl_Type_Int32Array_Int32Array
		{
			get
			{
				if(r_MCreateInstanceImpl_Type_Int32Array_Int32Array == null)
				{
					r_MCreateInstanceImpl_Type_Int32Array_Int32Array = new(typeof(System.Array), "CreateInstanceImpl", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_MCreateInstanceImpl_Type_Int32Array_Int32Array.SetBelong(null);
				}
				return r_MCreateInstanceImpl_Type_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Int32 GetUpperBound(Int32)
		/// </summary>
		protected RMethod r_MGetUpperBound_Int32;
		public virtual RMethod RMGetUpperBound_Int32
		{
			get
			{
				if(r_MGetUpperBound_Int32 == null)
				{
					r_MGetUpperBound_Int32 = new(this, "GetUpperBound", 0, typeof(System.Int32));
					r_MGetUpperBound_Int32.SetBelong(this.instance);
				}
				return r_MGetUpperBound_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32)
		/// </summary>
		protected RMethod r_MGetValue_Int32;
		public virtual RMethod RMGetValue_Int32
		{
			get
			{
				if(r_MGetValue_Int32 == null)
				{
					r_MGetValue_Int32 = new(this, "GetValue", 0, typeof(System.Int32));
					r_MGetValue_Int32.SetBelong(this.instance);
				}
				return r_MGetValue_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetValue_Int32_Int32;
		public virtual RMethod RMGetValue_Int32_Int32
		{
			get
			{
				if(r_MGetValue_Int32_Int32 == null)
				{
					r_MGetValue_Int32_Int32 = new(this, "GetValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_MGetValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_MGetValue_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Object GetValue(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetValue_Int32_Int32_Int32;
		public virtual RMethod RMGetValue_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetValue_Int32_Int32_Int32 == null)
				{
					r_MGetValue_Int32_Int32_Int32 = new(this, "GetValue", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MGetValue_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MGetValue_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32)
		/// </summary>
		protected RMethod r_MSetValue_Object_Int32;
		public virtual RMethod RMSetValue_Object_Int32
		{
			get
			{
				if(r_MSetValue_Object_Int32 == null)
				{
					r_MSetValue_Object_Int32 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32));
					r_MSetValue_Object_Int32.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetValue_Object_Int32_Int32;
		public virtual RMethod RMSetValue_Object_Int32_Int32
		{
			get
			{
				if(r_MSetValue_Object_Int32_Int32 == null)
				{
					r_MSetValue_Object_Int32_Int32 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_MSetValue_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetValue_Object_Int32_Int32_Int32;
		public virtual RMethod RMSetValue_Object_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetValue_Object_Int32_Int32_Int32 == null)
				{
					r_MSetValue_Object_Int32_Int32_Int32 = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MSetValue_Object_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array UnsafeCreateInstance(System.Type, Int32[], Int32[])
		/// </summary>
		protected static RMethod r_MUnsafeCreateInstance_Type_Int32Array_Int32Array;
		public static RMethod RMUnsafeCreateInstance_Type_Int32Array_Int32Array
		{
			get
			{
				if(r_MUnsafeCreateInstance_Type_Int32Array_Int32Array == null)
				{
					r_MUnsafeCreateInstance_Type_Int32Array_Int32Array = new(typeof(System.Array), "UnsafeCreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_MUnsafeCreateInstance_Type_Int32Array_Int32Array.SetBelong(null);
				}
				return r_MUnsafeCreateInstance_Type_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// System.Array UnsafeCreateInstance(System.Type, Int32, Int32)
		/// </summary>
		protected static RMethod r_MUnsafeCreateInstance_Type_Int32_Int32;
		public static RMethod RMUnsafeCreateInstance_Type_Int32_Int32
		{
			get
			{
				if(r_MUnsafeCreateInstance_Type_Int32_Int32 == null)
				{
					r_MUnsafeCreateInstance_Type_Int32_Int32 = new(typeof(System.Array), "UnsafeCreateInstance", 0, typeof(System.Type), typeof(System.Int32), typeof(System.Int32));
					r_MUnsafeCreateInstance_Type_Int32_Int32.SetBelong(null);
				}
				return r_MUnsafeCreateInstance_Type_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array UnsafeCreateInstance(System.Type, Int32[])
		/// </summary>
		protected static RMethod r_MUnsafeCreateInstance_Type_Int32Array;
		public static RMethod RMUnsafeCreateInstance_Type_Int32Array
		{
			get
			{
				if(r_MUnsafeCreateInstance_Type_Int32Array == null)
				{
					r_MUnsafeCreateInstance_Type_Int32Array = new(typeof(System.Array), "UnsafeCreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType());
					r_MUnsafeCreateInstance_Type_Int32Array.SetBelong(null);
				}
				return r_MUnsafeCreateInstance_Type_Int32Array;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32)
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Int32;
		public static RMethod RMCreateInstance_Type_Int32
		{
			get
			{
				if(r_MCreateInstance_Type_Int32 == null)
				{
					r_MCreateInstance_Type_Int32 = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32));
					r_MCreateInstance_Type_Int32.SetBelong(null);
				}
				return r_MCreateInstance_Type_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Int32_Int32;
		public static RMethod RMCreateInstance_Type_Int32_Int32
		{
			get
			{
				if(r_MCreateInstance_Type_Int32_Int32 == null)
				{
					r_MCreateInstance_Type_Int32_Int32 = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32), typeof(System.Int32));
					r_MCreateInstance_Type_Int32_Int32.SetBelong(null);
				}
				return r_MCreateInstance_Type_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Int32_Int32_Int32;
		public static RMethod RMCreateInstance_Type_Int32_Int32_Int32
		{
			get
			{
				if(r_MCreateInstance_Type_Int32_Int32_Int32 == null)
				{
					r_MCreateInstance_Type_Int32_Int32_Int32 = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MCreateInstance_Type_Int32_Int32_Int32.SetBelong(null);
				}
				return r_MCreateInstance_Type_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32[])
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Int32Array;
		public static RMethod RMCreateInstance_Type_Int32Array
		{
			get
			{
				if(r_MCreateInstance_Type_Int32Array == null)
				{
					r_MCreateInstance_Type_Int32Array = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType());
					r_MCreateInstance_Type_Int32Array.SetBelong(null);
				}
				return r_MCreateInstance_Type_Int32Array;
			}
		}

		/// <summary>
		/// System.Array CreateInstance(System.Type, Int32[], Int32[])
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Int32Array_Int32Array;
		public static RMethod RMCreateInstance_Type_Int32Array_Int32Array
		{
			get
			{
				if(r_MCreateInstance_Type_Int32Array_Int32Array == null)
				{
					r_MCreateInstance_Type_Int32Array_Int32Array = new(typeof(System.Array), "CreateInstance", 0, typeof(System.Type), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_MCreateInstance_Type_Int32Array_Int32Array.SetBelong(null);
				}
				return r_MCreateInstance_Type_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Void Clear(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MClear_Array_Int32_Int32;
		public static RMethod RMClear_Array_Int32_Int32
		{
			get
			{
				if(r_MClear_Array_Int32_Int32 == null)
				{
					r_MClear_Array_Int32_Int32 = new(typeof(System.Array), "Clear", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MClear_Array_Int32_Int32.SetBelong(null);
				}
				return r_MClear_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ClearInternal(System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MClearInternal_Array_Int32_Int32;
		public static RMethod RMClearInternal_Array_Int32_Int32
		{
			get
			{
				if(r_MClearInternal_Array_Int32_Int32 == null)
				{
					r_MClearInternal_Array_Int32_Int32 = new(typeof(System.Array), "ClearInternal", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MClearInternal_Array_Int32_Int32.SetBelong(null);
				}
				return r_MClearInternal_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, System.Array, Int32)
		/// </summary>
		protected static RMethod r_MCopy_Array_Array_Int32;
		public static RMethod RMCopy_Array_Array_Int32
		{
			get
			{
				if(r_MCopy_Array_Array_Int32 == null)
				{
					r_MCopy_Array_Array_Int32 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32));
					r_MCopy_Array_Array_Int32.SetBelong(null);
				}
				return r_MCopy_Array_Array_Int32;
			}
		}

		/// <summary>
		/// Void Copy(System.Array, Int32, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCopy_Array_Int32_Array_Int32_Int32;
		public static RMethod RMCopy_Array_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_MCopy_Array_Int32_Array_Int32_Int32 == null)
				{
					r_MCopy_Array_Int32_Array_Int32_Int32 = new(typeof(System.Array), "Copy", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MCopy_Array_Int32_Array_Int32_Int32.SetBelong(null);
				}
				return r_MCopy_Array_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// System.ArrayTypeMismatchException CreateArrayTypeMismatchException()
		/// </summary>
		protected static RMethod r_MCreateArrayTypeMismatchException;
		public static RMethod RMCreateArrayTypeMismatchException
		{
			get
			{
				if(r_MCreateArrayTypeMismatchException == null)
				{
					r_MCreateArrayTypeMismatchException = new(typeof(System.Array), "CreateArrayTypeMismatchException", 0);
					r_MCreateArrayTypeMismatchException.SetBelong(null);
				}
				return r_MCreateArrayTypeMismatchException;
			}
		}

		/// <summary>
		/// Boolean CanAssignArrayElement(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_MCanAssignArrayElement_Type_Type;
		public static RMethod RMCanAssignArrayElement_Type_Type
		{
			get
			{
				if(r_MCanAssignArrayElement_Type_Type == null)
				{
					r_MCanAssignArrayElement_Type_Type = new(typeof(System.Array), "CanAssignArrayElement", 0, typeof(System.Type), typeof(System.Type));
					r_MCanAssignArrayElement_Type_Type.SetBelong(null);
				}
				return r_MCanAssignArrayElement_Type_Type;
			}
		}

		/// <summary>
		/// Void ConstrainedCopy(System.Array, Int32, System.Array, Int32, Int32)
		/// </summary>
		protected static RMethod r_MConstrainedCopy_Array_Int32_Array_Int32_Int32;
		public static RMethod RMConstrainedCopy_Array_Int32_Array_Int32_Int32
		{
			get
			{
				if(r_MConstrainedCopy_Array_Int32_Array_Int32_Int32 == null)
				{
					r_MConstrainedCopy_Array_Int32_Array_Int32_Int32 = new(typeof(System.Array), "ConstrainedCopy", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_MConstrainedCopy_Array_Int32_Array_Int32_Int32.SetBelong(null);
				}
				return r_MConstrainedCopy_Array_Int32_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// T[] Empty[T]()
		/// </summary>
		protected static RMethod r_MEmpty_GT;
		public static RMethod RMEmpty_GT
		{
			get
			{
				if(r_MEmpty_GT == null)
				{
					r_MEmpty_GT = new(typeof(System.Array), "Empty", 1);
					r_MEmpty_GT.SetBelong(null);
				}
				return r_MEmpty_GT;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_MInitialize;
		public virtual RMethod RMInitialize
		{
			get
			{
				if(r_MInitialize == null)
				{
					r_MInitialize = new(this, "Initialize", 0);
					r_MInitialize.SetBelong(this.instance);
				}
				return r_MInitialize;
			}
		}

		/// <summary>
		/// Int32 IndexOfImpl[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_MIndexOfImpl_GT_TArray_T_Int32_Int32;
		public static RMethod RMIndexOfImpl_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_MIndexOfImpl_GT_TArray_T_Int32_Int32 == null)
				{
					r_MIndexOfImpl_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "IndexOfImpl", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOfImpl_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_MIndexOfImpl_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfImpl[T](T[], T, Int32, Int32)
		/// </summary>
		protected static RMethod r_MLastIndexOfImpl_GT_TArray_T_Int32_Int32;
		public static RMethod RMLastIndexOfImpl_GT_TArray_T_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOfImpl_GT_TArray_T_Int32_Int32 == null)
				{
					r_MLastIndexOfImpl_GT_TArray_T_Int32_Int32 = new(typeof(System.Array), "LastIndexOfImpl", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOfImpl_GT_TArray_T_Int32_Int32.SetBelong(null);
				}
				return r_MLastIndexOfImpl_GT_TArray_T_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SortImpl(System.Array, System.Array, Int32, Int32, System.Collections.IComparer)
		/// </summary>
		protected static RMethod r_MSortImpl_Array_Array_Int32_Int32_IComparer;
		public static RMethod RMSortImpl_Array_Array_Int32_Int32_IComparer
		{
			get
			{
				if(r_MSortImpl_Array_Array_Int32_Int32_IComparer == null)
				{
					r_MSortImpl_Array_Array_Int32_Int32_IComparer = new(typeof(System.Array), "SortImpl", 0, typeof(System.Array), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.IComparer));
					r_MSortImpl_Array_Array_Int32_Int32_IComparer.SetBelong(null);
				}
				return r_MSortImpl_Array_Array_Int32_Int32_IComparer;
			}
		}

		/// <summary>
		/// T UnsafeLoad[T](T[], Int32)
		/// </summary>
		protected static RMethod r_MUnsafeLoad_GT_TArray_Int32;
		public static RMethod RMUnsafeLoad_GT_TArray_Int32
		{
			get
			{
				if(r_MUnsafeLoad_GT_TArray_Int32 == null)
				{
					r_MUnsafeLoad_GT_TArray_Int32 = new(typeof(System.Array), "UnsafeLoad", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_MUnsafeLoad_GT_TArray_Int32.SetBelong(null);
				}
				return r_MUnsafeLoad_GT_TArray_Int32;
			}
		}

		/// <summary>
		/// Void UnsafeStore[T](T[], Int32, T)
		/// </summary>
		protected static RMethod r_MUnsafeStore_GT_TArray_Int32_T;
		public static RMethod RMUnsafeStore_GT_TArray_Int32_T
		{
			get
			{
				if(r_MUnsafeStore_GT_TArray_Int32_T == null)
				{
					r_MUnsafeStore_GT_TArray_Int32_T = new(typeof(System.Array), "UnsafeStore", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0));
					r_MUnsafeStore_GT_TArray_Int32_T.SetBelong(null);
				}
				return r_MUnsafeStore_GT_TArray_Int32_T;
			}
		}

		/// <summary>
		/// R UnsafeMov[S,R](S)
		/// </summary>
		protected static RMethod r_MUnsafeMov_GS_GR_S;
		public static RMethod RMUnsafeMov_GS_GR_S
		{
			get
			{
				if(r_MUnsafeMov_GS_GR_S == null)
				{
					r_MUnsafeMov_GS_GR_S = new(typeof(System.Array), "UnsafeMov", 2, Type.MakeGenericMethodParameter(0));
					r_MUnsafeMov_GS_GR_S.SetBelong(null);
				}
				return r_MUnsafeMov_GS_GR_S;
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

        public static System.Array CreateInstance(System.Type @elementType, System.Int64[] @lengths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths};
            var ___result = RMCreateInstance_Type_Int64Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[] @array)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array};
            var ___result = RMAsReadOnly_GT_TArray.Invoke(___genericsType, ___parameters);

            return (System.Collections.ObjectModel.ReadOnlyCollection<T>)___result;
        }


        public static void Resize<T>(ref T[] @array, System.Int32 @newSize)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @newSize};
            var ___result = RMResize_GT_Ref_TArray_Int32.Invoke(___genericsType, ___parameters);
			@array = (T[])___parameters[0];

            
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IList__2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMSystem__2__Collections__2__IList__2__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__Remove(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSystem__2__Collections__2__IList__2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IStructuralComparable__2__CompareTo(System.Object @other, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RMSystem__2__Collections__2__IStructuralComparable__2__CompareTo_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean System__2__Collections__2__IStructuralEquatable__2__Equals(System.Object @other, System.Collections.IEqualityComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RMSystem__2__Collections__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32 @h1, System.Int32 @h2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h1, @h2};
            var ___result = RMCombineHashCodes_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IStructuralEquatable__2__GetHashCode(System.Collections.IEqualityComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RMSystem__2__Collections__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch(System.Array @array, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMBinarySearch_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] @array, System.Converter<TInput, TOutput> @converter)
        {

            var ___genericsType = new Type[] {typeof(TInput), typeof(TOutput)};
            var ___parameters = new object[]{@array, @converter};
            var ___result = RMConvertAll_GTInput_GTOutput_TInputArray_Converter_d_TInput_TOutput_p_.Invoke(___genericsType, ___parameters);

            return (TOutput[])___result;
        }


        public static void Copy(System.Array @sourceArray, System.Array @destinationArray, System.Int64 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @destinationArray, @length};
            var ___result = RMCopy_Array_Array_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(System.Array @sourceArray, System.Int64 @sourceIndex, System.Array @destinationArray, System.Int64 @destinationIndex, System.Int64 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @sourceIndex, @destinationArray, @destinationIndex, @length};
            var ___result = RMCopy_Array_Int64_Array_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int64 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public static void ForEach<T>(T[] @array, System.Action<T> @action)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @action};
            var ___result = RMForEach_GT_TArray_Action_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 GetLongLength(System.Int32 @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RMGetLongLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Object GetValue(System.Int64 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetValue_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int64 @index1, System.Int64 @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2};
            var ___result = RMGetValue_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int64 @index1, System.Int64 @index2, System.Int64 @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2, @index3};
            var ___result = RMGetValue_Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int64[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMGetValue_Int64Array.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Int32 BinarySearch(System.Array @array, System.Int32 @index, System.Int32 @length, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length, @value};
            var ___result = RMBinarySearch_Array_Int32_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch(System.Array @array, System.Object @value, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @comparer};
            var ___result = RMBinarySearch_Array_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch(System.Array @array, System.Int32 @index, System.Int32 @length, System.Object @value, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length, @value, @comparer};
            var ___result = RMBinarySearch_Array_Int32_Int32_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetMedian(System.Int32 @low, System.Int32 @hi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@low, @hi};
            var ___result = RMGetMedian_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[] @array, T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMBinarySearch_GT_TArray_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[] @array, T @value, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @comparer};
            var ___result = RMBinarySearch_GT_TArray_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[] @array, System.Int32 @index, System.Int32 @length, T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length, @value};
            var ___result = RMBinarySearch_GT_TArray_Int32_Int32_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 BinarySearch<T>(T[] @array, System.Int32 @index, System.Int32 @length, T @value, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length, @value, @comparer};
            var ___result = RMBinarySearch_GT_TArray_Int32_Int32_T_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf(System.Array @array, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMIndexOf_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf(System.Array @array, System.Object @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RMIndexOf_Array_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf(System.Array @array, System.Object @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMIndexOf_Array_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf<T>(T[] @array, T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMIndexOf_GT_TArray_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf<T>(T[] @array, T @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RMIndexOf_GT_TArray_T_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOf<T>(T[] @array, T @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMIndexOf_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf(System.Array @array, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMLastIndexOf_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf(System.Array @array, System.Object @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RMLastIndexOf_Array_Object_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf(System.Array @array, System.Object @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMLastIndexOf_Array_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf<T>(T[] @array, T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMLastIndexOf_GT_TArray_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf<T>(T[] @array, T @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex};
            var ___result = RMLastIndexOf_GT_TArray_T_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOf<T>(T[] @array, T @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMLastIndexOf_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Reverse(System.Array @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMReverse_Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Reverse(System.Array @array, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RMReverse_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Reverse<T>(T[] @array)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array};
            var ___result = RMReverse_GT_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Reverse<T>(T[] @array, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RMReverse_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @value, System.Int64 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index};
            var ___result = RMSetValue_Object_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @value, System.Int64 @index1, System.Int64 @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2};
            var ___result = RMSetValue_Object_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @value, System.Int64 @index1, System.Int64 @index2, System.Int64 @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2, @index3};
            var ___result = RMSetValue_Object_Int64_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @value, System.Int64[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @indices};
            var ___result = RMSetValue_Object_Int64Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RMSort_Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @array, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RMSort_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @array, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @comparer};
            var ___result = RMSort_Array_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @array, System.Int32 @index, System.Int32 @length, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length, @comparer};
            var ___result = RMSort_Array_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @keys, System.Array @items)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items};
            var ___result = RMSort_Array_Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @keys, System.Array @items, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @comparer};
            var ___result = RMSort_Array_Array_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @keys, System.Array @items, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @index, @length};
            var ___result = RMSort_Array_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort(System.Array @keys, System.Array @items, System.Int32 @index, System.Int32 @length, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @index, @length, @comparer};
            var ___result = RMSort_Array_Array_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[] @array)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array};
            var ___result = RMSort_GT_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[] @array, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RMSort_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[] @array, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @comparer};
            var ___result = RMSort_GT_TArray_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[] @array, System.Int32 @index, System.Int32 @length, System.Collections.Generic.IComparer<T> @comparer)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @length, @comparer};
            var ___result = RMSort_GT_TArray_Int32_Int32_IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<T>(T[] @array, System.Comparison<T> @comparison)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @comparison};
            var ___result = RMSort_GT_TArray_Comparison_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[] @keys, TValue[] @items)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items};
            var ___result = RMSort_GTKey_GTValue_TKeyArray_TValueArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[] @keys, TValue[] @items, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items, @index, @length};
            var ___result = RMSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[] @keys, TValue[] @items, System.Collections.Generic.IComparer<TKey> @comparer)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items, @comparer};
            var ___result = RMSort_GTKey_GTValue_TKeyArray_TValueArray_IComparer_d_TKey_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Sort<TKey, TValue>(TKey[] @keys, TValue[] @items, System.Int32 @index, System.Int32 @length, System.Collections.Generic.IComparer<TKey> @comparer)
        {

            var ___genericsType = new Type[] {typeof(TKey), typeof(TValue)};
            var ___parameters = new object[]{@keys, @items, @index, @length, @comparer};
            var ___result = RMSort_GTKey_GTValue_TKeyArray_TValueArray_Int32_Int32_IComparer_d_TKey_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Exists<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMExists_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Fill<T>(T[] @array, T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMFill_GT_TArray_T.Invoke(___genericsType, ___parameters);

            
        }


        public static void Fill<T>(T[] @array, T @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMFill_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static T Find<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMFind_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T[] FindAll<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMFindAll_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static System.Int32 FindIndex<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMFindIndex_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindIndex<T>(T[] @array, System.Int32 @startIndex, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @match};
            var ___result = RMFindIndex_GT_TArray_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindIndex<T>(T[] @array, System.Int32 @startIndex, System.Int32 @count, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @count, @match};
            var ___result = RMFindIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static T FindLast<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMFindLast_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static System.Int32 FindLastIndex<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMFindLastIndex_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindLastIndex<T>(T[] @array, System.Int32 @startIndex, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @match};
            var ___result = RMFindLastIndex_GT_TArray_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 FindLastIndex<T>(T[] @array, System.Int32 @startIndex, System.Int32 @count, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @startIndex, @count, @match};
            var ___result = RMFindLastIndex_GT_TArray_Int32_Int32_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean TrueForAll<T>(T[] @array, System.Predicate<T> @match)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @match};
            var ___result = RMTrueForAll_GT_TArray_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Int32 InternalArray__ICollection_get_Count()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalArray__ICollection_get_Count.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean InternalArray__ICollection_get_IsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalArray__ICollection_get_IsReadOnly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte GetRawSzArrayData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawSzArrayData.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMInternalArray__IEnumerable_GetEnumerator_GT.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual void InternalArray__ICollection_Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalArray__ICollection_Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalArray__ICollection_Add<T>(T @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RMInternalArray__ICollection_Add_GT_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InternalArray__ICollection_Remove<T>(T @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RMInternalArray__ICollection_Remove_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalArray__ICollection_Contains<T>(T @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RMInternalArray__ICollection_Contains_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InternalArray__ICollection_CopyTo<T>(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMInternalArray__ICollection_CopyTo_GT_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T InternalArray__IReadOnlyList_get_Item<T>(System.Int32 @index)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index};
            var ___result = RMInternalArray__IReadOnlyList_get_Item_GT_Int32.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Int32 InternalArray__IReadOnlyCollection_get_Count()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalArray__IReadOnlyCollection_get_Count.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InternalArray__Insert<T>(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMInternalArray__Insert_GT_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalArray__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMInternalArray__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalArray__IndexOf<T>(T @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@item};
            var ___result = RMInternalArray__IndexOf_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual T InternalArray__get_Item<T>(System.Int32 @index)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index};
            var ___result = RMInternalArray__get_Item_GT_Int32.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void InternalArray__set_Item<T>(System.Int32 @index, T @item)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMInternalArray__set_Item_GT_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetGenericValue_icall<T>(ref System.Array @self, System.Int32 @pos, out T @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@self, @pos, @value};
            var ___result = RMGetGenericValue_icall_GT_Ref_Array_Int32_Out_T.Invoke(___genericsType, ___parameters);
			@self = (System.Array)___parameters[0];
			@value = (T)___parameters[2];

            
        }


        public static void SetGenericValue_icall<T>(ref System.Array @self, System.Int32 @pos, ref T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@self, @pos, @value};
            var ___result = RMSetGenericValue_icall_GT_Ref_Array_Int32_Ref_T.Invoke(___genericsType, ___parameters);
			@self = (System.Array)___parameters[0];
			@value = (T)___parameters[2];

            
        }


        public virtual void GetGenericValueImpl<T>(System.Int32 @pos, out T @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@pos, @value};
            var ___result = RMGetGenericValueImpl_GT_Int32_Out_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[1];

            
        }


        public virtual void SetGenericValueImpl<T>(System.Int32 @pos, ref T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@pos, @value};
            var ___result = RMSetGenericValueImpl_GT_Int32_Ref_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[1];

            
        }


        public virtual System.Int32 GetRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLength(System.Int32 @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RMGetLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLowerBound(System.Int32 @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RMGetLowerBound_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetValue(System.Int32[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMGetValue_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object @value, System.Int32[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @indices};
            var ___result = RMSetValue_Object_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetValueImpl(System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMGetValueImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValueImpl(System.Object @value, System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @pos};
            var ___result = RMSetValueImpl_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean FastCopy(System.Array @source, System.Int32 @source_idx, System.Array @dest, System.Int32 @dest_idx, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @source_idx, @dest, @dest_idx, @length};
            var ___result = RMFastCopy_Array_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Array CreateInstanceImpl(System.Type @elementType, System.Int32[] @lengths, System.Int32[] @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths, @bounds};
            var ___result = RMCreateInstanceImpl_Type_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Int32 GetUpperBound(System.Int32 @dimension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dimension};
            var ___result = RMGetUpperBound_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetValue(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int32 @index1, System.Int32 @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2};
            var ___result = RMGetValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int32 @index1, System.Int32 @index2, System.Int32 @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index1, @index2, @index3};
            var ___result = RMGetValue_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object @value, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index};
            var ___result = RMSetValue_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @value, System.Int32 @index1, System.Int32 @index2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2};
            var ___result = RMSetValue_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @value, System.Int32 @index1, System.Int32 @index2, System.Int32 @index3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index1, @index2, @index3};
            var ___result = RMSetValue_Object_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Array UnsafeCreateInstance(System.Type @elementType, System.Int32[] @lengths, System.Int32[] @lowerBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths, @lowerBounds};
            var ___result = RMUnsafeCreateInstance_Type_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array UnsafeCreateInstance(System.Type @elementType, System.Int32 @length1, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length1, @length2};
            var ___result = RMUnsafeCreateInstance_Type_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array UnsafeCreateInstance(System.Type @elementType, System.Int32[] @lengths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths};
            var ___result = RMUnsafeCreateInstance_Type_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type @elementType, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length};
            var ___result = RMCreateInstance_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type @elementType, System.Int32 @length1, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length1, @length2};
            var ___result = RMCreateInstance_Type_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type @elementType, System.Int32 @length1, System.Int32 @length2, System.Int32 @length3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @length1, @length2, @length3};
            var ___result = RMCreateInstance_Type_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type @elementType, System.Int32[] @lengths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths};
            var ___result = RMCreateInstance_Type_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static System.Array CreateInstance(System.Type @elementType, System.Int32[] @lengths, System.Int32[] @lowerBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType, @lengths, @lowerBounds};
            var ___result = RMCreateInstance_Type_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static void Clear(System.Array @array, System.Int32 @index, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @length};
            var ___result = RMClear_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearInternal(System.Array @a, System.Int32 @index, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @index, @count};
            var ___result = RMClearInternal_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(System.Array @sourceArray, System.Array @destinationArray, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @destinationArray, @length};
            var ___result = RMCopy_Array_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Copy(System.Array @sourceArray, System.Int32 @sourceIndex, System.Array @destinationArray, System.Int32 @destinationIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @sourceIndex, @destinationArray, @destinationIndex, @length};
            var ___result = RMCopy_Array_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.ArrayTypeMismatchException CreateArrayTypeMismatchException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateArrayTypeMismatchException.Invoke(___genericsType, ___parameters);

            return (System.ArrayTypeMismatchException)___result;
        }


        public static System.Boolean CanAssignArrayElement(System.Type @source, System.Type @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target};
            var ___result = RMCanAssignArrayElement_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void ConstrainedCopy(System.Array @sourceArray, System.Int32 @sourceIndex, System.Array @destinationArray, System.Int32 @destinationIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceArray, @sourceIndex, @destinationArray, @destinationIndex, @length};
            var ___result = RMConstrainedCopy_Array_Int32_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static T[] Empty<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMEmpty_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 IndexOfImpl<T>(T[] @array, T @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMIndexOfImpl_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfImpl<T>(T[] @array, T @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @value, @startIndex, @count};
            var ___result = RMLastIndexOfImpl_GT_TArray_T_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SortImpl(System.Array @keys, System.Array @items, System.Int32 @index, System.Int32 @length, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keys, @items, @index, @length, @comparer};
            var ___result = RMSortImpl_Array_Array_Int32_Int32_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public static T UnsafeLoad<T>(T[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMUnsafeLoad_GT_TArray_Int32.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static void UnsafeStore<T>(T[] @array, System.Int32 @index, T @value)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @index, @value};
            var ___result = RMUnsafeStore_GT_TArray_Int32_T.Invoke(___genericsType, ___parameters);

            
        }


        public static R UnsafeMov<S, R>(S @instance)
        {

            var ___genericsType = new Type[] {typeof(S), typeof(R)};
            var ___parameters = new object[]{@instance};
            var ___result = RMUnsafeMov_GS_GR_S.Invoke(___genericsType, ___parameters);

            return (R)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
