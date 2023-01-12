using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.Stack
	/// </summary>
    public partial class RStack : RMember //
    {

		/// <summary>
		/// System.Object[] _array
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_F_array;
		public virtual RFieldArray<RSystem.RObject> RF_array
		{
			get
			{
				if(r_F_array == null)
				{
					r_F_array = new(this, "_array");
					r_F_array.SetBelong(this.instance);
				}
				return r_F_array;
			}
		}

		/// <summary>
		/// System.Int32 _size
		/// </summary>
		protected RSystem.RInt32 r_F_size;
		public virtual RSystem.RInt32 RF_size
		{
			get
			{
				if(r_F_size == null)
				{
					r_F_size = new(this, "_size");
					r_F_size.SetBelong(this.instance);
				}
				return r_F_size;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected RSystem.RInt32 r_F_version;
		public virtual RSystem.RInt32 RF_version
		{
			get
			{
				if(r_F_version == null)
				{
					r_F_version = new(this, "_version");
					r_F_version.SetBelong(this.instance);
				}
				return r_F_version;
			}
		}

		/// <summary>
		/// System.Object _syncRoot
		/// </summary>
		protected RSystem.RObject r_F_syncRoot;
		public virtual RSystem.RObject RF_syncRoot
		{
			get
			{
				if(r_F_syncRoot == null)
				{
					r_F_syncRoot = new(this, "_syncRoot");
					r_F_syncRoot.SetBelong(this.instance);
				}
				return r_F_syncRoot;
			}
		}

		/// <summary>
		/// System.Int32 _defaultCapacity
		/// </summary>
		protected static RSystem.RInt32 r_F_defaultCapacity;
		public static RSystem.RInt32 RF_defaultCapacity
		{
			get
			{
				if(r_F_defaultCapacity == null)
				{
					r_F_defaultCapacity = new(typeof(System.Collections.Stack), "_defaultCapacity");
					r_F_defaultCapacity.SetBelong(null);
				}
				return r_F_defaultCapacity;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RSystem.RInt32 r_PCount;
		public virtual RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.instance);
				}
				return r_PCount;
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
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
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
					r_MContains_Object.SetBelong(this.instance);
				}
				return r_MContains_Object;
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
					r_MPeek.SetBelong(this.instance);
				}
				return r_MPeek;
			}
		}

		/// <summary>
		/// System.Object Pop()
		/// </summary>
		protected RMethod r_MPop;
		public virtual RMethod RMPop
		{
			get
			{
				if(r_MPop == null)
				{
					r_MPop = new(this, "Pop", 0);
					r_MPop.SetBelong(this.instance);
				}
				return r_MPop;
			}
		}

		/// <summary>
		/// Void Push(System.Object)
		/// </summary>
		protected RMethod r_MPush_Object;
		public virtual RMethod RMPush_Object
		{
			get
			{
				if(r_MPush_Object == null)
				{
					r_MPush_Object = new(this, "Push", 0, typeof(System.Object));
					r_MPush_Object.SetBelong(this.instance);
				}
				return r_MPush_Object;
			}
		}

		/// <summary>
		/// System.Collections.Stack Synchronized(System.Collections.Stack)
		/// </summary>
		protected static RMethod r_MSynchronized_Stack;
		public static RMethod RMSynchronized_Stack
		{
			get
			{
				if(r_MSynchronized_Stack == null)
				{
					r_MSynchronized_Stack = new(typeof(System.Collections.Stack), "Synchronized", 0, typeof(System.Collections.Stack));
					r_MSynchronized_Stack.SetBelong(null);
				}
				return r_MSynchronized_Stack;
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
					r_MToArray.SetBelong(this.instance);
				}
				return r_MToArray;
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


        public RStack() : base("System.Collections.Stack")
        {
        }

        public RStack(System.Object instance) : base("System.Collections.Stack")
		{
            SetInstance(instance);
		}

        public RStack(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStack(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Contains(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Object Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPeek.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Pop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPop.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Push(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMPush_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Stack Synchronized(System.Collections.Stack @stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stack};
            var ___result = RMSynchronized_Stack.Invoke(___genericsType, ___parameters);

            return (System.Collections.Stack)___result;
        }


        public virtual System.Object[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
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
