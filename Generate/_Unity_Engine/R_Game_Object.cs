
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GameObject
	/// </summary>
    public partial class RGameObject : RMember //
    {

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
					r_Ptransform.SetBelong(this.GetValue());
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// Int32 layer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Player;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlayer
		{
			get
			{
				if(r_Player == null)
				{
					r_Player = new(this, "layer", -1);
					r_Player.SetBelong(this.GetValue());
				}
				return r_Player;
			}
		}

		/// <summary>
		/// Boolean active
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pactive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPactive
		{
			get
			{
				if(r_Pactive == null)
				{
					r_Pactive = new(this, "active", -1);
					r_Pactive.SetBelong(this.GetValue());
				}
				return r_Pactive;
			}
		}

		/// <summary>
		/// Boolean activeSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PactiveSelf;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPactiveSelf
		{
			get
			{
				if(r_PactiveSelf == null)
				{
					r_PactiveSelf = new(this, "activeSelf", -1);
					r_PactiveSelf.SetBelong(this.GetValue());
				}
				return r_PactiveSelf;
			}
		}

		/// <summary>
		/// Boolean activeInHierarchy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PactiveInHierarchy;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPactiveInHierarchy
		{
			get
			{
				if(r_PactiveInHierarchy == null)
				{
					r_PactiveInHierarchy = new(this, "activeInHierarchy", -1);
					r_PactiveInHierarchy.SetBelong(this.GetValue());
				}
				return r_PactiveInHierarchy;
			}
		}

		/// <summary>
		/// Boolean isStatic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisStatic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisStatic
		{
			get
			{
				if(r_PisStatic == null)
				{
					r_PisStatic = new(this, "isStatic", -1);
					r_PisStatic.SetBelong(this.GetValue());
				}
				return r_PisStatic;
			}
		}

		/// <summary>
		/// Boolean isStaticBatchable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisStaticBatchable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisStaticBatchable
		{
			get
			{
				if(r_PisStaticBatchable == null)
				{
					r_PisStaticBatchable = new(this, "isStaticBatchable", -1);
					r_PisStaticBatchable.SetBelong(this.GetValue());
				}
				return r_PisStaticBatchable;
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
					r_Ptag.SetBelong(this.GetValue());
				}
				return r_Ptag;
			}
		}

		/// <summary>
		/// UnityEngine.SceneManagement.Scene scene
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement.RScene r_Pscene;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSceneManagement.RScene RPscene
		{
			get
			{
				if(r_Pscene == null)
				{
					r_Pscene = new(this, "scene", -1);
					r_Pscene.SetBelong(this.GetValue());
				}
				return r_Pscene;
			}
		}

		/// <summary>
		/// UInt64 sceneCullingMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PsceneCullingMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPsceneCullingMask
		{
			get
			{
				if(r_PsceneCullingMask == null)
				{
					r_PsceneCullingMask = new(this, "sceneCullingMask", -1);
					r_PsceneCullingMask.SetBelong(this.GetValue());
				}
				return r_PsceneCullingMask;
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
					r_PgameObject.SetBelong(this.GetValue());
				}
				return r_PgameObject;
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
					r_Prigidbody.SetBelong(this.GetValue());
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
					r_Prigidbody2D.SetBelong(this.GetValue());
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
					r_Pcamera.SetBelong(this.GetValue());
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
					r_Plight.SetBelong(this.GetValue());
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
					r_Panimation.SetBelong(this.GetValue());
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
					r_PconstantForce.SetBelong(this.GetValue());
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
					r_Prenderer.SetBelong(this.GetValue());
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
					r_Paudio.SetBelong(this.GetValue());
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
					r_PnetworkView.SetBelong(this.GetValue());
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
					r_Pcollider.SetBelong(this.GetValue());
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
					r_Pcollider2D.SetBelong(this.GetValue());
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
					r_PhingeJoint.SetBelong(this.GetValue());
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
					r_PparticleSystem.SetBelong(this.GetValue());
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
					r_Pname.SetBelong(this.GetValue());
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
					r_PhideFlags.SetBelong(this.GetValue());
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType)
		/// </summary>
		protected static RMethod r_MCreatePrimitive_PrimitiveType;
		public static RMethod RMCreatePrimitive_PrimitiveType
		{
			get
			{
				if(r_MCreatePrimitive_PrimitiveType == null)
				{
					r_MCreatePrimitive_PrimitiveType = new(typeof(UnityEngine.GameObject), "CreatePrimitive", 0, typeof(UnityEngine.PrimitiveType));
					r_MCreatePrimitive_PrimitiveType.SetBelong(null);
				}
				return r_MCreatePrimitive_PrimitiveType;
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
					r_MGetComponent_GT.SetBelong(this.GetValue());
				}
				return r_MGetComponent_GT;
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
					r_MGetComponent_Type.SetBelong(this.GetValue());
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
					r_MGetComponentFastPath_Type_IntPtr.SetBelong(this.GetValue());
				}
				return r_MGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentByName(System.String)
		/// </summary>
		protected RMethod r_MGetComponentByName_String;
		public virtual RMethod RMGetComponentByName_String
		{
			get
			{
				if(r_MGetComponentByName_String == null)
				{
					r_MGetComponentByName_String = new(this, "GetComponentByName", 0, typeof(System.String));
					r_MGetComponentByName_String.SetBelong(this.GetValue());
				}
				return r_MGetComponentByName_String;
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
					r_MGetComponent_String.SetBelong(this.GetValue());
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
					r_MGetComponentInChildren_Type_Boolean.SetBelong(this.GetValue());
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
					r_MGetComponentInChildren_Type.SetBelong(this.GetValue());
				}
				return r_MGetComponentInChildren_Type;
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
					r_MGetComponentInChildren_GT.SetBelong(this.GetValue());
				}
				return r_MGetComponentInChildren_GT;
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
					r_MGetComponentInChildren_GT_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetComponentInChildren_GT_Boolean;
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
					r_MGetComponentInParent_Type_Boolean.SetBelong(this.GetValue());
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
					r_MGetComponentInParent_Type.SetBelong(this.GetValue());
				}
				return r_MGetComponentInParent_Type;
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
					r_MGetComponentInParent_GT.SetBelong(this.GetValue());
				}
				return r_MGetComponentInParent_GT;
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
					r_MGetComponentInParent_GT_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// System.Array GetComponentsInternal(System.Type, Boolean, Boolean, Boolean, Boolean, System.Object)
		/// </summary>
		protected RMethod r_MGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object;
		public virtual RMethod RMGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object
		{
			get
			{
				if(r_MGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object == null)
				{
					r_MGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object = new(this, "GetComponentsInternal", 0, typeof(System.Type), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Object));
					r_MGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object;
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
					r_MGetComponents_Type.SetBelong(this.GetValue());
				}
				return r_MGetComponents_Type;
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
					r_MGetComponents_GT.SetBelong(this.GetValue());
				}
				return r_MGetComponents_GT;
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
					r_MGetComponents_Type_List_d_Component_p_.SetBelong(this.GetValue());
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
					r_MGetComponents_GT_List_d_T_p_.SetBelong(this.GetValue());
				}
				return r_MGetComponents_GT_List_d_T_p_;
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
					r_MGetComponentsInChildren_Type.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInChildren_Type;
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
					r_MGetComponentsInChildren_Type_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInChildren_Type_Boolean;
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
					r_MGetComponentsInChildren_GT_Boolean.SetBelong(this.GetValue());
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
					r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_.SetBelong(this.GetValue());
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
					r_MGetComponentsInChildren_GT.SetBelong(this.GetValue());
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
					r_MGetComponentsInChildren_GT_List_d_T_p_.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInChildren_GT_List_d_T_p_;
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
					r_MGetComponentsInParent_Type.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInParent_Type;
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
					r_MGetComponentsInParent_Type_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInParent_Type_Boolean;
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
					r_MGetComponentsInParent_GT_Boolean_List_d_T_p_.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInParent_GT_Boolean_List_d_T_p_;
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
					r_MGetComponentsInParent_GT_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInParent_GT_Boolean;
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
					r_MGetComponentsInParent_GT.SetBelong(this.GetValue());
				}
				return r_MGetComponentsInParent_GT;
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
					r_MTryGetComponent_GT_Out_T.SetBelong(this.GetValue());
				}
				return r_MTryGetComponent_GT_Out_T;
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
					r_MTryGetComponent_Type_Out_Component.SetBelong(this.GetValue());
				}
				return r_MTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// UnityEngine.Component TryGetComponentInternal(System.Type)
		/// </summary>
		protected RMethod r_MTryGetComponentInternal_Type;
		public virtual RMethod RMTryGetComponentInternal_Type
		{
			get
			{
				if(r_MTryGetComponentInternal_Type == null)
				{
					r_MTryGetComponentInternal_Type = new(this, "TryGetComponentInternal", 0, typeof(System.Type));
					r_MTryGetComponentInternal_Type.SetBelong(this.GetValue());
				}
				return r_MTryGetComponentInternal_Type;
			}
		}

		/// <summary>
		/// Void TryGetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_MTryGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RMTryGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_MTryGetComponentFastPath_Type_IntPtr == null)
				{
					r_MTryGetComponentFastPath_Type_IntPtr = new(this, "TryGetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_MTryGetComponentFastPath_Type_IntPtr.SetBelong(this.GetValue());
				}
				return r_MTryGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject FindWithTag(System.String)
		/// </summary>
		protected static RMethod r_MFindWithTag_String;
		public static RMethod RMFindWithTag_String
		{
			get
			{
				if(r_MFindWithTag_String == null)
				{
					r_MFindWithTag_String = new(typeof(UnityEngine.GameObject), "FindWithTag", 0, typeof(System.String));
					r_MFindWithTag_String.SetBelong(null);
				}
				return r_MFindWithTag_String;
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
					r_MSendMessageUpwards_String_SendMessageOptions.SetBelong(this.GetValue());
				}
				return r_MSendMessageUpwards_String_SendMessageOptions;
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
					r_MSendMessage_String_SendMessageOptions.SetBelong(this.GetValue());
				}
				return r_MSendMessage_String_SendMessageOptions;
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
					r_MBroadcastMessage_String_SendMessageOptions.SetBelong(this.GetValue());
				}
				return r_MBroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Component AddComponentInternal(System.String)
		/// </summary>
		protected RMethod r_MAddComponentInternal_String;
		public virtual RMethod RMAddComponentInternal_String
		{
			get
			{
				if(r_MAddComponentInternal_String == null)
				{
					r_MAddComponentInternal_String = new(this, "AddComponentInternal", 0, typeof(System.String));
					r_MAddComponentInternal_String.SetBelong(this.GetValue());
				}
				return r_MAddComponentInternal_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component Internal_AddComponentWithType(System.Type)
		/// </summary>
		protected RMethod r_MInternal_AddComponentWithType_Type;
		public virtual RMethod RMInternal_AddComponentWithType_Type
		{
			get
			{
				if(r_MInternal_AddComponentWithType_Type == null)
				{
					r_MInternal_AddComponentWithType_Type = new(this, "Internal_AddComponentWithType", 0, typeof(System.Type));
					r_MInternal_AddComponentWithType_Type.SetBelong(this.GetValue());
				}
				return r_MInternal_AddComponentWithType_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Component AddComponent(System.Type)
		/// </summary>
		protected RMethod r_MAddComponent_Type;
		public virtual RMethod RMAddComponent_Type
		{
			get
			{
				if(r_MAddComponent_Type == null)
				{
					r_MAddComponent_Type = new(this, "AddComponent", 0, typeof(System.Type));
					r_MAddComponent_Type.SetBelong(this.GetValue());
				}
				return r_MAddComponent_Type;
			}
		}

		/// <summary>
		/// T AddComponent[T]()
		/// </summary>
		protected RMethod r_MAddComponent_GT;
		public virtual RMethod RMAddComponent_GT
		{
			get
			{
				if(r_MAddComponent_GT == null)
				{
					r_MAddComponent_GT = new(this, "AddComponent", 1);
					r_MAddComponent_GT.SetBelong(this.GetValue());
				}
				return r_MAddComponent_GT;
			}
		}

		/// <summary>
		/// Void SetActive(Boolean)
		/// </summary>
		protected RMethod r_MSetActive_Boolean;
		public virtual RMethod RMSetActive_Boolean
		{
			get
			{
				if(r_MSetActive_Boolean == null)
				{
					r_MSetActive_Boolean = new(this, "SetActive", 0, typeof(System.Boolean));
					r_MSetActive_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetActive_Boolean;
			}
		}

		/// <summary>
		/// Void SetActiveRecursively(Boolean)
		/// </summary>
		protected RMethod r_MSetActiveRecursively_Boolean;
		public virtual RMethod RMSetActiveRecursively_Boolean
		{
			get
			{
				if(r_MSetActiveRecursively_Boolean == null)
				{
					r_MSetActiveRecursively_Boolean = new(this, "SetActiveRecursively", 0, typeof(System.Boolean));
					r_MSetActiveRecursively_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetActiveRecursively_Boolean;
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
					r_MCompareTag_String.SetBelong(this.GetValue());
				}
				return r_MCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject FindGameObjectWithTag(System.String)
		/// </summary>
		protected static RMethod r_MFindGameObjectWithTag_String;
		public static RMethod RMFindGameObjectWithTag_String
		{
			get
			{
				if(r_MFindGameObjectWithTag_String == null)
				{
					r_MFindGameObjectWithTag_String = new(typeof(UnityEngine.GameObject), "FindGameObjectWithTag", 0, typeof(System.String));
					r_MFindGameObjectWithTag_String.SetBelong(null);
				}
				return r_MFindGameObjectWithTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] FindGameObjectsWithTag(System.String)
		/// </summary>
		protected static RMethod r_MFindGameObjectsWithTag_String;
		public static RMethod RMFindGameObjectsWithTag_String
		{
			get
			{
				if(r_MFindGameObjectsWithTag_String == null)
				{
					r_MFindGameObjectsWithTag_String = new(typeof(UnityEngine.GameObject), "FindGameObjectsWithTag", 0, typeof(System.String));
					r_MFindGameObjectsWithTag_String.SetBelong(null);
				}
				return r_MFindGameObjectsWithTag_String;
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
					r_MSendMessageUpwards_String_Object_SendMessageOptions.SetBelong(this.GetValue());
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
					r_MSendMessageUpwards_String_Object.SetBelong(this.GetValue());
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
					r_MSendMessageUpwards_String.SetBelong(this.GetValue());
				}
				return r_MSendMessageUpwards_String;
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
					r_MSendMessage_String_Object_SendMessageOptions.SetBelong(this.GetValue());
				}
				return r_MSendMessage_String_Object_SendMessageOptions;
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
					r_MSendMessage_String_Object.SetBelong(this.GetValue());
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
					r_MSendMessage_String.SetBelong(this.GetValue());
				}
				return r_MSendMessage_String;
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
					r_MBroadcastMessage_String_Object_SendMessageOptions.SetBelong(this.GetValue());
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
					r_MBroadcastMessage_String_Object.SetBelong(this.GetValue());
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
					r_MBroadcastMessage_String.SetBelong(this.GetValue());
				}
				return r_MBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void Internal_CreateGameObject(UnityEngine.GameObject, System.String)
		/// </summary>
		protected static RMethod r_MInternal_CreateGameObject_GameObject_String;
		public static RMethod RMInternal_CreateGameObject_GameObject_String
		{
			get
			{
				if(r_MInternal_CreateGameObject_GameObject_String == null)
				{
					r_MInternal_CreateGameObject_GameObject_String = new(typeof(UnityEngine.GameObject), "Internal_CreateGameObject", 0, typeof(UnityEngine.GameObject), typeof(System.String));
					r_MInternal_CreateGameObject_GameObject_String.SetBelong(null);
				}
				return r_MInternal_CreateGameObject_GameObject_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject Find(System.String)
		/// </summary>
		protected static RMethod r_MFind_String;
		public static RMethod RMFind_String
		{
			get
			{
				if(r_MFind_String == null)
				{
					r_MFind_String = new(typeof(UnityEngine.GameObject), "Find", 0, typeof(System.String));
					r_MFind_String.SetBelong(null);
				}
				return r_MFind_String;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds CalculateBounds()
		/// </summary>
		protected RMethod r_MCalculateBounds;
		public virtual RMethod RMCalculateBounds
		{
			get
			{
				if(r_MCalculateBounds == null)
				{
					r_MCalculateBounds = new(this, "CalculateBounds", 0);
					r_MCalculateBounds.SetBelong(this.GetValue());
				}
				return r_MCalculateBounds;
			}
		}

		/// <summary>
		/// Int32 IsMarkedVisible()
		/// </summary>
		protected RMethod r_MIsMarkedVisible;
		public virtual RMethod RMIsMarkedVisible
		{
			get
			{
				if(r_MIsMarkedVisible == null)
				{
					r_MIsMarkedVisible = new(this, "IsMarkedVisible", 0);
					r_MIsMarkedVisible.SetBelong(this.GetValue());
				}
				return r_MIsMarkedVisible;
			}
		}

		/// <summary>
		/// Void SampleAnimation(UnityEngine.Object, Single)
		/// </summary>
		protected RMethod r_MSampleAnimation_Object_Single;
		public virtual RMethod RMSampleAnimation_Object_Single
		{
			get
			{
				if(r_MSampleAnimation_Object_Single == null)
				{
					r_MSampleAnimation_Object_Single = new(this, "SampleAnimation", 0, typeof(UnityEngine.Object), typeof(System.Single));
					r_MSampleAnimation_Object_Single.SetBelong(this.GetValue());
				}
				return r_MSampleAnimation_Object_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Component AddComponent(System.String)
		/// </summary>
		protected RMethod r_MAddComponent_String;
		public virtual RMethod RMAddComponent_String
		{
			get
			{
				if(r_MAddComponent_String == null)
				{
					r_MAddComponent_String = new(this, "AddComponent", 0, typeof(System.String));
					r_MAddComponent_String.SetBelong(this.GetValue());
				}
				return r_MAddComponent_String;
			}
		}

		/// <summary>
		/// Void PlayAnimation(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MPlayAnimation_Object;
		public virtual RMethod RMPlayAnimation_Object
		{
			get
			{
				if(r_MPlayAnimation_Object == null)
				{
					r_MPlayAnimation_Object = new(this, "PlayAnimation", 0, typeof(UnityEngine.Object));
					r_MPlayAnimation_Object.SetBelong(this.GetValue());
				}
				return r_MPlayAnimation_Object;
			}
		}

		/// <summary>
		/// Void StopAnimation()
		/// </summary>
		protected RMethod r_MStopAnimation;
		public virtual RMethod RMStopAnimation
		{
			get
			{
				if(r_MStopAnimation == null)
				{
					r_MStopAnimation = new(this, "StopAnimation", 0);
					r_MStopAnimation.SetBelong(this.GetValue());
				}
				return r_MStopAnimation;
			}
		}

		/// <summary>
		/// Void get_scene_Injected(UnityEngine.SceneManagement.Scene ByRef)
		/// </summary>
		protected RMethod r_Mget_scene_Injected_Out_Scene;
		public virtual RMethod RMget_scene_Injected_Out_Scene
		{
			get
			{
				if(r_Mget_scene_Injected_Out_Scene == null)
				{
					r_Mget_scene_Injected_Out_Scene = new(this, "get_scene_Injected", 0, typeof(UnityEngine.SceneManagement.Scene).MakeByRefType());
					r_Mget_scene_Injected_Out_Scene.SetBelong(this.GetValue());
				}
				return r_Mget_scene_Injected_Out_Scene;
			}
		}

		/// <summary>
		/// Void CalculateBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_MCalculateBounds_Injected_Out_Bounds;
		public virtual RMethod RMCalculateBounds_Injected_Out_Bounds
		{
			get
			{
				if(r_MCalculateBounds_Injected_Out_Bounds == null)
				{
					r_MCalculateBounds_Injected_Out_Bounds = new(this, "CalculateBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_MCalculateBounds_Injected_Out_Bounds.SetBelong(this.GetValue());
				}
				return r_MCalculateBounds_Injected_Out_Bounds;
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
					r_MGetInstanceID.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
            var ___result = RMCreatePrimitive_PrimitiveType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
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


        public virtual UnityEngine.Component GetComponentByName(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponentByName_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RMGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RMGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Array GetComponentsInternal(System.Type @type, System.Boolean @useSearchTypeAsArrayReturnType, System.Boolean @recursive, System.Boolean @includeInactive, System.Boolean @reverse, System.Object @resultList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @useSearchTypeAsArrayReturnType, @recursive, @includeInactive, @reverse, @resultList};
            var ___result = RMGetComponentsInternal_Type_Boolean_Boolean_Boolean_Boolean_Object.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
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


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RMGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
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


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @type, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @includeInactive};
            var ___result = RMGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual void GetComponentsInParent<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RMGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
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


        public virtual System.Boolean TryGetComponent(System.Type @type, out UnityEngine.Component @component)
        {
			@component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RMTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			@component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component TryGetComponentInternal(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMTryGetComponentInternal_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void TryGetComponentFastPath(System.Type @type, System.IntPtr @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RMTryGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GameObject FindWithTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMFindWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void SendMessageUpwards(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component AddComponentInternal(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMAddComponentInternal_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component Internal_AddComponentWithType(System.Type @componentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@componentType};
            var ___result = RMInternal_AddComponentWithType_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component AddComponent(System.Type @componentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@componentType};
            var ___result = RMAddComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T AddComponent<T>() where T : UnityEngine.Component
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMAddComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void SetActive(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetActive_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActiveRecursively(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetActiveRecursively_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CompareTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.GameObject FindGameObjectWithTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMFindGameObjectWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public static UnityEngine.GameObject[] FindGameObjectsWithTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMFindGameObjectsWithTag_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject[])___result;
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


        public virtual void SendMessage(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RMSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
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


        public static void Internal_CreateGameObject(UnityEngine.GameObject @self, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @name};
            var ___result = RMInternal_CreateGameObject_GameObject_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GameObject Find(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFind_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual UnityEngine.Bounds CalculateBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalculateBounds.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Bounds)___result;
        }


        public virtual System.Int32 IsMarkedVisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsMarkedVisible.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SampleAnimation(UnityEngine.Object @clip, System.Single @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @time};
            var ___result = RMSampleAnimation_Object_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component AddComponent(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMAddComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void PlayAnimation(UnityEngine.Object @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RMPlayAnimation_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopAnimation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopAnimation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_scene_Injected(out UnityEngine.SceneManagement.Scene @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_scene_Injected_Out_Scene.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
        }


        public virtual void CalculateBounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMCalculateBounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
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
