using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.JobManager
	/// </summary>
    public partial class RJobManager : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.NativePagedList`1[UnityEngine.UIElements.UIR.NudgeJobData] m_NudgeJobs
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RNativePagedList<RUnityEngine.RUIElements.RUIR.RNudgeJobData> r_m_NudgeJobs;
		public virtual RUnityEngine.RUIElements.RUIR.RNativePagedList<RUnityEngine.RUIElements.RUIR.RNudgeJobData> Rm_NudgeJobs
		{
			get
			{
				if(r_m_NudgeJobs == null)
				{
					r_m_NudgeJobs = new(this, "m_NudgeJobs");
					r_m_NudgeJobs.SetBelong(this.instance);
				}
				return r_m_NudgeJobs;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.NativePagedList`1[UnityEngine.UIElements.UIR.ConvertMeshJobData] m_ConvertMeshJobs
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RNativePagedList<RUnityEngine.RUIElements.RUIR.RConvertMeshJobData> r_m_ConvertMeshJobs;
		public virtual RUnityEngine.RUIElements.RUIR.RNativePagedList<RUnityEngine.RUIElements.RUIR.RConvertMeshJobData> Rm_ConvertMeshJobs
		{
			get
			{
				if(r_m_ConvertMeshJobs == null)
				{
					r_m_ConvertMeshJobs = new(this, "m_ConvertMeshJobs");
					r_m_ConvertMeshJobs.SetBelong(this.instance);
				}
				return r_m_ConvertMeshJobs;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.NativePagedList`1[UnityEngine.UIElements.UIR.CopyClosingMeshJobData] m_CopyClosingMeshJobs
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RNativePagedList<RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData> r_m_CopyClosingMeshJobs;
		public virtual RUnityEngine.RUIElements.RUIR.RNativePagedList<RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData> Rm_CopyClosingMeshJobs
		{
			get
			{
				if(r_m_CopyClosingMeshJobs == null)
				{
					r_m_CopyClosingMeshJobs = new(this, "m_CopyClosingMeshJobs");
					r_m_CopyClosingMeshJobs.SetBelong(this.instance);
				}
				return r_m_CopyClosingMeshJobs;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobMerger m_JobMerger
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RJobMerger r_m_JobMerger;
		public virtual RUnityEngine.RUIElements.RUIR.RJobMerger Rm_JobMerger
		{
			get
			{
				if(r_m_JobMerger == null)
				{
					r_m_JobMerger = new(this, "m_JobMerger");
					r_m_JobMerger.SetBelong(this.instance);
				}
				return r_m_JobMerger;
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
		/// Void Add(UnityEngine.UIElements.UIR.NudgeJobData ByRef)
		/// </summary>
		protected RMethod r_Add_Ref_NudgeJobData;
		public virtual RMethod RAdd_Ref_NudgeJobData
		{
			get
			{
				if(r_Add_Ref_NudgeJobData == null)
				{
					r_Add_Ref_NudgeJobData = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.NudgeJobData").MakeByRefType());
					r_Add_Ref_NudgeJobData.SetBelong(this.instance);
				}
				return r_Add_Ref_NudgeJobData;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.UIR.ConvertMeshJobData ByRef)
		/// </summary>
		protected RMethod r_Add_Ref_ConvertMeshJobData;
		public virtual RMethod RAdd_Ref_ConvertMeshJobData
		{
			get
			{
				if(r_Add_Ref_ConvertMeshJobData == null)
				{
					r_Add_Ref_ConvertMeshJobData = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.ConvertMeshJobData").MakeByRefType());
					r_Add_Ref_ConvertMeshJobData.SetBelong(this.instance);
				}
				return r_Add_Ref_ConvertMeshJobData;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.UIR.CopyClosingMeshJobData ByRef)
		/// </summary>
		protected RMethod r_Add_Ref_CopyClosingMeshJobData;
		public virtual RMethod RAdd_Ref_CopyClosingMeshJobData
		{
			get
			{
				if(r_Add_Ref_CopyClosingMeshJobData == null)
				{
					r_Add_Ref_CopyClosingMeshJobData = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.CopyClosingMeshJobData").MakeByRefType());
					r_Add_Ref_CopyClosingMeshJobData.SetBelong(this.instance);
				}
				return r_Add_Ref_CopyClosingMeshJobData;
			}
		}

		/// <summary>
		/// Void CompleteNudgeJobs()
		/// </summary>
		protected RMethod r_CompleteNudgeJobs;
		public virtual RMethod RCompleteNudgeJobs
		{
			get
			{
				if(r_CompleteNudgeJobs == null)
				{
					r_CompleteNudgeJobs = new(this, "CompleteNudgeJobs", 0);
					r_CompleteNudgeJobs.SetBelong(this.instance);
				}
				return r_CompleteNudgeJobs;
			}
		}

		/// <summary>
		/// Void CompleteConvertMeshJobs()
		/// </summary>
		protected RMethod r_CompleteConvertMeshJobs;
		public virtual RMethod RCompleteConvertMeshJobs
		{
			get
			{
				if(r_CompleteConvertMeshJobs == null)
				{
					r_CompleteConvertMeshJobs = new(this, "CompleteConvertMeshJobs", 0);
					r_CompleteConvertMeshJobs.SetBelong(this.instance);
				}
				return r_CompleteConvertMeshJobs;
			}
		}

		/// <summary>
		/// Void CompleteClosingMeshJobs()
		/// </summary>
		protected RMethod r_CompleteClosingMeshJobs;
		public virtual RMethod RCompleteClosingMeshJobs
		{
			get
			{
				if(r_CompleteClosingMeshJobs == null)
				{
					r_CompleteClosingMeshJobs = new(this, "CompleteClosingMeshJobs", 0);
					r_CompleteClosingMeshJobs.SetBelong(this.instance);
				}
				return r_CompleteClosingMeshJobs;
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

        public virtual void Add(ref RUnityEngine.RUIElements.RUIR.RNudgeJobData  @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job.Value};
            var ___result = RAdd_Ref_NudgeJobData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(ref RUnityEngine.RUIElements.RUIR.RConvertMeshJobData  @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job.Value};
            var ___result = RAdd_Ref_ConvertMeshJobData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(ref RUnityEngine.RUIElements.RUIR.RCopyClosingMeshJobData  @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job.Value};
            var ___result = RAdd_Ref_CopyClosingMeshJobData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteNudgeJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteNudgeJobs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteConvertMeshJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteConvertMeshJobs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteClosingMeshJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteClosingMeshJobs.Invoke(___genericsType, ___parameters);

            
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
