using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RComponent : Member
    {
		public  RTransform transform; //UnityEngine.Transform
		public  RGameObject gameObject; //UnityEngine.GameObject
		public  Property tag; //System.String
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
		public  Method RGetComponent_Type; //UnityEngine.Component GetComponent(System.Type)
		public  Method RGetComponentFastPath_Type_IntPtr; //Void GetComponentFastPath(System.Type, IntPtr)
		public  Method RGetComponent_GT; //T GetComponent[T]()
		public  Method RTryGetComponent_Type_Out_Component; //Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		public  Method RTryGetComponent_GT_Out_T; //Boolean TryGetComponent[T](T ByRef)
		public  Method RGetComponent_String; //UnityEngine.Component GetComponent(System.String)
		public  Method RGetComponentInChildren_Type_Boolean; //UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		public  Method RGetComponentInChildren_Type; //UnityEngine.Component GetComponentInChildren(System.Type)
		public  Method RGetComponentInChildren_GT_Boolean; //T GetComponentInChildren[T](Boolean)
		public  Method RGetComponentInChildren_GT; //T GetComponentInChildren[T]()
		public  Method RGetComponentsInChildren_Type_Boolean; //UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		public  Method RGetComponentsInChildren_Type; //UnityEngine.Component[] GetComponentsInChildren(System.Type)
		public  Method RGetComponentsInChildren_GT_Boolean; //T[] GetComponentsInChildren[T](Boolean)
		public  Method RGetComponentsInChildren_GT_Boolean_List_d_T_p_; //Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		public  Method RGetComponentsInChildren_GT; //T[] GetComponentsInChildren[T]()
		public  Method RGetComponentsInChildren_GT_List_d_T_p_; //Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		public  Method RGetComponentInParent_Type_Boolean; //UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		public  Method RGetComponentInParent_Type; //UnityEngine.Component GetComponentInParent(System.Type)
		public  Method RGetComponentInParent_GT_Boolean; //T GetComponentInParent[T](Boolean)
		public  Method RGetComponentInParent_GT; //T GetComponentInParent[T]()
		public  Method RGetComponentsInParent_Type_Boolean; //UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		public  Method RGetComponentsInParent_Type; //UnityEngine.Component[] GetComponentsInParent(System.Type)
		public  Method RGetComponentsInParent_GT_Boolean; //T[] GetComponentsInParent[T](Boolean)
		public  Method RGetComponentsInParent_GT_Boolean_List_d_T_p_; //Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		public  Method RGetComponentsInParent_GT; //T[] GetComponentsInParent[T]()
		public  Method RGetComponents_Type; //UnityEngine.Component[] GetComponents(System.Type)
		public  Method RGetComponentsForListInternal_Type_Object; //Void GetComponentsForListInternal(System.Type, System.Object)
		public  Method RGetComponents_Type_List_d_Component_p_; //Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		public  Method RGetComponents_GT_List_d_T_p_; //Void GetComponents[T](System.Collections.Generic.List`1[T])
		public  Method RGetComponents_GT; //T[] GetComponents[T]()
		public  Method RCompareTag_String; //Boolean CompareTag(System.String)
		public  Method RGetCoupledComponent; //UnityEngine.Component GetCoupledComponent()
		public  Method RIsCoupledComponent; //Boolean IsCoupledComponent()
		public  Method RSendMessageUpwards_String_Object_SendMessageOptions; //Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  Method RSendMessageUpwards_String_Object; //Void SendMessageUpwards(System.String, System.Object)
		public  Method RSendMessageUpwards_String; //Void SendMessageUpwards(System.String)
		public  Method RSendMessageUpwards_String_SendMessageOptions; //Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		public  Method RSendMessage_String_Object; //Void SendMessage(System.String, System.Object)
		public  Method RSendMessage_String; //Void SendMessage(System.String)
		public  Method RSendMessage_String_Object_SendMessageOptions; //Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  Method RSendMessage_String_SendMessageOptions; //Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		public  Method RBroadcastMessage_String_Object_SendMessageOptions; //Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  Method RBroadcastMessage_String_Object; //Void BroadcastMessage(System.String, System.Object)
		public  Method RBroadcastMessage_String; //Void BroadcastMessage(System.String)
		public  Method RBroadcastMessage_String_SendMessageOptions; //Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		public  Method RGetInstanceID; //Int32 GetInstanceID()
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method RToString; //System.String ToString()
		public  Method RFinalize; //Void Finalize()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()


        public RComponent() : base("UnityEngine.Component")
        {
            NewMembers();
        }

        public RComponent(System.Object instance) : base("UnityEngine.Component")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RComponent(Member belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			transform = new RTransform(this, "transform", -1);
			gameObject = new RGameObject(this, "gameObject", -1);
			tag = new Property(this, "tag", -1);
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
			RGetComponent_Type = new Method(this, "GetComponent", 0, typeof(System.Type));
			RGetComponentFastPath_Type_IntPtr = new Method(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
			RGetComponent_GT = new Method(this, "GetComponent", 1);
			RTryGetComponent_Type_Out_Component = new Method(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
			RTryGetComponent_GT_Out_T = new Method(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
			RGetComponent_String = new Method(this, "GetComponent", 0, typeof(System.String));
			RGetComponentInChildren_Type_Boolean = new Method(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInChildren_Type = new Method(this, "GetComponentInChildren", 0, typeof(System.Type));
			RGetComponentInChildren_GT_Boolean = new Method(this, "GetComponentInChildren", 1, typeof(System.Boolean));
			RGetComponentInChildren_GT = new Method(this, "GetComponentInChildren", 1);
			RGetComponentsInChildren_Type_Boolean = new Method(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInChildren_Type = new Method(this, "GetComponentsInChildren", 0, typeof(System.Type));
			RGetComponentsInChildren_GT_Boolean = new Method(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
			RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new Method(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInChildren_GT = new Method(this, "GetComponentsInChildren", 1);
			RGetComponentsInChildren_GT_List_d_T_p_ = new Method(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentInParent_Type_Boolean = new Method(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInParent_Type = new Method(this, "GetComponentInParent", 0, typeof(System.Type));
			RGetComponentInParent_GT_Boolean = new Method(this, "GetComponentInParent", 1, typeof(System.Boolean));
			RGetComponentInParent_GT = new Method(this, "GetComponentInParent", 1);
			RGetComponentsInParent_Type_Boolean = new Method(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInParent_Type = new Method(this, "GetComponentsInParent", 0, typeof(System.Type));
			RGetComponentsInParent_GT_Boolean = new Method(this, "GetComponentsInParent", 1, typeof(System.Boolean));
			RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new Method(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInParent_GT = new Method(this, "GetComponentsInParent", 1);
			RGetComponents_Type = new Method(this, "GetComponents", 0, typeof(System.Type));
			RGetComponentsForListInternal_Type_Object = new Method(this, "GetComponentsForListInternal", 0, typeof(System.Type), typeof(System.Object));
			RGetComponents_Type_List_d_Component_p_ = new Method(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
			RGetComponents_GT_List_d_T_p_ = new Method(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponents_GT = new Method(this, "GetComponents", 1);
			RCompareTag_String = new Method(this, "CompareTag", 0, typeof(System.String));
			RGetCoupledComponent = new Method(this, "GetCoupledComponent", 0);
			RIsCoupledComponent = new Method(this, "IsCoupledComponent", 0);
			RSendMessageUpwards_String_Object_SendMessageOptions = new Method(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessageUpwards_String_Object = new Method(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
			RSendMessageUpwards_String = new Method(this, "SendMessageUpwards", 0, typeof(System.String));
			RSendMessageUpwards_String_SendMessageOptions = new Method(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_Object = new Method(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
			RSendMessage_String = new Method(this, "SendMessage", 0, typeof(System.String));
			RSendMessage_String_Object_SendMessageOptions = new Method(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_SendMessageOptions = new Method(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_Object_SendMessageOptions = new Method(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_Object = new Method(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
			RBroadcastMessage_String = new Method(this, "BroadcastMessage", 0, typeof(System.String));
			RBroadcastMessage_String_SendMessageOptions = new Method(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RGetInstanceID = new Method(this, "GetInstanceID", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RToString = new Method(this, "ToString", 0);
			RFinalize = new Method(this, "Finalize", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);

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

        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
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

        public virtual System.Boolean TryGetComponent<T>(out T  @component)
        {
			component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			component = (T)___parameters[0];

            return (System.Boolean)___result;
        }

        public virtual UnityEngine.Component GetComponent(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual T GetComponentInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual T[] GetComponentsInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual void GetComponentsInChildren<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @result)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @result};
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

        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual T GetComponentInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }

        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual T[] GetComponentsInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual void GetComponentsInParent<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual UnityEngine.Component[] GetComponents(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }

        public virtual void GetComponentsForListInternal(System.Type  @searchType, System.Object  @resultList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchType, @resultList};
            var ___result = RGetComponentsForListInternal_Type_Object.Invoke(___genericsType, ___parameters);

            
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

        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }

        public virtual System.Boolean CompareTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }

        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

        public virtual void SendMessageUpwards(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
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

        public virtual void SendMessage(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SendMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
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

        public virtual void BroadcastMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
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
