
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Collections.Generic.ICollection`1
	/// </summary>
    public partial class RICollection<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Collections.Generic.ICollection`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RICollection() : base("System.Collections.Generic.ICollection`1")
        {
        }

        public RICollection(System.Object instance) : base("System.Collections.Generic.ICollection`1")
		{
            SetInstance(instance);
		}

        public RICollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RICollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
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
				}
				return r_MAdd_T;
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
		/// Boolean Contains(T)
		/// </summary>
		protected RMethod r_MContains_T;
		public virtual RMethod RMContains_T
		{
			get
			{
				if(r_MContains_T == null)
				{
					r_MContains_T = new(this, "Contains", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MContains_T;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_TArray_Int32;
		public virtual RMethod RMCopyTo_TArray_Int32
		{
			get
			{
				if(r_MCopyTo_TArray_Int32 == null)
				{
					r_MCopyTo_TArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopyTo_TArray_Int32;
			}
		}

		/// <summary>
		/// Boolean Remove(T)
		/// </summary>
		protected RMethod r_MRemove_T;
		public virtual RMethod RMRemove_T
		{
			get
			{
				if(r_MRemove_T == null)
				{
					r_MRemove_T = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MRemove_T;
			}
		}


        public virtual void Add(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMAdd_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMContains_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void CopyTo(T[] @array, System.Int32 @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RMCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(T @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMRemove_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


    }
}
