using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.RenderChain
	/// </summary>
    public partial class RRenderChain : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand m_FirstCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_m_FirstCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand Rm_FirstCommand
		{
			get
			{
				if(r_m_FirstCommand == null)
				{
					r_m_FirstCommand = new(this, "m_FirstCommand");
					r_m_FirstCommand.SetBelong(this.instance);
				}
				return r_m_FirstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking m_DirtyTracker
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChain.RDepthOrderedDirtyTracking r_m_DirtyTracker;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChain.RDepthOrderedDirtyTracking Rm_DirtyTracker
		{
			get
			{
				if(r_m_DirtyTracker == null)
				{
					r_m_DirtyTracker = new(this, "m_DirtyTracker");
					r_m_DirtyTracker.SetBelong(this.instance);
				}
				return r_m_DirtyTracker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.LinkedPool`1[UnityEngine.UIElements.UIR.RenderChainCommand] m_CommandPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RLinkedPool<RUnityEngine.RUIElements.RUIR.RRenderChainCommand> r_m_CommandPool;
		public virtual RUnityEngine.RUIElements.RUIR.RLinkedPool<RUnityEngine.RUIElements.RUIR.RRenderChainCommand> Rm_CommandPool
		{
			get
			{
				if(r_m_CommandPool == null)
				{
					r_m_CommandPool = new(this, "m_CommandPool");
					r_m_CommandPool.SetBelong(this.instance);
				}
				return r_m_CommandPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNodePool`1[UnityEngine.UIElements.UIR.TextureEntry] m_TexturePool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBasicNodePool<RUnityEngine.RUIElements.RUIR.RTextureEntry> r_m_TexturePool;
		public virtual RUnityEngine.RUIElements.RUIR.RBasicNodePool<RUnityEngine.RUIElements.RUIR.RTextureEntry> Rm_TexturePool
		{
			get
			{
				if(r_m_TexturePool == null)
				{
					r_m_TexturePool = new(this, "m_TexturePool");
					r_m_TexturePool.SetBelong(this.instance);
				}
				return r_m_TexturePool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.RenderChain+RenderNodeData] m_RenderNodesData
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData> r_m_RenderNodesData;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData> Rm_RenderNodesData
		{
			get
			{
				if(r_m_RenderNodesData == null)
				{
					r_m_RenderNodesData = new(this, "m_RenderNodesData");
					r_m_RenderNodesData.SetBelong(this.instance);
				}
				return r_m_RenderNodesData;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_DefaultShader
		/// </summary>
		protected RUnityEngine.RShader r_m_DefaultShader;
		public virtual RUnityEngine.RShader Rm_DefaultShader
		{
			get
			{
				if(r_m_DefaultShader == null)
				{
					r_m_DefaultShader = new(this, "m_DefaultShader");
					r_m_DefaultShader.SetBelong(this.instance);
				}
				return r_m_DefaultShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_DefaultWorldSpaceShader
		/// </summary>
		protected RUnityEngine.RShader r_m_DefaultWorldSpaceShader;
		public virtual RUnityEngine.RShader Rm_DefaultWorldSpaceShader
		{
			get
			{
				if(r_m_DefaultWorldSpaceShader == null)
				{
					r_m_DefaultWorldSpaceShader = new(this, "m_DefaultWorldSpaceShader");
					r_m_DefaultWorldSpaceShader.SetBelong(this.instance);
				}
				return r_m_DefaultWorldSpaceShader;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_DefaultMat
		/// </summary>
		protected RUnityEngine.RMaterial r_m_DefaultMat;
		public virtual RUnityEngine.RMaterial Rm_DefaultMat
		{
			get
			{
				if(r_m_DefaultMat == null)
				{
					r_m_DefaultMat = new(this, "m_DefaultMat");
					r_m_DefaultMat.SetBelong(this.instance);
				}
				return r_m_DefaultMat;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_DefaultWorldSpaceMat
		/// </summary>
		protected RUnityEngine.RMaterial r_m_DefaultWorldSpaceMat;
		public virtual RUnityEngine.RMaterial Rm_DefaultWorldSpaceMat
		{
			get
			{
				if(r_m_DefaultWorldSpaceMat == null)
				{
					r_m_DefaultWorldSpaceMat = new(this, "m_DefaultWorldSpaceMat");
					r_m_DefaultWorldSpaceMat.SetBelong(this.instance);
				}
				return r_m_DefaultWorldSpaceMat;
			}
		}

		/// <summary>
		/// System.Boolean m_BlockDirtyRegistration
		/// </summary>
		protected RField r_m_BlockDirtyRegistration;
		public virtual RField Rm_BlockDirtyRegistration
		{
			get
			{
				if(r_m_BlockDirtyRegistration == null)
				{
					r_m_BlockDirtyRegistration = new(this, "m_BlockDirtyRegistration");
					r_m_BlockDirtyRegistration.SetBelong(this.instance);
				}
				return r_m_BlockDirtyRegistration;
			}
		}

		/// <summary>
		/// System.Int32 m_StaticIndex
		/// </summary>
		protected RField r_m_StaticIndex;
		public virtual RField Rm_StaticIndex
		{
			get
			{
				if(r_m_StaticIndex == null)
				{
					r_m_StaticIndex = new(this, "m_StaticIndex");
					r_m_StaticIndex.SetBelong(this.instance);
				}
				return r_m_StaticIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_ActiveRenderNodes
		/// </summary>
		protected RField r_m_ActiveRenderNodes;
		public virtual RField Rm_ActiveRenderNodes
		{
			get
			{
				if(r_m_ActiveRenderNodes == null)
				{
					r_m_ActiveRenderNodes = new(this, "m_ActiveRenderNodes");
					r_m_ActiveRenderNodes.SetBelong(this.instance);
				}
				return r_m_ActiveRenderNodes;
			}
		}

		/// <summary>
		/// System.Int32 m_CustomMaterialCommands
		/// </summary>
		protected RField r_m_CustomMaterialCommands;
		public virtual RField Rm_CustomMaterialCommands
		{
			get
			{
				if(r_m_CustomMaterialCommands == null)
				{
					r_m_CustomMaterialCommands = new(this, "m_CustomMaterialCommands");
					r_m_CustomMaterialCommands.SetBelong(this.instance);
				}
				return r_m_CustomMaterialCommands;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.ChainBuilderStats m_Stats
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RChainBuilderStats r_m_Stats;
		public virtual RUnityEngine.RUIElements.RUIR.RChainBuilderStats Rm_Stats
		{
			get
			{
				if(r_m_Stats == null)
				{
					r_m_Stats = new(this, "m_Stats");
					r_m_Stats.SetBelong(this.instance);
				}
				return r_m_Stats;
			}
		}

		/// <summary>
		/// System.UInt32 m_StatsElementsAdded
		/// </summary>
		protected RField r_m_StatsElementsAdded;
		public virtual RField Rm_StatsElementsAdded
		{
			get
			{
				if(r_m_StatsElementsAdded == null)
				{
					r_m_StatsElementsAdded = new(this, "m_StatsElementsAdded");
					r_m_StatsElementsAdded.SetBelong(this.instance);
				}
				return r_m_StatsElementsAdded;
			}
		}

		/// <summary>
		/// System.UInt32 m_StatsElementsRemoved
		/// </summary>
		protected RField r_m_StatsElementsRemoved;
		public virtual RField Rm_StatsElementsRemoved
		{
			get
			{
				if(r_m_StatsElementsRemoved == null)
				{
					r_m_StatsElementsRemoved = new(this, "m_StatsElementsRemoved");
					r_m_StatsElementsRemoved.SetBelong(this.instance);
				}
				return r_m_StatsElementsRemoved;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry m_TextureRegistry
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureRegistry r_m_TextureRegistry;
		public virtual RUnityEngine.RUIElements.RTextureRegistry Rm_TextureRegistry
		{
			get
			{
				if(r_m_TextureRegistry == null)
				{
					r_m_TextureRegistry = new(this, "m_TextureRegistry");
					r_m_TextureRegistry.SetBelong(this.instance);
				}
				return r_m_TextureRegistry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.OpacityIdAccelerator <opacityIdAccelerator>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator r___1__opacityIdAccelerator__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator R__1__opacityIdAccelerator__2__k__BackingField
		{
			get
			{
				if(r___1__opacityIdAccelerator__2__k__BackingField == null)
				{
					r___1__opacityIdAccelerator__2__k__BackingField = new(this, "<opacityIdAccelerator>k__BackingField");
					r___1__opacityIdAccelerator__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__opacityIdAccelerator__2__k__BackingField;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerProcess
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerProcess;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerProcess
		{
			get
			{
				if(r_s_MarkerProcess == null)
				{
					r_s_MarkerProcess = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerProcess");
					r_s_MarkerProcess.SetBelong(null);
				}
				return r_s_MarkerProcess;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerClipProcessing
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerClipProcessing;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerClipProcessing
		{
			get
			{
				if(r_s_MarkerClipProcessing == null)
				{
					r_s_MarkerClipProcessing = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerClipProcessing");
					r_s_MarkerClipProcessing.SetBelong(null);
				}
				return r_s_MarkerClipProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerOpacityProcessing
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerOpacityProcessing;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerOpacityProcessing
		{
			get
			{
				if(r_s_MarkerOpacityProcessing == null)
				{
					r_s_MarkerOpacityProcessing = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerOpacityProcessing");
					r_s_MarkerOpacityProcessing.SetBelong(null);
				}
				return r_s_MarkerOpacityProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerColorsProcessing
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerColorsProcessing;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerColorsProcessing
		{
			get
			{
				if(r_s_MarkerColorsProcessing == null)
				{
					r_s_MarkerColorsProcessing = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerColorsProcessing");
					r_s_MarkerColorsProcessing.SetBelong(null);
				}
				return r_s_MarkerColorsProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerTransformProcessing
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerTransformProcessing;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerTransformProcessing
		{
			get
			{
				if(r_s_MarkerTransformProcessing == null)
				{
					r_s_MarkerTransformProcessing = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerTransformProcessing");
					r_s_MarkerTransformProcessing.SetBelong(null);
				}
				return r_s_MarkerTransformProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerVisualsProcessing
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerVisualsProcessing;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerVisualsProcessing
		{
			get
			{
				if(r_s_MarkerVisualsProcessing == null)
				{
					r_s_MarkerVisualsProcessing = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerVisualsProcessing");
					r_s_MarkerVisualsProcessing.SetBelong(null);
				}
				return r_s_MarkerVisualsProcessing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerTextRegen
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerTextRegen;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerTextRegen
		{
			get
			{
				if(r_s_MarkerTextRegen == null)
				{
					r_s_MarkerTextRegen = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerTextRegen");
					r_s_MarkerTextRegen.SetBelong(null);
				}
				return r_s_MarkerTextRegen;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RField r___1__disposed__2__k__BackingField;
		public virtual RField R__1__disposed__2__k__BackingField
		{
			get
			{
				if(r___1__disposed__2__k__BackingField == null)
				{
					r___1__disposed__2__k__BackingField = new(this, "<disposed>k__BackingField");
					r___1__disposed__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__disposed__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action OnPreRender
		/// </summary>
		protected static RSystem.RAction r_OnPreRender;
		public static RSystem.RAction ROnPreRender
		{
			get
			{
				if(r_OnPreRender == null)
				{
					r_OnPreRender = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnPreRender");
					r_OnPreRender.SetBelong(null);
				}
				return r_OnPreRender;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r___1__panel__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel R__1__panel__2__k__BackingField
		{
			get
			{
				if(r___1__panel__2__k__BackingField == null)
				{
					r___1__panel__2__k__BackingField = new(this, "<panel>k__BackingField");
					r___1__panel__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__panel__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice r___1__device__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice R__1__device__2__k__BackingField
		{
			get
			{
				if(r___1__device__2__k__BackingField == null)
				{
					r___1__device__2__k__BackingField = new(this, "<device>k__BackingField");
					r___1__device__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__device__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase <atlas>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RAtlasBase r___1__atlas__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RAtlasBase R__1__atlas__2__k__BackingField
		{
			get
			{
				if(r___1__atlas__2__k__BackingField == null)
				{
					r___1__atlas__2__k__BackingField = new(this, "<atlas>k__BackingField");
					r___1__atlas__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__atlas__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RVectorImageManager r___1__vectorImageManager__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RVectorImageManager R__1__vectorImageManager__2__k__BackingField
		{
			get
			{
				if(r___1__vectorImageManager__2__k__BackingField == null)
				{
					r___1__vectorImageManager__2__k__BackingField = new(this, "<vectorImageManager>k__BackingField");
					r___1__vectorImageManager__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__vectorImageManager__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] <vertsPool>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> r___1__vertsPool__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> R__1__vertsPool__2__k__BackingField
		{
			get
			{
				if(r___1__vertsPool__2__k__BackingField == null)
				{
					r___1__vertsPool__2__k__BackingField = new(this, "<vertsPool>k__BackingField");
					r___1__vertsPool__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__vertsPool__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] <indicesPool>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> r___1__indicesPool__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> R__1__indicesPool__2__k__BackingField
		{
			get
			{
				if(r___1__indicesPool__2__k__BackingField == null)
				{
					r___1__indicesPool__2__k__BackingField = new(this, "<indicesPool>k__BackingField");
					r___1__indicesPool__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__indicesPool__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobManager <jobManager>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RJobManager r___1__jobManager__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RJobManager R__1__jobManager__2__k__BackingField
		{
			get
			{
				if(r___1__jobManager__2__k__BackingField == null)
				{
					r___1__jobManager__2__k__BackingField = new(this, "<jobManager>k__BackingField");
					r___1__jobManager__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__jobManager__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator shaderInfoAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRVEShaderInfoAllocator r_shaderInfoAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRVEShaderInfoAllocator RshaderInfoAllocator
		{
			get
			{
				if(r_shaderInfoAllocator == null)
				{
					r_shaderInfoAllocator = new(this, "shaderInfoAllocator");
					r_shaderInfoAllocator.SetBelong(this.instance);
				}
				return r_shaderInfoAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter <painter>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter r___1__painter__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter R__1__painter__2__k__BackingField
		{
			get
			{
				if(r___1__painter__2__k__BackingField == null)
				{
					r___1__painter__2__k__BackingField = new(this, "<painter>k__BackingField");
					r___1__painter__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__painter__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <drawStats>k__BackingField
		/// </summary>
		protected RField r___1__drawStats__2__k__BackingField;
		public virtual RField R__1__drawStats__2__k__BackingField
		{
			get
			{
				if(r___1__drawStats__2__k__BackingField == null)
				{
					r___1__drawStats__2__k__BackingField = new(this, "<drawStats>k__BackingField");
					r___1__drawStats__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__drawStats__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <drawInCameras>k__BackingField
		/// </summary>
		protected RField r___1__drawInCameras__2__k__BackingField;
		public virtual RField R__1__drawInCameras__2__k__BackingField
		{
			get
			{
				if(r___1__drawInCameras__2__k__BackingField == null)
				{
					r___1__drawInCameras__2__k__BackingField = new(this, "<drawInCameras>k__BackingField");
					r___1__drawInCameras__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__drawInCameras__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_firstCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RfirstCommand
		{
			get
			{
				if(r_firstCommand == null)
				{
					r_firstCommand = new(this, "firstCommand", -1);
					r_firstCommand.SetBelong(this.instance);
				}
				return r_firstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.OpacityIdAccelerator opacityIdAccelerator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator r_opacityIdAccelerator;
		public virtual RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator RopacityIdAccelerator
		{
			get
			{
				if(r_opacityIdAccelerator == null)
				{
					r_opacityIdAccelerator = new(this, "opacityIdAccelerator", -1);
					r_opacityIdAccelerator.SetBelong(this.instance);
				}
				return r_opacityIdAccelerator;
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
		/// UnityEngine.UIElements.UIR.ChainBuilderStats stats
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RChainBuilderStats r_stats;
		public virtual RUnityEngine.RUIElements.RUIR.RChainBuilderStats Rstats
		{
			get
			{
				if(r_stats == null)
				{
					r_stats = new(this, "stats", -1);
					r_stats.SetBelong(this.instance);
				}
				return r_stats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_panel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel Rpanel
		{
			get
			{
				if(r_panel == null)
				{
					r_panel = new(this, "panel", -1);
					r_panel.SetBelong(this.instance);
				}
				return r_panel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice device
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice r_device;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice Rdevice
		{
			get
			{
				if(r_device == null)
				{
					r_device = new(this, "device", -1);
					r_device.SetBelong(this.instance);
				}
				return r_device;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase atlas
		/// </summary>
		protected RUnityEngine.RUIElements.RAtlasBase r_atlas;
		public virtual RUnityEngine.RUIElements.RAtlasBase Ratlas
		{
			get
			{
				if(r_atlas == null)
				{
					r_atlas = new(this, "atlas", -1);
					r_atlas.SetBelong(this.instance);
				}
				return r_atlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager vectorImageManager
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RVectorImageManager r_vectorImageManager;
		public virtual RUnityEngine.RUIElements.RUIR.RVectorImageManager RvectorImageManager
		{
			get
			{
				if(r_vectorImageManager == null)
				{
					r_vectorImageManager = new(this, "vectorImageManager", -1);
					r_vectorImageManager.SetBelong(this.instance);
				}
				return r_vectorImageManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] vertsPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> r_vertsPool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> RvertsPool
		{
			get
			{
				if(r_vertsPool == null)
				{
					r_vertsPool = new(this, "vertsPool", -1);
					r_vertsPool.SetBelong(this.instance);
				}
				return r_vertsPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] indicesPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RProperty> r_indicesPool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RProperty> RindicesPool
		{
			get
			{
				if(r_indicesPool == null)
				{
					r_indicesPool = new(this, "indicesPool", -1);
					r_indicesPool.SetBelong(this.instance);
				}
				return r_indicesPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobManager jobManager
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RJobManager r_jobManager;
		public virtual RUnityEngine.RUIElements.RUIR.RJobManager RjobManager
		{
			get
			{
				if(r_jobManager == null)
				{
					r_jobManager = new(this, "jobManager", -1);
					r_jobManager.SetBelong(this.instance);
				}
				return r_jobManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter painter
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter r_painter;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter Rpainter
		{
			get
			{
				if(r_painter == null)
				{
					r_painter = new(this, "painter", -1);
					r_painter.SetBelong(this.instance);
				}
				return r_painter;
			}
		}

		/// <summary>
		/// Boolean drawStats
		/// </summary>
		protected RProperty r_drawStats;
		public virtual RProperty RdrawStats
		{
			get
			{
				if(r_drawStats == null)
				{
					r_drawStats = new(this, "drawStats", -1);
					r_drawStats.SetBelong(this.instance);
				}
				return r_drawStats;
			}
		}

		/// <summary>
		/// Boolean drawInCameras
		/// </summary>
		protected RProperty r_drawInCameras;
		public virtual RProperty RdrawInCameras
		{
			get
			{
				if(r_drawInCameras == null)
				{
					r_drawInCameras = new(this, "drawInCameras", -1);
					r_drawInCameras.SetBelong(this.instance);
				}
				return r_drawInCameras;
			}
		}

		/// <summary>
		/// UnityEngine.Shader defaultShader
		/// </summary>
		protected RUnityEngine.RShader r_defaultShader;
		public virtual RUnityEngine.RShader RdefaultShader
		{
			get
			{
				if(r_defaultShader == null)
				{
					r_defaultShader = new(this, "defaultShader", -1);
					r_defaultShader.SetBelong(this.instance);
				}
				return r_defaultShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader defaultWorldSpaceShader
		/// </summary>
		protected RUnityEngine.RShader r_defaultWorldSpaceShader;
		public virtual RUnityEngine.RShader RdefaultWorldSpaceShader
		{
			get
			{
				if(r_defaultWorldSpaceShader == null)
				{
					r_defaultWorldSpaceShader = new(this, "defaultWorldSpaceShader", -1);
					r_defaultWorldSpaceShader.SetBelong(this.instance);
				}
				return r_defaultWorldSpaceShader;
			}
		}

		/// <summary>
		/// Void Constructor(UnityEngine.UIElements.BaseVisualElementPanel, UnityEngine.UIElements.UIR.UIRenderDevice, UnityEngine.UIElements.AtlasBase, UnityEngine.UIElements.UIR.VectorImageManager)
		/// </summary>
		protected RMethod r_RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager;
		public virtual RMethod RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager
		{
			get
			{
				if(r_RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager == null)
				{
					r_RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager = new(this, "Constructor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"),  ReleactionUtils.GetType("UnityEngine.UIElements.AtlasBase"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"));
					r_RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager.SetBelong(this.instance);
				}
				return r_RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager;
			}
		}

		/// <summary>
		/// Void Destructor()
		/// </summary>
		protected RMethod r_RDestructor;
		public virtual RMethod RDestructor
		{
			get
			{
				if(r_RDestructor == null)
				{
					r_RDestructor = new(this, "Destructor", 0);
					r_RDestructor.SetBelong(this.instance);
				}
				return r_RDestructor;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void ProcessChanges()
		/// </summary>
		protected RMethod r_RProcessChanges;
		public virtual RMethod RProcessChanges
		{
			get
			{
				if(r_RProcessChanges == null)
				{
					r_RProcessChanges = new(this, "ProcessChanges", 0);
					r_RProcessChanges.SetBelong(this.instance);
				}
				return r_RProcessChanges;
			}
		}

		/// <summary>
		/// Void Render()
		/// </summary>
		protected RMethod r_RRender;
		public virtual RMethod RRender
		{
			get
			{
				if(r_RRender == null)
				{
					r_RRender = new(this, "Render", 0);
					r_RRender.SetBelong(this.instance);
				}
				return r_RRender;
			}
		}

		/// <summary>
		/// Void UIEOnChildAdded(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUIEOnChildAdded_VisualElement;
		public virtual RMethod RUIEOnChildAdded_VisualElement
		{
			get
			{
				if(r_RUIEOnChildAdded_VisualElement == null)
				{
					r_RUIEOnChildAdded_VisualElement = new(this, "UIEOnChildAdded", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUIEOnChildAdded_VisualElement.SetBelong(this.instance);
				}
				return r_RUIEOnChildAdded_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUIEOnChildrenReordered_VisualElement;
		public virtual RMethod RUIEOnChildrenReordered_VisualElement
		{
			get
			{
				if(r_RUIEOnChildrenReordered_VisualElement == null)
				{
					r_RUIEOnChildrenReordered_VisualElement = new(this, "UIEOnChildrenReordered", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUIEOnChildrenReordered_VisualElement.SetBelong(this.instance);
				}
				return r_RUIEOnChildrenReordered_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUIEOnChildRemoving_VisualElement;
		public virtual RMethod RUIEOnChildRemoving_VisualElement
		{
			get
			{
				if(r_RUIEOnChildRemoving_VisualElement == null)
				{
					r_RUIEOnChildRemoving_VisualElement = new(this, "UIEOnChildRemoving", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUIEOnChildRemoving_VisualElement.SetBelong(this.instance);
				}
				return r_RUIEOnChildRemoving_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUIEOnRenderHintsChanged_VisualElement;
		public virtual RMethod RUIEOnRenderHintsChanged_VisualElement
		{
			get
			{
				if(r_RUIEOnRenderHintsChanged_VisualElement == null)
				{
					r_RUIEOnRenderHintsChanged_VisualElement = new(this, "UIEOnRenderHintsChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUIEOnRenderHintsChanged_VisualElement.SetBelong(this.instance);
				}
				return r_RUIEOnRenderHintsChanged_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_RUIEOnClippingChanged_VisualElement_Boolean;
		public virtual RMethod RUIEOnClippingChanged_VisualElement_Boolean
		{
			get
			{
				if(r_RUIEOnClippingChanged_VisualElement_Boolean == null)
				{
					r_RUIEOnClippingChanged_VisualElement_Boolean = new(this, "UIEOnClippingChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_RUIEOnClippingChanged_VisualElement_Boolean.SetBelong(this.instance);
				}
				return r_RUIEOnClippingChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_RUIEOnOpacityChanged_VisualElement_Boolean;
		public virtual RMethod RUIEOnOpacityChanged_VisualElement_Boolean
		{
			get
			{
				if(r_RUIEOnOpacityChanged_VisualElement_Boolean == null)
				{
					r_RUIEOnOpacityChanged_VisualElement_Boolean = new(this, "UIEOnOpacityChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_RUIEOnOpacityChanged_VisualElement_Boolean.SetBelong(this.instance);
				}
				return r_RUIEOnOpacityChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnColorChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUIEOnColorChanged_VisualElement;
		public virtual RMethod RUIEOnColorChanged_VisualElement
		{
			get
			{
				if(r_RUIEOnColorChanged_VisualElement == null)
				{
					r_RUIEOnColorChanged_VisualElement = new(this, "UIEOnColorChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUIEOnColorChanged_VisualElement.SetBelong(this.instance);
				}
				return r_RUIEOnColorChanged_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean;
		public virtual RMethod RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean
		{
			get
			{
				if(r_RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean == null)
				{
					r_RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean = new(this, "UIEOnTransformOrSizeChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean), typeof(System.Boolean));
					r_RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_RUIEOnVisualsChanged_VisualElement_Boolean;
		public virtual RMethod RUIEOnVisualsChanged_VisualElement_Boolean
		{
			get
			{
				if(r_RUIEOnVisualsChanged_VisualElement_Boolean == null)
				{
					r_RUIEOnVisualsChanged_VisualElement_Boolean = new(this, "UIEOnVisualsChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_RUIEOnVisualsChanged_VisualElement_Boolean.SetBelong(this.instance);
				}
				return r_RUIEOnVisualsChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnOpacityIdChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUIEOnOpacityIdChanged_VisualElement;
		public virtual RMethod RUIEOnOpacityIdChanged_VisualElement
		{
			get
			{
				if(r_RUIEOnOpacityIdChanged_VisualElement == null)
				{
					r_RUIEOnOpacityIdChanged_VisualElement = new(this, "UIEOnOpacityIdChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUIEOnOpacityIdChanged_VisualElement.SetBelong(this.instance);
				}
				return r_RUIEOnOpacityIdChanged_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetStandardMaterial()
		/// </summary>
		protected RMethod r_RGetStandardMaterial;
		public virtual RMethod RGetStandardMaterial
		{
			get
			{
				if(r_RGetStandardMaterial == null)
				{
					r_RGetStandardMaterial = new(this, "GetStandardMaterial", 0);
					r_RGetStandardMaterial.SetBelong(this.instance);
				}
				return r_RGetStandardMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetStandardWorldSpaceMaterial()
		/// </summary>
		protected RMethod r_RGetStandardWorldSpaceMaterial;
		public virtual RMethod RGetStandardWorldSpaceMaterial
		{
			get
			{
				if(r_RGetStandardWorldSpaceMaterial == null)
				{
					r_RGetStandardWorldSpaceMaterial = new(this, "GetStandardWorldSpaceMaterial", 0);
					r_RGetStandardWorldSpaceMaterial.SetBelong(this.instance);
				}
				return r_RGetStandardWorldSpaceMaterial;
			}
		}

		/// <summary>
		/// Void EnsureFitsDepth(Int32)
		/// </summary>
		protected RMethod r_REnsureFitsDepth_Int32;
		public virtual RMethod REnsureFitsDepth_Int32
		{
			get
			{
				if(r_REnsureFitsDepth_Int32 == null)
				{
					r_REnsureFitsDepth_Int32 = new(this, "EnsureFitsDepth", 0, typeof(System.Int32));
					r_REnsureFitsDepth_Int32.SetBelong(this.instance);
				}
				return r_REnsureFitsDepth_Int32;
			}
		}

		/// <summary>
		/// Void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RChildWillBeRemoved_VisualElement;
		public virtual RMethod RChildWillBeRemoved_VisualElement
		{
			get
			{
				if(r_RChildWillBeRemoved_VisualElement == null)
				{
					r_RChildWillBeRemoved_VisualElement = new(this, "ChildWillBeRemoved", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RChildWillBeRemoved_VisualElement.SetBelong(this.instance);
				}
				return r_RChildWillBeRemoved_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand()
		/// </summary>
		protected RMethod r_RAllocCommand;
		public virtual RMethod RAllocCommand
		{
			get
			{
				if(r_RAllocCommand == null)
				{
					r_RAllocCommand = new(this, "AllocCommand", 0);
					r_RAllocCommand.SetBelong(this.instance);
				}
				return r_RAllocCommand;
			}
		}

		/// <summary>
		/// Void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_RFreeCommand_RenderChainCommand;
		public virtual RMethod RFreeCommand_RenderChainCommand
		{
			get
			{
				if(r_RFreeCommand_RenderChainCommand == null)
				{
					r_RFreeCommand_RenderChainCommand = new(this, "FreeCommand", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_RFreeCommand_RenderChainCommand.SetBelong(this.instance);
				}
				return r_RFreeCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_ROnRenderCommandAdded_RenderChainCommand;
		public virtual RMethod ROnRenderCommandAdded_RenderChainCommand
		{
			get
			{
				if(r_ROnRenderCommandAdded_RenderChainCommand == null)
				{
					r_ROnRenderCommandAdded_RenderChainCommand = new(this, "OnRenderCommandAdded", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_ROnRenderCommandAdded_RenderChainCommand.SetBelong(this.instance);
				}
				return r_ROnRenderCommandAdded_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand, UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand;
		public virtual RMethod ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand
		{
			get
			{
				if(r_ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand == null)
				{
					r_ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand = new(this, "OnRenderCommandsRemoved", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand.SetBelong(this.instance);
				}
				return r_ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// RenderNodeData AccessRenderNodeData(IntPtr)
		/// </summary>
		protected static RMethod r_RAccessRenderNodeData_IntPtr;
		public static RMethod RAccessRenderNodeData_IntPtr
		{
			get
			{
				if(r_RAccessRenderNodeData_IntPtr == null)
				{
					r_RAccessRenderNodeData_IntPtr = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "AccessRenderNodeData", 0, typeof(System.IntPtr));
					r_RAccessRenderNodeData_IntPtr.SetBelong(null);
				}
				return r_RAccessRenderNodeData_IntPtr;
			}
		}

		/// <summary>
		/// Void OnRenderNodeExecute(IntPtr)
		/// </summary>
		protected static RMethod r_ROnRenderNodeExecute_IntPtr;
		public static RMethod ROnRenderNodeExecute_IntPtr
		{
			get
			{
				if(r_ROnRenderNodeExecute_IntPtr == null)
				{
					r_ROnRenderNodeExecute_IntPtr = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRenderNodeExecute", 0, typeof(System.IntPtr));
					r_ROnRenderNodeExecute_IntPtr.SetBelong(null);
				}
				return r_ROnRenderNodeExecute_IntPtr;
			}
		}

		/// <summary>
		/// Void OnRegisterIntermediateRenderers(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_ROnRegisterIntermediateRenderers_Camera;
		public static RMethod ROnRegisterIntermediateRenderers_Camera
		{
			get
			{
				if(r_ROnRegisterIntermediateRenderers_Camera == null)
				{
					r_ROnRegisterIntermediateRenderers_Camera = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRegisterIntermediateRenderers", 0, typeof(UnityEngine.Camera));
					r_ROnRegisterIntermediateRenderers_Camera.SetBelong(null);
				}
				return r_ROnRegisterIntermediateRenderers_Camera;
			}
		}

		/// <summary>
		/// Void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel, UnityEngine.UIElements.UIR.RenderChain, RenderNodeData ByRef, UnityEngine.Camera, Int32)
		/// </summary>
		protected static RMethod r_ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32;
		public static RMethod ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32
		{
			get
			{
				if(r_ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32 == null)
				{
					r_ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32 = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRegisterIntermediateRendererMat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain+RenderNodeData").MakeByRefType(), typeof(UnityEngine.Camera), typeof(System.Int32));
					r_ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32.SetBelong(null);
				}
				return r_ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32;
			}
		}

		/// <summary>
		/// Void RepaintTexturedElements()
		/// </summary>
		protected RMethod r_RRepaintTexturedElements;
		public virtual RMethod RRepaintTexturedElements
		{
			get
			{
				if(r_RRepaintTexturedElements == null)
				{
					r_RRepaintTexturedElements = new(this, "RepaintTexturedElements", 0);
					r_RRepaintTexturedElements.SetBelong(this.instance);
				}
				return r_RRepaintTexturedElements;
			}
		}

		/// <summary>
		/// Void AppendTexture(UnityEngine.UIElements.VisualElement, UnityEngine.Texture, UnityEngine.UIElements.TextureId, Boolean)
		/// </summary>
		protected RMethod r_RAppendTexture_VisualElement_Texture_TextureId_Boolean;
		public virtual RMethod RAppendTexture_VisualElement_Texture_TextureId_Boolean
		{
			get
			{
				if(r_RAppendTexture_VisualElement_Texture_TextureId_Boolean == null)
				{
					r_RAppendTexture_VisualElement_Texture_TextureId_Boolean = new(this, "AppendTexture", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Boolean));
					r_RAppendTexture_VisualElement_Texture_TextureId_Boolean.SetBelong(this.instance);
				}
				return r_RAppendTexture_VisualElement_Texture_TextureId_Boolean;
			}
		}

		/// <summary>
		/// Void ResetTextures(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RResetTextures_VisualElement;
		public virtual RMethod RResetTextures_VisualElement
		{
			get
			{
				if(r_RResetTextures_VisualElement == null)
				{
					r_RResetTextures_VisualElement = new(this, "ResetTextures", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RResetTextures_VisualElement.SetBelong(this.instance);
				}
				return r_RResetTextures_VisualElement;
			}
		}

		/// <summary>
		/// Void DrawStats()
		/// </summary>
		protected RMethod r_RDrawStats;
		public virtual RMethod RDrawStats
		{
			get
			{
				if(r_RDrawStats == null)
				{
					r_RDrawStats = new(this, "DrawStats", 0);
					r_RDrawStats.SetBelong(this.instance);
				}
				return r_RDrawStats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_RGetFirstElementInPanel_VisualElement;
		public static RMethod RGetFirstElementInPanel_VisualElement
		{
			get
			{
				if(r_RGetFirstElementInPanel_VisualElement == null)
				{
					r_RGetFirstElementInPanel_VisualElement = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "GetFirstElementInPanel", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RGetFirstElementInPanel_VisualElement.SetBelong(null);
				}
				return r_RGetFirstElementInPanel_VisualElement;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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


        public virtual void Destructor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestructor.Invoke(___genericsType, ___parameters);

            
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


        public virtual void ProcessChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Render()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRender.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnChildAdded(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RUIEOnChildAdded_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RUIEOnChildrenReordered_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RUIEOnChildRemoving_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RUIEOnRenderHintsChanged_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement  @ve, System.Boolean  @hierarchical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @hierarchical};
            var ___result = RUIEOnClippingChanged_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement  @ve, System.Boolean  @hierarchical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @hierarchical};
            var ___result = RUIEOnOpacityChanged_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnColorChanged(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RUIEOnColorChanged_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement  @ve, System.Boolean  @transformChanged, System.Boolean  @clipRectSizeChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @transformChanged, @clipRectSizeChanged};
            var ___result = RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement  @ve, System.Boolean  @hierarchical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @hierarchical};
            var ___result = RUIEOnVisualsChanged_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UIEOnOpacityIdChanged(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RUIEOnOpacityIdChanged_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material GetStandardMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStandardMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual UnityEngine.Material GetStandardWorldSpaceMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStandardWorldSpaceMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual void EnsureFitsDepth(System.Int32  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depth};
            var ___result = REnsureFitsDepth_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RChildWillBeRemoved_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object AllocCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocCommand.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public static System.Object AccessRenderNodeData(System.IntPtr  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RAccessRenderNodeData_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void OnRenderNodeExecute(System.IntPtr  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnRenderNodeExecute_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnRegisterIntermediateRenderers(UnityEngine.Camera  @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@camera};
            var ___result = ROnRegisterIntermediateRenderers_Camera.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void RepaintTexturedElements()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaintTexturedElements.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ResetTextures(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RResetTextures_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawStats()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawStats.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RGetFirstElementInPanel_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
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
