using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ReflectionProbe
	/// </summary>
    public partial class RReflectionProbe : RMember //
    {

		/// <summary>
		/// System.Action`2[UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe+ReflectionProbeEvent] reflectionProbeChanged
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RReflectionProbe, RField> r_reflectionProbeChanged;
		public static RSystem.RAction<RUnityEngine.RReflectionProbe, RField> RreflectionProbeChanged
		{
			get
			{
				if(r_reflectionProbeChanged == null)
				{
					r_reflectionProbeChanged = new(typeof(UnityEngine.ReflectionProbe), "reflectionProbeChanged");
					r_reflectionProbeChanged.SetBelong(null);
				}
				return r_reflectionProbeChanged;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Action`1[UnityEngine.Texture]] registeredDefaultReflectionSetActions
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RAction<RUnityEngine.RTexture>> r_registeredDefaultReflectionSetActions;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RAction<RUnityEngine.RTexture>> RregisteredDefaultReflectionSetActions
		{
			get
			{
				if(r_registeredDefaultReflectionSetActions == null)
				{
					r_registeredDefaultReflectionSetActions = new(typeof(UnityEngine.ReflectionProbe), "registeredDefaultReflectionSetActions");
					r_registeredDefaultReflectionSetActions.SetBelong(null);
				}
				return r_registeredDefaultReflectionSetActions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Action`1[UnityEngine.Texture]] registeredDefaultReflectionTextureActions
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RSystem.RAction<RUnityEngine.RTexture>> r_registeredDefaultReflectionTextureActions;
		public static RSystem.RCollections.RGeneric.RList<RSystem.RAction<RUnityEngine.RTexture>> RregisteredDefaultReflectionTextureActions
		{
			get
			{
				if(r_registeredDefaultReflectionTextureActions == null)
				{
					r_registeredDefaultReflectionTextureActions = new(typeof(UnityEngine.ReflectionProbe), "registeredDefaultReflectionTextureActions");
					r_registeredDefaultReflectionTextureActions.SetBelong(null);
				}
				return r_registeredDefaultReflectionTextureActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeType type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 size
		/// </summary>
		protected RUnityEngine.RVector3 r_size;
		public virtual RUnityEngine.RVector3 Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size", -1);
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 center
		/// </summary>
		protected RUnityEngine.RVector3 r_center;
		public virtual RUnityEngine.RVector3 Rcenter
		{
			get
			{
				if(r_center == null)
				{
					r_center = new(this, "center", -1);
					r_center.SetBelong(this.instance);
				}
				return r_center;
			}
		}

		/// <summary>
		/// Single nearClipPlane
		/// </summary>
		protected RProperty r_nearClipPlane;
		public virtual RProperty RnearClipPlane
		{
			get
			{
				if(r_nearClipPlane == null)
				{
					r_nearClipPlane = new(this, "nearClipPlane", -1);
					r_nearClipPlane.SetBelong(this.instance);
				}
				return r_nearClipPlane;
			}
		}

		/// <summary>
		/// Single farClipPlane
		/// </summary>
		protected RProperty r_farClipPlane;
		public virtual RProperty RfarClipPlane
		{
			get
			{
				if(r_farClipPlane == null)
				{
					r_farClipPlane = new(this, "farClipPlane", -1);
					r_farClipPlane.SetBelong(this.instance);
				}
				return r_farClipPlane;
			}
		}

		/// <summary>
		/// Single intensity
		/// </summary>
		protected RProperty r_intensity;
		public virtual RProperty Rintensity
		{
			get
			{
				if(r_intensity == null)
				{
					r_intensity = new(this, "intensity", -1);
					r_intensity.SetBelong(this.instance);
				}
				return r_intensity;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected RUnityEngine.RBounds r_bounds;
		public virtual RUnityEngine.RBounds Rbounds
		{
			get
			{
				if(r_bounds == null)
				{
					r_bounds = new(this, "bounds", -1);
					r_bounds.SetBelong(this.instance);
				}
				return r_bounds;
			}
		}

		/// <summary>
		/// Boolean hdr
		/// </summary>
		protected RProperty r_hdr;
		public virtual RProperty Rhdr
		{
			get
			{
				if(r_hdr == null)
				{
					r_hdr = new(this, "hdr", -1);
					r_hdr.SetBelong(this.instance);
				}
				return r_hdr;
			}
		}

		/// <summary>
		/// Boolean renderDynamicObjects
		/// </summary>
		protected RProperty r_renderDynamicObjects;
		public virtual RProperty RrenderDynamicObjects
		{
			get
			{
				if(r_renderDynamicObjects == null)
				{
					r_renderDynamicObjects = new(this, "renderDynamicObjects", -1);
					r_renderDynamicObjects.SetBelong(this.instance);
				}
				return r_renderDynamicObjects;
			}
		}

		/// <summary>
		/// Single shadowDistance
		/// </summary>
		protected RProperty r_shadowDistance;
		public virtual RProperty RshadowDistance
		{
			get
			{
				if(r_shadowDistance == null)
				{
					r_shadowDistance = new(this, "shadowDistance", -1);
					r_shadowDistance.SetBelong(this.instance);
				}
				return r_shadowDistance;
			}
		}

		/// <summary>
		/// Int32 resolution
		/// </summary>
		protected RProperty r_resolution;
		public virtual RProperty Rresolution
		{
			get
			{
				if(r_resolution == null)
				{
					r_resolution = new(this, "resolution", -1);
					r_resolution.SetBelong(this.instance);
				}
				return r_resolution;
			}
		}

		/// <summary>
		/// Int32 cullingMask
		/// </summary>
		protected RProperty r_cullingMask;
		public virtual RProperty RcullingMask
		{
			get
			{
				if(r_cullingMask == null)
				{
					r_cullingMask = new(this, "cullingMask", -1);
					r_cullingMask.SetBelong(this.instance);
				}
				return r_cullingMask;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags
		/// </summary>
		protected RProperty r_clearFlags;
		public virtual RProperty RclearFlags
		{
			get
			{
				if(r_clearFlags == null)
				{
					r_clearFlags = new(this, "clearFlags", -1);
					r_clearFlags.SetBelong(this.instance);
				}
				return r_clearFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_backgroundColor;
		public virtual RUnityEngine.RColor RbackgroundColor
		{
			get
			{
				if(r_backgroundColor == null)
				{
					r_backgroundColor = new(this, "backgroundColor", -1);
					r_backgroundColor.SetBelong(this.instance);
				}
				return r_backgroundColor;
			}
		}

		/// <summary>
		/// Single blendDistance
		/// </summary>
		protected RProperty r_blendDistance;
		public virtual RProperty RblendDistance
		{
			get
			{
				if(r_blendDistance == null)
				{
					r_blendDistance = new(this, "blendDistance", -1);
					r_blendDistance.SetBelong(this.instance);
				}
				return r_blendDistance;
			}
		}

		/// <summary>
		/// Boolean boxProjection
		/// </summary>
		protected RProperty r_boxProjection;
		public virtual RProperty RboxProjection
		{
			get
			{
				if(r_boxProjection == null)
				{
					r_boxProjection = new(this, "boxProjection", -1);
					r_boxProjection.SetBelong(this.instance);
				}
				return r_boxProjection;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeMode mode
		/// </summary>
		protected RProperty r_mode;
		public virtual RProperty Rmode
		{
			get
			{
				if(r_mode == null)
				{
					r_mode = new(this, "mode", -1);
					r_mode.SetBelong(this.instance);
				}
				return r_mode;
			}
		}

		/// <summary>
		/// Int32 importance
		/// </summary>
		protected RProperty r_importance;
		public virtual RProperty Rimportance
		{
			get
			{
				if(r_importance == null)
				{
					r_importance = new(this, "importance", -1);
					r_importance.SetBelong(this.instance);
				}
				return r_importance;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode
		/// </summary>
		protected RProperty r_refreshMode;
		public virtual RProperty RrefreshMode
		{
			get
			{
				if(r_refreshMode == null)
				{
					r_refreshMode = new(this, "refreshMode", -1);
					r_refreshMode.SetBelong(this.instance);
				}
				return r_refreshMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode
		/// </summary>
		protected RProperty r_timeSlicingMode;
		public virtual RProperty RtimeSlicingMode
		{
			get
			{
				if(r_timeSlicingMode == null)
				{
					r_timeSlicingMode = new(this, "timeSlicingMode", -1);
					r_timeSlicingMode.SetBelong(this.instance);
				}
				return r_timeSlicingMode;
			}
		}

		/// <summary>
		/// UnityEngine.Texture bakedTexture
		/// </summary>
		protected RUnityEngine.RTexture r_bakedTexture;
		public virtual RUnityEngine.RTexture RbakedTexture
		{
			get
			{
				if(r_bakedTexture == null)
				{
					r_bakedTexture = new(this, "bakedTexture", -1);
					r_bakedTexture.SetBelong(this.instance);
				}
				return r_bakedTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture customBakedTexture
		/// </summary>
		protected RUnityEngine.RTexture r_customBakedTexture;
		public virtual RUnityEngine.RTexture RcustomBakedTexture
		{
			get
			{
				if(r_customBakedTexture == null)
				{
					r_customBakedTexture = new(this, "customBakedTexture", -1);
					r_customBakedTexture.SetBelong(this.instance);
				}
				return r_customBakedTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture realtimeTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_realtimeTexture;
		public virtual RUnityEngine.RRenderTexture RrealtimeTexture
		{
			get
			{
				if(r_realtimeTexture == null)
				{
					r_realtimeTexture = new(this, "realtimeTexture", -1);
					r_realtimeTexture.SetBelong(this.instance);
				}
				return r_realtimeTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture texture
		/// </summary>
		protected RUnityEngine.RTexture r_texture;
		public virtual RUnityEngine.RTexture Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 textureHDRDecodeValues
		/// </summary>
		protected RUnityEngine.RVector4 r_textureHDRDecodeValues;
		public virtual RUnityEngine.RVector4 RtextureHDRDecodeValues
		{
			get
			{
				if(r_textureHDRDecodeValues == null)
				{
					r_textureHDRDecodeValues = new(this, "textureHDRDecodeValues", -1);
					r_textureHDRDecodeValues.SetBelong(this.instance);
				}
				return r_textureHDRDecodeValues;
			}
		}

		/// <summary>
		/// Int32 minBakedCubemapResolution
		/// </summary>
		protected static RProperty r_minBakedCubemapResolution;
		public static RProperty RminBakedCubemapResolution
		{
			get
			{
				if(r_minBakedCubemapResolution == null)
				{
					r_minBakedCubemapResolution = new(typeof(UnityEngine.ReflectionProbe), "minBakedCubemapResolution", -1);
					r_minBakedCubemapResolution.SetBelong(null);
				}
				return r_minBakedCubemapResolution;
			}
		}

		/// <summary>
		/// Int32 maxBakedCubemapResolution
		/// </summary>
		protected static RProperty r_maxBakedCubemapResolution;
		public static RProperty RmaxBakedCubemapResolution
		{
			get
			{
				if(r_maxBakedCubemapResolution == null)
				{
					r_maxBakedCubemapResolution = new(typeof(UnityEngine.ReflectionProbe), "maxBakedCubemapResolution", -1);
					r_maxBakedCubemapResolution.SetBelong(null);
				}
				return r_maxBakedCubemapResolution;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 defaultTextureHDRDecodeValues
		/// </summary>
		protected static RUnityEngine.RVector4 r_defaultTextureHDRDecodeValues;
		public static RUnityEngine.RVector4 RdefaultTextureHDRDecodeValues
		{
			get
			{
				if(r_defaultTextureHDRDecodeValues == null)
				{
					r_defaultTextureHDRDecodeValues = new(typeof(UnityEngine.ReflectionProbe), "defaultTextureHDRDecodeValues", -1);
					r_defaultTextureHDRDecodeValues.SetBelong(null);
				}
				return r_defaultTextureHDRDecodeValues;
			}
		}

		/// <summary>
		/// UnityEngine.Texture defaultTexture
		/// </summary>
		protected static RUnityEngine.RTexture r_defaultTexture;
		public static RUnityEngine.RTexture RdefaultTexture
		{
			get
			{
				if(r_defaultTexture == null)
				{
					r_defaultTexture = new(typeof(UnityEngine.ReflectionProbe), "defaultTexture", -1);
					r_defaultTexture.SetBelong(null);
				}
				return r_defaultTexture;
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
		/// System.Action`1[UnityEngine.Cubemap] defaultReflectionSet
		/// </summary>
		protected static REvent r_defaultReflectionSet;
		public static REvent RdefaultReflectionSet
		{
			get
			{
				if(r_defaultReflectionSet == null)
				{
					r_defaultReflectionSet = new(typeof(UnityEngine.ReflectionProbe), "defaultReflectionSet");
					r_defaultReflectionSet.SetBelong(null);
				}
				return r_defaultReflectionSet;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Texture] defaultReflectionTexture
		/// </summary>
		protected static REvent r_defaultReflectionTexture;
		public static REvent RdefaultReflectionTexture
		{
			get
			{
				if(r_defaultReflectionTexture == null)
				{
					r_defaultReflectionTexture = new(typeof(UnityEngine.ReflectionProbe), "defaultReflectionTexture");
					r_defaultReflectionTexture.SetBelong(null);
				}
				return r_defaultReflectionTexture;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Int32 RenderProbe()
		/// </summary>
		protected RMethod r_RRenderProbe;
		public virtual RMethod RRenderProbe
		{
			get
			{
				if(r_RRenderProbe == null)
				{
					r_RRenderProbe = new(this, "RenderProbe", 0);
					r_RRenderProbe.SetBelong(this.instance);
				}
				return r_RRenderProbe;
			}
		}

		/// <summary>
		/// Int32 RenderProbe(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_RRenderProbe_RenderTexture;
		public virtual RMethod RRenderProbe_RenderTexture
		{
			get
			{
				if(r_RRenderProbe_RenderTexture == null)
				{
					r_RRenderProbe_RenderTexture = new(this, "RenderProbe", 0, typeof(UnityEngine.RenderTexture));
					r_RRenderProbe_RenderTexture.SetBelong(this.instance);
				}
				return r_RRenderProbe_RenderTexture;
			}
		}

		/// <summary>
		/// Boolean IsFinishedRendering(Int32)
		/// </summary>
		protected RMethod r_RIsFinishedRendering_Int32;
		public virtual RMethod RIsFinishedRendering_Int32
		{
			get
			{
				if(r_RIsFinishedRendering_Int32 == null)
				{
					r_RIsFinishedRendering_Int32 = new(this, "IsFinishedRendering", 0, typeof(System.Int32));
					r_RIsFinishedRendering_Int32.SetBelong(this.instance);
				}
				return r_RIsFinishedRendering_Int32;
			}
		}

		/// <summary>
		/// Int32 ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode, UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture;
		public virtual RMethod RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture
		{
			get
			{
				if(r_RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture == null)
				{
					r_RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture = new(this, "ScheduleRender", 0, typeof(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode), typeof(UnityEngine.RenderTexture));
					r_RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture.SetBelong(this.instance);
				}
				return r_RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture;
			}
		}

		/// <summary>
		/// Boolean BlendCubemap(UnityEngine.Texture, UnityEngine.Texture, Single, UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_RBlendCubemap_Texture_Texture_Single_RenderTexture;
		public static RMethod RBlendCubemap_Texture_Texture_Single_RenderTexture
		{
			get
			{
				if(r_RBlendCubemap_Texture_Texture_Single_RenderTexture == null)
				{
					r_RBlendCubemap_Texture_Texture_Single_RenderTexture = new(typeof(UnityEngine.ReflectionProbe), "BlendCubemap", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Texture), typeof(System.Single), typeof(UnityEngine.RenderTexture));
					r_RBlendCubemap_Texture_Texture_Single_RenderTexture.SetBelong(null);
				}
				return r_RBlendCubemap_Texture_Texture_Single_RenderTexture;
			}
		}

		/// <summary>
		/// Void UpdateCachedState()
		/// </summary>
		protected static RMethod r_RUpdateCachedState;
		public static RMethod RUpdateCachedState
		{
			get
			{
				if(r_RUpdateCachedState == null)
				{
					r_RUpdateCachedState = new(typeof(UnityEngine.ReflectionProbe), "UpdateCachedState", 0);
					r_RUpdateCachedState.SetBelong(null);
				}
				return r_RUpdateCachedState;
			}
		}

		/// <summary>
		/// Void CallReflectionProbeEvent(UnityEngine.ReflectionProbe, ReflectionProbeEvent)
		/// </summary>
		protected static RMethod r_RCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent;
		public static RMethod RCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent
		{
			get
			{
				if(r_RCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent == null)
				{
					r_RCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent = new(typeof(UnityEngine.ReflectionProbe), "CallReflectionProbeEvent", 0, typeof(UnityEngine.ReflectionProbe),  ReleactionUtils.GetType("UnityEngine.ReflectionProbe+ReflectionProbeEvent"));
					r_RCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent.SetBelong(null);
				}
				return r_RCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent;
			}
		}

		/// <summary>
		/// Void CallSetDefaultReflection(UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_RCallSetDefaultReflection_Texture;
		public static RMethod RCallSetDefaultReflection_Texture
		{
			get
			{
				if(r_RCallSetDefaultReflection_Texture == null)
				{
					r_RCallSetDefaultReflection_Texture = new(typeof(UnityEngine.ReflectionProbe), "CallSetDefaultReflection", 0, typeof(UnityEngine.Texture));
					r_RCallSetDefaultReflection_Texture.SetBelong(null);
				}
				return r_RCallSetDefaultReflection_Texture;
			}
		}

		/// <summary>
		/// Void get_size_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_size_Injected_Out_Vector3;
		public virtual RMethod Rget_size_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_size_Injected_Out_Vector3 == null)
				{
					r_Rget_size_Injected_Out_Vector3 = new(this, "get_size_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_size_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_size_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_size_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_size_Injected_Ref_Vector3;
		public virtual RMethod Rset_size_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_size_Injected_Ref_Vector3 == null)
				{
					r_Rset_size_Injected_Ref_Vector3 = new(this, "set_size_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_size_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_size_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_center_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_center_Injected_Out_Vector3;
		public virtual RMethod Rget_center_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_center_Injected_Out_Vector3 == null)
				{
					r_Rget_center_Injected_Out_Vector3 = new(this, "get_center_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_center_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_center_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_center_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_center_Injected_Ref_Vector3;
		public virtual RMethod Rset_center_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_center_Injected_Ref_Vector3 == null)
				{
					r_Rset_center_Injected_Ref_Vector3 = new(this, "set_center_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_center_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_center_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Rget_bounds_Injected_Out_Bounds;
		public virtual RMethod Rget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Rget_bounds_Injected_Out_Bounds == null)
				{
					r_Rget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Rget_bounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_Rget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void get_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rget_backgroundColor_Injected_Out_Color;
		public virtual RMethod Rget_backgroundColor_Injected_Out_Color
		{
			get
			{
				if(r_Rget_backgroundColor_Injected_Out_Color == null)
				{
					r_Rget_backgroundColor_Injected_Out_Color = new(this, "get_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rget_backgroundColor_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_Rget_backgroundColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rset_backgroundColor_Injected_Ref_Color;
		public virtual RMethod Rset_backgroundColor_Injected_Ref_Color
		{
			get
			{
				if(r_Rset_backgroundColor_Injected_Ref_Color == null)
				{
					r_Rset_backgroundColor_Injected_Ref_Color = new(this, "set_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rset_backgroundColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_Rset_backgroundColor_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void get_textureHDRDecodeValues_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_textureHDRDecodeValues_Injected_Out_Vector4;
		public virtual RMethod Rget_textureHDRDecodeValues_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_textureHDRDecodeValues_Injected_Out_Vector4 == null)
				{
					r_Rget_textureHDRDecodeValues_Injected_Out_Vector4 = new(this, "get_textureHDRDecodeValues_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_textureHDRDecodeValues_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_textureHDRDecodeValues_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void get_defaultTextureHDRDecodeValues_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4;
		public static RMethod Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4 == null)
				{
					r_Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4 = new(typeof(UnityEngine.ReflectionProbe), "get_defaultTextureHDRDecodeValues_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4.SetBelong(null);
				}
				return r_Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4;
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


        public RReflectionProbe() : base("UnityEngine.ReflectionProbe")
        {
        }

        public RReflectionProbe(System.Object instance) : base("UnityEngine.ReflectionProbe")
		{
            SetInstance(instance);
		}

        public RReflectionProbe(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReflectionProbe(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RenderProbe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRenderProbe.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 RenderProbe(UnityEngine.RenderTexture  @targetTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetTexture};
            var ___result = RRenderProbe_RenderTexture.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsFinishedRendering(System.Int32  @renderId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderId};
            var ___result = RIsFinishedRendering_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode  @timeSlicingMode, UnityEngine.RenderTexture  @targetTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSlicingMode, @targetTexture};
            var ___result = RScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean BlendCubemap(UnityEngine.Texture  @src, UnityEngine.Texture  @dst, System.Single  @blend, UnityEngine.RenderTexture  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @blend, @target};
            var ___result = RBlendCubemap_Texture_Texture_Single_RenderTexture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void UpdateCachedState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCachedState.Invoke(___genericsType, ___parameters);

            
        }



        public static void CallSetDefaultReflection(UnityEngine.Texture  @defaultReflectionCubemap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultReflectionCubemap};
            var ___result = RCallSetDefaultReflection_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_size_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_size_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_size_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_size_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_center_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_center_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_center_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_center_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void get_backgroundColor_Injected(out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_backgroundColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_backgroundColor_Injected(ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_backgroundColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void get_textureHDRDecodeValues_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_textureHDRDecodeValues_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public static void get_defaultTextureHDRDecodeValues_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_defaultTextureHDRDecodeValues_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
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
