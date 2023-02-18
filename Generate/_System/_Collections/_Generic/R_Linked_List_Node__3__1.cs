
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.LinkedListNode`1
	/// </summary>
    public partial class RLinkedListNode<T> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[T] list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RField> r_Flist;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RField> RFlist
		{
			get
			{
				if(r_Flist == null)
				{
					r_Flist = new(this, "list");
				}
				return r_Flist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] next
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> r_Fnext;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] prev
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> r_Fprev;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> RFprev
		{
			get
			{
				if(r_Fprev == null)
				{
					r_Fprev = new(this, "prev");
				}
				return r_Fprev;
			}
		}

		/// <summary>
		/// T item
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fitem;
		public virtual Hvak.Editor.Refleaction.RField RFitem
		{
			get
			{
				if(r_Fitem == null)
				{
					r_Fitem = new(this, "item");
				}
				return r_Fitem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[T] List
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RProperty> r_PList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RProperty> RPList
		{
			get
			{
				if(r_PList == null)
				{
					r_PList = new(this, "List", -1);
				}
				return r_PList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] Next
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> r_PNext;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> RPNext
		{
			get
			{
				if(r_PNext == null)
				{
					r_PNext = new(this, "Next", -1);
				}
				return r_PNext;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] Previous
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> r_PPrevious;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RProperty> RPPrevious
		{
			get
			{
				if(r_PPrevious == null)
				{
					r_PPrevious = new(this, "Previous", -1);
				}
				return r_PPrevious;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PValue;
		public virtual Hvak.Editor.Refleaction.RProperty RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Void Invalidate()
		/// </summary>
		protected RMethod r_MInvalidate;
		public virtual RMethod RMInvalidate
		{
			get
			{
				if(r_MInvalidate == null)
				{
					r_MInvalidate = new(this, "Invalidate", 0);
				}
				return r_MInvalidate;
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
            var ___result = RMInvalidate.Invoke(___genericsType, ___parameters);

            
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
