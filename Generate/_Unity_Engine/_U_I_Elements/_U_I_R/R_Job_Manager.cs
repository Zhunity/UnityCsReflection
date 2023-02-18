
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.JobManager
	/// </summary>
    public partial class RJobManager : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.NativePagedList`1[UnityEngine.UIElements.UIR.NudgeJobData] m_NudgeJobs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNativePagedList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNudgeJobData> r_Fm_NudgeJobs;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNativePagedList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNudgeJobData> RFm_NudgeJobs
		{
			get
			{
				if(r_Fm_NudgeJobs == null)
				{
					r_Fm_NudgeJobs = new(this, "m_NudgeJobs");
				}
				return r_Fm_NudgeJobs;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.NativePagedList`1[UnityEngine.UIElements.UIR.ConvertMeshJobData] m_ConvertMeshJobs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNativePagedList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RConvertMeshJobData> r_Fm_ConvertMeshJobs;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNativePagedList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RConvertMeshJobData> RFm_ConvertMeshJobs
		{
			get
			{
				if(r_Fm_ConvertMeshJobs == null)
				{
					r_Fm_ConvertMeshJobs = new(this, "m_ConvertMeshJobs");
				}
				return r_Fm_ConvertMeshJobs;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.NativePagedList`1[UnityEngine.UIElements.UIR.CopyClosingMeshJobData] m_CopyClosingMeshJobs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNativePagedList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData> r_Fm_CopyClosingMeshJobs;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNativePagedList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData> RFm_CopyClosingMeshJobs
		{
			get
			{
				if(r_Fm_CopyClosingMeshJobs == null)
				{
					r_Fm_CopyClosingMeshJobs = new(this, "m_CopyClosingMeshJobs");
				}
				return r_Fm_CopyClosingMeshJobs;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobMerger m_JobMerger
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RJobMerger r_Fm_JobMerger;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RJobMerger RFm_JobMerger
		{
			get
			{
				if(r_Fm_JobMerger == null)
				{
					r_Fm_JobMerger = new(this, "m_JobMerger");
				}
				return r_Fm_JobMerger;
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
		/// Void Add(UnityEngine.UIElements.UIR.NudgeJobData ByRef)
		/// </summary>
		protected RMethod r_MAdd_Ref_NudgeJobData;
		public virtual RMethod RMAdd_Ref_NudgeJobData
		{
			get
			{
				if(r_MAdd_Ref_NudgeJobData == null)
				{
					r_MAdd_Ref_NudgeJobData = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.NudgeJobData").MakeByRefType());
				}
				return r_MAdd_Ref_NudgeJobData;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.UIR.ConvertMeshJobData ByRef)
		/// </summary>
		protected RMethod r_MAdd_Ref_ConvertMeshJobData;
		public virtual RMethod RMAdd_Ref_ConvertMeshJobData
		{
			get
			{
				if(r_MAdd_Ref_ConvertMeshJobData == null)
				{
					r_MAdd_Ref_ConvertMeshJobData = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.ConvertMeshJobData").MakeByRefType());
				}
				return r_MAdd_Ref_ConvertMeshJobData;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.UIR.CopyClosingMeshJobData ByRef)
		/// </summary>
		protected RMethod r_MAdd_Ref_CopyClosingMeshJobData;
		public virtual RMethod RMAdd_Ref_CopyClosingMeshJobData
		{
			get
			{
				if(r_MAdd_Ref_CopyClosingMeshJobData == null)
				{
					r_MAdd_Ref_CopyClosingMeshJobData = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.CopyClosingMeshJobData").MakeByRefType());
				}
				return r_MAdd_Ref_CopyClosingMeshJobData;
			}
		}

		/// <summary>
		/// Void CompleteNudgeJobs()
		/// </summary>
		protected RMethod r_MCompleteNudgeJobs;
		public virtual RMethod RMCompleteNudgeJobs
		{
			get
			{
				if(r_MCompleteNudgeJobs == null)
				{
					r_MCompleteNudgeJobs = new(this, "CompleteNudgeJobs", 0);
				}
				return r_MCompleteNudgeJobs;
			}
		}

		/// <summary>
		/// Void CompleteConvertMeshJobs()
		/// </summary>
		protected RMethod r_MCompleteConvertMeshJobs;
		public virtual RMethod RMCompleteConvertMeshJobs
		{
			get
			{
				if(r_MCompleteConvertMeshJobs == null)
				{
					r_MCompleteConvertMeshJobs = new(this, "CompleteConvertMeshJobs", 0);
				}
				return r_MCompleteConvertMeshJobs;
			}
		}

		/// <summary>
		/// Void CompleteClosingMeshJobs()
		/// </summary>
		protected RMethod r_MCompleteClosingMeshJobs;
		public virtual RMethod RMCompleteClosingMeshJobs
		{
			get
			{
				if(r_MCompleteClosingMeshJobs == null)
				{
					r_MCompleteClosingMeshJobs = new(this, "CompleteClosingMeshJobs", 0);
				}
				return r_MCompleteClosingMeshJobs;
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


        public RJobManager() : base("UnityEngine.UIElements.UIR.JobManager")
        {
        }

        public RJobManager(System.Object instance) : base("UnityEngine.UIElements.UIR.JobManager")
		{
            SetInstance(instance);
		}

        public RJobManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RJobManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNudgeJobData @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job.Value};
            var ___result = RMAdd_Ref_NudgeJobData.Invoke(___genericsType, ___parameters);
			@job = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RNudgeJobData(___parameters[0]);

            
        }


        public virtual void Add(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RConvertMeshJobData @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job.Value};
            var ___result = RMAdd_Ref_ConvertMeshJobData.Invoke(___genericsType, ___parameters);
			@job = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RConvertMeshJobData(___parameters[0]);

            
        }


        public virtual void Add(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job.Value};
            var ___result = RMAdd_Ref_CopyClosingMeshJobData.Invoke(___genericsType, ___parameters);
			@job = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData(___parameters[0]);

            
        }


        public virtual void CompleteNudgeJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCompleteNudgeJobs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteConvertMeshJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCompleteConvertMeshJobs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteClosingMeshJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCompleteClosingMeshJobs.Invoke(___genericsType, ___parameters);

            
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
