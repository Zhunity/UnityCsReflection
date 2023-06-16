
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Text.RegularExpressions.CaptureCollection
	/// </summary>
    public partial class RCaptureCollection : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Text.RegularExpressions.CaptureCollection);
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


		/// <summary>
		/// System.Text.RegularExpressions.Group _group
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroup r_F_group;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroup RF_group
		{
			get
			{
				if(r_F_group == null)
				{
					r_F_group = new(this, "_group");
				}
				return r_F_group;
			}
		}

		/// <summary>
		/// System.Int32 _capcount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_capcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_capcount
		{
			get
			{
				if(r_F_capcount == null)
				{
					r_F_capcount = new(this, "_capcount");
				}
				return r_F_capcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture[] _captures
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCapture> r_F_captures;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCapture> RF_captures
		{
			get
			{
				if(r_F_captures == null)
				{
					r_F_captures = new(this, "_captures");
				}
				return r_F_captures;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCapture r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCapture RPItem_Int32
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
		/// Boolean IsSynchronized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSynchronized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSyncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCapture r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCapture RPSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item", -1, typeof(System.Int32));
				}
				return r_PSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Item_Int32;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSystem__2__Collections__2__IList__2__IsFixedSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSystem__2__Collections__2__IList__2__IsFixedSize
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__IsFixedSize == null)
				{
					r_PSystem__2__Collections__2__IList__2__IsFixedSize = new(this, "System.Collections.IList.IsFixedSize", -1);
				}
				return r_PSystem__2__Collections__2__IList__2__IsFixedSize;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IList.Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IList__2__Item_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IList__2__Item_Int32
		{
			get
			{
				if(r_PSystem__2__Collections__2__IList__2__Item_Int32 == null)
				{
					r_PSystem__2__Collections__2__IList__2__Item_Int32 = new(this, "System.Collections.IList.Item", -1, typeof(System.Int32));
				}
				return r_PSystem__2__Collections__2__IList__2__Item_Int32;
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
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[System.Text.RegularExpressions.Capture] System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Capture GetCapture(Int32)
		/// </summary>
		protected RMethod r_MGetCapture_Int32;
		public virtual RMethod RMGetCapture_Int32
		{
			get
			{
				if(r_MGetCapture_Int32 == null)
				{
					r_MGetCapture_Int32 = new(this, "GetCapture", 0, typeof(System.Int32));
				}
				return r_MGetCapture_Int32;
			}
		}

		/// <summary>
		/// Void ForceInitialized()
		/// </summary>
		protected RMethod r_MForceInitialized;
		public virtual RMethod RMForceInitialized
		{
			get
			{
				if(r_MForceInitialized == null)
				{
					r_MForceInitialized = new(this, "ForceInitialized", 0);
				}
				return r_MForceInitialized;
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
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Text.RegularExpressions.Capture[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_CaptureArray_Int32;
		public virtual RMethod RMCopyTo_CaptureArray_Int32
		{
			get
			{
				if(r_MCopyTo_CaptureArray_Int32 == null)
				{
					r_MCopyTo_CaptureArray_Int32 = new(this, "CopyTo", 0, typeof(System.Text.RegularExpressions.Capture).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopyTo_CaptureArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf", 0, typeof(System.Text.RegularExpressions.Capture));
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(Int32, System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert", 0, typeof(System.Int32), typeof(System.Text.RegularExpressions.Capture));
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32 == null)
				{
					r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt", 0, typeof(System.Int32));
				}
				return r_MSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add", 0, typeof(System.Text.RegularExpressions.Capture));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear", 0);
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains", 0, typeof(System.Text.RegularExpressions.Capture));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture;
		public virtual RMethod RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture
		{
			get
			{
				if(r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture == null)
				{
					r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove", 0, typeof(System.Text.RegularExpressions.Capture));
				}
				return r_MSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture;
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
				}
				return r_MSystem__2__Collections__2__IList__2__Add_Object;
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
				}
				return r_MSystem__2__Collections__2__IList__2__Clear;
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
				}
				return r_MSystem__2__Collections__2__IList__2__Contains_Object;
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
				}
				return r_MSystem__2__Collections__2__IList__2__RemoveAt_Int32;
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


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>>(___result);
        }


        public virtual System.Text.RegularExpressions.Capture GetCapture(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMGetCapture_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Text.RegularExpressions.Capture>(___result);
        }


        public virtual void ForceInitialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMForceInitialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Text.RegularExpressions.Capture[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_CaptureArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__IndexOf_Capture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert(System.Int32 @index, System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Insert_Int32_Capture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Add_Capture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Contains_Capture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove(System.Text.RegularExpressions.Capture @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Capture__1____2__Remove_Capture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__Add(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Add_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void System__2__Collections__2__IList__2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IList__2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__IList__2__Contains(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__Contains_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 System__2__Collections__2__IList__2__IndexOf(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSystem__2__Collections__2__IList__2__IndexOf_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
