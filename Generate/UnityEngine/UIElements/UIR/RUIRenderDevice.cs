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
		protected static RSystem.RUInt32 r_Fk_MaxQueuedFrameCount;
		public static RSystem.RUInt32 RFk_MaxQueuedFrameCount
		{
			get
			{
				if(r_Fk_MaxQueuedFrameCount == null)
				{
					r_Fk_MaxQueuedFrameCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_MaxQueuedFrameCount");
					r_Fk_MaxQueuedFrameCount.SetBelong(null);
				}
				return r_Fk_MaxQueuedFrameCount;
			}
		}

		/// <summary>
		/// System.Int32 k_PruneEmptyPageFrameCount
		/// </summary>
		protected static RSystem.RInt32 r_Fk_PruneEmptyPageFrameCount;
		public static RSystem.RInt32 RFk_PruneEmptyPageFrameCount
		{
			get
			{
				if(r_Fk_PruneEmptyPageFrameCount == null)
				{
					r_Fk_PruneEmptyPageFrameCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_PruneEmptyPageFrameCount");
					r_Fk_PruneEmptyPageFrameCount.SetBelong(null);
				}
				return r_Fk_PruneEmptyPageFrameCount;
			}
		}

		/// <summary>
		/// System.Boolean m_MockDevice
		/// </summary>
		protected RSystem.RBoolean r_Fm_MockDevice;
		public virtual RSystem.RBoolean RFm_MockDevice
		{
			get
			{
				if(r_Fm_MockDevice == null)
				{
					r_Fm_MockDevice = new(this, "m_MockDevice");
					r_Fm_MockDevice.SetBelong(this.instance);
				}
				return r_Fm_MockDevice;
			}
		}

		/// <summary>
		/// System.IntPtr m_DefaultStencilState
		/// </summary>
		protected RSystem.RIntPtr r_Fm_DefaultStencilState;
		public virtual RSystem.RIntPtr RFm_DefaultStencilState
		{
			get
			{
				if(r_Fm_DefaultStencilState == null)
				{
					r_Fm_DefaultStencilState = new(this, "m_DefaultStencilState");
					r_Fm_DefaultStencilState.SetBelong(this.instance);
				}
				return r_Fm_DefaultStencilState;
			}
		}

		/// <summary>
		/// System.IntPtr m_VertexDecl
		/// </summary>
		protected RSystem.RIntPtr r_Fm_VertexDecl;
		public virtual RSystem.RIntPtr RFm_VertexDecl
		{
			get
			{
				if(r_Fm_VertexDecl == null)
				{
					r_Fm_VertexDecl = new(this, "m_VertexDecl");
					r_Fm_VertexDecl.SetBelong(this.instance);
				}
				return r_Fm_VertexDecl;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page m_FirstPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_Fm_FirstPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RFm_FirstPage
		{
			get
			{
				if(r_Fm_FirstPage == null)
				{
					r_Fm_FirstPage = new(this, "m_FirstPage");
					r_Fm_FirstPage.SetBelong(this.instance);
				}
				return r_Fm_FirstPage;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextPageVertexCount
		/// </summary>
		protected RSystem.RUInt32 r_Fm_NextPageVertexCount;
		public virtual RSystem.RUInt32 RFm_NextPageVertexCount
		{
			get
			{
				if(r_Fm_NextPageVertexCount == null)
				{
					r_Fm_NextPageVertexCount = new(this, "m_NextPageVertexCount");
					r_Fm_NextPageVertexCount.SetBelong(this.instance);
				}
				return r_Fm_NextPageVertexCount;
			}
		}

		/// <summary>
		/// System.UInt32 m_LargeMeshVertexCount
		/// </summary>
		protected RSystem.RUInt32 r_Fm_LargeMeshVertexCount;
		public virtual RSystem.RUInt32 RFm_LargeMeshVertexCount
		{
			get
			{
				if(r_Fm_LargeMeshVertexCount == null)
				{
					r_Fm_LargeMeshVertexCount = new(this, "m_LargeMeshVertexCount");
					r_Fm_LargeMeshVertexCount.SetBelong(this.instance);
				}
				return r_Fm_LargeMeshVertexCount;
			}
		}

		/// <summary>
		/// System.Single m_IndexToVertexCountRatio
		/// </summary>
		protected RSystem.RSingle r_Fm_IndexToVertexCountRatio;
		public virtual RSystem.RSingle RFm_IndexToVertexCountRatio
		{
			get
			{
				if(r_Fm_IndexToVertexCountRatio == null)
				{
					r_Fm_IndexToVertexCountRatio = new(this, "m_IndexToVertexCountRatio");
					r_Fm_IndexToVertexCountRatio.SetBelong(this.instance);
				}
				return r_Fm_IndexToVertexCountRatio;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.UIRenderDevice+AllocToFree]] m_DeferredFrees
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToFree>> r_Fm_DeferredFrees;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToFree>> RFm_DeferredFrees
		{
			get
			{
				if(r_Fm_DeferredFrees == null)
				{
					r_Fm_DeferredFrees = new(this, "m_DeferredFrees");
					r_Fm_DeferredFrees.SetBelong(this.instance);
				}
				return r_Fm_DeferredFrees;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate]] m_Updates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToUpdate>> r_Fm_Updates;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToUpdate>> RFm_Updates
		{
			get
			{
				if(r_Fm_Updates == null)
				{
					r_Fm_Updates = new(this, "m_Updates");
					r_Fm_Updates.SetBelong(this.instance);
				}
				return r_Fm_Updates;
			}
		}

		/// <summary>
		/// System.UInt32[] m_Fences
		/// </summary>
		protected RFieldArray<RSystem.RUInt32> r_Fm_Fences;
		public virtual RFieldArray<RSystem.RUInt32> RFm_Fences
		{
			get
			{
				if(r_Fm_Fences == null)
				{
					r_Fm_Fences = new(this, "m_Fences");
					r_Fm_Fences.SetBelong(this.instance);
				}
				return r_Fm_Fences;
			}
		}

		/// <summary>
		/// UnityEngine.MaterialPropertyBlock m_StandardMatProps
		/// </summary>
		protected RUnityEngine.RMaterialPropertyBlock r_Fm_StandardMatProps;
		public virtual RUnityEngine.RMaterialPropertyBlock RFm_StandardMatProps
		{
			get
			{
				if(r_Fm_StandardMatProps == null)
				{
					r_Fm_StandardMatProps = new(this, "m_StandardMatProps");
					r_Fm_StandardMatProps.SetBelong(this.instance);
				}
				return r_Fm_StandardMatProps;
			}
		}

		/// <summary>
		/// System.UInt32 m_FrameIndex
		/// </summary>
		protected RSystem.RUInt32 r_Fm_FrameIndex;
		public virtual RSystem.RUInt32 RFm_FrameIndex
		{
			get
			{
				if(r_Fm_FrameIndex == null)
				{
					r_Fm_FrameIndex = new(this, "m_FrameIndex");
					r_Fm_FrameIndex.SetBelong(this.instance);
				}
				return r_Fm_FrameIndex;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextUpdateID
		/// </summary>
		protected RSystem.RUInt32 r_Fm_NextUpdateID;
		public virtual RSystem.RUInt32 RFm_NextUpdateID
		{
			get
			{
				if(r_Fm_NextUpdateID == null)
				{
					r_Fm_NextUpdateID = new(this, "m_NextUpdateID");
					r_Fm_NextUpdateID.SetBelong(this.instance);
				}
				return r_Fm_NextUpdateID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics m_DrawStats
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDrawStatistics r_Fm_DrawStats;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDrawStatistics RFm_DrawStats
		{
			get
			{
				if(r_Fm_DrawStats == null)
				{
					r_Fm_DrawStats = new(this, "m_DrawStats");
					r_Fm_DrawStats.SetBelong(this.instance);
				}
				return r_Fm_DrawStats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.LinkedPool`1[UnityEngine.UIElements.UIR.MeshHandle] m_MeshHandles
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RLinkedPool<RUnityEngine.RUIElements.RUIR.RMeshHandle> r_Fm_MeshHandles;
		public virtual RUnityEngine.RUIElements.RUIR.RLinkedPool<RUnityEngine.RUIElements.RUIR.RMeshHandle> RFm_MeshHandles
		{
			get
			{
				if(r_Fm_MeshHandles == null)
				{
					r_Fm_MeshHandles = new(this, "m_MeshHandles");
					r_Fm_MeshHandles.SetBelong(this.instance);
				}
				return r_Fm_MeshHandles;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.DrawParams m_DrawParams
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RDrawParams r_Fm_DrawParams;
		public virtual RUnityEngine.RUIElements.RUIR.RDrawParams RFm_DrawParams
		{
			get
			{
				if(r_Fm_DrawParams == null)
				{
					r_Fm_DrawParams = new(this, "m_DrawParams");
					r_Fm_DrawParams.SetBelong(this.instance);
				}
				return r_Fm_DrawParams;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TextureSlotManager m_TextureSlotManager
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTextureSlotManager r_Fm_TextureSlotManager;
		public virtual RUnityEngine.RUIElements.RUIR.RTextureSlotManager RFm_TextureSlotManager
		{
			get
			{
				if(r_Fm_TextureSlotManager == null)
				{
					r_Fm_TextureSlotManager = new(this, "m_TextureSlotManager");
					r_Fm_TextureSlotManager.SetBelong(this.instance);
				}
				return r_Fm_TextureSlotManager;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree] m_DeviceFreeQueue
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RLinkedList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDeviceToFree> r_Fm_DeviceFreeQueue;
		public static RSystem.RCollections.RGeneric.RLinkedList<RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDeviceToFree> RFm_DeviceFreeQueue
		{
			get
			{
				if(r_Fm_DeviceFreeQueue == null)
				{
					r_Fm_DeviceFreeQueue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_DeviceFreeQueue");
					r_Fm_DeviceFreeQueue.SetBelong(null);
				}
				return r_Fm_DeviceFreeQueue;
			}
		}

		/// <summary>
		/// System.Int32 m_ActiveDeviceCount
		/// </summary>
		protected static RSystem.RInt32 r_Fm_ActiveDeviceCount;
		public static RSystem.RInt32 RFm_ActiveDeviceCount
		{
			get
			{
				if(r_Fm_ActiveDeviceCount == null)
				{
					r_Fm_ActiveDeviceCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_ActiveDeviceCount");
					r_Fm_ActiveDeviceCount.SetBelong(null);
				}
				return r_Fm_ActiveDeviceCount;
			}
		}

		/// <summary>
		/// System.Boolean m_SubscribedToNotifications
		/// </summary>
		protected static RSystem.RBoolean r_Fm_SubscribedToNotifications;
		public static RSystem.RBoolean RFm_SubscribedToNotifications
		{
			get
			{
				if(r_Fm_SubscribedToNotifications == null)
				{
					r_Fm_SubscribedToNotifications = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_SubscribedToNotifications");
					r_Fm_SubscribedToNotifications.SetBelong(null);
				}
				return r_Fm_SubscribedToNotifications;
			}
		}

		/// <summary>
		/// System.Boolean m_SynchronousFree
		/// </summary>
		protected static RSystem.RBoolean r_Fm_SynchronousFree;
		public static RSystem.RBoolean RFm_SynchronousFree
		{
			get
			{
				if(r_Fm_SynchronousFree == null)
				{
					r_Fm_SynchronousFree = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "m_SynchronousFree");
					r_Fm_SynchronousFree.SetBelong(null);
				}
				return r_Fm_SynchronousFree;
			}
		}

		/// <summary>
		/// System.Int32 s_GradientSettingsTexID
		/// </summary>
		protected static RSystem.RInt32 r_Fs_GradientSettingsTexID;
		public static RSystem.RInt32 RFs_GradientSettingsTexID
		{
			get
			{
				if(r_Fs_GradientSettingsTexID == null)
				{
					r_Fs_GradientSettingsTexID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_GradientSettingsTexID");
					r_Fs_GradientSettingsTexID.SetBelong(null);
				}
				return r_Fs_GradientSettingsTexID;
			}
		}

		/// <summary>
		/// System.Int32 s_ShaderInfoTexID
		/// </summary>
		protected static RSystem.RInt32 r_Fs_ShaderInfoTexID;
		public static RSystem.RInt32 RFs_ShaderInfoTexID
		{
			get
			{
				if(r_Fs_ShaderInfoTexID == null)
				{
					r_Fs_ShaderInfoTexID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_ShaderInfoTexID");
					r_Fs_ShaderInfoTexID.SetBelong(null);
				}
				return r_Fs_ShaderInfoTexID;
			}
		}

		/// <summary>
		/// System.Int32 s_TransformsPropID
		/// </summary>
		protected static RSystem.RInt32 r_Fs_TransformsPropID;
		public static RSystem.RInt32 RFs_TransformsPropID
		{
			get
			{
				if(r_Fs_TransformsPropID == null)
				{
					r_Fs_TransformsPropID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_TransformsPropID");
					r_Fs_TransformsPropID.SetBelong(null);
				}
				return r_Fs_TransformsPropID;
			}
		}

		/// <summary>
		/// System.Int32 s_ClipRectsPropID
		/// </summary>
		protected static RSystem.RInt32 r_Fs_ClipRectsPropID;
		public static RSystem.RInt32 RFs_ClipRectsPropID
		{
			get
			{
				if(r_Fs_ClipRectsPropID == null)
				{
					r_Fs_ClipRectsPropID = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_ClipRectsPropID");
					r_Fs_ClipRectsPropID.SetBelong(null);
				}
				return r_Fs_ClipRectsPropID;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerAllocate
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerAllocate;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerAllocate
		{
			get
			{
				if(r_Fs_MarkerAllocate == null)
				{
					r_Fs_MarkerAllocate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerAllocate");
					r_Fs_MarkerAllocate.SetBelong(null);
				}
				return r_Fs_MarkerAllocate;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerFree
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerFree;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerFree
		{
			get
			{
				if(r_Fs_MarkerFree == null)
				{
					r_Fs_MarkerFree = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerFree");
					r_Fs_MarkerFree.SetBelong(null);
				}
				return r_Fs_MarkerFree;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerAdvanceFrame
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerAdvanceFrame;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerAdvanceFrame
		{
			get
			{
				if(r_Fs_MarkerAdvanceFrame == null)
				{
					r_Fs_MarkerAdvanceFrame = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerAdvanceFrame");
					r_Fs_MarkerAdvanceFrame.SetBelong(null);
				}
				return r_Fs_MarkerAdvanceFrame;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerFence
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerFence;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerFence
		{
			get
			{
				if(r_Fs_MarkerFence == null)
				{
					r_Fs_MarkerFence = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerFence");
					r_Fs_MarkerFence.SetBelong(null);
				}
				return r_Fs_MarkerFence;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerBeforeDraw
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerBeforeDraw;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerBeforeDraw
		{
			get
			{
				if(r_Fs_MarkerBeforeDraw == null)
				{
					r_Fs_MarkerBeforeDraw = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_MarkerBeforeDraw");
					r_Fs_MarkerBeforeDraw.SetBelong(null);
				}
				return r_Fs_MarkerBeforeDraw;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] s_VertexTexturingIsAvailable
		/// </summary>
		protected static RSystem.RNullable<RSystem.RBoolean> r_Fs_VertexTexturingIsAvailable;
		public static RSystem.RNullable<RSystem.RBoolean> RFs_VertexTexturingIsAvailable
		{
			get
			{
				if(r_Fs_VertexTexturingIsAvailable == null)
				{
					r_Fs_VertexTexturingIsAvailable = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_VertexTexturingIsAvailable");
					r_Fs_VertexTexturingIsAvailable.SetBelong(null);
				}
				return r_Fs_VertexTexturingIsAvailable;
			}
		}

		/// <summary>
		/// System.String k_VertexTexturingIsAvailableTag
		/// </summary>
		protected static RSystem.RString r_Fk_VertexTexturingIsAvailableTag;
		public static RSystem.RString RFk_VertexTexturingIsAvailableTag
		{
			get
			{
				if(r_Fk_VertexTexturingIsAvailableTag == null)
				{
					r_Fk_VertexTexturingIsAvailableTag = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_VertexTexturingIsAvailableTag");
					r_Fk_VertexTexturingIsAvailableTag.SetBelong(null);
				}
				return r_Fk_VertexTexturingIsAvailableTag;
			}
		}

		/// <summary>
		/// System.String k_VertexTexturingIsAvailableTrue
		/// </summary>
		protected static RSystem.RString r_Fk_VertexTexturingIsAvailableTrue;
		public static RSystem.RString RFk_VertexTexturingIsAvailableTrue
		{
			get
			{
				if(r_Fk_VertexTexturingIsAvailableTrue == null)
				{
					r_Fk_VertexTexturingIsAvailableTrue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_VertexTexturingIsAvailableTrue");
					r_Fk_VertexTexturingIsAvailableTrue.SetBelong(null);
				}
				return r_Fk_VertexTexturingIsAvailableTrue;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] s_ShaderModelIs35
		/// </summary>
		protected static RSystem.RNullable<RSystem.RBoolean> r_Fs_ShaderModelIs35;
		public static RSystem.RNullable<RSystem.RBoolean> RFs_ShaderModelIs35
		{
			get
			{
				if(r_Fs_ShaderModelIs35 == null)
				{
					r_Fs_ShaderModelIs35 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_ShaderModelIs35");
					r_Fs_ShaderModelIs35.SetBelong(null);
				}
				return r_Fs_ShaderModelIs35;
			}
		}

		/// <summary>
		/// System.String k_ShaderModelIs35Tag
		/// </summary>
		protected static RSystem.RString r_Fk_ShaderModelIs35Tag;
		public static RSystem.RString RFk_ShaderModelIs35Tag
		{
			get
			{
				if(r_Fk_ShaderModelIs35Tag == null)
				{
					r_Fk_ShaderModelIs35Tag = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_ShaderModelIs35Tag");
					r_Fk_ShaderModelIs35Tag.SetBelong(null);
				}
				return r_Fk_ShaderModelIs35Tag;
			}
		}

		/// <summary>
		/// System.String k_ShaderModelIs35True
		/// </summary>
		protected static RSystem.RString r_Fk_ShaderModelIs35True;
		public static RSystem.RString RFk_ShaderModelIs35True
		{
			get
			{
				if(r_Fk_ShaderModelIs35True == null)
				{
					r_Fk_ShaderModelIs35True = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "k_ShaderModelIs35True");
					r_Fk_ShaderModelIs35True.SetBelong(null);
				}
				return r_Fk_ShaderModelIs35True;
			}
		}

		/// <summary>
		/// System.UInt32 <maxVerticesPerPage>k__BackingField
		/// </summary>
		protected RSystem.RUInt32 r_F__0__maxVerticesPerPage__1__k__BackingField;
		public virtual RSystem.RUInt32 RF__0__maxVerticesPerPage__1__k__BackingField
		{
			get
			{
				if(r_F__0__maxVerticesPerPage__1__k__BackingField == null)
				{
					r_F__0__maxVerticesPerPage__1__k__BackingField = new(this, "<maxVerticesPerPage>k__BackingField");
					r_F__0__maxVerticesPerPage__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__maxVerticesPerPage__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <breakBatches>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__breakBatches__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__breakBatches__1__k__BackingField
		{
			get
			{
				if(r_F__0__breakBatches__1__k__BackingField == null)
				{
					r_F__0__breakBatches__1__k__BackingField = new(this, "<breakBatches>k__BackingField");
					r_F__0__breakBatches__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__breakBatches__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`1[UnityEngine.Shader] getEditorShader
		/// </summary>
		protected static RSystem.RFunc<RUnityEngine.RShader> r_FgetEditorShader;
		public static RSystem.RFunc<RUnityEngine.RShader> RFgetEditorShader
		{
			get
			{
				if(r_FgetEditorShader == null)
				{
					r_FgetEditorShader = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "getEditorShader");
					r_FgetEditorShader.SetBelong(null);
				}
				return r_FgetEditorShader;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D s_DefaultShaderInfoTexFloat
		/// </summary>
		protected static RUnityEngine.RTexture2D r_Fs_DefaultShaderInfoTexFloat;
		public static RUnityEngine.RTexture2D RFs_DefaultShaderInfoTexFloat
		{
			get
			{
				if(r_Fs_DefaultShaderInfoTexFloat == null)
				{
					r_Fs_DefaultShaderInfoTexFloat = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_DefaultShaderInfoTexFloat");
					r_Fs_DefaultShaderInfoTexFloat.SetBelong(null);
				}
				return r_Fs_DefaultShaderInfoTexFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D s_DefaultShaderInfoTexARGB8
		/// </summary>
		protected static RUnityEngine.RTexture2D r_Fs_DefaultShaderInfoTexARGB8;
		public static RUnityEngine.RTexture2D RFs_DefaultShaderInfoTexARGB8
		{
			get
			{
				if(r_Fs_DefaultShaderInfoTexARGB8 == null)
				{
					r_Fs_DefaultShaderInfoTexARGB8 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "s_DefaultShaderInfoTexARGB8");
					r_Fs_DefaultShaderInfoTexARGB8.SetBelong(null);
				}
				return r_Fs_DefaultShaderInfoTexARGB8;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r_F__0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// UInt32 maxVerticesPerPage
		/// </summary>
		protected RSystem.RUInt32 r_PmaxVerticesPerPage;
		public virtual RSystem.RUInt32 RPmaxVerticesPerPage
		{
			get
			{
				if(r_PmaxVerticesPerPage == null)
				{
					r_PmaxVerticesPerPage = new(this, "maxVerticesPerPage", -1);
					r_PmaxVerticesPerPage.SetBelong(this.instance);
				}
				return r_PmaxVerticesPerPage;
			}
		}

		/// <summary>
		/// Boolean breakBatches
		/// </summary>
		protected RSystem.RBoolean r_PbreakBatches;
		public virtual RSystem.RBoolean RPbreakBatches
		{
			get
			{
				if(r_PbreakBatches == null)
				{
					r_PbreakBatches = new(this, "breakBatches", -1);
					r_PbreakBatches.SetBelong(this.instance);
				}
				return r_PbreakBatches;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D defaultShaderInfoTexFloat
		/// </summary>
		protected static RUnityEngine.RTexture2D r_PdefaultShaderInfoTexFloat;
		public static RUnityEngine.RTexture2D RPdefaultShaderInfoTexFloat
		{
			get
			{
				if(r_PdefaultShaderInfoTexFloat == null)
				{
					r_PdefaultShaderInfoTexFloat = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "defaultShaderInfoTexFloat", -1);
					r_PdefaultShaderInfoTexFloat.SetBelong(null);
				}
				return r_PdefaultShaderInfoTexFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D defaultShaderInfoTexARGB8
		/// </summary>
		protected static RUnityEngine.RTexture2D r_PdefaultShaderInfoTexARGB8;
		public static RUnityEngine.RTexture2D RPdefaultShaderInfoTexARGB8
		{
			get
			{
				if(r_PdefaultShaderInfoTexARGB8 == null)
				{
					r_PdefaultShaderInfoTexARGB8 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "defaultShaderInfoTexARGB8", -1);
					r_PdefaultShaderInfoTexARGB8.SetBelong(null);
				}
				return r_PdefaultShaderInfoTexARGB8;
			}
		}

		/// <summary>
		/// Boolean vertexTexturingIsAvailable
		/// </summary>
		protected static RSystem.RBoolean r_PvertexTexturingIsAvailable;
		public static RSystem.RBoolean RPvertexTexturingIsAvailable
		{
			get
			{
				if(r_PvertexTexturingIsAvailable == null)
				{
					r_PvertexTexturingIsAvailable = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "vertexTexturingIsAvailable", -1);
					r_PvertexTexturingIsAvailable.SetBelong(null);
				}
				return r_PvertexTexturingIsAvailable;
			}
		}

		/// <summary>
		/// Boolean shaderModelIs35
		/// </summary>
		protected static RSystem.RBoolean r_PshaderModelIs35;
		public static RSystem.RBoolean RPshaderModelIs35
		{
			get
			{
				if(r_PshaderModelIs35 == null)
				{
					r_PshaderModelIs35 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "shaderModelIs35", -1);
					r_PshaderModelIs35.SetBelong(null);
				}
				return r_PshaderModelIs35;
			}
		}

		/// <summary>
		/// Boolean fullyCreated
		/// </summary>
		protected RSystem.RBoolean r_PfullyCreated;
		public virtual RSystem.RBoolean RPfullyCreated
		{
			get
			{
				if(r_PfullyCreated == null)
				{
					r_PfullyCreated = new(this, "fullyCreated", -1);
					r_PfullyCreated.SetBelong(this.instance);
				}
				return r_PfullyCreated;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RSystem.RBoolean r_Pdisposed;
		public virtual RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
					r_Pdisposed.SetBelong(this.instance);
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// Void InitVertexDeclaration()
		/// </summary>
		protected RMethod r_MInitVertexDeclaration;
		public virtual RMethod RMInitVertexDeclaration
		{
			get
			{
				if(r_MInitVertexDeclaration == null)
				{
					r_MInitVertexDeclaration = new(this, "InitVertexDeclaration", 0);
					r_MInitVertexDeclaration.SetBelong(this.instance);
				}
				return r_MInitVertexDeclaration;
			}
		}

		/// <summary>
		/// Void CompleteCreation()
		/// </summary>
		protected RMethod r_MCompleteCreation;
		public virtual RMethod RMCompleteCreation
		{
			get
			{
				if(r_MCompleteCreation == null)
				{
					r_MCompleteCreation = new(this, "CompleteCreation", 0);
					r_MCompleteCreation.SetBelong(this.instance);
				}
				return r_MCompleteCreation;
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
		/// Void DisposeImmediate()
		/// </summary>
		protected RMethod r_MDisposeImmediate;
		public virtual RMethod RMDisposeImmediate
		{
			get
			{
				if(r_MDisposeImmediate == null)
				{
					r_MDisposeImmediate = new(this, "DisposeImmediate", 0);
					r_MDisposeImmediate.SetBelong(this.instance);
				}
				return r_MDisposeImmediate;
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
		/// UnityEngine.UIElements.UIR.MeshHandle Allocate(UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, UInt16 ByRef)
		/// </summary>
		protected RMethod r_MAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
		public virtual RMethod RMAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16
		{
			get
			{
				if(r_MAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 == null)
				{
					r_MAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 = new(this, "Allocate", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.UInt16).MakeByRefType());
					r_MAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16.SetBelong(this.instance);
				}
				return r_MAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
			}
		}

		/// <summary>
		/// Void Update(UnityEngine.UIElements.UIR.MeshHandle, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef)
		/// </summary>
		protected RMethod r_MUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_;
		public virtual RMethod RMUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_
		{
			get
			{
				if(r_MUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_ == null)
				{
					r_MUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_ = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType());
					r_MUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_.SetBelong(this.instance);
				}
				return r_MUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_;
			}
		}

		/// <summary>
		/// Void Update(UnityEngine.UIElements.UIR.MeshHandle, UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, UInt16 ByRef)
		/// </summary>
		protected RMethod r_MUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
		public virtual RMethod RMUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16
		{
			get
			{
				if(r_MUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 == null)
				{
					r_MUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16 = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.UInt16).MakeByRefType());
					r_MUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16.SetBelong(this.instance);
				}
				return r_MUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16;
			}
		}

		/// <summary>
		/// Boolean TryAllocFromPage(UnityEngine.UIElements.UIR.Page, UInt32, UInt32, UnityEngine.UIElements.UIR.Alloc ByRef, UnityEngine.UIElements.UIR.Alloc ByRef, Boolean)
		/// </summary>
		protected RMethod r_MTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean;
		public virtual RMethod RMTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean
		{
			get
			{
				if(r_MTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean == null)
				{
					r_MTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean = new(this, "TryAllocFromPage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Page"), typeof(System.UInt32), typeof(System.UInt32),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc").MakeByRefType(), typeof(System.Boolean));
					r_MTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean.SetBelong(this.instance);
				}
				return r_MTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean;
			}
		}

		/// <summary>
		/// Void Allocate(UnityEngine.UIElements.UIR.MeshHandle, UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, Boolean)
		/// </summary>
		protected RMethod r_MAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean;
		public virtual RMethod RMAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean
		{
			get
			{
				if(r_MAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean == null)
				{
					r_MAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean = new(this, "Allocate", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.Boolean));
					r_MAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean.SetBelong(this.instance);
				}
				return r_MAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean;
			}
		}

		/// <summary>
		/// Void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle, UInt32, UInt32, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] ByRef, Unity.Collections.NativeSlice`1[System.UInt16] ByRef, UInt16 ByRef, AllocToUpdate ByRef, Boolean)
		/// </summary>
		protected RMethod r_MUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean;
		public virtual RMethod RMUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean
		{
			get
			{
				if(r_MUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean == null)
				{
					r_MUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean = new(this, "UpdateAfterGPUUsedData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"), typeof(System.UInt32), typeof(System.UInt32), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)).MakeByRefType(), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)).MakeByRefType(), typeof(System.UInt16).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate").MakeByRefType(), typeof(System.Boolean));
					r_MUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean.SetBelong(this.instance);
				}
				return r_MUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.MeshHandle)
		/// </summary>
		protected RMethod r_MFree_MeshHandle;
		public virtual RMethod RMFree_MeshHandle
		{
			get
			{
				if(r_MFree_MeshHandle == null)
				{
					r_MFree_MeshHandle = new(this, "Free", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshHandle"));
					r_MFree_MeshHandle.SetBelong(this.instance);
				}
				return r_MFree_MeshHandle;
			}
		}

		/// <summary>
		/// Void OnFrameRenderingBegin()
		/// </summary>
		protected RMethod r_MOnFrameRenderingBegin;
		public virtual RMethod RMOnFrameRenderingBegin
		{
			get
			{
				if(r_MOnFrameRenderingBegin == null)
				{
					r_MOnFrameRenderingBegin = new(this, "OnFrameRenderingBegin", 0);
					r_MOnFrameRenderingBegin.SetBelong(this.instance);
				}
				return r_MOnFrameRenderingBegin;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[T] PtrToSlice[T](Void*, Int32)
		/// </summary>
		protected static RMethod r_MPtrToSlice_GT_VoidPointer_Int32;
		public static RMethod RMPtrToSlice_GT_VoidPointer_Int32
		{
			get
			{
				if(r_MPtrToSlice_GT_VoidPointer_Int32 == null)
				{
					r_MPtrToSlice_GT_VoidPointer_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "PtrToSlice", 1, typeof(void).MakePointerType(), typeof(System.Int32));
					r_MPtrToSlice_GT_VoidPointer_Int32.SetBelong(null);
				}
				return r_MPtrToSlice_GT_VoidPointer_Int32;
			}
		}

		/// <summary>
		/// Void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand, Int32, UnityEngine.Material, Boolean, EvaluationState ByRef)
		/// </summary>
		protected RMethod r_MApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState;
		public virtual RMethod RMApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState
		{
			get
			{
				if(r_MApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState == null)
				{
					r_MApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState = new(this, "ApplyDrawCommandState", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState").MakeByRefType());
					r_MApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState.SetBelong(this.instance);
				}
				return r_MApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState;
			}
		}

		/// <summary>
		/// Void ApplyBatchState(EvaluationState ByRef, Boolean)
		/// </summary>
		protected RMethod r_MApplyBatchState_Ref_EvaluationState_Boolean;
		public virtual RMethod RMApplyBatchState_Ref_EvaluationState_Boolean
		{
			get
			{
				if(r_MApplyBatchState_Ref_EvaluationState_Boolean == null)
				{
					r_MApplyBatchState_Ref_EvaluationState_Boolean = new(this, "ApplyBatchState", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState").MakeByRefType(), typeof(System.Boolean));
					r_MApplyBatchState_Ref_EvaluationState_Boolean.SetBelong(this.instance);
				}
				return r_MApplyBatchState_Ref_EvaluationState_Boolean;
			}
		}

		/// <summary>
		/// Void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand, UnityEngine.Material, UnityEngine.Material, UnityEngine.Texture, UnityEngine.Texture, Single, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4], Unity.Collections.NativeSlice`1[UnityEngine.Vector4], UnityEngine.MaterialPropertyBlock, Boolean, System.Exception ByRef)
		/// </summary>
		protected RMethod r_MEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception;
		public virtual RMethod RMEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception
		{
			get
			{
				if(r_MEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception == null)
				{
					r_MEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception = new(this, "EvaluateChain", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), typeof(UnityEngine.Material), typeof(UnityEngine.Material), typeof(UnityEngine.Texture), typeof(UnityEngine.Texture), typeof(System.Single), typeof(Unity.Collections.NativeSlice<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Transform3x4")), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Exception).MakeByRefType());
					r_MEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception.SetBelong(this.instance);
				}
				return r_MEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception;
			}
		}

		/// <summary>
		/// Void UpdateFenceValue()
		/// </summary>
		protected RMethod r_MUpdateFenceValue;
		public virtual RMethod RMUpdateFenceValue
		{
			get
			{
				if(r_MUpdateFenceValue == null)
				{
					r_MUpdateFenceValue = new(this, "UpdateFenceValue", 0);
					r_MUpdateFenceValue.SetBelong(this.instance);
				}
				return r_MUpdateFenceValue;
			}
		}

		/// <summary>
		/// Void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange*, Int32 ByRef, Int32 ByRef, Int32, UnityEngine.UIElements.UIR.Page)
		/// </summary>
		protected RMethod r_MKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page;
		public virtual RMethod RMKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page
		{
			get
			{
				if(r_MKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page == null)
				{
					r_MKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page = new(this, "KickRanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawBufferRange").MakePointerType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Page"));
					r_MKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page.SetBelong(this.instance);
				}
				return r_MKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page;
			}
		}

		/// <summary>
		/// Void DrawRanges[I,T](GPUBuffer`1, GPUBuffer`1, Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.DrawBufferRange])
		/// </summary>
		protected RMethod r_MDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_;
		public virtual RMethod RMDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_
		{
			get
			{
				if(r_MDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_ == null)
				{
					r_MDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_ = new(this, "DrawRanges", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Utility+GPUBuffer`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Utility+GPUBuffer`1").MakeGenericType(Type.MakeGenericMethodParameter(1)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawBufferRange")));
					r_MDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_.SetBelong(this.instance);
				}
				return r_MDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_;
			}
		}

		/// <summary>
		/// Void WaitOnAllCpuFences()
		/// </summary>
		protected RMethod r_MWaitOnAllCpuFences;
		public virtual RMethod RMWaitOnAllCpuFences
		{
			get
			{
				if(r_MWaitOnAllCpuFences == null)
				{
					r_MWaitOnAllCpuFences = new(this, "WaitOnAllCpuFences", 0);
					r_MWaitOnAllCpuFences.SetBelong(this.instance);
				}
				return r_MWaitOnAllCpuFences;
			}
		}

		/// <summary>
		/// Void WaitOnCpuFence(UInt32)
		/// </summary>
		protected RMethod r_MWaitOnCpuFence_UInt32;
		public virtual RMethod RMWaitOnCpuFence_UInt32
		{
			get
			{
				if(r_MWaitOnCpuFence_UInt32 == null)
				{
					r_MWaitOnCpuFence_UInt32 = new(this, "WaitOnCpuFence", 0, typeof(System.UInt32));
					r_MWaitOnCpuFence_UInt32.SetBelong(this.instance);
				}
				return r_MWaitOnCpuFence_UInt32;
			}
		}

		/// <summary>
		/// Void AdvanceFrame()
		/// </summary>
		protected RMethod r_MAdvanceFrame;
		public virtual RMethod RMAdvanceFrame
		{
			get
			{
				if(r_MAdvanceFrame == null)
				{
					r_MAdvanceFrame = new(this, "AdvanceFrame", 0);
					r_MAdvanceFrame.SetBelong(this.instance);
				}
				return r_MAdvanceFrame;
			}
		}

		/// <summary>
		/// Void PruneUnusedPages()
		/// </summary>
		protected RMethod r_MPruneUnusedPages;
		public virtual RMethod RMPruneUnusedPages
		{
			get
			{
				if(r_MPruneUnusedPages == null)
				{
					r_MPruneUnusedPages = new(this, "PruneUnusedPages", 0);
					r_MPruneUnusedPages.SetBelong(this.instance);
				}
				return r_MPruneUnusedPages;
			}
		}

		/// <summary>
		/// Void PrepareForGfxDeviceRecreate()
		/// </summary>
		protected static RMethod r_MPrepareForGfxDeviceRecreate;
		public static RMethod RMPrepareForGfxDeviceRecreate
		{
			get
			{
				if(r_MPrepareForGfxDeviceRecreate == null)
				{
					r_MPrepareForGfxDeviceRecreate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "PrepareForGfxDeviceRecreate", 0);
					r_MPrepareForGfxDeviceRecreate.SetBelong(null);
				}
				return r_MPrepareForGfxDeviceRecreate;
			}
		}

		/// <summary>
		/// Void WrapUpGfxDeviceRecreate()
		/// </summary>
		protected static RMethod r_MWrapUpGfxDeviceRecreate;
		public static RMethod RMWrapUpGfxDeviceRecreate
		{
			get
			{
				if(r_MWrapUpGfxDeviceRecreate == null)
				{
					r_MWrapUpGfxDeviceRecreate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "WrapUpGfxDeviceRecreate", 0);
					r_MWrapUpGfxDeviceRecreate.SetBelong(null);
				}
				return r_MWrapUpGfxDeviceRecreate;
			}
		}

		/// <summary>
		/// Void FlushAllPendingDeviceDisposes()
		/// </summary>
		protected static RMethod r_MFlushAllPendingDeviceDisposes;
		public static RMethod RMFlushAllPendingDeviceDisposes
		{
			get
			{
				if(r_MFlushAllPendingDeviceDisposes == null)
				{
					r_MFlushAllPendingDeviceDisposes = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "FlushAllPendingDeviceDisposes", 0);
					r_MFlushAllPendingDeviceDisposes.SetBelong(null);
				}
				return r_MFlushAllPendingDeviceDisposes;
			}
		}

		/// <summary>
		/// AllocationStatistics GatherAllocationStatistics()
		/// </summary>
		protected RMethod r_MGatherAllocationStatistics;
		public virtual RMethod RMGatherAllocationStatistics
		{
			get
			{
				if(r_MGatherAllocationStatistics == null)
				{
					r_MGatherAllocationStatistics = new(this, "GatherAllocationStatistics", 0);
					r_MGatherAllocationStatistics.SetBelong(this.instance);
				}
				return r_MGatherAllocationStatistics;
			}
		}

		/// <summary>
		/// DrawStatistics GatherDrawStatistics()
		/// </summary>
		protected RMethod r_MGatherDrawStatistics;
		public virtual RMethod RMGatherDrawStatistics
		{
			get
			{
				if(r_MGatherDrawStatistics == null)
				{
					r_MGatherDrawStatistics = new(this, "GatherDrawStatistics", 0);
					r_MGatherDrawStatistics.SetBelong(this.instance);
				}
				return r_MGatherDrawStatistics;
			}
		}

		/// <summary>
		/// Void ProcessDeviceFreeQueue()
		/// </summary>
		protected static RMethod r_MProcessDeviceFreeQueue;
		public static RMethod RMProcessDeviceFreeQueue
		{
			get
			{
				if(r_MProcessDeviceFreeQueue == null)
				{
					r_MProcessDeviceFreeQueue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "ProcessDeviceFreeQueue", 0);
					r_MProcessDeviceFreeQueue.SetBelong(null);
				}
				return r_MProcessDeviceFreeQueue;
			}
		}

		/// <summary>
		/// Void OnEngineUpdateGlobal()
		/// </summary>
		protected static RMethod r_MOnEngineUpdateGlobal;
		public static RMethod RMOnEngineUpdateGlobal
		{
			get
			{
				if(r_MOnEngineUpdateGlobal == null)
				{
					r_MOnEngineUpdateGlobal = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "OnEngineUpdateGlobal", 0);
					r_MOnEngineUpdateGlobal.SetBelong(null);
				}
				return r_MOnEngineUpdateGlobal;
			}
		}

		/// <summary>
		/// Void OnFlushPendingResources()
		/// </summary>
		protected static RMethod r_MOnFlushPendingResources;
		public static RMethod RMOnFlushPendingResources
		{
			get
			{
				if(r_MOnFlushPendingResources == null)
				{
					r_MOnFlushPendingResources = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"), "OnFlushPendingResources", 0);
					r_MOnFlushPendingResources.SetBelong(null);
				}
				return r_MOnFlushPendingResources;
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
            var ___result = RMInitVertexDeclaration.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteCreation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCompleteCreation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisposeImmediate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeImmediate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle Allocate(System.UInt32 @vertexCount, System.UInt32 @indexCount, out RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertexData, out RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indexData, out System.UInt16 @indexOffset)
        {
			@vertexData = default;
			@indexData = default;
			@indexOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @vertexData.Value, @indexData.Value, @indexOffset};
            var ___result = RMAllocate_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16.Invoke(___genericsType, ___parameters);
			@vertexData = new RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex>(___parameters[2]);
			@indexData = new RUnity.RCollections.RNativeSlice<RSystem.RUInt16>(___parameters[3]);
			@indexOffset = (System.UInt16)___parameters[4];

            return new RUnityEngine.RUIElements.RUIR.RMeshHandle(___result);
        }


        public virtual void Update(RUnityEngine.RUIElements.RUIR.RMeshHandle @mesh, System.UInt32 @vertexCount, out RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertexData)
        {
			@vertexData = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh.Value, @vertexCount, @vertexData.Value};
            var ___result = RMUpdate_MeshHandle_UInt32_Out_NativeSlice_d_Vertex_p_.Invoke(___genericsType, ___parameters);
			@vertexData = new RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex>(___parameters[2]);

            
        }


        public virtual void Update(RUnityEngine.RUIElements.RUIR.RMeshHandle @mesh, System.UInt32 @vertexCount, System.UInt32 @indexCount, out RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertexData, out RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indexData, out System.UInt16 @indexOffset)
        {
			@vertexData = default;
			@indexData = default;
			@indexOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh.Value, @vertexCount, @indexCount, @vertexData.Value, @indexData.Value, @indexOffset};
            var ___result = RMUpdate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16.Invoke(___genericsType, ___parameters);
			@vertexData = new RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex>(___parameters[3]);
			@indexData = new RUnity.RCollections.RNativeSlice<RSystem.RUInt16>(___parameters[4]);
			@indexOffset = (System.UInt16)___parameters[5];

            
        }


        public virtual System.Boolean TryAllocFromPage(RUnityEngine.RUIElements.RUIR.RPage @page, System.UInt32 @vertexCount, System.UInt32 @indexCount, ref RUnityEngine.RUIElements.RUIR.RAlloc @va, ref RUnityEngine.RUIElements.RUIR.RAlloc @ia, System.Boolean @shortLived)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page.Value, @vertexCount, @indexCount, @va.Value, @ia.Value, @shortLived};
            var ___result = RMTryAllocFromPage_Page_UInt32_UInt32_Ref_Alloc_Ref_Alloc_Boolean.Invoke(___genericsType, ___parameters);
			@va = new RUnityEngine.RUIElements.RUIR.RAlloc(___parameters[3]);
			@ia = new RUnityEngine.RUIElements.RUIR.RAlloc(___parameters[4]);

            return (System.Boolean)___result;
        }


        public virtual void Allocate(RUnityEngine.RUIElements.RUIR.RMeshHandle @meshHandle, System.UInt32 @vertexCount, System.UInt32 @indexCount, out RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertexData, out RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indexData, System.Boolean @shortLived)
        {
			@vertexData = default;
			@indexData = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshHandle.Value, @vertexCount, @indexCount, @vertexData.Value, @indexData.Value, @shortLived};
            var ___result = RMAllocate_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Boolean.Invoke(___genericsType, ___parameters);
			@vertexData = new RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex>(___parameters[3]);
			@indexData = new RUnity.RCollections.RNativeSlice<RSystem.RUInt16>(___parameters[4]);

            
        }


        public virtual void UpdateAfterGPUUsedData(RUnityEngine.RUIElements.RUIR.RMeshHandle @mesh, System.UInt32 @vertexCount, System.UInt32 @indexCount, out RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertexData, out RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indexData, out System.UInt16 @indexOffset, out RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToUpdate @allocToUpdate, System.Boolean @copyBackIndices)
        {
			@vertexData = default;
			@indexData = default;
			@indexOffset = default;
			@allocToUpdate = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh.Value, @vertexCount, @indexCount, @vertexData.Value, @indexData.Value, @indexOffset, @allocToUpdate.Value, @copyBackIndices};
            var ___result = RMUpdateAfterGPUUsedData_MeshHandle_UInt32_UInt32_Out_NativeSlice_d_Vertex_p__Out_NativeSlice_d_UInt16_p__Out_UInt16_Out_AllocToUpdate_Boolean.Invoke(___genericsType, ___parameters);
			@vertexData = new RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex>(___parameters[3]);
			@indexData = new RUnity.RCollections.RNativeSlice<RSystem.RUInt16>(___parameters[4]);
			@indexOffset = (System.UInt16)___parameters[5];
			@allocToUpdate = new RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocToUpdate(___parameters[6]);

            
        }


        public virtual void Free(RUnityEngine.RUIElements.RUIR.RMeshHandle @mesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh.Value};
            var ___result = RMFree_MeshHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFrameRenderingBegin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnFrameRenderingBegin.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static RUnity.RCollections.RNativeSlice<RType> PtrToSlice<T>(void* @p, System.Int32 @count) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@p, typeof(void)), @count};
            var ___result = RMPtrToSlice_GT_VoidPointer_Int32.Invoke(___genericsType, ___parameters);

            return new RUnity.RCollections.RNativeSlice<RType>(___result);
        }


        public virtual void ApplyDrawCommandState(RUnityEngine.RUIElements.RUIR.RRenderChainCommand @cmd, System.Int32 @textureSlot, UnityEngine.Material @newMat, System.Boolean @newMatDiffers, ref RUnityEngine.RUIElements.RUIR.RUIRenderDevice.REvaluationState @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd.Value, @textureSlot, @newMat, @newMatDiffers, @st.Value};
            var ___result = RMApplyDrawCommandState_RenderChainCommand_Int32_Material_Boolean_Ref_EvaluationState.Invoke(___genericsType, ___parameters);
			@st = new RUnityEngine.RUIElements.RUIR.RUIRenderDevice.REvaluationState(___parameters[4]);

            
        }


        public virtual void ApplyBatchState(ref RUnityEngine.RUIElements.RUIR.RUIRenderDevice.REvaluationState @st, System.Boolean @allowMaterialChange)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st.Value, @allowMaterialChange};
            var ___result = RMApplyBatchState_Ref_EvaluationState_Boolean.Invoke(___genericsType, ___parameters);
			@st = new RUnityEngine.RUIElements.RUIR.RUIRenderDevice.REvaluationState(___parameters[0]);

            
        }


        public virtual void EvaluateChain(RUnityEngine.RUIElements.RUIR.RRenderChainCommand @head, UnityEngine.Material @initialMat, UnityEngine.Material @defaultMat, UnityEngine.Texture @gradientSettings, UnityEngine.Texture @shaderInfo, System.Single @pixelsPerPoint, RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RUIR.RTransform3x4> @transforms, RUnity.RCollections.RNativeSlice<RUnityEngine.RVector4> @clipRects, UnityEngine.MaterialPropertyBlock @stateMatProps, System.Boolean @allowMaterialChange, ref System.Exception @immediateException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@head.Value, @initialMat, @defaultMat, @gradientSettings, @shaderInfo, @pixelsPerPoint, @transforms.Value, @clipRects.Value, @stateMatProps, @allowMaterialChange, @immediateException};
            var ___result = RMEvaluateChain_RenderChainCommand_Material_Material_Texture_Texture_Single_NativeSlice_d_Transform3x4_p__NativeSlice_d_Vector4_p__MaterialPropertyBlock_Boolean_Ref_Exception.Invoke(___genericsType, ___parameters);
			@immediateException = (System.Exception)___parameters[10];

            
        }


        public virtual void UpdateFenceValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateFenceValue.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void KickRanges(RTypePointer<RUnityEngine.RUIElements.RUIR.RDrawBufferRange> @ranges, ref System.Int32 @rangesReady, ref System.Int32 @rangesStart, System.Int32 @rangesCount, RUnityEngine.RUIElements.RUIR.RPage @curPage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ranges.Value, @rangesReady, @rangesStart, @rangesCount, @curPage.Value};
            var ___result = RMKickRanges_DrawBufferRangePointer_Ref_Int32_Ref_Int32_Int32_Page.Invoke(___genericsType, ___parameters);
			@rangesReady = (System.Int32)___parameters[1];
			@rangesStart = (System.Int32)___parameters[2];

            
        }


        public virtual void DrawRanges<I, T>(RUnityEngine.RUIElements.RUIR.RUtility.RGPUBuffer<RType> @ib, RUnityEngine.RUIElements.RUIR.RUtility.RGPUBuffer<RType> @vb, RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RUIR.RDrawBufferRange> @ranges) where I : struct where T : struct
        {

            var ___genericsType = new Type[] {typeof(I), typeof(T)};
            var ___parameters = new object[]{@ib.Value, @vb.Value, @ranges.Value};
            var ___result = RMDrawRanges_GI_GT_GPUBuffer_d_I_p__GPUBuffer_d_T_p__NativeSlice_d_DrawBufferRange_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnAllCpuFences()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitOnAllCpuFences.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WaitOnCpuFence(System.UInt32 @fence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fence};
            var ___result = RMWaitOnCpuFence_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AdvanceFrame()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAdvanceFrame.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PruneUnusedPages()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPruneUnusedPages.Invoke(___genericsType, ___parameters);

            
        }


        public static void PrepareForGfxDeviceRecreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepareForGfxDeviceRecreate.Invoke(___genericsType, ___parameters);

            
        }


        public static void WrapUpGfxDeviceRecreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWrapUpGfxDeviceRecreate.Invoke(___genericsType, ___parameters);

            
        }


        public static void FlushAllPendingDeviceDisposes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlushAllPendingDeviceDisposes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocationStatistics GatherAllocationStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGatherAllocationStatistics.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocationStatistics(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDrawStatistics GatherDrawStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGatherDrawStatistics.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RDrawStatistics(___result);
        }


        public static void ProcessDeviceFreeQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProcessDeviceFreeQueue.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnEngineUpdateGlobal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEngineUpdateGlobal.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnFlushPendingResources()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnFlushPendingResources.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
