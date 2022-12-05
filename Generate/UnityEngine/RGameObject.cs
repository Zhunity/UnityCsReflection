using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction.RUnityEngine.RSceneManagement;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RGameObject : Member
    {
		public  RTransform transform; //UnityEngine.Transform
		public  Property layer; //System.Int32
		public  Property active; //System.Boolean
		public  Property activeSelf; //System.Boolean
		public  Property activeInHierarchy; //System.Boolean
		public  Property isStatic; //System.Boolean
		public  Property isStaticBatchable; //System.Boolean
		public  Property tag; //System.String
		public  RScene scene; //UnityEngine.SceneManagement.Scene
		public  Property sceneCullingMask; //System.UInt64
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
		public  Property name; //System.String
		public  Property hideFlags; //UnityEngine.HideFlags
		public static Method RCreatePrimitive_PrimitiveType; //UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType)
		public  Method RGetComponent_GT; //T GetComponent[T]()
		public  Method RGetComponent_Type; //UnityEngine.Component GetComponent(System.Type)
		public  Method RGetComponentFastPath_Type_IntPtr; //Void GetComponentFastPath(System.Type, IntPtr)
		public  Method RGetComponentByName_String; //UnityEngine.Component GetComponentByName(System.String)
		public  Method RGetComponent_String; //UnityEngine.Component GetComponent(System.String)
		public  Method RGetComponentInChildren_Type_Boolean; //UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		public  Method RGetComponentInChildren_Type; //UnityEngine.Component GetComponentInChildren(System.Type)
		public  Method RGetComponentInChildren_GT; //T GetComponentInChildren[T]()
		public  Method RGetComponentInChildren_GT_Boolean; //T GetComponentInChildren[T](Boolean)
		public  Method RGetComponentInParent_Type_Boolean; //UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		public  Method RGetComponentInParent_Type; //UnityEngine.Component GetComponentInParent(System.Type)
		public  Method RGetComponentInParent_GT; //T GetComponentInParent[T]()
		public  Method RGetComponentInParent_GT_Boolean; //T GetComponentInParent[T](Boolean)
		public  Method RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object; //System.Array GetComponentsInternal(System.Type, Boolean, Boolean, Boolean, Boolean, System.Object)
		public  Method RGetComponents_Type; //UnityEngine.Component[] GetComponents(System.Type)
		public  Method RGetComponents_GT; //T[] GetComponents[T]()
		public  Method RGetComponents_Type_List_d_Component_p_; //Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		public  Method RGetComponents_GT_List_d_T_p_; //Void GetComponents[T](System.Collections.Generic.List`1[T])
		public  Method RGetComponentsInChildren_Type; //UnityEngine.Component[] GetComponentsInChildren(System.Type)
		public  Method RGetComponentsInChildren_Type_Boolean; //UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		public  Method RGetComponentsInChildren_GT_Boolean; //T[] GetComponentsInChildren[T](Boolean)
		public  Method RGetComponentsInChildren_GT_Boolean_List_d_T_p_; //Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		public  Method RGetComponentsInChildren_GT; //T[] GetComponentsInChildren[T]()
		public  Method RGetComponentsInChildren_GT_List_d_T_p_; //Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		public  Method RGetComponentsInParent_Type; //UnityEngine.Component[] GetComponentsInParent(System.Type)
		public  Method RGetComponentsInParent_Type_Boolean; //UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		public  Method RGetComponentsInParent_GT_Boolean_List_d_T_p_; //Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		public  Method RGetComponentsInParent_GT_Boolean; //T[] GetComponentsInParent[T](Boolean)
		public  Method RGetComponentsInParent_GT; //T[] GetComponentsInParent[T]()
		public  Method RTryGetComponent_GT_Out_T; //Boolean TryGetComponent[T](T ByRef)
		public  Method RTryGetComponent_Type_Out_Component; //Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		public  Method RTryGetComponentInternal_Type; //UnityEngine.Component TryGetComponentInternal(System.Type)
		public  Method RTryGetComponentFastPath_Type_IntPtr; //Void TryGetComponentFastPath(System.Type, IntPtr)
		public static Method RFindWithTag_String; //UnityEngine.GameObject FindWithTag(System.String)
		public  Method RSendMessageUpwards_String_SendMessageOptions; //Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		public  Method RSendMessage_String_SendMessageOptions; //Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		public  Method RBroadcastMessage_String_SendMessageOptions; //Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		public  Method RAddComponentInternal_String; //UnityEngine.Component AddComponentInternal(System.String)
		public  Method RInternal_AddComponentWithType_Type; //UnityEngine.Component Internal_AddComponentWithType(System.Type)
		public  Method RAddComponent_Type; //UnityEngine.Component AddComponent(System.Type)
		public  Method RAddComponent_GT; //T AddComponent[T]()
		public  Method RSetActive_Boolean; //Void SetActive(Boolean)
		public  Method RSetActiveRecursively_Boolean; //Void SetActiveRecursively(Boolean)
		public  Method RCompareTag_String; //Boolean CompareTag(System.String)
		public static Method RFindGameObjectWithTag_String; //UnityEngine.GameObject FindGameObjectWithTag(System.String)
		public static Method RFindGameObjectsWithTag_String; //UnityEngine.GameObject[] FindGameObjectsWithTag(System.String)
		public  Method RSendMessageUpwards_String_Object_SendMessageOptions; //Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  Method RSendMessageUpwards_String_Object; //Void SendMessageUpwards(System.String, System.Object)
		public  Method RSendMessageUpwards_String; //Void SendMessageUpwards(System.String)
		public  Method RSendMessage_String_Object_SendMessageOptions; //Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  Method RSendMessage_String_Object; //Void SendMessage(System.String, System.Object)
		public  Method RSendMessage_String; //Void SendMessage(System.String)
		public  Method RBroadcastMessage_String_Object_SendMessageOptions; //Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  Method RBroadcastMessage_String_Object; //Void BroadcastMessage(System.String, System.Object)
		public  Method RBroadcastMessage_String; //Void BroadcastMessage(System.String)
		public static Method RInternal_CreateGameObject_GameObject_String; //Void Internal_CreateGameObject(UnityEngine.GameObject, System.String)
		public static Method RFind_String; //UnityEngine.GameObject Find(System.String)
		public  Method RCalculateBounds; //UnityEngine.Bounds CalculateBounds()
		public  Method RIsMarkedVisible; //Int32 IsMarkedVisible()
		public  Method RSampleAnimation_Object_Single; //Void SampleAnimation(UnityEngine.Object, Single)
		public  Method RAddComponent_String; //UnityEngine.Component AddComponent(System.String)
		public  Method RPlayAnimation_Object; //Void PlayAnimation(UnityEngine.Object)
		public  Method RStopAnimation; //Void StopAnimation()
		public  Method Rget_scene_Injected_Out_Scene; //Void get_scene_Injected(UnityEngine.SceneManagement.Scene ByRef)
		public  Method RCalculateBounds_Injected_Out_Bounds; //Void CalculateBounds_Injected(UnityEngine.Bounds ByRef)
		public  Method RGetInstanceID; //Int32 GetInstanceID()
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method RToString; //System.String ToString()
		public  Method RFinalize; //Void Finalize()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()


        public RGameObject() : base("UnityEngine.GameObject")
        {
            NewMembers();
        }

        public RGameObject(System.Object instance) : base("UnityEngine.GameObject")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RGameObject(Member belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			transform = new RTransform(this, "transform", -1);
			layer = new Property(this, "layer", -1);
			active = new Property(this, "active", -1);
			activeSelf = new Property(this, "activeSelf", -1);
			activeInHierarchy = new Property(this, "activeInHierarchy", -1);
			isStatic = new Property(this, "isStatic", -1);
			isStaticBatchable = new Property(this, "isStaticBatchable", -1);
			tag = new Property(this, "tag", -1);
			scene = new RScene(this, "scene", -1);
			sceneCullingMask = new Property(this, "sceneCullingMask", -1);
			gameObject = new RGameObject(this, "gameObject", -1);
			rigidbody = new RComponent(this, "rigidbody", -1);
			rigidbody2D = new RComponent(this, "rigidbody2D", -1);
			camera = new RComponent(this, "camera", -1);
			light = new RComponent(this, "light", -1);
			animation = new RComponent(this, "animation", -1);
			constantForce = new RComponent(this, "constantForce", -1);
			renderer = new RComponent(this, "renderer", -1);
			audio = new RComponent(this, "audio", -1);
			networkView = new RComponent(this, "networkView", -1);
			collider = new RComponent(this, "collider", -1);
			collider2D = new RComponent(this, "collider2D", -1);
			hingeJoint = new RComponent(this, "hingeJoint", -1);
			particleSystem = new RComponent(this, "particleSystem", -1);
			name = new Property(this, "name", -1);
			hideFlags = new Property(this, "hideFlags", -1);
			RCreatePrimitive_PrimitiveType = new Method(this, "CreatePrimitive", 0, typeof(UnityEngine.PrimitiveType));
			RGetComponent_GT = new Method(this, "GetComponent", 1);
			RGetComponent_Type = new Method(this, "GetComponent", 0, typeof(System.Type));
			RGetComponentFastPath_Type_IntPtr = new Method(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
			RGetComponentByName_String = new Method(this, "GetComponentByName", 0, typeof(System.String));
			RGetComponent_String = new Method(this, "GetComponent", 0, typeof(System.String));
			RGetComponentInChildren_Type_Boolean = new Method(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInChildren_Type = new Method(this, "GetComponentInChildren", 0, typeof(System.Type));
			RGetComponentInChildren_GT = new Method(this, "GetComponentInChildren", 1);
			RGetComponentInChildren_GT_Boolean = new Method(this, "GetComponentInChildren", 1, typeof(System.Boolean));
			RGetComponentInParent_Type_Boolean = new Method(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInParent_Type = new Method(this, "GetComponentInParent", 0, typeof(System.Type));
			RGetComponentInParent_GT = new Method(this, "GetComponentInParent", 1);
			RGetComponentInParent_GT_Boolean = new Method(this, "GetComponentInParent", 1, typeof(System.Boolean));
			RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object = new Method(this, "GetComponentsInternal", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Object));
			RGetComponents_Type = new Method(this, "GetComponents", 0, typeof(System.Type));
			RGetComponents_GT = new Method(this, "GetComponents", 1);
			RGetComponents_Type_List_d_Component_p_ = new Method(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
			RGetComponents_GT_List_d_T_p_ = new Method(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInChildren_Type = new Method(this, "GetComponentsInChildren", 0, typeof(System.Type));
			RGetComponentsInChildren_Type_Boolean = new Method(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInChildren_GT_Boolean = new Method(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
			RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new Method(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInChildren_GT = new Method(this, "GetComponentsInChildren", 1);
			RGetComponentsInChildren_GT_List_d_T_p_ = new Method(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInParent_Type = new Method(this, "GetComponentsInParent", 0, typeof(System.Type));
			RGetComponentsInParent_Type_Boolean = new Method(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new Method(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInParent_GT_Boolean = new Method(this, "GetComponentsInParent", 1, typeof(System.Boolean));
			RGetComponentsInParent_GT = new Method(this, "GetComponentsInParent", 1);
			RTryGetComponent_GT_Out_T = new Method(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
			RTryGetComponent_Type_Out_Component = new Method(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
			RTryGetComponentInternal_Type = new Method(this, "TryGetComponentInternal", 0, typeof(System.Type));
			RTryGetComponentFastPath_Type_IntPtr = new Method(this, "TryGetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
			RFindWithTag_String = new Method(this, "FindWithTag", 0, typeof(System.String));
			RSendMessageUpwards_String_SendMessageOptions = new Method(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_SendMessageOptions = new Method(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_SendMessageOptions = new Method(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RAddComponentInternal_String = new Method(this, "AddComponentInternal", 0, typeof(System.String));
			RInternal_AddComponentWithType_Type = new Method(this, "Internal_AddComponentWithType", 0, typeof(System.Type));
			RAddComponent_Type = new Method(this, "AddComponent", 0, typeof(System.Type));
			RAddComponent_GT = new Method(this, "AddComponent", 1);
			RSetActive_Boolean = new Method(this, "SetActive", 0, typeof(System.Boolean));
			RSetActiveRecursively_Boolean = new Method(this, "SetActiveRecursively", 0, typeof(System.Boolean));
			RCompareTag_String = new Method(this, "CompareTag", 0, typeof(System.String));
			RFindGameObjectWithTag_String = new Method(this, "FindGameObjectWithTag", 0, typeof(System.String));
			RFindGameObjectsWithTag_String = new Method(this, "FindGameObjectsWithTag", 0, typeof(System.String));
			RSendMessageUpwards_String_Object_SendMessageOptions = new Method(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessageUpwards_String_Object = new Method(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
			RSendMessageUpwards_String = new Method(this, "SendMessageUpwards", 0, typeof(System.String));
			RSendMessage_String_Object_SendMessageOptions = new Method(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_Object = new Method(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
			RSendMessage_String = new Method(this, "SendMessage", 0, typeof(System.String));
			RBroadcastMessage_String_Object_SendMessageOptions = new Method(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_Object = new Method(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
			RBroadcastMessage_String = new Method(this, "BroadcastMessage", 0, typeof(System.String));
			RInternal_CreateGameObject_GameObject_String = new Method(this, "Internal_CreateGameObject", 0, typeof(UnityEngine.GameObject), typeof(System.String));
			RFind_String = new Method(this, "Find", 0, typeof(System.String));
			RCalculateBounds = new Method(this, "CalculateBounds", 0);
			RIsMarkedVisible = new Method(this, "IsMarkedVisible", 0);
			RSampleAnimation_Object_Single = new Method(this, "SampleAnimation", 0, typeof(UnityEngine.Object), typeof(System.Single));
			RAddComponent_String = new Method(this, "AddComponent", 0, typeof(System.String));
			RPlayAnimation_Object = new Method(this, "PlayAnimation", 0, typeof(UnityEngine.Object));
			RStopAnimation = new Method(this, "StopAnimation", 0);
			Rget_scene_Injected_Out_Scene = new Method(this, "get_scene_Injected", 0, typeof(UnityEngine.SceneManagement.Scene).MakeByRefType());
			RCalculateBounds_Injected_Out_Bounds = new Method(this, "CalculateBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
			RGetInstanceID = new Method(this, "GetInstanceID", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RToString = new Method(this, "ToString", 0);
			RFinalize = new Method(this, "Finalize", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);

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
