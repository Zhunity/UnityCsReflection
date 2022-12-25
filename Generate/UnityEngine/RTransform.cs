using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Transform
	/// </summary>
    public partial class RTransform : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_localPosition;
		public virtual RUnityEngine.RVector3 RlocalPosition
		{
			get
			{
				if(r_localPosition == null)
				{
					r_localPosition = new(this, "localPosition", -1);
					r_localPosition.SetBelong(this.instance);
				}
				return r_localPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 eulerAngles
		/// </summary>
		protected RUnityEngine.RVector3 r_eulerAngles;
		public virtual RUnityEngine.RVector3 ReulerAngles
		{
			get
			{
				if(r_eulerAngles == null)
				{
					r_eulerAngles = new(this, "eulerAngles", -1);
					r_eulerAngles.SetBelong(this.instance);
				}
				return r_eulerAngles;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localEulerAngles
		/// </summary>
		protected RUnityEngine.RVector3 r_localEulerAngles;
		public virtual RUnityEngine.RVector3 RlocalEulerAngles
		{
			get
			{
				if(r_localEulerAngles == null)
				{
					r_localEulerAngles = new(this, "localEulerAngles", -1);
					r_localEulerAngles.SetBelong(this.instance);
				}
				return r_localEulerAngles;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 right
		/// </summary>
		protected RUnityEngine.RVector3 r_right;
		public virtual RUnityEngine.RVector3 Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right", -1);
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 up
		/// </summary>
		protected RUnityEngine.RVector3 r_up;
		public virtual RUnityEngine.RVector3 Rup
		{
			get
			{
				if(r_up == null)
				{
					r_up = new(this, "up", -1);
					r_up.SetBelong(this.instance);
				}
				return r_up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 forward
		/// </summary>
		protected RUnityEngine.RVector3 r_forward;
		public virtual RUnityEngine.RVector3 Rforward
		{
			get
			{
				if(r_forward == null)
				{
					r_forward = new(this, "forward", -1);
					r_forward.SetBelong(this.instance);
				}
				return r_forward;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_rotation;
		public virtual RUnityEngine.RQuaternion Rrotation
		{
			get
			{
				if(r_rotation == null)
				{
					r_rotation = new(this, "rotation", -1);
					r_rotation.SetBelong(this.instance);
				}
				return r_rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion localRotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_localRotation;
		public virtual RUnityEngine.RQuaternion RlocalRotation
		{
			get
			{
				if(r_localRotation == null)
				{
					r_localRotation = new(this, "localRotation", -1);
					r_localRotation.SetBelong(this.instance);
				}
				return r_localRotation;
			}
		}

		/// <summary>
		/// UnityEngine.RotationOrder rotationOrder
		/// </summary>
		protected RProperty r_rotationOrder;
		public virtual RProperty RrotationOrder
		{
			get
			{
				if(r_rotationOrder == null)
				{
					r_rotationOrder = new(this, "rotationOrder", -1);
					r_rotationOrder.SetBelong(this.instance);
				}
				return r_rotationOrder;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 localScale
		/// </summary>
		protected RUnityEngine.RVector3 r_localScale;
		public virtual RUnityEngine.RVector3 RlocalScale
		{
			get
			{
				if(r_localScale == null)
				{
					r_localScale = new(this, "localScale", -1);
					r_localScale.SetBelong(this.instance);
				}
				return r_localScale;
			}
		}

		/// <summary>
		/// UnityEngine.Transform parent
		/// </summary>
		protected RUnityEngine.RTransform r_parent;
		public virtual RUnityEngine.RTransform Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// UnityEngine.Transform parentInternal
		/// </summary>
		protected RUnityEngine.RTransform r_parentInternal;
		public virtual RUnityEngine.RTransform RparentInternal
		{
			get
			{
				if(r_parentInternal == null)
				{
					r_parentInternal = new(this, "parentInternal", -1);
					r_parentInternal.SetBelong(this.instance);
				}
				return r_parentInternal;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldToLocalMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldToLocalMatrix;
		public virtual RUnityEngine.RMatrix4x4 RworldToLocalMatrix
		{
			get
			{
				if(r_worldToLocalMatrix == null)
				{
					r_worldToLocalMatrix = new(this, "worldToLocalMatrix", -1);
					r_worldToLocalMatrix.SetBelong(this.instance);
				}
				return r_worldToLocalMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 localToWorldMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_localToWorldMatrix;
		public virtual RUnityEngine.RMatrix4x4 RlocalToWorldMatrix
		{
			get
			{
				if(r_localToWorldMatrix == null)
				{
					r_localToWorldMatrix = new(this, "localToWorldMatrix", -1);
					r_localToWorldMatrix.SetBelong(this.instance);
				}
				return r_localToWorldMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Transform root
		/// </summary>
		protected RUnityEngine.RTransform r_root;
		public virtual RUnityEngine.RTransform Rroot
		{
			get
			{
				if(r_root == null)
				{
					r_root = new(this, "root", -1);
					r_root.SetBelong(this.instance);
				}
				return r_root;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected RProperty r_childCount;
		public virtual RProperty RchildCount
		{
			get
			{
				if(r_childCount == null)
				{
					r_childCount = new(this, "childCount", -1);
					r_childCount.SetBelong(this.instance);
				}
				return r_childCount;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 lossyScale
		/// </summary>
		protected RUnityEngine.RVector3 r_lossyScale;
		public virtual RUnityEngine.RVector3 RlossyScale
		{
			get
			{
				if(r_lossyScale == null)
				{
					r_lossyScale = new(this, "lossyScale", -1);
					r_lossyScale.SetBelong(this.instance);
				}
				return r_lossyScale;
			}
		}

		/// <summary>
		/// Boolean hasChanged
		/// </summary>
		protected RProperty r_hasChanged;
		public virtual RProperty RhasChanged
		{
			get
			{
				if(r_hasChanged == null)
				{
					r_hasChanged = new(this, "hasChanged", -1);
					r_hasChanged.SetBelong(this.instance);
				}
				return r_hasChanged;
			}
		}

		/// <summary>
		/// Int32 hierarchyCapacity
		/// </summary>
		protected RProperty r_hierarchyCapacity;
		public virtual RProperty RhierarchyCapacity
		{
			get
			{
				if(r_hierarchyCapacity == null)
				{
					r_hierarchyCapacity = new(this, "hierarchyCapacity", -1);
					r_hierarchyCapacity.SetBelong(this.instance);
				}
				return r_hierarchyCapacity;
			}
		}

		/// <summary>
		/// Int32 hierarchyCount
		/// </summary>
		protected RProperty r_hierarchyCount;
		public virtual RProperty RhierarchyCount
		{
			get
			{
				if(r_hierarchyCount == null)
				{
					r_hierarchyCount = new(this, "hierarchyCount", -1);
					r_hierarchyCount.SetBelong(this.instance);
				}
				return r_hierarchyCount;
			}
		}

		/// <summary>
		/// Boolean constrainProportionsScale
		/// </summary>
		protected RProperty r_constrainProportionsScale;
		public virtual RProperty RconstrainProportionsScale
		{
			get
			{
				if(r_constrainProportionsScale == null)
				{
					r_constrainProportionsScale = new(this, "constrainProportionsScale", -1);
					r_constrainProportionsScale.SetBelong(this.instance);
				}
				return r_constrainProportionsScale;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_transform;
		public virtual RUnityEngine.RTransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_gameObject;
		public virtual RUnityEngine.RGameObject RgameObject
		{
			get
			{
				if(r_gameObject == null)
				{
					r_gameObject = new(this, "gameObject", -1);
					r_gameObject.SetBelong(this.instance);
				}
				return r_gameObject;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected RProperty r_tag;
		public virtual RProperty Rtag
		{
			get
			{
				if(r_tag == null)
				{
					r_tag = new(this, "tag", -1);
					r_tag.SetBelong(this.instance);
				}
				return r_tag;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody;
		public virtual RUnityEngine.RComponent Rrigidbody
		{
			get
			{
				if(r_rigidbody == null)
				{
					r_rigidbody = new(this, "rigidbody", -1);
					r_rigidbody.SetBelong(this.instance);
				}
				return r_rigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody2D
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody2D;
		public virtual RUnityEngine.RComponent Rrigidbody2D
		{
			get
			{
				if(r_rigidbody2D == null)
				{
					r_rigidbody2D = new(this, "rigidbody2D", -1);
					r_rigidbody2D.SetBelong(this.instance);
				}
				return r_rigidbody2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component camera
		/// </summary>
		protected RUnityEngine.RComponent r_camera;
		public virtual RUnityEngine.RComponent Rcamera
		{
			get
			{
				if(r_camera == null)
				{
					r_camera = new(this, "camera", -1);
					r_camera.SetBelong(this.instance);
				}
				return r_camera;
			}
		}

		/// <summary>
		/// UnityEngine.Component light
		/// </summary>
		protected RUnityEngine.RComponent r_light;
		public virtual RUnityEngine.RComponent Rlight
		{
			get
			{
				if(r_light == null)
				{
					r_light = new(this, "light", -1);
					r_light.SetBelong(this.instance);
				}
				return r_light;
			}
		}

		/// <summary>
		/// UnityEngine.Component animation
		/// </summary>
		protected RUnityEngine.RComponent r_animation;
		public virtual RUnityEngine.RComponent Ranimation
		{
			get
			{
				if(r_animation == null)
				{
					r_animation = new(this, "animation", -1);
					r_animation.SetBelong(this.instance);
				}
				return r_animation;
			}
		}

		/// <summary>
		/// UnityEngine.Component constantForce
		/// </summary>
		protected RUnityEngine.RComponent r_constantForce;
		public virtual RUnityEngine.RComponent RconstantForce
		{
			get
			{
				if(r_constantForce == null)
				{
					r_constantForce = new(this, "constantForce", -1);
					r_constantForce.SetBelong(this.instance);
				}
				return r_constantForce;
			}
		}

		/// <summary>
		/// UnityEngine.Component renderer
		/// </summary>
		protected RUnityEngine.RComponent r_renderer;
		public virtual RUnityEngine.RComponent Rrenderer
		{
			get
			{
				if(r_renderer == null)
				{
					r_renderer = new(this, "renderer", -1);
					r_renderer.SetBelong(this.instance);
				}
				return r_renderer;
			}
		}

		/// <summary>
		/// UnityEngine.Component audio
		/// </summary>
		protected RUnityEngine.RComponent r_audio;
		public virtual RUnityEngine.RComponent Raudio
		{
			get
			{
				if(r_audio == null)
				{
					r_audio = new(this, "audio", -1);
					r_audio.SetBelong(this.instance);
				}
				return r_audio;
			}
		}

		/// <summary>
		/// UnityEngine.Component networkView
		/// </summary>
		protected RUnityEngine.RComponent r_networkView;
		public virtual RUnityEngine.RComponent RnetworkView
		{
			get
			{
				if(r_networkView == null)
				{
					r_networkView = new(this, "networkView", -1);
					r_networkView.SetBelong(this.instance);
				}
				return r_networkView;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider
		/// </summary>
		protected RUnityEngine.RComponent r_collider;
		public virtual RUnityEngine.RComponent Rcollider
		{
			get
			{
				if(r_collider == null)
				{
					r_collider = new(this, "collider", -1);
					r_collider.SetBelong(this.instance);
				}
				return r_collider;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider2D
		/// </summary>
		protected RUnityEngine.RComponent r_collider2D;
		public virtual RUnityEngine.RComponent Rcollider2D
		{
			get
			{
				if(r_collider2D == null)
				{
					r_collider2D = new(this, "collider2D", -1);
					r_collider2D.SetBelong(this.instance);
				}
				return r_collider2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component hingeJoint
		/// </summary>
		protected RUnityEngine.RComponent r_hingeJoint;
		public virtual RUnityEngine.RComponent RhingeJoint
		{
			get
			{
				if(r_hingeJoint == null)
				{
					r_hingeJoint = new(this, "hingeJoint", -1);
					r_hingeJoint.SetBelong(this.instance);
				}
				return r_hingeJoint;
			}
		}

		/// <summary>
		/// UnityEngine.Component particleSystem
		/// </summary>
		protected RUnityEngine.RComponent r_particleSystem;
		public virtual RUnityEngine.RComponent RparticleSystem
		{
			get
			{
				if(r_particleSystem == null)
				{
					r_particleSystem = new(this, "particleSystem", -1);
					r_particleSystem.SetBelong(this.instance);
				}
				return r_particleSystem;
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
		/// UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_RGetLocalEulerAngles_RotationOrder;
		public virtual RMethod RGetLocalEulerAngles_RotationOrder
		{
			get
			{
				if(r_RGetLocalEulerAngles_RotationOrder == null)
				{
					r_RGetLocalEulerAngles_RotationOrder = new(this, "GetLocalEulerAngles", 0,  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
					r_RGetLocalEulerAngles_RotationOrder.SetBelong(this.instance);
				}
				return r_RGetLocalEulerAngles_RotationOrder;
			}
		}

		/// <summary>
		/// Void SetLocalEulerAngles(UnityEngine.Vector3, UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_RSetLocalEulerAngles_Vector3_RotationOrder;
		public virtual RMethod RSetLocalEulerAngles_Vector3_RotationOrder
		{
			get
			{
				if(r_RSetLocalEulerAngles_Vector3_RotationOrder == null)
				{
					r_RSetLocalEulerAngles_Vector3_RotationOrder = new(this, "SetLocalEulerAngles", 0, typeof(UnityEngine.Vector3),  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
					r_RSetLocalEulerAngles_Vector3_RotationOrder.SetBelong(this.instance);
				}
				return r_RSetLocalEulerAngles_Vector3_RotationOrder;
			}
		}

		/// <summary>
		/// Void SetLocalEulerHint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetLocalEulerHint_Vector3;
		public virtual RMethod RSetLocalEulerHint_Vector3
		{
			get
			{
				if(r_RSetLocalEulerHint_Vector3 == null)
				{
					r_RSetLocalEulerHint_Vector3 = new(this, "SetLocalEulerHint", 0, typeof(UnityEngine.Vector3));
					r_RSetLocalEulerHint_Vector3.SetBelong(this.instance);
				}
				return r_RSetLocalEulerHint_Vector3;
			}
		}

		/// <summary>
		/// Int32 GetRotationOrderInternal()
		/// </summary>
		protected RMethod r_RGetRotationOrderInternal;
		public virtual RMethod RGetRotationOrderInternal
		{
			get
			{
				if(r_RGetRotationOrderInternal == null)
				{
					r_RGetRotationOrderInternal = new(this, "GetRotationOrderInternal", 0);
					r_RGetRotationOrderInternal.SetBelong(this.instance);
				}
				return r_RGetRotationOrderInternal;
			}
		}

		/// <summary>
		/// Void SetRotationOrderInternal(UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_RSetRotationOrderInternal_RotationOrder;
		public virtual RMethod RSetRotationOrderInternal_RotationOrder
		{
			get
			{
				if(r_RSetRotationOrderInternal_RotationOrder == null)
				{
					r_RSetRotationOrderInternal_RotationOrder = new(this, "SetRotationOrderInternal", 0,  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
					r_RSetRotationOrderInternal_RotationOrder.SetBelong(this.instance);
				}
				return r_RSetRotationOrderInternal_RotationOrder;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetParent()
		/// </summary>
		protected RMethod r_RGetParent;
		public virtual RMethod RGetParent
		{
			get
			{
				if(r_RGetParent == null)
				{
					r_RGetParent = new(this, "GetParent", 0);
					r_RGetParent.SetBelong(this.instance);
				}
				return r_RGetParent;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RSetParent_Transform;
		public virtual RMethod RSetParent_Transform
		{
			get
			{
				if(r_RSetParent_Transform == null)
				{
					r_RSetParent_Transform = new(this, "SetParent", 0, typeof(UnityEngine.Transform));
					r_RSetParent_Transform.SetBelong(this.instance);
				}
				return r_RSetParent_Transform;
			}
		}

		/// <summary>
		/// Void SetParent(UnityEngine.Transform, Boolean)
		/// </summary>
		protected RMethod r_RSetParent_Transform_Boolean;
		public virtual RMethod RSetParent_Transform_Boolean
		{
			get
			{
				if(r_RSetParent_Transform_Boolean == null)
				{
					r_RSetParent_Transform_Boolean = new(this, "SetParent", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_RSetParent_Transform_Boolean.SetBelong(this.instance);
				}
				return r_RSetParent_Transform_Boolean;
			}
		}

		/// <summary>
		/// Void SetPositionAndRotation(UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_RSetPositionAndRotation_Vector3_Quaternion;
		public virtual RMethod RSetPositionAndRotation_Vector3_Quaternion
		{
			get
			{
				if(r_RSetPositionAndRotation_Vector3_Quaternion == null)
				{
					r_RSetPositionAndRotation_Vector3_Quaternion = new(this, "SetPositionAndRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_RSetPositionAndRotation_Vector3_Quaternion.SetBelong(this.instance);
				}
				return r_RSetPositionAndRotation_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// Void SetLocalPositionAndRotation(UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_RSetLocalPositionAndRotation_Vector3_Quaternion;
		public virtual RMethod RSetLocalPositionAndRotation_Vector3_Quaternion
		{
			get
			{
				if(r_RSetLocalPositionAndRotation_Vector3_Quaternion == null)
				{
					r_RSetLocalPositionAndRotation_Vector3_Quaternion = new(this, "SetLocalPositionAndRotation", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_RSetLocalPositionAndRotation_Vector3_Quaternion.SetBelong(this.instance);
				}
				return r_RSetLocalPositionAndRotation_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3, UnityEngine.Space)
		/// </summary>
		protected RMethod r_RTranslate_Vector3_Space;
		public virtual RMethod RTranslate_Vector3_Space
		{
			get
			{
				if(r_RTranslate_Vector3_Space == null)
				{
					r_RTranslate_Vector3_Space = new(this, "Translate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Space));
					r_RTranslate_Vector3_Space.SetBelong(this.instance);
				}
				return r_RTranslate_Vector3_Space;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RTranslate_Vector3;
		public virtual RMethod RTranslate_Vector3
		{
			get
			{
				if(r_RTranslate_Vector3 == null)
				{
					r_RTranslate_Vector3 = new(this, "Translate", 0, typeof(UnityEngine.Vector3));
					r_RTranslate_Vector3.SetBelong(this.instance);
				}
				return r_RTranslate_Vector3;
			}
		}

		/// <summary>
		/// Void Translate(Single, Single, Single, UnityEngine.Space)
		/// </summary>
		protected RMethod r_RTranslate_Single_Single_Single_Space;
		public virtual RMethod RTranslate_Single_Single_Single_Space
		{
			get
			{
				if(r_RTranslate_Single_Single_Single_Space == null)
				{
					r_RTranslate_Single_Single_Single_Space = new(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Space));
					r_RTranslate_Single_Single_Single_Space.SetBelong(this.instance);
				}
				return r_RTranslate_Single_Single_Single_Space;
			}
		}

		/// <summary>
		/// Void Translate(Single, Single, Single)
		/// </summary>
		protected RMethod r_RTranslate_Single_Single_Single;
		public virtual RMethod RTranslate_Single_Single_Single
		{
			get
			{
				if(r_RTranslate_Single_Single_Single == null)
				{
					r_RTranslate_Single_Single_Single = new(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RTranslate_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RTranslate_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3, UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RTranslate_Vector3_Transform;
		public virtual RMethod RTranslate_Vector3_Transform
		{
			get
			{
				if(r_RTranslate_Vector3_Transform == null)
				{
					r_RTranslate_Vector3_Transform = new(this, "Translate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Transform));
					r_RTranslate_Vector3_Transform.SetBelong(this.instance);
				}
				return r_RTranslate_Vector3_Transform;
			}
		}

		/// <summary>
		/// Void Translate(Single, Single, Single, UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RTranslate_Single_Single_Single_Transform;
		public virtual RMethod RTranslate_Single_Single_Single_Transform
		{
			get
			{
				if(r_RTranslate_Single_Single_Single_Transform == null)
				{
					r_RTranslate_Single_Single_Single_Transform = new(this, "Translate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Transform));
					r_RTranslate_Single_Single_Single_Transform.SetBelong(this.instance);
				}
				return r_RTranslate_Single_Single_Single_Transform;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3, UnityEngine.Space)
		/// </summary>
		protected RMethod r_RRotate_Vector3_Space;
		public virtual RMethod RRotate_Vector3_Space
		{
			get
			{
				if(r_RRotate_Vector3_Space == null)
				{
					r_RRotate_Vector3_Space = new(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Space));
					r_RRotate_Vector3_Space.SetBelong(this.instance);
				}
				return r_RRotate_Vector3_Space;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RRotate_Vector3;
		public virtual RMethod RRotate_Vector3
		{
			get
			{
				if(r_RRotate_Vector3 == null)
				{
					r_RRotate_Vector3 = new(this, "Rotate", 0, typeof(UnityEngine.Vector3));
					r_RRotate_Vector3.SetBelong(this.instance);
				}
				return r_RRotate_Vector3;
			}
		}

		/// <summary>
		/// Void Rotate(Single, Single, Single, UnityEngine.Space)
		/// </summary>
		protected RMethod r_RRotate_Single_Single_Single_Space;
		public virtual RMethod RRotate_Single_Single_Single_Space
		{
			get
			{
				if(r_RRotate_Single_Single_Single_Space == null)
				{
					r_RRotate_Single_Single_Single_Space = new(this, "Rotate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Space));
					r_RRotate_Single_Single_Single_Space.SetBelong(this.instance);
				}
				return r_RRotate_Single_Single_Single_Space;
			}
		}

		/// <summary>
		/// Void Rotate(Single, Single, Single)
		/// </summary>
		protected RMethod r_RRotate_Single_Single_Single;
		public virtual RMethod RRotate_Single_Single_Single
		{
			get
			{
				if(r_RRotate_Single_Single_Single == null)
				{
					r_RRotate_Single_Single_Single = new(this, "Rotate", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RRotate_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RRotate_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void RotateAroundInternal(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RRotateAroundInternal_Vector3_Single;
		public virtual RMethod RRotateAroundInternal_Vector3_Single
		{
			get
			{
				if(r_RRotateAroundInternal_Vector3_Single == null)
				{
					r_RRotateAroundInternal_Vector3_Single = new(this, "RotateAroundInternal", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RRotateAroundInternal_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAroundInternal_Vector3_Single;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3, Single, UnityEngine.Space)
		/// </summary>
		protected RMethod r_RRotate_Vector3_Single_Space;
		public virtual RMethod RRotate_Vector3_Single_Space
		{
			get
			{
				if(r_RRotate_Vector3_Single_Space == null)
				{
					r_RRotate_Vector3_Single_Space = new(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(UnityEngine.Space));
					r_RRotate_Vector3_Single_Space.SetBelong(this.instance);
				}
				return r_RRotate_Vector3_Single_Space;
			}
		}

		/// <summary>
		/// Void Rotate(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RRotate_Vector3_Single;
		public virtual RMethod RRotate_Vector3_Single
		{
			get
			{
				if(r_RRotate_Vector3_Single == null)
				{
					r_RRotate_Vector3_Single = new(this, "Rotate", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RRotate_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotate_Vector3_Single;
			}
		}

		/// <summary>
		/// Void RotateAround(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RRotateAround_Vector3_Vector3_Single;
		public virtual RMethod RRotateAround_Vector3_Vector3_Single
		{
			get
			{
				if(r_RRotateAround_Vector3_Vector3_Single == null)
				{
					r_RRotateAround_Vector3_Vector3_Single = new(this, "RotateAround", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RRotateAround_Vector3_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAround_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Transform, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RLookAt_Transform_Vector3;
		public virtual RMethod RLookAt_Transform_Vector3
		{
			get
			{
				if(r_RLookAt_Transform_Vector3 == null)
				{
					r_RLookAt_Transform_Vector3 = new(this, "LookAt", 0, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3));
					r_RLookAt_Transform_Vector3.SetBelong(this.instance);
				}
				return r_RLookAt_Transform_Vector3;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RLookAt_Transform;
		public virtual RMethod RLookAt_Transform
		{
			get
			{
				if(r_RLookAt_Transform == null)
				{
					r_RLookAt_Transform = new(this, "LookAt", 0, typeof(UnityEngine.Transform));
					r_RLookAt_Transform.SetBelong(this.instance);
				}
				return r_RLookAt_Transform;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RLookAt_Vector3_Vector3;
		public virtual RMethod RLookAt_Vector3_Vector3
		{
			get
			{
				if(r_RLookAt_Vector3_Vector3 == null)
				{
					r_RLookAt_Vector3_Vector3 = new(this, "LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RLookAt_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RLookAt_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void LookAt(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RLookAt_Vector3;
		public virtual RMethod RLookAt_Vector3
		{
			get
			{
				if(r_RLookAt_Vector3 == null)
				{
					r_RLookAt_Vector3 = new(this, "LookAt", 0, typeof(UnityEngine.Vector3));
					r_RLookAt_Vector3.SetBelong(this.instance);
				}
				return r_RLookAt_Vector3;
			}
		}

		/// <summary>
		/// Void Internal_LookAt(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RInternal_LookAt_Vector3_Vector3;
		public virtual RMethod RInternal_LookAt_Vector3_Vector3
		{
			get
			{
				if(r_RInternal_LookAt_Vector3_Vector3 == null)
				{
					r_RInternal_LookAt_Vector3_Vector3 = new(this, "Internal_LookAt", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RInternal_LookAt_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RInternal_LookAt_Vector3_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RTransformDirection_Vector3;
		public virtual RMethod RTransformDirection_Vector3
		{
			get
			{
				if(r_RTransformDirection_Vector3 == null)
				{
					r_RTransformDirection_Vector3 = new(this, "TransformDirection", 0, typeof(UnityEngine.Vector3));
					r_RTransformDirection_Vector3.SetBelong(this.instance);
				}
				return r_RTransformDirection_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformDirection(Single, Single, Single)
		/// </summary>
		protected RMethod r_RTransformDirection_Single_Single_Single;
		public virtual RMethod RTransformDirection_Single_Single_Single
		{
			get
			{
				if(r_RTransformDirection_Single_Single_Single == null)
				{
					r_RTransformDirection_Single_Single_Single = new(this, "TransformDirection", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RTransformDirection_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RTransformDirection_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RInverseTransformDirection_Vector3;
		public virtual RMethod RInverseTransformDirection_Vector3
		{
			get
			{
				if(r_RInverseTransformDirection_Vector3 == null)
				{
					r_RInverseTransformDirection_Vector3 = new(this, "InverseTransformDirection", 0, typeof(UnityEngine.Vector3));
					r_RInverseTransformDirection_Vector3.SetBelong(this.instance);
				}
				return r_RInverseTransformDirection_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformDirection(Single, Single, Single)
		/// </summary>
		protected RMethod r_RInverseTransformDirection_Single_Single_Single;
		public virtual RMethod RInverseTransformDirection_Single_Single_Single
		{
			get
			{
				if(r_RInverseTransformDirection_Single_Single_Single == null)
				{
					r_RInverseTransformDirection_Single_Single_Single = new(this, "InverseTransformDirection", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RInverseTransformDirection_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RInverseTransformDirection_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformVector(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RTransformVector_Vector3;
		public virtual RMethod RTransformVector_Vector3
		{
			get
			{
				if(r_RTransformVector_Vector3 == null)
				{
					r_RTransformVector_Vector3 = new(this, "TransformVector", 0, typeof(UnityEngine.Vector3));
					r_RTransformVector_Vector3.SetBelong(this.instance);
				}
				return r_RTransformVector_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformVector(Single, Single, Single)
		/// </summary>
		protected RMethod r_RTransformVector_Single_Single_Single;
		public virtual RMethod RTransformVector_Single_Single_Single
		{
			get
			{
				if(r_RTransformVector_Single_Single_Single == null)
				{
					r_RTransformVector_Single_Single_Single = new(this, "TransformVector", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RTransformVector_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RTransformVector_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RInverseTransformVector_Vector3;
		public virtual RMethod RInverseTransformVector_Vector3
		{
			get
			{
				if(r_RInverseTransformVector_Vector3 == null)
				{
					r_RInverseTransformVector_Vector3 = new(this, "InverseTransformVector", 0, typeof(UnityEngine.Vector3));
					r_RInverseTransformVector_Vector3.SetBelong(this.instance);
				}
				return r_RInverseTransformVector_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformVector(Single, Single, Single)
		/// </summary>
		protected RMethod r_RInverseTransformVector_Single_Single_Single;
		public virtual RMethod RInverseTransformVector_Single_Single_Single
		{
			get
			{
				if(r_RInverseTransformVector_Single_Single_Single == null)
				{
					r_RInverseTransformVector_Single_Single_Single = new(this, "InverseTransformVector", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RInverseTransformVector_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RInverseTransformVector_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RTransformPoint_Vector3;
		public virtual RMethod RTransformPoint_Vector3
		{
			get
			{
				if(r_RTransformPoint_Vector3 == null)
				{
					r_RTransformPoint_Vector3 = new(this, "TransformPoint", 0, typeof(UnityEngine.Vector3));
					r_RTransformPoint_Vector3.SetBelong(this.instance);
				}
				return r_RTransformPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 TransformPoint(Single, Single, Single)
		/// </summary>
		protected RMethod r_RTransformPoint_Single_Single_Single;
		public virtual RMethod RTransformPoint_Single_Single_Single
		{
			get
			{
				if(r_RTransformPoint_Single_Single_Single == null)
				{
					r_RTransformPoint_Single_Single_Single = new(this, "TransformPoint", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RTransformPoint_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RTransformPoint_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RInverseTransformPoint_Vector3;
		public virtual RMethod RInverseTransformPoint_Vector3
		{
			get
			{
				if(r_RInverseTransformPoint_Vector3 == null)
				{
					r_RInverseTransformPoint_Vector3 = new(this, "InverseTransformPoint", 0, typeof(UnityEngine.Vector3));
					r_RInverseTransformPoint_Vector3.SetBelong(this.instance);
				}
				return r_RInverseTransformPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 InverseTransformPoint(Single, Single, Single)
		/// </summary>
		protected RMethod r_RInverseTransformPoint_Single_Single_Single;
		public virtual RMethod RInverseTransformPoint_Single_Single_Single
		{
			get
			{
				if(r_RInverseTransformPoint_Single_Single_Single == null)
				{
					r_RInverseTransformPoint_Single_Single_Single = new(this, "InverseTransformPoint", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RInverseTransformPoint_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RInverseTransformPoint_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetRoot()
		/// </summary>
		protected RMethod r_RGetRoot;
		public virtual RMethod RGetRoot
		{
			get
			{
				if(r_RGetRoot == null)
				{
					r_RGetRoot = new(this, "GetRoot", 0);
					r_RGetRoot.SetBelong(this.instance);
				}
				return r_RGetRoot;
			}
		}

		/// <summary>
		/// Void DetachChildren()
		/// </summary>
		protected RMethod r_RDetachChildren;
		public virtual RMethod RDetachChildren
		{
			get
			{
				if(r_RDetachChildren == null)
				{
					r_RDetachChildren = new(this, "DetachChildren", 0);
					r_RDetachChildren.SetBelong(this.instance);
				}
				return r_RDetachChildren;
			}
		}

		/// <summary>
		/// Void SetAsFirstSibling()
		/// </summary>
		protected RMethod r_RSetAsFirstSibling;
		public virtual RMethod RSetAsFirstSibling
		{
			get
			{
				if(r_RSetAsFirstSibling == null)
				{
					r_RSetAsFirstSibling = new(this, "SetAsFirstSibling", 0);
					r_RSetAsFirstSibling.SetBelong(this.instance);
				}
				return r_RSetAsFirstSibling;
			}
		}

		/// <summary>
		/// Void SetAsLastSibling()
		/// </summary>
		protected RMethod r_RSetAsLastSibling;
		public virtual RMethod RSetAsLastSibling
		{
			get
			{
				if(r_RSetAsLastSibling == null)
				{
					r_RSetAsLastSibling = new(this, "SetAsLastSibling", 0);
					r_RSetAsLastSibling.SetBelong(this.instance);
				}
				return r_RSetAsLastSibling;
			}
		}

		/// <summary>
		/// Void SetSiblingIndex(Int32)
		/// </summary>
		protected RMethod r_RSetSiblingIndex_Int32;
		public virtual RMethod RSetSiblingIndex_Int32
		{
			get
			{
				if(r_RSetSiblingIndex_Int32 == null)
				{
					r_RSetSiblingIndex_Int32 = new(this, "SetSiblingIndex", 0, typeof(System.Int32));
					r_RSetSiblingIndex_Int32.SetBelong(this.instance);
				}
				return r_RSetSiblingIndex_Int32;
			}
		}

		/// <summary>
		/// Void MoveAfterSibling(UnityEngine.Transform, Boolean)
		/// </summary>
		protected RMethod r_RMoveAfterSibling_Transform_Boolean;
		public virtual RMethod RMoveAfterSibling_Transform_Boolean
		{
			get
			{
				if(r_RMoveAfterSibling_Transform_Boolean == null)
				{
					r_RMoveAfterSibling_Transform_Boolean = new(this, "MoveAfterSibling", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_RMoveAfterSibling_Transform_Boolean.SetBelong(this.instance);
				}
				return r_RMoveAfterSibling_Transform_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetSiblingIndex()
		/// </summary>
		protected RMethod r_RGetSiblingIndex;
		public virtual RMethod RGetSiblingIndex
		{
			get
			{
				if(r_RGetSiblingIndex == null)
				{
					r_RGetSiblingIndex = new(this, "GetSiblingIndex", 0);
					r_RGetSiblingIndex.SetBelong(this.instance);
				}
				return r_RGetSiblingIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RFindRelativeTransformWithPath_Transform_String_Boolean;
		public static RMethod RFindRelativeTransformWithPath_Transform_String_Boolean
		{
			get
			{
				if(r_RFindRelativeTransformWithPath_Transform_String_Boolean == null)
				{
					r_RFindRelativeTransformWithPath_Transform_String_Boolean = new(typeof(UnityEngine.Transform), "FindRelativeTransformWithPath", 0, typeof(UnityEngine.Transform), typeof(System.String), typeof(System.Boolean));
					r_RFindRelativeTransformWithPath_Transform_String_Boolean.SetBelong(null);
				}
				return r_RFindRelativeTransformWithPath_Transform_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Transform Find(System.String)
		/// </summary>
		protected RMethod r_RFind_String;
		public virtual RMethod RFind_String
		{
			get
			{
				if(r_RFind_String == null)
				{
					r_RFind_String = new(this, "Find", 0, typeof(System.String));
					r_RFind_String.SetBelong(this.instance);
				}
				return r_RFind_String;
			}
		}

		/// <summary>
		/// Void SendTransformChangedScale()
		/// </summary>
		protected RMethod r_RSendTransformChangedScale;
		public virtual RMethod RSendTransformChangedScale
		{
			get
			{
				if(r_RSendTransformChangedScale == null)
				{
					r_RSendTransformChangedScale = new(this, "SendTransformChangedScale", 0);
					r_RSendTransformChangedScale.SetBelong(this.instance);
				}
				return r_RSendTransformChangedScale;
			}
		}

		/// <summary>
		/// Boolean IsChildOf(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RIsChildOf_Transform;
		public virtual RMethod RIsChildOf_Transform
		{
			get
			{
				if(r_RIsChildOf_Transform == null)
				{
					r_RIsChildOf_Transform = new(this, "IsChildOf", 0, typeof(UnityEngine.Transform));
					r_RIsChildOf_Transform.SetBelong(this.instance);
				}
				return r_RIsChildOf_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Transform FindChild(System.String)
		/// </summary>
		protected RMethod r_RFindChild_String;
		public virtual RMethod RFindChild_String
		{
			get
			{
				if(r_RFindChild_String == null)
				{
					r_RFindChild_String = new(this, "FindChild", 0, typeof(System.String));
					r_RFindChild_String.SetBelong(this.instance);
				}
				return r_RFindChild_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// Void RotateAround(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RRotateAround_Vector3_Single;
		public virtual RMethod RRotateAround_Vector3_Single
		{
			get
			{
				if(r_RRotateAround_Vector3_Single == null)
				{
					r_RRotateAround_Vector3_Single = new(this, "RotateAround", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RRotateAround_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAround_Vector3_Single;
			}
		}

		/// <summary>
		/// Void RotateAroundLocal(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RRotateAroundLocal_Vector3_Single;
		public virtual RMethod RRotateAroundLocal_Vector3_Single
		{
			get
			{
				if(r_RRotateAroundLocal_Vector3_Single == null)
				{
					r_RRotateAroundLocal_Vector3_Single = new(this, "RotateAroundLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RRotateAroundLocal_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAroundLocal_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetChild(Int32)
		/// </summary>
		protected RMethod r_RGetChild_Int32;
		public virtual RMethod RGetChild_Int32
		{
			get
			{
				if(r_RGetChild_Int32 == null)
				{
					r_RGetChild_Int32 = new(this, "GetChild", 0, typeof(System.Int32));
					r_RGetChild_Int32.SetBelong(this.instance);
				}
				return r_RGetChild_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChildCount()
		/// </summary>
		protected RMethod r_RGetChildCount;
		public virtual RMethod RGetChildCount
		{
			get
			{
				if(r_RGetChildCount == null)
				{
					r_RGetChildCount = new(this, "GetChildCount", 0);
					r_RGetChildCount.SetBelong(this.instance);
				}
				return r_RGetChildCount;
			}
		}

		/// <summary>
		/// Int32 internal_getHierarchyCapacity()
		/// </summary>
		protected RMethod r_Rinternal_getHierarchyCapacity;
		public virtual RMethod Rinternal_getHierarchyCapacity
		{
			get
			{
				if(r_Rinternal_getHierarchyCapacity == null)
				{
					r_Rinternal_getHierarchyCapacity = new(this, "internal_getHierarchyCapacity", 0);
					r_Rinternal_getHierarchyCapacity.SetBelong(this.instance);
				}
				return r_Rinternal_getHierarchyCapacity;
			}
		}

		/// <summary>
		/// Void internal_setHierarchyCapacity(Int32)
		/// </summary>
		protected RMethod r_Rinternal_setHierarchyCapacity_Int32;
		public virtual RMethod Rinternal_setHierarchyCapacity_Int32
		{
			get
			{
				if(r_Rinternal_setHierarchyCapacity_Int32 == null)
				{
					r_Rinternal_setHierarchyCapacity_Int32 = new(this, "internal_setHierarchyCapacity", 0, typeof(System.Int32));
					r_Rinternal_setHierarchyCapacity_Int32.SetBelong(this.instance);
				}
				return r_Rinternal_setHierarchyCapacity_Int32;
			}
		}

		/// <summary>
		/// Int32 internal_getHierarchyCount()
		/// </summary>
		protected RMethod r_Rinternal_getHierarchyCount;
		public virtual RMethod Rinternal_getHierarchyCount
		{
			get
			{
				if(r_Rinternal_getHierarchyCount == null)
				{
					r_Rinternal_getHierarchyCount = new(this, "internal_getHierarchyCount", 0);
					r_Rinternal_getHierarchyCount.SetBelong(this.instance);
				}
				return r_Rinternal_getHierarchyCount;
			}
		}

		/// <summary>
		/// Boolean IsNonUniformScaleTransform()
		/// </summary>
		protected RMethod r_RIsNonUniformScaleTransform;
		public virtual RMethod RIsNonUniformScaleTransform
		{
			get
			{
				if(r_RIsNonUniformScaleTransform == null)
				{
					r_RIsNonUniformScaleTransform = new(this, "IsNonUniformScaleTransform", 0);
					r_RIsNonUniformScaleTransform.SetBelong(this.instance);
				}
				return r_RIsNonUniformScaleTransform;
			}
		}

		/// <summary>
		/// Void SetConstrainProportionsScale(Boolean)
		/// </summary>
		protected RMethod r_RSetConstrainProportionsScale_Boolean;
		public virtual RMethod RSetConstrainProportionsScale_Boolean
		{
			get
			{
				if(r_RSetConstrainProportionsScale_Boolean == null)
				{
					r_RSetConstrainProportionsScale_Boolean = new(this, "SetConstrainProportionsScale", 0, typeof(System.Boolean));
					r_RSetConstrainProportionsScale_Boolean.SetBelong(this.instance);
				}
				return r_RSetConstrainProportionsScale_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsConstrainProportionsScale()
		/// </summary>
		protected RMethod r_RIsConstrainProportionsScale;
		public virtual RMethod RIsConstrainProportionsScale
		{
			get
			{
				if(r_RIsConstrainProportionsScale == null)
				{
					r_RIsConstrainProportionsScale = new(this, "IsConstrainProportionsScale", 0);
					r_RIsConstrainProportionsScale.SetBelong(this.instance);
				}
				return r_RIsConstrainProportionsScale;
			}
		}

		/// <summary>
		/// Void get_position_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_position_Injected_Out_Vector3;
		public virtual RMethod Rget_position_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_position_Injected_Out_Vector3 == null)
				{
					r_Rget_position_Injected_Out_Vector3 = new(this, "get_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_position_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_position_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_position_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_position_Injected_Ref_Vector3;
		public virtual RMethod Rset_position_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_position_Injected_Ref_Vector3 == null)
				{
					r_Rset_position_Injected_Ref_Vector3 = new(this, "set_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_position_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_position_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_localPosition_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_localPosition_Injected_Out_Vector3;
		public virtual RMethod Rget_localPosition_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_localPosition_Injected_Out_Vector3 == null)
				{
					r_Rget_localPosition_Injected_Out_Vector3 = new(this, "get_localPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_localPosition_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_localPosition_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_localPosition_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_localPosition_Injected_Ref_Vector3;
		public virtual RMethod Rset_localPosition_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_localPosition_Injected_Ref_Vector3 == null)
				{
					r_Rset_localPosition_Injected_Ref_Vector3 = new(this, "set_localPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_localPosition_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_localPosition_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3;
		public virtual RMethod RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3
		{
			get
			{
				if(r_RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3 == null)
				{
					r_RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3 = new(this, "GetLocalEulerAngles_Injected", 0,  ReleactionUtils.GetType("UnityEngine.RotationOrder"), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetLocalEulerAngles_Injected_RotationOrder_Out_Vector3;
			}
		}

		/// <summary>
		/// Void SetLocalEulerAngles_Injected(UnityEngine.Vector3 ByRef, UnityEngine.RotationOrder)
		/// </summary>
		protected RMethod r_RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder;
		public virtual RMethod RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder
		{
			get
			{
				if(r_RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder == null)
				{
					r_RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder = new(this, "SetLocalEulerAngles_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.RotationOrder"));
					r_RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder.SetBelong(this.instance);
				}
				return r_RSetLocalEulerAngles_Injected_Ref_Vector3_RotationOrder;
			}
		}

		/// <summary>
		/// Void SetLocalEulerHint_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RSetLocalEulerHint_Injected_Ref_Vector3;
		public virtual RMethod RSetLocalEulerHint_Injected_Ref_Vector3
		{
			get
			{
				if(r_RSetLocalEulerHint_Injected_Ref_Vector3 == null)
				{
					r_RSetLocalEulerHint_Injected_Ref_Vector3 = new(this, "SetLocalEulerHint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_RSetLocalEulerHint_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_RSetLocalEulerHint_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_rotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rget_rotation_Injected_Out_Quaternion;
		public virtual RMethod Rget_rotation_Injected_Out_Quaternion
		{
			get
			{
				if(r_Rget_rotation_Injected_Out_Quaternion == null)
				{
					r_Rget_rotation_Injected_Out_Quaternion = new(this, "get_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rget_rotation_Injected_Out_Quaternion.SetBelong(this.instance);
				}
				return r_Rget_rotation_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void set_rotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rset_rotation_Injected_Ref_Quaternion;
		public virtual RMethod Rset_rotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_Rset_rotation_Injected_Ref_Quaternion == null)
				{
					r_Rset_rotation_Injected_Ref_Quaternion = new(this, "set_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rset_rotation_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_Rset_rotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void get_localRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rget_localRotation_Injected_Out_Quaternion;
		public virtual RMethod Rget_localRotation_Injected_Out_Quaternion
		{
			get
			{
				if(r_Rget_localRotation_Injected_Out_Quaternion == null)
				{
					r_Rget_localRotation_Injected_Out_Quaternion = new(this, "get_localRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rget_localRotation_Injected_Out_Quaternion.SetBelong(this.instance);
				}
				return r_Rget_localRotation_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void set_localRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rset_localRotation_Injected_Ref_Quaternion;
		public virtual RMethod Rset_localRotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_Rset_localRotation_Injected_Ref_Quaternion == null)
				{
					r_Rset_localRotation_Injected_Ref_Quaternion = new(this, "set_localRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rset_localRotation_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_Rset_localRotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void get_localScale_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_localScale_Injected_Out_Vector3;
		public virtual RMethod Rget_localScale_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_localScale_Injected_Out_Vector3 == null)
				{
					r_Rget_localScale_Injected_Out_Vector3 = new(this, "get_localScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_localScale_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_localScale_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_localScale_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_localScale_Injected_Ref_Vector3;
		public virtual RMethod Rset_localScale_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_localScale_Injected_Ref_Vector3 == null)
				{
					r_Rset_localScale_Injected_Ref_Vector3 = new(this, "set_localScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_localScale_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_localScale_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Rget_worldToLocalMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_worldToLocalMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Rget_worldToLocalMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Rget_worldToLocalMatrix_Injected_Out_Matrix4x4 = new(this, "get_worldToLocalMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Rget_worldToLocalMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_Rget_worldToLocalMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Rget_localToWorldMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_localToWorldMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Rget_localToWorldMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Rget_localToWorldMatrix_Injected_Out_Matrix4x4 = new(this, "get_localToWorldMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Rget_localToWorldMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_Rget_localToWorldMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetPositionAndRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
		public virtual RMethod RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion == null)
				{
					r_RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion = new(this, "SetPositionAndRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_RSetPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void SetLocalPositionAndRotation_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
		public virtual RMethod RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion == null)
				{
					r_RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion = new(this, "SetLocalPositionAndRotation_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_RSetLocalPositionAndRotation_Injected_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void RotateAroundInternal_Injected(UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected RMethod r_RRotateAroundInternal_Injected_Ref_Vector3_Single;
		public virtual RMethod RRotateAroundInternal_Injected_Ref_Vector3_Single
		{
			get
			{
				if(r_RRotateAroundInternal_Injected_Ref_Vector3_Single == null)
				{
					r_RRotateAroundInternal_Injected_Ref_Vector3_Single = new(this, "RotateAroundInternal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
					r_RRotateAroundInternal_Injected_Ref_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAroundInternal_Injected_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// Void Internal_LookAt_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3;
		public virtual RMethod RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3
		{
			get
			{
				if(r_RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3 == null)
				{
					r_RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3 = new(this, "Internal_LookAt_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3.SetBelong(this.instance);
				}
				return r_RInternal_LookAt_Injected_Ref_Vector3_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void TransformDirection_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RTransformDirection_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RTransformDirection_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RTransformDirection_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RTransformDirection_Injected_Ref_Vector3_Out_Vector3 = new(this, "TransformDirection_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RTransformDirection_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RTransformDirection_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void InverseTransformDirection_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3 = new(this, "InverseTransformDirection_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RInverseTransformDirection_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void TransformVector_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RTransformVector_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RTransformVector_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RTransformVector_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RTransformVector_Injected_Ref_Vector3_Out_Vector3 = new(this, "TransformVector_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RTransformVector_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RTransformVector_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void InverseTransformVector_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3 = new(this, "InverseTransformVector_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RInverseTransformVector_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void TransformPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RTransformPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RTransformPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RTransformPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RTransformPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "TransformPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RTransformPoint_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RTransformPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void InverseTransformPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "InverseTransformPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RInverseTransformPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_lossyScale_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_lossyScale_Injected_Out_Vector3;
		public virtual RMethod Rget_lossyScale_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_lossyScale_Injected_Out_Vector3 == null)
				{
					r_Rget_lossyScale_Injected_Out_Vector3 = new(this, "get_lossyScale_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_lossyScale_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_lossyScale_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void RotateAround_Injected(UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected RMethod r_RRotateAround_Injected_Ref_Vector3_Single;
		public virtual RMethod RRotateAround_Injected_Ref_Vector3_Single
		{
			get
			{
				if(r_RRotateAround_Injected_Ref_Vector3_Single == null)
				{
					r_RRotateAround_Injected_Ref_Vector3_Single = new(this, "RotateAround_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
					r_RRotateAround_Injected_Ref_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAround_Injected_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// Void RotateAroundLocal_Injected(UnityEngine.Vector3 ByRef, Single)
		/// </summary>
		protected RMethod r_RRotateAroundLocal_Injected_Ref_Vector3_Single;
		public virtual RMethod RRotateAroundLocal_Injected_Ref_Vector3_Single
		{
			get
			{
				if(r_RRotateAroundLocal_Injected_Ref_Vector3_Single == null)
				{
					r_RRotateAroundLocal_Injected_Ref_Vector3_Single = new(this, "RotateAroundLocal_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single));
					r_RRotateAroundLocal_Injected_Ref_Vector3_Single.SetBelong(this.instance);
				}
				return r_RRotateAroundLocal_Injected_Ref_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponent_Type;
		public virtual RMethod RGetComponent_Type
		{
			get
			{
				if(r_RGetComponent_Type == null)
				{
					r_RGetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
					r_RGetComponent_Type.SetBelong(this.instance);
				}
				return r_RGetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_RGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_RGetComponentFastPath_Type_IntPtr == null)
				{
					r_RGetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_RGetComponentFastPath_Type_IntPtr.SetBelong(this.instance);
				}
				return r_RGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_RGetComponent_GT;
		public virtual RMethod RGetComponent_GT
		{
			get
			{
				if(r_RGetComponent_GT == null)
				{
					r_RGetComponent_GT = new(this, "GetComponent", 1);
					r_RGetComponent_GT.SetBelong(this.instance);
				}
				return r_RGetComponent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_Type_Out_Component;
		public virtual RMethod RTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_RTryGetComponent_Type_Out_Component == null)
				{
					r_RTryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
					r_RTryGetComponent_Type_Out_Component.SetBelong(this.instance);
				}
				return r_RTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_GT_Out_T;
		public virtual RMethod RTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_RTryGetComponent_GT_Out_T == null)
				{
					r_RTryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryGetComponent_GT_Out_T.SetBelong(this.instance);
				}
				return r_RTryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_RGetComponent_String;
		public virtual RMethod RGetComponent_String
		{
			get
			{
				if(r_RGetComponent_String == null)
				{
					r_RGetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
					r_RGetComponent_String.SetBelong(this.instance);
				}
				return r_RGetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type_Boolean;
		public virtual RMethod RGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_Type_Boolean == null)
				{
					r_RGetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type;
		public virtual RMethod RGetComponentInChildren_Type
		{
			get
			{
				if(r_RGetComponentInChildren_Type == null)
				{
					r_RGetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
					r_RGetComponentInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT_Boolean;
		public virtual RMethod RGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_GT_Boolean == null)
				{
					r_RGetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
					r_RGetComponentInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT;
		public virtual RMethod RGetComponentInChildren_GT
		{
			get
			{
				if(r_RGetComponentInChildren_GT == null)
				{
					r_RGetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
					r_RGetComponentInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type_Boolean;
		public virtual RMethod RGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_Type_Boolean == null)
				{
					r_RGetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type;
		public virtual RMethod RGetComponentsInChildren_Type
		{
			get
			{
				if(r_RGetComponentsInChildren_Type == null)
				{
					r_RGetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
					r_RGetComponentsInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean == null)
				{
					r_RGetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
					r_RGetComponentsInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT;
		public virtual RMethod RGetComponentsInChildren_GT
		{
			get
			{
				if(r_RGetComponentsInChildren_GT == null)
				{
					r_RGetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
					r_RGetComponentsInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type_Boolean;
		public virtual RMethod RGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_Type_Boolean == null)
				{
					r_RGetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type;
		public virtual RMethod RGetComponentInParent_Type
		{
			get
			{
				if(r_RGetComponentInParent_Type == null)
				{
					r_RGetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
					r_RGetComponentInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT_Boolean;
		public virtual RMethod RGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_GT_Boolean == null)
				{
					r_RGetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
					r_RGetComponentInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT;
		public virtual RMethod RGetComponentInParent_GT
		{
			get
			{
				if(r_RGetComponentInParent_GT == null)
				{
					r_RGetComponentInParent_GT = new(this, "GetComponentInParent", 1);
					r_RGetComponentInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type_Boolean;
		public virtual RMethod RGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_Type_Boolean == null)
				{
					r_RGetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type;
		public virtual RMethod RGetComponentsInParent_Type
		{
			get
			{
				if(r_RGetComponentsInParent_Type == null)
				{
					r_RGetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
					r_RGetComponentsInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean;
		public virtual RMethod RGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean == null)
				{
					r_RGetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
					r_RGetComponentsInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT;
		public virtual RMethod RGetComponentsInParent_GT
		{
			get
			{
				if(r_RGetComponentsInParent_GT == null)
				{
					r_RGetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
					r_RGetComponentsInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_RGetComponents_Type;
		public virtual RMethod RGetComponents_Type
		{
			get
			{
				if(r_RGetComponents_Type == null)
				{
					r_RGetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
					r_RGetComponents_Type.SetBelong(this.instance);
				}
				return r_RGetComponents_Type;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_RGetComponents_Type_List_d_Component_p_;
		public virtual RMethod RGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_RGetComponents_Type_List_d_Component_p_ == null)
				{
					r_RGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
					r_RGetComponents_Type_List_d_Component_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponents_GT_List_d_T_p_;
		public virtual RMethod RGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponents_GT_List_d_T_p_ == null)
				{
					r_RGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponents_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_RGetComponents_GT;
		public virtual RMethod RGetComponents_GT
		{
			get
			{
				if(r_RGetComponents_GT == null)
				{
					r_RGetComponents_GT = new(this, "GetComponents", 1);
					r_RGetComponents_GT.SetBelong(this.instance);
				}
				return r_RGetComponents_GT;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_RCompareTag_String;
		public virtual RMethod RCompareTag_String
		{
			get
			{
				if(r_RCompareTag_String == null)
				{
					r_RCompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
					r_RCompareTag_String.SetBelong(this.instance);
				}
				return r_RCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_RGetCoupledComponent;
		public virtual RMethod RGetCoupledComponent
		{
			get
			{
				if(r_RGetCoupledComponent == null)
				{
					r_RGetCoupledComponent = new(this, "GetCoupledComponent", 0);
					r_RGetCoupledComponent.SetBelong(this.instance);
				}
				return r_RGetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_RIsCoupledComponent;
		public virtual RMethod RIsCoupledComponent
		{
			get
			{
				if(r_RIsCoupledComponent == null)
				{
					r_RIsCoupledComponent = new(this, "IsCoupledComponent", 0);
					r_RIsCoupledComponent.SetBelong(this.instance);
				}
				return r_RIsCoupledComponent;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object;
		public virtual RMethod RSendMessageUpwards_String_Object
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object == null)
				{
					r_RSendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessageUpwards_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String;
		public virtual RMethod RSendMessageUpwards_String
		{
			get
			{
				if(r_RSendMessageUpwards_String == null)
				{
					r_RSendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
					r_RSendMessageUpwards_String.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object;
		public virtual RMethod RSendMessage_String_Object
		{
			get
			{
				if(r_RSendMessage_String_Object == null)
				{
					r_RSendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessage_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_RSendMessage_String;
		public virtual RMethod RSendMessage_String
		{
			get
			{
				if(r_RSendMessage_String == null)
				{
					r_RSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
					r_RSendMessage_String.SetBelong(this.instance);
				}
				return r_RSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_Object_SendMessageOptions == null)
				{
					r_RSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_SendMessageOptions;
		public virtual RMethod RSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_SendMessageOptions == null)
				{
					r_RSendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object;
		public virtual RMethod RBroadcastMessage_String_Object
		{
			get
			{
				if(r_RBroadcastMessage_String_Object == null)
				{
					r_RBroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
					r_RBroadcastMessage_String_Object.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String;
		public virtual RMethod RBroadcastMessage_String
		{
			get
			{
				if(r_RBroadcastMessage_String == null)
				{
					r_RBroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
					r_RBroadcastMessage_String.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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
