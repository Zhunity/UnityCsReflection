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
		protected RSystem.RText.RRegularExpressions.RCapture r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__get_Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RCapture RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__get_Item_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__get_Item_Int32;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected RProperty r_RSystem__0__Collections__0__IList__0__get_IsFixedSize;
		public virtual RProperty RSystem__0__Collections__0__IList__0__get_IsFixedSize
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_IsFixedSize == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
					r_RSystem__0__Collections__0__IList__0__get_IsFixedSize.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_IsFixedSize;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_RSystem__0__Collections__0__IList__0__get_Item_Int32;
		public virtual RSystem.RObject RSystem__0__Collections__0__IList__0__get_Item_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__get_Item_Int32 == null)
				{
					r_RSystem__0__Collections__0__IList__0__get_Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
					r_RSystem__0__Collections__0__IList__0__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__get_Item_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Text.RegularExpressions.Capture] System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator", 0);
					r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture GetCapture(Int32)
		/// </summary>
		protected RMethod r_RGetCapture_Int32;
		public virtual RMethod RGetCapture_Int32
		{
			get
			{
				if(r_RGetCapture_Int32 == null)
				{
					r_RGetCapture_Int32 = new(this, "GetCapture", 0, typeof(System.Int32));
					r_RGetCapture_Int32.SetBelong(this.instance);
				}
				return r_RGetCapture_Int32;
			}
		}

		/// <summary>
		/// Void ForceInitialized()
		/// </summary>
		protected RMethod r_RForceInitialized;
		public virtual RMethod RForceInitialized
		{
			get
			{
				if(r_RForceInitialized == null)
				{
					r_RForceInitialized = new(this, "ForceInitialized", 0);
					r_RForceInitialized.SetBelong(this.instance);
				}
				return r_RForceInitialized;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_RCopyTo_Array_Int32 == null)
				{
					r_RCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Text.RegularExpressions.Capture[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_CaptureArray_Int32;
		public virtual RMethod RCopyTo_CaptureArray_Int32
		{
			get
			{
				if(r_RCopyTo_CaptureArray_Int32 == null)
				{
					r_RCopyTo_CaptureArray_Int32 = new(this, "CopyTo", 0, typeof(System.Text.RegularExpressions.Capture).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_CaptureArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_CaptureArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf", 0, typeof(System.Text.RegularExpressions.Capture));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(Int32, System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert", 0, typeof(System.Int32), typeof(System.Text.RegularExpressions.Capture));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32 == null)
				{
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt", 0, typeof(System.Int32));
					r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add", 0, typeof(System.Text.RegularExpressions.Capture));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear", 0);
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains", 0, typeof(System.Text.RegularExpressions.Capture));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture;
		public virtual RMethod RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture
		{
			get
			{
				if(r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture == null)
				{
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove", 0, typeof(System.Text.RegularExpressions.Capture));
					r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.Add(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Add_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Add_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Add_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Add_Object = new(this, "System.Collections.IList.Add", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Add_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Add_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Clear()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Clear;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Clear
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Clear == null)
				{
					r_RSystem__0__Collections__0__IList__0__Clear = new(this, "System.Collections.IList.Clear", 0);
					r_RSystem__0__Collections__0__IList__0__Clear.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.Contains(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Contains_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Contains_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Contains_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Contains_Object = new(this, "System.Collections.IList.Contains", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Contains_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Contains_Object;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IList.IndexOf(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__IndexOf_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__IndexOf_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__IndexOf_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__IndexOf_Object = new(this, "System.Collections.IList.IndexOf", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__IndexOf_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__IndexOf_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Insert_Int32_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object = new(this, "System.Collections.IList.Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Insert_Int32_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.Remove(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__Remove_Object;
		public virtual RMethod RSystem__0__Collections__0__IList__0__Remove_Object
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__Remove_Object == null)
				{
					r_RSystem__0__Collections__0__IList__0__Remove_Object = new(this, "System.Collections.IList.Remove", 0, typeof(System.Object));
					r_RSystem__0__Collections__0__IList__0__Remove_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__Remove_Object;
			}
		}

		/// <summary>
		/// Void System.Collections.IList.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32;
		public virtual RMethod RSystem__0__Collections__0__IList__0__RemoveAt_Int32
		{
			get
			{
				if(r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32 == null)
				{
					r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32 = new(this, "System.Collections.IList.RemoveAt", 0, typeof(System.Int32));
					r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IList__0__RemoveAt_Int32;
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


        public virtual System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__IEnumerable__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>)___result;
        }


        public virtual System.Text.RegularExpressions.Capture GetCapture(System.Int32  @i)
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


        public virtual void CopyTo(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Text.RegularExpressions.Capture[]  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_CaptureArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf(System.Text.RegularExpressions.Capture  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__IndexOf_Capture.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert(System.Int32  @index, System.Text.RegularExpressions.Capture  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Insert_Int32_Capture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__Generic__0__IList__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add(System.Text.RegularExpressions.Capture  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Add_Capture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains(System.Text.RegularExpressions.Capture  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Contains_Capture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove(System.Text.RegularExpressions.Capture  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__0__Collections__0__Generic__0__ICollection__1__System__0__Text__0__RegularExpressions__0__Capture__2____0__Remove_Capture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__0__Collections__0__IList__0__Add(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Add_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__IList__0__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IList__0__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__0__Collections__0__IList__0__Contains(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__0__Collections__0__IList__0__IndexOf(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__0__Collections__0__IList__0__Insert(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSystem__0__Collections__0__IList__0__Insert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IList__0__Remove(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSystem__0__Collections__0__IList__0__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IList__0__RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__0__Collections__0__IList__0__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
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
