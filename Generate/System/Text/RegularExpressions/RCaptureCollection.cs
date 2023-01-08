using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.CaptureCollection
	/// </summary>
    public partial class RCaptureCollection : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Group _group
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RGroup r__group;
		public virtual RSystem.RText.RRegularExpressions.RGroup R_group
		{
			get
			{
				if(r__group == null)
				{
					r__group = new(this, "_group");
					r__group.SetBelong(this.instance);
				}
				return r__group;
			}
		}

		/// <summary>
		/// System.Int32 _capcount
		/// </summary>
		protected RField r__capcount;
		public virtual RField R_capcount
		{
			get
			{
				if(r__capcount == null)
				{
					r__capcount = new(this, "_capcount");
					r__capcount.SetBelong(this.instance);
				}
				return r__capcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture[] _captures
		/// </summary>
		protected RFieldArray<RSystem.RText.RRegularExpressions.RCapture> r__captures;
		public virtual RFieldArray<RSystem.RText.RRegularExpressions.RCapture> R_captures
		{
			get
			{
				if(r__captures == null)
				{
					r__captures = new(this, "_captures");
					r__captures.SetBelong(this.instance);
				}
				return r__captures;
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
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture Item [Int32]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RCapture r_Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RCapture RItem_Int32
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
		/// System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item [Int32]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RCapture r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RCapture RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item", -1, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected RProperty r_System__2__Collections__2__IList__2__IsFixedSize;
		public virtual RProperty RSystem__2__Collections__2__IList__2__IsFixedSize
		{
			get
			{
				if(r_System__2__Collections__2__IList__2__IsFixedSize == null)
				{
					r_System__2__Collections__2__IList__2__IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
					r_System__2__Collections__2__IList__2__IsFixedSize.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IList__2__IsFixedSize;
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
		/// System.Collections.Generic.IEnumerator`1[System.Text.RegularExpressions.Capture] System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator == null)
				{
					r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator", 0);
					r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture GetCapture(Int32)
		/// </summary>
		protected RMethod r_GetCapture_Int32;
		public virtual RMethod RGetCapture_Int32
		{
			get
			{
				if(r_GetCapture_Int32 == null)
				{
					r_GetCapture_Int32 = new(this, "GetCapture", 0, typeof(System.Int32));
					r_GetCapture_Int32.SetBelong(this.instance);
				}
				return r_GetCapture_Int32;
			}
		}

		/// <summary>
		/// Void ForceInitialized()
		/// </summary>
		protected RMethod r_ForceInitialized;
		public virtual RMethod RForceInitialized
		{
			get
			{
				if(r_ForceInitialized == null)
				{
					r_ForceInitialized = new(this, "ForceInitialized", 0);
					r_ForceInitialized.SetBelong(this.instance);
				}
				return r_ForceInitialized;
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
		/// Void CopyTo(System.Text.RegularExpressions.Capture[], Int32)
		/// </summary>
		protected RMethod r_CopyTo_CaptureArray_Int32;
		public virtual RMethod RCopyTo_CaptureArray_Int32
		{
			get
			{
				if(r_CopyTo_CaptureArray_Int32 == null)
				{
					r_CopyTo_CaptureArray_Int32 = new(this, "CopyTo", 0, typeof(System.Text.RegularExpressions.Capture).MakeArrayType(), typeof(System.Int32));
					r_CopyTo_CaptureArray_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_CaptureArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf", 0, typeof(System.Text.RegularExpressions.Capture));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(Int32, System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert", 0, typeof(System.Int32), typeof(System.Text.RegularExpressions.Capture));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt", 0, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add", 0, typeof(System.Text.RegularExpressions.Capture));
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear", 0);
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains", 0, typeof(System.Text.RegularExpressions.Capture));
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove", 0, typeof(System.Text.RegularExpressions.Capture));
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture;
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


        public RCaptureCollection() : base("System.Text.RegularExpressions.CaptureCollection")
        {
        }

        public RCaptureCollection(System.Object instance) : base("System.Text.RegularExpressions.CaptureCollection")
		{
            SetInstance(instance);
		}

        public RCaptureCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCaptureCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>)___result;
        }


        public virtual System.Text.RegularExpressions.Capture GetCapture(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RGetCapture_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Capture)___result;
        }


        public virtual void ForceInitialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RForceInitialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Text.RegularExpressions.Capture[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_CaptureArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert(System.Int32 @index, System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IList__2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__IList__2__Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSystem__2__Collections__2__IList__2__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__Remove(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__2__Collections__2__IList__2__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__IList__2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__2__Collections__2__IList__2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
