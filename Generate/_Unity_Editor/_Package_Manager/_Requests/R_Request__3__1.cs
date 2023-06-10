
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests
{
	/// <summary>
	/// UnityEditor.PackageManager.Requests.Request`1
	/// </summary>
    public partial class RRequest<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PackageManager.Requests.Request<>);
            }
        }

        public RRequest() : base("UnityEditor.PackageManager.Requests.Request`1")
        {
        }

        public RRequest(System.Object instance) : base("UnityEditor.PackageManager.Requests.Request`1")
		{
            SetInstance(instance);
		}

        public RRequest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRequest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean m_ResultFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ResultFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ResultFetched
		{
			get
			{
				if(r_Fm_ResultFetched == null)
				{
					r_Fm_ResultFetched = new(this, "m_ResultFetched");
				}
				return r_Fm_ResultFetched;
			}
		}

		/// <summary>
		/// T m_Result
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_Result;
		public virtual Hvak.Editor.Refleaction.RField RFm_Result
		{
			get
			{
				if(r_Fm_Result == null)
				{
					r_Fm_Result = new(this, "m_Result");
				}
				return r_Fm_Result;
			}
		}

		/// <summary>
		/// T Result
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PResult;
		public virtual Hvak.Editor.Refleaction.RProperty RPResult
		{
			get
			{
				if(r_PResult == null)
				{
					r_PResult = new(this, "Result", -1);
				}
				return r_PResult;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeStatusCode NativeStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeStatusCode r_PNativeStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeStatusCode RPNativeStatus
		{
			get
			{
				if(r_PNativeStatus == null)
				{
					r_PNativeStatus = new(this, "NativeStatus", -1);
				}
				return r_PNativeStatus;
			}
		}

		/// <summary>
		/// Int64 Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPId
		{
			get
			{
				if(r_PId == null)
				{
					r_PId = new(this, "Id", -1);
				}
				return r_PId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.StatusCode Status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RStatusCode r_PStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RStatusCode RPStatus
		{
			get
			{
				if(r_PStatus == null)
				{
					r_PStatus = new(this, "Status", -1);
				}
				return r_PStatus;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Error Error
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RError r_PError;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RError RPError
		{
			get
			{
				if(r_PError == null)
				{
					r_PError = new(this, "Error", -1);
				}
				return r_PError;
			}
		}

		/// <summary>
		/// T GetResult()
		/// </summary>
		protected RMethod r_MGetResult;
		public virtual RMethod RMGetResult
		{
			get
			{
				if(r_MGetResult == null)
				{
					r_MGetResult = new(this, "GetResult", 0);
				}
				return r_MGetResult;
			}
		}

		/// <summary>
		/// Void FetchResult()
		/// </summary>
		protected RMethod r_MFetchResult;
		public virtual RMethod RMFetchResult
		{
			get
			{
				if(r_MFetchResult == null)
				{
					r_MFetchResult = new(this, "FetchResult", 0);
				}
				return r_MFetchResult;
			}
		}

		/// <summary>
		/// Void FetchNativeData()
		/// </summary>
		protected RMethod r_MFetchNativeData;
		public virtual RMethod RMFetchNativeData
		{
			get
			{
				if(r_MFetchNativeData == null)
				{
					r_MFetchNativeData = new(this, "FetchNativeData", 0);
				}
				return r_MFetchNativeData;
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


        public virtual T GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetResult.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void FetchResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFetchResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FetchNativeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFetchNativeData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
