
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.FetchStatusTracker
	/// </summary>
    public partial class RFetchStatusTracker : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.FetchStatus] onFetchStatusChanged
		/// </summary>
		protected REvent r_EonFetchStatusChanged;
		public virtual REvent REonFetchStatusChanged
		{
			get
			{
				if(r_EonFetchStatusChanged == null)
				{
					r_EonFetchStatusChanged = new(this, "onFetchStatusChanged");
					r_EonFetchStatusChanged.SetBelong(this.instance);
				}
				return r_EonFetchStatusChanged;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.FetchStatus] m_FetchStatuses
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> r_Fm_FetchStatuses;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> RFm_FetchStatuses
		{
			get
			{
				if(r_Fm_FetchStatuses == null)
				{
					r_Fm_FetchStatuses = new(this, "m_FetchStatuses");
					r_Fm_FetchStatuses.SetBelong(this.instance);
				}
				return r_Fm_FetchStatuses;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.FetchStatus] onFetchStatusChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> r_FonFetchStatusChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> RFonFetchStatusChanged
		{
			get
			{
				if(r_FonFetchStatusChanged == null)
				{
					r_FonFetchStatusChanged = new(this, "onFetchStatusChanged");
					r_FonFetchStatusChanged.SetBelong(this.instance);
				}
				return r_FonFetchStatusChanged;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FetchStatus[] m_SerializedFetchStatuses
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> r_Fm_SerializedFetchStatuses;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> RFm_SerializedFetchStatuses
		{
			get
			{
				if(r_Fm_SerializedFetchStatuses == null)
				{
					r_Fm_SerializedFetchStatuses = new(this, "m_SerializedFetchStatuses");
					r_Fm_SerializedFetchStatuses.SetBelong(this.instance);
				}
				return r_Fm_SerializedFetchStatuses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.FetchStatus] fetchStatuses
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> r_PfetchStatuses;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus> RPfetchStatuses
		{
			get
			{
				if(r_PfetchStatuses == null)
				{
					r_PfetchStatuses = new(this, "fetchStatuses", -1);
					r_PfetchStatuses.SetBelong(this.instance);
				}
				return r_PfetchStatuses;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.FetchStatus GetOrCreateFetchStatus(System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateFetchStatus_String;
		public virtual RMethod RMGetOrCreateFetchStatus_String
		{
			get
			{
				if(r_MGetOrCreateFetchStatus_String == null)
				{
					r_MGetOrCreateFetchStatus_String = new(this, "GetOrCreateFetchStatus", 0, typeof(System.String));
					r_MGetOrCreateFetchStatus_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateFetchStatus_String;
			}
		}

		/// <summary>
		/// Void SetFetchInProgress(System.String, UnityEditor.PackageManager.UI.Internal.FetchType)
		/// </summary>
		protected RMethod r_MSetFetchInProgress_String_FetchType;
		public virtual RMethod RMSetFetchInProgress_String_FetchType
		{
			get
			{
				if(r_MSetFetchInProgress_String_FetchType == null)
				{
					r_MSetFetchInProgress_String_FetchType = new(this, "SetFetchInProgress", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchType"));
					r_MSetFetchInProgress_String_FetchType.SetBelong(this.instance);
				}
				return r_MSetFetchInProgress_String_FetchType;
			}
		}

		/// <summary>
		/// Void SetFetchSuccess(System.String, UnityEditor.PackageManager.UI.Internal.FetchType)
		/// </summary>
		protected RMethod r_MSetFetchSuccess_String_FetchType;
		public virtual RMethod RMSetFetchSuccess_String_FetchType
		{
			get
			{
				if(r_MSetFetchSuccess_String_FetchType == null)
				{
					r_MSetFetchSuccess_String_FetchType = new(this, "SetFetchSuccess", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchType"));
					r_MSetFetchSuccess_String_FetchType.SetBelong(this.instance);
				}
				return r_MSetFetchSuccess_String_FetchType;
			}
		}

		/// <summary>
		/// Void SetFetchError(System.String, UnityEditor.PackageManager.UI.Internal.FetchType, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MSetFetchError_String_FetchType_UIError;
		public virtual RMethod RMSetFetchError_String_FetchType_UIError
		{
			get
			{
				if(r_MSetFetchError_String_FetchType_UIError == null)
				{
					r_MSetFetchError_String_FetchType_UIError = new(this, "SetFetchError", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.FetchType"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
					r_MSetFetchError_String_FetchType_UIError.SetBelong(this.instance);
				}
				return r_MSetFetchError_String_FetchType_UIError;
			}
		}

		/// <summary>
		/// Void ClearCache()
		/// </summary>
		protected RMethod r_MClearCache;
		public virtual RMethod RMClearCache
		{
			get
			{
				if(r_MClearCache == null)
				{
					r_MClearCache = new(this, "ClearCache", 0);
					r_MClearCache.SetBelong(this.instance);
				}
				return r_MClearCache;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_MOnBeforeSerialize.SetBelong(this.instance);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_MOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_MOnAfterDeserialize;
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


        public RFetchStatusTracker() : base("UnityEditor.PackageManager.UI.Internal.FetchStatusTracker")
        {
        }

        public RFetchStatusTracker(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.FetchStatusTracker")
		{
            SetInstance(instance);
		}

        public RFetchStatusTracker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFetchStatusTracker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus GetOrCreateFetchStatus(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMGetOrCreateFetchStatus_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchStatus(___result);
        }


        public virtual void SetFetchInProgress(System.String @productId, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType @fetchType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @fetchType.Value};
            var ___result = RMSetFetchInProgress_String_FetchType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFetchSuccess(System.String @productId, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType @fetchType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @fetchType.Value};
            var ___result = RMSetFetchSuccess_String_FetchType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFetchError(System.String @productId, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RFetchType @fetchType, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @fetchType.Value, @error.Value};
            var ___result = RMSetFetchError_String_FetchType_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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
