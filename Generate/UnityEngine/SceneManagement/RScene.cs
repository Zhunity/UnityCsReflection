using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RSceneManagement
{
    public partial class RScene : Member
    {
		public  Property handle; //System.Int32
		public  Property loadingState; //UnityEngine.SceneManagement.Scene+LoadingState
		public  Property guid; //System.String
		public  Property path; //System.String
		public  Property name; //System.String
		public  Property isLoaded; //System.Boolean
		public  Property buildIndex; //System.Int32
		public  Property isDirty; //System.Boolean
		public  Property dirtyID; //System.Int32
		public  Property rootCount; //System.Int32
		public  Property isSubScene; //System.Boolean
		public  Field m_Handle; //System.Int32
		public static Method RIsValidInternal_Int32; //Boolean IsValidInternal(Int32)
		public static Method RGetPathInternal_Int32; //System.String GetPathInternal(Int32)
		public static Method RSetPathAndGUIDInternal_Int32_String_String; //Void SetPathAndGUIDInternal(Int32, System.String, System.String)
		public static Method RGetNameInternal_Int32; //System.String GetNameInternal(Int32)
		public static Method RSetNameInternal_Int32_String; //Void SetNameInternal(Int32, System.String)
		public static Method RGetGUIDInternal_Int32; //System.String GetGUIDInternal(Int32)
		public static Method RIsSubScene_Int32; //Boolean IsSubScene(Int32)
		public static Method RSetIsSubScene_Int32_Boolean; //Void SetIsSubScene(Int32, Boolean)
		public static Method RGetIsLoadedInternal_Int32; //Boolean GetIsLoadedInternal(Int32)
		public static Method RGetLoadingStateInternal_Int32; //LoadingState GetLoadingStateInternal(Int32)
		public static Method RGetIsDirtyInternal_Int32; //Boolean GetIsDirtyInternal(Int32)
		public static Method RGetDirtyID_Int32; //Int32 GetDirtyID(Int32)
		public static Method RGetBuildIndexInternal_Int32; //Int32 GetBuildIndexInternal(Int32)
		public static Method RGetRootCountInternal_Int32; //Int32 GetRootCountInternal(Int32)
		public static Method RGetRootGameObjectsInternal_Int32_Object; //Void GetRootGameObjectsInternal(Int32, System.Object)
		public  Method RIsValid; //Boolean IsValid()
		public  Method RGetRootGameObjects; //UnityEngine.GameObject[] GetRootGameObjects()
		public  Method RGetRootGameObjects_List_d_GameObject_p_; //Void GetRootGameObjects(System.Collections.Generic.List`1[UnityEngine.GameObject])
		public static Method Rop_Equality_Scene_Scene; //Boolean op_Equality(UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene)
		public static Method Rop_Inequality_Scene_Scene; //Boolean op_Inequality(UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene)
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method RSetPathAndGuid_String_String; //Void SetPathAndGuid(System.String, System.String)
		public  Method RToString; //System.String ToString()
		public  Method RFinalize; //Void Finalize()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()


        public RScene() : base("UnityEngine.SceneManagement.Scene")
        {
            NewMembers();
        }

        public RScene(System.Object instance) : base("UnityEngine.SceneManagement.Scene")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RScene(Member belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			handle = new Property(this, "handle", -1);
			loadingState = new Property(this, "loadingState", -1);
			guid = new Property(this, "guid", -1);
			path = new Property(this, "path", -1);
			name = new Property(this, "name", -1);
			isLoaded = new Property(this, "isLoaded", -1);
			buildIndex = new Property(this, "buildIndex", -1);
			isDirty = new Property(this, "isDirty", -1);
			dirtyID = new Property(this, "dirtyID", -1);
			rootCount = new Property(this, "rootCount", -1);
			isSubScene = new Property(this, "isSubScene", -1);
			m_Handle = new Field(this, "m_Handle");
			RIsValidInternal_Int32 = new Method(this, "IsValidInternal", 0, typeof(System.Int32));
			RGetPathInternal_Int32 = new Method(this, "GetPathInternal", 0, typeof(System.Int32));
			RSetPathAndGUIDInternal_Int32_String_String = new Method(this, "SetPathAndGUIDInternal", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
			RGetNameInternal_Int32 = new Method(this, "GetNameInternal", 0, typeof(System.Int32));
			RSetNameInternal_Int32_String = new Method(this, "SetNameInternal", 0, typeof(System.Int32), typeof(System.String));
			RGetGUIDInternal_Int32 = new Method(this, "GetGUIDInternal", 0, typeof(System.Int32));
			RIsSubScene_Int32 = new Method(this, "IsSubScene", 0, typeof(System.Int32));
			RSetIsSubScene_Int32_Boolean = new Method(this, "SetIsSubScene", 0, typeof(System.Int32), typeof(System.Boolean));
			RGetIsLoadedInternal_Int32 = new Method(this, "GetIsLoadedInternal", 0, typeof(System.Int32));
			RGetLoadingStateInternal_Int32 = new Method(this, "GetLoadingStateInternal", 0, typeof(System.Int32));
			RGetIsDirtyInternal_Int32 = new Method(this, "GetIsDirtyInternal", 0, typeof(System.Int32));
			RGetDirtyID_Int32 = new Method(this, "GetDirtyID", 0, typeof(System.Int32));
			RGetBuildIndexInternal_Int32 = new Method(this, "GetBuildIndexInternal", 0, typeof(System.Int32));
			RGetRootCountInternal_Int32 = new Method(this, "GetRootCountInternal", 0, typeof(System.Int32));
			RGetRootGameObjectsInternal_Int32_Object = new Method(this, "GetRootGameObjectsInternal", 0, typeof(System.Int32), typeof(System.Object));
			RIsValid = new Method(this, "IsValid", 0);
			RGetRootGameObjects = new Method(this, "GetRootGameObjects", 0);
			RGetRootGameObjects_List_d_GameObject_p_ = new Method(this, "GetRootGameObjects", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.GameObject)));
			Rop_Equality_Scene_Scene = new Method(this, "op_Equality", 0, typeof(UnityEngine.SceneManagement.Scene), typeof(UnityEngine.SceneManagement.Scene));
			Rop_Inequality_Scene_Scene = new Method(this, "op_Inequality", 0, typeof(UnityEngine.SceneManagement.Scene), typeof(UnityEngine.SceneManagement.Scene));
			RGetHashCode = new Method(this, "GetHashCode", 0);
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RSetPathAndGuid_String_String = new Method(this, "SetPathAndGuid", 0, typeof(System.String), typeof(System.String));
			RToString = new Method(this, "ToString", 0);
			RFinalize = new Method(this, "Finalize", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);

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
