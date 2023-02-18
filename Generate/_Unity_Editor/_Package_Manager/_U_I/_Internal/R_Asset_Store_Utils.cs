
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreUtils
	/// </summary>
    public partial class RAssetStoreUtils : RMember //
    {

		/// <summary>
		/// System.String k_InvalidJSONErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_InvalidJSONErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_InvalidJSONErrorMessage
		{
			get
			{
				if(r_Fk_InvalidJSONErrorMessage == null)
				{
					r_Fk_InvalidJSONErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"), "k_InvalidJSONErrorMessage");
				}
				return r_Fk_InvalidJSONErrorMessage;
			}
		}

		/// <summary>
		/// System.String k_ServerErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ServerErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ServerErrorMessage
		{
			get
			{
				if(r_Fk_ServerErrorMessage == null)
				{
					r_Fk_ServerErrorMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"), "k_ServerErrorMessage");
				}
				return r_Fk_ServerErrorMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnect;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnect
		{
			get
			{
				if(r_Fm_UnityConnect == null)
				{
					r_Fm_UnityConnect = new(this, "m_UnityConnect");
				}
				return r_Fm_UnityConnect;
			}
		}

		/// <summary>
		/// System.String assetStoreUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PassetStoreUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPassetStoreUrl
		{
			get
			{
				if(r_PassetStoreUrl == null)
				{
					r_PassetStoreUrl = new(this, "assetStoreUrl", -1);
				}
				return r_PassetStoreUrl;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UnityConnectProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UnityConnectProxy;
		public virtual RMethod RMResolveDependencies_UnityConnectProxy
		{
			get
			{
				if(r_MResolveDependencies_UnityConnectProxy == null)
				{
					r_MResolveDependencies_UnityConnectProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UnityConnectProxy"));
				}
				return r_MResolveDependencies_UnityConnectProxy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] ParseResponseAsDictionary(UnityEditor.IAsyncHTTPClient)
		/// </summary>
		protected static RMethod r_MParseResponseAsDictionary_IAsyncHTTPClient;
		public static RMethod RMParseResponseAsDictionary_IAsyncHTTPClient
		{
			get
			{
				if(r_MParseResponseAsDictionary_IAsyncHTTPClient == null)
				{
					r_MParseResponseAsDictionary_IAsyncHTTPClient = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"), "ParseResponseAsDictionary", 0,  ReflectionUtils.GetType("UnityEditor.IAsyncHTTPClient"));
				}
				return r_MParseResponseAsDictionary_IAsyncHTTPClient;
			}
		}

		/// <summary>
		/// System.String BuildBaseDownloadPath(System.String, System.String)
		/// </summary>
		protected RMethod r_MBuildBaseDownloadPath_String_String;
		public virtual RMethod RMBuildBaseDownloadPath_String_String
		{
			get
			{
				if(r_MBuildBaseDownloadPath_String_String == null)
				{
					r_MBuildBaseDownloadPath_String_String = new(this, "BuildBaseDownloadPath", 0, typeof(System.String), typeof(System.String));
				}
				return r_MBuildBaseDownloadPath_String_String;
			}
		}

		/// <summary>
		/// System.String BuildFinalDownloadPath(System.String, System.String)
		/// </summary>
		protected RMethod r_MBuildFinalDownloadPath_String_String;
		public virtual RMethod RMBuildFinalDownloadPath_String_String
		{
			get
			{
				if(r_MBuildFinalDownloadPath_String_String == null)
				{
					r_MBuildFinalDownloadPath_String_String = new(this, "BuildFinalDownloadPath", 0, typeof(System.String), typeof(System.String));
				}
				return r_MBuildFinalDownloadPath_String_String;
			}
		}

		/// <summary>
		/// Void Download(System.String, System.String, System.String[], System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_MDownload_String_String_StringArray_String_String_Boolean;
		public virtual RMethod RMDownload_String_String_StringArray_String_String_Boolean
		{
			get
			{
				if(r_MDownload_String_String_StringArray_String_String_Boolean == null)
				{
					r_MDownload_String_String_StringArray_String_String_Boolean = new(this, "Download", 0, typeof(System.String), typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MDownload_String_String_StringArray_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.String CheckDownload(System.String, System.String, System.String[], System.String)
		/// </summary>
		protected RMethod r_MCheckDownload_String_String_StringArray_String;
		public virtual RMethod RMCheckDownload_String_String_StringArray_String
		{
			get
			{
				if(r_MCheckDownload_String_String_StringArray_String == null)
				{
					r_MCheckDownload_String_String_StringArray_String = new(this, "CheckDownload", 0, typeof(System.String), typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.String));
				}
				return r_MCheckDownload_String_String_StringArray_String;
			}
		}

		/// <summary>
		/// Boolean AbortDownload(System.String[])
		/// </summary>
		protected RMethod r_MAbortDownload_StringArray;
		public virtual RMethod RMAbortDownload_StringArray
		{
			get
			{
				if(r_MAbortDownload_StringArray == null)
				{
					r_MAbortDownload_StringArray = new(this, "AbortDownload", 0, typeof(System.String).MakeArrayType());
				}
				return r_MAbortDownload_StringArray;
			}
		}

		/// <summary>
		/// Void RegisterDownloadDelegate(UnityEngine.ScriptableObject)
		/// </summary>
		protected RMethod r_MRegisterDownloadDelegate_ScriptableObject;
		public virtual RMethod RMRegisterDownloadDelegate_ScriptableObject
		{
			get
			{
				if(r_MRegisterDownloadDelegate_ScriptableObject == null)
				{
					r_MRegisterDownloadDelegate_ScriptableObject = new(this, "RegisterDownloadDelegate", 0, typeof(UnityEngine.ScriptableObject));
				}
				return r_MRegisterDownloadDelegate_ScriptableObject;
			}
		}

		/// <summary>
		/// Void UnRegisterDownloadDelegate(UnityEngine.ScriptableObject)
		/// </summary>
		protected RMethod r_MUnRegisterDownloadDelegate_ScriptableObject;
		public virtual RMethod RMUnRegisterDownloadDelegate_ScriptableObject
		{
			get
			{
				if(r_MUnRegisterDownloadDelegate_ScriptableObject == null)
				{
					r_MUnRegisterDownloadDelegate_ScriptableObject = new(this, "UnRegisterDownloadDelegate", 0, typeof(UnityEngine.ScriptableObject));
				}
				return r_MUnRegisterDownloadDelegate_ScriptableObject;
			}
		}

		/// <summary>
		/// UnityEditor.PackageInfo[] GetLocalPackageList()
		/// </summary>
		protected RMethod r_MGetLocalPackageList;
		public virtual RMethod RMGetLocalPackageList
		{
			get
			{
				if(r_MGetLocalPackageList == null)
				{
					r_MGetLocalPackageList = new(this, "GetLocalPackageList", 0);
				}
				return r_MGetLocalPackageList;
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


        public RAssetStoreUtils() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils")
        {
        }

        public RAssetStoreUtils(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils")
		{
            SetInstance(instance);
		}

        public RAssetStoreUtils(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreUtils(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy @unityConnect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityConnect.Value};
            var ___result = RMResolveDependencies_UnityConnectProxy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.Dictionary<System.String, System.Object> ParseResponseAsDictionary(Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient @request)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request.Value};
            var ___result = RMParseResponseAsDictionary_IAsyncHTTPClient.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, System.Object>)___result;
        }


        public virtual System.String BuildBaseDownloadPath(System.String @publisher, System.String @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publisher, @category};
            var ___result = RMBuildBaseDownloadPath_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String BuildFinalDownloadPath(System.String @basePath, System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@basePath, @packageName};
            var ___result = RMBuildFinalDownloadPath_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Download(System.String @id, System.String @url, System.String[] @destination, System.String @key, System.String @jsonData, System.Boolean @resumeOK)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @url, @destination, @key, @jsonData, @resumeOK};
            var ___result = RMDownload_String_String_StringArray_String_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String CheckDownload(System.String @id, System.String @url, System.String[] @destination, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @url, @destination, @key};
            var ___result = RMCheckDownload_String_String_StringArray_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean AbortDownload(System.String[] @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMAbortDownload_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterDownloadDelegate(UnityEngine.ScriptableObject @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMRegisterDownloadDelegate_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnRegisterDownloadDelegate(UnityEngine.ScriptableObject @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMUnRegisterDownloadDelegate_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.PackageInfo[] GetLocalPackageList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLocalPackageList.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageInfo[])___result;
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
