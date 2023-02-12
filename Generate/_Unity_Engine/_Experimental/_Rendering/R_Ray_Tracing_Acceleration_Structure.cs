
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
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
					r_Fm_Ptr.SetBelong(this.instance);
				}
				return r_Fm_Ptr;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// IntPtr Create(RASSettings)
		/// </summary>
		protected static RMethod r_MCreate_RASSettings;
		public static RMethod RMCreate_RASSettings
		{
			get
			{
				if(r_MCreate_RASSettings == null)
				{
					r_MCreate_RASSettings = new(typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), "Create", 0,  ReflectionUtils.GetType("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings"));
					r_MCreate_RASSettings.SetBelong(null);
				}
				return r_MCreate_RASSettings;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected static RMethod r_MDestroy_RayTracingAccelerationStructure;
		public static RMethod RMDestroy_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MDestroy_RayTracingAccelerationStructure == null)
				{
					r_MDestroy_RayTracingAccelerationStructure = new(typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), "Destroy", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_MDestroy_RayTracingAccelerationStructure.SetBelong(null);
				}
				return r_MDestroy_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
					r_MRelease.SetBelong(this.instance);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Void Build()
		/// </summary>
		protected RMethod r_MBuild;
		public virtual RMethod RMBuild
		{
			get
			{
				if(r_MBuild == null)
				{
					r_MBuild = new(this, "Build", 0);
					r_MBuild.SetBelong(this.instance);
				}
				return r_MBuild;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.Renderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[], Boolean, Boolean, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
		public virtual RMethod RMAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32
		{
			get
			{
				if(r_MAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 == null)
				{
					r_MAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.UInt32));
					r_MAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 AddInstance(UnityEngine.GraphicsBuffer, UInt32, Boolean, UnityEngine.Matrix4x4, UnityEngine.Material, Boolean, UnityEngine.MaterialPropertyBlock, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
		public virtual RMethod RMAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32
		{
			get
			{
				if(r_MAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 == null)
				{
					r_MAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(System.Boolean), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.UInt32), typeof(System.UInt32));
					r_MAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void RemoveInstance(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_MRemoveInstance_Renderer;
		public virtual RMethod RMRemoveInstance_Renderer
		{
			get
			{
				if(r_MRemoveInstance_Renderer == null)
				{
					r_MRemoveInstance_Renderer = new(this, "RemoveInstance", 0, typeof(UnityEngine.Renderer));
					r_MRemoveInstance_Renderer.SetBelong(this.instance);
				}
				return r_MRemoveInstance_Renderer;
			}
		}

		/// <summary>
		/// Void RemoveInstance(Int32)
		/// </summary>
		protected RMethod r_MRemoveInstance_Int32;
		public virtual RMethod RMRemoveInstance_Int32
		{
			get
			{
				if(r_MRemoveInstance_Int32 == null)
				{
					r_MRemoveInstance_Int32 = new(this, "RemoveInstance", 0, typeof(System.Int32));
					r_MRemoveInstance_Int32.SetBelong(this.instance);
				}
				return r_MRemoveInstance_Int32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_MUpdateInstanceTransform_Renderer;
		public virtual RMethod RMUpdateInstanceTransform_Renderer
		{
			get
			{
				if(r_MUpdateInstanceTransform_Renderer == null)
				{
					r_MUpdateInstanceTransform_Renderer = new(this, "UpdateInstanceTransform", 0, typeof(UnityEngine.Renderer));
					r_MUpdateInstanceTransform_Renderer.SetBelong(this.instance);
				}
				return r_MUpdateInstanceTransform_Renderer;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MUpdateInstanceTransform_Int32_Matrix4x4;
		public virtual RMethod RMUpdateInstanceTransform_Int32_Matrix4x4
		{
			get
			{
				if(r_MUpdateInstanceTransform_Int32_Matrix4x4 == null)
				{
					r_MUpdateInstanceTransform_Int32_Matrix4x4 = new(this, "UpdateInstanceTransform", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MUpdateInstanceTransform_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_MUpdateInstanceTransform_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
					r_MUpdate.SetBelong(this.instance);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void Update(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MUpdate_Vector3;
		public virtual RMethod RMUpdate_Vector3
		{
			get
			{
				if(r_MUpdate_Vector3 == null)
				{
					r_MUpdate_Vector3 = new(this, "Update", 0, typeof(UnityEngine.Vector3));
					r_MUpdate_Vector3.SetBelong(this.instance);
				}
				return r_MUpdate_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.Renderer, Boolean[], Boolean[], Boolean, Boolean, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32;
		public virtual RMethod RMAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32
		{
			get
			{
				if(r_MAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32 == null)
				{
					r_MAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.Renderer), typeof(System.Boolean).MakeArrayType(), typeof(System.Boolean).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.UInt32));
					r_MAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RMAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_MAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_MAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_MAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Void AddInstance(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RMAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_MAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_MAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_MAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Void Build(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MBuild_Vector3;
		public virtual RMethod RMBuild_Vector3
		{
			get
			{
				if(r_MBuild_Vector3 == null)
				{
					r_MBuild_Vector3 = new(this, "Build", 0, typeof(UnityEngine.Vector3));
					r_MBuild_Vector3.SetBelong(this.instance);
				}
				return r_MBuild_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance_Procedural_Deprecated(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RMAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_MAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_MAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance_Procedural_Deprecated", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_MAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Int32 AddInstance_Procedural(UnityEngine.GraphicsBuffer, UInt32, Boolean, UnityEngine.Matrix4x4, UnityEngine.Material, Boolean, UnityEngine.MaterialPropertyBlock, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
		public virtual RMethod RMAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32
		{
			get
			{
				if(r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 == null)
				{
					r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 = new(this, "AddInstance_Procedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(System.Boolean), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.UInt32), typeof(System.UInt32));
					r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void RemoveInstance_Renderer(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_MRemoveInstance_Renderer_Renderer;
		public virtual RMethod RMRemoveInstance_Renderer_Renderer
		{
			get
			{
				if(r_MRemoveInstance_Renderer_Renderer == null)
				{
					r_MRemoveInstance_Renderer_Renderer = new(this, "RemoveInstance_Renderer", 0, typeof(UnityEngine.Renderer));
					r_MRemoveInstance_Renderer_Renderer.SetBelong(this.instance);
				}
				return r_MRemoveInstance_Renderer_Renderer;
			}
		}

		/// <summary>
		/// Void RemoveInstance_InstanceID(Int32)
		/// </summary>
		protected RMethod r_MRemoveInstance_InstanceID_Int32;
		public virtual RMethod RMRemoveInstance_InstanceID_Int32
		{
			get
			{
				if(r_MRemoveInstance_InstanceID_Int32 == null)
				{
					r_MRemoveInstance_InstanceID_Int32 = new(this, "RemoveInstance_InstanceID", 0, typeof(System.Int32));
					r_MRemoveInstance_InstanceID_Int32.SetBelong(this.instance);
				}
				return r_MRemoveInstance_InstanceID_Int32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform_Renderer(UnityEngine.Renderer)
		/// </summary>
		protected RMethod r_MUpdateInstanceTransform_Renderer_Renderer;
		public virtual RMethod RMUpdateInstanceTransform_Renderer_Renderer
		{
			get
			{
				if(r_MUpdateInstanceTransform_Renderer_Renderer == null)
				{
					r_MUpdateInstanceTransform_Renderer_Renderer = new(this, "UpdateInstanceTransform_Renderer", 0, typeof(UnityEngine.Renderer));
					r_MUpdateInstanceTransform_Renderer_Renderer.SetBelong(this.instance);
				}
				return r_MUpdateInstanceTransform_Renderer_Renderer;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform_InstanceID(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MUpdateInstanceTransform_InstanceID_Int32_Matrix4x4;
		public virtual RMethod RMUpdateInstanceTransform_InstanceID_Int32_Matrix4x4
		{
			get
			{
				if(r_MUpdateInstanceTransform_InstanceID_Int32_Matrix4x4 == null)
				{
					r_MUpdateInstanceTransform_InstanceID_Int32_Matrix4x4 = new(this, "UpdateInstanceTransform_InstanceID", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MUpdateInstanceTransform_InstanceID_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_MUpdateInstanceTransform_InstanceID_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void UpdateInstanceMask(UnityEngine.Renderer, UInt32)
		/// </summary>
		protected RMethod r_MUpdateInstanceMask_Renderer_UInt32;
		public virtual RMethod RMUpdateInstanceMask_Renderer_UInt32
		{
			get
			{
				if(r_MUpdateInstanceMask_Renderer_UInt32 == null)
				{
					r_MUpdateInstanceMask_Renderer_UInt32 = new(this, "UpdateInstanceMask", 0, typeof(UnityEngine.Renderer), typeof(System.UInt32));
					r_MUpdateInstanceMask_Renderer_UInt32.SetBelong(this.instance);
				}
				return r_MUpdateInstanceMask_Renderer_UInt32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceID(UnityEngine.Renderer, UInt32)
		/// </summary>
		protected RMethod r_MUpdateInstanceID_Renderer_UInt32;
		public virtual RMethod RMUpdateInstanceID_Renderer_UInt32
		{
			get
			{
				if(r_MUpdateInstanceID_Renderer_UInt32 == null)
				{
					r_MUpdateInstanceID_Renderer_UInt32 = new(this, "UpdateInstanceID", 0, typeof(UnityEngine.Renderer), typeof(System.UInt32));
					r_MUpdateInstanceID_Renderer_UInt32.SetBelong(this.instance);
				}
				return r_MUpdateInstanceID_Renderer_UInt32;
			}
		}

		/// <summary>
		/// Void UpdateInstancePropertyBlock(Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock;
		public virtual RMethod RMUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock == null)
				{
					r_MUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock = new(this, "UpdateInstancePropertyBlock", 0, typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_MUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_MUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// UInt64 GetSize()
		/// </summary>
		protected RMethod r_MGetSize;
		public virtual RMethod RMGetSize
		{
			get
			{
				if(r_MGetSize == null)
				{
					r_MGetSize = new(this, "GetSize", 0);
					r_MGetSize.SetBelong(this.instance);
				}
				return r_MGetSize;
			}
		}

		/// <summary>
		/// UInt32 GetInstanceCount()
		/// </summary>
		protected RMethod r_MGetInstanceCount;
		public virtual RMethod RMGetInstanceCount
		{
			get
			{
				if(r_MGetInstanceCount == null)
				{
					r_MGetInstanceCount = new(this, "GetInstanceCount", 0);
					r_MGetInstanceCount.SetBelong(this.instance);
				}
				return r_MGetInstanceCount;
			}
		}

		/// <summary>
		/// Void ClearInstances()
		/// </summary>
		protected RMethod r_MClearInstances;
		public virtual RMethod RMClearInstances
		{
			get
			{
				if(r_MClearInstances == null)
				{
					r_MClearInstances = new(this, "ClearInstances", 0);
					r_MClearInstances.SetBelong(this.instance);
				}
				return r_MClearInstances;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults CullInstances(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig ByRef)
		/// </summary>
		protected RMethod r_MCullInstances_Ref_RayTracingInstanceCullingConfig;
		public virtual RMethod RMCullInstances_Ref_RayTracingInstanceCullingConfig
		{
			get
			{
				if(r_MCullInstances_Ref_RayTracingInstanceCullingConfig == null)
				{
					r_MCullInstances_Ref_RayTracingInstanceCullingConfig = new(this, "CullInstances", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig).MakeByRefType());
					r_MCullInstances_Ref_RayTracingInstanceCullingConfig.SetBelong(this.instance);
				}
				return r_MCullInstances_Ref_RayTracingInstanceCullingConfig;
			}
		}

		/// <summary>
		/// Void AddInstanceSubMeshFlagsArray(UnityEngine.Renderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[], Boolean, Boolean, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
		public virtual RMethod RMAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32
		{
			get
			{
				if(r_MAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 == null)
				{
					r_MAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32 = new(this, "AddInstanceSubMeshFlagsArray", 0, typeof(UnityEngine.Renderer), typeof(UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.UInt32));
					r_MAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
			}
		}

		/// <summary>
		/// IntPtr Create_Injected(RASSettings ByRef)
		/// </summary>
		protected static RMethod r_MCreate_Injected_Ref_RASSettings;
		public static RMethod RMCreate_Injected_Ref_RASSettings
		{
			get
			{
				if(r_MCreate_Injected_Ref_RASSettings == null)
				{
					r_MCreate_Injected_Ref_RASSettings = new(typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure), "Create_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings").MakeByRefType());
					r_MCreate_Injected_Ref_RASSettings.SetBelong(null);
				}
				return r_MCreate_Injected_Ref_RASSettings;
			}
		}

		/// <summary>
		/// Void Update_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MUpdate_Injected_Ref_Vector3;
		public virtual RMethod RMUpdate_Injected_Ref_Vector3
		{
			get
			{
				if(r_MUpdate_Injected_Ref_Vector3 == null)
				{
					r_MUpdate_Injected_Ref_Vector3 = new(this, "Update_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_MUpdate_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_MUpdate_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void Build_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_MBuild_Injected_Ref_Vector3;
		public virtual RMethod RMBuild_Injected_Ref_Vector3
		{
			get
			{
				if(r_MBuild_Injected_Ref_Vector3 == null)
				{
					r_MBuild_Injected_Ref_Vector3 = new(this, "Build_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_MBuild_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_MBuild_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance_Procedural_Deprecated_Injected(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4 ByRef, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RMAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_MAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_MAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance_Procedural_Deprecated_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
					r_MAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Int32 AddInstance_Procedural_Injected(UnityEngine.GraphicsBuffer, UInt32, Boolean, UnityEngine.Matrix4x4 ByRef, UnityEngine.Material, Boolean, UnityEngine.MaterialPropertyBlock, UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
		public virtual RMethod RMAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32
		{
			get
			{
				if(r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 == null)
				{
					r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32 = new(this, "AddInstance_Procedural_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(System.Boolean), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.UInt32), typeof(System.UInt32));
					r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void UpdateInstanceTransform_InstanceID_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RMUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_MUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4 = new(this, "UpdateInstanceTransform_InstanceID_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_MUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void CullInstances_Injected(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig ByRef, UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults ByRef)
		/// </summary>
		protected RMethod r_MCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults;
		public virtual RMethod RMCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults
		{
			get
			{
				if(r_MCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults == null)
				{
					r_MCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults = new(this, "CullInstances_Injected", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig).MakeByRefType(), typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults).MakeByRefType());
					r_MCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults.SetBelong(this.instance);
				}
				return r_MCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults;
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
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Create(SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRASSettings @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc.Value};
            var ___result = RMCreate_RASSettings.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void Destroy(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelStruct)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@accelStruct};
            var ___result = RMDestroy_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Build()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.Renderer @targetRenderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] @subMeshFlags, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer, @subMeshFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
            var ___result = RMAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 AddInstance(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @aabbCount, System.Boolean @dynamicData, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Boolean @opaqueMaterial, UnityEngine.MaterialPropertyBlock @properties, System.UInt32 @mask, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @aabbCount, @dynamicData, @matrix, @material, @opaqueMaterial, @properties, @mask, @id};
            var ___result = RMAddInstance_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RemoveInstance(UnityEngine.Renderer @targetRenderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer};
            var ___result = RMRemoveInstance_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveInstance(System.Int32 @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMRemoveInstance_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform(UnityEngine.Renderer @renderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer};
            var ___result = RMUpdateInstanceTransform_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform(System.Int32 @handle, UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @matrix};
            var ___result = RMUpdateInstanceTransform_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update(UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RMUpdate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.Renderer @targetRenderer, System.Boolean[] @subMeshMask, System.Boolean[] @subMeshTransparencyFlags, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer, @subMeshMask, @subMeshTransparencyFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
            var ___result = RMAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @numElements, UnityEngine.Material @material, System.Boolean @isCutOff, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.Boolean @reuseBounds, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RMAddInstance_GraphicsBuffer_UInt32_Material_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @numElements, UnityEngine.Material @material, UnityEngine.Matrix4x4 @instanceTransform, System.Boolean @isCutOff, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.Boolean @reuseBounds, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RMAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Build(UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RMBuild_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInstance_Procedural_Deprecated(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @numElements, UnityEngine.Material @material, UnityEngine.Matrix4x4 @instanceTransform, System.Boolean @isCutOff, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.Boolean @reuseBounds, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RMAddInstance_Procedural_Deprecated_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 AddInstance_Procedural(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @aabbCount, System.Boolean @dynamicData, UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Boolean @opaqueMaterial, UnityEngine.MaterialPropertyBlock @properties, System.UInt32 @mask, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @aabbCount, @dynamicData, @matrix, @material, @opaqueMaterial, @properties, @mask, @id};
            var ___result = RMAddInstance_Procedural_GraphicsBuffer_UInt32_Boolean_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RemoveInstance_Renderer(UnityEngine.Renderer @targetRenderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer};
            var ___result = RMRemoveInstance_Renderer_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveInstance_InstanceID(System.Int32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID};
            var ___result = RMRemoveInstance_InstanceID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform_Renderer(UnityEngine.Renderer @renderer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer};
            var ___result = RMUpdateInstanceTransform_Renderer_Renderer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceTransform_InstanceID(System.Int32 @instanceID, UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID, @matrix};
            var ___result = RMUpdateInstanceTransform_InstanceID_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceMask(UnityEngine.Renderer @renderer, System.UInt32 @mask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @mask};
            var ___result = RMUpdateInstanceMask_Renderer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstanceID(UnityEngine.Renderer @renderer, System.UInt32 @instanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderer, @instanceID};
            var ___result = RMUpdateInstanceID_Renderer_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInstancePropertyBlock(System.Int32 @handle, UnityEngine.MaterialPropertyBlock @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @properties};
            var ___result = RMUpdateInstancePropertyBlock_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSize.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.UInt32 GetInstanceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceCount.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void ClearInstances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearInstances.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults CullInstances(ref UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig @cullingConfig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cullingConfig};
            var ___result = RMCullInstances_Ref_RayTracingInstanceCullingConfig.Invoke(___genericsType, ___parameters);
			@cullingConfig = (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig)___parameters[0];

            return (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults)___result;
        }


        public virtual void AddInstanceSubMeshFlagsArray(UnityEngine.Renderer @targetRenderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] @subMeshFlags, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRenderer, @subMeshFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
            var ___result = RMAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Create_Injected(ref SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRASSettings @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc.Value};
            var ___result = RMCreate_Injected_Ref_RASSettings.Invoke(___genericsType, ___parameters);
			@desc = new SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRASSettings(___parameters[0]);

            return (System.IntPtr)___result;
        }


        public virtual void Update_Injected(ref UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RMUpdate_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@relativeOrigin = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void Build_Injected(ref UnityEngine.Vector3 @relativeOrigin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeOrigin};
            var ___result = RMBuild_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@relativeOrigin = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void AddInstance_Procedural_Deprecated_Injected(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @numElements, UnityEngine.Material @material, ref UnityEngine.Matrix4x4 @instanceTransform, System.Boolean @isCutOff, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.Boolean @reuseBounds, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
            var ___result = RMAddInstance_Procedural_Deprecated_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);
			@instanceTransform = (UnityEngine.Matrix4x4)___parameters[3];

            
        }


        public virtual System.Int32 AddInstance_Procedural_Injected(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @aabbCount, System.Boolean @dynamicData, ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Material @material, System.Boolean @opaqueMaterial, UnityEngine.MaterialPropertyBlock @properties, System.UInt32 @mask, System.UInt32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aabbBuffer, @aabbCount, @dynamicData, @matrix, @material, @opaqueMaterial, @properties, @mask, @id};
            var ___result = RMAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Boolean_Ref_Matrix4x4_Material_Boolean_MaterialPropertyBlock_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[3];

            return (System.Int32)___result;
        }


        public virtual void UpdateInstanceTransform_InstanceID_Injected(System.Int32 @instanceID, ref UnityEngine.Matrix4x4 @matrix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instanceID, @matrix};
            var ___result = RMUpdateInstanceTransform_InstanceID_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[1];

            
        }


        public virtual void CullInstances_Injected(ref UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig @cullingConfig, out UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cullingConfig, @ret};
            var ___result = RMCullInstances_Injected_Ref_RayTracingInstanceCullingConfig_Out_RayTracingInstanceCullingResults.Invoke(___genericsType, ___parameters);
			@cullingConfig = (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig)___parameters[0];
			@ret = (UnityEngine.Experimental.Rendering.RayTracingInstanceCullingResults)___parameters[1];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
