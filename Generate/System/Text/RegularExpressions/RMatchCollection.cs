using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.MatchCollection
	/// </summary>
    public partial class RMatchCollection : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Regex _regex
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegex r__regex;
		public virtual RSystem.RText.RRegularExpressions.RRegex R_regex
		{
			get
			{
				if(r__regex == null)
				{
					r__regex = new(this, "_regex");
					r__regex.SetBelong(this.instance);
				}
				return r__regex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Text.RegularExpressions.Match] _matches
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RText.RRegularExpressions.RMatch> r__matches;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RText.RRegularExpressions.RMatch> R_matches
		{
			get
			{
				if(r__matches == null)
				{
					r__matches = new(this, "_matches");
					r__matches.SetBelong(this.instance);
				}
				return r__matches;
			}
		}

		/// <summary>
		/// System.Boolean _done
		/// </summary>
		protected RSystem.RBoolean r__done;
		public virtual RSystem.RBoolean R_done
		{
			get
			{
				if(r__done == null)
				{
					r__done = new(this, "_done");
					r__done.SetBelong(this.instance);
				}
				return r__done;
			}
		}

		/// <summary>
		/// System.String _input
		/// </summary>
		protected RSystem.RString r__input;
		public virtual RSystem.RString R_input
		{
			get
			{
				if(r__input == null)
				{
					r__input = new(this, "_input");
					r__input.SetBelong(this.instance);
				}
				return r__input;
			}
		}

		/// <summary>
		/// System.Int32 _beginning
		/// </summary>
		protected RSystem.RInt32 r__beginning;
		public virtual RSystem.RInt32 R_beginning
		{
			get
			{
				if(r__beginning == null)
				{
					r__beginning = new(this, "_beginning");
					r__beginning.SetBelong(this.instance);
				}
				return r__beginning;
			}
		}

		/// <summary>
		/// System.Int32 _length
		/// </summary>
		protected RSystem.RInt32 r__length;
		public virtual RSystem.RInt32 R_length
		{
			get
			{
				if(r__length == null)
				{
					r__length = new(this, "_length");
					r__length.SetBelong(this.instance);
				}
				return r__length;
			}
		}

		/// <summary>
		/// System.Int32 _startat
		/// </summary>
		protected RSystem.RInt32 r__startat;
		public virtual RSystem.RInt32 R_startat
		{
			get
			{
				if(r__startat == null)
				{
					r__startat = new(this, "_startat");
					r__startat.SetBelong(this.instance);
				}
				return r__startat;
			}
		}

		/// <summary>
		/// System.Int32 _prevlen
		/// </summary>
		protected RSystem.RInt32 r__prevlen;
		public virtual RSystem.RInt32 R_prevlen
		{
			get
			{
				if(r__prevlen == null)
				{
					r__prevlen = new(this, "_prevlen");
					r__prevlen.SetBelong(this.instance);
				}
				return r__prevlen;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RSystem.RBoolean r_IsReadOnly;
		public virtual RSystem.RBoolean RIsReadOnly
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
		protected RSystem.RInt32 r_Count;
		public virtual RSystem.RInt32 RCount
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
		/// System.Text.RegularExpressions.Match Item [Int32]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RMatch r_Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RMatch RItem_Int32
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
		protected RSystem.RBoolean r_IsSynchronized;
		public virtual RSystem.RBoolean RIsSynchronized
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
		/// System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item [Int32]
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RMatch r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32;
		public virtual RSystem.RText.RRegularExpressions.RMatch RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item", -1, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Item_Int32;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IList.IsFixedSize
		/// </summary>
		protected RSystem.RBoolean r_System__2__Collections__2__IList__2__IsFixedSize;
		public virtual RSystem.RBoolean RSystem__2__Collections__2__IList__2__IsFixedSize
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
		/// System.Collections.Generic.IEnumerator`1[System.Text.RegularExpressions.Match] System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator == null)
				{
					r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator", 0);
					r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match GetMatch(Int32)
		/// </summary>
		protected RMethod r_GetMatch_Int32;
		public virtual RMethod RGetMatch_Int32
		{
			get
			{
				if(r_GetMatch_Int32 == null)
				{
					r_GetMatch_Int32 = new(this, "GetMatch", 0, typeof(System.Int32));
					r_GetMatch_Int32.SetBelong(this.instance);
				}
				return r_GetMatch_Int32;
			}
		}

		/// <summary>
		/// Void EnsureInitialized()
		/// </summary>
		protected RMethod r_EnsureInitialized;
		public virtual RMethod REnsureInitialized
		{
			get
			{
				if(r_EnsureInitialized == null)
				{
					r_EnsureInitialized = new(this, "EnsureInitialized", 0);
					r_EnsureInitialized.SetBelong(this.instance);
				}
				return r_EnsureInitialized;
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
		/// Void CopyTo(System.Text.RegularExpressions.Match[], Int32)
		/// </summary>
		protected RMethod r_CopyTo_MatchArray_Int32;
		public virtual RMethod RCopyTo_MatchArray_Int32
		{
			get
			{
				if(r_CopyTo_MatchArray_Int32 == null)
				{
					r_CopyTo_MatchArray_Int32 = new(this, "CopyTo", 0, typeof(System.Text.RegularExpressions.Match).MakeArrayType(), typeof(System.Int32));
					r_CopyTo_MatchArray_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_MatchArray_Int32;
			}
		}

		/// <summary>
		/// Int32 System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf", 0, typeof(System.Text.RegularExpressions.Match));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(Int32, System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert", 0, typeof(System.Int32), typeof(System.Text.RegularExpressions.Match));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(Int32)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32 == null)
				{
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32 = new(this, "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt", 0, typeof(System.Int32));
					r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add", 0, typeof(System.Text.RegularExpressions.Match));
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear()
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear", 0);
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains", 0, typeof(System.Text.RegularExpressions.Match));
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match;
		public virtual RMethod RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match
		{
			get
			{
				if(r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match == null)
				{
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match = new(this, "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove", 0, typeof(System.Text.RegularExpressions.Match));
					r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match;
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


        public RMatchCollection() : base("System.Text.RegularExpressions.MatchCollection")
        {
        }

        public RMatchCollection(System.Object instance) : base("System.Text.RegularExpressions.MatchCollection")
		{
            SetInstance(instance);
		}

        public RMatchCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMatchCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__IEnumerable__0__System__2__Text__2__RegularExpressions__2__Match__1____2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>)___result;
        }


        public virtual System.Text.RegularExpressions.Match GetMatch(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RGetMatch_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void EnsureInitialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureInitialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Text.RegularExpressions.Match[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_MatchArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__IndexOf_Match.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert(System.Int32 @index, System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Insert_Int32_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSystem__2__Collections__2__Generic__2__IList__0__System__2__Text__2__RegularExpressions__2__Match__1____2__RemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Add_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Clear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Contains_Match.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove(System.Text.RegularExpressions.Match @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__2__Collections__2__Generic__2__ICollection__0__System__2__Text__2__RegularExpressions__2__Match__1____2__Remove_Match.Invoke(___genericsType, ___parameters);

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
