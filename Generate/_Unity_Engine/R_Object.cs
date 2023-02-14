
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Object
	/// </summary>
    public partial class RObject : RMember //
    {

		/// <summary>
		/// System.IntPtr m_CachedPtr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_CachedPtr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_CachedPtr
		{
			get
			{
				if(r_Fm_CachedPtr == null)
				{
					r_Fm_CachedPtr = new(this, "m_CachedPtr");
					r_Fm_CachedPtr.SetBelong(this.instance);
				}
				return r_Fm_CachedPtr;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_InstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_InstanceID
		{
			get
			{
				if(r_Fm_InstanceID == null)
				{
					r_Fm_InstanceID = new(this, "m_InstanceID");
					r_Fm_InstanceID.SetBelong(this.instance);
				}
				return r_Fm_InstanceID;
			}
		}

		/// <summary>
		/// System.String m_UnityRuntimeErrorString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_UnityRuntimeErrorString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_UnityRuntimeErrorString
		{
			get
			{
				if(r_Fm_UnityRuntimeErrorString == null)
				{
					r_Fm_UnityRuntimeErrorString = new(this, "m_UnityRuntimeErrorString");
					r_Fm_UnityRuntimeErrorString.SetBelong(this.instance);
				}
				return r_Fm_UnityRuntimeErrorString;
			}
		}

		/// <summary>
		/// System.Int32 OffsetOfInstanceIDInCPlusPlusObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FOffsetOfInstanceIDInCPlusPlusObject;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFOffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				if(r_FOffsetOfInstanceIDInCPlusPlusObject == null)
				{
					r_FOffsetOfInstanceIDInCPlusPlusObject = new(typeof(UnityEngine.Object), "OffsetOfInstanceIDInCPlusPlusObject");
					r_FOffsetOfInstanceIDInCPlusPlusObject.SetBelong(null);
				}
				return r_FOffsetOfInstanceIDInCPlusPlusObject;
			}
		}

		/// <summary>
		/// System.String objectIsNullMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FobjectIsNullMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFobjectIsNullMessage
		{
			get
			{
				if(r_FobjectIsNullMessage == null)
				{
					r_FobjectIsNullMessage = new(typeof(UnityEngine.Object), "objectIsNullMessage");
					r_FobjectIsNullMessage.SetBelong(null);
				}
				return r_FobjectIsNullMessage;
			}
		}

		/// <summary>
		/// System.String cloneDestroyedMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FcloneDestroyedMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFcloneDestroyedMessage
		{
			get
			{
				if(r_FcloneDestroyedMessage == null)
				{
					r_FcloneDestroyedMessage = new(typeof(UnityEngine.Object), "cloneDestroyedMessage");
					r_FcloneDestroyedMessage.SetBelong(null);
				}
				return r_FcloneDestroyedMessage;
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
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean op_Implicit(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Object;
		public static RMethod RMop_Implicit_Object
		{
			get
			{
				if(r_Mop_Implicit_Object == null)
				{
					r_Mop_Implicit_Object = new(typeof(UnityEngine.Object), "op_Implicit", 0, typeof(UnityEngine.Object));
					r_Mop_Implicit_Object.SetBelong(null);
				}
				return r_Mop_Implicit_Object;
			}
		}

		/// <summary>
		/// Boolean CompareBaseObjects(UnityEngine.Object, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MCompareBaseObjects_Object_Object;
		public static RMethod RMCompareBaseObjects_Object_Object
		{
			get
			{
				if(r_MCompareBaseObjects_Object_Object == null)
				{
					r_MCompareBaseObjects_Object_Object = new(typeof(UnityEngine.Object), "CompareBaseObjects", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object));
					r_MCompareBaseObjects_Object_Object.SetBelong(null);
				}
				return r_MCompareBaseObjects_Object_Object;
			}
		}

		/// <summary>
		/// Void EnsureRunningOnMainThread()
		/// </summary>
		protected RMethod r_MEnsureRunningOnMainThread;
		public virtual RMethod RMEnsureRunningOnMainThread
		{
			get
			{
				if(r_MEnsureRunningOnMainThread == null)
				{
					r_MEnsureRunningOnMainThread = new(this, "EnsureRunningOnMainThread", 0);
					r_MEnsureRunningOnMainThread.SetBelong(this.instance);
				}
				return r_MEnsureRunningOnMainThread;
			}
		}

		/// <summary>
		/// Boolean IsNativeObjectAlive(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MIsNativeObjectAlive_Object;
		public static RMethod RMIsNativeObjectAlive_Object
		{
			get
			{
				if(r_MIsNativeObjectAlive_Object == null)
				{
					r_MIsNativeObjectAlive_Object = new(typeof(UnityEngine.Object), "IsNativeObjectAlive", 0, typeof(UnityEngine.Object));
					r_MIsNativeObjectAlive_Object.SetBelong(null);
				}
				return r_MIsNativeObjectAlive_Object;
			}
		}

		/// <summary>
		/// IntPtr GetCachedPtr()
		/// </summary>
		protected RMethod r_MGetCachedPtr;
		public virtual RMethod RMGetCachedPtr
		{
			get
			{
				if(r_MGetCachedPtr == null)
				{
					r_MGetCachedPtr = new(this, "GetCachedPtr", 0);
					r_MGetCachedPtr.SetBelong(this.instance);
				}
				return r_MGetCachedPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MInstantiate_Object_Vector3_Quaternion;
		public static RMethod RMInstantiate_Object_Vector3_Quaternion
		{
			get
			{
				if(r_MInstantiate_Object_Vector3_Quaternion == null)
				{
					r_MInstantiate_Object_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_MInstantiate_Object_Vector3_Quaternion.SetBelong(null);
				}
				return r_MInstantiate_Object_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_MInstantiate_Object_Vector3_Quaternion_Transform;
		public static RMethod RMInstantiate_Object_Vector3_Quaternion_Transform
		{
			get
			{
				if(r_MInstantiate_Object_Vector3_Quaternion_Transform == null)
				{
					r_MInstantiate_Object_Vector3_Quaternion_Transform = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Transform));
					r_MInstantiate_Object_Vector3_Quaternion_Transform.SetBelong(null);
				}
				return r_MInstantiate_Object_Vector3_Quaternion_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MInstantiate_Object;
		public static RMethod RMInstantiate_Object
		{
			get
			{
				if(r_MInstantiate_Object == null)
				{
					r_MInstantiate_Object = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object));
					r_MInstantiate_Object.SetBelong(null);
				}
				return r_MInstantiate_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_MInstantiate_Object_Transform;
		public static RMethod RMInstantiate_Object_Transform
		{
			get
			{
				if(r_MInstantiate_Object_Transform == null)
				{
					r_MInstantiate_Object_Transform = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform));
					r_MInstantiate_Object_Transform.SetBelong(null);
				}
				return r_MInstantiate_Object_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Object Instantiate(UnityEngine.Object, UnityEngine.Transform, Boolean)
		/// </summary>
		protected static RMethod r_MInstantiate_Object_Transform_Boolean;
		public static RMethod RMInstantiate_Object_Transform_Boolean
		{
			get
			{
				if(r_MInstantiate_Object_Transform_Boolean == null)
				{
					r_MInstantiate_Object_Transform_Boolean = new(typeof(UnityEngine.Object), "Instantiate", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_MInstantiate_Object_Transform_Boolean.SetBelong(null);
				}
				return r_MInstantiate_Object_Transform_Boolean;
			}
		}

		/// <summary>
		/// T Instantiate[T](T)
		/// </summary>
		protected static RMethod r_MInstantiate_GT_T;
		public static RMethod RMInstantiate_GT_T
		{
			get
			{
				if(r_MInstantiate_GT_T == null)
				{
					r_MInstantiate_GT_T = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0));
					r_MInstantiate_GT_T.SetBelong(null);
				}
				return r_MInstantiate_GT_T;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MInstantiate_GT_T_Vector3_Quaternion;
		public static RMethod RMInstantiate_GT_T_Vector3_Quaternion
		{
			get
			{
				if(r_MInstantiate_GT_T_Vector3_Quaternion == null)
				{
					r_MInstantiate_GT_T_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_MInstantiate_GT_T_Vector3_Quaternion.SetBelong(null);
				}
				return r_MInstantiate_GT_T_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_MInstantiate_GT_T_Vector3_Quaternion_Transform;
		public static RMethod RMInstantiate_GT_T_Vector3_Quaternion_Transform
		{
			get
			{
				if(r_MInstantiate_GT_T_Vector3_Quaternion_Transform == null)
				{
					r_MInstantiate_GT_T_Vector3_Quaternion_Transform = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Transform));
					r_MInstantiate_GT_T_Vector3_Quaternion_Transform.SetBelong(null);
				}
				return r_MInstantiate_GT_T_Vector3_Quaternion_Transform;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_MInstantiate_GT_T_Transform;
		public static RMethod RMInstantiate_GT_T_Transform
		{
			get
			{
				if(r_MInstantiate_GT_T_Transform == null)
				{
					r_MInstantiate_GT_T_Transform = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Transform));
					r_MInstantiate_GT_T_Transform.SetBelong(null);
				}
				return r_MInstantiate_GT_T_Transform;
			}
		}

		/// <summary>
		/// T Instantiate[T](T, UnityEngine.Transform, Boolean)
		/// </summary>
		protected static RMethod r_MInstantiate_GT_T_Transform_Boolean;
		public static RMethod RMInstantiate_GT_T_Transform_Boolean
		{
			get
			{
				if(r_MInstantiate_GT_T_Transform_Boolean == null)
				{
					r_MInstantiate_GT_T_Transform_Boolean = new(typeof(UnityEngine.Object), "Instantiate", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_MInstantiate_GT_T_Transform_Boolean.SetBelong(null);
				}
				return r_MInstantiate_GT_T_Transform_Boolean;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Object, Single)
		/// </summary>
		protected static RMethod r_MDestroy_Object_Single;
		public static RMethod RMDestroy_Object_Single
		{
			get
			{
				if(r_MDestroy_Object_Single == null)
				{
					r_MDestroy_Object_Single = new(typeof(UnityEngine.Object), "Destroy", 0, typeof(UnityEngine.Object), typeof(System.Single));
					r_MDestroy_Object_Single.SetBelong(null);
				}
				return r_MDestroy_Object_Single;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MDestroy_Object;
		public static RMethod RMDestroy_Object
		{
			get
			{
				if(r_MDestroy_Object == null)
				{
					r_MDestroy_Object = new(typeof(UnityEngine.Object), "Destroy", 0, typeof(UnityEngine.Object));
					r_MDestroy_Object.SetBelong(null);
				}
				return r_MDestroy_Object;
			}
		}

		/// <summary>
		/// Void DestroyImmediate(UnityEngine.Object, Boolean)
		/// </summary>
		protected static RMethod r_MDestroyImmediate_Object_Boolean;
		public static RMethod RMDestroyImmediate_Object_Boolean
		{
			get
			{
				if(r_MDestroyImmediate_Object_Boolean == null)
				{
					r_MDestroyImmediate_Object_Boolean = new(typeof(UnityEngine.Object), "DestroyImmediate", 0, typeof(UnityEngine.Object), typeof(System.Boolean));
					r_MDestroyImmediate_Object_Boolean.SetBelong(null);
				}
				return r_MDestroyImmediate_Object_Boolean;
			}
		}

		/// <summary>
		/// Void DestroyImmediate(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MDestroyImmediate_Object;
		public static RMethod RMDestroyImmediate_Object
		{
			get
			{
				if(r_MDestroyImmediate_Object == null)
				{
					r_MDestroyImmediate_Object = new(typeof(UnityEngine.Object), "DestroyImmediate", 0, typeof(UnityEngine.Object));
					r_MDestroyImmediate_Object.SetBelong(null);
				}
				return r_MDestroyImmediate_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfType(System.Type)
		/// </summary>
		protected static RMethod r_MFindObjectsOfType_Type;
		public static RMethod RMFindObjectsOfType_Type
		{
			get
			{
				if(r_MFindObjectsOfType_Type == null)
				{
					r_MFindObjectsOfType_Type = new(typeof(UnityEngine.Object), "FindObjectsOfType", 0, typeof(System.Type));
					r_MFindObjectsOfType_Type.SetBelong(null);
				}
				return r_MFindObjectsOfType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_MFindObjectsOfType_Type_Boolean;
		public static RMethod RMFindObjectsOfType_Type_Boolean
		{
			get
			{
				if(r_MFindObjectsOfType_Type_Boolean == null)
				{
					r_MFindObjectsOfType_Type_Boolean = new(typeof(UnityEngine.Object), "FindObjectsOfType", 0, typeof(System.Type), typeof(System.Boolean));
					r_MFindObjectsOfType_Type_Boolean.SetBelong(null);
				}
				return r_MFindObjectsOfType_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsByType(System.Type, UnityEngine.FindObjectsSortMode)
		/// </summary>
		protected static RMethod r_MFindObjectsByType_Type_FindObjectsSortMode;
		public static RMethod RMFindObjectsByType_Type_FindObjectsSortMode
		{
			get
			{
				if(r_MFindObjectsByType_Type_FindObjectsSortMode == null)
				{
					r_MFindObjectsByType_Type_FindObjectsSortMode = new(typeof(UnityEngine.Object), "FindObjectsByType", 0, typeof(System.Type), typeof(UnityEngine.FindObjectsSortMode));
					r_MFindObjectsByType_Type_FindObjectsSortMode.SetBelong(null);
				}
				return r_MFindObjectsByType_Type_FindObjectsSortMode;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsByType(System.Type, UnityEngine.FindObjectsInactive, UnityEngine.FindObjectsSortMode)
		/// </summary>
		protected static RMethod r_MFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode;
		public static RMethod RMFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode
		{
			get
			{
				if(r_MFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode == null)
				{
					r_MFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode = new(typeof(UnityEngine.Object), "FindObjectsByType", 0, typeof(System.Type), typeof(UnityEngine.FindObjectsInactive), typeof(UnityEngine.FindObjectsSortMode));
					r_MFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode.SetBelong(null);
				}
				return r_MFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode;
			}
		}

		/// <summary>
		/// Void DontDestroyOnLoad(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MDontDestroyOnLoad_Object;
		public static RMethod RMDontDestroyOnLoad_Object
		{
			get
			{
				if(r_MDontDestroyOnLoad_Object == null)
				{
					r_MDontDestroyOnLoad_Object = new(typeof(UnityEngine.Object), "DontDestroyOnLoad", 0, typeof(UnityEngine.Object));
					r_MDontDestroyOnLoad_Object.SetBelong(null);
				}
				return r_MDontDestroyOnLoad_Object;
			}
		}

		/// <summary>
		/// Void DestroyObject(UnityEngine.Object, Single)
		/// </summary>
		protected static RMethod r_MDestroyObject_Object_Single;
		public static RMethod RMDestroyObject_Object_Single
		{
			get
			{
				if(r_MDestroyObject_Object_Single == null)
				{
					r_MDestroyObject_Object_Single = new(typeof(UnityEngine.Object), "DestroyObject", 0, typeof(UnityEngine.Object), typeof(System.Single));
					r_MDestroyObject_Object_Single.SetBelong(null);
				}
				return r_MDestroyObject_Object_Single;
			}
		}

		/// <summary>
		/// Void DestroyObject(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MDestroyObject_Object;
		public static RMethod RMDestroyObject_Object
		{
			get
			{
				if(r_MDestroyObject_Object == null)
				{
					r_MDestroyObject_Object = new(typeof(UnityEngine.Object), "DestroyObject", 0, typeof(UnityEngine.Object));
					r_MDestroyObject_Object.SetBelong(null);
				}
				return r_MDestroyObject_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindSceneObjectsOfType(System.Type)
		/// </summary>
		protected static RMethod r_MFindSceneObjectsOfType_Type;
		public static RMethod RMFindSceneObjectsOfType_Type
		{
			get
			{
				if(r_MFindSceneObjectsOfType_Type == null)
				{
					r_MFindSceneObjectsOfType_Type = new(typeof(UnityEngine.Object), "FindSceneObjectsOfType", 0, typeof(System.Type));
					r_MFindSceneObjectsOfType_Type.SetBelong(null);
				}
				return r_MFindSceneObjectsOfType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type)
		/// </summary>
		protected static RMethod r_MFindObjectsOfTypeIncludingAssets_Type;
		public static RMethod RMFindObjectsOfTypeIncludingAssets_Type
		{
			get
			{
				if(r_MFindObjectsOfTypeIncludingAssets_Type == null)
				{
					r_MFindObjectsOfTypeIncludingAssets_Type = new(typeof(UnityEngine.Object), "FindObjectsOfTypeIncludingAssets", 0, typeof(System.Type));
					r_MFindObjectsOfTypeIncludingAssets_Type.SetBelong(null);
				}
				return r_MFindObjectsOfTypeIncludingAssets_Type;
			}
		}

		/// <summary>
		/// T[] FindObjectsOfType[T]()
		/// </summary>
		protected static RMethod r_MFindObjectsOfType_GT;
		public static RMethod RMFindObjectsOfType_GT
		{
			get
			{
				if(r_MFindObjectsOfType_GT == null)
				{
					r_MFindObjectsOfType_GT = new(typeof(UnityEngine.Object), "FindObjectsOfType", 1);
					r_MFindObjectsOfType_GT.SetBelong(null);
				}
				return r_MFindObjectsOfType_GT;
			}
		}

		/// <summary>
		/// T[] FindObjectsByType[T](UnityEngine.FindObjectsSortMode)
		/// </summary>
		protected static RMethod r_MFindObjectsByType_GT_FindObjectsSortMode;
		public static RMethod RMFindObjectsByType_GT_FindObjectsSortMode
		{
			get
			{
				if(r_MFindObjectsByType_GT_FindObjectsSortMode == null)
				{
					r_MFindObjectsByType_GT_FindObjectsSortMode = new(typeof(UnityEngine.Object), "FindObjectsByType", 1, typeof(UnityEngine.FindObjectsSortMode));
					r_MFindObjectsByType_GT_FindObjectsSortMode.SetBelong(null);
				}
				return r_MFindObjectsByType_GT_FindObjectsSortMode;
			}
		}

		/// <summary>
		/// T[] FindObjectsOfType[T](Boolean)
		/// </summary>
		protected static RMethod r_MFindObjectsOfType_GT_Boolean;
		public static RMethod RMFindObjectsOfType_GT_Boolean
		{
			get
			{
				if(r_MFindObjectsOfType_GT_Boolean == null)
				{
					r_MFindObjectsOfType_GT_Boolean = new(typeof(UnityEngine.Object), "FindObjectsOfType", 1, typeof(System.Boolean));
					r_MFindObjectsOfType_GT_Boolean.SetBelong(null);
				}
				return r_MFindObjectsOfType_GT_Boolean;
			}
		}

		/// <summary>
		/// T[] FindObjectsByType[T](UnityEngine.FindObjectsInactive, UnityEngine.FindObjectsSortMode)
		/// </summary>
		protected static RMethod r_MFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode;
		public static RMethod RMFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode
		{
			get
			{
				if(r_MFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode == null)
				{
					r_MFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode = new(typeof(UnityEngine.Object), "FindObjectsByType", 1, typeof(UnityEngine.FindObjectsInactive), typeof(UnityEngine.FindObjectsSortMode));
					r_MFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode.SetBelong(null);
				}
				return r_MFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode;
			}
		}

		/// <summary>
		/// T FindObjectOfType[T]()
		/// </summary>
		protected static RMethod r_MFindObjectOfType_GT;
		public static RMethod RMFindObjectOfType_GT
		{
			get
			{
				if(r_MFindObjectOfType_GT == null)
				{
					r_MFindObjectOfType_GT = new(typeof(UnityEngine.Object), "FindObjectOfType", 1);
					r_MFindObjectOfType_GT.SetBelong(null);
				}
				return r_MFindObjectOfType_GT;
			}
		}

		/// <summary>
		/// T FindObjectOfType[T](Boolean)
		/// </summary>
		protected static RMethod r_MFindObjectOfType_GT_Boolean;
		public static RMethod RMFindObjectOfType_GT_Boolean
		{
			get
			{
				if(r_MFindObjectOfType_GT_Boolean == null)
				{
					r_MFindObjectOfType_GT_Boolean = new(typeof(UnityEngine.Object), "FindObjectOfType", 1, typeof(System.Boolean));
					r_MFindObjectOfType_GT_Boolean.SetBelong(null);
				}
				return r_MFindObjectOfType_GT_Boolean;
			}
		}

		/// <summary>
		/// T FindFirstObjectByType[T]()
		/// </summary>
		protected static RMethod r_MFindFirstObjectByType_GT;
		public static RMethod RMFindFirstObjectByType_GT
		{
			get
			{
				if(r_MFindFirstObjectByType_GT == null)
				{
					r_MFindFirstObjectByType_GT = new(typeof(UnityEngine.Object), "FindFirstObjectByType", 1);
					r_MFindFirstObjectByType_GT.SetBelong(null);
				}
				return r_MFindFirstObjectByType_GT;
			}
		}

		/// <summary>
		/// T FindAnyObjectByType[T]()
		/// </summary>
		protected static RMethod r_MFindAnyObjectByType_GT;
		public static RMethod RMFindAnyObjectByType_GT
		{
			get
			{
				if(r_MFindAnyObjectByType_GT == null)
				{
					r_MFindAnyObjectByType_GT = new(typeof(UnityEngine.Object), "FindAnyObjectByType", 1);
					r_MFindAnyObjectByType_GT.SetBelong(null);
				}
				return r_MFindAnyObjectByType_GT;
			}
		}

		/// <summary>
		/// T FindFirstObjectByType[T](UnityEngine.FindObjectsInactive)
		/// </summary>
		protected static RMethod r_MFindFirstObjectByType_GT_FindObjectsInactive;
		public static RMethod RMFindFirstObjectByType_GT_FindObjectsInactive
		{
			get
			{
				if(r_MFindFirstObjectByType_GT_FindObjectsInactive == null)
				{
					r_MFindFirstObjectByType_GT_FindObjectsInactive = new(typeof(UnityEngine.Object), "FindFirstObjectByType", 1, typeof(UnityEngine.FindObjectsInactive));
					r_MFindFirstObjectByType_GT_FindObjectsInactive.SetBelong(null);
				}
				return r_MFindFirstObjectByType_GT_FindObjectsInactive;
			}
		}

		/// <summary>
		/// T FindAnyObjectByType[T](UnityEngine.FindObjectsInactive)
		/// </summary>
		protected static RMethod r_MFindAnyObjectByType_GT_FindObjectsInactive;
		public static RMethod RMFindAnyObjectByType_GT_FindObjectsInactive
		{
			get
			{
				if(r_MFindAnyObjectByType_GT_FindObjectsInactive == null)
				{
					r_MFindAnyObjectByType_GT_FindObjectsInactive = new(typeof(UnityEngine.Object), "FindAnyObjectByType", 1, typeof(UnityEngine.FindObjectsInactive));
					r_MFindAnyObjectByType_GT_FindObjectsInactive.SetBelong(null);
				}
				return r_MFindAnyObjectByType_GT_FindObjectsInactive;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] FindObjectsOfTypeAll(System.Type)
		/// </summary>
		protected static RMethod r_MFindObjectsOfTypeAll_Type;
		public static RMethod RMFindObjectsOfTypeAll_Type
		{
			get
			{
				if(r_MFindObjectsOfTypeAll_Type == null)
				{
					r_MFindObjectsOfTypeAll_Type = new(typeof(UnityEngine.Object), "FindObjectsOfTypeAll", 0, typeof(System.Type));
					r_MFindObjectsOfTypeAll_Type.SetBelong(null);
				}
				return r_MFindObjectsOfTypeAll_Type;
			}
		}

		/// <summary>
		/// Void CheckNullArgument(System.Object, System.String)
		/// </summary>
		protected static RMethod r_MCheckNullArgument_Object_String;
		public static RMethod RMCheckNullArgument_Object_String
		{
			get
			{
				if(r_MCheckNullArgument_Object_String == null)
				{
					r_MCheckNullArgument_Object_String = new(typeof(UnityEngine.Object), "CheckNullArgument", 0, typeof(System.Object), typeof(System.String));
					r_MCheckNullArgument_Object_String.SetBelong(null);
				}
				return r_MCheckNullArgument_Object_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindObjectOfType(System.Type)
		/// </summary>
		protected static RMethod r_MFindObjectOfType_Type;
		public static RMethod RMFindObjectOfType_Type
		{
			get
			{
				if(r_MFindObjectOfType_Type == null)
				{
					r_MFindObjectOfType_Type = new(typeof(UnityEngine.Object), "FindObjectOfType", 0, typeof(System.Type));
					r_MFindObjectOfType_Type.SetBelong(null);
				}
				return r_MFindObjectOfType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindFirstObjectByType(System.Type)
		/// </summary>
		protected static RMethod r_MFindFirstObjectByType_Type;
		public static RMethod RMFindFirstObjectByType_Type
		{
			get
			{
				if(r_MFindFirstObjectByType_Type == null)
				{
					r_MFindFirstObjectByType_Type = new(typeof(UnityEngine.Object), "FindFirstObjectByType", 0, typeof(System.Type));
					r_MFindFirstObjectByType_Type.SetBelong(null);
				}
				return r_MFindFirstObjectByType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindAnyObjectByType(System.Type)
		/// </summary>
		protected static RMethod r_MFindAnyObjectByType_Type;
		public static RMethod RMFindAnyObjectByType_Type
		{
			get
			{
				if(r_MFindAnyObjectByType_Type == null)
				{
					r_MFindAnyObjectByType_Type = new(typeof(UnityEngine.Object), "FindAnyObjectByType", 0, typeof(System.Type));
					r_MFindAnyObjectByType_Type.SetBelong(null);
				}
				return r_MFindAnyObjectByType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindObjectOfType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_MFindObjectOfType_Type_Boolean;
		public static RMethod RMFindObjectOfType_Type_Boolean
		{
			get
			{
				if(r_MFindObjectOfType_Type_Boolean == null)
				{
					r_MFindObjectOfType_Type_Boolean = new(typeof(UnityEngine.Object), "FindObjectOfType", 0, typeof(System.Type), typeof(System.Boolean));
					r_MFindObjectOfType_Type_Boolean.SetBelong(null);
				}
				return r_MFindObjectOfType_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindFirstObjectByType(System.Type, UnityEngine.FindObjectsInactive)
		/// </summary>
		protected static RMethod r_MFindFirstObjectByType_Type_FindObjectsInactive;
		public static RMethod RMFindFirstObjectByType_Type_FindObjectsInactive
		{
			get
			{
				if(r_MFindFirstObjectByType_Type_FindObjectsInactive == null)
				{
					r_MFindFirstObjectByType_Type_FindObjectsInactive = new(typeof(UnityEngine.Object), "FindFirstObjectByType", 0, typeof(System.Type), typeof(UnityEngine.FindObjectsInactive));
					r_MFindFirstObjectByType_Type_FindObjectsInactive.SetBelong(null);
				}
				return r_MFindFirstObjectByType_Type_FindObjectsInactive;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindAnyObjectByType(System.Type, UnityEngine.FindObjectsInactive)
		/// </summary>
		protected static RMethod r_MFindAnyObjectByType_Type_FindObjectsInactive;
		public static RMethod RMFindAnyObjectByType_Type_FindObjectsInactive
		{
			get
			{
				if(r_MFindAnyObjectByType_Type_FindObjectsInactive == null)
				{
					r_MFindAnyObjectByType_Type_FindObjectsInactive = new(typeof(UnityEngine.Object), "FindAnyObjectByType", 0, typeof(System.Type), typeof(UnityEngine.FindObjectsInactive));
					r_MFindAnyObjectByType_Type_FindObjectsInactive.SetBelong(null);
				}
				return r_MFindAnyObjectByType_Type_FindObjectsInactive;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Object, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_Mop_Equality_Object_Object;
		public static RMethod RMop_Equality_Object_Object
		{
			get
			{
				if(r_Mop_Equality_Object_Object == null)
				{
					r_Mop_Equality_Object_Object = new(typeof(UnityEngine.Object), "op_Equality", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object));
					r_Mop_Equality_Object_Object.SetBelong(null);
				}
				return r_Mop_Equality_Object_Object;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Object, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Object_Object;
		public static RMethod RMop_Inequality_Object_Object
		{
			get
			{
				if(r_Mop_Inequality_Object_Object == null)
				{
					r_Mop_Inequality_Object_Object = new(typeof(UnityEngine.Object), "op_Inequality", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object));
					r_Mop_Inequality_Object_Object.SetBelong(null);
				}
				return r_Mop_Inequality_Object_Object;
			}
		}

		/// <summary>
		/// Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
		/// </summary>
		protected static RMethod r_MGetOffsetOfInstanceIDInCPlusPlusObject;
		public static RMethod RMGetOffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				if(r_MGetOffsetOfInstanceIDInCPlusPlusObject == null)
				{
					r_MGetOffsetOfInstanceIDInCPlusPlusObject = new(typeof(UnityEngine.Object), "GetOffsetOfInstanceIDInCPlusPlusObject", 0);
					r_MGetOffsetOfInstanceIDInCPlusPlusObject.SetBelong(null);
				}
				return r_MGetOffsetOfInstanceIDInCPlusPlusObject;
			}
		}

		/// <summary>
		/// Boolean CurrentThreadIsMainThread()
		/// </summary>
		protected static RMethod r_MCurrentThreadIsMainThread;
		public static RMethod RMCurrentThreadIsMainThread
		{
			get
			{
				if(r_MCurrentThreadIsMainThread == null)
				{
					r_MCurrentThreadIsMainThread = new(typeof(UnityEngine.Object), "CurrentThreadIsMainThread", 0);
					r_MCurrentThreadIsMainThread.SetBelong(null);
				}
				return r_MCurrentThreadIsMainThread;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_CloneSingle(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MInternal_CloneSingle_Object;
		public static RMethod RMInternal_CloneSingle_Object
		{
			get
			{
				if(r_MInternal_CloneSingle_Object == null)
				{
					r_MInternal_CloneSingle_Object = new(typeof(UnityEngine.Object), "Internal_CloneSingle", 0, typeof(UnityEngine.Object));
					r_MInternal_CloneSingle_Object.SetBelong(null);
				}
				return r_MInternal_CloneSingle_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object, UnityEngine.Transform, Boolean)
		/// </summary>
		protected static RMethod r_MInternal_CloneSingleWithParent_Object_Transform_Boolean;
		public static RMethod RMInternal_CloneSingleWithParent_Object_Transform_Boolean
		{
			get
			{
				if(r_MInternal_CloneSingleWithParent_Object_Transform_Boolean == null)
				{
					r_MInternal_CloneSingleWithParent_Object_Transform_Boolean = new(typeof(UnityEngine.Object), "Internal_CloneSingleWithParent", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_MInternal_CloneSingleWithParent_Object_Transform_Boolean.SetBelong(null);
				}
				return r_MInternal_CloneSingleWithParent_Object_Transform_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MInternal_InstantiateSingle_Object_Vector3_Quaternion;
		public static RMethod RMInternal_InstantiateSingle_Object_Vector3_Quaternion
		{
			get
			{
				if(r_MInternal_InstantiateSingle_Object_Vector3_Quaternion == null)
				{
					r_MInternal_InstantiateSingle_Object_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingle", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_MInternal_InstantiateSingle_Object_Vector3_Quaternion.SetBelong(null);
				}
				return r_MInternal_InstantiateSingle_Object_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object, UnityEngine.Transform, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected static RMethod r_MInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion;
		public static RMethod RMInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion
		{
			get
			{
				if(r_MInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion == null)
				{
					r_MInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingleWithParent", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_MInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion.SetBelong(null);
				}
				return r_MInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// System.String ToString(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MToString_Object;
		public static RMethod RMToString_Object
		{
			get
			{
				if(r_MToString_Object == null)
				{
					r_MToString_Object = new(typeof(UnityEngine.Object), "ToString", 0, typeof(UnityEngine.Object));
					r_MToString_Object.SetBelong(null);
				}
				return r_MToString_Object;
			}
		}

		/// <summary>
		/// System.String GetName(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MGetName_Object;
		public static RMethod RMGetName_Object
		{
			get
			{
				if(r_MGetName_Object == null)
				{
					r_MGetName_Object = new(typeof(UnityEngine.Object), "GetName", 0, typeof(UnityEngine.Object));
					r_MGetName_Object.SetBelong(null);
				}
				return r_MGetName_Object;
			}
		}

		/// <summary>
		/// Boolean IsPersistent(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MIsPersistent_Object;
		public static RMethod RMIsPersistent_Object
		{
			get
			{
				if(r_MIsPersistent_Object == null)
				{
					r_MIsPersistent_Object = new(typeof(UnityEngine.Object), "IsPersistent", 0, typeof(UnityEngine.Object));
					r_MIsPersistent_Object.SetBelong(null);
				}
				return r_MIsPersistent_Object;
			}
		}

		/// <summary>
		/// Void SetName(UnityEngine.Object, System.String)
		/// </summary>
		protected static RMethod r_MSetName_Object_String;
		public static RMethod RMSetName_Object_String
		{
			get
			{
				if(r_MSetName_Object_String == null)
				{
					r_MSetName_Object_String = new(typeof(UnityEngine.Object), "SetName", 0, typeof(UnityEngine.Object), typeof(System.String));
					r_MSetName_Object_String.SetBelong(null);
				}
				return r_MSetName_Object_String;
			}
		}

		/// <summary>
		/// Boolean DoesObjectWithInstanceIDExist(Int32)
		/// </summary>
		protected static RMethod r_MDoesObjectWithInstanceIDExist_Int32;
		public static RMethod RMDoesObjectWithInstanceIDExist_Int32
		{
			get
			{
				if(r_MDoesObjectWithInstanceIDExist_Int32 == null)
				{
					r_MDoesObjectWithInstanceIDExist_Int32 = new(typeof(UnityEngine.Object), "DoesObjectWithInstanceIDExist", 0, typeof(System.Int32));
					r_MDoesObjectWithInstanceIDExist_Int32.SetBelong(null);
				}
				return r_MDoesObjectWithInstanceIDExist_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object FindObjectFromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_MFindObjectFromInstanceID_Int32;
		public static RMethod RMFindObjectFromInstanceID_Int32
		{
			get
			{
				if(r_MFindObjectFromInstanceID_Int32 == null)
				{
					r_MFindObjectFromInstanceID_Int32 = new(typeof(UnityEngine.Object), "FindObjectFromInstanceID", 0, typeof(System.Int32));
					r_MFindObjectFromInstanceID_Int32.SetBelong(null);
				}
				return r_MFindObjectFromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object ForceLoadFromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_MForceLoadFromInstanceID_Int32;
		public static RMethod RMForceLoadFromInstanceID_Int32
		{
			get
			{
				if(r_MForceLoadFromInstanceID_Int32 == null)
				{
					r_MForceLoadFromInstanceID_Int32 = new(typeof(UnityEngine.Object), "ForceLoadFromInstanceID", 0, typeof(System.Int32));
					r_MForceLoadFromInstanceID_Int32.SetBelong(null);
				}
				return r_MForceLoadFromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object CreateMissingReferenceObject(Int32)
		/// </summary>
		protected static RMethod r_MCreateMissingReferenceObject_Int32;
		public static RMethod RMCreateMissingReferenceObject_Int32
		{
			get
			{
				if(r_MCreateMissingReferenceObject_Int32 == null)
				{
					r_MCreateMissingReferenceObject_Int32 = new(typeof(UnityEngine.Object), "CreateMissingReferenceObject", 0, typeof(System.Int32));
					r_MCreateMissingReferenceObject_Int32.SetBelong(null);
				}
				return r_MCreateMissingReferenceObject_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion;
		public static RMethod RMInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_MInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion == null)
				{
					r_MInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingle_Injected", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_MInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion.SetBelong(null);
				}
				return r_MInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object, UnityEngine.Transform, UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected static RMethod r_MInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion;
		public static RMethod RMInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_MInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion == null)
				{
					r_MInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion = new(typeof(UnityEngine.Object), "Internal_InstantiateSingleWithParent_Injected", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_MInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion.SetBelong(null);
				}
				return r_MInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion;
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Implicit(UnityEngine.Object @exists)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exists};
            var ___result = RMop_Implicit_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CompareBaseObjects(UnityEngine.Object @lhs, UnityEngine.Object @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMCompareBaseObjects_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EnsureRunningOnMainThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureRunningOnMainThread.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsNativeObjectAlive(UnityEngine.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMIsNativeObjectAlive_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IntPtr GetCachedPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCachedPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object @original, UnityEngine.Vector3 @position, UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @position, @rotation};
            var ___result = RMInstantiate_Object_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object @original, UnityEngine.Vector3 @position, UnityEngine.Quaternion @rotation, UnityEngine.Transform @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @position, @rotation, @parent};
            var ___result = RMInstantiate_Object_Vector3_Quaternion_Transform.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object @original)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original};
            var ___result = RMInstantiate_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object @original, UnityEngine.Transform @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @parent};
            var ___result = RMInstantiate_Object_Transform.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Instantiate(UnityEngine.Object @original, UnityEngine.Transform @parent, System.Boolean @instantiateInWorldSpace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original, @parent, @instantiateInWorldSpace};
            var ___result = RMInstantiate_Object_Transform_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static T Instantiate<T>(T @original) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original};
            var ___result = RMInstantiate_GT_T.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T @original, UnityEngine.Vector3 @position, UnityEngine.Quaternion @rotation) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @position, @rotation};
            var ___result = RMInstantiate_GT_T_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T @original, UnityEngine.Vector3 @position, UnityEngine.Quaternion @rotation, UnityEngine.Transform @parent) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @position, @rotation, @parent};
            var ___result = RMInstantiate_GT_T_Vector3_Quaternion_Transform.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T @original, UnityEngine.Transform @parent) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @parent};
            var ___result = RMInstantiate_GT_T_Transform.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T Instantiate<T>(T @original, UnityEngine.Transform @parent, System.Boolean @worldPositionStays) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@original, @parent, @worldPositionStays};
            var ___result = RMInstantiate_GT_T_Transform_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static void Destroy(UnityEngine.Object @obj, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @t};
            var ___result = RMDestroy_Object_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void Destroy(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMDestroy_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyImmediate(UnityEngine.Object @obj, System.Boolean @allowDestroyingAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @allowDestroyingAssets};
            var ___result = RMDestroyImmediate_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyImmediate(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMDestroyImmediate_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Object[] FindObjectsOfType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindObjectsOfType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static UnityEngine.Object[] FindObjectsOfType(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RMFindObjectsOfType_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static UnityEngine.Object[] FindObjectsByType(System.Type @type, UnityEngine.FindObjectsSortMode @sortMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @sortMode};
            var ___result = RMFindObjectsByType_Type_FindObjectsSortMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static UnityEngine.Object[] FindObjectsByType(System.Type @type, UnityEngine.FindObjectsInactive @findObjectsInactive, UnityEngine.FindObjectsSortMode @sortMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @findObjectsInactive, @sortMode};
            var ___result = RMFindObjectsByType_Type_FindObjectsInactive_FindObjectsSortMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static void DontDestroyOnLoad(UnityEngine.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMDontDestroyOnLoad_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyObject(UnityEngine.Object @obj, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @t};
            var ___result = RMDestroyObject_Object_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void DestroyObject(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMDestroyObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Object[] FindSceneObjectsOfType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindSceneObjectsOfType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindObjectsOfTypeIncludingAssets_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMFindObjectsOfType_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static T[] FindObjectsByType<T>(UnityEngine.FindObjectsSortMode @sortMode) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@sortMode};
            var ___result = RMFindObjectsByType_GT_FindObjectsSortMode.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static T[] FindObjectsOfType<T>(System.Boolean @includeInactive) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMFindObjectsOfType_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static T[] FindObjectsByType<T>(UnityEngine.FindObjectsInactive @findObjectsInactive, UnityEngine.FindObjectsSortMode @sortMode) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@findObjectsInactive, @sortMode};
            var ___result = RMFindObjectsByType_GT_FindObjectsInactive_FindObjectsSortMode.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public static T FindObjectOfType<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMFindObjectOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T FindObjectOfType<T>(System.Boolean @includeInactive) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMFindObjectOfType_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T FindFirstObjectByType<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMFindFirstObjectByType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T FindAnyObjectByType<T>() where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMFindAnyObjectByType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T FindFirstObjectByType<T>(UnityEngine.FindObjectsInactive @findObjectsInactive) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@findObjectsInactive};
            var ___result = RMFindFirstObjectByType_GT_FindObjectsInactive.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static T FindAnyObjectByType<T>(UnityEngine.FindObjectsInactive @findObjectsInactive) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@findObjectsInactive};
            var ___result = RMFindAnyObjectByType_GT_FindObjectsInactive.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static UnityEngine.Object[] FindObjectsOfTypeAll(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindObjectsOfTypeAll_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public static void CheckNullArgument(System.Object @arg, System.String @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @message};
            var ___result = RMCheckNullArgument_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Object FindObjectOfType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindObjectOfType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object FindFirstObjectByType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindFirstObjectByType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object FindAnyObjectByType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMFindAnyObjectByType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object FindObjectOfType(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RMFindObjectOfType_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object FindFirstObjectByType(System.Type @type, UnityEngine.FindObjectsInactive @findObjectsInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @findObjectsInactive};
            var ___result = RMFindFirstObjectByType_Type_FindObjectsInactive.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object FindAnyObjectByType(System.Type @type, UnityEngine.FindObjectsInactive @findObjectsInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @findObjectsInactive};
            var ___result = RMFindAnyObjectByType_Type_FindObjectsInactive.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Object @x, UnityEngine.Object @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMop_Equality_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Object @x, UnityEngine.Object @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMop_Inequality_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOffsetOfInstanceIDInCPlusPlusObject.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean CurrentThreadIsMainThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCurrentThreadIsMainThread.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Object Internal_CloneSingle(UnityEngine.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMInternal_CloneSingle_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object @data, UnityEngine.Transform @parent, System.Boolean @worldPositionStays)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @parent, @worldPositionStays};
            var ___result = RMInternal_CloneSingleWithParent_Object_Transform_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object @data, UnityEngine.Vector3 @pos, UnityEngine.Quaternion @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rot};
            var ___result = RMInternal_InstantiateSingle_Object_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object @data, UnityEngine.Transform @parent, UnityEngine.Vector3 @pos, UnityEngine.Quaternion @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @parent, @pos, @rot};
            var ___result = RMInternal_InstantiateSingleWithParent_Object_Transform_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static System.String ToString(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMToString_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetName(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetName_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean IsPersistent(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMIsPersistent_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetName(UnityEngine.Object @obj, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @name};
            var ___result = RMSetName_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean DoesObjectWithInstanceIDExist(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMDoesObjectWithInstanceIDExist_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Object FindObjectFromInstanceID(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMFindObjectFromInstanceID_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object ForceLoadFromInstanceID(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMForceLoadFromInstanceID_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object CreateMissingReferenceObject(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMCreateMissingReferenceObject_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object @data, ref UnityEngine.Vector3 @pos, ref UnityEngine.Quaternion @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rot};
            var ___result = RMInternal_InstantiateSingle_Injected_Object_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@pos = (UnityEngine.Vector3)___parameters[1];
			@rot = (UnityEngine.Quaternion)___parameters[2];

            return (UnityEngine.Object)___result;
        }


        public static UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object @data, UnityEngine.Transform @parent, ref UnityEngine.Vector3 @pos, ref UnityEngine.Quaternion @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @parent, @pos, @rot};
            var ___result = RMInternal_InstantiateSingleWithParent_Injected_Object_Transform_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@pos = (UnityEngine.Vector3)___parameters[2];
			@rot = (UnityEngine.Quaternion)___parameters[3];

            return (UnityEngine.Object)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
