
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Camera
	/// </summary>
    public partial class RCamera : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Camera);
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


		/// <summary>
		/// System.Single kMinAperture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkMinAperture;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkMinAperture
		{
			get
			{
				if(r_FkMinAperture == null)
				{
					r_FkMinAperture = new(Type, "kMinAperture");
				}
				return r_FkMinAperture;
			}
		}

		/// <summary>
		/// System.Single kMaxAperture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkMaxAperture;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkMaxAperture
		{
			get
			{
				if(r_FkMaxAperture == null)
				{
					r_FkMaxAperture = new(Type, "kMaxAperture");
				}
				return r_FkMaxAperture;
			}
		}

		/// <summary>
		/// System.Int32 kMinBladeCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FkMinBladeCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFkMinBladeCount
		{
			get
			{
				if(r_FkMinBladeCount == null)
				{
					r_FkMinBladeCount = new(Type, "kMinBladeCount");
				}
				return r_FkMinBladeCount;
			}
		}

		/// <summary>
		/// System.Int32 kMaxBladeCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FkMaxBladeCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFkMaxBladeCount
		{
			get
			{
				if(r_FkMaxBladeCount == null)
				{
					r_FkMaxBladeCount = new(Type, "kMaxBladeCount");
				}
				return r_FkMaxBladeCount;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+CameraCallback onPreCull
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RCameraCallback r_FonPreCull;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RCameraCallback RFonPreCull
		{
			get
			{
				if(r_FonPreCull == null)
				{
					r_FonPreCull = new(Type, "onPreCull");
				}
				return r_FonPreCull;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+CameraCallback onPreRender
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RCameraCallback r_FonPreRender;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RCameraCallback RFonPreRender
		{
			get
			{
				if(r_FonPreRender == null)
				{
					r_FonPreRender = new(Type, "onPreRender");
				}
				return r_FonPreRender;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+CameraCallback onPostRender
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RCameraCallback r_FonPostRender;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RCameraCallback RFonPostRender
		{
			get
			{
				if(r_FonPostRender == null)
				{
					r_FonPostRender = new(Type, "onPostRender");
				}
				return r_FonPostRender;
			}
		}

		/// <summary>
		/// Single nearClipPlane
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PnearClipPlane;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPnearClipPlane
		{
			get
			{
				if(r_PnearClipPlane == null)
				{
					r_PnearClipPlane = new(this, "nearClipPlane", -1);
				}
				return r_PnearClipPlane;
			}
		}

		/// <summary>
		/// Single farClipPlane
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfarClipPlane;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfarClipPlane
		{
			get
			{
				if(r_PfarClipPlane == null)
				{
					r_PfarClipPlane = new(this, "farClipPlane", -1);
				}
				return r_PfarClipPlane;
			}
		}

		/// <summary>
		/// Single fieldOfView
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfieldOfView;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfieldOfView
		{
			get
			{
				if(r_PfieldOfView == null)
				{
					r_PfieldOfView = new(this, "fieldOfView", -1);
				}
				return r_PfieldOfView;
			}
		}

		/// <summary>
		/// UnityEngine.RenderingPath renderingPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderingPath r_PrenderingPath;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderingPath RPrenderingPath
		{
			get
			{
				if(r_PrenderingPath == null)
				{
					r_PrenderingPath = new(this, "renderingPath", -1);
				}
				return r_PrenderingPath;
			}
		}

		/// <summary>
		/// UnityEngine.RenderingPath actualRenderingPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderingPath r_PactualRenderingPath;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderingPath RPactualRenderingPath
		{
			get
			{
				if(r_PactualRenderingPath == null)
				{
					r_PactualRenderingPath = new(this, "actualRenderingPath", -1);
				}
				return r_PactualRenderingPath;
			}
		}

		/// <summary>
		/// Boolean allowHDR
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowHDR;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPallowHDR
		{
			get
			{
				if(r_PallowHDR == null)
				{
					r_PallowHDR = new(this, "allowHDR", -1);
				}
				return r_PallowHDR;
			}
		}

		/// <summary>
		/// Boolean allowMSAA
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowMSAA;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPallowMSAA
		{
			get
			{
				if(r_PallowMSAA == null)
				{
					r_PallowMSAA = new(this, "allowMSAA", -1);
				}
				return r_PallowMSAA;
			}
		}

		/// <summary>
		/// Boolean allowDynamicResolution
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowDynamicResolution;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPallowDynamicResolution
		{
			get
			{
				if(r_PallowDynamicResolution == null)
				{
					r_PallowDynamicResolution = new(this, "allowDynamicResolution", -1);
				}
				return r_PallowDynamicResolution;
			}
		}

		/// <summary>
		/// Boolean forceIntoRenderTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PforceIntoRenderTexture;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPforceIntoRenderTexture
		{
			get
			{
				if(r_PforceIntoRenderTexture == null)
				{
					r_PforceIntoRenderTexture = new(this, "forceIntoRenderTexture", -1);
				}
				return r_PforceIntoRenderTexture;
			}
		}

		/// <summary>
		/// Single orthographicSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PorthographicSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPorthographicSize
		{
			get
			{
				if(r_PorthographicSize == null)
				{
					r_PorthographicSize = new(this, "orthographicSize", -1);
				}
				return r_PorthographicSize;
			}
		}

		/// <summary>
		/// Boolean orthographic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Porthographic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPorthographic
		{
			get
			{
				if(r_Porthographic == null)
				{
					r_Porthographic = new(this, "orthographic", -1);
				}
				return r_Porthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.OpaqueSortMode opaqueSortMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.ROpaqueSortMode r_PopaqueSortMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.ROpaqueSortMode RPopaqueSortMode
		{
			get
			{
				if(r_PopaqueSortMode == null)
				{
					r_PopaqueSortMode = new(this, "opaqueSortMode", -1);
				}
				return r_PopaqueSortMode;
			}
		}

		/// <summary>
		/// UnityEngine.TransparencySortMode transparencySortMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransparencySortMode r_PtransparencySortMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransparencySortMode RPtransparencySortMode
		{
			get
			{
				if(r_PtransparencySortMode == null)
				{
					r_PtransparencySortMode = new(this, "transparencySortMode", -1);
				}
				return r_PtransparencySortMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 transparencySortAxis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PtransparencySortAxis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPtransparencySortAxis
		{
			get
			{
				if(r_PtransparencySortAxis == null)
				{
					r_PtransparencySortAxis = new(this, "transparencySortAxis", -1);
				}
				return r_PtransparencySortAxis;
			}
		}

		/// <summary>
		/// Single depth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pdepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPdepth
		{
			get
			{
				if(r_Pdepth == null)
				{
					r_Pdepth = new(this, "depth", -1);
				}
				return r_Pdepth;
			}
		}

		/// <summary>
		/// Single aspect
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Paspect;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPaspect
		{
			get
			{
				if(r_Paspect == null)
				{
					r_Paspect = new(this, "aspect", -1);
				}
				return r_Paspect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 velocity
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pvelocity;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPvelocity
		{
			get
			{
				if(r_Pvelocity == null)
				{
					r_Pvelocity = new(this, "velocity", -1);
				}
				return r_Pvelocity;
			}
		}

		/// <summary>
		/// Int32 cullingMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcullingMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcullingMask
		{
			get
			{
				if(r_PcullingMask == null)
				{
					r_PcullingMask = new(this, "cullingMask", -1);
				}
				return r_PcullingMask;
			}
		}

		/// <summary>
		/// Int32 eventMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PeventMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPeventMask
		{
			get
			{
				if(r_PeventMask == null)
				{
					r_PeventMask = new(this, "eventMask", -1);
				}
				return r_PeventMask;
			}
		}

		/// <summary>
		/// Boolean layerCullSpherical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PlayerCullSpherical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPlayerCullSpherical
		{
			get
			{
				if(r_PlayerCullSpherical == null)
				{
					r_PlayerCullSpherical = new(this, "layerCullSpherical", -1);
				}
				return r_PlayerCullSpherical;
			}
		}

		/// <summary>
		/// UnityEngine.CameraType cameraType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCameraType r_PcameraType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCameraType RPcameraType
		{
			get
			{
				if(r_PcameraType == null)
				{
					r_PcameraType = new(this, "cameraType", -1);
				}
				return r_PcameraType;
			}
		}

		/// <summary>
		/// UnityEngine.Material skyboxMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_PskyboxMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPskyboxMaterial
		{
			get
			{
				if(r_PskyboxMaterial == null)
				{
					r_PskyboxMaterial = new(this, "skyboxMaterial", -1);
				}
				return r_PskyboxMaterial;
			}
		}

		/// <summary>
		/// UInt64 overrideSceneCullingMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PoverrideSceneCullingMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPoverrideSceneCullingMask
		{
			get
			{
				if(r_PoverrideSceneCullingMask == null)
				{
					r_PoverrideSceneCullingMask = new(this, "overrideSceneCullingMask", -1);
				}
				return r_PoverrideSceneCullingMask;
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
				}
				return r_PsceneCullingMask;
			}
		}

		/// <summary>
		/// Single[] layerCullDistances
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RSingle> r_PlayerCullDistances;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RSingle> RPlayerCullDistances
		{
			get
			{
				if(r_PlayerCullDistances == null)
				{
					r_PlayerCullDistances = new(this, "layerCullDistances", -1);
				}
				return r_PlayerCullDistances;
			}
		}

		/// <summary>
		/// Int32 PreviewCullingLayer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PPreviewCullingLayer;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPPreviewCullingLayer
		{
			get
			{
				if(r_PPreviewCullingLayer == null)
				{
					r_PPreviewCullingLayer = new(Type, "PreviewCullingLayer", -1);
				}
				return r_PPreviewCullingLayer;
			}
		}

		/// <summary>
		/// Boolean useOcclusionCulling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseOcclusionCulling;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseOcclusionCulling
		{
			get
			{
				if(r_PuseOcclusionCulling == null)
				{
					r_PuseOcclusionCulling = new(this, "useOcclusionCulling", -1);
				}
				return r_PuseOcclusionCulling;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cullingMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PcullingMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPcullingMatrix
		{
			get
			{
				if(r_PcullingMatrix == null)
				{
					r_PcullingMatrix = new(this, "cullingMatrix", -1);
				}
				return r_PcullingMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PbackgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPbackgroundColor
		{
			get
			{
				if(r_PbackgroundColor == null)
				{
					r_PbackgroundColor = new(this, "backgroundColor", -1);
				}
				return r_PbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.CameraClearFlags clearFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCameraClearFlags r_PclearFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCameraClearFlags RPclearFlags
		{
			get
			{
				if(r_PclearFlags == null)
				{
					r_PclearFlags = new(this, "clearFlags", -1);
				}
				return r_PclearFlags;
			}
		}

		/// <summary>
		/// UnityEngine.DepthTextureMode depthTextureMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RDepthTextureMode r_PdepthTextureMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RDepthTextureMode RPdepthTextureMode
		{
			get
			{
				if(r_PdepthTextureMode == null)
				{
					r_PdepthTextureMode = new(this, "depthTextureMode", -1);
				}
				return r_PdepthTextureMode;
			}
		}

		/// <summary>
		/// Boolean clearStencilAfterLightingPass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PclearStencilAfterLightingPass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPclearStencilAfterLightingPass
		{
			get
			{
				if(r_PclearStencilAfterLightingPass == null)
				{
					r_PclearStencilAfterLightingPass = new(this, "clearStencilAfterLightingPass", -1);
				}
				return r_PclearStencilAfterLightingPass;
			}
		}

		/// <summary>
		/// ProjectionMatrixMode projectionMatrixMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RProjectionMatrixMode r_PprojectionMatrixMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RProjectionMatrixMode RPprojectionMatrixMode
		{
			get
			{
				if(r_PprojectionMatrixMode == null)
				{
					r_PprojectionMatrixMode = new(this, "projectionMatrixMode", -1);
				}
				return r_PprojectionMatrixMode;
			}
		}

		/// <summary>
		/// Boolean usePhysicalProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PusePhysicalProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPusePhysicalProperties
		{
			get
			{
				if(r_PusePhysicalProperties == null)
				{
					r_PusePhysicalProperties = new(this, "usePhysicalProperties", -1);
				}
				return r_PusePhysicalProperties;
			}
		}

		/// <summary>
		/// Int32 iso
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Piso;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPiso
		{
			get
			{
				if(r_Piso == null)
				{
					r_Piso = new(this, "iso", -1);
				}
				return r_Piso;
			}
		}

		/// <summary>
		/// Single shutterSpeed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PshutterSpeed;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPshutterSpeed
		{
			get
			{
				if(r_PshutterSpeed == null)
				{
					r_PshutterSpeed = new(this, "shutterSpeed", -1);
				}
				return r_PshutterSpeed;
			}
		}

		/// <summary>
		/// Single aperture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Paperture;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPaperture
		{
			get
			{
				if(r_Paperture == null)
				{
					r_Paperture = new(this, "aperture", -1);
				}
				return r_Paperture;
			}
		}

		/// <summary>
		/// Single focusDistance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfocusDistance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfocusDistance
		{
			get
			{
				if(r_PfocusDistance == null)
				{
					r_PfocusDistance = new(this, "focusDistance", -1);
				}
				return r_PfocusDistance;
			}
		}

		/// <summary>
		/// Single focalLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfocalLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfocalLength
		{
			get
			{
				if(r_PfocalLength == null)
				{
					r_PfocalLength = new(this, "focalLength", -1);
				}
				return r_PfocalLength;
			}
		}

		/// <summary>
		/// Int32 bladeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PbladeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbladeCount
		{
			get
			{
				if(r_PbladeCount == null)
				{
					r_PbladeCount = new(this, "bladeCount", -1);
				}
				return r_PbladeCount;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 curvature
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pcurvature;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPcurvature
		{
			get
			{
				if(r_Pcurvature == null)
				{
					r_Pcurvature = new(this, "curvature", -1);
				}
				return r_Pcurvature;
			}
		}

		/// <summary>
		/// Single barrelClipping
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PbarrelClipping;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPbarrelClipping
		{
			get
			{
				if(r_PbarrelClipping == null)
				{
					r_PbarrelClipping = new(this, "barrelClipping", -1);
				}
				return r_PbarrelClipping;
			}
		}

		/// <summary>
		/// Single anamorphism
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Panamorphism;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPanamorphism
		{
			get
			{
				if(r_Panamorphism == null)
				{
					r_Panamorphism = new(this, "anamorphism", -1);
				}
				return r_Panamorphism;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 sensorSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PsensorSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPsensorSize
		{
			get
			{
				if(r_PsensorSize == null)
				{
					r_PsensorSize = new(this, "sensorSize", -1);
				}
				return r_PsensorSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 lensShift
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PlensShift;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPlensShift
		{
			get
			{
				if(r_PlensShift == null)
				{
					r_PlensShift = new(this, "lensShift", -1);
				}
				return r_PlensShift;
			}
		}

		/// <summary>
		/// GateFitMode gateFit
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode r_PgateFit;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode RPgateFit
		{
			get
			{
				if(r_PgateFit == null)
				{
					r_PgateFit = new(this, "gateFit", -1);
				}
				return r_PgateFit;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Prect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPrect
		{
			get
			{
				if(r_Prect == null)
				{
					r_Prect = new(this, "rect", -1);
				}
				return r_Prect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect pixelRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PpixelRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPpixelRect
		{
			get
			{
				if(r_PpixelRect == null)
				{
					r_PpixelRect = new(this, "pixelRect", -1);
				}
				return r_PpixelRect;
			}
		}

		/// <summary>
		/// Int32 pixelWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpixelWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpixelWidth
		{
			get
			{
				if(r_PpixelWidth == null)
				{
					r_PpixelWidth = new(this, "pixelWidth", -1);
				}
				return r_PpixelWidth;
			}
		}

		/// <summary>
		/// Int32 pixelHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpixelHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpixelHeight
		{
			get
			{
				if(r_PpixelHeight == null)
				{
					r_PpixelHeight = new(this, "pixelHeight", -1);
				}
				return r_PpixelHeight;
			}
		}

		/// <summary>
		/// Int32 scaledPixelWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PscaledPixelWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPscaledPixelWidth
		{
			get
			{
				if(r_PscaledPixelWidth == null)
				{
					r_PscaledPixelWidth = new(this, "scaledPixelWidth", -1);
				}
				return r_PscaledPixelWidth;
			}
		}

		/// <summary>
		/// Int32 scaledPixelHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PscaledPixelHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPscaledPixelHeight
		{
			get
			{
				if(r_PscaledPixelHeight == null)
				{
					r_PscaledPixelHeight = new(this, "scaledPixelHeight", -1);
				}
				return r_PscaledPixelHeight;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture targetTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_PtargetTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPtargetTexture
		{
			get
			{
				if(r_PtargetTexture == null)
				{
					r_PtargetTexture = new(this, "targetTexture", -1);
				}
				return r_PtargetTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture activeTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_PactiveTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPactiveTexture
		{
			get
			{
				if(r_PactiveTexture == null)
				{
					r_PactiveTexture = new(this, "activeTexture", -1);
				}
				return r_PactiveTexture;
			}
		}

		/// <summary>
		/// Int32 targetDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtargetDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtargetDisplay
		{
			get
			{
				if(r_PtargetDisplay == null)
				{
					r_PtargetDisplay = new(this, "targetDisplay", -1);
				}
				return r_PtargetDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraToWorldMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PcameraToWorldMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPcameraToWorldMatrix
		{
			get
			{
				if(r_PcameraToWorldMatrix == null)
				{
					r_PcameraToWorldMatrix = new(this, "cameraToWorldMatrix", -1);
				}
				return r_PcameraToWorldMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldToCameraMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldToCameraMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldToCameraMatrix
		{
			get
			{
				if(r_PworldToCameraMatrix == null)
				{
					r_PworldToCameraMatrix = new(this, "worldToCameraMatrix", -1);
				}
				return r_PworldToCameraMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 projectionMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PprojectionMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPprojectionMatrix
		{
			get
			{
				if(r_PprojectionMatrix == null)
				{
					r_PprojectionMatrix = new(this, "projectionMatrix", -1);
				}
				return r_PprojectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 nonJitteredProjectionMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PnonJitteredProjectionMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPnonJitteredProjectionMatrix
		{
			get
			{
				if(r_PnonJitteredProjectionMatrix == null)
				{
					r_PnonJitteredProjectionMatrix = new(this, "nonJitteredProjectionMatrix", -1);
				}
				return r_PnonJitteredProjectionMatrix;
			}
		}

		/// <summary>
		/// Boolean useJitteredProjectionMatrixForTransparentRendering
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseJitteredProjectionMatrixForTransparentRendering;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseJitteredProjectionMatrixForTransparentRendering
		{
			get
			{
				if(r_PuseJitteredProjectionMatrixForTransparentRendering == null)
				{
					r_PuseJitteredProjectionMatrixForTransparentRendering = new(this, "useJitteredProjectionMatrixForTransparentRendering", -1);
				}
				return r_PuseJitteredProjectionMatrixForTransparentRendering;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 previousViewProjectionMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PpreviousViewProjectionMatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPpreviousViewProjectionMatrix
		{
			get
			{
				if(r_PpreviousViewProjectionMatrix == null)
				{
					r_PpreviousViewProjectionMatrix = new(this, "previousViewProjectionMatrix", -1);
				}
				return r_PpreviousViewProjectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Camera main
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera r_Pmain;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera RPmain
		{
			get
			{
				if(r_Pmain == null)
				{
					r_Pmain = new(Type, "main", -1);
				}
				return r_Pmain;
			}
		}

		/// <summary>
		/// UnityEngine.Camera current
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera r_Pcurrent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera RPcurrent
		{
			get
			{
				if(r_Pcurrent == null)
				{
					r_Pcurrent = new(Type, "current", -1);
				}
				return r_Pcurrent;
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
				}
				return r_Pscene;
			}
		}

		/// <summary>
		/// Boolean stereoEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstereoEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstereoEnabled
		{
			get
			{
				if(r_PstereoEnabled == null)
				{
					r_PstereoEnabled = new(this, "stereoEnabled", -1);
				}
				return r_PstereoEnabled;
			}
		}

		/// <summary>
		/// Single stereoSeparation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PstereoSeparation;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPstereoSeparation
		{
			get
			{
				if(r_PstereoSeparation == null)
				{
					r_PstereoSeparation = new(this, "stereoSeparation", -1);
				}
				return r_PstereoSeparation;
			}
		}

		/// <summary>
		/// Single stereoConvergence
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PstereoConvergence;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPstereoConvergence
		{
			get
			{
				if(r_PstereoConvergence == null)
				{
					r_PstereoConvergence = new(this, "stereoConvergence", -1);
				}
				return r_PstereoConvergence;
			}
		}

		/// <summary>
		/// Boolean areVRStereoViewMatricesWithinSingleCullTolerance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PareVRStereoViewMatricesWithinSingleCullTolerance;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPareVRStereoViewMatricesWithinSingleCullTolerance
		{
			get
			{
				if(r_PareVRStereoViewMatricesWithinSingleCullTolerance == null)
				{
					r_PareVRStereoViewMatricesWithinSingleCullTolerance = new(this, "areVRStereoViewMatricesWithinSingleCullTolerance", -1);
				}
				return r_PareVRStereoViewMatricesWithinSingleCullTolerance;
			}
		}

		/// <summary>
		/// UnityEngine.StereoTargetEyeMask stereoTargetEye
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RStereoTargetEyeMask r_PstereoTargetEye;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RStereoTargetEyeMask RPstereoTargetEye
		{
			get
			{
				if(r_PstereoTargetEye == null)
				{
					r_PstereoTargetEye = new(this, "stereoTargetEye", -1);
				}
				return r_PstereoTargetEye;
			}
		}

		/// <summary>
		/// MonoOrStereoscopicEye stereoActiveEye
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye r_PstereoActiveEye;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye RPstereoActiveEye
		{
			get
			{
				if(r_PstereoActiveEye == null)
				{
					r_PstereoActiveEye = new(this, "stereoActiveEye", -1);
				}
				return r_PstereoActiveEye;
			}
		}

		/// <summary>
		/// Int32 allCamerasCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PallCamerasCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPallCamerasCount
		{
			get
			{
				if(r_PallCamerasCount == null)
				{
					r_PallCamerasCount = new(Type, "allCamerasCount", -1);
				}
				return r_PallCamerasCount;
			}
		}

		/// <summary>
		/// UnityEngine.Camera[] allCameras
		/// </summary>
		protected static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RCamera> r_PallCameras;
		public static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RCamera> RPallCameras
		{
			get
			{
				if(r_PallCameras == null)
				{
					r_PallCameras = new(Type, "allCameras", -1);
				}
				return r_PallCameras;
			}
		}

		/// <summary>
		/// SceneViewFilterMode sceneViewFilterMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RSceneViewFilterMode r_PsceneViewFilterMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RSceneViewFilterMode RPsceneViewFilterMode
		{
			get
			{
				if(r_PsceneViewFilterMode == null)
				{
					r_PsceneViewFilterMode = new(this, "sceneViewFilterMode", -1);
				}
				return r_PsceneViewFilterMode;
			}
		}

		/// <summary>
		/// Int32 commandBufferCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcommandBufferCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcommandBufferCount
		{
			get
			{
				if(r_PcommandBufferCount == null)
				{
					r_PcommandBufferCount = new(this, "commandBufferCount", -1);
				}
				return r_PcommandBufferCount;
			}
		}

		/// <summary>
		/// Boolean isOrthoGraphic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisOrthoGraphic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisOrthoGraphic
		{
			get
			{
				if(r_PisOrthoGraphic == null)
				{
					r_PisOrthoGraphic = new(this, "isOrthoGraphic", -1);
				}
				return r_PisOrthoGraphic;
			}
		}

		/// <summary>
		/// UnityEngine.Camera mainCamera
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera r_PmainCamera;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera RPmainCamera
		{
			get
			{
				if(r_PmainCamera == null)
				{
					r_PmainCamera = new(Type, "mainCamera", -1);
				}
				return r_PmainCamera;
			}
		}

		/// <summary>
		/// Single near
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pnear;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPnear
		{
			get
			{
				if(r_Pnear == null)
				{
					r_Pnear = new(this, "near", -1);
				}
				return r_Pnear;
			}
		}

		/// <summary>
		/// Single far
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pfar;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfar
		{
			get
			{
				if(r_Pfar == null)
				{
					r_Pfar = new(this, "far", -1);
				}
				return r_Pfar;
			}
		}

		/// <summary>
		/// Single fov
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pfov;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfov
		{
			get
			{
				if(r_Pfov == null)
				{
					r_Pfov = new(this, "fov", -1);
				}
				return r_Pfov;
			}
		}

		/// <summary>
		/// Boolean hdr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Phdr;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhdr
		{
			get
			{
				if(r_Phdr == null)
				{
					r_Phdr = new(this, "hdr", -1);
				}
				return r_Phdr;
			}
		}

		/// <summary>
		/// Boolean stereoMirrorMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstereoMirrorMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstereoMirrorMode
		{
			get
			{
				if(r_PstereoMirrorMode == null)
				{
					r_PstereoMirrorMode = new(this, "stereoMirrorMode", -1);
				}
				return r_PstereoMirrorMode;
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
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Boolean isActiveAndEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisActiveAndEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisActiveAndEnabled
		{
			get
			{
				if(r_PisActiveAndEnabled == null)
				{
					r_PisActiveAndEnabled = new(this, "isActiveAndEnabled", -1);
				}
				return r_PisActiveAndEnabled;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void ResetTransparencySortSettings()
		/// </summary>
		protected RMethod r_MResetTransparencySortSettings;
		public virtual RMethod RMResetTransparencySortSettings
		{
			get
			{
				if(r_MResetTransparencySortSettings == null)
				{
					r_MResetTransparencySortSettings = new(this, "ResetTransparencySortSettings", 0);
				}
				return r_MResetTransparencySortSettings;
			}
		}

		/// <summary>
		/// Void ResetAspect()
		/// </summary>
		protected RMethod r_MResetAspect;
		public virtual RMethod RMResetAspect
		{
			get
			{
				if(r_MResetAspect == null)
				{
					r_MResetAspect = new(this, "ResetAspect", 0);
				}
				return r_MResetAspect;
			}
		}

		/// <summary>
		/// Single[] GetLayerCullDistances()
		/// </summary>
		protected RMethod r_MGetLayerCullDistances;
		public virtual RMethod RMGetLayerCullDistances
		{
			get
			{
				if(r_MGetLayerCullDistances == null)
				{
					r_MGetLayerCullDistances = new(this, "GetLayerCullDistances", 0);
				}
				return r_MGetLayerCullDistances;
			}
		}

		/// <summary>
		/// Void SetLayerCullDistances(Single[])
		/// </summary>
		protected RMethod r_MSetLayerCullDistances_SingleArray;
		public virtual RMethod RMSetLayerCullDistances_SingleArray
		{
			get
			{
				if(r_MSetLayerCullDistances_SingleArray == null)
				{
					r_MSetLayerCullDistances_SingleArray = new(this, "SetLayerCullDistances", 0, typeof(System.Single).MakeArrayType());
				}
				return r_MSetLayerCullDistances_SingleArray;
			}
		}

		/// <summary>
		/// Void ResetCullingMatrix()
		/// </summary>
		protected RMethod r_MResetCullingMatrix;
		public virtual RMethod RMResetCullingMatrix
		{
			get
			{
				if(r_MResetCullingMatrix == null)
				{
					r_MResetCullingMatrix = new(this, "ResetCullingMatrix", 0);
				}
				return r_MResetCullingMatrix;
			}
		}

		/// <summary>
		/// Void SetReplacementShader(UnityEngine.Shader, System.String)
		/// </summary>
		protected RMethod r_MSetReplacementShader_Shader_String;
		public virtual RMethod RMSetReplacementShader_Shader_String
		{
			get
			{
				if(r_MSetReplacementShader_Shader_String == null)
				{
					r_MSetReplacementShader_Shader_String = new(this, "SetReplacementShader", 0, typeof(UnityEngine.Shader), typeof(System.String));
				}
				return r_MSetReplacementShader_Shader_String;
			}
		}

		/// <summary>
		/// Void ResetReplacementShader()
		/// </summary>
		protected RMethod r_MResetReplacementShader;
		public virtual RMethod RMResetReplacementShader
		{
			get
			{
				if(r_MResetReplacementShader == null)
				{
					r_MResetReplacementShader = new(this, "ResetReplacementShader", 0);
				}
				return r_MResetReplacementShader;
			}
		}

		/// <summary>
		/// Single GetGateFittedFieldOfView()
		/// </summary>
		protected RMethod r_MGetGateFittedFieldOfView;
		public virtual RMethod RMGetGateFittedFieldOfView
		{
			get
			{
				if(r_MGetGateFittedFieldOfView == null)
				{
					r_MGetGateFittedFieldOfView = new(this, "GetGateFittedFieldOfView", 0);
				}
				return r_MGetGateFittedFieldOfView;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetGateFittedLensShift()
		/// </summary>
		protected RMethod r_MGetGateFittedLensShift;
		public virtual RMethod RMGetGateFittedLensShift
		{
			get
			{
				if(r_MGetGateFittedLensShift == null)
				{
					r_MGetGateFittedLensShift = new(this, "GetGateFittedLensShift", 0);
				}
				return r_MGetGateFittedLensShift;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetLocalSpaceAim()
		/// </summary>
		protected RMethod r_MGetLocalSpaceAim;
		public virtual RMethod RMGetLocalSpaceAim
		{
			get
			{
				if(r_MGetLocalSpaceAim == null)
				{
					r_MGetLocalSpaceAim = new(this, "GetLocalSpaceAim", 0);
				}
				return r_MGetLocalSpaceAim;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersImpl(UnityEngine.RenderBuffer, UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_MSetTargetBuffersImpl_RenderBuffer_RenderBuffer;
		public virtual RMethod RMSetTargetBuffersImpl_RenderBuffer_RenderBuffer
		{
			get
			{
				if(r_MSetTargetBuffersImpl_RenderBuffer_RenderBuffer == null)
				{
					r_MSetTargetBuffersImpl_RenderBuffer_RenderBuffer = new(this, "SetTargetBuffersImpl", 0, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer));
				}
				return r_MSetTargetBuffersImpl_RenderBuffer_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffers(UnityEngine.RenderBuffer, UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_MSetTargetBuffers_RenderBuffer_RenderBuffer;
		public virtual RMethod RMSetTargetBuffers_RenderBuffer_RenderBuffer
		{
			get
			{
				if(r_MSetTargetBuffers_RenderBuffer_RenderBuffer == null)
				{
					r_MSetTargetBuffers_RenderBuffer_RenderBuffer = new(this, "SetTargetBuffers", 0, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer));
				}
				return r_MSetTargetBuffers_RenderBuffer_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_MSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer;
		public virtual RMethod RMSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer
		{
			get
			{
				if(r_MSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer == null)
				{
					r_MSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer = new(this, "SetTargetBuffersMRTImpl", 0, typeof(UnityEngine.RenderBuffer).MakeArrayType(), typeof(UnityEngine.RenderBuffer));
				}
				return r_MSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffers(UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer)
		/// </summary>
		protected RMethod r_MSetTargetBuffers_RenderBufferArray_RenderBuffer;
		public virtual RMethod RMSetTargetBuffers_RenderBufferArray_RenderBuffer
		{
			get
			{
				if(r_MSetTargetBuffers_RenderBufferArray_RenderBuffer == null)
				{
					r_MSetTargetBuffers_RenderBufferArray_RenderBuffer = new(this, "SetTargetBuffers", 0, typeof(UnityEngine.RenderBuffer).MakeArrayType(), typeof(UnityEngine.RenderBuffer));
				}
				return r_MSetTargetBuffers_RenderBufferArray_RenderBuffer;
			}
		}

		/// <summary>
		/// System.String[] GetCameraBufferWarnings()
		/// </summary>
		protected RMethod r_MGetCameraBufferWarnings;
		public virtual RMethod RMGetCameraBufferWarnings
		{
			get
			{
				if(r_MGetCameraBufferWarnings == null)
				{
					r_MGetCameraBufferWarnings = new(this, "GetCameraBufferWarnings", 0);
				}
				return r_MGetCameraBufferWarnings;
			}
		}

		/// <summary>
		/// Void ResetWorldToCameraMatrix()
		/// </summary>
		protected RMethod r_MResetWorldToCameraMatrix;
		public virtual RMethod RMResetWorldToCameraMatrix
		{
			get
			{
				if(r_MResetWorldToCameraMatrix == null)
				{
					r_MResetWorldToCameraMatrix = new(this, "ResetWorldToCameraMatrix", 0);
				}
				return r_MResetWorldToCameraMatrix;
			}
		}

		/// <summary>
		/// Void ResetProjectionMatrix()
		/// </summary>
		protected RMethod r_MResetProjectionMatrix;
		public virtual RMethod RMResetProjectionMatrix
		{
			get
			{
				if(r_MResetProjectionMatrix == null)
				{
					r_MResetProjectionMatrix = new(this, "ResetProjectionMatrix", 0);
				}
				return r_MResetProjectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MCalculateObliqueMatrix_Vector4;
		public virtual RMethod RMCalculateObliqueMatrix_Vector4
		{
			get
			{
				if(r_MCalculateObliqueMatrix_Vector4 == null)
				{
					r_MCalculateObliqueMatrix_Vector4 = new(this, "CalculateObliqueMatrix", 0, typeof(UnityEngine.Vector4));
				}
				return r_MCalculateObliqueMatrix_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MWorldToScreenPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RMWorldToScreenPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MWorldToScreenPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_MWorldToScreenPoint_Vector3_MonoOrStereoscopicEye = new(this, "WorldToScreenPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MWorldToScreenPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MWorldToViewportPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RMWorldToViewportPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MWorldToViewportPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_MWorldToViewportPoint_Vector3_MonoOrStereoscopicEye = new(this, "WorldToViewportPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MWorldToViewportPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MViewportToWorldPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RMViewportToWorldPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MViewportToWorldPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_MViewportToWorldPoint_Vector3_MonoOrStereoscopicEye = new(this, "ViewportToWorldPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MViewportToWorldPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MScreenToWorldPoint_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RMScreenToWorldPoint_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MScreenToWorldPoint_Vector3_MonoOrStereoscopicEye == null)
				{
					r_MScreenToWorldPoint_Vector3_MonoOrStereoscopicEye = new(this, "ScreenToWorldPoint", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MScreenToWorldPoint_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MWorldToScreenPoint_Vector3;
		public virtual RMethod RMWorldToScreenPoint_Vector3
		{
			get
			{
				if(r_MWorldToScreenPoint_Vector3 == null)
				{
					r_MWorldToScreenPoint_Vector3 = new(this, "WorldToScreenPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MWorldToScreenPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MWorldToViewportPoint_Vector3;
		public virtual RMethod RMWorldToViewportPoint_Vector3
		{
			get
			{
				if(r_MWorldToViewportPoint_Vector3 == null)
				{
					r_MWorldToViewportPoint_Vector3 = new(this, "WorldToViewportPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MWorldToViewportPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MViewportToWorldPoint_Vector3;
		public virtual RMethod RMViewportToWorldPoint_Vector3
		{
			get
			{
				if(r_MViewportToWorldPoint_Vector3 == null)
				{
					r_MViewportToWorldPoint_Vector3 = new(this, "ViewportToWorldPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MViewportToWorldPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MScreenToWorldPoint_Vector3;
		public virtual RMethod RMScreenToWorldPoint_Vector3
		{
			get
			{
				if(r_MScreenToWorldPoint_Vector3 == null)
				{
					r_MScreenToWorldPoint_Vector3 = new(this, "ScreenToWorldPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MScreenToWorldPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MScreenToViewportPoint_Vector3;
		public virtual RMethod RMScreenToViewportPoint_Vector3
		{
			get
			{
				if(r_MScreenToViewportPoint_Vector3 == null)
				{
					r_MScreenToViewportPoint_Vector3 = new(this, "ScreenToViewportPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MScreenToViewportPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MViewportToScreenPoint_Vector3;
		public virtual RMethod RMViewportToScreenPoint_Vector3
		{
			get
			{
				if(r_MViewportToScreenPoint_Vector3 == null)
				{
					r_MViewportToScreenPoint_Vector3 = new(this, "ViewportToScreenPoint", 0, typeof(UnityEngine.Vector3));
				}
				return r_MViewportToScreenPoint_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetFrustumPlaneSizeAt(Single)
		/// </summary>
		protected RMethod r_MGetFrustumPlaneSizeAt_Single;
		public virtual RMethod RMGetFrustumPlaneSizeAt_Single
		{
			get
			{
				if(r_MGetFrustumPlaneSizeAt_Single == null)
				{
					r_MGetFrustumPlaneSizeAt_Single = new(this, "GetFrustumPlaneSizeAt", 0, typeof(System.Single));
				}
				return r_MGetFrustumPlaneSizeAt_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MViewportPointToRay_Vector2_MonoOrStereoscopicEye;
		public virtual RMethod RMViewportPointToRay_Vector2_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MViewportPointToRay_Vector2_MonoOrStereoscopicEye == null)
				{
					r_MViewportPointToRay_Vector2_MonoOrStereoscopicEye = new(this, "ViewportPointToRay", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MViewportPointToRay_Vector2_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MViewportPointToRay_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RMViewportPointToRay_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MViewportPointToRay_Vector3_MonoOrStereoscopicEye == null)
				{
					r_MViewportPointToRay_Vector3_MonoOrStereoscopicEye = new(this, "ViewportPointToRay", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MViewportPointToRay_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MViewportPointToRay_Vector3;
		public virtual RMethod RMViewportPointToRay_Vector3
		{
			get
			{
				if(r_MViewportPointToRay_Vector3 == null)
				{
					r_MViewportPointToRay_Vector3 = new(this, "ViewportPointToRay", 0, typeof(UnityEngine.Vector3));
				}
				return r_MViewportPointToRay_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MScreenPointToRay_Vector2_MonoOrStereoscopicEye;
		public virtual RMethod RMScreenPointToRay_Vector2_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MScreenPointToRay_Vector2_MonoOrStereoscopicEye == null)
				{
					r_MScreenPointToRay_Vector2_MonoOrStereoscopicEye = new(this, "ScreenPointToRay", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MScreenPointToRay_Vector2_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MScreenPointToRay_Vector3_MonoOrStereoscopicEye;
		public virtual RMethod RMScreenPointToRay_Vector3_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MScreenPointToRay_Vector3_MonoOrStereoscopicEye == null)
				{
					r_MScreenPointToRay_Vector3_MonoOrStereoscopicEye = new(this, "ScreenPointToRay", 0, typeof(UnityEngine.Vector3),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MScreenPointToRay_Vector3_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MScreenPointToRay_Vector3;
		public virtual RMethod RMScreenPointToRay_Vector3
		{
			get
			{
				if(r_MScreenPointToRay_Vector3 == null)
				{
					r_MScreenPointToRay_Vector3 = new(this, "ScreenPointToRay", 0, typeof(UnityEngine.Vector3));
				}
				return r_MScreenPointToRay_Vector3;
			}
		}

		/// <summary>
		/// Void CalculateFrustumCornersInternal(UnityEngine.Rect, Single, MonoOrStereoscopicEye, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
		public virtual RMethod RMCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array
		{
			get
			{
				if(r_MCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array == null)
				{
					r_MCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array = new(this, "CalculateFrustumCornersInternal", 0, typeof(UnityEngine.Rect), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
			}
		}

		/// <summary>
		/// Void CalculateFrustumCorners(UnityEngine.Rect, Single, MonoOrStereoscopicEye, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
		public virtual RMethod RMCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array
		{
			get
			{
				if(r_MCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array == null)
				{
					r_MCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array = new(this, "CalculateFrustumCorners", 0, typeof(UnityEngine.Rect), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
			}
		}

		/// <summary>
		/// Void CalculateProjectionMatrixFromPhysicalPropertiesInternal(UnityEngine.Matrix4x4 ByRef, Single, UnityEngine.Vector2, UnityEngine.Vector2, Single, Single, Single, GateFitMode)
		/// </summary>
		protected static RMethod r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode;
		public static RMethod RMCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode
		{
			get
			{
				if(r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode == null)
				{
					r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode = new(Type, "CalculateProjectionMatrixFromPhysicalPropertiesInternal", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Single), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+GateFitMode"));
				}
				return r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode;
			}
		}

		/// <summary>
		/// Void CalculateProjectionMatrixFromPhysicalProperties(UnityEngine.Matrix4x4 ByRef, Single, UnityEngine.Vector2, UnityEngine.Vector2, Single, Single, GateFitParameters)
		/// </summary>
		protected static RMethod r_MCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters;
		public static RMethod RMCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters
		{
			get
			{
				if(r_MCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters == null)
				{
					r_MCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters = new(Type, "CalculateProjectionMatrixFromPhysicalProperties", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+GateFitParameters"));
				}
				return r_MCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters;
			}
		}

		/// <summary>
		/// Single FocalLengthToFieldOfView(Single, Single)
		/// </summary>
		protected static RMethod r_MFocalLengthToFieldOfView_Single_Single;
		public static RMethod RMFocalLengthToFieldOfView_Single_Single
		{
			get
			{
				if(r_MFocalLengthToFieldOfView_Single_Single == null)
				{
					r_MFocalLengthToFieldOfView_Single_Single = new(Type, "FocalLengthToFieldOfView", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MFocalLengthToFieldOfView_Single_Single;
			}
		}

		/// <summary>
		/// Single FieldOfViewToFocalLength(Single, Single)
		/// </summary>
		protected static RMethod r_MFieldOfViewToFocalLength_Single_Single;
		public static RMethod RMFieldOfViewToFocalLength_Single_Single
		{
			get
			{
				if(r_MFieldOfViewToFocalLength_Single_Single == null)
				{
					r_MFieldOfViewToFocalLength_Single_Single = new(Type, "FieldOfViewToFocalLength", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MFieldOfViewToFocalLength_Single_Single;
			}
		}

		/// <summary>
		/// Single HorizontalToVerticalFieldOfView(Single, Single)
		/// </summary>
		protected static RMethod r_MHorizontalToVerticalFieldOfView_Single_Single;
		public static RMethod RMHorizontalToVerticalFieldOfView_Single_Single
		{
			get
			{
				if(r_MHorizontalToVerticalFieldOfView_Single_Single == null)
				{
					r_MHorizontalToVerticalFieldOfView_Single_Single = new(Type, "HorizontalToVerticalFieldOfView", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MHorizontalToVerticalFieldOfView_Single_Single;
			}
		}

		/// <summary>
		/// Single VerticalToHorizontalFieldOfView(Single, Single)
		/// </summary>
		protected static RMethod r_MVerticalToHorizontalFieldOfView_Single_Single;
		public static RMethod RMVerticalToHorizontalFieldOfView_Single_Single
		{
			get
			{
				if(r_MVerticalToHorizontalFieldOfView_Single_Single == null)
				{
					r_MVerticalToHorizontalFieldOfView_Single_Single = new(Type, "VerticalToHorizontalFieldOfView", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MVerticalToHorizontalFieldOfView_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye)
		/// </summary>
		protected RMethod r_MGetStereoNonJitteredProjectionMatrix_StereoscopicEye;
		public virtual RMethod RMGetStereoNonJitteredProjectionMatrix_StereoscopicEye
		{
			get
			{
				if(r_MGetStereoNonJitteredProjectionMatrix_StereoscopicEye == null)
				{
					r_MGetStereoNonJitteredProjectionMatrix_StereoscopicEye = new(this, "GetStereoNonJitteredProjectionMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
				}
				return r_MGetStereoNonJitteredProjectionMatrix_StereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetStereoViewMatrix(StereoscopicEye)
		/// </summary>
		protected RMethod r_MGetStereoViewMatrix_StereoscopicEye;
		public virtual RMethod RMGetStereoViewMatrix_StereoscopicEye
		{
			get
			{
				if(r_MGetStereoViewMatrix_StereoscopicEye == null)
				{
					r_MGetStereoViewMatrix_StereoscopicEye = new(this, "GetStereoViewMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
				}
				return r_MGetStereoViewMatrix_StereoscopicEye;
			}
		}

		/// <summary>
		/// Void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye)
		/// </summary>
		protected RMethod r_MCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye;
		public virtual RMethod RMCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye
		{
			get
			{
				if(r_MCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye == null)
				{
					r_MCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye = new(this, "CopyStereoDeviceProjectionMatrixToNonJittered", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
				}
				return r_MCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye)
		/// </summary>
		protected RMethod r_MGetStereoProjectionMatrix_StereoscopicEye;
		public virtual RMethod RMGetStereoProjectionMatrix_StereoscopicEye
		{
			get
			{
				if(r_MGetStereoProjectionMatrix_StereoscopicEye == null)
				{
					r_MGetStereoProjectionMatrix_StereoscopicEye = new(this, "GetStereoProjectionMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"));
				}
				return r_MGetStereoProjectionMatrix_StereoscopicEye;
			}
		}

		/// <summary>
		/// Void SetStereoProjectionMatrix(StereoscopicEye, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4;
		public virtual RMethod RMSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4
		{
			get
			{
				if(r_MSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4 == null)
				{
					r_MSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4 = new(this, "SetStereoProjectionMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4;
			}
		}

		/// <summary>
		/// Void ResetStereoProjectionMatrices()
		/// </summary>
		protected RMethod r_MResetStereoProjectionMatrices;
		public virtual RMethod RMResetStereoProjectionMatrices
		{
			get
			{
				if(r_MResetStereoProjectionMatrices == null)
				{
					r_MResetStereoProjectionMatrices = new(this, "ResetStereoProjectionMatrices", 0);
				}
				return r_MResetStereoProjectionMatrices;
			}
		}

		/// <summary>
		/// Void SetStereoViewMatrix(StereoscopicEye, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetStereoViewMatrix_StereoscopicEye_Matrix4x4;
		public virtual RMethod RMSetStereoViewMatrix_StereoscopicEye_Matrix4x4
		{
			get
			{
				if(r_MSetStereoViewMatrix_StereoscopicEye_Matrix4x4 == null)
				{
					r_MSetStereoViewMatrix_StereoscopicEye_Matrix4x4 = new(this, "SetStereoViewMatrix", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetStereoViewMatrix_StereoscopicEye_Matrix4x4;
			}
		}

		/// <summary>
		/// Void ResetStereoViewMatrices()
		/// </summary>
		protected RMethod r_MResetStereoViewMatrices;
		public virtual RMethod RMResetStereoViewMatrices
		{
			get
			{
				if(r_MResetStereoViewMatrices == null)
				{
					r_MResetStereoViewMatrices = new(this, "ResetStereoViewMatrices", 0);
				}
				return r_MResetStereoViewMatrices;
			}
		}

		/// <summary>
		/// Int32 GetAllCamerasCount()
		/// </summary>
		protected static RMethod r_MGetAllCamerasCount;
		public static RMethod RMGetAllCamerasCount
		{
			get
			{
				if(r_MGetAllCamerasCount == null)
				{
					r_MGetAllCamerasCount = new(Type, "GetAllCamerasCount", 0);
				}
				return r_MGetAllCamerasCount;
			}
		}

		/// <summary>
		/// Int32 GetAllCamerasImpl(UnityEngine.Camera[])
		/// </summary>
		protected static RMethod r_MGetAllCamerasImpl_CameraArray;
		public static RMethod RMGetAllCamerasImpl_CameraArray
		{
			get
			{
				if(r_MGetAllCamerasImpl_CameraArray == null)
				{
					r_MGetAllCamerasImpl_CameraArray = new(Type, "GetAllCamerasImpl", 0, typeof(UnityEngine.Camera).MakeArrayType());
				}
				return r_MGetAllCamerasImpl_CameraArray;
			}
		}

		/// <summary>
		/// Int32 GetAllCameras(UnityEngine.Camera[])
		/// </summary>
		protected static RMethod r_MGetAllCameras_CameraArray;
		public static RMethod RMGetAllCameras_CameraArray
		{
			get
			{
				if(r_MGetAllCameras_CameraArray == null)
				{
					r_MGetAllCameras_CameraArray = new(Type, "GetAllCameras", 0, typeof(UnityEngine.Camera).MakeArrayType());
				}
				return r_MGetAllCameras_CameraArray;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemapImpl(UnityEngine.Texture, Int32)
		/// </summary>
		protected RMethod r_MRenderToCubemapImpl_Texture_Int32;
		public virtual RMethod RMRenderToCubemapImpl_Texture_Int32
		{
			get
			{
				if(r_MRenderToCubemapImpl_Texture_Int32 == null)
				{
					r_MRenderToCubemapImpl_Texture_Int32 = new(this, "RenderToCubemapImpl", 0, typeof(UnityEngine.Texture), typeof(System.Int32));
				}
				return r_MRenderToCubemapImpl_Texture_Int32;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.Cubemap, Int32)
		/// </summary>
		protected RMethod r_MRenderToCubemap_Cubemap_Int32;
		public virtual RMethod RMRenderToCubemap_Cubemap_Int32
		{
			get
			{
				if(r_MRenderToCubemap_Cubemap_Int32 == null)
				{
					r_MRenderToCubemap_Cubemap_Int32 = new(this, "RenderToCubemap", 0, typeof(UnityEngine.Cubemap), typeof(System.Int32));
				}
				return r_MRenderToCubemap_Cubemap_Int32;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.Cubemap)
		/// </summary>
		protected RMethod r_MRenderToCubemap_Cubemap;
		public virtual RMethod RMRenderToCubemap_Cubemap
		{
			get
			{
				if(r_MRenderToCubemap_Cubemap == null)
				{
					r_MRenderToCubemap_Cubemap = new(this, "RenderToCubemap", 0, typeof(UnityEngine.Cubemap));
				}
				return r_MRenderToCubemap_Cubemap;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.RenderTexture, Int32)
		/// </summary>
		protected RMethod r_MRenderToCubemap_RenderTexture_Int32;
		public virtual RMethod RMRenderToCubemap_RenderTexture_Int32
		{
			get
			{
				if(r_MRenderToCubemap_RenderTexture_Int32 == null)
				{
					r_MRenderToCubemap_RenderTexture_Int32 = new(this, "RenderToCubemap", 0, typeof(UnityEngine.RenderTexture), typeof(System.Int32));
				}
				return r_MRenderToCubemap_RenderTexture_Int32;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MRenderToCubemap_RenderTexture;
		public virtual RMethod RMRenderToCubemap_RenderTexture
		{
			get
			{
				if(r_MRenderToCubemap_RenderTexture == null)
				{
					r_MRenderToCubemap_RenderTexture = new(this, "RenderToCubemap", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MRenderToCubemap_RenderTexture;
			}
		}

		/// <summary>
		/// Int32 GetFilterMode()
		/// </summary>
		protected RMethod r_MGetFilterMode;
		public virtual RMethod RMGetFilterMode
		{
			get
			{
				if(r_MGetFilterMode == null)
				{
					r_MGetFilterMode = new(this, "GetFilterMode", 0);
				}
				return r_MGetFilterMode;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemapEyeImpl(UnityEngine.RenderTexture, Int32, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye;
		public virtual RMethod RMRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye == null)
				{
					r_MRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye = new(this, "RenderToCubemapEyeImpl", 0, typeof(UnityEngine.RenderTexture), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// Boolean RenderToCubemap(UnityEngine.RenderTexture, Int32, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye;
		public virtual RMethod RMRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye == null)
				{
					r_MRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye = new(this, "RenderToCubemap", 0, typeof(UnityEngine.RenderTexture), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// Void Render()
		/// </summary>
		protected RMethod r_MRender;
		public virtual RMethod RMRender
		{
			get
			{
				if(r_MRender == null)
				{
					r_MRender = new(this, "Render", 0);
				}
				return r_MRender;
			}
		}

		/// <summary>
		/// Void RenderWithShader(UnityEngine.Shader, System.String)
		/// </summary>
		protected RMethod r_MRenderWithShader_Shader_String;
		public virtual RMethod RMRenderWithShader_Shader_String
		{
			get
			{
				if(r_MRenderWithShader_Shader_String == null)
				{
					r_MRenderWithShader_Shader_String = new(this, "RenderWithShader", 0, typeof(UnityEngine.Shader), typeof(System.String));
				}
				return r_MRenderWithShader_Shader_String;
			}
		}

		/// <summary>
		/// Void RenderDontRestore()
		/// </summary>
		protected RMethod r_MRenderDontRestore;
		public virtual RMethod RMRenderDontRestore
		{
			get
			{
				if(r_MRenderDontRestore == null)
				{
					r_MRenderDontRestore = new(this, "RenderDontRestore", 0);
				}
				return r_MRenderDontRestore;
			}
		}

		/// <summary>
		/// Void SubmitRenderRequests(System.Collections.Generic.List`1[UnityEngine.Camera+RenderRequest])
		/// </summary>
		protected RMethod r_MSubmitRenderRequests_List_d_RenderRequest_p_;
		public virtual RMethod RMSubmitRenderRequests_List_d_RenderRequest_p_
		{
			get
			{
				if(r_MSubmitRenderRequests_List_d_RenderRequest_p_ == null)
				{
					r_MSubmitRenderRequests_List_d_RenderRequest_p_ = new(this, "SubmitRenderRequests", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequest")));
				}
				return r_MSubmitRenderRequests_List_d_RenderRequest_p_;
			}
		}

		/// <summary>
		/// Void SubmitRenderRequest[RequestData](RequestData)
		/// </summary>
		protected RMethod r_MSubmitRenderRequest_GRequestData_RequestData;
		public virtual RMethod RMSubmitRenderRequest_GRequestData_RequestData
		{
			get
			{
				if(r_MSubmitRenderRequest_GRequestData_RequestData == null)
				{
					r_MSubmitRenderRequest_GRequestData_RequestData = new(this, "SubmitRenderRequest", 1, Type.MakeGenericMethodParameter(0));
				}
				return r_MSubmitRenderRequest_GRequestData_RequestData;
			}
		}

		/// <summary>
		/// Void SubmitRenderRequestsInternal(System.Object)
		/// </summary>
		protected RMethod r_MSubmitRenderRequestsInternal_Object;
		public virtual RMethod RMSubmitRenderRequestsInternal_Object
		{
			get
			{
				if(r_MSubmitRenderRequestsInternal_Object == null)
				{
					r_MSubmitRenderRequestsInternal_Object = new(this, "SubmitRenderRequestsInternal", 0, typeof(System.Object));
				}
				return r_MSubmitRenderRequestsInternal_Object;
			}
		}

		/// <summary>
		/// Void SetupCurrent(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_MSetupCurrent_Camera;
		public static RMethod RMSetupCurrent_Camera
		{
			get
			{
				if(r_MSetupCurrent_Camera == null)
				{
					r_MSetupCurrent_Camera = new(Type, "SetupCurrent", 0, typeof(UnityEngine.Camera));
				}
				return r_MSetupCurrent_Camera;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.Camera)
		/// </summary>
		protected RMethod r_MCopyFrom_Camera;
		public virtual RMethod RMCopyFrom_Camera
		{
			get
			{
				if(r_MCopyFrom_Camera == null)
				{
					r_MCopyFrom_Camera = new(this, "CopyFrom", 0, typeof(UnityEngine.Camera));
				}
				return r_MCopyFrom_Camera;
			}
		}

		/// <summary>
		/// Void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent)
		/// </summary>
		protected RMethod r_MRemoveCommandBuffers_CameraEvent;
		public virtual RMethod RMRemoveCommandBuffers_CameraEvent
		{
			get
			{
				if(r_MRemoveCommandBuffers_CameraEvent == null)
				{
					r_MRemoveCommandBuffers_CameraEvent = new(this, "RemoveCommandBuffers", 0, typeof(UnityEngine.Rendering.CameraEvent));
				}
				return r_MRemoveCommandBuffers_CameraEvent;
			}
		}

		/// <summary>
		/// Void RemoveAllCommandBuffers()
		/// </summary>
		protected RMethod r_MRemoveAllCommandBuffers;
		public virtual RMethod RMRemoveAllCommandBuffers
		{
			get
			{
				if(r_MRemoveAllCommandBuffers == null)
				{
					r_MRemoveAllCommandBuffers = new(this, "RemoveAllCommandBuffers", 0);
				}
				return r_MRemoveAllCommandBuffers;
			}
		}

		/// <summary>
		/// Void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_MAddCommandBufferImpl_CameraEvent_CommandBuffer;
		public virtual RMethod RMAddCommandBufferImpl_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_MAddCommandBufferImpl_CameraEvent_CommandBuffer == null)
				{
					r_MAddCommandBufferImpl_CameraEvent_CommandBuffer = new(this, "AddCommandBufferImpl", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
				}
				return r_MAddCommandBufferImpl_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType)
		/// </summary>
		protected RMethod r_MAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType;
		public virtual RMethod RMAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType
		{
			get
			{
				if(r_MAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType == null)
				{
					r_MAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType = new(this, "AddCommandBufferAsyncImpl", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ComputeQueueType));
				}
				return r_MAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType;
			}
		}

		/// <summary>
		/// Void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_MRemoveCommandBufferImpl_CameraEvent_CommandBuffer;
		public virtual RMethod RMRemoveCommandBufferImpl_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_MRemoveCommandBufferImpl_CameraEvent_CommandBuffer == null)
				{
					r_MRemoveCommandBufferImpl_CameraEvent_CommandBuffer = new(this, "RemoveCommandBufferImpl", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
				}
				return r_MRemoveCommandBufferImpl_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBuffer(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_MAddCommandBuffer_CameraEvent_CommandBuffer;
		public virtual RMethod RMAddCommandBuffer_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_MAddCommandBuffer_CameraEvent_CommandBuffer == null)
				{
					r_MAddCommandBuffer_CameraEvent_CommandBuffer = new(this, "AddCommandBuffer", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
				}
				return r_MAddCommandBuffer_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType)
		/// </summary>
		protected RMethod r_MAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType;
		public virtual RMethod RMAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType
		{
			get
			{
				if(r_MAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType == null)
				{
					r_MAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType = new(this, "AddCommandBufferAsync", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ComputeQueueType));
				}
				return r_MAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType;
			}
		}

		/// <summary>
		/// Void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_MRemoveCommandBuffer_CameraEvent_CommandBuffer;
		public virtual RMethod RMRemoveCommandBuffer_CameraEvent_CommandBuffer
		{
			get
			{
				if(r_MRemoveCommandBuffer_CameraEvent_CommandBuffer == null)
				{
					r_MRemoveCommandBuffer_CameraEvent_CommandBuffer = new(this, "RemoveCommandBuffer", 0, typeof(UnityEngine.Rendering.CameraEvent), typeof(UnityEngine.Rendering.CommandBuffer));
				}
				return r_MRemoveCommandBuffer_CameraEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent)
		/// </summary>
		protected RMethod r_MGetCommandBuffers_CameraEvent;
		public virtual RMethod RMGetCommandBuffers_CameraEvent
		{
			get
			{
				if(r_MGetCommandBuffers_CameraEvent == null)
				{
					r_MGetCommandBuffers_CameraEvent = new(this, "GetCommandBuffers", 0, typeof(UnityEngine.Rendering.CameraEvent));
				}
				return r_MGetCommandBuffers_CameraEvent;
			}
		}

		/// <summary>
		/// Void FireOnPreCull(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_MFireOnPreCull_Camera;
		public static RMethod RMFireOnPreCull_Camera
		{
			get
			{
				if(r_MFireOnPreCull_Camera == null)
				{
					r_MFireOnPreCull_Camera = new(Type, "FireOnPreCull", 0, typeof(UnityEngine.Camera));
				}
				return r_MFireOnPreCull_Camera;
			}
		}

		/// <summary>
		/// Void FireOnPreRender(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_MFireOnPreRender_Camera;
		public static RMethod RMFireOnPreRender_Camera
		{
			get
			{
				if(r_MFireOnPreRender_Camera == null)
				{
					r_MFireOnPreRender_Camera = new(Type, "FireOnPreRender", 0, typeof(UnityEngine.Camera));
				}
				return r_MFireOnPreRender_Camera;
			}
		}

		/// <summary>
		/// Void FireOnPostRender(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_MFireOnPostRender_Camera;
		public static RMethod RMFireOnPostRender_Camera
		{
			get
			{
				if(r_MFireOnPostRender_Camera == null)
				{
					r_MFireOnPostRender_Camera = new(Type, "FireOnPostRender", 0, typeof(UnityEngine.Camera));
				}
				return r_MFireOnPostRender_Camera;
			}
		}

		/// <summary>
		/// Void OnlyUsedForTesting1()
		/// </summary>
		protected RMethod r_MOnlyUsedForTesting1;
		public virtual RMethod RMOnlyUsedForTesting1
		{
			get
			{
				if(r_MOnlyUsedForTesting1 == null)
				{
					r_MOnlyUsedForTesting1 = new(this, "OnlyUsedForTesting1", 0);
				}
				return r_MOnlyUsedForTesting1;
			}
		}

		/// <summary>
		/// Void OnlyUsedForTesting2()
		/// </summary>
		protected RMethod r_MOnlyUsedForTesting2;
		public virtual RMethod RMOnlyUsedForTesting2
		{
			get
			{
				if(r_MOnlyUsedForTesting2 == null)
				{
					r_MOnlyUsedForTesting2 = new(this, "OnlyUsedForTesting2", 0);
				}
				return r_MOnlyUsedForTesting2;
			}
		}

		/// <summary>
		/// Boolean TryGetCullingParameters(UnityEngine.Rendering.ScriptableCullingParameters ByRef)
		/// </summary>
		protected RMethod r_MTryGetCullingParameters_Out_ScriptableCullingParameters;
		public virtual RMethod RMTryGetCullingParameters_Out_ScriptableCullingParameters
		{
			get
			{
				if(r_MTryGetCullingParameters_Out_ScriptableCullingParameters == null)
				{
					r_MTryGetCullingParameters_Out_ScriptableCullingParameters = new(this, "TryGetCullingParameters", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters).MakeByRefType());
				}
				return r_MTryGetCullingParameters_Out_ScriptableCullingParameters;
			}
		}

		/// <summary>
		/// Boolean TryGetCullingParameters(Boolean, UnityEngine.Rendering.ScriptableCullingParameters ByRef)
		/// </summary>
		protected RMethod r_MTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters;
		public virtual RMethod RMTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters
		{
			get
			{
				if(r_MTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters == null)
				{
					r_MTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters = new(this, "TryGetCullingParameters", 0, typeof(System.Boolean), typeof(UnityEngine.Rendering.ScriptableCullingParameters).MakeByRefType());
				}
				return r_MTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters;
			}
		}

		/// <summary>
		/// Boolean GetCullingParameters_Internal(UnityEngine.Camera, Boolean, UnityEngine.Rendering.ScriptableCullingParameters ByRef, Int32)
		/// </summary>
		protected static RMethod r_MGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32;
		public static RMethod RMGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32
		{
			get
			{
				if(r_MGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32 == null)
				{
					r_MGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32 = new(Type, "GetCullingParameters_Internal", 0, typeof(UnityEngine.Camera), typeof(System.Boolean), typeof(UnityEngine.Rendering.ScriptableCullingParameters).MakeByRefType(), typeof(System.Int32));
				}
				return r_MGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32;
			}
		}

		/// <summary>
		/// Single GetScreenWidth()
		/// </summary>
		protected RMethod r_MGetScreenWidth;
		public virtual RMethod RMGetScreenWidth
		{
			get
			{
				if(r_MGetScreenWidth == null)
				{
					r_MGetScreenWidth = new(this, "GetScreenWidth", 0);
				}
				return r_MGetScreenWidth;
			}
		}

		/// <summary>
		/// Single GetScreenHeight()
		/// </summary>
		protected RMethod r_MGetScreenHeight;
		public virtual RMethod RMGetScreenHeight
		{
			get
			{
				if(r_MGetScreenHeight == null)
				{
					r_MGetScreenHeight = new(this, "GetScreenHeight", 0);
				}
				return r_MGetScreenHeight;
			}
		}

		/// <summary>
		/// Void DoClear()
		/// </summary>
		protected RMethod r_MDoClear;
		public virtual RMethod RMDoClear
		{
			get
			{
				if(r_MDoClear == null)
				{
					r_MDoClear = new(this, "DoClear", 0);
				}
				return r_MDoClear;
			}
		}

		/// <summary>
		/// Void ResetFieldOfView()
		/// </summary>
		protected RMethod r_MResetFieldOfView;
		public virtual RMethod RMResetFieldOfView
		{
			get
			{
				if(r_MResetFieldOfView == null)
				{
					r_MResetFieldOfView = new(this, "ResetFieldOfView", 0);
				}
				return r_MResetFieldOfView;
			}
		}

		/// <summary>
		/// Void SetStereoViewMatrices(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetStereoViewMatrices_Matrix4x4_Matrix4x4;
		public virtual RMethod RMSetStereoViewMatrices_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_MSetStereoViewMatrices_Matrix4x4_Matrix4x4 == null)
				{
					r_MSetStereoViewMatrices_Matrix4x4_Matrix4x4 = new(this, "SetStereoViewMatrices", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetStereoViewMatrices_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetStereoProjectionMatrices(UnityEngine.Matrix4x4, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetStereoProjectionMatrices_Matrix4x4_Matrix4x4;
		public virtual RMethod RMSetStereoProjectionMatrices_Matrix4x4_Matrix4x4
		{
			get
			{
				if(r_MSetStereoProjectionMatrices_Matrix4x4_Matrix4x4 == null)
				{
					r_MSetStereoProjectionMatrices_Matrix4x4_Matrix4x4 = new(this, "SetStereoProjectionMatrices", 0, typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4));
				}
				return r_MSetStereoProjectionMatrices_Matrix4x4_Matrix4x4;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetStereoViewMatrices()
		/// </summary>
		protected RMethod r_MGetStereoViewMatrices;
		public virtual RMethod RMGetStereoViewMatrices
		{
			get
			{
				if(r_MGetStereoViewMatrices == null)
				{
					r_MGetStereoViewMatrices = new(this, "GetStereoViewMatrices", 0);
				}
				return r_MGetStereoViewMatrices;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] GetStereoProjectionMatrices()
		/// </summary>
		protected RMethod r_MGetStereoProjectionMatrices;
		public virtual RMethod RMGetStereoProjectionMatrices
		{
			get
			{
				if(r_MGetStereoProjectionMatrices == null)
				{
					r_MGetStereoProjectionMatrices = new(this, "GetStereoProjectionMatrices", 0);
				}
				return r_MGetStereoProjectionMatrices;
			}
		}

		/// <summary>
		/// Void get_transparencySortAxis_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_transparencySortAxis_Injected_Out_Vector3;
		public virtual RMethod RMget_transparencySortAxis_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_transparencySortAxis_Injected_Out_Vector3 == null)
				{
					r_Mget_transparencySortAxis_Injected_Out_Vector3 = new(this, "get_transparencySortAxis_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_transparencySortAxis_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_transparencySortAxis_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mset_transparencySortAxis_Injected_Ref_Vector3;
		public virtual RMethod RMset_transparencySortAxis_Injected_Ref_Vector3
		{
			get
			{
				if(r_Mset_transparencySortAxis_Injected_Ref_Vector3 == null)
				{
					r_Mset_transparencySortAxis_Injected_Ref_Vector3 = new(this, "set_transparencySortAxis_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mset_transparencySortAxis_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_velocity_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_velocity_Injected_Out_Vector3;
		public virtual RMethod RMget_velocity_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_velocity_Injected_Out_Vector3 == null)
				{
					r_Mget_velocity_Injected_Out_Vector3 = new(this, "get_velocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_velocity_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_cullingMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_cullingMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_cullingMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_cullingMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_cullingMatrix_Injected_Out_Matrix4x4 = new(this, "get_cullingMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_cullingMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_cullingMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mset_cullingMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RMset_cullingMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_Mset_cullingMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_Mset_cullingMatrix_Injected_Ref_Matrix4x4 = new(this, "set_cullingMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mset_cullingMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mget_backgroundColor_Injected_Out_Color;
		public virtual RMethod RMget_backgroundColor_Injected_Out_Color
		{
			get
			{
				if(r_Mget_backgroundColor_Injected_Out_Color == null)
				{
					r_Mget_backgroundColor_Injected_Out_Color = new(this, "get_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_Mget_backgroundColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mset_backgroundColor_Injected_Ref_Color;
		public virtual RMethod RMset_backgroundColor_Injected_Ref_Color
		{
			get
			{
				if(r_Mset_backgroundColor_Injected_Ref_Color == null)
				{
					r_Mset_backgroundColor_Injected_Ref_Color = new(this, "set_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_Mset_backgroundColor_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void get_curvature_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_curvature_Injected_Out_Vector2;
		public virtual RMethod RMget_curvature_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_curvature_Injected_Out_Vector2 == null)
				{
					r_Mget_curvature_Injected_Out_Vector2 = new(this, "get_curvature_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_curvature_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_curvature_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_curvature_Injected_Ref_Vector2;
		public virtual RMethod RMset_curvature_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_curvature_Injected_Ref_Vector2 == null)
				{
					r_Mset_curvature_Injected_Ref_Vector2 = new(this, "set_curvature_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_curvature_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_sensorSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_sensorSize_Injected_Out_Vector2;
		public virtual RMethod RMget_sensorSize_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_sensorSize_Injected_Out_Vector2 == null)
				{
					r_Mget_sensorSize_Injected_Out_Vector2 = new(this, "get_sensorSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_sensorSize_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_sensorSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_sensorSize_Injected_Ref_Vector2;
		public virtual RMethod RMset_sensorSize_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_sensorSize_Injected_Ref_Vector2 == null)
				{
					r_Mset_sensorSize_Injected_Ref_Vector2 = new(this, "set_sensorSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_sensorSize_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_lensShift_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_lensShift_Injected_Out_Vector2;
		public virtual RMethod RMget_lensShift_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_lensShift_Injected_Out_Vector2 == null)
				{
					r_Mget_lensShift_Injected_Out_Vector2 = new(this, "get_lensShift_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_lensShift_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_lensShift_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_lensShift_Injected_Ref_Vector2;
		public virtual RMethod RMset_lensShift_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_lensShift_Injected_Ref_Vector2 == null)
				{
					r_Mset_lensShift_Injected_Ref_Vector2 = new(this, "set_lensShift_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_lensShift_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void GetGateFittedLensShift_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MGetGateFittedLensShift_Injected_Out_Vector2;
		public virtual RMethod RMGetGateFittedLensShift_Injected_Out_Vector2
		{
			get
			{
				if(r_MGetGateFittedLensShift_Injected_Out_Vector2 == null)
				{
					r_MGetGateFittedLensShift_Injected_Out_Vector2 = new(this, "GetGateFittedLensShift_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MGetGateFittedLensShift_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void GetLocalSpaceAim_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MGetLocalSpaceAim_Injected_Out_Vector3;
		public virtual RMethod RMGetLocalSpaceAim_Injected_Out_Vector3
		{
			get
			{
				if(r_MGetLocalSpaceAim_Injected_Out_Vector3 == null)
				{
					r_MGetLocalSpaceAim_Injected_Out_Vector3 = new(this, "GetLocalSpaceAim_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MGetLocalSpaceAim_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_rect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mget_rect_Injected_Out_Rect;
		public virtual RMethod RMget_rect_Injected_Out_Rect
		{
			get
			{
				if(r_Mget_rect_Injected_Out_Rect == null)
				{
					r_Mget_rect_Injected_Out_Rect = new(this, "get_rect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_Mget_rect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void set_rect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mset_rect_Injected_Ref_Rect;
		public virtual RMethod RMset_rect_Injected_Ref_Rect
		{
			get
			{
				if(r_Mset_rect_Injected_Ref_Rect == null)
				{
					r_Mset_rect_Injected_Ref_Rect = new(this, "set_rect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_Mset_rect_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void get_pixelRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mget_pixelRect_Injected_Out_Rect;
		public virtual RMethod RMget_pixelRect_Injected_Out_Rect
		{
			get
			{
				if(r_Mget_pixelRect_Injected_Out_Rect == null)
				{
					r_Mget_pixelRect_Injected_Out_Rect = new(this, "get_pixelRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_Mget_pixelRect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void set_pixelRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Mset_pixelRect_Injected_Ref_Rect;
		public virtual RMethod RMset_pixelRect_Injected_Ref_Rect
		{
			get
			{
				if(r_Mset_pixelRect_Injected_Ref_Rect == null)
				{
					r_Mset_pixelRect_Injected_Ref_Rect = new(this, "set_pixelRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_Mset_pixelRect_Injected_Ref_Rect;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersImpl_Injected(UnityEngine.RenderBuffer ByRef, UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_MSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer;
		public virtual RMethod RMSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer
		{
			get
			{
				if(r_MSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer == null)
				{
					r_MSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer = new(this, "SetTargetBuffersImpl_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType(), typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetTargetBuffersMRTImpl_Injected(UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_MSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer;
		public virtual RMethod RMSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer
		{
			get
			{
				if(r_MSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer == null)
				{
					r_MSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer = new(this, "SetTargetBuffersMRTImpl_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeArrayType(), typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// Void get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_cameraToWorldMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_cameraToWorldMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_cameraToWorldMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_cameraToWorldMatrix_Injected_Out_Matrix4x4 = new(this, "get_cameraToWorldMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_cameraToWorldMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_worldToCameraMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_worldToCameraMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_worldToCameraMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_worldToCameraMatrix_Injected_Out_Matrix4x4 = new(this, "get_worldToCameraMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_worldToCameraMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mset_worldToCameraMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RMset_worldToCameraMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_Mset_worldToCameraMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_Mset_worldToCameraMatrix_Injected_Ref_Matrix4x4 = new(this, "set_worldToCameraMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mset_worldToCameraMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_projectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_projectionMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_projectionMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_projectionMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_projectionMatrix_Injected_Out_Matrix4x4 = new(this, "get_projectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_projectionMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_projectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mset_projectionMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RMset_projectionMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_Mset_projectionMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_Mset_projectionMatrix_Injected_Ref_Matrix4x4 = new(this, "set_projectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mset_projectionMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4 = new(this, "get_nonJitteredProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4;
		public virtual RMethod RMset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_Mset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4 == null)
				{
					r_Mset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4 = new(this, "set_nonJitteredProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_previousViewProjectionMatrix_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Mget_previousViewProjectionMatrix_Injected_Out_Matrix4x4;
		public virtual RMethod RMget_previousViewProjectionMatrix_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Mget_previousViewProjectionMatrix_Injected_Out_Matrix4x4 == null)
				{
					r_Mget_previousViewProjectionMatrix_Injected_Out_Matrix4x4 = new(this, "get_previousViewProjectionMatrix_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_Mget_previousViewProjectionMatrix_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void CalculateObliqueMatrix_Injected(UnityEngine.Vector4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4;
		public virtual RMethod RMCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4
		{
			get
			{
				if(r_MCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4 == null)
				{
					r_MCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4 = new(this, "CalculateObliqueMatrix_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void WorldToScreenPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RMWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_MWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_MWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "WorldToScreenPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void WorldToViewportPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RMWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_MWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_MWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "WorldToViewportPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ViewportToWorldPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RMViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_MViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_MViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "ViewportToWorldPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ScreenToWorldPoint_Injected(UnityEngine.Vector3 ByRef, MonoOrStereoscopicEye, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
		public virtual RMethod RMScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3
		{
			get
			{
				if(r_MScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 == null)
				{
					r_MScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3 = new(this, "ScreenToWorldPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ScreenToViewportPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "ScreenToViewportPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void ViewportToScreenPoint_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RMViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_MViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3 = new(this, "ViewportToScreenPoint_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_MViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void GetFrustumPlaneSizeAt_Injected(Single, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2;
		public virtual RMethod RMGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2
		{
			get
			{
				if(r_MGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2 == null)
				{
					r_MGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2 = new(this, "GetFrustumPlaneSizeAt_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2;
			}
		}

		/// <summary>
		/// Void ViewportPointToRay_Injected(UnityEngine.Vector2 ByRef, MonoOrStereoscopicEye, UnityEngine.Ray ByRef)
		/// </summary>
		protected RMethod r_MViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
		public virtual RMethod RMViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray
		{
			get
			{
				if(r_MViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray == null)
				{
					r_MViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray = new(this, "ViewportPointToRay_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Ray).MakeByRefType());
				}
				return r_MViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
			}
		}

		/// <summary>
		/// Void ScreenPointToRay_Injected(UnityEngine.Vector2 ByRef, MonoOrStereoscopicEye, UnityEngine.Ray ByRef)
		/// </summary>
		protected RMethod r_MScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
		public virtual RMethod RMScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray
		{
			get
			{
				if(r_MScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray == null)
				{
					r_MScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray = new(this, "ScreenPointToRay_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Ray).MakeByRefType());
				}
				return r_MScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray;
			}
		}

		/// <summary>
		/// Void CalculateFrustumCornersInternal_Injected(UnityEngine.Rect ByRef, Single, MonoOrStereoscopicEye, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
		public virtual RMethod RMCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array
		{
			get
			{
				if(r_MCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array == null)
				{
					r_MCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array = new(this, "CalculateFrustumCornersInternal_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"), typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array;
			}
		}

		/// <summary>
		/// Void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matrix4x4 ByRef, Single, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Single, Single, Single, GateFitMode)
		/// </summary>
		protected static RMethod r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode;
		public static RMethod RMCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode
		{
			get
			{
				if(r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode == null)
				{
					r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode = new(Type, "CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Camera+GateFitMode"));
				}
				return r_MCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode;
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
				}
				return r_Mget_scene_Injected_Out_Scene;
			}
		}

		/// <summary>
		/// Void set_scene_Injected(UnityEngine.SceneManagement.Scene ByRef)
		/// </summary>
		protected RMethod r_Mset_scene_Injected_Ref_Scene;
		public virtual RMethod RMset_scene_Injected_Ref_Scene
		{
			get
			{
				if(r_Mset_scene_Injected_Ref_Scene == null)
				{
					r_Mset_scene_Injected_Ref_Scene = new(this, "set_scene_Injected", 0, typeof(UnityEngine.SceneManagement.Scene).MakeByRefType());
				}
				return r_Mset_scene_Injected_Ref_Scene;
			}
		}

		/// <summary>
		/// Void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
		public virtual RMethod RMGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4
		{
			get
			{
				if(r_MGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 == null)
				{
					r_MGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 = new(this, "GetStereoNonJitteredProjectionMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetStereoViewMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
		public virtual RMethod RMGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4
		{
			get
			{
				if(r_MGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4 == null)
				{
					r_MGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4 = new(this, "GetStereoViewMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void GetStereoProjectionMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
		public virtual RMethod RMGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4
		{
			get
			{
				if(r_MGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 == null)
				{
					r_MGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4 = new(this, "GetStereoProjectionMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetStereoProjectionMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
		public virtual RMethod RMSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 == null)
				{
					r_MSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 = new(this, "SetStereoProjectionMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetStereoViewMatrix_Injected(StereoscopicEye, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
		public virtual RMethod RMSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 == null)
				{
					r_MSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4 = new(this, "SetStereoViewMatrix_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Camera+StereoscopicEye"), typeof(UnityEngine.Matrix4x4).MakeByRefType());
				}
				return r_MSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4;
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
					r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
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
					r_MGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
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
					r_MGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
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
					r_MGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Component)));
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
					r_MGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetTransparencySortSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetTransparencySortSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAspect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetAspect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single[] GetLayerCullDistances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLayerCullDistances.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single[]>(___result);
        }


        public virtual void SetLayerCullDistances(System.Single[] @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMSetLayerCullDistances_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCullingMatrix()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetCullingMatrix.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetReplacementShader(UnityEngine.Shader @shader, System.String @replacementTag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @replacementTag};
            var ___result = RMSetReplacementShader_Shader_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetReplacementShader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetReplacementShader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetGateFittedFieldOfView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGateFittedFieldOfView.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual UnityEngine.Vector2 GetGateFittedLensShift()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGateFittedLensShift.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual UnityEngine.Vector3 GetLocalSpaceAim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLocalSpaceAim.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual void SetTargetBuffersImpl(UnityEngine.RenderBuffer @color, UnityEngine.RenderBuffer @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RMSetTargetBuffersImpl_RenderBuffer_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTargetBuffers(UnityEngine.RenderBuffer @colorBuffer, UnityEngine.RenderBuffer @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorBuffer, @depthBuffer};
            var ___result = RMSetTargetBuffers_RenderBuffer_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[] @color, UnityEngine.RenderBuffer @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RMSetTargetBuffersMRTImpl_RenderBufferArray_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTargetBuffers(UnityEngine.RenderBuffer[] @colorBuffer, UnityEngine.RenderBuffer @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorBuffer, @depthBuffer};
            var ___result = RMSetTargetBuffers_RenderBufferArray_RenderBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetCameraBufferWarnings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCameraBufferWarnings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual void ResetWorldToCameraMatrix()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetWorldToCameraMatrix.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetProjectionMatrix()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetProjectionMatrix.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 @clipPlane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clipPlane};
            var ___result = RMCalculateObliqueMatrix_Vector4.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value};
            var ___result = RMWorldToScreenPoint_Vector3_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value};
            var ___result = RMWorldToViewportPoint_Vector3_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value};
            var ___result = RMViewportToWorldPoint_Vector3_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value};
            var ___result = RMScreenToWorldPoint_Vector3_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMWorldToScreenPoint_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMWorldToViewportPoint_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMViewportToWorldPoint_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMScreenToWorldPoint_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMScreenToViewportPoint_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMViewportToScreenPoint_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector2 GetFrustumPlaneSizeAt(System.Single @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@distance};
            var ___result = RMGetFrustumPlaneSizeAt_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2 @pos, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @eye.Value};
            var ___result = RMViewportPointToRay_Vector2_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Ray>(___result);
        }


        public virtual UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 @pos, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @eye.Value};
            var ___result = RMViewportPointToRay_Vector3_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Ray>(___result);
        }


        public virtual UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMViewportPointToRay_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Ray>(___result);
        }


        public virtual UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 @pos, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @eye.Value};
            var ___result = RMScreenPointToRay_Vector2_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Ray>(___result);
        }


        public virtual UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 @pos, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @eye.Value};
            var ___result = RMScreenPointToRay_Vector3_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Ray>(___result);
        }


        public virtual UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMScreenPointToRay_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Ray>(___result);
        }


        public virtual void CalculateFrustumCornersInternal(UnityEngine.Rect @viewport, System.Single @z, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, UnityEngine.Vector3[] @outCorners)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viewport, @z, @eye.Value, @outCorners};
            var ___result = RMCalculateFrustumCornersInternal_Rect_Single_MonoOrStereoscopicEye_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalculateFrustumCorners(UnityEngine.Rect @viewport, System.Single @z, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, UnityEngine.Vector3[] @outCorners)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viewport, @z, @eye.Value, @outCorners};
            var ___result = RMCalculateFrustumCorners_Rect_Single_MonoOrStereoscopicEye_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out UnityEngine.Matrix4x4 @output, System.Single @focalLength, UnityEngine.Vector2 @sensorSize, UnityEngine.Vector2 @lensShift, System.Single @nearClip, System.Single @farClip, System.Single @gateAspect, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode @gateFitMode)
        {
			@output = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @focalLength, @sensorSize, @lensShift, @nearClip, @farClip, @gateAspect, @gateFitMode.Value};
            var ___result = RMCalculateProjectionMatrixFromPhysicalPropertiesInternal_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode.Invoke(___genericsType, ___parameters);
			@output = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public static void CalculateProjectionMatrixFromPhysicalProperties(out UnityEngine.Matrix4x4 @output, System.Single @focalLength, UnityEngine.Vector2 @sensorSize, UnityEngine.Vector2 @lensShift, System.Single @nearClip, System.Single @farClip, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitParameters @gateFitParameters)
        {
			@output = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @focalLength, @sensorSize, @lensShift, @nearClip, @farClip, @gateFitParameters.Value};
            var ___result = RMCalculateProjectionMatrixFromPhysicalProperties_Out_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters.Invoke(___genericsType, ___parameters);
			@output = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public static System.Single FocalLengthToFieldOfView(System.Single @focalLength, System.Single @sensorSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focalLength, @sensorSize};
            var ___result = RMFocalLengthToFieldOfView_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single FieldOfViewToFocalLength(System.Single @fieldOfView, System.Single @sensorSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldOfView, @sensorSize};
            var ___result = RMFieldOfViewToFocalLength_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single HorizontalToVerticalFieldOfView(System.Single @horizontalFieldOfView, System.Single @aspectRatio)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@horizontalFieldOfView, @aspectRatio};
            var ___result = RMHorizontalToVerticalFieldOfView_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single VerticalToHorizontalFieldOfView(System.Single @verticalFieldOfView, System.Single @aspectRatio)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@verticalFieldOfView, @aspectRatio};
            var ___result = RMVerticalToHorizontalFieldOfView_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value};
            var ___result = RMGetStereoNonJitteredProjectionMatrix_StereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual UnityEngine.Matrix4x4 GetStereoViewMatrix(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value};
            var ___result = RMGetStereoViewMatrix_StereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual void CopyStereoDeviceProjectionMatrixToNonJittered(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value};
            var ___result = RMCopyStereoDeviceProjectionMatrixToNonJittered_StereoscopicEye.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Matrix4x4 GetStereoProjectionMatrix(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value};
            var ___result = RMGetStereoProjectionMatrix_StereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___result);
        }


        public virtual void SetStereoProjectionMatrix(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @matrix};
            var ___result = RMSetStereoProjectionMatrix_StereoscopicEye_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetStereoProjectionMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetStereoProjectionMatrices.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStereoViewMatrix(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @matrix};
            var ___result = RMSetStereoViewMatrix_StereoscopicEye_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetStereoViewMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetStereoViewMatrices.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetAllCamerasCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllCamerasCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetAllCamerasImpl(UnityEngine.Camera[] @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RMGetAllCamerasImpl_CameraArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetAllCameras(UnityEngine.Camera[] @cameras)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cameras};
            var ___result = RMGetAllCameras_CameraArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean RenderToCubemapImpl(UnityEngine.Texture @tex, System.Int32 @faceMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex, @faceMask};
            var ___result = RMRenderToCubemapImpl_Texture_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.Cubemap @cubemap, System.Int32 @faceMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap, @faceMask};
            var ___result = RMRenderToCubemap_Cubemap_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.Cubemap @cubemap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap};
            var ___result = RMRenderToCubemap_Cubemap.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.RenderTexture @cubemap, System.Int32 @faceMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap, @faceMask};
            var ___result = RMRenderToCubemap_RenderTexture_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.RenderTexture @cubemap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap};
            var ___result = RMRenderToCubemap_RenderTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetFilterMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFilterMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean RenderToCubemapEyeImpl(UnityEngine.RenderTexture @cubemap, System.Int32 @faceMask, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @stereoEye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap, @faceMask, @stereoEye.Value};
            var ___result = RMRenderToCubemapEyeImpl_RenderTexture_Int32_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean RenderToCubemap(UnityEngine.RenderTexture @cubemap, System.Int32 @faceMask, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @stereoEye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cubemap, @faceMask, @stereoEye.Value};
            var ___result = RMRenderToCubemap_RenderTexture_Int32_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Render()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRender.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RenderWithShader(UnityEngine.Shader @shader, System.String @replacementTag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @replacementTag};
            var ___result = RMRenderWithShader_Shader_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RenderDontRestore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRenderDontRestore.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SubmitRenderRequests(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequest> @renderRequests)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderRequests.Value};
            var ___result = RMSubmitRenderRequests_List_d_RenderRequest_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SubmitRenderRequest<RequestData>(RequestData @renderRequest)
        {

            var ___genericsType = new Type[] {typeof(RequestData)};
            var ___parameters = new object[]{@renderRequest};
            var ___result = RMSubmitRenderRequest_GRequestData_RequestData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SubmitRenderRequestsInternal(System.Object @requests)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requests};
            var ___result = RMSubmitRenderRequestsInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetupCurrent(UnityEngine.Camera @cur)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cur};
            var ___result = RMSetupCurrent_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(UnityEngine.Camera @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMCopyFrom_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMRemoveCommandBuffers_CameraEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAllCommandBuffers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveAllCommandBuffers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent @evt, UnityEngine.Rendering.CommandBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RMAddCommandBufferImpl_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent @evt, UnityEngine.Rendering.CommandBuffer @buffer, UnityEngine.Rendering.ComputeQueueType @queueType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @queueType};
            var ___result = RMAddCommandBufferAsyncImpl_CameraEvent_CommandBuffer_ComputeQueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent @evt, UnityEngine.Rendering.CommandBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RMRemoveCommandBufferImpl_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBuffer(UnityEngine.Rendering.CameraEvent @evt, UnityEngine.Rendering.CommandBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RMAddCommandBuffer_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent @evt, UnityEngine.Rendering.CommandBuffer @buffer, UnityEngine.Rendering.ComputeQueueType @queueType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @queueType};
            var ___result = RMAddCommandBufferAsync_CameraEvent_CommandBuffer_ComputeQueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent @evt, UnityEngine.Rendering.CommandBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RMRemoveCommandBuffer_CameraEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMGetCommandBuffers_CameraEvent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.CommandBuffer[]>(___result);
        }


        public static void FireOnPreCull(UnityEngine.Camera @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RMFireOnPreCull_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public static void FireOnPreRender(UnityEngine.Camera @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RMFireOnPreRender_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public static void FireOnPostRender(UnityEngine.Camera @cam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cam};
            var ___result = RMFireOnPostRender_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnlyUsedForTesting1()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnlyUsedForTesting1.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnlyUsedForTesting2()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnlyUsedForTesting2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetCullingParameters(out UnityEngine.Rendering.ScriptableCullingParameters @cullingParameters)
        {
			@cullingParameters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cullingParameters};
            var ___result = RMTryGetCullingParameters_Out_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);
			@cullingParameters = (UnityEngine.Rendering.ScriptableCullingParameters)___parameters[0];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetCullingParameters(System.Boolean @stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters @cullingParameters)
        {
			@cullingParameters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stereoAware, @cullingParameters};
            var ___result = RMTryGetCullingParameters_Boolean_Out_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);
			@cullingParameters = (UnityEngine.Rendering.ScriptableCullingParameters)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean GetCullingParameters_Internal(UnityEngine.Camera @camera, System.Boolean @stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters @cullingParameters, System.Int32 @managedCullingParametersSize)
        {
			@cullingParameters = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@camera, @stereoAware, @cullingParameters, @managedCullingParametersSize};
            var ___result = RMGetCullingParameters_Internal_Camera_Boolean_Out_ScriptableCullingParameters_Int32.Invoke(___genericsType, ___parameters);
			@cullingParameters = (UnityEngine.Rendering.ScriptableCullingParameters)___parameters[2];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Single GetScreenWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetScreenWidth.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single GetScreenHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetScreenHeight.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void DoClear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetFieldOfView()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetFieldOfView.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStereoViewMatrices(UnityEngine.Matrix4x4 @leftMatrix, UnityEngine.Matrix4x4 @rightMatrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leftMatrix, @rightMatrix};
            var ___result = RMSetStereoViewMatrices_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStereoProjectionMatrices(UnityEngine.Matrix4x4 @leftMatrix, UnityEngine.Matrix4x4 @rightMatrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leftMatrix, @rightMatrix};
            var ___result = RMSetStereoProjectionMatrices_Matrix4x4_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Matrix4x4[] GetStereoViewMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStereoViewMatrices.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4[]>(___result);
        }


        public virtual UnityEngine.Matrix4x4[] GetStereoProjectionMatrices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStereoProjectionMatrices.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Matrix4x4[]>(___result);
        }


        public virtual void get_transparencySortAxis_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_transparencySortAxis_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_transparencySortAxis_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_transparencySortAxis_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_velocity_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_velocity_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_cullingMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_cullingMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_cullingMatrix_Injected(ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_cullingMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_backgroundColor_Injected(out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_backgroundColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_backgroundColor_Injected(ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_backgroundColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void get_curvature_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_curvature_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_curvature_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_curvature_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_sensorSize_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_sensorSize_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_sensorSize_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_sensorSize_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_lensShift_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_lensShift_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_lensShift_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_lensShift_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetGateFittedLensShift_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetGateFittedLensShift_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetLocalSpaceAim_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetLocalSpaceAim_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_rect_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_rect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void set_rect_Injected(ref UnityEngine.Rect @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_rect_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void get_pixelRect_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_pixelRect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void set_pixelRect_Injected(ref UnityEngine.Rect @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_pixelRect_Injected_Ref_Rect.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void SetTargetBuffersImpl_Injected(ref UnityEngine.RenderBuffer @color, ref UnityEngine.RenderBuffer @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RMSetTargetBuffersImpl_Injected_Ref_RenderBuffer_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@color = (UnityEngine.RenderBuffer)___parameters[0];
			@depth = (UnityEngine.RenderBuffer)___parameters[1];

            
        }


        public virtual void SetTargetBuffersMRTImpl_Injected(UnityEngine.RenderBuffer[] @color, ref UnityEngine.RenderBuffer @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color, @depth};
            var ___result = RMSetTargetBuffersMRTImpl_Injected_RenderBufferArray_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@depth = (UnityEngine.RenderBuffer)___parameters[1];

            
        }


        public virtual void get_cameraToWorldMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_cameraToWorldMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_worldToCameraMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_worldToCameraMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_worldToCameraMatrix_Injected(ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_worldToCameraMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_projectionMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_projectionMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_projectionMatrix_Injected(ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_projectionMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_nonJitteredProjectionMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_nonJitteredProjectionMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_nonJitteredProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_nonJitteredProjectionMatrix_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_previousViewProjectionMatrix_Injected(out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_previousViewProjectionMatrix_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void CalculateObliqueMatrix_Injected(ref UnityEngine.Vector4 @clipPlane, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clipPlane, @ret};
            var ___result = RMCalculateObliqueMatrix_Injected_Ref_Vector4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@clipPlane = (UnityEngine.Vector4)___parameters[0];
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void WorldToScreenPoint_Injected(ref UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value, @ret};
            var ___result = RMWorldToScreenPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[2];

            
        }


        public virtual void WorldToViewportPoint_Injected(ref UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value, @ret};
            var ___result = RMWorldToViewportPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[2];

            
        }


        public virtual void ViewportToWorldPoint_Injected(ref UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value, @ret};
            var ___result = RMViewportToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[2];

            
        }


        public virtual void ScreenToWorldPoint_Injected(ref UnityEngine.Vector3 @position, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @eye.Value, @ret};
            var ___result = RMScreenToWorldPoint_Injected_Ref_Vector3_MonoOrStereoscopicEye_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[2];

            
        }


        public virtual void ScreenToViewportPoint_Injected(ref UnityEngine.Vector3 @position, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RMScreenToViewportPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void ViewportToScreenPoint_Injected(ref UnityEngine.Vector3 @position, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @ret};
            var ___result = RMViewportToScreenPoint_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Vector3)___parameters[0];
			@ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void GetFrustumPlaneSizeAt_Injected(System.Single @distance, out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@distance, @ret};
            var ___result = RMGetFrustumPlaneSizeAt_Injected_Single_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void ViewportPointToRay_Injected(ref UnityEngine.Vector2 @pos, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, out UnityEngine.Ray @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @eye.Value, @ret};
            var ___result = RMViewportPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray.Invoke(___genericsType, ___parameters);
			@pos = (UnityEngine.Vector2)___parameters[0];
			@ret = (UnityEngine.Ray)___parameters[2];

            
        }


        public virtual void ScreenPointToRay_Injected(ref UnityEngine.Vector2 @pos, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, out UnityEngine.Ray @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @eye.Value, @ret};
            var ___result = RMScreenPointToRay_Injected_Ref_Vector2_MonoOrStereoscopicEye_Out_Ray.Invoke(___genericsType, ___parameters);
			@pos = (UnityEngine.Vector2)___parameters[0];
			@ret = (UnityEngine.Ray)___parameters[2];

            
        }


        public virtual void CalculateFrustumCornersInternal_Injected(ref UnityEngine.Rect @viewport, System.Single @z, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye, UnityEngine.Vector3[] @outCorners)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viewport, @z, @eye.Value, @outCorners};
            var ___result = RMCalculateFrustumCornersInternal_Injected_Ref_Rect_Single_MonoOrStereoscopicEye_Vector3Array.Invoke(___genericsType, ___parameters);
			@viewport = (UnityEngine.Rect)___parameters[0];

            
        }


        public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out UnityEngine.Matrix4x4 @output, System.Single @focalLength, ref UnityEngine.Vector2 @sensorSize, ref UnityEngine.Vector2 @lensShift, System.Single @nearClip, System.Single @farClip, System.Single @gateAspect, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode @gateFitMode)
        {
			@output = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output, @focalLength, @sensorSize, @lensShift, @nearClip, @farClip, @gateAspect, @gateFitMode.Value};
            var ___result = RMCalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Out_Matrix4x4_Single_Ref_Vector2_Ref_Vector2_Single_Single_Single_GateFitMode.Invoke(___genericsType, ___parameters);
			@output = (UnityEngine.Matrix4x4)___parameters[0];
			@sensorSize = (UnityEngine.Vector2)___parameters[2];
			@lensShift = (UnityEngine.Vector2)___parameters[3];

            
        }


        public virtual void get_scene_Injected(out UnityEngine.SceneManagement.Scene @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_scene_Injected_Out_Scene.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
        }


        public virtual void set_scene_Injected(ref UnityEngine.SceneManagement.Scene @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_scene_Injected_Ref_Scene.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.SceneManagement.Scene)___parameters[0];

            
        }


        public virtual void GetStereoNonJitteredProjectionMatrix_Injected(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @ret};
            var ___result = RMGetStereoNonJitteredProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void GetStereoViewMatrix_Injected(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @ret};
            var ___result = RMGetStereoViewMatrix_Injected_StereoscopicEye_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void GetStereoProjectionMatrix_Injected(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, out UnityEngine.Matrix4x4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @ret};
            var ___result = RMGetStereoProjectionMatrix_Injected_StereoscopicEye_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void SetStereoProjectionMatrix_Injected(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, ref UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @matrix};
            var ___result = RMSetStereoProjectionMatrix_Injected_StereoscopicEye_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void SetStereoViewMatrix_Injected(Hvak.Editor.Refleaction.RUnityEngine.RCamera.RStereoscopicEye @eye, ref UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eye.Value, @matrix};
            var ___result = RMSetStereoViewMatrix_Injected_StereoscopicEye_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual UnityEngine.Component GetComponent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
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

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual System.Boolean TryGetComponent(System.Type @type, out UnityEngine.Component @component)
        {
			@component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RMTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			@component = (UnityEngine.Component)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetComponent<T>(out T @component)
        {
			@component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RMTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			@component = (T)___parameters[0];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Component GetComponent(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual T GetComponentInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
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

            return ReflectionUtils.Convert<T[]>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual T GetComponentInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
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

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponents_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
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

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual System.Boolean CompareTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMCompareTag_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
