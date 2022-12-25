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
		protected RProperty r_isValid;
		public virtual RProperty RisValid
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
		protected RProperty r_enabled;
		public virtual RProperty Renabled
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
		protected RProperty r_elapsedNanoseconds;
		public virtual RProperty RelapsedNanoseconds
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
		protected RProperty r_gpuElapsedNanoseconds;
		public virtual RProperty RgpuElapsedNanoseconds
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
		protected RProperty r_sampleBlockCount;
		public virtual RProperty RsampleBlockCount
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
		protected RProperty r_gpuSampleBlockCount;
		public virtual RProperty RgpuSampleBlockCount
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
		/// UnityEngine.Profiling.Recorder Get(System.String)
		/// </summary>
		protected static RMethod r_RGet_String;
		public static RMethod RGet_String
		{
			get
			{
				if(r_RGet_String == null)
				{
					r_RGet_String = new(typeof(UnityEngine.Profiling.Recorder), "Get", 0, typeof(System.String));
					r_RGet_String.SetBelong(null);
				}
				return r_RGet_String;
			}
		}

		/// <summary>
		/// Void FilterToCurrentThread()
		/// </summary>
		protected RMethod r_RFilterToCurrentThread;
		public virtual RMethod RFilterToCurrentThread
		{
			get
			{
				if(r_RFilterToCurrentThread == null)
				{
					r_RFilterToCurrentThread = new(this, "FilterToCurrentThread", 0);
					r_RFilterToCurrentThread.SetBelong(this.instance);
				}
				return r_RFilterToCurrentThread;
			}
		}

		/// <summary>
		/// Void CollectFromAllThreads()
		/// </summary>
		protected RMethod r_RCollectFromAllThreads;
		public virtual RMethod RCollectFromAllThreads
		{
			get
			{
				if(r_RCollectFromAllThreads == null)
				{
					r_RCollectFromAllThreads = new(this, "CollectFromAllThreads", 0);
					r_RCollectFromAllThreads.SetBelong(this.instance);
				}
				return r_RCollectFromAllThreads;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_RSetEnabled_Boolean;
		public virtual RMethod RSetEnabled_Boolean
		{
			get
			{
				if(r_RSetEnabled_Boolean == null)
				{
					r_RSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_RSetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_RSetEnabled_Boolean;
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


        public static UnityEngine.Profiling.Recorder Get(System.String  @samplerName)
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


        public virtual void SetEnabled(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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
