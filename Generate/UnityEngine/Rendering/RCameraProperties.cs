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
		protected static RSystem.RInt32 r_k_NumLayers;
		public static RSystem.RInt32 Rk_NumLayers
		{
			get
			{
				if(r_k_NumLayers == null)
				{
					r_k_NumLayers = new(typeof(UnityEngine.Rendering.CameraProperties), "k_NumLayers");
					r_k_NumLayers.SetBelong(null);
				}
				return r_k_NumLayers;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenRect
		/// </summary>
		protected RUnityEngine.RRect r_screenRect;
		public virtual RUnityEngine.RRect RscreenRect
		{
			get
			{
				if(r_screenRect == null)
				{
					r_screenRect = new(this, "screenRect");
					r_screenRect.SetBelong(this.instance);
				}
				return r_screenRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 viewDir
		/// </summary>
		protected RUnityEngine.RVector3 r_viewDir;
		public virtual RUnityEngine.RVector3 RviewDir
		{
			get
			{
				if(r_viewDir == null)
				{
					r_viewDir = new(this, "viewDir");
					r_viewDir.SetBelong(this.instance);
				}
				return r_viewDir;
			}
		}

		/// <summary>
		/// System.Single projectionNear
		/// </summary>
		protected RSystem.RSingle r_projectionNear;
		public virtual RSystem.RSingle RprojectionNear
		{
			get
			{
				if(r_projectionNear == null)
				{
					r_projectionNear = new(this, "projectionNear");
					r_projectionNear.SetBelong(this.instance);
				}
				return r_projectionNear;
			}
		}

		/// <summary>
		/// System.Single projectionFar
		/// </summary>
		protected RSystem.RSingle r_projectionFar;
		public virtual RSystem.RSingle RprojectionFar
		{
			get
			{
				if(r_projectionFar == null)
				{
					r_projectionFar = new(this, "projectionFar");
					r_projectionFar.SetBelong(this.instance);
				}
				return r_projectionFar;
			}
		}

		/// <summary>
		/// System.Single cameraNear
		/// </summary>
		protected RSystem.RSingle r_cameraNear;
		public virtual RSystem.RSingle RcameraNear
		{
			get
			{
				if(r_cameraNear == null)
				{
					r_cameraNear = new(this, "cameraNear");
					r_cameraNear.SetBelong(this.instance);
				}
				return r_cameraNear;
			}
		}

		/// <summary>
		/// System.Single cameraFar
		/// </summary>
		protected RSystem.RSingle r_cameraFar;
		public virtual RSystem.RSingle RcameraFar
		{
			get
			{
				if(r_cameraFar == null)
				{
					r_cameraFar = new(this, "cameraFar");
					r_cameraFar.SetBelong(this.instance);
				}
				return r_cameraFar;
			}
		}

		/// <summary>
		/// System.Single cameraAspect
		/// </summary>
		protected RSystem.RSingle r_cameraAspect;
		public virtual RSystem.RSingle RcameraAspect
		{
			get
			{
				if(r_cameraAspect == null)
				{
					r_cameraAspect = new(this, "cameraAspect");
					r_cameraAspect.SetBelong(this.instance);
				}
				return r_cameraAspect;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraToWorld
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_cameraToWorld;
		public virtual RUnityEngine.RMatrix4x4 RcameraToWorld
		{
			get
			{
				if(r_cameraToWorld == null)
				{
					r_cameraToWorld = new(this, "cameraToWorld");
					r_cameraToWorld.SetBelong(this.instance);
				}
				return r_cameraToWorld;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 actualWorldToClip
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_actualWorldToClip;
		public virtual RUnityEngine.RMatrix4x4 RactualWorldToClip
		{
			get
			{
				if(r_actualWorldToClip == null)
				{
					r_actualWorldToClip = new(this, "actualWorldToClip");
					r_actualWorldToClip.SetBelong(this.instance);
				}
				return r_actualWorldToClip;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraClipToWorld
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_cameraClipToWorld;
		public virtual RUnityEngine.RMatrix4x4 RcameraClipToWorld
		{
			get
			{
				if(r_cameraClipToWorld == null)
				{
					r_cameraClipToWorld = new(this, "cameraClipToWorld");
					r_cameraClipToWorld.SetBelong(this.instance);
				}
				return r_cameraClipToWorld;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 cameraWorldToClip
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_cameraWorldToClip;
		public virtual RUnityEngine.RMatrix4x4 RcameraWorldToClip
		{
			get
			{
				if(r_cameraWorldToClip == null)
				{
					r_cameraWorldToClip = new(this, "cameraWorldToClip");
					r_cameraWorldToClip.SetBelong(this.instance);
				}
				return r_cameraWorldToClip;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 implicitProjection
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_implicitProjection;
		public virtual RUnityEngine.RMatrix4x4 RimplicitProjection
		{
			get
			{
				if(r_implicitProjection == null)
				{
					r_implicitProjection = new(this, "implicitProjection");
					r_implicitProjection.SetBelong(this.instance);
				}
				return r_implicitProjection;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoWorldToClipLeft
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_stereoWorldToClipLeft;
		public virtual RUnityEngine.RMatrix4x4 RstereoWorldToClipLeft
		{
			get
			{
				if(r_stereoWorldToClipLeft == null)
				{
					r_stereoWorldToClipLeft = new(this, "stereoWorldToClipLeft");
					r_stereoWorldToClipLeft.SetBelong(this.instance);
				}
				return r_stereoWorldToClipLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 stereoWorldToClipRight
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_stereoWorldToClipRight;
		public virtual RUnityEngine.RMatrix4x4 RstereoWorldToClipRight
		{
			get
			{
				if(r_stereoWorldToClipRight == null)
				{
					r_stereoWorldToClipRight = new(this, "stereoWorldToClipRight");
					r_stereoWorldToClipRight.SetBelong(this.instance);
				}
				return r_stereoWorldToClipRight;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldToCamera
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldToCamera;
		public virtual RUnityEngine.RMatrix4x4 RworldToCamera
		{
			get
			{
				if(r_worldToCamera == null)
				{
					r_worldToCamera = new(this, "worldToCamera");
					r_worldToCamera.SetBelong(this.instance);
				}
				return r_worldToCamera;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 up
		/// </summary>
		protected RUnityEngine.RVector3 r_up;
		public virtual RUnityEngine.RVector3 Rup
		{
			get
			{
				if(r_up == null)
				{
					r_up = new(this, "up");
					r_up.SetBelong(this.instance);
				}
				return r_up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 right
		/// </summary>
		protected RUnityEngine.RVector3 r_right;
		public virtual RUnityEngine.RVector3 Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right");
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 transformDirection
		/// </summary>
		protected RUnityEngine.RVector3 r_transformDirection;
		public virtual RUnityEngine.RVector3 RtransformDirection
		{
			get
			{
				if(r_transformDirection == null)
				{
					r_transformDirection = new(this, "transformDirection");
					r_transformDirection.SetBelong(this.instance);
				}
				return r_transformDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 cameraEuler
		/// </summary>
		protected RUnityEngine.RVector3 r_cameraEuler;
		public virtual RUnityEngine.RVector3 RcameraEuler
		{
			get
			{
				if(r_cameraEuler == null)
				{
					r_cameraEuler = new(this, "cameraEuler");
					r_cameraEuler.SetBelong(this.instance);
				}
				return r_cameraEuler;
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
					r_velocity = new(this, "velocity");
					r_velocity.SetBelong(this.instance);
				}
				return r_velocity;
			}
		}

		/// <summary>
		/// System.Single farPlaneWorldSpaceLength
		/// </summary>
		protected RSystem.RSingle r_farPlaneWorldSpaceLength;
		public virtual RSystem.RSingle RfarPlaneWorldSpaceLength
		{
			get
			{
				if(r_farPlaneWorldSpaceLength == null)
				{
					r_farPlaneWorldSpaceLength = new(this, "farPlaneWorldSpaceLength");
					r_farPlaneWorldSpaceLength.SetBelong(this.instance);
				}
				return r_farPlaneWorldSpaceLength;
			}
		}

		/// <summary>
		/// System.UInt32 rendererCount
		/// </summary>
		protected RSystem.RUInt32 r_rendererCount;
		public virtual RSystem.RUInt32 RrendererCount
		{
			get
			{
				if(r_rendererCount == null)
				{
					r_rendererCount = new(this, "rendererCount");
					r_rendererCount.SetBelong(this.instance);
				}
				return r_rendererCount;
			}
		}

		/// <summary>
		/// System.Int32 k_PlaneCount
		/// </summary>
		protected static RSystem.RInt32 r_k_PlaneCount;
		public static RSystem.RInt32 Rk_PlaneCount
		{
			get
			{
				if(r_k_PlaneCount == null)
				{
					r_k_PlaneCount = new(typeof(UnityEngine.Rendering.CameraProperties), "k_PlaneCount");
					r_k_PlaneCount.SetBelong(null);
				}
				return r_k_PlaneCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties+<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties.R__0__m_ShadowCullPlanes__1__e__FixedBuffer r_m_ShadowCullPlanes;
		public virtual RUnityEngine.RRendering.RCameraProperties.R__0__m_ShadowCullPlanes__1__e__FixedBuffer Rm_ShadowCullPlanes
		{
			get
			{
				if(r_m_ShadowCullPlanes == null)
				{
					r_m_ShadowCullPlanes = new(this, "m_ShadowCullPlanes");
					r_m_ShadowCullPlanes.SetBelong(this.instance);
				}
				return r_m_ShadowCullPlanes;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties+<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties.R__0__m_CameraCullPlanes__1__e__FixedBuffer r_m_CameraCullPlanes;
		public virtual RUnityEngine.RRendering.RCameraProperties.R__0__m_CameraCullPlanes__1__e__FixedBuffer Rm_CameraCullPlanes
		{
			get
			{
				if(r_m_CameraCullPlanes == null)
				{
					r_m_CameraCullPlanes = new(this, "m_CameraCullPlanes");
					r_m_CameraCullPlanes.SetBelong(this.instance);
				}
				return r_m_CameraCullPlanes;
			}
		}

		/// <summary>
		/// System.Single baseFarDistance
		/// </summary>
		protected RSystem.RSingle r_baseFarDistance;
		public virtual RSystem.RSingle RbaseFarDistance
		{
			get
			{
				if(r_baseFarDistance == null)
				{
					r_baseFarDistance = new(this, "baseFarDistance");
					r_baseFarDistance.SetBelong(this.instance);
				}
				return r_baseFarDistance;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 shadowCullCenter
		/// </summary>
		protected RUnityEngine.RVector3 r_shadowCullCenter;
		public virtual RUnityEngine.RVector3 RshadowCullCenter
		{
			get
			{
				if(r_shadowCullCenter == null)
				{
					r_shadowCullCenter = new(this, "shadowCullCenter");
					r_shadowCullCenter.SetBelong(this.instance);
				}
				return r_shadowCullCenter;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraProperties+<layerCullDistances>e__FixedBuffer layerCullDistances
		/// </summary>
		protected RUnityEngine.RRendering.RCameraProperties.R__0__layerCullDistances__1__e__FixedBuffer r_layerCullDistances;
		public virtual RUnityEngine.RRendering.RCameraProperties.R__0__layerCullDistances__1__e__FixedBuffer RlayerCullDistances
		{
			get
			{
				if(r_layerCullDistances == null)
				{
					r_layerCullDistances = new(this, "layerCullDistances");
					r_layerCullDistances.SetBelong(this.instance);
				}
				return r_layerCullDistances;
			}
		}

		/// <summary>
		/// System.Int32 layerCullSpherical
		/// </summary>
		protected RSystem.RInt32 r_layerCullSpherical;
		public virtual RSystem.RInt32 RlayerCullSpherical
		{
			get
			{
				if(r_layerCullSpherical == null)
				{
					r_layerCullSpherical = new(this, "layerCullSpherical");
					r_layerCullSpherical.SetBelong(this.instance);
				}
				return r_layerCullSpherical;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CoreCameraValues coreCameraValues
		/// </summary>
		protected RUnityEngine.RRendering.RCoreCameraValues r_coreCameraValues;
		public virtual RUnityEngine.RRendering.RCoreCameraValues RcoreCameraValues
		{
			get
			{
				if(r_coreCameraValues == null)
				{
					r_coreCameraValues = new(this, "coreCameraValues");
					r_coreCameraValues.SetBelong(this.instance);
				}
				return r_coreCameraValues;
			}
		}

		/// <summary>
		/// System.UInt32 cameraType
		/// </summary>
		protected RSystem.RUInt32 r_cameraType;
		public virtual RSystem.RUInt32 RcameraType
		{
			get
			{
				if(r_cameraType == null)
				{
					r_cameraType = new(this, "cameraType");
					r_cameraType.SetBelong(this.instance);
				}
				return r_cameraType;
			}
		}

		/// <summary>
		/// System.Int32 projectionIsOblique
		/// </summary>
		protected RSystem.RInt32 r_projectionIsOblique;
		public virtual RSystem.RInt32 RprojectionIsOblique
		{
			get
			{
				if(r_projectionIsOblique == null)
				{
					r_projectionIsOblique = new(this, "projectionIsOblique");
					r_projectionIsOblique.SetBelong(this.instance);
				}
				return r_projectionIsOblique;
			}
		}

		/// <summary>
		/// System.Int32 isImplicitProjectionMatrix
		/// </summary>
		protected RSystem.RInt32 r_isImplicitProjectionMatrix;
		public virtual RSystem.RInt32 RisImplicitProjectionMatrix
		{
			get
			{
				if(r_isImplicitProjectionMatrix == null)
				{
					r_isImplicitProjectionMatrix = new(this, "isImplicitProjectionMatrix");
					r_isImplicitProjectionMatrix.SetBelong(this.instance);
				}
				return r_isImplicitProjectionMatrix;
			}
		}

		/// <summary>
		/// UnityEngine.Plane GetShadowCullingPlane(Int32)
		/// </summary>
		protected RMethod r_GetShadowCullingPlane_Int32;
		public virtual RMethod RGetShadowCullingPlane_Int32
		{
			get
			{
				if(r_GetShadowCullingPlane_Int32 == null)
				{
					r_GetShadowCullingPlane_Int32 = new(this, "GetShadowCullingPlane", 0, typeof(System.Int32));
					r_GetShadowCullingPlane_Int32.SetBelong(this.instance);
				}
				return r_GetShadowCullingPlane_Int32;
			}
		}

		/// <summary>
		/// Void SetShadowCullingPlane(Int32, UnityEngine.Plane)
		/// </summary>
		protected RMethod r_SetShadowCullingPlane_Int32_Plane;
		public virtual RMethod RSetShadowCullingPlane_Int32_Plane
		{
			get
			{
				if(r_SetShadowCullingPlane_Int32_Plane == null)
				{
					r_SetShadowCullingPlane_Int32_Plane = new(this, "SetShadowCullingPlane", 0, typeof(System.Int32), typeof(UnityEngine.Plane));
					r_SetShadowCullingPlane_Int32_Plane.SetBelong(this.instance);
				}
				return r_SetShadowCullingPlane_Int32_Plane;
			}
		}

		/// <summary>
		/// UnityEngine.Plane GetCameraCullingPlane(Int32)
		/// </summary>
		protected RMethod r_GetCameraCullingPlane_Int32;
		public virtual RMethod RGetCameraCullingPlane_Int32
		{
			get
			{
				if(r_GetCameraCullingPlane_Int32 == null)
				{
					r_GetCameraCullingPlane_Int32 = new(this, "GetCameraCullingPlane", 0, typeof(System.Int32));
					r_GetCameraCullingPlane_Int32.SetBelong(this.instance);
				}
				return r_GetCameraCullingPlane_Int32;
			}
		}

		/// <summary>
		/// Void SetCameraCullingPlane(Int32, UnityEngine.Plane)
		/// </summary>
		protected RMethod r_SetCameraCullingPlane_Int32_Plane;
		public virtual RMethod RSetCameraCullingPlane_Int32_Plane
		{
			get
			{
				if(r_SetCameraCullingPlane_Int32_Plane == null)
				{
					r_SetCameraCullingPlane_Int32_Plane = new(this, "SetCameraCullingPlane", 0, typeof(System.Int32), typeof(UnityEngine.Plane));
					r_SetCameraCullingPlane_Int32_Plane.SetBelong(this.instance);
				}
				return r_SetCameraCullingPlane_Int32_Plane;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.CameraProperties)
		/// </summary>
		protected RMethod r_Equals_CameraProperties;
		public virtual RMethod REquals_CameraProperties
		{
			get
			{
				if(r_Equals_CameraProperties == null)
				{
					r_Equals_CameraProperties = new(this, "Equals", 0, typeof(UnityEngine.Rendering.CameraProperties));
					r_Equals_CameraProperties.SetBelong(this.instance);
				}
				return r_Equals_CameraProperties;
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
		/// Boolean op_Equality(UnityEngine.Rendering.CameraProperties, UnityEngine.Rendering.CameraProperties)
		/// </summary>
		protected static RMethod r_op_Equality_CameraProperties_CameraProperties;
		public static RMethod Rop_Equality_CameraProperties_CameraProperties
		{
			get
			{
				if(r_op_Equality_CameraProperties_CameraProperties == null)
				{
					r_op_Equality_CameraProperties_CameraProperties = new(typeof(UnityEngine.Rendering.CameraProperties), "op_Equality", 0, typeof(UnityEngine.Rendering.CameraProperties), typeof(UnityEngine.Rendering.CameraProperties));
					r_op_Equality_CameraProperties_CameraProperties.SetBelong(null);
				}
				return r_op_Equality_CameraProperties_CameraProperties;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.CameraProperties, UnityEngine.Rendering.CameraProperties)
		/// </summary>
		protected static RMethod r_op_Inequality_CameraProperties_CameraProperties;
		public static RMethod Rop_Inequality_CameraProperties_CameraProperties
		{
			get
			{
				if(r_op_Inequality_CameraProperties_CameraProperties == null)
				{
					r_op_Inequality_CameraProperties_CameraProperties = new(typeof(UnityEngine.Rendering.CameraProperties), "op_Inequality", 0, typeof(UnityEngine.Rendering.CameraProperties), typeof(UnityEngine.Rendering.CameraProperties));
					r_op_Inequality_CameraProperties_CameraProperties.SetBelong(null);
				}
				return r_op_Inequality_CameraProperties_CameraProperties;
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
            var ___result = RGetShadowCullingPlane_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual void SetShadowCullingPlane(System.Int32 @index, UnityEngine.Plane @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @plane};
            var ___result = RSetShadowCullingPlane_Int32_Plane.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Plane GetCameraCullingPlane(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetCameraCullingPlane_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual void SetCameraCullingPlane(System.Int32 @index, UnityEngine.Plane @plane)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @plane};
            var ___result = RSetCameraCullingPlane_Int32_Plane.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.CameraProperties @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_CameraProperties.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean op_Equality(UnityEngine.Rendering.CameraProperties @left, UnityEngine.Rendering.CameraProperties @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_CameraProperties_CameraProperties.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.CameraProperties @left, UnityEngine.Rendering.CameraProperties @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_CameraProperties_CameraProperties.Invoke(___genericsType, ___parameters);

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
