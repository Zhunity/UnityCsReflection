using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RSceneManagement
{
	/// <summary>
	/// UnityEngine.SceneManagement.Scene
	/// </summary>
    public partial class RScene : RMember //
    {

		/// <summary>
		/// System.Int32 m_Handle
		/// </summary>
		protected RField r_m_Handle;
		public virtual RField Rm_Handle
		{
			get
			{
				if(r_m_Handle == null)
				{
					r_m_Handle = new(this, "m_Handle");
					r_m_Handle.SetBelong(this.instance);
				}
				return r_m_Handle;
			}
		}

		/// <summary>
		/// Int32 handle
		/// </summary>
		protected RProperty r_handle;
		public virtual RProperty Rhandle
		{
			get
			{
				if(r_handle == null)
				{
					r_handle = new(this, "handle", -1);
					r_handle.SetBelong(this.instance);
				}
				return r_handle;
			}
		}

		/// <summary>
		/// LoadingState loadingState
		/// </summary>
		protected RProperty r_loadingState;
		public virtual RProperty RloadingState
		{
			get
			{
				if(r_loadingState == null)
				{
					r_loadingState = new(this, "loadingState", -1);
					r_loadingState.SetBelong(this.instance);
				}
				return r_loadingState;
			}
		}

		/// <summary>
		/// System.String guid
		/// </summary>
		protected RProperty r_guid;
		public virtual RProperty Rguid
		{
			get
			{
				if(r_guid == null)
				{
					r_guid = new(this, "guid", -1);
					r_guid.SetBelong(this.instance);
				}
				return r_guid;
			}
		}

		/// <summary>
		/// System.String path
		/// </summary>
		protected RProperty r_path;
		public virtual RProperty Rpath
		{
			get
			{
				if(r_path == null)
				{
					r_path = new(this, "path", -1);
					r_path.SetBelong(this.instance);
				}
				return r_path;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Boolean isLoaded
		/// </summary>
		protected RProperty r_isLoaded;
		public virtual RProperty RisLoaded
		{
			get
			{
				if(r_isLoaded == null)
				{
					r_isLoaded = new(this, "isLoaded", -1);
					r_isLoaded.SetBelong(this.instance);
				}
				return r_isLoaded;
			}
		}

		/// <summary>
		/// Int32 buildIndex
		/// </summary>
		protected RProperty r_buildIndex;
		public virtual RProperty RbuildIndex
		{
			get
			{
				if(r_buildIndex == null)
				{
					r_buildIndex = new(this, "buildIndex", -1);
					r_buildIndex.SetBelong(this.instance);
				}
				return r_buildIndex;
			}
		}

		/// <summary>
		/// Boolean isDirty
		/// </summary>
		protected RProperty r_isDirty;
		public virtual RProperty RisDirty
		{
			get
			{
				if(r_isDirty == null)
				{
					r_isDirty = new(this, "isDirty", -1);
					r_isDirty.SetBelong(this.instance);
				}
				return r_isDirty;
			}
		}

		/// <summary>
		/// Int32 dirtyID
		/// </summary>
		protected RProperty r_dirtyID;
		public virtual RProperty RdirtyID
		{
			get
			{
				if(r_dirtyID == null)
				{
					r_dirtyID = new(this, "dirtyID", -1);
					r_dirtyID.SetBelong(this.instance);
				}
				return r_dirtyID;
			}
		}

		/// <summary>
		/// Int32 rootCount
		/// </summary>
		protected RProperty r_rootCount;
		public virtual RProperty RrootCount
		{
			get
			{
				if(r_rootCount == null)
				{
					r_rootCount = new(this, "rootCount", -1);
					r_rootCount.SetBelong(this.instance);
				}
				return r_rootCount;
			}
		}

		/// <summary>
		/// Boolean isSubScene
		/// </summary>
		protected RProperty r_isSubScene;
		public virtual RProperty RisSubScene
		{
			get
			{
				if(r_isSubScene == null)
				{
					r_isSubScene = new(this, "isSubScene", -1);
					r_isSubScene.SetBelong(this.instance);
				}
				return r_isSubScene;
			}
		}

		/// <summary>
		/// Boolean IsValidInternal(Int32)
		/// </summary>
		protected static RMethod r_IsValidInternal_Int32;
		public static RMethod RIsValidInternal_Int32
		{
			get
			{
				if(r_IsValidInternal_Int32 == null)
				{
					r_IsValidInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "IsValidInternal", 0, typeof(System.Int32));
					r_IsValidInternal_Int32.SetBelong(null);
				}
				return r_IsValidInternal_Int32;
			}
		}

		/// <summary>
		/// System.String GetPathInternal(Int32)
		/// </summary>
		protected static RMethod r_GetPathInternal_Int32;
		public static RMethod RGetPathInternal_Int32
		{
			get
			{
				if(r_GetPathInternal_Int32 == null)
				{
					r_GetPathInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetPathInternal", 0, typeof(System.Int32));
					r_GetPathInternal_Int32.SetBelong(null);
				}
				return r_GetPathInternal_Int32;
			}
		}

		/// <summary>
		/// Void SetPathAndGUIDInternal(Int32, System.String, System.String)
		/// </summary>
		protected static RMethod r_SetPathAndGUIDInternal_Int32_String_String;
		public static RMethod RSetPathAndGUIDInternal_Int32_String_String
		{
			get
			{
				if(r_SetPathAndGUIDInternal_Int32_String_String == null)
				{
					r_SetPathAndGUIDInternal_Int32_String_String = new(typeof(UnityEngine.SceneManagement.Scene), "SetPathAndGUIDInternal", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
					r_SetPathAndGUIDInternal_Int32_String_String.SetBelong(null);
				}
				return r_SetPathAndGUIDInternal_Int32_String_String;
			}
		}

		/// <summary>
		/// System.String GetNameInternal(Int32)
		/// </summary>
		protected static RMethod r_GetNameInternal_Int32;
		public static RMethod RGetNameInternal_Int32
		{
			get
			{
				if(r_GetNameInternal_Int32 == null)
				{
					r_GetNameInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetNameInternal", 0, typeof(System.Int32));
					r_GetNameInternal_Int32.SetBelong(null);
				}
				return r_GetNameInternal_Int32;
			}
		}

		/// <summary>
		/// Void SetNameInternal(Int32, System.String)
		/// </summary>
		protected static RMethod r_SetNameInternal_Int32_String;
		public static RMethod RSetNameInternal_Int32_String
		{
			get
			{
				if(r_SetNameInternal_Int32_String == null)
				{
					r_SetNameInternal_Int32_String = new(typeof(UnityEngine.SceneManagement.Scene), "SetNameInternal", 0, typeof(System.Int32), typeof(System.String));
					r_SetNameInternal_Int32_String.SetBelong(null);
				}
				return r_SetNameInternal_Int32_String;
			}
		}

		/// <summary>
		/// System.String GetGUIDInternal(Int32)
		/// </summary>
		protected static RMethod r_GetGUIDInternal_Int32;
		public static RMethod RGetGUIDInternal_Int32
		{
			get
			{
				if(r_GetGUIDInternal_Int32 == null)
				{
					r_GetGUIDInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetGUIDInternal", 0, typeof(System.Int32));
					r_GetGUIDInternal_Int32.SetBelong(null);
				}
				return r_GetGUIDInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSubScene(Int32)
		/// </summary>
		protected static RMethod r_IsSubScene_Int32;
		public static RMethod RIsSubScene_Int32
		{
			get
			{
				if(r_IsSubScene_Int32 == null)
				{
					r_IsSubScene_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "IsSubScene", 0, typeof(System.Int32));
					r_IsSubScene_Int32.SetBelong(null);
				}
				return r_IsSubScene_Int32;
			}
		}

		/// <summary>
		/// Void SetIsSubScene(Int32, Boolean)
		/// </summary>
		protected static RMethod r_SetIsSubScene_Int32_Boolean;
		public static RMethod RSetIsSubScene_Int32_Boolean
		{
			get
			{
				if(r_SetIsSubScene_Int32_Boolean == null)
				{
					r_SetIsSubScene_Int32_Boolean = new(typeof(UnityEngine.SceneManagement.Scene), "SetIsSubScene", 0, typeof(System.Int32), typeof(System.Boolean));
					r_SetIsSubScene_Int32_Boolean.SetBelong(null);
				}
				return r_SetIsSubScene_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetIsLoadedInternal(Int32)
		/// </summary>
		protected static RMethod r_GetIsLoadedInternal_Int32;
		public static RMethod RGetIsLoadedInternal_Int32
		{
			get
			{
				if(r_GetIsLoadedInternal_Int32 == null)
				{
					r_GetIsLoadedInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetIsLoadedInternal", 0, typeof(System.Int32));
					r_GetIsLoadedInternal_Int32.SetBelong(null);
				}
				return r_GetIsLoadedInternal_Int32;
			}
		}

		/// <summary>
		/// LoadingState GetLoadingStateInternal(Int32)
		/// </summary>
		protected static RMethod r_GetLoadingStateInternal_Int32;
		public static RMethod RGetLoadingStateInternal_Int32
		{
			get
			{
				if(r_GetLoadingStateInternal_Int32 == null)
				{
					r_GetLoadingStateInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetLoadingStateInternal", 0, typeof(System.Int32));
					r_GetLoadingStateInternal_Int32.SetBelong(null);
				}
				return r_GetLoadingStateInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean GetIsDirtyInternal(Int32)
		/// </summary>
		protected static RMethod r_GetIsDirtyInternal_Int32;
		public static RMethod RGetIsDirtyInternal_Int32
		{
			get
			{
				if(r_GetIsDirtyInternal_Int32 == null)
				{
					r_GetIsDirtyInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetIsDirtyInternal", 0, typeof(System.Int32));
					r_GetIsDirtyInternal_Int32.SetBelong(null);
				}
				return r_GetIsDirtyInternal_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDirtyID(Int32)
		/// </summary>
		protected static RMethod r_GetDirtyID_Int32;
		public static RMethod RGetDirtyID_Int32
		{
			get
			{
				if(r_GetDirtyID_Int32 == null)
				{
					r_GetDirtyID_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetDirtyID", 0, typeof(System.Int32));
					r_GetDirtyID_Int32.SetBelong(null);
				}
				return r_GetDirtyID_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBuildIndexInternal(Int32)
		/// </summary>
		protected static RMethod r_GetBuildIndexInternal_Int32;
		public static RMethod RGetBuildIndexInternal_Int32
		{
			get
			{
				if(r_GetBuildIndexInternal_Int32 == null)
				{
					r_GetBuildIndexInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetBuildIndexInternal", 0, typeof(System.Int32));
					r_GetBuildIndexInternal_Int32.SetBelong(null);
				}
				return r_GetBuildIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Int32 GetRootCountInternal(Int32)
		/// </summary>
		protected static RMethod r_GetRootCountInternal_Int32;
		public static RMethod RGetRootCountInternal_Int32
		{
			get
			{
				if(r_GetRootCountInternal_Int32 == null)
				{
					r_GetRootCountInternal_Int32 = new(typeof(UnityEngine.SceneManagement.Scene), "GetRootCountInternal", 0, typeof(System.Int32));
					r_GetRootCountInternal_Int32.SetBelong(null);
				}
				return r_GetRootCountInternal_Int32;
			}
		}

		/// <summary>
		/// Void GetRootGameObjectsInternal(Int32, System.Object)
		/// </summary>
		protected static RMethod r_GetRootGameObjectsInternal_Int32_Object;
		public static RMethod RGetRootGameObjectsInternal_Int32_Object
		{
			get
			{
				if(r_GetRootGameObjectsInternal_Int32_Object == null)
				{
					r_GetRootGameObjectsInternal_Int32_Object = new(typeof(UnityEngine.SceneManagement.Scene), "GetRootGameObjectsInternal", 0, typeof(System.Int32), typeof(System.Object));
					r_GetRootGameObjectsInternal_Int32_Object.SetBelong(null);
				}
				return r_GetRootGameObjectsInternal_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_IsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_IsValid == null)
				{
					r_IsValid = new(this, "IsValid", 0);
					r_IsValid.SetBelong(this.instance);
				}
				return r_IsValid;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] GetRootGameObjects()
		/// </summary>
		protected RMethod r_GetRootGameObjects;
		public virtual RMethod RGetRootGameObjects
		{
			get
			{
				if(r_GetRootGameObjects == null)
				{
					r_GetRootGameObjects = new(this, "GetRootGameObjects", 0);
					r_GetRootGameObjects.SetBelong(this.instance);
				}
				return r_GetRootGameObjects;
			}
		}

		/// <summary>
		/// Void GetRootGameObjects(System.Collections.Generic.List`1[UnityEngine.GameObject])
		/// </summary>
		protected RMethod r_GetRootGameObjects_List_d_GameObject_p_;
		public virtual RMethod RGetRootGameObjects_List_d_GameObject_p_
		{
			get
			{
				if(r_GetRootGameObjects_List_d_GameObject_p_ == null)
				{
					r_GetRootGameObjects_List_d_GameObject_p_ = new(this, "GetRootGameObjects", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.GameObject)));
					r_GetRootGameObjects_List_d_GameObject_p_.SetBelong(this.instance);
				}
				return r_GetRootGameObjects_List_d_GameObject_p_;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene)
		/// </summary>
		protected static RMethod r_op_Equality_Scene_Scene;
		public static RMethod Rop_Equality_Scene_Scene
		{
			get
			{
				if(r_op_Equality_Scene_Scene == null)
				{
					r_op_Equality_Scene_Scene = new(typeof(UnityEngine.SceneManagement.Scene), "op_Equality", 0, typeof(UnityEngine.SceneManagement.Scene), typeof(UnityEngine.SceneManagement.Scene));
					r_op_Equality_Scene_Scene.SetBelong(null);
				}
				return r_op_Equality_Scene_Scene;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene)
		/// </summary>
		protected static RMethod r_op_Inequality_Scene_Scene;
		public static RMethod Rop_Inequality_Scene_Scene
		{
			get
			{
				if(r_op_Inequality_Scene_Scene == null)
				{
					r_op_Inequality_Scene_Scene = new(typeof(UnityEngine.SceneManagement.Scene), "op_Inequality", 0, typeof(UnityEngine.SceneManagement.Scene), typeof(UnityEngine.SceneManagement.Scene));
					r_op_Inequality_Scene_Scene.SetBelong(null);
				}
				return r_op_Inequality_Scene_Scene;
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
		/// Void SetPathAndGuid(System.String, System.String)
		/// </summary>
		protected RMethod r_SetPathAndGuid_String_String;
		public virtual RMethod RSetPathAndGuid_String_String
		{
			get
			{
				if(r_SetPathAndGuid_String_String == null)
				{
					r_SetPathAndGuid_String_String = new(this, "SetPathAndGuid", 0, typeof(System.String), typeof(System.String));
					r_SetPathAndGuid_String_String.SetBelong(this.instance);
				}
				return r_SetPathAndGuid_String_String;
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


        public RScene() : base("UnityEngine.SceneManagement.Scene")
        {
        }

        public RScene(System.Object instance) : base("UnityEngine.SceneManagement.Scene")
		{
            SetInstance(instance);
		}

        public RScene(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScene(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsValidInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RIsValidInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetPathInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetPathInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void SetPathAndGUIDInternal(System.Int32  @sceneHandle, System.String  @path, System.String  @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @path, @guid};
            var ___result = RSetPathAndGUIDInternal_Int32_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetNameInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetNameInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void SetNameInternal(System.Int32  @sceneHandle, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @name};
            var ___result = RSetNameInternal_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetGUIDInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetGUIDInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean IsSubScene(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RIsSubScene_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetIsSubScene(System.Int32  @sceneHandle, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @value};
            var ___result = RSetIsSubScene_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetIsLoadedInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetIsLoadedInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object GetLoadingStateInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetLoadingStateInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean GetIsDirtyInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetIsDirtyInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetDirtyID(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetDirtyID_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetBuildIndexInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetBuildIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetRootCountInternal(System.Int32  @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RGetRootCountInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void GetRootGameObjectsInternal(System.Int32  @sceneHandle, System.Object  @resultRootList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @resultRootList};
            var ___result = RGetRootGameObjectsInternal_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.GameObject[] GetRootGameObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRootGameObjects.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject[])___result;
        }


        public virtual void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject>  @rootGameObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootGameObjects};
            var ___result = RGetRootGameObjects_List_d_GameObject_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean op_Equality(UnityEngine.SceneManagement.Scene  @lhs, UnityEngine.SceneManagement.Scene  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Scene_Scene.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.SceneManagement.Scene  @lhs, UnityEngine.SceneManagement.Scene  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Scene_Scene.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPathAndGuid(System.String  @path, System.String  @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @guid};
            var ___result = RSetPathAndGuid_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
