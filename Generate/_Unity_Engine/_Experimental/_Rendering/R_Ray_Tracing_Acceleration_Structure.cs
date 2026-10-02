
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure
	/// </summary>
    public partial class RRayTracingAccelerationStructure : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure);
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


		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
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
					r_MCreate_RASSettings = new(Type, "Create", 0,  ReflectionUtils.GetType("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings"));
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
					r_MDestroy_RayTracingAccelerationStructure = new(Type, "Destroy", 0, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
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
				}
				return r_MBuild;
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
				}
				return r_MUpdate;
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
				}
				return r_MBuild_Vector3;
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
				}
				return r_MAddInstance_Renderer_BooleanArray_BooleanArray_Boolean_Boolean_UInt32_UInt32;
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
				}
				return r_MAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32;
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
				}
				return r_MRemoveInstance_Renderer;
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
				}
				return r_MAddInstance_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
			}
		}

		/// <summary>
		/// Void AddInstance_Procedural(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RMAddInstance_Procedural_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance_Procedural", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
				}
				return r_MAddInstance_Procedural_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
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
				}
				return r_MUpdateInstanceTransform_Renderer;
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
				}
				return r_MUpdateInstanceID_Renderer_UInt32;
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
				}
				return r_MGetInstanceCount;
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
					r_MCreate_Injected_Ref_RASSettings = new(Type, "Create_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure+RASSettings").MakeByRefType());
				}
				return r_MCreate_Injected_Ref_RASSettings;
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
				}
				return r_MBuild_Injected_Ref_Vector3;
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
				}
				return r_MUpdate_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void AddInstance_Procedural_Injected(UnityEngine.GraphicsBuffer, UInt32, UnityEngine.Material, UnityEngine.Matrix4x4 ByRef, Boolean, Boolean, Boolean, UInt32, Boolean, UInt32)
		/// </summary>
		protected RMethod r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
		public virtual RMethod RMAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32
		{
			get
			{
				if(r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 == null)
				{
					r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32 = new(this, "AddInstance_Procedural_Injected", 0, typeof(UnityEngine.GraphicsBuffer), typeof(System.UInt32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UInt32), typeof(System.Boolean), typeof(System.UInt32));
				}
				return r_MAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32;
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


		public static System.IntPtr Create(Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRASSettings @desc)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@desc.Value};
			var ___result = RMCreate_RASSettings.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.IntPtr>(___result);
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


		public virtual void Update()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMUpdate.Invoke(___genericsType, ___parameters);
		}


		public virtual void Build(UnityEngine.Vector3 @relativeOrigin)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@relativeOrigin};
			var ___result = RMBuild_Vector3.Invoke(___genericsType, ___parameters);
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


		public virtual void AddInstance(UnityEngine.Renderer @targetRenderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] @subMeshFlags, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.UInt32 @id)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@targetRenderer, @subMeshFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
			var ___result = RMAddInstance_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);
		}


		public virtual void RemoveInstance(UnityEngine.Renderer @targetRenderer)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@targetRenderer};
			var ___result = RMRemoveInstance_Renderer.Invoke(___genericsType, ___parameters);
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


		public virtual void AddInstance_Procedural(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @numElements, UnityEngine.Material @material, UnityEngine.Matrix4x4 @instanceTransform, System.Boolean @isCutOff, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.Boolean @reuseBounds, System.UInt32 @id)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
			var ___result = RMAddInstance_Procedural_GraphicsBuffer_UInt32_Material_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);
		}


		public virtual void UpdateInstanceTransform(UnityEngine.Renderer @renderer)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@renderer};
			var ___result = RMUpdateInstanceTransform_Renderer.Invoke(___genericsType, ___parameters);
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


		public virtual System.UInt64 GetSize()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetSize.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.UInt64>(___result);
		}


		public virtual System.UInt32 GetInstanceCount()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetInstanceCount.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.UInt32>(___result);
		}


		public virtual void AddInstanceSubMeshFlagsArray(UnityEngine.Renderer @targetRenderer, UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] @subMeshFlags, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.UInt32 @id)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@targetRenderer, @subMeshFlags, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @id};
			var ___result = RMAddInstanceSubMeshFlagsArray_Renderer_RayTracingSubMeshFlagsArray_Boolean_Boolean_UInt32_UInt32.Invoke(___genericsType, ___parameters);
		}


		public static System.IntPtr Create_Injected(ref Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRASSettings @desc)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@desc.Value};
			var ___result = RMCreate_Injected_Ref_RASSettings.Invoke(___genericsType, ___parameters);
			@desc = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingAccelerationStructure.RRASSettings>(___parameters[0]);
			return ReflectionUtils.Convert<System.IntPtr>(___result);
		}


		public virtual void Build_Injected(ref UnityEngine.Vector3 @relativeOrigin)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@relativeOrigin};
			var ___result = RMBuild_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@relativeOrigin = ReflectionUtils.Convert<UnityEngine.Vector3>(___parameters[0]);
		}


		public virtual void Update_Injected(ref UnityEngine.Vector3 @relativeOrigin)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@relativeOrigin};
			var ___result = RMUpdate_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@relativeOrigin = ReflectionUtils.Convert<UnityEngine.Vector3>(___parameters[0]);
		}


		public virtual void AddInstance_Procedural_Injected(UnityEngine.GraphicsBuffer @aabbBuffer, System.UInt32 @numElements, UnityEngine.Material @material, ref UnityEngine.Matrix4x4 @instanceTransform, System.Boolean @isCutOff, System.Boolean @enableTriangleCulling, System.Boolean @frontTriangleCounterClockwise, System.UInt32 @mask, System.Boolean @reuseBounds, System.UInt32 @id)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@aabbBuffer, @numElements, @material, @instanceTransform, @isCutOff, @enableTriangleCulling, @frontTriangleCounterClockwise, @mask, @reuseBounds, @id};
			var ___result = RMAddInstance_Procedural_Injected_GraphicsBuffer_UInt32_Material_Ref_Matrix4x4_Boolean_Boolean_Boolean_UInt32_Boolean_UInt32.Invoke(___genericsType, ___parameters);
			@instanceTransform = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[3]);
		}


		public virtual System.Boolean Equals(System.Object @obj)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@obj};
			var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Int32 GetHashCode()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Int32>(___result);
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


		public virtual System.String ToString()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMToString.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


    }
}
