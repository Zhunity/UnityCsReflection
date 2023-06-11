
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.SparselyPopulatedArrayAddInfo`1
	/// </summary>
    public partial class RSparselyPopulatedArrayAddInfo<T> : RMember // where T : class
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.SparselyPopulatedArrayAddInfo`1").MakeGenericType(typeof(T));
            }
        }

        public RSparselyPopulatedArrayAddInfo() : base("System.Threading.SparselyPopulatedArrayAddInfo`1")
        {
        }

        public RSparselyPopulatedArrayAddInfo(System.Object instance) : base("System.Threading.SparselyPopulatedArrayAddInfo`1")
		{
            SetInstance(instance);
		}

        public RSparselyPopulatedArrayAddInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSparselyPopulatedArrayAddInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] _source
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> r_F_source;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RField> RF_source
		{
			get
			{
				if(r_F_source == null)
				{
					r_F_source = new(this, "_source");
				}
				return r_F_source;
			}
		}

		/// <summary>
		/// System.Int32 _index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_index
		{
			get
			{
				if(r_F_index == null)
				{
					r_F_index = new(this, "_index");
				}
				return r_F_index;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayFragment`1[T] Source
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RProperty> r_PSource;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayFragment<Hvak.Editor.Refleaction.RProperty> RPSource
		{
			get
			{
				if(r_PSource == null)
				{
					r_PSource = new(this, "Source", -1);
				}
				return r_PSource;
			}
		}

		/// <summary>
		/// Int32 Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIndex
		{
			get
			{
				if(r_PIndex == null)
				{
					r_PIndex = new(this, "Index", -1);
				}
				return r_PIndex;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
