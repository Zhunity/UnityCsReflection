
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.TempAllocator`1
	/// </summary>
    public partial class RTempAllocator<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TempAllocator`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
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


		/// <summary>
		/// System.Int32 m_ExcessMinCapacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ExcessMinCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ExcessMinCapacity
		{
			get
			{
				if(r_Fm_ExcessMinCapacity == null)
				{
					r_Fm_ExcessMinCapacity = new(this, "m_ExcessMinCapacity");
				}
				return r_Fm_ExcessMinCapacity;
			}
		}

		/// <summary>
		/// System.Int32 m_ExcessMaxCapacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ExcessMaxCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ExcessMaxCapacity
		{
			get
			{
				if(r_Fm_ExcessMaxCapacity == null)
				{
					r_Fm_ExcessMaxCapacity = new(this, "m_ExcessMaxCapacity");
				}
				return r_Fm_ExcessMaxCapacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1+Page[T] m_Pool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RField>.RPage r_Fm_Pool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RField>.RPage RFm_Pool
		{
			get
			{
				if(r_Fm_Pool == null)
				{
					r_Fm_Pool = new(this, "m_Pool");
				}
				return r_Fm_Pool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.TempAllocator`1+Page[T]] m_Excess
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RField>.RPage> r_Fm_Excess;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RField>.RPage> RFm_Excess
		{
			get
			{
				if(r_Fm_Excess == null)
				{
					r_Fm_Excess = new(this, "m_Excess");
				}
				return r_Fm_Excess;
			}
		}

		/// <summary>
		/// System.Int32 m_NextExcessSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NextExcessSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NextExcessSize
		{
			get
			{
				if(r_Fm_NextExcessSize == null)
				{
					r_Fm_NextExcessSize = new(this, "m_NextExcessSize");
				}
				return r_Fm_NextExcessSize;
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
		/// Unity.Collections.NativeSlice`1[T] Alloc(Int32)
		/// </summary>
		protected RMethod r_MAlloc_Int32;
		public virtual RMethod RMAlloc_Int32
		{
			get
			{
				if(r_MAlloc_Int32 == null)
				{
					r_MAlloc_Int32 = new(this, "Alloc", 0, typeof(System.Int32));
				}
				return r_MAlloc_Int32;
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
		/// Void ReleaseExcess()
		/// </summary>
		protected RMethod r_MReleaseExcess;
		public virtual RMethod RMReleaseExcess
		{
			get
			{
				if(r_MReleaseExcess == null)
				{
					r_MReleaseExcess = new(this, "ReleaseExcess", 0);
				}
				return r_MReleaseExcess;
			}
		}

		/// <summary>
		/// Statistics GatherStatistics()
		/// </summary>
		protected RMethod r_MGatherStatistics;
		public virtual RMethod RMGatherStatistics
		{
			get
			{
				if(r_MGatherStatistics == null)
				{
					r_MGatherStatistics = new(this, "GatherStatistics", 0);
				}
				return r_MGatherStatistics;
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


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> Alloc(System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RMAlloc_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseExcess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReleaseExcess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RType>.RStatistics GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGatherStatistics.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RType>.RStatistics>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
