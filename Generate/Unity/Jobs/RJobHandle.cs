using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RJobs
{
	/// <summary>
	/// Unity.Jobs.JobHandle
	/// </summary>
    public partial class RJobHandle : RMember //
    {

		/// <summary>
		/// System.UInt64 jobGroup
		/// </summary>
		protected RField r_jobGroup;
		public virtual RField RjobGroup
		{
			get
			{
				if(r_jobGroup == null)
				{
					r_jobGroup = new(this, "jobGroup");
					r_jobGroup.SetBelong(this.instance);
				}
				return r_jobGroup;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected RField r_version;
		public virtual RField Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.Int32 debugVersion
		/// </summary>
		protected RField r_debugVersion;
		public virtual RField RdebugVersion
		{
			get
			{
				if(r_debugVersion == null)
				{
					r_debugVersion = new(this, "debugVersion");
					r_debugVersion.SetBelong(this.instance);
				}
				return r_debugVersion;
			}
		}

		/// <summary>
		/// System.IntPtr debugInfo
		/// </summary>
		protected RField r_debugInfo;
		public virtual RField RdebugInfo
		{
			get
			{
				if(r_debugInfo == null)
				{
					r_debugInfo = new(this, "debugInfo");
					r_debugInfo.SetBelong(this.instance);
				}
				return r_debugInfo;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RProperty r_IsCompleted;
		public virtual RProperty RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// Void Complete()
		/// </summary>
		protected RMethod r_Complete;
		public virtual RMethod RComplete
		{
			get
			{
				if(r_Complete == null)
				{
					r_Complete = new(this, "Complete", 0);
					r_Complete.SetBelong(this.instance);
				}
				return r_Complete;
			}
		}

		/// <summary>
		/// Void CompleteAll(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CompleteAll_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RCompleteAll_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_CompleteAll_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_CompleteAll_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CompleteAll", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CompleteAll_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_CompleteAll_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Void CompleteAll(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_CompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_CompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CompleteAll", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_CompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Void CompleteAll(Unity.Collections.NativeArray`1[Unity.Jobs.JobHandle])
		/// </summary>
		protected static RMethod r_CompleteAll_NativeArray_d_JobHandle_p_;
		public static RMethod RCompleteAll_NativeArray_d_JobHandle_p_
		{
			get
			{
				if(r_CompleteAll_NativeArray_d_JobHandle_p_ == null)
				{
					r_CompleteAll_NativeArray_d_JobHandle_p_ = new(typeof(Unity.Jobs.JobHandle), "CompleteAll", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(Unity.Jobs.JobHandle)));
					r_CompleteAll_NativeArray_d_JobHandle_p_.SetBelong(null);
				}
				return r_CompleteAll_NativeArray_d_JobHandle_p_;
			}
		}

		/// <summary>
		/// Void ScheduleBatchedJobs()
		/// </summary>
		protected static RMethod r_ScheduleBatchedJobs;
		public static RMethod RScheduleBatchedJobs
		{
			get
			{
				if(r_ScheduleBatchedJobs == null)
				{
					r_ScheduleBatchedJobs = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobs", 0);
					r_ScheduleBatchedJobs.SetBelong(null);
				}
				return r_ScheduleBatchedJobs;
			}
		}

		/// <summary>
		/// Void ScheduleBatchedJobsAndComplete(Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_ScheduleBatchedJobsAndComplete_Ref_JobHandle;
		public static RMethod RScheduleBatchedJobsAndComplete_Ref_JobHandle
		{
			get
			{
				if(r_ScheduleBatchedJobsAndComplete_Ref_JobHandle == null)
				{
					r_ScheduleBatchedJobsAndComplete_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobsAndComplete", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_ScheduleBatchedJobsAndComplete_Ref_JobHandle.SetBelong(null);
				}
				return r_ScheduleBatchedJobsAndComplete_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Boolean ScheduleBatchedJobsAndIsCompleted(Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_ScheduleBatchedJobsAndIsCompleted_Ref_JobHandle;
		public static RMethod RScheduleBatchedJobsAndIsCompleted_Ref_JobHandle
		{
			get
			{
				if(r_ScheduleBatchedJobsAndIsCompleted_Ref_JobHandle == null)
				{
					r_ScheduleBatchedJobsAndIsCompleted_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobsAndIsCompleted", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_ScheduleBatchedJobsAndIsCompleted_Ref_JobHandle.SetBelong(null);
				}
				return r_ScheduleBatchedJobsAndIsCompleted_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Void ScheduleBatchedJobsAndCompleteAll(Void*, Int32)
		/// </summary>
		protected static RMethod r_ScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32;
		public static RMethod RScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32
		{
			get
			{
				if(r_ScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32 == null)
				{
					r_ScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32 = new(typeof(Unity.Jobs.JobHandle), "ScheduleBatchedJobsAndCompleteAll", 0, typeof(void).MakePointerType(), typeof(System.Int32));
					r_ScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32.SetBelong(null);
				}
				return r_ScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_CombineDependencies_JobHandle_JobHandle;
		public static RMethod RCombineDependencies_JobHandle_JobHandle
		{
			get
			{
				if(r_CombineDependencies_JobHandle_JobHandle == null)
				{
					r_CombineDependencies_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_CombineDependencies_JobHandle_JobHandle.SetBelong(null);
				}
				return r_CombineDependencies_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_CombineDependencies_JobHandle_JobHandle_JobHandle;
		public static RMethod RCombineDependencies_JobHandle_JobHandle_JobHandle
		{
			get
			{
				if(r_CombineDependencies_JobHandle_JobHandle_JobHandle == null)
				{
					r_CombineDependencies_JobHandle_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_CombineDependencies_JobHandle_JobHandle_JobHandle.SetBelong(null);
				}
				return r_CombineDependencies_JobHandle_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray`1[Unity.Jobs.JobHandle])
		/// </summary>
		protected static RMethod r_CombineDependencies_NativeArray_d_JobHandle_p_;
		public static RMethod RCombineDependencies_NativeArray_d_JobHandle_p_
		{
			get
			{
				if(r_CombineDependencies_NativeArray_d_JobHandle_p_ == null)
				{
					r_CombineDependencies_NativeArray_d_JobHandle_p_ = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(Unity.Jobs.JobHandle)));
					r_CombineDependencies_NativeArray_d_JobHandle_p_.SetBelong(null);
				}
				return r_CombineDependencies_NativeArray_d_JobHandle_p_;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice`1[Unity.Jobs.JobHandle])
		/// </summary>
		protected static RMethod r_CombineDependencies_NativeSlice_d_JobHandle_p_;
		public static RMethod RCombineDependencies_NativeSlice_d_JobHandle_p_
		{
			get
			{
				if(r_CombineDependencies_NativeSlice_d_JobHandle_p_ == null)
				{
					r_CombineDependencies_NativeSlice_d_JobHandle_p_ = new(typeof(Unity.Jobs.JobHandle), "CombineDependencies", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(Unity.Jobs.JobHandle)));
					r_CombineDependencies_NativeSlice_d_JobHandle_p_.SetBelong(null);
				}
				return r_CombineDependencies_NativeSlice_d_JobHandle_p_;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependenciesInternal2(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_CombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_CombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal2", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_CombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependenciesInternal3(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_CombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_CombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal3", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_CombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle;
			}
		}

		/// <summary>
		/// Unity.Jobs.JobHandle CombineDependenciesInternalPtr(Void*, Int32)
		/// </summary>
		protected static RMethod r_CombineDependenciesInternalPtr_VoidPointer_Int32;
		public static RMethod RCombineDependenciesInternalPtr_VoidPointer_Int32
		{
			get
			{
				if(r_CombineDependenciesInternalPtr_VoidPointer_Int32 == null)
				{
					r_CombineDependenciesInternalPtr_VoidPointer_Int32 = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternalPtr", 0, typeof(void).MakePointerType(), typeof(System.Int32));
					r_CombineDependenciesInternalPtr_VoidPointer_Int32.SetBelong(null);
				}
				return r_CombineDependenciesInternalPtr_VoidPointer_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckFenceIsDependencyOrDidSyncFence(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_CheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle;
		public static RMethod RCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle
		{
			get
			{
				if(r_CheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle == null)
				{
					r_CheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CheckFenceIsDependencyOrDidSyncFence", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_CheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle.SetBelong(null);
				}
				return r_CheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Boolean Equals(Unity.Jobs.JobHandle)
		/// </summary>
		protected RMethod r_Equals_JobHandle;
		public virtual RMethod REquals_JobHandle
		{
			get
			{
				if(r_Equals_JobHandle == null)
				{
					r_Equals_JobHandle = new(this, "Equals", 0, typeof(Unity.Jobs.JobHandle));
					r_Equals_JobHandle.SetBelong(this.instance);
				}
				return r_Equals_JobHandle;
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
		/// Boolean op_Equality(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_op_Equality_JobHandle_JobHandle;
		public static RMethod Rop_Equality_JobHandle_JobHandle
		{
			get
			{
				if(r_op_Equality_JobHandle_JobHandle == null)
				{
					r_op_Equality_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "op_Equality", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_op_Equality_JobHandle_JobHandle.SetBelong(null);
				}
				return r_op_Equality_JobHandle_JobHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Unity.Jobs.JobHandle, Unity.Jobs.JobHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_JobHandle_JobHandle;
		public static RMethod Rop_Inequality_JobHandle_JobHandle
		{
			get
			{
				if(r_op_Inequality_JobHandle_JobHandle == null)
				{
					r_op_Inequality_JobHandle_JobHandle = new(typeof(Unity.Jobs.JobHandle), "op_Inequality", 0, typeof(Unity.Jobs.JobHandle), typeof(Unity.Jobs.JobHandle));
					r_op_Inequality_JobHandle_JobHandle.SetBelong(null);
				}
				return r_op_Inequality_JobHandle_JobHandle;
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
		/// Void CombineDependenciesInternal2_Injected(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
		public static RMethod RCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle
		{
			get
			{
				if(r_CombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle == null)
				{
					r_CombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal2_Injected", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.SetBelong(null);
				}
				return r_CombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
			}
		}

		/// <summary>
		/// Void CombineDependenciesInternal3_Injected(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
		public static RMethod RCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle
		{
			get
			{
				if(r_CombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle == null)
				{
					r_CombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternal3_Injected", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.SetBelong(null);
				}
				return r_CombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle;
			}
		}

		/// <summary>
		/// Void CombineDependenciesInternalPtr_Injected(Void*, Int32, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle;
		public static RMethod RCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle
		{
			get
			{
				if(r_CombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle == null)
				{
					r_CombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CombineDependenciesInternalPtr_Injected", 0, typeof(void).MakePointerType(), typeof(System.Int32), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle.SetBelong(null);
				}
				return r_CombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle;
			}
		}

		/// <summary>
		/// Boolean CheckFenceIsDependencyOrDidSyncFence_Injected(Unity.Jobs.JobHandle ByRef, Unity.Jobs.JobHandle ByRef)
		/// </summary>
		protected static RMethod r_CheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle;
		public static RMethod RCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle
		{
			get
			{
				if(r_CheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle == null)
				{
					r_CheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle = new(typeof(Unity.Jobs.JobHandle), "CheckFenceIsDependencyOrDidSyncFence_Injected", 0, typeof(Unity.Jobs.JobHandle).MakeByRefType(), typeof(Unity.Jobs.JobHandle).MakeByRefType());
					r_CheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle.SetBelong(null);
				}
				return r_CheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle;
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


        public RJobHandle() : base("Unity.Jobs.JobHandle")
        {
        }

        public RJobHandle(System.Object instance) : base("Unity.Jobs.JobHandle")
		{
            SetInstance(instance);
		}

        public RJobHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RJobHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Complete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RComplete.Invoke(___genericsType, ___parameters);

            
        }


        public static void CompleteAll(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1};
            var ___result = RCompleteAll_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];

            
        }


        public static void CompleteAll(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, ref Unity.Jobs.JobHandle @job2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2};
            var ___result = RCompleteAll_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@job2 = (Unity.Jobs.JobHandle)___parameters[2];

            
        }



        public static void ScheduleBatchedJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScheduleBatchedJobs.Invoke(___genericsType, ___parameters);

            
        }


        public static void ScheduleBatchedJobsAndComplete(ref Unity.Jobs.JobHandle @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job};
            var ___result = RScheduleBatchedJobsAndComplete_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job = (Unity.Jobs.JobHandle)___parameters[0];

            
        }


        public static System.Boolean ScheduleBatchedJobsAndIsCompleted(ref Unity.Jobs.JobHandle @job)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job};
            var ___result = RScheduleBatchedJobsAndIsCompleted_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job = (Unity.Jobs.JobHandle)___parameters[0];

            return (System.Boolean)___result;
        }


        public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* @jobs, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@jobs, typeof(void)), @count};
            var ___result = RScheduleBatchedJobsAndCompleteAll_VoidPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle @job0, Unity.Jobs.JobHandle @job1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1};
            var ___result = RCombineDependencies_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle @job0, Unity.Jobs.JobHandle @job1, Unity.Jobs.JobHandle @job2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2};
            var ___result = RCombineDependencies_JobHandle_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }




        public static Unity.Jobs.JobHandle CombineDependenciesInternal2(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1};
            var ___result = RCombineDependenciesInternal2_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];

            return (Unity.Jobs.JobHandle)___result;
        }


        public static Unity.Jobs.JobHandle CombineDependenciesInternal3(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, ref Unity.Jobs.JobHandle @job2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2};
            var ___result = RCombineDependenciesInternal3_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@job2 = (Unity.Jobs.JobHandle)___parameters[2];

            return (Unity.Jobs.JobHandle)___result;
        }


        public unsafe static Unity.Jobs.JobHandle CombineDependenciesInternalPtr(void* @jobs, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@jobs, typeof(void)), @count};
            var ___result = RCombineDependenciesInternalPtr_VoidPointer_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Jobs.JobHandle)___result;
        }


        public static System.Boolean CheckFenceIsDependencyOrDidSyncFence(Unity.Jobs.JobHandle @jobHandle, Unity.Jobs.JobHandle @dependsOn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobHandle, @dependsOn};
            var ___result = RCheckFenceIsDependencyOrDidSyncFence_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Unity.Jobs.JobHandle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(Unity.Jobs.JobHandle @a, Unity.Jobs.JobHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Unity.Jobs.JobHandle @a, Unity.Jobs.JobHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_JobHandle_JobHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void CombineDependenciesInternal2_Injected(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @ret};
            var ___result = RCombineDependenciesInternal2_Injected_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@ret = (Unity.Jobs.JobHandle)___parameters[2];

            
        }


        public static void CombineDependenciesInternal3_Injected(ref Unity.Jobs.JobHandle @job0, ref Unity.Jobs.JobHandle @job1, ref Unity.Jobs.JobHandle @job2, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@job0, @job1, @job2, @ret};
            var ___result = RCombineDependenciesInternal3_Injected_Ref_JobHandle_Ref_JobHandle_Ref_JobHandle_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@job0 = (Unity.Jobs.JobHandle)___parameters[0];
			@job1 = (Unity.Jobs.JobHandle)___parameters[1];
			@job2 = (Unity.Jobs.JobHandle)___parameters[2];
			@ret = (Unity.Jobs.JobHandle)___parameters[3];

            
        }


        public unsafe static void CombineDependenciesInternalPtr_Injected(void* @jobs, System.Int32 @count, out Unity.Jobs.JobHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@jobs, typeof(void)), @count, @ret};
            var ___result = RCombineDependenciesInternalPtr_Injected_VoidPointer_Int32_Out_JobHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Jobs.JobHandle)___parameters[2];

            
        }


        public static System.Boolean CheckFenceIsDependencyOrDidSyncFence_Injected(ref Unity.Jobs.JobHandle @jobHandle, ref Unity.Jobs.JobHandle @dependsOn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@jobHandle, @dependsOn};
            var ___result = RCheckFenceIsDependencyOrDidSyncFence_Injected_Ref_JobHandle_Ref_JobHandle.Invoke(___genericsType, ___parameters);
			@jobHandle = (Unity.Jobs.JobHandle)___parameters[0];
			@dependsOn = (Unity.Jobs.JobHandle)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
