
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RProfiling
{
	/// <summary>
	/// UnityEngine.Profiling.Recorder
	/// </summary>
    public partial class RRecorder : RMember //
    {

		/// <summary>
		/// Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorderOptions r_Fs_RecorderDefaultOptions;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorderOptions RFs_RecorderDefaultOptions
		{
			get
			{
				if(r_Fs_RecorderDefaultOptions == null)
				{
					r_Fs_RecorderDefaultOptions = new(typeof(UnityEngine.Profiling.Recorder), "s_RecorderDefaultOptions");
					r_Fs_RecorderDefaultOptions.SetBelong(null);
				}
				return r_Fs_RecorderDefaultOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.Recorder s_InvalidRecorder
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RProfiling.RRecorder r_Fs_InvalidRecorder;
		public static Hvak.Editor.Refleaction.RUnityEngine.RProfiling.RRecorder RFs_InvalidRecorder
		{
			get
			{
				if(r_Fs_InvalidRecorder == null)
				{
					r_Fs_InvalidRecorder = new(typeof(UnityEngine.Profiling.Recorder), "s_InvalidRecorder");
					r_Fs_InvalidRecorder.SetBelong(null);
				}
				return r_Fs_InvalidRecorder;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder m_RecorderCPU
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder r_Fm_RecorderCPU;
		public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder RFm_RecorderCPU
		{
			get
			{
				if(r_Fm_RecorderCPU == null)
				{
					r_Fm_RecorderCPU = new(this, "m_RecorderCPU");
					r_Fm_RecorderCPU.SetBelong(this.instance);
				}
				return r_Fm_RecorderCPU;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerRecorder m_RecorderGPU
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder r_Fm_RecorderGPU;
		public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerRecorder RFm_RecorderGPU
		{
			get
			{
				if(r_Fm_RecorderGPU == null)
				{
					r_Fm_RecorderGPU = new(this, "m_RecorderGPU");
					r_Fm_RecorderGPU.SetBelong(this.instance);
				}
				return r_Fm_RecorderGPU;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
					r_PisValid.SetBelong(this.instance);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
					r_Penabled.SetBelong(this.instance);
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Int64 elapsedNanoseconds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PelapsedNanoseconds;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPelapsedNanoseconds
		{
			get
			{
				if(r_PelapsedNanoseconds == null)
				{
					r_PelapsedNanoseconds = new(this, "elapsedNanoseconds", -1);
					r_PelapsedNanoseconds.SetBelong(this.instance);
				}
				return r_PelapsedNanoseconds;
			}
		}

		/// <summary>
		/// Int64 gpuElapsedNanoseconds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PgpuElapsedNanoseconds;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPgpuElapsedNanoseconds
		{
			get
			{
				if(r_PgpuElapsedNanoseconds == null)
				{
					r_PgpuElapsedNanoseconds = new(this, "gpuElapsedNanoseconds", -1);
					r_PgpuElapsedNanoseconds.SetBelong(this.instance);
				}
				return r_PgpuElapsedNanoseconds;
			}
		}

		/// <summary>
		/// Int32 sampleBlockCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsampleBlockCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsampleBlockCount
		{
			get
			{
				if(r_PsampleBlockCount == null)
				{
					r_PsampleBlockCount = new(this, "sampleBlockCount", -1);
					r_PsampleBlockCount.SetBelong(this.instance);
				}
				return r_PsampleBlockCount;
			}
		}

		/// <summary>
		/// Int32 gpuSampleBlockCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PgpuSampleBlockCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPgpuSampleBlockCount
		{
			get
			{
				if(r_PgpuSampleBlockCount == null)
				{
					r_PgpuSampleBlockCount = new(this, "gpuSampleBlockCount", -1);
					r_PgpuSampleBlockCount.SetBelong(this.instance);
				}
				return r_PgpuSampleBlockCount;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.Recorder Get(System.String)
		/// </summary>
		protected static RMethod r_MGet_String;
		public static RMethod RMGet_String
		{
			get
			{
				if(r_MGet_String == null)
				{
					r_MGet_String = new(typeof(UnityEngine.Profiling.Recorder), "Get", 0, typeof(System.String));
					r_MGet_String.SetBelong(null);
				}
				return r_MGet_String;
			}
		}

		/// <summary>
		/// Void FilterToCurrentThread()
		/// </summary>
		protected RMethod r_MFilterToCurrentThread;
		public virtual RMethod RMFilterToCurrentThread
		{
			get
			{
				if(r_MFilterToCurrentThread == null)
				{
					r_MFilterToCurrentThread = new(this, "FilterToCurrentThread", 0);
					r_MFilterToCurrentThread.SetBelong(this.instance);
				}
				return r_MFilterToCurrentThread;
			}
		}

		/// <summary>
		/// Void CollectFromAllThreads()
		/// </summary>
		protected RMethod r_MCollectFromAllThreads;
		public virtual RMethod RMCollectFromAllThreads
		{
			get
			{
				if(r_MCollectFromAllThreads == null)
				{
					r_MCollectFromAllThreads = new(this, "CollectFromAllThreads", 0);
					r_MCollectFromAllThreads.SetBelong(this.instance);
				}
				return r_MCollectFromAllThreads;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabled_Boolean;
		public virtual RMethod RMSetEnabled_Boolean
		{
			get
			{
				if(r_MSetEnabled_Boolean == null)
				{
					r_MSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_MSetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabled_Boolean;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Profiling.Recorder Get(System.String @samplerName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@samplerName};
            var ___result = RMGet_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Profiling.Recorder)___result;
        }


        public virtual void FilterToCurrentThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFilterToCurrentThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CollectFromAllThreads()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCollectFromAllThreads.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEnabled(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
