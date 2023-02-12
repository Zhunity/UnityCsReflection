
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{public partial class RRuntimeType
{
	
	/// <summary>
	/// System.RuntimeType+ListBuilder`1
	/// </summary>
    public partial class RListBuilder<T> : RMember // where T : class
    {

		/// <summary>
		/// T[] _items
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RField> r_F_items;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RField> RF_items
		{
			get
			{
				if(r_F_items == null)
				{
					r_F_items = new(this, "_items");
					r_F_items.SetBelong(this.instance);
				}
				return r_F_items;
			}
		}

		/// <summary>
		/// T _item
		/// </summary>
		protected SMFrame.Editor.Refleaction.RField r_F_item;
		public virtual SMFrame.Editor.Refleaction.RField RF_item
		{
			get
			{
				if(r_F_item == null)
				{
					r_F_item = new(this, "_item");
					r_F_item.SetBelong(this.instance);
				}
				return r_F_item;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_count;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_count
		{
			get
			{
				if(r_F_count == null)
				{
					r_F_count = new(this, "_count");
					r_F_count.SetBelong(this.instance);
				}
				return r_F_count;
			}
		}

		/// <summary>
		/// System.Int32 _capacity
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_capacity;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_capacity
		{
			get
			{
				if(r_F_capacity == null)
				{
					r_F_capacity = new(this, "_capacity");
					r_F_capacity.SetBelong(this.instance);
				}
				return r_F_capacity;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RProperty r_PItem_Int32;
		public virtual SMFrame.Editor.Refleaction.RProperty RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPCount
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
		/// T[] ToArray()
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
		/// Void CopyTo(System.Object[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_ObjectArray_Int32;
		public virtual RMethod RMCopyTo_ObjectArray_Int32
		{
			get
			{
				if(r_MCopyTo_ObjectArray_Int32 == null)
				{
					r_MCopyTo_ObjectArray_Int32 = new(this, "CopyTo", 0, typeof(System.Object).MakeArrayType(), typeof(System.Int32));
					r_MCopyTo_ObjectArray_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_ObjectArray_Int32;
			}
		}

		/// <summary>
		/// Void Add(T)
		/// </summary>
		protected RMethod r_MAdd_T;
		public virtual RMethod RMAdd_T
		{
			get
			{
				if(r_MAdd_T == null)
				{
					r_MAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_MAdd_T.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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


        public RListBuilder() : base("System.RuntimeType+ListBuilder`1")
        {
        }

        public RListBuilder(System.Object instance) : base("System.RuntimeType+ListBuilder`1")
		{
            SetInstance(instance);
		}

        public RListBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RListBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void CopyTo(System.Object[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_ObjectArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAdd_T.Invoke(___genericsType, ___parameters);

            
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
}