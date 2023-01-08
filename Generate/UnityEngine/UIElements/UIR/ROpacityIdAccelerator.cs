using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.OpacityIdAccelerator
	/// </summary>
    public partial class ROpacityIdAccelerator : RMember //
    {

		/// <summary>
		/// System.Int32 k_VerticesPerBatch
		/// </summary>
		protected static RField r_k_VerticesPerBatch;
		public static RField Rk_VerticesPerBatch
		{
			get
			{
				if(r_k_VerticesPerBatch == null)
				{
					r_k_VerticesPerBatch = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.OpacityIdAccelerator"), "k_VerticesPerBatch");
					r_k_VerticesPerBatch.SetBelong(null);
				}
				return r_k_VerticesPerBatch;
			}
		}

		/// <summary>
		/// System.Int32 k_JobLimit
		/// </summary>
		protected static RField r_k_JobLimit;
		public static RField Rk_JobLimit
		{
			get
			{
				if(r_k_JobLimit == null)
				{
					r_k_JobLimit = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.OpacityIdAccelerator"), "k_JobLimit");
					r_k_JobLimit.SetBelong(null);
				}
				return r_k_JobLimit;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[Unity.Jobs.JobHandle] m_Jobs
		/// </summary>
		protected RField r_m_Jobs;
		public virtual RField Rm_Jobs
		{
			get
			{
				if(r_m_Jobs == null)
				{
					r_m_Jobs = new(this, "m_Jobs");
					r_m_Jobs.SetBelong(this.instance);
				}
				return r_m_Jobs;
			}
		}

		/// <summary>
		/// System.Int32 m_NextJobIndex
		/// </summary>
		protected RField r_m_NextJobIndex;
		public virtual RField Rm_NextJobIndex
		{
			get
			{
				if(r_m_NextJobIndex == null)
				{
					r_m_NextJobIndex = new(this, "m_NextJobIndex");
					r_m_NextJobIndex.SetBelong(this.instance);
				}
				return r_m_NextJobIndex;
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
		/// Void CreateJob(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], UnityEngine.Color32, Int32)
		/// </summary>
		protected RMethod r_CreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32;
		public virtual RMethod RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32
		{
			get
			{
				if(r_CreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32 == null)
				{
					r_CreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32 = new(this, "CreateJob", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(UnityEngine.Color32), typeof(System.Int32));
					r_CreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32.SetBelong(this.instance);
				}
				return r_CreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32;
			}
		}

		/// <summary>
		/// Void CompleteJobs()
		/// </summary>
		protected RMethod r_CompleteJobs;
		public virtual RMethod RCompleteJobs
		{
			get
			{
				if(r_CompleteJobs == null)
				{
					r_CompleteJobs = new(this, "CompleteJobs", 0);
					r_CompleteJobs.SetBelong(this.instance);
				}
				return r_CompleteJobs;
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


        public ROpacityIdAccelerator() : base("UnityEngine.UIElements.UIR.OpacityIdAccelerator")
        {
        }

        public ROpacityIdAccelerator(System.Object instance) : base("UnityEngine.UIElements.UIR.OpacityIdAccelerator")
		{
            SetInstance(instance);
		}

        public ROpacityIdAccelerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROpacityIdAccelerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual void CompleteJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteJobs.Invoke(___genericsType, ___parameters);

            
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
