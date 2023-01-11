using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.ValueListBuilder`1
	/// </summary>
    public partial class RValueListBuilder<T> : RMember //
    {

		/// <summary>
		/// System.Span`1[T] _span
		/// </summary>
		protected RSystem.RSpan<RField> r__span;
		public virtual RSystem.RSpan<RField> R_span
		{
			get
			{
				if(r__span == null)
				{
					r__span = new(this, "_span");
					r__span.SetBelong(this.instance);
				}
				return r__span;
			}
		}

		/// <summary>
		/// T[] _arrayFromPool
		/// </summary>
		protected RFieldArray<RField> r__arrayFromPool;
		public virtual RFieldArray<RField> R_arrayFromPool
		{
			get
			{
				if(r__arrayFromPool == null)
				{
					r__arrayFromPool = new(this, "_arrayFromPool");
					r__arrayFromPool.SetBelong(this.instance);
				}
				return r__arrayFromPool;
			}
		}

		/// <summary>
		/// System.Int32 _pos
		/// </summary>
		protected RSystem.RInt32 r__pos;
		public virtual RSystem.RInt32 R_pos
		{
			get
			{
				if(r__pos == null)
				{
					r__pos = new(this, "_pos");
					r__pos.SetBelong(this.instance);
				}
				return r__pos;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_Length;
		public virtual RSystem.RInt32 RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// T& Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Void Append(T)
		/// </summary>
		protected RMethod r_Append_T;
		public virtual RMethod RAppend_T
		{
			get
			{
				if(r_Append_T == null)
				{
					r_Append_T = new(this, "Append", 0, Type.MakeGenericMethodParameter(0));
					r_Append_T.SetBelong(this.instance);
				}
				return r_Append_T;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] AsSpan()
		/// </summary>
		protected RMethod r_AsSpan;
		public virtual RMethod RAsSpan
		{
			get
			{
				if(r_AsSpan == null)
				{
					r_AsSpan = new(this, "AsSpan", 0);
					r_AsSpan.SetBelong(this.instance);
				}
				return r_AsSpan;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Grow()
		/// </summary>
		protected RMethod r_Grow;
		public virtual RMethod RGrow
		{
			get
			{
				if(r_Grow == null)
				{
					r_Grow = new(this, "Grow", 0);
					r_Grow.SetBelong(this.instance);
				}
				return r_Grow;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public virtual void Append(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAppend_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RSystem.RReadOnlySpan<RType> AsSpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsSpan.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RType>(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Grow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGrow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
