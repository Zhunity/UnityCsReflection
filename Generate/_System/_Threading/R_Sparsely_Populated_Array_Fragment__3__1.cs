
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SparselyPopulatedArrayFragment`1
	/// </summary>
    public partial class RSparselyPopulatedArrayFragment<T> : RMember // where T : class
    {

		/// <summary>
		/// T[] _elements
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> r_F_elements;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> RF_elements
		{
			get
			{
				if(r_F_elements == null)
				{
					r_F_elements = new(this, "_elements");
				}
				return r_F_elements;
			}
		}

		/// <summary>
		/// System.Int32 _freeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_freeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_freeCount
		{
			get
			{
				if(r_F_freeCount == null)
				{
					r_F_freeCount = new(this, "_freeCount");
				}
				return r_F_freeCount;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _next
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> r_F_next;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> RF_next
		{
			get
			{
				if(r_F_next == null)
				{
					r_F_next = new(this, "_next");
				}
				return r_F_next;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _prev
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> r_F_prev;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> RF_prev
		{
			get
			{
				if(r_F_prev == null)
				{
					r_F_prev = new(this, "_prev");
				}
				return r_F_prev;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem_Int32
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
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] Prev
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RProperty> r_PPrev;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RProperty> RPPrev
		{
			get
			{
				if(r_PPrev == null)
				{
					r_PPrev = new(this, "Prev", -1);
				}
				return r_PPrev;
			}
		}

		/// <summary>
		/// T SafeAtomicRemove(Int32, T)
		/// </summary>
		protected RMethod r_MSafeAtomicRemove_Int32_T;
		public virtual RMethod RMSafeAtomicRemove_Int32_T
		{
			get
			{
				if(r_MSafeAtomicRemove_Int32_T == null)
				{
					r_MSafeAtomicRemove_Int32_T = new(this, "SafeAtomicRemove", 0, typeof(System.Int32), Type.MakeGenericMethodParameter(0));
				}
				return r_MSafeAtomicRemove_Int32_T;
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


        public RSparselyPopulatedArrayFragment() : base("System.Threading.SparselyPopulatedArrayFragment`1")
        {
        }

        public RSparselyPopulatedArrayFragment(System.Object instance) : base("System.Threading.SparselyPopulatedArrayFragment`1")
		{
            SetInstance(instance);
		}

        public RSparselyPopulatedArrayFragment(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSparselyPopulatedArrayFragment(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual T SafeAtomicRemove(System.Int32 @index, T @expectedElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @expectedElement};
            var ___result = RMSafeAtomicRemove_Int32_T.Invoke(___genericsType, ___parameters);

            return (T)___result;
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
