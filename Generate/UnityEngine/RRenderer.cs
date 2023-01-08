using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Renderer
	/// </summary>
    public partial class RRenderer : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector4 lightmapTilingOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_lightmapTilingOffset;
		public virtual RUnityEngine.RVector4 RlightmapTilingOffset
		{
			get
			{
				if(r_lightmapTilingOffset == null)
				{
					r_lightmapTilingOffset = new(this, "lightmapTilingOffset", -1);
					r_lightmapTilingOffset.SetBelong(this.instance);
				}
				return r_lightmapTilingOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Transform lightProbeAnchor
		/// </summary>
		protected RUnityEngine.RTransform r_lightProbeAnchor;
		public virtual RUnityEngine.RTransform RlightProbeAnchor
		{
			get
			{
				if(r_lightProbeAnchor == null)
				{
					r_lightProbeAnchor = new(this, "lightProbeAnchor", -1);
					r_lightProbeAnchor.SetBelong(this.instance);
				}
				return r_lightProbeAnchor;
			}
		}

		/// <summary>
		/// Boolean castShadows
		/// </summary>
		protected RProperty r_castShadows;
		public virtual RProperty RcastShadows
		{
			get
			{
				if(r_castShadows == null)
				{
					r_castShadows = new(this, "castShadows", -1);
					r_castShadows.SetBelong(this.instance);
				}
				return r_castShadows;
			}
		}

		/// <summary>
		/// Boolean motionVectors
		/// </summary>
		protected RProperty r_motionVectors;
		public virtual RProperty RmotionVectors
		{
			get
			{
				if(r_motionVectors == null)
				{
					r_motionVectors = new(this, "motionVectors", -1);
					r_motionVectors.SetBelong(this.instance);
				}
				return r_motionVectors;
			}
		}

		/// <summary>
		/// Boolean useLightProbes
		/// </summary>
		protected RProperty r_useLightProbes;
		public virtual RProperty RuseLightProbes
		{
			get
			{
				if(r_useLightProbes == null)
				{
					r_useLightProbes = new(this, "useLightProbes", -1);
					r_useLightProbes.SetBelong(this.instance);
				}
				return r_useLightProbes;
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
		/// UnityEngine.Bounds localBounds
		/// </summary>
		protected RUnityEngine.RBounds r_localBounds;
		public virtual RUnityEngine.RBounds RlocalBounds
		{
			get
			{
				if(r_localBounds == null)
				{
					r_localBounds = new(this, "localBounds", -1);
					r_localBounds.SetBelong(this.instance);
				}
				return r_localBounds;
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
		/// Boolean isVisible
		/// </summary>
		protected RProperty r_isVisible;
		public virtual RProperty RisVisible
		{
			get
			{
				if(r_isVisible == null)
				{
					r_isVisible = new(this, "isVisible", -1);
					r_isVisible.SetBelong(this.instance);
				}
				return r_isVisible;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		/// </summary>
		protected RProperty r_shadowCastingMode;
		public virtual RProperty RshadowCastingMode
		{
			get
			{
				if(r_shadowCastingMode == null)
				{
					r_shadowCastingMode = new(this, "shadowCastingMode", -1);
					r_shadowCastingMode.SetBelong(this.instance);
				}
				return r_shadowCastingMode;
			}
		}

		/// <summary>
		/// Boolean receiveShadows
		/// </summary>
		protected RProperty r_receiveShadows;
		public virtual RProperty RreceiveShadows
		{
			get
			{
				if(r_receiveShadows == null)
				{
					r_receiveShadows = new(this, "receiveShadows", -1);
					r_receiveShadows.SetBelong(this.instance);
				}
				return r_receiveShadows;
			}
		}

		/// <summary>
		/// Boolean forceRenderingOff
		/// </summary>
		protected RProperty r_forceRenderingOff;
		public virtual RProperty RforceRenderingOff
		{
			get
			{
				if(r_forceRenderingOff == null)
				{
					r_forceRenderingOff = new(this, "forceRenderingOff", -1);
					r_forceRenderingOff.SetBelong(this.instance);
				}
				return r_forceRenderingOff;
			}
		}

		/// <summary>
		/// Boolean staticShadowCaster
		/// </summary>
		protected RProperty r_staticShadowCaster;
		public virtual RProperty RstaticShadowCaster
		{
			get
			{
				if(r_staticShadowCaster == null)
				{
					r_staticShadowCaster = new(this, "staticShadowCaster", -1);
					r_staticShadowCaster.SetBelong(this.instance);
				}
				return r_staticShadowCaster;
			}
		}

		/// <summary>
		/// UnityEngine.MotionVectorGenerationMode motionVectorGenerationMode
		/// </summary>
		protected RProperty r_motionVectorGenerationMode;
		public virtual RProperty RmotionVectorGenerationMode
		{
			get
			{
				if(r_motionVectorGenerationMode == null)
				{
					r_motionVectorGenerationMode = new(this, "motionVectorGenerationMode", -1);
					r_motionVectorGenerationMode.SetBelong(this.instance);
				}
				return r_motionVectorGenerationMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LightProbeUsage lightProbeUsage
		/// </summary>
		protected RProperty r_lightProbeUsage;
		public virtual RProperty RlightProbeUsage
		{
			get
			{
				if(r_lightProbeUsage == null)
				{
					r_lightProbeUsage = new(this, "lightProbeUsage", -1);
					r_lightProbeUsage.SetBelong(this.instance);
				}
				return r_lightProbeUsage;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		/// </summary>
		protected RProperty r_reflectionProbeUsage;
		public virtual RProperty RreflectionProbeUsage
		{
			get
			{
				if(r_reflectionProbeUsage == null)
				{
					r_reflectionProbeUsage = new(this, "reflectionProbeUsage", -1);
					r_reflectionProbeUsage.SetBelong(this.instance);
				}
				return r_reflectionProbeUsage;
			}
		}

		/// <summary>
		/// UInt32 renderingLayerMask
		/// </summary>
		protected RProperty r_renderingLayerMask;
		public virtual RProperty RrenderingLayerMask
		{
			get
			{
				if(r_renderingLayerMask == null)
				{
					r_renderingLayerMask = new(this, "renderingLayerMask", -1);
					r_renderingLayerMask.SetBelong(this.instance);
				}
				return r_renderingLayerMask;
			}
		}

		/// <summary>
		/// Int32 rendererPriority
		/// </summary>
		protected RProperty r_rendererPriority;
		public virtual RProperty RrendererPriority
		{
			get
			{
				if(r_rendererPriority == null)
				{
					r_rendererPriority = new(this, "rendererPriority", -1);
					r_rendererPriority.SetBelong(this.instance);
				}
				return r_rendererPriority;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode
		/// </summary>
		protected RProperty r_rayTracingMode;
		public virtual RProperty RrayTracingMode
		{
			get
			{
				if(r_rayTracingMode == null)
				{
					r_rayTracingMode = new(this, "rayTracingMode", -1);
					r_rayTracingMode.SetBelong(this.instance);
				}
				return r_rayTracingMode;
			}
		}

		/// <summary>
		/// System.String sortingLayerName
		/// </summary>
		protected RProperty r_sortingLayerName;
		public virtual RProperty RsortingLayerName
		{
			get
			{
				if(r_sortingLayerName == null)
				{
					r_sortingLayerName = new(this, "sortingLayerName", -1);
					r_sortingLayerName.SetBelong(this.instance);
				}
				return r_sortingLayerName;
			}
		}

		/// <summary>
		/// Int32 sortingLayerID
		/// </summary>
		protected RProperty r_sortingLayerID;
		public virtual RProperty RsortingLayerID
		{
			get
			{
				if(r_sortingLayerID == null)
				{
					r_sortingLayerID = new(this, "sortingLayerID", -1);
					r_sortingLayerID.SetBelong(this.instance);
				}
				return r_sortingLayerID;
			}
		}

		/// <summary>
		/// Int32 sortingOrder
		/// </summary>
		protected RProperty r_sortingOrder;
		public virtual RProperty RsortingOrder
		{
			get
			{
				if(r_sortingOrder == null)
				{
					r_sortingOrder = new(this, "sortingOrder", -1);
					r_sortingOrder.SetBelong(this.instance);
				}
				return r_sortingOrder;
			}
		}

		/// <summary>
		/// Int32 sortingGroupID
		/// </summary>
		protected RProperty r_sortingGroupID;
		public virtual RProperty RsortingGroupID
		{
			get
			{
				if(r_sortingGroupID == null)
				{
					r_sortingGroupID = new(this, "sortingGroupID", -1);
					r_sortingGroupID.SetBelong(this.instance);
				}
				return r_sortingGroupID;
			}
		}

		/// <summary>
		/// Int32 sortingGroupOrder
		/// </summary>
		protected RProperty r_sortingGroupOrder;
		public virtual RProperty RsortingGroupOrder
		{
			get
			{
				if(r_sortingGroupOrder == null)
				{
					r_sortingGroupOrder = new(this, "sortingGroupOrder", -1);
					r_sortingGroupOrder.SetBelong(this.instance);
				}
				return r_sortingGroupOrder;
			}
		}

		/// <summary>
		/// Boolean allowOcclusionWhenDynamic
		/// </summary>
		protected RProperty r_allowOcclusionWhenDynamic;
		public virtual RProperty RallowOcclusionWhenDynamic
		{
			get
			{
				if(r_allowOcclusionWhenDynamic == null)
				{
					r_allowOcclusionWhenDynamic = new(this, "allowOcclusionWhenDynamic", -1);
					r_allowOcclusionWhenDynamic.SetBelong(this.instance);
				}
				return r_allowOcclusionWhenDynamic;
			}
		}

		/// <summary>
		/// UnityEngine.Transform staticBatchRootTransform
		/// </summary>
		protected RUnityEngine.RTransform r_staticBatchRootTransform;
		public virtual RUnityEngine.RTransform RstaticBatchRootTransform
		{
			get
			{
				if(r_staticBatchRootTransform == null)
				{
					r_staticBatchRootTransform = new(this, "staticBatchRootTransform", -1);
					r_staticBatchRootTransform.SetBelong(this.instance);
				}
				return r_staticBatchRootTransform;
			}
		}

		/// <summary>
		/// Int32 staticBatchIndex
		/// </summary>
		protected RProperty r_staticBatchIndex;
		public virtual RProperty RstaticBatchIndex
		{
			get
			{
				if(r_staticBatchIndex == null)
				{
					r_staticBatchIndex = new(this, "staticBatchIndex", -1);
					r_staticBatchIndex.SetBelong(this.instance);
				}
				return r_staticBatchIndex;
			}
		}

		/// <summary>
		/// Boolean isPartOfStaticBatch
		/// </summary>
		protected RProperty r_isPartOfStaticBatch;
		public virtual RProperty RisPartOfStaticBatch
		{
			get
			{
				if(r_isPartOfStaticBatch == null)
				{
					r_isPartOfStaticBatch = new(this, "isPartOfStaticBatch", -1);
					r_isPartOfStaticBatch.SetBelong(this.instance);
				}
				return r_isPartOfStaticBatch;
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
		/// UnityEngine.GameObject lightProbeProxyVolumeOverride
		/// </summary>
		protected RUnityEngine.RGameObject r_lightProbeProxyVolumeOverride;
		public virtual RUnityEngine.RGameObject RlightProbeProxyVolumeOverride
		{
			get
			{
				if(r_lightProbeProxyVolumeOverride == null)
				{
					r_lightProbeProxyVolumeOverride = new(this, "lightProbeProxyVolumeOverride", -1);
					r_lightProbeProxyVolumeOverride.SetBelong(this.instance);
				}
				return r_lightProbeProxyVolumeOverride;
			}
		}

		/// <summary>
		/// UnityEngine.Transform probeAnchor
		/// </summary>
		protected RUnityEngine.RTransform r_probeAnchor;
		public virtual RUnityEngine.RTransform RprobeAnchor
		{
			get
			{
				if(r_probeAnchor == null)
				{
					r_probeAnchor = new(this, "probeAnchor", -1);
					r_probeAnchor.SetBelong(this.instance);
				}
				return r_probeAnchor;
			}
		}

		/// <summary>
		/// Int32 lightmapIndex
		/// </summary>
		protected RProperty r_lightmapIndex;
		public virtual RProperty RlightmapIndex
		{
			get
			{
				if(r_lightmapIndex == null)
				{
					r_lightmapIndex = new(this, "lightmapIndex", -1);
					r_lightmapIndex.SetBelong(this.instance);
				}
				return r_lightmapIndex;
			}
		}

		/// <summary>
		/// Int32 realtimeLightmapIndex
		/// </summary>
		protected RProperty r_realtimeLightmapIndex;
		public virtual RProperty RrealtimeLightmapIndex
		{
			get
			{
				if(r_realtimeLightmapIndex == null)
				{
					r_realtimeLightmapIndex = new(this, "realtimeLightmapIndex", -1);
					r_realtimeLightmapIndex.SetBelong(this.instance);
				}
				return r_realtimeLightmapIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 lightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_lightmapScaleOffset;
		public virtual RUnityEngine.RVector4 RlightmapScaleOffset
		{
			get
			{
				if(r_lightmapScaleOffset == null)
				{
					r_lightmapScaleOffset = new(this, "lightmapScaleOffset", -1);
					r_lightmapScaleOffset.SetBelong(this.instance);
				}
				return r_lightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 realtimeLightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_realtimeLightmapScaleOffset;
		public virtual RUnityEngine.RVector4 RrealtimeLightmapScaleOffset
		{
			get
			{
				if(r_realtimeLightmapScaleOffset == null)
				{
					r_realtimeLightmapScaleOffset = new(this, "realtimeLightmapScaleOffset", -1);
					r_realtimeLightmapScaleOffset.SetBelong(this.instance);
				}
				return r_realtimeLightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] materials
		/// </summary>
		protected RPropertyArray<RUnityEngine.RMaterial> r_materials;
		public virtual RPropertyArray<RUnityEngine.RMaterial> Rmaterials
		{
			get
			{
				if(r_materials == null)
				{
					r_materials = new(this, "materials", -1);
					r_materials.SetBelong(this.instance);
				}
				return r_materials;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material", -1);
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// UnityEngine.Material sharedMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_sharedMaterial;
		public virtual RUnityEngine.RMaterial RsharedMaterial
		{
			get
			{
				if(r_sharedMaterial == null)
				{
					r_sharedMaterial = new(this, "sharedMaterial", -1);
					r_sharedMaterial.SetBelong(this.instance);
				}
				return r_sharedMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] sharedMaterials
		/// </summary>
		protected RPropertyArray<RUnityEngine.RMaterial> r_sharedMaterials;
		public virtual RPropertyArray<RUnityEngine.RMaterial> RsharedMaterials
		{
			get
			{
				if(r_sharedMaterials == null)
				{
					r_sharedMaterials = new(this, "sharedMaterials", -1);
					r_sharedMaterials.SetBelong(this.instance);
				}
				return r_sharedMaterials;
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
		/// Void ResetBounds()
		/// </summary>
		protected RMethod r_ResetBounds;
		public virtual RMethod RResetBounds
		{
			get
			{
				if(r_ResetBounds == null)
				{
					r_ResetBounds = new(this, "ResetBounds", 0);
					r_ResetBounds.SetBelong(this.instance);
				}
				return r_ResetBounds;
			}
		}

		/// <summary>
		/// Void ResetLocalBounds()
		/// </summary>
		protected RMethod r_ResetLocalBounds;
		public virtual RMethod RResetLocalBounds
		{
			get
			{
				if(r_ResetLocalBounds == null)
				{
					r_ResetLocalBounds = new(this, "ResetLocalBounds", 0);
					r_ResetLocalBounds.SetBelong(this.instance);
				}
				return r_ResetLocalBounds;
			}
		}

		/// <summary>
		/// Void SetStaticLightmapST(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetStaticLightmapST_Vector4;
		public virtual RMethod RSetStaticLightmapST_Vector4
		{
			get
			{
				if(r_SetStaticLightmapST_Vector4 == null)
				{
					r_SetStaticLightmapST_Vector4 = new(this, "SetStaticLightmapST", 0, typeof(UnityEngine.Vector4));
					r_SetStaticLightmapST_Vector4.SetBelong(this.instance);
				}
				return r_SetStaticLightmapST_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetMaterial()
		/// </summary>
		protected RMethod r_GetMaterial;
		public virtual RMethod RGetMaterial
		{
			get
			{
				if(r_GetMaterial == null)
				{
					r_GetMaterial = new(this, "GetMaterial", 0);
					r_GetMaterial.SetBelong(this.instance);
				}
				return r_GetMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetSharedMaterial()
		/// </summary>
		protected RMethod r_GetSharedMaterial;
		public virtual RMethod RGetSharedMaterial
		{
			get
			{
				if(r_GetSharedMaterial == null)
				{
					r_GetSharedMaterial = new(this, "GetSharedMaterial", 0);
					r_GetSharedMaterial.SetBelong(this.instance);
				}
				return r_GetSharedMaterial;
			}
		}

		/// <summary>
		/// Void SetMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_SetMaterial_Material;
		public virtual RMethod RSetMaterial_Material
		{
			get
			{
				if(r_SetMaterial_Material == null)
				{
					r_SetMaterial_Material = new(this, "SetMaterial", 0, typeof(UnityEngine.Material));
					r_SetMaterial_Material.SetBelong(this.instance);
				}
				return r_SetMaterial_Material;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] GetMaterialArray()
		/// </summary>
		protected RMethod r_GetMaterialArray;
		public virtual RMethod RGetMaterialArray
		{
			get
			{
				if(r_GetMaterialArray == null)
				{
					r_GetMaterialArray = new(this, "GetMaterialArray", 0);
					r_GetMaterialArray.SetBelong(this.instance);
				}
				return r_GetMaterialArray;
			}
		}

		/// <summary>
		/// Void CopyMaterialArray(UnityEngine.Material[])
		/// </summary>
		protected RMethod r_CopyMaterialArray_MaterialArray;
		public virtual RMethod RCopyMaterialArray_MaterialArray
		{
			get
			{
				if(r_CopyMaterialArray_MaterialArray == null)
				{
					r_CopyMaterialArray_MaterialArray = new(this, "CopyMaterialArray", 0, typeof(UnityEngine.Material).MakeArrayType());
					r_CopyMaterialArray_MaterialArray.SetBelong(this.instance);
				}
				return r_CopyMaterialArray_MaterialArray;
			}
		}

		/// <summary>
		/// Void CopySharedMaterialArray(UnityEngine.Material[])
		/// </summary>
		protected RMethod r_CopySharedMaterialArray_MaterialArray;
		public virtual RMethod RCopySharedMaterialArray_MaterialArray
		{
			get
			{
				if(r_CopySharedMaterialArray_MaterialArray == null)
				{
					r_CopySharedMaterialArray_MaterialArray = new(this, "CopySharedMaterialArray", 0, typeof(UnityEngine.Material).MakeArrayType());
					r_CopySharedMaterialArray_MaterialArray.SetBelong(this.instance);
				}
				return r_CopySharedMaterialArray_MaterialArray;
			}
		}

		/// <summary>
		/// Void SetMaterialArray(UnityEngine.Material[])
		/// </summary>
		protected RMethod r_SetMaterialArray_MaterialArray;
		public virtual RMethod RSetMaterialArray_MaterialArray
		{
			get
			{
				if(r_SetMaterialArray_MaterialArray == null)
				{
					r_SetMaterialArray_MaterialArray = new(this, "SetMaterialArray", 0, typeof(UnityEngine.Material).MakeArrayType());
					r_SetMaterialArray_MaterialArray.SetBelong(this.instance);
				}
				return r_SetMaterialArray_MaterialArray;
			}
		}

		/// <summary>
		/// Void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_Internal_SetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RInternal_SetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_Internal_SetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_Internal_SetPropertyBlock_MaterialPropertyBlock = new(this, "Internal_SetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_Internal_SetPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_Internal_SetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_Internal_GetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RInternal_GetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_Internal_GetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_Internal_GetPropertyBlock_MaterialPropertyBlock = new(this, "Internal_GetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_Internal_GetPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_Internal_GetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_Internal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
		public virtual RMethod RInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_Internal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 == null)
				{
					r_Internal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 = new(this, "Internal_SetPropertyBlockMaterialIndex", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_Internal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.SetBelong(this.instance);
				}
				return r_Internal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_Internal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
		public virtual RMethod RInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_Internal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 == null)
				{
					r_Internal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 = new(this, "Internal_GetPropertyBlockMaterialIndex", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_Internal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.SetBelong(this.instance);
				}
				return r_Internal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPropertyBlock()
		/// </summary>
		protected RMethod r_HasPropertyBlock;
		public virtual RMethod RHasPropertyBlock
		{
			get
			{
				if(r_HasPropertyBlock == null)
				{
					r_HasPropertyBlock = new(this, "HasPropertyBlock", 0);
					r_HasPropertyBlock.SetBelong(this.instance);
				}
				return r_HasPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_SetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RSetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_SetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_SetPropertyBlock_MaterialPropertyBlock = new(this, "SetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_SetPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_SetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_SetPropertyBlock_MaterialPropertyBlock_Int32;
		public virtual RMethod RSetPropertyBlock_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_SetPropertyBlock_MaterialPropertyBlock_Int32 == null)
				{
					r_SetPropertyBlock_MaterialPropertyBlock_Int32 = new(this, "SetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_SetPropertyBlock_MaterialPropertyBlock_Int32.SetBelong(this.instance);
				}
				return r_SetPropertyBlock_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_GetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RGetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_GetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_GetPropertyBlock_MaterialPropertyBlock = new(this, "GetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_GetPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_GetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_GetPropertyBlock_MaterialPropertyBlock_Int32;
		public virtual RMethod RGetPropertyBlock_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_GetPropertyBlock_MaterialPropertyBlock_Int32 == null)
				{
					r_GetPropertyBlock_MaterialPropertyBlock_Int32 = new(this, "GetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_GetPropertyBlock_MaterialPropertyBlock_Int32.SetBelong(this.instance);
				}
				return r_GetPropertyBlock_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Void GetClosestReflectionProbesInternal(System.Object)
		/// </summary>
		protected RMethod r_GetClosestReflectionProbesInternal_Object;
		public virtual RMethod RGetClosestReflectionProbesInternal_Object
		{
			get
			{
				if(r_GetClosestReflectionProbesInternal_Object == null)
				{
					r_GetClosestReflectionProbesInternal_Object = new(this, "GetClosestReflectionProbesInternal", 0, typeof(System.Object));
					r_GetClosestReflectionProbesInternal_Object.SetBelong(this.instance);
				}
				return r_GetClosestReflectionProbesInternal_Object;
			}
		}

		/// <summary>
		/// Boolean GetIsStaticShadowCaster()
		/// </summary>
		protected RMethod r_GetIsStaticShadowCaster;
		public virtual RMethod RGetIsStaticShadowCaster
		{
			get
			{
				if(r_GetIsStaticShadowCaster == null)
				{
					r_GetIsStaticShadowCaster = new(this, "GetIsStaticShadowCaster", 0);
					r_GetIsStaticShadowCaster.SetBelong(this.instance);
				}
				return r_GetIsStaticShadowCaster;
			}
		}

		/// <summary>
		/// Void SetIsStaticShadowCaster(Boolean)
		/// </summary>
		protected RMethod r_SetIsStaticShadowCaster_Boolean;
		public virtual RMethod RSetIsStaticShadowCaster_Boolean
		{
			get
			{
				if(r_SetIsStaticShadowCaster_Boolean == null)
				{
					r_SetIsStaticShadowCaster_Boolean = new(this, "SetIsStaticShadowCaster", 0, typeof(System.Boolean));
					r_SetIsStaticShadowCaster_Boolean.SetBelong(this.instance);
				}
				return r_SetIsStaticShadowCaster_Boolean;
			}
		}

		/// <summary>
		/// Void SetStaticBatchInfo(Int32, Int32)
		/// </summary>
		protected RMethod r_SetStaticBatchInfo_Int32_Int32;
		public virtual RMethod RSetStaticBatchInfo_Int32_Int32
		{
			get
			{
				if(r_SetStaticBatchInfo_Int32_Int32 == null)
				{
					r_SetStaticBatchInfo_Int32_Int32 = new(this, "SetStaticBatchInfo", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetStaticBatchInfo_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetStaticBatchInfo_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLightmapIndex(UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_GetLightmapIndex_LightmapType;
		public virtual RMethod RGetLightmapIndex_LightmapType
		{
			get
			{
				if(r_GetLightmapIndex_LightmapType == null)
				{
					r_GetLightmapIndex_LightmapType = new(this, "GetLightmapIndex", 0,  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_GetLightmapIndex_LightmapType.SetBelong(this.instance);
				}
				return r_GetLightmapIndex_LightmapType;
			}
		}

		/// <summary>
		/// Void SetLightmapIndex(Int32, UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_SetLightmapIndex_Int32_LightmapType;
		public virtual RMethod RSetLightmapIndex_Int32_LightmapType
		{
			get
			{
				if(r_SetLightmapIndex_Int32_LightmapType == null)
				{
					r_SetLightmapIndex_Int32_LightmapType = new(this, "SetLightmapIndex", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_SetLightmapIndex_Int32_LightmapType.SetBelong(this.instance);
				}
				return r_SetLightmapIndex_Int32_LightmapType;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetLightmapST(UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_GetLightmapST_LightmapType;
		public virtual RMethod RGetLightmapST_LightmapType
		{
			get
			{
				if(r_GetLightmapST_LightmapType == null)
				{
					r_GetLightmapST_LightmapType = new(this, "GetLightmapST", 0,  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_GetLightmapST_LightmapType.SetBelong(this.instance);
				}
				return r_GetLightmapST_LightmapType;
			}
		}

		/// <summary>
		/// Void SetLightmapST(UnityEngine.Vector4, UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_SetLightmapST_Vector4_LightmapType;
		public virtual RMethod RSetLightmapST_Vector4_LightmapType
		{
			get
			{
				if(r_SetLightmapST_Vector4_LightmapType == null)
				{
					r_SetLightmapST_Vector4_LightmapType = new(this, "SetLightmapST", 0, typeof(UnityEngine.Vector4),  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_SetLightmapST_Vector4_LightmapType.SetBelong(this.instance);
				}
				return r_SetLightmapST_Vector4_LightmapType;
			}
		}

		/// <summary>
		/// Int32 GetMaterialCount()
		/// </summary>
		protected RMethod r_GetMaterialCount;
		public virtual RMethod RGetMaterialCount
		{
			get
			{
				if(r_GetMaterialCount == null)
				{
					r_GetMaterialCount = new(this, "GetMaterialCount", 0);
					r_GetMaterialCount.SetBelong(this.instance);
				}
				return r_GetMaterialCount;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] GetSharedMaterialArray()
		/// </summary>
		protected RMethod r_GetSharedMaterialArray;
		public virtual RMethod RGetSharedMaterialArray
		{
			get
			{
				if(r_GetSharedMaterialArray == null)
				{
					r_GetSharedMaterialArray = new(this, "GetSharedMaterialArray", 0);
					r_GetSharedMaterialArray.SetBelong(this.instance);
				}
				return r_GetSharedMaterialArray;
			}
		}

		/// <summary>
		/// Boolean IsPersistent()
		/// </summary>
		protected RMethod r_IsPersistent;
		public virtual RMethod RIsPersistent
		{
			get
			{
				if(r_IsPersistent == null)
				{
					r_IsPersistent = new(this, "IsPersistent", 0);
					r_IsPersistent.SetBelong(this.instance);
				}
				return r_IsPersistent;
			}
		}

		/// <summary>
		/// Void GetMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_GetMaterials_List_d_Material_p_;
		public virtual RMethod RGetMaterials_List_d_Material_p_
		{
			get
			{
				if(r_GetMaterials_List_d_Material_p_ == null)
				{
					r_GetMaterials_List_d_Material_p_ = new(this, "GetMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_GetMaterials_List_d_Material_p_.SetBelong(this.instance);
				}
				return r_GetMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void SetSharedMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_SetSharedMaterials_List_d_Material_p_;
		public virtual RMethod RSetSharedMaterials_List_d_Material_p_
		{
			get
			{
				if(r_SetSharedMaterials_List_d_Material_p_ == null)
				{
					r_SetSharedMaterials_List_d_Material_p_ = new(this, "SetSharedMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_SetSharedMaterials_List_d_Material_p_.SetBelong(this.instance);
				}
				return r_SetSharedMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void SetMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_SetMaterials_List_d_Material_p_;
		public virtual RMethod RSetMaterials_List_d_Material_p_
		{
			get
			{
				if(r_SetMaterials_List_d_Material_p_ == null)
				{
					r_SetMaterials_List_d_Material_p_ = new(this, "SetMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_SetMaterials_List_d_Material_p_.SetBelong(this.instance);
				}
				return r_SetMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void GetSharedMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_GetSharedMaterials_List_d_Material_p_;
		public virtual RMethod RGetSharedMaterials_List_d_Material_p_
		{
			get
			{
				if(r_GetSharedMaterials_List_d_Material_p_ == null)
				{
					r_GetSharedMaterials_List_d_Material_p_ = new(this, "GetSharedMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_GetSharedMaterials_List_d_Material_p_.SetBelong(this.instance);
				}
				return r_GetSharedMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void GetClosestReflectionProbes(System.Collections.Generic.List`1[UnityEngine.Rendering.ReflectionProbeBlendInfo])
		/// </summary>
		protected RMethod r_GetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_;
		public virtual RMethod RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_
		{
			get
			{
				if(r_GetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_ == null)
				{
					r_GetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_ = new(this, "GetClosestReflectionProbes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo)));
					r_GetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_.SetBelong(this.instance);
				}
				return r_GetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_get_bounds_Injected_Out_Bounds;
		public virtual RMethod Rget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_get_bounds_Injected_Out_Bounds == null)
				{
					r_get_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_get_bounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_get_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_set_bounds_Injected_Ref_Bounds;
		public virtual RMethod Rset_bounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_set_bounds_Injected_Ref_Bounds == null)
				{
					r_set_bounds_Injected_Ref_Bounds = new(this, "set_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_set_bounds_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_set_bounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Void get_localBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_get_localBounds_Injected_Out_Bounds;
		public virtual RMethod Rget_localBounds_Injected_Out_Bounds
		{
			get
			{
				if(r_get_localBounds_Injected_Out_Bounds == null)
				{
					r_get_localBounds_Injected_Out_Bounds = new(this, "get_localBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_get_localBounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_get_localBounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_localBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_set_localBounds_Injected_Ref_Bounds;
		public virtual RMethod Rset_localBounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_set_localBounds_Injected_Ref_Bounds == null)
				{
					r_set_localBounds_Injected_Ref_Bounds = new(this, "set_localBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_set_localBounds_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_set_localBounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Void SetStaticLightmapST_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_SetStaticLightmapST_Injected_Ref_Vector4;
		public virtual RMethod RSetStaticLightmapST_Injected_Ref_Vector4
		{
			get
			{
				if(r_SetStaticLightmapST_Injected_Ref_Vector4 == null)
				{
					r_SetStaticLightmapST_Injected_Ref_Vector4 = new(this, "SetStaticLightmapST_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_SetStaticLightmapST_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_SetStaticLightmapST_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_worldToLocalMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_worldToLocalMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_worldToLocalMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_worldToLocalMatrix_Injected_Out_Matrix4x4 = new(this, "get_worldToLocalMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_worldToLocalMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_worldToLocalMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_localToWorldMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_localToWorldMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_localToWorldMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_localToWorldMatrix_Injected_Out_Matrix4x4 = new(this, "get_localToWorldMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_localToWorldMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_localToWorldMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetLightmapST_Injected(UnityEngineInternal.LightmapType, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_GetLightmapST_Injected_LightmapType_Out_Vector4;
		public virtual RMethod RGetLightmapST_Injected_LightmapType_Out_Vector4
		{
			get
			{
				if(r_GetLightmapST_Injected_LightmapType_Out_Vector4 == null)
				{
					r_GetLightmapST_Injected_LightmapType_Out_Vector4 = new(this, "GetLightmapST_Injected", 0,  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"), typeof(UnityEngine.Vector4).MakeByRefType());
					r_GetLightmapST_Injected_LightmapType_Out_Vector4.SetBelong(this.instance);
				}
				return r_GetLightmapST_Injected_LightmapType_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetLightmapST_Injected(UnityEngine.Vector4 ByRef, UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_SetLightmapST_Injected_Ref_Vector4_LightmapType;
		public virtual RMethod RSetLightmapST_Injected_Ref_Vector4_LightmapType
		{
			get
			{
				if(r_SetLightmapST_Injected_Ref_Vector4_LightmapType == null)
				{
					r_SetLightmapST_Injected_Ref_Vector4_LightmapType = new(this, "SetLightmapST_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType(),  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_SetLightmapST_Injected_Ref_Vector4_LightmapType.SetBelong(this.instance);
				}
				return r_SetLightmapST_Injected_Ref_Vector4_LightmapType;
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


        public RRenderer() : base("UnityEngine.Renderer")
        {
        }

        public RRenderer(System.Object instance) : base("UnityEngine.Renderer")
		{
            SetInstance(instance);
		}

        public RRenderer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResetBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetLocalBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetLocalBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStaticLightmapST(UnityEngine.Vector4  @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RSetStaticLightmapST_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material GetMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual UnityEngine.Material GetSharedMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSharedMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual void SetMaterial(UnityEngine.Material  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RSetMaterial_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material[] GetMaterialArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMaterialArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material[])___result;
        }


        public virtual void CopyMaterialArray(UnityEngine.Material[]  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RCopyMaterialArray_MaterialArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySharedMaterialArray(UnityEngine.Material[]  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RCopySharedMaterialArray_MaterialArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMaterialArray(UnityEngine.Material[]  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RSetMaterialArray_MaterialArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RInternal_SetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RInternal_GetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock  @properties, System.Int32  @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @materialIndex};
            var ___result = RInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock  @dest, System.Int32  @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @materialIndex};
            var ___result = RInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasPropertyBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasPropertyBlock.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPropertyBlock(UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RSetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPropertyBlock(UnityEngine.MaterialPropertyBlock  @properties, System.Int32  @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @materialIndex};
            var ___result = RSetPropertyBlock_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyBlock(UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RGetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyBlock(UnityEngine.MaterialPropertyBlock  @properties, System.Int32  @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @materialIndex};
            var ___result = RGetPropertyBlock_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetClosestReflectionProbesInternal(System.Object  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RGetClosestReflectionProbesInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsStaticShadowCaster()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsStaticShadowCaster.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsStaticShadowCaster(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetIsStaticShadowCaster_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStaticBatchInfo(System.Int32  @firstSubMesh, System.Int32  @subMeshCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstSubMesh, @subMeshCount};
            var ___result = RSetStaticBatchInfo_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetLightmapIndex(RType  @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lt.Value};
            var ___result = RGetLightmapIndex_LightmapType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetLightmapIndex(System.Int32  @index, RType  @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @lt.Value};
            var ___result = RSetLightmapIndex_Int32_LightmapType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector4 GetLightmapST(RType  @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lt.Value};
            var ___result = RGetLightmapST_LightmapType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void SetLightmapST(UnityEngine.Vector4  @st, RType  @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st, @lt.Value};
            var ___result = RSetLightmapST_Vector4_LightmapType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetMaterialCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMaterialCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Material[] GetSharedMaterialArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSharedMaterialArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material[])___result;
        }


        public virtual System.Boolean IsPersistent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPersistent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetMaterials(System.Collections.Generic.List<UnityEngine.Material>  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RGetMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material>  @materials)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@materials};
            var ___result = RSetSharedMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMaterials(System.Collections.Generic.List<UnityEngine.Material>  @materials)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@materials};
            var ___result = RSetMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material>  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RGetSharedMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetClosestReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_bounds_Injected(ref UnityEngine.Bounds  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_bounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void get_localBounds_Injected(out UnityEngine.Bounds  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localBounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_localBounds_Injected(ref UnityEngine.Bounds  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_localBounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void SetStaticLightmapST_Injected(ref UnityEngine.Vector4  @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RSetStaticLightmapST_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@st = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_worldToLocalMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_worldToLocalMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_localToWorldMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localToWorldMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void GetLightmapST_Injected(RType  @lt, out UnityEngine.Vector4  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lt.Value, @ret};
            var ___result = RGetLightmapST_Injected_LightmapType_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetLightmapST_Injected(ref UnityEngine.Vector4  @st, RType  @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st, @lt.Value};
            var ___result = RSetLightmapST_Injected_Ref_Vector4_LightmapType.Invoke(___genericsType, ___parameters);
			@st = (UnityEngine.Vector4)___parameters[0];

            
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
			@component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			@component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetComponent<T>(out T  @component)
        {
			@component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			@component = (T)___parameters[0];

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
