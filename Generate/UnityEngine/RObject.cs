using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Object
	/// </summary>
    public partial class RObject : RMember //
    {

		/// <summary>
		/// System.IntPtr m_CachedPtr
		/// </summary>
		protected RField r_m_CachedPtr;
		public virtual RField Rm_CachedPtr
		{
			get
			{
				if(r_m_CachedPtr == null)
				{
					r_m_CachedPtr = new(this, "m_CachedPtr");
					r_m_CachedPtr.SetBelong(this.instance);
				}
				return r_m_CachedPtr;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected RField r_m_InstanceID;
		public virtual RField Rm_InstanceID
		{
			get
			{
				if(r_m_InstanceID == null)
				{
					r_m_InstanceID = new(this, "m_InstanceID");
					r_m_InstanceID.SetBelong(this.instance);
				}
				return r_m_InstanceID;
			}
		}

		/// <summary>
		/// System.String m_UnityRuntimeErrorString
		/// </summary>
		protected RField r_m_UnityRuntimeErrorString;
		public virtual RField Rm_UnityRuntimeErrorString
		{
			get
			{
				if(r_m_UnityRuntimeErrorString == null)
				{
					r_m_UnityRuntimeErrorString = new(this, "m_UnityRuntimeErrorString");
					r_m_UnityRuntimeErrorString.SetBelong(this.instance);
				}
				return r_m_UnityRuntimeErrorString;
			}
		}

		/// <summary>
		/// System.Int32 OffsetOfInstanceIDInCPlusPlusObject
		/// </summary>
		protected static RField r_OffsetOfInstanceIDInCPlusPlusObject;
		public static RField ROffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				if(r_OffsetOfInstanceIDInCPlusPlusObject == null)
				{
					r_OffsetOfInstanceIDInCPlusPlusObject = new(typeof(UnityEngine.Object), "OffsetOfInstanceIDInCPlusPlusObject");
					r_OffsetOfInstanceIDInCPlusPlusObject.SetBelong(null);
				}
				return r_OffsetOfInstanceIDInCPlusPlusObject;
			}
		}

		/// <summary>
		/// System.String objectIsNullMessage
		/// </summary>
		protected static RField r_objectIsNullMessage;
		public static RField RobjectIsNullMessage
		{
			get
			{
				if(r_objectIsNullMessage == null)
				{
					r_objectIsNullMessage = new(typeof(UnityEngine.Object), "objectIsNullMessage");
					r_objectIsNullMessage.SetBelong(null);
				}
				return r_objectIsNullMessage;
			}
		}

		/// <summary>
		/// System.String cloneDestroyedMessage
		/// </summary>
		protected static RField r_cloneDestroyedMessage;
		public static RField RcloneDestroyedMessage
		{
			get
			{
				if(r_cloneDestroyedMessage == null)
				{
					r_cloneDestroyedMessage = new(typeof(UnityEngine.Object), "cloneDestroyedMessage");
					r_cloneDestroyedMessage.SetBelong(null);
				}
				return r_cloneDestroyedMessage;
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
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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
		/// Boolean op_Implicit(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_op_Implicit_Object;
		public static RMethod Rop_Implicit_Object
		{
			get
			{
				if(r_op_Implicit_Object == null)
				{
					r_op_Implicit_Object = new(typeof(UnityEngine.Object), "op_Implicit", 0, typeof(UnityEngine.Object));
					r_op_Implicit_Object.SetBelong(null);
				}
				return r_op_Implicit_Object;
			}
		}

		/// <summary>
		/// Boolean CompareBaseObjects(UnityEngine.Object, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_CompareBaseObjects_Object_Object;
		public static RMethod RCompareBaseObjects_Object_Object
		{
			get
			{
				if(r_CompareBaseObjects_Object_Object == null)
				{
					r_CompareBaseObjects_Object_Object = new(typeof(UnityEngine.Object), "CompareBaseObjects", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object));
					r_CompareBaseObjects_Object_Object.SetBelong(null);
				}
				return r_CompareBaseObjects_Object_Object;
			}
		}

		/// <summary>
		/// Void EnsureRunningOnMainThread()
		/// </summary>
		protected RMethod r_EnsureRunningOnMainThread;
		public virtual RMethod REnsureRunningOnMainThread
		{
			get
			{
				if(r_EnsureRunningOnMainThread == null)
				{
					r_EnsureRunningOnMainThread = new(this, "EnsureRunningOnMainThread", 0);
					r_EnsureRunningOnMainThread.SetBelong(this.instance);
				}
				return r_EnsureRunningOnMainThread;
			}
		}

		/// <summary>
		/// Boolean IsNativeObjectAlive(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_IsNativeObjectAlive_Object;
		public static RMethod RIsNativeObjectAlive_Object
		{
			get
			{
				if(r_IsNativeObjectAlive_Object == null)
				{
					r_IsNativeObjectAlive_Object = new(typeof(UnityEngine.Object), "IsNativeObjectAlive", 0, typeof(UnityEngine.Object));
					r_IsNativeObjectAlive_Object.SetBelong(null);
				}
				return r_IsNativeObjectAlive_Object;
			}
		}

		/// <summary>
		/// IntPtr GetCachedPtr()
		/// </summary>
		protected RMethod r_GetCachedPtr;
		public virtual RMethod RGetCachedPtr
		{
			get
			{
				if(r_GetCachedPtr == null)
				{
					r_GetCachedPtr = new(this, "GetCachedPtr", 0);
					r_GetCachedPtr.SetBelong(this.instance);
				}
				return r_GetCachedPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Instantiate_Object_Vector3_Quaternion;
		public static RMethod RInstantiate_Object_Vector3_Quaternion
		{
			get
			{
				if(r_Instantiate_Object_Vector3_Quaternion == null)
				{
					r_Instantiate_Object_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_Instantiate_Object_Vector3_Quaternion.SetBelong(null);
				}
				return r_Instantiate_Object_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_Instantiate_Object_Vector3_Quaternion_Transform;
		public static RMethod RInstantiate_Object_Vector3_Quaternion_Transform
		{
			get
			{
				if(r_Instantiate_Object_Vector3_Quaternion_Transform == null)
				{
					r_Instantiate_Object_Vector3_Quaternion_Transform = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Transform));
					r_Instantiate_Object_Vector3_Quaternion_Transform.SetBelong(null);
				}
				return r_Instantiate_Object_Vector3_Quaternion_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_Instantiate_Object;
		public static RMethod RInstantiate_Object
		{
			get
			{
				if(r_Instantiate_Object == null)
				{
					r_Instantiate_Object = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object));
					r_Instantiate_Object.SetBelong(null);
				}
				return r_Instantiate_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_Instantiate_Object_Transform;
		public static RMethod RInstantiate_Object_Transform
		{
			get
			{
				if(r_Instantiate_Object_Transform == null)
				{
					r_Instantiate_Object_Transform = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform));
					r_Instantiate_Object_Transform.SetBelong(null);
				}
				return r_Instantiate_Object_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Transform, Boolean)
		/// </summary>
		protected static RMethod r_Instantiate_Object_Transform_Boolean;
		public static RMethod RInstantiate_Object_Transform_Boolean
		{
			get
			{
				if(r_Instantiate_Object_Transform_Boolean == null)
				{
					r_Instantiate_Object_Transform_Boolean = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_Instantiate_Object_Transform_Boolean.SetBelong(null);
				}
				return r_Instantiate_Object_Transform_Boolean;
			}
		}

		/// <summary>
		/// T Instantiate[T](T)
		/// </summary>
		protected static RMethod r_Instantiate_GT_T;
		public static RMethod RInstantiate_GT_T
		{
			get
			{
				if(r_Instantiate_GT_T == null)
				{
					r_Instantiate_GT_T = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0));
					r_Instantiate_GT_T.SetBelong(null);
				}
				return r_Instantiate_GT_T;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Instantiate_GT_T_Vector3_Quaternion;
		public static RMethod RInstantiate_GT_T_Vector3_Quaternion
		{
			get
			{
				if(r_Instantiate_GT_T_Vector3_Quaternion == null)
				{
					r_Instantiate_GT_T_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_Instantiate_GT_T_Vector3_Quaternion.SetBelong(null);
				}
				return r_Instantiate_GT_T_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_Instantiate_GT_T_Vector3_Quaternion_Transform;
		public static RMethod RInstantiate_GT_T_Vector3_Quaternion_Transform
		{
			get
			{
				if(r_Instantiate_GT_T_Vector3_Quaternion_Transform == null)
				{
					r_Instantiate_GT_T_Vector3_Quaternion_Transform = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Transform));
					r_Instantiate_GT_T_Vector3_Quaternion_Transform.SetBelong(null);
				}
				return r_Instantiate_GT_T_Vector3_Quaternion_Transform;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_Instantiate_GT_T_Transform;
		public static RMethod RInstantiate_GT_T_Transform
		{
			get
			{
				if(r_Instantiate_GT_T_Transform == null)
				{
					r_Instantiate_GT_T_Transform = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Transform));
					r_Instantiate_GT_T_Transform.SetBelong(null);
				}
				return r_Instantiate_GT_T_Transform;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Transform, Boolean)
		/// </summary>
		protected static RMethod r_Instantiate_GT_T_Transform_Boolean;
		public static RMethod RInstantiate_GT_T_Transform_Boolean
		{
			get
			{
				if(r_Instantiate_GT_T_Transform_Boolean == null)
				{
					r_Instantiate_GT_T_Transform_Boolean = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_Instantiate_GT_T_Transform_Boolean.SetBelong(null);
				}
				return r_Instantiate_GT_T_Transform_Boolean;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Object, Single)
		/// </summary>
		protected static RMethod r_Destroy_Object_Single;
		public static RMethod RDestroy_Object_Single
		{
			get
			{
				if(r_Destroy_Object_Single == null)
				{
					r_Destroy_Object_Single = new(typeof(UnityEngine.Object), "Destroy", 0, typeof(UnityEngine.Object), typeof(System.Single));
					r_Destroy_Object_Single.SetBelong(null);
				}
				return r_Destroy_Object_Single;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_Destroy_Object;
		public static RMethod RDestroy_Object
		{
			get
			{
				if(r_Destroy_Object == null)
				{
					r_Destroy_Object = new(typeof(UnityEngine.Object), "Destroy", 0, typeof(UnityEngine.Object));
					r_Destroy_Object.SetBelong(null);
				}
				return r_Destroy_Object;
			}
		}

		/// <summary>
		/// Void DestroyImmediate(UnityEngine.Object, Boolean)
		/// </summary>
		protected static RMethod r_DestroyImmediate_Object_Boolean;
		public static RMethod RDestroyImmediate_Object_Boolean
		{
			get
			{
				if(r_DestroyImmediate_Object_Boolean == null)
				{
					r_DestroyImmediate_Object_Boolean = new(typeof(UnityEngine.Object), "DestroyImmediate", 0, typeof(UnityEngine.Object), typeof(System.Boolean));
					r_DestroyImmediate_Object_Boolean.SetBelong(null);
				}
				return r_DestroyImmediate_Object_Boolean;
			}
		}

		/// <summary>
		/// Void DestroyImmediate(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_DestroyImmediate_Object;
		public static RMethod RDestroyImmediate_Object
		{
			get
			{
				if(r_DestroyImmediate_Object == null)
				{
					r_DestroyImmediate_Object = new(typeof(UnityEngine.Object), "DestroyImmediate", 0, typeof(UnityEngine.Object));
					r_DestroyImmediate_Object.SetBelong(null);
				}
				return r_DestroyImmediate_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfType(System.Type)
		/// </summary>
		protected static RMethod r_FindObjectsOfType_Type;
		public static RMethod RFindObjectsOfType_Type
		{
			get
			{
				if(r_FindObjectsOfType_Type == null)
				{
					r_FindObjectsOfType_Type = new(typeof(UnityEngine.Object), "FindObjectsOfType", 0, typeof(System.Type));
					r_FindObjectsOfType_Type.SetBelong(null);
				}
				return r_FindObjectsOfType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_FindObjectsOfType_Type_Boolean;
		public static RMethod RFindObjectsOfType_Type_Boolean
		{
			get
			{
				if(r_FindObjectsOfType_Type_Boolean == null)
				{
					r_FindObjectsOfType_Type_Boolean = new(typeof(UnityEngine.Object), "FindObjectsOfType", 0, typeof(System.Type), typeof(System.Boolean));
					r_FindObjectsOfType_Type_Boolean.SetBelong(null);
				}
				return r_FindObjectsOfType_Type_Boolean;
			}
		}

		/// <summary>
		/// Void DontDestroyOnLoad(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_DontDestroyOnLoad_Object;
		public static RMethod RDontDestroyOnLoad_Object
		{
			get
			{
				if(r_DontDestroyOnLoad_Object == null)
				{
					r_DontDestroyOnLoad_Object = new(typeof(UnityEngine.Object), "DontDestroyOnLoad", 0, typeof(UnityEngine.Object));
					r_DontDestroyOnLoad_Object.SetBelong(null);
				}
				return r_DontDestroyOnLoad_Object;
			}
		}

		/// <summary>
		/// Void DestroyObject(UnityEngine.Object, Single)
		/// </summary>
		protected static RMethod r_DestroyObject_Object_Single;
		public static RMethod RDestroyObject_Object_Single
		{
			get
			{
				if(r_DestroyObject_Object_Single == null)
				{
					r_DestroyObject_Object_Single = new(typeof(UnityEngine.Object), "DestroyObject", 0, typeof(UnityEngine.Object), typeof(System.Single));
					r_DestroyObject_Object_Single.SetBelong(null);
				}
				return r_DestroyObject_Object_Single;
			}
		}

		/// <summary>
		/// Void DestroyObject(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_DestroyObject_Object;
		public static RMethod RDestroyObject_Object
		{
			get
			{
				if(r_DestroyObject_Object == null)
				{
					r_DestroyObject_Object = new(typeof(UnityEngine.Object), "DestroyObject", 0, typeof(UnityEngine.Object));
					r_DestroyObject_Object.SetBelong(null);
				}
				return r_DestroyObject_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindSceneObjectsOfType(System.Type)
		/// </summary>
		protected static RMethod r_FindSceneObjectsOfType_Type;
		public static RMethod RFindSceneObjectsOfType_Type
		{
			get
			{
				if(r_FindSceneObjectsOfType_Type == null)
				{
					r_FindSceneObjectsOfType_Type = new(typeof(UnityEngine.Object), "FindSceneObjectsOfType", 0, typeof(System.Type));
					r_FindSceneObjectsOfType_Type.SetBelong(null);
				}
				return r_FindSceneObjectsOfType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type)
		/// </summary>
		protected static RMethod r_FindObjectsOfTypeIncludingAssets_Type;
		public static RMethod RFindObjectsOfTypeIncludingAssets_Type
		{
			get
			{
				if(r_FindObjectsOfTypeIncludingAssets_Type == null)
				{
					r_FindObjectsOfTypeIncludingAssets_Type = new(typeof(UnityEngine.Object), "FindObjectsOfTypeIncludingAssets", 0, typeof(System.Type));
					r_FindObjectsOfTypeIncludingAssets_Type.SetBelong(null);
				}
				return r_FindObjectsOfTypeIncludingAssets_Type;
			}
		}

		/// <summary>
		/// T[] FindObjectsOfType[T]()
		/// </summary>
		protected static RMethod r_FindObjectsOfType_GT;
		public static RMethod RFindObjectsOfType_GT
		{
			get
			{
				if(r_FindObjectsOfType_GT == null)
				{
					r_FindObjectsOfType_GT = new(typeof(UnityEngine.Object), "FindObjectsOfType", 1);
					r_FindObjectsOfType_GT.SetBelong(null);
				}
				return r_FindObjectsOfType_GT;
			}
		}

		/// <summary>
		/// T[] FindObjectsOfType[T](Boolean)
		/// </summary>
		protected static RMethod r_FindObjectsOfType_GT_Boolean;
		public static RMethod RFindObjectsOfType_GT_Boolean
		{
			get
			{
				if(r_FindObjectsOfType_GT_Boolean == null)
				{
					r_FindObjectsOfType_GT_Boolean = new(typeof(UnityEngine.Object), "FindObjectsOfType", 1, typeof(System.Boolean));
					r_FindObjectsOfType_GT_Boolean.SetBelong(null);
				}
				return r_FindObjectsOfType_GT_Boolean;
			}
		}

		/// <summary>
		/// T FindObjectOfType[T]()
		/// </summary>
		protected static RMethod r_FindObjectOfType_GT;
		public static RMethod RFindObjectOfType_GT
		{
			get
			{
				if(r_FindObjectOfType_GT == null)
				{
					r_FindObjectOfType_GT = new(typeof(UnityEngine.Object), "FindObjectOfType", 1);
					r_FindObjectOfType_GT.SetBelong(null);
				}
				return r_FindObjectOfType_GT;
			}
		}

		/// <summary>
		/// T FindObjectOfType[T](Boolean)
		/// </summary>
		protected static RMethod r_FindObjectOfType_GT_Boolean;
		public static RMethod RFindObjectOfType_GT_Boolean
		{
			get
			{
				if(r_FindObjectOfType_GT_Boolean == null)
				{
					r_FindObjectOfType_GT_Boolean = new(typeof(UnityEngine.Object), "FindObjectOfType", 1, typeof(System.Boolean));
					r_FindObjectOfType_GT_Boolean.SetBelong(null);
				}
				return r_FindObjectOfType_GT_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfTypeAll(System.Type)
		/// </summary>
		protected static RMethod r_FindObjectsOfTypeAll_Type;
		public static RMethod RFindObjectsOfTypeAll_Type
		{
			get
			{
				if(r_FindObjectsOfTypeAll_Type == null)
				{
					r_FindObjectsOfTypeAll_Type = new(typeof(UnityEngine.Object), "FindObjectsOfTypeAll", 0, typeof(System.Type));
					r_FindObjectsOfTypeAll_Type.SetBelong(null);
				}
				return r_FindObjectsOfTypeAll_Type;
			}
		}

		/// <summary>
		/// Void CheckNullArgument(System.Object, System.String)
		/// </summary>
		protected static RMethod r_CheckNullArgument_Object_String;
		public static RMethod RCheckNullArgument_Object_String
		{
			get
			{
				if(r_CheckNullArgument_Object_String == null)
				{
					r_CheckNullArgument_Object_String = new(typeof(UnityEngine.Object), "CheckNullArgument", 0, typeof(System.Object), typeof(System.String));
					r_CheckNullArgument_Object_String.SetBelong(null);
				}
				return r_CheckNullArgument_Object_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindObjectOfType(System.Type)
		/// </summary>
		protected static RMethod r_FindObjectOfType_Type;
		public static RMethod RFindObjectOfType_Type
		{
			get
			{
				if(r_FindObjectOfType_Type == null)
				{
					r_FindObjectOfType_Type = new(typeof(UnityEngine.Object), "FindObjectOfType", 0, typeof(System.Type));
					r_FindObjectOfType_Type.SetBelong(null);
				}
				return r_FindObjectOfType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindObjectOfType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_FindObjectOfType_Type_Boolean;
		public static RMethod RFindObjectOfType_Type_Boolean
		{
			get
			{
				if(r_FindObjectOfType_Type_Boolean == null)
				{
					r_FindObjectOfType_Type_Boolean = new(typeof(UnityEngine.Object), "FindObjectOfType", 0, typeof(System.Type), typeof(System.Boolean));
					r_FindObjectOfType_Type_Boolean.SetBelong(null);
				}
				return r_FindObjectOfType_Type_Boolean;
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
		/// Boolean op_Equality(UnityEngine.Object, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_op_Equality_Object_Object;
		public static RMethod Rop_Equality_Object_Object
		{
			get
			{
				if(r_op_Equality_Object_Object == null)
				{
					r_op_Equality_Object_Object = new(typeof(UnityEngine.Object), "op_Equality", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object));
					r_op_Equality_Object_Object.SetBelong(null);
				}
				return r_op_Equality_Object_Object;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Object, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_op_Inequality_Object_Object;
		public static RMethod Rop_Inequality_Object_Object
		{
			get
			{
				if(r_op_Inequality_Object_Object == null)
				{
					r_op_Inequality_Object_Object = new(typeof(UnityEngine.Object), "op_Inequality", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object));
					r_op_Inequality_Object_Object.SetBelong(null);
				}
				return r_op_Inequality_Object_Object;
			}
		}

		/// <summary>
		/// Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
		/// </summary>
		protected static RMethod r_GetOffsetOfInstanceIDInCPlusPlusObject;
		public static RMethod RGetOffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				if(r_GetOffsetOfInstanceIDInCPlusPlusObject == null)
				{
					r_GetOffsetOfInstanceIDInCPlusPlusObject = new(typeof(UnityEngine.Object), "GetOffsetOfInstanceIDInCPlusPlusObject", 0);
					r_GetOffsetOfInstanceIDInCPlusPlusObject.SetBelong(null);
				}
				return r_GetOffsetOfInstanceIDInCPlusPlusObject;
			}
		}

		/// <summary>
		/// Boolean CurrentThreadIsMainThread()
		/// </summary>
		protected static RMethod r_CurrentThreadIsMainThread;
		public static RMethod RCurrentThreadIsMainThread
		{
			get
			{
				if(r_CurrentThreadIsMainThread == null)
				{
					r_CurrentThreadIsMainThread = new(typeof(UnityEngine.Object), "CurrentThreadIsMainThread", 0);
					r_CurrentThreadIsMainThread.SetBelong(null);
				}
				return r_CurrentThreadIsMainThread;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_CloneSingle(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_Internal_CloneSingle_Object;
		public static RMethod RInternal_CloneSingle_Object
		{
			get
			{
				if(r_Internal_CloneSingle_Object == null)
				{
					r_Internal_CloneSingle_Object = new(typeof(UnityEngine.Object), "Internal_CloneSingle", 0, typeof(UnityEngine.Object));
					r_Internal_CloneSingle_Object.SetBelong(null);
				}
				return r_Internal_CloneSingle_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object, UnityEngine.Transform, Boolean)
		/// </summary>
		protected static RMethod r_Internal_CloneSingleWithParent_Object_Transform_Boolean;
		public static RMethod RInternal_CloneSingleWithParent_Object_Transform_Boolean
		{
			get
			{
				if(r_Internal_CloneSingleWithParent_Object_Transform_Boolean == null)
				{
					r_Internal_CloneSingleWithParent_Object_Transform_Boolean = new(typeof(UnityEngine.Object), "Internal_CloneSingleWithParent", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_Internal_CloneSingleWithParent_Object_Transform_Boolean.SetBelong(null);
				}
				return r_Internal_CloneSingleWithParent_Object_Transform_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Internal_InstantiateSingle_Object_Vector3_Quaternion;
		public static RMethod RInternal_InstantiateSingle_Object_Vector3_Quaternion
		{
			get
			{
				if(r_Internal_InstantiateSingle_Object_Vector3_Quaternion == null)
				{
					r_Internal_InstantiateSingle_Object_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingle", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_Internal_InstantiateSingle_Object_Vector3_Quaternion.SetBelong(null);
				}
				return r_Internal_InstantiateSingle_Object_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object, UnityEngine.Transform, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_Internal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion;
		public static RMethod RInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion
		{
			get
			{
				if(r_Internal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion == null)
				{
					r_Internal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingleWithParent", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_Internal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion.SetBelong(null);
				}
				return r_Internal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// System.String ToString(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_ToString_Object;
		public static RMethod RToString_Object
		{
			get
			{
				if(r_ToString_Object == null)
				{
					r_ToString_Object = new(typeof(UnityEngine.Object), "ToString", 0, typeof(UnityEngine.Object));
					r_ToString_Object.SetBelong(null);
				}
				return r_ToString_Object;
			}
		}

		/// <summary>
		/// System.String GetName(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_GetName_Object;
		public static RMethod RGetName_Object
		{
			get
			{
				if(r_GetName_Object == null)
				{
					r_GetName_Object = new(typeof(UnityEngine.Object), "GetName", 0, typeof(UnityEngine.Object));
					r_GetName_Object.SetBelong(null);
				}
				return r_GetName_Object;
			}
		}

		/// <summary>
		/// Boolean IsPersistent(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_IsPersistent_Object;
		public static RMethod RIsPersistent_Object
		{
			get
			{
				if(r_IsPersistent_Object == null)
				{
					r_IsPersistent_Object = new(typeof(UnityEngine.Object), "IsPersistent", 0, typeof(UnityEngine.Object));
					r_IsPersistent_Object.SetBelong(null);
				}
				return r_IsPersistent_Object;
			}
		}

		/// <summary>
		/// Void SetName(UnityEngine.Object, System.String)
		/// </summary>
		protected static RMethod r_SetName_Object_String;
		public static RMethod RSetName_Object_String
		{
			get
			{
				if(r_SetName_Object_String == null)
				{
					r_SetName_Object_String = new(typeof(UnityEngine.Object), "SetName", 0, typeof(UnityEngine.Object), typeof(System.String));
					r_SetName_Object_String.SetBelong(null);
				}
				return r_SetName_Object_String;
			}
		}

		/// <summary>
		/// Boolean DoesObjectWithInstanceIDExist(Int32)
		/// </summary>
		protected static RMethod r_DoesObjectWithInstanceIDExist_Int32;
		public static RMethod RDoesObjectWithInstanceIDExist_Int32
		{
			get
			{
				if(r_DoesObjectWithInstanceIDExist_Int32 == null)
				{
					r_DoesObjectWithInstanceIDExist_Int32 = new(typeof(UnityEngine.Object), "DoesObjectWithInstanceIDExist", 0, typeof(System.Int32));
					r_DoesObjectWithInstanceIDExist_Int32.SetBelong(null);
				}
				return r_DoesObjectWithInstanceIDExist_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindObjectFromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_FindObjectFromInstanceID_Int32;
		public static RMethod RFindObjectFromInstanceID_Int32
		{
			get
			{
				if(r_FindObjectFromInstanceID_Int32 == null)
				{
					r_FindObjectFromInstanceID_Int32 = new(typeof(UnityEngine.Object), "FindObjectFromInstanceID", 0, typeof(System.Int32));
					r_FindObjectFromInstanceID_Int32.SetBelong(null);
				}
				return r_FindObjectFromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object ForceLoadFromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_ForceLoadFromInstanceID_Int32;
		public static RMethod RForceLoadFromInstanceID_Int32
		{
			get
			{
				if(r_ForceLoadFromInstanceID_Int32 == null)
				{
					r_ForceLoadFromInstanceID_Int32 = new(typeof(UnityEngine.Object), "ForceLoadFromInstanceID", 0, typeof(System.Int32));
					r_ForceLoadFromInstanceID_Int32.SetBelong(null);
				}
				return r_ForceLoadFromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object CreateMissingReferenceObject(Int32)
		/// </summary>
		protected static RMethod r_CreateMissingReferenceObject_Int32;
		public static RMethod RCreateMissingReferenceObject_Int32
		{
			get
			{
				if(r_CreateMissingReferenceObject_Int32 == null)
				{
					r_CreateMissingReferenceObject_Int32 = new(typeof(UnityEngine.Object), "CreateMissingReferenceObject", 0, typeof(System.Int32));
					r_CreateMissingReferenceObject_Int32.SetBelong(null);
				}
				return r_CreateMissingReferenceObject_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_Internal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion;
		public static RMethod RInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_Internal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion == null)
				{
					r_Internal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingle_Injected", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Internal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion.SetBelong(null);
				}
				return r_Internal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object, UnityEngine.Transform, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_Internal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion;
		public static RMethod RInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_Internal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion == null)
				{
					r_Internal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingleWithParent_Injected", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Internal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion.SetBelong(null);
				}
				return r_Internal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion;
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


        public RObject() : base("UnityEngine.Object")
        {
        }

        public RObject(System.Object instance) : base("UnityEngine.Object")
		{
            SetInstance(instance);
		}

        public RObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public static System.Boolean op_Implicit(UnityEngine.Object  @exists)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exists};
            var ___result = Rop_Implicit_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CompareBaseObjects(UnityEngine.Object  @lhs, UnityEngine.Object  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RCompareBaseObjects_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EnsureRunningOnMainThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureRunningOnMainThread.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsNativeObjectAlive(UnityEngine.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RIsNativeObjectAlive_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IntPtr GetCachedPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCachedPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object  @original, UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @position, @rotation};
            var ___result = RInstantiate_Object_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object  @original, UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation, UnityEngine.Transform  @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @position, @rotation, @parent};
            var ___result = RInstantiate_Object_Vector3_Quaternion_Transform.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object  @original)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original};
            var ___result = RInstantiate_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object  @original, UnityEngine.Transform  @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @parent};
            var ___result = RInstantiate_Object_Transform.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object  @original, UnityEngine.Transform  @parent, System.Boolean  @instantiateInWorldSpace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @parent, @instantiateInWorldSpace};
            var ___result = RInstantiate_Object_Transform_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static T Instantiate<T>(T  @original) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original};
            var ___result = RInstantiate_GT_T.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T  @original, UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @position, @rotation};
            var ___result = RInstantiate_GT_T_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T  @original, UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation, UnityEngine.Transform  @parent) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @position, @rotation, @parent};
            var ___result = RInstantiate_GT_T_Vector3_Quaternion_Transform.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T  @original, UnityEngine.Transform  @parent) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @parent};
            var ___result = RInstantiate_GT_T_Transform.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T  @original, UnityEngine.Transform  @parent, System.Boolean  @worldPositionStays) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @parent, @worldPositionStays};
            var ___result = RInstantiate_GT_T_Transform_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static void Destroy(UnityEngine.Object  @obj, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @t};
            var ___result = RDestroy_Object_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void Destroy(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RDestroy_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyImmediate(UnityEngine.Object  @obj, System.Boolean  @allowDestroyingAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @allowDestroyingAssets};
            var ___result = RDestroyImmediate_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyImmediate(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RDestroyImmediate_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Object[] FindObjectsOfType(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RFindObjectsOfType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static UnityEngine.Object[] FindObjectsOfType(System.Type  @type, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RFindObjectsOfType_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static void DontDestroyOnLoad(UnityEngine.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RDontDestroyOnLoad_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyObject(UnityEngine.Object  @obj, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @t};
            var ___result = RDestroyObject_Object_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyObject(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RDestroyObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Object[] FindSceneObjectsOfType(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RFindSceneObjectsOfType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RFindObjectsOfTypeIncludingAssets_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RFindObjectsOfType_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static T[] FindObjectsOfType<T>(System.Boolean  @includeInactive) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RFindObjectsOfType_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static T FindObjectOfType<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RFindObjectOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T FindObjectOfType<T>(System.Boolean  @includeInactive) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RFindObjectOfType_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static UnityEngine.Object[] FindObjectsOfTypeAll(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RFindObjectsOfTypeAll_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static void CheckNullArgument(System.Object  @arg, System.String  @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @message};
            var ___result = RCheckNullArgument_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Object FindObjectOfType(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RFindObjectOfType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object FindObjectOfType(System.Type  @type, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RFindObjectOfType_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Object  @x, UnityEngine.Object  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = Rop_Equality_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Object  @x, UnityEngine.Object  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = Rop_Inequality_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOffsetOfInstanceIDInCPlusPlusObject.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean CurrentThreadIsMainThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCurrentThreadIsMainThread.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Object Internal_CloneSingle(UnityEngine.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RInternal_CloneSingle_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object  @data, UnityEngine.Transform  @parent, System.Boolean  @worldPositionStays)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @parent, @worldPositionStays};
            var ___result = RInternal_CloneSingleWithParent_Object_Transform_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object  @data, UnityEngine.Vector3  @pos, UnityEngine.Quaternion  @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rot};
            var ___result = RInternal_InstantiateSingle_Object_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object  @data, UnityEngine.Transform  @parent, UnityEngine.Vector3  @pos, UnityEngine.Quaternion  @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @parent, @pos, @rot};
            var ___result = RInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static System.String ToString(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RToString_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetName(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetName_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean IsPersistent(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RIsPersistent_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetName(UnityEngine.Object  @obj, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @name};
            var ___result = RSetName_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean DoesObjectWithInstanceIDExist(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RDoesObjectWithInstanceIDExist_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Object FindObjectFromInstanceID(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RFindObjectFromInstanceID_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object ForceLoadFromInstanceID(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RForceLoadFromInstanceID_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object CreateMissingReferenceObject(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RCreateMissingReferenceObject_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object  @data, ref UnityEngine.Vector3  @pos, ref UnityEngine.Quaternion  @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rot};
            var ___result = RInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			pos = (UnityEngine.Vector3)___parameters[1];
			rot = (UnityEngine.Quaternion)___parameters[2];

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object  @data, UnityEngine.Transform  @parent, ref UnityEngine.Vector3  @pos, ref UnityEngine.Quaternion  @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @parent, @pos, @rot};
            var ___result = RInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			pos = (UnityEngine.Vector3)___parameters[2];
			rot = (UnityEngine.Quaternion)___parameters[3];

            return (UnityEngine.Object)___result;
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
