
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.Queue
	/// </summary>
    public partial class RQueue : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.Queue);
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


		/// <summary>
		/// System.Object[] _array
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_F_array;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RF_array
		{
			get
			{
				if(r_F_array == null)
				{
					r_F_array = new(this, "_array");
				}
				return r_F_array;
			}
		}

		/// <summary>
		/// System.Int32 _head
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_head;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_head
		{
			get
			{
				if(r_F_head == null)
				{
					r_F_head = new(this, "_head");
				}
				return r_F_head;
			}
		}

		/// <summary>
		/// System.Int32 _tail
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_tail;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_tail
		{
			get
			{
				if(r_F_tail == null)
				{
					r_F_tail = new(this, "_tail");
				}
				return r_F_tail;
			}
		}

		/// <summary>
		/// System.Int32 _size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_size;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_size
		{
			get
			{
				if(r_F_size == null)
				{
					r_F_size = new(this, "_size");
				}
				return r_F_size;
			}
		}

		/// <summary>
		/// System.Int32 _growFactor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_growFactor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_growFactor
		{
			get
			{
				if(r_F_growFactor == null)
				{
					r_F_growFactor = new(this, "_growFactor");
				}
				return r_F_growFactor;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_version
		{
			get
			{
				if(r_F_version == null)
				{
					r_F_version = new(this, "_version");
				}
				return r_F_version;
			}
		}

		/// <summary>
		/// System.Object _syncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_syncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_syncRoot
		{
			get
			{
				if(r_F_syncRoot == null)
				{
					r_F_syncRoot = new(this, "_syncRoot");
				}
				return r_F_syncRoot;
			}
		}

		/// <summary>
		/// System.Int32 _MinimumGrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_F_MinimumGrow;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RF_MinimumGrow
		{
			get
			{
				if(r_F_MinimumGrow == null)
				{
					r_F_MinimumGrow = new(Type, "_MinimumGrow");
				}
				return r_F_MinimumGrow;
			}
		}

		/// <summary>
		/// System.Int32 _ShrinkThreshold
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_F_ShrinkThreshold;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RF_ShrinkThreshold
		{
			get
			{
				if(r_F_ShrinkThreshold == null)
				{
					r_F_ShrinkThreshold = new(Type, "_ShrinkThreshold");
				}
				return r_F_ShrinkThreshold;
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
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
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
		/// Void Enqueue(System.Object)
		/// </summary>
		protected RMethod r_MEnqueue_Object;
		public virtual RMethod RMEnqueue_Object
		{
			get
			{
				if(r_MEnqueue_Object == null)
				{
					r_MEnqueue_Object = new(this, "Enqueue", 0, typeof(System.Object));
				}
				return r_MEnqueue_Object;
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
		/// System.Object Dequeue()
		/// </summary>
		protected RMethod r_MDequeue;
		public virtual RMethod RMDequeue
		{
			get
			{
				if(r_MDequeue == null)
				{
					r_MDequeue = new(this, "Dequeue", 0);
				}
				return r_MDequeue;
			}
		}

		/// <summary>
		/// System.Object Peek()
		/// </summary>
		protected RMethod r_MPeek;
		public virtual RMethod RMPeek
		{
			get
			{
				if(r_MPeek == null)
				{
					r_MPeek = new(this, "Peek", 0);
				}
				return r_MPeek;
			}
		}

		/// <summary>
		/// System.Collections.Queue Synchronized(System.Collections.Queue)
		/// </summary>
		protected static RMethod r_MSynchronized_Queue;
		public static RMethod RMSynchronized_Queue
		{
			get
			{
				if(r_MSynchronized_Queue == null)
				{
					r_MSynchronized_Queue = new(Type, "Synchronized", 0, typeof(System.Collections.Queue));
				}
				return r_MSynchronized_Queue;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_MContains_Object;
		public virtual RMethod RMContains_Object
		{
			get
			{
				if(r_MContains_Object == null)
				{
					r_MContains_Object = new(this, "Contains", 0, typeof(System.Object));
				}
				return r_MContains_Object;
			}
		}

		/// <summary>
		/// System.Object GetElement(Int32)
		/// </summary>
		protected RMethod r_MGetElement_Int32;
		public virtual RMethod RMGetElement_Int32
		{
			get
			{
				if(r_MGetElement_Int32 == null)
				{
					r_MGetElement_Int32 = new(this, "GetElement", 0, typeof(System.Int32));
				}
				return r_MGetElement_Int32;
			}
		}

		/// <summary>
		/// System.Object[] ToArray()
		/// </summary>
		protected RMethod r_MToArray;
		public virtual RMethod RMToArray
		{
			get
			{
				if(r_MToArray == null)
				{
					r_MToArray = new(this, "ToArray", 0);
				}
				return r_MToArray;
			}
		}

		/// <summary>
		/// Void SetCapacity(Int32)
		/// </summary>
		protected RMethod r_MSetCapacity_Int32;
		public virtual RMethod RMSetCapacity_Int32
		{
			get
			{
				if(r_MSetCapacity_Int32 == null)
				{
					r_MSetCapacity_Int32 = new(this, "SetCapacity", 0, typeof(System.Int32));
				}
				return r_MSetCapacity_Int32;
			}
		}

		/// <summary>
		/// Void TrimToSize()
		/// </summary>
		protected RMethod r_MTrimToSize;
		public virtual RMethod RMTrimToSize
		{
			get
			{
				if(r_MTrimToSize == null)
				{
					r_MTrimToSize = new(this, "TrimToSize", 0);
				}
				return r_MTrimToSize;
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


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Enqueue(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEnqueue_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual System.Object Dequeue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDequeue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPeek.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static System.Collections.Queue Synchronized(System.Collections.Queue @queue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@queue};
            var ___result = RMSynchronized_Queue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Queue>(___result);
        }


        public virtual System.Boolean Contains(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMContains_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Object GetElement(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMGetElement_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual void SetCapacity(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RMSetCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TrimToSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimToSize.Invoke(___genericsType, ___parameters);

            
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
