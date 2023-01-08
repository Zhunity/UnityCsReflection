using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.MonoBehaviour
	/// </summary>
    public partial class RMonoBehaviour : RMember //
    {

		/// <summary>
		/// System.Threading.CancellationTokenSource m_CancellationTokenSource
		/// </summary>
		protected RSystem.RThreading.RCancellationTokenSource r_m_CancellationTokenSource;
		public virtual RSystem.RThreading.RCancellationTokenSource Rm_CancellationTokenSource
		{
			get
			{
				if(r_m_CancellationTokenSource == null)
				{
					r_m_CancellationTokenSource = new(this, "m_CancellationTokenSource");
					r_m_CancellationTokenSource.SetBelong(this.instance);
				}
				return r_m_CancellationTokenSource;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken destroyCancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_destroyCancellationToken;
		public virtual RSystem.RThreading.RCancellationToken RdestroyCancellationToken
		{
			get
			{
				if(r_destroyCancellationToken == null)
				{
					r_destroyCancellationToken = new(this, "destroyCancellationToken", -1);
					r_destroyCancellationToken.SetBelong(this.instance);
				}
				return r_destroyCancellationToken;
			}
		}

		/// <summary>
		/// Boolean useGUILayout
		/// </summary>
		protected RProperty r_useGUILayout;
		public virtual RProperty RuseGUILayout
		{
			get
			{
				if(r_useGUILayout == null)
				{
					r_useGUILayout = new(this, "useGUILayout", -1);
					r_useGUILayout.SetBelong(this.instance);
				}
				return r_useGUILayout;
			}
		}

		/// <summary>
		/// Boolean runInEditMode
		/// </summary>
		protected RProperty r_runInEditMode;
		public virtual RProperty RrunInEditMode
		{
			get
			{
				if(r_runInEditMode == null)
				{
					r_runInEditMode = new(this, "runInEditMode", -1);
					r_runInEditMode.SetBelong(this.instance);
				}
				return r_runInEditMode;
			}
		}

		/// <summary>
		/// Boolean allowPrefabModeInPlayMode
		/// </summary>
		protected RProperty r_allowPrefabModeInPlayMode;
		public virtual RProperty RallowPrefabModeInPlayMode
		{
			get
			{
				if(r_allowPrefabModeInPlayMode == null)
				{
					r_allowPrefabModeInPlayMode = new(this, "allowPrefabModeInPlayMode", -1);
					r_allowPrefabModeInPlayMode.SetBelong(this.instance);
				}
				return r_allowPrefabModeInPlayMode;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// Boolean isActiveAndEnabled
		/// </summary>
		protected RProperty r_isActiveAndEnabled;
		public virtual RProperty RisActiveAndEnabled
		{
			get
			{
				if(r_isActiveAndEnabled == null)
				{
					r_isActiveAndEnabled = new(this, "isActiveAndEnabled", -1);
					r_isActiveAndEnabled.SetBelong(this.instance);
				}
				return r_isActiveAndEnabled;
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
		/// Void RaiseCancellation()
		/// </summary>
		protected RMethod r_RaiseCancellation;
		public virtual RMethod RRaiseCancellation
		{
			get
			{
				if(r_RaiseCancellation == null)
				{
					r_RaiseCancellation = new(this, "RaiseCancellation", 0);
					r_RaiseCancellation.SetBelong(this.instance);
				}
				return r_RaiseCancellation;
			}
		}

		/// <summary>
		/// Boolean IsInvoking()
		/// </summary>
		protected RMethod r_IsInvoking;
		public virtual RMethod RIsInvoking
		{
			get
			{
				if(r_IsInvoking == null)
				{
					r_IsInvoking = new(this, "IsInvoking", 0);
					r_IsInvoking.SetBelong(this.instance);
				}
				return r_IsInvoking;
			}
		}

		/// <summary>
		/// Void CancelInvoke()
		/// </summary>
		protected RMethod r_CancelInvoke;
		public virtual RMethod RCancelInvoke
		{
			get
			{
				if(r_CancelInvoke == null)
				{
					r_CancelInvoke = new(this, "CancelInvoke", 0);
					r_CancelInvoke.SetBelong(this.instance);
				}
				return r_CancelInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, Single)
		/// </summary>
		protected RMethod r_Invoke_String_Single;
		public virtual RMethod RInvoke_String_Single
		{
			get
			{
				if(r_Invoke_String_Single == null)
				{
					r_Invoke_String_Single = new(this, "Invoke", 0, typeof(System.String), typeof(System.Single));
					r_Invoke_String_Single.SetBelong(this.instance);
				}
				return r_Invoke_String_Single;
			}
		}

		/// <summary>
		/// Void InvokeRepeating(System.String, Single, Single)
		/// </summary>
		protected RMethod r_InvokeRepeating_String_Single_Single;
		public virtual RMethod RInvokeRepeating_String_Single_Single
		{
			get
			{
				if(r_InvokeRepeating_String_Single_Single == null)
				{
					r_InvokeRepeating_String_Single_Single = new(this, "InvokeRepeating", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_InvokeRepeating_String_Single_Single.SetBelong(this.instance);
				}
				return r_InvokeRepeating_String_Single_Single;
			}
		}

		/// <summary>
		/// Void CancelInvoke(System.String)
		/// </summary>
		protected RMethod r_CancelInvoke_String;
		public virtual RMethod RCancelInvoke_String
		{
			get
			{
				if(r_CancelInvoke_String == null)
				{
					r_CancelInvoke_String = new(this, "CancelInvoke", 0, typeof(System.String));
					r_CancelInvoke_String.SetBelong(this.instance);
				}
				return r_CancelInvoke_String;
			}
		}

		/// <summary>
		/// Boolean IsInvoking(System.String)
		/// </summary>
		protected RMethod r_IsInvoking_String;
		public virtual RMethod RIsInvoking_String
		{
			get
			{
				if(r_IsInvoking_String == null)
				{
					r_IsInvoking_String = new(this, "IsInvoking", 0, typeof(System.String));
					r_IsInvoking_String.SetBelong(this.instance);
				}
				return r_IsInvoking_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String)
		/// </summary>
		protected RMethod r_StartCoroutine_String;
		public virtual RMethod RStartCoroutine_String
		{
			get
			{
				if(r_StartCoroutine_String == null)
				{
					r_StartCoroutine_String = new(this, "StartCoroutine", 0, typeof(System.String));
					r_StartCoroutine_String.SetBelong(this.instance);
				}
				return r_StartCoroutine_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String, System.Object)
		/// </summary>
		protected RMethod r_StartCoroutine_String_Object;
		public virtual RMethod RStartCoroutine_String_Object
		{
			get
			{
				if(r_StartCoroutine_String_Object == null)
				{
					r_StartCoroutine_String_Object = new(this, "StartCoroutine", 0, typeof(System.String), typeof(System.Object));
					r_StartCoroutine_String_Object.SetBelong(this.instance);
				}
				return r_StartCoroutine_String_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_StartCoroutine_IEnumerator;
		public virtual RMethod RStartCoroutine_IEnumerator
		{
			get
			{
				if(r_StartCoroutine_IEnumerator == null)
				{
					r_StartCoroutine_IEnumerator = new(this, "StartCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_StartCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_StartCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_StartCoroutine_Auto_IEnumerator;
		public virtual RMethod RStartCoroutine_Auto_IEnumerator
		{
			get
			{
				if(r_StartCoroutine_Auto_IEnumerator == null)
				{
					r_StartCoroutine_Auto_IEnumerator = new(this, "StartCoroutine_Auto", 0, typeof(System.Collections.IEnumerator));
					r_StartCoroutine_Auto_IEnumerator.SetBelong(this.instance);
				}
				return r_StartCoroutine_Auto_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_StopCoroutine_IEnumerator;
		public virtual RMethod RStopCoroutine_IEnumerator
		{
			get
			{
				if(r_StopCoroutine_IEnumerator == null)
				{
					r_StopCoroutine_IEnumerator = new(this, "StopCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_StopCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_StopCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(UnityEngine.Coroutine)
		/// </summary>
		protected RMethod r_StopCoroutine_Coroutine;
		public virtual RMethod RStopCoroutine_Coroutine
		{
			get
			{
				if(r_StopCoroutine_Coroutine == null)
				{
					r_StopCoroutine_Coroutine = new(this, "StopCoroutine", 0, typeof(UnityEngine.Coroutine));
					r_StopCoroutine_Coroutine.SetBelong(this.instance);
				}
				return r_StopCoroutine_Coroutine;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.String)
		/// </summary>
		protected RMethod r_StopCoroutine_String;
		public virtual RMethod RStopCoroutine_String
		{
			get
			{
				if(r_StopCoroutine_String == null)
				{
					r_StopCoroutine_String = new(this, "StopCoroutine", 0, typeof(System.String));
					r_StopCoroutine_String.SetBelong(this.instance);
				}
				return r_StopCoroutine_String;
			}
		}

		/// <summary>
		/// Void StopAllCoroutines()
		/// </summary>
		protected RMethod r_StopAllCoroutines;
		public virtual RMethod RStopAllCoroutines
		{
			get
			{
				if(r_StopAllCoroutines == null)
				{
					r_StopAllCoroutines = new(this, "StopAllCoroutines", 0);
					r_StopAllCoroutines.SetBelong(this.instance);
				}
				return r_StopAllCoroutines;
			}
		}

		/// <summary>
		/// Void print(System.Object)
		/// </summary>
		protected static RMethod r_print_Object;
		public static RMethod Rprint_Object
		{
			get
			{
				if(r_print_Object == null)
				{
					r_print_Object = new(typeof(UnityEngine.MonoBehaviour), "print", 0, typeof(System.Object));
					r_print_Object.SetBelong(null);
				}
				return r_print_Object;
			}
		}

		/// <summary>
		/// Void ConstructorCheck(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_ConstructorCheck_Object;
		public static RMethod RConstructorCheck_Object
		{
			get
			{
				if(r_ConstructorCheck_Object == null)
				{
					r_ConstructorCheck_Object = new(typeof(UnityEngine.MonoBehaviour), "ConstructorCheck", 0, typeof(UnityEngine.Object));
					r_ConstructorCheck_Object.SetBelong(null);
				}
				return r_ConstructorCheck_Object;
			}
		}

		/// <summary>
		/// Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour)
		/// </summary>
		protected static RMethod r_Internal_CancelInvokeAll_MonoBehaviour;
		public static RMethod RInternal_CancelInvokeAll_MonoBehaviour
		{
			get
			{
				if(r_Internal_CancelInvokeAll_MonoBehaviour == null)
				{
					r_Internal_CancelInvokeAll_MonoBehaviour = new(typeof(UnityEngine.MonoBehaviour), "Internal_CancelInvokeAll", 0, typeof(UnityEngine.MonoBehaviour));
					r_Internal_CancelInvokeAll_MonoBehaviour.SetBelong(null);
				}
				return r_Internal_CancelInvokeAll_MonoBehaviour;
			}
		}

		/// <summary>
		/// Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour)
		/// </summary>
		protected static RMethod r_Internal_IsInvokingAll_MonoBehaviour;
		public static RMethod RInternal_IsInvokingAll_MonoBehaviour
		{
			get
			{
				if(r_Internal_IsInvokingAll_MonoBehaviour == null)
				{
					r_Internal_IsInvokingAll_MonoBehaviour = new(typeof(UnityEngine.MonoBehaviour), "Internal_IsInvokingAll", 0, typeof(UnityEngine.MonoBehaviour));
					r_Internal_IsInvokingAll_MonoBehaviour.SetBelong(null);
				}
				return r_Internal_IsInvokingAll_MonoBehaviour;
			}
		}

		/// <summary>
		/// Void InvokeDelayed(UnityEngine.MonoBehaviour, System.String, Single, Single)
		/// </summary>
		protected static RMethod r_InvokeDelayed_MonoBehaviour_String_Single_Single;
		public static RMethod RInvokeDelayed_MonoBehaviour_String_Single_Single
		{
			get
			{
				if(r_InvokeDelayed_MonoBehaviour_String_Single_Single == null)
				{
					r_InvokeDelayed_MonoBehaviour_String_Single_Single = new(typeof(UnityEngine.MonoBehaviour), "InvokeDelayed", 0, typeof(UnityEngine.MonoBehaviour), typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_InvokeDelayed_MonoBehaviour_String_Single_Single.SetBelong(null);
				}
				return r_InvokeDelayed_MonoBehaviour_String_Single_Single;
			}
		}

		/// <summary>
		/// Void CancelInvoke(UnityEngine.MonoBehaviour, System.String)
		/// </summary>
		protected static RMethod r_CancelInvoke_MonoBehaviour_String;
		public static RMethod RCancelInvoke_MonoBehaviour_String
		{
			get
			{
				if(r_CancelInvoke_MonoBehaviour_String == null)
				{
					r_CancelInvoke_MonoBehaviour_String = new(typeof(UnityEngine.MonoBehaviour), "CancelInvoke", 0, typeof(UnityEngine.MonoBehaviour), typeof(System.String));
					r_CancelInvoke_MonoBehaviour_String.SetBelong(null);
				}
				return r_CancelInvoke_MonoBehaviour_String;
			}
		}

		/// <summary>
		/// Boolean IsInvoking(UnityEngine.MonoBehaviour, System.String)
		/// </summary>
		protected static RMethod r_IsInvoking_MonoBehaviour_String;
		public static RMethod RIsInvoking_MonoBehaviour_String
		{
			get
			{
				if(r_IsInvoking_MonoBehaviour_String == null)
				{
					r_IsInvoking_MonoBehaviour_String = new(typeof(UnityEngine.MonoBehaviour), "IsInvoking", 0, typeof(UnityEngine.MonoBehaviour), typeof(System.String));
					r_IsInvoking_MonoBehaviour_String.SetBelong(null);
				}
				return r_IsInvoking_MonoBehaviour_String;
			}
		}

		/// <summary>
		/// Boolean IsObjectMonoBehaviour(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_IsObjectMonoBehaviour_Object;
		public static RMethod RIsObjectMonoBehaviour_Object
		{
			get
			{
				if(r_IsObjectMonoBehaviour_Object == null)
				{
					r_IsObjectMonoBehaviour_Object = new(typeof(UnityEngine.MonoBehaviour), "IsObjectMonoBehaviour", 0, typeof(UnityEngine.Object));
					r_IsObjectMonoBehaviour_Object.SetBelong(null);
				}
				return r_IsObjectMonoBehaviour_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutineManaged(System.String, System.Object)
		/// </summary>
		protected RMethod r_StartCoroutineManaged_String_Object;
		public virtual RMethod RStartCoroutineManaged_String_Object
		{
			get
			{
				if(r_StartCoroutineManaged_String_Object == null)
				{
					r_StartCoroutineManaged_String_Object = new(this, "StartCoroutineManaged", 0, typeof(System.String), typeof(System.Object));
					r_StartCoroutineManaged_String_Object.SetBelong(this.instance);
				}
				return r_StartCoroutineManaged_String_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_StartCoroutineManaged2_IEnumerator;
		public virtual RMethod RStartCoroutineManaged2_IEnumerator
		{
			get
			{
				if(r_StartCoroutineManaged2_IEnumerator == null)
				{
					r_StartCoroutineManaged2_IEnumerator = new(this, "StartCoroutineManaged2", 0, typeof(System.Collections.IEnumerator));
					r_StartCoroutineManaged2_IEnumerator.SetBelong(this.instance);
				}
				return r_StartCoroutineManaged2_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutineManaged(UnityEngine.Coroutine)
		/// </summary>
		protected RMethod r_StopCoroutineManaged_Coroutine;
		public virtual RMethod RStopCoroutineManaged_Coroutine
		{
			get
			{
				if(r_StopCoroutineManaged_Coroutine == null)
				{
					r_StopCoroutineManaged_Coroutine = new(this, "StopCoroutineManaged", 0, typeof(UnityEngine.Coroutine));
					r_StopCoroutineManaged_Coroutine.SetBelong(this.instance);
				}
				return r_StopCoroutineManaged_Coroutine;
			}
		}

		/// <summary>
		/// Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_StopCoroutineFromEnumeratorManaged_IEnumerator;
		public virtual RMethod RStopCoroutineFromEnumeratorManaged_IEnumerator
		{
			get
			{
				if(r_StopCoroutineFromEnumeratorManaged_IEnumerator == null)
				{
					r_StopCoroutineFromEnumeratorManaged_IEnumerator = new(this, "StopCoroutineFromEnumeratorManaged", 0, typeof(System.Collections.IEnumerator));
					r_StopCoroutineFromEnumeratorManaged_IEnumerator.SetBelong(this.instance);
				}
				return r_StopCoroutineFromEnumeratorManaged_IEnumerator;
			}
		}

		/// <summary>
		/// System.String GetScriptClassName()
		/// </summary>
		protected RMethod r_GetScriptClassName;
		public virtual RMethod RGetScriptClassName
		{
			get
			{
				if(r_GetScriptClassName == null)
				{
					r_GetScriptClassName = new(this, "GetScriptClassName", 0);
					r_GetScriptClassName.SetBelong(this.instance);
				}
				return r_GetScriptClassName;
			}
		}

		/// <summary>
		/// Void OnCancellationTokenCreated()
		/// </summary>
		protected RMethod r_OnCancellationTokenCreated;
		public virtual RMethod ROnCancellationTokenCreated
		{
			get
			{
				if(r_OnCancellationTokenCreated == null)
				{
					r_OnCancellationTokenCreated = new(this, "OnCancellationTokenCreated", 0);
					r_OnCancellationTokenCreated.SetBelong(this.instance);
				}
				return r_OnCancellationTokenCreated;
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
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_GetCoupledComponent;
		public virtual RMethod RGetCoupledComponent
		{
			get
			{
				if(r_GetCoupledComponent == null)
				{
					r_GetCoupledComponent = new(this, "GetCoupledComponent", 0);
					r_GetCoupledComponent.SetBelong(this.instance);
				}
				return r_GetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_IsCoupledComponent;
		public virtual RMethod RIsCoupledComponent
		{
			get
			{
				if(r_IsCoupledComponent == null)
				{
					r_IsCoupledComponent = new(this, "IsCoupledComponent", 0);
					r_IsCoupledComponent.SetBelong(this.instance);
				}
				return r_IsCoupledComponent;
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


        public RMonoBehaviour() : base("UnityEngine.MonoBehaviour")
        {
        }

        public RMonoBehaviour(System.Object instance) : base("UnityEngine.MonoBehaviour")
		{
            SetInstance(instance);
		}

        public RMonoBehaviour(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMonoBehaviour(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void RaiseCancellation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRaiseCancellation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInvoking.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CancelInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancelInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String  @methodName, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time};
            var ___result = RInvoke_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeRepeating(System.String  @methodName, System.Single  @time, System.Single  @repeatRate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time, @repeatRate};
            var ___result = RInvokeRepeating_String_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelInvoke(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCancelInvoke_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RIsInvoking_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStartCoroutine_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RStartCoroutine_String_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_Auto_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void StopCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(UnityEngine.Coroutine  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_Coroutine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStopCoroutine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopAllCoroutines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopAllCoroutines.Invoke(___genericsType, ___parameters);

            
        }


        public static void print(System.Object  @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message};
            var ___result = Rprint_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void ConstructorCheck(UnityEngine.Object  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RConstructorCheck_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_CancelInvokeAll_MonoBehaviour.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_IsInvokingAll_MonoBehaviour.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void InvokeDelayed(UnityEngine.MonoBehaviour  @self, System.String  @methodName, System.Single  @time, System.Single  @repeatRate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @methodName, @time, @repeatRate};
            var ___result = RInvokeDelayed_MonoBehaviour_String_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void CancelInvoke(UnityEngine.MonoBehaviour  @self, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @methodName};
            var ___result = RCancelInvoke_MonoBehaviour_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsInvoking(UnityEngine.MonoBehaviour  @self, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @methodName};
            var ___result = RIsInvoking_MonoBehaviour_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsObjectMonoBehaviour(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RIsObjectMonoBehaviour_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutineManaged(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RStartCoroutineManaged_String_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator  @enumerator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumerator};
            var ___result = RStartCoroutineManaged2_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void StopCoroutineManaged(UnityEngine.Coroutine  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutineManaged_Coroutine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutineFromEnumeratorManaged_IEnumerator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetScriptClassName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScriptClassName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void OnCancellationTokenCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnCancellationTokenCreated.Invoke(___genericsType, ___parameters);

            
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
