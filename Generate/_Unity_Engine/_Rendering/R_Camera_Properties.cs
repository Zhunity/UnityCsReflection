
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.CameraProperties
	/// </summary>
    public partial class RCameraProperties : RMember //
    {

		/// <summary>
		/// System.Int32 k_NumLayers
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fk_NumLayers;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFk_NumLayers
		{
			get
			{
				if(r_Fk_NumLayers == null)
				{
					r_Fk_NumLayers = new(typeof(UnityEngine.Rendering.CameraProperties), "k_NumLayers");
					r_Fk_NumLayers.SetBelong(null);
				}
				return r_Fk_NumLayers;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenRect
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRect r_FscreenRect;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRect RFscreenRect
		{
			get
			{
				if(r_FscreenRect == null)
				{
					r_FscreenRect = new(this, "screenRect");
					r_FscreenRect.SetBelong(this.instance);
				}
				return r_FscreenRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 viewDir
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_FviewDir;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFviewDir
		{
			get
			{
				if(r_FviewDir == null)
				{
					r_FviewDir = new(this, "viewDir");
					r_FviewDir.SetBelong(this.instance);
				}
				return r_FviewDir;
			}
		}

		/// <summary>
		/// System.Single projectionNear
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FprojectionNear;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFprojectionNear
		{
			get
			{
				if(r_FprojectionNear == null)
				{
					r_FprojectionNear = new(this, "projectionNear");
					r_FprojectionNear.SetBelong(this.instance);
				}
				return r_FprojectionNear;
			}
		}

		/// <summary>
		/// System.Single projectionFar
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FprojectionFar;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFprojectionFar
		{
			get
			{
				if(r_FprojectionFar == null)
				{
					r_FprojectionFar = new(this, "projectionFar");
					r_FprojectionFar.SetBelong(this.instance);
				}
				return r_FprojectionFar;
			}
		}

		/// <summary>
		/// System.Single cameraNear
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FcameraNear;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFcameraNear
		{
			get
			{
				if(r_FcameraNear == null)
				{
					r_FcameraNear = new(this, "cameraNear");
					r_FcameraNear.SetBelong(this.instance);
				}
				return r_FcameraNear;
			}
		}

		/// <summary>
		/// System.Single cameraFar
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FcameraFar;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFcameraFar
		{
			get
			{
				if(r_FcameraFar == null)
				{
					r_FcameraFar = new(this, "cameraFar");
					r_FcameraFar.SetBelong(this.instance);
				}
				return r_FcameraFar;
			}
		}

		/// <summary>
		/// System.Single cameraAspect
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FcameraAspect;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFcameraAspect
		{
			get
			{
				if(r_FcameraAspect == null)
				{
					r_FcameraAspect = new(this, "cameraAspect");
					r_FcameraAspect.SetBelong(this.instance);
				}
				return r_FcameraAspect;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraToWorld
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FcameraToWorld;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFcameraToWorld
		{
			get
			{
				if(r_FcameraToWorld == null)
				{
					r_FcameraToWorld = new(this, "cameraToWorld");
					r_FcameraToWorld.SetBelong(this.instance);
				}
				return r_FcameraToWorld;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 actualWorldToClip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FactualWorldToClip;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFactualWorldToClip
		{
			get
			{
				if(r_FactualWorldToClip == null)
				{
					r_FactualWorldToClip = new(this, "actualWorldToClip");
					r_FactualWorldToClip.SetBelong(this.instance);
				}
				return r_FactualWorldToClip;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraClipToWorld
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FcameraClipToWorld;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFcameraClipToWorld
		{
			get
			{
				if(r_FcameraClipToWorld == null)
				{
					r_FcameraClipToWorld = new(this, "cameraClipToWorld");
					r_FcameraClipToWorld.SetBelong(this.instance);
				}
				return r_FcameraClipToWorld;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraWorldToClip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FcameraWorldToClip;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFcameraWorldToClip
		{
			get
			{
				if(r_FcameraWorldToClip == null)
				{
					r_FcameraWorldToClip = new(this, "cameraWorldToClip");
					r_FcameraWorldToClip.SetBelong(this.instance);
				}
				return r_FcameraWorldToClip;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 implicitProjection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FimplicitProjection;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFimplicitProjection
		{
			get
			{
				if(r_FimplicitProjection == null)
				{
					r_FimplicitProjection = new(this, "implicitProjection");
					r_FimplicitProjection.SetBelong(this.instance);
				}
				return r_FimplicitProjection;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoWorldToClipLeft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FstereoWorldToClipLeft;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFstereoWorldToClipLeft
		{
			get
			{
				if(r_FstereoWorldToClipLeft == null)
				{
					r_FstereoWorldToClipLeft = new(this, "stereoWorldToClipLeft");
					r_FstereoWorldToClipLeft.SetBelong(this.instance);
				}
				return r_FstereoWorldToClipLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoWorldToClipRight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FstereoWorldToClipRight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFstereoWorldToClipRight
		{
			get
			{
				if(r_FstereoWorldToClipRight == null)
				{
					r_FstereoWorldToClipRight = new(this, "stereoWorldToClipRight");
					r_FstereoWorldToClipRight.SetBelong(this.instance);
				}
				return r_FstereoWorldToClipRight;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldToCamera
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FworldToCamera;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFworldToCamera
		{
			get
			{
				if(r_FworldToCamera == null)
				{
					r_FworldToCamera = new(this, "worldToCamera");
					r_FworldToCamera.SetBelong(this.instance);
				}
				return r_FworldToCamera;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 up
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_Fup;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFup
		{
			get
			{
				if(r_Fup == null)
				{
					r_Fup = new(this, "up");
					r_Fup.SetBelong(this.instance);
				}
				return r_Fup;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 right
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_Fright;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFright
		{
			get
			{
				if(r_Fright == null)
				{
					r_Fright = new(this, "right");
					r_Fright.SetBelong(this.instance);
				}
				return r_Fright;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 transformDirection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_FtransformDirection;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFtransformDirection
		{
			get
			{
				if(r_FtransformDirection == null)
				{
					r_FtransformDirection = new(this, "transformDirection");
					r_FtransformDirection.SetBelong(this.instance);
				}
				return r_FtransformDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 cameraEuler
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_FcameraEuler;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFcameraEuler
		{
			get
			{
				if(r_FcameraEuler == null)
				{
					r_FcameraEuler = new(this, "cameraEuler");
					r_FcameraEuler.SetBelong(this.instance);
				}
				return r_FcameraEuler;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 velocity
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_Fvelocity;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFvelocity
		{
			get
			{
				if(r_Fvelocity == null)
				{
					r_Fvelocity = new(this, "velocity");
					r_Fvelocity.SetBelong(this.instance);
				}
				return r_Fvelocity;
			}
		}

		/// <summary>
		/// System.Single farPlaneWorldSpaceLength
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FfarPlaneWorldSpaceLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFfarPlaneWorldSpaceLength
		{
			get
			{
				if(r_FfarPlaneWorldSpaceLength == null)
				{
					r_FfarPlaneWorldSpaceLength = new(this, "farPlaneWorldSpaceLength");
					r_FfarPlaneWorldSpaceLength.SetBelong(this.instance);
				}
				return r_FfarPlaneWorldSpaceLength;
			}
		}

		/// <summary>
		/// System.UInt32 rendererCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FrendererCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFrendererCount
		{
			get
			{
				if(r_FrendererCount == null)
				{
					r_FrendererCount = new(this, "rendererCount");
					r_FrendererCount.SetBelong(this.instance);
				}
				return r_FrendererCount;
			}
		}

		/// <summary>
		/// System.Int32 k_PlaneCount
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fk_PlaneCount;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFk_PlaneCount
		{
			get
			{
				if(r_Fk_PlaneCount == null)
				{
					r_Fk_PlaneCount = new(typeof(UnityEngine.Rendering.CameraProperties), "k_PlaneCount");
					r_Fk_PlaneCount.SetBelong(null);
				}
				return r_Fk_PlaneCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties+<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCameraProperties.R__0__m_ShadowCullPlanes__1__e__FixedBuffer r_Fm_ShadowCullPlanes;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCameraProperties.R__0__m_ShadowCullPlanes__1__e__FixedBuffer RFm_ShadowCullPlanes
		{
			get
			{
				if(r_Fm_ShadowCullPlanes == null)
				{
					r_Fm_ShadowCullPlanes = new(this, "m_ShadowCullPlanes");
					r_Fm_ShadowCullPlanes.SetBelong(this.instance);
				}
				return r_Fm_ShadowCullPlanes;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties+<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCameraProperties.R__0__m_CameraCullPlanes__1__e__FixedBuffer r_Fm_CameraCullPlanes;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCameraProperties.R__0__m_CameraCullPlanes__1__e__FixedBuffer RFm_CameraCullPlanes
		{
			get
			{
				if(r_Fm_CameraCullPlanes == null)
				{
					r_Fm_CameraCullPlanes = new(this, "m_CameraCullPlanes");
					r_Fm_CameraCullPlanes.SetBelong(this.instance);
				}
				return r_Fm_CameraCullPlanes;
			}
		}

		/// <summary>
		/// System.Single baseFarDistance
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FbaseFarDistance;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFbaseFarDistance
		{
			get
			{
				if(r_FbaseFarDistance == null)
				{
					r_FbaseFarDistance = new(this, "baseFarDistance");
					r_FbaseFarDistance.SetBelong(this.instance);
				}
				return r_FbaseFarDistance;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 shadowCullCenter
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_FshadowCullCenter;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFshadowCullCenter
		{
			get
			{
				if(r_FshadowCullCenter == null)
				{
					r_FshadowCullCenter = new(this, "shadowCullCenter");
					r_FshadowCullCenter.SetBelong(this.instance);
				}
				return r_FshadowCullCenter;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties+<layerCullDistances>e__FixedBuffer layerCullDistances
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCameraProperties.R__0__layerCullDistances__1__e__FixedBuffer r_FlayerCullDistances;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCameraProperties.R__0__layerCullDistances__1__e__FixedBuffer RFlayerCullDistances
		{
			get
			{
				if(r_FlayerCullDistances == null)
				{
					r_FlayerCullDistances = new(this, "layerCullDistances");
					r_FlayerCullDistances.SetBelong(this.instance);
				}
				return r_FlayerCullDistances;
			}
		}

		/// <summary>
		/// System.Int32 layerCullSpherical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FlayerCullSpherical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFlayerCullSpherical
		{
			get
			{
				if(r_FlayerCullSpherical == null)
				{
					r_FlayerCullSpherical = new(this, "layerCullSpherical");
					r_FlayerCullSpherical.SetBelong(this.instance);
				}
				return r_FlayerCullSpherical;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CoreCameraValues coreCameraValues
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues r_FcoreCameraValues;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues RFcoreCameraValues
		{
			get
			{
				if(r_FcoreCameraValues == null)
				{
					r_FcoreCameraValues = new(this, "coreCameraValues");
					r_FcoreCameraValues.SetBelong(this.instance);
				}
				return r_FcoreCameraValues;
			}
		}

		/// <summary>
		/// System.UInt32 cameraType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FcameraType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFcameraType
		{
			get
			{
				if(r_FcameraType == null)
				{
					r_FcameraType = new(this, "cameraType");
					r_FcameraType.SetBelong(this.instance);
				}
				return r_FcameraType;
			}
		}

		/// <summary>
		/// System.Int32 projectionIsOblique
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FprojectionIsOblique;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFprojectionIsOblique
		{
			get
			{
				if(r_FprojectionIsOblique == null)
				{
					r_FprojectionIsOblique = new(this, "projectionIsOblique");
					r_FprojectionIsOblique.SetBelong(this.instance);
				}
				return r_FprojectionIsOblique;
			}
		}

		/// <summary>
		/// System.Int32 isImplicitProjectionMatrix
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FisImplicitProjectionMatrix;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFisImplicitProjectionMatrix
		{
			get
			{
				if(r_FisImplicitProjectionMatrix == null)
				{
					r_FisImplicitProjectionMatrix = new(this, "isImplicitProjectionMatrix");
					r_FisImplicitProjectionMatrix.SetBelong(this.instance);
				}
				return r_FisImplicitProjectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Plane GetShadowCullingPlane(Int32)
		/// </summary>
		protected RMethod r_MGetShadowCullingPlane_Int32;
		public virtual RMethod RMGetShadowCullingPlane_Int32
		{
			get
			{
				if(r_MGetShadowCullingPlane_Int32 == null)
				{
					r_MGetShadowCullingPlane_Int32 = new(this, "GetShadowCullingPlane", 0, typeof(System.Int32));
					r_MGetShadowCullingPlane_Int32.SetBelong(this.instance);
				}
				return r_MGetShadowCullingPlane_Int32;
			}
		}

		/// <summary>
		/// Void SetShadowCullingPlane(Int32, UnityEngine.Plane)
		/// </summary>
		protected RMethod r_MSetShadowCullingPlane_Int32_Plane;
		public virtual RMethod RMSetShadowCullingPlane_Int32_Plane
		{
			get
			{
				if(r_MSetShadowCullingPlane_Int32_Plane == null)
				{
					r_MSetShadowCullingPlane_Int32_Plane = new(this, "SetShadowCullingPlane", 0, typeof(System.Int32), typeof(UnityEngine.Plane));
					r_MSetShadowCullingPlane_Int32_Plane.SetBelong(this.instance);
				}
				return r_MSetShadowCullingPlane_Int32_Plane;
			}
		}

		/// <summary>
		/// UnityEngine.Plane GetCameraCullingPlane(Int32)
		/// </summary>
		protected RMethod r_MGetCameraCullingPlane_Int32;
		public virtual RMethod RMGetCameraCullingPlane_Int32
		{
			get
			{
				if(r_MGetCameraCullingPlane_Int32 == null)
				{
					r_MGetCameraCullingPlane_Int32 = new(this, "GetCameraCullingPlane", 0, typeof(System.Int32));
					r_MGetCameraCullingPlane_Int32.SetBelong(this.instance);
				}
				return r_MGetCameraCullingPlane_Int32;
			}
		}

		/// <summary>
		/// Void SetCameraCullingPlane(Int32, UnityEngine.Plane)
		/// </summary>
		protected RMethod r_MSetCameraCullingPlane_Int32_Plane;
		public virtual RMethod RMSetCameraCullingPlane_Int32_Plane
		{
			get
			{
				if(r_MSetCameraCullingPlane_Int32_Plane == null)
				{
					r_MSetCameraCullingPlane_Int32_Plane = new(this, "SetCameraCullingPlane", 0, typeof(System.Int32), typeof(UnityEngine.Plane));
					r_MSetCameraCullingPlane_Int32_Plane.SetBelong(this.instance);
				}
				return r_MSetCameraCullingPlane_Int32_Plane;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.CameraProperties)
		/// </summary>
		protected RMethod r_MEquals_CameraProperties;
		public virtual RMethod RMEquals_CameraProperties
		{
			get
			{
				if(r_MEquals_CameraProperties == null)
				{
					r_MEquals_CameraProperties = new(this, "Equals", 0, typeof(UnityEngine.Rendering.CameraProperties));
					r_MEquals_CameraProperties.SetBelong(this.instance);
				}
				return r_MEquals_CameraProperties;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.CameraProperties, UnityEngine.Rendering.CameraProperties)
		/// </summary>
		protected static RMethod r_Mop_Equality_CameraProperties_CameraProperties;
		public static RMethod RMop_Equality_CameraProperties_CameraProperties
		{
			get
			{
				if(r_Mop_Equality_CameraProperties_CameraProperties == null)
				{
					r_Mop_Equality_CameraProperties_CameraProperties = new(typeof(UnityEngine.Rendering.CameraProperties), "op_Equality", 0, typeof(UnityEngine.Rendering.CameraProperties), typeof(UnityEngine.Rendering.CameraProperties));
					r_Mop_Equality_CameraProperties_CameraProperties.SetBelong(null);
				}
				return r_Mop_Equality_CameraProperties_CameraProperties;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.CameraProperties, UnityEngine.Rendering.CameraProperties)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CameraProperties_CameraProperties;
		public static RMethod RMop_Inequality_CameraProperties_CameraProperties
		{
			get
			{
				if(r_Mop_Inequality_CameraProperties_CameraProperties == null)
				{
					r_Mop_Inequality_CameraProperties_CameraProperties = new(typeof(UnityEngine.Rendering.CameraProperties), "op_Inequality", 0, typeof(UnityEngine.Rendering.CameraProperties), typeof(UnityEngine.Rendering.CameraProperties));
					r_Mop_Inequality_CameraProperties_CameraProperties.SetBelong(null);
				}
				return r_Mop_Inequality_CameraProperties_CameraProperties;
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RCameraProperties() : base("UnityEngine.Rendering.CameraProperties")
        {
        }

        public RCameraProperties(System.Object instance) : base("UnityEngine.Rendering.CameraProperties")
		{
            SetInstance(instance);
		}

        public RCameraProperties(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCameraProperties(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Plane GetShadowCullingPlane(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetShadowCullingPlane_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual void SetShadowCullingPlane(System.Int32 @index, UnityEngine.Plane @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @plane};
            var ___result = RMSetShadowCullingPlane_Int32_Plane.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Plane GetCameraCullingPlane(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetCameraCullingPlane_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual void SetCameraCullingPlane(System.Int32 @index, UnityEngine.Plane @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @plane};
            var ___result = RMSetCameraCullingPlane_Int32_Plane.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.CameraProperties @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_CameraProperties.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.CameraProperties @left, UnityEngine.Rendering.CameraProperties @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_CameraProperties_CameraProperties.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.CameraProperties @left, UnityEngine.Rendering.CameraProperties @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_CameraProperties_CameraProperties.Invoke(___genericsType, ___parameters);

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