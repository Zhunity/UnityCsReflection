using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.Queue
	/// </summary>
    public partial class RQueue : RMember //
    {

		/// <summary>
		/// System.Object[] _array
		/// </summary>
		protected RFieldArray<RSystem.RObject> r__array;
		public virtual RFieldArray<RSystem.RObject> R_array
		{
			get
			{
				if(r__array == null)
				{
					r__array = new(this, "_array");
					r__array.SetBelong(this.instance);
				}
				return r__array;
			}
		}

		/// <summary>
		/// System.Int32 _head
		/// </summary>
		protected RField r__head;
		public virtual RField R_head
		{
			get
			{
				if(r__head == null)
				{
					r__head = new(this, "_head");
					r__head.SetBelong(this.instance);
				}
				return r__head;
			}
		}

		/// <summary>
		/// System.Int32 _tail
		/// </summary>
		protected RField r__tail;
		public virtual RField R_tail
		{
			get
			{
				if(r__tail == null)
				{
					r__tail = new(this, "_tail");
					r__tail.SetBelong(this.instance);
				}
				return r__tail;
			}
		}

		/// <summary>
		/// System.Int32 _size
		/// </summary>
		protected RField r__size;
		public virtual RField R_size
		{
			get
			{
				if(r__size == null)
				{
					r__size = new(this, "_size");
					r__size.SetBelong(this.instance);
				}
				return r__size;
			}
		}

		/// <summary>
		/// System.Int32 _growFactor
		/// </summary>
		protected RField r__growFactor;
		public virtual RField R_growFactor
		{
			get
			{
				if(r__growFactor == null)
				{
					r__growFactor = new(this, "_growFactor");
					r__growFactor.SetBelong(this.instance);
				}
				return r__growFactor;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected RField r__version;
		public virtual RField R_version
		{
			get
			{
				if(r__version == null)
				{
					r__version = new(this, "_version");
					r__version.SetBelong(this.instance);
				}
				return r__version;
			}
		}

		/// <summary>
		/// System.Object _syncRoot
		/// </summary>
		protected RSystem.RObject r__syncRoot;
		public virtual RSystem.RObject R_syncRoot
		{
			get
			{
				if(r__syncRoot == null)
				{
					r__syncRoot = new(this, "_syncRoot");
					r__syncRoot.SetBelong(this.instance);
				}
				return r__syncRoot;
			}
		}

		/// <summary>
		/// System.Int32 _MinimumGrow
		/// </summary>
		protected static RField r__MinimumGrow;
		public static RField R_MinimumGrow
		{
			get
			{
				if(r__MinimumGrow == null)
				{
					r__MinimumGrow = new(typeof(System.Collections.Queue), "_MinimumGrow");
					r__MinimumGrow.SetBelong(null);
				}
				return r__MinimumGrow;
			}
		}

		/// <summary>
		/// System.Int32 _ShrinkThreshold
		/// </summary>
		protected static RField r__ShrinkThreshold;
		public static RField R_ShrinkThreshold
		{
			get
			{
				if(r__ShrinkThreshold == null)
				{
					r__ShrinkThreshold = new(typeof(System.Collections.Queue), "_ShrinkThreshold");
					r__ShrinkThreshold.SetBelong(null);
				}
				return r__ShrinkThreshold;
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
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
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
		/// Void Enqueue(System.Object)
		/// </summary>
		protected RMethod r_REnqueue_Object;
		public virtual RMethod REnqueue_Object
		{
			get
			{
				if(r_REnqueue_Object == null)
				{
					r_REnqueue_Object = new(this, "Enqueue", 0, typeof(System.Object));
					r_REnqueue_Object.SetBelong(this.instance);
				}
				return r_REnqueue_Object;
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
		/// System.Object Dequeue()
		/// </summary>
		protected RMethod r_RDequeue;
		public virtual RMethod RDequeue
		{
			get
			{
				if(r_RDequeue == null)
				{
					r_RDequeue = new(this, "Dequeue", 0);
					r_RDequeue.SetBelong(this.instance);
				}
				return r_RDequeue;
			}
		}

		/// <summary>
		/// System.Object Peek()
		/// </summary>
		protected RMethod r_RPeek;
		public virtual RMethod RPeek
		{
			get
			{
				if(r_RPeek == null)
				{
					r_RPeek = new(this, "Peek", 0);
					r_RPeek.SetBelong(this.instance);
				}
				return r_RPeek;
			}
		}

		/// <summary>
		/// System.Collections.Queue Synchronized(System.Collections.Queue)
		/// </summary>
		protected static RMethod r_RSynchronized_Queue;
		public static RMethod RSynchronized_Queue
		{
			get
			{
				if(r_RSynchronized_Queue == null)
				{
					r_RSynchronized_Queue = new(typeof(System.Collections.Queue), "Synchronized", 0, typeof(System.Collections.Queue));
					r_RSynchronized_Queue.SetBelong(null);
				}
				return r_RSynchronized_Queue;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_RContains_Object;
		public virtual RMethod RContains_Object
		{
			get
			{
				if(r_RContains_Object == null)
				{
					r_RContains_Object = new(this, "Contains", 0, typeof(System.Object));
					r_RContains_Object.SetBelong(this.instance);
				}
				return r_RContains_Object;
			}
		}

		/// <summary>
		/// System.Object GetElement(Int32)
		/// </summary>
		protected RMethod r_RGetElement_Int32;
		public virtual RMethod RGetElement_Int32
		{
			get
			{
				if(r_RGetElement_Int32 == null)
				{
					r_RGetElement_Int32 = new(this, "GetElement", 0, typeof(System.Int32));
					r_RGetElement_Int32.SetBelong(this.instance);
				}
				return r_RGetElement_Int32;
			}
		}

		/// <summary>
		/// System.Object[] ToArray()
		/// </summary>
		protected RMethod r_RToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_RToArray == null)
				{
					r_RToArray = new(this, "ToArray", 0);
					r_RToArray.SetBelong(this.instance);
				}
				return r_RToArray;
			}
		}

		/// <summary>
		/// Void SetCapacity(Int32)
		/// </summary>
		protected RMethod r_RSetCapacity_Int32;
		public virtual RMethod RSetCapacity_Int32
		{
			get
			{
				if(r_RSetCapacity_Int32 == null)
				{
					r_RSetCapacity_Int32 = new(this, "SetCapacity", 0, typeof(System.Int32));
					r_RSetCapacity_Int32.SetBelong(this.instance);
				}
				return r_RSetCapacity_Int32;
			}
		}

		/// <summary>
		/// Void TrimToSize()
		/// </summary>
		protected RMethod r_RTrimToSize;
		public virtual RMethod RTrimToSize
		{
			get
			{
				if(r_RTrimToSize == null)
				{
					r_RTrimToSize = new(this, "TrimToSize", 0);
					r_RTrimToSize.SetBelong(this.instance);
				}
				return r_RTrimToSize;
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


        public RQueue() : base("System.Collections.Queue")
        {
        }

        public RQueue(System.Object instance) : base("System.Collections.Queue")
		{
            SetInstance(instance);
		}

        public RQueue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RQueue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Enqueue(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REnqueue_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Object Dequeue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDequeue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeek.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Collections.Queue Synchronized(System.Collections.Queue  @queue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@queue};
            var ___result = RSynchronized_Queue.Invoke(___genericsType, ___parameters);

            return (System.Collections.Queue)___result;
        }


        public virtual System.Boolean Contains(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetElement(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RGetElement_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual void SetCapacity(System.Int32  @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RSetCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TrimToSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimToSize.Invoke(___genericsType, ___parameters);

            
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
