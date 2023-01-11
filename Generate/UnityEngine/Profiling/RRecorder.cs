using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RProfiling
{
	/// <summary>
	/// UnityEngine.Profiling.Recorder
	/// </summary>
    public partial class RRecorder : RMember //
    {

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions
		/// </summary>
		protected static RField r_s_RecorderDefaultOptions;
		public static RField Rs_RecorderDefaultOptions
		{
			get
			{
				if(r_s_RecorderDefaultOptions == null)
				{
					r_s_RecorderDefaultOptions = new(typeof(UnityEngine.Profiling.Recorder), "s_RecorderDefaultOptions");
					r_s_RecorderDefaultOptions.SetBelong(null);
				}
				return r_s_RecorderDefaultOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.Recorder s_InvalidRecorder
		/// </summary>
		protected static RUnityEngine.RProfiling.RRecorder r_s_InvalidRecorder;
		public static RUnityEngine.RProfiling.RRecorder Rs_InvalidRecorder
		{
			get
			{
				if(r_s_InvalidRecorder == null)
				{
					r_s_InvalidRecorder = new(typeof(UnityEngine.Profiling.Recorder), "s_InvalidRecorder");
					r_s_InvalidRecorder.SetBelong(null);
				}
				return r_s_InvalidRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder m_RecorderCPU
		/// </summary>
		protected RUnity.RProfiling.RProfilerRecorder r_m_RecorderCPU;
		public virtual RUnity.RProfiling.RProfilerRecorder Rm_RecorderCPU
		{
			get
			{
				if(r_m_RecorderCPU == null)
				{
					r_m_RecorderCPU = new(this, "m_RecorderCPU");
					r_m_RecorderCPU.SetBelong(this.instance);
				}
				return r_m_RecorderCPU;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder m_RecorderGPU
		/// </summary>
		protected RUnity.RProfiling.RProfilerRecorder r_m_RecorderGPU;
		public virtual RUnity.RProfiling.RProfilerRecorder Rm_RecorderGPU
		{
			get
			{
				if(r_m_RecorderGPU == null)
				{
					r_m_RecorderGPU = new(this, "m_RecorderGPU");
					r_m_RecorderGPU.SetBelong(this.instance);
				}
				return r_m_RecorderGPU;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected RSystem.RBoolean r_isValid;
		public virtual RSystem.RBoolean RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid", -1);
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RSystem.RBoolean r_enabled;
		public virtual RSystem.RBoolean Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// Int64 elapsedNanoseconds
		/// </summary>
		protected RSystem.RInt64 r_elapsedNanoseconds;
		public virtual RSystem.RInt64 RelapsedNanoseconds
		{
			get
			{
				if(r_elapsedNanoseconds == null)
				{
					r_elapsedNanoseconds = new(this, "elapsedNanoseconds", -1);
					r_elapsedNanoseconds.SetBelong(this.instance);
				}
				return r_elapsedNanoseconds;
			}
		}

		/// <summary>
		/// Int64 gpuElapsedNanoseconds
		/// </summary>
		protected RSystem.RInt64 r_gpuElapsedNanoseconds;
		public virtual RSystem.RInt64 RgpuElapsedNanoseconds
		{
			get
			{
				if(r_gpuElapsedNanoseconds == null)
				{
					r_gpuElapsedNanoseconds = new(this, "gpuElapsedNanoseconds", -1);
					r_gpuElapsedNanoseconds.SetBelong(this.instance);
				}
				return r_gpuElapsedNanoseconds;
			}
		}

		/// <summary>
		/// Int32 sampleBlockCount
		/// </summary>
		protected RSystem.RInt32 r_sampleBlockCount;
		public virtual RSystem.RInt32 RsampleBlockCount
		{
			get
			{
				if(r_sampleBlockCount == null)
				{
					r_sampleBlockCount = new(this, "sampleBlockCount", -1);
					r_sampleBlockCount.SetBelong(this.instance);
				}
				return r_sampleBlockCount;
			}
		}

		/// <summary>
		/// Int32 gpuSampleBlockCount
		/// </summary>
		protected RSystem.RInt32 r_gpuSampleBlockCount;
		public virtual RSystem.RInt32 RgpuSampleBlockCount
		{
			get
			{
				if(r_gpuSampleBlockCount == null)
				{
					r_gpuSampleBlockCount = new(this, "gpuSampleBlockCount", -1);
					r_gpuSampleBlockCount.SetBelong(this.instance);
				}
				return r_gpuSampleBlockCount;
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
		/// UnityEngine.Profiling.Recorder Get(System.String)
		/// </summary>
		protected static RMethod r_Get_String;
		public static RMethod RGet_String
		{
			get
			{
				if(r_Get_String == null)
				{
					r_Get_String = new(typeof(UnityEngine.Profiling.Recorder), "Get", 0, typeof(System.String));
					r_Get_String.SetBelong(null);
				}
				return r_Get_String;
			}
		}

		/// <summary>
		/// Void FilterToCurrentThread()
		/// </summary>
		protected RMethod r_FilterToCurrentThread;
		public virtual RMethod RFilterToCurrentThread
		{
			get
			{
				if(r_FilterToCurrentThread == null)
				{
					r_FilterToCurrentThread = new(this, "FilterToCurrentThread", 0);
					r_FilterToCurrentThread.SetBelong(this.instance);
				}
				return r_FilterToCurrentThread;
			}
		}

		/// <summary>
		/// Void CollectFromAllThreads()
		/// </summary>
		protected RMethod r_CollectFromAllThreads;
		public virtual RMethod RCollectFromAllThreads
		{
			get
			{
				if(r_CollectFromAllThreads == null)
				{
					r_CollectFromAllThreads = new(this, "CollectFromAllThreads", 0);
					r_CollectFromAllThreads.SetBelong(this.instance);
				}
				return r_CollectFromAllThreads;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_SetEnabled_Boolean;
		public virtual RMethod RSetEnabled_Boolean
		{
			get
			{
				if(r_SetEnabled_Boolean == null)
				{
					r_SetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_SetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_SetEnabled_Boolean;
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


        public RRecorder() : base("UnityEngine.Profiling.Recorder")
        {
        }

        public RRecorder(System.Object instance) : base("UnityEngine.Profiling.Recorder")
		{
            SetInstance(instance);
		}

        public RRecorder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRecorder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Profiling.Recorder Get(System.String @samplerName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@samplerName};
            var ___result = RGet_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Profiling.Recorder)___result;
        }


        public virtual void FilterToCurrentThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFilterToCurrentThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CollectFromAllThreads()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCollectFromAllThreads.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEnabled(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
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
