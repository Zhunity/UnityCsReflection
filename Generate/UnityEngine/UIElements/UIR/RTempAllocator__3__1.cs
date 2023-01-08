using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.TempAllocator`1
	/// </summary>
    public partial class RTempAllocator<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.Int32 m_ExcessMinCapacity
		/// </summary>
		protected RField r_m_ExcessMinCapacity;
		public virtual RField Rm_ExcessMinCapacity
		{
			get
			{
				if(r_m_ExcessMinCapacity == null)
				{
					r_m_ExcessMinCapacity = new(this, "m_ExcessMinCapacity");
					r_m_ExcessMinCapacity.SetBelong(this.instance);
				}
				return r_m_ExcessMinCapacity;
			}
		}

		/// <summary>
		/// System.Int32 m_ExcessMaxCapacity
		/// </summary>
		protected RField r_m_ExcessMaxCapacity;
		public virtual RField Rm_ExcessMaxCapacity
		{
			get
			{
				if(r_m_ExcessMaxCapacity == null)
				{
					r_m_ExcessMaxCapacity = new(this, "m_ExcessMaxCapacity");
					r_m_ExcessMaxCapacity.SetBelong(this.instance);
				}
				return r_m_ExcessMaxCapacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1+Page[T] m_Pool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RField>.RPage r_m_Pool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RField>.RPage Rm_Pool
		{
			get
			{
				if(r_m_Pool == null)
				{
					r_m_Pool = new(this, "m_Pool");
					r_m_Pool.SetBelong(this.instance);
				}
				return r_m_Pool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.TempAllocator`1+Page[T]] m_Excess
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RTempAllocator<RField>.RPage> r_m_Excess;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RTempAllocator<RField>.RPage> Rm_Excess
		{
			get
			{
				if(r_m_Excess == null)
				{
					r_m_Excess = new(this, "m_Excess");
					r_m_Excess.SetBelong(this.instance);
				}
				return r_m_Excess;
			}
		}

		/// <summary>
		/// System.Int32 m_NextExcessSize
		/// </summary>
		protected RField r_m_NextExcessSize;
		public virtual RField Rm_NextExcessSize
		{
			get
			{
				if(r_m_NextExcessSize == null)
				{
					r_m_NextExcessSize = new(this, "m_NextExcessSize");
					r_m_NextExcessSize.SetBelong(this.instance);
				}
				return r_m_NextExcessSize;
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
		/// Unity.Collections.NativeSlice`1[T] Alloc(Int32)
		/// </summary>
		protected RMethod r_Alloc_Int32;
		public virtual RMethod RAlloc_Int32
		{
			get
			{
				if(r_Alloc_Int32 == null)
				{
					r_Alloc_Int32 = new(this, "Alloc", 0, typeof(System.Int32));
					r_Alloc_Int32.SetBelong(this.instance);
				}
				return r_Alloc_Int32;
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
		/// Void ReleaseExcess()
		/// </summary>
		protected RMethod r_ReleaseExcess;
		public virtual RMethod RReleaseExcess
		{
			get
			{
				if(r_ReleaseExcess == null)
				{
					r_ReleaseExcess = new(this, "ReleaseExcess", 0);
					r_ReleaseExcess.SetBelong(this.instance);
				}
				return r_ReleaseExcess;
			}
		}

		/// <summary>
		/// Statistics GatherStatistics()
		/// </summary>
		protected RMethod r_GatherStatistics;
		public virtual RMethod RGatherStatistics
		{
			get
			{
				if(r_GatherStatistics == null)
				{
					r_GatherStatistics = new(this, "GatherStatistics", 0);
					r_GatherStatistics.SetBelong(this.instance);
				}
				return r_GatherStatistics;
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


        public RTempAllocator() : base("UnityEngine.UIElements.UIR.TempAllocator`1")
        {
        }

        public RTempAllocator(System.Object instance) : base("UnityEngine.UIElements.UIR.TempAllocator`1")
		{
            SetInstance(instance);
		}

        public RTempAllocator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTempAllocator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Alloc(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RAlloc_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseExcess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherStatistics.Invoke(___genericsType, ___parameters);

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
