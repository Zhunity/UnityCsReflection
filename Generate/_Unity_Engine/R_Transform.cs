
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Transform
	/// </summary>
    public partial class RTransform : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PlocalPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPlocalPosition
		{
			get
			{
				if(r_PlocalPosition == null)
				{
					r_PlocalPosition = new(this, "localPosition", -1);
				}
				return r_PlocalPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 eulerAngles
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PeulerAngles;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPeulerAngles
		{
			get
			{
				if(r_PeulerAngles == null)
				{
					r_PeulerAngles = new(this, "eulerAngles", -1);
				}
				return r_PeulerAngles;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localEulerAngles
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PlocalEulerAngles;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPlocalEulerAngles
		{
			get
			{
				if(r_PlocalEulerAngles == null)
				{
					r_PlocalEulerAngles = new(this, "localEulerAngles", -1);
				}
				return r_PlocalEulerAngles;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 right
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pright;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 up
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pup;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPup
		{
			get
			{
				if(r_Pup == null)
				{
					r_Pup = new(this, "up", -1);
				}
				return r_Pup;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 forward
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pforward;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPforward
		{
			get
			{
				if(r_Pforward == null)
				{
					r_Pforward = new(this, "forward", -1);
				}
				return r_Pforward;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rotation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_Protation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RProtation
		{
			get
			{
				if(r_Protation == null)
				{
					r_Protation = new(this, "rotation", -1);
				}
				return r_Protation;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion localRotation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_PlocalRotation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RPlocalRotation
		{
			get
			{
				if(r_PlocalRotation == null)
				{
					r_PlocalRotation = new(this, "localRotation", -1);
				}
				return r_PlocalRotation;
			}
		}

		/// <summary>
		/// UnityEngine.RotationOrder rotationOrder
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder r_ProtationOrder;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder RProtationOrder
		{
			get
			{
				if(r_ProtationOrder == null)
				{
					r_ProtationOrder = new(this, "rotationOrder", -1);
				}
				return r_ProtationOrder;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PlocalScale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPlocalScale
		{
			get
			{
				if(r_PlocalScale == null)
				{
					r_PlocalScale = new(this, "localScale", -1);
				}
				return r_PlocalScale;
			}
		}

		/// <summary>
		/// UnityEngine.Transform parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEngine.Transform parentInternal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_PparentInternal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPparentInternal
		{
			get
			{
				if(r_PparentInternal == null)
				{
					r_PparentInternal = new(this, "parentInternal", -1);
				}
				return r_PparentInternal;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldToLocalMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldToLocalMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldToLocalMatrix
		{
			get
			{
				if(r_PworldToLocalMatrix == null)
				{
					r_PworldToLocalMatrix = new(this, "worldToLocalMatrix", -1);
				}
				return r_PworldToLocalMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 localToWorldMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PlocalToWorldMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPlocalToWorldMatrix
		{
			get
			{
				if(r_PlocalToWorldMatrix == null)
				{
					r_PlocalToWorldMatrix = new(this, "localToWorldMatrix", -1);
				}
				return r_PlocalToWorldMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Transform root
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_Proot;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RProot
		{
			get
			{
				if(r_Proot == null)
				{
					r_Proot = new(this, "root", -1);
				}
				return r_Proot;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PchildCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPchildCount
		{
			get
			{
				if(r_PchildCount == null)
				{
					r_PchildCount = new(this, "childCount", -1);
				}
				return r_PchildCount;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 lossyScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PlossyScale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPlossyScale
		{
			get
			{
				if(r_PlossyScale == null)
				{
					r_PlossyScale = new(this, "lossyScale", -1);
				}
				return r_PlossyScale;
			}
		}

		/// <summary>
		/// Boolean hasChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasChanged
		{
			get
			{
				if(r_PhasChanged == null)
				{
					r_PhasChanged = new(this, "hasChanged", -1);
				}
				return r_PhasChanged;
			}
		}

		/// <summary>
		/// Int32 hierarchyCapacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PhierarchyCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPhierarchyCapacity
		{
			get
			{
				if(r_PhierarchyCapacity == null)
				{
					r_PhierarchyCapacity = new(this, "hierarchyCapacity", -1);
				}
				return r_PhierarchyCapacity;
			}
		}

		/// <summary>
		/// Int32 hierarchyCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PhierarchyCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPhierarchyCount
		{
			get
			{
				if(r_PhierarchyCount == null)
				{
					r_PhierarchyCount = new(this, "hierarchyCount", -1);
				}
				return r_PhierarchyCount;
			}
		}

		/// <summary>
		/// Boolean constrainProportionsScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PconstrainProportionsScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPconstrainProportionsScale
		{
			get
			{
				if(r_PconstrainProportionsScale == null)
				{
					r_PconstrainProportionsScale = new(this, "constrainProportionsScale", -1);
				}
				return r_PconstrainProportionsScale;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_Ptransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGameObject r_PgameObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGameObject RPgameObject
		{
			get
			{
				if(r_PgameObject == null)
				{
					r_PgameObject = new(this, "gameObject", -1);
				}
				return r_PgameObject;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtag
		{
			get
			{
				if(r_Ptag == null)
				{
					r_Ptag = new(this, "tag", -1);
				}
				return r_Ptag;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Prigidbody;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPrigidbody
		{
			get
			{
				if(r_Prigidbody == null)
				{
					r_Prigidbody = new(this, "rigidbody", -1);
				}
				return r_Prigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Prigidbody2D;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPrigidbody2D
		{
			get
			{
				if(r_Prigidbody2D == null)
				{
					r_Prigidbody2D = new(this, "rigidbody2D", -1);
				}
				return r_Prigidbody2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component camera
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Pcamera;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPcamera
		{
			get
			{
				if(r_Pcamera == null)
				{
					r_Pcamera = new(this, "camera", -1);
				}
				return r_Pcamera;
			}
		}

		/// <summary>
		/// UnityEngine.Component light
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Plight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPlight
		{
			get
			{
				if(r_Plight == null)
				{
					r_Plight = new(this, "light", -1);
				}
				return r_Plight;
			}
		}

		/// <summary>
		/// UnityEngine.Component animation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Panimation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPanimation
		{
			get
			{
				if(r_Panimation == null)
				{
					r_Panimation = new(this, "animation", -1);
				}
				return r_Panimation;
			}
		}

		/// <summary>
		/// UnityEngine.Component constantForce
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PconstantForce;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPconstantForce
		{
			get
			{
				if(r_PconstantForce == null)
				{
					r_PconstantForce = new(this, "constantForce", -1);
				}
				return r_PconstantForce;
			}
		}

		/// <summary>
		/// UnityEngine.Component renderer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Prenderer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPrenderer
		{
			get
			{
				if(r_Prenderer == null)
				{
					r_Prenderer = new(this, "renderer", -1);
				}
				return r_Prenderer;
			}
		}

		/// <summary>
		/// UnityEngine.Component audio
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Paudio;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPaudio
		{
			get
			{
				if(r_Paudio == null)
				{
					r_Paudio = new(this, "audio", -1);
				}
				return r_Paudio;
			}
		}

		/// <summary>
		/// UnityEngine.Component networkView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PnetworkView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPnetworkView
		{
			get
			{
				if(r_PnetworkView == null)
				{
					r_PnetworkView = new(this, "networkView", -1);
				}
				return r_PnetworkView;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Pcollider;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPcollider
		{
			get
			{
				if(r_Pcollider == null)
				{
					r_Pcollider = new(this, "collider", -1);
				}
				return r_Pcollider;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Pcollider2D;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPcollider2D
		{
			get
			{
				if(r_Pcollider2D == null)
				{
					r_Pcollider2D = new(this, "collider2D", -1);
				}
				return r_Pcollider2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component hingeJoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PhingeJoint;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPhingeJoint
		{
			get
			{
				if(r_PhingeJoint == null)
				{
					r_PhingeJoint = new(this, "hingeJoint", -1);
				}
				return r_PhingeJoint;
			}
		}

		/// <summary>
		/// UnityEngine.Component particleSystem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PparticleSystem;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPparticleSystem
		{
			get
			{
				if(r_PparticleSystem == null)
				{
					r_PparticleSystem = new(this, "particleSystem", -1);
				}
				return r_PparticleSystem;
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
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_MGetLocalEulerAngles_RotationOrder;
		public virtual RMethod RMGetLocalEulerAngles_RotationOrder
		{
			get
			{
				if(r_MGetLocalEulerAngles_RotationOrder == null)
				{
					r_MGetLocalEulerAngles_RotationOrder = new(this, "GetLocalEulerAngles", 0,  ReflectionUtils.GetType("UnityEngine.RotationOrder"));
				}
				return r_MGetLocalEulerAngles_RotationOrder;
			}
		}

		/// <summary>
		/// Void SetLocalEulerAngles(UnityEngine.Vector3, UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_MSetLocalEulerAngles_Vector3_RotationOrder;
		public virtual RMethod RMSetLocalEulerAngles_Vector3_RotationOrder
		{
			get
			{
				if(r_MSetLocalEulerAngles_Vector3_RotationOrder == null)
				{
					r_MSetLocalEulerAngles_Vector3_RotationOrder = new(this, "SetLocalEulerAngles", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.RotationOrder"));
				}
				return r_MSetLocalEulerAngles_Vector3_RotationOrder;
			}
		}

		/// <summary>
		/// Void SetLocalEulerHint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetLocalEulerHint_Vector3;
		public virtual RMethod RMSetLocalEulerHint_Vector3
		{
			get
			{
				if(r_MSetLocalEulerHint_Vector3 == null)
				{
					r_MSetLocalEulerHint_Vector3 = new(this, "SetLocalEulerHint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MSetLocalEulerHint_Vector3;
			}
		}

		/// <summary>
		/// Int32 GetRotationOrderInternal()
		/// </summary>
		protected RMethod r_MGetRotationOrderInternal;
		public virtual RMethod RMGetRotationOrderInternal
		{
			get
			{
				if(r_MGetRotationOrderInternal == null)
				{
					r_MGetRotationOrderInternal = new(this, "GetRotationOrderInternal", 0);
				}
				return r_MGetRotationOrderInternal;
			}
		}

		/// <summary>
		/// Void SetRotationOrderInternal(UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_MSetRotationOrderInternal_RotationOrder;
		public virtual RMethod RMSetRotationOrderInternal_RotationOrder
		{
			get
			{
				if(r_MSetRotationOrderInternal_RotationOrder == null)
				{
					r_MSetRotationOrderInternal_RotationOrder = new(this, "SetRotationOrderInternal", 0,  ReflectionUtils.GetType("UnityEngine.RotationOrder"));
				}
				return r_MSetRotationOrderInternal_RotationOrder;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetParent()
		/// </summary>
		protected RMethod r_MGetParent;
		public virtual RMethod RMGetParent
		{
			get
			{
				if(r_MGetParent == null)
				{
					r_MGetParent = new(this, "GetParent", 0);
				}
				return r_MGetParent;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_MSetParent_Transform;
		public virtual RMethod RMSetParent_Transform
		{
			get
			{
				if(r_MSetParent_Transform == null)
				{
					r_MSetParent_Transform = new(this, "SetParent", 0, typeof(UnityEngine.Transform));
				}
				return r_MSetParent_Transform;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.Transform, Boolean)
		/// </summary>
		protected RMethod r_MSetParent_Transform_Boolean;
		public virtual RMethod RMSetParent_Transform_Boolean
		{
			get
			{
				if(r_MSetParent_Transform_Boolean == null)
				{
					r_MSetParent_Transform_Boolean = new(this, "SetParent", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
				}
				return r_MSetParent_Transform_Boolean;
			}
		}

		/// <summary>
		/// Void SetPositionAndRotation(UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_MSetPositionAndRotation_Vector3_Quaternion;
		public virtual RMethod RMSetPositionAndRotation_Vector3_Quaternion
		{
			get
			{
				if(r_MSetPositionAndRotation_Vector3_Quaternion == null)
				{
					r_MSetPositionAndRotation_Vector3_Quaternion = new(this, "SetPositionAndRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
				}
				return r_MSetPositionAndRotation_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// Void SetLocalPositionAndRotation(UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_MSetLocalPositionAndRotation_Vector3_Quaternion;
		public virtual RMethod RMSetLocalPositionAndRotation_Vector3_Quaternion
		{
			get
			{
				if(r_MSetLocalPositionAndRotation_Vector3_Quaternion == null)
				{
					r_MSetLocalPositionAndRotation_Vector3_Quaternion = new(this, "SetLocalPositionAndRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
				}
				return r_MSetLocalPositionAndRotation_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// Void GetPositionAndRotation(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_MGetPositionAndRotation_Out_Vector3_Out_Quaternion;
		public virtual RMethod RMGetPositionAndRotation_Out_Vector3_Out_Quaternion
		{
			get
			{
				if(r_MGetPositionAndRotation_Out_Vector3_Out_Quaternion == null)
				{
					r_MGetPositionAndRotation_Out_Vector3_Out_Quaternion = new(this, "GetPositionAndRotation", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MGetPositionAndRotation_Out_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void GetLocalPositionAndRotation(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_MGetLocalPositionAndRotation_Out_Vector3_Out_Quaternion;
		public virtual RMethod RMGetLocalPositionAndRotation_Out_Vector3_Out_Quaternion
		{
			get
			{
				if(r_MGetLocalPositionAndRotation_Out_Vector3_Out_Quaternion == null)
				{
					r_MGetLocalPositionAndRotation_Out_Vector3_Out_Quaternion = new(this, "GetLocalPositionAndRotation", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MGetLocalPositionAndRotation_Out_Vector3_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3, UnityEngine.Space)
		/// </summary>
		protected RMethod r_MTranslate_Vector3_Space;
		public virtual RMethod RMTranslate_Vector3_Space
		{
			get
			{
				if(r_MTranslate_Vector3_Space == null)
				{
					r_MTranslate_Vector3_Space = new(this, "Translate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Space));
				}
				return r_MTranslate_Vector3_Space;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MTranslate_Vector3;
		public virtual RMethod RMTranslate_Vector3
		{
			get
			{
				if(r_MTranslate_Vector3 == null)
				{
					r_MTranslate_Vector3 = new(this, "Translate", 0, typeof(UnityEngine.Vector3));
				}
				return r_MTranslate_Vector3;
			}
		}

		/// <summary>
		/// Void Translate(Single, Single, Single, UnityEngine.Space)
		/// </summary>
		protected RMethod r_MTranslate_Single_Single_Single_Space;
		public virtual RMethod RMTranslate_Single_Single_Single_Space
		{
			get
			{
				if(r_MTranslate_Single_Single_Single_Space == null)
				{
					r_MTranslate_Single_Single_Single_Space = new(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Space));
				}
				return r_MTranslate_Single_Single_Single_Space;
			}
		}

		/// <summary>
		/// Void Translate(Single, Single, Single)
		/// </summary>
		protected RMethod r_MTranslate_Single_Single_Single;
		public virtual RMethod RMTranslate_Single_Single_Single
		{
			get
			{
				if(r_MTranslate_Single_Single_Single == null)
				{
					r_MTranslate_Single_Single_Single = new(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MTranslate_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3, UnityEngine.Transform)
		/// </summary>
		protected RMethod r_MTranslate_Vector3_Transform;
		public virtual RMethod RMTranslate_Vector3_Transform
		{
			get
			{
				if(r_MTranslate_Vector3_Transform == null)
				{
					r_MTranslate_Vector3_Transform = new(this, "Translate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Transform));
				}
				return r_MTranslate_Vector3_Transform;
			}
		}

		/// <summary>
		/// Void Translate(Single, Single, Single, UnityEngine.Transform)
		/// </summary>
		protected RMethod r_MTranslate_Single_Single_Single_Transform;
		public virtual RMethod RMTranslate_Single_Single_Single_Transform
		{
			get
			{
				if(r_MTranslate_Single_Single_Single_Transform == null)
				{
					r_MTranslate_Single_Single_Single_Transform = new(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Transform));
				}
				return r_MTranslate_Single_Single_Single_Transform;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3, UnityEngine.Space)
		/// </summary>
		protected RMethod r_MRotate_Vector3_Space;
		public virtual RMethod RMRotate_Vector3_Space
		{
			get
			{
				if(r_MRotate_Vector3_Space == null)
				{
					r_MRotate_Vector3_Space = new(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Space));
				}
				return r_MRotate_Vector3_Space;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MRotate_Vector3;
		public virtual RMethod RMRotate_Vector3
		{
			get
			{
				if(r_MRotate_Vector3 == null)
				{
					r_MRotate_Vector3 = new(this, "Rotate", 0, typeof(UnityEngine.Vector3));
				}
				return r_MRotate_Vector3;
			}
		}

		/// <summary>
		/// Void Rotate(Single, Single, Single, UnityEngine.Space)
		/// </summary>
		protected RMethod r_MRotate_Single_Single_Single_Space;
		public virtual RMethod RMRotate_Single_Single_Single_Space
		{
			get
			{
				if(r_MRotate_Single_Single_Single_Space == null)
				{
					r_MRotate_Single_Single_Single_Space = new(this, "Rotate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Space));
				}
				return r_MRotate_Single_Single_Single_Space;
			}
		}

		/// <summary>
		/// Void Rotate(Single, Single, Single)
		/// </summary>
		protected RMethod r_MRotate_Single_Single_Single;
		public virtual RMethod RMRotate_Single_Single_Single
		{
			get
			{
				if(r_MRotate_Single_Single_Single == null)
				{
					r_MRotate_Single_Single_Single = new(this, "Rotate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MRotate_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void RotateAroundInternal(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_MRotateAroundInternal_Vector3_Single;
		public virtual RMethod RMRotateAroundInternal_Vector3_Single
		{
			get
			{
				if(r_MRotateAroundInternal_Vector3_Single == null)
				{
					r_MRotateAroundInternal_Vector3_Single = new(this, "RotateAroundInternal", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MRotateAroundInternal_Vector3_Single;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3, Single, UnityEngine.Space)
		/// </summary>
		protected RMethod r_MRotate_Vector3_Single_Space;
		public virtual RMethod RMRotate_Vector3_Single_Space
		{
			get
			{
				if(r_MRotate_Vector3_Single_Space == null)
				{
					r_MRotate_Vector3_Single_Space = new(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(UnityEngine.Space));
				}
				return r_MRotate_Vector3_Single_Space;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_MRotate_Vector3_Single;
		public virtual RMethod RMRotate_Vector3_Single
		{
			get
			{
				if(r_MRotate_Vector3_Single == null)
				{
					r_MRotate_Vector3_Single = new(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MRotate_Vector3_Single;
			}
		}

		/// <summary>
		/// Void RotateAround(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_MRotateAround_Vector3_Vector3_Single;
		public virtual RMethod RMRotateAround_Vector3_Vector3_Single
		{
			get
			{
				if(r_MRotateAround_Vector3_Vector3_Single == null)
				{
					r_MRotateAround_Vector3_Vector3_Single = new(this, "RotateAround", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MRotateAround_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Transform, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MLookAt_Transform_Vector3;
		public virtual RMethod RMLookAt_Transform_Vector3
		{
			get
			{
				if(r_MLookAt_Transform_Vector3 == null)
				{
					r_MLookAt_Transform_Vector3 = new(this, "LookAt", 0, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3));
				}
				return r_MLookAt_Transform_Vector3;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_MLookAt_Transform;
		public virtual RMethod RMLookAt_Transform
		{
			get
			{
				if(r_MLookAt_Transform == null)
				{
					r_MLookAt_Transform = new(this, "LookAt", 0, typeof(UnityEngine.Transform));
				}
				return r_MLookAt_Transform;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MLookAt_Vector3_Vector3;
		public virtual RMethod RMLookAt_Vector3_Vector3
		{
			get
			{
				if(r_MLookAt_Vector3_Vector3 == null)
				{
					r_MLookAt_Vector3_Vector3 = new(this, "LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MLookAt_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MLookAt_Vector3;
		public virtual RMethod RMLookAt_Vector3
		{
			get
			{
				if(r_MLookAt_Vector3 == null)
				{
					r_MLookAt_Vector3 = new(this, "LookAt", 0, typeof(UnityEngine.Vector3));
				}
				return r_MLookAt_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_LookAt(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MInternal_LookAt_Vector3_Vector3;
		public virtual RMethod RMInternal_LookAt_Vector3_Vector3
		{
			get
			{
				if(r_MInternal_LookAt_Vector3_Vector3 == null)
				{
					r_MInternal_LookAt_Vector3_Vector3 = new(this, "Internal_LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MInternal_LookAt_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MTransformDirection_Vector3;
		public virtual RMethod RMTransformDirection_Vector3
		{
			get
			{
				if(r_MTransformDirection_Vector3 == null)
				{
					r_MTransformDirection_Vector3 = new(this, "TransformDirection", 0, typeof(UnityEngine.Vector3));
				}
				return r_MTransformDirection_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformDirection(Single, Single, Single)
		/// </summary>
		protected RMethod r_MTransformDirection_Single_Single_Single;
		public virtual RMethod RMTransformDirection_Single_Single_Single
		{
			get
			{
				if(r_MTransformDirection_Single_Single_Single == null)
				{
					r_MTransformDirection_Single_Single_Single = new(this, "TransformDirection", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MTransformDirection_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void TransformDirections(UnityEngine.Vector3*, Int32, UnityEngine.Vector3*, Int32)
		/// </summary>
		protected RMethod r_MTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32;
		public virtual RMethod RMTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32
		{
			get
			{
				if(r_MTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32 == null)
				{
					r_MTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32 = new(this, "TransformDirections", 0, typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32));
				}
				return r_MTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32;
			}
		}

		/// <summary>
		/// Void TransformDirections(System.ReadOnlySpan`1[UnityEngine.Vector3], System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
		public virtual RMethod RMTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_
		{
			get
			{
				if(r_MTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ == null)
				{
					r_MTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ = new(this, "TransformDirections", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void TransformDirections(System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MTransformDirections_Span_d_Vector3_p_;
		public virtual RMethod RMTransformDirections_Span_d_Vector3_p_
		{
			get
			{
				if(r_MTransformDirections_Span_d_Vector3_p_ == null)
				{
					r_MTransformDirections_Span_d_Vector3_p_ = new(this, "TransformDirections", 0, typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MTransformDirections_Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MInverseTransformDirection_Vector3;
		public virtual RMethod RMInverseTransformDirection_Vector3
		{
			get
			{
				if(r_MInverseTransformDirection_Vector3 == null)
				{
					r_MInverseTransformDirection_Vector3 = new(this, "InverseTransformDirection", 0, typeof(UnityEngine.Vector3));
				}
				return r_MInverseTransformDirection_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformDirection(Single, Single, Single)
		/// </summary>
		protected RMethod r_MInverseTransformDirection_Single_Single_Single;
		public virtual RMethod RMInverseTransformDirection_Single_Single_Single
		{
			get
			{
				if(r_MInverseTransformDirection_Single_Single_Single == null)
				{
					r_MInverseTransformDirection_Single_Single_Single = new(this, "InverseTransformDirection", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MInverseTransformDirection_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void InverseTransformDirections(UnityEngine.Vector3*, Int32, UnityEngine.Vector3*, Int32)
		/// </summary>
		protected RMethod r_MInverseTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32;
		public virtual RMethod RMInverseTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32
		{
			get
			{
				if(r_MInverseTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32 == null)
				{
					r_MInverseTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32 = new(this, "InverseTransformDirections", 0, typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32));
				}
				return r_MInverseTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32;
			}
		}

		/// <summary>
		/// Void InverseTransformDirections(System.ReadOnlySpan`1[UnityEngine.Vector3], System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MInverseTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
		public virtual RMethod RMInverseTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_
		{
			get
			{
				if(r_MInverseTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ == null)
				{
					r_MInverseTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ = new(this, "InverseTransformDirections", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MInverseTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void InverseTransformDirections(System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MInverseTransformDirections_Span_d_Vector3_p_;
		public virtual RMethod RMInverseTransformDirections_Span_d_Vector3_p_
		{
			get
			{
				if(r_MInverseTransformDirections_Span_d_Vector3_p_ == null)
				{
					r_MInverseTransformDirections_Span_d_Vector3_p_ = new(this, "InverseTransformDirections", 0, typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MInverseTransformDirections_Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformVector(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MTransformVector_Vector3;
		public virtual RMethod RMTransformVector_Vector3
		{
			get
			{
				if(r_MTransformVector_Vector3 == null)
				{
					r_MTransformVector_Vector3 = new(this, "TransformVector", 0, typeof(UnityEngine.Vector3));
				}
				return r_MTransformVector_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformVector(Single, Single, Single)
		/// </summary>
		protected RMethod r_MTransformVector_Single_Single_Single;
		public virtual RMethod RMTransformVector_Single_Single_Single
		{
			get
			{
				if(r_MTransformVector_Single_Single_Single == null)
				{
					r_MTransformVector_Single_Single_Single = new(this, "TransformVector", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MTransformVector_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void TransformVectors(UnityEngine.Vector3*, Int32, UnityEngine.Vector3*, Int32)
		/// </summary>
		protected RMethod r_MTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32;
		public virtual RMethod RMTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32
		{
			get
			{
				if(r_MTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32 == null)
				{
					r_MTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32 = new(this, "TransformVectors", 0, typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32));
				}
				return r_MTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32;
			}
		}

		/// <summary>
		/// Void TransformVectors(System.ReadOnlySpan`1[UnityEngine.Vector3], System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
		public virtual RMethod RMTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_
		{
			get
			{
				if(r_MTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ == null)
				{
					r_MTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ = new(this, "TransformVectors", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void TransformVectors(System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MTransformVectors_Span_d_Vector3_p_;
		public virtual RMethod RMTransformVectors_Span_d_Vector3_p_
		{
			get
			{
				if(r_MTransformVectors_Span_d_Vector3_p_ == null)
				{
					r_MTransformVectors_Span_d_Vector3_p_ = new(this, "TransformVectors", 0, typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MTransformVectors_Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MInverseTransformVector_Vector3;
		public virtual RMethod RMInverseTransformVector_Vector3
		{
			get
			{
				if(r_MInverseTransformVector_Vector3 == null)
				{
					r_MInverseTransformVector_Vector3 = new(this, "InverseTransformVector", 0, typeof(UnityEngine.Vector3));
				}
				return r_MInverseTransformVector_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformVector(Single, Single, Single)
		/// </summary>
		protected RMethod r_MInverseTransformVector_Single_Single_Single;
		public virtual RMethod RMInverseTransformVector_Single_Single_Single
		{
			get
			{
				if(r_MInverseTransformVector_Single_Single_Single == null)
				{
					r_MInverseTransformVector_Single_Single_Single = new(this, "InverseTransformVector", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MInverseTransformVector_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void InverseTransformVectors(UnityEngine.Vector3*, Int32, UnityEngine.Vector3*, Int32)
		/// </summary>
		protected RMethod r_MInverseTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32;
		public virtual RMethod RMInverseTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32
		{
			get
			{
				if(r_MInverseTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32 == null)
				{
					r_MInverseTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32 = new(this, "InverseTransformVectors", 0, typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32));
				}
				return r_MInverseTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32;
			}
		}

		/// <summary>
		/// Void InverseTransformVectors(System.ReadOnlySpan`1[UnityEngine.Vector3], System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MInverseTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
		public virtual RMethod RMInverseTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_
		{
			get
			{
				if(r_MInverseTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ == null)
				{
					r_MInverseTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ = new(this, "InverseTransformVectors", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MInverseTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void InverseTransformVectors(System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MInverseTransformVectors_Span_d_Vector3_p_;
		public virtual RMethod RMInverseTransformVectors_Span_d_Vector3_p_
		{
			get
			{
				if(r_MInverseTransformVectors_Span_d_Vector3_p_ == null)
				{
					r_MInverseTransformVectors_Span_d_Vector3_p_ = new(this, "InverseTransformVectors", 0, typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MInverseTransformVectors_Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MTransformPoint_Vector3;
		public virtual RMethod RMTransformPoint_Vector3
		{
			get
			{
				if(r_MTransformPoint_Vector3 == null)
				{
					r_MTransformPoint_Vector3 = new(this, "TransformPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MTransformPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformPoint(Single, Single, Single)
		/// </summary>
		protected RMethod r_MTransformPoint_Single_Single_Single;
		public virtual RMethod RMTransformPoint_Single_Single_Single
		{
			get
			{
				if(r_MTransformPoint_Single_Single_Single == null)
				{
					r_MTransformPoint_Single_Single_Single = new(this, "TransformPoint", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MTransformPoint_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void TransformPoints(UnityEngine.Vector3*, Int32, UnityEngine.Vector3*, Int32)
		/// </summary>
		protected RMethod r_MTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32;
		public virtual RMethod RMTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32
		{
			get
			{
				if(r_MTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32 == null)
				{
					r_MTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32 = new(this, "TransformPoints", 0, typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32));
				}
				return r_MTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32;
			}
		}

		/// <summary>
		/// Void TransformPoints(System.ReadOnlySpan`1[UnityEngine.Vector3], System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
		public virtual RMethod RMTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_
		{
			get
			{
				if(r_MTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ == null)
				{
					r_MTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ = new(this, "TransformPoints", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void TransformPoints(System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MTransformPoints_Span_d_Vector3_p_;
		public virtual RMethod RMTransformPoints_Span_d_Vector3_p_
		{
			get
			{
				if(r_MTransformPoints_Span_d_Vector3_p_ == null)
				{
					r_MTransformPoints_Span_d_Vector3_p_ = new(this, "TransformPoints", 0, typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MTransformPoints_Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MInverseTransformPoint_Vector3;
		public virtual RMethod RMInverseTransformPoint_Vector3
		{
			get
			{
				if(r_MInverseTransformPoint_Vector3 == null)
				{
					r_MInverseTransformPoint_Vector3 = new(this, "InverseTransformPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MInverseTransformPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformPoint(Single, Single, Single)
		/// </summary>
		protected RMethod r_MInverseTransformPoint_Single_Single_Single;
		public virtual RMethod RMInverseTransformPoint_Single_Single_Single
		{
			get
			{
				if(r_MInverseTransformPoint_Single_Single_Single == null)
				{
					r_MInverseTransformPoint_Single_Single_Single = new(this, "InverseTransformPoint", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
				}
				return r_MInverseTransformPoint_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void InverseTransformPoints(UnityEngine.Vector3*, Int32, UnityEngine.Vector3*, Int32)
		/// </summary>
		protected RMethod r_MInverseTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32;
		public virtual RMethod RMInverseTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32
		{
			get
			{
				if(r_MInverseTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32 == null)
				{
					r_MInverseTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32 = new(this, "InverseTransformPoints", 0, typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Vector3).MakePointerType(), typeof(System.Int32));
				}
				return r_MInverseTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32;
			}
		}

		/// <summary>
		/// Void InverseTransformPoints(System.ReadOnlySpan`1[UnityEngine.Vector3], System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MInverseTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
		public virtual RMethod RMInverseTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_
		{
			get
			{
				if(r_MInverseTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ == null)
				{
					r_MInverseTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_ = new(this, "InverseTransformPoints", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MInverseTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void InverseTransformPoints(System.Span`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MInverseTransformPoints_Span_d_Vector3_p_;
		public virtual RMethod RMInverseTransformPoints_Span_d_Vector3_p_
		{
			get
			{
				if(r_MInverseTransformPoints_Span_d_Vector3_p_ == null)
				{
					r_MInverseTransformPoints_Span_d_Vector3_p_ = new(this, "InverseTransformPoints", 0, typeof(System.Span<>).MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MInverseTransformPoints_Span_d_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetRoot()
		/// </summary>
		protected RMethod r_MGetRoot;
		public virtual RMethod RMGetRoot
		{
			get
			{
				if(r_MGetRoot == null)
				{
					r_MGetRoot = new(this, "GetRoot", 0);
				}
				return r_MGetRoot;
			}
		}

		/// <summary>
		/// Void DetachChildren()
		/// </summary>
		protected RMethod r_MDetachChildren;
		public virtual RMethod RMDetachChildren
		{
			get
			{
				if(r_MDetachChildren == null)
				{
					r_MDetachChildren = new(this, "DetachChildren", 0);
				}
				return r_MDetachChildren;
			}
		}

		/// <summary>
		/// Void SetAsFirstSibling()
		/// </summary>
		protected RMethod r_MSetAsFirstSibling;
		public virtual RMethod RMSetAsFirstSibling
		{
			get
			{
				if(r_MSetAsFirstSibling == null)
				{
					r_MSetAsFirstSibling = new(this, "SetAsFirstSibling", 0);
				}
				return r_MSetAsFirstSibling;
			}
		}

		/// <summary>
		/// Void SetAsLastSibling()
		/// </summary>
		protected RMethod r_MSetAsLastSibling;
		public virtual RMethod RMSetAsLastSibling
		{
			get
			{
				if(r_MSetAsLastSibling == null)
				{
					r_MSetAsLastSibling = new(this, "SetAsLastSibling", 0);
				}
				return r_MSetAsLastSibling;
			}
		}

		/// <summary>
		/// Void SetSiblingIndex(Int32)
		/// </summary>
		protected RMethod r_MSetSiblingIndex_Int32;
		public virtual RMethod RMSetSiblingIndex_Int32
		{
			get
			{
				if(r_MSetSiblingIndex_Int32 == null)
				{
					r_MSetSiblingIndex_Int32 = new(this, "SetSiblingIndex", 0, typeof(System.Int32));
				}
				return r_MSetSiblingIndex_Int32;
			}
		}

		/// <summary>
		/// Void MoveAfterSibling(UnityEngine.Transform, Boolean)
		/// </summary>
		protected RMethod r_MMoveAfterSibling_Transform_Boolean;
		public virtual RMethod RMMoveAfterSibling_Transform_Boolean
		{
			get
			{
				if(r_MMoveAfterSibling_Transform_Boolean == null)
				{
					r_MMoveAfterSibling_Transform_Boolean = new(this, "MoveAfterSibling", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
				}
				return r_MMoveAfterSibling_Transform_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetSiblingIndex()
		/// </summary>
		protected RMethod r_MGetSiblingIndex;
		public virtual RMethod RMGetSiblingIndex
		{
			get
			{
				if(r_MGetSiblingIndex == null)
				{
					r_MGetSiblingIndex = new(this, "GetSiblingIndex", 0);
				}
				return r_MGetSiblingIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MFindRelativeTransformWithPath_Transform_String_Boolean;
		public static RMethod RMFindRelativeTransformWithPath_Transform_String_Boolean
		{
			get
			{
				if(r_MFindRelativeTransformWithPath_Transform_String_Boolean == null)
				{
					r_MFindRelativeTransformWithPath_Transform_String_Boolean = new(typeof(UnityEngine.Transform), "FindRelativeTransformWithPath", 0, typeof(UnityEngine.Transform), typeof(System.String), typeof(System.Boolean));
				}
				return r_MFindRelativeTransformWithPath_Transform_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Transform Find(System.String)
		/// </summary>
		protected RMethod r_MFind_String;
		public virtual RMethod RMFind_String
		{
			get
			{
				if(r_MFind_String == null)
				{
					r_MFind_String = new(this, "Find", 0, typeof(System.String));
				}
				return r_MFind_String;
			}
		}

		/// <summary>
		/// Void SendTransformChangedScale()
		/// </summary>
		protected RMethod r_MSendTransformChangedScale;
		public virtual RMethod RMSendTransformChangedScale
		{
			get
			{
				if(r_MSendTransformChangedScale == null)
				{
					r_MSendTransformChangedScale = new(this, "SendTransformChangedScale", 0);
				}
				return r_MSendTransformChangedScale;
			}
		}

		/// <summary>
		/// Boolean IsChildOf(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_MIsChildOf_Transform;
		public virtual RMethod RMIsChildOf_Transform
		{
			get
			{
				if(r_MIsChildOf_Transform == null)
				{
					r_MIsChildOf_Transform = new(this, "IsChildOf", 0, typeof(UnityEngine.Transform));
				}
				return r_MIsChildOf_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Transform FindChild(System.String)
		/// </summary>
		protected RMethod r_MFindChild_String;
		public virtual RMethod RMFindChild_String
		{
			get
			{
				if(r_MFindChild_String == null)
				{
					r_MFindChild_String = new(this, "FindChild", 0, typeof(System.String));
				}
				return r_MFindChild_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// Void RotateAround(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_MRotateAround_Vector3_Single;
		public virtual RMethod RMRotateAround_Vector3_Single
		{
			get
			{
				if(r_MRotateAround_Vector3_Single == null)
				{
					r_MRotateAround_Vector3_Single = new(this, "RotateAround", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MRotateAround_Vector3_Single;
			}
		}

		/// <summary>
		/// Void RotateAroundLocal(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_MRotateAroundLocal_Vector3_Single;
		public virtual RMethod RMRotateAroundLocal_Vector3_Single
		{
			get
			{
				if(r_MRotateAroundLocal_Vector3_Single == null)
				{
					r_MRotateAroundLocal_Vector3_Single = new(this, "RotateAroundLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
				}
				return r_MRotateAroundLocal_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetChild(Int32)
		/// </summary>
		protected RMethod r_MGetChild_Int32;
		public virtual RMethod RMGetChild_Int32
		{
			get
			{
				if(r_MGetChild_Int32 == null)
				{
					r_MGetChild_Int32 = new(this, "GetChild", 0, typeof(System.Int32));
				}
				return r_MGetChild_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChildCount()
		/// </summary>
		protected RMethod r_MGetChildCount;
		public virtual RMethod RMGetChildCount
		{
			get
			{
				if(r_MGetChildCount == null)
				{
					r_MGetChildCount = new(this, "GetChildCount", 0);
				}
				return r_MGetChildCount;
			}
		}

		/// <summary>
		/// Int32 internal_getHierarchyCapacity()
		/// </summary>
		protected RMethod r_Minternal_getHierarchyCapacity;
		public virtual RMethod RMinternal_getHierarchyCapacity
		{
			get
			{
				if(r_Minternal_getHierarchyCapacity == null)
				{
					r_Minternal_getHierarchyCapacity = new(this, "internal_getHierarchyCapacity", 0);
				}
				return r_Minternal_getHierarchyCapacity;
			}
		}

		/// <summary>
		/// Void internal_setHierarchyCapacity(Int32)
		/// </summary>
		protected RMethod r_Minternal_setHierarchyCapacity_Int32;
		public virtual RMethod RMinternal_setHierarchyCapacity_Int32
		{
			get
			{
				if(r_Minternal_setHierarchyCapacity_Int32 == null)
				{
					r_Minternal_setHierarchyCapacity_Int32 = new(this, "internal_setHierarchyCapacity", 0, typeof(System.Int32));
				}
				return r_Minternal_setHierarchyCapacity_Int32;
			}
		}

		/// <summary>
		/// Int32 internal_getHierarchyCount()
		/// </summary>
		protected RMethod r_Minternal_getHierarchyCount;
		public virtual RMethod RMinternal_getHierarchyCount
		{
			get
			{
				if(r_Minternal_getHierarchyCount == null)
				{
					r_Minternal_getHierarchyCount = new(this, "internal_getHierarchyCount", 0);
				}
				return r_Minternal_getHierarchyCount;
			}
		}

		/// <summary>
		/// Boolean IsNonUniformScaleTransform()
		/// </summary>
		protected RMethod r_MIsNonUniformScaleTransform;
		public virtual RMethod RMIsNonUniformScaleTransform
		{
			get
			{
				if(r_MIsNonUniformScaleTransform == null)
				{
					r_MIsNonUniformScaleTransform = new(this, "IsNonUniformScaleTransform", 0);
				}
				return r_MIsNonUniformScaleTransform;
			}
		}

		/// <summary>
		/// Void SetConstrainProportionsScale(Boolean)
		/// </summary>
		protected RMethod r_MSetConstrainProportionsScale_Boolean;
		public virtual RMethod RMSetConstrainProportionsScale_Boolean
		{
			get
			{
				if(r_MSetConstrainProportionsScale_Boolean == null)
				{
					r_MSetConstrainProportionsScale_Boolean = new(this, "SetConstrainProportionsScale", 0, typeof(System.Boolean));
				}
				return r_MSetConstrainProportionsScale_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsConstrainProportionsScale()
		/// </summary>
		protected RMethod r_MIsConstrainProportionsScale;
		public virtual RMethod RMIsConstrainProportionsScale
		{
			get
			{
				if(r_MIsConstrainProportionsScale == null)
				{
					r_MIsConstrainProportionsScale = new(this, "IsConstrainProportionsScale", 0);
				}
				return r_MIsConstrainProportionsScale;
			}
		}

		/// <summary>
		/// Void get_position_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_position_Injected_Out_Vector3;
		public virtual RMethod RMget_position_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_position_Injected_Out_Vector3 == null)
				{
					r_Mget_position_Injected_Out_Vector3 = new(this, "get_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_position_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_position_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mset_position_Injected_Ref_Vector3;
		public virtual RMethod RMset_position_Injected_Ref_Vector3
		{
			get
			{
				if(r_Mset_position_Injected_Ref_Vector3 == null)
				{
					r_Mset_position_Injected_Ref_Vector3 = new(this, "set_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mset_position_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_localPosition_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_localPosition_Injected_Out_Vector3;
		public virtual RMethod RMget_localPosition_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_localPosition_Injected_Out_Vector3 == null)
				{
					r_Mget_localPosition_Injected_Out_Vector3 = new(this, "get_localPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_localPosition_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_localPosition_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mset_localPosition_Injected_Ref_Vector3;
		public virtual RMethod RMset_localPosition_Injected_Ref_Vector3
		{
			get
			{
				if(r_Mset_localPosition_Injected_Ref_Vector3 == null)
				{
					r_Mset_localPosition_Injected_Ref_Vector3 = new(this, "set_localPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mset_localPosition_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3;
		public virtual RMethod RMGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3
		{
			get
			{
				if(r_MGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3 == null)
				{
					r_MGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3 = new(this, "GetLocalEulerAngles_Injected", 0,  ReflectionUtils.GetType("UnityEngine.RotationOrder"), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SetLocalEulerAngles_Injected(UnityEngine.Vector3 ByRef, UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_MSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder;
		public virtual RMethod RMSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder
		{
			get
			{
				if(r_MSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder == null)
				{
					r_MSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder = new(this, "SetLocalEulerAngles_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.RotationOrder"));
				}
				return r_MSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder;
			}
		}

		/// <summary>
		/// Void SetLocalEulerHint_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MSetLocalEulerHint_Injected_Ref_Vector3;
		public virtual RMethod RMSetLocalEulerHint_Injected_Ref_Vector3
		{
			get
			{
				if(r_MSetLocalEulerHint_Injected_Ref_Vector3 == null)
				{
					r_MSetLocalEulerHint_Injected_Ref_Vector3 = new(this, "SetLocalEulerHint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MSetLocalEulerHint_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_rotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Mget_rotation_Injected_Out_Quaternion;
		public virtual RMethod RMget_rotation_Injected_Out_Quaternion
		{
			get
			{
				if(r_Mget_rotation_Injected_Out_Quaternion == null)
				{
					r_Mget_rotation_Injected_Out_Quaternion = new(this, "get_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_Mget_rotation_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void set_rotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Mset_rotation_Injected_Ref_Quaternion;
		public virtual RMethod RMset_rotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_Mset_rotation_Injected_Ref_Quaternion == null)
				{
					r_Mset_rotation_Injected_Ref_Quaternion = new(this, "set_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_Mset_rotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void get_localRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Mget_localRotation_Injected_Out_Quaternion;
		public virtual RMethod RMget_localRotation_Injected_Out_Quaternion
		{
			get
			{
				if(r_Mget_localRotation_Injected_Out_Quaternion == null)
				{
					r_Mget_localRotation_Injected_Out_Quaternion = new(this, "get_localRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_Mget_localRotation_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void set_localRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Mset_localRotation_Injected_Ref_Quaternion;
		public virtual RMethod RMset_localRotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_Mset_localRotation_Injected_Ref_Quaternion == null)
				{
					r_Mset_localRotation_Injected_Ref_Quaternion = new(this, "set_localRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_Mset_localRotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void get_localScale_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_localScale_Injected_Out_Vector3;
		public virtual RMethod RMget_localScale_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_localScale_Injected_Out_Vector3 == null)
				{
					r_Mget_localScale_Injected_Out_Vector3 = new(this, "get_localScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_localScale_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_localScale_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mset_localScale_Injected_Ref_Vector3;
		public virtual RMethod RMset_localScale_Injected_Ref_Vector3
		{
			get
			{
				if(r_Mset_localScale_Injected_Ref_Vector3 == null)
				{
					r_Mset_localScale_Injected_Ref_Vector3 = new(this, "set_localScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mset_localScale_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_worldToLocalMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_worldToLocalMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_worldToLocalMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_worldToLocalMatrix_Injected_Out_Matrix4x4 = new(this, "get_worldToLocalMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_worldToLocalMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_localToWorldMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_localToWorldMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_localToWorldMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_localToWorldMatrix_Injected_Out_Matrix4x4 = new(this, "get_localToWorldMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_localToWorldMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetPositionAndRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_MSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
		public virtual RMethod RMSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_MSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion == null)
				{
					r_MSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion = new(this, "SetPositionAndRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void SetLocalPositionAndRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_MSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
		public virtual RMethod RMSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_MSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion == null)
				{
					r_MSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion = new(this, "SetLocalPositionAndRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
				}
				return r_MSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void RotateAroundInternal_Injected(UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected RMethod r_MRotateAroundInternal_Injected_Ref_Vector3_Single;
		public virtual RMethod RMRotateAroundInternal_Injected_Ref_Vector3_Single
		{
			get
			{
				if(r_MRotateAroundInternal_Injected_Ref_Vector3_Single == null)
				{
					r_MRotateAroundInternal_Injected_Ref_Vector3_Single = new(this, "RotateAroundInternal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
				}
				return r_MRotateAroundInternal_Injected_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// Void Internal_LookAt_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3;
		public virtual RMethod RMInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_MInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3 == null)
				{
					r_MInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3 = new(this, "Internal_LookAt_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void TransformDirection_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MTransformDirection_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMTransformDirection_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MTransformDirection_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MTransformDirection_Injected_Ref_Vector3_Out_Vector3 = new(this, "TransformDirection_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MTransformDirection_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void InverseTransformDirection_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3 = new(this, "InverseTransformDirection_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void TransformVector_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MTransformVector_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMTransformVector_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MTransformVector_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MTransformVector_Injected_Ref_Vector3_Out_Vector3 = new(this, "TransformVector_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MTransformVector_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void InverseTransformVector_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MInverseTransformVector_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMInverseTransformVector_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MInverseTransformVector_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MInverseTransformVector_Injected_Ref_Vector3_Out_Vector3 = new(this, "InverseTransformVector_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MInverseTransformVector_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void TransformPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MTransformPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMTransformPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MTransformPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MTransformPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "TransformPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MTransformPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void InverseTransformPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "InverseTransformPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_lossyScale_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_lossyScale_Injected_Out_Vector3;
		public virtual RMethod RMget_lossyScale_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_lossyScale_Injected_Out_Vector3 == null)
				{
					r_Mget_lossyScale_Injected_Out_Vector3 = new(this, "get_lossyScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_lossyScale_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void RotateAround_Injected(UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected RMethod r_MRotateAround_Injected_Ref_Vector3_Single;
		public virtual RMethod RMRotateAround_Injected_Ref_Vector3_Single
		{
			get
			{
				if(r_MRotateAround_Injected_Ref_Vector3_Single == null)
				{
					r_MRotateAround_Injected_Ref_Vector3_Single = new(this, "RotateAround_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
				}
				return r_MRotateAround_Injected_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// Void RotateAroundLocal_Injected(UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected RMethod r_MRotateAroundLocal_Injected_Ref_Vector3_Single;
		public virtual RMethod RMRotateAroundLocal_Injected_Ref_Vector3_Single
		{
			get
			{
				if(r_MRotateAroundLocal_Injected_Ref_Vector3_Single == null)
				{
					r_MRotateAroundLocal_Injected_Ref_Vector3_Single = new(this, "RotateAroundLocal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
				}
				return r_MRotateAroundLocal_Injected_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_MGetComponent_Type;
		public virtual RMethod RMGetComponent_Type
		{
			get
			{
				if(r_MGetComponent_Type == null)
				{
					r_MGetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
				}
				return r_MGetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_MGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RMGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_MGetComponentFastPath_Type_IntPtr == null)
				{
					r_MGetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
				}
				return r_MGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_MGetComponent_GT;
		public virtual RMethod RMGetComponent_GT
		{
			get
			{
				if(r_MGetComponent_GT == null)
				{
					r_MGetComponent_GT = new(this, "GetComponent", 1);
				}
				return r_MGetComponent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_MTryGetComponent_Type_Out_Component;
		public virtual RMethod RMTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_MTryGetComponent_Type_Out_Component == null)
				{
					r_MTryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
				}
				return r_MTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_MTryGetComponent_GT_Out_T;
		public virtual RMethod RMTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_MTryGetComponent_GT_Out_T == null)
				{
					r_MTryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MTryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_MGetComponent_String;
		public virtual RMethod RMGetComponent_String
		{
			get
			{
				if(r_MGetComponent_String == null)
				{
					r_MGetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
				}
				return r_MGetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInChildren_Type_Boolean;
		public virtual RMethod RMGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_MGetComponentInChildren_Type_Boolean == null)
				{
					r_MGetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentInChildren_Type;
		public virtual RMethod RMGetComponentInChildren_Type
		{
			get
			{
				if(r_MGetComponentInChildren_Type == null)
				{
					r_MGetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
				}
				return r_MGetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInChildren_GT_Boolean;
		public virtual RMethod RMGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_MGetComponentInChildren_GT_Boolean == null)
				{
					r_MGetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
				}
				return r_MGetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_MGetComponentInChildren_GT;
		public virtual RMethod RMGetComponentInChildren_GT
		{
			get
			{
				if(r_MGetComponentInChildren_GT == null)
				{
					r_MGetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
				}
				return r_MGetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_Type_Boolean;
		public virtual RMethod RMGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_MGetComponentsInChildren_Type_Boolean == null)
				{
					r_MGetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_Type;
		public virtual RMethod RMGetComponentsInChildren_Type
		{
			get
			{
				if(r_MGetComponentsInChildren_Type == null)
				{
					r_MGetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
				}
				return r_MGetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT_Boolean;
		public virtual RMethod RMGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_MGetComponentsInChildren_GT_Boolean == null)
				{
					r_MGetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
				}
				return r_MGetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RMGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT;
		public virtual RMethod RMGetComponentsInChildren_GT
		{
			get
			{
				if(r_MGetComponentsInChildren_GT == null)
				{
					r_MGetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
				}
				return r_MGetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RMGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_MGetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_MGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInParent_Type_Boolean;
		public virtual RMethod RMGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_MGetComponentInParent_Type_Boolean == null)
				{
					r_MGetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentInParent_Type;
		public virtual RMethod RMGetComponentInParent_Type
		{
			get
			{
				if(r_MGetComponentInParent_Type == null)
				{
					r_MGetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
				}
				return r_MGetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInParent_GT_Boolean;
		public virtual RMethod RMGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_MGetComponentInParent_GT_Boolean == null)
				{
					r_MGetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
				}
				return r_MGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_MGetComponentInParent_GT;
		public virtual RMethod RMGetComponentInParent_GT
		{
			get
			{
				if(r_MGetComponentInParent_GT == null)
				{
					r_MGetComponentInParent_GT = new(this, "GetComponentInParent", 1);
				}
				return r_MGetComponentInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInParent_Type_Boolean;
		public virtual RMethod RMGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_MGetComponentsInParent_Type_Boolean == null)
				{
					r_MGetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentsInParent_Type;
		public virtual RMethod RMGetComponentsInParent_Type
		{
			get
			{
				if(r_MGetComponentsInParent_Type == null)
				{
					r_MGetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
				}
				return r_MGetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInParent_GT_Boolean;
		public virtual RMethod RMGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_MGetComponentsInParent_GT_Boolean == null)
				{
					r_MGetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
				}
				return r_MGetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RMGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_MGetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_MGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_MGetComponentsInParent_GT;
		public virtual RMethod RMGetComponentsInParent_GT
		{
			get
			{
				if(r_MGetComponentsInParent_GT == null)
				{
					r_MGetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
				}
				return r_MGetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_MGetComponents_Type;
		public virtual RMethod RMGetComponents_Type
		{
			get
			{
				if(r_MGetComponents_Type == null)
				{
					r_MGetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
				}
				return r_MGetComponents_Type;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_MGetComponents_Type_List_d_Component_p_;
		public virtual RMethod RMGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_MGetComponents_Type_List_d_Component_p_ == null)
				{
					r_MGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
				}
				return r_MGetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponents_GT_List_d_T_p_;
		public virtual RMethod RMGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_MGetComponents_GT_List_d_T_p_ == null)
				{
					r_MGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_MGetComponents_GT;
		public virtual RMethod RMGetComponents_GT
		{
			get
			{
				if(r_MGetComponents_GT == null)
				{
					r_MGetComponents_GT = new(this, "GetComponents", 1);
				}
				return r_MGetComponents_GT;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_MCompareTag_String;
		public virtual RMethod RMCompareTag_String
		{
			get
			{
				if(r_MCompareTag_String == null)
				{
					r_MCompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
				}
				return r_MCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_MGetCoupledComponent;
		public virtual RMethod RMGetCoupledComponent
		{
			get
			{
				if(r_MGetCoupledComponent == null)
				{
					r_MGetCoupledComponent = new(this, "GetCoupledComponent", 0);
				}
				return r_MGetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_MIsCoupledComponent;
		public virtual RMethod RMIsCoupledComponent
		{
			get
			{
				if(r_MIsCoupledComponent == null)
				{
					r_MIsCoupledComponent = new(this, "IsCoupledComponent", 0);
				}
				return r_MIsCoupledComponent;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RMSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_MSendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_MSendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String_Object;
		public virtual RMethod RMSendMessageUpwards_String_Object
		{
			get
			{
				if(r_MSendMessageUpwards_String_Object == null)
				{
					r_MSendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String;
		public virtual RMethod RMSendMessageUpwards_String
		{
			get
			{
				if(r_MSendMessageUpwards_String == null)
				{
					r_MSendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
				}
				return r_MSendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RMSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_MSendMessageUpwards_String_SendMessageOptions == null)
				{
					r_MSendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSendMessage_String_Object;
		public virtual RMethod RMSendMessage_String_Object
		{
			get
			{
				if(r_MSendMessage_String_Object == null)
				{
					r_MSendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_MSendMessage_String;
		public virtual RMethod RMSendMessage_String
		{
			get
			{
				if(r_MSendMessage_String == null)
				{
					r_MSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
				}
				return r_MSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RMSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_MSendMessage_String_Object_SendMessageOptions == null)
				{
					r_MSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessage_String_SendMessageOptions;
		public virtual RMethod RMSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_MSendMessage_String_SendMessageOptions == null)
				{
					r_MSendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RMBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_MBroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_MBroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MBroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String_Object;
		public virtual RMethod RMBroadcastMessage_String_Object
		{
			get
			{
				if(r_MBroadcastMessage_String_Object == null)
				{
					r_MBroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MBroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String;
		public virtual RMethod RMBroadcastMessage_String
		{
			get
			{
				if(r_MBroadcastMessage_String == null)
				{
					r_MBroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
				}
				return r_MBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RMBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_MBroadcastMessage_String_SendMessageOptions == null)
				{
					r_MBroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MBroadcastMessage_String_SendMessageOptions;
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


        public RTransform() : base("UnityEngine.Transform")
        {
        }

        public RTransform(System.Object instance) : base("UnityEngine.Transform")
		{
            SetInstance(instance);
		}

        public RTransform(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransform(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Vector3 GetLocalEulerAngles(Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder @order)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@order.Value};
            var ___result = RMGetLocalEulerAngles_RotationOrder.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetLocalEulerAngles(UnityEngine.Vector3 @euler, Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder @order)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler, @order.Value};
            var ___result = RMSetLocalEulerAngles_Vector3_RotationOrder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalEulerHint(UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMSetLocalEulerHint_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetRotationOrderInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRotationOrderInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetRotationOrderInternal(Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder @rotationOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotationOrder.Value};
            var ___result = RMSetRotationOrderInternal_RotationOrder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Transform GetParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual void SetParent(UnityEngine.Transform @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RMSetParent_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParent(UnityEngine.Transform @parent, System.Boolean @worldPositionStays)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @worldPositionStays};
            var ___result = RMSetParent_Transform_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPositionAndRotation(UnityEngine.Vector3 @position, UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RMSetPositionAndRotation_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalPositionAndRotation(UnityEngine.Vector3 @localPosition, UnityEngine.Quaternion @localRotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @localRotation};
            var ___result = RMSetLocalPositionAndRotation_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPositionAndRotation(out UnityEngine.Vector3 @position, out UnityEngine.Quaternion @rotation)
        {
			@position = default;
			@rotation = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RMGetPositionAndRotation_Out_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@rotation = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public virtual void GetLocalPositionAndRotation(out UnityEngine.Vector3 @localPosition, out UnityEngine.Quaternion @localRotation)
        {
			@localPosition = default;
			@localRotation = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @localRotation};
            var ___result = RMGetLocalPositionAndRotation_Out_Vector3_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@localPosition = (UnityEngine.Vector3)___parameters[0];
			@localRotation = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public virtual void Translate(UnityEngine.Vector3 @translation, UnityEngine.Space @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation, @relativeTo};
            var ___result = RMTranslate_Vector3_Space.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(UnityEngine.Vector3 @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation};
            var ___result = RMTranslate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(System.Single @x, System.Single @y, System.Single @z, UnityEngine.Space @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @relativeTo};
            var ___result = RMTranslate_Single_Single_Single_Space.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMTranslate_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(UnityEngine.Vector3 @translation, UnityEngine.Transform @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation, @relativeTo};
            var ___result = RMTranslate_Vector3_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(System.Single @x, System.Single @y, System.Single @z, UnityEngine.Transform @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @relativeTo};
            var ___result = RMTranslate_Single_Single_Single_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rotate(UnityEngine.Vector3 @eulers, UnityEngine.Space @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eulers, @relativeTo};
            var ___result = RMRotate_Vector3_Space.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rotate(UnityEngine.Vector3 @eulers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eulers};
            var ___result = RMRotate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rotate(System.Single @xAngle, System.Single @yAngle, System.Single @zAngle, UnityEngine.Space @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xAngle, @yAngle, @zAngle, @relativeTo};
            var ___result = RMRotate_Single_Single_Single_Space.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rotate(System.Single @xAngle, System.Single @yAngle, System.Single @zAngle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xAngle, @yAngle, @zAngle};
            var ___result = RMRotate_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RotateAroundInternal(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotateAroundInternal_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rotate(UnityEngine.Vector3 @axis, System.Single @angle, UnityEngine.Space @relativeTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle, @relativeTo};
            var ___result = RMRotate_Vector3_Single_Space.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rotate(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotate_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RotateAround(UnityEngine.Vector3 @point, UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @axis, @angle};
            var ___result = RMRotateAround_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LookAt(UnityEngine.Transform @target, UnityEngine.Vector3 @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @worldUp};
            var ___result = RMLookAt_Transform_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LookAt(UnityEngine.Transform @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMLookAt_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LookAt(UnityEngine.Vector3 @worldPosition, UnityEngine.Vector3 @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition, @worldUp};
            var ___result = RMLookAt_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LookAt(UnityEngine.Vector3 @worldPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition};
            var ___result = RMLookAt_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_LookAt(UnityEngine.Vector3 @worldPosition, UnityEngine.Vector3 @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition, @worldUp};
            var ___result = RMInternal_LookAt_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RMTransformDirection_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 TransformDirection(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMTransformDirection_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public unsafe virtual void TransformDirections(UnityEngine.Vector3* @directions, System.Int32 @count, UnityEngine.Vector3* @transformedDirections, System.Int32 @transformedCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@directions, typeof(UnityEngine.Vector3)), @count, Pointer.Box(@transformedDirections, typeof(UnityEngine.Vector3)), @transformedCount};
            var ___result = RMTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransformDirections(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @directions, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @transformedDirections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directions.Value, @transformedDirections.Value};
            var ___result = RMTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransformDirections(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @directions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directions.Value};
            var ___result = RMTransformDirections_Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RMInverseTransformDirection_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 InverseTransformDirection(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMInverseTransformDirection_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public unsafe virtual void InverseTransformDirections(UnityEngine.Vector3* @directions, System.Int32 @count, UnityEngine.Vector3* @transformedDirections, System.Int32 @transformedCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@directions, typeof(UnityEngine.Vector3)), @count, Pointer.Box(@transformedDirections, typeof(UnityEngine.Vector3)), @transformedCount};
            var ___result = RMInverseTransformDirections_Vector3Pointer_Int32_Vector3Pointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InverseTransformDirections(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @directions, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @transformedDirections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directions.Value, @transformedDirections.Value};
            var ___result = RMInverseTransformDirections_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InverseTransformDirections(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @directions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directions.Value};
            var ___result = RMInverseTransformDirections_Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RMTransformVector_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 TransformVector(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMTransformVector_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public unsafe virtual void TransformVectors(UnityEngine.Vector3* @vectors, System.Int32 @count, UnityEngine.Vector3* @transformedVectors, System.Int32 @transformedCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@vectors, typeof(UnityEngine.Vector3)), @count, Pointer.Box(@transformedVectors, typeof(UnityEngine.Vector3)), @transformedCount};
            var ___result = RMTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransformVectors(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @vectors, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @transformedVectors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectors.Value, @transformedVectors.Value};
            var ___result = RMTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransformVectors(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @vectors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectors.Value};
            var ___result = RMTransformVectors_Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector};
            var ___result = RMInverseTransformVector_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 InverseTransformVector(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMInverseTransformVector_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public unsafe virtual void InverseTransformVectors(UnityEngine.Vector3* @vectors, System.Int32 @count, UnityEngine.Vector3* @transformedVectors, System.Int32 @transformedCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@vectors, typeof(UnityEngine.Vector3)), @count, Pointer.Box(@transformedVectors, typeof(UnityEngine.Vector3)), @transformedCount};
            var ___result = RMInverseTransformVectors_Vector3Pointer_Int32_Vector3Pointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InverseTransformVectors(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @vectors, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @transformedVectors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectors.Value, @transformedVectors.Value};
            var ___result = RMInverseTransformVectors_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InverseTransformVectors(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @vectors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectors.Value};
            var ___result = RMInverseTransformVectors_Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMTransformPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 TransformPoint(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMTransformPoint_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public unsafe virtual void TransformPoints(UnityEngine.Vector3* @positions, System.Int32 @count, UnityEngine.Vector3* @transformedPositions, System.Int32 @transformedCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@positions, typeof(UnityEngine.Vector3)), @count, Pointer.Box(@transformedPositions, typeof(UnityEngine.Vector3)), @transformedCount};
            var ___result = RMTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransformPoints(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @positions, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @transformedPositions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@positions.Value, @transformedPositions.Value};
            var ___result = RMTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransformPoints(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @positions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@positions.Value};
            var ___result = RMTransformPoints_Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMInverseTransformPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 InverseTransformPoint(System.Single @x, System.Single @y, System.Single @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMInverseTransformPoint_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public unsafe virtual void InverseTransformPoints(UnityEngine.Vector3* @positions, System.Int32 @count, UnityEngine.Vector3* @transformedPositions, System.Int32 @transformedCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@positions, typeof(UnityEngine.Vector3)), @count, Pointer.Box(@transformedPositions, typeof(UnityEngine.Vector3)), @transformedCount};
            var ___result = RMInverseTransformPoints_Vector3Pointer_Int32_Vector3Pointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InverseTransformPoints(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @positions, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @transformedPositions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@positions.Value, @transformedPositions.Value};
            var ___result = RMInverseTransformPoints_ReadOnlySpan_d_Vector3_p__Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InverseTransformPoints(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @positions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@positions.Value};
            var ___result = RMInverseTransformPoints_Span_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Transform GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual void DetachChildren()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDetachChildren.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAsFirstSibling()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetAsFirstSibling.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAsLastSibling()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetAsLastSibling.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSiblingIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSetSiblingIndex_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveAfterSibling(UnityEngine.Transform @transform, System.Boolean @notifyEditorAndMarkDirty)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transform, @notifyEditorAndMarkDirty};
            var ___result = RMMoveAfterSibling_Transform_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSiblingIndex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSiblingIndex.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform @transform, System.String @path, System.Boolean @isActiveOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transform, @path, @isActiveOnly};
            var ___result = RMFindRelativeTransformWithPath_Transform_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual UnityEngine.Transform Find(System.String @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RMFind_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual void SendTransformChangedScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendTransformChangedScale.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsChildOf(UnityEngine.Transform @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent};
            var ___result = RMIsChildOf_Transform.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Transform FindChild(System.String @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RMFindChild_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void RotateAround(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotateAround_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RotateAroundLocal(UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotateAroundLocal_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Transform GetChild(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetChild_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual System.Int32 GetChildCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetChildCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_getHierarchyCapacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternal_getHierarchyCapacity.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void internal_setHierarchyCapacity(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMinternal_setHierarchyCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 internal_getHierarchyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMinternal_getHierarchyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsNonUniformScaleTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNonUniformScaleTransform.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetConstrainProportionsScale(System.Boolean @isLinked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isLinked};
            var ___result = RMSetConstrainProportionsScale_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsConstrainProportionsScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsConstrainProportionsScale.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void get_position_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_position_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_position_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_position_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_localPosition_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_localPosition_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_localPosition_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_localPosition_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void GetLocalEulerAngles_Injected(Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder @order, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@order.Value, @ret};
            var ___result = RMGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void SetLocalEulerAngles_Injected(ref UnityEngine.Vector3 @euler, Hvak.Editor.Refleaction.RUnityEngine.RRotationOrder @order)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler, @order.Value};
            var ___result = RMSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder.Invoke(___genericsType, ___parameters);
			@euler = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void SetLocalEulerHint_Injected(ref UnityEngine.Vector3 @euler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@euler};
            var ___result = RMSetLocalEulerHint_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@euler = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_rotation_Injected(out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_rotation_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void set_rotation_Injected(ref UnityEngine.Quaternion @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_rotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void get_localRotation_Injected(out UnityEngine.Quaternion @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_localRotation_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void set_localRotation_Injected(ref UnityEngine.Quaternion @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_localRotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void get_localScale_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_localScale_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_localScale_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_localScale_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_worldToLocalMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_worldToLocalMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_localToWorldMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_localToWorldMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void SetPositionAndRotation_Injected(ref UnityEngine.Vector3 @position, ref UnityEngine.Quaternion @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RMSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@rotation = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public virtual void SetLocalPositionAndRotation_Injected(ref UnityEngine.Vector3 @localPosition, ref UnityEngine.Quaternion @localRotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @localRotation};
            var ___result = RMSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			@localPosition = (UnityEngine.Vector3)___parameters[0];
			@localRotation = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public virtual void RotateAroundInternal_Injected(ref UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotateAroundInternal_Injected_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void Internal_LookAt_Injected(ref UnityEngine.Vector3 @worldPosition, ref UnityEngine.Vector3 @worldUp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition, @worldUp};
            var ___result = RMInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@worldPosition = (UnityEngine.Vector3)___parameters[0];
			@worldUp = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void TransformDirection_Injected(ref UnityEngine.Vector3 @direction, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @ret};
            var ___result = RMTransformDirection_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@direction = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void InverseTransformDirection_Injected(ref UnityEngine.Vector3 @direction, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @ret};
            var ___result = RMInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@direction = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void TransformVector_Injected(ref UnityEngine.Vector3 @vector, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @ret};
            var ___result = RMTransformVector_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@vector = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void InverseTransformVector_Injected(ref UnityEngine.Vector3 @vector, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vector, @ret};
            var ___result = RMInverseTransformVector_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@vector = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void TransformPoint_Injected(ref UnityEngine.Vector3 @position, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RMTransformPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void InverseTransformPoint_Injected(ref UnityEngine.Vector3 @position, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RMInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void get_lossyScale_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_lossyScale_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void RotateAround_Injected(ref UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotateAround_Injected_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void RotateAroundLocal_Injected(ref UnityEngine.Vector3 @axis, System.Single @angle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@axis, @angle};
            var ___result = RMRotateAroundLocal_Injected_Ref_Vector3_Single.Invoke(___genericsType, ___parameters);
			@axis = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual UnityEngine.Component GetComponent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void GetComponentFastPath(System.Type @type, System.IntPtr @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RMGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryGetComponent(System.Type @type, out UnityEngine.Component @component)
        {
			@component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RMTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			@component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetComponent<T>(out T @component)
        {
			@component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RMTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			@component = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @result)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @result};
            var ___result = RMGetComponentsInChildren_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentsInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RMGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInParent<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RMGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual void GetComponents(System.Type @type, System.Collections.Generic.List<UnityEngine.Component> @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RMGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetComponents<T>(System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RMGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean CompareTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendMessageUpwards(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RMSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RMSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RMSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RMSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, System.Object @parameter, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RMBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, System.Object @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RMBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
