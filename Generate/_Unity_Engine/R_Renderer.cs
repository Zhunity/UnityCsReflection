
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Renderer
	/// </summary>
    public partial class RRenderer : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector4 lightmapTilingOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PlightmapTilingOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPlightmapTilingOffset
		{
			get
			{
				if(r_PlightmapTilingOffset == null)
				{
					r_PlightmapTilingOffset = new(this, "lightmapTilingOffset", -1);
					r_PlightmapTilingOffset.SetBelong(this.GetValue());
				}
				return r_PlightmapTilingOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Transform lightProbeAnchor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_PlightProbeAnchor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPlightProbeAnchor
		{
			get
			{
				if(r_PlightProbeAnchor == null)
				{
					r_PlightProbeAnchor = new(this, "lightProbeAnchor", -1);
					r_PlightProbeAnchor.SetBelong(this.GetValue());
				}
				return r_PlightProbeAnchor;
			}
		}

		/// <summary>
		/// Boolean castShadows
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcastShadows;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcastShadows
		{
			get
			{
				if(r_PcastShadows == null)
				{
					r_PcastShadows = new(this, "castShadows", -1);
					r_PcastShadows.SetBelong(this.GetValue());
				}
				return r_PcastShadows;
			}
		}

		/// <summary>
		/// Boolean motionVectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PmotionVectors;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPmotionVectors
		{
			get
			{
				if(r_PmotionVectors == null)
				{
					r_PmotionVectors = new(this, "motionVectors", -1);
					r_PmotionVectors.SetBelong(this.GetValue());
				}
				return r_PmotionVectors;
			}
		}

		/// <summary>
		/// Boolean useLightProbes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseLightProbes;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseLightProbes
		{
			get
			{
				if(r_PuseLightProbes == null)
				{
					r_PuseLightProbes = new(this, "useLightProbes", -1);
					r_PuseLightProbes.SetBelong(this.GetValue());
				}
				return r_PuseLightProbes;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBounds r_Pbounds;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBounds RPbounds
		{
			get
			{
				if(r_Pbounds == null)
				{
					r_Pbounds = new(this, "bounds", -1);
					r_Pbounds.SetBelong(this.GetValue());
				}
				return r_Pbounds;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds localBounds
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBounds r_PlocalBounds;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBounds RPlocalBounds
		{
			get
			{
				if(r_PlocalBounds == null)
				{
					r_PlocalBounds = new(this, "localBounds", -1);
					r_PlocalBounds.SetBelong(this.GetValue());
				}
				return r_PlocalBounds;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
					r_Penabled.SetBelong(this.GetValue());
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Boolean isVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisVisible
		{
			get
			{
				if(r_PisVisible == null)
				{
					r_PisVisible = new(this, "isVisible", -1);
					r_PisVisible.SetBelong(this.GetValue());
				}
				return r_PisVisible;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShadowCastingMode r_PshadowCastingMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShadowCastingMode RPshadowCastingMode
		{
			get
			{
				if(r_PshadowCastingMode == null)
				{
					r_PshadowCastingMode = new(this, "shadowCastingMode", -1);
					r_PshadowCastingMode.SetBelong(this.GetValue());
				}
				return r_PshadowCastingMode;
			}
		}

		/// <summary>
		/// Boolean receiveShadows
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PreceiveShadows;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPreceiveShadows
		{
			get
			{
				if(r_PreceiveShadows == null)
				{
					r_PreceiveShadows = new(this, "receiveShadows", -1);
					r_PreceiveShadows.SetBelong(this.GetValue());
				}
				return r_PreceiveShadows;
			}
		}

		/// <summary>
		/// Boolean forceRenderingOff
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PforceRenderingOff;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPforceRenderingOff
		{
			get
			{
				if(r_PforceRenderingOff == null)
				{
					r_PforceRenderingOff = new(this, "forceRenderingOff", -1);
					r_PforceRenderingOff.SetBelong(this.GetValue());
				}
				return r_PforceRenderingOff;
			}
		}

		/// <summary>
		/// Boolean staticShadowCaster
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstaticShadowCaster;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstaticShadowCaster
		{
			get
			{
				if(r_PstaticShadowCaster == null)
				{
					r_PstaticShadowCaster = new(this, "staticShadowCaster", -1);
					r_PstaticShadowCaster.SetBelong(this.GetValue());
				}
				return r_PstaticShadowCaster;
			}
		}

		/// <summary>
		/// UnityEngine.MotionVectorGenerationMode motionVectorGenerationMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMotionVectorGenerationMode r_PmotionVectorGenerationMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMotionVectorGenerationMode RPmotionVectorGenerationMode
		{
			get
			{
				if(r_PmotionVectorGenerationMode == null)
				{
					r_PmotionVectorGenerationMode = new(this, "motionVectorGenerationMode", -1);
					r_PmotionVectorGenerationMode.SetBelong(this.GetValue());
				}
				return r_PmotionVectorGenerationMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LightProbeUsage lightProbeUsage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLightProbeUsage r_PlightProbeUsage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLightProbeUsage RPlightProbeUsage
		{
			get
			{
				if(r_PlightProbeUsage == null)
				{
					r_PlightProbeUsage = new(this, "lightProbeUsage", -1);
					r_PlightProbeUsage.SetBelong(this.GetValue());
				}
				return r_PlightProbeUsage;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeUsage r_PreflectionProbeUsage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeUsage RPreflectionProbeUsage
		{
			get
			{
				if(r_PreflectionProbeUsage == null)
				{
					r_PreflectionProbeUsage = new(this, "reflectionProbeUsage", -1);
					r_PreflectionProbeUsage.SetBelong(this.GetValue());
				}
				return r_PreflectionProbeUsage;
			}
		}

		/// <summary>
		/// UInt32 renderingLayerMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PrenderingLayerMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPrenderingLayerMask
		{
			get
			{
				if(r_PrenderingLayerMask == null)
				{
					r_PrenderingLayerMask = new(this, "renderingLayerMask", -1);
					r_PrenderingLayerMask.SetBelong(this.GetValue());
				}
				return r_PrenderingLayerMask;
			}
		}

		/// <summary>
		/// Int32 rendererPriority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrendererPriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrendererPriority
		{
			get
			{
				if(r_PrendererPriority == null)
				{
					r_PrendererPriority = new(this, "rendererPriority", -1);
					r_PrendererPriority.SetBelong(this.GetValue());
				}
				return r_PrendererPriority;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingMode r_PrayTracingMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingMode RPrayTracingMode
		{
			get
			{
				if(r_PrayTracingMode == null)
				{
					r_PrayTracingMode = new(this, "rayTracingMode", -1);
					r_PrayTracingMode.SetBelong(this.GetValue());
				}
				return r_PrayTracingMode;
			}
		}

		/// <summary>
		/// System.String sortingLayerName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PsortingLayerName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsortingLayerName
		{
			get
			{
				if(r_PsortingLayerName == null)
				{
					r_PsortingLayerName = new(this, "sortingLayerName", -1);
					r_PsortingLayerName.SetBelong(this.GetValue());
				}
				return r_PsortingLayerName;
			}
		}

		/// <summary>
		/// Int32 sortingLayerID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsortingLayerID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsortingLayerID
		{
			get
			{
				if(r_PsortingLayerID == null)
				{
					r_PsortingLayerID = new(this, "sortingLayerID", -1);
					r_PsortingLayerID.SetBelong(this.GetValue());
				}
				return r_PsortingLayerID;
			}
		}

		/// <summary>
		/// Int32 sortingOrder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsortingOrder;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsortingOrder
		{
			get
			{
				if(r_PsortingOrder == null)
				{
					r_PsortingOrder = new(this, "sortingOrder", -1);
					r_PsortingOrder.SetBelong(this.GetValue());
				}
				return r_PsortingOrder;
			}
		}

		/// <summary>
		/// Int32 sortingGroupID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsortingGroupID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsortingGroupID
		{
			get
			{
				if(r_PsortingGroupID == null)
				{
					r_PsortingGroupID = new(this, "sortingGroupID", -1);
					r_PsortingGroupID.SetBelong(this.GetValue());
				}
				return r_PsortingGroupID;
			}
		}

		/// <summary>
		/// Int32 sortingGroupOrder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsortingGroupOrder;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsortingGroupOrder
		{
			get
			{
				if(r_PsortingGroupOrder == null)
				{
					r_PsortingGroupOrder = new(this, "sortingGroupOrder", -1);
					r_PsortingGroupOrder.SetBelong(this.GetValue());
				}
				return r_PsortingGroupOrder;
			}
		}

		/// <summary>
		/// Boolean allowOcclusionWhenDynamic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowOcclusionWhenDynamic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPallowOcclusionWhenDynamic
		{
			get
			{
				if(r_PallowOcclusionWhenDynamic == null)
				{
					r_PallowOcclusionWhenDynamic = new(this, "allowOcclusionWhenDynamic", -1);
					r_PallowOcclusionWhenDynamic.SetBelong(this.GetValue());
				}
				return r_PallowOcclusionWhenDynamic;
			}
		}

		/// <summary>
		/// UnityEngine.Transform staticBatchRootTransform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_PstaticBatchRootTransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPstaticBatchRootTransform
		{
			get
			{
				if(r_PstaticBatchRootTransform == null)
				{
					r_PstaticBatchRootTransform = new(this, "staticBatchRootTransform", -1);
					r_PstaticBatchRootTransform.SetBelong(this.GetValue());
				}
				return r_PstaticBatchRootTransform;
			}
		}

		/// <summary>
		/// Int32 staticBatchIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PstaticBatchIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPstaticBatchIndex
		{
			get
			{
				if(r_PstaticBatchIndex == null)
				{
					r_PstaticBatchIndex = new(this, "staticBatchIndex", -1);
					r_PstaticBatchIndex.SetBelong(this.GetValue());
				}
				return r_PstaticBatchIndex;
			}
		}

		/// <summary>
		/// Boolean isPartOfStaticBatch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPartOfStaticBatch;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPartOfStaticBatch
		{
			get
			{
				if(r_PisPartOfStaticBatch == null)
				{
					r_PisPartOfStaticBatch = new(this, "isPartOfStaticBatch", -1);
					r_PisPartOfStaticBatch.SetBelong(this.GetValue());
				}
				return r_PisPartOfStaticBatch;
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
					r_PworldToLocalMatrix.SetBelong(this.GetValue());
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
					r_PlocalToWorldMatrix.SetBelong(this.GetValue());
				}
				return r_PlocalToWorldMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject lightProbeProxyVolumeOverride
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGameObject r_PlightProbeProxyVolumeOverride;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGameObject RPlightProbeProxyVolumeOverride
		{
			get
			{
				if(r_PlightProbeProxyVolumeOverride == null)
				{
					r_PlightProbeProxyVolumeOverride = new(this, "lightProbeProxyVolumeOverride", -1);
					r_PlightProbeProxyVolumeOverride.SetBelong(this.GetValue());
				}
				return r_PlightProbeProxyVolumeOverride;
			}
		}

		/// <summary>
		/// UnityEngine.Transform probeAnchor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_PprobeAnchor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPprobeAnchor
		{
			get
			{
				if(r_PprobeAnchor == null)
				{
					r_PprobeAnchor = new(this, "probeAnchor", -1);
					r_PprobeAnchor.SetBelong(this.GetValue());
				}
				return r_PprobeAnchor;
			}
		}

		/// <summary>
		/// Int32 lightmapIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PlightmapIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlightmapIndex
		{
			get
			{
				if(r_PlightmapIndex == null)
				{
					r_PlightmapIndex = new(this, "lightmapIndex", -1);
					r_PlightmapIndex.SetBelong(this.GetValue());
				}
				return r_PlightmapIndex;
			}
		}

		/// <summary>
		/// Int32 realtimeLightmapIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrealtimeLightmapIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrealtimeLightmapIndex
		{
			get
			{
				if(r_PrealtimeLightmapIndex == null)
				{
					r_PrealtimeLightmapIndex = new(this, "realtimeLightmapIndex", -1);
					r_PrealtimeLightmapIndex.SetBelong(this.GetValue());
				}
				return r_PrealtimeLightmapIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 lightmapScaleOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PlightmapScaleOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPlightmapScaleOffset
		{
			get
			{
				if(r_PlightmapScaleOffset == null)
				{
					r_PlightmapScaleOffset = new(this, "lightmapScaleOffset", -1);
					r_PlightmapScaleOffset.SetBelong(this.GetValue());
				}
				return r_PlightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 realtimeLightmapScaleOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PrealtimeLightmapScaleOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPrealtimeLightmapScaleOffset
		{
			get
			{
				if(r_PrealtimeLightmapScaleOffset == null)
				{
					r_PrealtimeLightmapScaleOffset = new(this, "realtimeLightmapScaleOffset", -1);
					r_PrealtimeLightmapScaleOffset.SetBelong(this.GetValue());
				}
				return r_PrealtimeLightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] materials
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RMaterial> r_Pmaterials;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RMaterial> RPmaterials
		{
			get
			{
				if(r_Pmaterials == null)
				{
					r_Pmaterials = new(this, "materials", -1);
					r_Pmaterials.SetBelong(this.GetValue());
				}
				return r_Pmaterials;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Pmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPmaterial
		{
			get
			{
				if(r_Pmaterial == null)
				{
					r_Pmaterial = new(this, "material", -1);
					r_Pmaterial.SetBelong(this.GetValue());
				}
				return r_Pmaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material sharedMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_PsharedMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPsharedMaterial
		{
			get
			{
				if(r_PsharedMaterial == null)
				{
					r_PsharedMaterial = new(this, "sharedMaterial", -1);
					r_PsharedMaterial.SetBelong(this.GetValue());
				}
				return r_PsharedMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] sharedMaterials
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RMaterial> r_PsharedMaterials;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RMaterial> RPsharedMaterials
		{
			get
			{
				if(r_PsharedMaterials == null)
				{
					r_PsharedMaterials = new(this, "sharedMaterials", -1);
					r_PsharedMaterials.SetBelong(this.GetValue());
				}
				return r_PsharedMaterials;
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
					r_Ptransform.SetBelong(this.GetValue());
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
					r_PgameObject.SetBelong(this.GetValue());
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
					r_Ptag.SetBelong(this.GetValue());
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
		/// Void ResetBounds()
		/// </summary>
		protected RMethod r_MResetBounds;
		public virtual RMethod RMResetBounds
		{
			get
			{
				if(r_MResetBounds == null)
				{
					r_MResetBounds = new(this, "ResetBounds", 0);
					r_MResetBounds.SetBelong(this.GetValue());
				}
				return r_MResetBounds;
			}
		}

		/// <summary>
		/// Void ResetLocalBounds()
		/// </summary>
		protected RMethod r_MResetLocalBounds;
		public virtual RMethod RMResetLocalBounds
		{
			get
			{
				if(r_MResetLocalBounds == null)
				{
					r_MResetLocalBounds = new(this, "ResetLocalBounds", 0);
					r_MResetLocalBounds.SetBelong(this.GetValue());
				}
				return r_MResetLocalBounds;
			}
		}

		/// <summary>
		/// Void SetStaticLightmapST(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetStaticLightmapST_Vector4;
		public virtual RMethod RMSetStaticLightmapST_Vector4
		{
			get
			{
				if(r_MSetStaticLightmapST_Vector4 == null)
				{
					r_MSetStaticLightmapST_Vector4 = new(this, "SetStaticLightmapST", 0, typeof(UnityEngine.Vector4));
					r_MSetStaticLightmapST_Vector4.SetBelong(this.GetValue());
				}
				return r_MSetStaticLightmapST_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetMaterial()
		/// </summary>
		protected RMethod r_MGetMaterial;
		public virtual RMethod RMGetMaterial
		{
			get
			{
				if(r_MGetMaterial == null)
				{
					r_MGetMaterial = new(this, "GetMaterial", 0);
					r_MGetMaterial.SetBelong(this.GetValue());
				}
				return r_MGetMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetSharedMaterial()
		/// </summary>
		protected RMethod r_MGetSharedMaterial;
		public virtual RMethod RMGetSharedMaterial
		{
			get
			{
				if(r_MGetSharedMaterial == null)
				{
					r_MGetSharedMaterial = new(this, "GetSharedMaterial", 0);
					r_MGetSharedMaterial.SetBelong(this.GetValue());
				}
				return r_MGetSharedMaterial;
			}
		}

		/// <summary>
		/// Void SetMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_MSetMaterial_Material;
		public virtual RMethod RMSetMaterial_Material
		{
			get
			{
				if(r_MSetMaterial_Material == null)
				{
					r_MSetMaterial_Material = new(this, "SetMaterial", 0, typeof(UnityEngine.Material));
					r_MSetMaterial_Material.SetBelong(this.GetValue());
				}
				return r_MSetMaterial_Material;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] GetMaterialArray()
		/// </summary>
		protected RMethod r_MGetMaterialArray;
		public virtual RMethod RMGetMaterialArray
		{
			get
			{
				if(r_MGetMaterialArray == null)
				{
					r_MGetMaterialArray = new(this, "GetMaterialArray", 0);
					r_MGetMaterialArray.SetBelong(this.GetValue());
				}
				return r_MGetMaterialArray;
			}
		}

		/// <summary>
		/// Void CopyMaterialArray(UnityEngine.Material[])
		/// </summary>
		protected RMethod r_MCopyMaterialArray_MaterialArray;
		public virtual RMethod RMCopyMaterialArray_MaterialArray
		{
			get
			{
				if(r_MCopyMaterialArray_MaterialArray == null)
				{
					r_MCopyMaterialArray_MaterialArray = new(this, "CopyMaterialArray", 0, typeof(UnityEngine.Material).MakeArrayType());
					r_MCopyMaterialArray_MaterialArray.SetBelong(this.GetValue());
				}
				return r_MCopyMaterialArray_MaterialArray;
			}
		}

		/// <summary>
		/// Void CopySharedMaterialArray(UnityEngine.Material[])
		/// </summary>
		protected RMethod r_MCopySharedMaterialArray_MaterialArray;
		public virtual RMethod RMCopySharedMaterialArray_MaterialArray
		{
			get
			{
				if(r_MCopySharedMaterialArray_MaterialArray == null)
				{
					r_MCopySharedMaterialArray_MaterialArray = new(this, "CopySharedMaterialArray", 0, typeof(UnityEngine.Material).MakeArrayType());
					r_MCopySharedMaterialArray_MaterialArray.SetBelong(this.GetValue());
				}
				return r_MCopySharedMaterialArray_MaterialArray;
			}
		}

		/// <summary>
		/// Void SetMaterialArray(UnityEngine.Material[])
		/// </summary>
		protected RMethod r_MSetMaterialArray_MaterialArray;
		public virtual RMethod RMSetMaterialArray_MaterialArray
		{
			get
			{
				if(r_MSetMaterialArray_MaterialArray == null)
				{
					r_MSetMaterialArray_MaterialArray = new(this, "SetMaterialArray", 0, typeof(UnityEngine.Material).MakeArrayType());
					r_MSetMaterialArray_MaterialArray.SetBelong(this.GetValue());
				}
				return r_MSetMaterialArray_MaterialArray;
			}
		}

		/// <summary>
		/// Void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_SetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RMInternal_SetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_SetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_MInternal_SetPropertyBlock_MaterialPropertyBlock = new(this, "Internal_SetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_MInternal_SetPropertyBlock_MaterialPropertyBlock.SetBelong(this.GetValue());
				}
				return r_MInternal_SetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MInternal_GetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RMInternal_GetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_MInternal_GetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_MInternal_GetPropertyBlock_MaterialPropertyBlock = new(this, "Internal_GetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_MInternal_GetPropertyBlock_MaterialPropertyBlock.SetBelong(this.GetValue());
				}
				return r_MInternal_GetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_MInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
		public virtual RMethod RMInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_MInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 == null)
				{
					r_MInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 = new(this, "Internal_SetPropertyBlockMaterialIndex", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_MInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.SetBelong(this.GetValue());
				}
				return r_MInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_MInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
		public virtual RMethod RMInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_MInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 == null)
				{
					r_MInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32 = new(this, "Internal_GetPropertyBlockMaterialIndex", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_MInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.SetBelong(this.GetValue());
				}
				return r_MInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPropertyBlock()
		/// </summary>
		protected RMethod r_MHasPropertyBlock;
		public virtual RMethod RMHasPropertyBlock
		{
			get
			{
				if(r_MHasPropertyBlock == null)
				{
					r_MHasPropertyBlock = new(this, "HasPropertyBlock", 0);
					r_MHasPropertyBlock.SetBelong(this.GetValue());
				}
				return r_MHasPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MSetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RMSetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_MSetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_MSetPropertyBlock_MaterialPropertyBlock = new(this, "SetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_MSetPropertyBlock_MaterialPropertyBlock.SetBelong(this.GetValue());
				}
				return r_MSetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_MSetPropertyBlock_MaterialPropertyBlock_Int32;
		public virtual RMethod RMSetPropertyBlock_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_MSetPropertyBlock_MaterialPropertyBlock_Int32 == null)
				{
					r_MSetPropertyBlock_MaterialPropertyBlock_Int32 = new(this, "SetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_MSetPropertyBlock_MaterialPropertyBlock_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPropertyBlock_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MGetPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RMGetPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_MGetPropertyBlock_MaterialPropertyBlock == null)
				{
					r_MGetPropertyBlock_MaterialPropertyBlock = new(this, "GetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_MGetPropertyBlock_MaterialPropertyBlock.SetBelong(this.GetValue());
				}
				return r_MGetPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock, Int32)
		/// </summary>
		protected RMethod r_MGetPropertyBlock_MaterialPropertyBlock_Int32;
		public virtual RMethod RMGetPropertyBlock_MaterialPropertyBlock_Int32
		{
			get
			{
				if(r_MGetPropertyBlock_MaterialPropertyBlock_Int32 == null)
				{
					r_MGetPropertyBlock_MaterialPropertyBlock_Int32 = new(this, "GetPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Int32));
					r_MGetPropertyBlock_MaterialPropertyBlock_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPropertyBlock_MaterialPropertyBlock_Int32;
			}
		}

		/// <summary>
		/// Void GetClosestReflectionProbesInternal(System.Object)
		/// </summary>
		protected RMethod r_MGetClosestReflectionProbesInternal_Object;
		public virtual RMethod RMGetClosestReflectionProbesInternal_Object
		{
			get
			{
				if(r_MGetClosestReflectionProbesInternal_Object == null)
				{
					r_MGetClosestReflectionProbesInternal_Object = new(this, "GetClosestReflectionProbesInternal", 0, typeof(System.Object));
					r_MGetClosestReflectionProbesInternal_Object.SetBelong(this.GetValue());
				}
				return r_MGetClosestReflectionProbesInternal_Object;
			}
		}

		/// <summary>
		/// Boolean GetIsStaticShadowCaster()
		/// </summary>
		protected RMethod r_MGetIsStaticShadowCaster;
		public virtual RMethod RMGetIsStaticShadowCaster
		{
			get
			{
				if(r_MGetIsStaticShadowCaster == null)
				{
					r_MGetIsStaticShadowCaster = new(this, "GetIsStaticShadowCaster", 0);
					r_MGetIsStaticShadowCaster.SetBelong(this.GetValue());
				}
				return r_MGetIsStaticShadowCaster;
			}
		}

		/// <summary>
		/// Void SetIsStaticShadowCaster(Boolean)
		/// </summary>
		protected RMethod r_MSetIsStaticShadowCaster_Boolean;
		public virtual RMethod RMSetIsStaticShadowCaster_Boolean
		{
			get
			{
				if(r_MSetIsStaticShadowCaster_Boolean == null)
				{
					r_MSetIsStaticShadowCaster_Boolean = new(this, "SetIsStaticShadowCaster", 0, typeof(System.Boolean));
					r_MSetIsStaticShadowCaster_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetIsStaticShadowCaster_Boolean;
			}
		}

		/// <summary>
		/// Void SetStaticBatchInfo(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetStaticBatchInfo_Int32_Int32;
		public virtual RMethod RMSetStaticBatchInfo_Int32_Int32
		{
			get
			{
				if(r_MSetStaticBatchInfo_Int32_Int32 == null)
				{
					r_MSetStaticBatchInfo_Int32_Int32 = new(this, "SetStaticBatchInfo", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetStaticBatchInfo_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetStaticBatchInfo_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetLightmapIndex(UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_MGetLightmapIndex_LightmapType;
		public virtual RMethod RMGetLightmapIndex_LightmapType
		{
			get
			{
				if(r_MGetLightmapIndex_LightmapType == null)
				{
					r_MGetLightmapIndex_LightmapType = new(this, "GetLightmapIndex", 0,  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_MGetLightmapIndex_LightmapType.SetBelong(this.GetValue());
				}
				return r_MGetLightmapIndex_LightmapType;
			}
		}

		/// <summary>
		/// Void SetLightmapIndex(Int32, UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_MSetLightmapIndex_Int32_LightmapType;
		public virtual RMethod RMSetLightmapIndex_Int32_LightmapType
		{
			get
			{
				if(r_MSetLightmapIndex_Int32_LightmapType == null)
				{
					r_MSetLightmapIndex_Int32_LightmapType = new(this, "SetLightmapIndex", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_MSetLightmapIndex_Int32_LightmapType.SetBelong(this.GetValue());
				}
				return r_MSetLightmapIndex_Int32_LightmapType;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetLightmapST(UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_MGetLightmapST_LightmapType;
		public virtual RMethod RMGetLightmapST_LightmapType
		{
			get
			{
				if(r_MGetLightmapST_LightmapType == null)
				{
					r_MGetLightmapST_LightmapType = new(this, "GetLightmapST", 0,  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_MGetLightmapST_LightmapType.SetBelong(this.GetValue());
				}
				return r_MGetLightmapST_LightmapType;
			}
		}

		/// <summary>
		/// Void SetLightmapST(UnityEngine.Vector4, UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_MSetLightmapST_Vector4_LightmapType;
		public virtual RMethod RMSetLightmapST_Vector4_LightmapType
		{
			get
			{
				if(r_MSetLightmapST_Vector4_LightmapType == null)
				{
					r_MSetLightmapST_Vector4_LightmapType = new(this, "SetLightmapST", 0, typeof(UnityEngine.Vector4),  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_MSetLightmapST_Vector4_LightmapType.SetBelong(this.GetValue());
				}
				return r_MSetLightmapST_Vector4_LightmapType;
			}
		}

		/// <summary>
		/// Int32 GetMaterialCount()
		/// </summary>
		protected RMethod r_MGetMaterialCount;
		public virtual RMethod RMGetMaterialCount
		{
			get
			{
				if(r_MGetMaterialCount == null)
				{
					r_MGetMaterialCount = new(this, "GetMaterialCount", 0);
					r_MGetMaterialCount.SetBelong(this.GetValue());
				}
				return r_MGetMaterialCount;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] GetSharedMaterialArray()
		/// </summary>
		protected RMethod r_MGetSharedMaterialArray;
		public virtual RMethod RMGetSharedMaterialArray
		{
			get
			{
				if(r_MGetSharedMaterialArray == null)
				{
					r_MGetSharedMaterialArray = new(this, "GetSharedMaterialArray", 0);
					r_MGetSharedMaterialArray.SetBelong(this.GetValue());
				}
				return r_MGetSharedMaterialArray;
			}
		}

		/// <summary>
		/// Boolean IsPersistent()
		/// </summary>
		protected RMethod r_MIsPersistent;
		public virtual RMethod RMIsPersistent
		{
			get
			{
				if(r_MIsPersistent == null)
				{
					r_MIsPersistent = new(this, "IsPersistent", 0);
					r_MIsPersistent.SetBelong(this.GetValue());
				}
				return r_MIsPersistent;
			}
		}

		/// <summary>
		/// Void GetMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_MGetMaterials_List_d_Material_p_;
		public virtual RMethod RMGetMaterials_List_d_Material_p_
		{
			get
			{
				if(r_MGetMaterials_List_d_Material_p_ == null)
				{
					r_MGetMaterials_List_d_Material_p_ = new(this, "GetMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_MGetMaterials_List_d_Material_p_.SetBelong(this.GetValue());
				}
				return r_MGetMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void SetSharedMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_MSetSharedMaterials_List_d_Material_p_;
		public virtual RMethod RMSetSharedMaterials_List_d_Material_p_
		{
			get
			{
				if(r_MSetSharedMaterials_List_d_Material_p_ == null)
				{
					r_MSetSharedMaterials_List_d_Material_p_ = new(this, "SetSharedMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_MSetSharedMaterials_List_d_Material_p_.SetBelong(this.GetValue());
				}
				return r_MSetSharedMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void SetMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_MSetMaterials_List_d_Material_p_;
		public virtual RMethod RMSetMaterials_List_d_Material_p_
		{
			get
			{
				if(r_MSetMaterials_List_d_Material_p_ == null)
				{
					r_MSetMaterials_List_d_Material_p_ = new(this, "SetMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_MSetMaterials_List_d_Material_p_.SetBelong(this.GetValue());
				}
				return r_MSetMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void GetSharedMaterials(System.Collections.Generic.List`1[UnityEngine.Material])
		/// </summary>
		protected RMethod r_MGetSharedMaterials_List_d_Material_p_;
		public virtual RMethod RMGetSharedMaterials_List_d_Material_p_
		{
			get
			{
				if(r_MGetSharedMaterials_List_d_Material_p_ == null)
				{
					r_MGetSharedMaterials_List_d_Material_p_ = new(this, "GetSharedMaterials", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Material)));
					r_MGetSharedMaterials_List_d_Material_p_.SetBelong(this.GetValue());
				}
				return r_MGetSharedMaterials_List_d_Material_p_;
			}
		}

		/// <summary>
		/// Void GetClosestReflectionProbes(System.Collections.Generic.List`1[UnityEngine.Rendering.ReflectionProbeBlendInfo])
		/// </summary>
		protected RMethod r_MGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_;
		public virtual RMethod RMGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_
		{
			get
			{
				if(r_MGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_ == null)
				{
					r_MGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_ = new(this, "GetClosestReflectionProbes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo)));
					r_MGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_.SetBelong(this.GetValue());
				}
				return r_MGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mget_bounds_Injected_Out_Bounds;
		public virtual RMethod RMget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Mget_bounds_Injected_Out_Bounds == null)
				{
					r_Mget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Mget_bounds_Injected_Out_Bounds.SetBelong(this.GetValue());
				}
				return r_Mget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mset_bounds_Injected_Ref_Bounds;
		public virtual RMethod RMset_bounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_Mset_bounds_Injected_Ref_Bounds == null)
				{
					r_Mset_bounds_Injected_Ref_Bounds = new(this, "set_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Mset_bounds_Injected_Ref_Bounds.SetBelong(this.GetValue());
				}
				return r_Mset_bounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Void get_localBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mget_localBounds_Injected_Out_Bounds;
		public virtual RMethod RMget_localBounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Mget_localBounds_Injected_Out_Bounds == null)
				{
					r_Mget_localBounds_Injected_Out_Bounds = new(this, "get_localBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Mget_localBounds_Injected_Out_Bounds.SetBelong(this.GetValue());
				}
				return r_Mget_localBounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_localBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mset_localBounds_Injected_Ref_Bounds;
		public virtual RMethod RMset_localBounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_Mset_localBounds_Injected_Ref_Bounds == null)
				{
					r_Mset_localBounds_Injected_Ref_Bounds = new(this, "set_localBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Mset_localBounds_Injected_Ref_Bounds.SetBelong(this.GetValue());
				}
				return r_Mset_localBounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Void SetStaticLightmapST_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetStaticLightmapST_Injected_Ref_Vector4;
		public virtual RMethod RMSetStaticLightmapST_Injected_Ref_Vector4
		{
			get
			{
				if(r_MSetStaticLightmapST_Injected_Ref_Vector4 == null)
				{
					r_MSetStaticLightmapST_Injected_Ref_Vector4 = new(this, "SetStaticLightmapST_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_MSetStaticLightmapST_Injected_Ref_Vector4.SetBelong(this.GetValue());
				}
				return r_MSetStaticLightmapST_Injected_Ref_Vector4;
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
					r_Mget_worldToLocalMatrix_Injected_Out_Matrix4x4.SetBelong(this.GetValue());
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
					r_Mget_localToWorldMatrix_Injected_Out_Matrix4x4.SetBelong(this.GetValue());
				}
				return r_Mget_localToWorldMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetLightmapST_Injected(UnityEngineInternal.LightmapType, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MGetLightmapST_Injected_LightmapType_Out_Vector4;
		public virtual RMethod RMGetLightmapST_Injected_LightmapType_Out_Vector4
		{
			get
			{
				if(r_MGetLightmapST_Injected_LightmapType_Out_Vector4 == null)
				{
					r_MGetLightmapST_Injected_LightmapType_Out_Vector4 = new(this, "GetLightmapST_Injected", 0,  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MGetLightmapST_Injected_LightmapType_Out_Vector4.SetBelong(this.GetValue());
				}
				return r_MGetLightmapST_Injected_LightmapType_Out_Vector4;
			}
		}

		/// <summary>
		/// Void SetLightmapST_Injected(UnityEngine.Vector4 ByRef, UnityEngineInternal.LightmapType)
		/// </summary>
		protected RMethod r_MSetLightmapST_Injected_Ref_Vector4_LightmapType;
		public virtual RMethod RMSetLightmapST_Injected_Ref_Vector4_LightmapType
		{
			get
			{
				if(r_MSetLightmapST_Injected_Ref_Vector4_LightmapType == null)
				{
					r_MSetLightmapST_Injected_Ref_Vector4_LightmapType = new(this, "SetLightmapST_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType(),  ReflectionUtils.GetType("UnityEngineInternal.LightmapType"));
					r_MSetLightmapST_Injected_Ref_Vector4_LightmapType.SetBelong(this.GetValue());
				}
				return r_MSetLightmapST_Injected_Ref_Vector4_LightmapType;
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
					r_MGetCoupledComponent.SetBelong(this.GetValue());
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
					r_MIsCoupledComponent.SetBelong(this.GetValue());
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
            var ___result = RMResetBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetLocalBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetLocalBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStaticLightmapST(UnityEngine.Vector4 @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RMSetStaticLightmapST_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material GetMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual UnityEngine.Material GetSharedMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSharedMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual void SetMaterial(UnityEngine.Material @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMSetMaterial_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material[] GetMaterialArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMaterialArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material[])___result;
        }


        public virtual void CopyMaterialArray(UnityEngine.Material[] @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMCopyMaterialArray_MaterialArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySharedMaterialArray(UnityEngine.Material[] @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMCopySharedMaterialArray_MaterialArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMaterialArray(UnityEngine.Material[] @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMSetMaterialArray_MaterialArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RMInternal_SetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RMInternal_GetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock @properties, System.Int32 @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @materialIndex};
            var ___result = RMInternal_SetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock @dest, System.Int32 @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @materialIndex};
            var ___result = RMInternal_GetPropertyBlockMaterialIndex_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasPropertyBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasPropertyBlock.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPropertyBlock(UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RMSetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPropertyBlock(UnityEngine.MaterialPropertyBlock @properties, System.Int32 @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @materialIndex};
            var ___result = RMSetPropertyBlock_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyBlock(UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RMGetPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPropertyBlock(UnityEngine.MaterialPropertyBlock @properties, System.Int32 @materialIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties, @materialIndex};
            var ___result = RMGetPropertyBlock_MaterialPropertyBlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetClosestReflectionProbesInternal(System.Object @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMGetClosestReflectionProbesInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsStaticShadowCaster()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsStaticShadowCaster.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetIsStaticShadowCaster(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetIsStaticShadowCaster_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStaticBatchInfo(System.Int32 @firstSubMesh, System.Int32 @subMeshCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstSubMesh, @subMeshCount};
            var ___result = RMSetStaticBatchInfo_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetLightmapIndex(Hvak.Editor.Refleaction.RUnityEngineInternal.RLightmapType @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lt.Value};
            var ___result = RMGetLightmapIndex_LightmapType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetLightmapIndex(System.Int32 @index, Hvak.Editor.Refleaction.RUnityEngineInternal.RLightmapType @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @lt.Value};
            var ___result = RMSetLightmapIndex_Int32_LightmapType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector4 GetLightmapST(Hvak.Editor.Refleaction.RUnityEngineInternal.RLightmapType @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lt.Value};
            var ___result = RMGetLightmapST_LightmapType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual void SetLightmapST(UnityEngine.Vector4 @st, Hvak.Editor.Refleaction.RUnityEngineInternal.RLightmapType @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st, @lt.Value};
            var ___result = RMSetLightmapST_Vector4_LightmapType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetMaterialCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMaterialCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Material[] GetSharedMaterialArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSharedMaterialArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material[])___result;
        }


        public virtual System.Boolean IsPersistent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsPersistent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetMaterials(System.Collections.Generic.List<UnityEngine.Material> @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMGetMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> @materials)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@materials};
            var ___result = RMSetSharedMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMaterials(System.Collections.Generic.List<UnityEngine.Material> @materials)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@materials};
            var ___result = RMSetMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RMGetSharedMaterials_List_d_Material_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetClosestReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_bounds_Injected(ref UnityEngine.Bounds @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_bounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void get_localBounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_localBounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_localBounds_Injected(ref UnityEngine.Bounds @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_localBounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void SetStaticLightmapST_Injected(ref UnityEngine.Vector4 @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RMSetStaticLightmapST_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@st = (UnityEngine.Vector4)___parameters[0];

            
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


        public virtual void GetLightmapST_Injected(Hvak.Editor.Refleaction.RUnityEngineInternal.RLightmapType @lt, out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lt.Value, @ret};
            var ___result = RMGetLightmapST_Injected_LightmapType_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetLightmapST_Injected(ref UnityEngine.Vector4 @st, Hvak.Editor.Refleaction.RUnityEngineInternal.RLightmapType @lt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st, @lt.Value};
            var ___result = RMSetLightmapST_Injected_Ref_Vector4_LightmapType.Invoke(___genericsType, ___parameters);
			@st = (UnityEngine.Vector4)___parameters[0];

            
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
