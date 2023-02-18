
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.RenderChain
	/// </summary>
    public partial class RRenderChain : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand m_FirstCommand
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_Fm_FirstCommand;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFm_FirstCommand
		{
			get
			{
				if(r_Fm_FirstCommand == null)
				{
					r_Fm_FirstCommand = new(this, "m_FirstCommand");
					r_Fm_FirstCommand.SetBelong(this.GetValue());
				}
				return r_Fm_FirstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking m_DirtyTracker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RDepthOrderedDirtyTracking r_Fm_DirtyTracker;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RDepthOrderedDirtyTracking RFm_DirtyTracker
		{
			get
			{
				if(r_Fm_DirtyTracker == null)
				{
					r_Fm_DirtyTracker = new(this, "m_DirtyTracker");
					r_Fm_DirtyTracker.SetBelong(this.GetValue());
				}
				return r_Fm_DirtyTracker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.LinkedPool`1[UnityEngine.UIElements.UIR.RenderChainCommand] m_CommandPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RLinkedPool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand> r_Fm_CommandPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RLinkedPool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand> RFm_CommandPool
		{
			get
			{
				if(r_Fm_CommandPool == null)
				{
					r_Fm_CommandPool = new(this, "m_CommandPool");
					r_Fm_CommandPool.SetBelong(this.GetValue());
				}
				return r_Fm_CommandPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNodePool`1[UnityEngine.UIElements.UIR.TextureEntry] m_TexturePool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNodePool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextureEntry> r_Fm_TexturePool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNodePool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextureEntry> RFm_TexturePool
		{
			get
			{
				if(r_Fm_TexturePool == null)
				{
					r_Fm_TexturePool = new(this, "m_TexturePool");
					r_Fm_TexturePool.SetBelong(this.GetValue());
				}
				return r_Fm_TexturePool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.RenderChain+RenderNodeData] m_RenderNodesData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData> r_Fm_RenderNodesData;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData> RFm_RenderNodesData
		{
			get
			{
				if(r_Fm_RenderNodesData == null)
				{
					r_Fm_RenderNodesData = new(this, "m_RenderNodesData");
					r_Fm_RenderNodesData.SetBelong(this.GetValue());
				}
				return r_Fm_RenderNodesData;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_DefaultShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_Fm_DefaultShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RFm_DefaultShader
		{
			get
			{
				if(r_Fm_DefaultShader == null)
				{
					r_Fm_DefaultShader = new(this, "m_DefaultShader");
					r_Fm_DefaultShader.SetBelong(this.GetValue());
				}
				return r_Fm_DefaultShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_DefaultWorldSpaceShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_Fm_DefaultWorldSpaceShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RFm_DefaultWorldSpaceShader
		{
			get
			{
				if(r_Fm_DefaultWorldSpaceShader == null)
				{
					r_Fm_DefaultWorldSpaceShader = new(this, "m_DefaultWorldSpaceShader");
					r_Fm_DefaultWorldSpaceShader.SetBelong(this.GetValue());
				}
				return r_Fm_DefaultWorldSpaceShader;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_DefaultMat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fm_DefaultMat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFm_DefaultMat
		{
			get
			{
				if(r_Fm_DefaultMat == null)
				{
					r_Fm_DefaultMat = new(this, "m_DefaultMat");
					r_Fm_DefaultMat.SetBelong(this.GetValue());
				}
				return r_Fm_DefaultMat;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_DefaultWorldSpaceMat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fm_DefaultWorldSpaceMat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFm_DefaultWorldSpaceMat
		{
			get
			{
				if(r_Fm_DefaultWorldSpaceMat == null)
				{
					r_Fm_DefaultWorldSpaceMat = new(this, "m_DefaultWorldSpaceMat");
					r_Fm_DefaultWorldSpaceMat.SetBelong(this.GetValue());
				}
				return r_Fm_DefaultWorldSpaceMat;
			}
		}

		/// <summary>
		/// System.Boolean m_BlockDirtyRegistration
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_BlockDirtyRegistration;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_BlockDirtyRegistration
		{
			get
			{
				if(r_Fm_BlockDirtyRegistration == null)
				{
					r_Fm_BlockDirtyRegistration = new(this, "m_BlockDirtyRegistration");
					r_Fm_BlockDirtyRegistration.SetBelong(this.GetValue());
				}
				return r_Fm_BlockDirtyRegistration;
			}
		}

		/// <summary>
		/// System.Int32 m_StaticIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_StaticIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_StaticIndex
		{
			get
			{
				if(r_Fm_StaticIndex == null)
				{
					r_Fm_StaticIndex = new(this, "m_StaticIndex");
					r_Fm_StaticIndex.SetBelong(this.GetValue());
				}
				return r_Fm_StaticIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_ActiveRenderNodes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ActiveRenderNodes;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ActiveRenderNodes
		{
			get
			{
				if(r_Fm_ActiveRenderNodes == null)
				{
					r_Fm_ActiveRenderNodes = new(this, "m_ActiveRenderNodes");
					r_Fm_ActiveRenderNodes.SetBelong(this.GetValue());
				}
				return r_Fm_ActiveRenderNodes;
			}
		}

		/// <summary>
		/// System.Int32 m_CustomMaterialCommands
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CustomMaterialCommands;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CustomMaterialCommands
		{
			get
			{
				if(r_Fm_CustomMaterialCommands == null)
				{
					r_Fm_CustomMaterialCommands = new(this, "m_CustomMaterialCommands");
					r_Fm_CustomMaterialCommands.SetBelong(this.GetValue());
				}
				return r_Fm_CustomMaterialCommands;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.ChainBuilderStats m_Stats
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RChainBuilderStats r_Fm_Stats;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RChainBuilderStats RFm_Stats
		{
			get
			{
				if(r_Fm_Stats == null)
				{
					r_Fm_Stats = new(this, "m_Stats");
					r_Fm_Stats.SetBelong(this.GetValue());
				}
				return r_Fm_Stats;
			}
		}

		/// <summary>
		/// System.UInt32 m_StatsElementsAdded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_StatsElementsAdded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_StatsElementsAdded
		{
			get
			{
				if(r_Fm_StatsElementsAdded == null)
				{
					r_Fm_StatsElementsAdded = new(this, "m_StatsElementsAdded");
					r_Fm_StatsElementsAdded.SetBelong(this.GetValue());
				}
				return r_Fm_StatsElementsAdded;
			}
		}

		/// <summary>
		/// System.UInt32 m_StatsElementsRemoved
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_StatsElementsRemoved;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_StatsElementsRemoved
		{
			get
			{
				if(r_Fm_StatsElementsRemoved == null)
				{
					r_Fm_StatsElementsRemoved = new(this, "m_StatsElementsRemoved");
					r_Fm_StatsElementsRemoved.SetBelong(this.GetValue());
				}
				return r_Fm_StatsElementsRemoved;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry m_TextureRegistry
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry r_Fm_TextureRegistry;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry RFm_TextureRegistry
		{
			get
			{
				if(r_Fm_TextureRegistry == null)
				{
					r_Fm_TextureRegistry = new(this, "m_TextureRegistry");
					r_Fm_TextureRegistry.SetBelong(this.GetValue());
				}
				return r_Fm_TextureRegistry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.OpacityIdAccelerator <opacityIdAccelerator>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator r_F__0__opacityIdAccelerator__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator RF__0__opacityIdAccelerator__1__k__BackingField
		{
			get
			{
				if(r_F__0__opacityIdAccelerator__1__k__BackingField == null)
				{
					r_F__0__opacityIdAccelerator__1__k__BackingField = new(this, "<opacityIdAccelerator>k__BackingField");
					r_F__0__opacityIdAccelerator__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__opacityIdAccelerator__1__k__BackingField;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerProcess
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerProcess;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerProcess
		{
			get
			{
				if(r_Fs_MarkerProcess == null)
				{
					r_Fs_MarkerProcess = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerProcess");
					r_Fs_MarkerProcess.SetBelong(null);
				}
				return r_Fs_MarkerProcess;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerClipProcessing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerClipProcessing;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerClipProcessing
		{
			get
			{
				if(r_Fs_MarkerClipProcessing == null)
				{
					r_Fs_MarkerClipProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerClipProcessing");
					r_Fs_MarkerClipProcessing.SetBelong(null);
				}
				return r_Fs_MarkerClipProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerOpacityProcessing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerOpacityProcessing;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerOpacityProcessing
		{
			get
			{
				if(r_Fs_MarkerOpacityProcessing == null)
				{
					r_Fs_MarkerOpacityProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerOpacityProcessing");
					r_Fs_MarkerOpacityProcessing.SetBelong(null);
				}
				return r_Fs_MarkerOpacityProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerColorsProcessing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerColorsProcessing;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerColorsProcessing
		{
			get
			{
				if(r_Fs_MarkerColorsProcessing == null)
				{
					r_Fs_MarkerColorsProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerColorsProcessing");
					r_Fs_MarkerColorsProcessing.SetBelong(null);
				}
				return r_Fs_MarkerColorsProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerTransformProcessing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerTransformProcessing;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerTransformProcessing
		{
			get
			{
				if(r_Fs_MarkerTransformProcessing == null)
				{
					r_Fs_MarkerTransformProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerTransformProcessing");
					r_Fs_MarkerTransformProcessing.SetBelong(null);
				}
				return r_Fs_MarkerTransformProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerVisualsProcessing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerVisualsProcessing;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerVisualsProcessing
		{
			get
			{
				if(r_Fs_MarkerVisualsProcessing == null)
				{
					r_Fs_MarkerVisualsProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerVisualsProcessing");
					r_Fs_MarkerVisualsProcessing.SetBelong(null);
				}
				return r_Fs_MarkerVisualsProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerTextRegen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerTextRegen;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerTextRegen
		{
			get
			{
				if(r_Fs_MarkerTextRegen == null)
				{
					r_Fs_MarkerTextRegen = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerTextRegen");
					r_Fs_MarkerTextRegen.SetBelong(null);
				}
				return r_Fs_MarkerTextRegen;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r_F__0__disposed__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action OnPreRender
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction r_FOnPreRender;
		public static Hvak.Editor.Refleaction.RSystem.RAction RFOnPreRender
		{
			get
			{
				if(r_FOnPreRender == null)
				{
					r_FOnPreRender = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnPreRender");
					r_FOnPreRender.SetBelong(null);
				}
				return r_FOnPreRender;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_F__0__panel__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RF__0__panel__1__k__BackingField
		{
			get
			{
				if(r_F__0__panel__1__k__BackingField == null)
				{
					r_F__0__panel__1__k__BackingField = new(this, "<panel>k__BackingField");
					r_F__0__panel__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__panel__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice r_F__0__device__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice RF__0__device__1__k__BackingField
		{
			get
			{
				if(r_F__0__device__1__k__BackingField == null)
				{
					r_F__0__device__1__k__BackingField = new(this, "<device>k__BackingField");
					r_F__0__device__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__device__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase <atlas>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase r_F__0__atlas__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase RF__0__atlas__1__k__BackingField
		{
			get
			{
				if(r_F__0__atlas__1__k__BackingField == null)
				{
					r_F__0__atlas__1__k__BackingField = new(this, "<atlas>k__BackingField");
					r_F__0__atlas__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__atlas__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager r_F__0__vectorImageManager__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager RF__0__vectorImageManager__1__k__BackingField
		{
			get
			{
				if(r_F__0__vectorImageManager__1__k__BackingField == null)
				{
					r_F__0__vectorImageManager__1__k__BackingField = new(this, "<vectorImageManager>k__BackingField");
					r_F__0__vectorImageManager__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__vectorImageManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] <vertsPool>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_F__0__vertsPool__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RF__0__vertsPool__1__k__BackingField
		{
			get
			{
				if(r_F__0__vertsPool__1__k__BackingField == null)
				{
					r_F__0__vertsPool__1__k__BackingField = new(this, "<vertsPool>k__BackingField");
					r_F__0__vertsPool__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__vertsPool__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] <indicesPool>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RSystem.RUInt16> r_F__0__indicesPool__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RSystem.RUInt16> RF__0__indicesPool__1__k__BackingField
		{
			get
			{
				if(r_F__0__indicesPool__1__k__BackingField == null)
				{
					r_F__0__indicesPool__1__k__BackingField = new(this, "<indicesPool>k__BackingField");
					r_F__0__indicesPool__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__indicesPool__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobManager <jobManager>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RJobManager r_F__0__jobManager__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RJobManager RF__0__jobManager__1__k__BackingField
		{
			get
			{
				if(r_F__0__jobManager__1__k__BackingField == null)
				{
					r_F__0__jobManager__1__k__BackingField = new(this, "<jobManager>k__BackingField");
					r_F__0__jobManager__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__jobManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator shaderInfoAllocator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRVEShaderInfoAllocator r_FshaderInfoAllocator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRVEShaderInfoAllocator RFshaderInfoAllocator
		{
			get
			{
				if(r_FshaderInfoAllocator == null)
				{
					r_FshaderInfoAllocator = new(this, "shaderInfoAllocator");
					r_FshaderInfoAllocator.SetBelong(this.GetValue());
				}
				return r_FshaderInfoAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter <painter>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter r_F__0__painter__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter RF__0__painter__1__k__BackingField
		{
			get
			{
				if(r_F__0__painter__1__k__BackingField == null)
				{
					r_F__0__painter__1__k__BackingField = new(this, "<painter>k__BackingField");
					r_F__0__painter__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__painter__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <drawStats>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__drawStats__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__drawStats__1__k__BackingField
		{
			get
			{
				if(r_F__0__drawStats__1__k__BackingField == null)
				{
					r_F__0__drawStats__1__k__BackingField = new(this, "<drawStats>k__BackingField");
					r_F__0__drawStats__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__drawStats__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <drawInCameras>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__drawInCameras__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__drawInCameras__1__k__BackingField
		{
			get
			{
				if(r_F__0__drawInCameras__1__k__BackingField == null)
				{
					r_F__0__drawInCameras__1__k__BackingField = new(this, "<drawInCameras>k__BackingField");
					r_F__0__drawInCameras__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__drawInCameras__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_PfirstCommand;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RPfirstCommand
		{
			get
			{
				if(r_PfirstCommand == null)
				{
					r_PfirstCommand = new(this, "firstCommand", -1);
					r_PfirstCommand.SetBelong(this.GetValue());
				}
				return r_PfirstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.OpacityIdAccelerator opacityIdAccelerator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator r_PopacityIdAccelerator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator RPopacityIdAccelerator
		{
			get
			{
				if(r_PopacityIdAccelerator == null)
				{
					r_PopacityIdAccelerator = new(this, "opacityIdAccelerator", -1);
					r_PopacityIdAccelerator.SetBelong(this.GetValue());
				}
				return r_PopacityIdAccelerator;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
					r_Pdisposed.SetBelong(this.GetValue());
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.ChainBuilderStats stats
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RChainBuilderStats r_Pstats;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RChainBuilderStats RPstats
		{
			get
			{
				if(r_Pstats == null)
				{
					r_Pstats = new(this, "stats", -1);
					r_Pstats.SetBelong(this.GetValue());
				}
				return r_Pstats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_Ppanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
					r_Ppanel.SetBelong(this.GetValue());
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice device
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice r_Pdevice;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice RPdevice
		{
			get
			{
				if(r_Pdevice == null)
				{
					r_Pdevice = new(this, "device", -1);
					r_Pdevice.SetBelong(this.GetValue());
				}
				return r_Pdevice;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase r_Patlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase RPatlas
		{
			get
			{
				if(r_Patlas == null)
				{
					r_Patlas = new(this, "atlas", -1);
					r_Patlas.SetBelong(this.GetValue());
				}
				return r_Patlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager vectorImageManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager r_PvectorImageManager;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager RPvectorImageManager
		{
			get
			{
				if(r_PvectorImageManager == null)
				{
					r_PvectorImageManager = new(this, "vectorImageManager", -1);
					r_PvectorImageManager.SetBelong(this.GetValue());
				}
				return r_PvectorImageManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] vertsPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_PvertsPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RPvertsPool
		{
			get
			{
				if(r_PvertsPool == null)
				{
					r_PvertsPool = new(this, "vertsPool", -1);
					r_PvertsPool.SetBelong(this.GetValue());
				}
				return r_PvertsPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] indicesPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RSystem.RUInt16> r_PindicesPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RSystem.RUInt16> RPindicesPool
		{
			get
			{
				if(r_PindicesPool == null)
				{
					r_PindicesPool = new(this, "indicesPool", -1);
					r_PindicesPool.SetBelong(this.GetValue());
				}
				return r_PindicesPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobManager jobManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RJobManager r_PjobManager;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RJobManager RPjobManager
		{
			get
			{
				if(r_PjobManager == null)
				{
					r_PjobManager = new(this, "jobManager", -1);
					r_PjobManager.SetBelong(this.GetValue());
				}
				return r_PjobManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter painter
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter r_Ppainter;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter RPpainter
		{
			get
			{
				if(r_Ppainter == null)
				{
					r_Ppainter = new(this, "painter", -1);
					r_Ppainter.SetBelong(this.GetValue());
				}
				return r_Ppainter;
			}
		}

		/// <summary>
		/// Boolean drawStats
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdrawStats;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdrawStats
		{
			get
			{
				if(r_PdrawStats == null)
				{
					r_PdrawStats = new(this, "drawStats", -1);
					r_PdrawStats.SetBelong(this.GetValue());
				}
				return r_PdrawStats;
			}
		}

		/// <summary>
		/// Boolean drawInCameras
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdrawInCameras;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdrawInCameras
		{
			get
			{
				if(r_PdrawInCameras == null)
				{
					r_PdrawInCameras = new(this, "drawInCameras", -1);
					r_PdrawInCameras.SetBelong(this.GetValue());
				}
				return r_PdrawInCameras;
			}
		}

		/// <summary>
		/// UnityEngine.Shader defaultShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_PdefaultShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RPdefaultShader
		{
			get
			{
				if(r_PdefaultShader == null)
				{
					r_PdefaultShader = new(this, "defaultShader", -1);
					r_PdefaultShader.SetBelong(this.GetValue());
				}
				return r_PdefaultShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader defaultWorldSpaceShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_PdefaultWorldSpaceShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RPdefaultWorldSpaceShader
		{
			get
			{
				if(r_PdefaultWorldSpaceShader == null)
				{
					r_PdefaultWorldSpaceShader = new(this, "defaultWorldSpaceShader", -1);
					r_PdefaultWorldSpaceShader.SetBelong(this.GetValue());
				}
				return r_PdefaultWorldSpaceShader;
			}
		}

		/// <summary>
		/// Void Constructor(UnityEngine.UIElements.BaseVisualElementPanel, UnityEngine.UIElements.UIR.UIRenderDevice, UnityEngine.UIElements.AtlasBase, UnityEngine.UIElements.UIR.VectorImageManager)
		/// </summary>
		protected RMethod r_MConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager;
		public virtual RMethod RMConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager
		{
			get
			{
				if(r_MConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager == null)
				{
					r_MConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager = new(this, "Constructor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"),  ReflectionUtils.GetType("UnityEngine.UIElements.AtlasBase"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"));
					r_MConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager.SetBelong(this.GetValue());
				}
				return r_MConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager;
			}
		}

		/// <summary>
		/// Void Destructor()
		/// </summary>
		protected RMethod r_MDestructor;
		public virtual RMethod RMDestructor
		{
			get
			{
				if(r_MDestructor == null)
				{
					r_MDestructor = new(this, "Destructor", 0);
					r_MDestructor.SetBelong(this.GetValue());
				}
				return r_MDestructor;
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
					r_MDispose.SetBelong(this.GetValue());
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
					r_MDispose_Boolean.SetBelong(this.GetValue());
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void ProcessChanges()
		/// </summary>
		protected RMethod r_MProcessChanges;
		public virtual RMethod RMProcessChanges
		{
			get
			{
				if(r_MProcessChanges == null)
				{
					r_MProcessChanges = new(this, "ProcessChanges", 0);
					r_MProcessChanges.SetBelong(this.GetValue());
				}
				return r_MProcessChanges;
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
					r_MRender.SetBelong(this.GetValue());
				}
				return r_MRender;
			}
		}

		/// <summary>
		/// Void UIEOnChildAdded(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUIEOnChildAdded_VisualElement;
		public virtual RMethod RMUIEOnChildAdded_VisualElement
		{
			get
			{
				if(r_MUIEOnChildAdded_VisualElement == null)
				{
					r_MUIEOnChildAdded_VisualElement = new(this, "UIEOnChildAdded", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUIEOnChildAdded_VisualElement.SetBelong(this.GetValue());
				}
				return r_MUIEOnChildAdded_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUIEOnChildrenReordered_VisualElement;
		public virtual RMethod RMUIEOnChildrenReordered_VisualElement
		{
			get
			{
				if(r_MUIEOnChildrenReordered_VisualElement == null)
				{
					r_MUIEOnChildrenReordered_VisualElement = new(this, "UIEOnChildrenReordered", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUIEOnChildrenReordered_VisualElement.SetBelong(this.GetValue());
				}
				return r_MUIEOnChildrenReordered_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUIEOnChildRemoving_VisualElement;
		public virtual RMethod RMUIEOnChildRemoving_VisualElement
		{
			get
			{
				if(r_MUIEOnChildRemoving_VisualElement == null)
				{
					r_MUIEOnChildRemoving_VisualElement = new(this, "UIEOnChildRemoving", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUIEOnChildRemoving_VisualElement.SetBelong(this.GetValue());
				}
				return r_MUIEOnChildRemoving_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUIEOnRenderHintsChanged_VisualElement;
		public virtual RMethod RMUIEOnRenderHintsChanged_VisualElement
		{
			get
			{
				if(r_MUIEOnRenderHintsChanged_VisualElement == null)
				{
					r_MUIEOnRenderHintsChanged_VisualElement = new(this, "UIEOnRenderHintsChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUIEOnRenderHintsChanged_VisualElement.SetBelong(this.GetValue());
				}
				return r_MUIEOnRenderHintsChanged_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_MUIEOnClippingChanged_VisualElement_Boolean;
		public virtual RMethod RMUIEOnClippingChanged_VisualElement_Boolean
		{
			get
			{
				if(r_MUIEOnClippingChanged_VisualElement_Boolean == null)
				{
					r_MUIEOnClippingChanged_VisualElement_Boolean = new(this, "UIEOnClippingChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_MUIEOnClippingChanged_VisualElement_Boolean.SetBelong(this.GetValue());
				}
				return r_MUIEOnClippingChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_MUIEOnOpacityChanged_VisualElement_Boolean;
		public virtual RMethod RMUIEOnOpacityChanged_VisualElement_Boolean
		{
			get
			{
				if(r_MUIEOnOpacityChanged_VisualElement_Boolean == null)
				{
					r_MUIEOnOpacityChanged_VisualElement_Boolean = new(this, "UIEOnOpacityChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_MUIEOnOpacityChanged_VisualElement_Boolean.SetBelong(this.GetValue());
				}
				return r_MUIEOnOpacityChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnColorChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUIEOnColorChanged_VisualElement;
		public virtual RMethod RMUIEOnColorChanged_VisualElement
		{
			get
			{
				if(r_MUIEOnColorChanged_VisualElement == null)
				{
					r_MUIEOnColorChanged_VisualElement = new(this, "UIEOnColorChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUIEOnColorChanged_VisualElement.SetBelong(this.GetValue());
				}
				return r_MUIEOnColorChanged_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean;
		public virtual RMethod RMUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean
		{
			get
			{
				if(r_MUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean == null)
				{
					r_MUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean = new(this, "UIEOnTransformOrSizeChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean), typeof(System.Boolean));
					r_MUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_MUIEOnVisualsChanged_VisualElement_Boolean;
		public virtual RMethod RMUIEOnVisualsChanged_VisualElement_Boolean
		{
			get
			{
				if(r_MUIEOnVisualsChanged_VisualElement_Boolean == null)
				{
					r_MUIEOnVisualsChanged_VisualElement_Boolean = new(this, "UIEOnVisualsChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_MUIEOnVisualsChanged_VisualElement_Boolean.SetBelong(this.GetValue());
				}
				return r_MUIEOnVisualsChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnOpacityIdChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUIEOnOpacityIdChanged_VisualElement;
		public virtual RMethod RMUIEOnOpacityIdChanged_VisualElement
		{
			get
			{
				if(r_MUIEOnOpacityIdChanged_VisualElement == null)
				{
					r_MUIEOnOpacityIdChanged_VisualElement = new(this, "UIEOnOpacityIdChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUIEOnOpacityIdChanged_VisualElement.SetBelong(this.GetValue());
				}
				return r_MUIEOnOpacityIdChanged_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetStandardMaterial()
		/// </summary>
		protected RMethod r_MGetStandardMaterial;
		public virtual RMethod RMGetStandardMaterial
		{
			get
			{
				if(r_MGetStandardMaterial == null)
				{
					r_MGetStandardMaterial = new(this, "GetStandardMaterial", 0);
					r_MGetStandardMaterial.SetBelong(this.GetValue());
				}
				return r_MGetStandardMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetStandardWorldSpaceMaterial()
		/// </summary>
		protected RMethod r_MGetStandardWorldSpaceMaterial;
		public virtual RMethod RMGetStandardWorldSpaceMaterial
		{
			get
			{
				if(r_MGetStandardWorldSpaceMaterial == null)
				{
					r_MGetStandardWorldSpaceMaterial = new(this, "GetStandardWorldSpaceMaterial", 0);
					r_MGetStandardWorldSpaceMaterial.SetBelong(this.GetValue());
				}
				return r_MGetStandardWorldSpaceMaterial;
			}
		}

		/// <summary>
		/// Void EnsureFitsDepth(Int32)
		/// </summary>
		protected RMethod r_MEnsureFitsDepth_Int32;
		public virtual RMethod RMEnsureFitsDepth_Int32
		{
			get
			{
				if(r_MEnsureFitsDepth_Int32 == null)
				{
					r_MEnsureFitsDepth_Int32 = new(this, "EnsureFitsDepth", 0, typeof(System.Int32));
					r_MEnsureFitsDepth_Int32.SetBelong(this.GetValue());
				}
				return r_MEnsureFitsDepth_Int32;
			}
		}

		/// <summary>
		/// Void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MChildWillBeRemoved_VisualElement;
		public virtual RMethod RMChildWillBeRemoved_VisualElement
		{
			get
			{
				if(r_MChildWillBeRemoved_VisualElement == null)
				{
					r_MChildWillBeRemoved_VisualElement = new(this, "ChildWillBeRemoved", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MChildWillBeRemoved_VisualElement.SetBelong(this.GetValue());
				}
				return r_MChildWillBeRemoved_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand()
		/// </summary>
		protected RMethod r_MAllocCommand;
		public virtual RMethod RMAllocCommand
		{
			get
			{
				if(r_MAllocCommand == null)
				{
					r_MAllocCommand = new(this, "AllocCommand", 0);
					r_MAllocCommand.SetBelong(this.GetValue());
				}
				return r_MAllocCommand;
			}
		}

		/// <summary>
		/// Void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_MFreeCommand_RenderChainCommand;
		public virtual RMethod RMFreeCommand_RenderChainCommand
		{
			get
			{
				if(r_MFreeCommand_RenderChainCommand == null)
				{
					r_MFreeCommand_RenderChainCommand = new(this, "FreeCommand", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_MFreeCommand_RenderChainCommand.SetBelong(this.GetValue());
				}
				return r_MFreeCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_MOnRenderCommandAdded_RenderChainCommand;
		public virtual RMethod RMOnRenderCommandAdded_RenderChainCommand
		{
			get
			{
				if(r_MOnRenderCommandAdded_RenderChainCommand == null)
				{
					r_MOnRenderCommandAdded_RenderChainCommand = new(this, "OnRenderCommandAdded", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_MOnRenderCommandAdded_RenderChainCommand.SetBelong(this.GetValue());
				}
				return r_MOnRenderCommandAdded_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand, UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_MOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand;
		public virtual RMethod RMOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand
		{
			get
			{
				if(r_MOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand == null)
				{
					r_MOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand = new(this, "OnRenderCommandsRemoved", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_MOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand.SetBelong(this.GetValue());
				}
				return r_MOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// RenderNodeData AccessRenderNodeData(IntPtr)
		/// </summary>
		protected static RMethod r_MAccessRenderNodeData_IntPtr;
		public static RMethod RMAccessRenderNodeData_IntPtr
		{
			get
			{
				if(r_MAccessRenderNodeData_IntPtr == null)
				{
					r_MAccessRenderNodeData_IntPtr = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "AccessRenderNodeData", 0, typeof(System.IntPtr));
					r_MAccessRenderNodeData_IntPtr.SetBelong(null);
				}
				return r_MAccessRenderNodeData_IntPtr;
			}
		}

		/// <summary>
		/// Void OnRenderNodeExecute(IntPtr)
		/// </summary>
		protected static RMethod r_MOnRenderNodeExecute_IntPtr;
		public static RMethod RMOnRenderNodeExecute_IntPtr
		{
			get
			{
				if(r_MOnRenderNodeExecute_IntPtr == null)
				{
					r_MOnRenderNodeExecute_IntPtr = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRenderNodeExecute", 0, typeof(System.IntPtr));
					r_MOnRenderNodeExecute_IntPtr.SetBelong(null);
				}
				return r_MOnRenderNodeExecute_IntPtr;
			}
		}

		/// <summary>
		/// Void OnRegisterIntermediateRenderers(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_MOnRegisterIntermediateRenderers_Camera;
		public static RMethod RMOnRegisterIntermediateRenderers_Camera
		{
			get
			{
				if(r_MOnRegisterIntermediateRenderers_Camera == null)
				{
					r_MOnRegisterIntermediateRenderers_Camera = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRegisterIntermediateRenderers", 0, typeof(UnityEngine.Camera));
					r_MOnRegisterIntermediateRenderers_Camera.SetBelong(null);
				}
				return r_MOnRegisterIntermediateRenderers_Camera;
			}
		}

		/// <summary>
		/// Void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel, UnityEngine.UIElements.UIR.RenderChain, RenderNodeData ByRef, UnityEngine.Camera, Int32)
		/// </summary>
		protected static RMethod r_MOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32;
		public static RMethod RMOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32
		{
			get
			{
				if(r_MOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32 == null)
				{
					r_MOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRegisterIntermediateRendererMat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain+RenderNodeData").MakeByRefType(), typeof(UnityEngine.Camera), typeof(System.Int32));
					r_MOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32.SetBelong(null);
				}
				return r_MOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32;
			}
		}

		/// <summary>
		/// Void RepaintTexturedElements()
		/// </summary>
		protected RMethod r_MRepaintTexturedElements;
		public virtual RMethod RMRepaintTexturedElements
		{
			get
			{
				if(r_MRepaintTexturedElements == null)
				{
					r_MRepaintTexturedElements = new(this, "RepaintTexturedElements", 0);
					r_MRepaintTexturedElements.SetBelong(this.GetValue());
				}
				return r_MRepaintTexturedElements;
			}
		}

		/// <summary>
		/// Void AppendTexture(UnityEngine.UIElements.VisualElement, UnityEngine.Texture, UnityEngine.UIElements.TextureId, Boolean)
		/// </summary>
		protected RMethod r_MAppendTexture_VisualElement_Texture_TextureId_Boolean;
		public virtual RMethod RMAppendTexture_VisualElement_Texture_TextureId_Boolean
		{
			get
			{
				if(r_MAppendTexture_VisualElement_Texture_TextureId_Boolean == null)
				{
					r_MAppendTexture_VisualElement_Texture_TextureId_Boolean = new(this, "AppendTexture", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Boolean));
					r_MAppendTexture_VisualElement_Texture_TextureId_Boolean.SetBelong(this.GetValue());
				}
				return r_MAppendTexture_VisualElement_Texture_TextureId_Boolean;
			}
		}

		/// <summary>
		/// Void ResetTextures(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MResetTextures_VisualElement;
		public virtual RMethod RMResetTextures_VisualElement
		{
			get
			{
				if(r_MResetTextures_VisualElement == null)
				{
					r_MResetTextures_VisualElement = new(this, "ResetTextures", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MResetTextures_VisualElement.SetBelong(this.GetValue());
				}
				return r_MResetTextures_VisualElement;
			}
		}

		/// <summary>
		/// Void DrawStats()
		/// </summary>
		protected RMethod r_MDrawStats;
		public virtual RMethod RMDrawStats
		{
			get
			{
				if(r_MDrawStats == null)
				{
					r_MDrawStats = new(this, "DrawStats", 0);
					r_MDrawStats.SetBelong(this.GetValue());
				}
				return r_MDrawStats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_MGetFirstElementInPanel_VisualElement;
		public static RMethod RMGetFirstElementInPanel_VisualElement
		{
			get
			{
				if(r_MGetFirstElementInPanel_VisualElement == null)
				{
					r_MGetFirstElementInPanel_VisualElement = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "GetFirstElementInPanel", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MGetFirstElementInPanel_VisualElement.SetBelong(null);
				}
				return r_MGetFirstElementInPanel_VisualElement;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RRenderChain() : base("UnityEngine.UIElements.UIR.RenderChain")
        {
        }

        public RRenderChain(System.Object instance) : base("UnityEngine.UIElements.UIR.RenderChain")
		{
            SetInstance(instance);
		}

        public RRenderChain(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderChain(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Constructor(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel @panelObj, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice @deviceObj, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase @atlas, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager @vectorImageMan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panelObj.Value, @deviceObj.Value, @atlas.Value, @vectorImageMan.Value};
            var ___result = RMConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destructor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDestructor.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ProcessChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProcessChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Render()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRender.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnChildAdded(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMUIEOnChildAdded_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMUIEOnChildrenReordered_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMUIEOnChildRemoving_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMUIEOnRenderHintsChanged_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement @ve, System.Boolean @hierarchical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @hierarchical};
            var ___result = RMUIEOnClippingChanged_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement @ve, System.Boolean @hierarchical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @hierarchical};
            var ___result = RMUIEOnOpacityChanged_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnColorChanged(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMUIEOnColorChanged_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement @ve, System.Boolean @transformChanged, System.Boolean @clipRectSizeChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @transformChanged, @clipRectSizeChanged};
            var ___result = RMUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement @ve, System.Boolean @hierarchical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @hierarchical};
            var ___result = RMUIEOnVisualsChanged_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnOpacityIdChanged(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMUIEOnOpacityIdChanged_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material GetStandardMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStandardMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual UnityEngine.Material GetStandardWorldSpaceMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStandardWorldSpaceMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual void EnsureFitsDepth(System.Int32 @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depth};
            var ___result = RMEnsureFitsDepth_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMChildWillBeRemoved_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand AllocCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocCommand.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand(___result);
        }


        public virtual void FreeCommand(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd.Value};
            var ___result = RMFreeCommand_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRenderCommandAdded(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand @command)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@command.Value};
            var ___result = RMOnRenderCommandAdded_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRenderCommandsRemoved(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand @firstCommand, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand @lastCommand)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstCommand.Value, @lastCommand.Value};
            var ___result = RMOnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData AccessRenderNodeData(System.IntPtr @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMAccessRenderNodeData_IntPtr.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData(___result);
        }


        public static void OnRenderNodeExecute(System.IntPtr @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMOnRenderNodeExecute_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnRegisterIntermediateRenderers(UnityEngine.Camera @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@camera};
            var ___result = RMOnRegisterIntermediateRenderers_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnRegisterIntermediateRendererMat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseRuntimePanel @rtp, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain @renderChain, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData @rnd, UnityEngine.Camera @camera, System.Int32 @sameDistanceSortPriority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rtp.Value, @renderChain.Value, @rnd.Value, @camera, @sameDistanceSortPriority};
            var ___result = RMOnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32.Invoke(___genericsType, ___parameters);
			@rnd = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData(___parameters[2]);

            
        }


        public virtual void RepaintTexturedElements()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaintTexturedElements.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendTexture(UnityEngine.UIElements.VisualElement @ve, UnityEngine.Texture @src, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id, System.Boolean @isAtlas)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @src, @id.Value, @isAtlas};
            var ___result = RMAppendTexture_VisualElement_Texture_TextureId_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetTextures(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMResetTextures_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawStats()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawStats.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMGetFirstElementInPanel_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
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
