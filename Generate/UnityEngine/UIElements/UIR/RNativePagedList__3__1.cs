using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.NativePagedList`1
	/// </summary>
    public partial class RNativePagedList<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.Int32 k_PoolCapacity
		/// </summary>
		protected RField r_k_PoolCapacity;
		public virtual RField Rk_PoolCapacity
		{
			get
			{
				if(r_k_PoolCapacity == null)
				{
					r_k_PoolCapacity = new(this, "k_PoolCapacity");
					r_k_PoolCapacity.SetBelong(this.instance);
				}
				return r_k_PoolCapacity;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Unity.Collections.NativeArray`1[T]] m_Pages
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_Pages;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_Pages
		{
			get
			{
				if(r_m_Pages == null)
				{
					r_m_Pages = new(this, "m_Pages");
					r_m_Pages.SetBelong(this.instance);
				}
				return r_m_Pages;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] m_CurrentPage
		/// </summary>
		protected RField r_m_CurrentPage;
		public virtual RField Rm_CurrentPage
		{
			get
			{
				if(r_m_CurrentPage == null)
				{
					r_m_CurrentPage = new(this, "m_CurrentPage");
					r_m_CurrentPage.SetBelong(this.instance);
				}
				return r_m_CurrentPage;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentPageCount
		/// </summary>
		protected RField r_m_CurrentPageCount;
		public virtual RField Rm_CurrentPageCount
		{
			get
			{
				if(r_m_CurrentPageCount == null)
				{
					r_m_CurrentPageCount = new(this, "m_CurrentPageCount");
					r_m_CurrentPageCount.SetBelong(this.instance);
				}
				return r_m_CurrentPageCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Unity.Collections.NativeSlice`1[T]] m_Enumerator
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_Enumerator;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_Enumerator
		{
			get
			{
				if(r_m_Enumerator == null)
				{
					r_m_Enumerator = new(this, "m_Enumerator");
					r_m_Enumerator.SetBelong(this.instance);
				}
				return r_m_Enumerator;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RField r___0__disposed__1__k__BackingField;
		public virtual RField R__0__disposed__1__k__BackingField
		{
			get
			{
				if(r___0__disposed__1__k__BackingField == null)
				{
					r___0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r___0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RProperty r_disposed;
		public virtual RProperty Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed", -1);
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// Void Add(T ByRef)
		/// </summary>
		protected RMethod r_Add_Ref_T;
		public virtual RMethod RAdd_Ref_T
		{
			get
			{
				if(r_Add_Ref_T == null)
				{
					r_Add_Ref_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_Add_Ref_T.SetBelong(this.instance);
				}
				return r_Add_Ref_T;
			}
		}

		/// <summary>
		/// Void Add(T)
		/// </summary>
		protected RMethod r_Add_T;
		public virtual RMethod RAdd_T
		{
			get
			{
				if(r_Add_T == null)
				{
					r_Add_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_Add_T.SetBelong(this.instance);
				}
				return r_Add_T;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Unity.Collections.NativeSlice`1[T]] GetPages()
		/// </summary>
		protected RMethod r_GetPages;
		public virtual RMethod RGetPages
		{
			get
			{
				if(r_GetPages == null)
				{
					r_GetPages = new(this, "GetPages", 0);
					r_GetPages.SetBelong(this.instance);
				}
				return r_GetPages;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
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

        public virtual void Add(ref T @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RAdd_Ref_T.Invoke(___genericsType, ___parameters);
			@data = (T)___parameters[0];

            
        }


        public virtual void Add(T @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RAdd_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetPages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPages.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
