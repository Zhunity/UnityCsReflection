using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction.RUnityEngine.RSceneManagement;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RGameObject : RMember
    {
		public  RTransform transform; //UnityEngine.Transform
		public  RProperty layer; //System.Int32
		public  RProperty active; //System.Boolean
		public  RProperty activeSelf; //System.Boolean
		public  RProperty activeInHierarchy; //System.Boolean
		public  RProperty isStatic; //System.Boolean
		public  RProperty isStaticBatchable; //System.Boolean
		public  RProperty tag; //System.String
		public  RScene scene; //UnityEngine.SceneManagement.Scene
		public  RProperty sceneCullingMask; //System.UInt64
		public  RGameObject gameObject; //UnityEngine.GameObject
		public  RComponent rigidbody; //UnityEngine.Component
		public  RComponent rigidbody2D; //UnityEngine.Component
		public  RComponent camera; //UnityEngine.Component
		public  RComponent light; //UnityEngine.Component
		public  RComponent animation; //UnityEngine.Component
		public  RComponent constantForce; //UnityEngine.Component
		public  RComponent renderer; //UnityEngine.Component
		public  RComponent audio; //UnityEngine.Component
		public  RComponent networkView; //UnityEngine.Component
		public  RComponent collider; //UnityEngine.Component
		public  RComponent collider2D; //UnityEngine.Component
		public  RComponent hingeJoint; //UnityEngine.Component
		public  RComponent particleSystem; //UnityEngine.Component
		public  RProperty name; //System.String
		public  RProperty hideFlags; //UnityEngine.HideFlags
		public static RMethod RCreatePrimitive_PrimitiveType; //UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType)
		public  RMethod RGetComponent_GT; //T GetComponent[T]()
		public  RMethod RGetComponent_Type; //UnityEngine.Component GetComponent(System.Type)
		public  RMethod RGetComponentFastPath_Type_IntPtr; //Void GetComponentFastPath(System.Type, IntPtr)
		public  RMethod RGetComponentByName_String; //UnityEngine.Component GetComponentByName(System.String)
		public  RMethod RGetComponent_String; //UnityEngine.Component GetComponent(System.String)
		public  RMethod RGetComponentInChildren_Type_Boolean; //UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		public  RMethod RGetComponentInChildren_Type; //UnityEngine.Component GetComponentInChildren(System.Type)
		public  RMethod RGetComponentInChildren_GT; //T GetComponentInChildren[T]()
		public  RMethod RGetComponentInChildren_GT_Boolean; //T GetComponentInChildren[T](Boolean)
		public  RMethod RGetComponentInParent_Type_Boolean; //UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		public  RMethod RGetComponentInParent_Type; //UnityEngine.Component GetComponentInParent(System.Type)
		public  RMethod RGetComponentInParent_GT; //T GetComponentInParent[T]()
		public  RMethod RGetComponentInParent_GT_Boolean; //T GetComponentInParent[T](Boolean)
		public  RMethod RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object; //System.Array GetComponentsInternal(System.Type, Boolean, Boolean, Boolean, Boolean, System.Object)
		public  RMethod RGetComponents_Type; //UnityEngine.Component[] GetComponents(System.Type)
		public  RMethod RGetComponents_GT; //T[] GetComponents[T]()
		public  RMethod RGetComponents_Type_List_d_Component_p_; //Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		public  RMethod RGetComponents_GT_List_d_T_p_; //Void GetComponents[T](System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentsInChildren_Type; //UnityEngine.Component[] GetComponentsInChildren(System.Type)
		public  RMethod RGetComponentsInChildren_Type_Boolean; //UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		public  RMethod RGetComponentsInChildren_GT_Boolean; //T[] GetComponentsInChildren[T](Boolean)
		public  RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_; //Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentsInChildren_GT; //T[] GetComponentsInChildren[T]()
		public  RMethod RGetComponentsInChildren_GT_List_d_T_p_; //Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentsInParent_Type; //UnityEngine.Component[] GetComponentsInParent(System.Type)
		public  RMethod RGetComponentsInParent_Type_Boolean; //UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		public  RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_; //Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentsInParent_GT_Boolean; //T[] GetComponentsInParent[T](Boolean)
		public  RMethod RGetComponentsInParent_GT; //T[] GetComponentsInParent[T]()
		public  RMethod RTryGetComponent_GT_Out_T; //Boolean TryGetComponent[T](T ByRef)
		public  RMethod RTryGetComponent_Type_Out_Component; //Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		public  RMethod RTryGetComponentInternal_Type; //UnityEngine.Component TryGetComponentInternal(System.Type)
		public  RMethod RTryGetComponentFastPath_Type_IntPtr; //Void TryGetComponentFastPath(System.Type, IntPtr)
		public static RMethod RFindWithTag_String; //UnityEngine.GameObject FindWithTag(System.String)
		public  RMethod RSendMessageUpwards_String_SendMessageOptions; //Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		public  RMethod RSendMessage_String_SendMessageOptions; //Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		public  RMethod RBroadcastMessage_String_SendMessageOptions; //Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		public  RMethod RAddComponentInternal_String; //UnityEngine.Component AddComponentInternal(System.String)
		public  RMethod RInternal_AddComponentWithType_Type; //UnityEngine.Component Internal_AddComponentWithType(System.Type)
		public  RMethod RAddComponent_Type; //UnityEngine.Component AddComponent(System.Type)
		public  RMethod RAddComponent_GT; //T AddComponent[T]()
		public  RMethod RSetActive_Boolean; //Void SetActive(Boolean)
		public  RMethod RSetActiveRecursively_Boolean; //Void SetActiveRecursively(Boolean)
		public  RMethod RCompareTag_String; //Boolean CompareTag(System.String)
		public static RMethod RFindGameObjectWithTag_String; //UnityEngine.GameObject FindGameObjectWithTag(System.String)
		public static RMethod RFindGameObjectsWithTag_String; //UnityEngine.GameObject[] FindGameObjectsWithTag(System.String)
		public  RMethod RSendMessageUpwards_String_Object_SendMessageOptions; //Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  RMethod RSendMessageUpwards_String_Object; //Void SendMessageUpwards(System.String, System.Object)
		public  RMethod RSendMessageUpwards_String; //Void SendMessageUpwards(System.String)
		public  RMethod RSendMessage_String_Object_SendMessageOptions; //Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  RMethod RSendMessage_String_Object; //Void SendMessage(System.String, System.Object)
		public  RMethod RSendMessage_String; //Void SendMessage(System.String)
		public  RMethod RBroadcastMessage_String_Object_SendMessageOptions; //Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  RMethod RBroadcastMessage_String_Object; //Void BroadcastMessage(System.String, System.Object)
		public  RMethod RBroadcastMessage_String; //Void BroadcastMessage(System.String)
		public static RMethod RInternal_CreateGameObject_GameObject_String; //Void Internal_CreateGameObject(UnityEngine.GameObject, System.String)
		public static RMethod RFind_String; //UnityEngine.GameObject Find(System.String)
		public  RMethod RCalculateBounds; //UnityEngine.Bounds CalculateBounds()
		public  RMethod RIsMarkedVisible; //Int32 IsMarkedVisible()
		public  RMethod RSampleAnimation_Object_Single; //Void SampleAnimation(UnityEngine.Object, Single)
		public  RMethod RAddComponent_String; //UnityEngine.Component AddComponent(System.String)
		public  RMethod RPlayAnimation_Object; //Void PlayAnimation(UnityEngine.Object)
		public  RMethod RStopAnimation; //Void StopAnimation()
		public  RMethod Rget_scene_Injected_Out_Scene; //Void get_scene_Injected(UnityEngine.SceneManagement.Scene ByRef)
		public  RMethod RCalculateBounds_Injected_Out_Bounds; //Void CalculateBounds_Injected(UnityEngine.Bounds ByRef)
		public  RMethod RGetInstanceID; //Int32 GetInstanceID()
		public  RMethod RGetHashCode; //Int32 GetHashCode()
		public  RMethod REquals_Object; //Boolean Equals(System.Object)
		public  RMethod RToString; //System.String ToString()
		public  RMethod RFinalize; //Void Finalize()
		public  RMethod RGetType; //System.Type GetType()
		public  RMethod RMemberwiseClone; //System.Object MemberwiseClone()


        public RGameObject() : base("UnityEngine.GameObject")
        {
            NewMembers();
        }

        public RGameObject(System.Object instance) : base("UnityEngine.GameObject")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RGameObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			
			RCreatePrimitive_PrimitiveType = new RMethod(this, "CreatePrimitive", 0, typeof(UnityEngine.PrimitiveType));
			RGetComponent_GT = new RMethod(this, "GetComponent", 1);
			RGetComponent_Type = new RMethod(this, "GetComponent", 0, typeof(System.Type));
			RGetComponentFastPath_Type_IntPtr = new RMethod(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
			RGetComponentByName_String = new RMethod(this, "GetComponentByName", 0, typeof(System.String));
			RGetComponent_String = new RMethod(this, "GetComponent", 0, typeof(System.String));
			RGetComponentInChildren_Type_Boolean = new RMethod(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInChildren_Type = new RMethod(this, "GetComponentInChildren", 0, typeof(System.Type));
			RGetComponentInChildren_GT = new RMethod(this, "GetComponentInChildren", 1);
			RGetComponentInChildren_GT_Boolean = new RMethod(this, "GetComponentInChildren", 1, typeof(System.Boolean));
			RGetComponentInParent_Type_Boolean = new RMethod(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInParent_Type = new RMethod(this, "GetComponentInParent", 0, typeof(System.Type));
			RGetComponentInParent_GT = new RMethod(this, "GetComponentInParent", 1);
			RGetComponentInParent_GT_Boolean = new RMethod(this, "GetComponentInParent", 1, typeof(System.Boolean));
			RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object = new RMethod(this, "GetComponentsInternal", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Object));
			RGetComponents_Type = new RMethod(this, "GetComponents", 0, typeof(System.Type));
			RGetComponents_GT = new RMethod(this, "GetComponents", 1);
			RGetComponents_Type_List_d_Component_p_ = new RMethod(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
			RGetComponents_GT_List_d_T_p_ = new RMethod(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInChildren_Type = new RMethod(this, "GetComponentsInChildren", 0, typeof(System.Type));
			RGetComponentsInChildren_Type_Boolean = new RMethod(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInChildren_GT_Boolean = new RMethod(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
			RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new RMethod(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInChildren_GT = new RMethod(this, "GetComponentsInChildren", 1);
			RGetComponentsInChildren_GT_List_d_T_p_ = new RMethod(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInParent_Type = new RMethod(this, "GetComponentsInParent", 0, typeof(System.Type));
			RGetComponentsInParent_Type_Boolean = new RMethod(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new RMethod(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInParent_GT_Boolean = new RMethod(this, "GetComponentsInParent", 1, typeof(System.Boolean));
			RGetComponentsInParent_GT = new RMethod(this, "GetComponentsInParent", 1);
			RTryGetComponent_GT_Out_T = new RMethod(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
			RTryGetComponent_Type_Out_Component = new RMethod(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
			RTryGetComponentInternal_Type = new RMethod(this, "TryGetComponentInternal", 0, typeof(System.Type));
			RTryGetComponentFastPath_Type_IntPtr = new RMethod(this, "TryGetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
			RFindWithTag_String = new RMethod(this, "FindWithTag", 0, typeof(System.String));
			RSendMessageUpwards_String_SendMessageOptions = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_SendMessageOptions = new RMethod(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_SendMessageOptions = new RMethod(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RAddComponentInternal_String = new RMethod(this, "AddComponentInternal", 0, typeof(System.String));
			RInternal_AddComponentWithType_Type = new RMethod(this, "Internal_AddComponentWithType", 0, typeof(System.Type));
			RAddComponent_Type = new RMethod(this, "AddComponent", 0, typeof(System.Type));
			RAddComponent_GT = new RMethod(this, "AddComponent", 1);
			RSetActive_Boolean = new RMethod(this, "SetActive", 0, typeof(System.Boolean));
			RSetActiveRecursively_Boolean = new RMethod(this, "SetActiveRecursively", 0, typeof(System.Boolean));
			RCompareTag_String = new RMethod(this, "CompareTag", 0, typeof(System.String));
			RFindGameObjectWithTag_String = new RMethod(this, "FindGameObjectWithTag", 0, typeof(System.String));
			RFindGameObjectsWithTag_String = new RMethod(this, "FindGameObjectsWithTag", 0, typeof(System.String));
			RSendMessageUpwards_String_Object_SendMessageOptions = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessageUpwards_String_Object = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
			RSendMessageUpwards_String = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String));
			RSendMessage_String_Object_SendMessageOptions = new RMethod(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_Object = new RMethod(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
			RSendMessage_String = new RMethod(this, "SendMessage", 0, typeof(System.String));
			RBroadcastMessage_String_Object_SendMessageOptions = new RMethod(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_Object = new RMethod(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
			RBroadcastMessage_String = new RMethod(this, "BroadcastMessage", 0, typeof(System.String));
			RInternal_CreateGameObject_GameObject_String = new RMethod(this, "Internal_CreateGameObject", 0, typeof(UnityEngine.GameObject), typeof(System.String));
			RFind_String = new RMethod(this, "Find", 0, typeof(System.String));
			RCalculateBounds = new RMethod(this, "CalculateBounds", 0);
			RIsMarkedVisible = new RMethod(this, "IsMarkedVisible", 0);
			RSampleAnimation_Object_Single = new RMethod(this, "SampleAnimation", 0, typeof(UnityEngine.Object), typeof(System.Single));
			RAddComponent_String = new RMethod(this, "AddComponent", 0, typeof(System.String));
			RPlayAnimation_Object = new RMethod(this, "PlayAnimation", 0, typeof(UnityEngine.Object));
			RStopAnimation = new RMethod(this, "StopAnimation", 0);
			Rget_scene_Injected_Out_Scene = new RMethod(this, "get_scene_Injected", 0, typeof(UnityEngine.SceneManagement.Scene).MakeByRefType());
			RCalculateBounds_Injected_Out_Bounds = new RMethod(this, "CalculateBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
			RGetInstanceID = new RMethod(this, "GetInstanceID", 0);
			RGetHashCode = new RMethod(this, "GetHashCode", 0);
			REquals_Object = new RMethod(this, "Equals", 0, typeof(System.Object));
			RToString = new RMethod(this, "ToString", 0);
			RFinalize = new RMethod(this, "Finalize", 0);
			RGetType = new RMethod(this, "GetType", 0);
			RMemberwiseClone = new RMethod(this, "MemberwiseClone", 0);

        }

        public static UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RCreatePrimitive_PrimitiveType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }

        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual UnityEngine.Component GetComponent(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual void GetComponentFastPath(System.Type  @type, System.IntPtr  @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Component GetComponentByName(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentByName_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponent(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @type, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual T GetComponentInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual UnityEngine.Component GetComponentInParent(System.Type  @type, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponentInParent(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual T GetComponentInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual System.Array GetComponentsInternal(System.Type  @type, System.Boolean  @useSearchTypeAsArrayReturnType, System.Boolean  @recursive, System.Boolean  @includeInactive, System.Boolean  @reverse, System.Object  @resultList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @useSearchTypeAsArrayReturnType, @recursive, @includeInactive, @reverse, @resultList};
            var ___result = RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }

        public virtual UnityEngine.Component[] GetComponents(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual void GetComponents(System.Type  @type, System.Collections.Generic.List<UnityEngine.Component>  @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void GetComponents<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @type, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual T[] GetComponentsInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual void GetComponentsInChildren<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInChildren_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual T[] GetComponentsInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @type, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual void GetComponentsInParent<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual T[] GetComponentsInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual System.Boolean TryGetComponent<T>(out T  @component)
        {
			component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			component = (T)___parameters[0];

            return (System.Boolean)___result;
        }

        public virtual System.Boolean TryGetComponent(System.Type  @type, out UnityEngine.Component  @component)
        {
			component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }

        public virtual UnityEngine.Component TryGetComponentInternal(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RTryGetComponentInternal_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual void TryGetComponentFastPath(System.Type  @type, System.IntPtr  @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RTryGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }

        public static UnityEngine.GameObject FindWithTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RFindWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }

        public virtual void SendMessageUpwards(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void BroadcastMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Component AddComponentInternal(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RAddComponentInternal_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component Internal_AddComponentWithType(System.Type  @componentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@componentType};
            var ___result = RInternal_AddComponentWithType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component AddComponent(System.Type  @componentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@componentType};
            var ___result = RAddComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual T AddComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RAddComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual void SetActive(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetActive_Boolean.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetActiveRecursively(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetActiveRecursively_Boolean.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.Boolean CompareTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public static UnityEngine.GameObject FindGameObjectWithTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RFindGameObjectWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }

        public static UnityEngine.GameObject[] FindGameObjectsWithTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RFindGameObjectsWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject[])___result;
        }

        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessageUpwards(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessage(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessage(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void BroadcastMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }

        public static void Internal_CreateGameObject(UnityEngine.GameObject  @self, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @name};
            var ___result = RInternal_CreateGameObject_GameObject_String.Invoke(___genericsType, ___parameters);

            
        }

        public static UnityEngine.GameObject Find(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFind_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }

        public virtual UnityEngine.Bounds CalculateBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalculateBounds.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Bounds)___result;
        }

        public virtual System.Int32 IsMarkedVisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsMarkedVisible.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public virtual void SampleAnimation(UnityEngine.Object  @clip, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @time};
            var ___result = RSampleAnimation_Object_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Component AddComponent(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RAddComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual void PlayAnimation(UnityEngine.Object  @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RPlayAnimation_Object.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void StopAnimation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopAnimation.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void get_scene_Injected(out UnityEngine.SceneManagement.Scene  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_scene_Injected_Out_Scene.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
        }

        public virtual void CalculateBounds_Injected(out UnityEngine.Bounds  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RCalculateBounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Bounds)___parameters[0];

            
        }

        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
