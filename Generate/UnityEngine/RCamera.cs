using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Camera
	/// </summary>
    public partial class RCamera : RMember //
    {

		/// <summary>
		/// System.Single kMinAperture
		/// </summary>
		protected static RField r_kMinAperture;
		public static RField RkMinAperture
		{
			get
			{
				if(r_kMinAperture == null)
				{
					r_kMinAperture = new(typeof(UnityEngine.Camera), "kMinAperture");
					r_kMinAperture.SetBelong(null);
				}
				return r_kMinAperture;
			}
		}

		/// <summary>
		/// System.Single kMaxAperture
		/// </summary>
		protected static RField r_kMaxAperture;
		public static RField RkMaxAperture
		{
			get
			{
				if(r_kMaxAperture == null)
				{
					r_kMaxAperture = new(typeof(UnityEngine.Camera), "kMaxAperture");
					r_kMaxAperture.SetBelong(null);
				}
				return r_kMaxAperture;
			}
		}

		/// <summary>
		/// System.Int32 kMinBladeCount
		/// </summary>
		protected static RField r_kMinBladeCount;
		public static RField RkMinBladeCount
		{
			get
			{
				if(r_kMinBladeCount == null)
				{
					r_kMinBladeCount = new(typeof(UnityEngine.Camera), "kMinBladeCount");
					r_kMinBladeCount.SetBelong(null);
				}
				return r_kMinBladeCount;
			}
		}

		/// <summary>
		/// System.Int32 kMaxBladeCount
		/// </summary>
		protected static RField r_kMaxBladeCount;
		public static RField RkMaxBladeCount
		{
			get
			{
				if(r_kMaxBladeCount == null)
				{
					r_kMaxBladeCount = new(typeof(UnityEngine.Camera), "kMaxBladeCount");
					r_kMaxBladeCount.SetBelong(null);
				}
				return r_kMaxBladeCount;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+CameraCallback onPreCull
		/// </summary>
		protected static RUnityEngine.RCamera.RCameraCallback r_onPreCull;
		public static RUnityEngine.RCamera.RCameraCallback RonPreCull
		{
			get
			{
				if(r_onPreCull == null)
				{
					r_onPreCull = new(typeof(UnityEngine.Camera), "onPreCull");
					r_onPreCull.SetBelong(null);
				}
				return r_onPreCull;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+CameraCallback onPreRender
		/// </summary>
		protected static RUnityEngine.RCamera.RCameraCallback r_onPreRender;
		public static RUnityEngine.RCamera.RCameraCallback RonPreRender
		{
			get
			{
				if(r_onPreRender == null)
				{
					r_onPreRender = new(typeof(UnityEngine.Camera), "onPreRender");
					r_onPreRender.SetBelong(null);
				}
				return r_onPreRender;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+CameraCallback onPostRender
		/// </summary>
		protected static RUnityEngine.RCamera.RCameraCallback r_onPostRender;
		public static RUnityEngine.RCamera.RCameraCallback RonPostRender
		{
			get
			{
				if(r_onPostRender == null)
				{
					r_onPostRender = new(typeof(UnityEngine.Camera), "onPostRender");
					r_onPostRender.SetBelong(null);
				}
				return r_onPostRender;
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
		/// Single fieldOfView
		/// </summary>
		protected RProperty r_fieldOfView;
		public virtual RProperty RfieldOfView
		{
			get
			{
				if(r_fieldOfView == null)
				{
					r_fieldOfView = new(this, "fieldOfView", -1);
					r_fieldOfView.SetBelong(this.instance);
				}
				return r_fieldOfView;
			}
		}

		/// <summary>
		/// UnityEngine.RenderingPath renderingPath
		/// </summary>
		protected RProperty r_renderingPath;
		public virtual RProperty RrenderingPath
		{
			get
			{
				if(r_renderingPath == null)
				{
					r_renderingPath = new(this, "renderingPath", -1);
					r_renderingPath.SetBelong(this.instance);
				}
				return r_renderingPath;
			}
		}

		/// <summary>
		/// UnityEngine.RenderingPath actualRenderingPath
		/// </summary>
		protected RProperty r_actualRenderingPath;
		public virtual RProperty RactualRenderingPath
		{
			get
			{
				if(r_actualRenderingPath == null)
				{
					r_actualRenderingPath = new(this, "actualRenderingPath", -1);
					r_actualRenderingPath.SetBelong(this.instance);
				}
				return r_actualRenderingPath;
			}
		}

		/// <summary>
		/// Boolean allowHDR
		/// </summary>
		protected RProperty r_allowHDR;
		public virtual RProperty RallowHDR
		{
			get
			{
				if(r_allowHDR == null)
				{
					r_allowHDR = new(this, "allowHDR", -1);
					r_allowHDR.SetBelong(this.instance);
				}
				return r_allowHDR;
			}
		}

		/// <summary>
		/// Boolean allowMSAA
		/// </summary>
		protected RProperty r_allowMSAA;
		public virtual RProperty RallowMSAA
		{
			get
			{
				if(r_allowMSAA == null)
				{
					r_allowMSAA = new(this, "allowMSAA", -1);
					r_allowMSAA.SetBelong(this.instance);
				}
				return r_allowMSAA;
			}
		}

		/// <summary>
		/// Boolean allowDynamicResolution
		/// </summary>
		protected RProperty r_allowDynamicResolution;
		public virtual RProperty RallowDynamicResolution
		{
			get
			{
				if(r_allowDynamicResolution == null)
				{
					r_allowDynamicResolution = new(this, "allowDynamicResolution", -1);
					r_allowDynamicResolution.SetBelong(this.instance);
				}
				return r_allowDynamicResolution;
			}
		}

		/// <summary>
		/// Boolean forceIntoRenderTexture
		/// </summary>
		protected RProperty r_forceIntoRenderTexture;
		public virtual RProperty RforceIntoRenderTexture
		{
			get
			{
				if(r_forceIntoRenderTexture == null)
				{
					r_forceIntoRenderTexture = new(this, "forceIntoRenderTexture", -1);
					r_forceIntoRenderTexture.SetBelong(this.instance);
				}
				return r_forceIntoRenderTexture;
			}
		}

		/// <summary>
		/// Single orthographicSize
		/// </summary>
		protected RProperty r_orthographicSize;
		public virtual RProperty RorthographicSize
		{
			get
			{
				if(r_orthographicSize == null)
				{
					r_orthographicSize = new(this, "orthographicSize", -1);
					r_orthographicSize.SetBelong(this.instance);
				}
				return r_orthographicSize;
			}
		}

		/// <summary>
		/// Boolean orthographic
		/// </summary>
		protected RProperty r_orthographic;
		public virtual RProperty Rorthographic
		{
			get
			{
				if(r_orthographic == null)
				{
					r_orthographic = new(this, "orthographic", -1);
					r_orthographic.SetBelong(this.instance);
				}
				return r_orthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.OpaqueSortMode opaqueSortMode
		/// </summary>
		protected RProperty r_opaqueSortMode;
		public virtual RProperty RopaqueSortMode
		{
			get
			{
				if(r_opaqueSortMode == null)
				{
					r_opaqueSortMode = new(this, "opaqueSortMode", -1);
					r_opaqueSortMode.SetBelong(this.instance);
				}
				return r_opaqueSortMode;
			}
		}

		/// <summary>
		/// UnityEngine.TransparencySortMode transparencySortMode
		/// </summary>
		protected RProperty r_transparencySortMode;
		public virtual RProperty RtransparencySortMode
		{
			get
			{
				if(r_transparencySortMode == null)
				{
					r_transparencySortMode = new(this, "transparencySortMode", -1);
					r_transparencySortMode.SetBelong(this.instance);
				}
				return r_transparencySortMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 transparencySortAxis
		/// </summary>
		protected RUnityEngine.RVector3 r_transparencySortAxis;
		public virtual RUnityEngine.RVector3 RtransparencySortAxis
		{
			get
			{
				if(r_transparencySortAxis == null)
				{
					r_transparencySortAxis = new(this, "transparencySortAxis", -1);
					r_transparencySortAxis.SetBelong(this.instance);
				}
				return r_transparencySortAxis;
			}
		}

		/// <summary>
		/// Single depth
		/// </summary>
		protected RProperty r_depth;
		public virtual RProperty Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth", -1);
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// Single aspect
		/// </summary>
		protected RProperty r_aspect;
		public virtual RProperty Raspect
		{
			get
			{
				if(r_aspect == null)
				{
					r_aspect = new(this, "aspect", -1);
					r_aspect.SetBelong(this.instance);
				}
				return r_aspect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 velocity
		/// </summary>
		protected RUnityEngine.RVector3 r_velocity;
		public virtual RUnityEngine.RVector3 Rvelocity
		{
			get
			{
				if(r_velocity == null)
				{
					r_velocity = new(this, "velocity", -1);
					r_velocity.SetBelong(this.instance);
				}
				return r_velocity;
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
		/// Int32 eventMask
		/// </summary>
		protected RProperty r_eventMask;
		public virtual RProperty ReventMask
		{
			get
			{
				if(r_eventMask == null)
				{
					r_eventMask = new(this, "eventMask", -1);
					r_eventMask.SetBelong(this.instance);
				}
				return r_eventMask;
			}
		}

		/// <summary>
		/// Boolean layerCullSpherical
		/// </summary>
		protected RProperty r_layerCullSpherical;
		public virtual RProperty RlayerCullSpherical
		{
			get
			{
				if(r_layerCullSpherical == null)
				{
					r_layerCullSpherical = new(this, "layerCullSpherical", -1);
					r_layerCullSpherical.SetBelong(this.instance);
				}
				return r_layerCullSpherical;
			}
		}

		/// <summary>
		/// UnityEngine.CameraType cameraType
		/// </summary>
		protected RProperty r_cameraType;
		public virtual RProperty RcameraType
		{
			get
			{
				if(r_cameraType == null)
				{
					r_cameraType = new(this, "cameraType", -1);
					r_cameraType.SetBelong(this.instance);
				}
				return r_cameraType;
			}
		}

		/// <summary>
		/// UnityEngine.Material skyboxMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_skyboxMaterial;
		public virtual RUnityEngine.RMaterial RskyboxMaterial
		{
			get
			{
				if(r_skyboxMaterial == null)
				{
					r_skyboxMaterial = new(this, "skyboxMaterial", -1);
					r_skyboxMaterial.SetBelong(this.instance);
				}
				return r_skyboxMaterial;
			}
		}

		/// <summary>
		/// UInt64 overrideSceneCullingMask
		/// </summary>
		protected RProperty r_overrideSceneCullingMask;
		public virtual RProperty RoverrideSceneCullingMask
		{
			get
			{
				if(r_overrideSceneCullingMask == null)
				{
					r_overrideSceneCullingMask = new(this, "overrideSceneCullingMask", -1);
					r_overrideSceneCullingMask.SetBelong(this.instance);
				}
				return r_overrideSceneCullingMask;
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
		/// Single[] layerCullDistances
		/// </summary>
		protected RPropertyArray<RProperty> r_layerCullDistances;
		public virtual RPropertyArray<RProperty> RlayerCullDistances
		{
			get
			{
				if(r_layerCullDistances == null)
				{
					r_layerCullDistances = new(this, "layerCullDistances", -1);
					r_layerCullDistances.SetBelong(this.instance);
				}
				return r_layerCullDistances;
			}
		}

		/// <summary>
		/// Int32 PreviewCullingLayer
		/// </summary>
		protected static RProperty r_PreviewCullingLayer;
		public static RProperty RPreviewCullingLayer
		{
			get
			{
				if(r_PreviewCullingLayer == null)
				{
					r_PreviewCullingLayer = new(typeof(UnityEngine.Camera), "PreviewCullingLayer", -1);
					r_PreviewCullingLayer.SetBelong(null);
				}
				return r_PreviewCullingLayer;
			}
		}

		/// <summary>
		/// Boolean useOcclusionCulling
		/// </summary>
		protected RProperty r_useOcclusionCulling;
		public virtual RProperty RuseOcclusionCulling
		{
			get
			{
				if(r_useOcclusionCulling == null)
				{
					r_useOcclusionCulling = new(this, "useOcclusionCulling", -1);
					r_useOcclusionCulling.SetBelong(this.instance);
				}
				return r_useOcclusionCulling;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cullingMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_cullingMatrix;
		public virtual RUnityEngine.RMatrix4x4 RcullingMatrix
		{
			get
			{
				if(r_cullingMatrix == null)
				{
					r_cullingMatrix = new(this, "cullingMatrix", -1);
					r_cullingMatrix.SetBelong(this.instance);
				}
				return r_cullingMatrix;
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
		/// UnityEngine.CameraClearFlags clearFlags
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
		/// UnityEngine.DepthTextureMode depthTextureMode
		/// </summary>
		protected RProperty r_depthTextureMode;
		public virtual RProperty RdepthTextureMode
		{
			get
			{
				if(r_depthTextureMode == null)
				{
					r_depthTextureMode = new(this, "depthTextureMode", -1);
					r_depthTextureMode.SetBelong(this.instance);
				}
				return r_depthTextureMode;
			}
		}

		/// <summary>
		/// Boolean clearStencilAfterLightingPass
		/// </summary>
		protected RProperty r_clearStencilAfterLightingPass;
		public virtual RProperty RclearStencilAfterLightingPass
		{
			get
			{
				if(r_clearStencilAfterLightingPass == null)
				{
					r_clearStencilAfterLightingPass = new(this, "clearStencilAfterLightingPass", -1);
					r_clearStencilAfterLightingPass.SetBelong(this.instance);
				}
				return r_clearStencilAfterLightingPass;
			}
		}

		/// <summary>
		/// ProjectionMatrixMode projectionMatrixMode
		/// </summary>
		protected RProperty r_projectionMatrixMode;
		public virtual RProperty RprojectionMatrixMode
		{
			get
			{
				if(r_projectionMatrixMode == null)
				{
					r_projectionMatrixMode = new(this, "projectionMatrixMode", -1);
					r_projectionMatrixMode.SetBelong(this.instance);
				}
				return r_projectionMatrixMode;
			}
		}

		/// <summary>
		/// Boolean usePhysicalProperties
		/// </summary>
		protected RProperty r_usePhysicalProperties;
		public virtual RProperty RusePhysicalProperties
		{
			get
			{
				if(r_usePhysicalProperties == null)
				{
					r_usePhysicalProperties = new(this, "usePhysicalProperties", -1);
					r_usePhysicalProperties.SetBelong(this.instance);
				}
				return r_usePhysicalProperties;
			}
		}

		/// <summary>
		/// Int32 iso
		/// </summary>
		protected RProperty r_iso;
		public virtual RProperty Riso
		{
			get
			{
				if(r_iso == null)
				{
					r_iso = new(this, "iso", -1);
					r_iso.SetBelong(this.instance);
				}
				return r_iso;
			}
		}

		/// <summary>
		/// Single shutterSpeed
		/// </summary>
		protected RProperty r_shutterSpeed;
		public virtual RProperty RshutterSpeed
		{
			get
			{
				if(r_shutterSpeed == null)
				{
					r_shutterSpeed = new(this, "shutterSpeed", -1);
					r_shutterSpeed.SetBelong(this.instance);
				}
				return r_shutterSpeed;
			}
		}

		/// <summary>
		/// Single aperture
		/// </summary>
		protected RProperty r_aperture;
		public virtual RProperty Raperture
		{
			get
			{
				if(r_aperture == null)
				{
					r_aperture = new(this, "aperture", -1);
					r_aperture.SetBelong(this.instance);
				}
				return r_aperture;
			}
		}

		/// <summary>
		/// Single focusDistance
		/// </summary>
		protected RProperty r_focusDistance;
		public virtual RProperty RfocusDistance
		{
			get
			{
				if(r_focusDistance == null)
				{
					r_focusDistance = new(this, "focusDistance", -1);
					r_focusDistance.SetBelong(this.instance);
				}
				return r_focusDistance;
			}
		}

		/// <summary>
		/// Single focalLength
		/// </summary>
		protected RProperty r_focalLength;
		public virtual RProperty RfocalLength
		{
			get
			{
				if(r_focalLength == null)
				{
					r_focalLength = new(this, "focalLength", -1);
					r_focalLength.SetBelong(this.instance);
				}
				return r_focalLength;
			}
		}

		/// <summary>
		/// Int32 bladeCount
		/// </summary>
		protected RProperty r_bladeCount;
		public virtual RProperty RbladeCount
		{
			get
			{
				if(r_bladeCount == null)
				{
					r_bladeCount = new(this, "bladeCount", -1);
					r_bladeCount.SetBelong(this.instance);
				}
				return r_bladeCount;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 curvature
		/// </summary>
		protected RUnityEngine.RVector2 r_curvature;
		public virtual RUnityEngine.RVector2 Rcurvature
		{
			get
			{
				if(r_curvature == null)
				{
					r_curvature = new(this, "curvature", -1);
					r_curvature.SetBelong(this.instance);
				}
				return r_curvature;
			}
		}

		/// <summary>
		/// Single barrelClipping
		/// </summary>
		protected RProperty r_barrelClipping;
		public virtual RProperty RbarrelClipping
		{
			get
			{
				if(r_barrelClipping == null)
				{
					r_barrelClipping = new(this, "barrelClipping", -1);
					r_barrelClipping.SetBelong(this.instance);
				}
				return r_barrelClipping;
			}
		}

		/// <summary>
		/// Single anamorphism
		/// </summary>
		protected RProperty r_anamorphism;
		public virtual RProperty Ranamorphism
		{
			get
			{
				if(r_anamorphism == null)
				{
					r_anamorphism = new(this, "anamorphism", -1);
					r_anamorphism.SetBelong(this.instance);
				}
				return r_anamorphism;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 sensorSize
		/// </summary>
		protected RUnityEngine.RVector2 r_sensorSize;
		public virtual RUnityEngine.RVector2 RsensorSize
		{
			get
			{
				if(r_sensorSize == null)
				{
					r_sensorSize = new(this, "sensorSize", -1);
					r_sensorSize.SetBelong(this.instance);
				}
				return r_sensorSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 lensShift
		/// </summary>
		protected RUnityEngine.RVector2 r_lensShift;
		public virtual RUnityEngine.RVector2 RlensShift
		{
			get
			{
				if(r_lensShift == null)
				{
					r_lensShift = new(this, "lensShift", -1);
					r_lensShift.SetBelong(this.instance);
				}
				return r_lensShift;
			}
		}

		/// <summary>
		/// GateFitMode gateFit
		/// </summary>
		protected RProperty r_gateFit;
		public virtual RProperty RgateFit
		{
			get
			{
				if(r_gateFit == null)
				{
					r_gateFit = new(this, "gateFit", -1);
					r_gateFit.SetBelong(this.instance);
				}
				return r_gateFit;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_rect;
		public virtual RUnityEngine.RRect Rrect
		{
			get
			{
				if(r_rect == null)
				{
					r_rect = new(this, "rect", -1);
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect pixelRect
		/// </summary>
		protected RUnityEngine.RRect r_pixelRect;
		public virtual RUnityEngine.RRect RpixelRect
		{
			get
			{
				if(r_pixelRect == null)
				{
					r_pixelRect = new(this, "pixelRect", -1);
					r_pixelRect.SetBelong(this.instance);
				}
				return r_pixelRect;
			}
		}

		/// <summary>
		/// Int32 pixelWidth
		/// </summary>
		protected RProperty r_pixelWidth;
		public virtual RProperty RpixelWidth
		{
			get
			{
				if(r_pixelWidth == null)
				{
					r_pixelWidth = new(this, "pixelWidth", -1);
					r_pixelWidth.SetBelong(this.instance);
				}
				return r_pixelWidth;
			}
		}

		/// <summary>
		/// Int32 pixelHeight
		/// </summary>
		protected RProperty r_pixelHeight;
		public virtual RProperty RpixelHeight
		{
			get
			{
				if(r_pixelHeight == null)
				{
					r_pixelHeight = new(this, "pixelHeight", -1);
					r_pixelHeight.SetBelong(this.instance);
				}
				return r_pixelHeight;
			}
		}

		/// <summary>
		/// Int32 scaledPixelWidth
		/// </summary>
		protected RProperty r_scaledPixelWidth;
		public virtual RProperty RscaledPixelWidth
		{
			get
			{
				if(r_scaledPixelWidth == null)
				{
					r_scaledPixelWidth = new(this, "scaledPixelWidth", -1);
					r_scaledPixelWidth.SetBelong(this.instance);
				}
				return r_scaledPixelWidth;
			}
		}

		/// <summary>
		/// Int32 scaledPixelHeight
		/// </summary>
		protected RProperty r_scaledPixelHeight;
		public virtual RProperty RscaledPixelHeight
		{
			get
			{
				if(r_scaledPixelHeight == null)
				{
					r_scaledPixelHeight = new(this, "scaledPixelHeight", -1);
					r_scaledPixelHeight.SetBelong(this.instance);
				}
				return r_scaledPixelHeight;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture targetTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_targetTexture;
		public virtual RUnityEngine.RRenderTexture RtargetTexture
		{
			get
			{
				if(r_targetTexture == null)
				{
					r_targetTexture = new(this, "targetTexture", -1);
					r_targetTexture.SetBelong(this.instance);
				}
				return r_targetTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture activeTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_activeTexture;
		public virtual RUnityEngine.RRenderTexture RactiveTexture
		{
			get
			{
				if(r_activeTexture == null)
				{
					r_activeTexture = new(this, "activeTexture", -1);
					r_activeTexture.SetBelong(this.instance);
				}
				return r_activeTexture;
			}
		}

		/// <summary>
		/// Int32 targetDisplay
		/// </summary>
		protected RProperty r_targetDisplay;
		public virtual RProperty RtargetDisplay
		{
			get
			{
				if(r_targetDisplay == null)
				{
					r_targetDisplay = new(this, "targetDisplay", -1);
					r_targetDisplay.SetBelong(this.instance);
				}
				return r_targetDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraToWorldMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_cameraToWorldMatrix;
		public virtual RUnityEngine.RMatrix4x4 RcameraToWorldMatrix
		{
			get
			{
				if(r_cameraToWorldMatrix == null)
				{
					r_cameraToWorldMatrix = new(this, "cameraToWorldMatrix", -1);
					r_cameraToWorldMatrix.SetBelong(this.instance);
				}
				return r_cameraToWorldMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldToCameraMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldToCameraMatrix;
		public virtual RUnityEngine.RMatrix4x4 RworldToCameraMatrix
		{
			get
			{
				if(r_worldToCameraMatrix == null)
				{
					r_worldToCameraMatrix = new(this, "worldToCameraMatrix", -1);
					r_worldToCameraMatrix.SetBelong(this.instance);
				}
				return r_worldToCameraMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 projectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_projectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 RprojectionMatrix
		{
			get
			{
				if(r_projectionMatrix == null)
				{
					r_projectionMatrix = new(this, "projectionMatrix", -1);
					r_projectionMatrix.SetBelong(this.instance);
				}
				return r_projectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 nonJitteredProjectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_nonJitteredProjectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 RnonJitteredProjectionMatrix
		{
			get
			{
				if(r_nonJitteredProjectionMatrix == null)
				{
					r_nonJitteredProjectionMatrix = new(this, "nonJitteredProjectionMatrix", -1);
					r_nonJitteredProjectionMatrix.SetBelong(this.instance);
				}
				return r_nonJitteredProjectionMatrix;
			}
		}

		/// <summary>
		/// Boolean useJitteredProjectionMatrixForTransparentRendering
		/// </summary>
		protected RProperty r_useJitteredProjectionMatrixForTransparentRendering;
		public virtual RProperty RuseJitteredProjectionMatrixForTransparentRendering
		{
			get
			{
				if(r_useJitteredProjectionMatrixForTransparentRendering == null)
				{
					r_useJitteredProjectionMatrixForTransparentRendering = new(this, "useJitteredProjectionMatrixForTransparentRendering", -1);
					r_useJitteredProjectionMatrixForTransparentRendering.SetBelong(this.instance);
				}
				return r_useJitteredProjectionMatrixForTransparentRendering;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 previousViewProjectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_previousViewProjectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 RpreviousViewProjectionMatrix
		{
			get
			{
				if(r_previousViewProjectionMatrix == null)
				{
					r_previousViewProjectionMatrix = new(this, "previousViewProjectionMatrix", -1);
					r_previousViewProjectionMatrix.SetBelong(this.instance);
				}
				return r_previousViewProjectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Camera main
		/// </summary>
		protected static RUnityEngine.RCamera r_main;
		public static RUnityEngine.RCamera Rmain
		{
			get
			{
				if(r_main == null)
				{
					r_main = new(typeof(UnityEngine.Camera), "main", -1);
					r_main.SetBelong(null);
				}
				return r_main;
			}
		}

		/// <summary>
		/// UnityEngine.Camera current
		/// </summary>
		protected static RUnityEngine.RCamera r_current;
		public static RUnityEngine.RCamera Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new(typeof(UnityEngine.Camera), "current", -1);
					r_current.SetBelong(null);
				}
				return r_current;
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
		/// Boolean stereoEnabled
		/// </summary>
		protected RProperty r_stereoEnabled;
		public virtual RProperty RstereoEnabled
		{
			get
			{
				if(r_stereoEnabled == null)
				{
					r_stereoEnabled = new(this, "stereoEnabled", -1);
					r_stereoEnabled.SetBelong(this.instance);
				}
				return r_stereoEnabled;
			}
		}

		/// <summary>
		/// Single stereoSeparation
		/// </summary>
		protected RProperty r_stereoSeparation;
		public virtual RProperty RstereoSeparation
		{
			get
			{
				if(r_stereoSeparation == null)
				{
					r_stereoSeparation = new(this, "stereoSeparation", -1);
					r_stereoSeparation.SetBelong(this.instance);
				}
				return r_stereoSeparation;
			}
		}

		/// <summary>
		/// Single stereoConvergence
		/// </summary>
		protected RProperty r_stereoConvergence;
		public virtual RProperty RstereoConvergence
		{
			get
			{
				if(r_stereoConvergence == null)
				{
					r_stereoConvergence = new(this, "stereoConvergence", -1);
					r_stereoConvergence.SetBelong(this.instance);
				}
				return r_stereoConvergence;
			}
		}

		/// <summary>
		/// Boolean areVRStereoViewMatricesWithinSingleCullTolerance
		/// </summary>
		protected RProperty r_areVRStereoViewMatricesWithinSingleCullTolerance;
		public virtual RProperty RareVRStereoViewMatricesWithinSingleCullTolerance
		{
			get
			{
				if(r_areVRStereoViewMatricesWithinSingleCullTolerance == null)
				{
					r_areVRStereoViewMatricesWithinSingleCullTolerance = new(this, "areVRStereoViewMatricesWithinSingleCullTolerance", -1);
					r_areVRStereoViewMatricesWithinSingleCullTolerance.SetBelong(this.instance);
				}
				return r_areVRStereoViewMatricesWithinSingleCullTolerance;
			}
		}

		/// <summary>
		/// UnityEngine.StereoTargetEyeMask stereoTargetEye
		/// </summary>
		protected RProperty r_stereoTargetEye;
		public virtual RProperty RstereoTargetEye
		{
			get
			{
				if(r_stereoTargetEye == null)
				{
					r_stereoTargetEye = new(this, "stereoTargetEye", -1);
					r_stereoTargetEye.SetBelong(this.instance);
				}
				return r_stereoTargetEye;
			}
		}

		/// <summary>
		/// MonoOrStereoscopicEye stereoActiveEye
		/// </summary>
		protected RProperty r_stereoActiveEye;
		public virtual RProperty RstereoActiveEye
		{
			get
			{
				if(r_stereoActiveEye == null)
				{
					r_stereoActiveEye = new(this, "stereoActiveEye", -1);
					r_stereoActiveEye.SetBelong(this.instance);
				}
				return r_stereoActiveEye;
			}
		}

		/// <summary>
		/// Int32 allCamerasCount
		/// </summary>
		protected static RProperty r_allCamerasCount;
		public static RProperty RallCamerasCount
		{
			get
			{
				if(r_allCamerasCount == null)
				{
					r_allCamerasCount = new(typeof(UnityEngine.Camera), "allCamerasCount", -1);
					r_allCamerasCount.SetBelong(null);
				}
				return r_allCamerasCount;
			}
		}

		/// <summary>
		/// UnityEngine.Camera[] allCameras
		/// </summary>
		protected static RPropertyArray<RUnityEngine.RCamera> r_allCameras;
		public static RPropertyArray<RUnityEngine.RCamera> RallCameras
		{
			get
			{
				if(r_allCameras == null)
				{
					r_allCameras = new(typeof(UnityEngine.Camera), "allCameras", -1);
					r_allCameras.SetBelong(null);
				}
				return r_allCameras;
			}
		}

		/// <summary>
		/// SceneViewFilterMode sceneViewFilterMode
		/// </summary>
		protected RProperty r_sceneViewFilterMode;
		public virtual RProperty RsceneViewFilterMode
		{
			get
			{
				if(r_sceneViewFilterMode == null)
				{
					r_sceneViewFilterMode = new(this, "sceneViewFilterMode", -1);
					r_sceneViewFilterMode.SetBelong(this.instance);
				}
				return r_sceneViewFilterMode;
			}
		}

		/// <summary>
		/// Int32 commandBufferCount
		/// </summary>
		protected RProperty r_commandBufferCount;
		public virtual RProperty RcommandBufferCount
		{
			get
			{
				if(r_commandBufferCount == null)
				{
					r_commandBufferCount = new(this, "commandBufferCount", -1);
					r_commandBufferCount.SetBelong(this.instance);
				}
				return r_commandBufferCount;
			}
		}

		/// <summary>
		/// Boolean isOrthoGraphic
		/// </summary>
		protected RProperty r_isOrthoGraphic;
		public virtual RProperty RisOrthoGraphic
		{
			get
			{
				if(r_isOrthoGraphic == null)
				{
					r_isOrthoGraphic = new(this, "isOrthoGraphic", -1);
					r_isOrthoGraphic.SetBelong(this.instance);
				}
				return r_isOrthoGraphic;
			}
		}

		/// <summary>
		/// UnityEngine.Camera mainCamera
		/// </summary>
		protected static RUnityEngine.RCamera r_mainCamera;
		public static RUnityEngine.RCamera RmainCamera
		{
			get
			{
				if(r_mainCamera == null)
				{
					r_mainCamera = new(typeof(UnityEngine.Camera), "mainCamera", -1);
					r_mainCamera.SetBelong(null);
				}
				return r_mainCamera;
			}
		}

		/// <summary>
		/// Single near
		/// </summary>
		protected RProperty r_near;
		public virtual RProperty Rnear
		{
			get
			{
				if(r_near == null)
				{
					r_near = new(this, "near", -1);
					r_near.SetBelong(this.instance);
				}
				return r_near;
			}
		}

		/// <summary>
		/// Single far
		/// </summary>
		protected RProperty r_far;
		public virtual RProperty Rfar
		{
			get
			{
				if(r_far == null)
				{
					r_far = new(this, "far", -1);
					r_far.SetBelong(this.instance);
				}
				return r_far;
			}
		}

		/// <summary>
		/// Single fov
		/// </summary>
		protected RProperty r_fov;
		public virtual RProperty Rfov
		{
			get
			{
				if(r_fov == null)
				{
					r_fov = new(this, "fov", -1);
					r_fov.SetBelong(this.instance);
				}
				return r_fov;
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
		/// Boolean stereoMirrorMode
		/// </summary>
		protected RProperty r_stereoMirrorMode;
		public virtual RProperty RstereoMirrorMode
		{
			get
			{
				if(r_stereoMirrorMode == null)
				{
					r_stereoMirrorMode = new(this, "stereoMirrorMode", -1);
					r_stereoMirrorMode.SetBelong(this.instance);
				}
				return r_stereoMirrorMode;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// Void ResetTransparencySortSettings()
		/// </summary>
		protected RMethod r_ResetTransparencySortSettings;
		public virtual RMethod RResetTransparencySortSettings
		{
			get
			{
				if(r_ResetTransparencySortSettings == null)
				{
					r_ResetTransparencySortSettings = new(this, "ResetTransparencySortSettings", 0);
					r_ResetTransparencySortSettings.SetBelong(this.instance);
				}
				return r_ResetTransparencySortSettings;
			}
		}

		/// <summary>
		/// Void ResetAspect()
		/// </summary>
		protected RMethod r_ResetAspect;
		public virtual RMethod RResetAspect
		{
			get
			{
				if(r_ResetAspect == null)
				{
					r_ResetAspect = new(this, "ResetAspect", 0);
					r_ResetAspect.SetBelong(this.instance);
				}
				return r_ResetAspect;
			}
		}

		/// <summary>
		/// Single[] GetLayerCullDistances()
		/// </summary>
		protected RMethod r_GetLayerCullDistances;
		public virtual RMethod RGetLayerCullDistances
		{
			get
			{
				if(r_GetLayerCullDistances == null)
				{
					r_GetLayerCullDistances = new(this, "GetLayerCullDistances", 0);
					r_GetLayerCullDistances.SetBelong(this.instance);
				}
				return r_GetLayerCullDistances;
			}
		}

		/// <summary>
		/// Void SetLayerCullDistances(Single[])
		/// </summary>
		protected RMethod r_SetLayerCullDistances_SingleArray;
		public virtual RMethod RSetLayerCullDistances_SingleArray
		{
			get
			{
				if(r_SetLayerCullDistances_SingleArray == null)
				{
					r_SetLayerCullDistances_SingleArray = new(this, "SetLayerCullDistances", 0, typeof(System.Single).MakeArrayType());
					r_SetLayerCullDistances_SingleArray.SetBelong(this.instance);
				}
				return r_SetLayerCullDistances_SingleArray;
			}
		}

		/// <summary>
		/// Void ResetCullingMatrix()
		/// </summary>
		protected RMethod r_ResetCullingMatrix;
		public virtual RMethod RResetCullingMatrix
		{
			get
			{
				if(r_ResetCullingMatrix == null)
				{
					r_ResetCullingMatrix = new(this, "ResetCullingMatrix", 0);
					r_ResetCullingMatrix.SetBelong(this.instance);
				}
				return r_ResetCullingMatrix;
			}
		}

		/// <summary>
		/// Void SetReplacementShader(UnityEngine.Shader, System.String)
		/// </summary>
		protected RMethod r_SetReplacementShader_Shader_String;
		public virtual RMethod RSetReplacementShader_Shader_String
		{
			get
			{
				if(r_SetReplacementShader_Shader_String == null)
				{
					r_SetReplacementShader_Shader_String = new(this, "SetReplacementShader", 0, typeof(UnityEngine.Shader), typeof(System.String));
					r_SetReplacementShader_Shader_String.SetBelong(this.instance);
				}
				return r_SetReplacementShader_Shader_String;
			}
		}

		/// <summary>
		/// Void ResetReplacementShader()
		/// </summary>
		protected RMethod r_ResetReplacementShader;
		public virtual RMethod RResetReplacementShader
		{
			get
			{
				if(r_ResetReplacementShader == null)
				{
					r_ResetReplacementShader = new(this, "ResetReplacementShader", 0);
					r_ResetReplacementShader.SetBelong(this.instance);
				}
				return r_ResetReplacementShader;
			}
		}

		/// <summary>
		/// Single GetGateFittedFieldOfView()
		/// </summary>
		protected RMethod r_GetGateFittedFieldOfView;
		public virtual RMethod RGetGateFittedFieldOfView
		{
			get
			{
				if(r_GetGateFittedFieldOfView == null)
				{
					r_GetGateFittedFieldOfView = new(this, "GetGateFittedFieldOfView", 0);
					r_GetGateFittedFieldOfView.SetBelong(this.instance);
				}
				return r_GetGateFittedFieldOfView;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetGateFittedLensShift()
		/// </summary>
		protected RMethod r_GetGateFittedLensShift;
		public virtual RMethod RGetGateFittedLensShift
		{
			get
			{
				if(r_GetGateFittedLensShift == null)
				{
					r_GetGateFittedLensShift = new(this, "GetGateFittedLensShift", 0);
					r_GetGateFittedLensShift.SetBelong(this.instance);
				}
				return r_GetGateFittedLensShift;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetLocalSpaceAim()
		/// </summary>
		protected RMethod r_GetLocalSpaceAim;
		public virtual RMethod RGetLocalSpaceAim
		{
			get
			{
				if(r_GetLocalSpaceAim == null)
				{
					r_GetLocalSpaceAim = new(this, "GetLocalSpaceAim", 0);
					r_GetLocalSpaceAim.SetBelong(this.instance);
				}
				return r_GetLocalSpaceAim;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersImpl(UnityEngine.RenderBuffer, UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_SetTargetBuffersImpl_RenderBuffer_RenderBuffer;
		public virtual RMethod RSetTargetBuffersImpl_RenderBuffer_RenderBuffer
		{
			get
			{
				if(r_SetTargetBuffersImpl_RenderBuffer_RenderBuffer == null)
				{
					r_SetTargetBuffersImpl_RenderBuffer_RenderBuffer = new(this, "SetTargetBuffersImpl", 0, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer));
					r_SetTargetBuffersImpl_RenderBuffer_RenderBuffer.SetBelong(this.instance);
				}
				return r_SetTargetBuffersImpl_RenderBuffer_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffers(UnityEngine.RenderBuffer, UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_SetTargetBuffers_RenderBuffer_RenderBuffer;
		public virtual RMethod RSetTargetBuffers_RenderBuffer_RenderBuffer
		{
			get
			{
				if(r_SetTargetBuffers_RenderBuffer_RenderBuffer == null)
				{
					r_SetTargetBuffers_RenderBuffer_RenderBuffer = new(this, "SetTargetBuffers", 0, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer));
					r_SetTargetBuffers_RenderBuffer_RenderBuffer.SetBelong(this.instance);
				}
				return r_SetTargetBuffers_RenderBuffer_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_SetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer;
		public virtual RMethod RSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer
		{
			get
			{
				if(r_SetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer == null)
				{
					r_SetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer = new(this, "SetTargetBuffersMRTImpl", 0, typeof(UnityEngine.RenderBuffer).MakeArrayType(), typeof(UnityEngine.RenderBuffer));
					r_SetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer.SetBelong(this.instance);
				}
				return r_SetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffers(UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_SetTargetBuffers_RenderBufferArray_RenderBuffer;
		public virtual RMethod RSetTargetBuffers_RenderBufferArray_RenderBuffer
		{
			get
			{
				if(r_SetTargetBuffers_RenderBufferArray_RenderBuffer == null)
				{
					r_SetTargetBuffers_RenderBufferArray_RenderBuffer = new(this, "SetTargetBuffers", 0, typeof(UnityEngine.RenderBuffer).MakeArrayType(), typeof(UnityEngine.RenderBuffer));
					r_SetTargetBuffers_RenderBufferArray_RenderBuffer.SetBelong(this.instance);
				}
				return r_SetTargetBuffers_RenderBufferArray_RenderBuffer;
			}
		}

		/// <summary>
		/// System.String[] GetCameraBufferWarnings()
		/// </summary>
		protected RMethod r_GetCameraBufferWarnings;
		public virtual RMethod RGetCameraBufferWarnings
		{
			get
			{
				if(r_GetCameraBufferWarnings == null)
				{
					r_GetCameraBufferWarnings = new(this, "GetCameraBufferWarnings", 0);
					r_GetCameraBufferWarnings.SetBelong(this.instance);
				}
				return r_GetCameraBufferWarnings;
			}
		}

		/// <summary>
		/// Void ResetWorldToCameraMatrix()
		/// </summary>
		protected RMethod r_ResetWorldToCameraMatrix;
		public virtual RMethod RResetWorldToCameraMatrix
		{
			get
			{
				if(r_ResetWorldToCameraMatrix == null)
				{
					r_ResetWorldToCameraMatrix = new(this, "ResetWorldToCameraMatrix", 0);
					r_ResetWorldToCameraMatrix.SetBelong(this.instance);
				}
				return r_ResetWorldToCameraMatrix;
			}
		}

		/// <summary>
		/// Void ResetProjectionMatrix()
		/// </summary>
		protected RMethod r_ResetProjectionMatrix;
		public virtual RMethod RResetProjectionMatrix
		{
			get
			{
				if(r_ResetProjectionMatrix == null)
				{
					r_ResetProjectionMatrix = new(this, "ResetProjectionMatrix", 0);
					r_ResetProjectionMatrix.SetBelong(this.instance);
				}
				return r_ResetProjectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_CalculateObliqueMatrix_Vector4;
		public virtual RMethod RCalculateObliqueMatrix_Vector4
		{
			get
			{
				if(r_CalculateObliqueMatrix_Vector4 == null)
				{
					r_CalculateObliqueMatrix_Vector4 = new(this, "CalculateObliqueMatrix", 0, typeof(UnityEngine.Vector4));
					r_CalculateObliqueMatrix_Vector4.SetBelong(this.instance);
				}
				return r_CalculateObliqueMatrix_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_WorldToScreenPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RWorldToScreenPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_WorldToScreenPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_WorldToScreenPoint_Vector3_MonoOrStereoscopicEye = new(this, "WorldToScreenPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_WorldToScreenPoint_Vector3_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_WorldToScreenPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_WorldToViewportPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RWorldToViewportPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_WorldToViewportPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_WorldToViewportPoint_Vector3_MonoOrStereoscopicEye = new(this, "WorldToViewportPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_WorldToViewportPoint_Vector3_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_WorldToViewportPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ViewportToWorldPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RViewportToWorldPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ViewportToWorldPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_ViewportToWorldPoint_Vector3_MonoOrStereoscopicEye = new(this, "ViewportToWorldPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ViewportToWorldPoint_Vector3_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ViewportToWorldPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ScreenToWorldPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RScreenToWorldPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ScreenToWorldPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_ScreenToWorldPoint_Vector3_MonoOrStereoscopicEye = new(this, "ScreenToWorldPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ScreenToWorldPoint_Vector3_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ScreenToWorldPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_WorldToScreenPoint_Vector3;
		public virtual RMethod RWorldToScreenPoint_Vector3
		{
			get
			{
				if(r_WorldToScreenPoint_Vector3 == null)
				{
					r_WorldToScreenPoint_Vector3 = new(this, "WorldToScreenPoint", 0, typeof(UnityEngine.Vector3));
					r_WorldToScreenPoint_Vector3.SetBelong(this.instance);
				}
				return r_WorldToScreenPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_WorldToViewportPoint_Vector3;
		public virtual RMethod RWorldToViewportPoint_Vector3
		{
			get
			{
				if(r_WorldToViewportPoint_Vector3 == null)
				{
					r_WorldToViewportPoint_Vector3 = new(this, "WorldToViewportPoint", 0, typeof(UnityEngine.Vector3));
					r_WorldToViewportPoint_Vector3.SetBelong(this.instance);
				}
				return r_WorldToViewportPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ViewportToWorldPoint_Vector3;
		public virtual RMethod RViewportToWorldPoint_Vector3
		{
			get
			{
				if(r_ViewportToWorldPoint_Vector3 == null)
				{
					r_ViewportToWorldPoint_Vector3 = new(this, "ViewportToWorldPoint", 0, typeof(UnityEngine.Vector3));
					r_ViewportToWorldPoint_Vector3.SetBelong(this.instance);
				}
				return r_ViewportToWorldPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ScreenToWorldPoint_Vector3;
		public virtual RMethod RScreenToWorldPoint_Vector3
		{
			get
			{
				if(r_ScreenToWorldPoint_Vector3 == null)
				{
					r_ScreenToWorldPoint_Vector3 = new(this, "ScreenToWorldPoint", 0, typeof(UnityEngine.Vector3));
					r_ScreenToWorldPoint_Vector3.SetBelong(this.instance);
				}
				return r_ScreenToWorldPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ScreenToViewportPoint_Vector3;
		public virtual RMethod RScreenToViewportPoint_Vector3
		{
			get
			{
				if(r_ScreenToViewportPoint_Vector3 == null)
				{
					r_ScreenToViewportPoint_Vector3 = new(this, "ScreenToViewportPoint", 0, typeof(UnityEngine.Vector3));
					r_ScreenToViewportPoint_Vector3.SetBelong(this.instance);
				}
				return r_ScreenToViewportPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ViewportToScreenPoint_Vector3;
		public virtual RMethod RViewportToScreenPoint_Vector3
		{
			get
			{
				if(r_ViewportToScreenPoint_Vector3 == null)
				{
					r_ViewportToScreenPoint_Vector3 = new(this, "ViewportToScreenPoint", 0, typeof(UnityEngine.Vector3));
					r_ViewportToScreenPoint_Vector3.SetBelong(this.instance);
				}
				return r_ViewportToScreenPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetFrustumPlaneSizeAt(Single)
		/// </summary>
		protected RMethod r_GetFrustumPlaneSizeAt_Single;
		public virtual RMethod RGetFrustumPlaneSizeAt_Single
		{
			get
			{
				if(r_GetFrustumPlaneSizeAt_Single == null)
				{
					r_GetFrustumPlaneSizeAt_Single = new(this, "GetFrustumPlaneSizeAt", 0, typeof(System.Single));
					r_GetFrustumPlaneSizeAt_Single.SetBelong(this.instance);
				}
				return r_GetFrustumPlaneSizeAt_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ViewportPointToRay_Vector2_MonoOrStereoscopicEye;
		public virtual RMethod RViewportPointToRay_Vector2_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ViewportPointToRay_Vector2_MonoOrStereoscopicEye == null)
				{
					r_ViewportPointToRay_Vector2_MonoOrStereoscopicEye = new(this, "ViewportPointToRay", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ViewportPointToRay_Vector2_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ViewportPointToRay_Vector2_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ViewportPointToRay_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RViewportPointToRay_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ViewportPointToRay_Vector3_MonoOrStereoscopicEye == null)
				{
					r_ViewportPointToRay_Vector3_MonoOrStereoscopicEye = new(this, "ViewportPointToRay", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ViewportPointToRay_Vector3_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ViewportPointToRay_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ViewportPointToRay_Vector3;
		public virtual RMethod RViewportPointToRay_Vector3
		{
			get
			{
				if(r_ViewportPointToRay_Vector3 == null)
				{
					r_ViewportPointToRay_Vector3 = new(this, "ViewportPointToRay", 0, typeof(UnityEngine.Vector3));
					r_ViewportPointToRay_Vector3.SetBelong(this.instance);
				}
				return r_ViewportPointToRay_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ScreenPointToRay_Vector2_MonoOrStereoscopicEye;
		public virtual RMethod RScreenPointToRay_Vector2_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ScreenPointToRay_Vector2_MonoOrStereoscopicEye == null)
				{
					r_ScreenPointToRay_Vector2_MonoOrStereoscopicEye = new(this, "ScreenPointToRay", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ScreenPointToRay_Vector2_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ScreenPointToRay_Vector2_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ScreenPointToRay_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RScreenPointToRay_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ScreenPointToRay_Vector3_MonoOrStereoscopicEye == null)
				{
					r_ScreenPointToRay_Vector3_MonoOrStereoscopicEye = new(this, "ScreenPointToRay", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ScreenPointToRay_Vector3_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ScreenPointToRay_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ScreenPointToRay_Vector3;
		public virtual RMethod RScreenPointToRay_Vector3
		{
			get
			{
				if(r_ScreenPointToRay_Vector3 == null)
				{
					r_ScreenPointToRay_Vector3 = new(this, "ScreenPointToRay", 0, typeof(UnityEngine.Vector3));
					r_ScreenPointToRay_Vector3.SetBelong(this.instance);
				}
				return r_ScreenPointToRay_Vector3;
			}
		}

		/// <summary>
		/// Void CalculateFrustumCornersInternal(UnityEngine.Rect, Single, MonoOrStereoscopicEye, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_CalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
		public virtual RMethod RCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array
		{
			get
			{
				if(r_CalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array == null)
				{
					r_CalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array = new(this, "CalculateFrustumCornersInternal", 0, typeof(UnityEngine.Rect), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeArrayType());
					r_CalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array.SetBelong(this.instance);
				}
				return r_CalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
			}
		}

		/// <summary>
		/// Void CalculateFrustumCorners(UnityEngine.Rect, Single, MonoOrStereoscopicEye, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_CalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
		public virtual RMethod RCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array
		{
			get
			{
				if(r_CalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array == null)
				{
					r_CalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array = new(this, "CalculateFrustumCorners", 0, typeof(UnityEngine.Rect), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeArrayType());
					r_CalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array.SetBelong(this.instance);
				}
				return r_CalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
			}
		}

		/// <summary>
		/// Void CalculateProjectionMatrixFromPhysicalPropertiesInternal(UnityEngine.Matrix4x4 ByRef, Single, UnityEngine.Vector2, UnityEngine.Vector2, Single, Single, Single, GateFitMode)
		/// </summary>
		protected static RMethod r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode;
		public static RMethod RCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode
		{
			get
			{
				if(r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode == null)
				{
					r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode = new(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalPropertiesInternal", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Single), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+GateFitMode"));
					r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode.SetBelong(null);
				}
				return r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode;
			}
		}

		/// <summary>
		/// Void CalculateProjectionMatrixFromPhysicalProperties(UnityEngine.Matrix4x4 ByRef, Single, UnityEngine.Vector2, UnityEngine.Vector2, Single, Single, GateFitParameters)
		/// </summary>
		protected static RMethod r_CalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters;
		public static RMethod RCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters
		{
			get
			{
				if(r_CalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters == null)
				{
					r_CalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters = new(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+GateFitParameters"));
					r_CalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters.SetBelong(null);
				}
				return r_CalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters;
			}
		}

		/// <summary>
		/// Single FocalLengthToFieldOfView(Single, Single)
		/// </summary>
		protected static RMethod r_FocalLengthToFieldOfView_Single_Single;
		public static RMethod RFocalLengthToFieldOfView_Single_Single
		{
			get
			{
				if(r_FocalLengthToFieldOfView_Single_Single == null)
				{
					r_FocalLengthToFieldOfView_Single_Single = new(typeof(UnityEngine.Camera), "FocalLengthToFieldOfView", 0, typeof(System.Single), typeof(System.Single));
					r_FocalLengthToFieldOfView_Single_Single.SetBelong(null);
				}
				return r_FocalLengthToFieldOfView_Single_Single;
			}
		}

		/// <summary>
		/// Single FieldOfViewToFocalLength(Single, Single)
		/// </summary>
		protected static RMethod r_FieldOfViewToFocalLength_Single_Single;
		public static RMethod RFieldOfViewToFocalLength_Single_Single
		{
			get
			{
				if(r_FieldOfViewToFocalLength_Single_Single == null)
				{
					r_FieldOfViewToFocalLength_Single_Single = new(typeof(UnityEngine.Camera), "FieldOfViewToFocalLength", 0, typeof(System.Single), typeof(System.Single));
					r_FieldOfViewToFocalLength_Single_Single.SetBelong(null);
				}
				return r_FieldOfViewToFocalLength_Single_Single;
			}
		}

		/// <summary>
		/// Single HorizontalToVerticalFieldOfView(Single, Single)
		/// </summary>
		protected static RMethod r_HorizontalToVerticalFieldOfView_Single_Single;
		public static RMethod RHorizontalToVerticalFieldOfView_Single_Single
		{
			get
			{
				if(r_HorizontalToVerticalFieldOfView_Single_Single == null)
				{
					r_HorizontalToVerticalFieldOfView_Single_Single = new(typeof(UnityEngine.Camera), "HorizontalToVerticalFieldOfView", 0, typeof(System.Single), typeof(System.Single));
					r_HorizontalToVerticalFieldOfView_Single_Single.SetBelong(null);
				}
				return r_HorizontalToVerticalFieldOfView_Single_Single;
			}
		}

		/// <summary>
		/// Single VerticalToHorizontalFieldOfView(Single, Single)
		/// </summary>
		protected static RMethod r_VerticalToHorizontalFieldOfView_Single_Single;
		public static RMethod RVerticalToHorizontalFieldOfView_Single_Single
		{
			get
			{
				if(r_VerticalToHorizontalFieldOfView_Single_Single == null)
				{
					r_VerticalToHorizontalFieldOfView_Single_Single = new(typeof(UnityEngine.Camera), "VerticalToHorizontalFieldOfView", 0, typeof(System.Single), typeof(System.Single));
					r_VerticalToHorizontalFieldOfView_Single_Single.SetBelong(null);
				}
				return r_VerticalToHorizontalFieldOfView_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye)
		/// </summary>
		protected RMethod r_GetStereoNonJitteredProjectionMatrix_StereoscopicEye;
		public virtual RMethod RGetStereoNonJitteredProjectionMatrix_StereoscopicEye
		{
			get
			{
				if(r_GetStereoNonJitteredProjectionMatrix_StereoscopicEye == null)
				{
					r_GetStereoNonJitteredProjectionMatrix_StereoscopicEye = new(this, "GetStereoNonJitteredProjectionMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
					r_GetStereoNonJitteredProjectionMatrix_StereoscopicEye.SetBelong(this.instance);
				}
				return r_GetStereoNonJitteredProjectionMatrix_StereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetStereoViewMatrix(StereoscopicEye)
		/// </summary>
		protected RMethod r_GetStereoViewMatrix_StereoscopicEye;
		public virtual RMethod RGetStereoViewMatrix_StereoscopicEye
		{
			get
			{
				if(r_GetStereoViewMatrix_StereoscopicEye == null)
				{
					r_GetStereoViewMatrix_StereoscopicEye = new(this, "GetStereoViewMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
					r_GetStereoViewMatrix_StereoscopicEye.SetBelong(this.instance);
				}
				return r_GetStereoViewMatrix_StereoscopicEye;
			}
		}

		/// <summary>
		/// Void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye)
		/// </summary>
		protected RMethod r_CopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye;
		public virtual RMethod RCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye
		{
			get
			{
				if(r_CopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye == null)
				{
					r_CopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye = new(this, "CopyStereoDeviceProjectionMatrixToNonJittered", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
					r_CopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye.SetBelong(this.instance);
				}
				return r_CopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye)
		/// </summary>
		protected RMethod r_GetStereoProjectionMatrix_StereoscopicEye;
		public virtual RMethod RGetStereoProjectionMatrix_StereoscopicEye
		{
			get
			{
				if(r_GetStereoProjectionMatrix_StereoscopicEye == null)
				{
					r_GetStereoProjectionMatrix_StereoscopicEye = new(this, "GetStereoProjectionMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
					r_GetStereoProjectionMatrix_StereoscopicEye.SetBelong(this.instance);
				}
				return r_GetStereoProjectionMatrix_StereoscopicEye;
			}
		}

		/// <summary>
		/// Void SetStereoProjectionMatrix(StereoscopicEye, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetStereoProjectionMatrix_StereoscopicEye_Matrix4x4;
		public virtual RMethod RSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4
		{
			get
			{
				if(r_SetStereoProjectionMatrix_StereoscopicEye_Matrix4x4 == null)
				{
					r_SetStereoProjectionMatrix_StereoscopicEye_Matrix4x4 = new(this, "SetStereoProjectionMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4));
					r_SetStereoProjectionMatrix_StereoscopicEye_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetStereoProjectionMatrix_StereoscopicEye_Matrix4x4;
			}
		}

		/// <summary>
		/// Void ResetStereoProjectionMatrices()
		/// </summary>
		protected RMethod r_ResetStereoProjectionMatrices;
		public virtual RMethod RResetStereoProjectionMatrices
		{
			get
			{
				if(r_ResetStereoProjectionMatrices == null)
				{
					r_ResetStereoProjectionMatrices = new(this, "ResetStereoProjectionMatrices", 0);
					r_ResetStereoProjectionMatrices.SetBelong(this.instance);
				}
				return r_ResetStereoProjectionMatrices;
			}
		}

		/// <summary>
		/// Void SetStereoViewMatrix(StereoscopicEye, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetStereoViewMatrix_StereoscopicEye_Matrix4x4;
		public virtual RMethod RSetStereoViewMatrix_StereoscopicEye_Matrix4x4
		{
			get
			{
				if(r_SetStereoViewMatrix_StereoscopicEye_Matrix4x4 == null)
				{
					r_SetStereoViewMatrix_StereoscopicEye_Matrix4x4 = new(this, "SetStereoViewMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4));
					r_SetStereoViewMatrix_StereoscopicEye_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetStereoViewMatrix_StereoscopicEye_Matrix4x4;
			}
		}

		/// <summary>
		/// Void ResetStereoViewMatrices()
		/// </summary>
		protected RMethod r_ResetStereoViewMatrices;
		public virtual RMethod RResetStereoViewMatrices
		{
			get
			{
				if(r_ResetStereoViewMatrices == null)
				{
					r_ResetStereoViewMatrices = new(this, "ResetStereoViewMatrices", 0);
					r_ResetStereoViewMatrices.SetBelong(this.instance);
				}
				return r_ResetStereoViewMatrices;
			}
		}

		/// <summary>
		/// Int32 GetAllCamerasCount()
		/// </summary>
		protected static RMethod r_GetAllCamerasCount;
		public static RMethod RGetAllCamerasCount
		{
			get
			{
				if(r_GetAllCamerasCount == null)
				{
					r_GetAllCamerasCount = new(typeof(UnityEngine.Camera), "GetAllCamerasCount", 0);
					r_GetAllCamerasCount.SetBelong(null);
				}
				return r_GetAllCamerasCount;
			}
		}

		/// <summary>
		/// Int32 GetAllCamerasImpl(UnityEngine.Camera[])
		/// </summary>
		protected static RMethod r_GetAllCamerasImpl_CameraArray;
		public static RMethod RGetAllCamerasImpl_CameraArray
		{
			get
			{
				if(r_GetAllCamerasImpl_CameraArray == null)
				{
					r_GetAllCamerasImpl_CameraArray = new(typeof(UnityEngine.Camera), "GetAllCamerasImpl", 0, typeof(UnityEngine.Camera).MakeArrayType());
					r_GetAllCamerasImpl_CameraArray.SetBelong(null);
				}
				return r_GetAllCamerasImpl_CameraArray;
			}
		}

		/// <summary>
		/// Int32 GetAllCameras(UnityEngine.Camera[])
		/// </summary>
		protected static RMethod r_GetAllCameras_CameraArray;
		public static RMethod RGetAllCameras_CameraArray
		{
			get
			{
				if(r_GetAllCameras_CameraArray == null)
				{
					r_GetAllCameras_CameraArray = new(typeof(UnityEngine.Camera), "GetAllCameras", 0, typeof(UnityEngine.Camera).MakeArrayType());
					r_GetAllCameras_CameraArray.SetBelong(null);
				}
				return r_GetAllCameras_CameraArray;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemapImpl(UnityEngine.Texture, Int32)
		/// </summary>
		protected RMethod r_RenderToCubemapImpl_Texture_Int32;
		public virtual RMethod RRenderToCubemapImpl_Texture_Int32
		{
			get
			{
				if(r_RenderToCubemapImpl_Texture_Int32 == null)
				{
					r_RenderToCubemapImpl_Texture_Int32 = new(this, "RenderToCubemapImpl", 0, typeof(UnityEngine.Texture), typeof(System.Int32));
					r_RenderToCubemapImpl_Texture_Int32.SetBelong(this.instance);
				}
				return r_RenderToCubemapImpl_Texture_Int32;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.Cubemap, Int32)
		/// </summary>
		protected RMethod r_RenderToCubemap_Cubemap_Int32;
		public virtual RMethod RRenderToCubemap_Cubemap_Int32
		{
			get
			{
				if(r_RenderToCubemap_Cubemap_Int32 == null)
				{
					r_RenderToCubemap_Cubemap_Int32 = new(this, "RenderToCubemap", 0, typeof(UnityEngine.Cubemap), typeof(System.Int32));
					r_RenderToCubemap_Cubemap_Int32.SetBelong(this.instance);
				}
				return r_RenderToCubemap_Cubemap_Int32;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.Cubemap)
		/// </summary>
		protected RMethod r_RenderToCubemap_Cubemap;
		public virtual RMethod RRenderToCubemap_Cubemap
		{
			get
			{
				if(r_RenderToCubemap_Cubemap == null)
				{
					r_RenderToCubemap_Cubemap = new(this, "RenderToCubemap", 0, typeof(UnityEngine.Cubemap));
					r_RenderToCubemap_Cubemap.SetBelong(this.instance);
				}
				return r_RenderToCubemap_Cubemap;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.RenderTexture, Int32)
		/// </summary>
		protected RMethod r_RenderToCubemap_RenderTexture_Int32;
		public virtual RMethod RRenderToCubemap_RenderTexture_Int32
		{
			get
			{
				if(r_RenderToCubemap_RenderTexture_Int32 == null)
				{
					r_RenderToCubemap_RenderTexture_Int32 = new(this, "RenderToCubemap", 0, typeof(UnityEngine.RenderTexture), typeof(System.Int32));
					r_RenderToCubemap_RenderTexture_Int32.SetBelong(this.instance);
				}
				return r_RenderToCubemap_RenderTexture_Int32;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_RenderToCubemap_RenderTexture;
		public virtual RMethod RRenderToCubemap_RenderTexture
		{
			get
			{
				if(r_RenderToCubemap_RenderTexture == null)
				{
					r_RenderToCubemap_RenderTexture = new(this, "RenderToCubemap", 0, typeof(UnityEngine.RenderTexture));
					r_RenderToCubemap_RenderTexture.SetBelong(this.instance);
				}
				return r_RenderToCubemap_RenderTexture;
			}
		}

		/// <summary>
		/// Int32 GetFilterMode()
		/// </summary>
		protected RMethod r_GetFilterMode;
		public virtual RMethod RGetFilterMode
		{
			get
			{
				if(r_GetFilterMode == null)
				{
					r_GetFilterMode = new(this, "GetFilterMode", 0);
					r_GetFilterMode.SetBelong(this.instance);
				}
				return r_GetFilterMode;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemapEyeImpl(UnityEngine.RenderTexture, Int32, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_RenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye;
		public virtual RMethod RRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye
		{
			get
			{
				if(r_RenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye == null)
				{
					r_RenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye = new(this, "RenderToCubemapEyeImpl", 0, typeof(UnityEngine.RenderTexture), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_RenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_RenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.RenderTexture, Int32, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_RenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye;
		public virtual RMethod RRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye
		{
			get
			{
				if(r_RenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye == null)
				{
					r_RenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye = new(this, "RenderToCubemap", 0, typeof(UnityEngine.RenderTexture), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_RenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_RenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// Void Render()
		/// </summary>
		protected RMethod r_Render;
		public virtual RMethod RRender
		{
			get
			{
				if(r_Render == null)
				{
					r_Render = new(this, "Render", 0);
					r_Render.SetBelong(this.instance);
				}
				return r_Render;
			}
		}

		/// <summary>
		/// Void RenderWithShader(UnityEngine.Shader, System.String)
		/// </summary>
		protected RMethod r_RenderWithShader_Shader_String;
		public virtual RMethod RRenderWithShader_Shader_String
		{
			get
			{
				if(r_RenderWithShader_Shader_String == null)
				{
					r_RenderWithShader_Shader_String = new(this, "RenderWithShader", 0, typeof(UnityEngine.Shader), typeof(System.String));
					r_RenderWithShader_Shader_String.SetBelong(this.instance);
				}
				return r_RenderWithShader_Shader_String;
			}
		}

		/// <summary>
		/// Void RenderDontRestore()
		/// </summary>
		protected RMethod r_RenderDontRestore;
		public virtual RMethod RRenderDontRestore
		{
			get
			{
				if(r_RenderDontRestore == null)
				{
					r_RenderDontRestore = new(this, "RenderDontRestore", 0);
					r_RenderDontRestore.SetBelong(this.instance);
				}
				return r_RenderDontRestore;
			}
		}

		/// <summary>
		/// Void SubmitRenderRequests(System.Collections.Generic.List`1[UnityEngine.Camera+RenderRequest])
		/// </summary>
		protected RMethod r_SubmitRenderRequests_List_d_RenderRequest_p_;
		public virtual RMethod RSubmitRenderRequests_List_d_RenderRequest_p_
		{
			get
			{
				if(r_SubmitRenderRequests_List_d_RenderRequest_p_ == null)
				{
					r_SubmitRenderRequests_List_d_RenderRequest_p_ = new(this, "SubmitRenderRequests", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequest")));
					r_SubmitRenderRequests_List_d_RenderRequest_p_.SetBelong(this.instance);
				}
				return r_SubmitRenderRequests_List_d_RenderRequest_p_;
			}
		}

		/// <summary>
		/// Void SubmitRenderRequest[RequestData](RequestData)
		/// </summary>
		protected RMethod r_SubmitRenderRequest_GRequestData_RequestData;
		public virtual RMethod RSubmitRenderRequest_GRequestData_RequestData
		{
			get
			{
				if(r_SubmitRenderRequest_GRequestData_RequestData == null)
				{
					r_SubmitRenderRequest_GRequestData_RequestData = new(this, "SubmitRenderRequest", 1, Type.MakeGenericMethodParameter(0));
					r_SubmitRenderRequest_GRequestData_RequestData.SetBelong(this.instance);
				}
				return r_SubmitRenderRequest_GRequestData_RequestData;
			}
		}

		/// <summary>
		/// Void SubmitRenderRequestsInternal(System.Object)
		/// </summary>
		protected RMethod r_SubmitRenderRequestsInternal_Object;
		public virtual RMethod RSubmitRenderRequestsInternal_Object
		{
			get
			{
				if(r_SubmitRenderRequestsInternal_Object == null)
				{
					r_SubmitRenderRequestsInternal_Object = new(this, "SubmitRenderRequestsInternal", 0, typeof(System.Object));
					r_SubmitRenderRequestsInternal_Object.SetBelong(this.instance);
				}
				return r_SubmitRenderRequestsInternal_Object;
			}
		}

		/// <summary>
		/// Void SetupCurrent(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_SetupCurrent_Camera;
		public static RMethod RSetupCurrent_Camera
		{
			get
			{
				if(r_SetupCurrent_Camera == null)
				{
					r_SetupCurrent_Camera = new(typeof(UnityEngine.Camera), "SetupCurrent", 0, typeof(UnityEngine.Camera));
					r_SetupCurrent_Camera.SetBelong(null);
				}
				return r_SetupCurrent_Camera;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.Camera)
		/// </summary>
		protected RMethod r_CopyFrom_Camera;
		public virtual RMethod RCopyFrom_Camera
		{
			get
			{
				if(r_CopyFrom_Camera == null)
				{
					r_CopyFrom_Camera = new(this, "CopyFrom", 0, typeof(UnityEngine.Camera));
					r_CopyFrom_Camera.SetBelong(this.instance);
				}
				return r_CopyFrom_Camera;
			}
		}

		/// <summary>
		/// Void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent)
		/// </summary>
		protected RMethod r_RemoveCommandBuffers_CameraEvent;
		public virtual RMethod RRemoveCommandBuffers_CameraEvent
		{
			get
			{
				if(r_RemoveCommandBuffers_CameraEvent == null)
				{
					r_RemoveCommandBuffers_CameraEvent = new(this, "RemoveCommandBuffers", 0, typeof(UnityEngine.Rendering.CameraEvent));
					r_RemoveCommandBuffers_CameraEvent.SetBelong(this.instance);
				}
				return r_RemoveCommandBuffers_CameraEvent;
			}
		}

		/// <summary>
		/// Void RemoveAllCommandBuffers()
		/// </summary>
		protected RMethod r_RemoveAllCommandBuffers;
		public virtual RMethod RRemoveAllCommandBuffers
		{
			get
			{
				if(r_RemoveAllCommandBuffers == null)
				{
					r_RemoveAllCommandBuffers = new(this, "RemoveAllCommandBuffers", 0);
					r_RemoveAllCommandBuffers.SetBelong(this.instance);
				}
				return r_RemoveAllCommandBuffers;
			}
		}

		/// <summary>
		/// Void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_AddCommandBufferImpl_CameraEvent_CommandBuffer;
		public virtual RMethod RAddCommandBufferImpl_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_AddCommandBufferImpl_CameraEvent_CommandBuffer == null)
				{
					r_AddCommandBufferImpl_CameraEvent_CommandBuffer = new(this, "AddCommandBufferImpl", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
					r_AddCommandBufferImpl_CameraEvent_CommandBuffer.SetBelong(this.instance);
				}
				return r_AddCommandBufferImpl_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType)
		/// </summary>
		protected RMethod r_AddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType;
		public virtual RMethod RAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType
		{
			get
			{
				if(r_AddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType == null)
				{
					r_AddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType = new(this, "AddCommandBufferAsyncImpl", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ComputeQueueType));
					r_AddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType.SetBelong(this.instance);
				}
				return r_AddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType;
			}
		}

		/// <summary>
		/// Void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_RemoveCommandBufferImpl_CameraEvent_CommandBuffer;
		public virtual RMethod RRemoveCommandBufferImpl_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_RemoveCommandBufferImpl_CameraEvent_CommandBuffer == null)
				{
					r_RemoveCommandBufferImpl_CameraEvent_CommandBuffer = new(this, "RemoveCommandBufferImpl", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
					r_RemoveCommandBufferImpl_CameraEvent_CommandBuffer.SetBelong(this.instance);
				}
				return r_RemoveCommandBufferImpl_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBuffer(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_AddCommandBuffer_CameraEvent_CommandBuffer;
		public virtual RMethod RAddCommandBuffer_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_AddCommandBuffer_CameraEvent_CommandBuffer == null)
				{
					r_AddCommandBuffer_CameraEvent_CommandBuffer = new(this, "AddCommandBuffer", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
					r_AddCommandBuffer_CameraEvent_CommandBuffer.SetBelong(this.instance);
				}
				return r_AddCommandBuffer_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType)
		/// </summary>
		protected RMethod r_AddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType;
		public virtual RMethod RAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType
		{
			get
			{
				if(r_AddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType == null)
				{
					r_AddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType = new(this, "AddCommandBufferAsync", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ComputeQueueType));
					r_AddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType.SetBelong(this.instance);
				}
				return r_AddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType;
			}
		}

		/// <summary>
		/// Void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_RemoveCommandBuffer_CameraEvent_CommandBuffer;
		public virtual RMethod RRemoveCommandBuffer_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_RemoveCommandBuffer_CameraEvent_CommandBuffer == null)
				{
					r_RemoveCommandBuffer_CameraEvent_CommandBuffer = new(this, "RemoveCommandBuffer", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
					r_RemoveCommandBuffer_CameraEvent_CommandBuffer.SetBelong(this.instance);
				}
				return r_RemoveCommandBuffer_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent)
		/// </summary>
		protected RMethod r_GetCommandBuffers_CameraEvent;
		public virtual RMethod RGetCommandBuffers_CameraEvent
		{
			get
			{
				if(r_GetCommandBuffers_CameraEvent == null)
				{
					r_GetCommandBuffers_CameraEvent = new(this, "GetCommandBuffers", 0, typeof(UnityEngine.Rendering.CameraEvent));
					r_GetCommandBuffers_CameraEvent.SetBelong(this.instance);
				}
				return r_GetCommandBuffers_CameraEvent;
			}
		}

		/// <summary>
		/// Void FireOnPreCull(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_FireOnPreCull_Camera;
		public static RMethod RFireOnPreCull_Camera
		{
			get
			{
				if(r_FireOnPreCull_Camera == null)
				{
					r_FireOnPreCull_Camera = new(typeof(UnityEngine.Camera), "FireOnPreCull", 0, typeof(UnityEngine.Camera));
					r_FireOnPreCull_Camera.SetBelong(null);
				}
				return r_FireOnPreCull_Camera;
			}
		}

		/// <summary>
		/// Void FireOnPreRender(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_FireOnPreRender_Camera;
		public static RMethod RFireOnPreRender_Camera
		{
			get
			{
				if(r_FireOnPreRender_Camera == null)
				{
					r_FireOnPreRender_Camera = new(typeof(UnityEngine.Camera), "FireOnPreRender", 0, typeof(UnityEngine.Camera));
					r_FireOnPreRender_Camera.SetBelong(null);
				}
				return r_FireOnPreRender_Camera;
			}
		}

		/// <summary>
		/// Void FireOnPostRender(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_FireOnPostRender_Camera;
		public static RMethod RFireOnPostRender_Camera
		{
			get
			{
				if(r_FireOnPostRender_Camera == null)
				{
					r_FireOnPostRender_Camera = new(typeof(UnityEngine.Camera), "FireOnPostRender", 0, typeof(UnityEngine.Camera));
					r_FireOnPostRender_Camera.SetBelong(null);
				}
				return r_FireOnPostRender_Camera;
			}
		}

		/// <summary>
		/// Void OnlyUsedForTesting1()
		/// </summary>
		protected RMethod r_OnlyUsedForTesting1;
		public virtual RMethod ROnlyUsedForTesting1
		{
			get
			{
				if(r_OnlyUsedForTesting1 == null)
				{
					r_OnlyUsedForTesting1 = new(this, "OnlyUsedForTesting1", 0);
					r_OnlyUsedForTesting1.SetBelong(this.instance);
				}
				return r_OnlyUsedForTesting1;
			}
		}

		/// <summary>
		/// Void OnlyUsedForTesting2()
		/// </summary>
		protected RMethod r_OnlyUsedForTesting2;
		public virtual RMethod ROnlyUsedForTesting2
		{
			get
			{
				if(r_OnlyUsedForTesting2 == null)
				{
					r_OnlyUsedForTesting2 = new(this, "OnlyUsedForTesting2", 0);
					r_OnlyUsedForTesting2.SetBelong(this.instance);
				}
				return r_OnlyUsedForTesting2;
			}
		}

		/// <summary>
		/// Boolean TryGetCullingParameters(UnityEngine.Rendering.ScriptableCullingParameters ByRef)
		/// </summary>
		protected RMethod r_TryGetCullingParameters_Out_ScriptableCullingParameters;
		public virtual RMethod RTryGetCullingParameters_Out_ScriptableCullingParameters
		{
			get
			{
				if(r_TryGetCullingParameters_Out_ScriptableCullingParameters == null)
				{
					r_TryGetCullingParameters_Out_ScriptableCullingParameters = new(this, "TryGetCullingParameters", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters).MakeByRefType());
					r_TryGetCullingParameters_Out_ScriptableCullingParameters.SetBelong(this.instance);
				}
				return r_TryGetCullingParameters_Out_ScriptableCullingParameters;
			}
		}

		/// <summary>
		/// Boolean TryGetCullingParameters(Boolean, UnityEngine.Rendering.ScriptableCullingParameters ByRef)
		/// </summary>
		protected RMethod r_TryGetCullingParameters_Boolean_Out_ScriptableCullingParameters;
		public virtual RMethod RTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters
		{
			get
			{
				if(r_TryGetCullingParameters_Boolean_Out_ScriptableCullingParameters == null)
				{
					r_TryGetCullingParameters_Boolean_Out_ScriptableCullingParameters = new(this, "TryGetCullingParameters", 0, typeof(System.Boolean), typeof(UnityEngine.Rendering.ScriptableCullingParameters).MakeByRefType());
					r_TryGetCullingParameters_Boolean_Out_ScriptableCullingParameters.SetBelong(this.instance);
				}
				return r_TryGetCullingParameters_Boolean_Out_ScriptableCullingParameters;
			}
		}

		/// <summary>
		/// Boolean GetCullingParameters_Internal(UnityEngine.Camera, Boolean, UnityEngine.Rendering.ScriptableCullingParameters ByRef, Int32)
		/// </summary>
		protected static RMethod r_GetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32;
		public static RMethod RGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32
		{
			get
			{
				if(r_GetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32 == null)
				{
					r_GetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32 = new(typeof(UnityEngine.Camera), "GetCullingParameters_Internal", 0, typeof(UnityEngine.Camera), typeof(System.Boolean), typeof(UnityEngine.Rendering.ScriptableCullingParameters).MakeByRefType(), typeof(System.Int32));
					r_GetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32.SetBelong(null);
				}
				return r_GetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32;
			}
		}

		/// <summary>
		/// Single GetScreenWidth()
		/// </summary>
		protected RMethod r_GetScreenWidth;
		public virtual RMethod RGetScreenWidth
		{
			get
			{
				if(r_GetScreenWidth == null)
				{
					r_GetScreenWidth = new(this, "GetScreenWidth", 0);
					r_GetScreenWidth.SetBelong(this.instance);
				}
				return r_GetScreenWidth;
			}
		}

		/// <summary>
		/// Single GetScreenHeight()
		/// </summary>
		protected RMethod r_GetScreenHeight;
		public virtual RMethod RGetScreenHeight
		{
			get
			{
				if(r_GetScreenHeight == null)
				{
					r_GetScreenHeight = new(this, "GetScreenHeight", 0);
					r_GetScreenHeight.SetBelong(this.instance);
				}
				return r_GetScreenHeight;
			}
		}

		/// <summary>
		/// Void DoClear()
		/// </summary>
		protected RMethod r_DoClear;
		public virtual RMethod RDoClear
		{
			get
			{
				if(r_DoClear == null)
				{
					r_DoClear = new(this, "DoClear", 0);
					r_DoClear.SetBelong(this.instance);
				}
				return r_DoClear;
			}
		}

		/// <summary>
		/// Void ResetFieldOfView()
		/// </summary>
		protected RMethod r_ResetFieldOfView;
		public virtual RMethod RResetFieldOfView
		{
			get
			{
				if(r_ResetFieldOfView == null)
				{
					r_ResetFieldOfView = new(this, "ResetFieldOfView", 0);
					r_ResetFieldOfView.SetBelong(this.instance);
				}
				return r_ResetFieldOfView;
			}
		}

		/// <summary>
		/// Void SetStereoViewMatrices(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetStereoViewMatrices_Matrix4x4_Matrix4x4;
		public virtual RMethod RSetStereoViewMatrices_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_SetStereoViewMatrices_Matrix4x4_Matrix4x4 == null)
				{
					r_SetStereoViewMatrices_Matrix4x4_Matrix4x4 = new(this, "SetStereoViewMatrices", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
					r_SetStereoViewMatrices_Matrix4x4_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetStereoViewMatrices_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetStereoProjectionMatrices(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetStereoProjectionMatrices_Matrix4x4_Matrix4x4;
		public virtual RMethod RSetStereoProjectionMatrices_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_SetStereoProjectionMatrices_Matrix4x4_Matrix4x4 == null)
				{
					r_SetStereoProjectionMatrices_Matrix4x4_Matrix4x4 = new(this, "SetStereoProjectionMatrices", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
					r_SetStereoProjectionMatrices_Matrix4x4_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetStereoProjectionMatrices_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetStereoViewMatrices()
		/// </summary>
		protected RMethod r_GetStereoViewMatrices;
		public virtual RMethod RGetStereoViewMatrices
		{
			get
			{
				if(r_GetStereoViewMatrices == null)
				{
					r_GetStereoViewMatrices = new(this, "GetStereoViewMatrices", 0);
					r_GetStereoViewMatrices.SetBelong(this.instance);
				}
				return r_GetStereoViewMatrices;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetStereoProjectionMatrices()
		/// </summary>
		protected RMethod r_GetStereoProjectionMatrices;
		public virtual RMethod RGetStereoProjectionMatrices
		{
			get
			{
				if(r_GetStereoProjectionMatrices == null)
				{
					r_GetStereoProjectionMatrices = new(this, "GetStereoProjectionMatrices", 0);
					r_GetStereoProjectionMatrices.SetBelong(this.instance);
				}
				return r_GetStereoProjectionMatrices;
			}
		}

		/// <summary>
		/// Void get_transparencySortAxis_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_get_transparencySortAxis_Injected_Out_Vector3;
		public virtual RMethod Rget_transparencySortAxis_Injected_Out_Vector3
		{
			get
			{
				if(r_get_transparencySortAxis_Injected_Out_Vector3 == null)
				{
					r_get_transparencySortAxis_Injected_Out_Vector3 = new(this, "get_transparencySortAxis_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_get_transparencySortAxis_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_get_transparencySortAxis_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_transparencySortAxis_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_set_transparencySortAxis_Injected_Ref_Vector3;
		public virtual RMethod Rset_transparencySortAxis_Injected_Ref_Vector3
		{
			get
			{
				if(r_set_transparencySortAxis_Injected_Ref_Vector3 == null)
				{
					r_set_transparencySortAxis_Injected_Ref_Vector3 = new(this, "set_transparencySortAxis_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_set_transparencySortAxis_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_set_transparencySortAxis_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_velocity_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_get_velocity_Injected_Out_Vector3;
		public virtual RMethod Rget_velocity_Injected_Out_Vector3
		{
			get
			{
				if(r_get_velocity_Injected_Out_Vector3 == null)
				{
					r_get_velocity_Injected_Out_Vector3 = new(this, "get_velocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_get_velocity_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_get_velocity_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_cullingMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_cullingMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_cullingMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_cullingMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_cullingMatrix_Injected_Out_Matrix4x4 = new(this, "get_cullingMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_cullingMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_cullingMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_cullingMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_set_cullingMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod Rset_cullingMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_set_cullingMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_set_cullingMatrix_Injected_Ref_Matrix4x4 = new(this, "set_cullingMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_set_cullingMatrix_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_set_cullingMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_get_backgroundColor_Injected_Out_Color;
		public virtual RMethod Rget_backgroundColor_Injected_Out_Color
		{
			get
			{
				if(r_get_backgroundColor_Injected_Out_Color == null)
				{
					r_get_backgroundColor_Injected_Out_Color = new(this, "get_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_get_backgroundColor_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_get_backgroundColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_set_backgroundColor_Injected_Ref_Color;
		public virtual RMethod Rset_backgroundColor_Injected_Ref_Color
		{
			get
			{
				if(r_set_backgroundColor_Injected_Ref_Color == null)
				{
					r_set_backgroundColor_Injected_Ref_Color = new(this, "set_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_set_backgroundColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_set_backgroundColor_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void get_curvature_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_get_curvature_Injected_Out_Vector2;
		public virtual RMethod Rget_curvature_Injected_Out_Vector2
		{
			get
			{
				if(r_get_curvature_Injected_Out_Vector2 == null)
				{
					r_get_curvature_Injected_Out_Vector2 = new(this, "get_curvature_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_get_curvature_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_get_curvature_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_curvature_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_set_curvature_Injected_Ref_Vector2;
		public virtual RMethod Rset_curvature_Injected_Ref_Vector2
		{
			get
			{
				if(r_set_curvature_Injected_Ref_Vector2 == null)
				{
					r_set_curvature_Injected_Ref_Vector2 = new(this, "set_curvature_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_set_curvature_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_set_curvature_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_sensorSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_get_sensorSize_Injected_Out_Vector2;
		public virtual RMethod Rget_sensorSize_Injected_Out_Vector2
		{
			get
			{
				if(r_get_sensorSize_Injected_Out_Vector2 == null)
				{
					r_get_sensorSize_Injected_Out_Vector2 = new(this, "get_sensorSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_get_sensorSize_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_get_sensorSize_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_sensorSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_set_sensorSize_Injected_Ref_Vector2;
		public virtual RMethod Rset_sensorSize_Injected_Ref_Vector2
		{
			get
			{
				if(r_set_sensorSize_Injected_Ref_Vector2 == null)
				{
					r_set_sensorSize_Injected_Ref_Vector2 = new(this, "set_sensorSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_set_sensorSize_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_set_sensorSize_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_lensShift_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_get_lensShift_Injected_Out_Vector2;
		public virtual RMethod Rget_lensShift_Injected_Out_Vector2
		{
			get
			{
				if(r_get_lensShift_Injected_Out_Vector2 == null)
				{
					r_get_lensShift_Injected_Out_Vector2 = new(this, "get_lensShift_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_get_lensShift_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_get_lensShift_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_lensShift_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_set_lensShift_Injected_Ref_Vector2;
		public virtual RMethod Rset_lensShift_Injected_Ref_Vector2
		{
			get
			{
				if(r_set_lensShift_Injected_Ref_Vector2 == null)
				{
					r_set_lensShift_Injected_Ref_Vector2 = new(this, "set_lensShift_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_set_lensShift_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_set_lensShift_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void GetGateFittedLensShift_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_GetGateFittedLensShift_Injected_Out_Vector2;
		public virtual RMethod RGetGateFittedLensShift_Injected_Out_Vector2
		{
			get
			{
				if(r_GetGateFittedLensShift_Injected_Out_Vector2 == null)
				{
					r_GetGateFittedLensShift_Injected_Out_Vector2 = new(this, "GetGateFittedLensShift_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_GetGateFittedLensShift_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_GetGateFittedLensShift_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void GetLocalSpaceAim_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_GetLocalSpaceAim_Injected_Out_Vector3;
		public virtual RMethod RGetLocalSpaceAim_Injected_Out_Vector3
		{
			get
			{
				if(r_GetLocalSpaceAim_Injected_Out_Vector3 == null)
				{
					r_GetLocalSpaceAim_Injected_Out_Vector3 = new(this, "GetLocalSpaceAim_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_GetLocalSpaceAim_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_GetLocalSpaceAim_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_rect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_get_rect_Injected_Out_Rect;
		public virtual RMethod Rget_rect_Injected_Out_Rect
		{
			get
			{
				if(r_get_rect_Injected_Out_Rect == null)
				{
					r_get_rect_Injected_Out_Rect = new(this, "get_rect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_get_rect_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_get_rect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void set_rect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_set_rect_Injected_Ref_Rect;
		public virtual RMethod Rset_rect_Injected_Ref_Rect
		{
			get
			{
				if(r_set_rect_Injected_Ref_Rect == null)
				{
					r_set_rect_Injected_Ref_Rect = new(this, "set_rect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_set_rect_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_set_rect_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void get_pixelRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_get_pixelRect_Injected_Out_Rect;
		public virtual RMethod Rget_pixelRect_Injected_Out_Rect
		{
			get
			{
				if(r_get_pixelRect_Injected_Out_Rect == null)
				{
					r_get_pixelRect_Injected_Out_Rect = new(this, "get_pixelRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_get_pixelRect_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_get_pixelRect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void set_pixelRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_set_pixelRect_Injected_Ref_Rect;
		public virtual RMethod Rset_pixelRect_Injected_Ref_Rect
		{
			get
			{
				if(r_set_pixelRect_Injected_Ref_Rect == null)
				{
					r_set_pixelRect_Injected_Ref_Rect = new(this, "set_pixelRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_set_pixelRect_Injected_Ref_Rect.SetBelong(this.instance);
				}
				return r_set_pixelRect_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersImpl_Injected(UnityEngine.RenderBuffer ByRef, UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_SetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer;
		public virtual RMethod RSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer
		{
			get
			{
				if(r_SetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer == null)
				{
					r_SetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer = new(this, "SetTargetBuffersImpl_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType(), typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_SetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer.SetBelong(this.instance);
				}
				return r_SetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersMRTImpl_Injected(UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_SetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer;
		public virtual RMethod RSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer
		{
			get
			{
				if(r_SetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer == null)
				{
					r_SetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer = new(this, "SetTargetBuffersMRTImpl_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeArrayType(), typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_SetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer.SetBelong(this.instance);
				}
				return r_SetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// Void get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_cameraToWorldMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_cameraToWorldMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_cameraToWorldMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_cameraToWorldMatrix_Injected_Out_Matrix4x4 = new(this, "get_cameraToWorldMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_cameraToWorldMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_cameraToWorldMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_worldToCameraMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_worldToCameraMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_worldToCameraMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_worldToCameraMatrix_Injected_Out_Matrix4x4 = new(this, "get_worldToCameraMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_worldToCameraMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_worldToCameraMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_set_worldToCameraMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod Rset_worldToCameraMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_set_worldToCameraMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_set_worldToCameraMatrix_Injected_Ref_Matrix4x4 = new(this, "set_worldToCameraMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_set_worldToCameraMatrix_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_set_worldToCameraMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_projectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_projectionMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_projectionMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_projectionMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_projectionMatrix_Injected_Out_Matrix4x4 = new(this, "get_projectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_projectionMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_projectionMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_projectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_set_projectionMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod Rset_projectionMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_set_projectionMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_set_projectionMatrix_Injected_Ref_Matrix4x4 = new(this, "set_projectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_set_projectionMatrix_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_set_projectionMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4 = new(this, "get_nonJitteredProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_set_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod Rset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_set_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_set_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4 = new(this, "set_nonJitteredProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_set_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_set_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_previousViewProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_get_previousViewProjectionMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_previousViewProjectionMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_get_previousViewProjectionMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_get_previousViewProjectionMatrix_Injected_Out_Matrix4x4 = new(this, "get_previousViewProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_get_previousViewProjectionMatrix_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_get_previousViewProjectionMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void CalculateObliqueMatrix_Injected(UnityEngine.Vector4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_CalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4;
		public virtual RMethod RCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4
		{
			get
			{
				if(r_CalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4 == null)
				{
					r_CalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4 = new(this, "CalculateObliqueMatrix_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_CalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_CalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void WorldToScreenPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_WorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_WorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_WorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "WorldToScreenPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
					r_WorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.SetBelong(this.instance);
				}
				return r_WorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void WorldToViewportPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_WorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_WorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_WorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "WorldToViewportPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
					r_WorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.SetBelong(this.instance);
				}
				return r_WorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ViewportToWorldPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_ViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_ViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_ViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "ViewportToWorldPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.SetBelong(this.instance);
				}
				return r_ViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ScreenToWorldPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_ScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_ScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_ScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "ScreenToWorldPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.SetBelong(this.instance);
				}
				return r_ScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ScreenToViewportPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_ScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_ScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_ScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "ScreenToViewportPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_ScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ViewportToScreenPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_ViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_ViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_ViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "ViewportToScreenPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_ViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_ViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void GetFrustumPlaneSizeAt_Injected(Single, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_GetFrustumPlaneSizeAt_Injected_Single_Out_Vector2;
		public virtual RMethod RGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2
		{
			get
			{
				if(r_GetFrustumPlaneSizeAt_Injected_Single_Out_Vector2 == null)
				{
					r_GetFrustumPlaneSizeAt_Injected_Single_Out_Vector2 = new(this, "GetFrustumPlaneSizeAt_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector2).MakeByRefType());
					r_GetFrustumPlaneSizeAt_Injected_Single_Out_Vector2.SetBelong(this.instance);
				}
				return r_GetFrustumPlaneSizeAt_Injected_Single_Out_Vector2;
			}
		}

		/// <summary>
		/// Void ViewportPointToRay_Injected(UnityEngine.Vector2 ByRef, MonoOrStereoscopicEye, UnityEngine.Ray ByRef)
		/// </summary>
		protected RMethod r_ViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
		public virtual RMethod RViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray
		{
			get
			{
				if(r_ViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray == null)
				{
					r_ViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray = new(this, "ViewportPointToRay_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Ray).MakeByRefType());
					r_ViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray.SetBelong(this.instance);
				}
				return r_ViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
			}
		}

		/// <summary>
		/// Void ScreenPointToRay_Injected(UnityEngine.Vector2 ByRef, MonoOrStereoscopicEye, UnityEngine.Ray ByRef)
		/// </summary>
		protected RMethod r_ScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
		public virtual RMethod RScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray
		{
			get
			{
				if(r_ScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray == null)
				{
					r_ScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray = new(this, "ScreenPointToRay_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Ray).MakeByRefType());
					r_ScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray.SetBelong(this.instance);
				}
				return r_ScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
			}
		}

		/// <summary>
		/// Void CalculateFrustumCornersInternal_Injected(UnityEngine.Rect ByRef, Single, MonoOrStereoscopicEye, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_CalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
		public virtual RMethod RCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array
		{
			get
			{
				if(r_CalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array == null)
				{
					r_CalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array = new(this, "CalculateFrustumCornersInternal_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeArrayType());
					r_CalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array.SetBelong(this.instance);
				}
				return r_CalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
			}
		}

		/// <summary>
		/// Void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matrix4x4 ByRef, Single, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Single, Single, Single, GateFitMode)
		/// </summary>
		protected static RMethod r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode;
		public static RMethod RCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode
		{
			get
			{
				if(r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode == null)
				{
					r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode = new(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+GateFitMode"));
					r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode.SetBelong(null);
				}
				return r_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode;
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
		/// Void set_scene_Injected(UnityEngine.SceneManagement.Scene ByRef)
		/// </summary>
		protected RMethod r_set_scene_Injected_Ref_Scene;
		public virtual RMethod Rset_scene_Injected_Ref_Scene
		{
			get
			{
				if(r_set_scene_Injected_Ref_Scene == null)
				{
					r_set_scene_Injected_Ref_Scene = new(this, "set_scene_Injected", 0, typeof(UnityEngine.SceneManagement.Scene).MakeByRefType());
					r_set_scene_Injected_Ref_Scene.SetBelong(this.instance);
				}
				return r_set_scene_Injected_Ref_Scene;
			}
		}

		/// <summary>
		/// Void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_GetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
		public virtual RMethod RGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4
		{
			get
			{
				if(r_GetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 == null)
				{
					r_GetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 = new(this, "GetStereoNonJitteredProjectionMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_GetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetStereoViewMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_GetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
		public virtual RMethod RGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4
		{
			get
			{
				if(r_GetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4 == null)
				{
					r_GetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4 = new(this, "GetStereoViewMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_GetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetStereoProjectionMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_GetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
		public virtual RMethod RGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4
		{
			get
			{
				if(r_GetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 == null)
				{
					r_GetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 = new(this, "GetStereoProjectionMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_GetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_GetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetStereoProjectionMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_SetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
		public virtual RMethod RSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4
		{
			get
			{
				if(r_SetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 == null)
				{
					r_SetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 = new(this, "SetStereoProjectionMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_SetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetStereoViewMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_SetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
		public virtual RMethod RSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4
		{
			get
			{
				if(r_SetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 == null)
				{
					r_SetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 = new(this, "SetStereoViewMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_SetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
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


        public RCamera() : base("UnityEngine.Camera")
        {
        }

        public RCamera(System.Object instance) : base("UnityEngine.Camera")
		{
            SetInstance(instance);
		}

        public RCamera(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCamera(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetTransparencySortSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetTransparencySortSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAspect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetAspect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single[] GetLayerCullDistances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLayerCullDistances.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual void SetLayerCullDistances(System.Single[]  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RSetLayerCullDistances_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCullingMatrix()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCullingMatrix.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReplacementShader(UnityEngine.Shader  @shader, System.String  @replacementTag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @replacementTag};
            var ___result = RSetReplacementShader_Shader_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetReplacementShader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetReplacementShader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetGateFittedFieldOfView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGateFittedFieldOfView.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector2 GetGateFittedLensShift()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGateFittedLensShift.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector3 GetLocalSpaceAim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLocalSpaceAim.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void SetTargetBuffersImpl(UnityEngine.RenderBuffer  @color, UnityEngine.RenderBuffer  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RSetTargetBuffersImpl_RenderBuffer_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTargetBuffers(UnityEngine.RenderBuffer  @colorBuffer, UnityEngine.RenderBuffer  @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorBuffer, @depthBuffer};
            var ___result = RSetTargetBuffers_RenderBuffer_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[]  @color, UnityEngine.RenderBuffer  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTargetBuffers(UnityEngine.RenderBuffer[]  @colorBuffer, UnityEngine.RenderBuffer  @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorBuffer, @depthBuffer};
            var ___result = RSetTargetBuffers_RenderBufferArray_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetCameraBufferWarnings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCameraBufferWarnings.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void ResetWorldToCameraMatrix()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetWorldToCameraMatrix.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetProjectionMatrix()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetProjectionMatrix.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4  @clipPlane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clipPlane};
            var ___result = RCalculateObliqueMatrix_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4)___result;
        }






        public virtual UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RWorldToScreenPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RWorldToViewportPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RViewportToWorldPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RScreenToWorldPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RScreenToViewportPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RViewportToScreenPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector2 GetFrustumPlaneSizeAt(System.Single  @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@distance};
            var ___result = RGetFrustumPlaneSizeAt_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }




        public virtual UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RViewportPointToRay_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Ray)___result;
        }




        public virtual UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RScreenPointToRay_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Ray)___result;
        }






        public static System.Single FocalLengthToFieldOfView(System.Single  @focalLength, System.Single  @sensorSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focalLength, @sensorSize};
            var ___result = RFocalLengthToFieldOfView_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single FieldOfViewToFocalLength(System.Single  @fieldOfView, System.Single  @sensorSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldOfView, @sensorSize};
            var ___result = RFieldOfViewToFocalLength_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single HorizontalToVerticalFieldOfView(System.Single  @horizontalFieldOfView, System.Single  @aspectRatio)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@horizontalFieldOfView, @aspectRatio};
            var ___result = RHorizontalToVerticalFieldOfView_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single VerticalToHorizontalFieldOfView(System.Single  @verticalFieldOfView, System.Single  @aspectRatio)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@verticalFieldOfView, @aspectRatio};
            var ___result = RVerticalToHorizontalFieldOfView_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }







        public virtual void ResetStereoProjectionMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetStereoProjectionMatrices.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ResetStereoViewMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetStereoViewMatrices.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetAllCamerasCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllCamerasCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetAllCamerasImpl(UnityEngine.Camera[]  @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RGetAllCamerasImpl_CameraArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetAllCameras(UnityEngine.Camera[]  @cameras)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cameras};
            var ___result = RGetAllCameras_CameraArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean RenderToCubemapImpl(UnityEngine.Texture  @tex, System.Int32  @faceMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex, @faceMask};
            var ___result = RRenderToCubemapImpl_Texture_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.Cubemap  @cubemap, System.Int32  @faceMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap, @faceMask};
            var ___result = RRenderToCubemap_Cubemap_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.Cubemap  @cubemap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap};
            var ___result = RRenderToCubemap_Cubemap.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.RenderTexture  @cubemap, System.Int32  @faceMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap, @faceMask};
            var ___result = RRenderToCubemap_RenderTexture_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.RenderTexture  @cubemap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap};
            var ___result = RRenderToCubemap_RenderTexture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetFilterMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFilterMode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual void Render()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRender.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RenderWithShader(UnityEngine.Shader  @shader, System.String  @replacementTag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @replacementTag};
            var ___result = RRenderWithShader_Shader_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RenderDontRestore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRenderDontRestore.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SubmitRenderRequest<RequestData>(RequestData  @renderRequest)
        {

            var ___genericsType = new Type[] {typeof(RequestData)};
            var ___parameters = new object[]{@renderRequest};
            var ___result = RSubmitRenderRequest_GRequestData_RequestData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SubmitRenderRequestsInternal(System.Object  @requests)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requests};
            var ___result = RSubmitRenderRequestsInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetupCurrent(UnityEngine.Camera  @cur)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cur};
            var ___result = RSetupCurrent_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(UnityEngine.Camera  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCopyFrom_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RRemoveCommandBuffers_CameraEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAllCommandBuffers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveAllCommandBuffers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RAddCommandBufferImpl_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer, UnityEngine.Rendering.ComputeQueueType  @queueType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @queueType};
            var ___result = RAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RRemoveCommandBufferImpl_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBuffer(UnityEngine.Rendering.CameraEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RAddCommandBuffer_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer, UnityEngine.Rendering.ComputeQueueType  @queueType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @queueType};
            var ___result = RAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RRemoveCommandBuffer_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RGetCommandBuffers_CameraEvent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.CommandBuffer[])___result;
        }


        public static void FireOnPreCull(UnityEngine.Camera  @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RFireOnPreCull_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public static void FireOnPreRender(UnityEngine.Camera  @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RFireOnPreRender_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public static void FireOnPostRender(UnityEngine.Camera  @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RFireOnPostRender_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnlyUsedForTesting1()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnlyUsedForTesting1.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnlyUsedForTesting2()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnlyUsedForTesting2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetCullingParameters(out UnityEngine.Rendering.ScriptableCullingParameters  @cullingParameters)
        {
			cullingParameters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cullingParameters};
            var ___result = RTryGetCullingParameters_Out_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);
			cullingParameters = (UnityEngine.Rendering.ScriptableCullingParameters)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetCullingParameters(System.Boolean  @stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters  @cullingParameters)
        {
			cullingParameters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stereoAware, @cullingParameters};
            var ___result = RTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);
			cullingParameters = (UnityEngine.Rendering.ScriptableCullingParameters)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean GetCullingParameters_Internal(UnityEngine.Camera  @camera, System.Boolean  @stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters  @cullingParameters, System.Int32  @managedCullingParametersSize)
        {
			cullingParameters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@camera, @stereoAware, @cullingParameters, @managedCullingParametersSize};
            var ___result = RGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32.Invoke(___genericsType, ___parameters);
			cullingParameters = (UnityEngine.Rendering.ScriptableCullingParameters)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Single GetScreenWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScreenWidth.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetScreenHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScreenHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void DoClear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetFieldOfView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetFieldOfView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStereoViewMatrices(UnityEngine.Matrix4x4  @leftMatrix, UnityEngine.Matrix4x4  @rightMatrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leftMatrix, @rightMatrix};
            var ___result = RSetStereoViewMatrices_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStereoProjectionMatrices(UnityEngine.Matrix4x4  @leftMatrix, UnityEngine.Matrix4x4  @rightMatrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leftMatrix, @rightMatrix};
            var ___result = RSetStereoProjectionMatrices_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Matrix4x4[] GetStereoViewMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStereoViewMatrices.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual UnityEngine.Matrix4x4[] GetStereoProjectionMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStereoProjectionMatrices.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Matrix4x4[])___result;
        }


        public virtual void get_transparencySortAxis_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_transparencySortAxis_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_transparencySortAxis_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_transparencySortAxis_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_velocity_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_velocity_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_cullingMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_cullingMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_cullingMatrix_Injected(ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_cullingMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[0];

            
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


        public virtual void get_curvature_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_curvature_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_curvature_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_curvature_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_sensorSize_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_sensorSize_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_sensorSize_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_sensorSize_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_lensShift_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_lensShift_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_lensShift_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_lensShift_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetGateFittedLensShift_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetGateFittedLensShift_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetLocalSpaceAim_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetLocalSpaceAim_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_rect_Injected(out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_rect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void set_rect_Injected(ref UnityEngine.Rect  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_rect_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void get_pixelRect_Injected(out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_pixelRect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void set_pixelRect_Injected(ref UnityEngine.Rect  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_pixelRect_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void SetTargetBuffersImpl_Injected(ref UnityEngine.RenderBuffer  @color, ref UnityEngine.RenderBuffer  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			color = (UnityEngine.RenderBuffer)___parameters[0];
			depth = (UnityEngine.RenderBuffer)___parameters[1];

            
        }


        public virtual void SetTargetBuffersMRTImpl_Injected(UnityEngine.RenderBuffer[]  @color, ref UnityEngine.RenderBuffer  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			depth = (UnityEngine.RenderBuffer)___parameters[1];

            
        }


        public virtual void get_cameraToWorldMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_cameraToWorldMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_worldToCameraMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_worldToCameraMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_worldToCameraMatrix_Injected(ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_worldToCameraMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_projectionMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_projectionMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_projectionMatrix_Injected(ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_projectionMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_nonJitteredProjectionMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_nonJitteredProjectionMatrix_Injected(ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_previousViewProjectionMatrix_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_previousViewProjectionMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void CalculateObliqueMatrix_Injected(ref UnityEngine.Vector4  @clipPlane, out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clipPlane, @ret};
            var ___result = RCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			clipPlane = (UnityEngine.Vector4)___parameters[0];
			ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }






        public virtual void ScreenToViewportPoint_Injected(ref UnityEngine.Vector3  @position, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void ViewportToScreenPoint_Injected(ref UnityEngine.Vector3  @position, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void GetFrustumPlaneSizeAt_Injected(System.Single  @distance, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@distance, @ret};
            var ___result = RGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[1];

            
        }






        public virtual void get_scene_Injected(out UnityEngine.SceneManagement.Scene  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_scene_Injected_Out_Scene.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
        }


        public virtual void set_scene_Injected(ref UnityEngine.SceneManagement.Scene  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_scene_Injected_Ref_Scene.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
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
