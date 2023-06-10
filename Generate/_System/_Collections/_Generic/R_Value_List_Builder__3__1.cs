
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.ValueListBuilder`1
	/// </summary>
    public partial class RValueListBuilder<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.ValueListBuilder`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RValueListBuilder() : base("System.Collections.Generic.ValueListBuilder`1")
        {
        }

        public RValueListBuilder(System.Object instance) : base("System.Collections.Generic.ValueListBuilder`1")
		{
            SetInstance(instance);
		}

        public RValueListBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValueListBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Span`1[T] _span
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RField> r_F_span;
		public virtual Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RField> RF_span
		{
			get
			{
				if(r_F_span == null)
				{
					r_F_span = new(this, "_span");
				}
				return r_F_span;
			}
		}

		/// <summary>
		/// T[] _arrayFromPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> r_F_arrayFromPool;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RField> RF_arrayFromPool
		{
			get
			{
				if(r_F_arrayFromPool == null)
				{
					r_F_arrayFromPool = new(this, "_arrayFromPool");
				}
				return r_F_arrayFromPool;
			}
		}

		/// <summary>
		/// System.Int32 _pos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_pos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_pos
		{
			get
			{
				if(r_F_pos == null)
				{
					r_F_pos = new(this, "_pos");
				}
				return r_F_pos;
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
		/// T& Item [Int32]
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
		/// Void Append(T)
		/// </summary>
		protected RMethod r_MAppend_T;
		public virtual RMethod RMAppend_T
		{
			get
			{
				if(r_MAppend_T == null)
				{
					r_MAppend_T = new(this, "Append", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MAppend_T;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] AsSpan()
		/// </summary>
		protected RMethod r_MAsSpan;
		public virtual RMethod RMAsSpan
		{
			get
			{
				if(r_MAsSpan == null)
				{
					r_MAsSpan = new(this, "AsSpan", 0);
				}
				return r_MAsSpan;
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
		/// Void Grow()
		/// </summary>
		protected RMethod r_MGrow;
		public virtual RMethod RMGrow
		{
			get
			{
				if(r_MGrow == null)
				{
					r_MGrow = new(this, "Grow", 0);
				}
				return r_MGrow;
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


        public virtual void Append(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAppend_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RType> AsSpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsSpan.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Grow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGrow.Invoke(___genericsType, ___parameters);

            
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
