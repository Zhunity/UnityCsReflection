
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.FetchStatus
	/// </summary>
    public partial class RFetchStatus : RMember //
    {

		/// <summary>
		/// System.String productId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FproductId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFproductId
		{
			get
			{
				if(r_FproductId == null)
				{
					r_FproductId = new(this, "productId");
				}
				return r_FproductId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FetchType fetchingInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType r_FfetchingInProgress;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType RFfetchingInProgress
		{
			get
			{
				if(r_FfetchingInProgress == null)
				{
					r_FfetchingInProgress = new(this, "fetchingInProgress");
				}
				return r_FfetchingInProgress;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FetchType fetchingFinished
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType r_FfetchingFinished;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType RFfetchingFinished
		{
			get
			{
				if(r_FfetchingFinished == null)
				{
					r_FfetchingFinished = new(this, "fetchingFinished");
				}
				return r_FfetchingFinished;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.FetchError] errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchError> r_Ferrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchError> RFerrors
		{
			get
			{
				if(r_Ferrors == null)
				{
					r_Ferrors = new(this, "errors");
				}
				return r_Ferrors;
			}
		}

		/// <summary>
		/// Boolean IsFetchInProgress(UnityEditor.PackageManager.UI.Internal.FetchType)
		/// </summary>
		protected RMethod r_MIsFetchInProgress_FetchType;
		public virtual RMethod RMIsFetchInProgress_FetchType
		{
			get
			{
				if(r_MIsFetchInProgress_FetchType == null)
				{
					r_MIsFetchInProgress_FetchType = new(this, "IsFetchInProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchType"));
				}
				return r_MIsFetchInProgress_FetchType;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FetchError GetFetchError(UnityEditor.PackageManager.UI.Internal.FetchType)
		/// </summary>
		protected RMethod r_MGetFetchError_FetchType;
		public virtual RMethod RMGetFetchError_FetchType
		{
			get
			{
				if(r_MGetFetchError_FetchType == null)
				{
					r_MGetFetchError_FetchType = new(this, "GetFetchError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchType"));
				}
				return r_MGetFetchError_FetchType;
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


        public RFetchStatus() : base("UnityEditor.PackageManager.UI.Internal.FetchStatus")
        {
        }

        public RFetchStatus(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.FetchStatus")
		{
            SetInstance(instance);
		}

        public RFetchStatus(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFetchStatus(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsFetchInProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType @fetchType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fetchType.Value};
            var ___result = RMIsFetchInProgress_FetchType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchError GetFetchError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType @fetchType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fetchType.Value};
            var ___result = RMGetFetchError_FetchType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchError(___result);
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
