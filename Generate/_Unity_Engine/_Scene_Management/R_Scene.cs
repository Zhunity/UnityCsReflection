
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.SceneManagement.Scene
	/// </summary>
    public partial class RScene : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.SceneManagement.Scene);
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


		/// <summary>
		/// System.Int32 m_Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Handle;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Handle
		{
			get
			{
				if(r_Fm_Handle == null)
				{
					r_Fm_Handle = new(this, "m_Handle");
				}
				return r_Fm_Handle;
			}
		}

		/// <summary>
		/// Int32 handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Phandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPhandle
		{
			get
			{
				if(r_Phandle == null)
				{
					r_Phandle = new(this, "handle", -1);
				}
				return r_Phandle;
			}
		}

		/// <summary>
		/// LoadingState loadingState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement.RScene.RLoadingState r_PloadingState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement.RScene.RLoadingState RPloadingState
		{
			get
			{
				if(r_PloadingState == null)
				{
					r_PloadingState = new(this, "loadingState", -1);
				}
				return r_PloadingState;
			}
		}

		/// <summary>
		/// System.String guid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pguid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPguid
		{
			get
			{
				if(r_Pguid == null)
				{
					r_Pguid = new(this, "guid", -1);
				}
				return r_Pguid;
			}
		}

		/// <summary>
		/// System.String path
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ppath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpath
		{
			get
			{
				if(r_Ppath == null)
				{
					r_Ppath = new(this, "path", -1);
				}
				return r_Ppath;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Boolean isLoaded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisLoaded;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisLoaded
		{
			get
			{
				if(r_PisLoaded == null)
				{
					r_PisLoaded = new(this, "isLoaded", -1);
				}
				return r_PisLoaded;
			}
		}

		/// <summary>
		/// Int32 buildIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PbuildIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbuildIndex
		{
			get
			{
				if(r_PbuildIndex == null)
				{
					r_PbuildIndex = new(this, "buildIndex", -1);
				}
				return r_PbuildIndex;
			}
		}

		/// <summary>
		/// Boolean isDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDirty
		{
			get
			{
				if(r_PisDirty == null)
				{
					r_PisDirty = new(this, "isDirty", -1);
				}
				return r_PisDirty;
			}
		}

		/// <summary>
		/// Int32 dirtyID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdirtyID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdirtyID
		{
			get
			{
				if(r_PdirtyID == null)
				{
					r_PdirtyID = new(this, "dirtyID", -1);
				}
				return r_PdirtyID;
			}
		}

		/// <summary>
		/// Int32 rootCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_ProotCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RProotCount
		{
			get
			{
				if(r_ProotCount == null)
				{
					r_ProotCount = new(this, "rootCount", -1);
				}
				return r_ProotCount;
			}
		}

		/// <summary>
		/// Boolean isSubScene
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSubScene;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisSubScene
		{
			get
			{
				if(r_PisSubScene == null)
				{
					r_PisSubScene = new(this, "isSubScene", -1);
				}
				return r_PisSubScene;
			}
		}

		/// <summary>
		/// Boolean IsValidInternal(Int32)
		/// </summary>
		protected static RMethod r_MIsValidInternal_Int32;
		public static RMethod RMIsValidInternal_Int32
		{
			get
			{
				if(r_MIsValidInternal_Int32 == null)
				{
					r_MIsValidInternal_Int32 = new(Type, "IsValidInternal", 0, typeof(System.Int32));
				}
				return r_MIsValidInternal_Int32;
			}
		}

		/// <summary>
		/// System.String GetPathInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetPathInternal_Int32;
		public static RMethod RMGetPathInternal_Int32
		{
			get
			{
				if(r_MGetPathInternal_Int32 == null)
				{
					r_MGetPathInternal_Int32 = new(Type, "GetPathInternal", 0, typeof(System.Int32));
				}
				return r_MGetPathInternal_Int32;
			}
		}

		/// <summary>
		/// Void SetPathAndGUIDInternal(Int32, System.String, System.String)
		/// </summary>
		protected static RMethod r_MSetPathAndGUIDInternal_Int32_String_String;
		public static RMethod RMSetPathAndGUIDInternal_Int32_String_String
		{
			get
			{
				if(r_MSetPathAndGUIDInternal_Int32_String_String == null)
				{
					r_MSetPathAndGUIDInternal_Int32_String_String = new(Type, "SetPathAndGUIDInternal", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
				}
				return r_MSetPathAndGUIDInternal_Int32_String_String;
			}
		}

		/// <summary>
		/// System.String GetNameInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetNameInternal_Int32;
		public static RMethod RMGetNameInternal_Int32
		{
			get
			{
				if(r_MGetNameInternal_Int32 == null)
				{
					r_MGetNameInternal_Int32 = new(Type, "GetNameInternal", 0, typeof(System.Int32));
				}
				return r_MGetNameInternal_Int32;
			}
		}

		/// <summary>
		/// Void SetNameInternal(Int32, System.String)
		/// </summary>
		protected static RMethod r_MSetNameInternal_Int32_String;
		public static RMethod RMSetNameInternal_Int32_String
		{
			get
			{
				if(r_MSetNameInternal_Int32_String == null)
				{
					r_MSetNameInternal_Int32_String = new(Type, "SetNameInternal", 0, typeof(System.Int32), typeof(System.String));
				}
				return r_MSetNameInternal_Int32_String;
			}
		}

		/// <summary>
		/// System.String GetGUIDInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetGUIDInternal_Int32;
		public static RMethod RMGetGUIDInternal_Int32
		{
			get
			{
				if(r_MGetGUIDInternal_Int32 == null)
				{
					r_MGetGUIDInternal_Int32 = new(Type, "GetGUIDInternal", 0, typeof(System.Int32));
				}
				return r_MGetGUIDInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSubScene(Int32)
		/// </summary>
		protected static RMethod r_MIsSubScene_Int32;
		public static RMethod RMIsSubScene_Int32
		{
			get
			{
				if(r_MIsSubScene_Int32 == null)
				{
					r_MIsSubScene_Int32 = new(Type, "IsSubScene", 0, typeof(System.Int32));
				}
				return r_MIsSubScene_Int32;
			}
		}

		/// <summary>
		/// Void SetIsSubScene(Int32, Boolean)
		/// </summary>
		protected static RMethod r_MSetIsSubScene_Int32_Boolean;
		public static RMethod RMSetIsSubScene_Int32_Boolean
		{
			get
			{
				if(r_MSetIsSubScene_Int32_Boolean == null)
				{
					r_MSetIsSubScene_Int32_Boolean = new(Type, "SetIsSubScene", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MSetIsSubScene_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetIsLoadedInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetIsLoadedInternal_Int32;
		public static RMethod RMGetIsLoadedInternal_Int32
		{
			get
			{
				if(r_MGetIsLoadedInternal_Int32 == null)
				{
					r_MGetIsLoadedInternal_Int32 = new(Type, "GetIsLoadedInternal", 0, typeof(System.Int32));
				}
				return r_MGetIsLoadedInternal_Int32;
			}
		}

		/// <summary>
		/// LoadingState GetLoadingStateInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetLoadingStateInternal_Int32;
		public static RMethod RMGetLoadingStateInternal_Int32
		{
			get
			{
				if(r_MGetLoadingStateInternal_Int32 == null)
				{
					r_MGetLoadingStateInternal_Int32 = new(Type, "GetLoadingStateInternal", 0, typeof(System.Int32));
				}
				return r_MGetLoadingStateInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean GetIsDirtyInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetIsDirtyInternal_Int32;
		public static RMethod RMGetIsDirtyInternal_Int32
		{
			get
			{
				if(r_MGetIsDirtyInternal_Int32 == null)
				{
					r_MGetIsDirtyInternal_Int32 = new(Type, "GetIsDirtyInternal", 0, typeof(System.Int32));
				}
				return r_MGetIsDirtyInternal_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDirtyID(Int32)
		/// </summary>
		protected static RMethod r_MGetDirtyID_Int32;
		public static RMethod RMGetDirtyID_Int32
		{
			get
			{
				if(r_MGetDirtyID_Int32 == null)
				{
					r_MGetDirtyID_Int32 = new(Type, "GetDirtyID", 0, typeof(System.Int32));
				}
				return r_MGetDirtyID_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBuildIndexInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetBuildIndexInternal_Int32;
		public static RMethod RMGetBuildIndexInternal_Int32
		{
			get
			{
				if(r_MGetBuildIndexInternal_Int32 == null)
				{
					r_MGetBuildIndexInternal_Int32 = new(Type, "GetBuildIndexInternal", 0, typeof(System.Int32));
				}
				return r_MGetBuildIndexInternal_Int32;
			}
		}

		/// <summary>
		/// Int32 GetRootCountInternal(Int32)
		/// </summary>
		protected static RMethod r_MGetRootCountInternal_Int32;
		public static RMethod RMGetRootCountInternal_Int32
		{
			get
			{
				if(r_MGetRootCountInternal_Int32 == null)
				{
					r_MGetRootCountInternal_Int32 = new(Type, "GetRootCountInternal", 0, typeof(System.Int32));
				}
				return r_MGetRootCountInternal_Int32;
			}
		}

		/// <summary>
		/// Void GetRootGameObjectsInternal(Int32, System.Object)
		/// </summary>
		protected static RMethod r_MGetRootGameObjectsInternal_Int32_Object;
		public static RMethod RMGetRootGameObjectsInternal_Int32_Object
		{
			get
			{
				if(r_MGetRootGameObjectsInternal_Int32_Object == null)
				{
					r_MGetRootGameObjectsInternal_Int32_Object = new(Type, "GetRootGameObjectsInternal", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MGetRootGameObjectsInternal_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_MIsValid;
		public virtual RMethod RMIsValid
		{
			get
			{
				if(r_MIsValid == null)
				{
					r_MIsValid = new(this, "IsValid", 0);
				}
				return r_MIsValid;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] GetRootGameObjects()
		/// </summary>
		protected RMethod r_MGetRootGameObjects;
		public virtual RMethod RMGetRootGameObjects
		{
			get
			{
				if(r_MGetRootGameObjects == null)
				{
					r_MGetRootGameObjects = new(this, "GetRootGameObjects", 0);
				}
				return r_MGetRootGameObjects;
			}
		}

		/// <summary>
		/// Void GetRootGameObjects(System.Collections.Generic.List`1[UnityEngine.GameObject])
		/// </summary>
		protected RMethod r_MGetRootGameObjects_List_d_GameObject_p_;
		public virtual RMethod RMGetRootGameObjects_List_d_GameObject_p_
		{
			get
			{
				if(r_MGetRootGameObjects_List_d_GameObject_p_ == null)
				{
					r_MGetRootGameObjects_List_d_GameObject_p_ = new(this, "GetRootGameObjects", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.GameObject)));
				}
				return r_MGetRootGameObjects_List_d_GameObject_p_;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene)
		/// </summary>
		protected static RMethod r_Mop_Equality_Scene_Scene;
		public static RMethod RMop_Equality_Scene_Scene
		{
			get
			{
				if(r_Mop_Equality_Scene_Scene == null)
				{
					r_Mop_Equality_Scene_Scene = new(Type, "op_Equality", 0, typeof(UnityEngine.SceneManagement.Scene), typeof(UnityEngine.SceneManagement.Scene));
				}
				return r_Mop_Equality_Scene_Scene;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Scene_Scene;
		public static RMethod RMop_Inequality_Scene_Scene
		{
			get
			{
				if(r_Mop_Inequality_Scene_Scene == null)
				{
					r_Mop_Inequality_Scene_Scene = new(Type, "op_Inequality", 0, typeof(UnityEngine.SceneManagement.Scene), typeof(UnityEngine.SceneManagement.Scene));
				}
				return r_Mop_Inequality_Scene_Scene;
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
		/// Void SetPathAndGuid(System.String, System.String)
		/// </summary>
		protected RMethod r_MSetPathAndGuid_String_String;
		public virtual RMethod RMSetPathAndGuid_String_String
		{
			get
			{
				if(r_MSetPathAndGuid_String_String == null)
				{
					r_MSetPathAndGuid_String_String = new(this, "SetPathAndGuid", 0, typeof(System.String), typeof(System.String));
				}
				return r_MSetPathAndGuid_String_String;
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


        public static System.Boolean IsValidInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMIsValidInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.String GetPathInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetPathInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static void SetPathAndGUIDInternal(System.Int32 @sceneHandle, System.String @path, System.String @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @path, @guid};
            var ___result = RMSetPathAndGUIDInternal_Int32_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetNameInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetNameInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static void SetNameInternal(System.Int32 @sceneHandle, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @name};
            var ___result = RMSetNameInternal_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetGUIDInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetGUIDInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Boolean IsSubScene(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMIsSubScene_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void SetIsSubScene(System.Int32 @sceneHandle, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @value};
            var ___result = RMSetIsSubScene_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GetIsLoadedInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetIsLoadedInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement.RScene.RLoadingState GetLoadingStateInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetLoadingStateInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement.RScene.RLoadingState>(___result);
        }


        public static System.Boolean GetIsDirtyInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetIsDirtyInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 GetDirtyID(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetDirtyID_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetBuildIndexInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetBuildIndexInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetRootCountInternal(System.Int32 @sceneHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle};
            var ___result = RMGetRootCountInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static void GetRootGameObjectsInternal(System.Int32 @sceneHandle, System.Object @resultRootList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneHandle, @resultRootList};
            var ___result = RMGetRootGameObjectsInternal_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.GameObject[] GetRootGameObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootGameObjects.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GameObject[]>(___result);
        }


        public virtual void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> @rootGameObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootGameObjects};
            var ___result = RMGetRootGameObjects_List_d_GameObject_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean op_Equality(UnityEngine.SceneManagement.Scene @lhs, UnityEngine.SceneManagement.Scene @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Scene_Scene.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.SceneManagement.Scene @lhs, UnityEngine.SceneManagement.Scene @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Scene_Scene.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetPathAndGuid(System.String @path, System.String @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @guid};
            var ___result = RMSetPathAndGuid_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
