using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RPage
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.Page+DataSet`1
	/// </summary>
    public partial class RDataSet<T> : RMember // where T : struct
    {

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
		/// UnityEngine.UIElements.UIR.Utility+GPUBuffer`1[T] gpuData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUtility.RGPUBuffer<RField> r_gpuData;
		public virtual RUnityEngine.RUIElements.RUIR.RUtility.RGPUBuffer<RField> RgpuData
		{
			get
			{
				if(r_gpuData == null)
				{
					r_gpuData = new(this, "gpuData");
					r_gpuData.SetBelong(this.instance);
				}
				return r_gpuData;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] cpuData
		/// </summary>
		protected RField r_cpuData;
		public virtual RField RcpuData
		{
			get
			{
				if(r_cpuData == null)
				{
					r_cpuData = new(this, "cpuData");
					r_cpuData.SetBelong(this.instance);
				}
				return r_cpuData;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.UIElements.UIR.GfxUpdateBufferRange] updateRanges
		/// </summary>
		protected RField r_updateRanges;
		public virtual RField RupdateRanges
		{
			get
			{
				if(r_updateRanges == null)
				{
					r_updateRanges = new(this, "updateRanges");
					r_updateRanges.SetBelong(this.instance);
				}
				return r_updateRanges;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GPUBufferAllocator allocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGPUBufferAllocator r_allocator;
		public virtual RUnityEngine.RUIElements.RUIR.RGPUBufferAllocator Rallocator
		{
			get
			{
				if(r_allocator == null)
				{
					r_allocator = new(this, "allocator");
					r_allocator.SetBelong(this.instance);
				}
				return r_allocator;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangePoolSize
		/// </summary>
		protected RField r_m_UpdateRangePoolSize;
		public virtual RField Rm_UpdateRangePoolSize
		{
			get
			{
				if(r_m_UpdateRangePoolSize == null)
				{
					r_m_UpdateRangePoolSize = new(this, "m_UpdateRangePoolSize");
					r_m_UpdateRangePoolSize.SetBelong(this.instance);
				}
				return r_m_UpdateRangePoolSize;
			}
		}

		/// <summary>
		/// System.UInt32 m_ElemStride
		/// </summary>
		protected RField r_m_ElemStride;
		public virtual RField Rm_ElemStride
		{
			get
			{
				if(r_m_ElemStride == null)
				{
					r_m_ElemStride = new(this, "m_ElemStride");
					r_m_ElemStride.SetBelong(this.instance);
				}
				return r_m_ElemStride;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangeMin
		/// </summary>
		protected RField r_m_UpdateRangeMin;
		public virtual RField Rm_UpdateRangeMin
		{
			get
			{
				if(r_m_UpdateRangeMin == null)
				{
					r_m_UpdateRangeMin = new(this, "m_UpdateRangeMin");
					r_m_UpdateRangeMin.SetBelong(this.instance);
				}
				return r_m_UpdateRangeMin;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangeMax
		/// </summary>
		protected RField r_m_UpdateRangeMax;
		public virtual RField Rm_UpdateRangeMax
		{
			get
			{
				if(r_m_UpdateRangeMax == null)
				{
					r_m_UpdateRangeMax = new(this, "m_UpdateRangeMax");
					r_m_UpdateRangeMax.SetBelong(this.instance);
				}
				return r_m_UpdateRangeMax;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangesEnqueued
		/// </summary>
		protected RField r_m_UpdateRangesEnqueued;
		public virtual RField Rm_UpdateRangesEnqueued
		{
			get
			{
				if(r_m_UpdateRangesEnqueued == null)
				{
					r_m_UpdateRangesEnqueued = new(this, "m_UpdateRangesEnqueued");
					r_m_UpdateRangesEnqueued.SetBelong(this.instance);
				}
				return r_m_UpdateRangesEnqueued;
			}
		}

		/// <summary>
		/// System.UInt32 m_UpdateRangesBatchStart
		/// </summary>
		protected RField r_m_UpdateRangesBatchStart;
		public virtual RField Rm_UpdateRangesBatchStart
		{
			get
			{
				if(r_m_UpdateRangesBatchStart == null)
				{
					r_m_UpdateRangesBatchStart = new(this, "m_UpdateRangesBatchStart");
					r_m_UpdateRangesBatchStart.SetBelong(this.instance);
				}
				return r_m_UpdateRangesBatchStart;
			}
		}

		/// <summary>
		/// System.Boolean m_UpdateRangesSaturated
		/// </summary>
		protected RField r_m_UpdateRangesSaturated;
		public virtual RField Rm_UpdateRangesSaturated
		{
			get
			{
				if(r_m_UpdateRangesSaturated == null)
				{
					r_m_UpdateRangesSaturated = new(this, "m_UpdateRangesSaturated");
					r_m_UpdateRangesSaturated.SetBelong(this.instance);
				}
				return r_m_UpdateRangesSaturated;
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
		/// Void RegisterUpdate(UInt32, UInt32)
		/// </summary>
		protected RMethod r_RRegisterUpdate_UInt32_UInt32;
		public virtual RMethod RRegisterUpdate_UInt32_UInt32
		{
			get
			{
				if(r_RRegisterUpdate_UInt32_UInt32 == null)
				{
					r_RRegisterUpdate_UInt32_UInt32 = new(this, "RegisterUpdate", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_RRegisterUpdate_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_RRegisterUpdate_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Boolean HasMappedBufferRange()
		/// </summary>
		protected RMethod r_RHasMappedBufferRange;
		public virtual RMethod RHasMappedBufferRange
		{
			get
			{
				if(r_RHasMappedBufferRange == null)
				{
					r_RHasMappedBufferRange = new(this, "HasMappedBufferRange", 0);
					r_RHasMappedBufferRange.SetBelong(this.instance);
				}
				return r_RHasMappedBufferRange;
			}
		}

		/// <summary>
		/// Void SendUpdates()
		/// </summary>
		protected RMethod r_RSendUpdates;
		public virtual RMethod RSendUpdates
		{
			get
			{
				if(r_RSendUpdates == null)
				{
					r_RSendUpdates = new(this, "SendUpdates", 0);
					r_RSendUpdates.SetBelong(this.instance);
				}
				return r_RSendUpdates;
			}
		}

		/// <summary>
		/// Void SendFullRange()
		/// </summary>
		protected RMethod r_RSendFullRange;
		public virtual RMethod RSendFullRange
		{
			get
			{
				if(r_RSendFullRange == null)
				{
					r_RSendFullRange = new(this, "SendFullRange", 0);
					r_RSendFullRange.SetBelong(this.instance);
				}
				return r_RSendFullRange;
			}
		}

		/// <summary>
		/// Void SendPartialRanges()
		/// </summary>
		protected RMethod r_RSendPartialRanges;
		public virtual RMethod RSendPartialRanges
		{
			get
			{
				if(r_RSendPartialRanges == null)
				{
					r_RSendPartialRanges = new(this, "SendPartialRanges", 0);
					r_RSendPartialRanges.SetBelong(this.instance);
				}
				return r_RSendPartialRanges;
			}
		}

		/// <summary>
		/// Void ResetUpdateState()
		/// </summary>
		protected RMethod r_RResetUpdateState;
		public virtual RMethod RResetUpdateState
		{
			get
			{
				if(r_RResetUpdateState == null)
				{
					r_RResetUpdateState = new(this, "ResetUpdateState", 0);
					r_RResetUpdateState.SetBelong(this.instance);
				}
				return r_RResetUpdateState;
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


        public virtual void RegisterUpdate(System.UInt32  @start, System.UInt32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @size};
            var ___result = RRegisterUpdate_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasMappedBufferRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasMappedBufferRange.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendUpdates()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendUpdates.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendFullRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendFullRange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPartialRanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendPartialRanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetUpdateState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetUpdateState.Invoke(___genericsType, ___parameters);

            
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
}