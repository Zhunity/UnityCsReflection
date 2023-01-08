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
		protected RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator r___0__opacityIdAccelerator__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.ROpacityIdAccelerator R__0__opacityIdAccelerator__1__k__BackingField
		{
			get
			{
				if(r___0__opacityIdAccelerator__1__k__BackingField == null)
				{
					r___0__opacityIdAccelerator__1__k__BackingField = new(this, "<opacityIdAccelerator>k__BackingField");
					r___0__opacityIdAccelerator__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__opacityIdAccelerator__1__k__BackingField;
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
					r_s_MarkerProcess = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerProcess");
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
					r_s_MarkerClipProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerClipProcessing");
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
					r_s_MarkerOpacityProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerOpacityProcessing");
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
					r_s_MarkerColorsProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerColorsProcessing");
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
					r_s_MarkerTransformProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerTransformProcessing");
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
					r_s_MarkerVisualsProcessing = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerVisualsProcessing");
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
					r_s_MarkerTextRegen = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "s_MarkerTextRegen");
					r_s_MarkerTextRegen.SetBelong(null);
				}
				return r_s_MarkerTextRegen;
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
		/// System.Action OnPreRender
		/// </summary>
		protected static RSystem.RAction r_OnPreRender;
		public static RSystem.RAction ROnPreRender
		{
			get
			{
				if(r_OnPreRender == null)
				{
					r_OnPreRender = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnPreRender");
					r_OnPreRender.SetBelong(null);
				}
				return r_OnPreRender;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r___0__panel__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel R__0__panel__1__k__BackingField
		{
			get
			{
				if(r___0__panel__1__k__BackingField == null)
				{
					r___0__panel__1__k__BackingField = new(this, "<panel>k__BackingField");
					r___0__panel__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__panel__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice r___0__device__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice R__0__device__1__k__BackingField
		{
			get
			{
				if(r___0__device__1__k__BackingField == null)
				{
					r___0__device__1__k__BackingField = new(this, "<device>k__BackingField");
					r___0__device__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__device__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase <atlas>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RAtlasBase r___0__atlas__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RAtlasBase R__0__atlas__1__k__BackingField
		{
			get
			{
				if(r___0__atlas__1__k__BackingField == null)
				{
					r___0__atlas__1__k__BackingField = new(this, "<atlas>k__BackingField");
					r___0__atlas__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__atlas__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RVectorImageManager r___0__vectorImageManager__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RVectorImageManager R__0__vectorImageManager__1__k__BackingField
		{
			get
			{
				if(r___0__vectorImageManager__1__k__BackingField == null)
				{
					r___0__vectorImageManager__1__k__BackingField = new(this, "<vectorImageManager>k__BackingField");
					r___0__vectorImageManager__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__vectorImageManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] <vertsPool>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> r___0__vertsPool__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> R__0__vertsPool__1__k__BackingField
		{
			get
			{
				if(r___0__vertsPool__1__k__BackingField == null)
				{
					r___0__vertsPool__1__k__BackingField = new(this, "<vertsPool>k__BackingField");
					r___0__vertsPool__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__vertsPool__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] <indicesPool>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> r___0__indicesPool__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> R__0__indicesPool__1__k__BackingField
		{
			get
			{
				if(r___0__indicesPool__1__k__BackingField == null)
				{
					r___0__indicesPool__1__k__BackingField = new(this, "<indicesPool>k__BackingField");
					r___0__indicesPool__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__indicesPool__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.JobManager <jobManager>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RJobManager r___0__jobManager__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RJobManager R__0__jobManager__1__k__BackingField
		{
			get
			{
				if(r___0__jobManager__1__k__BackingField == null)
				{
					r___0__jobManager__1__k__BackingField = new(this, "<jobManager>k__BackingField");
					r___0__jobManager__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__jobManager__1__k__BackingField;
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
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter r___0__painter__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter R__0__painter__1__k__BackingField
		{
			get
			{
				if(r___0__painter__1__k__BackingField == null)
				{
					r___0__painter__1__k__BackingField = new(this, "<painter>k__BackingField");
					r___0__painter__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__painter__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <drawStats>k__BackingField
		/// </summary>
		protected RField r___0__drawStats__1__k__BackingField;
		public virtual RField R__0__drawStats__1__k__BackingField
		{
			get
			{
				if(r___0__drawStats__1__k__BackingField == null)
				{
					r___0__drawStats__1__k__BackingField = new(this, "<drawStats>k__BackingField");
					r___0__drawStats__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__drawStats__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <drawInCameras>k__BackingField
		/// </summary>
		protected RField r___0__drawInCameras__1__k__BackingField;
		public virtual RField R__0__drawInCameras__1__k__BackingField
		{
			get
			{
				if(r___0__drawInCameras__1__k__BackingField == null)
				{
					r___0__drawInCameras__1__k__BackingField = new(this, "<drawInCameras>k__BackingField");
					r___0__drawInCameras__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__drawInCameras__1__k__BackingField;
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
		protected RMethod r_Constructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager;
		public virtual RMethod RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager
		{
			get
			{
				if(r_Constructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager == null)
				{
					r_Constructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager = new(this, "Constructor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"),  ReflectionUtils.GetType("UnityEngine.UIElements.AtlasBase"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"));
					r_Constructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager.SetBelong(this.instance);
				}
				return r_Constructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager;
			}
		}

		/// <summary>
		/// Void Destructor()
		/// </summary>
		protected RMethod r_Destructor;
		public virtual RMethod RDestructor
		{
			get
			{
				if(r_Destructor == null)
				{
					r_Destructor = new(this, "Destructor", 0);
					r_Destructor.SetBelong(this.instance);
				}
				return r_Destructor;
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
		/// Void ProcessChanges()
		/// </summary>
		protected RMethod r_ProcessChanges;
		public virtual RMethod RProcessChanges
		{
			get
			{
				if(r_ProcessChanges == null)
				{
					r_ProcessChanges = new(this, "ProcessChanges", 0);
					r_ProcessChanges.SetBelong(this.instance);
				}
				return r_ProcessChanges;
			}
		}

		/// <summary>
		/// Void Render()
		/// </summary>
		protected RMethod r_Render;
		public virtual RMethod RRender
		{
			get
			{
				if(r_Render == null)
				{
					r_Render = new(this, "Render", 0);
					r_Render.SetBelong(this.instance);
				}
				return r_Render;
			}
		}

		/// <summary>
		/// Void UIEOnChildAdded(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UIEOnChildAdded_VisualElement;
		public virtual RMethod RUIEOnChildAdded_VisualElement
		{
			get
			{
				if(r_UIEOnChildAdded_VisualElement == null)
				{
					r_UIEOnChildAdded_VisualElement = new(this, "UIEOnChildAdded", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UIEOnChildAdded_VisualElement.SetBelong(this.instance);
				}
				return r_UIEOnChildAdded_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UIEOnChildrenReordered_VisualElement;
		public virtual RMethod RUIEOnChildrenReordered_VisualElement
		{
			get
			{
				if(r_UIEOnChildrenReordered_VisualElement == null)
				{
					r_UIEOnChildrenReordered_VisualElement = new(this, "UIEOnChildrenReordered", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UIEOnChildrenReordered_VisualElement.SetBelong(this.instance);
				}
				return r_UIEOnChildrenReordered_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UIEOnChildRemoving_VisualElement;
		public virtual RMethod RUIEOnChildRemoving_VisualElement
		{
			get
			{
				if(r_UIEOnChildRemoving_VisualElement == null)
				{
					r_UIEOnChildRemoving_VisualElement = new(this, "UIEOnChildRemoving", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UIEOnChildRemoving_VisualElement.SetBelong(this.instance);
				}
				return r_UIEOnChildRemoving_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UIEOnRenderHintsChanged_VisualElement;
		public virtual RMethod RUIEOnRenderHintsChanged_VisualElement
		{
			get
			{
				if(r_UIEOnRenderHintsChanged_VisualElement == null)
				{
					r_UIEOnRenderHintsChanged_VisualElement = new(this, "UIEOnRenderHintsChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UIEOnRenderHintsChanged_VisualElement.SetBelong(this.instance);
				}
				return r_UIEOnRenderHintsChanged_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_UIEOnClippingChanged_VisualElement_Boolean;
		public virtual RMethod RUIEOnClippingChanged_VisualElement_Boolean
		{
			get
			{
				if(r_UIEOnClippingChanged_VisualElement_Boolean == null)
				{
					r_UIEOnClippingChanged_VisualElement_Boolean = new(this, "UIEOnClippingChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_UIEOnClippingChanged_VisualElement_Boolean.SetBelong(this.instance);
				}
				return r_UIEOnClippingChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_UIEOnOpacityChanged_VisualElement_Boolean;
		public virtual RMethod RUIEOnOpacityChanged_VisualElement_Boolean
		{
			get
			{
				if(r_UIEOnOpacityChanged_VisualElement_Boolean == null)
				{
					r_UIEOnOpacityChanged_VisualElement_Boolean = new(this, "UIEOnOpacityChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_UIEOnOpacityChanged_VisualElement_Boolean.SetBelong(this.instance);
				}
				return r_UIEOnOpacityChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnColorChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UIEOnColorChanged_VisualElement;
		public virtual RMethod RUIEOnColorChanged_VisualElement
		{
			get
			{
				if(r_UIEOnColorChanged_VisualElement == null)
				{
					r_UIEOnColorChanged_VisualElement = new(this, "UIEOnColorChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UIEOnColorChanged_VisualElement.SetBelong(this.instance);
				}
				return r_UIEOnColorChanged_VisualElement;
			}
		}

		/// <summary>
		/// Void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement, Boolean, Boolean)
		/// </summary>
		protected RMethod r_UIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean;
		public virtual RMethod RUIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean
		{
			get
			{
				if(r_UIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean == null)
				{
					r_UIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean = new(this, "UIEOnTransformOrSizeChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean), typeof(System.Boolean));
					r_UIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_UIEOnTransformOrSizeChanged_VisualElement_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_UIEOnVisualsChanged_VisualElement_Boolean;
		public virtual RMethod RUIEOnVisualsChanged_VisualElement_Boolean
		{
			get
			{
				if(r_UIEOnVisualsChanged_VisualElement_Boolean == null)
				{
					r_UIEOnVisualsChanged_VisualElement_Boolean = new(this, "UIEOnVisualsChanged", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
					r_UIEOnVisualsChanged_VisualElement_Boolean.SetBelong(this.instance);
				}
				return r_UIEOnVisualsChanged_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UIEOnOpacityIdChanged(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UIEOnOpacityIdChanged_VisualElement;
		public virtual RMethod RUIEOnOpacityIdChanged_VisualElement
		{
			get
			{
				if(r_UIEOnOpacityIdChanged_VisualElement == null)
				{
					r_UIEOnOpacityIdChanged_VisualElement = new(this, "UIEOnOpacityIdChanged", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UIEOnOpacityIdChanged_VisualElement.SetBelong(this.instance);
				}
				return r_UIEOnOpacityIdChanged_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetStandardMaterial()
		/// </summary>
		protected RMethod r_GetStandardMaterial;
		public virtual RMethod RGetStandardMaterial
		{
			get
			{
				if(r_GetStandardMaterial == null)
				{
					r_GetStandardMaterial = new(this, "GetStandardMaterial", 0);
					r_GetStandardMaterial.SetBelong(this.instance);
				}
				return r_GetStandardMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material GetStandardWorldSpaceMaterial()
		/// </summary>
		protected RMethod r_GetStandardWorldSpaceMaterial;
		public virtual RMethod RGetStandardWorldSpaceMaterial
		{
			get
			{
				if(r_GetStandardWorldSpaceMaterial == null)
				{
					r_GetStandardWorldSpaceMaterial = new(this, "GetStandardWorldSpaceMaterial", 0);
					r_GetStandardWorldSpaceMaterial.SetBelong(this.instance);
				}
				return r_GetStandardWorldSpaceMaterial;
			}
		}

		/// <summary>
		/// Void EnsureFitsDepth(Int32)
		/// </summary>
		protected RMethod r_EnsureFitsDepth_Int32;
		public virtual RMethod REnsureFitsDepth_Int32
		{
			get
			{
				if(r_EnsureFitsDepth_Int32 == null)
				{
					r_EnsureFitsDepth_Int32 = new(this, "EnsureFitsDepth", 0, typeof(System.Int32));
					r_EnsureFitsDepth_Int32.SetBelong(this.instance);
				}
				return r_EnsureFitsDepth_Int32;
			}
		}

		/// <summary>
		/// Void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_ChildWillBeRemoved_VisualElement;
		public virtual RMethod RChildWillBeRemoved_VisualElement
		{
			get
			{
				if(r_ChildWillBeRemoved_VisualElement == null)
				{
					r_ChildWillBeRemoved_VisualElement = new(this, "ChildWillBeRemoved", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_ChildWillBeRemoved_VisualElement.SetBelong(this.instance);
				}
				return r_ChildWillBeRemoved_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand()
		/// </summary>
		protected RMethod r_AllocCommand;
		public virtual RMethod RAllocCommand
		{
			get
			{
				if(r_AllocCommand == null)
				{
					r_AllocCommand = new(this, "AllocCommand", 0);
					r_AllocCommand.SetBelong(this.instance);
				}
				return r_AllocCommand;
			}
		}

		/// <summary>
		/// Void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_FreeCommand_RenderChainCommand;
		public virtual RMethod RFreeCommand_RenderChainCommand
		{
			get
			{
				if(r_FreeCommand_RenderChainCommand == null)
				{
					r_FreeCommand_RenderChainCommand = new(this, "FreeCommand", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_FreeCommand_RenderChainCommand.SetBelong(this.instance);
				}
				return r_FreeCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_OnRenderCommandAdded_RenderChainCommand;
		public virtual RMethod ROnRenderCommandAdded_RenderChainCommand
		{
			get
			{
				if(r_OnRenderCommandAdded_RenderChainCommand == null)
				{
					r_OnRenderCommandAdded_RenderChainCommand = new(this, "OnRenderCommandAdded", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_OnRenderCommandAdded_RenderChainCommand.SetBelong(this.instance);
				}
				return r_OnRenderCommandAdded_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand, UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_OnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand;
		public virtual RMethod ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand
		{
			get
			{
				if(r_OnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand == null)
				{
					r_OnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand = new(this, "OnRenderCommandsRemoved", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_OnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand.SetBelong(this.instance);
				}
				return r_OnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// RenderNodeData AccessRenderNodeData(IntPtr)
		/// </summary>
		protected static RMethod r_AccessRenderNodeData_IntPtr;
		public static RMethod RAccessRenderNodeData_IntPtr
		{
			get
			{
				if(r_AccessRenderNodeData_IntPtr == null)
				{
					r_AccessRenderNodeData_IntPtr = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "AccessRenderNodeData", 0, typeof(System.IntPtr));
					r_AccessRenderNodeData_IntPtr.SetBelong(null);
				}
				return r_AccessRenderNodeData_IntPtr;
			}
		}

		/// <summary>
		/// Void OnRenderNodeExecute(IntPtr)
		/// </summary>
		protected static RMethod r_OnRenderNodeExecute_IntPtr;
		public static RMethod ROnRenderNodeExecute_IntPtr
		{
			get
			{
				if(r_OnRenderNodeExecute_IntPtr == null)
				{
					r_OnRenderNodeExecute_IntPtr = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRenderNodeExecute", 0, typeof(System.IntPtr));
					r_OnRenderNodeExecute_IntPtr.SetBelong(null);
				}
				return r_OnRenderNodeExecute_IntPtr;
			}
		}

		/// <summary>
		/// Void OnRegisterIntermediateRenderers(UnityEngine.Camera)
		/// </summary>
		protected static RMethod r_OnRegisterIntermediateRenderers_Camera;
		public static RMethod ROnRegisterIntermediateRenderers_Camera
		{
			get
			{
				if(r_OnRegisterIntermediateRenderers_Camera == null)
				{
					r_OnRegisterIntermediateRenderers_Camera = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRegisterIntermediateRenderers", 0, typeof(UnityEngine.Camera));
					r_OnRegisterIntermediateRenderers_Camera.SetBelong(null);
				}
				return r_OnRegisterIntermediateRenderers_Camera;
			}
		}

		/// <summary>
		/// Void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel, UnityEngine.UIElements.UIR.RenderChain, RenderNodeData ByRef, UnityEngine.Camera, Int32)
		/// </summary>
		protected static RMethod r_OnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32;
		public static RMethod ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32
		{
			get
			{
				if(r_OnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32 == null)
				{
					r_OnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "OnRegisterIntermediateRendererMat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain+RenderNodeData").MakeByRefType(), typeof(UnityEngine.Camera), typeof(System.Int32));
					r_OnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32.SetBelong(null);
				}
				return r_OnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32;
			}
		}

		/// <summary>
		/// Void RepaintTexturedElements()
		/// </summary>
		protected RMethod r_RepaintTexturedElements;
		public virtual RMethod RRepaintTexturedElements
		{
			get
			{
				if(r_RepaintTexturedElements == null)
				{
					r_RepaintTexturedElements = new(this, "RepaintTexturedElements", 0);
					r_RepaintTexturedElements.SetBelong(this.instance);
				}
				return r_RepaintTexturedElements;
			}
		}

		/// <summary>
		/// Void AppendTexture(UnityEngine.UIElements.VisualElement, UnityEngine.Texture, UnityEngine.UIElements.TextureId, Boolean)
		/// </summary>
		protected RMethod r_AppendTexture_VisualElement_Texture_TextureId_Boolean;
		public virtual RMethod RAppendTexture_VisualElement_Texture_TextureId_Boolean
		{
			get
			{
				if(r_AppendTexture_VisualElement_Texture_TextureId_Boolean == null)
				{
					r_AppendTexture_VisualElement_Texture_TextureId_Boolean = new(this, "AppendTexture", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Boolean));
					r_AppendTexture_VisualElement_Texture_TextureId_Boolean.SetBelong(this.instance);
				}
				return r_AppendTexture_VisualElement_Texture_TextureId_Boolean;
			}
		}

		/// <summary>
		/// Void ResetTextures(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_ResetTextures_VisualElement;
		public virtual RMethod RResetTextures_VisualElement
		{
			get
			{
				if(r_ResetTextures_VisualElement == null)
				{
					r_ResetTextures_VisualElement = new(this, "ResetTextures", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_ResetTextures_VisualElement.SetBelong(this.instance);
				}
				return r_ResetTextures_VisualElement;
			}
		}

		/// <summary>
		/// Void DrawStats()
		/// </summary>
		protected RMethod r_DrawStats;
		public virtual RMethod RDrawStats
		{
			get
			{
				if(r_DrawStats == null)
				{
					r_DrawStats = new(this, "DrawStats", 0);
					r_DrawStats.SetBelong(this.instance);
				}
				return r_DrawStats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_GetFirstElementInPanel_VisualElement;
		public static RMethod RGetFirstElementInPanel_VisualElement
		{
			get
			{
				if(r_GetFirstElementInPanel_VisualElement == null)
				{
					r_GetFirstElementInPanel_VisualElement = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"), "GetFirstElementInPanel", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_GetFirstElementInPanel_VisualElement.SetBelong(null);
				}
				return r_GetFirstElementInPanel_VisualElement;
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

        public virtual void Constructor(RUnityEngine.RUIElements.RBaseVisualElementPanel  @panelObj, RUnityEngine.RUIElements.RUIR.RUIRenderDevice  @deviceObj, RUnityEngine.RUIElements.RAtlasBase  @atlas, RUnityEngine.RUIElements.RUIR.RVectorImageManager  @vectorImageMan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panelObj.Value, @deviceObj.Value, @atlas.Value, @vectorImageMan.Value};
            var ___result = RConstructor_BaseVisualElementPanel_UIRenderDevice_AtlasBase_VectorImageManager.Invoke(___genericsType, ___parameters);

            
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


        public virtual void FreeCommand(RUnityEngine.RUIElements.RUIR.RRenderChainCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd.Value};
            var ___result = RFreeCommand_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRenderCommandAdded(RUnityEngine.RUIElements.RUIR.RRenderChainCommand  @command)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@command.Value};
            var ___result = ROnRenderCommandAdded_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRenderCommandsRemoved(RUnityEngine.RUIElements.RUIR.RRenderChainCommand  @firstCommand, RUnityEngine.RUIElements.RUIR.RRenderChainCommand  @lastCommand)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstCommand.Value, @lastCommand.Value};
            var ___result = ROnRenderCommandsRemoved_RenderChainCommand_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
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


        public static void OnRegisterIntermediateRendererMat(RUnityEngine.RUIElements.RBaseRuntimePanel  @rtp, RUnityEngine.RUIElements.RUIR.RRenderChain  @renderChain, ref RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData  @rnd, UnityEngine.Camera  @camera, System.Int32  @sameDistanceSortPriority)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rtp.Value, @renderChain.Value, @rnd.Value, @camera, @sameDistanceSortPriority};
            var ___result = ROnRegisterIntermediateRendererMat_BaseRuntimePanel_RenderChain_Ref_RenderNodeData_Camera_Int32.Invoke(___genericsType, ___parameters);
			@rnd = new RUnityEngine.RUIElements.RUIR.RRenderChain.RRenderNodeData(___parameters[2]);

            
        }


        public virtual void RepaintTexturedElements()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaintTexturedElements.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AppendTexture(UnityEngine.UIElements.VisualElement  @ve, UnityEngine.Texture  @src, RUnityEngine.RUIElements.RTextureId  @id, System.Boolean  @isAtlas)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @src, @id.Value, @isAtlas};
            var ___result = RAppendTexture_VisualElement_Texture_TextureId_Boolean.Invoke(___genericsType, ___parameters);

            
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
