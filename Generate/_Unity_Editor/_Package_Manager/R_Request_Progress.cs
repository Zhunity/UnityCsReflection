
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.RequestProgress
	/// </summary>
    public partial class RRequestProgress : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.ProgressUpdateEventArgs] progressUpdated
		/// </summary>
		protected REvent r_EprogressUpdated;
		public virtual REvent REprogressUpdated
		{
			get
			{
				if(r_EprogressUpdated == null)
				{
					r_EprogressUpdated = new(this, "progressUpdated");
				}
				return r_EprogressUpdated;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.ProgressUpdateEventArgs] m_ProgressUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressUpdateEventArgs> r_Fm_ProgressUpdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressUpdateEventArgs> RFm_ProgressUpdate
		{
			get
			{
				if(r_Fm_ProgressUpdate == null)
				{
					r_Fm_ProgressUpdate = new(this, "m_ProgressUpdate");
				}
				return r_Fm_ProgressUpdate;
			}
		}

		/// <summary>
		/// System.Object m_SubscribeLock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_SubscribeLock;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_SubscribeLock
		{
			get
			{
				if(r_Fm_SubscribeLock == null)
				{
					r_Fm_SubscribeLock = new(this, "m_SubscribeLock");
				}
				return r_Fm_SubscribeLock;
			}
		}

		/// <summary>
		/// System.Int64 m_OperationId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_OperationId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_OperationId
		{
			get
			{
				if(r_Fm_OperationId == null)
				{
					r_Fm_OperationId = new(this, "m_OperationId");
				}
				return r_Fm_OperationId;
			}
		}

		/// <summary>
		/// Void SetProgressHandler(Int64, UnityEditor.PackageManager.RequestProgress)
		/// </summary>
		protected static RMethod r_MSetProgressHandler_Int64_RequestProgress;
		public static RMethod RMSetProgressHandler_Int64_RequestProgress
		{
			get
			{
				if(r_MSetProgressHandler_Int64_RequestProgress == null)
				{
					r_MSetProgressHandler_Int64_RequestProgress = new( ReflectionUtils.GetType("UnityEditor.PackageManager.RequestProgress"), "SetProgressHandler", 0, typeof(System.Int64),  ReflectionUtils.GetType("UnityEditor.PackageManager.RequestProgress"));
				}
				return r_MSetProgressHandler_Int64_RequestProgress;
			}
		}

		/// <summary>
		/// Void ClearProgressHandler(Int64)
		/// </summary>
		protected static RMethod r_MClearProgressHandler_Int64;
		public static RMethod RMClearProgressHandler_Int64
		{
			get
			{
				if(r_MClearProgressHandler_Int64 == null)
				{
					r_MClearProgressHandler_Int64 = new( ReflectionUtils.GetType("UnityEditor.PackageManager.RequestProgress"), "ClearProgressHandler", 0, typeof(System.Int64));
				}
				return r_MClearProgressHandler_Int64;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageProgress[] Internal_GetPackageProgressArray(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_GetPackageProgressArray_IntPtr;
		public static RMethod RMInternal_GetPackageProgressArray_IntPtr
		{
			get
			{
				if(r_MInternal_GetPackageProgressArray_IntPtr == null)
				{
					r_MInternal_GetPackageProgressArray_IntPtr = new( ReflectionUtils.GetType("UnityEditor.PackageManager.RequestProgress"), "Internal_GetPackageProgressArray", 0, typeof(System.IntPtr));
				}
				return r_MInternal_GetPackageProgressArray_IntPtr;
			}
		}

		/// <summary>
		/// Void OnNativeProgress(UnityEditor.PackageManager.RequestProgress, IntPtr)
		/// </summary>
		protected static RMethod r_MOnNativeProgress_RequestProgress_IntPtr;
		public static RMethod RMOnNativeProgress_RequestProgress_IntPtr
		{
			get
			{
				if(r_MOnNativeProgress_RequestProgress_IntPtr == null)
				{
					r_MOnNativeProgress_RequestProgress_IntPtr = new( ReflectionUtils.GetType("UnityEditor.PackageManager.RequestProgress"), "OnNativeProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.RequestProgress"), typeof(System.IntPtr));
				}
				return r_MOnNativeProgress_RequestProgress_IntPtr;
			}
		}

		/// <summary>
		/// Void InvokeProgressUpdated(UnityEditor.PackageManager.ProgressUpdateEventArgs)
		/// </summary>
		protected RMethod r_MInvokeProgressUpdated_ProgressUpdateEventArgs;
		public virtual RMethod RMInvokeProgressUpdated_ProgressUpdateEventArgs
		{
			get
			{
				if(r_MInvokeProgressUpdated_ProgressUpdateEventArgs == null)
				{
					r_MInvokeProgressUpdated_ProgressUpdateEventArgs = new(this, "InvokeProgressUpdated", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.ProgressUpdateEventArgs"));
				}
				return r_MInvokeProgressUpdated_ProgressUpdateEventArgs;
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


        public RRequestProgress() : base("UnityEditor.PackageManager.RequestProgress")
        {
        }

        public RRequestProgress(System.Object instance) : base("UnityEditor.PackageManager.RequestProgress")
		{
            SetInstance(instance);
		}

        public RRequestProgress(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRequestProgress(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void SetProgressHandler(System.Int64 @operationId, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequestProgress @requestProgress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operationId, @requestProgress.Value};
            var ___result = RMSetProgressHandler_Int64_RequestProgress.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearProgressHandler(System.Int64 @operationId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operationId};
            var ___result = RMClearProgressHandler_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageProgress> Internal_GetPackageProgressArray(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMInternal_GetPackageProgressArray_IntPtr.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageProgress>(___result);
        }


        public static void OnNativeProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequestProgress @requestProgress, System.IntPtr @progressUpdatesPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestProgress.Value, @progressUpdatesPtr};
            var ___result = RMOnNativeProgress_RequestProgress_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeProgressUpdated(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressUpdateEventArgs @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e.Value};
            var ___result = RMInvokeProgressUpdated_ProgressUpdateEventArgs.Invoke(___genericsType, ___parameters);

            
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
