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
		protected RMethod r_RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32;
		public virtual RMethod RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32
		{
			get
			{
				if(r_RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32 == null)
				{
					r_RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32 = new(this, "CreateJob", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(UnityEngine.Color32), typeof(System.Int32));
					r_RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32.SetBelong(this.instance);
				}
				return r_RCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32;
			}
		}

		/// <summary>
		/// Void CompleteJobs()
		/// </summary>
		protected RMethod r_RCompleteJobs;
		public virtual RMethod RCompleteJobs
		{
			get
			{
				if(r_RCompleteJobs == null)
				{
					r_RCompleteJobs = new(this, "CompleteJobs", 0);
					r_RCompleteJobs.SetBelong(this.instance);
				}
				return r_RCompleteJobs;
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