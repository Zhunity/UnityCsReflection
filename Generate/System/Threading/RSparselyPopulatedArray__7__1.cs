using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SparselyPopulatedArray`1
	/// </summary>
    public partial class RSparselyPopulatedArray<T> : RMember // where T : class
    {

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _head
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> r__head;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> R_head
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
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _tail
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> r__tail;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayFragment<RField> R_tail
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
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] Tail
		/// </summary>
		protected RSystem.RThreading.RSparselyPopulatedArrayFragment<RProperty> r_Tail;
		public virtual RSystem.RThreading.RSparselyPopulatedArrayFragment<RProperty> RTail
		{
			get
			{
				if(r_Tail == null)
				{
					r_Tail = new(this, "Tail", -1);
					r_Tail.SetBelong(this.instance);
				}
				return r_Tail;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayAddInfo`1[T] Add(T)
		/// </summary>
		protected RMethod r_RAdd_T;
		public virtual RMethod RAdd_T
		{
			get
			{
				if(r_RAdd_T == null)
				{
					r_RAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_RAdd_T.SetBelong(this.instance);
				}
				return r_RAdd_T;
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

        public virtual System.Object Add(T  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RAdd_T.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
