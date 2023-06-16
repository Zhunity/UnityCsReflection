
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.UpmRegistryClient
	/// </summary>
    public partial class RUpmRegistryClient : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmRegistryClient");
            }
        }

        public RUpmRegistryClient() : base("UnityEditor.PackageManager.UI.Internal.UpmRegistryClient")
        {
        }

        public RUpmRegistryClient(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UpmRegistryClient")
		{
            SetInstance(instance);
		}

        public RUpmRegistryClient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmRegistryClient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[System.Int32] onRegistriesAdded
		/// </summary>
		protected REvent r_EonRegistriesAdded;
		public virtual REvent REonRegistriesAdded
		{
			get
			{
				if(r_EonRegistriesAdded == null)
				{
					r_EonRegistriesAdded = new(this, "onRegistriesAdded");
				}
				return r_EonRegistriesAdded;
			}
		}

		/// <summary>
		/// System.Action onRegistriesModified
		/// </summary>
		protected REvent r_EonRegistriesModified;
		public virtual REvent REonRegistriesModified
		{
			get
			{
				if(r_EonRegistriesModified == null)
				{
					r_EonRegistriesModified = new(this, "onRegistriesModified");
				}
				return r_EonRegistriesModified;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.UIError] onRegistryOperationError
		/// </summary>
		protected REvent r_EonRegistryOperationError;
		public virtual REvent REonRegistryOperationError
		{
			get
			{
				if(r_EonRegistryOperationError == null)
				{
					r_EonRegistryOperationError = new(this, "onRegistryOperationError");
				}
				return r_EonRegistryOperationError;
			}
		}

		/// <summary>
		/// System.Action`1[System.Int32] onRegistriesAdded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RInt32> r_FonRegistriesAdded;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RInt32> RFonRegistriesAdded
		{
			get
			{
				if(r_FonRegistriesAdded == null)
				{
					r_FonRegistriesAdded = new(this, "onRegistriesAdded");
				}
				return r_FonRegistriesAdded;
			}
		}

		/// <summary>
		/// System.Action onRegistriesModified
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonRegistriesModified;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonRegistriesModified
		{
			get
			{
				if(r_FonRegistriesModified == null)
				{
					r_FonRegistriesModified = new(this, "onRegistriesModified");
				}
				return r_FonRegistriesModified;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.UIError] onRegistryOperationError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_FonRegistryOperationError;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFonRegistryOperationError
		{
			get
			{
				if(r_FonRegistryOperationError == null)
				{
					r_FonRegistryOperationError = new(this, "onRegistryOperationError");
				}
				return r_FonRegistryOperationError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmGetRegistriesOperation m_GetRegistriesOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmGetRegistriesOperation r_Fm_GetRegistriesOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmGetRegistriesOperation RFm_GetRegistriesOperation
		{
			get
			{
				if(r_Fm_GetRegistriesOperation == null)
				{
					r_Fm_GetRegistriesOperation = new(this, "m_GetRegistriesOperation");
				}
				return r_Fm_GetRegistriesOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmAddRegistryOperation m_AddRegistryOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddRegistryOperation r_Fm_AddRegistryOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddRegistryOperation RFm_AddRegistryOperation
		{
			get
			{
				if(r_Fm_AddRegistryOperation == null)
				{
					r_Fm_AddRegistryOperation = new(this, "m_AddRegistryOperation");
				}
				return r_Fm_AddRegistryOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmUpdateRegistryOperation m_UpdateRegistryOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmUpdateRegistryOperation r_Fm_UpdateRegistryOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmUpdateRegistryOperation RFm_UpdateRegistryOperation
		{
			get
			{
				if(r_Fm_UpdateRegistryOperation == null)
				{
					r_Fm_UpdateRegistryOperation = new(this, "m_UpdateRegistryOperation");
				}
				return r_Fm_UpdateRegistryOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmRemoveRegistryOperation m_RemoveRegistryOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveRegistryOperation r_Fm_RemoveRegistryOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveRegistryOperation RFm_RemoveRegistryOperation
		{
			get
			{
				if(r_Fm_RemoveRegistryOperation == null)
				{
					r_Fm_RemoveRegistryOperation = new(this, "m_RemoveRegistryOperation");
				}
				return r_Fm_RemoveRegistryOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmCache m_UpmCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache r_Fm_UpmCache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache RFm_UpmCache
		{
			get
			{
				if(r_Fm_UpmCache == null)
				{
					r_Fm_UpmCache = new(this, "m_UpmCache");
				}
				return r_Fm_UpmCache;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy m_SettingsProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy r_Fm_SettingsProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy RFm_SettingsProxy
		{
			get
			{
				if(r_Fm_SettingsProxy == null)
				{
					r_Fm_SettingsProxy = new(this, "m_SettingsProxy");
				}
				return r_Fm_SettingsProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ClientProxy m_ClientProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy r_Fm_ClientProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy RFm_ClientProxy
		{
			get
			{
				if(r_Fm_ClientProxy == null)
				{
					r_Fm_ClientProxy = new(this, "m_ClientProxy");
				}
				return r_Fm_ClientProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy m_ApplicationProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy r_Fm_ApplicationProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy RFm_ApplicationProxy
		{
			get
			{
				if(r_Fm_ApplicationProxy == null)
				{
					r_Fm_ApplicationProxy = new(this, "m_ApplicationProxy");
				}
				return r_Fm_ApplicationProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmGetRegistriesOperation getRegistriesOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmGetRegistriesOperation r_PgetRegistriesOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmGetRegistriesOperation RPgetRegistriesOperation
		{
			get
			{
				if(r_PgetRegistriesOperation == null)
				{
					r_PgetRegistriesOperation = new(this, "getRegistriesOperation", -1);
				}
				return r_PgetRegistriesOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmAddRegistryOperation addRegistryOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddRegistryOperation r_PaddRegistryOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddRegistryOperation RPaddRegistryOperation
		{
			get
			{
				if(r_PaddRegistryOperation == null)
				{
					r_PaddRegistryOperation = new(this, "addRegistryOperation", -1);
				}
				return r_PaddRegistryOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmUpdateRegistryOperation updateRegistryOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmUpdateRegistryOperation r_PupdateRegistryOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmUpdateRegistryOperation RPupdateRegistryOperation
		{
			get
			{
				if(r_PupdateRegistryOperation == null)
				{
					r_PupdateRegistryOperation = new(this, "updateRegistryOperation", -1);
				}
				return r_PupdateRegistryOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmRemoveRegistryOperation removeRegistryOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveRegistryOperation r_PremoveRegistryOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveRegistryOperation RPremoveRegistryOperation
		{
			get
			{
				if(r_PremoveRegistryOperation == null)
				{
					r_PremoveRegistryOperation = new(this, "removeRegistryOperation", -1);
				}
				return r_PremoveRegistryOperation;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy, UnityEditor.PackageManager.UI.Internal.ClientProxy, UnityEditor.PackageManager.UI.Internal.ApplicationProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UpmCache_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy;
		public virtual RMethod RMResolveDependencies_UpmCache_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy
		{
			get
			{
				if(r_MResolveDependencies_UpmCache_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy == null)
				{
					r_MResolveDependencies_UpmCache_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ClientProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"));
				}
				return r_MResolveDependencies_UpmCache_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy;
			}
		}

		/// <summary>
		/// Void AddRegistry(System.String, System.String, System.String[])
		/// </summary>
		protected RMethod r_MAddRegistry_String_String_StringArray;
		public virtual RMethod RMAddRegistry_String_String_StringArray
		{
			get
			{
				if(r_MAddRegistry_String_String_StringArray == null)
				{
					r_MAddRegistry_String_String_StringArray = new(this, "AddRegistry", 0, typeof(System.String), typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MAddRegistry_String_String_StringArray;
			}
		}

		/// <summary>
		/// Void OnProcessAddRegistryResult(UnityEditor.PackageManager.Requests.AddScopedRegistryRequest)
		/// </summary>
		protected RMethod r_MOnProcessAddRegistryResult_AddScopedRegistryRequest;
		public virtual RMethod RMOnProcessAddRegistryResult_AddScopedRegistryRequest
		{
			get
			{
				if(r_MOnProcessAddRegistryResult_AddScopedRegistryRequest == null)
				{
					r_MOnProcessAddRegistryResult_AddScopedRegistryRequest = new(this, "OnProcessAddRegistryResult", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.Requests.AddScopedRegistryRequest"));
				}
				return r_MOnProcessAddRegistryResult_AddScopedRegistryRequest;
			}
		}

		/// <summary>
		/// Void UpdateRegistry(System.String, System.String, System.String, System.String[])
		/// </summary>
		protected RMethod r_MUpdateRegistry_String_String_String_StringArray;
		public virtual RMethod RMUpdateRegistry_String_String_String_StringArray
		{
			get
			{
				if(r_MUpdateRegistry_String_String_String_StringArray == null)
				{
					r_MUpdateRegistry_String_String_String_StringArray = new(this, "UpdateRegistry", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MUpdateRegistry_String_String_String_StringArray;
			}
		}

		/// <summary>
		/// Void OnProcessUpdateRegistryResult(UnityEditor.PackageManager.Requests.UpdateScopedRegistryRequest)
		/// </summary>
		protected RMethod r_MOnProcessUpdateRegistryResult_UpdateScopedRegistryRequest;
		public virtual RMethod RMOnProcessUpdateRegistryResult_UpdateScopedRegistryRequest
		{
			get
			{
				if(r_MOnProcessUpdateRegistryResult_UpdateScopedRegistryRequest == null)
				{
					r_MOnProcessUpdateRegistryResult_UpdateScopedRegistryRequest = new(this, "OnProcessUpdateRegistryResult", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.Requests.UpdateScopedRegistryRequest"));
				}
				return r_MOnProcessUpdateRegistryResult_UpdateScopedRegistryRequest;
			}
		}

		/// <summary>
		/// Void RemoveRegistry(System.String)
		/// </summary>
		protected RMethod r_MRemoveRegistry_String;
		public virtual RMethod RMRemoveRegistry_String
		{
			get
			{
				if(r_MRemoveRegistry_String == null)
				{
					r_MRemoveRegistry_String = new(this, "RemoveRegistry", 0, typeof(System.String));
				}
				return r_MRemoveRegistry_String;
			}
		}

		/// <summary>
		/// Void OnProcessRemoveRegistryResult(UnityEditor.PackageManager.Requests.RemoveScopedRegistryRequest)
		/// </summary>
		protected RMethod r_MOnProcessRemoveRegistryResult_RemoveScopedRegistryRequest;
		public virtual RMethod RMOnProcessRemoveRegistryResult_RemoveScopedRegistryRequest
		{
			get
			{
				if(r_MOnProcessRemoveRegistryResult_RemoveScopedRegistryRequest == null)
				{
					r_MOnProcessRemoveRegistryResult_RemoveScopedRegistryRequest = new(this, "OnProcessRemoveRegistryResult", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.Requests.RemoveScopedRegistryRequest"));
				}
				return r_MOnProcessRemoveRegistryResult_RemoveScopedRegistryRequest;
			}
		}

		/// <summary>
		/// Void CheckRegistriesChanged()
		/// </summary>
		protected RMethod r_MCheckRegistriesChanged;
		public virtual RMethod RMCheckRegistriesChanged
		{
			get
			{
				if(r_MCheckRegistriesChanged == null)
				{
					r_MCheckRegistriesChanged = new(this, "CheckRegistriesChanged", 0);
				}
				return r_MCheckRegistriesChanged;
			}
		}

		/// <summary>
		/// Void OnProcessGetRegistriesResult(UnityEditor.PackageManager.Requests.GetRegistriesRequest)
		/// </summary>
		protected RMethod r_MOnProcessGetRegistriesResult_GetRegistriesRequest;
		public virtual RMethod RMOnProcessGetRegistriesResult_GetRegistriesRequest
		{
			get
			{
				if(r_MOnProcessGetRegistriesResult_GetRegistriesRequest == null)
				{
					r_MOnProcessGetRegistriesResult_GetRegistriesRequest = new(this, "OnProcessGetRegistriesResult", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.Requests.GetRegistriesRequest"));
				}
				return r_MOnProcessGetRegistriesResult_GetRegistriesRequest;
			}
		}

		/// <summary>
		/// T CreateOperation[T](T ByRef)
		/// </summary>
		protected RMethod r_MCreateOperation_GT_Ref_T;
		public virtual RMethod RMCreateOperation_GT_Ref_T
		{
			get
			{
				if(r_MCreateOperation_GT_Ref_T == null)
				{
					r_MCreateOperation_GT_Ref_T = new(this, "CreateOperation", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MCreateOperation_GT_Ref_T;
			}
		}

		/// <summary>
		/// Boolean <OnProcessGetRegistriesResult>b__33_0(UnityEditor.PackageManager.RegistryInfo)
		/// </summary>
		protected RMethod r_M__0__OnProcessGetRegistriesResult__1__b__33_0_RegistryInfo;
		public virtual RMethod RM__0__OnProcessGetRegistriesResult__1__b__33_0_RegistryInfo
		{
			get
			{
				if(r_M__0__OnProcessGetRegistriesResult__1__b__33_0_RegistryInfo == null)
				{
					r_M__0__OnProcessGetRegistriesResult__1__b__33_0_RegistryInfo = new(this, "<OnProcessGetRegistriesResult>b__33_0", 0, typeof(UnityEditor.PackageManager.RegistryInfo));
				}
				return r_M__0__OnProcessGetRegistriesResult__1__b__33_0_RegistryInfo;
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


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy @settingsProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy @clientProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @applicationProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@upmCache.Value, @settingsProxy.Value, @clientProxy.Value, @applicationProxy.Value};
            var ___result = RMResolveDependencies_UpmCache_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRegistry(System.String @name, System.String @url, System.String[] @scopes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @url, @scopes};
            var ___result = RMAddRegistry_String_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProcessAddRegistryResult(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RAddScopedRegistryRequest @request)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request.Value};
            var ___result = RMOnProcessAddRegistryResult_AddScopedRegistryRequest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateRegistry(System.String @oldName, System.String @newName, System.String @url, System.String[] @scopes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldName, @newName, @url, @scopes};
            var ___result = RMUpdateRegistry_String_String_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProcessUpdateRegistryResult(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RUpdateScopedRegistryRequest @request)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request.Value};
            var ___result = RMOnProcessUpdateRegistryResult_UpdateScopedRegistryRequest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveRegistry(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMRemoveRegistry_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProcessRemoveRegistryResult(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RRemoveScopedRegistryRequest @request)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request.Value};
            var ___result = RMOnProcessRemoveRegistryResult_RemoveScopedRegistryRequest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckRegistriesChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckRegistriesChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProcessGetRegistriesResult(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RGetRegistriesRequest @request)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request.Value};
            var ___result = RMOnProcessGetRegistriesResult_GetRegistriesRequest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RType CreateOperation<T>(ref Hvak.Editor.Refleaction.RType @operation) where T : new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMCreateOperation_GT_Ref_T.Invoke(___genericsType, ___parameters);
			@operation = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual System.Boolean __0__OnProcessGetRegistriesResult__1__b__33_0(UnityEditor.PackageManager.RegistryInfo @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RM__0__OnProcessGetRegistriesResult__1__b__33_0_RegistryInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
