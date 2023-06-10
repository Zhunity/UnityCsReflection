
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.ClientProxy
	/// </summary>
    public partial class RClientProxy : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ClientProxy");
            }
        }

        public RClientProxy() : base("UnityEditor.PackageManager.UI.Internal.ClientProxy")
        {
        }

        public RClientProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ClientProxy")
		{
            SetInstance(instance);
		}

        public RClientProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RClientProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void Resolve(Boolean)
		/// </summary>
		protected RMethod r_MResolve_Boolean;
		public virtual RMethod RMResolve_Boolean
		{
			get
			{
				if(r_MResolve_Boolean == null)
				{
					r_MResolve_Boolean = new(this, "Resolve", 0, typeof(System.Boolean));
				}
				return r_MResolve_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.AddRequest Add(System.String)
		/// </summary>
		protected RMethod r_MAdd_String;
		public virtual RMethod RMAdd_String
		{
			get
			{
				if(r_MAdd_String == null)
				{
					r_MAdd_String = new(this, "Add", 0, typeof(System.String));
				}
				return r_MAdd_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.AddAndRemoveRequest AddAndRemove(System.String[], System.String[])
		/// </summary>
		protected RMethod r_MAddAndRemove_StringArray_StringArray;
		public virtual RMethod RMAddAndRemove_StringArray_StringArray
		{
			get
			{
				if(r_MAddAndRemove_StringArray_StringArray == null)
				{
					r_MAddAndRemove_StringArray_StringArray = new(this, "AddAndRemove", 0, typeof(System.String).MakeArrayType(), typeof(System.String).MakeArrayType());
				}
				return r_MAddAndRemove_StringArray_StringArray;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.AddScopedRegistryRequest AddScopedRegistry(System.String, System.String, System.String[])
		/// </summary>
		protected RMethod r_MAddScopedRegistry_String_String_StringArray;
		public virtual RMethod RMAddScopedRegistry_String_String_StringArray
		{
			get
			{
				if(r_MAddScopedRegistry_String_String_StringArray == null)
				{
					r_MAddScopedRegistry_String_String_StringArray = new(this, "AddScopedRegistry", 0, typeof(System.String), typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MAddScopedRegistry_String_String_StringArray;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.EmbedRequest Embed(System.String)
		/// </summary>
		protected RMethod r_MEmbed_String;
		public virtual RMethod RMEmbed_String
		{
			get
			{
				if(r_MEmbed_String == null)
				{
					r_MEmbed_String = new(this, "Embed", 0, typeof(System.String));
				}
				return r_MEmbed_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.GetRegistriesRequest GetRegistries()
		/// </summary>
		protected RMethod r_MGetRegistries;
		public virtual RMethod RMGetRegistries
		{
			get
			{
				if(r_MGetRegistries == null)
				{
					r_MGetRegistries = new(this, "GetRegistries", 0);
				}
				return r_MGetRegistries;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.ListRequest List(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MList_Boolean_Boolean;
		public virtual RMethod RMList_Boolean_Boolean
		{
			get
			{
				if(r_MList_Boolean_Boolean == null)
				{
					r_MList_Boolean_Boolean = new(this, "List", 0, typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MList_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.RemoveRequest Remove(System.String)
		/// </summary>
		protected RMethod r_MRemove_String;
		public virtual RMethod RMRemove_String
		{
			get
			{
				if(r_MRemove_String == null)
				{
					r_MRemove_String = new(this, "Remove", 0, typeof(System.String));
				}
				return r_MRemove_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.RemoveScopedRegistryRequest RemoveScopedRegistry(System.String)
		/// </summary>
		protected RMethod r_MRemoveScopedRegistry_String;
		public virtual RMethod RMRemoveScopedRegistry_String
		{
			get
			{
				if(r_MRemoveScopedRegistry_String == null)
				{
					r_MRemoveScopedRegistry_String = new(this, "RemoveScopedRegistry", 0, typeof(System.String));
				}
				return r_MRemoveScopedRegistry_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.SearchRequest Search(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSearch_String_Boolean;
		public virtual RMethod RMSearch_String_Boolean
		{
			get
			{
				if(r_MSearch_String_Boolean == null)
				{
					r_MSearch_String_Boolean = new(this, "Search", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MSearch_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.SearchRequest SearchAll(Boolean)
		/// </summary>
		protected RMethod r_MSearchAll_Boolean;
		public virtual RMethod RMSearchAll_Boolean
		{
			get
			{
				if(r_MSearchAll_Boolean == null)
				{
					r_MSearchAll_Boolean = new(this, "SearchAll", 0, typeof(System.Boolean));
				}
				return r_MSearchAll_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.UpdateScopedRegistryRequest UpdateScopedRegistry(System.String, UnityEditor.PackageManager.UpdateScopedRegistryOptions)
		/// </summary>
		protected RMethod r_MUpdateScopedRegistry_String_UpdateScopedRegistryOptions;
		public virtual RMethod RMUpdateScopedRegistry_String_UpdateScopedRegistryOptions
		{
			get
			{
				if(r_MUpdateScopedRegistry_String_UpdateScopedRegistryOptions == null)
				{
					r_MUpdateScopedRegistry_String_UpdateScopedRegistryOptions = new(this, "UpdateScopedRegistry", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UpdateScopedRegistryOptions"));
				}
				return r_MUpdateScopedRegistry_String_UpdateScopedRegistryOptions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.GetCacheRootRequest GetCacheRoot()
		/// </summary>
		protected RMethod r_MGetCacheRoot;
		public virtual RMethod RMGetCacheRoot
		{
			get
			{
				if(r_MGetCacheRoot == null)
				{
					r_MGetCacheRoot = new(this, "GetCacheRoot", 0);
				}
				return r_MGetCacheRoot;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.SetCacheRootRequest SetCacheRoot(System.String)
		/// </summary>
		protected RMethod r_MSetCacheRoot_String;
		public virtual RMethod RMSetCacheRoot_String
		{
			get
			{
				if(r_MSetCacheRoot_String == null)
				{
					r_MSetCacheRoot_String = new(this, "SetCacheRoot", 0, typeof(System.String));
				}
				return r_MSetCacheRoot_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.Requests.ClearCacheRootRequest ClearCacheRoot()
		/// </summary>
		protected RMethod r_MClearCacheRoot;
		public virtual RMethod RMClearCacheRoot
		{
			get
			{
				if(r_MClearCacheRoot == null)
				{
					r_MClearCacheRoot = new(this, "ClearCacheRoot", 0);
				}
				return r_MClearCacheRoot;
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


        public virtual void Resolve(System.Boolean @force)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force};
            var ___result = RMResolve_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.PackageManager.Requests.AddRequest Add(System.String @identifier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identifier};
            var ___result = RMAdd_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.AddRequest)___result;
        }


        public virtual UnityEditor.PackageManager.Requests.AddAndRemoveRequest AddAndRemove(System.String[] @packagesToAdd, System.String[] @packagesToRemove)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packagesToAdd, @packagesToRemove};
            var ___result = RMAddAndRemove_StringArray_StringArray.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.AddAndRemoveRequest)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RAddScopedRegistryRequest AddScopedRegistry(System.String @registryName, System.String @url, System.String[] @scopes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registryName, @url, @scopes};
            var ___result = RMAddScopedRegistry_String_String_StringArray.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RAddScopedRegistryRequest(___result);
        }


        public virtual UnityEditor.PackageManager.Requests.EmbedRequest Embed(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMEmbed_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.EmbedRequest)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RGetRegistriesRequest GetRegistries()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRegistries.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RGetRegistriesRequest(___result);
        }


        public virtual UnityEditor.PackageManager.Requests.ListRequest List(System.Boolean @offlineMode, System.Boolean @includeIndirectDependencies)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offlineMode, @includeIndirectDependencies};
            var ___result = RMList_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.ListRequest)___result;
        }


        public virtual UnityEditor.PackageManager.Requests.RemoveRequest Remove(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMRemove_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.RemoveRequest)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RRemoveScopedRegistryRequest RemoveScopedRegistry(System.String @registryName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registryName};
            var ___result = RMRemoveScopedRegistry_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RRemoveScopedRegistryRequest(___result);
        }


        public virtual UnityEditor.PackageManager.Requests.SearchRequest Search(System.String @packageIdOrName, System.Boolean @offlineMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageIdOrName, @offlineMode};
            var ___result = RMSearch_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.SearchRequest)___result;
        }


        public virtual UnityEditor.PackageManager.Requests.SearchRequest SearchAll(System.Boolean @offlineMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offlineMode};
            var ___result = RMSearchAll_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.Requests.SearchRequest)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RUpdateScopedRegistryRequest UpdateScopedRegistry(System.String @registryName, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUpdateScopedRegistryOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registryName, @options.Value};
            var ___result = RMUpdateScopedRegistry_String_UpdateScopedRegistryOptions.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RUpdateScopedRegistryRequest(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RGetCacheRootRequest GetCacheRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCacheRoot.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RGetCacheRootRequest(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RSetCacheRootRequest SetCacheRoot(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMSetCacheRoot_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RSetCacheRootRequest(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RClearCacheRootRequest ClearCacheRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCacheRoot.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RRequests.RClearCacheRootRequest(___result);
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
