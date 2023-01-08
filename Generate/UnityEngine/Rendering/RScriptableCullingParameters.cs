using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.ScriptableCullingParameters
	/// </summary>
    public partial class RScriptableCullingParameters : RMember //
    {

		/// <summary>
		/// System.Int32 m_IsOrthographic
		/// </summary>
		protected RField r_m_IsOrthographic;
		public virtual RField Rm_IsOrthographic
		{
			get
			{
				if(r_m_IsOrthographic == null)
				{
					r_m_IsOrthographic = new(this, "m_IsOrthographic");
					r_m_IsOrthographic.SetBelong(this.instance);
				}
				return r_m_IsOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters m_LODParameters
		/// </summary>
		protected RUnityEngine.RRendering.RLODParameters r_m_LODParameters;
		public virtual RUnityEngine.RRendering.RLODParameters Rm_LODParameters
		{
			get
			{
				if(r_m_LODParameters == null)
				{
					r_m_LODParameters = new(this, "m_LODParameters");
					r_m_LODParameters.SetBelong(this.instance);
				}
				return r_m_LODParameters;
			}
		}

		/// <summary>
		/// System.Int32 k_MaximumCullingPlaneCount
		/// </summary>
		protected static RField r_k_MaximumCullingPlaneCount;
		public static RField Rk_MaximumCullingPlaneCount
		{
			get
			{
				if(r_k_MaximumCullingPlaneCount == null)
				{
					r_k_MaximumCullingPlaneCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_MaximumCullingPlaneCount");
					r_k_MaximumCullingPlaneCount.SetBelong(null);
				}
				return r_k_MaximumCullingPlaneCount;
			}
		}

		/// <summary>
		/// System.Int32 maximumCullingPlaneCount
		/// </summary>
		protected static RField r_maximumCullingPlaneCount;
		public static RField RmaximumCullingPlaneCount
		{
			get
			{
				if(r_maximumCullingPlaneCount == null)
				{
					r_maximumCullingPlaneCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "maximumCullingPlaneCount");
					r_maximumCullingPlaneCount.SetBelong(null);
				}
				return r_maximumCullingPlaneCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ScriptableCullingParameters+<m_CullingPlanes>e__FixedBuffer m_CullingPlanes
		/// </summary>
		protected RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_CullingPlanes__1__e__FixedBuffer r_m_CullingPlanes;
		public virtual RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_CullingPlanes__1__e__FixedBuffer Rm_CullingPlanes
		{
			get
			{
				if(r_m_CullingPlanes == null)
				{
					r_m_CullingPlanes = new(this, "m_CullingPlanes");
					r_m_CullingPlanes.SetBelong(this.instance);
				}
				return r_m_CullingPlanes;
			}
		}

		/// <summary>
		/// System.Int32 m_CullingPlaneCount
		/// </summary>
		protected RField r_m_CullingPlaneCount;
		public virtual RField Rm_CullingPlaneCount
		{
			get
			{
				if(r_m_CullingPlaneCount == null)
				{
					r_m_CullingPlaneCount = new(this, "m_CullingPlaneCount");
					r_m_CullingPlaneCount.SetBelong(this.instance);
				}
				return r_m_CullingPlaneCount;
			}
		}

		/// <summary>
		/// System.UInt32 m_CullingMask
		/// </summary>
		protected RField r_m_CullingMask;
		public virtual RField Rm_CullingMask
		{
			get
			{
				if(r_m_CullingMask == null)
				{
					r_m_CullingMask = new(this, "m_CullingMask");
					r_m_CullingMask.SetBelong(this.instance);
				}
				return r_m_CullingMask;
			}
		}

		/// <summary>
		/// System.UInt64 m_SceneMask
		/// </summary>
		protected RField r_m_SceneMask;
		public virtual RField Rm_SceneMask
		{
			get
			{
				if(r_m_SceneMask == null)
				{
					r_m_SceneMask = new(this, "m_SceneMask");
					r_m_SceneMask.SetBelong(this.instance);
				}
				return r_m_SceneMask;
			}
		}

		/// <summary>
		/// System.UInt64 m_ViewID
		/// </summary>
		protected RField r_m_ViewID;
		public virtual RField Rm_ViewID
		{
			get
			{
				if(r_m_ViewID == null)
				{
					r_m_ViewID = new(this, "m_ViewID");
					r_m_ViewID.SetBelong(this.instance);
				}
				return r_m_ViewID;
			}
		}

		/// <summary>
		/// System.Int32 k_LayerCount
		/// </summary>
		protected static RField r_k_LayerCount;
		public static RField Rk_LayerCount
		{
			get
			{
				if(r_k_LayerCount == null)
				{
					r_k_LayerCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_LayerCount");
					r_k_LayerCount.SetBelong(null);
				}
				return r_k_LayerCount;
			}
		}

		/// <summary>
		/// System.Int32 layerCount
		/// </summary>
		protected static RField r_layerCount;
		public static RField RlayerCount
		{
			get
			{
				if(r_layerCount == null)
				{
					r_layerCount = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "layerCount");
					r_layerCount.SetBelong(null);
				}
				return r_layerCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ScriptableCullingParameters+<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances
		/// </summary>
		protected RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_LayerFarCullDistances__1__e__FixedBuffer r_m_LayerFarCullDistances;
		public virtual RUnityEngine.RRendering.RScriptableCullingParameters.R__0__m_LayerFarCullDistances__1__e__FixedBuffer Rm_LayerFarCullDistances
		{
			get
			{
				if(r_m_LayerFarCullDistances == null)
				{
					r_m_LayerFarCullDistances = new(this, "m_LayerFarCullDistances");
					r_m_LayerFarCullDistances.SetBelong(this.instance);
				}
				return r_m_LayerFarCullDistances;
			}
		}

		/// <summary>
		/// System.Int32 m_LayerCull
		/// </summary>
		protected RField r_m_LayerCull;
		public virtual RField Rm_LayerCull
		{
			get
			{
				if(r_m_LayerCull == null)
				{
					r_m_LayerCull = new(this, "m_LayerCull");
					r_m_LayerCull.SetBelong(this.instance);
				}
				return r_m_LayerCull;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_CullingMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_m_CullingMatrix;
		public virtual RUnityEngine.RMatrix4x4 Rm_CullingMatrix
		{
			get
			{
				if(r_m_CullingMatrix == null)
				{
					r_m_CullingMatrix = new(this, "m_CullingMatrix");
					r_m_CullingMatrix.SetBelong(this.instance);
				}
				return r_m_CullingMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Origin
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Origin;
		public virtual RUnityEngine.RVector3 Rm_Origin
		{
			get
			{
				if(r_m_Origin == null)
				{
					r_m_Origin = new(this, "m_Origin");
					r_m_Origin.SetBelong(this.instance);
				}
				return r_m_Origin;
			}
		}

		/// <summary>
		/// System.Single m_ShadowDistance
		/// </summary>
		protected RField r_m_ShadowDistance;
		public virtual RField Rm_ShadowDistance
		{
			get
			{
				if(r_m_ShadowDistance == null)
				{
					r_m_ShadowDistance = new(this, "m_ShadowDistance");
					r_m_ShadowDistance.SetBelong(this.instance);
				}
				return r_m_ShadowDistance;
			}
		}

		/// <summary>
		/// System.Single m_ShadowNearPlaneOffset
		/// </summary>
		protected RField r_m_ShadowNearPlaneOffset;
		public virtual RField Rm_ShadowNearPlaneOffset
		{
			get
			{
				if(r_m_ShadowNearPlaneOffset == null)
				{
					r_m_ShadowNearPlaneOffset = new(this, "m_ShadowNearPlaneOffset");
					r_m_ShadowNearPlaneOffset.SetBelong(this.instance);
				}
				return r_m_ShadowNearPlaneOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CullingOptions m_CullingOptions
		/// </summary>
		protected RField r_m_CullingOptions;
		public virtual RField Rm_CullingOptions
		{
			get
			{
				if(r_m_CullingOptions == null)
				{
					r_m_CullingOptions = new(this, "m_CullingOptions");
					r_m_CullingOptions.SetBelong(this.instance);
				}
				return r_m_CullingOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria
		/// </summary>
		protected RField r_m_ReflectionProbeSortingCriteria;
		public virtual RField Rm_ReflectionProbeSortingCriteria
		{
			get
			{
				if(r_m_ReflectionProbeSortingCriteria == null)
				{
					r_m_ReflectionProbeSortingCriteria = new(this, "m_ReflectionProbeSortingCriteria");
					r_m_ReflectionProbeSortingCriteria.SetBelong(this.instance);
				}
				return r_m_ReflectionProbeSortingCriteria;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties m_CameraProperties
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties r_m_CameraProperties;
		public virtual RUnityEngine.RRendering.RCameraProperties Rm_CameraProperties
		{
			get
			{
				if(r_m_CameraProperties == null)
				{
					r_m_CameraProperties = new(this, "m_CameraProperties");
					r_m_CameraProperties.SetBelong(this.instance);
				}
				return r_m_CameraProperties;
			}
		}

		/// <summary>
		/// System.Single m_AccurateOcclusionThreshold
		/// </summary>
		protected RField r_m_AccurateOcclusionThreshold;
		public virtual RField Rm_AccurateOcclusionThreshold
		{
			get
			{
				if(r_m_AccurateOcclusionThreshold == null)
				{
					r_m_AccurateOcclusionThreshold = new(this, "m_AccurateOcclusionThreshold");
					r_m_AccurateOcclusionThreshold.SetBelong(this.instance);
				}
				return r_m_AccurateOcclusionThreshold;
			}
		}

		/// <summary>
		/// System.Int32 m_MaximumPortalCullingJobs
		/// </summary>
		protected RField r_m_MaximumPortalCullingJobs;
		public virtual RField Rm_MaximumPortalCullingJobs
		{
			get
			{
				if(r_m_MaximumPortalCullingJobs == null)
				{
					r_m_MaximumPortalCullingJobs = new(this, "m_MaximumPortalCullingJobs");
					r_m_MaximumPortalCullingJobs.SetBelong(this.instance);
				}
				return r_m_MaximumPortalCullingJobs;
			}
		}

		/// <summary>
		/// System.Int32 k_CullingJobCountLowerLimit
		/// </summary>
		protected static RField r_k_CullingJobCountLowerLimit;
		public static RField Rk_CullingJobCountLowerLimit
		{
			get
			{
				if(r_k_CullingJobCountLowerLimit == null)
				{
					r_k_CullingJobCountLowerLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_CullingJobCountLowerLimit");
					r_k_CullingJobCountLowerLimit.SetBelong(null);
				}
				return r_k_CullingJobCountLowerLimit;
			}
		}

		/// <summary>
		/// System.Int32 k_CullingJobCountUpperLimit
		/// </summary>
		protected static RField r_k_CullingJobCountUpperLimit;
		public static RField Rk_CullingJobCountUpperLimit
		{
			get
			{
				if(r_k_CullingJobCountUpperLimit == null)
				{
					r_k_CullingJobCountUpperLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "k_CullingJobCountUpperLimit");
					r_k_CullingJobCountUpperLimit.SetBelong(null);
				}
				return r_k_CullingJobCountUpperLimit;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_StereoViewMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_m_StereoViewMatrix;
		public virtual RUnityEngine.RMatrix4x4 Rm_StereoViewMatrix
		{
			get
			{
				if(r_m_StereoViewMatrix == null)
				{
					r_m_StereoViewMatrix = new(this, "m_StereoViewMatrix");
					r_m_StereoViewMatrix.SetBelong(this.instance);
				}
				return r_m_StereoViewMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_StereoProjectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_m_StereoProjectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 Rm_StereoProjectionMatrix
		{
			get
			{
				if(r_m_StereoProjectionMatrix == null)
				{
					r_m_StereoProjectionMatrix = new(this, "m_StereoProjectionMatrix");
					r_m_StereoProjectionMatrix.SetBelong(this.instance);
				}
				return r_m_StereoProjectionMatrix;
			}
		}

		/// <summary>
		/// System.Single m_StereoSeparationDistance
		/// </summary>
		protected RField r_m_StereoSeparationDistance;
		public virtual RField Rm_StereoSeparationDistance
		{
			get
			{
				if(r_m_StereoSeparationDistance == null)
				{
					r_m_StereoSeparationDistance = new(this, "m_StereoSeparationDistance");
					r_m_StereoSeparationDistance.SetBelong(this.instance);
				}
				return r_m_StereoSeparationDistance;
			}
		}

		/// <summary>
		/// System.Int32 m_maximumVisibleLights
		/// </summary>
		protected RField r_m_maximumVisibleLights;
		public virtual RField Rm_maximumVisibleLights
		{
			get
			{
				if(r_m_maximumVisibleLights == null)
				{
					r_m_maximumVisibleLights = new(this, "m_maximumVisibleLights");
					r_m_maximumVisibleLights.SetBelong(this.instance);
				}
				return r_m_maximumVisibleLights;
			}
		}

		/// <summary>
		/// System.Boolean m_ConservativeEnclosingSphere
		/// </summary>
		protected RField r_m_ConservativeEnclosingSphere;
		public virtual RField Rm_ConservativeEnclosingSphere
		{
			get
			{
				if(r_m_ConservativeEnclosingSphere == null)
				{
					r_m_ConservativeEnclosingSphere = new(this, "m_ConservativeEnclosingSphere");
					r_m_ConservativeEnclosingSphere.SetBelong(this.instance);
				}
				return r_m_ConservativeEnclosingSphere;
			}
		}

		/// <summary>
		/// System.Int32 m_NumIterationsEnclosingSphere
		/// </summary>
		protected RField r_m_NumIterationsEnclosingSphere;
		public virtual RField Rm_NumIterationsEnclosingSphere
		{
			get
			{
				if(r_m_NumIterationsEnclosingSphere == null)
				{
					r_m_NumIterationsEnclosingSphere = new(this, "m_NumIterationsEnclosingSphere");
					r_m_NumIterationsEnclosingSphere.SetBelong(this.instance);
				}
				return r_m_NumIterationsEnclosingSphere;
			}
		}

		/// <summary>
		/// Int32 maximumVisibleLights
		/// </summary>
		protected RProperty r_maximumVisibleLights;
		public virtual RProperty RmaximumVisibleLights
		{
			get
			{
				if(r_maximumVisibleLights == null)
				{
					r_maximumVisibleLights = new(this, "maximumVisibleLights", -1);
					r_maximumVisibleLights.SetBelong(this.instance);
				}
				return r_maximumVisibleLights;
			}
		}

		/// <summary>
		/// Boolean conservativeEnclosingSphere
		/// </summary>
		protected RProperty r_conservativeEnclosingSphere;
		public virtual RProperty RconservativeEnclosingSphere
		{
			get
			{
				if(r_conservativeEnclosingSphere == null)
				{
					r_conservativeEnclosingSphere = new(this, "conservativeEnclosingSphere", -1);
					r_conservativeEnclosingSphere.SetBelong(this.instance);
				}
				return r_conservativeEnclosingSphere;
			}
		}

		/// <summary>
		/// Int32 numIterationsEnclosingSphere
		/// </summary>
		protected RProperty r_numIterationsEnclosingSphere;
		public virtual RProperty RnumIterationsEnclosingSphere
		{
			get
			{
				if(r_numIterationsEnclosingSphere == null)
				{
					r_numIterationsEnclosingSphere = new(this, "numIterationsEnclosingSphere", -1);
					r_numIterationsEnclosingSphere.SetBelong(this.instance);
				}
				return r_numIterationsEnclosingSphere;
			}
		}

		/// <summary>
		/// Int32 cullingPlaneCount
		/// </summary>
		protected RProperty r_cullingPlaneCount;
		public virtual RProperty RcullingPlaneCount
		{
			get
			{
				if(r_cullingPlaneCount == null)
				{
					r_cullingPlaneCount = new(this, "cullingPlaneCount", -1);
					r_cullingPlaneCount.SetBelong(this.instance);
				}
				return r_cullingPlaneCount;
			}
		}

		/// <summary>
		/// Boolean isOrthographic
		/// </summary>
		protected RProperty r_isOrthographic;
		public virtual RProperty RisOrthographic
		{
			get
			{
				if(r_isOrthographic == null)
				{
					r_isOrthographic = new(this, "isOrthographic", -1);
					r_isOrthographic.SetBelong(this.instance);
				}
				return r_isOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters lodParameters
		/// </summary>
		protected RUnityEngine.RRendering.RLODParameters r_lodParameters;
		public virtual RUnityEngine.RRendering.RLODParameters RlodParameters
		{
			get
			{
				if(r_lodParameters == null)
				{
					r_lodParameters = new(this, "lodParameters", -1);
					r_lodParameters.SetBelong(this.instance);
				}
				return r_lodParameters;
			}
		}

		/// <summary>
		/// UInt32 cullingMask
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
		/// UnityEngine.Vector3 origin
		/// </summary>
		protected RUnityEngine.RVector3 r_origin;
		public virtual RUnityEngine.RVector3 Rorigin
		{
			get
			{
				if(r_origin == null)
				{
					r_origin = new(this, "origin", -1);
					r_origin.SetBelong(this.instance);
				}
				return r_origin;
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
		/// Single shadowNearPlaneOffset
		/// </summary>
		protected RProperty r_shadowNearPlaneOffset;
		public virtual RProperty RshadowNearPlaneOffset
		{
			get
			{
				if(r_shadowNearPlaneOffset == null)
				{
					r_shadowNearPlaneOffset = new(this, "shadowNearPlaneOffset", -1);
					r_shadowNearPlaneOffset.SetBelong(this.instance);
				}
				return r_shadowNearPlaneOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CullingOptions cullingOptions
		/// </summary>
		protected RProperty r_cullingOptions;
		public virtual RProperty RcullingOptions
		{
			get
			{
				if(r_cullingOptions == null)
				{
					r_cullingOptions = new(this, "cullingOptions", -1);
					r_cullingOptions.SetBelong(this.instance);
				}
				return r_cullingOptions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
		/// </summary>
		protected RProperty r_reflectionProbeSortingCriteria;
		public virtual RProperty RreflectionProbeSortingCriteria
		{
			get
			{
				if(r_reflectionProbeSortingCriteria == null)
				{
					r_reflectionProbeSortingCriteria = new(this, "reflectionProbeSortingCriteria", -1);
					r_reflectionProbeSortingCriteria.SetBelong(this.instance);
				}
				return r_reflectionProbeSortingCriteria;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties cameraProperties
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties r_cameraProperties;
		public virtual RUnityEngine.RRendering.RCameraProperties RcameraProperties
		{
			get
			{
				if(r_cameraProperties == null)
				{
					r_cameraProperties = new(this, "cameraProperties", -1);
					r_cameraProperties.SetBelong(this.instance);
				}
				return r_cameraProperties;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoViewMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_stereoViewMatrix;
		public virtual RUnityEngine.RMatrix4x4 RstereoViewMatrix
		{
			get
			{
				if(r_stereoViewMatrix == null)
				{
					r_stereoViewMatrix = new(this, "stereoViewMatrix", -1);
					r_stereoViewMatrix.SetBelong(this.instance);
				}
				return r_stereoViewMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoProjectionMatrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_stereoProjectionMatrix;
		public virtual RUnityEngine.RMatrix4x4 RstereoProjectionMatrix
		{
			get
			{
				if(r_stereoProjectionMatrix == null)
				{
					r_stereoProjectionMatrix = new(this, "stereoProjectionMatrix", -1);
					r_stereoProjectionMatrix.SetBelong(this.instance);
				}
				return r_stereoProjectionMatrix;
			}
		}

		/// <summary>
		/// Single stereoSeparationDistance
		/// </summary>
		protected RProperty r_stereoSeparationDistance;
		public virtual RProperty RstereoSeparationDistance
		{
			get
			{
				if(r_stereoSeparationDistance == null)
				{
					r_stereoSeparationDistance = new(this, "stereoSeparationDistance", -1);
					r_stereoSeparationDistance.SetBelong(this.instance);
				}
				return r_stereoSeparationDistance;
			}
		}

		/// <summary>
		/// Single accurateOcclusionThreshold
		/// </summary>
		protected RProperty r_accurateOcclusionThreshold;
		public virtual RProperty RaccurateOcclusionThreshold
		{
			get
			{
				if(r_accurateOcclusionThreshold == null)
				{
					r_accurateOcclusionThreshold = new(this, "accurateOcclusionThreshold", -1);
					r_accurateOcclusionThreshold.SetBelong(this.instance);
				}
				return r_accurateOcclusionThreshold;
			}
		}

		/// <summary>
		/// Int32 maximumPortalCullingJobs
		/// </summary>
		protected RProperty r_maximumPortalCullingJobs;
		public virtual RProperty RmaximumPortalCullingJobs
		{
			get
			{
				if(r_maximumPortalCullingJobs == null)
				{
					r_maximumPortalCullingJobs = new(this, "maximumPortalCullingJobs", -1);
					r_maximumPortalCullingJobs.SetBelong(this.instance);
				}
				return r_maximumPortalCullingJobs;
			}
		}

		/// <summary>
		/// Int32 cullingJobsLowerLimit
		/// </summary>
		protected static RProperty r_cullingJobsLowerLimit;
		public static RProperty RcullingJobsLowerLimit
		{
			get
			{
				if(r_cullingJobsLowerLimit == null)
				{
					r_cullingJobsLowerLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "cullingJobsLowerLimit", -1);
					r_cullingJobsLowerLimit.SetBelong(null);
				}
				return r_cullingJobsLowerLimit;
			}
		}

		/// <summary>
		/// Int32 cullingJobsUpperLimit
		/// </summary>
		protected static RProperty r_cullingJobsUpperLimit;
		public static RProperty RcullingJobsUpperLimit
		{
			get
			{
				if(r_cullingJobsUpperLimit == null)
				{
					r_cullingJobsUpperLimit = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "cullingJobsUpperLimit", -1);
					r_cullingJobsUpperLimit.SetBelong(null);
				}
				return r_cullingJobsUpperLimit;
			}
		}

		/// <summary>
		/// Single GetLayerCullingDistance(Int32)
		/// </summary>
		protected RMethod r_GetLayerCullingDistance_Int32;
		public virtual RMethod RGetLayerCullingDistance_Int32
		{
			get
			{
				if(r_GetLayerCullingDistance_Int32 == null)
				{
					r_GetLayerCullingDistance_Int32 = new(this, "GetLayerCullingDistance", 0, typeof(System.Int32));
					r_GetLayerCullingDistance_Int32.SetBelong(this.instance);
				}
				return r_GetLayerCullingDistance_Int32;
			}
		}

		/// <summary>
		/// Void SetLayerCullingDistance(Int32, Single)
		/// </summary>
		protected RMethod r_SetLayerCullingDistance_Int32_Single;
		public virtual RMethod RSetLayerCullingDistance_Int32_Single
		{
			get
			{
				if(r_SetLayerCullingDistance_Int32_Single == null)
				{
					r_SetLayerCullingDistance_Int32_Single = new(this, "SetLayerCullingDistance", 0, typeof(System.Int32), typeof(System.Single));
					r_SetLayerCullingDistance_Int32_Single.SetBelong(this.instance);
				}
				return r_SetLayerCullingDistance_Int32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Plane GetCullingPlane(Int32)
		/// </summary>
		protected RMethod r_GetCullingPlane_Int32;
		public virtual RMethod RGetCullingPlane_Int32
		{
			get
			{
				if(r_GetCullingPlane_Int32 == null)
				{
					r_GetCullingPlane_Int32 = new(this, "GetCullingPlane", 0, typeof(System.Int32));
					r_GetCullingPlane_Int32.SetBelong(this.instance);
				}
				return r_GetCullingPlane_Int32;
			}
		}

		/// <summary>
		/// Void SetCullingPlane(Int32, UnityEngine.Plane)
		/// </summary>
		protected RMethod r_SetCullingPlane_Int32_Plane;
		public virtual RMethod RSetCullingPlane_Int32_Plane
		{
			get
			{
				if(r_SetCullingPlane_Int32_Plane == null)
				{
					r_SetCullingPlane_Int32_Plane = new(this, "SetCullingPlane", 0, typeof(System.Int32), typeof(UnityEngine.Plane));
					r_SetCullingPlane_Int32_Plane.SetBelong(this.instance);
				}
				return r_SetCullingPlane_Int32_Plane;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.ScriptableCullingParameters)
		/// </summary>
		protected RMethod r_Equals_ScriptableCullingParameters;
		public virtual RMethod REquals_ScriptableCullingParameters
		{
			get
			{
				if(r_Equals_ScriptableCullingParameters == null)
				{
					r_Equals_ScriptableCullingParameters = new(this, "Equals", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters));
					r_Equals_ScriptableCullingParameters.SetBelong(this.instance);
				}
				return r_Equals_ScriptableCullingParameters;
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
		/// Boolean op_Equality(UnityEngine.Rendering.ScriptableCullingParameters, UnityEngine.Rendering.ScriptableCullingParameters)
		/// </summary>
		protected static RMethod r_op_Equality_ScriptableCullingParameters_ScriptableCullingParameters;
		public static RMethod Rop_Equality_ScriptableCullingParameters_ScriptableCullingParameters
		{
			get
			{
				if(r_op_Equality_ScriptableCullingParameters_ScriptableCullingParameters == null)
				{
					r_op_Equality_ScriptableCullingParameters_ScriptableCullingParameters = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "op_Equality", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters), typeof(UnityEngine.Rendering.ScriptableCullingParameters));
					r_op_Equality_ScriptableCullingParameters_ScriptableCullingParameters.SetBelong(null);
				}
				return r_op_Equality_ScriptableCullingParameters_ScriptableCullingParameters;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.ScriptableCullingParameters, UnityEngine.Rendering.ScriptableCullingParameters)
		/// </summary>
		protected static RMethod r_op_Inequality_ScriptableCullingParameters_ScriptableCullingParameters;
		public static RMethod Rop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters
		{
			get
			{
				if(r_op_Inequality_ScriptableCullingParameters_ScriptableCullingParameters == null)
				{
					r_op_Inequality_ScriptableCullingParameters_ScriptableCullingParameters = new(typeof(UnityEngine.Rendering.ScriptableCullingParameters), "op_Inequality", 0, typeof(UnityEngine.Rendering.ScriptableCullingParameters), typeof(UnityEngine.Rendering.ScriptableCullingParameters));
					r_op_Inequality_ScriptableCullingParameters_ScriptableCullingParameters.SetBelong(null);
				}
				return r_op_Inequality_ScriptableCullingParameters_ScriptableCullingParameters;
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


        public RScriptableCullingParameters() : base("UnityEngine.Rendering.ScriptableCullingParameters")
        {
        }

        public RScriptableCullingParameters(System.Object instance) : base("UnityEngine.Rendering.ScriptableCullingParameters")
		{
            SetInstance(instance);
		}

        public RScriptableCullingParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScriptableCullingParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Single GetLayerCullingDistance(System.Int32 @layerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layerIndex};
            var ___result = RGetLayerCullingDistance_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void SetLayerCullingDistance(System.Int32 @layerIndex, System.Single @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layerIndex, @distance};
            var ___result = RSetLayerCullingDistance_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Plane GetCullingPlane(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetCullingPlane_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual void SetCullingPlane(System.Int32 @index, UnityEngine.Plane @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @plane};
            var ___result = RSetCullingPlane_Int32_Plane.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.ScriptableCullingParameters @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.ScriptableCullingParameters @left, UnityEngine.Rendering.ScriptableCullingParameters @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_ScriptableCullingParameters_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.ScriptableCullingParameters @left, UnityEngine.Rendering.ScriptableCullingParameters @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_ScriptableCullingParameters_ScriptableCullingParameters.Invoke(___genericsType, ___parameters);

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
