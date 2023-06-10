
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RPage
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.Page+DataSet`1
	/// </summary>
    public partial class RDataSet<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Page+DataSet`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RDataSet() : base("UnityEngine.UIElements.UIR.Page+DataSet`1")
        {
        }

        public RDataSet(System.Object instance) : base("UnityEngine.UIElements.UIR.Page+DataSet`1")
		{
            SetInstance(instance);
		}

        public RDataSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDataSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
		/// UnityEngine.UIElements.UIR.Utility+GPUBuffer`1[T] gpuData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUtility.RGPUBuffer<Hvak.Editor.Refleaction.RField> r_FgpuData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUtility.RGPUBuffer<Hvak.Editor.Refleaction.RField> RFgpuData
		{
			get
			{
				if(r_FgpuData == null)
				{
					r_FgpuData = new(this, "gpuData");
				}
				return r_FgpuData;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] cpuData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField> r_FcpuData;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField> RFcpuData
		{
			get
			{
				if(r_FcpuData == null)
				{
					r_FcpuData = new(this, "cpuData");
				}
				return r_FcpuData;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.UIElements.UIR.GfxUpdateBufferRange] updateRanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGfxUpdateBufferRange> r_FupdateRanges;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGfxUpdateBufferRange> RFupdateRanges
		{
			get
			{
				if(r_FupdateRanges == null)
				{
					r_FupdateRanges = new(this, "updateRanges");
				}
				return r_FupdateRanges;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GPUBufferAllocator allocator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGPUBufferAllocator r_Fallocator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGPUBufferAllocator RFallocator
		{
			get
			{
				if(r_Fallocator == null)
				{
					r_Fallocator = new(this, "allocator");
				}
				return r_Fallocator;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangePoolSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_UpdateRangePoolSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_UpdateRangePoolSize
		{
			get
			{
				if(r_Fm_UpdateRangePoolSize == null)
				{
					r_Fm_UpdateRangePoolSize = new(this, "m_UpdateRangePoolSize");
				}
				return r_Fm_UpdateRangePoolSize;
			}
		}

		/// <summary>
		/// System.UInt32 m_ElemStride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_ElemStride;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_ElemStride
		{
			get
			{
				if(r_Fm_ElemStride == null)
				{
					r_Fm_ElemStride = new(this, "m_ElemStride");
				}
				return r_Fm_ElemStride;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangeMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_UpdateRangeMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_UpdateRangeMin
		{
			get
			{
				if(r_Fm_UpdateRangeMin == null)
				{
					r_Fm_UpdateRangeMin = new(this, "m_UpdateRangeMin");
				}
				return r_Fm_UpdateRangeMin;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangeMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_UpdateRangeMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_UpdateRangeMax
		{
			get
			{
				if(r_Fm_UpdateRangeMax == null)
				{
					r_Fm_UpdateRangeMax = new(this, "m_UpdateRangeMax");
				}
				return r_Fm_UpdateRangeMax;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangesEnqueued
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_UpdateRangesEnqueued;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_UpdateRangesEnqueued
		{
			get
			{
				if(r_Fm_UpdateRangesEnqueued == null)
				{
					r_Fm_UpdateRangesEnqueued = new(this, "m_UpdateRangesEnqueued");
				}
				return r_Fm_UpdateRangesEnqueued;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangesBatchStart
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_UpdateRangesBatchStart;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_UpdateRangesBatchStart
		{
			get
			{
				if(r_Fm_UpdateRangesBatchStart == null)
				{
					r_Fm_UpdateRangesBatchStart = new(this, "m_UpdateRangesBatchStart");
				}
				return r_Fm_UpdateRangesBatchStart;
			}
		}

		/// <summary>
		/// System.Boolean m_UpdateRangesSaturated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UpdateRangesSaturated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UpdateRangesSaturated
		{
			get
			{
				if(r_Fm_UpdateRangesSaturated == null)
				{
					r_Fm_UpdateRangesSaturated = new(this, "m_UpdateRangesSaturated");
				}
				return r_Fm_UpdateRangesSaturated;
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
		/// Void RegisterUpdate(UInt32, UInt32)
		/// </summary>
		protected RMethod r_MRegisterUpdate_UInt32_UInt32;
		public virtual RMethod RMRegisterUpdate_UInt32_UInt32
		{
			get
			{
				if(r_MRegisterUpdate_UInt32_UInt32 == null)
				{
					r_MRegisterUpdate_UInt32_UInt32 = new(this, "RegisterUpdate", 0, typeof(System.UInt32), typeof(System.UInt32));
				}
				return r_MRegisterUpdate_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Boolean HasMappedBufferRange()
		/// </summary>
		protected RMethod r_MHasMappedBufferRange;
		public virtual RMethod RMHasMappedBufferRange
		{
			get
			{
				if(r_MHasMappedBufferRange == null)
				{
					r_MHasMappedBufferRange = new(this, "HasMappedBufferRange", 0);
				}
				return r_MHasMappedBufferRange;
			}
		}

		/// <summary>
		/// Void SendUpdates()
		/// </summary>
		protected RMethod r_MSendUpdates;
		public virtual RMethod RMSendUpdates
		{
			get
			{
				if(r_MSendUpdates == null)
				{
					r_MSendUpdates = new(this, "SendUpdates", 0);
				}
				return r_MSendUpdates;
			}
		}

		/// <summary>
		/// Void SendFullRange()
		/// </summary>
		protected RMethod r_MSendFullRange;
		public virtual RMethod RMSendFullRange
		{
			get
			{
				if(r_MSendFullRange == null)
				{
					r_MSendFullRange = new(this, "SendFullRange", 0);
				}
				return r_MSendFullRange;
			}
		}

		/// <summary>
		/// Void SendPartialRanges()
		/// </summary>
		protected RMethod r_MSendPartialRanges;
		public virtual RMethod RMSendPartialRanges
		{
			get
			{
				if(r_MSendPartialRanges == null)
				{
					r_MSendPartialRanges = new(this, "SendPartialRanges", 0);
				}
				return r_MSendPartialRanges;
			}
		}

		/// <summary>
		/// Void ResetUpdateState()
		/// </summary>
		protected RMethod r_MResetUpdateState;
		public virtual RMethod RMResetUpdateState
		{
			get
			{
				if(r_MResetUpdateState == null)
				{
					r_MResetUpdateState = new(this, "ResetUpdateState", 0);
				}
				return r_MResetUpdateState;
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


        public virtual void RegisterUpdate(System.UInt32 @start, System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @size};
            var ___result = RMRegisterUpdate_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasMappedBufferRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasMappedBufferRange.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendUpdates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendUpdates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendFullRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendFullRange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPartialRanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendPartialRanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetUpdateState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetUpdateState.Invoke(___genericsType, ___parameters);

            
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
}