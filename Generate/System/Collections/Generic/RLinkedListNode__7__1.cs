using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.LinkedListNode`1
	/// </summary>
    public partial class RLinkedListNode<T> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[T] list
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedList<RField> r_list;
		public virtual RSystem.RCollections.RGeneric.RLinkedList<RField> Rlist
		{
			get
			{
				if(r_list == null)
				{
					r_list = new(this, "list");
					r_list.SetBelong(this.instance);
				}
				return r_list;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] next
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RField> r_next;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RField> Rnext
		{
			get
			{
				if(r_next == null)
				{
					r_next = new(this, "next");
					r_next.SetBelong(this.instance);
				}
				return r_next;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] prev
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RField> r_prev;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RField> Rprev
		{
			get
			{
				if(r_prev == null)
				{
					r_prev = new(this, "prev");
					r_prev.SetBelong(this.instance);
				}
				return r_prev;
			}
		}

		/// <summary>
		/// T item
		/// </summary>
		protected RField r_item;
		public virtual RField Ritem
		{
			get
			{
				if(r_item == null)
				{
					r_item = new(this, "item");
					r_item.SetBelong(this.instance);
				}
				return r_item;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[T] List
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedList<RProperty> r_List;
		public virtual RSystem.RCollections.RGeneric.RLinkedList<RProperty> RList
		{
			get
			{
				if(r_List == null)
				{
					r_List = new(this, "List", -1);
					r_List.SetBelong(this.instance);
				}
				return r_List;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] Next
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> r_Next;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> RNext
		{
			get
			{
				if(r_Next == null)
				{
					r_Next = new(this, "Next", -1);
					r_Next.SetBelong(this.instance);
				}
				return r_Next;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] Previous
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> r_Previous;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RProperty> RPrevious
		{
			get
			{
				if(r_Previous == null)
				{
					r_Previous = new(this, "Previous", -1);
					r_Previous.SetBelong(this.instance);
				}
				return r_Previous;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Void Invalidate()
		/// </summary>
		protected RMethod r_RInvalidate;
		public virtual RMethod RInvalidate
		{
			get
			{
				if(r_RInvalidate == null)
				{
					r_RInvalidate = new(this, "Invalidate", 0);
					r_RInvalidate.SetBelong(this.instance);
				}
				return r_RInvalidate;
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


        public RLinkedListNode() : base("System.Collections.Generic.LinkedListNode`1")
        {
        }

        public RLinkedListNode(System.Object instance) : base("System.Collections.Generic.LinkedListNode`1")
		{
            SetInstance(instance);
		}

        public RLinkedListNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLinkedListNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Invalidate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidate.Invoke(___genericsType, ___parameters);

            
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
