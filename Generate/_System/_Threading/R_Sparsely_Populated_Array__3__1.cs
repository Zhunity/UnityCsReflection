
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SparselyPopulatedArray`1
	/// </summary>
    public partial class RSparselyPopulatedArray<T> : RMember // where T : class
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.SparselyPopulatedArray`1").MakeGenericType(typeof(T));
            }
        }

        public RSparselyPopulatedArray() : base("System.Threading.SparselyPopulatedArray`1")
        {
        }

        public RSparselyPopulatedArray(System.Object instance) : base("System.Threading.SparselyPopulatedArray`1")
		{
            SetInstance(instance);
		}

        public RSparselyPopulatedArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSparselyPopulatedArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _head
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> r_F_head;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> RF_head
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
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _tail
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> r_F_tail;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> RF_tail
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
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] Tail
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RProperty> r_PTail;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RProperty> RPTail
		{
			get
			{
				if(r_PTail == null)
				{
					r_PTail = new(this, "Tail", -1);
				}
				return r_PTail;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayAddInfo`1[T] Add(T)
		/// </summary>
		protected RMethod r_MAdd_T;
		public virtual RMethod RMAdd_T
		{
			get
			{
				if(r_MAdd_T == null)
				{
					r_MAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MAdd_T;
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


        public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayAddInfo<Hvak.Editor.Refleaction.RType> Add(T @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMAdd_T.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayAddInfo<Hvak.Editor.Refleaction.RType>(___result);
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
