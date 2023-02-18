
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.NativePagedList`1
	/// </summary>
    public partial class RNativePagedList<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.Int32 k_PoolCapacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_PoolCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFk_PoolCapacity
		{
			get
			{
				if(r_Fk_PoolCapacity == null)
				{
					r_Fk_PoolCapacity = new(this, "k_PoolCapacity");
				}
				return r_Fk_PoolCapacity;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Unity.Collections.NativeArray`1[T]] m_Pages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField>> r_Fm_Pages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField>> RFm_Pages
		{
			get
			{
				if(r_Fm_Pages == null)
				{
					r_Fm_Pages = new(this, "m_Pages");
				}
				return r_Fm_Pages;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] m_CurrentPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField> r_Fm_CurrentPage;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField> RFm_CurrentPage
		{
			get
			{
				if(r_Fm_CurrentPage == null)
				{
					r_Fm_CurrentPage = new(this, "m_CurrentPage");
				}
				return r_Fm_CurrentPage;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentPageCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CurrentPageCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CurrentPageCount
		{
			get
			{
				if(r_Fm_CurrentPageCount == null)
				{
					r_Fm_CurrentPageCount = new(this, "m_CurrentPageCount");
				}
				return r_Fm_CurrentPageCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Unity.Collections.NativeSlice`1[T]] m_Enumerator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RField>> r_Fm_Enumerator;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RField>> RFm_Enumerator
		{
			get
			{
				if(r_Fm_Enumerator == null)
				{
					r_Fm_Enumerator = new(this, "m_Enumerator");
				}
				return r_Fm_Enumerator;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// Void Add(T ByRef)
		/// </summary>
		protected RMethod r_MAdd_Ref_T;
		public virtual RMethod RMAdd_Ref_T
		{
			get
			{
				if(r_MAdd_Ref_T == null)
				{
					r_MAdd_Ref_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MAdd_Ref_T;
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
		/// System.Collections.Generic.List`1[Unity.Collections.NativeSlice`1[T]] GetPages()
		/// </summary>
		protected RMethod r_MGetPages;
		public virtual RMethod RMGetPages
		{
			get
			{
				if(r_MGetPages == null)
				{
					r_MGetPages = new(this, "GetPages", 0);
				}
				return r_MGetPages;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
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


        public RNativePagedList() : base("UnityEngine.UIElements.UIR.NativePagedList`1")
        {
        }

        public RNativePagedList(System.Object instance) : base("UnityEngine.UIElements.UIR.NativePagedList`1")
		{
            SetInstance(instance);
		}

        public RNativePagedList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNativePagedList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(ref Hvak.Editor.Refleaction.RType @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMAdd_Ref_T.Invoke(___genericsType, ___parameters);
			@data = new Hvak.Editor.Refleaction.RType(___parameters[0]);

            
        }


        public virtual void Add(Hvak.Editor.Refleaction.RType @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMAdd_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>> GetPages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPages.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
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
