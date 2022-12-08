using SMFrame.Editor.Refleaction.RUnityEngine;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RTransform : RMember
    {
		public  RVector3 position; //UnityEngine.Vector3
		public  RVector3 localPosition; //UnityEngine.Vector3
		public  RVector3 eulerAngles; //UnityEngine.Vector3
		public  RVector3 localEulerAngles; //UnityEngine.Vector3
		public  RVector3 right; //UnityEngine.Vector3
		public  RVector3 up; //UnityEngine.Vector3
		public  RVector3 forward; //UnityEngine.Vector3
		public  RQuaternion rotation; //UnityEngine.Quaternion
		public  RQuaternion localRotation; //UnityEngine.Quaternion
		public  RProperty rotationOrder; //UnityEngine.RotationOrder
		public  RVector3 localScale; //UnityEngine.Vector3
		public  RTransform parent; //UnityEngine.Transform
		public  RTransform parentInternal; //UnityEngine.Transform
		public  RMatrix4x4 worldToLocalMatrix; //UnityEngine.Matrix4x4
		public  RMatrix4x4 localToWorldMatrix; //UnityEngine.Matrix4x4
		public  RTransform root; //UnityEngine.Transform
		public  RProperty childCount; //System.Int32
		public  RVector3 lossyScale; //UnityEngine.Vector3
		public  RProperty hasChanged; //System.Boolean
		public  RProperty hierarchyCapacity; //System.Int32
		public  RProperty hierarchyCount; //System.Int32
		public  RProperty constrainProportionsScale; //System.Boolean
		public  RTransform transform; //UnityEngine.Transform
		public  RGameObject gameObject; //UnityEngine.GameObject
		public  RProperty tag; //System.String
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
		public  RMethod RGetLocalEulerAngles_RotationOrder; //UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder)
		public  RMethod RSetLocalEulerAngles_Vector3_RotationOrder; //Void SetLocalEulerAngles(UnityEngine.Vector3, UnityEngine.RotationOrder)
		public  RMethod RSetLocalEulerHint_Vector3; //Void SetLocalEulerHint(UnityEngine.Vector3)
		public  RMethod RGetRotationOrderInternal; //Int32 GetRotationOrderInternal()
		public  RMethod RSetRotationOrderInternal_RotationOrder; //Void SetRotationOrderInternal(UnityEngine.RotationOrder)
		public  RMethod RGetParent; //UnityEngine.Transform GetParent()
		public  RMethod RSetParent_Transform; //Void SetParent(UnityEngine.Transform)
		public  RMethod RSetParent_Transform_Boolean; //Void SetParent(UnityEngine.Transform, Boolean)
		public  RMethod RSetPositionAndRotation_Vector3_Quaternion; //Void SetPositionAndRotation(UnityEngine.Vector3, UnityEngine.Quaternion)
		public  RMethod RSetLocalPositionAndRotation_Vector3_Quaternion; //Void SetLocalPositionAndRotation(UnityEngine.Vector3, UnityEngine.Quaternion)
		public  RMethod RTranslate_Vector3_Space; //Void Translate(UnityEngine.Vector3, UnityEngine.Space)
		public  RMethod RTranslate_Vector3; //Void Translate(UnityEngine.Vector3)
		public  RMethod RTranslate_Single_Single_Single_Space; //Void Translate(Single, Single, Single, UnityEngine.Space)
		public  RMethod RTranslate_Single_Single_Single; //Void Translate(Single, Single, Single)
		public  RMethod RTranslate_Vector3_Transform; //Void Translate(UnityEngine.Vector3, UnityEngine.Transform)
		public  RMethod RTranslate_Single_Single_Single_Transform; //Void Translate(Single, Single, Single, UnityEngine.Transform)
		public  RMethod RRotate_Vector3_Space; //Void Rotate(UnityEngine.Vector3, UnityEngine.Space)
		public  RMethod RRotate_Vector3; //Void Rotate(UnityEngine.Vector3)
		public  RMethod RRotate_Single_Single_Single_Space; //Void Rotate(Single, Single, Single, UnityEngine.Space)
		public  RMethod RRotate_Single_Single_Single; //Void Rotate(Single, Single, Single)
		public  RMethod RRotateAroundInternal_Vector3_Single; //Void RotateAroundInternal(UnityEngine.Vector3, Single)
		public  RMethod RRotate_Vector3_Single_Space; //Void Rotate(UnityEngine.Vector3, Single, UnityEngine.Space)
		public  RMethod RRotate_Vector3_Single; //Void Rotate(UnityEngine.Vector3, Single)
		public  RMethod RRotateAround_Vector3_Vector3_Single; //Void RotateAround(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		public  RMethod RLookAt_Transform_Vector3; //Void LookAt(UnityEngine.Transform, UnityEngine.Vector3)
		public  RMethod RLookAt_Transform; //Void LookAt(UnityEngine.Transform)
		public  RMethod RLookAt_Vector3_Vector3; //Void LookAt(UnityEngine.Vector3, UnityEngine.Vector3)
		public  RMethod RLookAt_Vector3; //Void LookAt(UnityEngine.Vector3)
		public  RMethod RInternal_LookAt_Vector3_Vector3; //Void Internal_LookAt(UnityEngine.Vector3, UnityEngine.Vector3)
		public  RMethod RTransformDirection_Vector3; //UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3)
		public  RMethod RTransformDirection_Single_Single_Single; //UnityEngine.Vector3 TransformDirection(Single, Single, Single)
		public  RMethod RInverseTransformDirection_Vector3; //UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3)
		public  RMethod RInverseTransformDirection_Single_Single_Single; //UnityEngine.Vector3 InverseTransformDirection(Single, Single, Single)
		public  RMethod RTransformVector_Vector3; //UnityEngine.Vector3 TransformVector(UnityEngine.Vector3)
		public  RMethod RTransformVector_Single_Single_Single; //UnityEngine.Vector3 TransformVector(Single, Single, Single)
		public  RMethod RInverseTransformVector_Vector3; //UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3)
		public  RMethod RInverseTransformVector_Single_Single_Single; //UnityEngine.Vector3 InverseTransformVector(Single, Single, Single)
		public  RMethod RTransformPoint_Vector3; //UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3)
		public  RMethod RTransformPoint_Single_Single_Single; //UnityEngine.Vector3 TransformPoint(Single, Single, Single)
		public  RMethod RInverseTransformPoint_Vector3; //UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3)
		public  RMethod RInverseTransformPoint_Single_Single_Single; //UnityEngine.Vector3 InverseTransformPoint(Single, Single, Single)
		public  RMethod RGetRoot; //UnityEngine.Transform GetRoot()
		public  RMethod RDetachChildren; //Void DetachChildren()
		public  RMethod RSetAsFirstSibling; //Void SetAsFirstSibling()
		public  RMethod RSetAsLastSibling; //Void SetAsLastSibling()
		public  RMethod RSetSiblingIndex_Int32; //Void SetSiblingIndex(Int32)
		public  RMethod RMoveAfterSibling_Transform_Boolean; //Void MoveAfterSibling(UnityEngine.Transform, Boolean)
		public  RMethod RGetSiblingIndex; //Int32 GetSiblingIndex()
		public static RMethod RFindRelativeTransformWithPath_Transform_String_Boolean; //UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform, System.String, Boolean)
		public  RMethod RFind_String; //UnityEngine.Transform Find(System.String)
		public  RMethod RSendTransformChangedScale; //Void SendTransformChangedScale()
		public  RMethod RIsChildOf_Transform; //Boolean IsChildOf(UnityEngine.Transform)
		public  RMethod RFindChild_String; //UnityEngine.Transform FindChild(System.String)
		public  RMethod RGetEnumerator; //System.Collections.IEnumerator GetEnumerator()
		public  RMethod RRotateAround_Vector3_Single; //Void RotateAround(UnityEngine.Vector3, Single)
		public  RMethod RRotateAroundLocal_Vector3_Single; //Void RotateAroundLocal(UnityEngine.Vector3, Single)
		public  RMethod RGetChild_Int32; //UnityEngine.Transform GetChild(Int32)
		public  RMethod RGetChildCount; //Int32 GetChildCount()
		public  RMethod Rinternal_getHierarchyCapacity; //Int32 internal_getHierarchyCapacity()
		public  RMethod Rinternal_setHierarchyCapacity_Int32; //Void internal_setHierarchyCapacity(Int32)
		public  RMethod Rinternal_getHierarchyCount; //Int32 internal_getHierarchyCount()
		public  RMethod RIsNonUniformScaleTransform; //Boolean IsNonUniformScaleTransform()
		public  RMethod RSetConstrainProportionsScale_Boolean; //Void SetConstrainProportionsScale(Boolean)
		public  RMethod RIsConstrainProportionsScale; //Boolean IsConstrainProportionsScale()
		public  RMethod Rget_position_Injected_Out_Vector3; //Void get_position_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod Rset_position_Injected_Ref_Vector3; //Void set_position_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod Rget_localPosition_Injected_Out_Vector3; //Void get_localPosition_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod Rset_localPosition_Injected_Ref_Vector3; //Void set_localPosition_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3; //Void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder, UnityEngine.Vector3 ByRef)
		public  RMethod RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder; //Void SetLocalEulerAngles_Injected(UnityEngine.Vector3 ByRef, UnityEngine.RotationOrder)
		public  RMethod RSetLocalEulerHint_Injected_Ref_Vector3; //Void SetLocalEulerHint_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod Rget_rotation_Injected_Out_Quaternion; //Void get_rotation_Injected(UnityEngine.Quaternion ByRef)
		public  RMethod Rset_rotation_Injected_Ref_Quaternion; //Void set_rotation_Injected(UnityEngine.Quaternion ByRef)
		public  RMethod Rget_localRotation_Injected_Out_Quaternion; //Void get_localRotation_Injected(UnityEngine.Quaternion ByRef)
		public  RMethod Rset_localRotation_Injected_Ref_Quaternion; //Void set_localRotation_Injected(UnityEngine.Quaternion ByRef)
		public  RMethod Rget_localScale_Injected_Out_Vector3; //Void get_localScale_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod Rset_localScale_Injected_Ref_Vector3; //Void set_localScale_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod Rget_worldToLocalMatrix_Injected_Out_Matrix4x4; //Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		public  RMethod Rget_localToWorldMatrix_Injected_Out_Matrix4x4; //Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		public  RMethod RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion; //Void SetPositionAndRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		public  RMethod RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion; //Void SetLocalPositionAndRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		public  RMethod RRotateAroundInternal_Injected_Ref_Vector3_Single; //Void RotateAroundInternal_Injected(UnityEngine.Vector3 ByRef, Single)
		public  RMethod RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3; //Void Internal_LookAt_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod RTransformDirection_Injected_Ref_Vector3_Out_Vector3; //Void TransformDirection_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3; //Void InverseTransformDirection_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod RTransformVector_Injected_Ref_Vector3_Out_Vector3; //Void TransformVector_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3; //Void InverseTransformVector_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod RTransformPoint_Injected_Ref_Vector3_Out_Vector3; //Void TransformPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3; //Void InverseTransformPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		public  RMethod Rget_lossyScale_Injected_Out_Vector3; //Void get_lossyScale_Injected(UnityEngine.Vector3 ByRef)
		public  RMethod RRotateAround_Injected_Ref_Vector3_Single; //Void RotateAround_Injected(UnityEngine.Vector3 ByRef, Single)
		public  RMethod RRotateAroundLocal_Injected_Ref_Vector3_Single; //Void RotateAroundLocal_Injected(UnityEngine.Vector3 ByRef, Single)
		public  RMethod RGetComponent_Type; //UnityEngine.Component GetComponent(System.Type)
		public  RMethod RGetComponentFastPath_Type_IntPtr; //Void GetComponentFastPath(System.Type, IntPtr)
		public  RMethod RGetComponent_GT; //T GetComponent[T]()
		public  RMethod RTryGetComponent_Type_Out_Component; //Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		public  RMethod RTryGetComponent_GT_Out_T; //Boolean TryGetComponent[T](T ByRef)
		public  RMethod RGetComponent_String; //UnityEngine.Component GetComponent(System.String)
		public  RMethod RGetComponentInChildren_Type_Boolean; //UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		public  RMethod RGetComponentInChildren_Type; //UnityEngine.Component GetComponentInChildren(System.Type)
		public  RMethod RGetComponentInChildren_GT_Boolean; //T GetComponentInChildren[T](Boolean)
		public  RMethod RGetComponentInChildren_GT; //T GetComponentInChildren[T]()
		public  RMethod RGetComponentsInChildren_Type_Boolean; //UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		public  RMethod RGetComponentsInChildren_Type; //UnityEngine.Component[] GetComponentsInChildren(System.Type)
		public  RMethod RGetComponentsInChildren_GT_Boolean; //T[] GetComponentsInChildren[T](Boolean)
		public  RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_; //Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentsInChildren_GT; //T[] GetComponentsInChildren[T]()
		public  RMethod RGetComponentsInChildren_GT_List_d_T_p_; //Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentInParent_Type_Boolean; //UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		public  RMethod RGetComponentInParent_Type; //UnityEngine.Component GetComponentInParent(System.Type)
		public  RMethod RGetComponentInParent_GT_Boolean; //T GetComponentInParent[T](Boolean)
		public  RMethod RGetComponentInParent_GT; //T GetComponentInParent[T]()
		public  RMethod RGetComponentsInParent_Type_Boolean; //UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		public  RMethod RGetComponentsInParent_Type; //UnityEngine.Component[] GetComponentsInParent(System.Type)
		public  RMethod RGetComponentsInParent_GT_Boolean; //T[] GetComponentsInParent[T](Boolean)
		public  RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_; //Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		public  RMethod RGetComponentsInParent_GT; //T[] GetComponentsInParent[T]()
		public  RMethod RGetComponents_Type; //UnityEngine.Component[] GetComponents(System.Type)
		public  RMethod RGetComponents_Type_List_d_Component_p_; //Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		public  RMethod RGetComponents_GT_List_d_T_p_; //Void GetComponents[T](System.Collections.Generic.List`1[T])
		public  RMethod RGetComponents_GT; //T[] GetComponents[T]()
		public  RMethod RCompareTag_String; //Boolean CompareTag(System.String)
		public  RMethod RGetCoupledComponent; //UnityEngine.Component GetCoupledComponent()
		public  RMethod RIsCoupledComponent; //Boolean IsCoupledComponent()
		public  RMethod RSendMessageUpwards_String_Object_SendMessageOptions; //Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  RMethod RSendMessageUpwards_String_Object; //Void SendMessageUpwards(System.String, System.Object)
		public  RMethod RSendMessageUpwards_String; //Void SendMessageUpwards(System.String)
		public  RMethod RSendMessageUpwards_String_SendMessageOptions; //Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		public  RMethod RSendMessage_String_Object; //Void SendMessage(System.String, System.Object)
		public  RMethod RSendMessage_String; //Void SendMessage(System.String)
		public  RMethod RSendMessage_String_Object_SendMessageOptions; //Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  RMethod RSendMessage_String_SendMessageOptions; //Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		public  RMethod RBroadcastMessage_String_Object_SendMessageOptions; //Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		public  RMethod RBroadcastMessage_String_Object; //Void BroadcastMessage(System.String, System.Object)
		public  RMethod RBroadcastMessage_String; //Void BroadcastMessage(System.String)
		public  RMethod RBroadcastMessage_String_SendMessageOptions; //Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		public  RMethod RGetInstanceID; //Int32 GetInstanceID()
		public  RMethod RGetHashCode; //Int32 GetHashCode()
		public  RMethod REquals_Object; //Boolean Equals(System.Object)
		public  RMethod RToString; //System.String ToString()
		public  RMethod RFinalize; //Void Finalize()
		public  RMethod RGetType; //System.Type GetType()
		public  RMethod RMemberwiseClone; //System.Object MemberwiseClone()


        public RTransform() : base("UnityEngine.Transform")
        {
          //  NewMembers();
        }

        public RTransform(System.Object instance) : base("UnityEngine.Transform")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RTransform(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            //NewMembers();
	    }

        private void NewMembers()
        {
			position = new RVector3(this, "position", -1);
			localPosition = new RVector3(this, "localPosition", -1);
			eulerAngles = new RVector3(this, "eulerAngles", -1);
			localEulerAngles = new RVector3(this, "localEulerAngles", -1);
			right = new RVector3(this, "right", -1);
			up = new RVector3(this, "up", -1);
			forward = new RVector3(this, "forward", -1);
			rotation = new RQuaternion(this, "rotation", -1);
			localRotation = new RQuaternion(this, "localRotation", -1);
			rotationOrder = new RProperty(this, "rotationOrder", -1);
			localScale = new RVector3(this, "localScale", -1);
			parent = new RTransform(this, "parent", -1);
			parentInternal = new RTransform(this, "parentInternal", -1);
			worldToLocalMatrix = new RMatrix4x4(this, "worldToLocalMatrix", -1);
			localToWorldMatrix = new RMatrix4x4(this, "localToWorldMatrix", -1);
			root = new RTransform(this, "root", -1);
			childCount = new RProperty(this, "childCount", -1);
			lossyScale = new RVector3(this, "lossyScale", -1);
			hasChanged = new RProperty(this, "hasChanged", -1);
			hierarchyCapacity = new RProperty(this, "hierarchyCapacity", -1);
			hierarchyCount = new RProperty(this, "hierarchyCount", -1);
			constrainProportionsScale = new RProperty(this, "constrainProportionsScale", -1);
			transform = new RTransform(this, "transform", -1);
			gameObject = new RGameObject(this, "gameObject", -1);
			tag = new RProperty(this, "tag", -1);
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
			name = new RProperty(this, "name", -1);
			hideFlags = new RProperty(this, "hideFlags", -1);
			RGetLocalEulerAngles_RotationOrder = new RMethod(this, "GetLocalEulerAngles", 0,  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
			RSetLocalEulerAngles_Vector3_RotationOrder = new RMethod(this, "SetLocalEulerAngles", 0, typeof(UnityEngine.Vector3),  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
			RSetLocalEulerHint_Vector3 = new RMethod(this, "SetLocalEulerHint", 0, typeof(UnityEngine.Vector3));
			RGetRotationOrderInternal = new RMethod(this, "GetRotationOrderInternal", 0);
			RSetRotationOrderInternal_RotationOrder = new RMethod(this, "SetRotationOrderInternal", 0,  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
			RGetParent = new RMethod(this, "GetParent", 0);
			RSetParent_Transform = new RMethod(this, "SetParent", 0, typeof(UnityEngine.Transform));
			RSetParent_Transform_Boolean = new RMethod(this, "SetParent", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
			RSetPositionAndRotation_Vector3_Quaternion = new RMethod(this, "SetPositionAndRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
			RSetLocalPositionAndRotation_Vector3_Quaternion = new RMethod(this, "SetLocalPositionAndRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
			RTranslate_Vector3_Space = new RMethod(this, "Translate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Space));
			RTranslate_Vector3 = new RMethod(this, "Translate", 0, typeof(UnityEngine.Vector3));
			RTranslate_Single_Single_Single_Space = new RMethod(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Space));
			RTranslate_Single_Single_Single = new RMethod(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RTranslate_Vector3_Transform = new RMethod(this, "Translate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Transform));
			RTranslate_Single_Single_Single_Transform = new RMethod(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Transform));
			RRotate_Vector3_Space = new RMethod(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Space));
			RRotate_Vector3 = new RMethod(this, "Rotate", 0, typeof(UnityEngine.Vector3));
			RRotate_Single_Single_Single_Space = new RMethod(this, "Rotate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Space));
			RRotate_Single_Single_Single = new RMethod(this, "Rotate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RRotateAroundInternal_Vector3_Single = new RMethod(this, "RotateAroundInternal", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RRotate_Vector3_Single_Space = new RMethod(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(UnityEngine.Space));
			RRotate_Vector3_Single = new RMethod(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RRotateAround_Vector3_Vector3_Single = new RMethod(this, "RotateAround", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
			RLookAt_Transform_Vector3 = new RMethod(this, "LookAt", 0, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3));
			RLookAt_Transform = new RMethod(this, "LookAt", 0, typeof(UnityEngine.Transform));
			RLookAt_Vector3_Vector3 = new RMethod(this, "LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RLookAt_Vector3 = new RMethod(this, "LookAt", 0, typeof(UnityEngine.Vector3));
			RInternal_LookAt_Vector3_Vector3 = new RMethod(this, "Internal_LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
			RTransformDirection_Vector3 = new RMethod(this, "TransformDirection", 0, typeof(UnityEngine.Vector3));
			RTransformDirection_Single_Single_Single = new RMethod(this, "TransformDirection", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RInverseTransformDirection_Vector3 = new RMethod(this, "InverseTransformDirection", 0, typeof(UnityEngine.Vector3));
			RInverseTransformDirection_Single_Single_Single = new RMethod(this, "InverseTransformDirection", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RTransformVector_Vector3 = new RMethod(this, "TransformVector", 0, typeof(UnityEngine.Vector3));
			RTransformVector_Single_Single_Single = new RMethod(this, "TransformVector", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RInverseTransformVector_Vector3 = new RMethod(this, "InverseTransformVector", 0, typeof(UnityEngine.Vector3));
			RInverseTransformVector_Single_Single_Single = new RMethod(this, "InverseTransformVector", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RTransformPoint_Vector3 = new RMethod(this, "TransformPoint", 0, typeof(UnityEngine.Vector3));
			RTransformPoint_Single_Single_Single = new RMethod(this, "TransformPoint", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RInverseTransformPoint_Vector3 = new RMethod(this, "InverseTransformPoint", 0, typeof(UnityEngine.Vector3));
			RInverseTransformPoint_Single_Single_Single = new RMethod(this, "InverseTransformPoint", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
			RGetRoot = new RMethod(this, "GetRoot", 0);
			RDetachChildren = new RMethod(this, "DetachChildren", 0);
			RSetAsFirstSibling = new RMethod(this, "SetAsFirstSibling", 0);
			RSetAsLastSibling = new RMethod(this, "SetAsLastSibling", 0);
			RSetSiblingIndex_Int32 = new RMethod(this, "SetSiblingIndex", 0, typeof(System.Int32));
			RMoveAfterSibling_Transform_Boolean = new RMethod(this, "MoveAfterSibling", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
			RGetSiblingIndex = new RMethod(this, "GetSiblingIndex", 0);
			RFindRelativeTransformWithPath_Transform_String_Boolean = new RMethod(this, "FindRelativeTransformWithPath", 0, typeof(UnityEngine.Transform), typeof(System.String), typeof(System.Boolean));
			RFind_String = new RMethod(this, "Find", 0, typeof(System.String));
			RSendTransformChangedScale = new RMethod(this, "SendTransformChangedScale", 0);
			RIsChildOf_Transform = new RMethod(this, "IsChildOf", 0, typeof(UnityEngine.Transform));
			RFindChild_String = new RMethod(this, "FindChild", 0, typeof(System.String));
			RGetEnumerator = new RMethod(this, "GetEnumerator", 0);
			RRotateAround_Vector3_Single = new RMethod(this, "RotateAround", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RRotateAroundLocal_Vector3_Single = new RMethod(this, "RotateAroundLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
			RGetChild_Int32 = new RMethod(this, "GetChild", 0, typeof(System.Int32));
			RGetChildCount = new RMethod(this, "GetChildCount", 0);
			Rinternal_getHierarchyCapacity = new RMethod(this, "internal_getHierarchyCapacity", 0);
			Rinternal_setHierarchyCapacity_Int32 = new RMethod(this, "internal_setHierarchyCapacity", 0, typeof(System.Int32));
			Rinternal_getHierarchyCount = new RMethod(this, "internal_getHierarchyCount", 0);
			RIsNonUniformScaleTransform = new RMethod(this, "IsNonUniformScaleTransform", 0);
			RSetConstrainProportionsScale_Boolean = new RMethod(this, "SetConstrainProportionsScale", 0, typeof(System.Boolean));
			RIsConstrainProportionsScale = new RMethod(this, "IsConstrainProportionsScale", 0);
			Rget_position_Injected_Out_Vector3 = new RMethod(this, "get_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			Rset_position_Injected_Ref_Vector3 = new RMethod(this, "set_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			Rget_localPosition_Injected_Out_Vector3 = new RMethod(this, "get_localPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			Rset_localPosition_Injected_Ref_Vector3 = new RMethod(this, "set_localPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3 = new RMethod(this, "GetLocalEulerAngles_Injected", 0,  ReleactionUtils.GetType("UnityEngine.RotationOrder"), typeof(UnityEngine.Vector3).MakeByRefType());
			RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder = new RMethod(this, "SetLocalEulerAngles_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
			RSetLocalEulerHint_Injected_Ref_Vector3 = new RMethod(this, "SetLocalEulerHint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			Rget_rotation_Injected_Out_Quaternion = new RMethod(this, "get_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
			Rset_rotation_Injected_Ref_Quaternion = new RMethod(this, "set_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
			Rget_localRotation_Injected_Out_Quaternion = new RMethod(this, "get_localRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
			Rset_localRotation_Injected_Ref_Quaternion = new RMethod(this, "set_localRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
			Rget_localScale_Injected_Out_Vector3 = new RMethod(this, "get_localScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			Rset_localScale_Injected_Ref_Vector3 = new RMethod(this, "set_localScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			Rget_worldToLocalMatrix_Injected_Out_Matrix4x4 = new RMethod(this, "get_worldToLocalMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
			Rget_localToWorldMatrix_Injected_Out_Matrix4x4 = new RMethod(this, "get_localToWorldMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
			RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion = new RMethod(this, "SetPositionAndRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion = new RMethod(this, "SetLocalPositionAndRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
			RRotateAroundInternal_Injected_Ref_Vector3_Single = new RMethod(this, "RotateAroundInternal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
			RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3 = new RMethod(this, "Internal_LookAt_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RTransformDirection_Injected_Ref_Vector3_Out_Vector3 = new RMethod(this, "TransformDirection_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3 = new RMethod(this, "InverseTransformDirection_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RTransformVector_Injected_Ref_Vector3_Out_Vector3 = new RMethod(this, "TransformVector_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3 = new RMethod(this, "InverseTransformVector_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RTransformPoint_Injected_Ref_Vector3_Out_Vector3 = new RMethod(this, "TransformPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3 = new RMethod(this, "InverseTransformPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
			Rget_lossyScale_Injected_Out_Vector3 = new RMethod(this, "get_lossyScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
			RRotateAround_Injected_Ref_Vector3_Single = new RMethod(this, "RotateAround_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
			RRotateAroundLocal_Injected_Ref_Vector3_Single = new RMethod(this, "RotateAroundLocal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
			RGetComponent_Type = new RMethod(this, "GetComponent", 0, typeof(System.Type));
			RGetComponentFastPath_Type_IntPtr = new RMethod(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
			RGetComponent_GT = new RMethod(this, "GetComponent", 1);
			RTryGetComponent_Type_Out_Component = new RMethod(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
			RTryGetComponent_GT_Out_T = new RMethod(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
			RGetComponent_String = new RMethod(this, "GetComponent", 0, typeof(System.String));
			RGetComponentInChildren_Type_Boolean = new RMethod(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInChildren_Type = new RMethod(this, "GetComponentInChildren", 0, typeof(System.Type));
			RGetComponentInChildren_GT_Boolean = new RMethod(this, "GetComponentInChildren", 1, typeof(System.Boolean));
			RGetComponentInChildren_GT = new RMethod(this, "GetComponentInChildren", 1);
			RGetComponentsInChildren_Type_Boolean = new RMethod(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInChildren_Type = new RMethod(this, "GetComponentsInChildren", 0, typeof(System.Type));
			RGetComponentsInChildren_GT_Boolean = new RMethod(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
			RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new RMethod(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInChildren_GT = new RMethod(this, "GetComponentsInChildren", 1);
			RGetComponentsInChildren_GT_List_d_T_p_ = new RMethod(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentInParent_Type_Boolean = new RMethod(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentInParent_Type = new RMethod(this, "GetComponentInParent", 0, typeof(System.Type));
			RGetComponentInParent_GT_Boolean = new RMethod(this, "GetComponentInParent", 1, typeof(System.Boolean));
			RGetComponentInParent_GT = new RMethod(this, "GetComponentInParent", 1);
			RGetComponentsInParent_Type_Boolean = new RMethod(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
			RGetComponentsInParent_Type = new RMethod(this, "GetComponentsInParent", 0, typeof(System.Type));
			RGetComponentsInParent_GT_Boolean = new RMethod(this, "GetComponentsInParent", 1, typeof(System.Boolean));
			RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new RMethod(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponentsInParent_GT = new RMethod(this, "GetComponentsInParent", 1);
			RGetComponents_Type = new RMethod(this, "GetComponents", 0, typeof(System.Type));
			RGetComponents_Type_List_d_Component_p_ = new RMethod(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
			RGetComponents_GT_List_d_T_p_ = new RMethod(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
			RGetComponents_GT = new RMethod(this, "GetComponents", 1);
			RCompareTag_String = new RMethod(this, "CompareTag", 0, typeof(System.String));
			RGetCoupledComponent = new RMethod(this, "GetCoupledComponent", 0);
			RIsCoupledComponent = new RMethod(this, "IsCoupledComponent", 0);
			RSendMessageUpwards_String_Object_SendMessageOptions = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessageUpwards_String_Object = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
			RSendMessageUpwards_String = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String));
			RSendMessageUpwards_String_SendMessageOptions = new RMethod(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_Object = new RMethod(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
			RSendMessage_String = new RMethod(this, "SendMessage", 0, typeof(System.String));
			RSendMessage_String_Object_SendMessageOptions = new RMethod(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RSendMessage_String_SendMessageOptions = new RMethod(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_Object_SendMessageOptions = new RMethod(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
			RBroadcastMessage_String_Object = new RMethod(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
			RBroadcastMessage_String = new RMethod(this, "BroadcastMessage", 0, typeof(System.String));
			RBroadcastMessage_String_SendMessageOptions = new RMethod(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
			RGetInstanceID = new RMethod(this, "GetInstanceID", 0);
			RGetHashCode = new RMethod(this, "GetHashCode", 0);
			REquals_Object = new RMethod(this, "Equals", 0, typeof(System.Object));
			RToString = new RMethod(this, "ToString", 0);
			RFinalize = new RMethod(this, "Finalize", 0);
			RGetType = new RMethod(this, "GetType", 0);
			RMemberwiseClone = new RMethod(this, "MemberwiseClone", 0);

        }

        public virtual void SetLocalEulerHint(UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RSetLocalEulerHint_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.Int32 GetRotationOrderInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRotationOrderInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public virtual UnityEngine.Transform GetParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetParent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }

        public virtual void SetParent(UnityEngine.Transform  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RSetParent_Transform.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetParent(UnityEngine.Transform  @parent, System.Boolean  @worldPositionStays)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @worldPositionStays};
            var ___result = RSetParent_Transform_Boolean.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetPositionAndRotation(UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RSetPositionAndRotation_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetLocalPositionAndRotation(UnityEngine.Vector3  @localPosition, UnityEngine.Quaternion  @localRotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @localRotation};
            var ___result = RSetLocalPositionAndRotation_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Translate(UnityEngine.Vector3  @translation, UnityEngine.Space  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation, @relativeTo};
            var ___result = RTranslate_Vector3_Space.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Translate(UnityEngine.Vector3  @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation};
            var ___result = RTranslate_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Translate(System.Single  @x, System.Single  @y, System.Single  @z, UnityEngine.Space  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @relativeTo};
            var ___result = RTranslate_Single_Single_Single_Space.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Translate(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RTranslate_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Translate(UnityEngine.Vector3  @translation, UnityEngine.Transform  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation, @relativeTo};
            var ___result = RTranslate_Vector3_Transform.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Translate(System.Single  @x, System.Single  @y, System.Single  @z, UnityEngine.Transform  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @relativeTo};
            var ___result = RTranslate_Single_Single_Single_Transform.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Rotate(UnityEngine.Vector3  @eulers, UnityEngine.Space  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eulers, @relativeTo};
            var ___result = RRotate_Vector3_Space.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Rotate(UnityEngine.Vector3  @eulers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eulers};
            var ___result = RRotate_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Rotate(System.Single  @xAngle, System.Single  @yAngle, System.Single  @zAngle, UnityEngine.Space  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xAngle, @yAngle, @zAngle, @relativeTo};
            var ___result = RRotate_Single_Single_Single_Space.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Rotate(System.Single  @xAngle, System.Single  @yAngle, System.Single  @zAngle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xAngle, @yAngle, @zAngle};
            var ___result = RRotate_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void RotateAroundInternal(UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotateAroundInternal_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Rotate(UnityEngine.Vector3  @axis, System.Single  @angle, UnityEngine.Space  @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle, @relativeTo};
            var ___result = RRotate_Vector3_Single_Space.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Rotate(UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotate_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void RotateAround(UnityEngine.Vector3  @point, UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @axis, @angle};
            var ___result = RRotateAround_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void LookAt(UnityEngine.Transform  @target, UnityEngine.Vector3  @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @worldUp};
            var ___result = RLookAt_Transform_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void LookAt(UnityEngine.Transform  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RLookAt_Transform.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void LookAt(UnityEngine.Vector3  @worldPosition, UnityEngine.Vector3  @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition, @worldUp};
            var ___result = RLookAt_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void LookAt(UnityEngine.Vector3  @worldPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition};
            var ___result = RLookAt_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void Internal_LookAt(UnityEngine.Vector3  @worldPosition, UnityEngine.Vector3  @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition, @worldUp};
            var ___result = RInternal_LookAt_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3  @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RTransformDirection_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 TransformDirection(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RTransformDirection_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3  @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RInverseTransformDirection_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 InverseTransformDirection(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RInverseTransformDirection_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 TransformVector(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RTransformVector_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 TransformVector(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RTransformVector_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RInverseTransformVector_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 InverseTransformVector(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RInverseTransformVector_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RTransformPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 TransformPoint(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RTransformPoint_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RInverseTransformPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Vector3 InverseTransformPoint(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RInverseTransformPoint_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }

        public virtual UnityEngine.Transform GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }

        public virtual void DetachChildren()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDetachChildren.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetAsFirstSibling()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetAsFirstSibling.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetAsLastSibling()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetAsLastSibling.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void SetSiblingIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSetSiblingIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void MoveAfterSibling(UnityEngine.Transform  @transform, System.Boolean  @notifyEditorAndMarkDirty)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transform, @notifyEditorAndMarkDirty};
            var ___result = RMoveAfterSibling_Transform_Boolean.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.Int32 GetSiblingIndex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSiblingIndex.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public static UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform  @transform, System.String  @path, System.Boolean  @isActiveOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transform, @path, @isActiveOnly};
            var ___result = RFindRelativeTransformWithPath_Transform_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }

        public virtual UnityEngine.Transform Find(System.String  @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RFind_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }

        public virtual void SendTransformChangedScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendTransformChangedScale.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.Boolean IsChildOf(UnityEngine.Transform  @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent};
            var ___result = RIsChildOf_Transform.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public virtual UnityEngine.Transform FindChild(System.String  @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RFindChild_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }

        public virtual void RotateAround(UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotateAround_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual void RotateAroundLocal(UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotateAroundLocal_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }

        public virtual UnityEngine.Transform GetChild(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetChild_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }

        public virtual System.Int32 GetChildCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetChildCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public virtual System.Int32 internal_getHierarchyCapacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rinternal_getHierarchyCapacity.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public virtual void internal_setHierarchyCapacity(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rinternal_setHierarchyCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.Int32 internal_getHierarchyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rinternal_getHierarchyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public virtual System.Boolean IsNonUniformScaleTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNonUniformScaleTransform.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public virtual void SetConstrainProportionsScale(System.Boolean  @isLinked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isLinked};
            var ___result = RSetConstrainProportionsScale_Boolean.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.Boolean IsConstrainProportionsScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsConstrainProportionsScale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public virtual void get_position_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_position_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void set_position_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_position_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void get_localPosition_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localPosition_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void set_localPosition_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_localPosition_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void SetLocalEulerHint_Injected(ref UnityEngine.Vector3  @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RSetLocalEulerHint_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			euler = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void get_rotation_Injected(out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_rotation_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Quaternion)___parameters[0];

            
        }

        public virtual void set_rotation_Injected(ref UnityEngine.Quaternion  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_rotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Quaternion)___parameters[0];

            
        }

        public virtual void get_localRotation_Injected(out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localRotation_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Quaternion)___parameters[0];

            
        }

        public virtual void set_localRotation_Injected(ref UnityEngine.Quaternion  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_localRotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Quaternion)___parameters[0];

            
        }

        public virtual void get_localScale_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localScale_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void set_localScale_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_localScale_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void get_worldToLocalMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_worldToLocalMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }

        public virtual void get_localToWorldMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localToWorldMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }

        public virtual void SetPositionAndRotation_Injected(ref UnityEngine.Vector3  @position, ref UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];
			rotation = (UnityEngine.Quaternion)___parameters[1];

            
        }

        public virtual void SetLocalPositionAndRotation_Injected(ref UnityEngine.Vector3  @localPosition, ref UnityEngine.Quaternion  @localRotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @localRotation};
            var ___result = RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			localPosition = (UnityEngine.Vector3)___parameters[0];
			localRotation = (UnityEngine.Quaternion)___parameters[1];

            
        }

        public virtual void RotateAroundInternal_Injected(ref UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotateAroundInternal_Injected_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			axis = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void Internal_LookAt_Injected(ref UnityEngine.Vector3  @worldPosition, ref UnityEngine.Vector3  @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition, @worldUp};
            var ___result = RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			worldPosition = (UnityEngine.Vector3)___parameters[0];
			worldUp = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void TransformDirection_Injected(ref UnityEngine.Vector3  @direction, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @ret};
            var ___result = RTransformDirection_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			direction = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void InverseTransformDirection_Injected(ref UnityEngine.Vector3  @direction, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @ret};
            var ___result = RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			direction = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void TransformVector_Injected(ref UnityEngine.Vector3  @vector, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @ret};
            var ___result = RTransformVector_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			vector = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void InverseTransformVector_Injected(ref UnityEngine.Vector3  @vector, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @ret};
            var ___result = RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			vector = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void TransformPoint_Injected(ref UnityEngine.Vector3  @position, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RTransformPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void InverseTransformPoint_Injected(ref UnityEngine.Vector3  @position, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }

        public virtual void get_lossyScale_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_lossyScale_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void RotateAround_Injected(ref UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotateAround_Injected_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			axis = (UnityEngine.Vector3)___parameters[0];

            
        }

        public virtual void RotateAroundLocal_Injected(ref UnityEngine.Vector3  @axis, System.Single  @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RRotateAroundLocal_Injected_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			axis = (UnityEngine.Vector3)___parameters[0];

            
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
