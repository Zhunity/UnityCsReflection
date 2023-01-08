using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure
	/// </summary>
    public partial class RRayTracingAccelerationStructure : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// IntPtr Create(RASSettings)
		/// </summary>
		protected static RMethod r_Create_RASSettings;
		public static RMethod RCreate_RASSettings
		{
			get
			{
				if(r_Create_RASSettings == null)
				{
					r_Create_RASSettings = new(typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), "Create", 0,  ReleactionUtils.GetType("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings"));
					r_Create_RASSettings.SetBelong(null);
				}
				return r_Create_RASSettings;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected static RMethod r_Destroy_RayTracingAccelerationStructure;
		public static RMethod RDestroy_RayTracingAccelerationStructure
		{
			get
			{
				if(r_Destroy_RayTracingAccelerationStructure == null)
				{
					r_Destroy_RayTracingAccelerationStructure = new(typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), "Destroy", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_Destroy_RayTracingAccelerationStructure.SetBelong(null);
				}
				return r_Destroy_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_Release;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_Release == null)
				{
					r_Release = new(this, "Release", 0);
					r_Release.SetBelong(this.instance);
				}
				return r_Release;
			}
		}

		/// <summary>
		/// Void Build()
		/// </summary>
		protected RMethod r_Build;
		public virtual RMethod RBuild
		{
			get
			{
				if(r_Build == null)
				{
					r_Build = new(this, "Build", 0);
					r_Build.SetBelong(this.instance);
				}
				return r_Build;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.Renderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[], Boolean, Boolean, UInt32, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
		public virtual RMethod RAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32
		{
			get
			{
				if(r_AddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 == null)
				{
					r_AddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.UInt32));
					r_AddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 AddInstance(UnityEngine.GraphicsBuffer, UInt32, Boolean, UnityEngine.Matrix4x4, UnityEngine.Material, Boolean, UnityEngine.MaterialPropertyBlock, UInt32, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
		public virtual RMethod RAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32
		{
			get
			{
				if(r_AddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 == null)
				{
					r_AddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(System.Boolean), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.UInt32), typeof(System.UInt32));
					r_AddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void RemoveInstance(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_RemoveInstance_Renderer;
		public virtual RMethod RRemoveInstance_Renderer
		{
			get
			{
				if(r_RemoveInstance_Renderer == null)
				{
					r_RemoveInstance_Renderer = new(this, "RemoveInstance", 0, typeof(UnityEngine.Renderer));
					r_RemoveInstance_Renderer.SetBelong(this.instance);
				}
				return r_RemoveInstance_Renderer;
			}
		}

		/// <summary>
		/// Void RemoveInstance(Int32)
		/// </summary>
		protected RMethod r_RemoveInstance_Int32;
		public virtual RMethod RRemoveInstance_Int32
		{
			get
			{
				if(r_RemoveInstance_Int32 == null)
				{
					r_RemoveInstance_Int32 = new(this, "RemoveInstance", 0, typeof(System.Int32));
					r_RemoveInstance_Int32.SetBelong(this.instance);
				}
				return r_RemoveInstance_Int32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_UpdateInstanceTransform_Renderer;
		public virtual RMethod RUpdateInstanceTransform_Renderer
		{
			get
			{
				if(r_UpdateInstanceTransform_Renderer == null)
				{
					r_UpdateInstanceTransform_Renderer = new(this, "UpdateInstanceTransform", 0, typeof(UnityEngine.Renderer));
					r_UpdateInstanceTransform_Renderer.SetBelong(this.instance);
				}
				return r_UpdateInstanceTransform_Renderer;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_UpdateInstanceTransform_Int32_Matrix4x4;
		public virtual RMethod RUpdateInstanceTransform_Int32_Matrix4x4
		{
			get
			{
				if(r_UpdateInstanceTransform_Int32_Matrix4x4 == null)
				{
					r_UpdateInstanceTransform_Int32_Matrix4x4 = new(this, "UpdateInstanceTransform", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_UpdateInstanceTransform_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_UpdateInstanceTransform_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_Update;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_Update == null)
				{
					r_Update = new(this, "Update", 0);
					r_Update.SetBelong(this.instance);
				}
				return r_Update;
			}
		}

		/// <summary>
		/// Void Update(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_Update_Vector3;
		public virtual RMethod RUpdate_Vector3
		{
			get
			{
				if(r_Update_Vector3 == null)
				{
					r_Update_Vector3 = new(this, "Update", 0, typeof(UnityEngine.Vector3));
					r_Update_Vector3.SetBelong(this.instance);
				}
				return r_Update_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.Renderer, Boolean[], Boolean[], Boolean, Boolean, UInt32, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32;
		public virtual RMethod RAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32
		{
			get
			{
				if(r_AddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32 == null)
				{
					r_AddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.Renderer), typeof(System.Boolean).MakeArrayType(), typeof(System.Boolean).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.UInt32));
					r_AddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_AddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_AddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_AddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_AddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_AddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_AddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Void Build(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_Build_Vector3;
		public virtual RMethod RBuild_Vector3
		{
			get
			{
				if(r_Build_Vector3 == null)
				{
					r_Build_Vector3 = new(this, "Build", 0, typeof(UnityEngine.Vector3));
					r_Build_Vector3.SetBelong(this.instance);
				}
				return r_Build_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance_Procedural_Deprecated(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_AddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_AddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance_Procedural_Deprecated", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_AddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Int32 AddInstance_Procedural(UnityEngine.GraphicsBuffer, UInt32, Boolean, UnityEngine.Matrix4x4, UnityEngine.Material, Boolean, UnityEngine.MaterialPropertyBlock, UInt32, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
		public virtual RMethod RAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32
		{
			get
			{
				if(r_AddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 == null)
				{
					r_AddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 = new(this, "AddInstance_Procedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(System.Boolean), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.UInt32), typeof(System.UInt32));
					r_AddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void RemoveInstance_Renderer(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_RemoveInstance_Renderer_Renderer;
		public virtual RMethod RRemoveInstance_Renderer_Renderer
		{
			get
			{
				if(r_RemoveInstance_Renderer_Renderer == null)
				{
					r_RemoveInstance_Renderer_Renderer = new(this, "RemoveInstance_Renderer", 0, typeof(UnityEngine.Renderer));
					r_RemoveInstance_Renderer_Renderer.SetBelong(this.instance);
				}
				return r_RemoveInstance_Renderer_Renderer;
			}
		}

		/// <summary>
		/// Void RemoveInstance_InstanceID(Int32)
		/// </summary>
		protected RMethod r_RemoveInstance_InstanceID_Int32;
		public virtual RMethod RRemoveInstance_InstanceID_Int32
		{
			get
			{
				if(r_RemoveInstance_InstanceID_Int32 == null)
				{
					r_RemoveInstance_InstanceID_Int32 = new(this, "RemoveInstance_InstanceID", 0, typeof(System.Int32));
					r_RemoveInstance_InstanceID_Int32.SetBelong(this.instance);
				}
				return r_RemoveInstance_InstanceID_Int32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform_Renderer(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_UpdateInstanceTransform_Renderer_Renderer;
		public virtual RMethod RUpdateInstanceTransform_Renderer_Renderer
		{
			get
			{
				if(r_UpdateInstanceTransform_Renderer_Renderer == null)
				{
					r_UpdateInstanceTransform_Renderer_Renderer = new(this, "UpdateInstanceTransform_Renderer", 0, typeof(UnityEngine.Renderer));
					r_UpdateInstanceTransform_Renderer_Renderer.SetBelong(this.instance);
				}
				return r_UpdateInstanceTransform_Renderer_Renderer;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform_InstanceID(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_UpdateInstanceTransform_InstanceID_Int32_Matrix4x4;
		public virtual RMethod RUpdateInstanceTransform_InstanceID_Int32_Matrix4x4
		{
			get
			{
				if(r_UpdateInstanceTransform_InstanceID_Int32_Matrix4x4 == null)
				{
					r_UpdateInstanceTransform_InstanceID_Int32_Matrix4x4 = new(this, "UpdateInstanceTransform_InstanceID", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_UpdateInstanceTransform_InstanceID_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_UpdateInstanceTransform_InstanceID_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void UpdateInstanceMask(UnityEngine.Renderer, UInt32)
		/// </summary>
		protected RMethod r_UpdateInstanceMask_Renderer_UInt32;
		public virtual RMethod RUpdateInstanceMask_Renderer_UInt32
		{
			get
			{
				if(r_UpdateInstanceMask_Renderer_UInt32 == null)
				{
					r_UpdateInstanceMask_Renderer_UInt32 = new(this, "UpdateInstanceMask", 0, typeof(UnityEngine.Renderer), typeof(System.UInt32));
					r_UpdateInstanceMask_Renderer_UInt32.SetBelong(this.instance);
				}
				return r_UpdateInstanceMask_Renderer_UInt32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceID(UnityEngine.Renderer, UInt32)
		/// </summary>
		protected RMethod r_UpdateInstanceID_Renderer_UInt32;
		public virtual RMethod RUpdateInstanceID_Renderer_UInt32
		{
			get
			{
				if(r_UpdateInstanceID_Renderer_UInt32 == null)
				{
					r_UpdateInstanceID_Renderer_UInt32 = new(this, "UpdateInstanceID", 0, typeof(UnityEngine.Renderer), typeof(System.UInt32));
					r_UpdateInstanceID_Renderer_UInt32.SetBelong(this.instance);
				}
				return r_UpdateInstanceID_Renderer_UInt32;
			}
		}

		/// <summary>
		/// Void UpdateInstancePropertyBlock(Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_UpdateInstancePropertyBlock_Int32_MaterialPropertyBlock;
		public virtual RMethod RUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_UpdateInstancePropertyBlock_Int32_MaterialPropertyBlock == null)
				{
					r_UpdateInstancePropertyBlock_Int32_MaterialPropertyBlock = new(this, "UpdateInstancePropertyBlock", 0, typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_UpdateInstancePropertyBlock_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_UpdateInstancePropertyBlock_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// UInt64 GetSize()
		/// </summary>
		protected RMethod r_GetSize;
		public virtual RMethod RGetSize
		{
			get
			{
				if(r_GetSize == null)
				{
					r_GetSize = new(this, "GetSize", 0);
					r_GetSize.SetBelong(this.instance);
				}
				return r_GetSize;
			}
		}

		/// <summary>
		/// UInt32 GetInstanceCount()
		/// </summary>
		protected RMethod r_GetInstanceCount;
		public virtual RMethod RGetInstanceCount
		{
			get
			{
				if(r_GetInstanceCount == null)
				{
					r_GetInstanceCount = new(this, "GetInstanceCount", 0);
					r_GetInstanceCount.SetBelong(this.instance);
				}
				return r_GetInstanceCount;
			}
		}

		/// <summary>
		/// Void ClearInstances()
		/// </summary>
		protected RMethod r_ClearInstances;
		public virtual RMethod RClearInstances
		{
			get
			{
				if(r_ClearInstances == null)
				{
					r_ClearInstances = new(this, "ClearInstances", 0);
					r_ClearInstances.SetBelong(this.instance);
				}
				return r_ClearInstances;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults CullInstances(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig ByRef)
		/// </summary>
		protected RMethod r_CullInstances_Ref_RayTracingInstanceCullingConfig;
		public virtual RMethod RCullInstances_Ref_RayTracingInstanceCullingConfig
		{
			get
			{
				if(r_CullInstances_Ref_RayTracingInstanceCullingConfig == null)
				{
					r_CullInstances_Ref_RayTracingInstanceCullingConfig = new(this, "CullInstances", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig).MakeByRefType());
					r_CullInstances_Ref_RayTracingInstanceCullingConfig.SetBelong(this.instance);
				}
				return r_CullInstances_Ref_RayTracingInstanceCullingConfig;
			}
		}

		/// <summary>
		/// Void AddInstanceSubMeshFlagsArray(UnityEngine.Renderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[], Boolean, Boolean, UInt32, UInt32)
		/// </summary>
		protected RMethod r_AddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
		public virtual RMethod RAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32
		{
			get
			{
				if(r_AddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 == null)
				{
					r_AddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 = new(this, "AddInstanceSubMeshFlagsArray", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.UInt32));
					r_AddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_AddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
			}
		}

		/// <summary>
		/// IntPtr Create_Injected(RASSettings ByRef)
		/// </summary>
		protected static RMethod r_Create_Injected_Ref_RASSettings;
		public static RMethod RCreate_Injected_Ref_RASSettings
		{
			get
			{
				if(r_Create_Injected_Ref_RASSettings == null)
				{
					r_Create_Injected_Ref_RASSettings = new(typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), "Create_Injected", 0,  ReleactionUtils.GetType("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings").MakeByRefType());
					r_Create_Injected_Ref_RASSettings.SetBelong(null);
				}
				return r_Create_Injected_Ref_RASSettings;
			}
		}

		/// <summary>
		/// Void Update_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Update_Injected_Ref_Vector3;
		public virtual RMethod RUpdate_Injected_Ref_Vector3
		{
			get
			{
				if(r_Update_Injected_Ref_Vector3 == null)
				{
					r_Update_Injected_Ref_Vector3 = new(this, "Update_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Update_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Update_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void Build_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Build_Injected_Ref_Vector3;
		public virtual RMethod RBuild_Injected_Ref_Vector3
		{
			get
			{
				if(r_Build_Injected_Ref_Vector3 == null)
				{
					r_Build_Injected_Ref_Vector3 = new(this, "Build_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Build_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Build_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance_Procedural_Deprecated_Injected(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4 ByRef, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_AddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_AddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance_Procedural_Deprecated_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_AddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Int32 AddInstance_Procedural_Injected(UnityEngine.GraphicsBuffer, UInt32, Boolean, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Boolean, UnityEngine.MaterialPropertyBlock, UInt32, UInt32)
		/// </summary>
		protected RMethod r_AddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
		public virtual RMethod RAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32
		{
			get
			{
				if(r_AddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 == null)
				{
					r_AddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 = new(this, "AddInstance_Procedural_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(System.Boolean), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.UInt32), typeof(System.UInt32));
					r_AddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_AddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform_InstanceID_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_UpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_UpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_UpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4 = new(this, "UpdateInstanceTransform_InstanceID_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_UpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_UpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void CullInstances_Injected(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig ByRef, UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults ByRef)
		/// </summary>
		protected RMethod r_CullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults;
		public virtual RMethod RCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults
		{
			get
			{
				if(r_CullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults == null)
				{
					r_CullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults = new(this, "CullInstances_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig).MakeByRefType(), typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults).MakeByRefType());
					r_CullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults.SetBelong(this.instance);
				}
				return r_CullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults;
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


        public RRayTracingAccelerationStructure() : base("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure")
        {
        }

        public RRayTracingAccelerationStructure(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure")
		{
            SetInstance(instance);
		}

        public RRayTracingAccelerationStructure(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRayTracingAccelerationStructure(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public static void Destroy(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelStruct)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelStruct};
            var ___result = RDestroy_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Build()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.Renderer  @targetRenderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[]  @subMeshFlags, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer, @subMeshFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
            var ___result = RAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 AddInstance(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @aabbCount, System.Boolean  @dynamicData, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Boolean  @opaqueMaterial, UnityEngine.MaterialPropertyBlock  @properties, System.UInt32  @mask, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @aabbCount, @dynamicData, @matrix, @material, @opaqueMaterial, @properties, @mask, @id};
            var ___result = RAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RemoveInstance(UnityEngine.Renderer  @targetRenderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer};
            var ___result = RRemoveInstance_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveInstance(System.Int32  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RRemoveInstance_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform(UnityEngine.Renderer  @renderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer};
            var ___result = RUpdateInstanceTransform_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform(System.Int32  @handle, UnityEngine.Matrix4x4  @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @matrix};
            var ___result = RUpdateInstanceTransform_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update(UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RUpdate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.Renderer  @targetRenderer, System.Boolean[]  @subMeshMask, System.Boolean[]  @subMeshTransparencyFlags, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer, @subMeshMask, @subMeshTransparencyFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
            var ___result = RAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @numElements, UnityEngine.Material  @material, System.Boolean  @isCutOff, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.Boolean  @reuseBounds, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @numElements, UnityEngine.Material  @material, UnityEngine.Matrix4x4  @instanceTransform, System.Boolean  @isCutOff, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.Boolean  @reuseBounds, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Build(UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RBuild_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance_Procedural_Deprecated(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @numElements, UnityEngine.Material  @material, UnityEngine.Matrix4x4  @instanceTransform, System.Boolean  @isCutOff, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.Boolean  @reuseBounds, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 AddInstance_Procedural(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @aabbCount, System.Boolean  @dynamicData, UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Boolean  @opaqueMaterial, UnityEngine.MaterialPropertyBlock  @properties, System.UInt32  @mask, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @aabbCount, @dynamicData, @matrix, @material, @opaqueMaterial, @properties, @mask, @id};
            var ___result = RAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RemoveInstance_Renderer(UnityEngine.Renderer  @targetRenderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer};
            var ___result = RRemoveInstance_Renderer_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveInstance_InstanceID(System.Int32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RRemoveInstance_InstanceID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform_Renderer(UnityEngine.Renderer  @renderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer};
            var ___result = RUpdateInstanceTransform_Renderer_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform_InstanceID(System.Int32  @instanceID, UnityEngine.Matrix4x4  @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID, @matrix};
            var ___result = RUpdateInstanceTransform_InstanceID_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceMask(UnityEngine.Renderer  @renderer, System.UInt32  @mask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @mask};
            var ___result = RUpdateInstanceMask_Renderer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceID(UnityEngine.Renderer  @renderer, System.UInt32  @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @instanceID};
            var ___result = RUpdateInstanceID_Renderer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstancePropertyBlock(System.Int32  @handle, UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @properties};
            var ___result = RUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSize.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.UInt32 GetInstanceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceCount.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void ClearInstances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearInstances.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults CullInstances(ref UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig  @cullingConfig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cullingConfig};
            var ___result = RCullInstances_Ref_RayTracingInstanceCullingConfig.Invoke(___genericsType, ___parameters);
			cullingConfig = (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig)___parameters[0];

            return (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults)___result;
        }


        public virtual void AddInstanceSubMeshFlagsArray(UnityEngine.Renderer  @targetRenderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[]  @subMeshFlags, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer, @subMeshFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
            var ___result = RAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Update_Injected(ref UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RUpdate_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			relativeOrigin = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void Build_Injected(ref UnityEngine.Vector3  @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RBuild_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			relativeOrigin = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void AddInstance_Procedural_Deprecated_Injected(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @numElements, UnityEngine.Material  @material, ref UnityEngine.Matrix4x4  @instanceTransform, System.Boolean  @isCutOff, System.Boolean  @enableTriangleCulling, System.Boolean  @frontTriangleCounterClockwise, System.UInt32  @mask, System.Boolean  @reuseBounds, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);
			instanceTransform = (UnityEngine.Matrix4x4)___parameters[3];

            
        }


        public virtual System.Int32 AddInstance_Procedural_Injected(UnityEngine.GraphicsBuffer  @aabbBuffer, System.UInt32  @aabbCount, System.Boolean  @dynamicData, ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Material  @material, System.Boolean  @opaqueMaterial, UnityEngine.MaterialPropertyBlock  @properties, System.UInt32  @mask, System.UInt32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @aabbCount, @dynamicData, @matrix, @material, @opaqueMaterial, @properties, @mask, @id};
            var ___result = RAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[3];

            return (System.Int32)___result;
        }


        public virtual void UpdateInstanceTransform_InstanceID_Injected(System.Int32  @instanceID, ref UnityEngine.Matrix4x4  @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID, @matrix};
            var ___result = RUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void CullInstances_Injected(ref UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig  @cullingConfig, out UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cullingConfig, @ret};
            var ___result = RCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults.Invoke(___genericsType, ___parameters);
			cullingConfig = (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig)___parameters[0];
			ret = (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults)___parameters[1];

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
