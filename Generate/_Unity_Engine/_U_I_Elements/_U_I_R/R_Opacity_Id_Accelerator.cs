
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.OpacityIdAccelerator
	/// </summary>
    public partial class ROpacityIdAccelerator : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.OpacityIdAccelerator");
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


		/// <summary>
		/// System.Int32 k_VerticesPerBatch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_VerticesPerBatch;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_VerticesPerBatch
		{
			get
			{
				if(r_Fk_VerticesPerBatch == null)
				{
					r_Fk_VerticesPerBatch = new(Type, "k_VerticesPerBatch");
				}
				return r_Fk_VerticesPerBatch;
			}
		}

		/// <summary>
		/// System.Int32 k_JobLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_JobLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_JobLimit
		{
			get
			{
				if(r_Fk_JobLimit == null)
				{
					r_Fk_JobLimit = new(Type, "k_JobLimit");
				}
				return r_Fk_JobLimit;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[Unity.Jobs.JobHandle] m_Jobs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnity.RJobs.RJobHandle> r_Fm_Jobs;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnity.RJobs.RJobHandle> RFm_Jobs
		{
			get
			{
				if(r_Fm_Jobs == null)
				{
					r_Fm_Jobs = new(this, "m_Jobs");
				}
				return r_Fm_Jobs;
			}
		}

		/// <summary>
		/// System.Int32 m_NextJobIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NextJobIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NextJobIndex
		{
			get
			{
				if(r_Fm_NextJobIndex == null)
				{
					r_Fm_NextJobIndex = new(this, "m_NextJobIndex");
				}
				return r_Fm_NextJobIndex;
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
		/// Void CreateJob(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], UnityEngine.Color32, Int32)
		/// </summary>
		protected RMethod r_MCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32;
		public virtual RMethod RMCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32
		{
			get
			{
				if(r_MCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32 == null)
				{
					r_MCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32 = new(this, "CreateJob", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(UnityEngine.UIElements.Vertex)),  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(UnityEngine.Color32), typeof(System.Int32));
				}
				return r_MCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32;
			}
		}

		/// <summary>
		/// Void CompleteJobs()
		/// </summary>
		protected RMethod r_MCompleteJobs;
		public virtual RMethod RMCompleteJobs
		{
			get
			{
				if(r_MCompleteJobs == null)
				{
					r_MCompleteJobs = new(this, "CompleteJobs", 0);
				}
				return r_MCompleteJobs;
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


        public virtual void CreateJob(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> @oldVerts, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> @newVerts, UnityEngine.Color32 @opacityData, System.Int32 @vertexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldVerts.Value, @newVerts.Value, @opacityData, @vertexCount};
            var ___result = RMCreateJob_NativeSlice_d_Vertex_p__NativeSlice_d_Vertex_p__Color32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteJobs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCompleteJobs.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
