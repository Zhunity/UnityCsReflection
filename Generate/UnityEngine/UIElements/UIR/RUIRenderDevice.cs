using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRenderDevice
	/// </summary>
    public partial class RUIRenderDevice : RMember //
    {

		/// <summary>
		/// System.UInt32 k_MaxQueuedFrameCount
		/// </summary>
		protected static RField r_k_MaxQueuedFrameCount;
		public static RField Rk_MaxQueuedFrameCount
		{
			get
			{
				if(r_k_MaxQueuedFrameCount == null)
				{
					r_k_MaxQueuedFrameCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_MaxQueuedFrameCount");
					r_k_MaxQueuedFrameCount.SetBelong(null);
				}
				return r_k_MaxQueuedFrameCount;
			}
		}

		/// <summary>
		/// System.Int32 k_PruneEmptyPageFrameCount
		/// </summary>
		protected static RField r_k_PruneEmptyPageFrameCount;
		public static RField Rk_PruneEmptyPageFrameCount
		{
			get
			{
				if(r_k_PruneEmptyPageFrameCount == null)
				{
					r_k_PruneEmptyPageFrameCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_PruneEmptyPageFrameCount");
					r_k_PruneEmptyPageFrameCount.SetBelong(null);
				}
				return r_k_PruneEmptyPageFrameCount;
			}
		}

		/// <summary>
		/// System.Boolean m_MockDevice
		/// </summary>
		protected RField r_m_MockDevice;
		public virtual RField Rm_MockDevice
		{
			get
			{
				if(r_m_MockDevice == null)
				{
					r_m_MockDevice = new(this, "m_MockDevice");
					r_m_MockDevice.SetBelong(this.instance);
				}
				return r_m_MockDevice;
			}
		}

		/// <summary>
		/// System.IntPtr m_DefaultStencilState
		/// </summary>
		protected RField r_m_DefaultStencilState;
		public virtual RField Rm_DefaultStencilState
		{
			get
			{
				if(r_m_DefaultStencilState == null)
				{
					r_m_DefaultStencilState = new(this, "m_DefaultStencilState");
					r_m_DefaultStencilState.SetBelong(this.instance);
				}
				return r_m_DefaultStencilState;
			}
		}

		/// <summary>
		/// System.IntPtr m_VertexDecl
		/// </summary>
		protected RField r_m_VertexDecl;
		public virtual RField Rm_VertexDecl
		{
			get
			{
				if(r_m_VertexDecl == null)
				{
					r_m_VertexDecl = new(this, "m_VertexDecl");
					r_m_VertexDecl.SetBelong(this.instance);
				}
				return r_m_VertexDecl;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page m_FirstPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_m_FirstPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage Rm_FirstPage
		{
			get
			{
				if(r_m_FirstPage == null)
				{
					r_m_FirstPage = new(this, "m_FirstPage");
					r_m_FirstPage.SetBelong(this.instance);
				}
				return r_m_FirstPage;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextPageVertexCount
		/// </summary>
		protected RField r_m_NextPageVertexCount;
		public virtual RField Rm_NextPageVertexCount
		{
			get
			{
				if(r_m_NextPageVertexCount == null)
				{
					r_m_NextPageVertexCount = new(this, "m_NextPageVertexCount");
					r_m_NextPageVertexCount.SetBelong(this.instance);
				}
				return r_m_NextPageVertexCount;
			}
		}

		/// <summary>
		/// System.UInt32 m_LargeMeshVertexCount
		/// </summary>
		protected RField r_m_LargeMeshVertexCount;
		public virtual RField Rm_LargeMeshVertexCount
		{
			get
			{
				if(r_m_LargeMeshVertexCount == null)
				{
					r_m_LargeMeshVertexCount = new(this, "m_LargeMeshVertexCount");
					r_m_LargeMeshVertexCount.SetBelong(this.instance);
				}
				return r_m_LargeMeshVertexCount;
			}
		}

		/// <summary>
		/// System.Single m_IndexToVertexCountRatio
		/// </summary>
		protected RField r_m_IndexToVertexCountRatio;
		public virtual RField Rm_IndexToVertexCountRatio
		{
			get
			{
				if(r_m_IndexToVertexCountRatio == null)
				{
					r_m_IndexToVertexCountRatio = new(this, "m_IndexToVertexCountRatio");
					r_m_IndexToVertexCountRatio.SetBelong(this.instance);
				}
				return r_m_IndexToVertexCountRatio;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.UIRenderDevice+AllocToFree]] m_DeferredFrees
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToFree>> r_m_DeferredFrees;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToFree>> Rm_DeferredFrees
		{
			get
			{
				if(r_m_DeferredFrees == null)
				{
					r_m_DeferredFrees = new(this, "m_DeferredFrees");
					r_m_DeferredFrees.SetBelong(this.instance);
				}
				return r_m_DeferredFrees;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate]] m_Updates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToUpdate>> r_m_Updates;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToUpdate>> Rm_Updates
		{
			get
			{
				if(r_m_Updates == null)
				{
					r_m_Updates = new(this, "m_Updates");
					r_m_Updates.SetBelong(this.instance);
				}
				return r_m_Updates;
			}
		}

		/// <summary>
		/// System.UInt32[] m_Fences
		/// </summary>
		protected RFieldArray<RField> r_m_Fences;
		public virtual RFieldArray<RField> Rm_Fences
		{
			get
			{
				if(r_m_Fences == null)
				{
					r_m_Fences = new(this, "m_Fences");
					r_m_Fences.SetBelong(this.instance);
				}
				return r_m_Fences;
			}
		}

		/// <summary>
		/// UnityEngine.MaterialPropertyBlock m_StandardMatProps
		/// </summary>
		protected RUnityEngine.RMaterialPropertyBlock r_m_StandardMatProps;
		public virtual RUnityEngine.RMaterialPropertyBlock Rm_StandardMatProps
		{
			get
			{
				if(r_m_StandardMatProps == null)
				{
					r_m_StandardMatProps = new(this, "m_StandardMatProps");
					r_m_StandardMatProps.SetBelong(this.instance);
				}
				return r_m_StandardMatProps;
			}
		}

		/// <summary>
		/// System.UInt32 m_FrameIndex
		/// </summary>
		protected RField r_m_FrameIndex;
		public virtual RField Rm_FrameIndex
		{
			get
			{
				if(r_m_FrameIndex == null)
				{
					r_m_FrameIndex = new(this, "m_FrameIndex");
					r_m_FrameIndex.SetBelong(this.instance);
				}
				return r_m_FrameIndex;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextUpdateID
		/// </summary>
		protected RField r_m_NextUpdateID;
		public virtual RField Rm_NextUpdateID
		{
			get
			{
				if(r_m_NextUpdateID == null)
				{
					r_m_NextUpdateID = new(this, "m_NextUpdateID");
					r_m_NextUpdateID.SetBelong(this.instance);
				}
				return r_m_NextUpdateID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics m_DrawStats
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDrawStatistics r_m_DrawStats;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDrawStatistics Rm_DrawStats
		{
			get
			{
				if(r_m_DrawStats == null)
				{
					r_m_DrawStats = new(this, "m_DrawStats");
					r_m_DrawStats.SetBelong(this.instance);
				}
				return r_m_DrawStats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.LinkedPool`1[UnityEngine.UIElements.UIR.MeshHandle] m_MeshHandles
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RLinkedPool<RUnityEngine.RUIElements.RUIR.RMeshHandle> r_m_MeshHandles;
		public virtual RUnityEngine.RUIElements.RUIR.RLinkedPool<RUnityEngine.RUIElements.RUIR.RMeshHandle> Rm_MeshHandles
		{
			get
			{
				if(r_m_MeshHandles == null)
				{
					r_m_MeshHandles = new(this, "m_MeshHandles");
					r_m_MeshHandles.SetBelong(this.instance);
				}
				return r_m_MeshHandles;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.DrawParams m_DrawParams
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RDrawParams r_m_DrawParams;
		public virtual RUnityEngine.RUIElements.RUIR.RDrawParams Rm_DrawParams
		{
			get
			{
				if(r_m_DrawParams == null)
				{
					r_m_DrawParams = new(this, "m_DrawParams");
					r_m_DrawParams.SetBelong(this.instance);
				}
				return r_m_DrawParams;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TextureSlotManager m_TextureSlotManager
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTextureSlotManager r_m_TextureSlotManager;
		public virtual RUnityEngine.RUIElements.RUIR.RTextureSlotManager Rm_TextureSlotManager
		{
			get
			{
				if(r_m_TextureSlotManager == null)
				{
					r_m_TextureSlotManager = new(this, "m_TextureSlotManager");
					r_m_TextureSlotManager.SetBelong(this.instance);
				}
				return r_m_TextureSlotManager;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree] m_DeviceFreeQueue
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RLinkedList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDeviceToFree> r_m_DeviceFreeQueue;
		public static RSystem.RCollections.RGeneric.RLinkedList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDeviceToFree> Rm_DeviceFreeQueue
		{
			get
			{
				if(r_m_DeviceFreeQueue == null)
				{
					r_m_DeviceFreeQueue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_DeviceFreeQueue");
					r_m_DeviceFreeQueue.SetBelong(null);
				}
				return r_m_DeviceFreeQueue;
			}
		}

		/// <summary>
		/// System.Int32 m_ActiveDeviceCount
		/// </summary>
		protected static RField r_m_ActiveDeviceCount;
		public static RField Rm_ActiveDeviceCount
		{
			get
			{
				if(r_m_ActiveDeviceCount == null)
				{
					r_m_ActiveDeviceCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_ActiveDeviceCount");
					r_m_ActiveDeviceCount.SetBelong(null);
				}
				return r_m_ActiveDeviceCount;
			}
		}

		/// <summary>
		/// System.Boolean m_SubscribedToNotifications
		/// </summary>
		protected static RField r_m_SubscribedToNotifications;
		public static RField Rm_SubscribedToNotifications
		{
			get
			{
				if(r_m_SubscribedToNotifications == null)
				{
					r_m_SubscribedToNotifications = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_SubscribedToNotifications");
					r_m_SubscribedToNotifications.SetBelong(null);
				}
				return r_m_SubscribedToNotifications;
			}
		}

		/// <summary>
		/// System.Boolean m_SynchronousFree
		/// </summary>
		protected static RField r_m_SynchronousFree;
		public static RField Rm_SynchronousFree
		{
			get
			{
				if(r_m_SynchronousFree == null)
				{
					r_m_SynchronousFree = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_SynchronousFree");
					r_m_SynchronousFree.SetBelong(null);
				}
				return r_m_SynchronousFree;
			}
		}

		/// <summary>
		/// System.Int32 s_GradientSettingsTexID
		/// </summary>
		protected static RField r_s_GradientSettingsTexID;
		public static RField Rs_GradientSettingsTexID
		{
			get
			{
				if(r_s_GradientSettingsTexID == null)
				{
					r_s_GradientSettingsTexID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_GradientSettingsTexID");
					r_s_GradientSettingsTexID.SetBelong(null);
				}
				return r_s_GradientSettingsTexID;
			}
		}

		/// <summary>
		/// System.Int32 s_ShaderInfoTexID
		/// </summary>
		protected static RField r_s_ShaderInfoTexID;
		public static RField Rs_ShaderInfoTexID
		{
			get
			{
				if(r_s_ShaderInfoTexID == null)
				{
					r_s_ShaderInfoTexID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_ShaderInfoTexID");
					r_s_ShaderInfoTexID.SetBelong(null);
				}
				return r_s_ShaderInfoTexID;
			}
		}

		/// <summary>
		/// System.Int32 s_TransformsPropID
		/// </summary>
		protected static RField r_s_TransformsPropID;
		public static RField Rs_TransformsPropID
		{
			get
			{
				if(r_s_TransformsPropID == null)
				{
					r_s_TransformsPropID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_TransformsPropID");
					r_s_TransformsPropID.SetBelong(null);
				}
				return r_s_TransformsPropID;
			}
		}

		/// <summary>
		/// System.Int32 s_ClipRectsPropID
		/// </summary>
		protected static RField r_s_ClipRectsPropID;
		public static RField Rs_ClipRectsPropID
		{
			get
			{
				if(r_s_ClipRectsPropID == null)
				{
					r_s_ClipRectsPropID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_ClipRectsPropID");
					r_s_ClipRectsPropID.SetBelong(null);
				}
				return r_s_ClipRectsPropID;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerAllocate
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerAllocate;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerAllocate
		{
			get
			{
				if(r_s_MarkerAllocate == null)
				{
					r_s_MarkerAllocate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerAllocate");
					r_s_MarkerAllocate.SetBelong(null);
				}
				return r_s_MarkerAllocate;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerFree
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerFree;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerFree
		{
			get
			{
				if(r_s_MarkerFree == null)
				{
					r_s_MarkerFree = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerFree");
					r_s_MarkerFree.SetBelong(null);
				}
				return r_s_MarkerFree;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerAdvanceFrame
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerAdvanceFrame;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerAdvanceFrame
		{
			get
			{
				if(r_s_MarkerAdvanceFrame == null)
				{
					r_s_MarkerAdvanceFrame = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerAdvanceFrame");
					r_s_MarkerAdvanceFrame.SetBelong(null);
				}
				return r_s_MarkerAdvanceFrame;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerFence
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerFence;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerFence
		{
			get
			{
				if(r_s_MarkerFence == null)
				{
					r_s_MarkerFence = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerFence");
					r_s_MarkerFence.SetBelong(null);
				}
				return r_s_MarkerFence;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerBeforeDraw
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerBeforeDraw;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerBeforeDraw
		{
			get
			{
				if(r_s_MarkerBeforeDraw == null)
				{
					r_s_MarkerBeforeDraw = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerBeforeDraw");
					r_s_MarkerBeforeDraw.SetBelong(null);
				}
				return r_s_MarkerBeforeDraw;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] s_VertexTexturingIsAvailable
		/// </summary>
		protected static RField r_s_VertexTexturingIsAvailable;
		public static RField Rs_VertexTexturingIsAvailable
		{
			get
			{
				if(r_s_VertexTexturingIsAvailable == null)
				{
					r_s_VertexTexturingIsAvailable = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_VertexTexturingIsAvailable");
					r_s_VertexTexturingIsAvailable.SetBelong(null);
				}
				return r_s_VertexTexturingIsAvailable;
			}
		}

		/// <summary>
		/// System.String k_VertexTexturingIsAvailableTag
		/// </summary>
		protected static RField r_k_VertexTexturingIsAvailableTag;
		public static RField Rk_VertexTexturingIsAvailableTag
		{
			get
			{
				if(r_k_VertexTexturingIsAvailableTag == null)
				{
					r_k_VertexTexturingIsAvailableTag = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_VertexTexturingIsAvailableTag");
					r_k_VertexTexturingIsAvailableTag.SetBelong(null);
				}
				return r_k_VertexTexturingIsAvailableTag;
			}
		}

		/// <summary>
		/// System.String k_VertexTexturingIsAvailableTrue
		/// </summary>
		protected static RField r_k_VertexTexturingIsAvailableTrue;
		public static RField Rk_VertexTexturingIsAvailableTrue
		{
			get
			{
				if(r_k_VertexTexturingIsAvailableTrue == null)
				{
					r_k_VertexTexturingIsAvailableTrue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_VertexTexturingIsAvailableTrue");
					r_k_VertexTexturingIsAvailableTrue.SetBelong(null);
				}
				return r_k_VertexTexturingIsAvailableTrue;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] s_ShaderModelIs35
		/// </summary>
		protected static RField r_s_ShaderModelIs35;
		public static RField Rs_ShaderModelIs35
		{
			get
			{
				if(r_s_ShaderModelIs35 == null)
				{
					r_s_ShaderModelIs35 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_ShaderModelIs35");
					r_s_ShaderModelIs35.SetBelong(null);
				}
				return r_s_ShaderModelIs35;
			}
		}

		/// <summary>
		/// System.String k_ShaderModelIs35Tag
		/// </summary>
		protected static RField r_k_ShaderModelIs35Tag;
		public static RField Rk_ShaderModelIs35Tag
		{
			get
			{
				if(r_k_ShaderModelIs35Tag == null)
				{
					r_k_ShaderModelIs35Tag = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_ShaderModelIs35Tag");
					r_k_ShaderModelIs35Tag.SetBelong(null);
				}
				return r_k_ShaderModelIs35Tag;
			}
		}

		/// <summary>
		/// System.String k_ShaderModelIs35True
		/// </summary>
		protected static RField r_k_ShaderModelIs35True;
		public static RField Rk_ShaderModelIs35True
		{
			get
			{
				if(r_k_ShaderModelIs35True == null)
				{
					r_k_ShaderModelIs35True = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_ShaderModelIs35True");
					r_k_ShaderModelIs35True.SetBelong(null);
				}
				return r_k_ShaderModelIs35True;
			}
		}

		/// <summary>
		/// System.UInt32 <maxVerticesPerPage>k__BackingField
		/// </summary>
		protected RField r___0__maxVerticesPerPage__1__k__BackingField;
		public virtual RField R__0__maxVerticesPerPage__1__k__BackingField
		{
			get
			{
				if(r___0__maxVerticesPerPage__1__k__BackingField == null)
				{
					r___0__maxVerticesPerPage__1__k__BackingField = new(this, "<maxVerticesPerPage>k__BackingField");
					r___0__maxVerticesPerPage__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__maxVerticesPerPage__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <breakBatches>k__BackingField
		/// </summary>
		protected RField r___0__breakBatches__1__k__BackingField;
		public virtual RField R__0__breakBatches__1__k__BackingField
		{
			get
			{
				if(r___0__breakBatches__1__k__BackingField == null)
				{
					r___0__breakBatches__1__k__BackingField = new(this, "<breakBatches>k__BackingField");
					r___0__breakBatches__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__breakBatches__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`1[UnityEngine.Shader] getEditorShader
		/// </summary>
		protected static RSystem.RFunc<RUnityEngine.RShader> r_getEditorShader;
		public static RSystem.RFunc<RUnityEngine.RShader> RgetEditorShader
		{
			get
			{
				if(r_getEditorShader == null)
				{
					r_getEditorShader = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "getEditorShader");
					r_getEditorShader.SetBelong(null);
				}
				return r_getEditorShader;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D s_DefaultShaderInfoTexFloat
		/// </summary>
		protected static RUnityEngine.RTexture2D r_s_DefaultShaderInfoTexFloat;
		public static RUnityEngine.RTexture2D Rs_DefaultShaderInfoTexFloat
		{
			get
			{
				if(r_s_DefaultShaderInfoTexFloat == null)
				{
					r_s_DefaultShaderInfoTexFloat = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_DefaultShaderInfoTexFloat");
					r_s_DefaultShaderInfoTexFloat.SetBelong(null);
				}
				return r_s_DefaultShaderInfoTexFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D s_DefaultShaderInfoTexARGB8
		/// </summary>
		protected static RUnityEngine.RTexture2D r_s_DefaultShaderInfoTexARGB8;
		public static RUnityEngine.RTexture2D Rs_DefaultShaderInfoTexARGB8
		{
			get
			{
				if(r_s_DefaultShaderInfoTexARGB8 == null)
				{
					r_s_DefaultShaderInfoTexARGB8 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_DefaultShaderInfoTexARGB8");
					r_s_DefaultShaderInfoTexARGB8.SetBelong(null);
				}
				return r_s_DefaultShaderInfoTexARGB8;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RField r___0__disposed__1__k__BackingField;
		public virtual RField R__0__disposed__1__k__BackingField
		{
			get
			{
				if(r___0__disposed__1__k__BackingField == null)
				{
					r___0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r___0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// UInt32 maxVerticesPerPage
		/// </summary>
		protected RProperty r_maxVerticesPerPage;
		public virtual RProperty RmaxVerticesPerPage
		{
			get
			{
				if(r_maxVerticesPerPage == null)
				{
					r_maxVerticesPerPage = new(this, "maxVerticesPerPage", -1);
					r_maxVerticesPerPage.SetBelong(this.instance);
				}
				return r_maxVerticesPerPage;
			}
		}

		/// <summary>
		/// Boolean breakBatches
		/// </summary>
		protected RProperty r_breakBatches;
		public virtual RProperty RbreakBatches
		{
			get
			{
				if(r_breakBatches == null)
				{
					r_breakBatches = new(this, "breakBatches", -1);
					r_breakBatches.SetBelong(this.instance);
				}
				return r_breakBatches;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D defaultShaderInfoTexFloat
		/// </summary>
		protected static RUnityEngine.RTexture2D r_defaultShaderInfoTexFloat;
		public static RUnityEngine.RTexture2D RdefaultShaderInfoTexFloat
		{
			get
			{
				if(r_defaultShaderInfoTexFloat == null)
				{
					r_defaultShaderInfoTexFloat = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "defaultShaderInfoTexFloat", -1);
					r_defaultShaderInfoTexFloat.SetBelong(null);
				}
				return r_defaultShaderInfoTexFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D defaultShaderInfoTexARGB8
		/// </summary>
		protected static RUnityEngine.RTexture2D r_defaultShaderInfoTexARGB8;
		public static RUnityEngine.RTexture2D RdefaultShaderInfoTexARGB8
		{
			get
			{
				if(r_defaultShaderInfoTexARGB8 == null)
				{
					r_defaultShaderInfoTexARGB8 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "defaultShaderInfoTexARGB8", -1);
					r_defaultShaderInfoTexARGB8.SetBelong(null);
				}
				return r_defaultShaderInfoTexARGB8;
			}
		}

		/// <summary>
		/// Boolean vertexTexturingIsAvailable
		/// </summary>
		protected static RProperty r_vertexTexturingIsAvailable;
		public static RProperty RvertexTexturingIsAvailable
		{
			get
			{
				if(r_vertexTexturingIsAvailable == null)
				{
					r_vertexTexturingIsAvailable = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "vertexTexturingIsAvailable", -1);
					r_vertexTexturingIsAvailable.SetBelong(null);
				}
				return r_vertexTexturingIsAvailable;
			}
		}

		/// <summary>
		/// Boolean shaderModelIs35
		/// </summary>
		protected static RProperty r_shaderModelIs35;
		public static RProperty RshaderModelIs35
		{
			get
			{
				if(r_shaderModelIs35 == null)
				{
					r_shaderModelIs35 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "shaderModelIs35", -1);
					r_shaderModelIs35.SetBelong(null);
				}
				return r_shaderModelIs35;
			}
		}

		/// <summary>
		/// Boolean fullyCreated
		/// </summary>
		protected RProperty r_fullyCreated;
		public virtual RProperty RfullyCreated
		{
			get
			{
				if(r_fullyCreated == null)
				{
					r_fullyCreated = new(this, "fullyCreated", -1);
					r_fullyCreated.SetBelong(this.instance);
				}
				return r_fullyCreated;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RProperty r_disposed;
		public virtual RProperty Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed", -1);
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// Void InitVertexDeclaration()
		/// </summary>
		protected RMethod r_InitVertexDeclaration;
		public virtual RMethod RInitVertexDeclaration
		{
			get
			{
				if(r_InitVertexDeclaration == null)
				{
					r_InitVertexDeclaration = new(this, "InitVertexDeclaration", 0);
					r_InitVertexDeclaration.SetBelong(this.instance);
				}
				return r_InitVertexDeclaration;
			}
		}

		/// <summary>
		/// Void CompleteCreation()
		/// </summary>
		protected RMethod r_CompleteCreation;
		public virtual RMethod RCompleteCreation
		{
			get
			{
				if(r_CompleteCreation == null)
				{
					r_CompleteCreation = new(this, "CompleteCreation", 0);
					r_CompleteCreation.SetBelong(this.instance);
				}
				return r_CompleteCreation;
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
		/// Void DisposeImmediate()
		/// </summary>
		protected RMethod r_DisposeImmediate;
		public virtual RMethod RDisposeImmediate
		{
			get
			{
				if(r_DisposeImmediate == null)
				{
					r_DisposeImmediate = new(this, "DisposeImmediate", 0);
					r_DisposeImmediate.SetBelong(this.instance);
				}
				return r_DisposeImmediate;
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
		/// UnityEngine.UIElements.UIR.MeshHandle Allocate(UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, UInt16 ByRef)
		/// </summary>
		protected RMethod r_Allocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
		public virtual RMethod RAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16
		{
			get
			{
				if(r_Allocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 == null)
				{
					r_Allocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 = new(this, "Allocate", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.UInt16).MakeByRefType());
					r_Allocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16.SetBelong(this.instance);
				}
				return r_Allocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
			}
		}

		/// <summary>
		/// Void Update(UnityEngine.UIElements.UIR.MeshHandle, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef)
		/// </summary>
		protected RMethod r_Update_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_;
		public virtual RMethod RUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_
		{
			get
			{
				if(r_Update_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_ == null)
				{
					r_Update_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_ = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType());
					r_Update_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_.SetBelong(this.instance);
				}
				return r_Update_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_;
			}
		}

		/// <summary>
		/// Void Update(UnityEngine.UIElements.UIR.MeshHandle, UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, UInt16 ByRef)
		/// </summary>
		protected RMethod r_Update_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
		public virtual RMethod RUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16
		{
			get
			{
				if(r_Update_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 == null)
				{
					r_Update_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.UInt16).MakeByRefType());
					r_Update_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16.SetBelong(this.instance);
				}
				return r_Update_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
			}
		}

		/// <summary>
		/// Boolean TryAllocFromPage(UnityEngine.UIElements.UIR.Page, UInt32, UInt32, UnityEngine.UIElements.UIR.Alloc ByRef, UnityEngine.UIElements.UIR.Alloc ByRef, Boolean)
		/// </summary>
		protected RMethod r_TryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean;
		public virtual RMethod RTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean
		{
			get
			{
				if(r_TryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean == null)
				{
					r_TryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean = new(this, "TryAllocFromPage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Page"), typeof(System.UInt32), typeof(System.UInt32),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc").MakeByRefType(), typeof(System.Boolean));
					r_TryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean.SetBelong(this.instance);
				}
				return r_TryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean;
			}
		}

		/// <summary>
		/// Void Allocate(UnityEngine.UIElements.UIR.MeshHandle, UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, Boolean)
		/// </summary>
		protected RMethod r_Allocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean;
		public virtual RMethod RAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean
		{
			get
			{
				if(r_Allocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean == null)
				{
					r_Allocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean = new(this, "Allocate", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.Boolean));
					r_Allocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean.SetBelong(this.instance);
				}
				return r_Allocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean;
			}
		}

		/// <summary>
		/// Void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle, UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, UInt16 ByRef, AllocToUpdate ByRef, Boolean)
		/// </summary>
		protected RMethod r_UpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean;
		public virtual RMethod RUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean
		{
			get
			{
				if(r_UpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean == null)
				{
					r_UpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean = new(this, "UpdateAfterGPUUsedData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.UInt16).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate").MakeByRefType(), typeof(System.Boolean));
					r_UpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean.SetBelong(this.instance);
				}
				return r_UpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.MeshHandle)
		/// </summary>
		protected RMethod r_Free_MeshHandle;
		public virtual RMethod RFree_MeshHandle
		{
			get
			{
				if(r_Free_MeshHandle == null)
				{
					r_Free_MeshHandle = new(this, "Free", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"));
					r_Free_MeshHandle.SetBelong(this.instance);
				}
				return r_Free_MeshHandle;
			}
		}

		/// <summary>
		/// Void OnFrameRenderingBegin()
		/// </summary>
		protected RMethod r_OnFrameRenderingBegin;
		public virtual RMethod ROnFrameRenderingBegin
		{
			get
			{
				if(r_OnFrameRenderingBegin == null)
				{
					r_OnFrameRenderingBegin = new(this, "OnFrameRenderingBegin", 0);
					r_OnFrameRenderingBegin.SetBelong(this.instance);
				}
				return r_OnFrameRenderingBegin;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[T] PtrToSlice[T](Void*, Int32)
		/// </summary>
		protected static RMethod r_PtrToSlice_GT_VoidPointer_Int32;
		public static RMethod RPtrToSlice_GT_VoidPointer_Int32
		{
			get
			{
				if(r_PtrToSlice_GT_VoidPointer_Int32 == null)
				{
					r_PtrToSlice_GT_VoidPointer_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "PtrToSlice", 1, typeof(void).MakePointerType(), typeof(System.Int32));
					r_PtrToSlice_GT_VoidPointer_Int32.SetBelong(null);
				}
				return r_PtrToSlice_GT_VoidPointer_Int32;
			}
		}

		/// <summary>
		/// Void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand, Int32, UnityEngine.Material, Boolean, EvaluationState ByRef)
		/// </summary>
		protected RMethod r_ApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState;
		public virtual RMethod RApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState
		{
			get
			{
				if(r_ApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState == null)
				{
					r_ApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState = new(this, "ApplyDrawCommandState", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState").MakeByRefType());
					r_ApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState.SetBelong(this.instance);
				}
				return r_ApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState;
			}
		}

		/// <summary>
		/// Void ApplyBatchState(EvaluationState ByRef, Boolean)
		/// </summary>
		protected RMethod r_ApplyBatchState_Ref_EvaluationState_Boolean;
		public virtual RMethod RApplyBatchState_Ref_EvaluationState_Boolean
		{
			get
			{
				if(r_ApplyBatchState_Ref_EvaluationState_Boolean == null)
				{
					r_ApplyBatchState_Ref_EvaluationState_Boolean = new(this, "ApplyBatchState", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState").MakeByRefType(), typeof(System.Boolean));
					r_ApplyBatchState_Ref_EvaluationState_Boolean.SetBelong(this.instance);
				}
				return r_ApplyBatchState_Ref_EvaluationState_Boolean;
			}
		}

		/// <summary>
		/// Void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand, UnityEngine.Material, UnityEngine.Material, UnityEngine.Texture, UnityEngine.Texture, Single, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4], Unity.Collections.NativeSlice`1[UnityEngine.Vector4], UnityEngine.MaterialPropertyBlock, Boolean, System.Exception ByRef)
		/// </summary>
		protected RMethod r_EvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception;
		public virtual RMethod REvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception
		{
			get
			{
				if(r_EvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception == null)
				{
					r_EvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception = new(this, "EvaluateChain", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), typeof(UnityEngine.Material), typeof(UnityEngine.Material), typeof(UnityEngine.Texture), typeof(UnityEngine.Texture), typeof(System.Single), typeof(Unity.Collections.NativeSlice<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Transform3x4")), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Exception).MakeByRefType());
					r_EvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception.SetBelong(this.instance);
				}
				return r_EvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception;
			}
		}

		/// <summary>
		/// Void UpdateFenceValue()
		/// </summary>
		protected RMethod r_UpdateFenceValue;
		public virtual RMethod RUpdateFenceValue
		{
			get
			{
				if(r_UpdateFenceValue == null)
				{
					r_UpdateFenceValue = new(this, "UpdateFenceValue", 0);
					r_UpdateFenceValue.SetBelong(this.instance);
				}
				return r_UpdateFenceValue;
			}
		}

		/// <summary>
		/// Void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange*, Int32 ByRef, Int32 ByRef, Int32, UnityEngine.UIElements.UIR.Page)
		/// </summary>
		protected RMethod r_KickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page;
		public virtual RMethod RKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page
		{
			get
			{
				if(r_KickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page == null)
				{
					r_KickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page = new(this, "KickRanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawBufferRange").MakePointerType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Page"));
					r_KickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page.SetBelong(this.instance);
				}
				return r_KickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page;
			}
		}

		/// <summary>
		/// Void DrawRanges[I,T](GPUBuffer`1, GPUBuffer`1, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.DrawBufferRange])
		/// </summary>
		protected RMethod r_DrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_;
		public virtual RMethod RDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_
		{
			get
			{
				if(r_DrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_ == null)
				{
					r_DrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_ = new(this, "DrawRanges", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Utility+GPUBuffer`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Utility+GPUBuffer`1").MakeGenericType(Type.MakeGenericMethodParameter(1)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawBufferRange")));
					r_DrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_.SetBelong(this.instance);
				}
				return r_DrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_;
			}
		}

		/// <summary>
		/// Void WaitOnAllCpuFences()
		/// </summary>
		protected RMethod r_WaitOnAllCpuFences;
		public virtual RMethod RWaitOnAllCpuFences
		{
			get
			{
				if(r_WaitOnAllCpuFences == null)
				{
					r_WaitOnAllCpuFences = new(this, "WaitOnAllCpuFences", 0);
					r_WaitOnAllCpuFences.SetBelong(this.instance);
				}
				return r_WaitOnAllCpuFences;
			}
		}

		/// <summary>
		/// Void WaitOnCpuFence(UInt32)
		/// </summary>
		protected RMethod r_WaitOnCpuFence_UInt32;
		public virtual RMethod RWaitOnCpuFence_UInt32
		{
			get
			{
				if(r_WaitOnCpuFence_UInt32 == null)
				{
					r_WaitOnCpuFence_UInt32 = new(this, "WaitOnCpuFence", 0, typeof(System.UInt32));
					r_WaitOnCpuFence_UInt32.SetBelong(this.instance);
				}
				return r_WaitOnCpuFence_UInt32;
			}
		}

		/// <summary>
		/// Void AdvanceFrame()
		/// </summary>
		protected RMethod r_AdvanceFrame;
		public virtual RMethod RAdvanceFrame
		{
			get
			{
				if(r_AdvanceFrame == null)
				{
					r_AdvanceFrame = new(this, "AdvanceFrame", 0);
					r_AdvanceFrame.SetBelong(this.instance);
				}
				return r_AdvanceFrame;
			}
		}

		/// <summary>
		/// Void PruneUnusedPages()
		/// </summary>
		protected RMethod r_PruneUnusedPages;
		public virtual RMethod RPruneUnusedPages
		{
			get
			{
				if(r_PruneUnusedPages == null)
				{
					r_PruneUnusedPages = new(this, "PruneUnusedPages", 0);
					r_PruneUnusedPages.SetBelong(this.instance);
				}
				return r_PruneUnusedPages;
			}
		}

		/// <summary>
		/// Void PrepareForGfxDeviceRecreate()
		/// </summary>
		protected static RMethod r_PrepareForGfxDeviceRecreate;
		public static RMethod RPrepareForGfxDeviceRecreate
		{
			get
			{
				if(r_PrepareForGfxDeviceRecreate == null)
				{
					r_PrepareForGfxDeviceRecreate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "PrepareForGfxDeviceRecreate", 0);
					r_PrepareForGfxDeviceRecreate.SetBelong(null);
				}
				return r_PrepareForGfxDeviceRecreate;
			}
		}

		/// <summary>
		/// Void WrapUpGfxDeviceRecreate()
		/// </summary>
		protected static RMethod r_WrapUpGfxDeviceRecreate;
		public static RMethod RWrapUpGfxDeviceRecreate
		{
			get
			{
				if(r_WrapUpGfxDeviceRecreate == null)
				{
					r_WrapUpGfxDeviceRecreate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "WrapUpGfxDeviceRecreate", 0);
					r_WrapUpGfxDeviceRecreate.SetBelong(null);
				}
				return r_WrapUpGfxDeviceRecreate;
			}
		}

		/// <summary>
		/// Void FlushAllPendingDeviceDisposes()
		/// </summary>
		protected static RMethod r_FlushAllPendingDeviceDisposes;
		public static RMethod RFlushAllPendingDeviceDisposes
		{
			get
			{
				if(r_FlushAllPendingDeviceDisposes == null)
				{
					r_FlushAllPendingDeviceDisposes = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "FlushAllPendingDeviceDisposes", 0);
					r_FlushAllPendingDeviceDisposes.SetBelong(null);
				}
				return r_FlushAllPendingDeviceDisposes;
			}
		}

		/// <summary>
		/// AllocationStatistics GatherAllocationStatistics()
		/// </summary>
		protected RMethod r_GatherAllocationStatistics;
		public virtual RMethod RGatherAllocationStatistics
		{
			get
			{
				if(r_GatherAllocationStatistics == null)
				{
					r_GatherAllocationStatistics = new(this, "GatherAllocationStatistics", 0);
					r_GatherAllocationStatistics.SetBelong(this.instance);
				}
				return r_GatherAllocationStatistics;
			}
		}

		/// <summary>
		/// DrawStatistics GatherDrawStatistics()
		/// </summary>
		protected RMethod r_GatherDrawStatistics;
		public virtual RMethod RGatherDrawStatistics
		{
			get
			{
				if(r_GatherDrawStatistics == null)
				{
					r_GatherDrawStatistics = new(this, "GatherDrawStatistics", 0);
					r_GatherDrawStatistics.SetBelong(this.instance);
				}
				return r_GatherDrawStatistics;
			}
		}

		/// <summary>
		/// Void ProcessDeviceFreeQueue()
		/// </summary>
		protected static RMethod r_ProcessDeviceFreeQueue;
		public static RMethod RProcessDeviceFreeQueue
		{
			get
			{
				if(r_ProcessDeviceFreeQueue == null)
				{
					r_ProcessDeviceFreeQueue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "ProcessDeviceFreeQueue", 0);
					r_ProcessDeviceFreeQueue.SetBelong(null);
				}
				return r_ProcessDeviceFreeQueue;
			}
		}

		/// <summary>
		/// Void OnEngineUpdateGlobal()
		/// </summary>
		protected static RMethod r_OnEngineUpdateGlobal;
		public static RMethod ROnEngineUpdateGlobal
		{
			get
			{
				if(r_OnEngineUpdateGlobal == null)
				{
					r_OnEngineUpdateGlobal = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "OnEngineUpdateGlobal", 0);
					r_OnEngineUpdateGlobal.SetBelong(null);
				}
				return r_OnEngineUpdateGlobal;
			}
		}

		/// <summary>
		/// Void OnFlushPendingResources()
		/// </summary>
		protected static RMethod r_OnFlushPendingResources;
		public static RMethod ROnFlushPendingResources
		{
			get
			{
				if(r_OnFlushPendingResources == null)
				{
					r_OnFlushPendingResources = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "OnFlushPendingResources", 0);
					r_OnFlushPendingResources.SetBelong(null);
				}
				return r_OnFlushPendingResources;
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


        public RUIRenderDevice() : base("UnityEngine.UIElements.UIR.UIRenderDevice")
        {
        }

        public RUIRenderDevice(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice")
		{
            SetInstance(instance);
		}

        public RUIRenderDevice(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIRenderDevice(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void InitVertexDeclaration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitVertexDeclaration.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteCreation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteCreation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisposeImmediate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeImmediate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }









        public virtual void OnFrameRenderingBegin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnFrameRenderingBegin.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void UpdateFenceValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateFenceValue.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void WaitOnAllCpuFences()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitOnAllCpuFences.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnCpuFence(System.UInt32  @fence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence};
            var ___result = RWaitOnCpuFence_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AdvanceFrame()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAdvanceFrame.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PruneUnusedPages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPruneUnusedPages.Invoke(___genericsType, ___parameters);

            
        }


        public static void PrepareForGfxDeviceRecreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareForGfxDeviceRecreate.Invoke(___genericsType, ___parameters);

            
        }


        public static void WrapUpGfxDeviceRecreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWrapUpGfxDeviceRecreate.Invoke(___genericsType, ___parameters);

            
        }


        public static void FlushAllPendingDeviceDisposes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAllPendingDeviceDisposes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GatherAllocationStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherAllocationStatistics.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GatherDrawStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherDrawStatistics.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void ProcessDeviceFreeQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessDeviceFreeQueue.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnEngineUpdateGlobal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEngineUpdateGlobal.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnFlushPendingResources()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnFlushPendingResources.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
