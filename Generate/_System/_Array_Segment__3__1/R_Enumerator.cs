
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{public partial class RArraySegment<T>
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.ArraySegment`1+Enumerator
	/// </summary>
    public partial class REnumerator : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.ArraySegment`1+Enumerator").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public REnumerator() : base("System.ArraySegment`1+Enumerator")
        {
        }

        public REnumerator(System.Object instance) : base("System.ArraySegment`1+Enumerator")
		{
            SetInstance(instance);
		}

        public REnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// T[] _array
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> r_F_array;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> RF_array
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
		/// System.Int32 _start
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_start;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_start
		{
			get
			{
				if(r_F_start == null)
				{
					r_F_start = new(this, "_start");
				}
				return r_F_start;
			}
		}

		/// <summary>
		/// System.Int32 _end
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_end;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_end
		{
			get
			{
				if(r_F_end == null)
				{
					r_F_end = new(this, "_end");
				}
				return r_F_end;
			}
		}

		/// <summary>
		/// System.Int32 _current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_current;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_current
		{
			get
			{
				if(r_F_current == null)
				{
					r_F_current = new(this, "_current");
				}
				return r_F_current;
			}
		}

		/// <summary>
		/// T Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PCurrent;
		public virtual Hvak.Editor.Refleaction.RProperty RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IEnumerator__2__Current;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IEnumerator__2__Current
		{
			get
			{
				if(r_PSystem__2__Collections__2__IEnumerator__2__Current == null)
				{
					r_PSystem__2__Collections__2__IEnumerator__2__Current = new(this, "System.Collections.IEnumerator.Current", -1);
				}
				return r_PSystem__2__Collections__2__IEnumerator__2__Current;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_MMoveNext;
		public virtual RMethod RMMoveNext
		{
			get
			{
				if(r_MMoveNext == null)
				{
					r_MMoveNext = new(this, "MoveNext", 0);
				}
				return r_MMoveNext;
			}
		}

		/// <summary>
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerator__2__Reset;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerator__2__Reset
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerator__2__Reset == null)
				{
					r_MSystem__2__Collections__2__IEnumerator__2__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerator__2__Reset;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
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


        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void System__2__Collections__2__IEnumerator__2__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerator__2__Reset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}