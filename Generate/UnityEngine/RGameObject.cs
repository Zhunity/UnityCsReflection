using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GameObject
	/// </summary>
    public partial class RGameObject : RMember //
    {

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
		/// Int32 layer
		/// </summary>
		protected RProperty r_layer;
		public virtual RProperty Rlayer
		{
			get
			{
				if(r_layer == null)
				{
					r_layer = new(this, "layer", -1);
					r_layer.SetBelong(this.instance);
				}
				return r_layer;
			}
		}

		/// <summary>
		/// Boolean active
		/// </summary>
		protected RProperty r_active;
		public virtual RProperty Ractive
		{
			get
			{
				if(r_active == null)
				{
					r_active = new(this, "active", -1);
					r_active.SetBelong(this.instance);
				}
				return r_active;
			}
		}

		/// <summary>
		/// Boolean activeSelf
		/// </summary>
		protected RProperty r_activeSelf;
		public virtual RProperty RactiveSelf
		{
			get
			{
				if(r_activeSelf == null)
				{
					r_activeSelf = new(this, "activeSelf", -1);
					r_activeSelf.SetBelong(this.instance);
				}
				return r_activeSelf;
			}
		}

		/// <summary>
		/// Boolean activeInHierarchy
		/// </summary>
		protected RProperty r_activeInHierarchy;
		public virtual RProperty RactiveInHierarchy
		{
			get
			{
				if(r_activeInHierarchy == null)
				{
					r_activeInHierarchy = new(this, "activeInHierarchy", -1);
					r_activeInHierarchy.SetBelong(this.instance);
				}
				return r_activeInHierarchy;
			}
		}

		/// <summary>
		/// Boolean isStatic
		/// </summary>
		protected RProperty r_isStatic;
		public virtual RProperty RisStatic
		{
			get
			{
				if(r_isStatic == null)
				{
					r_isStatic = new(this, "isStatic", -1);
					r_isStatic.SetBelong(this.instance);
				}
				return r_isStatic;
			}
		}

		/// <summary>
		/// Boolean isStaticBatchable
		/// </summary>
		protected RProperty r_isStaticBatchable;
		public virtual RProperty RisStaticBatchable
		{
			get
			{
				if(r_isStaticBatchable == null)
				{
					r_isStaticBatchable = new(this, "isStaticBatchable", -1);
					r_isStaticBatchable.SetBelong(this.instance);
				}
				return r_isStaticBatchable;
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
		/// UnityEngine.SceneManagement.Scene scene
		/// </summary>
		protected RUnityEngine.RSceneManagement.RScene r_scene;
		public virtual RUnityEngine.RSceneManagement.RScene Rscene
		{
			get
			{
				if(r_scene == null)
				{
					r_scene = new(this, "scene", -1);
					r_scene.SetBelong(this.instance);
				}
				return r_scene;
			}
		}

		/// <summary>
		/// UInt64 sceneCullingMask
		/// </summary>
		protected RProperty r_sceneCullingMask;
		public virtual RProperty RsceneCullingMask
		{
			get
			{
				if(r_sceneCullingMask == null)
				{
					r_sceneCullingMask = new(this, "sceneCullingMask", -1);
					r_sceneCullingMask.SetBelong(this.instance);
				}
				return r_sceneCullingMask;
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
		/// UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType)
		/// </summary>
		protected static RMethod r_CreatePrimitive_PrimitiveType;
		public static RMethod RCreatePrimitive_PrimitiveType
		{
			get
			{
				if(r_CreatePrimitive_PrimitiveType == null)
				{
					r_CreatePrimitive_PrimitiveType = new(typeof(UnityEngine.GameObject), "CreatePrimitive", 0, typeof(UnityEngine.PrimitiveType));
					r_CreatePrimitive_PrimitiveType.SetBelong(null);
				}
				return r_CreatePrimitive_PrimitiveType;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_GetComponent_GT;
		public virtual RMethod RGetComponent_GT
		{
			get
			{
				if(r_GetComponent_GT == null)
				{
					r_GetComponent_GT = new(this, "GetComponent", 1);
					r_GetComponent_GT.SetBelong(this.instance);
				}
				return r_GetComponent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_GetComponent_Type;
		public virtual RMethod RGetComponent_Type
		{
			get
			{
				if(r_GetComponent_Type == null)
				{
					r_GetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
					r_GetComponent_Type.SetBelong(this.instance);
				}
				return r_GetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_GetComponentFastPath_Type_IntPtr;
		public virtual RMethod RGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_GetComponentFastPath_Type_IntPtr == null)
				{
					r_GetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_GetComponentFastPath_Type_IntPtr.SetBelong(this.instance);
				}
				return r_GetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentByName(System.String)
		/// </summary>
		protected RMethod r_GetComponentByName_String;
		public virtual RMethod RGetComponentByName_String
		{
			get
			{
				if(r_GetComponentByName_String == null)
				{
					r_GetComponentByName_String = new(this, "GetComponentByName", 0, typeof(System.String));
					r_GetComponentByName_String.SetBelong(this.instance);
				}
				return r_GetComponentByName_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_GetComponent_String;
		public virtual RMethod RGetComponent_String
		{
			get
			{
				if(r_GetComponent_String == null)
				{
					r_GetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
					r_GetComponent_String.SetBelong(this.instance);
				}
				return r_GetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_GetComponentInChildren_Type_Boolean;
		public virtual RMethod RGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_GetComponentInChildren_Type_Boolean == null)
				{
					r_GetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetComponentInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_GetComponentInChildren_Type;
		public virtual RMethod RGetComponentInChildren_Type
		{
			get
			{
				if(r_GetComponentInChildren_Type == null)
				{
					r_GetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
					r_GetComponentInChildren_Type.SetBelong(this.instance);
				}
				return r_GetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_GetComponentInChildren_GT;
		public virtual RMethod RGetComponentInChildren_GT
		{
			get
			{
				if(r_GetComponentInChildren_GT == null)
				{
					r_GetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
					r_GetComponentInChildren_GT.SetBelong(this.instance);
				}
				return r_GetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_GetComponentInChildren_GT_Boolean;
		public virtual RMethod RGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_GetComponentInChildren_GT_Boolean == null)
				{
					r_GetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
					r_GetComponentInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_GetComponentInParent_Type_Boolean;
		public virtual RMethod RGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_GetComponentInParent_Type_Boolean == null)
				{
					r_GetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetComponentInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_GetComponentInParent_Type;
		public virtual RMethod RGetComponentInParent_Type
		{
			get
			{
				if(r_GetComponentInParent_Type == null)
				{
					r_GetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
					r_GetComponentInParent_Type.SetBelong(this.instance);
				}
				return r_GetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_GetComponentInParent_GT;
		public virtual RMethod RGetComponentInParent_GT
		{
			get
			{
				if(r_GetComponentInParent_GT == null)
				{
					r_GetComponentInParent_GT = new(this, "GetComponentInParent", 1);
					r_GetComponentInParent_GT.SetBelong(this.instance);
				}
				return r_GetComponentInParent_GT;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_GetComponentInParent_GT_Boolean;
		public virtual RMethod RGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_GetComponentInParent_GT_Boolean == null)
				{
					r_GetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
					r_GetComponentInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// System.Array GetComponentsInternal(System.Type, Boolean, Boolean, Boolean, Boolean, System.Object)
		/// </summary>
		protected RMethod r_GetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object;
		public virtual RMethod RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object
		{
			get
			{
				if(r_GetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object == null)
				{
					r_GetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object = new(this, "GetComponentsInternal", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Object));
					r_GetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object.SetBelong(this.instance);
				}
				return r_GetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_GetComponents_Type;
		public virtual RMethod RGetComponents_Type
		{
			get
			{
				if(r_GetComponents_Type == null)
				{
					r_GetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
					r_GetComponents_Type.SetBelong(this.instance);
				}
				return r_GetComponents_Type;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_GetComponents_GT;
		public virtual RMethod RGetComponents_GT
		{
			get
			{
				if(r_GetComponents_GT == null)
				{
					r_GetComponents_GT = new(this, "GetComponents", 1);
					r_GetComponents_GT.SetBelong(this.instance);
				}
				return r_GetComponents_GT;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_GetComponents_Type_List_d_Component_p_;
		public virtual RMethod RGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_GetComponents_Type_List_d_Component_p_ == null)
				{
					r_GetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
					r_GetComponents_Type_List_d_Component_p_.SetBelong(this.instance);
				}
				return r_GetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_GetComponents_GT_List_d_T_p_;
		public virtual RMethod RGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_GetComponents_GT_List_d_T_p_ == null)
				{
					r_GetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_GetComponents_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_GetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_GetComponentsInChildren_Type;
		public virtual RMethod RGetComponentsInChildren_Type
		{
			get
			{
				if(r_GetComponentsInChildren_Type == null)
				{
					r_GetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
					r_GetComponentsInChildren_Type.SetBelong(this.instance);
				}
				return r_GetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_GetComponentsInChildren_Type_Boolean;
		public virtual RMethod RGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_GetComponentsInChildren_Type_Boolean == null)
				{
					r_GetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetComponentsInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_GetComponentsInChildren_GT_Boolean;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_GetComponentsInChildren_GT_Boolean == null)
				{
					r_GetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
					r_GetComponentsInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_GetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_GetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_GetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_GetComponentsInChildren_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_GetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_GetComponentsInChildren_GT;
		public virtual RMethod RGetComponentsInChildren_GT
		{
			get
			{
				if(r_GetComponentsInChildren_GT == null)
				{
					r_GetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
					r_GetComponentsInChildren_GT.SetBelong(this.instance);
				}
				return r_GetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_GetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_GetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_GetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_GetComponentsInChildren_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_GetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_GetComponentsInParent_Type;
		public virtual RMethod RGetComponentsInParent_Type
		{
			get
			{
				if(r_GetComponentsInParent_Type == null)
				{
					r_GetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
					r_GetComponentsInParent_Type.SetBelong(this.instance);
				}
				return r_GetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_GetComponentsInParent_Type_Boolean;
		public virtual RMethod RGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_GetComponentsInParent_Type_Boolean == null)
				{
					r_GetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetComponentsInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_GetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_GetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_GetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_GetComponentsInParent_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_GetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_GetComponentsInParent_GT_Boolean;
		public virtual RMethod RGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_GetComponentsInParent_GT_Boolean == null)
				{
					r_GetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
					r_GetComponentsInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_GetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_GetComponentsInParent_GT;
		public virtual RMethod RGetComponentsInParent_GT
		{
			get
			{
				if(r_GetComponentsInParent_GT == null)
				{
					r_GetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
					r_GetComponentsInParent_GT.SetBelong(this.instance);
				}
				return r_GetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_TryGetComponent_GT_Out_T;
		public virtual RMethod RTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_TryGetComponent_GT_Out_T == null)
				{
					r_TryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_TryGetComponent_GT_Out_T.SetBelong(this.instance);
				}
				return r_TryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_TryGetComponent_Type_Out_Component;
		public virtual RMethod RTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_TryGetComponent_Type_Out_Component == null)
				{
					r_TryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
					r_TryGetComponent_Type_Out_Component.SetBelong(this.instance);
				}
				return r_TryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// UnityEngine.Component TryGetComponentInternal(System.Type)
		/// </summary>
		protected RMethod r_TryGetComponentInternal_Type;
		public virtual RMethod RTryGetComponentInternal_Type
		{
			get
			{
				if(r_TryGetComponentInternal_Type == null)
				{
					r_TryGetComponentInternal_Type = new(this, "TryGetComponentInternal", 0, typeof(System.Type));
					r_TryGetComponentInternal_Type.SetBelong(this.instance);
				}
				return r_TryGetComponentInternal_Type;
			}
		}

		/// <summary>
		/// Void TryGetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_TryGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RTryGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_TryGetComponentFastPath_Type_IntPtr == null)
				{
					r_TryGetComponentFastPath_Type_IntPtr = new(this, "TryGetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_TryGetComponentFastPath_Type_IntPtr.SetBelong(this.instance);
				}
				return r_TryGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject FindWithTag(System.String)
		/// </summary>
		protected static RMethod r_FindWithTag_String;
		public static RMethod RFindWithTag_String
		{
			get
			{
				if(r_FindWithTag_String == null)
				{
					r_FindWithTag_String = new(typeof(UnityEngine.GameObject), "FindWithTag", 0, typeof(System.String));
					r_FindWithTag_String.SetBelong(null);
				}
				return r_FindWithTag_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_SendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_SendMessageUpwards_String_SendMessageOptions == null)
				{
					r_SendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_SendMessageUpwards_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_SendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_SendMessage_String_SendMessageOptions;
		public virtual RMethod RSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_SendMessage_String_SendMessageOptions == null)
				{
					r_SendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_SendMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_SendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_BroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_BroadcastMessage_String_SendMessageOptions == null)
				{
					r_BroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_BroadcastMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_BroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Component AddComponentInternal(System.String)
		/// </summary>
		protected RMethod r_AddComponentInternal_String;
		public virtual RMethod RAddComponentInternal_String
		{
			get
			{
				if(r_AddComponentInternal_String == null)
				{
					r_AddComponentInternal_String = new(this, "AddComponentInternal", 0, typeof(System.String));
					r_AddComponentInternal_String.SetBelong(this.instance);
				}
				return r_AddComponentInternal_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component Internal_AddComponentWithType(System.Type)
		/// </summary>
		protected RMethod r_Internal_AddComponentWithType_Type;
		public virtual RMethod RInternal_AddComponentWithType_Type
		{
			get
			{
				if(r_Internal_AddComponentWithType_Type == null)
				{
					r_Internal_AddComponentWithType_Type = new(this, "Internal_AddComponentWithType", 0, typeof(System.Type));
					r_Internal_AddComponentWithType_Type.SetBelong(this.instance);
				}
				return r_Internal_AddComponentWithType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Component AddComponent(System.Type)
		/// </summary>
		protected RMethod r_AddComponent_Type;
		public virtual RMethod RAddComponent_Type
		{
			get
			{
				if(r_AddComponent_Type == null)
				{
					r_AddComponent_Type = new(this, "AddComponent", 0, typeof(System.Type));
					r_AddComponent_Type.SetBelong(this.instance);
				}
				return r_AddComponent_Type;
			}
		}

		/// <summary>
		/// T AddComponent[T]()
		/// </summary>
		protected RMethod r_AddComponent_GT;
		public virtual RMethod RAddComponent_GT
		{
			get
			{
				if(r_AddComponent_GT == null)
				{
					r_AddComponent_GT = new(this, "AddComponent", 1);
					r_AddComponent_GT.SetBelong(this.instance);
				}
				return r_AddComponent_GT;
			}
		}

		/// <summary>
		/// Void SetActive(Boolean)
		/// </summary>
		protected RMethod r_SetActive_Boolean;
		public virtual RMethod RSetActive_Boolean
		{
			get
			{
				if(r_SetActive_Boolean == null)
				{
					r_SetActive_Boolean = new(this, "SetActive", 0, typeof(System.Boolean));
					r_SetActive_Boolean.SetBelong(this.instance);
				}
				return r_SetActive_Boolean;
			}
		}

		/// <summary>
		/// Void SetActiveRecursively(Boolean)
		/// </summary>
		protected RMethod r_SetActiveRecursively_Boolean;
		public virtual RMethod RSetActiveRecursively_Boolean
		{
			get
			{
				if(r_SetActiveRecursively_Boolean == null)
				{
					r_SetActiveRecursively_Boolean = new(this, "SetActiveRecursively", 0, typeof(System.Boolean));
					r_SetActiveRecursively_Boolean.SetBelong(this.instance);
				}
				return r_SetActiveRecursively_Boolean;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_CompareTag_String;
		public virtual RMethod RCompareTag_String
		{
			get
			{
				if(r_CompareTag_String == null)
				{
					r_CompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
					r_CompareTag_String.SetBelong(this.instance);
				}
				return r_CompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject FindGameObjectWithTag(System.String)
		/// </summary>
		protected static RMethod r_FindGameObjectWithTag_String;
		public static RMethod RFindGameObjectWithTag_String
		{
			get
			{
				if(r_FindGameObjectWithTag_String == null)
				{
					r_FindGameObjectWithTag_String = new(typeof(UnityEngine.GameObject), "FindGameObjectWithTag", 0, typeof(System.String));
					r_FindGameObjectWithTag_String.SetBelong(null);
				}
				return r_FindGameObjectWithTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] FindGameObjectsWithTag(System.String)
		/// </summary>
		protected static RMethod r_FindGameObjectsWithTag_String;
		public static RMethod RFindGameObjectsWithTag_String
		{
			get
			{
				if(r_FindGameObjectsWithTag_String == null)
				{
					r_FindGameObjectsWithTag_String = new(typeof(UnityEngine.GameObject), "FindGameObjectsWithTag", 0, typeof(System.String));
					r_FindGameObjectsWithTag_String.SetBelong(null);
				}
				return r_FindGameObjectsWithTag_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_SendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_SendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_SendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_SendMessageUpwards_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_SendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_SendMessageUpwards_String_Object;
		public virtual RMethod RSendMessageUpwards_String_Object
		{
			get
			{
				if(r_SendMessageUpwards_String_Object == null)
				{
					r_SendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
					r_SendMessageUpwards_String_Object.SetBelong(this.instance);
				}
				return r_SendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_SendMessageUpwards_String;
		public virtual RMethod RSendMessageUpwards_String
		{
			get
			{
				if(r_SendMessageUpwards_String == null)
				{
					r_SendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
					r_SendMessageUpwards_String.SetBelong(this.instance);
				}
				return r_SendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_SendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_SendMessage_String_Object_SendMessageOptions == null)
				{
					r_SendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_SendMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_SendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_SendMessage_String_Object;
		public virtual RMethod RSendMessage_String_Object
		{
			get
			{
				if(r_SendMessage_String_Object == null)
				{
					r_SendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
					r_SendMessage_String_Object.SetBelong(this.instance);
				}
				return r_SendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_SendMessage_String;
		public virtual RMethod RSendMessage_String
		{
			get
			{
				if(r_SendMessage_String == null)
				{
					r_SendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
					r_SendMessage_String.SetBelong(this.instance);
				}
				return r_SendMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_BroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_BroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_BroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_BroadcastMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_BroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_BroadcastMessage_String_Object;
		public virtual RMethod RBroadcastMessage_String_Object
		{
			get
			{
				if(r_BroadcastMessage_String_Object == null)
				{
					r_BroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
					r_BroadcastMessage_String_Object.SetBelong(this.instance);
				}
				return r_BroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_BroadcastMessage_String;
		public virtual RMethod RBroadcastMessage_String
		{
			get
			{
				if(r_BroadcastMessage_String == null)
				{
					r_BroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
					r_BroadcastMessage_String.SetBelong(this.instance);
				}
				return r_BroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void Internal_CreateGameObject(UnityEngine.GameObject, System.String)
		/// </summary>
		protected static RMethod r_Internal_CreateGameObject_GameObject_String;
		public static RMethod RInternal_CreateGameObject_GameObject_String
		{
			get
			{
				if(r_Internal_CreateGameObject_GameObject_String == null)
				{
					r_Internal_CreateGameObject_GameObject_String = new(typeof(UnityEngine.GameObject), "Internal_CreateGameObject", 0, typeof(UnityEngine.GameObject), typeof(System.String));
					r_Internal_CreateGameObject_GameObject_String.SetBelong(null);
				}
				return r_Internal_CreateGameObject_GameObject_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject Find(System.String)
		/// </summary>
		protected static RMethod r_Find_String;
		public static RMethod RFind_String
		{
			get
			{
				if(r_Find_String == null)
				{
					r_Find_String = new(typeof(UnityEngine.GameObject), "Find", 0, typeof(System.String));
					r_Find_String.SetBelong(null);
				}
				return r_Find_String;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds CalculateBounds()
		/// </summary>
		protected RMethod r_CalculateBounds;
		public virtual RMethod RCalculateBounds
		{
			get
			{
				if(r_CalculateBounds == null)
				{
					r_CalculateBounds = new(this, "CalculateBounds", 0);
					r_CalculateBounds.SetBelong(this.instance);
				}
				return r_CalculateBounds;
			}
		}

		/// <summary>
		/// Int32 IsMarkedVisible()
		/// </summary>
		protected RMethod r_IsMarkedVisible;
		public virtual RMethod RIsMarkedVisible
		{
			get
			{
				if(r_IsMarkedVisible == null)
				{
					r_IsMarkedVisible = new(this, "IsMarkedVisible", 0);
					r_IsMarkedVisible.SetBelong(this.instance);
				}
				return r_IsMarkedVisible;
			}
		}

		/// <summary>
		/// Void SampleAnimation(UnityEngine.Object, Single)
		/// </summary>
		protected RMethod r_SampleAnimation_Object_Single;
		public virtual RMethod RSampleAnimation_Object_Single
		{
			get
			{
				if(r_SampleAnimation_Object_Single == null)
				{
					r_SampleAnimation_Object_Single = new(this, "SampleAnimation", 0, typeof(UnityEngine.Object), typeof(System.Single));
					r_SampleAnimation_Object_Single.SetBelong(this.instance);
				}
				return r_SampleAnimation_Object_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Component AddComponent(System.String)
		/// </summary>
		protected RMethod r_AddComponent_String;
		public virtual RMethod RAddComponent_String
		{
			get
			{
				if(r_AddComponent_String == null)
				{
					r_AddComponent_String = new(this, "AddComponent", 0, typeof(System.String));
					r_AddComponent_String.SetBelong(this.instance);
				}
				return r_AddComponent_String;
			}
		}

		/// <summary>
		/// Void PlayAnimation(UnityEngine.Object)
		/// </summary>
		protected RMethod r_PlayAnimation_Object;
		public virtual RMethod RPlayAnimation_Object
		{
			get
			{
				if(r_PlayAnimation_Object == null)
				{
					r_PlayAnimation_Object = new(this, "PlayAnimation", 0, typeof(UnityEngine.Object));
					r_PlayAnimation_Object.SetBelong(this.instance);
				}
				return r_PlayAnimation_Object;
			}
		}

		/// <summary>
		/// Void StopAnimation()
		/// </summary>
		protected RMethod r_StopAnimation;
		public virtual RMethod RStopAnimation
		{
			get
			{
				if(r_StopAnimation == null)
				{
					r_StopAnimation = new(this, "StopAnimation", 0);
					r_StopAnimation.SetBelong(this.instance);
				}
				return r_StopAnimation;
			}
		}

		/// <summary>
		/// Void get_scene_Injected(UnityEngine.SceneManagement.Scene ByRef)
		/// </summary>
		protected RMethod r_get_scene_Injected_Out_Scene;
		public virtual RMethod Rget_scene_Injected_Out_Scene
		{
			get
			{
				if(r_get_scene_Injected_Out_Scene == null)
				{
					r_get_scene_Injected_Out_Scene = new(this, "get_scene_Injected", 0, typeof(UnityEngine.SceneManagement.Scene).MakeByRefType());
					r_get_scene_Injected_Out_Scene.SetBelong(this.instance);
				}
				return r_get_scene_Injected_Out_Scene;
			}
		}

		/// <summary>
		/// Void CalculateBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_CalculateBounds_Injected_Out_Bounds;
		public virtual RMethod RCalculateBounds_Injected_Out_Bounds
		{
			get
			{
				if(r_CalculateBounds_Injected_Out_Bounds == null)
				{
					r_CalculateBounds_Injected_Out_Bounds = new(this, "CalculateBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_CalculateBounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_CalculateBounds_Injected_Out_Bounds;
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


        public RGameObject() : base("UnityEngine.GameObject")
        {
        }

        public RGameObject(System.Object instance) : base("UnityEngine.GameObject")
		{
            SetInstance(instance);
		}

        public RGameObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGameObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType @type)
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


        public virtual UnityEngine.Component GetComponent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void GetComponentFastPath(System.Type @type, System.IntPtr @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component GetComponentByName(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentByName_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @type)
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


        public virtual T GetComponentInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @type)
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


        public virtual T GetComponentInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Array GetComponentsInternal(System.Type @type, System.Boolean @useSearchTypeAsArrayReturnType, System.Boolean @recursive, System.Boolean @includeInactive, System.Boolean @reverse, System.Object @resultList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @useSearchTypeAsArrayReturnType, @recursive, @includeInactive, @reverse, @resultList};
            var ___result = RGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type @type)
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


        public virtual void GetComponents(System.Type @type, System.Collections.Generic.List<UnityEngine.Component> @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetComponents<T>(System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @results)
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


        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual void GetComponentsInParent<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean @includeInactive)
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


        public virtual System.Boolean TryGetComponent<T>(out T @component)
        {
			@component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			@component = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetComponent(System.Type @type, out UnityEngine.Component @component)
        {
			@component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			@component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component TryGetComponentInternal(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RTryGetComponentInternal_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void TryGetComponentFastPath(System.Type @type, System.IntPtr @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RTryGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GameObject FindWithTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RFindWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void SendMessageUpwards(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component AddComponentInternal(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RAddComponentInternal_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component Internal_AddComponentWithType(System.Type @componentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@componentType};
            var ___result = RInternal_AddComponentWithType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component AddComponent(System.Type @componentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@componentType};
            var ___result = RAddComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T AddComponent<T>() where T : UnityEngine.Component
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RAddComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void SetActive(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetActive_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActiveRecursively(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetActiveRecursively_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CompareTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.GameObject FindGameObjectWithTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RFindGameObjectWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public static UnityEngine.GameObject[] FindGameObjectsWithTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RFindGameObjectsWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject[])___result;
        }


        public virtual void SendMessageUpwards(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, System.Object @parameter, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, System.Object @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CreateGameObject(UnityEngine.GameObject @self, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @name};
            var ___result = RInternal_CreateGameObject_GameObject_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GameObject Find(System.String @name)
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


        public virtual void SampleAnimation(UnityEngine.Object @clip, System.Single @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @time};
            var ___result = RSampleAnimation_Object_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component AddComponent(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RAddComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void PlayAnimation(UnityEngine.Object @animation)
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


        public virtual void get_scene_Injected(out UnityEngine.SceneManagement.Scene @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_scene_Injected_Out_Scene.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
        }


        public virtual void CalculateBounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RCalculateBounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
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


        public virtual System.Boolean Equals(System.Object @other)
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
