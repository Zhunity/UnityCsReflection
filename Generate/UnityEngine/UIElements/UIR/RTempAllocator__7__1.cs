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
		protected RField r___1__disposed__2__k__BackingField;
		public virtual RField R__1__disposed__2__k__BackingField
		{
			get
			{
				if(r___1__disposed__2__k__BackingField == null)
				{
					r___1__disposed__2__k__BackingField = new(this, "<disposed>k__BackingField");
					r___1__disposed__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__disposed__2__k__BackingField;
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
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[T] Alloc(Int32)
		/// </summary>
		protected RMethod r_RAlloc_Int32;
		public virtual RMethod RAlloc_Int32
		{
			get
			{
				if(r_RAlloc_Int32 == null)
				{
					r_RAlloc_Int32 = new(this, "Alloc", 0, typeof(System.Int32));
					r_RAlloc_Int32.SetBelong(this.instance);
				}
				return r_RAlloc_Int32;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void ReleaseExcess()
		/// </summary>
		protected RMethod r_RReleaseExcess;
		public virtual RMethod RReleaseExcess
		{
			get
			{
				if(r_RReleaseExcess == null)
				{
					r_RReleaseExcess = new(this, "ReleaseExcess", 0);
					r_RReleaseExcess.SetBelong(this.instance);
				}
				return r_RReleaseExcess;
			}
		}

		/// <summary>
		/// Statistics GatherStatistics()
		/// </summary>
		protected RMethod r_RGatherStatistics;
		public virtual RMethod RGatherStatistics
		{
			get
			{
				if(r_RGatherStatistics == null)
				{
					r_RGatherStatistics = new(this, "GatherStatistics", 0);
					r_RGatherStatistics.SetBelong(this.instance);
				}
				return r_RGatherStatistics;
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
